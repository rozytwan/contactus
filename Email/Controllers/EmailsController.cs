using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Email.Controllers
{
    public class EmailsController : Controller
    {
        // GET: Emails
        public ActionResult Index()
        {
            return View();
        }
        public void SendMail(Email.Models.Email _email)
        {
            if (ModelState.IsValid)
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("krennovatest@gmail.com");
                mail.To.Add(_email.To);
                mail.To.Add("krennovatest@gmail.com");
                mail.Subject = _email.Subject;
                mail.Body += _email.Body;
                mail.IsBodyHtml = true;
                try
                {
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("krennovatest@gmail.com", "test@123#");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                }
                catch (Exception er)
                {

                    throw;
                }

            }

        }
        public void SendMailtest()
        {
            if (ModelState.IsValid)
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("krennovatest@gmail.com");
                mail.To.Add("rozytwan@gmail.com");
                mail.To.Add("rozytwan@gmail.com");
                mail.Subject = "Password Recovery ";
                mail.Body += " <html>";
                mail.Body += "<body>";
                mail.Body += "<table>";
                mail.Body += "<tr>";
                mail.Body += "<td>User Name : </td><td> HAi </td>";
                mail.Body += "</tr>";

                mail.Body += "<tr>";

                mail.Body += "<td>Password : </td><td>aaaaaaaaaa</td>";
                mail.Body += "</tr>";
                mail.Body += "</table>";
                mail.Body += "</body>";
                mail.Body += "</html>";
                mail.IsBodyHtml = true;
                try
                {
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("krennovatest@gmail.com", "test@123#");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                }
                catch (Exception er)
                {

                    throw;
                }

            }
        }
    }
}