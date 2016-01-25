using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibDeClasses
{
    public class Patient
    {

        private int m_id;
        private int m_nss;
        private String m_nom;
        private String m_prenom;
        private DateTime m_dateNaissance;
        private float m_poids;
        private float m_taille;
        private String m_infos;


        public int id { get { return m_id; } private set { m_id = value; } }
        public int nss { get { return m_nss; }private set { m_nss = value; } }
        public String nom { get { return m_nom; } private set { m_nom = value; } }
        public String prenom { get { return m_prenom; } private set { m_prenom = value; } }
        public DateTime dateNaissance { get { return m_dateNaissance; } private set { m_dateNaissance = value; } }
        public float poids { get { return m_poids; }private set { m_poids = value; } }
        public float taille { get { return m_taille; } private set { m_taille = value; } }
        public String infos { get { return m_infos; } private set { m_infos = value; } }

        public Patient (int id,int nss,String nom,String prenom,DateTime date,float poids,float taille,String infos)
        {
            this.id = id;
            this.nss = nss;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = date;
            this.poids = poids;
            this.taille = taille;
            this.infos = infos;
        }



    }
}
