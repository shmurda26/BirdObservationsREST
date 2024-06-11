using Microsoft.AspNetCore.Mvc;
using BirdObservationsLib;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BirdObservationsREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdObservationsController : ControllerBase
    {
        private readonly BirdObservationsRepository _birdObservationsRepository;

        public BirdObservationsController(BirdObservationsRepository BirdObservationsRepository)
        {
            _birdObservationsRepository = BirdObservationsRepository;
        }

        // GET: api/
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<BirdObservation>> Get([FromQuery] int HowMany, string? Specices = null)
        {
            IEnumerable<BirdObservation> birdObs = _birdObservationsRepository.GetAll();
            if (birdObs == null)
            {
                return BadRequest(" is null");

            }
            else if (!birdObs.Any())
            {
                return NoContent();
            }
            else
            {
                return Ok(birdObs);
            }
        }
        // GET api/
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Get(int id)
        {
            BirdObservation birds = _birdObservationsRepository.GetById(id);
            if (birds == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(birds);
            }
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<BirdObservation> Post([FromBody] BirdObservation value)
        {
            BirdObservation birds = _birdObservationsRepository.Add(value);
            return CreatedAtAction(nameof(Get), new { id = birds.Id }, birds);

        }
       
       
    }

}
