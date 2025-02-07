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
using System.Collections.Generic;
using System.Linq;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class PollyTests
    {
        [TestMethod]
        [TestCategory("Polly")]
        public void MakeSureGeneratePresignedUrlGetsUpdated()
        {
            var expectedPropertyNames = new HashSet<string>()
            {
                "LexiconNames",
                "OutputFormat",
                "SampleRate",
                "SpeechMarkTypes",
                "Text",
                "TextType",
                "VoiceId",
                "LanguageCode",
                "Engine"
            };
            var actualPropertyNames = new HashSet<string>(typeof(SynthesizeSpeechRequest).GetProperties().Select(p => p.Name).ToArray());

            Assert.IsTrue(expectedPropertyNames.SetEquals(actualPropertyNames),
                "You need to update SynthesizeSpeechUtil.GeneratePresignedUrl and the expectedPropertyNames variable above.");
        }

        [TestMethod]
        [TestCategory("Polly")]
        public void TestLexiconNamesNull()
        {
            var request = new SynthesizeSpeechRequest();
            var url = SynthesizeSpeechUtil.GeneratePresignedUrl(RegionEndpoint.USWest2, request);
            Assert.IsFalse(url.Contains("LexiconNames"));
        }

        [TestMethod]
        [TestCategory("Polly")]
        public void TestLexiconNames0()
        {
            var request = new SynthesizeSpeechRequest()
            {
                LexiconNames = new List<string>()
            };
            var url = SynthesizeSpeechUtil.GeneratePresignedUrl(RegionEndpoint.USWest2, request);
            Assert.IsFalse(url.Contains("LexiconNames"));
        }

        [TestMethod]
        [TestCategory("Polly")]
        public void TestLexiconNames1()
        {
            var request = new SynthesizeSpeechRequest()
            {
                LexiconNames = new List<string>() { "lex1" }
            };
            var url = SynthesizeSpeechUtil.GeneratePresignedUrl(RegionEndpoint.USWest2, request);
            Assert.IsTrue(url.Contains("LexiconNames=lex1"));
        }

        [TestMethod]
        [TestCategory("Polly")]
        public void TestLexiconNames2()
        {
            var request = new SynthesizeSpeechRequest()
            {
                LexiconNames = new List<string>() { "lex1", "lex2" }
            };
            var url = SynthesizeSpeechUtil.GeneratePresignedUrl(RegionEndpoint.USWest2, request);
            Assert.IsTrue(url.Contains("LexiconNames=lex1&LexiconNames=lex2"));
        }

    }
}
