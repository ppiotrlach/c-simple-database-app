using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Repository
{
	//declaring SqlConnection object
	private readonly SqlConnection _connection = new SqlConnection(PiotrŁachZadDom2.Properties.Resources.ConnectionString);

	public Repository()
	{
	}

	/// <summary>
	/// GetMovies() returns DataTable filled with movies
	/// </summary>
	/// <returns></returns>
	public DataTable GetMovies()
    {
		//query for all movies with properly formatted data
		string query = "SELECT Movies.Id, Movies.Name, Genres.Name AS Genre, Directors.Name AS Director, Actors.Name as 'Main Actor', ReleaseYear as 'Release Year' FROM Movies JOIN Genres ON Movies.GenreId = Genres.Id JOIN Directors ON Movies.DirectorId = Directors.Id JOIN Actors ON Movies.MainActorId = Actors.Id;";
		SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
		DataTable table = new DataTable();
		adapter.Fill(table);

		return table;
    }
	/// <summary>
	/// GetSeries() returns DataTable filled with series
	/// </summary>
	/// <returns></returns>
	public DataTable GetSeries()
	{
		//query for all series with properly formatted data
		string query = "SELECT Series.Id, Series.Name, Genres.Name AS Genre, Directors.Name AS Director, Actors.Name as 'Main Actor', ReleaseYear as 'Release Year' FROM Series JOIN Genres ON Series.GenreId = Genres.Id JOIN Directors ON Series.DirectorId = Directors.Id JOIN Actors ON Series.MainActorId = Actors.Id;";
		SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
		DataTable table = new DataTable();
		adapter.Fill(table);

		return table;
	}

	/// <summary>
	/// add movie to database, if genre, directorName or mainActorName did not exist in the database before, add them to the appropriate tables 
	/// </summary>
	/// <param name="title"></param>
	/// <param name="genre"></param>
	/// <param name="directorName"></param>
	/// <param name="releaseYear"></param>
	/// <param name="mainActorName"></param>
	public void addMovie(string title, string genre, string directorName, int releaseYear, string mainActorName)
    {
		//check if this movie already exists in the database 
		int movieId = getIdOfValueInTable("Name", title, "Movies");
		//dont add same movie to database
		if (movieId != (-1))
		{
			MessageBox.Show("Movie already exists");
			return;
		}

		//get genre id
		int genreId = getIdOfValueInTable("Name", genre, "Genres");

		//if there is no given genre insert new into Genres table and get Id
		if(genreId == (-1))
        {
			insertIntoSmallTable(genre, "Genres");
			genreId = getIdOfValueInTable("Name", genre, "Genres");
		}

		//get directorId
		int directorId = getIdOfValueInTable("Name", directorName, "Genres");

		//if there is no given director insert new into Directors table and get Id
		if (directorId == (-1))
		{
			insertIntoSmallTable(directorName, "Directors");
			directorId = getIdOfValueInTable("Name", directorName, "Directors");
		}

		//get main actor id
		int mainActorId = getIdOfValueInTable("Name", mainActorName, "Actors");

		//if there is no given actor insert new into Actors table and get Id
		if (mainActorId == (-1))
		{
			insertIntoSmallTable(mainActorName, "Actors");
			mainActorId = getIdOfValueInTable("Name", mainActorName, "Actors");
		}

		//query to add movie do database
		string queryAddMovie = "INSERT INTO Movies(Name, GenreId, DirectorId, ReleaseYear, MainActorId) VALUES(\'" + title + "\', " + genreId + ", " + directorId + ", " + releaseYear + ", " +  mainActorId + ");";

		//open connection and execute query
		_connection.Open();

		SqlCommand commandAddMovie = new SqlCommand(queryAddMovie, _connection);
		commandAddMovie.ExecuteNonQuery();

		//close connection
		_connection.Close();
	}

	/// <summary>
	/// edit selected movie 
	/// </summary>
	/// <param name="movieId"></param>
	/// <param name="title"></param>
	/// <param name="genre"></param>
	/// <param name="directorName"></param>
	/// <param name="releaseYear"></param>
	/// <param name="mainActorName"></param>
	public void editMovie(int movieId, string title, string genre, string directorName, int releaseYear, string mainActorName)
    {
		//get genre id
		int genreId = getIdOfValueInTable("Name", genre, "Genres");

		//if there is no given genre insert new into Genres table and get Id
		if (genreId == (-1))
		{
			insertIntoSmallTable(genre, "Genres");
			genreId = getIdOfValueInTable("Name", genre, "Genres");
		}

		//get directorId
		int directorId = getIdOfValueInTable("Name", directorName, "Genres");

		//if there is no given director insert new into Directors table and get Id
		if (directorId == (-1))
		{
			insertIntoSmallTable(directorName, "Directors");
			directorId = getIdOfValueInTable("Name", directorName, "Directors");
		}

		//get main actor id
		int mainActorId = getIdOfValueInTable("Name", mainActorName, "Actors");

		//if there is no given actor insert new into Actors table and get Id
		if (mainActorId == (-1))
		{
			insertIntoSmallTable(mainActorName, "Actors");
			mainActorId = getIdOfValueInTable("Name", mainActorName, "Actors");
		}

		//query to update movie in databse
		string updateMovieQuery = "UPDATE Movies SET Name = '" + title + "', GenreId = " + genreId + ", DirectorId = " + directorId + ", ReleaseYear =" + releaseYear + ", MainActorId = " + mainActorId + "WHERE Id =" + movieId + ";";

		//open connection and execute query
		_connection.Open();

		SqlCommand commandInsertBook = new SqlCommand(updateMovieQuery, _connection);
		commandInsertBook.ExecuteNonQuery();

		//close connection
		_connection.Close();
	}

	/// <summary>
	/// edit selected series
	/// </summary>
	/// <param name="seriesId"></param>
	/// <param name="title"></param>
	/// <param name="genre"></param>
	/// <param name="directorName"></param>
	/// <param name="releaseYear"></param>
	/// <param name="mainActorName"></param>
	internal void editSeries(int seriesId, string title, string genre, string directorName, int releaseYear, string mainActorName)
	{
		//get genre id
		int genreId = getIdOfValueInTable("Name", genre, "Genres");

		//if there is no given genre insert new into Genres table and get Id
		if (genreId == (-1))
		{
			insertIntoSmallTable(genre, "Genres");
			genreId = getIdOfValueInTable("Name", genre, "Genres");
		}

		//get directorId
		int directorId = getIdOfValueInTable("Name", directorName, "Genres");

		//if there is no given director insert new into Directors table and get Id
		if (directorId == (-1))
		{
			insertIntoSmallTable(directorName, "Directors");
			directorId = getIdOfValueInTable("Name", directorName, "Directors");
		}

		//get main actor id
		int mainActorId = getIdOfValueInTable("Name", mainActorName, "Actors");

		//if there is no given actor insert new into Actors table and get Id
		if (mainActorId == (-1))
		{
			insertIntoSmallTable(mainActorName, "Actors");
			mainActorId = getIdOfValueInTable("Name", mainActorName, "Actors");
		}

		//query to update series in database
		string updateSeriesQuery = "UPDATE Series SET Name = '" + title + "', GenreId = " + genreId + ", DirectorId = " + directorId + ", ReleaseYear =" + releaseYear + ", MainActorId = " + mainActorId + "WHERE Id =" + seriesId + ";";

		//open connection and execute query
		_connection.Open();
		
		SqlCommand commandInsertBook = new SqlCommand(updateSeriesQuery, _connection);
		commandInsertBook.ExecuteNonQuery();

		//close connection
		_connection.Close();
	}

	/// <summary>
	/// remove the movie with the given id from the database 
	/// </summary>
	/// <param name="movieId"></param>
	public void deleteMovie(int movieId)
    {
		//query to delete movie in databse
		string queryDeleteMovie = "DELETE FROM Movies WHERE Id=" + movieId;

		//open connection and execute query
		_connection.Open();

		SqlCommand commandDeleteMovie = new SqlCommand(queryDeleteMovie, _connection);
		commandDeleteMovie.ExecuteNonQuery();

		//close connection
		_connection.Close();
	}

	/// <summary>
	/// remove the movie with the given id from the database 
	/// </summary>
	/// <param name="movieId"></param>
	public void deleteSeries(int seriesId)
	{
		//query to delete series in database
		string queryDeleteSeries = "DELETE FROM Series WHERE Id=" + seriesId;

		//open connection and execute query
		_connection.Open();

		SqlCommand commandDeleteSeries = new SqlCommand(queryDeleteSeries, _connection);
		commandDeleteSeries.ExecuteNonQuery();

		//close connection
		_connection.Close();
	}

	/// <summary>
	/// add series to database, if genre, directorName or mainActorName did not exist in the database before, add them to the appropriate tables 
	/// </summary>
	/// <param name="title"></param>
	/// <param name="genre"></param>
	/// <param name="directorName"></param>
	/// <param name="releaseYear"></param>
	/// <param name="mainActorName"></param>
	public void addSeries(string title, string genre, string directorName, int releaseYear, string mainActorName)
	{
		//check if this series already exists in the database 
		int seriesId = getIdOfValueInTable("Name", title, "Series");
		//dont add same series to database
		if (seriesId != (-1))
		{
			MessageBox.Show("Series already exists");
			return;
		}

		//get genre id
		int genreId = getIdOfValueInTable("Name", genre, "Genres");

		//if there is no given genre insert new into Genres table and get Id
		if (genreId == (-1))
		{
			insertIntoSmallTable(genre, "Genres");
			genreId = getIdOfValueInTable("Name", genre, "Genres");
		}

		//get directorId
		int directorId = getIdOfValueInTable("Name", directorName, "Genres");

		//if there is no given director insert new into Directors table and get Id
		if (directorId == (-1))
		{
			insertIntoSmallTable(directorName, "Directors");
			directorId = getIdOfValueInTable("Name", directorName, "Directors");
		}

		//get main actor id
		int mainActorId = getIdOfValueInTable("Name", mainActorName, "Actors");

		//if there is no given actor insert new into Actors table and get Id
		if (mainActorId == (-1))
		{
			insertIntoSmallTable(mainActorName, "Actors");
			mainActorId = getIdOfValueInTable("Name", mainActorName, "Actors");
		}

		//query to add series to database
		string queryAddSeries = "INSERT INTO Series(Name, GenreId, DirectorId, ReleaseYear, MainActorId) VALUES(\'" + title + "\', " + genreId + ", " + directorId + ", " + releaseYear + ", " + mainActorId + ");";


		//open connection and execute query
		_connection.Open();

		SqlCommand commandAddSeries = new SqlCommand(queryAddSeries, _connection);
		commandAddSeries.ExecuteNonQuery();


		//close connection
		_connection.Close();
	}

	/// <summary>
	/// returns id of given value in table
	/// </summary>
	/// <returns></returns>
	private int getIdOfValueInTable(string columnName, string value, string tableName)
    {
		//query to find in database given value in given columnName of tableName
		string query = "SELECT Id FROM " + tableName + " WHERE " +  columnName + " LIKE \'" + value + "\' ;";
		SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
		DataTable table = new DataTable();
		adapter.Fill(table);

		//check if the table has any columns, we need only first 
		if (table.Rows.Count > 0)
        { 
			//get first row from table
			DataRow dataRow = table.Rows[0];

			//return its id number
			return int.Parse(dataRow["Id"].ToString());
        }
		//else return -1 (there is no value like given id table)
		return -1;
    }

	/// <summary>
	/// used when there is no genre, actor or director in the database, insert value to tableName 
	/// </summary>
	/// <param name="value"></param>
	/// <param name=""></param>
	private void insertIntoSmallTable(string value, string tableName)
    {
		//query to insert value to table
		string insertQuery = "INSERT INTO " + tableName + "(Name) VALUES (\'" + value + "\');";

		//open connection and execute query
		_connection.Open();

		SqlCommand commandInsertValue = new SqlCommand(insertQuery, _connection);
		commandInsertValue.ExecuteNonQuery();

		//close connection
		_connection.Close();
	}
}
