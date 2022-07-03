
namespace SmartHeater
{
    partial class SmartHeater
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartHeater));
            this.tempVal = new System.Windows.Forms.Label();
            this.tempTXT = new System.Windows.Forms.Label();
            this.bordure1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bordure2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.battrypowerValue = new System.Windows.Forms.ProgressBar();
            this.batteryPowerTXT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshData = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.buttonrefresh = new System.Windows.Forms.Button();
            this.tempRadTXT = new System.Windows.Forms.Label();
            this.tensionBatTXT = new System.Windows.Forms.Label();
            this.gridPowerTXT = new System.Windows.Forms.Label();
            this.bordure3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.controleurTXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tempVal
            // 
            this.tempVal.BackColor = System.Drawing.Color.Silver;
            this.tempVal.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempVal.Location = new System.Drawing.Point(297, 51);
            this.tempVal.Name = "tempVal";
            this.tempVal.Size = new System.Drawing.Size(104, 19);
            this.tempVal.TabIndex = 1;
            // 
            // tempTXT
            // 
            this.tempTXT.AutoSize = true;
            this.tempTXT.BackColor = System.Drawing.Color.Silver;
            this.tempTXT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTXT.Location = new System.Drawing.Point(61, 50);
            this.tempTXT.Name = "tempTXT";
            this.tempTXT.Size = new System.Drawing.Size(216, 19);
            this.tempTXT.TabIndex = 2;
            this.tempTXT.Text = "Température extérieur :";
            // 
            // bordure1
            // 
            this.bordure1.BackColor = System.Drawing.Color.Silver;
            this.bordure1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bordure1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bordure1.Location = new System.Drawing.Point(40, 34);
            this.bordure1.Name = "bordure1";
            this.bordure1.Size = new System.Drawing.Size(363, 60);
            this.bordure1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Température radiateur :";
            // 
            // bordure2
            // 
            this.bordure2.BackColor = System.Drawing.Color.Silver;
            this.bordure2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bordure2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bordure2.Location = new System.Drawing.Point(40, 136);
            this.bordure2.Name = "bordure2";
            this.bordure2.Size = new System.Drawing.Size(691, 203);
            this.bordure2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tension batterie      :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Battery power         :";
            // 
            // battrypowerValue
            // 
            this.battrypowerValue.Location = new System.Drawing.Point(303, 247);
            this.battrypowerValue.Name = "battrypowerValue";
            this.battrypowerValue.Size = new System.Drawing.Size(112, 23);
            this.battrypowerValue.TabIndex = 8;
            this.battrypowerValue.Value = 63;
            // 
            // batteryPowerTXT
            // 
            this.batteryPowerTXT.BackColor = System.Drawing.Color.Silver;
            this.batteryPowerTXT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryPowerTXT.Location = new System.Drawing.Point(421, 250);
            this.batteryPowerTXT.Name = "batteryPowerTXT";
            this.batteryPowerTXT.Size = new System.Drawing.Size(118, 25);
            this.batteryPowerTXT.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Grid power            :";
            // 
            // refreshData
            // 
            this.refreshData.Interval = 5000;
            this.refreshData.Tick += new System.EventHandler(this.refreshData_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(691, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pierre FORQUIN";
            // 
            // buttonrefresh
            // 
            this.buttonrefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonrefresh.BackgroundImage")));
            this.buttonrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonrefresh.Location = new System.Drawing.Point(754, 12);
            this.buttonrefresh.Name = "buttonrefresh";
            this.buttonrefresh.Size = new System.Drawing.Size(42, 41);
            this.buttonrefresh.TabIndex = 12;
            this.buttonrefresh.UseVisualStyleBackColor = true;
            this.buttonrefresh.Click += new System.EventHandler(this.buttonrefresh_Click);
            // 
            // tempRadTXT
            // 
            this.tempRadTXT.BackColor = System.Drawing.Color.Silver;
            this.tempRadTXT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempRadTXT.Location = new System.Drawing.Point(297, 155);
            this.tempRadTXT.Name = "tempRadTXT";
            this.tempRadTXT.Size = new System.Drawing.Size(118, 25);
            this.tempRadTXT.TabIndex = 13;
            // 
            // tensionBatTXT
            // 
            this.tensionBatTXT.BackColor = System.Drawing.Color.Silver;
            this.tensionBatTXT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensionBatTXT.Location = new System.Drawing.Point(297, 205);
            this.tensionBatTXT.Name = "tensionBatTXT";
            this.tensionBatTXT.Size = new System.Drawing.Size(118, 25);
            this.tensionBatTXT.TabIndex = 14;
            // 
            // gridPowerTXT
            // 
            this.gridPowerTXT.BackColor = System.Drawing.Color.Silver;
            this.gridPowerTXT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPowerTXT.Location = new System.Drawing.Point(297, 300);
            this.gridPowerTXT.Name = "gridPowerTXT";
            this.gridPowerTXT.Size = new System.Drawing.Size(118, 25);
            this.gridPowerTXT.TabIndex = 15;
            // 
            // bordure3
            // 
            this.bordure3.BackColor = System.Drawing.Color.Silver;
            this.bordure3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bordure3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bordure3.Location = new System.Drawing.Point(425, 34);
            this.bordure3.Name = "bordure3";
            this.bordure3.Size = new System.Drawing.Size(306, 60);
            this.bordure3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Contrôleur :";
            // 
            // controleurTXT
            // 
            this.controleurTXT.BackColor = System.Drawing.Color.Silver;
            this.controleurTXT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controleurTXT.Location = new System.Drawing.Point(562, 52);
            this.controleurTXT.Name = "controleurTXT";
            this.controleurTXT.Size = new System.Drawing.Size(156, 25);
            this.controleurTXT.TabIndex = 18;
            // 
            // SmartHeater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(808, 439);
            this.Controls.Add(this.controleurTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bordure3);
            this.Controls.Add(this.gridPowerTXT);
            this.Controls.Add(this.tensionBatTXT);
            this.Controls.Add(this.tempRadTXT);
            this.Controls.Add(this.buttonrefresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.batteryPowerTXT);
            this.Controls.Add(this.battrypowerValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bordure2);
            this.Controls.Add(this.tempTXT);
            this.Controls.Add(this.tempVal);
            this.Controls.Add(this.bordure1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SmartHeater";
            this.Text = "SmartHeater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tempVal;
        private System.Windows.Forms.Label tempTXT;
        private System.Windows.Forms.Label bordure1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bordure2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar battrypowerValue;
        private System.Windows.Forms.Label batteryPowerTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer refreshData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonrefresh;
        private System.Windows.Forms.Label tempRadTXT;
        private System.Windows.Forms.Label tensionBatTXT;
        private System.Windows.Forms.Label gridPowerTXT;
        private System.Windows.Forms.Label bordure3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label controleurTXT;
    }
}

