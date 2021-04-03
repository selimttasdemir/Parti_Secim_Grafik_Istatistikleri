
namespace Parti_Secim_Grafik_Istatistikleri
{
    partial class Grafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbGrafikler = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbilceDegerleri = new System.Windows.Forms.GroupBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pBe = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pBd = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.pBc = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pBb = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pBa = new System.Windows.Forms.ProgressBar();
            this.cbIlceSecin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbGrafikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gbilceDegerleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGrafikler
            // 
            this.gbGrafikler.Controls.Add(this.chart1);
            this.gbGrafikler.Location = new System.Drawing.Point(3, 12);
            this.gbGrafikler.Name = "gbGrafikler";
            this.gbGrafikler.Size = new System.Drawing.Size(875, 302);
            this.gbGrafikler.TabIndex = 0;
            this.gbGrafikler.TabStop = false;
            this.gbGrafikler.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 22);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(869, 277);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // gbilceDegerleri
            // 
            this.gbilceDegerleri.Controls.Add(this.btnExit);
            this.gbilceDegerleri.Controls.Add(this.lblE);
            this.gbilceDegerleri.Controls.Add(this.lblD);
            this.gbilceDegerleri.Controls.Add(this.lblC);
            this.gbilceDegerleri.Controls.Add(this.lblB);
            this.gbilceDegerleri.Controls.Add(this.lblA);
            this.gbilceDegerleri.Controls.Add(this.label6);
            this.gbilceDegerleri.Controls.Add(this.pBe);
            this.gbilceDegerleri.Controls.Add(this.label5);
            this.gbilceDegerleri.Controls.Add(this.pBd);
            this.gbilceDegerleri.Controls.Add(this.label4);
            this.gbilceDegerleri.Controls.Add(this.pBc);
            this.gbilceDegerleri.Controls.Add(this.label3);
            this.gbilceDegerleri.Controls.Add(this.pBb);
            this.gbilceDegerleri.Controls.Add(this.label2);
            this.gbilceDegerleri.Controls.Add(this.pBa);
            this.gbilceDegerleri.Controls.Add(this.cbIlceSecin);
            this.gbilceDegerleri.Controls.Add(this.label1);
            this.gbilceDegerleri.Location = new System.Drawing.Point(3, 320);
            this.gbilceDegerleri.Name = "gbilceDegerleri";
            this.gbilceDegerleri.Size = new System.Drawing.Size(869, 296);
            this.gbilceDegerleri.TabIndex = 1;
            this.gbilceDegerleri.TabStop = false;
            this.gbilceDegerleri.Text = "İlçe Değerleri";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(611, 258);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(49, 18);
            this.lblE.TabIndex = 16;
            this.lblE.Text = "% 00";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(611, 217);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(49, 18);
            this.lblD.TabIndex = 15;
            this.lblD.Text = "% 00";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(611, 176);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(49, 18);
            this.lblC.TabIndex = 14;
            this.lblC.Text = "% 00";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(611, 135);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(49, 18);
            this.lblB.TabIndex = 13;
            this.lblB.Text = "% 00";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(611, 94);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(49, 18);
            this.lblA.TabIndex = 12;
            this.lblA.Text = "% 00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "E PARTİSİ :";
            // 
            // pBe
            // 
            this.pBe.Location = new System.Drawing.Point(151, 250);
            this.pBe.Maximum = 600;
            this.pBe.Name = "pBe";
            this.pBe.Size = new System.Drawing.Size(443, 35);
            this.pBe.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "D PARTİSİ :";
            // 
            // pBd
            // 
            this.pBd.Location = new System.Drawing.Point(151, 209);
            this.pBd.Maximum = 600;
            this.pBd.Name = "pBd";
            this.pBd.Size = new System.Drawing.Size(443, 35);
            this.pBd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "C PARTİSİ :";
            // 
            // pBc
            // 
            this.pBc.Location = new System.Drawing.Point(151, 168);
            this.pBc.Maximum = 600;
            this.pBc.Name = "pBc";
            this.pBc.Size = new System.Drawing.Size(443, 35);
            this.pBc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "B PARTİSİ :";
            // 
            // pBb
            // 
            this.pBb.Location = new System.Drawing.Point(151, 127);
            this.pBb.Maximum = 600;
            this.pBb.Name = "pBb";
            this.pBb.Size = new System.Drawing.Size(443, 35);
            this.pBb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "A PARTİSİ :";
            // 
            // pBa
            // 
            this.pBa.Location = new System.Drawing.Point(151, 86);
            this.pBa.Maximum = 600;
            this.pBa.Name = "pBa";
            this.pBa.Size = new System.Drawing.Size(443, 35);
            this.pBa.TabIndex = 2;
            // 
            // cbIlceSecin
            // 
            this.cbIlceSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIlceSecin.Font = new System.Drawing.Font("Georgia", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbIlceSecin.FormattingEnabled = true;
            this.cbIlceSecin.Location = new System.Drawing.Point(151, 36);
            this.cbIlceSecin.Name = "cbIlceSecin";
            this.cbIlceSecin.Size = new System.Drawing.Size(241, 31);
            this.cbIlceSecin.TabIndex = 1;
            this.cbIlceSecin.SelectedIndexChanged += new System.EventHandler(this.cbIlceSecin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(765, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 36);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Grafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(890, 628);
            this.Controls.Add(this.gbilceDegerleri);
            this.Controls.Add(this.gbGrafikler);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Grafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafikler";
            this.Load += new System.EventHandler(this.Grafikler_Load);
            this.gbGrafikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gbilceDegerleri.ResumeLayout(false);
            this.gbilceDegerleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGrafikler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox gbilceDegerleri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pBe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pBd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pBc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pBb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pBa;
        private System.Windows.Forms.ComboBox cbIlceSecin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button btnExit;
    }
}