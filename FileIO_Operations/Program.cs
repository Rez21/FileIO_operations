using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
namespace FileIO_Operations
{
    class Program
    {
        public static void FileExist()
        {
            string path = @"C:\Users\banpr\Desktop\FileOperations\FileIO\FileOperations.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
        }
        public static void ReadLines()
        {
            string path = @"C:\Users\banpr\Desktop\FileOperations\FileIO\FileOperations.txt";
            string[] line;
            line = File.ReadAllLines(path);

            Console.WriteLine(line[0]);
            Console.WriteLine(line[1]);
            Console.ReadKey();
        }
        public static void ReadAllText()
        {
            string path = @"C:\Users\banpr\Desktop\FileOperations\FileIO\FileOperations.txt";
            string line;
            line = File.ReadAllText(path);
            Console.WriteLine(line);
            Console.ReadKey();
        }
        public static void CopyFile()
        {
            string path = @"C:\Users\banpr\Desktop\FileOperations\FileIO\FileOperations.txt";
            string Copypath = @"C:\Users\banpr\Desktop\FileOperations\FileIO\FileOperationsCopy.txt";
            File.Copy(path, Copypath);
            Console.ReadKey();
        }
        public static void DeleteFile()
        {
            string path = @"C:\Users\banpr\Desktop\FileOperations\FileIO\FileOperationsCopy.txt";
            File.Delete(path);
            Console.ReadKey();
        }
        public void StreamReader()
        {
            string path = @"C:\Users\banpr\Desktop\FileOperations\FileIO\FileOperations.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
        public void StreamWriter()
        {
            string path = @"C:\Users\banpr\Desktop\FileOperations\FileIO\FileOperations.txt";
            using (StreamWriter sr = new StreamWriter(path))
            {
                sr.WriteLine("Stream Writing");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
                Console.ReadKey();
            }
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("File IO operations");
            //Console.WriteLine("\nFile Exists Operation ");
            //FileExist();
            //Console.WriteLine("\nRead lines operation");
            //ReadLines();
            //Console.WriteLine("\nRead All text operation");
            //ReadAllText();
            //Console.WriteLine("\nCopy File Operation");
            //CopyFile();
            //Console.WriteLine("\nDelete File Operation");
            //DeleteFile();


            //Program program = new Program();
            //program.StreamReader();
            // program.StreamWriter();
        }
    }
}