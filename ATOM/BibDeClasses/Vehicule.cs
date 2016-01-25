using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibDeClasses
{
    public class Vehicule
    {
        private int m_id;
        private bool m_disponible;
        private TypeTransport m_type;

        public int id { get { return m_id;}private set { m_id = value; } }
        public bool disponible { get { return m_disponible; }private set { m_disponible = value; } }
        public TypeTransport type { get { return m_type; }private set { m_type = value; } }

        public Vehicule(TypeTransport type)
        {
            this.disponible = true;
            this.type = type;
        }

        

       
    }
}
