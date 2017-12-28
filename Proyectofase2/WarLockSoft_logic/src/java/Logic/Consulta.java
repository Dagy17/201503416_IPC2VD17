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
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
/**
 *
 * @author dylan
 */
public class Consulta {
    Conexion C;
    public Consulta(Conexion c) {
          this.C=c;
    }
    
public int Usuario_Nickname(String nickname,String password){
    ArrayList<String> lista=new ArrayList<>();
    int idtemp=0;
 try {
     Statement declaracion =C.getDBConexion().createStatement();
     ResultSet result= declaracion.executeQuery("select id_usuario from usuario where nickname = '"+
             nickname+"' and password = "+password+"");
     if (result.next()) {
         idtemp=Integer.parseInt(result.getNString(1).toString());
         System.out.println(" "+idtemp);
      return idtemp;
     }else idtemp=0;
    
 }catch(SQLException ex){
     System.out.println("No se pudo realizar consulta: "+ex);
     return 0;
 }  
return idtemp; 
}

}
