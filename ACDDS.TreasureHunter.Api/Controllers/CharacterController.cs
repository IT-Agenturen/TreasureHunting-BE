using System;
using System.Collections.Generic;
using System.Linq;
using ACDDS.TreasureHunter.Api.Extensions;
using ACDDS.TreasureHunter.Api.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ACDDS.TreasureHunter.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ILogger<CharacterController> _logger;
        private readonly TreasureHunterService _treasureHunterService;

        public CharacterController(
            ILogger<CharacterController> logger,
            TreasureHunterService treasureHunterService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _treasureHunterService = treasureHunterService ?? throw new ArgumentNullException(nameof(treasureHunterService));
        }       

        [HttpGet()]
        public List<CharacterResult> GetCharacter()
        {
            var result = new List<CharacterResult>();

            result.Add(new CharacterResult
            {
                Id = 1,
                Name = "Jim",
                Luck = 26,
                Hit_points = 63,
                Characterimage = "../assets/images/character/Characters/Jim.png"
            });

            result.Add(new CharacterResult
            {
                Id = 2,
                Name = "Lily",
                Luck = 11,
                Hit_points = 79,
                Characterimage = "../assets/images/character/Characters/Lily.png"
            });

            result.Add(new CharacterResult
            {
                Id = 3,
                Name = "Richard",
                Luck = 43,
                Hit_points = 42,
                Characterimage = "../assets/images/character/Characters/Richard.png"
            });

            result.Shuffle();

            return result;

            //var character = _treasureHunterService.GetCharacter();
            //var characterWealth = _treasureHunterService.GetCharacterWealth();
            //var characterEquipment = _treasureHunterService
            //    .GetCharacterEquipment()
            //    .Select(ModelConversions.ToEquipmentResponseModel)
            //    .ToList();
            //return new CharacterResponse {
            //    Name = character.Name,
            //    HitPoints = character.HitPoints,
            //    Luck = character.Luck,
            //    Wealth = characterWealth,
            //    Equipment = characterEquipment
            //};
        }
    }
}
