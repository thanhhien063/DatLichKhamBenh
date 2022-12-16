using DatLichKhamBenh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace DatLichKhamBenh.Controllers
{
    public class LienHeController : Controller
    {
        // GET: LienHe
        public ActionResult LienHe()
        {
            return View();
        }
        public ActionResult SendMailLienHe(LienHeViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("trangialoc1998@gmail.com", "HealthCare@noreply");
                    var receiverEmail = new MailAddress(model.Email, "Receiver");
                    var password = "sjxzteanuixbqyjw";
                    var subject = "HealthCare thông tin liên hệ";
                    var body = "Thông tin liên hệ cảm ơn bạn đã liên hệ với chúng tôi. Chúng tôi sẽ liên hệ lại bạn trong vòng 8h làm việc.";
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return RedirectToAction("LienHe", "LienHe");
        }
    }
}