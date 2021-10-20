
namespace project_web_form.context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_student
    {

        public int ID { get; set; }
        [Required(ErrorMessage = "Required")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Required")]

        public string Fname { get; set; }
        [Required(ErrorMessage = "Required")]
        [EmailAddress(ErrorMessage = "'@email.com' is missing.")]


        public string Email { get; set; }


        [Required(ErrorMessage = "Required")]
        [MinLength(11, ErrorMessage = "mobile no should be 11 digits")]

        public string Mobile { get; set; }
            

        
        public string Descritipion { get; set; }

    }
}
