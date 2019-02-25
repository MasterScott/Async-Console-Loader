using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUBG_Pack_Loader
{
    class Program
    {

        static void Main(string[] args)
        {
            
            string mFold = @"\Pack\";
            string mput = Application.StartupPath.ToString();
            string mmf = mput + mFold;

            Console.Clear();
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("### Hello ###");
            }

            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Async Loader");
            }
            
                Console.ForegroundColor = ConsoleColor.Yellow;

            
                if (System.IO.Directory.Exists(mmf))
                {

                }
                else
                {
                    Console.WriteLine("Create main directory...");
                    string path = mmf;
                    Directory.CreateDirectory(path);
                }            

                Console.WriteLine("Please wait, we have download pack...");
            Console.WriteLine("Count files: 1, Size: 36,6 MB");

            Task.Run(() =>
            {
                WebClient wc = new WebClient();                
                string url = "https://adress.com/File.zip";               
                string save_path = mmf;
                string name = "File.zip";

                int currentProgress = -1;
                wc.DownloadProgressChanged += (o, e) =>
                {
                    if (currentProgress != e.ProgressPercentage)
                    {
                        Console.WriteLine(e.ProgressPercentage + "% ");
                    }
                        
                    Thread.Sleep(1000);
                };

                wc.DownloadFileAsync(new Uri(url), save_path + name);                
            });

            Console.ReadLine();

        }
    }
}
