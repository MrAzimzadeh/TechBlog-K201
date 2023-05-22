namespace TechBlog.Web.Models
{
    public class Article : BaseEntity
    {
       
        public string Title { get; set; }
        public string Content { get; set; }
        public string PhotoUrl { get; set; }
        public int Views { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public string SeoUrl { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
