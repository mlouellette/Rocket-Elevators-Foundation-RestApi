﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;


namespace Rocket_Elevators_Rest_API.Models
{
    public class Battery
    {

        
        [Key]
        public int id { get; set; }
        public string? status { get; set; }
        public int building_id { get; set; }

    }
}
