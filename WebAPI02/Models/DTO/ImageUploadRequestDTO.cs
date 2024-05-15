using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
namespace WebAPI02.Models.DTO
{
    public class ImageUploadRequestDTO
    {
        [Required]
        public IFormFile? File { get; set; }
        [Required]
        public string? FileNames { get; set; }
        public string? FileDescription { get; set; }
    }
}
