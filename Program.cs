using cSharpAcademy_Sports_Results_Notifier;

var dataCrawler = new DataCrawler("https://www.basketball-reference.com/boxscores/");

var pageData = dataCrawler.ExtractDataFromPage();

Mail.SendMail("kuba@wp.pl", "Hello world", Helpers.ResultListToString(pageData));