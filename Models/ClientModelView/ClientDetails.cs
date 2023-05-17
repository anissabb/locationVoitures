using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Location_voitures.Models.ClientModelView
{
    public class ClientDetails
    {
        

        [DisplayName("Nom:")]
        public string Nom { get; set; }

        [DisplayName("Prénom:")]
        public string Prenom { get; set; }

        [DisplayName("Adresse mail:")]
        public string AdresseMail { get; set; }


        [DisplayName("Date de naissance:")]
        public DateTime DateNaissance { get; set; }

        [DisplayName("Mot de passe:")]
        public string MotdePasse { get; set; }



    }
}
