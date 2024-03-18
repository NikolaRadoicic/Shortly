using System.ComponentModel.DataAnnotations;

namespace Shortly.Client.Data.ViewModels
{
    public class PostUrlVM
    {
        [Required(ErrorMessage = "Url is required")]
        [RegularExpression(@"^https?://(?:www\.)?[a-zA-Z0-9-]+(?:\.[a-zA-Z]{2,})+(?:/\S*)?$", ErrorMessage = "The value is not a valid URL")]
        public string Url { get; set; }
    }
}
