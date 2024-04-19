using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TicketMatic_V2
{
    public static class DbInitializer
    {
        private static string connectionString = "Data Source=..\\..\\Data\\TicketMaticDb.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists("..\\..\\Data\\TicketMaticDb.db"))
            {
                SQLiteConnection.CreateFile("..\\..\\Data\\TicketMaticDb.db");

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Users
                    string createUsersTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users(
                        id INTEGER PRIMARY KEY NOT NULL,
                        userName TEXT NOT NULL,
                        password TEXT NOT NULL
                    );"
                    ;
                    string insertUserQuery = @"
                    INSERT INTO Users (userName, password) VALUES ('user1', 'password1');";

                    // Movies
                    string createMoviesTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Movies(
                        id INTEGER PRIMARY KEY NOT NULL,
                        movieName TEXT NOT NULL,
                        movieGenre TEXT NOT NULL
                    );";
                    string insertMovieQuery = @"
                    INSERT INTO Movies (movieName, movieGenre) VALUES ('The Batman', 'superhero');
                    INSERT INTO Movies (movieName, movieGenre) VALUES ('Spider-Man 2', 'superhero');";

                    // Theaters
                    string createTheatersTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Theaters(
                        id INTEGER PRIMARY KEY NOT NULL,
                        theaterCapacity INTEGER NOT NULL
                    );";
                    string insertTheaterQuery = @"
                    INSERT INTO Theaters (theaterCapacity) VALUES (50);
                    INSERT INTO Theaters (theaterCapacity) VALUES (50);
                    INSERT INTO Theaters (theaterCapacity) VALUES (50);
                    INSERT INTO Theaters (theaterCapacity) VALUES (50);";

                    // Sessions
                    string createSessionsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Sessions(
                        id INTEGER PRIMARY KEY NOT NULL,
                        date TEXT NOT NULL,
                        time TEXT NOT NULL,
                        subtitle BOOL NOT NULL,
                        movieId INTEGER NOT NULL,
                        theaterId INTEGER NOT NULL,

                        FOREIGN KEY (movieId) REFERENCES Movies(id),
                        FOREIGN KEY (theaterId) REFERENCES Theaters(id)
                    );";
                    string insertSessionQuery = @"
                    INSERT INTO Sessions (date, time, subtitle, movieId, theaterId) VALUES ('01.01.2025', '19:00', 0, 1, 1);
                    INSERT INTO Sessions (date, time, subtitle, movieId, theaterId) VALUES ('01.01.2025', '23:00', 1, 1, 1);
                    INSERT INTO Sessions (date, time, subtitle, movieId, theaterId) VALUES ('01.01.2025', '19:00', 0, 1, 2);
                    INSERT INTO Sessions (date, time, subtitle, movieId, theaterId) VALUES ('01.01.2025', '23:00', 1, 1, 2);

                    INSERT INTO Sessions (date, time, subtitle, movieId, theaterId) VALUES ('01.01.2025', '19:00', 0, 2, 3);
                    INSERT INTO Sessions (date, time, subtitle, movieId, theaterId) VALUES ('01.01.2025', '23:00', 1, 2, 3);
                    INSERT INTO Sessions (date, time, subtitle, movieId, theaterId) VALUES ('01.01.2025', '19:00', 0, 2, 4);
                    INSERT INTO Sessions (date, time, subtitle, movieId, theaterId) VALUES ('01.01.2025', '23:00', 1, 2, 4);";

                    // Reservation
                    string createReservationsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Reservations(
                        id INTEGER PRIMARY KEY NOT NULL,
                        seatNo TEXT NOT NULL,
                        sessionId INTEGER NOT NULL,
                        userId INTEGER NOT NULL,

                        FOREIGN KEY (sessionId) REFERENCES Sessions(id),
                        FOREIGN KEY (userId) REFERENCES Users(id)
                    );";
                    string insertReservationQuery = @"
                    INSERT INTO Reservations (seatNo, sessionId, userId) VALUES ('a1', 1, 1);
                    INSERT INTO Reservations (seatNo, sessionId, userId) VALUES ('a2', 1, 1);
                    INSERT INTO Reservations (seatNo, sessionId, userId) VALUES ('a3', 1, 1);";

                    using (var command = new SQLiteCommand(connection))
                    {
                        // Users
                        command.CommandText = createUsersTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertUserQuery;
                        command.ExecuteNonQuery();

                        // Movies
                        command.CommandText = createMoviesTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertMovieQuery;
                        command.ExecuteNonQuery();

                        // Theaters
                        command.CommandText = createTheatersTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertTheaterQuery;
                        command.ExecuteNonQuery();

                        // Sessions
                        command.CommandText = createSessionsTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertSessionQuery;
                        command.ExecuteNonQuery();

                        // Reservation
                        command.CommandText = createReservationsTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertReservationQuery;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}