using System;
using System.Collections.Generic;
using System.Text;

namespace AutoUpdate.Common
{
    public interface IAutoUpdateApplication
    {
        void Initialize(IAutoUpdateMetadata metadata);
        int Start(string[] args);
    }
}
