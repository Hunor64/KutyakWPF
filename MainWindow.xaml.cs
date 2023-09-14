using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kutyak;

namespace Kutyak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Kutyak> kutyakLista = new List<Kutyak>();
        List<KutyakNeve> kutyakNeveLista = new List<KutyakNeve>();
        List<KutyakFajta> kutyakFajtaLista = new List<KutyakFajta>();
        public MainWindow()
        {
            InitializeComponent();
            kutyakBeolvas();
            KutyaFajtaBeolvas();
            lblKutyakSzama.Content = kutyakNeveLista.Count();
        }
        private void kutyakBeolvas()
        {
            string fileNeve = "Kutya.csv";
            var kutyakKiolva = File.ReadAllLines(fileNeve);
            for (int i = 1; i < kutyakKiolva.Count(); i++)
            {
                var kutyakAdd = kutyakKiolva[i].Split(';');
                kutyakLista.Add(new Kutyak(Convert.ToInt32(kutyakAdd[0]), Convert.ToInt32(kutyakAdd[1]), Convert.ToInt32(kutyakAdd[2]), Convert.ToInt32(kutyakAdd[3]), kutyakAdd[4]));
            }
        }
        private void KutyaFajtaBeolvas() 
        {
            string fileNeve = "KutyaFajtak.csv";
            var kutyakKiolva = File.ReadAllLines(fileNeve);
            for (int i = 1; i < kutyakKiolva.Count(); i++)
            {
                var kutyakNeveAdd = kutyakKiolva[i].Split(';');
                kutyakFajtaLista.Add(new KutyakFajta(Convert.ToInt32(kutyakNeveAdd[0]), kutyakNeveAdd[1], kutyakNeveAdd[2]));
            }
        }

        private void kutyakNeveBeolvas()
        {
            string fileNeve = "KutyaNevek.csv";
            var kutyakKiolva = File.ReadAllLines(fileNeve);
            for (int i = 1; i < kutyakKiolva.Count(); i++)
            {
                var kutyakNeveAdd = kutyakKiolva[i].Split(';');
                kutyakNeveLista.Add(new KutyakNeve(Convert.ToInt32(kutyakNeveAdd[0]), kutyakNeveAdd[1]));
            }
        }

    }
}
