using Microsoft.AspNetCore.Identity;

namespace TechBlog.Web.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoUrl { get; set; }
        public List<Article> Articles { get; set; }
    }
}
