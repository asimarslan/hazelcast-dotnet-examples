namespace HazelCarNet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rowDataView = new System.Windows.Forms.DataGridView();
            this.modelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelMakeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelBodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelEngineCcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelEngineCylDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelEngineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelEngineValvesPerCylDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelEnginePowerPsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelEngineCompressionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelEngineFuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelTopSpeedKphDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model0To100KphDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelTransmissionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelWeightKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.connectButton = new System.Windows.Forms.ToolStripButton();
            this.refreshDataButtom = new System.Windows.Forms.ToolStripButton();
            this.listenButton = new System.Windows.Forms.ToolStripButton();
            this.disconnectButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.rowDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowDataBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rowDataView
            // 
            this.rowDataView.AllowUserToAddRows = false;
            this.rowDataView.AllowUserToDeleteRows = false;
            this.rowDataView.AutoGenerateColumns = false;
            this.rowDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rowDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelIdDataGridViewTextBoxColumn,
            this.modelMakeIdDataGridViewTextBoxColumn,
            this.modelYearDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.modelBodyDataGridViewTextBoxColumn,
            this.modelEngineCcDataGridViewTextBoxColumn,
            this.modelEngineCylDataGridViewTextBoxColumn,
            this.modelEngineTypeDataGridViewTextBoxColumn,
            this.modelEngineValvesPerCylDataGridViewTextBoxColumn,
            this.modelEnginePowerPsDataGridViewTextBoxColumn,
            this.modelEngineCompressionDataGridViewTextBoxColumn,
            this.modelEngineFuelDataGridViewTextBoxColumn,
            this.modelTopSpeedKphDataGridViewTextBoxColumn,
            this.model0To100KphDataGridViewTextBoxColumn,
            this.modelTransmissionTypeDataGridViewTextBoxColumn,
            this.modelWeightKgDataGridViewTextBoxColumn});
            this.rowDataView.DataSource = this.rowDataBindingSource;
            this.rowDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rowDataView.Location = new System.Drawing.Point(0, 40);
            this.rowDataView.Name = "rowDataView";
            this.rowDataView.ReadOnly = true;
            this.rowDataView.Size = new System.Drawing.Size(1200, 823);
            this.rowDataView.TabIndex = 0;
            this.rowDataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.rowDataView_CellValueChanged);
            // 
            // modelIdDataGridViewTextBoxColumn
            // 
            this.modelIdDataGridViewTextBoxColumn.DataPropertyName = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.HeaderText = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.Name = "modelIdDataGridViewTextBoxColumn";
            this.modelIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelMakeIdDataGridViewTextBoxColumn
            // 
            this.modelMakeIdDataGridViewTextBoxColumn.DataPropertyName = "ModelMakeId";
            this.modelMakeIdDataGridViewTextBoxColumn.HeaderText = "ModelMakeId";
            this.modelMakeIdDataGridViewTextBoxColumn.Name = "modelMakeIdDataGridViewTextBoxColumn";
            this.modelMakeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelYearDataGridViewTextBoxColumn
            // 
            this.modelYearDataGridViewTextBoxColumn.DataPropertyName = "ModelYear";
            this.modelYearDataGridViewTextBoxColumn.HeaderText = "ModelYear";
            this.modelYearDataGridViewTextBoxColumn.Name = "modelYearDataGridViewTextBoxColumn";
            this.modelYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            this.modelNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelBodyDataGridViewTextBoxColumn
            // 
            this.modelBodyDataGridViewTextBoxColumn.DataPropertyName = "ModelBody";
            this.modelBodyDataGridViewTextBoxColumn.HeaderText = "ModelBody";
            this.modelBodyDataGridViewTextBoxColumn.Name = "modelBodyDataGridViewTextBoxColumn";
            this.modelBodyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelEngineCcDataGridViewTextBoxColumn
            // 
            this.modelEngineCcDataGridViewTextBoxColumn.DataPropertyName = "ModelEngineCc";
            this.modelEngineCcDataGridViewTextBoxColumn.HeaderText = "ModelEngineCc";
            this.modelEngineCcDataGridViewTextBoxColumn.Name = "modelEngineCcDataGridViewTextBoxColumn";
            this.modelEngineCcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelEngineCylDataGridViewTextBoxColumn
            // 
            this.modelEngineCylDataGridViewTextBoxColumn.DataPropertyName = "ModelEngineCyl";
            this.modelEngineCylDataGridViewTextBoxColumn.HeaderText = "ModelEngineCyl";
            this.modelEngineCylDataGridViewTextBoxColumn.Name = "modelEngineCylDataGridViewTextBoxColumn";
            this.modelEngineCylDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelEngineTypeDataGridViewTextBoxColumn
            // 
            this.modelEngineTypeDataGridViewTextBoxColumn.DataPropertyName = "ModelEngineType";
            this.modelEngineTypeDataGridViewTextBoxColumn.HeaderText = "ModelEngineType";
            this.modelEngineTypeDataGridViewTextBoxColumn.Name = "modelEngineTypeDataGridViewTextBoxColumn";
            this.modelEngineTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelEngineValvesPerCylDataGridViewTextBoxColumn
            // 
            this.modelEngineValvesPerCylDataGridViewTextBoxColumn.DataPropertyName = "ModelEngineValvesPerCyl";
            this.modelEngineValvesPerCylDataGridViewTextBoxColumn.HeaderText = "ModelEngineValvesPerCyl";
            this.modelEngineValvesPerCylDataGridViewTextBoxColumn.Name = "modelEngineValvesPerCylDataGridViewTextBoxColumn";
            this.modelEngineValvesPerCylDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelEnginePowerPsDataGridViewTextBoxColumn
            // 
            this.modelEnginePowerPsDataGridViewTextBoxColumn.DataPropertyName = "ModelEnginePowerPs";
            this.modelEnginePowerPsDataGridViewTextBoxColumn.HeaderText = "ModelEnginePowerPs";
            this.modelEnginePowerPsDataGridViewTextBoxColumn.Name = "modelEnginePowerPsDataGridViewTextBoxColumn";
            this.modelEnginePowerPsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelEngineCompressionDataGridViewTextBoxColumn
            // 
            this.modelEngineCompressionDataGridViewTextBoxColumn.DataPropertyName = "ModelEngineCompression";
            this.modelEngineCompressionDataGridViewTextBoxColumn.HeaderText = "ModelEngineCompression";
            this.modelEngineCompressionDataGridViewTextBoxColumn.Name = "modelEngineCompressionDataGridViewTextBoxColumn";
            this.modelEngineCompressionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelEngineFuelDataGridViewTextBoxColumn
            // 
            this.modelEngineFuelDataGridViewTextBoxColumn.DataPropertyName = "ModelEngineFuel";
            this.modelEngineFuelDataGridViewTextBoxColumn.HeaderText = "ModelEngineFuel";
            this.modelEngineFuelDataGridViewTextBoxColumn.Name = "modelEngineFuelDataGridViewTextBoxColumn";
            this.modelEngineFuelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelTopSpeedKphDataGridViewTextBoxColumn
            // 
            this.modelTopSpeedKphDataGridViewTextBoxColumn.DataPropertyName = "ModelTopSpeedKph";
            this.modelTopSpeedKphDataGridViewTextBoxColumn.HeaderText = "ModelTopSpeedKph";
            this.modelTopSpeedKphDataGridViewTextBoxColumn.Name = "modelTopSpeedKphDataGridViewTextBoxColumn";
            this.modelTopSpeedKphDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // model0To100KphDataGridViewTextBoxColumn
            // 
            this.model0To100KphDataGridViewTextBoxColumn.DataPropertyName = "Model0To100Kph";
            this.model0To100KphDataGridViewTextBoxColumn.HeaderText = "Model0To100Kph";
            this.model0To100KphDataGridViewTextBoxColumn.Name = "model0To100KphDataGridViewTextBoxColumn";
            this.model0To100KphDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelTransmissionTypeDataGridViewTextBoxColumn
            // 
            this.modelTransmissionTypeDataGridViewTextBoxColumn.DataPropertyName = "ModelTransmissionType";
            this.modelTransmissionTypeDataGridViewTextBoxColumn.HeaderText = "ModelTransmissionType";
            this.modelTransmissionTypeDataGridViewTextBoxColumn.Name = "modelTransmissionTypeDataGridViewTextBoxColumn";
            this.modelTransmissionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelWeightKgDataGridViewTextBoxColumn
            // 
            this.modelWeightKgDataGridViewTextBoxColumn.DataPropertyName = "ModelWeightKg";
            this.modelWeightKgDataGridViewTextBoxColumn.HeaderText = "ModelWeightKg";
            this.modelWeightKgDataGridViewTextBoxColumn.Name = "modelWeightKgDataGridViewTextBoxColumn";
            this.modelWeightKgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rowDataBindingSource
            // 
            this.rowDataBindingSource.DataSource = typeof(HazelCarNet.RowData);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectButton,
            this.refreshDataButtom,
            this.listenButton,
            this.disconnectButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // connectButton
            // 
            this.connectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.connectButton.Image = ((System.Drawing.Image)(resources.GetObject("connectButton.Image")));
            this.connectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(67, 22);
            this.connectButton.Text = "CONNECT";
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // refreshDataButtom
            // 
            this.refreshDataButtom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshDataButtom.Image = ((System.Drawing.Image)(resources.GetObject("refreshDataButtom.Image")));
            this.refreshDataButtom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshDataButtom.Name = "refreshDataButtom";
            this.refreshDataButtom.Size = new System.Drawing.Size(58, 22);
            this.refreshDataButtom.Text = "REFRESH";
            this.refreshDataButtom.Click += new System.EventHandler(this.refreshDataButtom_Click);
            // 
            // listenButton
            // 
            this.listenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.listenButton.Image = ((System.Drawing.Image)(resources.GetObject("listenButton.Image")));
            this.listenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(48, 22);
            this.listenButton.Text = "LISTEN";
            this.listenButton.Click += new System.EventHandler(this.listenButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.disconnectButton.Image = ((System.Drawing.Image)(resources.GetObject("disconnectButton.Image")));
            this.disconnectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(84, 22);
            this.disconnectButton.Text = "DISCONNECT";
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 863);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rowDataView);
            this.Name = "Form1";
            this.Text = "Hazelcast .Net Client Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.rowDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowDataBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rowDataView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton connectButton;
        private System.Windows.Forms.ToolStripButton disconnectButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelMakeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelBodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelEngineCcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelEngineCylDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelEngineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelEngineValvesPerCylDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelEnginePowerPsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelEngineCompressionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelEngineFuelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelTopSpeedKphDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn model0To100KphDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelTransmissionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelWeightKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rowDataBindingSource;
        private System.Windows.Forms.ToolStripButton refreshDataButtom;
        private System.Windows.Forms.ToolStripButton listenButton;
    }
}

