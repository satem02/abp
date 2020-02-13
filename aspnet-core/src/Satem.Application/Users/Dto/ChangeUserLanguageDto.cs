using System.ComponentModel.DataAnnotations;

namespace Satem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}