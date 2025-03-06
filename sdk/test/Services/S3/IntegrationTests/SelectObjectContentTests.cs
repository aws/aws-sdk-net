// /*******************************************************************************
//  *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

        // 1st line in input is considered as headers in CSVInput test configuration, hence not returned in output.
        private static readonly string TestCSVContent = "A,B\r\n1,2\r\n3,4\r\n";
        private static readonly string CSVVerificationContent = "1,2\n3,4\n";
        private static readonly string CSVScanRangeVerificationContent = "3,4\n";

        private const string SelectQuery = "select * from S3Object s where s.LOCATIONID = 'VALE'";

        private static string _bucketName;
        private static string _keyName;
        private static string _csvKeyName;

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            _bucketName = S3TestUtils.CreateBucketWithWait(Client);
            _keyName = UtilityMethods.GenerateName(nameof(SelectObjectContentTests) + "_json");
            _csvKeyName = UtilityMethods.GenerateName(nameof(SelectObjectContentTests) + "_csv");

            Client.PutObject(new PutObjectRequest()
            {
                BucketName = _bucketName,
                Key = _keyName,
                ContentBody = TestContent
            });

            Client.PutObject(new PutObjectRequest()
            {
                BucketName = _bucketName,
                Key = _csvKeyName,
                ContentBody = TestCSVContent
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

#if ASYNC_AWAIT
        /// <summary>
        /// Tests the Event-Driven method for iterating through an EventStream returned from SelectObjectContent. Technically, the enumerable test should suffice,
        /// but it may be useful to have a itegration test for each interaction pattern.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public async System.Threading.Tasks.Task TestCallEventsAsync()
        {
            var eventStream = GetSelectObjectContentEventStream();

            var testContent = "";
            var recordsEvents = new List<RecordsEvent>();

            eventStream.RecordsEventReceived += (sender, args) => recordsEvents.Add(args.EventStreamEvent);
            await eventStream.StartProcessingAsync();

            using (var streamReader = new StreamReader(recordsEvents[0].Payload))
            {
                testContent = streamReader.ReadToEnd();
            }
            eventStream.Dispose();

            AssertRecordsEqualsExpected(testContent);
        }
#endif

        /// <summary>
        /// Tests the Event-Driven method for checking an EventStream returned from SelectObjectContent based on RecordDelimiter settings for CSV InputSerialization and OutputSerialization.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestCallCSVInputOutputDelimiterEvents()
        {
            string selectQuery = "select * from s3object";
            InputSerialization inputSerialization = new InputSerialization()
            {
                CSV = new CSVInput()
                {
                    FileHeaderInfo = FileHeaderInfo.Use,
                    RecordDelimiter = "\r\n"
                }
            };
            OutputSerialization outputSerialization = new OutputSerialization()
            {
                CSV = new CSVOutput()
                {
                    RecordDelimiter = "\n"
                }
            };

            var eventStream = GetSelectObjectContentEventStream(_bucketName, _csvKeyName, selectQuery, inputSerialization, outputSerialization);

            var testContent = "";
            var recordsEvents = new List<RecordsEvent>();

            eventStream.RecordsEventReceived += (sender, args) => recordsEvents.Add(args.EventStreamEvent);
            eventStream.StartProcessing();
            SpinWait.SpinUntil(() => recordsEvents.Count > 0, TimeSpan.FromSeconds(5));

            using (var streamReader = new StreamReader(recordsEvents[0].Payload, Encoding.UTF8))
            {
                testContent = streamReader.ReadToEnd();
            }
            eventStream.Dispose();

            Assert.IsTrue(string.Equals(CSVVerificationContent, testContent));
        }

        /// <summary>
        /// Tests the Event-Driven method for checking an EventStream returned from SelectObjectContent based on ScanRange setting for CSV InputSerialization and OutputSerialization.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestCallScanRangeEvents()
        {
            string selectQuery = "select * from s3object";
            InputSerialization inputSerialization = new InputSerialization()
            {
                CSV = new CSVInput()
                {
                    FileHeaderInfo = FileHeaderInfo.Use,
                    RecordDelimiter = "\r\n"
                }
            };
            OutputSerialization outputSerialization = new OutputSerialization()
            {
                CSV = new CSVOutput()
                {
                    RecordDelimiter = "\n"
                }
            };

            var eventStream = GetSelectObjectContentEventStream(_bucketName, _csvKeyName, selectQuery, inputSerialization, outputSerialization, new ScanRange() { Start = 10, End = 20 });

            var testContent = string.Empty;
            var recordsEvents = new List<RecordsEvent>();

            eventStream.RecordsEventReceived += (sender, args) => recordsEvents.Add(args.EventStreamEvent);
            eventStream.StartProcessing();
            SpinWait.SpinUntil(() => recordsEvents.Count > 0, TimeSpan.FromSeconds(5));

            using (var streamReader = new StreamReader(recordsEvents[0].Payload, Encoding.UTF8))
            {
                testContent = streamReader.ReadToEnd();
            }
            eventStream.Dispose();

            Assert.IsTrue(string.Equals(CSVScanRangeVerificationContent, testContent));
        }

        private ISelectObjectContentEventStream GetSelectObjectContentEventStream(
            string bucketName, 
            string key, 
            string selectQuery, 
            InputSerialization inputSerialization, 
            OutputSerialization outputSerialization, 
            ScanRange scanRange = null)
        {
            if (string.IsNullOrWhiteSpace(bucketName)) throw new ArgumentNullException("bucketName");
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException("key");
            if (string.IsNullOrWhiteSpace(selectQuery)) throw new ArgumentNullException("selectQuery");
            if (inputSerialization == null) throw new ArgumentNullException("inputSerialization");
            if (outputSerialization == null) throw new ArgumentNullException("outputSerialization");

            SelectObjectContentRequest selectObjectContentRequest = new SelectObjectContentRequest()
            {
                BucketName = bucketName,
                Key = key,
                ExpressionType = ExpressionType.SQL,
                Expression = selectQuery,
                InputSerialization = inputSerialization,
                OutputSerialization = outputSerialization
            };

            if (scanRange != null) selectObjectContentRequest.ScanRange = scanRange;

            return Client.SelectObjectContent(selectObjectContentRequest).Payload;
        }

        private ISelectObjectContentEventStream GetSelectObjectContentEventStream()
        {
            return Client.SelectObjectContent(new SelectObjectContentRequest()
            {
                BucketName = _bucketName,
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