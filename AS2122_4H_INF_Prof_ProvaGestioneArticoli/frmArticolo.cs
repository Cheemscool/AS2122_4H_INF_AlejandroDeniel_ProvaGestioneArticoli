using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    public partial class frmArticolo : Form
    {
        List<Articolo> articoli;
        DialogResult status = DialogResult.Cancel;

        // TODO: (5) aggiungere attributi privati dei dati inseriti nella frmArticoli
        // ...
        string _descrizione;
        string _unitaMisura;
        double _prezzo;

        public DialogResult Status { get { return status; } }

        // TODO: (6) aggiungere property di sola lettura dei dati inseriti nella frmArticoli per l'utilizzo in frmMain
        // ...
        public string Descrizione { get { return _descrizione; } }
        public string UnitaMisura { get { return _unitaMisura; } }
        public double Prezzo { get { return _prezzo; } }

        public frmArticolo(List<Articolo> articoli)
        {
            InitializeComponent();
            this.articoli = articoli;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // TODO: (7) passaggio all' attributo/property dei dati inseriti nella frmArticoli con controllo di valorizzazione del dato
            // ... descrizione, unitaMisura, prezzo

            //Verifico se in txtPrezzo.Text viene inserito un valore numerico.
            double numero;
            if (!Double.TryParse(txtPrezzo.Text, out numero))
            {
                MessageBox.Show("Devi inserire un valore numerico per il prezzo.");
                return;
            }
            _descrizione = txtDescrizione.Text;
            _unitaMisura = cmbUnitaMisura.Text;
            _prezzo = numero;

            Articolo articolo = new Articolo(1, Descrizione, UnitaMisura, Prezzo);
            articoli.Add(articolo);

            status = DialogResult.OK;
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            status = DialogResult.Cancel;
            Close();
        }
    }
}
