using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace WebServiceTest
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public PO XmlWebTest()
        {
            PO p=new PO();
            p.PoNumber = "Jason";
            p.InDate = DateTime.Now;

            return p;
        }
    }

    public class PO
    {
        public string PoNumber;

        public DateTime InDate;
    }
}
