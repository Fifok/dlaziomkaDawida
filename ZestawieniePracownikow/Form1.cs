using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZestawieniePracownikow
{
    public partial class Form1 : Form
    {
        private List<Pracownik> pracownicy = new List<Pracownik>();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Pracownik nowyPracownik = new Pracownik
            {
                Imie = tbImie.Text,
                Nazwisko = tbNazwisko.Text,
                Stanowisko = tbStanowisko.Text,
                Zarobki = numZarobki.Value
            };

            pracownicy.Add(nowyPracownik);
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            decimal srednia = pracownicy.Average(x => x.Zarobki);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var pracownik in pracownicy)
            {
                stringBuilder.AppendLine(pracownik.ToString());
            }
            stringBuilder.AppendLine($"Srednio zarabiaja {srednia}zl");
            MessageBox.Show(stringBuilder.ToString());
        }
    }

    public class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Stanowisko { get; set; }
        public decimal Zarobki { get; set; }

        public override string ToString()
        {
            return $"{Imie.First()}. {Nazwisko} pracuje jako {Stanowisko}, zarabia {Zarobki}zl";
        }
    }
}
