using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Process current = Process.GetCurrentProcess();
        current.PriorityClass = ProcessPriorityClass.High;
        Console.WriteLine($"---------------------- Current Processes Info -------------------------------");
        Console.WriteLine($"PriorityClass            :: {current.PriorityClass}");
        Console.WriteLine($"ProcessName              :: {current.ProcessName}");
        Console.WriteLine($"Id                       :: {current.Id}");
        Console.WriteLine($"MachineName              :: {current.MachineName}");
        Console.WriteLine($"PrivateMemorySize (Kb)   :: {current.PrivateMemorySize64 / 1024}");
        Console.WriteLine($"StartTime                :: {current.StartTime}");
        Console.WriteLine($"TotalProcessorTime       :: {current.TotalProcessorTime}");
        Console.WriteLine($"UserProcessorTime        :: {current.UserProcessorTime}");*/

        // All processes

        /*Process[] processes = Process.GetProcesses();
        foreach (Process pr in processes) {
            try {
                Console.WriteLine($"{pr.ProcessName,-50} {pr.Id,-5} {pr.PriorityClass,-10} {pr.StartTime}");
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error with {pr.ProcessName}");
                Console.ResetColor();
            }

        
        }*/

        // Start Process

        /*var pr = Process.Start("Calc.exe");
        Console.WriteLine($"{pr.ProcessName,-50} {pr.Id,-5} {pr.PriorityClass,-10} {pr.StartTime}");*/

        //Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "google.com stackoverflow.com");

        ProcessStartInfo info = new ProcessStartInfo()
        {
            FileName = "notepad",
            Arguments = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\888.txt",
            WindowStyle = ProcessWindowStyle.Maximized
        };
        Process pr = Process.Start(info);
        Console.ReadKey();

        //pr.Close();
        //pr.CloseMainWindow(); // alt + F4
        pr.Kill();
        Console.WriteLine("Operation has done!");
        Console.WriteLine("Wait for exit");
        pr.WaitForExit();
        Console.WriteLine("Process was exit ...");
        Console.WriteLine($"Exit code :: {pr.ExitCode}");
        Console.WriteLine($"Exit time :: {pr.ExitTime}");
    }
}