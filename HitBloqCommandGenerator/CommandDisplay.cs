using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitBloqCommandGenerator
{
    public partial class CommandDisplay : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private CheckBox checkBoxCR;
        private CheckBox checkBoxPlaylists;
        private Button button1;
        private List<MapSelection> selections;

        public CommandDisplay(List<MapSelection> selections)
        {
            InitializeComponent();
            this.selections = selections;
            showCommands();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandDisplay));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxCR = new System.Windows.Forms.CheckBox();
            this.checkBoxPlaylists = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(166, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(12, 45);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(746, 880);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mappool name:";
            // 
            // checkBoxCR
            // 
            this.checkBoxCR.AutoSize = true;
            this.checkBoxCR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxCR.ForeColor = System.Drawing.Color.White;
            this.checkBoxCR.Location = new System.Drawing.Point(332, 14);
            this.checkBoxCR.Name = "checkBoxCR";
            this.checkBoxCR.Size = new System.Drawing.Size(140, 27);
            this.checkBoxCR.TabIndex = 4;
            this.checkBoxCR.Text = "recalculate_cr";
            this.checkBoxCR.UseVisualStyleBackColor = true;
            this.checkBoxCR.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxPlaylists
            // 
            this.checkBoxPlaylists.AutoSize = true;
            this.checkBoxPlaylists.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPlaylists.ForeColor = System.Drawing.Color.White;
            this.checkBoxPlaylists.Location = new System.Drawing.Point(478, 14);
            this.checkBoxPlaylists.Name = "checkBoxPlaylists";
            this.checkBoxPlaylists.Size = new System.Drawing.Size(191, 27);
            this.checkBoxPlaylists.TabIndex = 5;
            this.checkBoxPlaylists.Text = "regenerate_playlists";
            this.checkBoxPlaylists.UseVisualStyleBackColor = true;
            this.checkBoxPlaylists.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(656, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CommandDisplay
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(771, 942);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxCR);
            this.Controls.Add(this.checkBoxPlaylists);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CommandDisplay";
            this.RightToLeftLayout = true;
            this.Text = "Hitbloq Command Generator by AntiLink (not official)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private string getCommandsFromSelection(MapSelection selection, string poolName)
        {
            string result = "";
            string hash = selection.hash;
            //Ranking
            foreach (MapSelectionCharacteristic characteristic in selection.characteristics) {
                if (characteristic.easy)
                {
                    result += "!rank " + getMapIdentifier(hash, characteristic, "Easy", poolName) + "\r\n";
                }
                if (characteristic.normal)
                {
                    result += "!rank " + getMapIdentifier(hash, characteristic, "Normal", poolName) + "\r\n";
                }
                if (characteristic.hard)
                {
                    result += "!rank " + getMapIdentifier(hash, characteristic, "Hard", poolName) + "\r\n";
                }
                if (characteristic.expert)
                {
                    result += "!rank " + getMapIdentifier(hash, characteristic, "Expert", poolName) + "\r\n";
                }
                if (characteristic.expertPlus)
                {
                    result += "!rank " + getMapIdentifier(hash, characteristic, "ExpertPlus", poolName) + "\r\n";
                }

                //Stars
                if (characteristic.starsEasy != 0)
                {
                    result += "!set_manual " + getMapIdentifier(hash, characteristic, "Easy", poolName) + " " + parseDecimal(characteristic.starsEasy) + "\r\n";
                }
                if (characteristic.starsNormal != 0)
                {
                    result += "!set_manual " + getMapIdentifier(hash, characteristic, "Normal", poolName) + " " + parseDecimal(characteristic.starsNormal) + "\r\n";
                }
                if (characteristic.starsHard != 0)
                {
                    result += "!set_manual " + getMapIdentifier(hash, characteristic, "Hard", poolName) + " " + parseDecimal(characteristic.starsHard) + "\r\n";
                }
                if (characteristic.starsExpert != 0)
                {
                    result += "!set_manual " + getMapIdentifier(hash, characteristic, "Expert", poolName) + " " + parseDecimal(characteristic.starsExpert) + "\r\n";
                }
                if (characteristic.starsExpertPlus != 0)
                {
                    result += "!set_manual " + getMapIdentifier(hash, characteristic, "ExpertPlus", poolName) + " " + parseDecimal(characteristic.starsExpertPlus) + "\r\n";
                }
            }
            return result;
        }

        private string getMapIdentifier(string hash, MapSelectionCharacteristic characteristic, string diff, string poolName)
        {
            if (poolName.Equals(""))
            {
                poolName = "<MAP_POOL>";
            }
            return hash.ToUpper() + "|_" + diff + "_Solo" + characteristic.name + " " + poolName;
        }

        private string parseDecimal(decimal dec)
        {
            return dec.ToString("0.####").Replace(',', '.');
        }

        private void showCommands()
        {
            string commandList = "";
            string poolName = textBox1.Text;
            foreach (MapSelection selection in selections)
            {
                commandList += getCommandsFromSelection(selection, poolName) + "\n";
            }
            //Other
            if (checkBoxCR.Checked)
            {
                if (poolName.Equals(""))
                {
                    poolName = "<MAP_POOL>";
                }
                commandList += "!recalculate_cr " + poolName + "\r\n";
            }
            if (checkBoxPlaylists.Checked)
            {
                commandList += "!regenerate_playlists\r\n";
            }
            int nextLineIndex = commandList.LastIndexOf("\r\n");
            if (nextLineIndex >= 0)
            {
                commandList = commandList.Remove(commandList.LastIndexOf("\r\n"));
            }
            textBox2.Text = commandList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            showCommands();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            showCommands();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            showCommands();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBox2.Text);
            button1.Text = "Copied!";
        }
    }
}
