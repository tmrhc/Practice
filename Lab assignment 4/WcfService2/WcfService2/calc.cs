using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface calc
    {

        [OperationContract]
    
    [WebInvoke(Method = "GET", ResponseFormat= WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Addition/{a}/{b}" )]

        String Addition(string a,string b); 

        [OperationContract]
     
    [WebInvoke(Method = "GET", ResponseFormat= WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Subtraction/{a}/{b}")]

        String Subtraction(string a, string b);

        [OperationContract]
     
    [WebInvoke(Method = "GET", ResponseFormat= WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Multiplication/{a}/{b}")]

        String Multiplication(string a, string b);
        
        [OperationContract]
     
    [WebInvoke(Method = "GET", ResponseFormat= WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Division/{a}/{b}")]

        String Division(string a, string b);

        // TODO: Add your service operations here
    }
}
