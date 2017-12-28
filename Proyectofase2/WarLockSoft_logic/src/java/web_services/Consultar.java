/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package web_services;

import Logic.Manejo;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author dylan
 */
@WebService(serviceName = "Consultar")
public class Consultar {

    /**
     * This is a sample web service operation
     */
   @WebMethod(operationName = "Validar_Login")
    public int Validar_Login(@WebParam(name = "nickname") String nickname, @WebParam(name = "password") String password){
          Manejo M=new Manejo();
        if (M.getCns().Usuario_Nickname(nickname,password)!=0) {
           
            return M.getCns().Usuario_Nickname(nickname,password);
        }
        else{
           
            return 0;
        }
   }
}
