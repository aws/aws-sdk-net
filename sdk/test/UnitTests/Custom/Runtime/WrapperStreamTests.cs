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
    public class WrapperStreamTests : WrapperStreamTestBase<WrapperStream>
    {
#if ASYNC_AWAIT
        public override WrapperStream WrapStream(Stream baseStream)
        {
            return new WrapperStream(baseStream);
        }
#endif
    }
}
