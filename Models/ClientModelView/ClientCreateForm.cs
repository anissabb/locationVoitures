using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Location_voitures.Models.ClientModelView
{
    public class ClientCreateForm
    {
        [Required]
        [DisplayName("Nom de famille:")]
        public string Nom { get; set; }

        [Required]
        [DisplayName("Prénom:")]
        public string Prenom { get; set; }

        [Required]
        [DisplayName("Date de naissance:")]
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }

        [Required]
        [DisplayName("Adresse mail:")]
        [EmailAddress]
        public string AdresseMail { get; set; }

        [Required]
        [DisplayName("Mot de passe:")]
        [DataType(DataType.Password)]
        public string MotdePasse { get; set; }

        [Required]
        [DisplayName("Confirmer le mot de passe:")]
        [DataType(DataType.Password)]
        [Compare(nameof(MotdePasse))]
        public string ConfirmMotdePasse { get; set; }


    }
}
