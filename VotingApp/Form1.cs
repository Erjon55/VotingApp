using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingApp
{

    public partial class Form1 : Form
    {
        private string FileName;
        Overall overall = new Overall();
      
      
        public Form1()
        {
            InitializeComponent();
            
        }

        public void updateVotesPerParty(List<String> names)
        {
            foreach (VotingUnit vu in overall.votingUnits)
            {
                foreach (Party p in vu.Parties)
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i] == p.Name)
                        {
                            overall.VotesPerParty[i] += p.VotesPerUnit;

                        }
                    }
                }
            }
        }

        public void update()
        {
            updateVotesPerParty(overall.PartyNames);
           
            listBox1.Items.Add(overall.PartyNames.Count);
            for (int i=0; i< overall.PartyNames.Count; i++)
            {
               
                listBox1.Items.Add(overall.PartyNames[i]);
                listBox1.Items.Add(overall.VotesPerParty[i]);
                listBox1.Items.Add("-------");

            }
            printDhont();
        }



        public static int getMaxElement(double[,] dTable, int pN, int pM)
        {
            double maxValue = dTable[0,0];
            int i = 0, j = 0;
            for (int sn = 0; sn < pN; sn++)
            {
                for (int sm = 0; sm < pM; sm++)
                {
                    if (dTable[sm,sn] > maxValue)
                    {
                        maxValue = dTable[sm,sn];
                        i = sm;
                        j = sn;
                    }
                }
            }
            dTable[i,j] = 0.0; // zero the highest element for next run
            return j;
        }


        public void printDhont()
        {
            int chairs = 120;
            double[] votes = overall.VotesPerParty;
            string[] party = overall.PartyNames.ToArray();
            int[] allocated = new int[party.Length];
            double[,] dhondtTable = new double[chairs, votes.Length];

            // Build D'Hondt Table
            for (int m = 0; m < chairs; m++)
            {
                for (int n = 0; n < party.Length; n++)
                {
                    if (m == 0)
                        dhondtTable[m, n] = votes[n];
                    else
                        dhondtTable[m, n] = dhondtTable[0, n] / (m + 1);
                }
            }


            /*Allocate Ministers using D'Hondt
             * iterate through the number of cabinet posts to allocate
             * find the highest value in the D'Hondt Table 
             */
            int o = 0;
            for (int c = 1; c < chairs + 1; c++)
            {
                o = getMaxElement(dhondtTable, party.Length, chairs);

                allocated[o] = allocated[o] + 1;
            }

            for (int p = 0; p < party.Length; p++)
            {
                //lblDhondt.Text+=String.Format("{0} gets {1} Ministers\n",party[p], allocated[p]);
                lbDHondt.Items.Add(String.Format("{0} gets {1} Ministers\n", party[p], allocated[p]));

            }
        }

        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Votings doc file (*.vot)|*.vot";
                saveFileDialog.Title = "Save votings doc";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, overall);
                }
            }
        }

        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Votins file (*.vot)|*.vot";
            openFileDialog.Title = "Open votings doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        overall = (Overall)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }
        private void bntAddDemo_Click(object sender, EventArgs e)
        {
            

            if(overall.ShowDialog() == DialogResult.OK)
            {
                update();

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

       
       
        

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFile();

        }

        private void openToolStripButton_Click_1(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            saveFile();
        }

       
    }
}
