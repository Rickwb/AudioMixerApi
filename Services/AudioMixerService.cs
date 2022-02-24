using AudioMixerApi.Entities;
using AudioMixerApi.Entities.DTOS;
using FFMpegCore;
using SIPSorcery.Net;
using System.Collections.Generic;

namespace AudioMixerApi.Services
{
    public class AudioMixerService
    {
        private readonly FFMpegArgumentProcessor _audioStream;
        public AudioMixerService(AudioStream audioStream)
        {
         
        }
        //public AudioDTO MixAudios(List<RTPPacket> audios)
        //{
        //    _audioStream.
        //}
    }
}
