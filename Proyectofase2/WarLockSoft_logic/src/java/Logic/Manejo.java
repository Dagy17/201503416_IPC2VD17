package Logic;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.*;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author dylan
 */
public class Manejo {

    private Conexion C;
    private Datos D;
    private Consulta Cns;
   
    private String cadena;
    private String texto;
    private long dpi;
    private int entero;

    public Manejo() {
        C = new Conexion();
        D = new Datos();
        Cns = new Consulta(getC());
      
    }

    public void prueba_de_ingreso() {
        Scanner Sc = new Scanner(System.in);
//        System.out.println("ingrese nombre");
//        setCadena(Sc.nextLine());
//        System.out.println("ingrese dpi");
//        setDpi(Sc.nextLong());
        //getD().Crear_usuario("awus","124526262","Estandar");

    }
//
    public static void main(String[] args) {
        Manejo M = new Manejo();
        System.out.println("id es: "+M.getCns().Usuario_Nickname("user10","1234"));
    }
    
    
    
    //------------------Get and set here-----------
    
    
    
    
    /**
     * @return the C
     */
    public Conexion getC() {
        return C;
    }

    /**
     * @param C the C to set
     */
    public void setC(Conexion C) {
        this.C = C;
    }

    /**
     * @return the D
     */
    public Datos getD() {
        return D;
    }

    /**
     * @param D the D to set
     */
    public void setD(Datos D) {
        this.D = D;
    }

    /**
     * @return the Cns
     */
    public Consulta getCns() {
        return Cns;
    }

    /**
     * @param Cns the Cns to set
     */
    public void setCns(Consulta Cns) {
        this.Cns = Cns;
    }

    /**
     * @return the Srv
     */

    /**
     * @return the entero
     */
    public int getEntero() {
        return entero;
    }

    /**
     * @param entero the entero to set
     */
    public void setEntero(int entero) {
        this.entero = entero;
    }

    /**
     * @return the cadena
     */
    public String getCadena() {
        return cadena;
    }

    /**
     * @param cadena the cadena to set
     */
    public void setCadena(String cadena) {
        this.cadena = cadena;
    }

    /**
     * @return the texto
     */
    public String getTexto() {
        return texto;
    }

    /**
     * @param texto the texto to set
     */
    public void setTexto(String texto) {
        this.texto = texto;
    }

    /**
     * @return the dpi
     */
    public long getDpi() {
        return dpi;
    }

    /**
     * @param dpi the dpi to set
     */
    public void setDpi(long dpi) {
        this.dpi = dpi;
    }
    
}
