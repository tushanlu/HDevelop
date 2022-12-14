using System;
using System.Threading;

namespace HDevelop
{
    class Program
    {
        static void Main(string[] args)
        {
            string sPath = Environment.GetEnvironmentVariable("HALCONROOT");
            string sPlatform = Environment.GetEnvironmentVariable("HALCONARCH");

            if (sPath == null || sPlatform == null)
            {
                Console.WriteLine(">> 未找到Halcon程序");
                Console.ReadKey();
                return;
            }

            System.Diagnostics.Process exep = new System.Diagnostics.Process();
            exep.StartInfo.FileName = sPath + "\\bin\\" + sPlatform + "\\hdevelop.exe";
            exep.StartInfo.Arguments = "";
            exep.StartInfo.CreateNoWindow = false;
            exep.StartInfo.UseShellExecute = false;
            exep.Start();
            
        }
    }
}
