using System;
using Serilog;

namespace Lib1
{
    public class Class1
    {
	public void hello()
	{
		Log.Information("entering hello");
		Console.WriteLine("Greetings from Lib1.Class1!");
		Log.Information("exiting hello");
	}
    }
}
