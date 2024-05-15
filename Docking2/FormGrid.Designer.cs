namespace Docking2
{
    partial class FormGrid
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrid));
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asoft_DemoDataSet = new Docking2.Asoft_DemoDataSet();
            this.nguoiDungTableAdapter = new Docking2.Asoft_DemoDataSetTableAdapters.NguoiDungTableAdapter();
            this.btnLoad = new C1.Win.C1Input.C1Button();
            this.c1Button2 = new C1.Win.C1Input.C1Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capNhatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asoft_DemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DataSource = this.nguoiDungBindingSource;
            this.c1FlexGrid1.Location = new System.Drawing.Point(40, 29);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Size = new System.Drawing.Size(629, 245);
            this.c1FlexGrid1.TabIndex = 0;
            this.c1FlexGrid1.RowColChange += new System.EventHandler(this.c1FlexGrid1_CellButtonClick);
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.asoft_DemoDataSet;
            // 
            // asoft_DemoDataSet
            // 
            this.asoft_DemoDataSet.DataSetName = "Asoft_DemoDataSet";
            this.asoft_DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(136, 343);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Tải lại";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.UseVisualStyleForeColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // c1Button2
            // 
            this.c1Button2.ContextMenuStrip = this.contextMenuStrip1;
            this.c1Button2.Location = new System.Drawing.Point(306, 343);
            this.c1Button2.Name = "c1Button2";
            this.c1Button2.Size = new System.Drawing.Size(108, 23);
            this.c1Button2.TabIndex = 2;
            this.c1Button2.Text = "Thực hiện";
            this.c1Button2.UseVisualStyleBackColor = true;
            this.c1Button2.UseVisualStyleForeColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themToolStripMenuItem,
            this.capNhatToolStripMenuItem,
            this.xoaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 76);
            // 
            // themToolStripMenuItem
            // 
            this.themToolStripMenuItem.Name = "themToolStripMenuItem";
            this.themToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.themToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.themToolStripMenuItem.Text = "Thêm";
            this.themToolStripMenuItem.Click += new System.EventHandler(this.themToolStripMenuItem_Click);
            // 
            // capNhatToolStripMenuItem
            // 
            this.capNhatToolStripMenuItem.Name = "capNhatToolStripMenuItem";
            this.capNhatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.capNhatToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.capNhatToolStripMenuItem.Text = "Cập nhật";
            this.capNhatToolStripMenuItem.Click += new System.EventHandler(this.capNhatToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.xoaToolStripMenuItem.Text = "Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(493, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.UseVisualStyleForeColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 471);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.c1Button2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.c1FlexGrid1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGrid";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asoft_DemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private Asoft_DemoDataSet asoft_DemoDataSet;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private Asoft_DemoDataSetTableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private C1.Win.C1Input.C1Button btnLoad;
        private C1.Win.C1Input.C1Button c1Button2;
        private C1.Win.C1Input.C1Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capNhatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
    }
}

