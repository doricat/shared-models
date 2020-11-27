﻿using System.Collections.Generic;

namespace WebApi.Models
{
    public class ApiError
    {
        public ApiError(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public string Code { get; set; }

        public string Message { get; set; }

        public string Target { get; set; }

        public IList<ApiError> Details { get; set; }

        public InnerErrorObject InnerError { get; set; }
    }
}