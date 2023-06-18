using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gym_app_backend.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MembershipType
    {
        Daily = 1,
        Monthly = 2,
        Semesterly = 3,
        NoMembership = 4,
    }
}