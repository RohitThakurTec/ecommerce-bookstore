﻿using EcomProject_1155.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    namespace EcommProject_1155.Models.ViewModels
    {
        public class ProductVM
        {
            public Product Product { get; set; }
            public IEnumerable<SelectListItem> CategorytList { get; set; }
            public IEnumerable<SelectListItem> CoverTypeList { get; set; }

        }
    }




