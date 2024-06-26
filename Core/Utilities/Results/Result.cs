﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool Success, string message) : this(Success)
        {
            message = message;
        }

        public Result(bool Success) 
        {
        Success = Success;
        }

       

        public bool Success { get; }

        public string Message { get; }
    }
}
