using HtmlAgilityPack;
using System;

namespace cSharpAcademy_Sports_Results_Notifier
{
    internal class DataCrawler
    {
        private string _url;
        private HtmlWeb _web;
        private HtmlDocument _doc;

        public DataCrawler(string url)
        {
            _url = url;
            _web = new HtmlWeb();
            _doc = _web.Load(url);
        }

        public List<TableRowResults> ExtractDataFromPage()
        {
            HtmlNode EastConfTable = _doc.DocumentNode.SelectSingleNode("//table[@id='confs_standings_E']");
            List<TableRowResults> eastConfTableRowResult = new List<TableRowResults>();

            if (EastConfTable != null ) {

                HtmlNodeCollection rows = EastConfTable.SelectNodes(".//tbody//tr");

                foreach (var row in rows)
                {
                    HtmlNodeCollection cells = row.SelectNodes(".//td");
                    HtmlNodeCollection cellName = row.SelectNodes(".//th");

                    eastConfTableRowResult.Add(new TableRowResults { 
                        Name = cellName[0].InnerText,
                        Wins = cells[0].InnerText, 
                        Loses = cells[1].InnerText,
                        WinsLossesPercentage = cells[2].InnerText,
                        GamesBehind = cells[3].InnerText,
                        PointsPerGame = cells[4].InnerText,
                        OpponentsPointPerGame = cells[5].InnerText,
                    });
                }
            }

            return eastConfTableRowResult;
        }
    }
}
