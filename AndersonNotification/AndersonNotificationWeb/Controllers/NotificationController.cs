using AndersonNotificationFunction;
using AndersonNotificationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AccountExternalFunction;
using AccountExternalModel;
using ExternalAccountWebAuthentication.Authentication;

namespace AndersonNotificationWeb.Controllers
{
    public class NotificationController : BaseController
    {
        private IFNotification _iFNotification;
        public NotificationController(IFNotification iFNotification)
        {
            _iFNotification = iFNotification;
        }

        #region Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Notification());
        }

        [HttpPost]
        public ActionResult Create(Notification notification)
        {
            var createdNotification = _iFNotification.Create(CredentialId,notification);
            return RedirectToAction("Index");
        }
        #endregion

        #region Read
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region Update
        #endregion

        #region Delete
        #endregion

        #region Other Function
        #endregion
    }
}