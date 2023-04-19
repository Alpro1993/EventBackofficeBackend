using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventBackoffice.Backend.Models.DTOs.Event;
[Serializable]
public class GetMultipleEventsResponse 
{
    public List<GetSingleEventResponse> Events {get; set;} = default!;
}