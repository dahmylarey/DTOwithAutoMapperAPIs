namespace DTOwithAutoMapperAPIs.Controllers
{
    using AutoMapper;
    using DTOwithAutoMapperAPIs.Data;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Defines the <see cref="SuperHeroController" />
    /// </summary>
    [Route("api/controller")]
    [ApiController]
    public class SuperHeroController : Controller
    {
        /// <summary>
        /// Defines the heroes
        /// </summary>
        private static List<SuperHero> heroes = new List<SuperHero>{
            new SuperHero
            {
                Id = 1,
                Name = "Spider Man",
                FirstName = "peter",
                LastName = "Parker",
                Place = "New York City",
                DateAdded = new DateTime(2001, 08, 10 ),
                DateModified = DateTime.Now,
            },
            new SuperHero
            {
                Id = 2,
                Name = "Iron Man",
                FirstName = "Tony",
                LastName = "Stark",
                Place = "Malibu",
                DateAdded = new DateTime(1970, 05, 29 ),
                DateModified = DateTime.Now,
            }
        };

        //inject the Mapper

        /// <summary>
        /// Defines the _mapper
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="SuperHeroController"/> class.
        /// </summary>
        /// <param name="mapper">The mapper<see cref="IMapper"/></param>
        public SuperHeroController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// The GetHeroes
        /// </summary>
        /// <returns>The <see cref="ActionResult{List{SuperHero}}"/></returns>
        [HttpGet]
        public ActionResult<List<SuperHero>> GetHeroes()
        {
            //var superDto = new SuperHero();
            //superDto.Id = 1;
            //superDto.Name = heroes[0].Name;
            //superDto.FirstName = heroes[0].FirstName;
            //superDto.LastName = heroes[0].LastName;
            //superDto.Place = heroes[0].Place;
            return Ok(heroes.Select(hero => _mapper.Map<SuperHeroDTO>(hero)));
        }

        /// <summary>
        /// The AddHero
        /// </summary>
        /// <param name="newHero">The newHero<see cref="SuperHeroDTO"/></param>
        /// <returns>The <see cref="ActionResult{List{SuperHero}}"/></returns>
        [HttpPost]
        public ActionResult<List<SuperHero>> AddHero(SuperHeroDTO newHero)
        {
            var hero = _mapper.Map<SuperHero>(newHero);
            heroes.Add(hero);

            return Ok(heroes.Select(hero => _mapper.Map<SuperHeroDTO>(hero)));
        }
    }
}