// /*******************************************************************************
//  *  Copyright 2008-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//  *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
//  *  this file except in compliance with the License. A copy of the License is located at
//  *
//  *  http://aws.amazon.com/apache2.0
//  *
//  *  or in the "license" file accompanying this file.
//  *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
//  *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
//  *  specific language governing permissions and limitations under the License.
//  * *****************************************************************************
//  *    __  _    _  ___
//  *   (  )( \/\/ )/ __)
//  *   /__\ \    / \__ \
//  *  (_)(_) \/\/  (___/
//  *
//  *  AWS SDK for .NET
//  *
//  */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class SelectObjectContentTests : TestBase<AmazonS3Client>
    {
        private static readonly string TestFileKey = "selectobjectcontent_content.txt";
        private static readonly string VerificationFilePath = "selectobjectcontent_verify.txt";

        private static readonly string TestContent = GetResourceText(TestFileKey);
        private static readonly string VerificationContent = GetResourceText(VerificationFilePath);

        private const string SelectQuery = "select * from S3Object s where s.LOCATIONID = 'VALE'";

        private static string _bucketName;
        private static string _keyName;

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            _bucketName = S3TestUtils.CreateBucketWithWait(Client);
            _keyName = UtilityMethods.GenerateName(nameof(SelectObjectContentTests));

            Client.PutObject(new PutObjectRequest()
            {
                BucketName = _bucketName,
                Key = _keyName,
                ContentBody = TestContent
            });
        }

        /// <summary>
        /// Tests the Enumerable method for iterating through an EventStream returned from SelectObjectContent.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestCallEnumerable()
        {
            var eventStream = GetSelectObjectContentEventStream();

            var testContent = "";
            var eventTypes = new List<Type>();

            foreach (var ev in eventStream)
            {
                if (ev is RecordsEvent records)
                {
                    using (var reader = new StreamReader(records.Payload, Encoding.UTF8))
                    {
                        testContent = reader.ReadToEnd();
                    }
                }
                eventTypes.Add(ev.GetType());
            }

            AssertRecordsEqualsExpected(testContent);

            Assert.IsTrue(new List<Type>()
            {
                typeof(RecordsEvent),
                typeof(StatsEvent),
                typeof(EndEvent)
            }.SequenceEqual(eventTypes));
        }

        /// <summary>
        /// Tests the Event-Driven method for iterating through an EventStream returned from SelectObjectContent. Technically, the enumerable test should suffice,
        /// but it may be useful to have a itegration test for each interaction pattern.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestCallEvents()
        {
            var eventStream = GetSelectObjectContentEventStream();

            var testContent = "";
            var recordsEvents = new List<RecordsEvent>();

            eventStream.RecordsEventReceived += (sender, args) => recordsEvents.Add(args.EventStreamEvent);
            eventStream.StartProcessing();
            SpinWait.SpinUntil(() => recordsEvents.Count > 0, TimeSpan.FromSeconds(5));

            using (var streamReader = new StreamReader(recordsEvents[0].Payload))
            {
                testContent = streamReader.ReadToEnd();
            }
            eventStream.Dispose();

            AssertRecordsEqualsExpected(testContent);
        }

        private ISelectObjectContentEventStream GetSelectObjectContentEventStream()
        {
            return Client.SelectObjectContent(new SelectObjectContentRequest()
            {
                Bucket = _bucketName,
                Key = _keyName,
                ExpressionType = ExpressionType.SQL,
                Expression = SelectQuery,
                InputSerialization = new InputSerialization()
                {
                    JSON = new JSONInput()
                    {
                        JsonType = JsonType.Lines
                    }
                },
                OutputSerialization = new OutputSerialization()
                {
                    JSON = new JSONOutput()
                }
            }).Payload;
        }

        private void AssertRecordsEqualsExpected(string records)
        {
            Assert.IsTrue(String.Compare(VerificationContent, records, CultureInfo.CurrentCulture,
                              CompareOptions.IgnoreSymbols) == 0);
        }

        private static string GetResourceText(string resourceKey)
        {
            var currentAssembly = typeof(SelectObjectContentTests).Assembly;
            var fileKey = currentAssembly.GetManifestResourceNames()
                .First(name => name.EndsWith(resourceKey));
            var content = currentAssembly.GetManifestResourceStream(fileKey);
            using (var reader = new StreamReader(content, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, _bucketName);
            BaseClean();
        }
    }
}