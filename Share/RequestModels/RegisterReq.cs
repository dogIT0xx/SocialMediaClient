using System.ComponentModel.DataAnnotations;

namespace SocialMediaClient.Share.RequestModels
{
    public sealed class SignInReq
    {
        [Required]
        [EmailAddress]
        public string Email { get; init; }

        [Required]
        public string UserName { get; init; }

        [Required]
        public string Password { get; init; }

        
        [Required]
        public string ConfirmPassword { get; init; }
    }
}
