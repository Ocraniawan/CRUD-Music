using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using crud_music.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace crud_music.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistController : ControllerBase
    {
        private readonly dbMusicContext _dbMusicContext;
        public ArtistController(dbMusicContext dbMusicContext)
        {
            _dbMusicContext = dbMusicContext;
        }

        //GET: Artist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artists>>> GetArtist()
        {
            var list =  await _dbMusicContext.Artists.ToListAsync();
            if(list == null)
            {
                return NotFound();
            }
            return list;

        }

        [HttpPost("addArtist")]
        public async Task<ActionResult<Artists>> addArtist(Artists artists)
        {
            _dbMusicContext.Artists.Add(artists);
            await _dbMusicContext.SaveChangesAsync();
            return CreatedAtAction("GetArtist", new { id = artists.ArtistID }, artists);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Artists>> GetArtist(int id)
        {
            var artist = await _dbMusicContext.Artists.FindAsync(id);

            if (artist == null)
            {
                return NotFound();
            }

            return artist;
        }

        // DELETE: api/LoginAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Artists>> DeleteArtist(int id)
        {
            var artist = await _dbMusicContext.Artists.FindAsync(id);
            if (artist == null)
            {
                return NotFound();
            }

            _dbMusicContext.Artists.Remove(artist);
            await _dbMusicContext.SaveChangesAsync();

            return artist;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Artists>> updateArtist(int id, Artists artists)
        {
            if (id != artists.ArtistID)
            {
                return BadRequest();
            }

            _dbMusicContext.Entry(artists).State = EntityState.Modified;

            try
            {
                await _dbMusicContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                    throw;
            }

            return NoContent();
        }

        //https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio
    }
}
