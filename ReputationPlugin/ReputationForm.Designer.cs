namespace ReputationPlugin
{
    partial class ReputationForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.topPanel = new System.Windows.Forms.Panel();
            this.rank10CheckBox = new System.Windows.Forms.CheckBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.reputationListView = new System.Windows.Forms.ListView();
            this.factionNameColumn = new System.Windows.Forms.ColumnHeader();
            this.rankColumn = new System.Windows.Forms.ColumnHeader();
            this.repColumn = new System.Windows.Forms.ColumnHeader();
            this.requiredRepColumn = new System.Windows.Forms.ColumnHeader();
            this.remainingRepColumn = new System.Windows.Forms.ColumnHeader();
            this.rank10RemainingColumn = new System.Windows.Forms.ColumnHeader();
            this.totalRepColumn = new System.Windows.Forms.ColumnHeader();
            this.dateLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.dateLabel);
            this.topPanel.Controls.Add(this.rank10CheckBox);
            this.topPanel.Controls.Add(this.refreshButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(566, 44);
            this.topPanel.TabIndex = 0;
            // 
            // rank10CheckBox
            // 
            this.rank10CheckBox.AutoSize = true;
            this.rank10CheckBox.Location = new System.Drawing.Point(93, 15);
            this.rank10CheckBox.Name = "rank10CheckBox";
            this.rank10CheckBox.Size = new System.Drawing.Size(124, 19);
            this.rank10CheckBox.TabIndex = 3;
            this.rank10CheckBox.Text = "Dont show rank 10";
            this.rank10CheckBox.UseVisualStyleBackColor = true;
            this.rank10CheckBox.CheckedChanged += new System.EventHandler(this.rank10CheckBox_CheckedChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // reputationListView
            // 
            this.reputationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.factionNameColumn,
            this.rankColumn,
            this.repColumn,
            this.requiredRepColumn,
            this.remainingRepColumn,
            this.rank10RemainingColumn,
            this.totalRepColumn});
            this.reputationListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reputationListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.reputationListView.Location = new System.Drawing.Point(0, 44);
            this.reputationListView.Name = "reputationListView";
            this.reputationListView.Size = new System.Drawing.Size(566, 249);
            this.reputationListView.TabIndex = 1;
            this.reputationListView.UseCompatibleStateImageBehavior = false;
            this.reputationListView.View = System.Windows.Forms.View.Details;
            // 
            // factionNameColumn
            // 
            this.factionNameColumn.Text = "Faction Name";
            // 
            // rankColumn
            // 
            this.rankColumn.Text = "Rank";
            // 
            // repColumn
            // 
            this.repColumn.Text = "Reputation";
            // 
            // requiredRepColumn
            // 
            this.requiredRepColumn.Text = "Required Rep";
            // 
            // remainingRepColumn
            // 
            this.remainingRepColumn.Text = "Remaining Rep";
            // 
            // rank10RemainingColumn
            // 
            this.rank10RemainingColumn.Text = "Remaining Rep for Rank 10";
            // 
            // totalRepColumn
            // 
            this.totalRepColumn.Text = "Total Rep";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(223, 16);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 15);
            this.dateLabel.TabIndex = 4;
            // 
            // ReputationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 293);
            this.Controls.Add(this.reputationListView);
            this.Controls.Add(this.topPanel);
            this.Name = "ReputationForm";
            this.Text = "Reputation List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExampleForm_FormClosing);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel topPanel;
        private ListView reputationListView;
        private Button refreshButton;
        private ColumnHeader factionNameColumn;
        private ColumnHeader rankColumn;
        private ColumnHeader repColumn;
        private ColumnHeader requiredRepColumn;
        private ColumnHeader totalRepColumn;
        private ColumnHeader remainingRepColumn;
        private ColumnHeader rank10RemainingColumn;
        private CheckBox rank10CheckBox;
        private Label dateLabel;
    }
}