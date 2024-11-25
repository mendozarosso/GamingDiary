namespace GamingDiary.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string Username { get; set; } = string.Empty;
        
        public string Email { get; set; } = string.Empty;
        
        public string PasswordHash { get; set; } = string.Empty;
        
        public string ProfileImage { get; set; } = "/images/default-profile.png";
        
        public List<GameExperience> Experiences { get; set; } = new();
    }
}