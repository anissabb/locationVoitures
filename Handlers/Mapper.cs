using Location_voitures.Models.ClientModelView;
using Location_voitures.Models.VoitureModelView;
using Location_voitures_BLL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location_voitures.Handlers
{
    public static class Mapper
    {

        //permettra de convertir les données de l'asp au BLL

        public static Client ToBLL (this ClientCreateForm entity)
        {
            if (entity is null) return null;
            return new Client()
            {
                
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                AdresseMail = entity.AdresseMail,
                DateNaissance = entity.DateNaissance,
                MotdePasse = entity.MotdePasse
            };
        }
        public static ClientDetails ToDetails(this Client entity)
        {
            if (entity is null) return null;
            return new ClientDetails()
            {

                Nom = entity.Nom,
                Prenom = entity.Prenom,
                AdresseMail = entity.AdresseMail,
                DateNaissance = entity.DateNaissance,
                MotdePasse = entity.MotdePasse
            };
        }

        public static ClientCompte ToClientCompte(this Client entity)
        {
            if (entity is null) return null;
            return new ClientCompte()
            {

                Nom = entity.Nom,
                Prenom = entity.Prenom,
                AdresseMail = entity.AdresseMail,
                DateNaissance = entity.DateNaissance,
                MotdePasse = entity.MotdePasse
            };
        }


        // Voiture


        public static Voiture toBLL(this VoitureCreateForm entity)
        {
            if (entity is null) return null;
            return new Voiture()
            {

               
                Marque = entity.Marque,
                Modele = entity.Modele,
                Matricule = entity.Matricule,
                Puissance = entity.Puissance,
                Couleur = entity.Couleur,
                Categorie = entity.Categorie,
                CoutParJour = entity.CoutParJour,
                Image = entity.Image
            };
        }
   
    }
}
