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
    public class Section : Rangee
    {
        private List<Siege> _sieges;
        private string _position;
    }
}
