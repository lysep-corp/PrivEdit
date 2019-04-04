using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace PrivEdit.Parsers.JSON
{
    class parser
    {
        public static string ParseIt(string FilePath, string Part, string ItemName)
        {
            try
            {
                string output = "";
                JObject json = JObject.Parse(File.ReadAllText(FilePath));
                output = json[Part][ItemName].ToString();
                return output;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("" + ex);
                return "";
            }
        }
    }
}
