﻿
namespace Timer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_keres = new System.Windows.Forms.TextBox();
            this.dgw_nonActive = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.but_active = new System.Windows.Forms.Button();
            this.but_deactive = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.but_saveCSV = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.but_act_start = new System.Windows.Forms.Button();
            this.but_act_stop = new System.Windows.Forms.Button();
            this.but_act_pause = new System.Windows.Forms.Button();
            this.dgw_active = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_nonActive)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_active)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_keres, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgw_nonActive, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.764237F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.432433F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.93694F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(314, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keresés";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tb_keres
            // 
            this.tb_keres.Location = new System.Drawing.Point(3, 28);
            this.tb_keres.Name = "tb_keres";
            this.tb_keres.Size = new System.Drawing.Size(100, 20);
            this.tb_keres.TabIndex = 1;
            // 
            // dgw_nonActive
            // 
            this.dgw_nonActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_nonActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_nonActive.Location = new System.Drawing.Point(3, 60);
            this.dgw_nonActive.Name = "dgw_nonActive";
            this.dgw_nonActive.Size = new System.Drawing.Size(350, 381);
            this.dgw_nonActive.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.but_active, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.but_deactive, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(323, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(154, 444);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // but_active
            // 
            this.but_active.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_active.Location = new System.Drawing.Point(3, 136);
            this.but_active.Name = "but_active";
            this.but_active.Size = new System.Drawing.Size(200, 82);
            this.but_active.TabIndex = 0;
            this.but_active.Text = "Aktiválás";
            this.but_active.UseVisualStyleBackColor = true;
            // 
            // but_deactive
            // 
            this.but_deactive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_deactive.Location = new System.Drawing.Point(3, 224);
            this.but_deactive.Name = "but_deactive";
            this.but_deactive.Size = new System.Drawing.Size(200, 82);
            this.but_deactive.TabIndex = 1;
            this.but_deactive.Text = "Deaktiválás";
            this.but_deactive.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.but_saveCSV, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 312);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 129);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // but_saveCSV
            // 
            this.but_saveCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_saveCSV.Location = new System.Drawing.Point(3, 80);
            this.but_saveCSV.Name = "but_saveCSV";
            this.but_saveCSV.Size = new System.Drawing.Size(194, 32);
            this.but_saveCSV.TabIndex = 0;
            this.but_saveCSV.Text = "CSV-be mentés";
            this.but_saveCSV.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dgw_active, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(483, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(314, 444);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.424658F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.76712F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.424658F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.76712F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.424658F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.76712F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.424658F));
            this.tableLayoutPanel5.Controls.Add(this.but_act_start, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.but_act_stop, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.but_act_pause, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(308, 47);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // but_act_start
            // 
            this.but_act_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_act_start.Location = new System.Drawing.Point(13, 3);
            this.but_act_start.Name = "but_act_start";
            this.but_act_start.Size = new System.Drawing.Size(82, 41);
            this.but_act_start.TabIndex = 0;
            this.but_act_start.Text = "Start";
            this.but_act_start.UseVisualStyleBackColor = true;
            // 
            // but_act_stop
            // 
            this.but_act_stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_act_stop.Location = new System.Drawing.Point(209, 3);
            this.but_act_stop.Name = "but_act_stop";
            this.but_act_stop.Size = new System.Drawing.Size(82, 41);
            this.but_act_stop.TabIndex = 2;
            this.but_act_stop.Text = "Stop";
            this.but_act_stop.UseVisualStyleBackColor = true;
            // 
            // but_act_pause
            // 
            this.but_act_pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_act_pause.Location = new System.Drawing.Point(111, 3);
            this.but_act_pause.Name = "but_act_pause";
            this.but_act_pause.Size = new System.Drawing.Size(82, 41);
            this.but_act_pause.TabIndex = 3;
            this.but_act_pause.Text = "Szünet";
            this.but_act_pause.UseVisualStyleBackColor = true;
            // 
            // dgw_active
            // 
            this.dgw_active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_active.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_active.Location = new System.Drawing.Point(3, 56);
            this.dgw_active.Name = "dgw_active";
            this.dgw_active.Size = new System.Drawing.Size(308, 385);
            this.dgw_active.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_nonActive)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_active)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_keres;
        private System.Windows.Forms.DataGridView dgw_nonActive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button but_active;
        private System.Windows.Forms.Button but_deactive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button but_act_start;
        private System.Windows.Forms.Button but_act_stop;
        private System.Windows.Forms.DataGridView dgw_active;
        private System.Windows.Forms.Button but_act_pause;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button but_saveCSV;
    }
}

