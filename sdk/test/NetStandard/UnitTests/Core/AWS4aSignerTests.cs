/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Runtime.Internal.Auth;
using Amazon.Util;
using Xunit;

namespace UnitTests.NetStandard.Core
{
    public class AWS4aSignerTests
    {
        private const string SigningTestAccessKeyId = "AKIDEXAMPLE";
        private const string SigningTestSecretAccessKey = "wJalrXUtnFEMI/K7MDENG+bPxRfiCYEXAMPLEKEY";

        /* The public coordinates of the ecc key derived from the above credentials pair */
        private const string SigningTestEccPubX = "b6618f6a65740a99e650b33b6b4b5bd0d43b176d721a3edfea7e7d2d56d936b1";
        private const string SigningTestEccPubY = "865ed22a7eadc9c5cb9d2cbaca1b3699139fedc5043dc6661864218330c8e518";

        [Fact]
        public void DeriveSigningKey()
        {
            using var key = AWS4aSigner.ComputeSigningKey(SigningTestAccessKeyId, SigningTestSecretAccessKey);
            var parameters = key.ExportParameters(false);
            Assert.Equal(AWSSDKUtils.HexStringToBytes(SigningTestEccPubX), parameters.Q.X);
            Assert.Equal(AWSSDKUtils.HexStringToBytes(SigningTestEccPubY), parameters.Q.Y);
        }
    }
}
