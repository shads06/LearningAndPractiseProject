using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace Learning.FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateDirectoryAndFile();
            CreateDirectoryInfo();
            PreventDirectoryRenaming();
            Console.WriteLine("Press Enter to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// This method will check whether the CreateDirectory method of Directory class will delete content of the directory if we create the directory which is already created.
        /// </summary>
        public static void CreateDirectoryAndFile()
        {
            Console.WriteLine("\nCreating Directory...");
            var di = Directory.CreateDirectory("Sample");
            Directory.CreateDirectory(di.FullName + @"\Sample1");
            Directory.CreateDirectory(di.FullName + @"\Sample3");
            Directory.CreateDirectory(di.FullName + @"\Sample4");
            Console.WriteLine("Directory Created");
            if (!File.Exists("Sample\\abc.txt"))
            {
                Console.WriteLine("Creating File...");
                File.Create("Sample\\abc.txt").Close();
                using (var sw = new StreamWriter("Sample\\abc.txt"))
                {
                    sw.WriteLine("Sample Text 1");
                    sw.WriteLine("Sample Text 2");
                    sw.WriteLine("Sample Text 3");
                    sw.WriteLine("Sample Text 4");
                    sw.WriteLine("Sample Text 5");
                    sw.WriteLine("Sample Text 6");
                }

                File.Create("Sample\\Sample1\\abc.txt").Close();
                using (var sw = new StreamWriter("Sample\\Sample1\\abc.txt"))
                {
                    sw.WriteLine("Sample Text 1");
                    sw.WriteLine("Sample Text 2");
                    sw.WriteLine("Sample Text 3");
                    sw.WriteLine("Sample Text 4");
                    sw.WriteLine("Sample Text 5");
                    sw.WriteLine("Sample Text 6");
                }

                File.Create("Sample\\Sample3\\abc.txt").Close();
                using (var sw = new StreamWriter("Sample\\Sample3\\abc.txt"))
                {
                    sw.WriteLine("Sample Text 1");
                    sw.WriteLine("Sample Text 2");
                    sw.WriteLine("Sample Text 3");
                    sw.WriteLine("Sample Text 4");
                    sw.WriteLine("Sample Text 5");
                    sw.WriteLine("Sample Text 6");
                }

                File.Create("Sample\\Sample4\\abc.txt").Close();
                using (var sw = new StreamWriter("Sample\\Sample4\\abc.txt"))
                {
                    sw.WriteLine("Sample Text 1");
                    sw.WriteLine("Sample Text 2");
                    sw.WriteLine("Sample Text 3");
                    sw.WriteLine("Sample Text 4");
                    sw.WriteLine("Sample Text 5");
                    sw.WriteLine("Sample Text 6");
                }

                Console.WriteLine("File Created");
            }
        }

        /// <summary>
        /// This method will check whether the DirectoryInfo will be initialized if the path given to DirectoryInfo cosntructor doesn't exist
        /// </summary>
        public static void CreateDirectoryInfo()
        {
            Console.WriteLine("\nCreating Directory Info Instance...");
            DirectoryInfo di = new DirectoryInfo("Sample1");
            Console.WriteLine("Directory Info Instance Created");
        }

        /// <summary>
        /// This method will detect the folder Sample1 renamed to Sample2 and move it back to Sample1 automatically with delay of 3 seconds. This method will fail to execute if .txt files or anyother file is renamed.
        /// </summary>
        public static void PreventDirectoryRenaming()
        {
            Console.WriteLine("\nAdding File System Watcher...");
            FileSystemWatcher sampleWatcher = new FileSystemWatcher(Directory.GetCurrentDirectory() + @"\Sample");
            sampleWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            sampleWatcher.Renamed += SampleWatcher_Renamed;
            //sampleWatcher.Filter = "Sample";
            sampleWatcher.IncludeSubdirectories = true;
            sampleWatcher.EnableRaisingEvents = true;
            Console.WriteLine("File System Watcher Added");
            Console.WriteLine("++++++++++++++ Go Ahead! Rename Sample1 to Sample2 and see the magic ++++++++++++++");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static async void SampleWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            try
            {
                Console.WriteLine($"\nFile Renamed Event Fire. New Name: {e.Name} and Old Name: {e.OldName}");
                if (e.Name == "Sample2")
                {
                    Console.WriteLine("\nMessage From File System Watch - Directory Renamed. Moving Directory to New Directory");
                    await Task.Delay(3000);
                    var parentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\Sample");
                    //Directory.CreateDirectory(@"C:\Sample\Sample1");
                    var directory = parentDirectory.GetDirectories(e.Name)[0];
                    directory.MoveTo(Directory.GetCurrentDirectory() + @"\Sample\Sample1");
                    //directory.Delete();
                    Console.WriteLine("Directory Moved.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to move the directory. If you renamed file instead of folder, then please rename folder and see the magic, else this program needs to be improved.");
            }
        }
    }
}
