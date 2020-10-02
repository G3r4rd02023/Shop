﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Models
{
    public class CityViewModel
    {
		public int CountryId { get; set; }

		public int CityId { get; set; }

		[Required]
		[Display(Name = "City")]
		[MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
		public string Name { get; set; }

	}
}