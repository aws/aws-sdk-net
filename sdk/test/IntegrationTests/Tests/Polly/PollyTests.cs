/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon;
using Amazon.Polly;
using Amazon.Polly.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace AWSSDK_DotNet.IntegrationTests.Tests.Polly
{
    [TestClass]
    public class PollyTests
    {
        [TestMethod]
        [TestCategory("Polly")]
        public void HappyCase()
        {
            // build the request and get the PreSigned URL
            var request = new SynthesizeSpeechRequest()
            {
                VoiceId = "Joanna",
                Text = "Hello",
                OutputFormat = OutputFormat.Mp3
            };
            var url = SynthesizeSpeechUtil.GeneratePresignedUrl(RegionEndpoint.USWest2, request);

            // download using the PreSigned URL in a totally independent WebClient
            byte[] mp3;
            using (var webClient = new WebClient())
            {
                mp3 = webClient.DownloadData(url);
            }

            // make sure there are no exceptions, and that there's something there
            Assert.IsNotNull(mp3);
            Assert.IsTrue(mp3.Length > 0);
        }
    }
}
