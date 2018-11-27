using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace persentation_WorkoutR.Models
{  
    public class exerciseModel
    {
       // adding properties to exercise model class
        [DisplayName("Exercise ID")]
        public int exerciseID { get; set; }

        [DisplayName("Exercise Name")]
        [Required]
        public string exerciseName { get; set; }

        [DisplayName("Exercise Description")]
        [Required]
        [StringLength(255)]
        public string exerciseDescription { get; set; }
    }
}