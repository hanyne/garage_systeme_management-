//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp3
{
    using System;
    using System.Collections.Generic;
    
    public partial class LigneReparation
    {
        public int Id { get; set; }
        public int Quantite { get; set; }
        public int ReparationID { get; set; }
        public int PieceDetacheID { get; set; }
    
        public virtual PiecesDetachees PiecesDetachees { get; set; }
        public virtual Reparations Reparations { get; set; }
    }
}