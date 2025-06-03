using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
namespace AWSSDK.UnitTests
{
    [TestClass]
    public class QueryCompatibleTests
    {
        [TestMethod]
        public void ValidateSdkCanParseCodeField()
        {
            //var stream = Utils.GetResourceStream("QueryCompatibleTC1.txt");
            var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("QueryCompatibleTC1.txt");
            //using (var stream = Utils.GetResourceStream("QueryCompatibleTC1.txt"))
            //{
            //    StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(stream);
            //    var context = new JsonUnmarshallerContext(stream, false, null);
            //    var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            //    Console.WriteLine("hello");
            //}

        }
    }
}
