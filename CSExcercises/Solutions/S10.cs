using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSExcercises.Solutions
{
    public class S10
    {

        /*
         * Access a text file stored in ‘Environment’ folder 
         * containing  key values pairs of the environment 
         * details like URL, username password , etc 
         * store those values in a Dictionary object and iterate them.
         */

        public static void DemoReadDataKeyValuesFromFile()
        {
            // use relative path
            //Getting executing assembly path
            string AssemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Console.WriteLine("Assembly Path: " + AssemblyPath);

            string filename = AssemblyPath + "/../../Environment/UAT.txt";
            Dictionary<string, string> DicEnvData = LoadData(filename);

            // Iterate through the dictionary using foreach
            foreach (var kvp in DicEnvData)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

        }

        public static Dictionary<string, string> LoadData(string fname)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            var report = File.ReadAllLines(fname);
            foreach (string line in report)
            {
                string[] keyvalue = line.Split('=');
                if (keyvalue.Length == 2)
                {
                    result.Add(keyvalue[0].Trim(), keyvalue[1].Trim());
                }
            }
            return result;

        }

    }
}
