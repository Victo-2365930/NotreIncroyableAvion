using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    /// <summary>
    /// Un habitacle d'un avion
    /// </summary>
    public class Habitacle: IEquatable<Habitacle>, IComparable<Habitacle>
    {
        private uint _id;
        private List<Range> _rangees;

        /// <summary>
        /// Constructeur de la classe Habitacle
        /// </summary>
        /// <param name="id">numero de l'avion</param>
        /// <param name="rangees">Liste de rangées</param>
        public Habitacle(uint id, List<Range> rangees)
        {
            Id = id;
            Rangees = rangees;
        }

        public int CompareTo(Habitacle? other)
        {
            if (other is null)
                return 1;

            return this._id.CompareTo(other._id);
        }

        public bool Equals(Habitacle? other)
        {
            if (other is null)
                return false;
            if (object.ReferenceEquals(this, other))
                return true;
            return (this._id == other._id);
        }

        #region Accesseurs
        public uint Id 
        { 
            get => _id;
            private set
            {
                _id = value;
            }
        }
        public List<Range> Rangees 
        { 
            get => _rangees; 
            private set => _rangees = value; 
        }

        #endregion
    }
}
