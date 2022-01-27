using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDezesseis.Extentions
{
    public class ExercicioElapsedTime
    {
        public static void ExecutarExercicioElapsedTime()
        {
            DateTime dt = new DateTime(2021, 12, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}