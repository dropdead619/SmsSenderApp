﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    class RandomCodeGenerator
    {
       public static string Generate(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars); 
            return finalString;
        }
        
}
}
