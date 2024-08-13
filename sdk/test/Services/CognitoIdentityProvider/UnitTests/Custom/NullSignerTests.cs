using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using System.IO;

namespace AWSSDK_DotNet.UnitTests.Marshalling
{
    [TestClass]
    public class NullSignerTests
    {

        /// <summary>
        /// SignUp operation uses the NullSigner which doesn't have a rest or query
        /// protocol associated with it. There was a bug in the SDK when temporary credentials 
        /// were used. The SDK threw an exception not knowing how to set the session token
        /// on the request. Session token does not need to be set when using the null signer.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CognitoIdentityProvider")]
        public void CheckToMakeSureProtocolNotSetForTempCreds()
        {
            var client = new AmazonCognitoIdentityProviderClient("accessKeyId", "secretKey", "sessionToken", Amazon.RegionEndpoint.USEast1);

            Exception caughtException = null;
            try
            {
                client.SignUp(new SignUpRequest
                {
                    ClientId = "clientId",
                    Username = "username",
                    Password = "password"
                });
            }
            catch(Exception e)
            {
                caughtException = e;
            }

            Assert.IsNotNull(caughtException);

            // The Signer pipeline handler will throw an InvalidDataException if it fails to determine
            // protocol.
            Assert.IsNotInstanceOfType(caughtException, typeof(InvalidDataException));

            // The actual exception thrown which is a Cognito Identity Provider exception.
            // Although the previous Assert catches the case for the bug fix. This check is here
            // in case the internal code changes in the future.
            Assert.IsInstanceOfType(caughtException, typeof(ResourceNotFoundException));
        }
    }
}
