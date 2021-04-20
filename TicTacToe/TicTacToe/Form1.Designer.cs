namespace TicTacToe
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tr = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.cc = new System.Windows.Forms.Button();
            this.cr = new System.Windows.Forms.Button();
            this.bl = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.br = new System.Windows.Forms.Button();
            this.tl = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.tr, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cr, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.br, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tc, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 289);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tr
            // 
            this.tr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tr.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tr.Location = new System.Drawing.Point(241, 3);
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(115, 90);
            this.tr.TabIndex = 1;
            this.tr.Tag = "tr";
            this.tr.UseVisualStyleBackColor = true;
            this.tr.Click += new System.EventHandler(this.Mark);
            // 
            // cl
            // 
            this.cl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cl.Location = new System.Drawing.Point(3, 99);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(113, 90);
            this.cl.TabIndex = 2;
            this.cl.Tag = "cl";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.Mark);
            // 
            // cc
            // 
            this.cc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cc.Location = new System.Drawing.Point(122, 99);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(113, 90);
            this.cc.TabIndex = 3;
            this.cc.Tag = "cc";
            this.cc.UseVisualStyleBackColor = true;
            this.cc.Click += new System.EventHandler(this.Mark);
            // 
            // cr
            // 
            this.cr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cr.Location = new System.Drawing.Point(241, 99);
            this.cr.Name = "cr";
            this.cr.Size = new System.Drawing.Size(115, 90);
            this.cr.TabIndex = 4;
            this.cr.Tag = "cr";
            this.cr.UseVisualStyleBackColor = true;
            this.cr.Click += new System.EventHandler(this.Mark);
            // 
            // bl
            // 
            this.bl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bl.Location = new System.Drawing.Point(3, 195);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(113, 91);
            this.bl.TabIndex = 5;
            this.bl.Tag = "bl";
            this.bl.UseVisualStyleBackColor = true;
            this.bl.Click += new System.EventHandler(this.Mark);
            // 
            // bc
            // 
            this.bc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bc.Location = new System.Drawing.Point(122, 195);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(113, 91);
            this.bc.TabIndex = 6;
            this.bc.Tag = "bc";
            this.bc.UseVisualStyleBackColor = true;
            this.bc.Click += new System.EventHandler(this.Mark);
            // 
            // br
            // 
            this.br.Dock = System.Windows.Forms.DockStyle.Fill;
            this.br.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.br.Location = new System.Drawing.Point(241, 195);
            this.br.Name = "br";
            this.br.Size = new System.Drawing.Size(115, 91);
            this.br.TabIndex = 7;
            this.br.Tag = "br";
            this.br.UseVisualStyleBackColor = true;
            this.br.Click += new System.EventHandler(this.Mark);
            // 
            // tl
            // 
            this.tl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tl.Location = new System.Drawing.Point(3, 3);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(113, 90);
            this.tl.TabIndex = 0;
            this.tl.Tag = "tl";
            this.tl.UseVisualStyleBackColor = true;
            this.tl.Click += new System.EventHandler(this.Mark);
            // 
            // tc
            // 
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tc.Location = new System.Drawing.Point(122, 3);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(113, 90);
            this.tc.TabIndex = 1;
            this.tc.Tag = "tc";
            this.tc.UseVisualStyleBackColor = true;
            this.tc.Click += new System.EventHandler(this.Mark);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktualny ruch: ";
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.Location = new System.Drawing.Point(109, 320);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(0, 15);
            this.currentPlayerLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 355);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button tr;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button cc;
        private System.Windows.Forms.Button cr;
        private System.Windows.Forms.Button bl;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button br;
        private System.Windows.Forms.Button tl;
        private System.Windows.Forms.Button tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentPlayerLabel;
    }
}

