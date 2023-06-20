using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedProgramming_Lesson1.Models.bookshelf
{
    public class book
    {
        [Display(Name = "#")]
        public int Id { get; set; }





        [Required(ErrorMessage ="Nazwa wymagana")]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }



        [Display(Name = "Rok wydania")]
        [Required(ErrorMessage = "Rok wymagany")]
        [Range(1, int.MaxValue,ErrorMessage ="Nieprawidłowy Rok")]
        public int Year { get; set; }



        [Display(Name = "Gatunek")]
        [Required(ErrorMessage = "Gatunek wymagany")]
        public int GenreID { get; set; }


        [Display(Name = "Gatunek")]
        public Genre Genre { get; set; }




        [Display(Name = "Autor")]
        [Required(ErrorMessage = "Autor wymagany")]
        public int AuthorID { get; set; }




        [Display(Name = "Autor")]
        public Author Author { get; set; }





        [Display(Name = "Ilość Stron")]
        [Required(ErrorMessage = "Ilość Stron wymagana")]
        [Range(1, int.MaxValue, ErrorMessage = "Nieprawidłowa Liczba Stron")]
        public int Pages { get; set; }





        [Display(Name = "Cena")]
        [Required(ErrorMessage = "Cena wymagana")]
        [Range(1, int.MaxValue, ErrorMessage = "Nieprawidłowa Cena")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }


    }
}
