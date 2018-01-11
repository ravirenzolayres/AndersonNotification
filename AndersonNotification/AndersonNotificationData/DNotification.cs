using AndersonNotificationContext;
using BaseData;

namespace AndersonNotificationData
{
    public class DNotification : DBase, IDNotification
    {
        public DNotification() : base(new Context())
        {
        }
    }
}