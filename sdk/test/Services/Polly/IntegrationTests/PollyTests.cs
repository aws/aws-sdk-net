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

using Amazon;
using Amazon.Polly;
using Amazon.Polly.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.Polly
{
    [TestClass]
    [TestCategory("Polly")]
    public class PollyTests
    {
        [TestMethod]
        public async Task HappyCaseAPI()
        {
            using (var client = new AmazonPollyClient(RegionEndpoint.USWest2))
            {
                var response = await client.SynthesizeSpeechAsync(GetMp3Request());
                Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
                Assert.IsTrue(response.AudioStream.ReadByte() > -1);
            }
        }

        [TestMethod]
        public async Task APIWithSpeechMarks()
        {
            using (var client = new AmazonPollyClient(RegionEndpoint.USWest2))
            {
                var response = await client.SynthesizeSpeechAsync(GetSpeechMarkRequest());
                Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
                using (var streamReader = new StreamReader(response.AudioStream))
                {
                    string text = streamReader.ReadToEnd(); // read the stream to the end to make sure it's valid JSON
                    AssertSpeechMarks(text);
                }
            }
        }

        [TestMethod]
        public void HappyCasePresignedUrl()
        {
            AssertPreSignedUrl(SynthesizeSpeechUtil.GeneratePresignedUrl(RegionEndpoint.USWest2, GetMp3Request()));
        }

        [TestMethod]
        public void PresignedUrlWithSpeechMarks()
        {
            var data = AssertPreSignedUrl(SynthesizeSpeechUtil.GeneratePresignedUrl(RegionEndpoint.USWest2, GetSpeechMarkRequest()));
            AssertSpeechMarks(Encoding.UTF8.GetString(data));
        }

        [TestMethod]
        public void EnsureIsUrlEncoded()
        {
            var request = GetMp3Request();
            request.Text = "hello == hello"; // we will get an exception if the == isn't encoded
            AssertPreSignedUrl(SynthesizeSpeechUtil.GeneratePresignedUrl(RegionEndpoint.USWest2, GetMp3Request()));
        }

        private static void AssertSpeechMarks(string speechMarksString)
        {
            string[] speechMarksJsonObjects = speechMarksString.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string speechMarksJsonObject in speechMarksJsonObjects)
            {
                var jsonDoc = JsonDocument.Parse(speechMarksJsonObject);
                IEnumerable<string> propertyNames = jsonDoc.RootElement.EnumerateObject().Select(x => x.Name);
                Assert.IsTrue(propertyNames.Contains("time"));
                Assert.IsTrue(propertyNames.Contains("type"));
                Assert.IsTrue(propertyNames.Contains("start"));
                Assert.IsTrue(propertyNames.Contains("end"));
                Assert.IsTrue(propertyNames.Contains("value"));
            }
        }

        private static byte[] AssertPreSignedUrl(string url)
        {
            // download using the PreSigned URL in a totally independent WebClient
            byte[] data;
            using (var webClient = new WebClient())
            {
                data = webClient.DownloadData(url);
            }

            // make sure there are no exceptions, and that there's something there
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Length > 0);

            return data;
        }

        private static SynthesizeSpeechRequest GetMp3Request()
        {
            return new SynthesizeSpeechRequest
            {
                VoiceId = "Joanna",
                Text = "Hello",
                OutputFormat = OutputFormat.Mp3
            };
        }

        private static SynthesizeSpeechRequest GetSpeechMarkRequest()
        {
            return new SynthesizeSpeechRequest
            {
                VoiceId = "Joanna",
                Text = "Hello",
                OutputFormat = OutputFormat.Json,
                SpeechMarkTypes = new List<string> { "word", "sentence" }
            };
        }
    }
}
