using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 5; i++)
            //{

            //    HttpClient client = new HttpClient();
                
            //    //kanyeRest endpoint
            //    string kanyeRestURL = "https://api.kanye.rest";
                
            //    //GET Request
            //    string kanyeRestResponse = client.GetStringAsync(kanyeRestURL).Result;
                
            //    //Parse Object
            //    var kanyeObject = JObject.Parse(kanyeRestResponse);


            //    //Write Kanye Quote to the console
            //    Console.WriteLine($"Kanye West: {kanyeObject["quote"]}");

            //    //ronUrl endpoint
            //    string ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            //    //GET Request
            //    var ronResponse = client.GetStringAsync(ronUrl).Result;

            //    //Parse Object
            //    var ronQuote = JArray.Parse(ronResponse);

            //    //Write Ron Quote to the console
            //    Console.WriteLine($"Ron Swanson: {ronQuote[0]}");
            //    Console.WriteLine();
            //    }
            //^Uncomment Above For Exercise 1
            ///////
            ///

            //OpenWeatherAPI
            Console.WriteLine("OpenWeatherAPI");
            
                    var client = new HttpClient();

                    var apiKey = "3b6e6673a5b35f0d21b3f0750f4c98eb";
                    
                    
                    Console.WriteLine("Enter in City choice:");
                    var cityName =Console.ReadLine();

                    var weatherMapURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
                    var weatherResponse = client.GetStringAsync(weatherMapURL).Result;
                    var weatherObject = JObject.Parse(weatherResponse);

            //Console.WriteLine("Weather Object");
            //Console.WriteLine(weatherObject);
            //Console.WriteLine();

            Console.WriteLine($"{weatherObject["main"]["temp"]} degrees (F) in {cityName}");

            }
        }
    }

