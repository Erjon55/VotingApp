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
    public partial class VotingUnit : Form
    {
        public string Name { get; set; }

        public List<Party> Parties { get; set; } = new List<Party>();
        public List<string> partyNames { get; set; } = new List<string>();
        
        public int Population { get; set; }
        public int Voters { get; set; }

        public VotingUnit(string Unit)
        {
       
            InitializeComponent();
            Name = Unit;
            Population = 0;
            Voters = 0;
            label4.Text = Name;



        }

        public void check()
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach(Party p in Parties)
            {
                if(p.Name.Equals(tbPartyName.Text))
                {
                    lbCityInfo.Items.Remove(p);
                    p.VotesPerUnit += Convert.ToInt32(tbVotes.Text);
                    lbCityInfo.Items.Add(p);
                    
                    tbPartyName.Clear();
                    tbVotes.Clear();
                    return;

                }
            }

            
            Parties.Add(new Party(tbPartyName.Text, Convert.ToInt32(tbVotes.Text)));
            lbCityInfo.Items.Add(Parties.Last());
           
            Voters += Parties.Last().VotesPerUnit;
            partyNames.Add(Parties.Last().Name);

            label5.Text = partyNames.Count.ToString();
            tbPartyName.Clear();
            tbVotes.Clear();
            
            

        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Unit {0} - Voters :{1}", Name, Voters));

            foreach(Party p in Parties)
            {
                sb.AppendLine(p.ToString());
            }
            return sb.ToString();  
               
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            Close();
        }

        private void tbPartyName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPartyName.Text))
            {
                errorProvider1.SetError(tbPartyName, "Field must contain Party name");
            }
            else
            {
                errorProvider1.SetError(tbPartyName, null);
            }
        }

        private void tbVotes_Validating(object sender, CancelEventArgs e)
        {
            if(!int.TryParse(tbVotes.Text, out var votes))
            {
                errorProvider1.SetError(tbVotes, "Votes must be a number");
            }
            else
            {
                errorProvider1.SetError(tbVotes, null);
            }
        }
    }
}
