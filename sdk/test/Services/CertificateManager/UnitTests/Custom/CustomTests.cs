using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.CertificateManager.Model;
using Amazon.CertificateManager.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Util;
namespace AWSSDK.UnitTests
{

    [TestClass]
    public class CustomTests
    {
        //since ACM is a aws json service without the query compatible trait we create this custom test here
        [TestMethod]
        public void ValidateSdkDoesNotSendXamznQueryModeHeaderIfServiceHasNoAwsQueryCompatibleTrait()
        {
            //Any RequestMarshaller
            var request = new GetAccountConfigurationRequest { };
            var actualRequest = GetAccountConfigurationRequestMarshaller.Instance.Marshall(request);
            Assert.IsFalse(actualRequest.Headers.TryGetValue(HeaderKeys.XAmzQueryMode, out _));
        }
    }
}
