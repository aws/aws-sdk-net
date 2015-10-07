using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.KinesisFirehose;
using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class KinesisFirehose : TestBase<AmazonKinesisFirehoseClient>
    {
        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }
        

        // api call requires a service subscription, review post-release
        //[TestMethod]
        [TestCategory("KinesisFirehose")]
        public void KinesisFirehoseListDeliveryStreams()
        {
            var response = Client.ListDeliveryStreams(new ListDeliveryStreamsRequest());   

        }
    }
}
