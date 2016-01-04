using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace teamRandomizer
{
    public partial class Form1 : Form
    {
        private int MINIMUM_GENERATION_SIZE = 4;
        private string FIRST_GROUP_NAME = "txtCurrentGroup1";

        private int groupCount;
        private Dictionary<string, int> groupComponentDictionary;

        public Form1()
        {
            InitializeComponent();

            txtNumberOfGroups.Text = "1";
            groupComponentDictionary = new Dictionary<string, int>();

            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                ((ToolStripDropDownMenu)menuItem.DropDown).ShowImageMargin = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (groupComponentDictionary.Count == 0) 
            {
                MessageForm form = new MessageForm(1, "You must create at least one group before attempting to generate new ones.", "Generation Error", false);
                form.ShowDialog(this);
                return;
            }

            Control[] controls = Controls.Find(FIRST_GROUP_NAME, false);

            if (isEmpty(((System.Windows.Forms.TextBox)controls[0]).Text))
            {
                MessageForm form = new MessageForm(1, "Group #1 cannot be empty.", "Generation Error", false);
                form.ShowDialog(this);
                return;
            }

            List<TeamMember> teamList = getTeamList();

            if (teamList.Count < MINIMUM_GENERATION_SIZE)
            {
                MessageForm form = new MessageForm(1, "Must have at least four team members for the generator to work.", "Generation Error", false);
                form.ShowDialog(this);
                return;
            }

            generateNewTeams(teamList);

            clearOldData();

            bool firstPass = true;
            List<string> emptyList = new List<string>();
            foreach (TeamMember teamMember in teamList)
            {
                List<string> keyList = new List<string>(groupComponentDictionary.Keys);
                foreach (string key in keyList)
                {
                    if (!key.StartsWith("txtC")) 
                    {
                        continue;
                    }

                    if (groupComponentDictionary[key] <= 0)
                    {
                        if (!emptyList.Contains(key))
                        {
                            firstPass = true;
                            emptyList.Add(key);
                        }
                        
                        continue;
                    }

                    string newGroupName = key.Replace("Current", "New");
                    Control[] groups = Controls.Find(newGroupName, true);
                    System.Windows.Forms.TextBox txtBox = ((System.Windows.Forms.TextBox)groups[0]);

                    if (!firstPass)
                    {
                        txtBox.AppendText(",");
                    }

                    txtBox.AppendText(teamMember.getName());

                    groupComponentDictionary[key]--;
                    firstPass = false;
                    break;
                }
            }
        }

        private void clearOldData()
        {
            List<string> keyList = new List<string>(groupComponentDictionary.Keys);
            foreach (string key in keyList)
            {
                if (!key.StartsWith("txtN"))
                {
                    continue;
                }

                Control[] controls = Controls.Find(key, false);
                ((System.Windows.Forms.TextBox)controls[0]).Text = "";
            }
        }

        private void generateNewTeams(List<TeamMember> teamList)
        {
            do {
                shuffleList(teamList);
            } while(!isValid(teamList));
        }

        private bool isValid(List<TeamMember> teamList)
        {
            // make sure team members are in different positions
            int position = -1;
            foreach (TeamMember teamMember in teamList)
            {
                position++;

                if (teamMember.getPosition() == position)
                {
                    return false;
                }
            }

            // make sure the same team members are not setting together
            for (int i = 0; i < teamList.Count; i++)
            {
                TeamMember teamMember = teamList.ElementAt(i);

                if (i == 0)
                {
                    TeamMember neighbor = teamList.ElementAt(i + 1);
                    if (teamMember.getNeighborList().Contains(neighbor.getName()))
                    {
                        return false;
                    }
                }
                else if (i == teamList.Count - 1)
                {
                    TeamMember neighbor = teamList.ElementAt(i - 1);
                    if (teamMember.getNeighborList().Contains(neighbor.getName()))
                    {
                        return false;
                    }
                }
                else 
                {
                    TeamMember neighbor1 = teamList.ElementAt(i + 1);
                    if (teamMember.getNeighborList().Contains(neighbor1.getName()))
                    {
                        return false;
                    }

                    TeamMember neighbor2 = teamList.ElementAt(i - 1);
                    if (teamMember.getNeighborList().Contains(neighbor2.getName()))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void shuffleList<T>(IList<T> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private List<TeamMember> getTeamList()
        {
            List<TeamMember> teamList = new List<TeamMember>();
            
            List<string> teamNameList = new List<string>();
            List<string> keyList = new List<string>(groupComponentDictionary.Keys);
            foreach (string key in keyList) 
            {
                if (!key.StartsWith("txtC"))
                {
                    continue;
                }

                Control[] controls = Controls.Find(key, false);
                string group = ((System.Windows.Forms.TextBox)controls[0]).Text;

                if (!isEmpty(group))
                {
                    string[] groupList = group.Split(',');
                    int groupSize = groupList.Count();
                    foreach (string name in groupList)
                    {
                        if (name.Trim().Equals(""))
                        {
                            groupSize--;
                        }
                        else
                        {
                            teamNameList.Add(name.Trim());
                        }
                    }
                    groupComponentDictionary[key] = groupSize;
                }
            }

            if (teamNameList.Count < MINIMUM_GENERATION_SIZE)
            {
                return teamList;
            }

            int position = 0;
            foreach (string name in teamNameList) 
            {
                TeamMember teamMember = new TeamMember(position, name);

                int tempPos = 0;
                List<string> neighborList = new List<string>();
                foreach (string neighborName in teamNameList)
                {
                    bool isNeighbor = (tempPos - 1 == teamMember.getPosition()) || (tempPos + 1 == teamMember.getPosition());

                    if (!neighborName.Equals(name) && isNeighbor)
                    {
                        neighborList.Add(neighborName);
                    }
                    tempPos++;
                }

                teamMember.setNeighborList(neighborList);
                teamList.Add(teamMember);
                position++;
            }

            return teamList;
        }

        private Action<string> buildList(List<TeamMember> teamList)
        {
            throw new NotImplementedException();
        }

        private bool isEmpty(string s)
        {
            if (s == null || "".Equals(s.Trim()))
            {
                return true;
            }

            return false;
        }

        private bool isEmpty(List<string> list)
        {
            if (list == null || list.Count == 0)
            {
                return true;
            }

            return false;
        }

        private void txtNumberOfGroups_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            Match match = regex.Match(((TextBox)sender).Text);
            if (!match.Success)
            {
                txtNumberOfGroups.Text = "1";
            }
        }

        private void btnCreateGroups_Click(object sender, EventArgs e)
        {
            string groups = txtNumberOfGroups.Text;
            if (isEmpty(groups) || Int32.Parse(groups) < 1)
            {
                MessageForm form = new MessageForm(1, "Your number of groups must be greater than zero.", "Group Generation Error", false);
                form.ShowDialog(this);
                return;
            }

            groupCount = Convert.ToInt32(txtNumberOfGroups.Text);

            removeGroups();

            int currentLabelX = 13;
            int currentLabelY = 110;
            
            int newLabelX = 374;
            int newLabelY = 110;

            int currentTextX = 86;
            int currentTextY = 109;

            int newTextX = 447;
            int newTextY = 109;

           
            for (int i = 0; i < groupCount; i++)
            {
                createLabels(i + 1, currentLabelX, currentLabelY, currentTextX, currentTextY, newLabelX, newLabelY, newTextX, newTextY);

                currentLabelY += 30;
                currentTextY += 30;
                newLabelY += 30;
                newTextY += 30;
            }
        }

        private void removeGroups()
        {
            foreach(KeyValuePair<string, int> entry in groupComponentDictionary) 
            {
                Controls.RemoveByKey(entry.Key);
            }

            groupComponentDictionary.Clear();

            this.Invalidate();
            this.Refresh();
        }

        private void createLabels(int groupNumber, int currentLabelX, int currentLabelY, int currentTextX, int currentTextY, int newLabelX, int newLabelY, int newTextX, int newTextY)
        {
            System.Windows.Forms.Label lblCurrentGroup = new System.Windows.Forms.Label();
            lblCurrentGroup.AutoSize = true;
            lblCurrentGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCurrentGroup.Location = new System.Drawing.Point(currentLabelX, currentLabelY);
            lblCurrentGroup.Name = "lblCurrentGroup" + groupNumber;
            lblCurrentGroup.Size = new System.Drawing.Size(67, 16);
            //lblCurrentGroup.TabIndex = 1;
            lblCurrentGroup.Text = "Group #" + groupNumber + ":";

            groupComponentDictionary.Add(lblCurrentGroup.Name, 0);

            System.Windows.Forms.TextBox txtCurrentGroup = new System.Windows.Forms.TextBox();
            txtCurrentGroup.Location = new System.Drawing.Point(currentTextX, currentTextY);
            txtCurrentGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtCurrentGroup.Name = "txtCurrentGroup" + groupNumber;
            txtCurrentGroup.Size = new System.Drawing.Size(251, 20);
            //txtCurrentGroup.TabIndex = 2;

            groupComponentDictionary.Add(txtCurrentGroup.Name, 0);

            Controls.Add(lblCurrentGroup);
            Controls.Add(txtCurrentGroup);

            System.Windows.Forms.Label lblNewGroup = new System.Windows.Forms.Label();
            lblNewGroup.AutoSize = true;
            lblNewGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNewGroup.Location = new System.Drawing.Point(newLabelX, newLabelY);
            lblNewGroup.Name = "lblNewGroup" + groupNumber;
            lblNewGroup.Size = new System.Drawing.Size(67, 16);
            lblNewGroup.Text = "Group #" + groupNumber + ":";

            groupComponentDictionary.Add(lblNewGroup.Name, 0);

            System.Windows.Forms.TextBox txtNewGroup = new System.Windows.Forms.TextBox();
            txtNewGroup.Location = new System.Drawing.Point(newTextX, newTextY);
            txtNewGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtNewGroup.Name = "txtNewGroup" + groupNumber;
            txtNewGroup.Size = new System.Drawing.Size(251, 20);
            txtNewGroup.TabIndex = 0;

            groupComponentDictionary.Add(txtNewGroup.Name, 0);

            Controls.Add(lblNewGroup);
            Controls.Add(txtNewGroup);
        }

        private void mniAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog(this);
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            MessageForm form = new MessageForm(0, "Are you sure you want to exit?", "Confirm Exit", true);
            form.ShowDialog(this);

            if (form.isOkay())
            {
                Close();
            }
        }
    }
}
