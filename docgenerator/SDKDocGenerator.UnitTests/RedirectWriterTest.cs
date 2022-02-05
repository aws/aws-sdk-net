using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace SDKDocGenerator.UnitTests
{
    public class RedirectWriterTest
    {
        [Fact]
        public void ExtractFromUrlTest()
        {
            string serviceId;
            string shape;
            
            Assert.True(SDKDocRedirectWriter.ExtractServiceIDAndShapeFromUrl("https://docs.aws.amazon.com/goto/WebAPI/streams-dynamodb-2012-08-10/DescribeStream", out serviceId, out shape));
            Assert.Equal("streams-dynamodb-2012-08-10", serviceId);
            Assert.Equal("DescribeStream", shape);

            Assert.True(SDKDocRedirectWriter.ExtractServiceIDAndShapeFromUrl("https://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetImageAttribute", out serviceId, out shape));
            Assert.Equal("ec2-2016-11-15", serviceId);
            Assert.Equal("ResetImageAttribute", shape);
        }
    }
}
