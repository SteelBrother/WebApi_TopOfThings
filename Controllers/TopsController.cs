using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiCrud.Data;
using WebApiCrud.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using WebApiCrud.Dtos;

namespace WebApiCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopsController : ControllerBase
    {
        private IApiRepository<TopGames> _repo;
        public TopsController(IApiRepository<TopGames> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repo.GetAll());
        }


        [HttpPost]
        public async Task<IActionResult> Save(TopGamesDTO topGamesDTO) 
        {
            var Top = new TopGames()
            {
                Name = topGamesDTO.Name,
                Price = topGamesDTO.Price,
                PublicationDate = topGamesDTO.PublicationDate,
            };

            await _repo.Insert(Top);
            return Ok(Top);
        }

    }
}