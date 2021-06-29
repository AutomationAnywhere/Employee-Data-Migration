using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEmpId.Text=="1001")
            {
                txtFirstName.Text = "Stuart";
                txtLastName.Text = "Brandt";
                txtEmailId.Text = "StuartDBrandt@dxyl.com";
                txtZip.Text = "19108";
                txtCity.Text = "Philadelphia";
                txtJobTitle.Text = "Data Analyst";
                txtDepartment.Text = "Marketing";             
                txtManager.Text = "Norman Holler";                
                txtState.Text = "PA";
            }

            if (txtEmpId.Text == "1002")
            {
                txtFirstName.Text = "Denise";
                txtLastName.Text = "Peterson";
                txtEmailId.Text = "DeniseSPeterson@dxyl.us";
                txtCity.Text = "Las Vegas";
                txtZip.Text = "89102";
                txtJobTitle.Text = "Developer";
                txtDepartment.Text = "Engineering";
                txtManager.Text = "Henry Charlebois";
                txtState.Text = "NV";
            }

            if (txtEmpId.Text == "1003")
            {
                txtFirstName.Text = "Wilma";
                txtLastName.Text = "Rhodes";
                txtEmailId.Text = "WilmaRRhodes@dxyl.com";
                txtCity.Text = "Phoenix";
                txtZip.Text = "85001";
                txtJobTitle.Text = "Accountant";
                txtDepartment.Text = "Finance";
                txtManager.Text = "Steve Kent";
                txtState.Text = "AZ";
            }

            if (txtEmpId.Text == "1004")
            {
                txtFirstName.Text = "Irving";
                txtLastName.Text = "Stewart";
                txtEmailId.Text = "IrvingAStewart@dxyl.com";
                txtCity.Text = "Chicago";
                txtZip.Text = "60657";
                txtJobTitle.Text = "Payroll Processor";
                txtDepartment.Text = "Finance";
                txtManager.Text = "Jerry Hayes";
                txtState.Text = "IL";
            }

            if (txtEmpId.Text == "1005")
            {
                txtFirstName.Text = "Anthony";
                txtLastName.Text = "Holiday";
                txtEmailId.Text = "AnthonyAHoliday@dxyl.com";
                txtCity.Text = "Los Angeles";
                txtZip.Text = "90001";
                txtJobTitle.Text = "Marketing Director";
                txtDepartment.Text = "Marketing";
                txtManager.Text = "Doris Arellano";
                txtState.Text = "CA";
            }

            if (txtEmpId.Text == "1006")
            {
                txtFirstName.Text = "Mary";
                txtLastName.Text = "Fournier";
                txtEmailId.Text = "MaryWFournier@dxyl.com";
                txtCity.Text = "Hartford";
                txtZip.Text = "06101";
                txtJobTitle.Text = "Sales Engineer";
                txtDepartment.Text = "Sales";
                txtManager.Text = "Julio Torres";
                txtState.Text = "CT";
            }

            if (txtEmpId.Text == "1007")
            {
                txtFirstName.Text = "Kimberley";
                txtLastName.Text = "Martel";
                txtEmailId.Text = "KimberleyKMartel@dxyl.com";
                txtCity.Text = "New York";
                txtZip.Text = "10004";
                txtJobTitle.Text = "Tester";
                txtDepartment.Text = "Engineering";
                txtManager.Text = "Irma Figgs";
                txtState.Text = "NY";
            }

            if (txtEmpId.Text == "1008")
            {
                txtFirstName.Text = "Luciano";
                txtLastName.Text = "Wayne";
                txtEmailId.Text = "LucianoPWayne@dxyl.com";
                txtCity.Text = "Mansura";
                txtZip.Text = "71350";
                txtJobTitle.Text = "Scrum Master";
                txtDepartment.Text = "Engineering";
                txtManager.Text = "Kris Strouse";
                txtState.Text = "DE";
            }

            if (txtEmpId.Text == "1009")
            {
                txtFirstName.Text = "Tyler";
                txtLastName.Text = "Smith";
                txtEmailId.Text = "TylerMSmith@dxyl.com";
                txtCity.Text = "Columbus";
                txtZip.Text = "43213";
                txtJobTitle.Text = "Project Manager";
                txtDepartment.Text = "Engineering";
                txtManager.Text = "Ricky Joseph";
                txtState.Text = "OH";
            }

            if (txtEmpId.Text == "1010")
            {
                txtFirstName.Text = "Concordia";
                txtLastName.Text = "Ansley";
                txtEmailId.Text = "cansley0@dxyl.com";
                txtCity.Text = "Baltimore";
                txtZip.Text = "21201";
                txtJobTitle.Text = "Software Test Engineer I";
                txtDepartment.Text = "Engineering";
                txtManager.Text = "Alisun Disetti";
                txtState.Text = "MD";
            }

            if (txtEmpId.Text == "1011")
            {
                txtFirstName.Text = "Alisun";
                txtLastName.Text = "Dionisetti";
                txtEmailId.Text = "adionisetti1@dxyl.com";
                txtCity.Text = "Miami";
                txtZip.Text = "33124";
                txtJobTitle.Text = "Budget Analyst";
                txtDepartment.Text = "Sales";
                txtManager.Text = "Mindy Wellbeloved";
                txtState.Text = "FL";
            }

            if (txtEmpId.Text == "1012")
            {
                txtFirstName.Text = "Mindy";
                txtLastName.Text = "Tabart";
                txtEmailId.Text = "mtabart2@dxyl.com";
                txtCity.Text = "Chicago";
                txtZip.Text = "60601";
                txtJobTitle.Text = "Trainer";
                txtDepartment.Text = "L & D";
                txtManager.Text = "Shurlock Pickard";
                txtState.Text = "IL";
            }

            if (txtEmpId.Text == "1013")
            {
                txtFirstName.Text = "Shurlock";
                txtLastName.Text = "Simonard";
                txtEmailId.Text = "ssimonard3@dxyl.com";
                txtCity.Text = "Boston";
                txtZip.Text = "02101";
                txtJobTitle.Text = "Sr. Trainer";
                txtDepartment.Text = "L & D";
                txtManager.Text = "Cathlene Tabart";
                txtState.Text = "MA";
            }

            if (txtEmpId.Text == "1014")
            {
                txtFirstName.Text = "Cathlene";
                txtLastName.Text = "Wellbeloved";
                txtEmailId.Text = "cwellbeloved4@dxyl.com";
                txtCity.Text = "Cleveland";
                txtZip.Text = "44101";
                txtJobTitle.Text = "Customer Success Associate";
                txtDepartment.Text = "Services";
                txtManager.Text = "Bevan Mapson";
                txtState.Text = "OH";
            }

            if (txtEmpId.Text == "1015")
            {
                txtFirstName.Text = "Bevan";
                txtLastName.Text = "Mapson";
                txtEmailId.Text = "bmapson5@dxyl.com";
                txtCity.Text = "Nashville";
                txtZip.Text = "37201";
                txtJobTitle.Text = "Director of Customer Success";
                txtDepartment.Text = "Services";
                txtManager.Text = "Amabel Shimony";
                txtState.Text = "TN";
            }

            if (txtEmpId.Text == "1016")
            {
                txtFirstName.Text = "Amabel";
                txtLastName.Text = "Prop";
                txtEmailId.Text = "aprop6@dxyl.com";
                txtCity.Text = "Milwaukee";
                txtZip.Text = "53201";
                txtJobTitle.Text = "Sales Associate";
                txtDepartment.Text = "Sales";
                txtManager.Text = "Wilt Prop";
                txtState.Text = "WI";
            }

            if (txtEmpId.Text == "1017")
            {
                txtFirstName.Text = "Wilt";
                txtLastName.Text = "Shimony";
                txtEmailId.Text = "wshimony7@dxyl.com";
                txtCity.Text = "Portland";
                txtZip.Text = "97201";
                txtJobTitle.Text = "Project Manager";
                txtDepartment.Text = "Engineering";
                txtManager.Text = "Bonita Scroggs";
                txtState.Text = "OR";
            }

            if (txtEmpId.Text == "1018")
            {
                txtFirstName.Text = "Bonita";
                txtLastName.Text = "Slatter";
                txtEmailId.Text = "bslatter8@dxyl.com";
                txtCity.Text = "Pittsburgh";
                txtZip.Text = "15201";
                txtJobTitle.Text = "Product Manager";
                txtDepartment.Text = "Product Management";
                txtManager.Text = "Artur Slatter";
                txtState.Text = "PA";
            }

            if (txtEmpId.Text == "1019")
            {
                txtFirstName.Text = "Artur";
                txtLastName.Text = "Scroggs";
                txtEmailId.Text = "ascroggs9@dxyl.com";
                txtCity.Text = "Austin";
                txtZip.Text = "78701";
                txtJobTitle.Text = "Graphic Designer";
                txtDepartment.Text = "Design";
                txtManager.Text = "Curtice Ansley";
                txtState.Text = "TX";
            }

            if (txtEmpId.Text == "1020")
            {
                txtFirstName.Text = "Curtice";
                txtLastName.Text = "Botler";
                txtEmailId.Text = "cbotlera@dxyl.com";
                txtCity.Text = "New Orleans";
                txtZip.Text = "70112";
                txtJobTitle.Text = "Consultant";
                txtDepartment.Text = "Legal";
                txtManager.Text = "Concordia Botler";
                txtState.Text = "LA";
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmailId.Text = "";
            txtCity.Text = "";
            txtZip.Text = "";
            txtJobTitle.Text = "";
            txtDepartment.Text = "";
            txtManager.Text = "";
            txtState.Text = "";
            txtEmpId.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("explorer.exe","https://developer.automationanywhere.com");
        }
    }
}
