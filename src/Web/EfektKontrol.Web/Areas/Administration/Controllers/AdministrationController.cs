namespace EfektKontrol.Web.Areas.Administration.Controllers
{
    using EfektKontrol.Common;
    using EfektKontrol.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
