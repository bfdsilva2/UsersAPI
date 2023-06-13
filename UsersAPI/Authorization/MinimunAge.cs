using Microsoft.AspNetCore.Authorization;

namespace UsersAPI.Authorization
{
    public class MinimunAge : IAuthorizationRequirement
    {
        public MinimunAge(int age)
        {
            Idade = age;
            
        }

        public int Idade { get; set; }
    }
}
