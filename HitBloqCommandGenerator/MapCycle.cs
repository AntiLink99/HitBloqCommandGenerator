using BeatSaberPlaylistsLib.Types;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace HitBloqCommandGenerator
{
    public partial class MapCycle : Form
    {
        private Label label1;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button button2;
        List<MapData> mapData;
        Dictionary<string, List<Difficulty>> highlightedDifficultyData;
        List<MapSelection> selections = new List<MapSelection>();
        private Label label2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;

        private ComboBox comboBox1;
        private Label label3;
        int selectionIndex = 0;
        int characteristicIndex = 0;
        private Label labelMapHash;
        MapSelection currentSelection;

        public MapCycle(List<MapData> mapData, Dictionary<string, List<Difficulty>> highlightedDifficultyData)
        {
            InitializeComponent();
            this.mapData = mapData;
            this.highlightedDifficultyData = highlightedDifficultyData;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapCycle));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMapHash = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Map:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel1.Location = new System.Drawing.Point(27, 67);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 35);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Map";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.SpringGreen;
            this.checkBox1.Location = new System.Drawing.Point(99, 285);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 29);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Easy";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.ForeColor = System.Drawing.Color.Cyan;
            this.checkBox2.Location = new System.Drawing.Point(99, 250);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 29);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Normal";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox3.ForeColor = System.Drawing.Color.Orange;
            this.checkBox3.Location = new System.Drawing.Point(99, 217);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(79, 29);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Hard";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox4.ForeColor = System.Drawing.Color.Tomato;
            this.checkBox4.Location = new System.Drawing.Point(99, 186);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(93, 29);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Expert";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox5.ForeColor = System.Drawing.Color.Violet;
            this.checkBox5.Location = new System.Drawing.Point(99, 151);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(106, 29);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Expert+";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(572, 68);
            this.button2.TabIndex = 6;
            this.button2.Text = "Next Map";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stars:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Location = new System.Drawing.Point(27, 153);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 27);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Visible = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Location = new System.Drawing.Point(27, 186);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(66, 27);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Visible = false;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 3;
            this.numericUpDown3.Location = new System.Drawing.Point(27, 219);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(66, 27);
            this.numericUpDown3.TabIndex = 9;
            this.numericUpDown3.Visible = false;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 3;
            this.numericUpDown4.Location = new System.Drawing.Point(27, 252);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(66, 27);
            this.numericUpDown4.TabIndex = 9;
            this.numericUpDown4.Visible = false;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 3;
            this.numericUpDown5.Location = new System.Drawing.Point(27, 285);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(66, 27);
            this.numericUpDown5.TabIndex = 9;
            this.numericUpDown5.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownHeight = 212;
            this.comboBox1.DropDownWidth = 302;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(375, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(375, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Characteristic:";
            // 
            // labelMapHash
            // 
            this.labelMapHash.AutoSize = true;
            this.labelMapHash.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMapHash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(90)))));
            this.labelMapHash.Location = new System.Drawing.Point(195, 29);
            this.labelMapHash.Name = "labelMapHash";
            this.labelMapHash.Size = new System.Drawing.Size(0, 20);
            this.labelMapHash.TabIndex = 5;
            // 
            // MapCycle
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(572, 413);
            this.Controls.Add(this.labelMapHash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MapCycle";
            this.Text = "Hitbloq Command Generator by AntiLink (not official)";
            this.Load += new System.EventHandler(this.MapCycle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // store map
            currentSelection.hash = mapData[selectionIndex].versions[0].hash;
            storeCurrentCharacteristicState();
            selections.Add(currentSelection);

            // show new map
            comboBox1.SelectedIndex = 0;
            characteristicIndex = 0;
            if (selectionIndex < mapData.Count - 1)
            {
                selectionIndex++;
                currentSelection = getInitialSelectionFromMapData(mapData[selectionIndex]);
                reset();
                showMap(mapData[selectionIndex]);
                comboBox1.Items.Clear();
                mapData[selectionIndex].versions[0].getDiffsByCharacteristic().ForEach(characteristic =>
                {
                    comboBox1.Items.Add(characteristic.name);
                });

                return;
            }

            selectionIndex = 0;
            this.Close();
            new CommandDisplay(selections).ShowDialog();
        }

        private void MapCycle_Load(object sender, EventArgs e)
        {
            mapData[0].versions[0].getDiffsByCharacteristic().ForEach(characteristic =>
            {
                comboBox1.Items.Add(characteristic.name);
            });
            comboBox1.SelectedIndex = 0;

            currentSelection = getInitialSelectionFromMapData(mapData[0]);
            showMap(mapData[0]);
        }

        private MapSelection getInitialSelectionFromMapData(MapData data)
        {
            MapSelection initialSelection = new MapSelection();
            List<Difficulty> highlightedDiffs = new List<Difficulty>();
            if (highlightedDifficultyData.ContainsKey(data.versions[0].hash.ToUpper()))
            {
                highlightedDiffs = highlightedDifficultyData[data.versions[0].hash.ToUpper()];
            }
            data.versions[0].getDiffsByCharacteristic()
                .ConvertAll(diff => diff.name)
                .ForEach(characteristicName =>
            {
                MapSelectionCharacteristic mapSelectionCharacteristic = new MapSelectionCharacteristic();
                mapSelectionCharacteristic.name = characteristicName;

                foreach (Difficulty highlightedDiff in highlightedDiffs)
                {
                    if (characteristicName.Equals(highlightedDiff.Characteristic))
                    {
                        if (highlightedDiff.Name.ToLower().Equals("easy"))
                        {
                            mapSelectionCharacteristic.easy = true;
                        }
                        if (highlightedDiff.Name.ToLower().Equals("normal"))
                        {
                            mapSelectionCharacteristic.normal = true;
                        }
                        if (highlightedDiff.Name.ToLower().Equals("hard"))
                        {
                            mapSelectionCharacteristic.hard = true;
                        }
                        if (highlightedDiff.Name.ToLower().Equals("expert"))
                        {
                            mapSelectionCharacteristic.expert = true;
                        }
                        if (highlightedDiff.Name.ToLower().Equals("expertplus"))
                        {
                            mapSelectionCharacteristic.expertPlus = true;
                        }
                        break;
                    }
                }
                initialSelection.characteristics.Add(mapSelectionCharacteristic);
            });
            return initialSelection;
        }

        private void showMap(MapData map)
        {
            linkLabel1.Text = map.name;
            linkLabel1.Links.Clear();
            linkLabel1.Links.Add(0, map.name.Length, "https://beatsaver.com/maps/" + map.id);

            labelMapHash.Text = map.versions[0].hash.ToUpper();

            List<MapCharacteristic> diffsByCharacteristic = map.versions[0].getDiffsByCharacteristic();
            checkBox1.Visible = diffsByCharacteristic[characteristicIndex].hasDiff("Easy");
            checkBox2.Visible = diffsByCharacteristic[characteristicIndex].hasDiff("Normal");
            checkBox3.Visible = diffsByCharacteristic[characteristicIndex].hasDiff("Hard");
            checkBox4.Visible = diffsByCharacteristic[characteristicIndex].hasDiff("Expert");
            checkBox5.Visible = diffsByCharacteristic[characteristicIndex].hasDiff("ExpertPlus");

            //RESTORE DATA FROM CHARACTERISTIC
            MapSelectionCharacteristic characteristic = currentSelection.characteristics[characteristicIndex];
            checkBox1.Checked = characteristic.easy;
            checkBox2.Checked = characteristic.normal;
            checkBox3.Checked = characteristic.hard;
            checkBox4.Checked = characteristic.expert;
            checkBox5.Checked = characteristic.expertPlus;

            numericUpDown5.Value = characteristic.starsEasy;
            numericUpDown4.Value = characteristic.starsNormal;
            numericUpDown3.Value = characteristic.starsHard;
            numericUpDown2.Value = characteristic.starsExpert;
            numericUpDown1.Value = characteristic.starsExpertPlus;

            button2.Text = selectionIndex == mapData.Count - 1 ? "Show Commands" : "Next Map";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData.ToString();
            openInBrowser(url);
        }

        private void openInBrowser(string url)
        {
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = url;
                myProcess.Start();
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //Für jede Änderung MapData verändenr
            numericUpDown1.Visible = checkBox5.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.Visible = checkBox4.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Visible = checkBox3.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown4.Visible = checkBox2.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown5.Visible = checkBox1.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentSelection != null)
            {
                //STORE DATA
                storeCurrentCharacteristicState();

                //UPDATE INDEX
                characteristicIndex = comboBox1.SelectedIndex;

                //UPDATE DATA WITH NEW INDEX
                showMap(mapData[selectionIndex]);
            }
        }

        private void storeCurrentCharacteristicState()
        {
            MapSelectionCharacteristic characteristic = currentSelection.characteristics[characteristicIndex];
            characteristic.easy = checkBox1.Checked;
            characteristic.normal = checkBox2.Checked;
            characteristic.hard = checkBox3.Checked;
            characteristic.expert = checkBox4.Checked;
            characteristic.expertPlus = checkBox5.Checked;

            characteristic.starsEasy = numericUpDown5.Value;
            characteristic.starsNormal = numericUpDown4.Value;
            characteristic.starsHard = numericUpDown3.Value;
            characteristic.starsExpert = numericUpDown2.Value;
            characteristic.starsExpertPlus = numericUpDown1.Value;
            currentSelection.characteristics[characteristicIndex] = characteristic;
        }

        private void reset()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
        }
    }
}
