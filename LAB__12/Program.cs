using System;

namespace FILESTREAM
{
    class Program
    {
        static void Main()
        {
            XXXDiskInfo din = new XXXDiskInfo();
            din.DisInfo();
            Console.WriteLine();
            XXXDirInfo dinDir = new XXXDirInfo();
            dinDir.DirInfo();
            XXXFileInfo dinFileInfo = new XXXFileInfo();
            dinFileInfo.FileInformation();
            XXXFileManager xXXFileManager = new XXXFileManager();
            xXXFileManager.Task();
            CXXXLog logger = new CXXXLog();
            logger.LOGGER("", "D:\\BSTU\\ООП\\FILESTREAM\\XXXDIRECT");
        }
    }
}