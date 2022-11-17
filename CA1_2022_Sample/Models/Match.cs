using System.ComponentModel.DataAnnotations;

namespace CA1_2022_Sample.Models
{
    public class Match
    {
        /*  NB Value types (such as decimal, int, float, DateTime) are inherently required (because they are non-null types)
         *   and don't need the [Required] attribute.
         *   If you want to make them NOT required make them nullable (e.g int?)
         */
        public int MatchID { get; set; }

        [Display(Name = "Match Date")]
        public DateTime MatchDate { get; set; }

        [Required]
        [StringLength(maximumLength:100,MinimumLength =2)]
        public string Opponent { get; set; } = "";

        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Venue { get; set; } = "";

        
        //I've used int? below to enure Goals for and Goals agaist are not required 
        //If i used int, it means they are required

        [Display(Name = "Goals For")]
        [Range(0,50, ErrorMessage = "Max number of goals allowed is 50")]
        public int? GoalsFor { get; set; }

        
        [Display(Name = "Goals Against")]
        [Range(0, 50, ErrorMessage = "Max number of goals allowed is 50")]
        public int? GoalsAgainst { get; set; }
    }
}
