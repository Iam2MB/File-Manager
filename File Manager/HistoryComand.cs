using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Manager
{
    internal class HistoryComand
    {
        private static List<string> historyComand = new List<string>();

        public static void HC(string comand)
        {
            historyComand.Add(comand);
        }
    }
}
