/**/using System;
/**/using System.Collections.Generic;
/**/using System.Linq;
/**/using System.Text;
/**/using System.Threading.Tasks;
/**/using System.Windows.Forms;
/**/using System.Drawing;
/**/using System.Diagnostics;
/**/using System.IO;
/**/using System.Security.Cryptography;
/**/namespace PrivEdit
/**/{
/**/    class PrivLib
/**/    {
/**/        public class edSci : ScintillaNET.Scintilla
/**/        {
/**/            public int TabID;
/**/            public int MaxLineNumberCharLength;
/**/            string Path_ = null;
/**/            string Filename_ = null;
/**/            bool ChangedPoint_;
/**/            public bool ChangedPoint
/**/            {
/**/                get
/**/                {
/**/                    return ChangedPoint_; 
/**/                }
/**/            }
/**/            public string TextMD5
/**/            {
/**/                get{
/**/                    return md5_hexdigest(this.Text);
/**/                }
/**/            }
/**/            public void checkChanged()
/**/            {
/**/                if(this.Path_ != null)
/**/                {
/**/                    if(this.CanUndo)
/**/                    {
/**/                        ChangedPoint_ = true;
/**/                    }else
/**/                    {
/**/                        ChangedPoint_ = false;
/**/                    }
/**/                }
/**/                else
/**/                {
/**/                    this.ChangedPoint_ = false;
/**/                }
/**/            }
/**/            public string Filename {
/**/                get
/**/                {
/**/                        if(Path_ != null)
/**/                        {
/**/                            return splitPath(Path_);
/**/                        }else
/**/                        {
/**/                            return null;
/**/                        }
/**/                }
/**/            }
/**/            public string Path
/**/            {
/**/                get
/**/                {
/**/                    return Path_;
/**/                }
/**/                set
/**/                {
/**/                    Path_ = value;
/**/                    this.setVisibleLanguage((ScintillaNET.Lexer)getLanguage(Filename_));
/**/                }
/**/            }
/**/            public void setVisibleLanguage(ScintillaNET.Lexer Language)
/**/            {
/**/                
/**/                if (ScintillaNET.Lexer.Html == Language)
/**/                {
/**/                    this.Lexer = ScintillaNET.Lexer.Html;
/**/                    this.Styles[ScintillaNET.Style.Html.Comment].ForeColor = Color.Green;
/**/                    this.Styles[ScintillaNET.Style.Html.Value].ForeColor = Color.Yellow;
/**/                    this.Styles[ScintillaNET.Style.Html.Tag].ForeColor = Color.BlueViolet;
/**/                    this.Styles[ScintillaNET.Style.Html.Attribute].ForeColor = Color.LimeGreen;
/**/                    this.Styles[ScintillaNET.Style.Html.DoubleString].ForeColor = Color.Yellow;
/**/                    this.Styles[ScintillaNET.Style.Html.Other].ForeColor = Color.Gray;
/**/
/**/                }
/**/            }
/**/        }
/**/        public static string splitPath(string path)
/**/        {
/**/            if (path.Split('\\').Length > 1)
/**/            {
/**/                return path.Split('\\')[path.Split('\\').Length - 1];
/**/            }else if (path.Split('/').Length > 1)
/**/            {
/**/                return path.Split('/')[path.Split('/').Length - 1];
/**/
/**/            }else
/**/            {
/**/                return path;
/**/            }
/**/        }
/**/        public static int getLanguage(string filename)
/**/        {
/**/            string[] filenameSplitted;
/**/            try {
/**/                filenameSplitted = filename.Split('.');
/**/            }
/**/            catch
/**/            {
/**/                return -1;
/**/            }
/**/            if (filenameSplitted.Length > 1)
/**/            {
/**/                string extend = filenameSplitted[filenameSplitted.Length - 1];
/**/                if (extend == "txt")
/**/                {
/**/                    return -1;
/**/                }
/**/                else if (extend == "html" || extend == "htm" ||
/**/                   extend == "shtml" || extend == "shtm" ||
/**/                   extend == "xhtml" || extend == "xht" ||
/**/                   extend == "hta")
/**/                {
/**/                    return 4;
/**/                }
/**/                else if (extend == "ada" || extend == "ads" ||
/**/                       extend == "adb")
/**/                {
/**/                    return 20;
/**/                }
/**/                else if (extend == "asm")
/**/                {
/**/                    return 34;
/**/                }
/**/                else if (extend == "bat" || extend == "cmd" ||
/**/                        extend == "nt")
/**/                {
/**/                    return 12;
/**/                }
/**/                else if (extend == "bb" || extend == "bmx")
/**/                {
/**/                    return 66;
/**/                }
/**/                else if (extend == "container")
/**/                {
/**/                    return 0;
/**/                }
/**/                else if (extend == "cpp" || extend == "cxx" ||
/**/                        extend == "hpp" || extend == "hpp" ||
/**/                        extend == "cc" || extend == "ino" ||
/**/                        extend == "h" || extend == "cs")
/**/                {
/**/                    return 3;
/**/                }
/**/                else if (extend == "css")
/**/                {
/**/                    return 38;
/**/                }
/**/                else if (extend == "f" || extend == "for" ||
/**/                        extend == "f90" || extend == "f95" ||
/**/                        extend == "f25" || extend == "f23" ||
/**/                        extend == "f77")
/**/                {
/**/                    return 36;
/**/                }
/**/                else if (extend == "json")
/**/                {
/**/                    return 120;
/**/                }
/**/                else if (extend == "lisp")
/**/                {
/**/                    return 21;
/**/                }
/**/                else if (extend == "lua")
/**/                {
/**/                    return 15;
/**/                }
/**/                else if (extend == "markdown" || extend == "md")
/**/                {
/**/                    return 98;
/**/                }
/**/                else if (extend == "pas" || extend == "pp" ||
/**/                        extend == "p" || extend == "inc" ||
/**/                        extend == "lpr")
/**/                {
/**/                    return 18;
/**/                }
/**/                else if (extend == "pm" || extend == "pl" ||
/**/                        extend == "plx")
/**/                {
/**/                    return 6;
/**/                }
/**/                else if (extend == "php" || extend == "phps" ||
/**/                        extend == "php3" || extend == "php4" ||
/**/                        extend == "php5" || extend == "phpt" ||
/**/                        extend == "phphtml")
/**/                {
/**/                    return 69;
/**/                }
/**/                else if (extend == "ps1" || extend == "psc1" ||
/**/                        extend == "psd1" || extend == "psm1")
/**/                {
/**/                    return 88;
/**/                }
/**/                else if (extend == "pas" || extend == "properties")
/**/                {
/**/                    return 18;
/**/                }
/**/                else if (extend == "py" || extend == "pyw")
/**/                {
/**/                    return 2;
/**/                }
/**/                else if (extend == "r" || extend == "s" ||
/**/                        extend == "splus")
/**/                {
/**/                    return 86;
/**/                }
/**/                else if (extend == "rb" || extend == "rbw")
/**/                {
/**/                    return 22;
/**/                }
/**/                else if (extend == "st")
/**/                {
/**/                    return 72;
/**/                }
/**/                else if (extend == "sql" || extend == "sqlite" ||
/**/                        extend == "mdf" || extend == "myd" ||
/**/                        extend == "myi" || extend == "db")
/**/                {
/**/                    return 7;
/**/                }
/**/                else if (extend == "vbx")
/**/                {
/**/                    return 8;
/**/                }
/**/                else if (extend == "v" || extend == "sv" ||
/**/                        extend == "vh" || extend == "svh")
/**/                {
/**/                    return 56;
/**/                }
/**/                else if (extend == "xml" || extend == "xaml" ||
/**/                        extend == "xsl" || extend == "xslt" ||
/**/                        extend == "xsd" || extend == "xvl" ||
/**/                        extend == "kml" || extend == "svg" ||
/**/                        extend == "mxml" || extend == "xsml" ||
/**/                        extend == "wsdl" || extend == "xlf" ||
/**/                        extend == "xliff" || extend == "xbl" ||
/**/                        extend == "sxbl" || extend == "sitemap" ||
/**/                        extend == "gml" || extend == "gpx" ||
/**/                        extend == "plist")
/**/                {
/**/                    return 5;
/**/                }
/**/                else
/**/                {
/**/                    return -1;
/**/                }
/**/            }
/**/            else
/**/            {
/**/                return -1;
/**/            }
/**/        }
/**/        public static string md5_hexdigest(string data)
/**/        {
/**/            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
/**/            byte[] btr = Encoding.UTF8.GetBytes(data);
/**/            btr = md5.ComputeHash(btr);
/**/            StringBuilder sb = new StringBuilder();
/**/            foreach (byte ba in btr)
/**/            {
/**/                sb.Append(ba.ToString("x2").ToLower());
/**/            }
/**/            return sb.ToString();
/**/        }
/**/    }
/**/}
