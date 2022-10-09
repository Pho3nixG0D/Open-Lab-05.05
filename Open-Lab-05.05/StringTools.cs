using NUnit.Framework.Internal.Execution;
using System;
using System.Reflection;
using System.Text;

namespace Open_Lab_05._05
{
    public class StringTools
    {
        public string AlternatingCaps(string original)
        {
            string results = string.Empty;
            int count = 0;

            for (int i = 0; i < original.Length; i++)
            {
                //space check
                if (original[i] == ' ')
                {
                    results += ' ' ;
                    continue;
                }
                //check every second letter set uppercase
                if (count % 2 == 0)
                {
                    results += char.ToUpper(original[i]);
                    count++;
                }
                //set to lowercase
                else
                {
                    count++;
                    results += char.ToLower(original[i]);

                }
            }
            return results;


        }
        
    }
}
