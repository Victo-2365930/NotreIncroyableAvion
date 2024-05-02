using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    /// <summary>
    /// Une rangée de l'habitacle
    /// </summary>
    public class Rangee : IComparable<Rangee>, IEquatable<Rangee>
    {
        private List<Section> _sections;
        private string _classe;
        private uint _numeroRangee;

        /// <summary>
        /// Constructeur de la rangée
        /// </summary>
        /// <param name="sections">la liste de sections de l'habitacle</param>
        /// <param name="classe">La classe de la rangée, doit être Economic ou UnitedFirst</param>
        /// <param name="numeroRangee">numero de la rangée</param>
        public Rangee(List<Section> sections, string classe, uint numeroRangee) 
        {
            Sections = sections;
            Classe = classe;
            NumeroRangee = numeroRangee;
        }

        /// <summary>
        /// Méthode de comparaison entre deux rangées
        /// </summary>
        /// <param name="other">Une autre rangée</param>
        /// <returns>-1 si plus petit, 0 si le même et 1 si plus grand</returns>
        public int CompareTo(Rangee? other)
        {
            if(other is null)
                return 1;

            return (this._numeroRangee.CompareTo(other._numeroRangee)*2 + this._classe.CompareTo(other._classe));
        }

    /// <summary>
    /// Méthode pour savoir si deux rangées sont pareils
    /// </summary>
    /// <param name="other">une autre rangée</param>
    /// <returns>true si égal, false is différents</returns>
        public bool Equals(Rangee? other)
        {
            if (other is null) 
                return false;
            if (object.ReferenceEquals(this, other))
                return true;
            return(this._numeroRangee == other._numeroRangee);
        }


        #region  Accesseurs
        /// <summary>
        /// Accesseur de la Liste de Section
        /// </summary>
        public List<Section> Sections 
        { 
            get => _sections;
            private set
            {
                _sections = value;
            }
        }

        /// <summary>
        /// Accesseur de la string classe
        /// </summary>
        public string Classe 
        { 
            get => _classe;
            private set 
            {
                if(value is null)
                    throw new ArgumentNullException($"La classe ne peut être null");
                if (value != "Economic" || value != "UnitedFirst")
                    throw new ArgumentException("La Classe doit être Economic ou UnitedFirst");
                _classe = value;
            }
        }
        /// <summary>
        /// Accesseur du numero de Rangée
        /// </summary>
        public uint NumeroRangee 
        { 
            get => _numeroRangee; 
            private set => _numeroRangee = value; 
        }

       
        #endregion 
    }
}
