package web_services;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


//import Logica.Manejo;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import Logic.Manejo;
//import java.sql.SQLException;
/**
 *
 * @author dylan
 */
@WebService(serviceName = "Agregar_dato")
public class Agregar_dato {

    /**
     * This is a sample web service operation
     * @param user
     * @param dpi
     * @param tipo
     * @return 
     */
    @WebMethod(operationName = "Agregar_Usuario")
    public boolean Agregar_Usuario(@WebParam(name = "nickname") String nickname, @WebParam(name = "nombre") String nombre
            ,@WebParam( name = "correo") String correo,@WebParam( name = "password") String password){
          Manejo M=new Manejo();
        if (M.getD().Crear_usuario(nickname,nombre,correo,password)) {
            System.out.println("Exito");
            return true;
        }
        else{
            System.out.println("algo salio mal");
            return false;
        }
    
    }
     @WebMethod(operationName = "Agregar_Vehi")
    public boolean Agregar_Vehiculo(@WebParam(name = "username") String username,@WebParam( name = "placa") String placa
            ,@WebParam( name = "modelo") String modelo,@WebParam( name = "marca") String marca,@WebParam( name = "capacidad") 
                    String capacidad,@WebParam( name = "dpii") String dpii){
        Manejo M=new Manejo();
        if (M.getD().Crear_vehiculo(username, placa, modelo, marca, capacidad,dpii)) {
            System.out.println("Exito");
            return true;
        }
        else{
            System.out.println("algo salio mal");
            return false;
        }
    
    }
}
