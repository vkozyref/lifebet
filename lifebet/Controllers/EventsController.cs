using System.Collections.Generic;
using System.Threading.Tasks;
using lifebet.dataaccess.Repositories;
using lifebet.dataaccess.UnitOfWork;
using lifebet.entity;
using Microsoft.AspNetCore.Mvc;

namespace lifebet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IBettingUnitOfWork _bettingUnitOfWork;

        public EventsController(IBettingUnitOfWork bettingUnitOfWork)
        {
            _bettingUnitOfWork = bettingUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> Get()
        {
            return await _bettingUnitOfWork.EventRepository.GetAsync(x => true);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> Get(int id)
        {
            return await _bettingUnitOfWork.EventRepository.GetAsync(id);
        }

        [HttpPost]
        public async Task Post([FromBody] Event value)
        {
            await _bettingUnitOfWork.EventRepository.AddAsync(value);
            await _bettingUnitOfWork.SaveAsync();
        }

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Event value)
        {
            _bettingUnitOfWork.EventRepository.Update(value);
            await _bettingUnitOfWork.SaveAsync();
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _bettingUnitOfWork.EventRepository.Remove(id);
            await _bettingUnitOfWork.SaveAsync();
        }
    }
}
