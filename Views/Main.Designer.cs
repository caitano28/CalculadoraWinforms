namespace Calculadora.Views
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.RtVisor = new System.Windows.Forms.RichTextBox();
            this.BtLimpar = new System.Windows.Forms.Button();
            this.BtBack = new System.Windows.Forms.Button();
            this.BtPercent = new System.Windows.Forms.Button();
            this.BtDivide = new System.Windows.Forms.Button();
            this.BtTimes = new System.Windows.Forms.Button();
            this.BtMinus = new System.Windows.Forms.Button();
            this.BtPlus = new System.Windows.Forms.Button();
            this.BtEquals = new System.Windows.Forms.Button();
            this.BtSete = new System.Windows.Forms.Button();
            this.BtOito = new System.Windows.Forms.Button();
            this.BtNove = new System.Windows.Forms.Button();
            this.BtSeis = new System.Windows.Forms.Button();
            this.BtCinco = new System.Windows.Forms.Button();
            this.BtQuatro = new System.Windows.Forms.Button();
            this.BtTres = new System.Windows.Forms.Button();
            this.BtDois = new System.Windows.Forms.Button();
            this.BtUm = new System.Windows.Forms.Button();
            this.BtVirgula = new System.Windows.Forms.Button();
            this.BtZero = new System.Windows.Forms.Button();
            this.BtMudaSinal = new System.Windows.Forms.Button();
            this.LbSubtotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RtVisor
            // 
            this.RtVisor.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.RtVisor.BackColor = System.Drawing.Color.Black;
            this.RtVisor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtVisor.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtVisor.ForeColor = System.Drawing.Color.White;
            this.RtVisor.Location = new System.Drawing.Point(5, 5);
            this.RtVisor.Multiline = false;
            this.RtVisor.Name = "RtVisor";
            this.RtVisor.ReadOnly = true;
            this.RtVisor.Size = new System.Drawing.Size(218, 104);
            this.RtVisor.TabIndex = 0;
            this.RtVisor.Text = "0";
            // 
            // BtLimpar
            // 
            this.BtLimpar.BackColor = System.Drawing.Color.White;
            this.BtLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLimpar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtLimpar.ForeColor = System.Drawing.Color.Red;
            this.BtLimpar.Location = new System.Drawing.Point(5, 115);
            this.BtLimpar.Name = "BtLimpar";
            this.BtLimpar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtLimpar.Size = new System.Drawing.Size(50, 50);
            this.BtLimpar.TabIndex = 1;
            this.BtLimpar.Text = "C";
            this.BtLimpar.UseVisualStyleBackColor = false;
            this.BtLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // BtBack
            // 
            this.BtBack.BackColor = System.Drawing.Color.DimGray;
            this.BtBack.BackgroundImage = global::Calculadora.Properties.Resources.backspace24;
            this.BtBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtBack.ForeColor = System.Drawing.Color.Lime;
            this.BtBack.Location = new System.Drawing.Point(61, 115);
            this.BtBack.Name = "BtBack";
            this.BtBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtBack.Size = new System.Drawing.Size(50, 50);
            this.BtBack.TabIndex = 2;
            this.BtBack.UseVisualStyleBackColor = false;
            this.BtBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // BtPercent
            // 
            this.BtPercent.BackColor = System.Drawing.Color.DimGray;
            this.BtPercent.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtPercent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPercent.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtPercent.ForeColor = System.Drawing.Color.Lime;
            this.BtPercent.Location = new System.Drawing.Point(117, 115);
            this.BtPercent.Name = "BtPercent";
            this.BtPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtPercent.Size = new System.Drawing.Size(50, 50);
            this.BtPercent.TabIndex = 3;
            this.BtPercent.Text = "%";
            this.BtPercent.UseVisualStyleBackColor = false;
            this.BtPercent.Click += new System.EventHandler(this.BtPercent_Click);
            // 
            // BtDivide
            // 
            this.BtDivide.BackColor = System.Drawing.Color.DimGray;
            this.BtDivide.BackgroundImage = global::Calculadora.Properties.Resources.divide24;
            this.BtDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtDivide.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDivide.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtDivide.ForeColor = System.Drawing.Color.Lime;
            this.BtDivide.Location = new System.Drawing.Point(173, 115);
            this.BtDivide.Name = "BtDivide";
            this.BtDivide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtDivide.Size = new System.Drawing.Size(50, 50);
            this.BtDivide.TabIndex = 4;
            this.BtDivide.UseVisualStyleBackColor = false;
            this.BtDivide.Click += new System.EventHandler(this.BtDivide_Click);
            // 
            // BtTimes
            // 
            this.BtTimes.BackColor = System.Drawing.Color.DimGray;
            this.BtTimes.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtTimes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtTimes.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtTimes.ForeColor = System.Drawing.Color.Lime;
            this.BtTimes.Location = new System.Drawing.Point(173, 170);
            this.BtTimes.Name = "BtTimes";
            this.BtTimes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtTimes.Size = new System.Drawing.Size(50, 50);
            this.BtTimes.TabIndex = 5;
            this.BtTimes.Text = "X";
            this.BtTimes.UseVisualStyleBackColor = false;
            this.BtTimes.Click += new System.EventHandler(this.BtTimes_Click);
            // 
            // BtMinus
            // 
            this.BtMinus.BackColor = System.Drawing.Color.DimGray;
            this.BtMinus.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMinus.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtMinus.ForeColor = System.Drawing.Color.Lime;
            this.BtMinus.Location = new System.Drawing.Point(173, 225);
            this.BtMinus.Name = "BtMinus";
            this.BtMinus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtMinus.Size = new System.Drawing.Size(50, 50);
            this.BtMinus.TabIndex = 6;
            this.BtMinus.Text = "-";
            this.BtMinus.UseVisualStyleBackColor = false;
            this.BtMinus.Click += new System.EventHandler(this.BtMinus_Click);
            // 
            // BtPlus
            // 
            this.BtPlus.BackColor = System.Drawing.Color.DimGray;
            this.BtPlus.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPlus.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtPlus.ForeColor = System.Drawing.Color.Lime;
            this.BtPlus.Location = new System.Drawing.Point(173, 281);
            this.BtPlus.Name = "BtPlus";
            this.BtPlus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtPlus.Size = new System.Drawing.Size(50, 50);
            this.BtPlus.TabIndex = 7;
            this.BtPlus.Text = "+";
            this.BtPlus.UseVisualStyleBackColor = false;
            this.BtPlus.Click += new System.EventHandler(this.BtPlus_Click);
            // 
            // BtEquals
            // 
            this.BtEquals.BackColor = System.Drawing.Color.Lime;
            this.BtEquals.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtEquals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEquals.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtEquals.ForeColor = System.Drawing.Color.White;
            this.BtEquals.Location = new System.Drawing.Point(173, 337);
            this.BtEquals.Name = "BtEquals";
            this.BtEquals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEquals.Size = new System.Drawing.Size(50, 50);
            this.BtEquals.TabIndex = 8;
            this.BtEquals.Text = "=";
            this.BtEquals.UseVisualStyleBackColor = false;
            this.BtEquals.Click += new System.EventHandler(this.BtEquals_Click);
            // 
            // BtSete
            // 
            this.BtSete.BackColor = System.Drawing.Color.DimGray;
            this.BtSete.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtSete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtSete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtSete.ForeColor = System.Drawing.Color.White;
            this.BtSete.Location = new System.Drawing.Point(5, 170);
            this.BtSete.Name = "BtSete";
            this.BtSete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtSete.Size = new System.Drawing.Size(50, 50);
            this.BtSete.TabIndex = 9;
            this.BtSete.Text = "7";
            this.BtSete.UseVisualStyleBackColor = false;
            this.BtSete.Click += new System.EventHandler(this.BtSeven_Click);
            // 
            // BtOito
            // 
            this.BtOito.BackColor = System.Drawing.Color.DimGray;
            this.BtOito.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtOito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtOito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtOito.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtOito.ForeColor = System.Drawing.Color.White;
            this.BtOito.Location = new System.Drawing.Point(61, 170);
            this.BtOito.Name = "BtOito";
            this.BtOito.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtOito.Size = new System.Drawing.Size(50, 50);
            this.BtOito.TabIndex = 10;
            this.BtOito.Text = "8";
            this.BtOito.UseVisualStyleBackColor = false;
            this.BtOito.Click += new System.EventHandler(this.BtEight_Click);
            // 
            // BtNove
            // 
            this.BtNove.BackColor = System.Drawing.Color.DimGray;
            this.BtNove.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtNove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtNove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNove.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtNove.ForeColor = System.Drawing.Color.White;
            this.BtNove.Location = new System.Drawing.Point(117, 170);
            this.BtNove.Name = "BtNove";
            this.BtNove.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtNove.Size = new System.Drawing.Size(50, 50);
            this.BtNove.TabIndex = 11;
            this.BtNove.Text = "9";
            this.BtNove.UseVisualStyleBackColor = false;
            this.BtNove.Click += new System.EventHandler(this.BtNine_Click);
            // 
            // BtSeis
            // 
            this.BtSeis.BackColor = System.Drawing.Color.DimGray;
            this.BtSeis.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtSeis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSeis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtSeis.ForeColor = System.Drawing.Color.White;
            this.BtSeis.Location = new System.Drawing.Point(117, 225);
            this.BtSeis.Name = "BtSeis";
            this.BtSeis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtSeis.Size = new System.Drawing.Size(50, 50);
            this.BtSeis.TabIndex = 14;
            this.BtSeis.Text = "6";
            this.BtSeis.UseVisualStyleBackColor = false;
            this.BtSeis.Click += new System.EventHandler(this.BtSix_Click);
            // 
            // BtCinco
            // 
            this.BtCinco.BackColor = System.Drawing.Color.DimGray;
            this.BtCinco.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtCinco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCinco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtCinco.ForeColor = System.Drawing.Color.White;
            this.BtCinco.Location = new System.Drawing.Point(61, 225);
            this.BtCinco.Name = "BtCinco";
            this.BtCinco.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtCinco.Size = new System.Drawing.Size(50, 50);
            this.BtCinco.TabIndex = 13;
            this.BtCinco.Text = "5";
            this.BtCinco.UseVisualStyleBackColor = false;
            this.BtCinco.Click += new System.EventHandler(this.BtFive_Click);
            // 
            // BtQuatro
            // 
            this.BtQuatro.BackColor = System.Drawing.Color.DimGray;
            this.BtQuatro.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtQuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtQuatro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtQuatro.ForeColor = System.Drawing.Color.White;
            this.BtQuatro.Location = new System.Drawing.Point(5, 225);
            this.BtQuatro.Name = "BtQuatro";
            this.BtQuatro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtQuatro.Size = new System.Drawing.Size(50, 50);
            this.BtQuatro.TabIndex = 12;
            this.BtQuatro.Text = "4";
            this.BtQuatro.UseVisualStyleBackColor = false;
            this.BtQuatro.Click += new System.EventHandler(this.BtFour_Click);
            // 
            // BtTres
            // 
            this.BtTres.BackColor = System.Drawing.Color.DimGray;
            this.BtTres.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtTres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtTres.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtTres.ForeColor = System.Drawing.Color.White;
            this.BtTres.Location = new System.Drawing.Point(117, 281);
            this.BtTres.Name = "BtTres";
            this.BtTres.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtTres.Size = new System.Drawing.Size(50, 50);
            this.BtTres.TabIndex = 17;
            this.BtTres.Text = "3";
            this.BtTres.UseVisualStyleBackColor = false;
            this.BtTres.Click += new System.EventHandler(this.BtThree_Click);
            // 
            // BtDois
            // 
            this.BtDois.BackColor = System.Drawing.Color.DimGray;
            this.BtDois.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtDois.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtDois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDois.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtDois.ForeColor = System.Drawing.Color.White;
            this.BtDois.Location = new System.Drawing.Point(61, 281);
            this.BtDois.Name = "BtDois";
            this.BtDois.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtDois.Size = new System.Drawing.Size(50, 50);
            this.BtDois.TabIndex = 16;
            this.BtDois.Text = "2";
            this.BtDois.UseVisualStyleBackColor = false;
            this.BtDois.Click += new System.EventHandler(this.BtTwo_Click);
            // 
            // BtUm
            // 
            this.BtUm.BackColor = System.Drawing.Color.DimGray;
            this.BtUm.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtUm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtUm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtUm.ForeColor = System.Drawing.Color.White;
            this.BtUm.Location = new System.Drawing.Point(5, 281);
            this.BtUm.Name = "BtUm";
            this.BtUm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtUm.Size = new System.Drawing.Size(50, 50);
            this.BtUm.TabIndex = 15;
            this.BtUm.Text = "1";
            this.BtUm.UseVisualStyleBackColor = false;
            this.BtUm.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // BtVirgula
            // 
            this.BtVirgula.BackColor = System.Drawing.Color.DimGray;
            this.BtVirgula.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtVirgula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVirgula.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtVirgula.ForeColor = System.Drawing.Color.White;
            this.BtVirgula.Location = new System.Drawing.Point(117, 337);
            this.BtVirgula.Name = "BtVirgula";
            this.BtVirgula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtVirgula.Size = new System.Drawing.Size(50, 50);
            this.BtVirgula.TabIndex = 20;
            this.BtVirgula.Text = ",";
            this.BtVirgula.UseVisualStyleBackColor = false;
            this.BtVirgula.Click += new System.EventHandler(this.BtComma_Click);
            // 
            // BtZero
            // 
            this.BtZero.BackColor = System.Drawing.Color.DimGray;
            this.BtZero.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtZero.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtZero.ForeColor = System.Drawing.Color.White;
            this.BtZero.Location = new System.Drawing.Point(61, 337);
            this.BtZero.Name = "BtZero";
            this.BtZero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtZero.Size = new System.Drawing.Size(50, 50);
            this.BtZero.TabIndex = 19;
            this.BtZero.Text = "0";
            this.BtZero.UseVisualStyleBackColor = false;
            this.BtZero.Click += new System.EventHandler(this.BtZero_Click);
            // 
            // BtMudaSinal
            // 
            this.BtMudaSinal.BackColor = System.Drawing.Color.DimGray;
            this.BtMudaSinal.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtMudaSinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtMudaSinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMudaSinal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtMudaSinal.ForeColor = System.Drawing.Color.White;
            this.BtMudaSinal.Location = new System.Drawing.Point(5, 337);
            this.BtMudaSinal.Name = "BtMudaSinal";
            this.BtMudaSinal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtMudaSinal.Size = new System.Drawing.Size(50, 50);
            this.BtMudaSinal.TabIndex = 18;
            this.BtMudaSinal.Text = "+/-";
            this.BtMudaSinal.UseVisualStyleBackColor = false;
            // 
            // LbSubtotal
            // 
            this.LbSubtotal.AutoSize = true;
            this.LbSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbSubtotal.ForeColor = System.Drawing.Color.DarkGray;
            this.LbSubtotal.Location = new System.Drawing.Point(5, 70);
            this.LbSubtotal.Name = "LbSubtotal";
            this.LbSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbSubtotal.Size = new System.Drawing.Size(19, 21);
            this.LbSubtotal.TabIndex = 21;
            this.LbSubtotal.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(228, 392);
            this.Controls.Add(this.LbSubtotal);
            this.Controls.Add(this.BtVirgula);
            this.Controls.Add(this.BtZero);
            this.Controls.Add(this.BtMudaSinal);
            this.Controls.Add(this.BtTres);
            this.Controls.Add(this.BtDois);
            this.Controls.Add(this.BtUm);
            this.Controls.Add(this.BtSeis);
            this.Controls.Add(this.BtCinco);
            this.Controls.Add(this.BtQuatro);
            this.Controls.Add(this.BtNove);
            this.Controls.Add(this.BtOito);
            this.Controls.Add(this.BtSete);
            this.Controls.Add(this.BtEquals);
            this.Controls.Add(this.BtPlus);
            this.Controls.Add(this.BtMinus);
            this.Controls.Add(this.BtTimes);
            this.Controls.Add(this.BtDivide);
            this.Controls.Add(this.BtPercent);
            this.Controls.Add(this.BtBack);
            this.Controls.Add(this.BtLimpar);
            this.Controls.Add(this.RtVisor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(244, 431);
            this.Name = "Main";
            this.Text = "Calculadora";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox RtVisor;
        private Button BtLimpar;
        private Button BtBack;
        private Button BtPercent;
        private Button BtDivide;
        private Button BtTimes;
        private Button BtMinus;
        private Button BtPlus;
        private Button BtEquals;
        private Button BtSete;
        private Button BtOito;
        private Button BtNove;
        private Button BtSeis;
        private Button BtCinco;
        private Button BtQuatro;
        private Button BtTres;
        private Button BtDois;
        private Button BtUm;
        private Button BtVirgula;
        private Button BtZero;
        private Button BtMudaSinal;
        private Label LbSubtotal;
    }
}