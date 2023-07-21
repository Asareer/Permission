using Microsoft.AspNetCore.Identity;
using NewP.Contants;

namespace NewP.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(RoleManager<IdentityRole> roleManger)
        {
            if (roleManger.Roles.Any())
            {
                await roleManger.CreateAsync(new IdentityRole(Roles.SuperAdmin.ToString()));
               // await roleManger.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
                await roleManger.CreateAsync(new IdentityRole(Roles.Basic.ToString()));
            }
        }
    }
}
