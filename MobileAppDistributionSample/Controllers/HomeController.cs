using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using UAParser;

namespace MobileAppDistributionSample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Send(string phone)
        {
            var client = new TwilioRestClient(Credentials.AccountSid, Credentials.AuthToken);
            var result = client.SendMessage(Constants.FROM, phone, "Whooooo goes there!?! Download owl.ly the app for owls today! http://bit.ly/1nQuiB6");

            if (result.RestException != null)
            {
                return Json(new { result = false });
            }

            return Json(new { result = true });
        }

        public ActionResult Redirection()
        {
            var parser = Parser.GetDefault();
            var device = parser.ParseDevice(Request.UserAgent);
            string storeLink = String.Empty;

            switch (device.ToString())
            {
                case "iPhone" :
                case "iPad" :
                    storeLink = Constants.APPSTORELINK;
                    break;
                case "Android" :
                    storeLink = Constants.PLAYSTORELINK;
                    break;
                case "Windows Mobile" :
                    storeLink = Constants.WINSTORELINK;
                    break;
                //case "Blackberry" :
                //    storeLink = Constants.BLACKBERRYSTORELINK;
                //    break;
                default :
                    //take the user to a mobile web page where they explicitly choose their store
                    break;

            }

            return Redirect(storeLink);
        }
	}
}