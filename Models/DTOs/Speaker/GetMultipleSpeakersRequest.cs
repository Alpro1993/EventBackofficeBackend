using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventBackoffice.Backend.Models.DTOs.Speaker
{
    public class GetMultipleSpeakersRequest
    {
        public List<GetSingleSpeakerRequest> Speakers {get; set;} = default!;
    }
}