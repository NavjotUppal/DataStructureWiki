﻿namespace DataStructureWiki
{
    partial class DataStructureWiki
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxStructure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonEDIT = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.buttonLOAD = new System.Windows.Forms.Button();
            this.buttonSAVE = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSEARCH = new System.Windows.Forms.Button();
            this.listViewData = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStripMsg = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Structure";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(132, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(132, 75);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(200, 22);
            this.textBoxCategory.TabIndex = 4;
            // 
            // textBoxStructure
            // 
            this.textBoxStructure.Location = new System.Drawing.Point(132, 114);
            this.textBoxStructure.Name = "textBoxStructure";
            this.textBoxStructure.Size = new System.Drawing.Size(200, 22);
            this.textBoxStructure.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AllowDrop = true;
            this.textBoxDescription.Location = new System.Drawing.Point(132, 158);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 220);
            this.textBoxDescription.TabIndex = 7;
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(16, 403);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(75, 23);
            this.buttonADD.TabIndex = 8;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonEDIT
            // 
            this.buttonEDIT.Location = new System.Drawing.Point(154, 402);
            this.buttonEDIT.Name = "buttonEDIT";
            this.buttonEDIT.Size = new System.Drawing.Size(75, 23);
            this.buttonEDIT.TabIndex = 9;
            this.buttonEDIT.Text = "EDIT";
            this.buttonEDIT.UseVisualStyleBackColor = true;
            this.buttonEDIT.Click += new System.EventHandler(this.buttonEDIT_Click);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(293, 402);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(75, 23);
            this.buttonDELETE.TabIndex = 10;
            this.buttonDELETE.Text = "DELETE";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            // 
            // buttonLOAD
            // 
            this.buttonLOAD.Location = new System.Drawing.Point(495, 29);
            this.buttonLOAD.Name = "buttonLOAD";
            this.buttonLOAD.Size = new System.Drawing.Size(75, 23);
            this.buttonLOAD.TabIndex = 12;
            this.buttonLOAD.Text = "LOAD";
            this.buttonLOAD.UseVisualStyleBackColor = true;
            // 
            // buttonSAVE
            // 
            this.buttonSAVE.Location = new System.Drawing.Point(689, 29);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(75, 23);
            this.buttonSAVE.TabIndex = 13;
            this.buttonSAVE.Text = "SAVE";
            this.buttonSAVE.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(495, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 22);
            this.textBox1.TabIndex = 14;
            // 
            // buttonSEARCH
            // 
            this.buttonSEARCH.Location = new System.Drawing.Point(709, 403);
            this.buttonSEARCH.Name = "buttonSEARCH";
            this.buttonSEARCH.Size = new System.Drawing.Size(84, 23);
            this.buttonSEARCH.TabIndex = 15;
            this.buttonSEARCH.Text = "SEARCH";
            this.buttonSEARCH.UseVisualStyleBackColor = true;
            // 
            // listViewData
            // 
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderCategory});
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(495, 96);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(269, 271);
            this.listViewData.TabIndex = 16;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 100;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            this.columnHeaderCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCategory.Width = 100;
            // 
            // statusStripMsg
            // 
            this.statusStripMsg.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMsg.Location = new System.Drawing.Point(0, 472);
            this.statusStripMsg.Name = "statusStripMsg";
            this.statusStripMsg.Size = new System.Drawing.Size(912, 22);
            this.statusStripMsg.TabIndex = 17;
            this.statusStripMsg.Text = "statusStrip1";
            // 
            // DataStructureWiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 494);
            this.Controls.Add(this.statusStripMsg);
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.buttonSEARCH);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSAVE);
            this.Controls.Add(this.buttonLOAD);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.buttonEDIT);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStructure);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DataStructureWiki";
            this.Text = "Data Structure Wiki ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxStructure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonEDIT;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Button buttonLOAD;
        private System.Windows.Forms.Button buttonSAVE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSEARCH;
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.StatusStrip statusStripMsg;
    }
}

