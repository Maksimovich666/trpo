namespace ГАИ
{
    partial class Violations
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.гАИDataSet = new ГАИ.ГАИDataSet();
            this.списокНарушенийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_НарушенийTableAdapter = new ГАИ.ГАИDataSetTableAdapters.Список_НарушенийTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.штрафрубDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОГражданинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.разделDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.гАИDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокНарушенийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 89);
            this.panel1.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.BackgroundImage = global::ГАИ.Properties.Resources.close;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(862, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(914, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список нарушений";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(701, 534);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 38);
            this.button3.TabIndex = 54;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // гАИDataSet
            // 
            this.гАИDataSet.DataSetName = "ГАИDataSet";
            this.гАИDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокНарушенийBindingSource
            // 
            this.списокНарушенийBindingSource.DataMember = "Список_Нарушений";
            this.списокНарушенийBindingSource.DataSource = this.гАИDataSet;
            // 
            // список_НарушенийTableAdapter
            // 
            this.список_НарушенийTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.штрафрубDataGridViewTextBoxColumn,
            this.фИОГражданинаDataGridViewTextBoxColumn,
            this.паспортDataGridViewTextBoxColumn,
            this.разделDataGridViewTextBoxColumn,
            this.статьяDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.списокНарушенийBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(912, 436);
            this.dataGridView1.TabIndex = 76;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 27.53522F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.FillWeight = 134.8784F;
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // штрафрубDataGridViewTextBoxColumn
            // 
            this.штрафрубDataGridViewTextBoxColumn.DataPropertyName = "Штраф (руб)";
            this.штрафрубDataGridViewTextBoxColumn.FillWeight = 51.96173F;
            this.штрафрубDataGridViewTextBoxColumn.HeaderText = "Штраф (руб)";
            this.штрафрубDataGridViewTextBoxColumn.Name = "штрафрубDataGridViewTextBoxColumn";
            this.штрафрубDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОГражданинаDataGridViewTextBoxColumn
            // 
            this.фИОГражданинаDataGridViewTextBoxColumn.DataPropertyName = "ФИО гражданина";
            this.фИОГражданинаDataGridViewTextBoxColumn.FillWeight = 134.8784F;
            this.фИОГражданинаDataGridViewTextBoxColumn.HeaderText = "ФИО гражданина";
            this.фИОГражданинаDataGridViewTextBoxColumn.Name = "фИОГражданинаDataGridViewTextBoxColumn";
            this.фИОГражданинаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // паспортDataGridViewTextBoxColumn
            // 
            this.паспортDataGridViewTextBoxColumn.DataPropertyName = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.FillWeight = 100.4257F;
            this.паспортDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.Name = "паспортDataGridViewTextBoxColumn";
            this.паспортDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // разделDataGridViewTextBoxColumn
            // 
            this.разделDataGridViewTextBoxColumn.DataPropertyName = "Раздел";
            this.разделDataGridViewTextBoxColumn.FillWeight = 134.8784F;
            this.разделDataGridViewTextBoxColumn.HeaderText = "Раздел";
            this.разделDataGridViewTextBoxColumn.Name = "разделDataGridViewTextBoxColumn";
            this.разделDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статьяDataGridViewTextBoxColumn
            // 
            this.статьяDataGridViewTextBoxColumn.DataPropertyName = "Статья";
            this.статьяDataGridViewTextBoxColumn.FillWeight = 45.68528F;
            this.статьяDataGridViewTextBoxColumn.HeaderText = "Статья";
            this.статьяDataGridViewTextBoxColumn.Name = "статьяDataGridViewTextBoxColumn";
            this.статьяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.FillWeight = 134.8784F;
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.FillWeight = 134.8784F;
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Violations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(914, 584);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(930, 600);
            this.MinimumSize = new System.Drawing.Size(930, 600);
            this.Name = "Violations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Violations_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.гАИDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокНарушенийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private ГАИDataSet гАИDataSet;
        private System.Windows.Forms.BindingSource списокНарушенийBindingSource;
        private ГАИDataSetTableAdapters.Список_НарушенийTableAdapter список_НарушенийTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn штрафрубDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОГражданинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn разделDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
    }
}