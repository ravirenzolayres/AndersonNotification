using AndersonNotificationData;
using AndersonNotificationEntity;
using AndersonNotificationModel;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AndersonNotificationFunction
{
    public class FEmailNotification : IFEmailNotification
    {
        private IDEmailNotification _iDNotification;

        public FEmailNotification(IDEmailNotification iDNotifications)
        {
            _iDNotification = iDNotifications;
        }


        public FEmailNotification()
        {
            _iDNotification = new DEmailNotification();

        }
        #region Create
        public EmailNotification Create(int createdBy, EmailNotification notification)
        {   
            var eNotification = ENotification(notification);
            eNotification.CreatedDate = DateTime.Now;
            eNotification.CreatedBy = createdBy;
            eNotification = _iDNotification.Insert(eNotification);
            return Notification(eNotification);
        }
        #endregion

        #region Read
        public EmailNotification Read(int emailNotificationId)
        {
            var eNotification = _iDNotification.Read<EEmailNotification>(a => a.EmailNotificationId == emailNotificationId);
            return Notification(eNotification);
        }

        public List<EmailNotification> Read(string sortBy)
        {
            var eNotifications = _iDNotification.Read<EEmailNotification>(a => true, sortBy);
            return Notifications(eNotifications);
        }
        #endregion

        #region Update
        public EmailNotification Update(int updatedBy, EmailNotification notification)
        {
            var eNotification = ENotification(notification);
            eNotification.UpdatedDate = DateTime.Now;
            eNotification.UpdatedBy = updatedBy;
            eNotification = _iDNotification.Update(eNotification);
            return Notification(eNotification);
        }
        #endregion

        #region Delete
        public void Delete(int emailNotificationId)
        {
            _iDNotification.Delete<EEmailNotification>(a => a.EmailNotificationId == emailNotificationId);
        }
        #endregion

        #region Other Function
        private EEmailNotification ENotification(EmailNotification notification)
        {
            return new EEmailNotification
            {
                CreatedDate = notification.CreatedDate,
                UpdatedDate = notification.UpdatedDate,

                CreatedBy = notification.CreatedBy,
                UpdatedBy = notification.UpdatedBy,

                EmailNotificationId = notification.EmailNotificationId,
                Sender = notification.Sender,
                Body = notification.Body,
                Receiver = notification.Receiver,
            };
        }

        private EmailNotification Notification(EEmailNotification eNotification)
        {
            return new EmailNotification
            {
                CreatedDate = eNotification.CreatedDate,
                UpdatedDate = eNotification.UpdatedDate,

                CreatedBy = eNotification.CreatedBy,
                UpdatedBy = eNotification.UpdatedBy,

                EmailNotificationId = eNotification.EmailNotificationId,
                Sender = eNotification.Sender,
                Body = eNotification.Body,
                Receiver = eNotification.Receiver,
            };
        }
        private List<EmailNotification> Notifications(List<EEmailNotification> eNotifications)
        {
            return eNotifications.Select(a => new EmailNotification
            {
                CreatedDate = a.CreatedDate,
                UpdatedDate = a.UpdatedDate,

                CreatedBy = a.CreatedBy,
                UpdatedBy = a.UpdatedBy,

                EmailNotificationId = a.EmailNotificationId,
                Sender = a.Sender,
                Body = a.Body,
                Receiver = a.Receiver,


            }).ToList();
        }
        #endregion

    }
}