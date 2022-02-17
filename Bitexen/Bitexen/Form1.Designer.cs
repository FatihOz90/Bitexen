
namespace Bitexen
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_ALIS = new System.Windows.Forms.DataGridView();
            this.DGV_SATIS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Symbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAlis = new System.Windows.Forms.Label();
            this.lblSatis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ALIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SATIS)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_ALIS
            // 
            this.DGV_ALIS.AllowUserToAddRows = false;
            this.DGV_ALIS.AllowUserToDeleteRows = false;
            this.DGV_ALIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ALIS.Location = new System.Drawing.Point(12, 55);
            this.DGV_ALIS.Name = "DGV_ALIS";
            this.DGV_ALIS.ReadOnly = true;
            this.DGV_ALIS.Size = new System.Drawing.Size(369, 721);
            this.DGV_ALIS.TabIndex = 0;
            // 
            // DGV_SATIS
            // 
            this.DGV_SATIS.AllowUserToAddRows = false;
            this.DGV_SATIS.AllowUserToDeleteRows = false;
            this.DGV_SATIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SATIS.Location = new System.Drawing.Point(387, 55);
            this.DGV_SATIS.Name = "DGV_SATIS";
            this.DGV_SATIS.ReadOnly = true;
            this.DGV_SATIS.Size = new System.Drawing.Size(377, 721);
            this.DGV_SATIS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alış Tablosu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Satış Tablosu";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Symbol});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(824, 55);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(174, 748);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Symbol
            // 
            this.Symbol.Text = "Symbol";
            this.Symbol.Width = 120;
            // 
            // lblAlis
            // 
            this.lblAlis.AutoSize = true;
            this.lblAlis.Location = new System.Drawing.Point(12, 779);
            this.lblAlis.Name = "lblAlis";
            this.lblAlis.Size = new System.Drawing.Size(35, 13);
            this.lblAlis.TabIndex = 36;
            this.lblAlis.Text = "label3";
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.Location = new System.Drawing.Point(384, 779);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(35, 13);
            this.lblSatis.TabIndex = 37;
            this.lblSatis.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 815);
            this.Controls.Add(this.lblSatis);
            this.Controls.Add(this.lblAlis);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_SATIS);
            this.Controls.Add(this.DGV_ALIS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ALIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SATIS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_ALIS;
        private System.Windows.Forms.DataGridView DGV_SATIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Symbol;
        private System.Windows.Forms.Label lblAlis;
        private System.Windows.Forms.Label lblSatis;
    }
}

