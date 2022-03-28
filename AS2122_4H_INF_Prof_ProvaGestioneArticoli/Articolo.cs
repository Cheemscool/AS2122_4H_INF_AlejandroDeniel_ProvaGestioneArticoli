using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    public class Articolo
    {
        // TODO: (8) aggiungere attributi privati di Articolo
        // ...
        int _codice;
        string _descrizione;
        string _unitaMisura;
        double _prezzo;

        // TODO: (9) aggiungere property di sola lettura dei dati necessari all'esterno di Articolo
        // ...
        public string Descrizione{ get { return _descrizione; } }
        public string UnitaMisura { get { return _unitaMisura; } }
        public double Prezzo { get { return _prezzo; } }

        public Articolo(int codice, string descrizione, string unitaMisura, double prezzo)
        {
            // TODO: (10) impostazione costruttore classe Articolo come utilizzato da frmMain
            // ...
            _codice = codice;
            _descrizione = descrizione;
            _unitaMisura = unitaMisura;
            _prezzo = prezzo;
        }

        public string Visualizzati()
        {
            return $"{Descrizione} {UnitaMisura} {Prezzo} ({codice})";
        }
    }
}
