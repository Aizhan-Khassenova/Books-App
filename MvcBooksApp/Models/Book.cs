namespace MvcBooksApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int Id { get; set; }

        [StringLength(15)]
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        [Display(Name = "���������")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "�������� ������")]
        public int? AuthorId { get; set; }

        [Required]
        [Display(Name = "�������� ���������")]
        public int? CategoryId { get; set; }

        [Required]
        [Display(Name = "���������� �������")]
        [Range(3,9999)]
        public int? Pages { get; set; }

        [Required]
        [Display(Name = "����")]
        [Range(10, 999999)]
        public int? Cost { get; set; }

        public virtual Author Author { get; set; }

        public virtual Category Category { get; set; }
    }
}
