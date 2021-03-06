﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace LambdaLinq.ViewModels
{
    public class SearchViewModel
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public decimal PriceRangeMin { get; set; }
        public decimal PriceRangeMax { get; set; }
    }
}