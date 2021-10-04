using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4
{
    class Strings
    {

        static void Main(string[] args)
        {
            string @string = "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert";
            string[] str2 = @string.Split(',');
            var diapazon = Enumerable.Range(1, str2.Length);
            var result = diapazon.Zip(str2, (m, n) => m + ". " + n.Trim(' '));
            foreach (var val in result)
                Console.WriteLine(val);
            var str3 = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988";
            string[] str4 = str3.Split(';');

            var sortedMonths = str4
              .Select(x => new
              {
                  name = x.Split(',')[0],
                  age = ((DateTime.Now.Year - (DateTime.Parse(x.Split(',')[1])).Year))
              })
              .OrderByDescending(x => x.age);
            foreach (var val in sortedMonths)
                Console.WriteLine(val.name + " " + (val.age));
            string songs = "4:1,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";
            string[] songsArr = songs.Split(',');
            var S1 = songsArr
             .Select(x => new
             {
                 lenth = TimeSpan.Parse(x)
             })
             .Sum(x => x.lenth.TotalMinutes);
            Console.WriteLine($"Довжина всіх пісень {S1} хвилин i {S1 % 60} секунд");
        }
    }
}