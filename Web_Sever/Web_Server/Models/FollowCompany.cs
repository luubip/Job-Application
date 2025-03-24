using System.ComponentModel.DataAnnotations;

namespace Web_Server.Models
{
    public class FollowCompany
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public User User { get; set; }
        public Company Company { get; set; }
    }
}
