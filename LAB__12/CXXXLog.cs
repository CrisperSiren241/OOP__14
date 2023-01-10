using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILESTREAM
{
    public class CXXXLog
    {
        public void LOGGER(string info, string path)
        {
            if(path != null)
            {
                File.AppendAllText("newtext.txt", $"{DateTime.Now}: {info}");
            }
            else
            {
                Console.WriteLine("Has not path!");
            }
        }
    }       
}
