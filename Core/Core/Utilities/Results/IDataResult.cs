using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
        //byte[] PasswordHash { get; }
        //byte[] PasswordSalt { get; }
    }
}
