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
        public string Title { get; set; }

        /// <summary>
        /// Represents the MSRP of the Toy
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Represents the current Quantity in stock
        /// </summary>
        public int Quantity { get; set; }
    }
}
