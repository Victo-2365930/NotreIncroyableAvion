namespace Bibliotheque
{
    /// <summary>
    /// Un avion
    /// </summary>
    public class Avion : IComparable<Avion>, IEquatable<Avion>
    {
        #region Variables

        private uint _id;
        private string _modele;
        private List<Habitacle> _habitacles;

        #endregion

        #region Constructeurs

        public Avion(uint id, string modele, List<Habitacle> habitacles)
        {
            Id = id;
            Modele = modele;
            Habitacles = habitacles;
        }

        #endregion

        #region Interfaces

        /// <summary>
        /// Interface IComparable
        /// </summary>
        /// <param name="other">L'autre avion à comparer</param>
        /// <returns>Classe les avions par id</returns>
        public int CompareTo(Avion? other)
        {
            if (other is null) return 1;
            if (ReferenceEquals(this, other)) return 0;
            return (this._id.CompareTo(other._id));
        }

        /// <summary>
        /// Interface IEquatable
        /// </summary>
        /// <param name="other">L'autre avion à comparer</param>
        /// <returns>Vrai si les avions sont identiques sur leur id, leur modele et leur liste d'habitacle. Sinon faux</returns>
        public bool Equals(Avion? other)
        {
            if (other is null) return false;
            if (ReferenceEquals (this, other)) return true;
            return (this._id.Equals(other._id) && this._modele.Equals(other._modele) && this._habitacles.Equals(other._habitacles));
        }

        #endregion

        #region Accesseurs

        public uint Id { get => _id; set => _id = value; }
        public string Modele { get => _modele; set => _modele = value; }
        public List<Habitacle> Habitacles { get => _habitacles; set => _habitacles = value; }

        #endregion
    }
}
