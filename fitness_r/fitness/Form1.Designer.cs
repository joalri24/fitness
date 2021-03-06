﻿namespace fitness
{
    partial class Fitness
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
            this.label1 = new System.Windows.Forms.Label();
            this.initialSize = new System.Windows.Forms.NumericUpDown();
            this.aPercentaje = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.fitnessA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.growth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numCycles = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.replicas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.initialSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPercentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.growth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replicas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número inicial";
            // 
            // initialSize
            // 
            this.initialSize.Location = new System.Drawing.Point(100, 11);
            this.initialSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.initialSize.Name = "initialSize";
            this.initialSize.Size = new System.Drawing.Size(100, 20);
            this.initialSize.TabIndex = 1;
            this.initialSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // aPercentaje
            // 
            this.aPercentaje.Location = new System.Drawing.Point(100, 40);
            this.aPercentaje.Name = "aPercentaje";
            this.aPercentaje.Size = new System.Drawing.Size(62, 20);
            this.aPercentaje.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "% de A";
            // 
            // fitnessA
            // 
            this.fitnessA.DecimalPlaces = 2;
            this.fitnessA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.fitnessA.Location = new System.Drawing.Point(99, 71);
            this.fitnessA.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fitnessA.Name = "fitnessA";
            this.fitnessA.Size = new System.Drawing.Size(86, 20);
            this.fitnessA.TabIndex = 5;
            this.fitnessA.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fitness  de A";
            // 
            // growth
            // 
            this.growth.Location = new System.Drawing.Point(99, 103);
            this.growth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.growth.Name = "growth";
            this.growth.Size = new System.Drawing.Size(63, 20);
            this.growth.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Crecimiento";
            // 
            // numCycles
            // 
            this.numCycles.Location = new System.Drawing.Point(99, 139);
            this.numCycles.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numCycles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCycles.Name = "numCycles";
            this.numCycles.Size = new System.Drawing.Size(86, 20);
            this.numCycles.TabIndex = 9;
            this.numCycles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "# ciclos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Correr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "%";
            // 
            // replicas
            // 
            this.replicas.Location = new System.Drawing.Point(100, 186);
            this.replicas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.replicas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.replicas.Name = "replicas";
            this.replicas.Size = new System.Drawing.Size(86, 20);
            this.replicas.TabIndex = 13;
            this.replicas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "# Réplicas";
            // 
            // Fitness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 256);
            this.Controls.Add(this.replicas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numCycles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.growth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fitnessA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aPercentaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.initialSize);
            this.Controls.Add(this.label1);
            this.Name = "Fitness";
            this.Text = "Fitness";
            ((System.ComponentModel.ISupportInitialize)(this.initialSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPercentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.growth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown initialSize;
        private System.Windows.Forms.NumericUpDown aPercentaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown fitnessA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown growth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCycles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown replicas;
        private System.Windows.Forms.Label label7;
    }
}

