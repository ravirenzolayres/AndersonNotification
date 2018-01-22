using AndersonNotificationContext;
using AndersonNotificationEntity;
using BaseData;
using System.Collections.Generic;
using System.Linq;

namespace AndersonNotificationData
{
    public class DNotification : DBase, IDNotification
    {
        public DNotification() : base(new Context())
        {
        }
        #region Create
        #endregion

        #region Read
        //public List<ENotification> Read()
        //{
        //    using (var context = new Context())
        //    {
        //        return context.Notifications
        //            .Include(a => a.CredentialRoles)
        //            .Include(a => a.CredentialRoles.Select(b => b.Role))
        //            .OrderBy(a => a.Username)
        //            .ToList();
        //    }
        //}
            #endregion

            #region Update
            #endregion

            #region Delete
            #endregion

            #region Other Function
            #endregion
        }
}