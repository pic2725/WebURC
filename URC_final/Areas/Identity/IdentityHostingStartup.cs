using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using URC_final.Areas.Identity.Data;

[assembly: HostingStartup(typeof(URC_final.Areas.Identity.IdentityHostingStartup))]
namespace URC_final.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserRoleDB_final_Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UserRoleDB_final_ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<UserRoleDB_final_Context>();
            });
        }
    }
}