using System.Collections.Generic;
using static System.IO.Path;

namespace PrivEdit.Lib
{
    class global
    {
        public static List<PrivLib.edSci> tabList = new List<PrivLib.edSci>();
        public static PrivEditForm MainEditor = new PrivEditForm();
        public static int IDCounter = 0;
        public static string lang_pref = ucfg.Default.language;
        public static string path = GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static string LanguageFile = path + @"\Languages\" + lang_pref + ".json";
    }
}
