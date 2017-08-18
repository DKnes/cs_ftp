using System;
namespace cs_ftp
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //FtpWeb myFtp = new FtpWeb("123.206.93.234", "uftp", "ftpftp");
            //foreach (var i in myFtp.GetFileList("*.*")){
            //    Console.WriteLine(i);
            //}
            //myFtp.Download("/public/","ftp://123.206.93.234/123.xrx","123.xrx");
            HandyFtp myFtp = new HandyFtp("123.206.93.234", "uftp", "ftpftp");
            foreach (var i in myFtp.GetFileList()){
                Console.WriteLine(i);
            }
            myFtp.Download("123.xrx","/public/","hehe.txt");
        }
    }
}
