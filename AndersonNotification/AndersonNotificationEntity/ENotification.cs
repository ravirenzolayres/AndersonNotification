using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonNotificationEntity
{
    [Table("AndersonNotification")]
    public class ENotification : EBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotificationId { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Receiver { get; set; }
    }
}