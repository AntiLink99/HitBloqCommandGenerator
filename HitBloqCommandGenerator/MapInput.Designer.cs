namespace HitBloqCommandGenerator
{
    partial class MapInput
    {
        System.Windows.Forms.Button fetchSongsButton;

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
            fetchSongsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mapLinksInput
            // 
            this.mapLinksInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mapLinksInput.Location = new System.Drawing.Point(45, 57);
            this.mapLinksInput.Multiline = true;
            this.mapLinksInput.Name = "mapLinksInput";
            this.mapLinksInput.Size = new System.Drawing.Size(343, 404);
            this.mapLinksInput.TabIndex = 2;
            // 
            // addMapsButton
            // 
            this.addMapsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addMapsButton.Location = new System.Drawing.Point(45, 485);
            this.addMapsButton.Name = "addMapsButton";
            this.addMapsButton.Size = new System.Drawing.Size(201, 55);
            this.addMapsButton.TabIndex = 3;
            this.addMapsButton.Text = "Add Map(s) to List";
            this.addMapsButton.UseVisualStyleBackColor = true;
            this.addMapsButton.Click += new System.EventHandler(this.onAddMapsButton);
            // 
            // mapList
            // 
            this.mapList.AutoArrange = false;
            this.mapList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mapList.HideSelection = false;
            this.mapList.Location = new System.Drawing.Point(432, 57);
            this.mapList.Name = "mapList";
            this.mapList.Size = new System.Drawing.Size(761, 404);
            this.mapList.TabIndex = 7;
            this.mapList.UseCompatibleStateImageBehavior = false;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearAllButton.Location = new System.Drawing.Point(569, 485);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(131, 55);
            this.clearAllButton.TabIndex = 3;
            this.clearAllButton.Text = "Clear all";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.onClearAllButton);
            // 
            // fetchSongsButton
            // 
            fetchSongsButton.Enabled = false;
            fetchSongsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            fetchSongsButton.Location = new System.Drawing.Point(432, 485);
            fetchSongsButton.Name = "fetchSongsButton";
            fetchSongsButton.Size = new System.Drawing.Size(131, 55);
            fetchSongsButton.TabIndex = 3;
            fetchSongsButton.Text = "Fetch Maps";
            fetchSongsButton.UseVisualStyleBackColor = true;
            fetchSongsButton.Click += new System.EventHandler(this.onFetchMapsButton);
            // 
            // MapInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 593);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.mapList);
            this.Controls.Add(this.addMapsButton);
            this.Controls.Add(fetchSongsButton);
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
    }
}

