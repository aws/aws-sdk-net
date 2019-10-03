using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class ChunkedUploadWrapperStreamTests : WrapperStreamTestBase<ChunkedUploadWrapperStream>
    {
#if ASYNC_AWAIT
        public override ChunkedUploadWrapperStream WrapStream(Stream baseStream)
        {
            return new ChunkedUploadWrapperStream(baseStream, 1024, null);
        }
#endif
    }
}
