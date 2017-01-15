﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using MovieRentals.Dtos;
using MovieRentals.Models;

namespace MovieRentals.Controllers.Api
{
    public class MovieController : ApiController
    {
        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/movie
        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies
                .Include(c => c.GenreType)
                .ToList()
                .Select(Mapper.Map<Movie,MovieDto>);
        }

        // GET api/movie/1
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        // POST api/movie
        [HttpPost]
         public IHttpActionResult CreateMovie(MovieDto movieDto)
         {
             if (!ModelState.IsValid)
                 return BadRequest();
 
             var movie = Mapper.Map<MovieDto, Movie>(movieDto);
             _context.Movies.Add(movie);
             _context.SaveChanges();
 
             movieDto.Id = movie.Id;
             return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
         }
 
         // PUT api/movie/1
         [HttpPut]
         public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
         {
             if (!ModelState.IsValid)
                 return BadRequest();
 
             var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);
 
             if (movieInDb == null)
                 return NotFound();
 
             Mapper.Map(movieDto, movieInDb);
 
             _context.SaveChanges();
 
            return Ok();
         }
 
         // DELETE api/movie/1
         [HttpDelete]
         public IHttpActionResult DeleteMovie(int id)
         {
             var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);
 
             if (movieInDb == null)
                 return NotFound();
 
             _context.Movies.Remove(movieInDb);
             _context.SaveChanges();
 
             return Ok();
         }
    }
}
