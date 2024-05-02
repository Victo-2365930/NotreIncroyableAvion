using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    /// <summary>
    /// Un siège de la section
    /// </summary>
    public class Siege : IComparable<Siege>, IEquatable<Siege>
    {
        private Passager _passager;
        private char _lettre;

        #region Constructeurs

        /// <summary>
        /// Constructeur d'un siège sans passager
        /// </summary>
        /// <param name="lettre">La lettre attribuée au siège</param>
        public Siege(char lettre)
        {
            Passager = null;
            Lettre = lettre;
        }

        #endregion

        #region Interfaces

        /// <summary>
        /// Interface IComparable
        /// </summary>
        /// <param name="other">L'autre siège à comparer</param>
        /// <returns>Classe les sièges par leur lettre</returns>
        public int CompareTo(Siege? other)
        {
            if (other == null) return 1;
            if (object.ReferenceEquals(this, other)) return 0;
            return _lettre.CompareTo(other._lettre);
        }

        /// <summary>
        /// Interface IEquatable
        /// </summary>
        /// <param name="other">L'autre siège à comparer</param>
        /// <returns>Vrai si le numéro du siège et le numero de sa rangée est identique. Sinon faux</returns>
        bool IEquatable<Siege>.Equals(Siege? other)
        {
            if (other is null) return false;
            if (object.ReferenceEquals(this, other)) return true;
            return (this._lettre.Equals(other._lettre));
        }

        #endregion

        #region Accesseurs

        /// <summary>
        /// Accesseur Passager
        /// </summary>
        public Passager Passager 
        { 
            get => _passager; 
            private set => _passager = value; 
        }

        /// <summary>
        /// Accesseur Lettre
        /// </summary>
        public char Lettre
        { 
            get => _lettre;
            private set
            {
                if (value.ToString().ToUpper().ToCharArray()[0] < 'A' || value.ToString().ToUpper().ToCharArray()[0] > 'Z')
                    throw new ArgumentOutOfRangeException("Le caractère de la lettre doit se trouver entre A et Z");
                _lettre = value;
            }
        }

        #endregion
    }
}