namespace XMLVeriİslemleri
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVeriOku = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnVeriBul = new System.Windows.Forms.Button();
            this.btnSQLtoXML = new System.Windows.Forms.Button();
            this.btnXPathileTagBul = new System.Windows.Forms.Button();
            this.btnXMLtoSQL = new System.Windows.Forms.Button();
            this.btnXPathileVerileriBul = new System.Windows.Forms.Button();
            this.btnSchemaOlustur = new System.Windows.Forms.Button();
            this.btnVeriDegistir = new System.Windows.Forms.Button();
            this.btnSQLdenSchema = new System.Windows.Forms.Button();
            this.btnXMLVeriSil = new System.Windows.Forms.Button();
            this.btnXMLSchemaDogrula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(435, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(353, 426);
            this.webBrowser1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 217);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnVeriOku
            // 
            this.btnVeriOku.Location = new System.Drawing.Point(17, 235);
            this.btnVeriOku.Name = "btnVeriOku";
            this.btnVeriOku.Size = new System.Drawing.Size(168, 30);
            this.btnVeriOku.TabIndex = 2;
            this.btnVeriOku.Text = "XML Dosyadan Veri Oku";
            this.btnVeriOku.UseVisualStyleBackColor = true;
            this.btnVeriOku.Click += new System.EventHandler(this.btnVeriOku_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(241, 235);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(168, 30);
            this.btnAddChild.TabIndex = 2;
            this.btnAddChild.Text = "XML\'de veri ekle";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnVeriBul
            // 
            this.btnVeriBul.Location = new System.Drawing.Point(17, 271);
            this.btnVeriBul.Name = "btnVeriBul";
            this.btnVeriBul.Size = new System.Drawing.Size(168, 30);
            this.btnVeriBul.TabIndex = 2;
            this.btnVeriBul.Text = "XML İçindeki Veriyi Bul";
            this.btnVeriBul.UseVisualStyleBackColor = true;
            this.btnVeriBul.Click += new System.EventHandler(this.btnVeriBul_Click);
            // 
            // btnSQLtoXML
            // 
            this.btnSQLtoXML.Location = new System.Drawing.Point(241, 271);
            this.btnSQLtoXML.Name = "btnSQLtoXML";
            this.btnSQLtoXML.Size = new System.Drawing.Size(168, 30);
            this.btnSQLtoXML.TabIndex = 2;
            this.btnSQLtoXML.Text = "VeriTabanından XML\'e oku";
            this.btnSQLtoXML.UseVisualStyleBackColor = true;
            this.btnSQLtoXML.Click += new System.EventHandler(this.btnSQLtoXML_Click);
            // 
            // btnXPathileTagBul
            // 
            this.btnXPathileTagBul.Location = new System.Drawing.Point(17, 307);
            this.btnXPathileTagBul.Name = "btnXPathileTagBul";
            this.btnXPathileTagBul.Size = new System.Drawing.Size(168, 30);
            this.btnXPathileTagBul.TabIndex = 2;
            this.btnXPathileTagBul.Text = "XML\'de Veriyi XPath ile Bul";
            this.btnXPathileTagBul.UseVisualStyleBackColor = true;
            this.btnXPathileTagBul.Click += new System.EventHandler(this.btnXPathileTagBul_Click);
            // 
            // btnXMLtoSQL
            // 
            this.btnXMLtoSQL.Location = new System.Drawing.Point(241, 307);
            this.btnXMLtoSQL.Name = "btnXMLtoSQL";
            this.btnXMLtoSQL.Size = new System.Drawing.Size(168, 30);
            this.btnXMLtoSQL.TabIndex = 2;
            this.btnXMLtoSQL.Text = "XML\'de VeriTabanına Yaz";
            this.btnXMLtoSQL.UseVisualStyleBackColor = true;
            this.btnXMLtoSQL.Click += new System.EventHandler(this.btnXMLtoSQL_Click);
            // 
            // btnXPathileVerileriBul
            // 
            this.btnXPathileVerileriBul.Location = new System.Drawing.Point(17, 343);
            this.btnXPathileVerileriBul.Name = "btnXPathileVerileriBul";
            this.btnXPathileVerileriBul.Size = new System.Drawing.Size(168, 30);
            this.btnXPathileVerileriBul.TabIndex = 2;
            this.btnXPathileVerileriBul.Text = "XML\'de verileri XPath ile Bul";
            this.btnXPathileVerileriBul.UseVisualStyleBackColor = true;
            this.btnXPathileVerileriBul.Click += new System.EventHandler(this.btnXPathileVerileriBul_Click);
            // 
            // btnSchemaOlustur
            // 
            this.btnSchemaOlustur.Location = new System.Drawing.Point(241, 343);
            this.btnSchemaOlustur.Name = "btnSchemaOlustur";
            this.btnSchemaOlustur.Size = new System.Drawing.Size(168, 30);
            this.btnSchemaOlustur.TabIndex = 2;
            this.btnSchemaOlustur.Text = "XML Schema Tanımı Oluştur";
            this.btnSchemaOlustur.UseVisualStyleBackColor = true;
            this.btnSchemaOlustur.Click += new System.EventHandler(this.btnSchemaOlustur_Click);
            // 
            // btnVeriDegistir
            // 
            this.btnVeriDegistir.Location = new System.Drawing.Point(17, 379);
            this.btnVeriDegistir.Name = "btnVeriDegistir";
            this.btnVeriDegistir.Size = new System.Drawing.Size(168, 30);
            this.btnVeriDegistir.TabIndex = 2;
            this.btnVeriDegistir.Text = "XML İçindeki veriyi değiştir";
            this.btnVeriDegistir.UseVisualStyleBackColor = true;
            this.btnVeriDegistir.Click += new System.EventHandler(this.btnVeriDegistir_Click);
            // 
            // btnSQLdenSchema
            // 
            this.btnSQLdenSchema.Location = new System.Drawing.Point(241, 379);
            this.btnSQLdenSchema.Name = "btnSQLdenSchema";
            this.btnSQLdenSchema.Size = new System.Drawing.Size(168, 30);
            this.btnSQLdenSchema.TabIndex = 2;
            this.btnSQLdenSchema.Text = "SQL\'den istenen şemaya uygun XML oluştur";
            this.btnSQLdenSchema.UseVisualStyleBackColor = true;
            this.btnSQLdenSchema.Click += new System.EventHandler(this.btnSQLdenSchema_Click);
            // 
            // btnXMLVeriSil
            // 
            this.btnXMLVeriSil.Location = new System.Drawing.Point(17, 415);
            this.btnXMLVeriSil.Name = "btnXMLVeriSil";
            this.btnXMLVeriSil.Size = new System.Drawing.Size(168, 30);
            this.btnXMLVeriSil.TabIndex = 2;
            this.btnXMLVeriSil.Text = "XML\'den Veri Sil";
            this.btnXMLVeriSil.UseVisualStyleBackColor = true;
            this.btnXMLVeriSil.Click += new System.EventHandler(this.btnXMLVeriSil_Click);
            // 
            // btnXMLSchemaDogrula
            // 
            this.btnXMLSchemaDogrula.Location = new System.Drawing.Point(241, 415);
            this.btnXMLSchemaDogrula.Name = "btnXMLSchemaDogrula";
            this.btnXMLSchemaDogrula.Size = new System.Drawing.Size(168, 30);
            this.btnXMLSchemaDogrula.TabIndex = 2;
            this.btnXMLSchemaDogrula.Text = "XML Schema Doğrulama";
            this.btnXMLSchemaDogrula.UseVisualStyleBackColor = true;
            this.btnXMLSchemaDogrula.Click += new System.EventHandler(this.btnXMLSchemaDogrula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXMLSchemaDogrula);
            this.Controls.Add(this.btnSchemaOlustur);
            this.Controls.Add(this.btnSQLtoXML);
            this.Controls.Add(this.btnXMLVeriSil);
            this.Controls.Add(this.btnXPathileVerileriBul);
            this.Controls.Add(this.btnVeriBul);
            this.Controls.Add(this.btnSQLdenSchema);
            this.Controls.Add(this.btnXMLtoSQL);
            this.Controls.Add(this.btnVeriDegistir);
            this.Controls.Add(this.btnXPathileTagBul);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.btnVeriOku);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "XML Dosyadan Veri Oku";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVeriOku;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnVeriBul;
        private System.Windows.Forms.Button btnSQLtoXML;
        private System.Windows.Forms.Button btnXPathileTagBul;
        private System.Windows.Forms.Button btnXMLtoSQL;
        private System.Windows.Forms.Button btnXPathileVerileriBul;
        private System.Windows.Forms.Button btnSchemaOlustur;
        private System.Windows.Forms.Button btnVeriDegistir;
        private System.Windows.Forms.Button btnSQLdenSchema;
        private System.Windows.Forms.Button btnXMLVeriSil;
        private System.Windows.Forms.Button btnXMLSchemaDogrula;
    }
}

