using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAcademy_Sports_Results_Notifier
{
    internal static class Helpers
    {
        internal static string ResultListToString(List<TableRowResults> resultsList)
        {
            var htmlBody = new StringBuilder();

            htmlBody.AppendLine("<table>");

            htmlBody.AppendLine("<tr><th>Name</th><th>Wins</th><th>Loses</th><th>Win-Loss %</th><th>Games Behind</th><th>Points Per Game</th><th>Opponents Points Per Game</th></tr>");

            foreach (var result in resultsList)
            {
                htmlBody.AppendLine($"<tr><td>{result.Name}</td><td>{result.Wins}</td><td>{result.Loses}</td><td>{result.WinsLossesPercentage}</td><td>{result.GamesBehind}</td><td>{result.PointsPerGame}</td><td>{result.OpponentsPointPerGame}</td></tr>");
            }

            htmlBody.AppendLine("</table>");

            string emailBody = htmlBody.ToString();

            return emailBody;
        }
    }
}
