using System;
using System.Net;
using System.Text.Json;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Root unidades;
            
            var url = "https://age-of-empires-2-api.herokuapp.com/api/v1/units"; //Unidades
            var request = (HttpWebRequest) WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            
            try{
                using(WebResponse respuesta = request.GetResponse()){
                    using(Stream streamReader = respuesta.GetResponseStream()){
                        if(streamReader != null){
                            using(StreamReader objReader = new StreamReader(streamReader)){
                                string responseBody = objReader.ReadToEnd();
                                civilizaciones = JsonSerializer.Deserialize<Root>(responseBody);

                                foreach(Unidad unidad in unidades.Units){
                                    Console.WriteLine(unidad.Name);
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
