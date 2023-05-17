using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Location_voitures.Models.VoitureModelView
{
    public class VoitureCreateForm
    {

        [DisplayName("Matricule :")]
        public string Matricule { get; set; }
        


        [Required]
        [DisplayName("Marque:")]
        public string Marque { get; set; }

        [Required]
        [DisplayName("Modèle :")]
     
        public string Modele { get; set; }

        [Required]
        [DisplayName("Couleur :")]
        public string Couleur { get; set; }

        [DisplayName("Puissance en ch :")]
        public int Puissance { get; set; }

        [DisplayName("Catégorie :")]
        public string Categorie { get; set; }

        [Required]
        [DisplayName("Coût par jour :")]
        [DataType(DataType.Currency)]
        public int CoutParJour { get; set; }

        [Required]
        [DisplayName("Image :")]
        [DataType(DataType.Upload)]
        
        public string Image { get; set; }
    }
}
