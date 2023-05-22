using System.ComponentModel.DataAnnotations;

namespace TechBlog.Web.Models
{
    public class ArticleTags : BaseEntity
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
