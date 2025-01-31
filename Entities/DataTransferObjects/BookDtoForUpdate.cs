﻿

using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public record BookDtoForUpdate : BookDtoForManipulation
    {
        [Required]
        public int Id { get; set; }
        public String Title { get; set; }
        public decimal Price { get; set; }
    }
}
