﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Errors
{
    public class ApiValidationErrorReponse:ApiResponse
    {
        public ApiValidationErrorReponse():
            base(400)
        {

        }

        public IEnumerable<string> Errors { get; set; }
    }
}
