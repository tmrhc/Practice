﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/", Description ="A simple calculator service", Name = "Calculator service" )]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]

    public int Addition(int a, int b)
    {
        return a + b;
    }
    [WebMethod]
    public int Subtraction(int a, int b)
    {
        return a - b;
    }
    [WebMethod]
    public int Multiplication(int a, int b)
    {
        return a * b;
    }
    [WebMethod]
    public int Division(int a, int b)
    {
        return a / b;
    }

    
}
