using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Entities
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        [ForeignKey("CityId")]

        //navigation property => used to establish a relationship between two entities
        /* Relationships that are discovered by convention will always target the primary key of 
        the principal entity => the id of the city will be the foreign key in the point of interest table */
        public City? City { get; set; }

        //not required to define the foreign key property on the dependent class, only for clarity
        public int CityId { get; set; }

        public PointOfInterest(string name)
        {
            Name = name;
        }
    }
}
