namespace FileTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 and 3
            string path = @"C:\Users\user\Desktop\test.txt";
            //try
            //{

            //    if (!File.Exists(path))
            //    {
            //        File.Create(path);
            //        Console.WriteLine($"A file created with name {path.Split(@"\").Last()}");

            //    }
            //    else
            //    {
            //        throw new CreateErrorException("File already exist");
            //    }

            //}
            //catch (CreateErrorException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            // Task 2
            //try
            //{
            //    if (File.Exists(path))
            //    {
            //        File.Delete(path);
            //        Console.WriteLine($"The file {path.Split(@"\").Last()} deleted successfully.");
            //    }
            //    else
            //    {
            //        throw new Exception("File does not exist");
            //    }
            //}
            //catch (CreateErrorException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            // Task 4
            //File.Create(path);
            //File.WriteAllText(path, "This is my text which that already added");


            // Task 5
            //File.WriteAllText(path, "Here is the content of the file mytest.txt :\nHello and Welcome\nIt is the first content\nof the text file mytest.txt");


            // Task 6
            //string[] arr = { "this is 1st line", "this is 2nd line" };
            //File.WriteAllLines(path, arr);
            //var lines = File.ReadAllLines(path);
            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}


            // Task 7
            //List<string> arr =new List<string>() { "the quick brown fox jumps", "over the lazy dog", "me add" };
            //List<string> list = new List<string>();
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    if (!arr[i].Contains("fox"))
            //    {
            //        list.Add(arr[i]);
            //        File.WriteAllLines(path, list);
            //    }

            //}
            //var lines = File.ReadAllLines(path);
            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}


            // Task 8
            //List<string> list = new List<string>() { "Hello and Welcome", "It is the first content", "of the text file mytest.txt", "This is the line appended at last line." };
            //File.AppendAllLines(path, list);


            // Task 9
            //var destPath = $@"{Path.GetDirectoryName(path)}\test2.txt";
            //try
            //{
            //    if (!File.Exists(destPath))
            //    {
            //        List<String> copyList = new List<string>() { $"The file {path.Split(@"\").Last()} successfully copied to the name {destPath.Split(@"\").Last()} in the same directory.", $"Here is the content of the file {destPath.Split(@"\").Last()} :", "Hello and Welcome", "It is the first content", "of the text file mytest.txt" };
            //        File.Copy(path, destPath, true);
            //        File.WriteAllLines(destPath, copyList);
            //        var lines = File.ReadAllLines(destPath);
            //        foreach (string line in lines)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }
            //    else
            //    {
            //        throw new Exception("File does not exist");
            //    }
            //}
            //catch (CreateErrorException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //File.Delete(destPath);


            // Task 10
            var movePath = @"C:\Users\user\Desktop\test3.txt";
            //try
            //{
            //    if (File.Exists(path))
            //    {
            //        File.Move(path, movePath);
            //    }
            //    else
            //    {
            //        throw new Exception("File does not exist");
            //    }
            //}

            //catch (CreateErrorException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            // Task 11
            //var newFile = new FileInfo(movePath);
            //try
            //{
            //    if (newFile.Exists && newFile.Length > 0)
            //    {
            //        var line = File.ReadAllLines(movePath).First();
            //        Console.WriteLine("The content of the first line of the file is :\n" + line);
            //    }
            //    else
            //    {
            //        throw new Exception("File does not exist or Length is not bigger than 0");
            //    }
            //}
            //catch(CreateErrorException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            // Task 12
            //try
            //{
            //    if (newFile.Exists && newFile.Length > 0)
            //    {
            //        var line = File.ReadAllLines(movePath).Last();
            //        Console.WriteLine("The content of the last line of the file is :\n" + line);
            //    }
            //    else
            //    {
            //        throw new Exception("File does not exist or Length is not bigger than 0");
            //    }
            //}
            //catch (CreateErrorException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            // Task 13
            //try
            //{
            //    var userInput = int.Parse(Console.ReadLine());
            //    var lines = File.ReadAllLines(movePath);
            //    if (File.Exists(movePath) && lines.Length-1 >= userInput)
            //    {
            //        Console.WriteLine(lines[userInput]);
            //    }
            //    else
            //    {
            //        throw new Exception("File does not exist or UserInput does not exist in array index");
            //    }
            //}catch(CreateErrorException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            // Task 14
            //try
            //{
            //    var n = int.Parse(Console.ReadLine());
            //    var lines = File.ReadAllLines(movePath);
            //    if (File.Exists(movePath) && n<= lines.Length)
            //    {
            //        var res = lines.Skip(lines.Length - n).Take(n);
            //        foreach (var line in res)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }
            //    else
            //    {
            //        throw new Exception("File does not exist or input line is bigger than array length");
            //    }
            //}catch(CreateErrorException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            // Task 15
            //var countLine = File.ReadAllLines(movePath).Count();
            //var lines = File.ReadAllLines(movePath);
            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //Console.WriteLine($"The number of lines in  the file {movePath.Split(@"\").Last()} is : {countLine}");

        }
    }
}