using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAcademy_Sports_Results_Notifier
{
    internal class TableRowResults
    {
        public string Name { get; set; }
        public string Wins { get; set; }
        public string Loses { get; set; }
        public string WinsLossesPercentage { get; set; }
        public string GamesBehind { get; set; }
        public string PointsPerGame { get; set; }
        public string OpponentsPointPerGame { get; set; }
    }
}
