using AudioMixerApi.Services;
using Microsoft.AspNetCore.Mvc;
using SIPSorcery.Net;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AudioMixerApi.Controllers
{
    [ApiController]
    public class MixerController : ControllerBase
    {
        private readonly AudioMixerService _mixerService;
        public MixerController(AudioMixerService audioMixerService)
        {
            _mixerService = audioMixerService;
        }
        //[HttpPost]
        //public async Task<IActionResult> MixAudios([FromBody] List<RTPPacket> audios)
        //{
        //}
    }
}
