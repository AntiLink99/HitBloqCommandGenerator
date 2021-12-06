using System.Drawing;

namespace HitBloqCommandGenerator
{
    partial class MapInput
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapInput));
            this.mapLinksInput = new System.Windows.Forms.TextBox();
            this.addMapsButton = new System.Windows.Forms.Button();
            this.mapList = new System.Windows.Forms.ListView();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelPlaylists = new System.Windows.Forms.Label();
            this.fetchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mapLinksInput
            // 
            this.mapLinksInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mapLinksInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mapLinksInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mapLinksInput.ForeColor = System.Drawing.Color.White;
            this.mapLinksInput.Location = new System.Drawing.Point(45, 26);
            this.mapLinksInput.Multiline = true;
            this.mapLinksInput.Name = "mapLinksInput";
            this.mapLinksInput.PlaceholderText = "https://beatsaver.com/maps/19156";
            this.mapLinksInput.Size = new System.Drawing.Size(343, 404);
            this.mapLinksInput.TabIndex = 2;
            // 
            // addMapsButton
            // 
            this.addMapsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.addMapsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMapsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMapsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addMapsButton.ForeColor = System.Drawing.Color.White;
            this.addMapsButton.Location = new System.Drawing.Point(45, 454);
            this.addMapsButton.Name = "addMapsButton";
            this.addMapsButton.Size = new System.Drawing.Size(167, 66);
            this.addMapsButton.TabIndex = 3;
            this.addMapsButton.Text = "Import from Textbox";
            this.addMapsButton.UseVisualStyleBackColor = false;
            this.addMapsButton.Click += new System.EventHandler(this.onAddMapsButton);
            // 
            // mapList
            // 
            this.mapList.AutoArrange = false;
            this.mapList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.mapList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mapList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mapList.ForeColor = System.Drawing.Color.White;
            this.mapList.HideSelection = false;
            this.mapList.Location = new System.Drawing.Point(432, 26);
            this.mapList.Name = "mapList";
            this.mapList.Size = new System.Drawing.Size(500, 404);
            this.mapList.TabIndex = 7;
            this.mapList.UseCompatibleStateImageBehavior = false;
            this.mapList.View = System.Windows.Forms.View.List;
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.clearAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearAllButton.ForeColor = System.Drawing.Color.White;
            this.clearAllButton.Location = new System.Drawing.Point(578, 454);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(131, 55);
            this.clearAllButton.TabIndex = 3;
            this.clearAllButton.Text = "Clear all";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.onClearAllButton);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(233, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Import from Playlist";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.importPlaylist_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Select Playlist";
            this.openFileDialog1.Filter = "*.json; *.bplist|";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // labelPlaylists
            // 
            this.labelPlaylists.AutoSize = true;
            this.labelPlaylists.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlaylists.ForeColor = System.Drawing.Color.White;
            this.labelPlaylists.Location = new System.Drawing.Point(372, 22);
            this.labelPlaylists.Name = "labelPlaylists";
            this.labelPlaylists.Size = new System.Drawing.Size(0, 35);
            this.labelPlaylists.TabIndex = 9;
            // 
            // fetchButton
            // 
            this.fetchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.fetchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fetchButton.Enabled = false;
            this.fetchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fetchButton.ForeColor = System.Drawing.Color.White;
            this.fetchButton.Location = new System.Drawing.Point(432, 454);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(131, 55);
            this.fetchButton.TabIndex = 10;
            this.fetchButton.Text = "Fetch Maps";
            this.fetchButton.UseVisualStyleBackColor = false;
            this.fetchButton.Click += new System.EventHandler(this.onFetchMapsButton);
            // 
            // MapInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(974, 548);
            this.Controls.Add(this.fetchButton);
            this.Controls.Add(this.labelPlaylists);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.mapList);
            this.Controls.Add(this.addMapsButton);
            this.Controls.Add(this.mapLinksInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapInput";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hitbloq Command Generator by AntiLink (not official)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox mapLinksInput;
        private System.Windows.Forms.Button addMapsButton;
        private System.Windows.Forms.ListView mapList;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelPlaylists;
        private System.Windows.Forms.Button fetchButton;
    }
}

