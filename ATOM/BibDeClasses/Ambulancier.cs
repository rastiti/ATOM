using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibDeClasses
{
    public class Ambulancier
    {
        private int m_id;
        private String m_nom;
        private String m_prenom;

        public int id { get { return m_id; }private set { m_id = value; } }
        public String prenom { get { return m_prenom; }private set { m_prenom = value; } }
        public String nom { get { return m_nom; }private set { m_nom = value; } }

        public Ambulancier (String nom,String prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
    }
}