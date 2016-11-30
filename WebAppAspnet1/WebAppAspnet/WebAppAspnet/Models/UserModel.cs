using System.ComponentModel.DataAnnotations;

namespace WebAppAspnet.Models
{
    public class UserModel
    {
        public int idAd { get; set;}
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"(\S)+", ErrorMessage = "ERROR")]
        [Display(Name = "Заглавие")]
        public string adTitle { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Подтвержденный")]
        public string adConfirm { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Дата публикации")]
        public string adDatePublic { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Текст")]
        public string adText { get; set; }

        public int idRubric { get; set; }
    }
}