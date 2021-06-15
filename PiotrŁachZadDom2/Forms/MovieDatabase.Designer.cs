
namespace PiotrŁachZadDom2
{
    partial class MovieDatabase
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
            this.moviesDataGridView = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productionNameTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.directorLabel = new System.Windows.Forms.Label();
            this.releaseYearTextBox = new System.Windows.Forms.TextBox();
            this.releaseYearLabel = new System.Windows.Forms.Label();
            this.mainActorTextBox = new System.Windows.Forms.TextBox();
            this.mainActorLabel = new System.Windows.Forms.Label();
            this.movieSerialButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesDataGridView
            // 
            this.moviesDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.moviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDataGridView.Location = new System.Drawing.Point(36, 83);
            this.moviesDataGridView.Name = "moviesDataGridView";
            this.moviesDataGridView.Size = new System.Drawing.Size(734, 149);
            this.moviesDataGridView.TabIndex = 0;
            this.moviesDataGridView.SelectionChanged += new System.EventHandler(this.moviesDataGridView_SelectionChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(36, 280);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(157, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.idLabel.Location = new System.Drawing.Point(83, 249);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 28);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "Id";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.productNameLabel.Location = new System.Drawing.Point(237, 249);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(151, 28);
            this.productNameLabel.TabIndex = 5;
            this.productNameLabel.Text = "Production name";
            // 
            // productionNameTextBox
            // 
            this.productionNameTextBox.Location = new System.Drawing.Point(231, 280);
            this.productionNameTextBox.Name = "productionNameTextBox";
            this.productionNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.productionNameTextBox.TabIndex = 6;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.BackColor = System.Drawing.Color.Transparent;
            this.genreLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.genreLabel.Location = new System.Drawing.Point(482, 249);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(59, 28);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Genre";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(427, 280);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(157, 20);
            this.genreTextBox.TabIndex = 8;
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(36, 351);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(157, 20);
            this.directorTextBox.TabIndex = 9;
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.BackColor = System.Drawing.Color.Transparent;
            this.directorLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorLabel.ForeColor = System.Drawing.Color.Black;
            this.directorLabel.Location = new System.Drawing.Point(56, 319);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(78, 28);
            this.directorLabel.TabIndex = 10;
            this.directorLabel.Text = "Director";
            // 
            // releaseYearTextBox
            // 
            this.releaseYearTextBox.Location = new System.Drawing.Point(231, 351);
            this.releaseYearTextBox.Name = "releaseYearTextBox";
            this.releaseYearTextBox.Size = new System.Drawing.Size(157, 20);
            this.releaseYearTextBox.TabIndex = 11;
            // 
            // releaseYearLabel
            // 
            this.releaseYearLabel.AutoSize = true;
            this.releaseYearLabel.BackColor = System.Drawing.Color.Transparent;
            this.releaseYearLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseYearLabel.ForeColor = System.Drawing.Color.Black;
            this.releaseYearLabel.Location = new System.Drawing.Point(253, 319);
            this.releaseYearLabel.Name = "releaseYearLabel";
            this.releaseYearLabel.Size = new System.Drawing.Size(111, 28);
            this.releaseYearLabel.TabIndex = 12;
            this.releaseYearLabel.Text = "Release Year";
            // 
            // mainActorTextBox
            // 
            this.mainActorTextBox.Location = new System.Drawing.Point(427, 350);
            this.mainActorTextBox.Name = "mainActorTextBox";
            this.mainActorTextBox.Size = new System.Drawing.Size(157, 20);
            this.mainActorTextBox.TabIndex = 13;
            // 
            // mainActorLabel
            // 
            this.mainActorLabel.AutoSize = true;
            this.mainActorLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainActorLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainActorLabel.ForeColor = System.Drawing.Color.Black;
            this.mainActorLabel.Location = new System.Drawing.Point(455, 319);
            this.mainActorLabel.Name = "mainActorLabel";
            this.mainActorLabel.Size = new System.Drawing.Size(102, 28);
            this.mainActorLabel.TabIndex = 14;
            this.mainActorLabel.Text = "Main Actor";
            // 
            // movieSerialButton
            // 
            this.movieSerialButton.BackColor = System.Drawing.Color.Transparent;
            this.movieSerialButton.BackgroundImage = global::PiotrŁachZadDom2.Properties.Resources.video2;
            this.movieSerialButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.movieSerialButton.FlatAppearance.BorderSize = 0;
            this.movieSerialButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.movieSerialButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.movieSerialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movieSerialButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.movieSerialButton.Location = new System.Drawing.Point(146, 10);
            this.movieSerialButton.Name = "movieSerialButton";
            this.movieSerialButton.Size = new System.Drawing.Size(68, 67);
            this.movieSerialButton.TabIndex = 15;
            this.movieSerialButton.UseVisualStyleBackColor = false;
            this.movieSerialButton.Click += new System.EventHandler(this.movieSerialButton_Click);
            this.movieSerialButton.MouseEnter += new System.EventHandler(this.movieSerialButton_MouseEnter);
            this.movieSerialButton.MouseLeave += new System.EventHandler(this.movieSerialButton_MouseLeave);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.BackgroundImage = global::PiotrŁachZadDom2.Properties.Resources.edit;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(719, 249);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(51, 52);
            this.editButton.TabIndex = 16;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            this.editButton.MouseEnter += new System.EventHandler(this.editButton_MouseEnter);
            this.editButton.MouseLeave += new System.EventHandler(this.editButton_MouseLeave);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BackgroundImage = global::PiotrŁachZadDom2.Properties.Resources.delete;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(631, 319);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(51, 52);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.MouseEnter += new System.EventHandler(this.deleteButton_MouseEnter);
            this.deleteButton.MouseLeave += new System.EventHandler(this.deleteButton_MouseLeave);
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.Transparent;
            this.selectButton.BackgroundImage = global::PiotrŁachZadDom2.Properties.Resources.search;
            this.selectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectButton.FlatAppearance.BorderSize = 0;
            this.selectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.selectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Location = new System.Drawing.Point(719, 319);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(51, 52);
            this.selectButton.TabIndex = 18;
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            this.selectButton.MouseEnter += new System.EventHandler(this.selectButton_MouseEnter);
            this.selectButton.MouseLeave += new System.EventHandler(this.selectButton_MouseLeave);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BackgroundImage = global::PiotrŁachZadDom2.Properties.Resources.add;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(631, 249);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(51, 52);
            this.addButton.TabIndex = 19;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.addButton.MouseEnter += new System.EventHandler(this.addButton_MouseEnter);
            this.addButton.MouseLeave += new System.EventHandler(this.addButton_MouseLeave);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(230, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(370, 67);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "movie database";
            // 
            // MovieDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(803, 393);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.movieSerialButton);
            this.Controls.Add(this.mainActorLabel);
            this.Controls.Add(this.mainActorTextBox);
            this.Controls.Add(this.releaseYearLabel);
            this.Controls.Add(this.releaseYearTextBox);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.productionNameTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.moviesDataGridView);
            this.Name = "MovieDatabase";
            this.Text = "film productions database";
            this.Load += new System.EventHandler(this.MovieDatabase_Load);
            this.DoubleClick += new System.EventHandler(this.MovieDatabase_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView moviesDataGridView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productionNameTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.TextBox releaseYearTextBox;
        private System.Windows.Forms.Label releaseYearLabel;
        private System.Windows.Forms.TextBox mainActorTextBox;
        private System.Windows.Forms.Label mainActorLabel;
        private System.Windows.Forms.Button movieSerialButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label titleLabel;
    }
}

