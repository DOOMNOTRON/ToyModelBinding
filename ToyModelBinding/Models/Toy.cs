using System.ComponentModel.DataAnnotations;

namespace ToyModelBinding.Models
{

    // Validate Data

    /// <summary>
    /// Represent a toy to be added
    /// </summary>
    public class Toy
    {
        /// <summary>
        /// Represents the name of the toy
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Product Name")]
        public string Title { get; set; } // add ? next to type to make nullable

        /// <summary>
        /// A desciption of the toy
        /// </summary>
        [Display(Name = "Toy Description")]
        public string? Description { get; set; }// Not required

        /// <summary>
        /// The comic line the toy belongs to.
        /// </summary>
        [Display(Name = "Comic Line")]
        public string? Series { get; set; }

        /// <summary>
        /// The species that the toy is.
        /// </summary>
        [Display(Name = "Species")]
        public string? Species { get; set; }

        /// <summary>
        /// The Accessories that come woth the toy
        /// </summary>
        [Display(Name = "Accessories")]
        public string? Accessories { get; set; }


        /// <summary>
        /// Represents the MSRP of the Toy
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]//does not show up.Fixed neede to add the jquery script.
        [Display(Name = "MSRP")]
        [Range(0, double.MaxValue, ErrorMessage = "MSRP must be positive")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }


        /// <summary>
        /// Represents the current Quantity in stock
        /// </summary>
        [Range(0, double.MaxValue, ErrorMessage = "Quantity must be positive")]
        [Required(ErrorMessage = "This field is required.")]
        public int Quantity { get; set; }
    }
}
