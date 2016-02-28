using System;
using System.Collections.Generic;
using System.Text;

namespace AutoUpdate.Common
{
    public interface IAutoUpdateMetadata
    {
        string BlobSourceUrl { get; }
    }
}
