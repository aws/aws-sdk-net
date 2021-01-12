using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.DocDB.Internal
{
    /// <summary>
    /// Interface implemented by requests that are supported by <see cref="PreSignedUrlRequestHandler"/> 
    /// </summary>
    public interface IPreSignedUrlRequest
    {
        /// <summary>
        /// <para>
        /// Gets and sets the source region for the operation.
        /// If set, the PreSignedUrl property is not required for cross-region operations.
        /// PreSignedUrl will be auto-generated based on SourceRegion, and sent by the client.
        /// </para>
        /// </summary>
        string SourceRegion { get; set; }

        /// <summary>
        /// Gets and sets the property PreSignedUrl.
        /// </summary>
        string PreSignedUrl { get; set; }
    }
}
