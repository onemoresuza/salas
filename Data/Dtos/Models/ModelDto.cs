using System.ComponentModel.DataAnnotations;
using api_base.Models;

namespace api_base.Data.Dtos.Models
{
    public class ModelDto : Dto<Model>
    {
        [Required]
        public string? Name { get; init; }
    }
}