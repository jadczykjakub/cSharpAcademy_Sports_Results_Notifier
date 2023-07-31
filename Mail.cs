using System.Net;
using System.Net.Mail;

namespace cSharpAcademy_Sports_Results_Notifier
{
    internal class Mail
    {
        internal static void SendMail(string sendMailTo, string subject, string body)
        {
            string email = "santa.spencer66@ethereal.email";

            var smtpClient = new SmtpClient("smtp.ethereal.email")
            {
                Port = 587,
                Credentials = new NetworkCredential("santa.spencer66@ethereal.email", "13zyAfSaAcvX74pATF"),
                EnableSsl = true,
            };

            smtpClient.Send(email, sendMailTo, subject, body);
        }
    }
}
