using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel18_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random outpatientNumber = new Random();
            Random inpatientNumber = new Random();
            Random defferdInpatientNumber = new Random();
            Random defferdOutpatientNumber = new Random();
            Random dentalCheckUpsNumber = new Random();
            Random dentalCheckUpsNumber2 = new Random();
            Random cancerScreenCheckUpsNumber = new Random();
            Random cancerScreenCheckUpsNumber2 = new Random();
            Random bloodTestsNumber = new Random();
            Random entCheckUpsNumber = new Random();
      

            outpatientbunifuLabel21.Text = outpatientNumber.Next(6500, 8399).ToString();
            inpatientbunifuLabel18.Text = inpatientNumber.Next(2500, 5399).ToString();
            defferedInbunifuLabel23.Text = defferdInpatientNumber.Next(200, 500).ToString();
            defferedOutbunifuLabel25.Text = defferdOutpatientNumber.Next(700, 1000).ToString();

            List<double> dentalCheckupsList = new List<double>()
            {
                dentalCheckUpsNumber.Next(30,80),
                dentalCheckUpsNumber.Next(10,40),
                dentalCheckUpsNumber.Next(5,21),
                dentalCheckUpsNumber.Next(30,50),
                dentalCheckUpsNumber.Next(23,60),
                dentalCheckUpsNumber.Next(27,80),
            };

            List<double> dentalCheckupsList2 = new List<double>()
            {
                dentalCheckUpsNumber2.Next(30,80),
                dentalCheckUpsNumber2.Next(20,40),
                dentalCheckUpsNumber2.Next(15,21),
                dentalCheckUpsNumber2.Next(32,50),
                dentalCheckUpsNumber2.Next(13,60),
                dentalCheckUpsNumber2.Next(17,80),
            };

            List<double> cancerCheckupList = new List<double>()
            {
                cancerScreenCheckUpsNumber.Next(3,80),
                cancerScreenCheckUpsNumber.Next(21,40),
                cancerScreenCheckUpsNumber.Next(11,21),
                cancerScreenCheckUpsNumber.Next(10,50),
                cancerScreenCheckUpsNumber.Next(4,60),
                cancerScreenCheckUpsNumber.Next(22,80),
            };
            List<double> cancerCheckupList2 = new List<double>()
            {
                cancerScreenCheckUpsNumber2.Next(32,80),
                cancerScreenCheckUpsNumber2.Next(13,40),
                cancerScreenCheckUpsNumber2.Next(15,21),
                cancerScreenCheckUpsNumber2.Next(20,50),
                cancerScreenCheckUpsNumber2.Next(24,60),
                cancerScreenCheckUpsNumber2.Next(21,80),
            };

            List<double> bloodTestList = new List<double>()
            {
                bloodTestsNumber.Next(20,50),
                bloodTestsNumber.Next(10,20),
                bloodTestsNumber.Next(5,11),
                bloodTestsNumber.Next(30,50),
                bloodTestsNumber.Next(23,60),
                bloodTestsNumber.Next(27,40),
            };
            List<double> entCheckupTestList = new List<double>()
            {
                entCheckUpsNumber.Next(30,83),
                entCheckUpsNumber.Next(10,44),
                entCheckUpsNumber.Next(5,24),
                entCheckUpsNumber.Next(30,53),
                entCheckUpsNumber.Next(23,61),
                entCheckUpsNumber.Next(27,84),
            };
          

            entBunifuDoughnutChart3.Data = entCheckupTestList;
            bdBunifuDoughnutChart5.Data = bloodTestList;
            cancerBunifuDoughnutChart6.Data = cancerCheckupList;
            cancerBunifuDoughnutChart7.Data = cancerCheckupList2;
            dentalBunifuDoughnutChart1.Data = dentalCheckupsList;
            dentalBunifuDoughnutChart2.Data = dentalCheckupsList2;

            bunifuChartCanvas1.Update();
            bunifuChartCanvas2.Update();
            bunifuChartCanvas3.Update();
            bunifuChartCanvas5.Update();
        }
    }
}
