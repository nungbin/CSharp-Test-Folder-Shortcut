// ./CSharp_Test_Shortcut -Folder=c:\bin\p.lnk
using ShellLink;

namespace TestShortcut
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/CaledoniaProject/LNK-Parser-csharp/blob/master/ConsoleApp2/Program.cs            
            Shortcut shortcuts;
            string controlFileName = "";

            try {
                // Examine command line parameters
                foreach (string arg in args)
                {
                    if (arg.ToUpper().StartsWith("-FOLDER="))
                    {
                        controlFileName = arg.Split('=')[1];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred during Execution" + ex.Message);
            }

            try {
                //shortcuts = Shortcut.ReadFromFile(@"C:\Bin\p.lnk");
                shortcuts = Shortcut.ReadFromFile(controlFileName);

                Console.WriteLine(
                    //Shortcut.ReadFromFile(@"C:\Bin\calc.lnk")
                    //Shortcut.ReadFromFile(@"C:\Bin\p.lnk")
                    shortcuts.LinkInfo.LocalBasePath
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred during Execution" + ex.Message);
            }
        }
    }
}