using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    [Trait("Category", "S3SelectObjectContent")]
    public class SelectObjectContentTests : IClassFixture<S3BucketFixture>, IAsyncLifetime
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

        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _keyName;
        private readonly string _csvKeyName;

        public SelectObjectContentTests(S3BucketFixture bucket)
        {
            _client = bucket.Client;
            _bucketName = bucket.BucketName;
            _keyName = UtilityMethods.GenerateName(nameof(SelectObjectContentTests) + "_json");
            _csvKeyName = UtilityMethods.GenerateName(nameof(SelectObjectContentTests) + "_csv");
        }

        public async ValueTask InitializeAsync()
        {
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = _keyName,
                ContentBody = TestContent
            });

            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = _csvKeyName,
                ContentBody = TestCSVContent
            });
        }

        public ValueTask DisposeAsync() => new ValueTask();

        /// <summary>
        /// Tests the Enumerable method for iterating through an EventStream returned from SelectObjectContent.
        /// </summary>
        [Fact]
        public async Task TestCallEnumerable()
        {
            var eventStream = await GetSelectObjectContentEventStream();
            var testContent = "";
            var eventTypes = new List<Type>();

            foreach (var ev in eventStream)
            {
                if (ev is RecordsEvent records)
                {
                    using (var reader = new StreamReader(records.Payload, Encoding.UTF8))
                    {
                        testContent = await reader.ReadToEndAsync();
                    }
                }
                eventTypes.Add(ev.GetType());
            }

            AssertRecordsEqualsExpected(testContent);
            Assert.True(new List<Type>()
            {
                typeof(RecordsEvent),
                typeof(StatsEvent),
                typeof(EndEvent)
            }.SequenceEqual(eventTypes));
        }

        /// <summary>
        /// Tests the Event-Driven method for iterating through an EventStream returned from SelectObjectContent.
        /// </summary>
        [Fact]
        public async Task TestCallEventsAsync()
        {
            var eventStream = await GetSelectObjectContentEventStream();
            var testContent = "";
            var recordsEvents = new List<RecordsEvent>();

            eventStream.RecordsEventReceived += (sender, args) => recordsEvents.Add(args.EventStreamEvent);
            await eventStream.StartProcessingAsync();

            using (var streamReader = new StreamReader(recordsEvents[0].Payload))
            {
                testContent = await streamReader.ReadToEndAsync();
            }
            eventStream.Dispose();

            AssertRecordsEqualsExpected(testContent);
        }

        /// <summary>
        /// Tests the Event-Driven method for checking an EventStream returned from SelectObjectContent based on RecordDelimiter settings.
        /// </summary>
        [Fact]
        public async Task TestCallCSVInputOutputDelimiterEvents()
        {
            string selectQuery = "select * from s3object";
            var inputSerialization = new InputSerialization
            {
                CSV = new CSVInput()
                {
                    FileHeaderInfo = FileHeaderInfo.Use,
                    RecordDelimiter = "\r\n"
                }
            };
            var outputSerialization = new OutputSerialization
            {
                CSV = new CSVOutput
                {
                    RecordDelimiter = "\n"
                }
            };

            var eventStream = await GetSelectObjectContentEventStream(_bucketName, _csvKeyName, selectQuery, inputSerialization, outputSerialization);
            var testContent = "";
            var recordsEvents = new List<RecordsEvent>();

            eventStream.RecordsEventReceived += (sender, args) => recordsEvents.Add(args.EventStreamEvent);
            eventStream.StartProcessing();
            SpinWait.SpinUntil(() => recordsEvents.Count > 0, TimeSpan.FromSeconds(5));

            using (var streamReader = new StreamReader(recordsEvents[0].Payload, Encoding.UTF8))
            {
                testContent = await streamReader.ReadToEndAsync();
            }
            eventStream.Dispose();

            Assert.True(string.Equals(CSVVerificationContent, testContent));
        }

        /// <summary>
        /// Tests the Event-Driven method for checking an EventStream returned from SelectObjectContent based on ScanRange setting.
        /// </summary>
        [Fact]
        public async Task TestCallScanRangeEvents()
        {
            string selectQuery = "select * from s3object";
            var inputSerialization = new InputSerialization
            {
                CSV = new CSVInput
                {
                    FileHeaderInfo = FileHeaderInfo.Use,
                    RecordDelimiter = "\r\n"
                }
            };
            var outputSerialization = new OutputSerialization
            {
                CSV = new CSVOutput
                {
                    RecordDelimiter = "\n"
                }
            };

            var eventStream = await GetSelectObjectContentEventStream(_bucketName, _csvKeyName, selectQuery, inputSerialization, outputSerialization, new ScanRange() { Start = 10, End = 20 });
            var testContent = string.Empty;
            var recordsEvents = new List<RecordsEvent>();

            eventStream.RecordsEventReceived += (sender, args) => recordsEvents.Add(args.EventStreamEvent);
            eventStream.StartProcessing();
            SpinWait.SpinUntil(() => recordsEvents.Count > 0, TimeSpan.FromSeconds(5));

            using (var streamReader = new StreamReader(recordsEvents[0].Payload, Encoding.UTF8))
            {
                testContent = await streamReader.ReadToEndAsync();
            }
            eventStream.Dispose();

            Assert.True(string.Equals(CSVScanRangeVerificationContent, testContent));
        }

        private async Task<ISelectObjectContentEventStream> GetSelectObjectContentEventStream(
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

            var selectObjectContentRequest = new SelectObjectContentRequest
            {
                BucketName = bucketName,
                Key = key,
                ExpressionType = ExpressionType.SQL,
                Expression = selectQuery,
                InputSerialization = inputSerialization,
                OutputSerialization = outputSerialization
            };

            if (scanRange != null)
            {
                selectObjectContentRequest.ScanRange = scanRange;
            }

            return (await _client.SelectObjectContentAsync(selectObjectContentRequest)).Payload;
        }

        private async Task<ISelectObjectContentEventStream> GetSelectObjectContentEventStream()
        {
            return (await _client.SelectObjectContentAsync(new SelectObjectContentRequest
            {
                BucketName = _bucketName,
                Key = _keyName,
                ExpressionType = ExpressionType.SQL,
                Expression = SelectQuery,
                InputSerialization = new InputSerialization
                {
                    JSON = new JSONInput
                    {
                        JsonType = JsonType.Lines
                    }
                },
                OutputSerialization = new OutputSerialization
                {
                    JSON = new JSONOutput()
                }
            })).Payload;
        }

        private void AssertRecordsEqualsExpected(string records)
        {
            Assert.True(string.Compare(VerificationContent, records, CultureInfo.CurrentCulture,
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
    }
}
