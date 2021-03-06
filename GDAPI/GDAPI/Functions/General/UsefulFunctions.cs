﻿using GDAPI.Functions.Extensions;
using System.Collections.Generic;
using System.Text;
using static System.IO.File;

namespace GDAPI.Functions.General
{
    public static class UsefulFunctions
    {
        public static void WriteAllLinesWithoutUselessNewLine(string path, string[] contents)
        {
            var result = new StringBuilder();
            for (int i = 0; i < contents.Length; i++)
                result.Append(contents[i] + "\n");
            result.Remove(result.Length - 1, 1);
            WriteAllText(path, result.ToString());
        }
        public static void WriteAllLinesWithoutUselessNewLine(string path, StringBuilder[] contents)
        {
            var result = new StringBuilder();
            for (int i = 0; i < contents.Length; i++)
                result.Append(contents[i] + "\n");
            result.Remove(result.Length - 1, 1);
            WriteAllText(path, result.ToString());
        }
        public static void WriteAllLinesWithoutUselessNewLine(string path, List<string> contents)
        {
            var result = new StringBuilder();
            for (int i = 0; i < contents.Count; i++)
                result.Append(contents[i] + "\n");
            result.Remove(result.Length - 1, 1);
            WriteAllText(path, result.ToString());
        }
        public static void WriteAllLinesWithoutUselessNewLine(string path, List<StringBuilder> contents)
        {
            var result = new StringBuilder();
            for (int i = 0; i < contents.Count; i++)
                result.Append(contents[i] + "\n");
            result.Remove(result.Length - 1, 1);
            WriteAllText(path, result.ToString());
        }
    }
}