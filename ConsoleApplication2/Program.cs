using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace ConsoleApplication2
{
    class Program
    {
        static Renci.SshNet.SshClient ssh;
        static Renci.SshNet.ShellStream stream;
        static void Main(string[] args)
        {
            Console.WriteLine("denemedir");

            try
            {
                ssh = new SshClient("10.143.3.110", "root", "ismail");
                ssh.Connect();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + " ssh connect hatasi");
            }

/*
            try
            {
                stream = ssh.CreateShellStream("xterm", 80, 50, 1024, 1024, 1024);
                //Thread.Sleep(100);
                stream.WriteLine("telnet localhost 6571");
               // pictureBox1.Image = ATA50_Otomasyon.Properties.Resources.bagli;
               // Thread.Sleep(100);
               // kontrol();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + " shell streamda hata var");
            }
            */
            Console.ReadKey();
        }
    }
}
