using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    /// <summary>
    /// Une section de la rangée
    /// </summary>
    public class Section : IComparable<Section>, IEquatable<Section>
    {
        #region Variables

        private List<Siege> _sieges;
        private string _position;

        #endregion

        #region Consructeurs

        /// <summary>
        /// Constructeur d'une section
        /// </summary>
        /// <param name="sieges"></param>
        /// <param name="position"></param>
        public Section(List<Siege> sieges, string position)
        {
            _sieges = sieges;
            _position = position;
        }

        #endregion

        #region Interfaces

        /// <summary>
        /// Interface IComparable
        /// </summary>
        /// <param name="other">L'autre section à comparer</param>
        /// <returns>Classe les sections par leur position</returns>
        public int CompareTo(Section? other)
        {
            if (other is null) return 1;
            if (ReferenceEquals(this, other)) return 0;
            return this.Position.CompareTo(other.Position);
        }

        /// <summary>
        /// Interface IEquatable
        /// </summary>
        /// <param name="other">L'autre section à comparer</param>
        /// <returns>Vrai si les deux sections sont identiques sur leur position et leur liste de siège</returns>
        public bool Equals(Section? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return (this.Position == other.Position && this._sieges == other._sieges);
        }

        #endregion

        #region Accesseurs

        /// <summary>
        /// Accessuer Liste de siege
        /// </summary>
        public List<Siege> Sieges { get => _sieges; set => _sieges = value; }

        /// <summary>
        /// Accesseur Position
        /// </summary>
        public string Position { get => _position; set => _position = value; }

        #endregion

    }
}
