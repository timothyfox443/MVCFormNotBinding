using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFormNotBinding.Models
{
    public class Widget
    {
        /// <summary>
        /// Object name
        /// </summary>
        [Display(Name = "Product Name")]
        [Required(ErrorMessage ="A name is required.")]
        public String objName { get; set; }

        /// <summary>
        /// Object Description
        /// </summary>
        [Display(Name = "Product Description")]
        [Required(ErrorMessage = "A description is required.")]

        public String objDesc { get; set; }

        /// <summary>
        /// Object Unit Weight
        /// </summary>
        [Display(Name = "Product Unit Weight")]
        [Required(ErrorMessage = "A weight in decimal format is required.")]

        public Double objWeight { get; set; }

        /// <summary>
        /// Object Unit Cost to Purchase
        /// </summary>
        [Display(Name = "Product Unit Cost")]
        [Required(ErrorMessage = "A cost in $(USD) is required.")]

        public Double objUnitCost { get; set; }

        /// <summary>
        /// Object Customer Price for Sales
        /// </summary>
        [Display(Name = "Product Customer Price")]
        [Required(ErrorMessage = "A price in $(USD) is required.")]

        public Double objSalePrice { get; set; }
    }
}
