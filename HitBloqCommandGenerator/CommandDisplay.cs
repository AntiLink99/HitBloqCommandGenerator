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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(165, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(0, 45);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(718, 880);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mappool name:";
            // 
            // CommandDisplay
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(718, 925);
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
            string result = "\n";
            //Ranking
            if (selection.easy)
            {
                result += "!rank " + getMapIdentifier(selection, "Easy", poolName) + "\r\n";
            }
            if (selection.normal)
            {
                result += "!rank " + getMapIdentifier(selection, "Normal", poolName) + "\r\n";
            }
            if (selection.hard)
            {
                result += "!rank " + getMapIdentifier(selection, "Hard", poolName) + "\r\n";
            }
            if (selection.expert)
            {
                result += "!rank " + getMapIdentifier(selection, "Expert", poolName) + "\r\n";
            }
            if (selection.expertPlus)
            {
                result += "!rank " + getMapIdentifier(selection, "ExpertPlus", poolName) + "\r\n";
            }

            //Stars
            if (selection.starsEasy != 0)
            {
                result += "!set_manual " + getMapIdentifier(selection, "Easy", poolName) + " " + parseDecimal(selection.starsEasy) + "\r\n";
            }
            if (selection.starsNormal != 0)
            {
                result += "!set_manual " + getMapIdentifier(selection, "Normal", poolName) + " " + parseDecimal(selection.starsNormal) + "\r\n";
            }
            if (selection.starsHard != 0)
            {
                result += "!set_manual " + getMapIdentifier(selection, "Hard", poolName) + " " + parseDecimal(selection.starsHard) + "\r\n";
            }
            if (selection.starsExpert != 0)
            {
                result += "!set_manual " + getMapIdentifier(selection, "Expert", poolName) + " " + parseDecimal(selection.starsExpert) + "\r\n";
            }
            if (selection.starsExpertPlus != 0)
            {
                result += "!set_manual " + getMapIdentifier(selection, "ExpertPlus", poolName) + " " + parseDecimal(selection.starsExpertPlus) + "\r\n";
            }
            return result;
        }

        private string getMapIdentifier(MapSelection selection, string diff, string poolName)
        {
            if (poolName.Equals(""))
            {
                poolName = "<MAP_POOL>";
            }
            return selection.hash.ToUpper() + "|_" + diff + "_SoloStandard " + poolName;
        }

        private string parseDecimal(decimal dec)
        {
            return dec.ToString("0.####").Replace(',', '.');
        }

        private void showCommands()
        {
            string commandList = "";
            foreach (MapSelection selection in selections)
            {
                commandList += getCommandsFromSelection(selection, textBox1.Text) + "\n";
            }
            textBox2.Text = commandList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            showCommands();
        }
    }
}
