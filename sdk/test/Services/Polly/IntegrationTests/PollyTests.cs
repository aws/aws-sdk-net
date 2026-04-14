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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.Polly
{
    [Trait("Category", "Polly")]
    public class PollyTests
    {
        [Fact]
        public async Task HappyCaseAPI()
        {
            using (var client = new AmazonPollyClient(RegionEndpoint.USWest2))
            {
                var response = await client.SynthesizeSpeechAsync(GetMp3Request());
                Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);
                Assert.True(response.AudioStream.ReadByte() > -1);
            }
        }

        [Fact]
        public async Task APIWithSpeechMarks()
        {
            using (var client = new AmazonPollyClient(RegionEndpoint.USWest2))
            {
                var response = await client.SynthesizeSpeechAsync(GetSpeechMarkRequest());
                Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);
                using (var streamReader = new StreamReader(response.AudioStream))
                {
                    string text = await streamReader.ReadToEndAsync(); // read the stream to the end to make sure it's valid JSON
                    AssertSpeechMarks(text);
                }
            }
        }

        [Fact]
        public async Task HappyCasePresignedUrl()
        {
            await AssertPreSignedUrl(SynthesizeSpeechUtil.GeneratePresignedUrl(RegionEndpoint.USWest2, GetMp3Request()));
        }

        [Fact]
        public async Task PresignedUrlWithSpeechMarks()
        {
            var data = await AssertPreSignedUrl(SynthesizeSpeechUtil.GeneratePresignedUrl(RegionEndpoint.USWest2, GetSpeechMarkRequest()));
            AssertSpeechMarks(Encoding.UTF8.GetString(data));
        }

        [Fact]
        public async Task EnsureIsUrlEncoded()
        {
            var request = GetMp3Request();
            request.Text = "hello == hello"; // we will get an exception if the == isn't encoded
            await AssertPreSignedUrl(SynthesizeSpeechUtil.GeneratePresignedUrl(RegionEndpoint.USWest2, GetMp3Request()));
        }

        private static void AssertSpeechMarks(string speechMarksString)
        {
            string[] speechMarksJsonObjects = speechMarksString.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string speechMarksJsonObject in speechMarksJsonObjects)
            {
                var jsonDoc = JsonDocument.Parse(speechMarksJsonObject);
                IEnumerable<string> propertyNames = jsonDoc.RootElement.EnumerateObject().Select(x => x.Name);
                Assert.Contains("time", propertyNames);
                Assert.Contains("type", propertyNames);
                Assert.Contains("start", propertyNames);
                Assert.Contains("end", propertyNames);
                Assert.Contains("value", propertyNames);
            }
        }

        private static async Task<byte[]> AssertPreSignedUrl(string url)
        {
            // download using the PreSigned URL using HttpClient
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var data = await httpClient.GetByteArrayAsync(url);

                // make sure there are no exceptions, and that there's something there
                Assert.NotNull(data);
                Assert.True(data.Length > 0);

                return data;
            }
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
