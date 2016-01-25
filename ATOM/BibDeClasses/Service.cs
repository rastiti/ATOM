using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibDeClasses
{
    public class Service
    {
        private int m_id;
        private String m_libelle;
        private int m_numrue;
        private String m_rue;
        private String m_ville;
        private int m_codepostal;
        private String m_complementAdresse;
        private bool m_complet;
        private String m_infossupp;
        public ObservableCollection<Patient> listPatient = new ObservableCollection<Patient>();



        public int id { get { return m_id; }private set { m_id = value; } }
        public String libelle { get { return m_libelle; }private set { m_libelle = value; } }
        public int numrue { get { return m_numrue; }private set { m_numrue = value; } }
        public String rue { get { return m_rue; }private set { m_rue = value; } }
        public String ville { get { return m_ville; }private set { m_ville = value; } }
        public int codePostal { get { return m_codepostal; }private set { m_codepostal = value; } }
        public String complementAdresse { get { return m_complementAdresse; }private set { m_complementAdresse = value; } }
        public bool complet { get { return m_complet; }private set { m_complet = value; } }
        public String infossupp { get { return m_infossupp; }private set { m_infossupp = value; } }

        
        public Service (String libelle,int numrue,String rue,String ville,int codePostal,String complementAdresse,String infossupp)
        {
            this.libelle = libelle;
            this.numrue = numrue;
            this.rue = rue;
            this.ville = ville;
            this.codePostal = codePostal;
            this.complementAdresse = complementAdresse;
            this.infossupp = infossupp;
            this.complet = false;
        }


    }
}
