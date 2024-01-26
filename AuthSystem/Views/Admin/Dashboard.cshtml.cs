using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AuthSystem.Areas.Identity.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
namespace AuthSystem.Views.Admin
{
    public class DashboardModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<DashboardModel> _logger;

        public DashboardModel(SignInManager<ApplicationUser> signInManager, ILogger<DashboardModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }
        public class InputModel
        {
            [DataType(DataType.Text)]
            public string CompanyName { get; set; }

            [DataType(DataType.Text)]
            public string FirstName { get; set; }

            [DataType(DataType.Text)]
            public string LastName { get; set; }

            [DataType(DataType.Text)]
            public string Color { get; set; }


            [DataType(DataType.Text)]
            public string Designation { get; set; }

            [DataType(DataType.Text)]
            public string AboutMe { get; set; }

            
        }
        public void OnGet()
        {
        }
    }
}
