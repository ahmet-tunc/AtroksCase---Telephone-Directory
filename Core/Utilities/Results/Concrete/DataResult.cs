﻿using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T>:Result, IDataResult<T>
    {
        public DataResult(T data, string message, bool success) : base(message, success)
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; set; }
    }
}
