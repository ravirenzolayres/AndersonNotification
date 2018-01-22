using AndersonNotificationEntity;
using System.Data.Entity;

namespace AndersonNotificationContext
{
    public class DBInitializer : CreateDatabaseIfNotExists<Context>
    {
        public DBInitializer()
        {
        }
        protected override void Seed(Context context)
        {
            var Notifications = context.Notifications.Add(
                new ENotification
                {
                    Receiver = "notification@testing.com",
                    Sender = "notification@testing.com",
                    Subject = "Testing",
                    Body = "notification@testing.com",
                });
            context.SaveChanges();

        }
    }
}