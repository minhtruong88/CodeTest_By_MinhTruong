using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeTest_MinhTruong
{
    class Program
    {
        static void Main(string[] args)
        {
            Util utility = Factory_CodeTest.Create_Util();
            string filePath = utility.GetConfigValue("filePath");
            //Prompt(filePath);
            IJsonTag TagTest = Factory_CodeTest.Create_JsonTag(utility);
            Print(TagTest.GenerateTwoMatchTag_By_FilePath(filePath));
            //Print(TagTest.GenerateTwoMatchTagNamePair(File.ReadAllText(filePath)));
            //Print(TagTest.GenerateTwoMatchTagNamePair(new Recipients()));
            ReadLine();
        }

        private static void Prompt(string name)
        {
            string text = "The file Path is " + name + " get from AppConfig key Name: filePath \n";
            Print(text);
        }

        private static void Print(string content)
        {
            System.Console.WriteLine(content);
        }

        private static string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }
}
