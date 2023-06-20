using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AdvancedProgramming_Lesson1.Models.bookshelf
{
    public class Genre
    {
        [Display(Name = "#")]
        public int Id { get; set; }



        [Required(ErrorMessage = "Nazwa wymagana")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }






        [Display(Name = "Data")]
        [Required(ErrorMessage = "Data wymagana")]
        [DataType(DataType.Date)]
        public DateTime Release { get; set; }



        [Display(Name = "Motyw")]
        [Required(ErrorMessage = "Motyw wymagany")]
        public string Themes { get; set; }






        [Display(Name = "Popularność")]
        [Required(ErrorMessage = "Popularność jest wymagana")]
        [Range(1, 5, ErrorMessage = "Nieprawidłowa popularność")]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Popularity { get; set; }





        [Display(Name = "Ilość książek")]
        [Required(ErrorMessage = "ilośc wymagana")]
        public int AmountOfBooks { get; set; }
    }
}
