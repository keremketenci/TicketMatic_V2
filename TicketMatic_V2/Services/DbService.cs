using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketMatic_V2.Data;
using TicketMatic_V2.Models;

namespace TicketMatic_V2.Services
{
    internal class DbService
    {
        AppDbContext _dbContext = new AppDbContext();

        // Movie
        public List<Movie> GetAllMovies()
        {
            return _dbContext.Movies.ToList();
        }

        public List<string> GetMovieNames()
        {
            return _dbContext.Movies.Select(m => m.movieName).ToList();
        }

        public Movie GetMovieDetailsBasedOnmovieId(int movieId)
        {
            return _dbContext.Movies.FirstOrDefault(m => m.id == movieId);
        }

        // Session
        public List<Session> GetSessionsBasedOnMovie(string movieName)
        {
            var sessions = _dbContext.Sessions
                                     .Join(_dbContext.Movies,
                                           session => session.movieId,
                                           movie => movie.id,
                                           (session, movie) => new { Session = session, MovieName = movie.movieName })
                                     .Where(x => x.MovieName == movieName)
                                     .Select(x => x.Session)
                                     .ToList();

            return sessions;
        }

        public Session GetSessionDetailsBasedOnsessionId(int sessionId)
        {
            return _dbContext.Sessions.FirstOrDefault(s => s.id == sessionId);
        }
        
        public List<string> ReturnSeatsNoBasedOnSessionId(int sessionId)
        {
            return _dbContext.Reservations.Where(r => r.sessionId == sessionId).Select(r => r.seatNo).ToList();
        }

        // Theater
        public List<string> GetSeatNoBasedOnSessionId(int sessionId)
        {
            var seatNos = _dbContext.Reservations
                                  .Where(r => r.sessionId == sessionId)
                                  .Select(r => r.seatNo)
                                  .ToList();
            return seatNos;
        }

        // Reservation
        public List<Reservation> GetAllReservations()
        {
            return _dbContext.Reservations.ToList();
        }
        public Reservation GetSeatsNoBasedOnsessionId(int sessionId)
        {
            return _dbContext.Reservations
                        .FirstOrDefault(r => r.sessionId == sessionId);
        }
    }
}
