using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILESTREAM
{
    public class XXXFileManager
    {
        string path = "D:\\BSTU\\ООП\\FILESTREAM\\XXXDIRECT\\text.txt";
        string dir = "D:\\BSTU\\ООП\\FILESTREAM\\XXXDIRECT";
        public void Task()
        {
            Directory.CreateDirectory(dir);
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("Там текст");
                fs.Write(info, 0, info.Length);
            }
            FileInfo fi = new("D:\\BSTU\\ООП\\FILESTREAM\\XXXDIRECT\\text.txt");
            File.Delete(path);
        }
    }
}
