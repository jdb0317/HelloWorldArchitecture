using HelloWorld.Domain;
using HelloWorld.Domain.Entity;
using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var destinationString = 
                ConfigurationManager.AppSettings[Constants.OutputDestinationKey].ToString();
            var response = GetApiResponse();

            switch (destinationString)
            {
                case "console":
                    Console.WriteLine(response.MessageValue);
                    Console.WriteLine("Press enter to exit");
                    Console.ReadLine();
                    break;
                case "file":
                    var fileName = ConfigurationManager.AppSettings[Constants.TextFileNameKey].ToString();
                    File.AppendAllText(fileName, $"{response.MessageValue}{Environment.NewLine}");
                    break;
                case "database":
                    new DbWriter().Push(response.MessageValue);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Call Web API and return message object
        /// </summary>
        /// <returns></returns>
        private static IReturnMessage GetApiResponse()
        {
            IReturnMessage message;
            var requestweb = WebRequest.Create(
                ConfigurationManager.AppSettings[Constants.WebApiEndpointKey].ToString());

            using (var response = requestweb.GetResponse())
            {
                var data = response.GetResponseStream();
                using (var reader = new StreamReader(data, Encoding.ASCII))
                {
                    var responseObject = reader.ReadToEnd();
                    message = new JavaScriptSerializer().Deserialize<ReturnMessage>(responseObject);
                }
            }

            return message;
        }
    }
}
