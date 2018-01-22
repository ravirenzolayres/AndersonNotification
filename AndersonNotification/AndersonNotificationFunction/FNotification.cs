using AndersonNotificationData;
using AndersonNotificationEntity;
using AndersonNotificationModel;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AndersonNotificationFunction
{
    public class FNotification : IFNotification
    {
        private IDNotification _iDNotification;

        public FNotification(IDNotification iDNotifications)
        {
            _iDNotification = iDNotifications;
        }

        public FNotification()
        {
            _iDNotification = new DNotification();

        }
        #region Create
        public Notification Create(int createdBy, Notification notification)
        {   
            var eNotification = ENotification(notification);
            eNotification.CreatedDate = DateTime.Now;
            eNotification.CreatedBy = createdBy;
            eNotification = _iDNotification.Insert(eNotification);
            return Notification(eNotification);
        }
        #endregion

        #region Read
        public Notification Read(int notificationId)
        {
            var eNotification = _iDNotification.Read<ENotification>(a => a.NotificationId == notificationId);
            return Notification(eNotification);
        }

        public List<Notification> Read(string sortBy)
        {
            var eNotifications = _iDNotification.Read<ENotification>(a => true, sortBy);
            return Notifications(eNotifications);
        }
        #endregion

        #region Update
        public Notification Update(int updatedBy, Notification notification)
        {
            var eNotification = ENotification(notification);
            eNotification.UpdatedDate = DateTime.Now;
            eNotification.UpdatedBy = updatedBy;
            eNotification = _iDNotification.Update(eNotification);
            return Notification(eNotification);
        }
        #endregion

        #region Delete
        public void Delete(int notificationId)
        {
            _iDNotification.Delete<ENotification>(a => a.NotificationId == notificationId);
        }
        #endregion

        #region Other Function
        private ENotification ENotification(Notification notification)
        {
            return new ENotification
            {
                CreatedDate = notification.CreatedDate,
                UpdatedDate = notification.UpdatedDate,

                CreatedBy = notification.CreatedBy,
                UpdatedBy = notification.UpdatedBy,

                NotificationId = notification.NotificationId,
                Sender = notification.Sender,
                Body = notification.Body,
                Receiver = notification.Receiver,
            };
        }

        private Notification Notification(ENotification eNotification)
        {
            return new Notification
            {
                CreatedDate = eNotification.CreatedDate,
                UpdatedDate = eNotification.UpdatedDate,

                CreatedBy = eNotification.CreatedBy,
                UpdatedBy = eNotification.UpdatedBy,

                NotificationId = eNotification.NotificationId,
                Sender = eNotification.Sender,
                Body = eNotification.Body,
                Receiver = eNotification.Receiver,
            };
        }
        private List<Notification> Notifications(List<ENotification> eNotifications)
        {
            return eNotifications.Select(a => new Notification
            {
                CreatedDate = a.CreatedDate,
                UpdatedDate = a.UpdatedDate,

                CreatedBy = a.CreatedBy,
                UpdatedBy = a.UpdatedBy,

                NotificationId = a.NotificationId,
                Sender = a.Sender,
                Body = a.Body,
                Receiver = a.Receiver,


            }).ToList();
        }
        #endregion

    }
}