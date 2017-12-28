package Logic;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import Logic.Manejo;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;
/**
 *
 * @author dylan
 */
public class Datos {
    Conexion C;
    public Datos(Conexion c) {
          this.C=c;
    }
    
    public Datos(){
        C=new Conexion();
    }
    
    public boolean Crear_usuario(String nickname,String nombre,String correo,String password){
    
        try{
            String insert="INSERT INTO usuario(nickname,nombre,correo,password) VALUES(?,?,?,?)";
            PreparedStatement datosaingresar =C.getDBConexion().prepareStatement(insert);
            datosaingresar.setString(1, nickname);
            datosaingresar.setString(2, nombre);
            datosaingresar.setString(3, correo);
            datosaingresar.setString(4, password);
            datosaingresar.execute();
            datosaingresar.close();
            datosaingresar=null;
            C.desconectar();
            System.out.println("Exito!");
             return true;
        }
        catch(SQLException ex){
            System.out.println("Datos no ingresados: "+ex);
            return false;
        }
}
            
    public boolean Crear_vehiculo(String nombre_usuario,String placa_vehiculo,String modelo_vehiculo,
          String marca_vehiculo,String capacida,String dpi){
        int capacidad=Integer.parseInt(capacida);
        Statement declaracion;
        try {
            declaracion = C.getDBConexion().createStatement();
             ResultSet result= declaracion.executeQuery("SELECT u.id_usuario\n" +
"FROM usuario u\n" +
"WHERE u.nombre_usuario="+"'"+nombre_usuario+"'\n" +
"and u.dpi_usuario="+dpi+"");
             result.first();
             int id_user=Integer.parseInt(result.getString("id_usuario"));
             
             System.out.println(""+id_user);
             C.desconectar();
            String insert="INSERT INTO vehiculo(id_usuario,placa_vehiculo,modelo_vehiculo,marca_vehiculo,capacidad) VALUES(?,?,?,?,?)";
            PreparedStatement inser =C.getDBConexion().prepareStatement(insert);
            inser.setInt(1, id_user);
            inser.setString(2, placa_vehiculo);
            inser.setString(3, modelo_vehiculo);
            inser.setString(4, marca_vehiculo);           
            inser.setInt(5, capacidad);
            inser.execute();
            inser.close();
            inser=null;
            C.desconectar();
            System.out.println("Exito!");
             return true;
        }
        catch(SQLException ex){
            System.out.println("Datos no ingresados: "+ex);
            return false;
        }
}
   
    public boolean Crear_viaje(Manejo M){
        try{
            String insert="INSERT INTO detalle_servi(id_servicio,id_usuario,id_vehiculo,ubicacion,destino) VALUES(?,?,?,?,?)";
            PreparedStatement inser =C.getDBConexion().prepareStatement(insert);
            inser.setInt(1, M.getEntero());
            inser.setInt(2, M.getEntero());
            inser.setInt(3, M.getEntero());
            inser.setString(4, M.getCadena());
            inser.setString(5, M.getCadena());
            inser.execute();
            inser.close();
            inser=null;
            C.desconectar();
            System.out.println("Exito!");
             return true;
        }
        catch(SQLException ex){
            System.out.println("Datos no ingresados: "+ex);
            return false;
        }
}
}
