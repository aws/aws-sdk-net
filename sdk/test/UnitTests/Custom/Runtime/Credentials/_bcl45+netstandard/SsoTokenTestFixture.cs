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

using System;
using System.IO;
using System.Text;
using Amazon.Runtime.Credentials.Internal;

namespace AWSSDK.UnitTests
{
    public class SsoTokenTestFixture : IDisposable
    {
        /// <summary>
        /// A temporary directory that tests can use which will be cleaned up on disposal
        /// </summary>
        public string ScratchDirectory { get; set; }

        public string SampleSsoTokenJson { get; }

        public readonly SsoToken SampleSsoToken = new SsoToken()
        {
            AccessToken = "accessToken",
            ExpiresAt = new DateTime(2020, 1, 2, 3, 4, 5, DateTimeKind.Utc),
            Region = "us-west-2",
            StartUrl = "https://samplessoendpoint.example.com/start",
        };

        public SsoTokenTestFixture()
        {
            CreateScratchDirectory();

            var sampleJsonBuilder = new StringBuilder();
            sampleJsonBuilder.AppendLine();
            sampleJsonBuilder.AppendLine("{");
            sampleJsonBuilder.AppendLine($"    \"accessToken\" : \"{SampleSsoToken.AccessToken}\",");
            sampleJsonBuilder.AppendLine($"    \"expiresAt\"   : \"2020-01-02T03:04:05Z\",");
            sampleJsonBuilder.AppendLine($"    \"region\"      : \"{SampleSsoToken.Region}\",");
            sampleJsonBuilder.AppendLine($"    \"startUrl\"    : \"{SampleSsoToken.StartUrl}\"");
            sampleJsonBuilder.Append("}");
            SampleSsoTokenJson = sampleJsonBuilder.ToString();
        }

        public SsoTokenCache GetTokenCache(string startUrl)
        {
            return new SsoTokenCache(ScratchDirectory, startUrl);
        }

        public void Dispose()
        {
            Directory.Delete(ScratchDirectory, true);
        }

        private void CreateScratchDirectory()
        {
            ScratchDirectory = Path.Combine(Path.GetTempPath(), GetType().Name, Path.GetRandomFileName());
            Directory.CreateDirectory(ScratchDirectory);
        }
    }
}
