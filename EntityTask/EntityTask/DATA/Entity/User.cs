using System.Collections.Generic;

namespace EntityTask.DATA.Entity
{
    public class User
    {
        public int id {  get; set; }    
        public string UserName {  get; set; }

        public ICollection<UserProduct> UserProducts { get; set; } = new List<UserProduct>();
    }
}
