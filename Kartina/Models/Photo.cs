//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kartina.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Photo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int IdVendeur { get; set; }
    
        public virtual Vendeur Vendeur { get; set; }
    }
}