using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace UsersAPI.Authorization
{
    public class AgeAuthorization : AuthorizationHandler<MinimunAge>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimunAge requirement)
        {
            var dateOfBrithClaim = context.User.FindFirst(claim => claim.Type == ClaimTypes.DateOfBirth);

            if (dateOfBrithClaim == null)
                return Task.CompletedTask;

            var dateOfBrith = Convert.ToDateTime(dateOfBrithClaim.Value);

            if (DateTime.Now.AddYears(-18) >= dateOfBrith)
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
