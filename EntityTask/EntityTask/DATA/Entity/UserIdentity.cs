using Microsoft.AspNetCore.Identity;

namespace EntityTask.DATA.Entity
{
    public class UserIdentity :IdentityUser<int>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string FinCode { get; set; }
    }
}
