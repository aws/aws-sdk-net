using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using Amazon.Runtime;

namespace Amazon.S3.Util
{
    /// <summary>
    /// A helper class that represents a strongly typed S3 EventNotification item sent to SQS
    /// </summary>
    public class S3EventNotification 
    {


        /// <summary>
        /// Parse the JSON string into a S3EventNotification object.
        /// <para>
        /// The function will try its best to parse input JSON string as best as it can. 
        /// It will not fail even if the JSON string contains unknown properties.
        /// </para>
        /// <exception cref="Amazon.Runtime.AmazonClientException">For any parsing errors</exception>
        /// </summary>
        public static S3EventNotification ParseJson(string json) 
        {
            try
            {
                using var data = JsonDocument.Parse(json);

                var s3Event = new S3EventNotification { Records = new List<S3EventNotificationRecord>() };

                if (data.RootElement.TryGetProperty("Records", out var recordsElement) && recordsElement.ValueKind == JsonValueKind.Array)
                {
                    foreach (var jsonRecord in recordsElement.EnumerateArray())
                    {
                        var record = new S3EventNotificationRecord();

                        record.EventVersion = GetValueAsString(jsonRecord, "eventVersion");
                        record.EventSource = GetValueAsString(jsonRecord, "eventSource");
                        record.AwsRegion = GetValueAsString(jsonRecord, "awsRegion");

                        if (jsonRecord.TryGetProperty("eventTime", out var eventTimeElement) && eventTimeElement.ValueKind == JsonValueKind.String)
                        {
                            record.EventTime = DateTime.Parse(eventTimeElement.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
                        }
                        if (jsonRecord.TryGetProperty("eventName", out var eventNameElement) && eventNameElement.ValueKind == JsonValueKind.String)
                        {
                            string eventName = eventNameElement.GetString();
                            if (!eventName.StartsWith("s3:", StringComparison.OrdinalIgnoreCase))
                            {
                                eventName = "s3:" + eventName;
                            }
                            record.EventName = EventType.FindValue(eventName);
                        }

                        if (jsonRecord.TryGetProperty("userIdentity", out var jsonUserIdentity))
                        {
                            record.UserIdentity = new UserIdentityEntity();
                            record.UserIdentity.PrincipalId = GetValueAsString(jsonUserIdentity, "principalId");
                        }

                        if (jsonRecord.TryGetProperty("requestParameters", out var jsonRequestParameters))
                        {
                            record.RequestParameters = new RequestParametersEntity();
                            record.RequestParameters.SourceIPAddress = GetValueAsString(jsonRequestParameters, "sourceIPAddress");
                        }

                        if (jsonRecord.TryGetProperty("responseElements", out var jsonResponseElements))
                        {
                            record.ResponseElements = new ResponseElementsEntity();

                            record.ResponseElements.XAmzRequestId = GetValueAsString(jsonResponseElements, "x-amz-request-id");
                            record.ResponseElements.XAmzId2 = GetValueAsString(jsonResponseElements, "x-amz-id-2");
                        }

                        if (jsonRecord.TryGetProperty("s3", out var jsonS3))
                        {
                            record.S3 = new S3Entity();

                            record.S3.S3SchemaVersion = GetValueAsString(jsonS3, "s3SchemaVersion");
                            record.S3.ConfigurationId = GetValueAsString(jsonS3, "configurationId");

                            
                            if (jsonS3.TryGetProperty("bucket", out var jsonBucket))
                            {
                                record.S3.Bucket = new S3BucketEntity();

                                record.S3.Bucket.Name = GetValueAsString(jsonBucket, "name");
                                record.S3.Bucket.Arn = GetValueAsString(jsonBucket, "arn");


                                if (jsonBucket.TryGetProperty("ownerIdentity", out var jsonOwnerIdentity))
                                {
                                    record.S3.Bucket.OwnerIdentity = new UserIdentityEntity();
                                    record.S3.Bucket.OwnerIdentity.PrincipalId = GetValueAsString(jsonOwnerIdentity, "principalId");
                                }
                            }

                            if (jsonS3.TryGetProperty("object", out var jsonObject))
                            {
                                record.S3.Object = new S3ObjectEntity();

                                record.S3.Object.Key = GetValueAsString(jsonObject, "key");
                                record.S3.Object.Size = GetValueAsLong(jsonObject, "size");
                                record.S3.Object.ETag = GetValueAsString(jsonObject, "eTag");
                                record.S3.Object.VersionId = GetValueAsString(jsonObject, "versionId");
                                record.S3.Object.Sequencer = GetValueAsString(jsonObject, "sequencer");
                            }
                        }

                        if (jsonRecord.TryGetProperty("glacierEventData", out var jsonGlacier))
                        {
                            record.GlacierEventData = new S3GlacierEventDataEntity();

                            if(jsonGlacier.TryGetProperty("restoreEventData", out var jsonRestore))
                            {
                                record.GlacierEventData.RestoreEventData = new S3RestoreEventDataEntity();

                                record.GlacierEventData.RestoreEventData.LifecycleRestorationExpiryTime = GetValueAsDateTime(jsonRestore, "lifecycleRestorationExpiryTime").GetValueOrDefault();
                                record.GlacierEventData.RestoreEventData.LifecycleRestoreStorageClass = GetValueAsString(jsonRestore, "lifecycleRestoreStorageClass");
                            }
                        }

                        s3Event.Records.Add(record);
                    }
                }

                return s3Event;
            }
            catch(Exception e)
            {
                throw new AmazonClientException("Failed to parse json string: " + e.Message, e);
            }
        }

        /// <summary>
        /// Gets and sets the records for the S3 event notification
        /// </summary>
        public List<S3EventNotificationRecord> Records {get;set;}

        /// <summary>
        /// The class holds the user identity properties.
        /// </summary>
        public class UserIdentityEntity 
        {
            /// <summary>
            /// Gets and sets the PrincipalId property.
            /// </summary>
            public string PrincipalId { get; set; }
        }
    
        /// <summary>
        /// This class contains the identity information for an S3 bucket.
        /// </summary>
        public class S3BucketEntity 
        {
            /// <summary>
            /// Gets and sets the name of the bucket.
            /// </summary>
            public string Name {get; set;}

            /// <summary>
            /// Gets and sets the bucket owner id.
            /// </summary>
            public UserIdentityEntity OwnerIdentity {get; set;}

            /// <summary>
            /// Gets and sets the S3 bucket arn.
            /// </summary>
            public string Arn {get; set;}        
        }

        /// <summary>
        /// This class contains the information for an object in S3.
        /// </summary>
        public class S3ObjectEntity
        {
            /// <summary>
            /// Gets and sets the key for the object stored in S3.
            /// </summary>
            public string Key { get; set; }

            /// <summary>
            /// Gets and sets the size of the object in S3.
            /// </summary>
            public long Size { get; set; }

            /// <summary>
            /// Gets and sets the etag of the object. This can be used to determine if the object has changed.
            /// </summary>
            public string ETag { get; set; }

            /// <summary>
            /// Gets and sets the version id of the object in S3.
            /// </summary>
            public string VersionId { get; set; }

            /// <summary>
            /// Gets and sets the sequencer a string representation of a hexadecimal value used to determine event sequence, only used with PUTs and DELETEs.
            /// </summary>
            public string Sequencer { get; set; }
        }

        /// <summary>
        /// Gets and sets the meta information describing S3.
        /// </summary>
        public class S3Entity 
        {
            /// <summary>
            /// Gets and sets the ConfigurationId. This ID can be found in the bucket notification configuration.
            /// </summary>
            public string ConfigurationId {get;set;}

            /// <summary>
            /// Gets and sets the Bucket property.
            /// </summary>
            public S3BucketEntity Bucket {get;set;}

            /// <summary>
            /// Gets and sets the Object property.
            /// </summary>
            public S3ObjectEntity Object { get; set; }

            /// <summary>
            /// Gets and sets the S3SchemaVersion property.
            /// </summary>
            public string S3SchemaVersion { get; set; }
        }

        /// <summary>
        /// The class holds the request parameters
        /// </summary>
        public class RequestParametersEntity 
        {
            /// <summary>
            /// Gets and sets the SourceIPAddress. This is the ip address where the request came from.
            /// </summary>
            public string SourceIPAddress {get;set;}
        }
    
        /// <summary>
        /// This class holds the response elements.
        /// </summary>
        public class ResponseElementsEntity 
        {
            /// <summary>
            /// Gets and sets the XAmzId2 Property. This is the Amazon S3 host that processed the request.
            /// </summary>
            public string XAmzId2 {get;set;}

            /// <summary>
            /// Gets and sets the XAmzRequestId. This is the Amazon S3 generated request ID.
            /// </summary>
            public string XAmzRequestId {get;set;}
        }

        /// <summary>
        /// The class holds the glacier event data elements.
        /// </summary>
        public class S3GlacierEventDataEntity
        {
            /// <summary>
            /// Gets and sets the RestoreEventData property.  
            /// </summary>
            public S3RestoreEventDataEntity RestoreEventData { get; set; }
        }

        /// <summary>
        /// The class holds the restore event data elements.
        /// </summary>
        public class S3RestoreEventDataEntity
        {
            /// <summary>
            /// Gets and sets the LifecycleRestorationExpiryTime the time when the object restoration will be expired. 
            /// </summary>
            public DateTime LifecycleRestorationExpiryTime { get; set; }

            /// <summary>
            /// Gets and sets the LifecycleRestoreStorageClass the source storage class for restore.
            /// </summary>
            public string LifecycleRestoreStorageClass { get; set; }
        }

        /// <summary>
        /// The class holds the event notification.
        /// </summary>
        public class S3EventNotificationRecord 
        {        
            /// <summary>
            /// Gets and sets the AwsRegion property.  
            /// </summary>
            public string AwsRegion {get;set;}

            /// <summary>
            /// Gets and sets the EventName property. This identities what type of event occurred. 
            /// For example for an object just put in S3 this will be set to EventType.ObjectCreatedPut.
            /// </summary>
            public EventType EventName { get; set; }

            /// <summary>
            /// Gets and sets the EventSource property.
            /// </summary>
            public string EventSource {get;set;}

            /// <summary>
            /// Gets and sets the EventType property. The time when S3 finished processing the request.
            /// </summary>
            public DateTime EventTime {get;set;}

            /// <summary>
            /// Gets and sets the EventVersion property.
            /// </summary>
            public string EventVersion {get;set;}

            /// <summary>
            /// Gets and sets the RequestParameters property.
            /// </summary>
            public RequestParametersEntity RequestParameters { get; set; }

            /// <summary>
            /// Gets and sets the ResponseElements property.
            /// </summary>
            public ResponseElementsEntity ResponseElements { get; set; }

            /// <summary>
            /// Gets and sets the S3 property.
            /// </summary>
            public S3Entity S3 { get; set; }

            /// <summary>
            /// Gets and sets the UserIdentity property.
            /// </summary>
            public UserIdentityEntity UserIdentity { get; set; }

            /// <summary>
            /// Get and sets the GlacierEventData property.
            /// </summary>
            public S3GlacierEventDataEntity GlacierEventData { get; set; }
        }


        private static string GetValueAsString(JsonElement data, string key)
        {
            if (data.TryGetProperty(key, out var property) && property.ValueKind == JsonValueKind.String)
                return property.GetString();
            return null;
        }

        private static DateTime? GetValueAsDateTime(JsonElement data, string key)
        {
            var str = GetValueAsString(data, key);
            if (string.IsNullOrEmpty(str))
                return null;

            return DateTime.Parse(str, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
        }

        private static long GetValueAsLong(JsonElement data, string key)
        {
            if (data.TryGetProperty(key, out var property) &&
                property.ValueKind == JsonValueKind.Number && property.TryGetInt64(out long result))
            {
                return result;
            }
            return 0;
        }
    }
}