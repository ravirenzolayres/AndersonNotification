using ExternalAccountWebAuthentication.Authentication;
using ExternalAccountWebAuthentication.Controller;

namespace AndersonNotificationWeb.Controllers
{
    [MvcAuthorizationFilterAttribute(false, "Credential", "Login", new string[] { "AndersonNotificationAdministrator" })]
    public class BaseController : ExternalAccountBaseController
    {
    }
}