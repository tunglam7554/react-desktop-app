using System;
using System.Windows.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WinFormsApp;

namespace EquipmentManager
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().RunAsync();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
