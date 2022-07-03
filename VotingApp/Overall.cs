using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingApp
{
    [Serializable]
    public partial class Overall : Form
    {
        public List<VotingUnit> votingUnits = new List<VotingUnit>();
        public List<string> PartyNames = new List<string>();

        public double[] VotesPerParty { get; set; } = new double[15];

        public Overall()
        {
            InitializeComponent();
            PartyNames.Add("A");
        }


       public List<string> updatePartyNames()
        {
        
            List<string>vs = new List<string>();
            foreach(VotingUnit unit in votingUnits)
            {
              
                foreach(string name in unit.partyNames)
                {
                    if (!vs.Contains(name))
                    {
                        vs.Add(name);
                    }
                }
                
            }
            
            return vs;
        }

       

        private void btnDemoAdd_Click(object sender, EventArgs e)
        {


            VotingUnit VotingUnit = new VotingUnit(cbUnit.SelectedItem.ToString());
            if (VotingUnit.ShowDialog() == DialogResult.OK)
            {
                votingUnits.Add(VotingUnit);
                PartyNames = updatePartyNames();
               // updateVotesPerParty(PartyNames);

                lblNumParties.Text = PartyNames.Count.ToString();


                switch (cbUnit.Text)
                {
                    case "1":
                        lblU1.Text = VotingUnit.ToString();
                        break;

                    case "2":
                        lblU2.Text = VotingUnit.ToString();
                        break;

                    case "3":
                        lblU3.Text = VotingUnit.ToString();
                        break;
                    case "4":
                        lblU4.Text = VotingUnit.ToString();
                        break;
                    case "5":
                        lblU5.Text = VotingUnit.ToString();
                        break;
                    case "6":
                        lblU6.Text = VotingUnit.ToString();
                        break;
                }

                //DialogResult = DialogResult.OK;
            }
            else
            {
                Close();
               
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void cbUnit_Validating(object sender, CancelEventArgs e)
        {
            if(cbUnit.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbUnit, "A unit must be selected");
            }
            else
            {
                errorProvider1.SetError(cbUnit, null);
            }
        }
    }
}
