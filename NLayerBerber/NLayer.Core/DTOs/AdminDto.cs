﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
	public class AdminDto : BaseDto
	{
		public string? Name { get; set; }
		public string? AdminNo { get; set; }
		public string AdminMail { get; set; }
		public string AdminŞifre { get; set; }
	}
}