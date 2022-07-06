using System.Net;
using System.Text.Json;

namespace Ejercicio1
{

    class Program
    {
        private const string JsonType = "application/json";
        
        static void Main(string[] args)
        {
            List<Civilizacion> civilizaciones;
            
            var url = "";
            var request = (HttpWebRequest) WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = JsonType;
            request.Accept = JsonType;

            try{
                using(WebResponse respuesta = request.GetResponse()){
                    using(Stream streamReader = respuesta.GetResponseStream()){
                        if(streamReader != null){
                            using(StreamReader objReader = new StreamReader(streamReader)){
                                string responseBody = objReader.ReadToEnd();
                                civilizaciones = JsonSerializer.Deserialize<List<Civilizacion>>(responseBody);

                                foreach(Civilizacion civilizacion in civilizaciones){
                                    Console.WriteLine(civilizacion.ToString());
                                }
                            }
                        }
                        else{
                            Console.WriteLine("No se obtuvo respuesta");
                        }
                    }
                }            
            }catch(WebException e){
                Console.WriteLine(e.ToString());
            }
        }
    }
}
