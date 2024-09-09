using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Runtime.Internal
{
    public interface IAmazonWebServiceRequest
    {
        EventHandler<StreamTransferProgressArgs> StreamUploadProgressCallback { get; set; }

        void AddBeforeRequestHandler(RequestEventHandler handler);

        void RemoveBeforeRequestHandler(RequestEventHandler handler);

        Dictionary<string, object> RequestState { get; }

        [Obsolete("UseSigV4 is deprecated. Use SignatureVersion directly instead.")]
        bool UseSigV4 { get; set; }

        SignatureVersion SignatureVersion { get; set; }
    }
}
