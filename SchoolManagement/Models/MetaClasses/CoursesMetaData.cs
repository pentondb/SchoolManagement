using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models
{
    public class CoursesMetaData
    {
        /**
         Changed the namespace from SchoolManagement.Models.MetaClasses to SchoolManagement.Models, so that the partial class will be associated with the full class in the same namespace.
         */
        /**
         * Creating a meta-data class to be related to the Course.cs class in the EDMX-related folder,
         * so that the data annotations applied in this meta-data class are not wiped out when the database model is refreshed from the database.
         */
        [Required, StringLength(50)]
        public string Title { get; set; }

        [Required, Range(1, 8)]
        public int Credits { get; set; }
    }

    [MetadataType(typeof(CoursesMetaData))]
    public partial class Course
    {

    }
}