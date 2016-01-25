using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibDeClasses
{
    public class Demande
    {

        // A voir si on laisse idPatient,idServiceEmetteur ... ou si on met une instance de Classe Patient , Service 


        private int m_id;
        private DateTime m_dateDemande;
        private DateTime m_dateTransport;
        private DateTime m_dateAnnulation;
        private int m_idServiceEmetteur;
        private int m_idServiceRecepteur;
        private int m_idPatient;
        private int m_idPersonnelDemandeur;
        private int m_priorite;
        private String m_commentaire;
        private DateTime m_dateDepartPrevue;
        private DateTime m_dateArriveePrevue;
        private int m_idEquipage;
        private int m_idAmbPrivee;
        private int m_idRegulateur;
        private DateTime m_dateDepartReelle;
        private DateTime m_dateArriveeReelle;
        private String m_observation;
        private TypeTransport m_type;
        private ModeTransport m_mode;
        private Contexte m_contexte;
        private ConditionTransport m_condition;
        

        public int id { get { return m_id; }private set { m_id = value; } }
        public DateTime dateDemande { get { return m_dateDemande; } private set { m_dateDemande = value; } }
        public DateTime dateTransport { get { return m_dateTransport; }private set { m_dateTransport = value; } }
        public DateTime dateAnnulation { get { return m_dateAnnulation; }private set { m_dateAnnulation = value; } }
        public int idServiceEmetteur { get { return m_idServiceEmetteur; }private set { m_idServiceEmetteur = value; } }
        public int idServiceRecepteur { get { return m_idServiceRecepteur; }private set { m_idServiceRecepteur = value; } }
        public int idPatient { get { return m_idPatient; }private set { m_idPatient = value; } }
        public int idPersonnelDemandeur { get { return m_idPersonnelDemandeur; } private set { m_idPersonnelDemandeur = value; } }
        public int priorite { get { return m_priorite; }private set { m_priorite = value; } }
        public String commentaire { get { return m_commentaire; } private set { m_commentaire = value; } }
        public DateTime dateDepartPrevue { get { return m_dateDepartPrevue; }private set { m_dateDepartPrevue = value; } }
        public DateTime dateArriveePrevue { get { return m_dateArriveePrevue; }private set { m_dateArriveePrevue = value; } }
        public int idEquipage { get { return m_idEquipage; }private set { m_idEquipage = value; } }
        public int idAmbPrivee { get { return m_idAmbPrivee; }private set { m_idAmbPrivee = value; } }
        public int idRegulateur { get { return m_idRegulateur; }private set { m_idRegulateur = value; } }
        public DateTime dateDepartReelle { get { return m_dateDepartReelle; }private set { m_dateDepartReelle = value; } }
        public DateTime dateArriveeReelle { get { return m_dateArriveeReelle; }private set { m_dateArriveeReelle = value; } }
        public String observation { get { return m_observation; }private set { m_observation = value; } }
        public TypeTransport type { get { return m_type; } private set { m_type = value; } }
        public ModeTransport mode { get { return m_mode; }private set { m_mode = value; } }
        public Contexte contexte { get { return m_contexte; }private set { m_contexte = value; } }
        public ConditionTransport condition { get { return m_condition; }private set { m_condition = value; } }

       
        //Constructeur à définir

        public Demande()
        {

        }


    }
}
