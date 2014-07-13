using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SSWEditor
{
    public class Config
    {
        private string globalPrefix;
        public string GlobalPrefix
        {
            get { return globalPrefix; }
            set {
                globalPrefix = value;
                if (globalPrefix.Length > 0 && globalPrefix[globalPrefix.Length-1] != '/') globalPrefix += "/";
            }
        }

        private int fusekiPort = 3030;
        public int FusekiPort
        {
            get { return fusekiPort; }
            set {
                if ( value > 0 && value < 65536 ) fusekiPort = value;
            }
        }

        private bool showFusekiConsole = false;
        public bool ShowFusekiConsole
        {
            get { return showFusekiConsole; }
            set { showFusekiConsole = value; }
        }

        private string editorFont = "";
        public string EditorFont
        {
            get { return editorFont; }
            set { editorFont = value; }
        }

        public void SetEditorFont(Font font)
        {
            var cvt = new FontConverter();
            editorFont = cvt.ConvertToString(font);
        }

        public Font GetEditorFont()
        {
            var cvt = new FontConverter();
            return cvt.ConvertFromString(editorFont) as Font;
        }


        public static string GetRandomString(int length)
        {
            RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            string s = "";
            for (int i = 0; i < length; i++)
            {
                byte[] intBytes = new byte[4];
                rand.GetBytes(intBytes);
                uint randomInt = BitConverter.ToUInt32(intBytes, 0);
                s += chars[randomInt % chars.Length];
            }
            return s;
        }
    }

}
