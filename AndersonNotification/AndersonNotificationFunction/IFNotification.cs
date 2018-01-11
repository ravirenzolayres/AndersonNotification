using AndersonNotificationModel;
using System.Collections.Generic;

namespace AndersonNotificationFunction
{
    public interface IFNotification
    {
        #region Create
        Notification Create(int createdBy, Notification notification);
        #endregion

        #region Read
        Notification Read(int notificationId);
        List<Notification> Read(string sortBy);

        #endregion

        #region Update
        Notification Update(int updatedBy, Notification notification);
        #endregion

        #region Delete
        void Delete(int emailId);
        #endregion

        #region Other Function

        #endregion
    }
}
