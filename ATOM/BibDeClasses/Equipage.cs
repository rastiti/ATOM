using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibDeClasses
{
    public class Equipage
    {

        //De meme pour les id que la classe Demande

        private int m_id;
        private int m_idVehicule;
        private int m_idAmbulancier;
        private DateTime m_dateCreation;
          
        public int id { get { return m_id; }private set { m_id = value; } }
        public int idVehicule { get { return m_idVehicule; }private set { m_idVehicule = value; } }
        public int idAmbulancier { get { return m_idAmbulancier; }private set { m_idAmbulancier = value; } }
        public DateTime dateCreation { get { return m_dateCreation; }private set { m_dateCreation = value; } }

        
    }
}
