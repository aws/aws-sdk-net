using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.S3;
using Amazon.S3.Util;
using System.Globalization;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class S3EventNotificationTests
    {
        public const string SAMPLE_EVENT_JSON = 
"{  " +
"   \"Records\":[  " +
"      {  " +
"         \"eventVersion\":\"2.0\"," +
"         \"eventSource\":\"aws:s3\"," +
"         \"awsRegion\":\"us-east-1\"," +
"         \"eventTime\":\"1970-01-01T00:00:00.000Z\"," +
"         \"eventName\":\"ObjectCreated:Put\"," +
"         \"userIdentity\":{  " +
"            \"principalId\":\"AIDAJDPLRKLG7UEXAMPLE\"" +
"         }," +
"         \"requestParameters\":{  " +
"            \"sourceIPAddress\":\"127.0.0.1\"" +
"         }," +
"         \"responseElements\":{  " +
"            \"x-amz-request-id\":\"C3D13FE58DE4C810\"," +
"            \"x-amz-id-2\":\"FMyUVURIY8/IgAtTv8xRjskZQpcIZ9KG4V5Wp6S7S/JRWeUWerMUE5JgHvANOjpD\"" +
"         }," +
"         \"s3\":{  " +
"            \"s3SchemaVersion\":\"1.0\"," +
"            \"configurationId\":\"testConfigRule\"," +
"            \"bucket\":{  " +
"               \"name\":\"mybucket\"," +
"               \"ownerIdentity\":{  " +
"                  \"principalId\":\"A3NL1KOZZKExample\"" +
"               }," +
"               \"arn\":\"arn:aws:s3:::mybucket\"" +
"            }," +
"            \"object\":{  " +
"               \"key\":\"HappyFace.jpg\"," +
"               \"size\":1024," +
"               \"eTag\":\"d41d8cd98f00b204e9800998ecf8427e\"," +
"               \"versionId\":\"096fKKXTRTtl3on89fVO.nfljtsv6qko\"," +
"               \"sequencer\":\"1234567890\"" +
"            }" +
"         }," +
"         \"glacierEventData\":{" +
"           \"restoreEventData\":{" +
"               \"lifecycleRestorationExpiryTime\":\"1970-01-01T00:00:00.000Z\"," +
"               \"lifecycleRestoreStorageClass\":\"Standard\"" +
"            }" +
"         }" +
"      }" +
"   ]" +
"}";

        [TestMethod]
        [TestCategory("S3")]
        public void ParseS3EventTest()
        {
            var eventRecords = S3EventNotification.ParseJson(SAMPLE_EVENT_JSON);

            Assert.AreEqual(1, eventRecords.Records.Count);

            var record = eventRecords.Records[0];
            Assert.AreEqual("2.0", record.EventVersion);
            Assert.AreEqual("aws:s3", record.EventSource);
            Assert.AreEqual("us-east-1", record.AwsRegion);
            Assert.AreEqual(1970, record.EventTime.ToUniversalTime().Year);
            Assert.AreEqual(EventType.ObjectCreatedPut, record.EventName);

            Assert.AreEqual("AIDAJDPLRKLG7UEXAMPLE", record.UserIdentity.PrincipalId);

            Assert.AreEqual("127.0.0.1", record.RequestParameters.SourceIPAddress);

            Assert.AreEqual("C3D13FE58DE4C810", record.ResponseElements.XAmzRequestId);
            Assert.AreEqual("FMyUVURIY8/IgAtTv8xRjskZQpcIZ9KG4V5Wp6S7S/JRWeUWerMUE5JgHvANOjpD", record.ResponseElements.XAmzId2);

            Assert.AreEqual("1.0", record.S3.S3SchemaVersion);
            Assert.AreEqual("testConfigRule", record.S3.ConfigurationId);
            Assert.AreEqual("mybucket", record.S3.Bucket.Name);
            Assert.AreEqual("A3NL1KOZZKExample", record.S3.Bucket.OwnerIdentity.PrincipalId);
            Assert.AreEqual("arn:aws:s3:::mybucket", record.S3.Bucket.Arn);

            Assert.AreEqual("HappyFace.jpg", record.S3.Object.Key);
            Assert.AreEqual(1024, record.S3.Object.Size);
            Assert.AreEqual("d41d8cd98f00b204e9800998ecf8427e", record.S3.Object.ETag);
            Assert.AreEqual("096fKKXTRTtl3on89fVO.nfljtsv6qko", record.S3.Object.VersionId);
            Assert.AreEqual("1234567890", record.S3.Object.Sequencer);

            Assert.AreEqual(DateTime.Parse("1970-01-01T00:00:00.000Z", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal), record.GlacierEventData.RestoreEventData.LifecycleRestorationExpiryTime);
            Assert.AreEqual("Standard", record.GlacierEventData.RestoreEventData.LifecycleRestoreStorageClass);
        }

        [TestMethod]
        public void ParseS3EventInvalidJson()
        {
            Assert.ThrowsExactly<Amazon.Runtime.AmazonClientException>(() => S3EventNotification.ParseJson("{"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ToJsonRoundTripTest()
        {
            var original = S3EventNotification.ParseJson(SAMPLE_EVENT_JSON);
            var roundTripped = S3EventNotification.ParseJson(original.ToJson());
            Assert.AreEqual(original.Records.Count, roundTripped.Records.Count);

            var expected = original.Records[0];
            var actual = roundTripped.Records[0];
            Assert.AreEqual(expected.EventVersion, actual.EventVersion);
            Assert.AreEqual(expected.EventSource, actual.EventSource);
            Assert.AreEqual(expected.AwsRegion, actual.AwsRegion);
            Assert.AreEqual(expected.EventTime, actual.EventTime);
            Assert.AreEqual(expected.EventName, actual.EventName);
            Assert.AreEqual(expected.UserIdentity.PrincipalId, actual.UserIdentity.PrincipalId);
            Assert.AreEqual(expected.RequestParameters.SourceIPAddress, actual.RequestParameters.SourceIPAddress);
            Assert.AreEqual(expected.ResponseElements.XAmzRequestId, actual.ResponseElements.XAmzRequestId);
            Assert.AreEqual(expected.ResponseElements.XAmzId2, actual.ResponseElements.XAmzId2);
            Assert.AreEqual(expected.S3.S3SchemaVersion, actual.S3.S3SchemaVersion);
            Assert.AreEqual(expected.S3.ConfigurationId, actual.S3.ConfigurationId);
            Assert.AreEqual(expected.S3.Bucket.Name, actual.S3.Bucket.Name);
            Assert.AreEqual(expected.S3.Bucket.OwnerIdentity.PrincipalId, actual.S3.Bucket.OwnerIdentity.PrincipalId);
            Assert.AreEqual(expected.S3.Bucket.Arn, actual.S3.Bucket.Arn);
            Assert.AreEqual(expected.S3.Object.Key, actual.S3.Object.Key);
            Assert.AreEqual(expected.S3.Object.Size, actual.S3.Object.Size);
            Assert.AreEqual(expected.S3.Object.ETag, actual.S3.Object.ETag);
            Assert.AreEqual(expected.S3.Object.VersionId, actual.S3.Object.VersionId);
            Assert.AreEqual(expected.S3.Object.Sequencer, actual.S3.Object.Sequencer);
            Assert.AreEqual(expected.GlacierEventData.RestoreEventData.LifecycleRestorationExpiryTime, actual.GlacierEventData.RestoreEventData.LifecycleRestorationExpiryTime);
            Assert.AreEqual(expected.GlacierEventData.RestoreEventData.LifecycleRestoreStorageClass, actual.GlacierEventData.RestoreEventData.LifecycleRestoreStorageClass);
        }
    }
}
