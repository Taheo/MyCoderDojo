using System;
using System.IO;

namespace MyCoderDojo
{
    public class PathOperations
    {
        private readonly string GenericPath = @"c:\";
        private readonly string FilePath = @"testfile.txt";

        public void Test()
        {
            var combinedpath = TestCombine();
            TestGetDirectoryName(combinedpath);
            TestGetPathInAnyKind(combinedpath);
            TestExtensionsMethods(Path.Combine(combinedpath,FilePath));
        }

        private string TestCombine()
        {
            string addonToPath = "addon";
            return Path.Combine(GenericPath, addonToPath);
        }

        private void TestGetDirectoryName(string path)
        {
            Console.WriteLine($"Directory Name: {Path.GetDirectoryName(path)}");
        }

        private void TestGetPathInAnyKind(string path)
        {
            Console.WriteLine($"Full path: {Path.GetFullPath(path)}");
            Console.WriteLine($"Root path: {Path.GetPathRoot(path)}");
        }

        private void TestExtensionsMethods(string path) 
        {
            Console.WriteLine($"Has Extension: {Path.HasExtension(path)}");
            Console.WriteLine($"Extension: {Path.GetExtension(path)}");
        }
    }
}
