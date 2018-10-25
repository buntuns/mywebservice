using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Web;
using System.Web.Services;
using System.Globalization;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    public class AirData
    {
        public string room_number;
        public string time_record;
        public double temperature;
        public double humidity;
    }

    [WebMethod] // use this to declaer method on web service.
    public string HelloWorld()
    {
        return "Hello World";
    } //edit this function to modify web service
    [WebMethod]
    public string Add_data(string room, string temp , string humidity, string time )
    {
        XElement xml = XElement.Load(AppDomain.CurrentDomain.BaseDirectory + "/air_data.xml");
        xml.Add(new XElement("Airdata",
            new XElement("Room", room),
            new XElement("Temperature" , temp),
            new XElement("Humidity", humidity),
            new XElement("Time", time)
         ));
        xml.Save(AppDomain.CurrentDomain.BaseDirectory + "/air_data.xml"); 
        return room+" "+temp + " " + humidity + " " + time;
    }
    [WebMethod]
    public AirData[] Show_data()
    {
        XElement xml = XElement.Load(AppDomain.CurrentDomain.BaseDirectory + "/air_data.xml");
        IEnumerable<XElement> show_all =
           from el in xml.Elements()
           select el;

        AirData[] test = new AirData[show_all.Count()];

        int i = 0;
        foreach (XElement el in show_all)
        {
            test[i] = new AirData()
            {
                room_number = (string)el.Element("Room"),
                time_record = (string)el.Element("Time"),
                temperature = (double)el.Element("Temperature"),
                humidity = (double)el.Element("Humidity")
            };
            i++;
        }
        return test;
    }
}
