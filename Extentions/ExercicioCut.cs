using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDezesseis.Extentions
{
    class ExercicioCut
    {
        public static void ExecutarExercicioCut()
        {
            string s1 = "Good morning dear students...";
            Console.WriteLine(s1.Cut(10));           
        }

    }
}