using System;
using System.Collections.Generic;
using System.Text;

namespace AutoUpdate.Common
{
    public interface IAutoUpdateService
    {
        void Start();
        void Stop();
    }
}
