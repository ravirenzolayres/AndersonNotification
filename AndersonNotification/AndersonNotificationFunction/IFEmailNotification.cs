using AndersonNotificationModel;
using System.Collections.Generic;

namespace AndersonNotificationFunction
{
    public interface IFEmailNotification
    {
        #region Create
        EmailNotification Create(int createdBy, EmailNotification notification);
        #endregion

        #region Read
        EmailNotification Read(int notificationId);
        List<EmailNotification> Read(string sortBy);
        #endregion

        #region Update
        EmailNotification Update(int updatedBy, EmailNotification notification);
        #endregion

        #region Delete
        void Delete(int emailId);
        #endregion

        #region Other Function

        #endregion
    }
}
