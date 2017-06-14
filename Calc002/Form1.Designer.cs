namespace Calc002
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.b1 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b00 = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.bBS = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bEq = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bMulti = new System.Windows.Forms.Button();
            this.display1 = new System.Windows.Forms.TextBox();
            this.display2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(3, 39);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(40, 40);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(95, 85);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(40, 40);
            this.b6.TabIndex = 5;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(49, 85);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(40, 40);
            this.b5.TabIndex = 4;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(3, 85);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(40, 40);
            this.b4.TabIndex = 3;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(95, 39);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(40, 40);
            this.b3.TabIndex = 2;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(49, 39);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(40, 40);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.b00, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bC, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bCE, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bBS, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.b0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.b1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.b6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.b9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.b5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.b8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.b4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.b7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.b3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.b2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bDot, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(136, 232);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // b00
            // 
            this.b00.Location = new System.Drawing.Point(49, 177);
            this.b00.Name = "b00";
            this.b00.Size = new System.Drawing.Size(40, 40);
            this.b00.TabIndex = 34;
            this.b00.Text = "00";
            this.b00.UseVisualStyleBackColor = true;
            this.b00.Click += new System.EventHandler(this.b00_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(95, 3);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(40, 30);
            this.bC.TabIndex = 33;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bCE
            // 
            this.bCE.Location = new System.Drawing.Point(49, 3);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(40, 30);
            this.bCE.TabIndex = 32;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // bBS
            // 
            this.bBS.Location = new System.Drawing.Point(3, 3);
            this.bBS.Name = "bBS";
            this.bBS.Size = new System.Drawing.Size(40, 30);
            this.bBS.TabIndex = 31;
            this.bBS.Text = "BS";
            this.bBS.UseVisualStyleBackColor = true;
            this.bBS.Click += new System.EventHandler(this.bBS_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(3, 177);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(40, 40);
            this.b0.TabIndex = 9;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(95, 131);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(40, 40);
            this.b9.TabIndex = 8;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(49, 131);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(40, 40);
            this.b8.TabIndex = 7;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(3, 131);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(40, 40);
            this.b7.TabIndex = 6;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // bDot
            // 
            this.bDot.Location = new System.Drawing.Point(95, 177);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(40, 40);
            this.bDot.TabIndex = 10;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = true;
            this.bDot.Click += new System.EventHandler(this.bDot_Click);
            // 
            // bPlus
            // 
            this.bPlus.Location = new System.Drawing.Point(3, 3);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(40, 30);
            this.bPlus.TabIndex = 21;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bMinus
            // 
            this.bMinus.Location = new System.Drawing.Point(3, 49);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(40, 30);
            this.bMinus.TabIndex = 22;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.bEq, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.bDiv, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.bMulti, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bPlus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bMinus, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(152, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(48, 232);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // bEq
            // 
            this.bEq.Location = new System.Drawing.Point(3, 187);
            this.bEq.Name = "bEq";
            this.bEq.Size = new System.Drawing.Size(40, 31);
            this.bEq.TabIndex = 25;
            this.bEq.Text = "=";
            this.bEq.UseVisualStyleBackColor = true;
            this.bEq.Click += new System.EventHandler(this.bEq_Click);
            // 
            // bDiv
            // 
            this.bDiv.Location = new System.Drawing.Point(3, 141);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(40, 30);
            this.bDiv.TabIndex = 24;
            this.bDiv.Text = "÷";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // bMulti
            // 
            this.bMulti.Location = new System.Drawing.Point(3, 95);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(40, 30);
            this.bMulti.TabIndex = 23;
            this.bMulti.Text = "×";
            this.bMulti.UseVisualStyleBackColor = true;
            this.bMulti.Click += new System.EventHandler(this.bMulti_Click);
            // 
            // display1
            // 
            this.display1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.display1.Location = new System.Drawing.Point(8, 32);
            this.display1.Name = "display1";
            this.display1.ReadOnly = true;
            this.display1.Size = new System.Drawing.Size(200, 19);
            this.display1.TabIndex = 31;
            this.display1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // display2
            // 
            this.display2.Location = new System.Drawing.Point(184, 8);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(24, 19);
            this.display2.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 283);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.display1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calc";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bEq;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bBS;
        private System.Windows.Forms.TextBox display1;
        private System.Windows.Forms.TextBox display2;
        private System.Windows.Forms.Button b00;
    }
}

