using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PiotrŁachZadDom2
{
    public partial class MovieDatabase : Form
    {
        /// <summary>
        /// auxiliary variable telling whether the current operations are carried out on movies (or series) 
        /// </summary>
        bool ifShowMovies = true;

        /// <summary>
        /// tool tip to show user hint after hover over the button
        /// </summary>
        ToolTip hint = new ToolTip();

        /// <summary>
        /// declaring Repository object
        /// </summary>
        private readonly Repository _repository = new Repository();

        public MovieDatabase()
        {
            InitializeComponent();

            //positioning the window in the center of the screen 
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void MovieDatabase_Load(object sender, EventArgs e)
        {
            //fill the moviesDataGridView with movies while loading windows
            updateDataGridViewWithMovies();
        }


        /// <summary>
        /// clear text boxes method
        /// </summary>
        private void clearTextBoxes()
        {
            idTextBox.Text = "";
            productionNameTextBox.Text = "";
            genreTextBox.Text = "";
            directorTextBox.Text = "";
            releaseYearTextBox.Text = "";
            mainActorTextBox.Text = "";
        }

        /// <summary>
        /// fill the moviesDataGridView with movies
        /// </summary>
        private void updateDataGridViewWithMovies()
        {
            DataTable movies = _repository.GetMovies();
            moviesDataGridView.DataSource = movies;
        }

        /// <summary>
        /// fill the moviesDataGridView with series
        /// </summary>
        private void updateDataGridViewWithSeries()
        {
            DataTable series = _repository.GetSeries();
            moviesDataGridView.DataSource = series;
        }


        private void moviesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //do nothing if no row is selected or selected is more than one
            int rowsCount = moviesDataGridView.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
                return;

            //take the selected row
            DataGridViewRow row = moviesDataGridView.SelectedRows[0];

            //and extract the data from it
            int id = int.Parse(row.Cells[0].Value.ToString());
            string productionName = row.Cells[1].Value.ToString();
            string genre = row.Cells[2].Value.ToString();
            string director = row.Cells[3].Value.ToString();
            string mainActor = row.Cells[4].Value.ToString();
            int releaseYear = int.Parse(row.Cells[5].Value.ToString());
           

            //write extracted data into text boxes
            idTextBox.Text = id.ToString();
            productionNameTextBox.Text = productionName;
            genreTextBox.Text = genre;
            directorTextBox.Text = director;

            mainActorTextBox.Text = mainActor;
            releaseYearTextBox.Text = releaseYear.ToString();
        }

        /// <summary>
        /// action on click movieSerialButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieSerialButton_Click(object sender, EventArgs e)
        {
            //check whether to display movies or series   
            if (ifShowMovies)
            {

                //if movies have been shown previously fill moviesDataGridView with series
                updateDataGridViewWithSeries();

                //change value of ifShowMovies to false, now it shows series
                ifShowMovies = false;
                //change title
                titleLabel.Text = "series database";

                //update background image
                movieSerialButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.video;
            }
            else
            {
                //if series have been shown previously fill moviesDataGridView with movies
                updateDataGridViewWithMovies();

                //change value of ifShowMovies to true, now it shows movies
                ifShowMovies = true;
                //change title
                titleLabel.Text = "movies database";

                //update background image
                movieSerialButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.video2;
            }

            //clear text boxes after switch
            clearTextBoxes();
        }

        /// <summary>
        /// add movie or serial to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            //check if user provided all data
            if (productionNameTextBox.Text.Equals("") || genreTextBox.Text.Equals("") || directorTextBox.Text.Equals("") ||
                releaseYearTextBox.Text.Equals("") || mainActorTextBox.Text.Equals(""))
            {
                //if no show message box
                MessageBox.Show("Enter all data");
                return;
            }

            //get all data from text boxes
            string title = productionNameTextBox.Text;
            string genre = genreTextBox.Text;
            string director = directorTextBox.Text;
            int releaseYear;
            string mainActor = mainActorTextBox.Text;

            //check if user provided release year as number
            try
            {
                releaseYear = int.Parse(releaseYearTextBox.Text);
            }
            catch(System.FormatException)
            {
                //if no show message box
                MessageBox.Show("The given release year must be a number ");
                return;
            }
            //check what the user is currently viewing and add data to proper table, update DataGridViewWith
            if (ifShowMovies)
            {
                _repository.addMovie(title, genre, director, releaseYear, mainActor);
                updateDataGridViewWithMovies();
            }
            else
            {
                _repository.addSeries(title, genre, director, releaseYear, mainActor);
                updateDataGridViewWithSeries();
            }
            //clear text boxes
            clearTextBoxes();
        }

        /// <summary>
        /// edit movie or serial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            //check if user provided all data
            if (idTextBox.Text.Equals("") || productionNameTextBox.Text.Equals("") || genreTextBox.Text.Equals("") || directorTextBox.Text.Equals("") ||
                releaseYearTextBox.Text.Equals("") || mainActorTextBox.Text.Equals(""))
            {
                // if no show message box
                MessageBox.Show("Enter all data");
                return;
            }

            int idOfProduction;
            //check if user provided id as number
            try
            {
                idOfProduction = int.Parse(idTextBox.Text);
            }
            catch (System.FormatException)
            {
                // if no show message box
                MessageBox.Show("The id must be a number ");
                return;
            }

            //get all data from text boxes
            string title = productionNameTextBox.Text;
            string genre = genreTextBox.Text;
            string director = directorTextBox.Text;
            int releaseYear;
            string mainActor = mainActorTextBox.Text;

            //check if user provided release year as number
            try
            {
                releaseYear = int.Parse(releaseYearTextBox.Text);
            }
            catch (System.FormatException)
            {
                // if no show message box
                MessageBox.Show("The release year must be a number ");
                return;
            }

            //check what the user is currently viewing and edit data in proper table, update DataGridViewWith
            if (ifShowMovies)
            {
                _repository.editMovie(idOfProduction, title, genre, director, releaseYear, mainActor);
                updateDataGridViewWithMovies();
            }
            else
            {
                _repository.editSeries(idOfProduction,title, genre, director, releaseYear, mainActor);
                updateDataGridViewWithSeries();
            }

            //clear text boxes
            clearTextBoxes();
        }

        /// <summary>
        /// action on click deleteButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //check if user provided id
            if (idTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter id");
                return;
            }

            int idOfProduction;
            //check if user provided id as number
            try
            {
                idOfProduction = int.Parse(idTextBox.Text);
            }
            catch (System.FormatException)
            {
                // if no show message box
                MessageBox.Show("The id must be a number ");
                return;
            }

            //check what the user is currently viewing and delete row in proper table, update DataGridViewWith
            if (ifShowMovies)
            {
                _repository.deleteMovie(idOfProduction);
                updateDataGridViewWithMovies();
            }
            else
            {
                _repository.deleteSeries(idOfProduction);
                updateDataGridViewWithSeries();
            }

            //clear text boxes
            clearTextBoxes();
        }

        /// <summary>
        /// action on click selectButton -> fill text boxes with data from movie or series, looking by id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectButton_Click(object sender, EventArgs e)
        {
            //check if user provided id
            if (idTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter id");
                return;
            }

            int idOfProduction;
            //check if user provided id as number
            try
            {
                idOfProduction = int.Parse(idTextBox.Text);
            }
            catch (System.FormatException)
            {
                // if no show message box
                MessageBox.Show("The id must be a number ");
                return;
            }
            //take the selected row by id-1 (rows are counted from zero, id from 1 so -> idOfProduction-1
            DataGridViewRow row = moviesDataGridView.Rows[idOfProduction-1];

            //and extract the data from it
            int id = int.Parse(row.Cells[0].Value.ToString());
            string productionName = row.Cells[1].Value.ToString();
            string genre = row.Cells[2].Value.ToString();
            string director = row.Cells[3].Value.ToString();
            string mainActor = row.Cells[4].Value.ToString();
            int releaseYear = int.Parse(row.Cells[5].Value.ToString());

            //write extracted data into text boxes
            idTextBox.Text = id.ToString();
            productionNameTextBox.Text = productionName;
            genreTextBox.Text = genre;
            directorTextBox.Text = director;

            mainActorTextBox.Text = mainActor;
            releaseYearTextBox.Text = releaseYear.ToString();

        }

        /// <summary>
        /// changes the picture when mouse hover over the movieSerialButton and shows hint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieSerialButton_MouseEnter(object sender, EventArgs e)
        { 

            //check whether to display movies or series   
            if (ifShowMovies)
            {
                movieSerialButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.video;

                //show hint
                hint.Show("Change to series", movieSerialButton);
            }
            else
            {
                movieSerialButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.video2;

                //show hint
                hint.Show("Change to movies", movieSerialButton);
            }
        }

        /// <summary>
        /// changes the image after removing the cursor from the movieSerialButton 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieSerialButton_MouseLeave(object sender, EventArgs e)
        {
            //check what the user is currently viewing and change to proper image 
            if (ifShowMovies)
            {
                movieSerialButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.video2;
            }
            else
            {
                movieSerialButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.video;
            }
        }

        /// <summary>
        /// changes the picture and labels colors (to tell user what data he must enter) when mouse hover over the movieSerialButton and shows hint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_MouseEnter(object sender, EventArgs e)
        {
            //change background image
            addButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.add2;

            //change labels colors
            productNameLabel.ForeColor = Color.SpringGreen;
            genreLabel.ForeColor = Color.SpringGreen;
            directorLabel.ForeColor = Color.SpringGreen;
            releaseYearLabel.ForeColor = Color.SpringGreen;
            mainActorLabel.ForeColor = Color.SpringGreen;

            //show hint to user
            hint.Show("Add to database, you must fill in all highlighted data ", addButton);
        }

        /// <summary>
        /// changes the image and labels colors to default after removing the cursor from the addButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            //change background image
            addButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.add;

            //change labels colors
            productNameLabel.ForeColor = Color.Black;
            genreLabel.ForeColor = Color.Black;
            directorLabel.ForeColor = Color.Black;
            releaseYearLabel.ForeColor = Color.Black;
            mainActorLabel.ForeColor = Color.Black;
        }

        /// <summary>
        /// changes the picture and labels colors (to tell user what data he must enter) when mouse hover over the editButton
        /// ,shows hint to user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_MouseEnter(object sender, EventArgs e)
        {
            //change background image
            editButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.edit2;

            //change labels colors
            idLabel.ForeColor = Color.BlueViolet;
            productNameLabel.ForeColor = Color.BlueViolet;
            genreLabel.ForeColor = Color.BlueViolet;
            directorLabel.ForeColor = Color.BlueViolet;
            releaseYearLabel.ForeColor = Color.BlueViolet;
            mainActorLabel.ForeColor = Color.BlueViolet;

            //show hint to user
            hint.Show("Edit, you must fill in all highlighted data ", editButton);
        }

        /// <summary>
        /// changes the image and labels colors to default after removing the cursor from the editButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_MouseLeave(object sender, EventArgs e)
        {
            //change background image
            editButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.edit;

            //change labels colors
            idLabel.ForeColor = Color.Black;
            productNameLabel.ForeColor = Color.Black;
            genreLabel.ForeColor = Color.Black;
            directorLabel.ForeColor = Color.Black;
            releaseYearLabel.ForeColor = Color.Black;
            mainActorLabel.ForeColor = Color.Black;
        }

        /// <summary>
        /// changes the picture and id label color (to tell user what data he must enter) when mouse hover over the deleteButton
        /// ,shows hint to user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            //change background image
            deleteButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.delete2;

            //change label color
            idLabel.ForeColor = Color.Red;

            //show hint to user
            hint.Show("Delete, you must fill in all highlighted data ", deleteButton);
        }

        /// <summary>
        /// changes the image and id label color to default after removing the cursor from the deleteButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            //change background image
            deleteButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.delete;

            //change label color
            idLabel.ForeColor = Color.Black;
        }

        /// <summary>
        /// changes the picture and id label color (to tell user what data he must enter) when mouse hover over the selectButton
        /// ,shows hint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectButton_MouseEnter(object sender, EventArgs e)
        {
            //change background image
            selectButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.search2;

            //change label color
            idLabel.ForeColor = Color.Orange;

            //show hint to user
            hint.Show("Search, you must fill in all highlighted data ", selectButton);
        }

        /// <summary>
        /// changes the image and id label color to default after removing the cursor from the selectButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectButton_MouseLeave(object sender, EventArgs e)
        {
            //change background image
            selectButton.BackgroundImage = PiotrŁachZadDom2.Properties.Resources.search;

            //change label color
            idLabel.ForeColor = Color.Black;
        }

        /// <summary>
        /// double click on form to clear text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieDatabase_DoubleClick(object sender, EventArgs e)
        {
            clearTextBoxes();
        }
    }
}
