﻿using System;
using System.Linq;

public static class Kata
{
    public static string ReverseWords(string str)
    {
        return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
    }
}