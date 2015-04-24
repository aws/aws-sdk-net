using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using Amazon.Runtime;

using ThirdParty.Json.LitJson;


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
                var data = JsonMapper.ToObject(json);
                var s3Event = new S3EventNotification { Records = new List<S3EventNotificationRecord>() };

                if (data["Records"] != null)
                {
                    foreach (JsonData jsonRecord in data["Records"])
                    {
                        var record = new S3EventNotificationRecord();

                        record.EventVersion = GetValueAsString(jsonRecord, "eventVersion");
                        record.EventSource = GetValueAsString(jsonRecord, "eventSource");
                        record.AwsRegion = GetValueAsString(jsonRecord, "awsRegion");
                        record.EventVersion = GetValueAsString(jsonRecord, "eventVersion");

                        if (jsonRecord["eventTime"] != null)
                            record.EventTime = DateTime.Parse((string)jsonRecord["eventTime"], CultureInfo.InvariantCulture);
                        if (jsonRecord["eventName"] != null)
                        {
                            var eventName = (string)jsonRecord["eventName"];
                            if (!eventName.StartsWith("s3:", StringComparison.OrdinalIgnoreCase))
                                eventName = "s3:" + eventName;

                            record.EventName = EventType.FindValue(eventName);
                        }

                        if (jsonRecord["userIdentity"] != null)
                        {
                            var jsonUserIdentity = jsonRecord["userIdentity"];
                            record.UserIdentity = new UserIdentityEntity();
                            record.UserIdentity.PrincipalId = GetValueAsString(jsonUserIdentity, "principalId");
                        }

                        if (jsonRecord["requestParameters"] != null)
                        {
                            var jsonRequestParameters = jsonRecord["requestParameters"];
                            record.RequestParameters = new RequestParametersEntity();
                            record.RequestParameters.SourceIPAddress = GetValueAsString(jsonRequestParameters, "sourceIPAddress");
                        }

                        if (jsonRecord["responseElements"] != null)
                        {
                            var jsonResponseElements = jsonRecord["responseElements"];
                            record.ResponseElements = new ResponseElementsEntity();

                            record.ResponseElements.XAmzRequestId = GetValueAsString(jsonResponseElements, "x-amz-request-id");
                            record.ResponseElements.XAmzId2 = GetValueAsString(jsonResponseElements, "x-amz-id-2");
                        }

                        if (jsonRecord["s3"] != null)
                        {
                            var jsonS3 = jsonRecord["s3"];
                            record.S3 = new S3Entity();

                            record.S3.S3SchemaVersion = GetValueAsString(jsonS3, "s3SchemaVersion");
                            record.S3.ConfigurationId = GetValueAsString(jsonS3, "configurationId");

                            if (jsonS3["bucket"] != null)
                            {
                                var jsonBucket = jsonS3["bucket"];
                                record.S3.Bucket = new S3BucketEntity();

                                record.S3.Bucket.Name = GetValueAsString(jsonBucket, "name");
                                record.S3.Bucket.Arn = GetValueAsString(jsonBucket, "arn");


                                if (jsonBucket["ownerIdentity"] != null)
                                {
                                    var jsonOwnerIdentity = jsonBucket["ownerIdentity"];
                                    record.S3.Bucket.OwnerIdentity = new UserIdentityEntity();
                                    record.S3.Bucket.OwnerIdentity.PrincipalId = GetValueAsString(jsonOwnerIdentity, "principalId");
                                }
                            }

                            if (jsonS3["object"] != null)
                            {
                                var jsonObject = jsonS3["object"];
                                record.S3.Object = new S3ObjectEntity();

                                record.S3.Object.Key = GetValueAsString(jsonObject, "key");
                                record.S3.Object.Size = GetValueAsLong(jsonObject, "size");
                                record.S3.Object.ETag = GetValueAsString(jsonObject, "eTag");
                                record.S3.Object.VersionId = GetValueAsString(jsonObject, "versionId");
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
            public string Key {get; set;}

            /// <summary>
            /// Gets and sets the size of the object in S3.
            /// </summary>
            public long Size {get;set;}

            /// <summary>
            /// Gets and sets the etag of the object. This can be used to determine if the object has changed.
            /// </summary>
            public string ETag {get;set;}

            /// <summary>
            /// Gets and sets the version id of the object in S3.
            /// </summary>
            public string VersionId {get;set;}
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
        }

        private static string GetValueAsString(JsonData data, string key)
        {
            if (data[key] != null)
                return (string)data[key];
            return null;
        }

        private static long GetValueAsLong(JsonData data, string key)
        {
            if (data[key] != null)
            {
                if (data[key].IsInt)
                    return (int)data[key];
                else
                    return (long)data[key];
            }
            return 0;
        }
    }
}