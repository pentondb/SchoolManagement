using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class LecturersMetaData
    {
        [StringLength(50), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50), Display(Name = "Last Name")]
        public string LastName { get; set; }
    }

    [MetadataType(typeof(LecturersMetaData))]
    public partial class Lecturers
    {

    }
}