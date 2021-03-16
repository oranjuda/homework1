namespace HomeWork1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGoals = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToShow = new System.Windows.Forms.Label();
            this.btnShowPlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(69, 87);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(100, 28);
            this.btnAddPlayer.TabIndex = 0;
            this.btnAddPlayer.Text = "add player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtGoals
            // 
            this.txtGoals.Location = new System.Drawing.Point(69, 50);
            this.txtGoals.Name = "txtGoals";
            this.txtGoals.Size = new System.Drawing.Size(100, 22);
            this.txtGoals.TabIndex = 2;
            this.txtGoals.TextChanged += new System.EventHandler(this.txtGoals_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Goals:";
            // 
            // lblToShow
            // 
            this.lblToShow.AutoSize = true;
            this.lblToShow.Location = new System.Drawing.Point(17, 163);
            this.lblToShow.Name = "lblToShow";
            this.lblToShow.Size = new System.Drawing.Size(16, 17);
            this.lblToShow.TabIndex = 5;
            this.lblToShow.Text = "..";
            this.lblToShow.Click += new System.EventHandler(this.lblToShow_Click);
            // 
            // btnShowPlayers
            // 
            this.btnShowPlayers.Location = new System.Drawing.Point(69, 125);
            this.btnShowPlayers.Name = "btnShowPlayers";
            this.btnShowPlayers.Size = new System.Drawing.Size(100, 28);
            this.btnShowPlayers.TabIndex = 6;
            this.btnShowPlayers.Text = "Show players";
            this.btnShowPlayers.UseVisualStyleBackColor = true;
            this.btnShowPlayers.Click += new System.EventHandler(this.btnShowPlayers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowPlayers);
            this.Controls.Add(this.lblToShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGoals);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAddPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGoals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToShow;
        private System.Windows.Forms.Button btnShowPlayers;
    }
}

