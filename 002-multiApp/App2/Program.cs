using System;
using Serilog;
using Lib1;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
	    Log.Logger = new LoggerConfiguration().MinimumLevel.Information().WriteTo.Console().WriteTo.File("log.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true).CreateLogger();

	    Log.Information("entering Main");
            Console.WriteLine("Hello World!");
	    Class1 class1 = new Class1();
	    class1.hello();

	    Log.CloseAndFlush();
        }
    }
}
