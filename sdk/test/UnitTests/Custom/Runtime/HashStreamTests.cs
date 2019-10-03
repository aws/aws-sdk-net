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
    public class HashStreamTests : WrapperStreamTestBase<HashStream>
    {
#if ASYNC_AWAIT
        public override HashStream WrapStream(Stream baseStream)
        {
            return new MD5Stream(baseStream, null, 0);
        }
#endif
    }
}
