package Logic;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;
/**
 *
 * @author dylan
 */
public class Conexion {
    
  public static final String DRIVER= "org.mariadb.jdbc.Driver";
  public static final String USUARIO="localhost";
  public static final String PORT= "3306";
  public static final String PASSWORD="pass17287db";
  public static final String DB="warlockdb_ipc2vd17";
  public String url="jdbc:mariadb://localhost:3306/"+DB;
  public Connection conexionp;

  public Connection getDBConexion(){
    conexionp=null;
      try {
          Class.forName(DRIVER);
          conexionp=(Connection)DriverManager.getConnection(url,"root",PASSWORD);
          System.out.println("Conexion establecida");
      } catch (ClassNotFoundException |SQLException ex) {
          System.out.println("No se conecto: "+ex);
      }
      return conexionp;
} 
    public void desconectar(){
      try {
          conexionp.close();
          System.out.println("Conexion terminada");
      } catch (SQLException ex) {
          System.out.println("no se pudo desconectar: "+ex);
            
      }
    
}



  
}



