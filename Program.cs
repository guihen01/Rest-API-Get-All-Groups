using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Get_All_Jira_Groups
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Execute (Jira Server platform) REST API");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine(" REf : Goto : https://docs.atlassian.com/software/jira/docs/api/REST/8.13.2/");
            Console.WriteLine("----------------------------------------------------------------------------");
            
            string url,url1;
            Console.WriteLine(" pathname complet du serveur Jira (URL) with port number ? ");
            Console.WriteLine("as : http://localhost:8080");
            Console.WriteLine("----------------------------------------------------------------------------");
            
            url1 = Console.ReadLine();
            url = url1 +"/rest/api/2/groups/picker";
            Console.WriteLine(" URIs for Jira's REST API cchoosed to pick groups is : {0} ",url);
            Console.WriteLine("------------------------------------------------------------------------");

            using var client = new HttpClient();

            string user;
            Console.WriteLine("user account in Jira for authentication");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" Jira username  ? ");
            user = Console.ReadLine();

            string password;
            Console.WriteLine(" Jira password  ? ");
            password = Console.ReadLine();

            
            var base64String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{user}:{password}"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64String);

            var response = await client.GetAsync(url);
            Console.WriteLine(response.StatusCode);

            // It would be better to make sure this request actually made it through

            string result = await response.Content.ReadAsStringAsync();

            //close out the client
            client.Dispose();

            //wrtite to Console sous forme groupée
            //---------------------------------------------------------------------------
            Console.WriteLine(result);
            Console.WriteLine("----------------------------------------------------------");

            //wrtite to Console sous forme d'objet
            //---------------------------------------------------------------------------
            JObject o = JObject.Parse(result);
            Console.WriteLine(o.ToString());
            Console.WriteLine("----------------------------------------------------------");

            //var items = o.SelectTokens("$.[?(@.Country=='India')]");
            //foreach (var item in items)
            //   Console.WriteLine(item);

            //write the result sous forme groupée in a file 
            // write the result in a json formated file
            //----------------------------------------------------------------------------
            //ecriture dans un fichier des données au format Json
            // Get the current directory.

            string dir = Directory.GetCurrentDirectory();
            string path = dir + "/List-groups.json";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(result.ToString());
                tw.Close();
            }
            Console.WriteLine("json formated file : List-groups.json created ");
            Console.WriteLine("----------------------------------------------------------");

            //write the result sous forme d'objet in a file 
            // write the result in a text formated file
            //----------------------------------------------------------------------------
            //ecriture dans un fichier des données au format string

            string path1 = dir + "/List-groups.txt";
            if (File.Exists(path1))
            {
                File.Delete(path1);
            }
            using (var tw1 = new StreamWriter(path1, true))
            {
                tw1.WriteLine(o.ToString());
                tw1.Close();
            }
            Console.WriteLine("text formated file : List-groups.txt created ");
            Console.WriteLine("----------------------------------------------------------");

        }
    }
}

