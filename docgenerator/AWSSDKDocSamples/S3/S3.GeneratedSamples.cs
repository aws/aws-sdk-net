using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.S3;
using Amazon.S3.Model;

namespace AWSSDKDocSamples.Amazon.S3.Generated
{
    class S3Samples : ISample
    {
        public void S3AbortMultipartUpload()
        {
            #region to-abort-a-multipart-upload-1481853354987

            var client = new AmazonS3Client();
            var response = client.AbortMultipartUpload(new AbortMultipartUploadRequest 
            {
                Key = "bigobject",
                UploadId = "xadcOB_7YPBOJuoFiQ9cz4P3Pe6FIZwO4f7wN93uHsNBEw97pl5eNwzExg0LAT2dUN91cOmrEQHDsP3WA60CEg--"
            });


            #endregion
        }

        public void S3CompleteMultipartUpload()
        {
            #region to-complete-multipart-upload-1481851590483

            var client = new AmazonS3Client();
            var response = client.CompleteMultipartUpload(new CompleteMultipartUploadRequest 
            {
                Key = "bigobject",
                UploadId = "7YPBOJuoFiQ9cz4P3Pe6FIZwO4f7wN93uHsNBEw97pl5eNwzExg0LAT2dUN91cOmrEQHDsP3WA60CEg--"
            });

            string eTag = response.ETag;
            string key = response.Key;
            string location = response.Location;

            #endregion
        }

        public void S3CopyObject()
        {
            #region to-copy-an-object-1481823186878

            var client = new AmazonS3Client();
            var response = client.CopyObject(new CopyObjectRequest 
            {
            });

            CopyObjectResult copyObjectResult = response.CopyObjectResult;

            #endregion
        }

        public void S3CopyPart()
        {
            #region to-upload-a-part-by-copying-byte-range-from-an-existing-object-as-data-source-1483048068594

            var client = new AmazonS3Client();
            var response = client.CopyPart(new CopyPartRequest 
            {
            });


            #endregion
        }

        public void S3CopyPart()
        {
            #region to-upload-a-part-by-copying-data-from-an-existing-object-as-data-source-1483046746348

            var client = new AmazonS3Client();
            var response = client.CopyPart(new CopyPartRequest 
            {
            });


            #endregion
        }

        public void S3DeleteBucket()
        {
            #region to-delete-a-bucket-1473108514262

            var client = new AmazonS3Client();
            var response = client.DeleteBucket(new DeleteBucketRequest 
            {
            });


            #endregion
        }

        public void S3DeleteBucketPolicy()
        {
            #region to-delete-bucket-policy-1483043406577

            var client = new AmazonS3Client();
            var response = client.DeleteBucketPolicy(new DeleteBucketPolicyRequest 
            {
            });


            #endregion
        }

        public void S3DeleteBucketReplication()
        {
            #region to-delete-bucket-replication-configuration-1483043684668

            var client = new AmazonS3Client();
            var response = client.DeleteBucketReplication(new DeleteBucketReplicationRequest 
            {
            });


            #endregion
        }

        public void S3DeleteBucketTagging()
        {
            #region to-delete-bucket-tags-1483043846509

            var client = new AmazonS3Client();
            var response = client.DeleteBucketTagging(new DeleteBucketTaggingRequest 
            {
            });


            #endregion
        }

        public void S3DeleteBucketWebsite()
        {
            #region to-delete-bucket-website-configuration-1483043937825

            var client = new AmazonS3Client();
            var response = client.DeleteBucketWebsite(new DeleteBucketWebsiteRequest 
            {
            });


            #endregion
        }

        public void S3DeleteCORSConfiguration()
        {
            #region to-delete-cors-configuration-on-a-bucket-1483042856112

            var client = new AmazonS3Client();
            var response = client.DeleteCORSConfiguration(new DeleteCORSConfigurationRequest 
            {
            });


            #endregion
        }

        public void S3DeleteLifecycleConfiguration()
        {
            #region to-delete-lifecycle-configuration-on-a-bucket-1483043310583

            var client = new AmazonS3Client();
            var response = client.DeleteLifecycleConfiguration(new DeleteLifecycleConfigurationRequest 
            {
            });


            #endregion
        }

        public void S3DeleteObject()
        {
            #region to-delete-an-object-1472850136595

            var client = new AmazonS3Client();
            var response = client.DeleteObject(new DeleteObjectRequest 
            {
                Key = "objectkey.jpg"
            });


            #endregion
        }

        public void S3DeleteObject()
        {
            #region to-delete-an-object-from-a-non-versioned-bucket-1481588533089

            var client = new AmazonS3Client();
            var response = client.DeleteObject(new DeleteObjectRequest 
            {
                Key = "HappyFace.jpg"
            });


            #endregion
        }

        public void S3DeleteObjects()
        {
            #region to-delete-multiple-object-versions-from-a-versioned-bucket-1483147087737

            var client = new AmazonS3Client();
            var response = client.DeleteObjects(new DeleteObjectsRequest 
            {
            });

            List<DeletedObject> deleted = response.Deleted;

            #endregion
        }

        public void S3DeleteObjects()
        {
            #region to-delete-multiple-objects-from-a-versioned-bucket-1483146248805

            var client = new AmazonS3Client();
            var response = client.DeleteObjects(new DeleteObjectsRequest 
            {
            });

            List<DeletedObject> deleted = response.Deleted;

            #endregion
        }

        public void S3DeleteObjectTagging()
        {
            #region to-remove-tag-set-from-an-object-1483145342862

            var client = new AmazonS3Client();
            var response = client.DeleteObjectTagging(new DeleteObjectTaggingRequest 
            {
                Key = "HappyFace.jpg"
            });

            string versionId = response.VersionId;

            #endregion
        }

        public void S3DeleteObjectTagging()
        {
            #region to-remove-tag-set-from-an-object-version-1483145285913

            var client = new AmazonS3Client();
            var response = client.DeleteObjectTagging(new DeleteObjectTaggingRequest 
            {
                Key = "HappyFace.jpg",
                VersionId = "ydlaNkwWm0SfKJR.T1b1fIdPRbldTYRI"
            });

            string versionId = response.VersionId;

            #endregion
        }

        public void S3GetBucketLocation()
        {
            #region to-get-bucket-location-1481594573609

            var client = new AmazonS3Client();
            var response = client.GetBucketLocation(new GetBucketLocationRequest 
            {
            });

            string locationConstraint = response.LocationConstraint;

            #endregion
        }

        public void S3GetBucketPolicy()
        {
            #region to-get-bucket-policy-1481595098424

            var client = new AmazonS3Client();
            var response = client.GetBucketPolicy(new GetBucketPolicyRequest 
            {
            });

            string policy = response.Policy;

            #endregion
        }

        public void S3GetBucketReplication()
        {
            #region to-get-replication-configuration-set-on-a-bucket-1481593597175

            var client = new AmazonS3Client();
            var response = client.GetBucketReplication(new GetBucketReplicationRequest 
            {
            });

            ReplicationConfiguration replicationConfiguration = response.ReplicationConfiguration;

            #endregion
        }

        public void S3GetBucketRequestPayment()
        {
            #region to-get-bucket-versioning-configuration-1483037183929

            var client = new AmazonS3Client();
            var response = client.GetBucketRequestPayment(new GetBucketRequestPaymentRequest 
            {
            });

            string payer = response.Payer;

            #endregion
        }

        public void S3GetBucketTagging()
        {
            #region to-get-tag-set-associated-with-a-bucket-1481593232107

            var client = new AmazonS3Client();
            var response = client.GetBucketTagging(new GetBucketTaggingRequest 
            {
            });

            List<Tag> tagSet = response.TagSet;

            #endregion
        }

        public void S3GetBucketVersioning()
        {
            #region to-get-bucket-versioning-configuration-1483037183929

            var client = new AmazonS3Client();
            var response = client.GetBucketVersioning(new GetBucketVersioningRequest 
            {
            });

            string mfaDelete = response.MFADelete;
            string status = response.Status;

            #endregion
        }

        public void S3GetBucketWebsite()
        {
            #region to-get-bucket-website-configuration-1483037016926

            var client = new AmazonS3Client();
            var response = client.GetBucketWebsite(new GetBucketWebsiteRequest 
            {
            });

            ErrorDocument errorDocument = response.ErrorDocument;
            IndexDocument indexDocument = response.IndexDocument;

            #endregion
        }

        public void S3GetCORSConfiguration()
        {
            #region to-get-cors-configuration-set-on-a-bucket-1481596855475

            var client = new AmazonS3Client();
            var response = client.GetCORSConfiguration(new GetCORSConfigurationRequest 
            {
            });


            #endregion
        }

        public void S3GetLifecycleConfiguration()
        {
            #region to-get-lifecycle-configuration-on-a-bucket-1481666063200

            var client = new AmazonS3Client();
            var response = client.GetLifecycleConfiguration(new GetLifecycleConfigurationRequest 
            {
            });


            #endregion
        }

        public void S3GetObject()
        {
            #region to-retrieve-an-object-1481827837012

            var client = new AmazonS3Client();
            var response = client.GetObject(new GetObjectRequest 
            {
                Key = "HappyFace.jpg"
            });

            string acceptRanges = response.AcceptRanges;
            long contentLength = response.ContentLength;
            string contentType = response.ContentType;
            string eTag = response.ETag;
            DateTime lastModified = response.LastModified;
            Dictionary<string, string> metadata = response.Metadata;
            int tagCount = response.TagCount;
            string versionId = response.VersionId;

            #endregion
        }

        public void S3GetObject()
        {
            #region to-retrieve-a-byte-range-of-an-object--1481832674603

            var client = new AmazonS3Client();
            var response = client.GetObject(new GetObjectRequest 
            {
                Key = "SampleFile.txt",
                Range = "bytes=0-9"
            });

            string acceptRanges = response.AcceptRanges;
            long contentLength = response.ContentLength;
            string contentRange = response.ContentRange;
            string contentType = response.ContentType;
            string eTag = response.ETag;
            DateTime lastModified = response.LastModified;
            Dictionary<string, string> metadata = response.Metadata;
            string versionId = response.VersionId;

            #endregion
        }

        public void S3GetObjectAcl()
        {
            #region to-retrieve-object-acl-1481833557740

            var client = new AmazonS3Client();
            var response = client.GetObjectAcl(new GetObjectAclRequest 
            {
                Key = "HappyFace.jpg"
            });

            List<Grant> grants = response.Grants;
            Owner owner = response.Owner;

            #endregion
        }

        public void S3GetObjectMetadata()
        {
            #region to-retrieve-metadata-of-an-object-without-returning-the-object-itself-1481834820480

            var client = new AmazonS3Client();
            var response = client.GetObjectMetadata(new GetObjectMetadataRequest 
            {
            });


            #endregion
        }

        public void S3GetObjectTagging()
        {
            #region to-retrieve-tag-set-of-a-specific-object-version-1483400283663

            var client = new AmazonS3Client();
            var response = client.GetObjectTagging(new GetObjectTaggingRequest 
            {
                Key = "exampleobject",
                VersionId = "ydlaNkwWm0SfKJR.T1b1fIdPRbldTYRI"
            });

            List<Tag> tagSet = response.TagSet;
            string versionId = response.VersionId;

            #endregion
        }

        public void S3GetObjectTagging()
        {
            #region to-retrieve-tag-set-of-an-object-1481833847896

            var client = new AmazonS3Client();
            var response = client.GetObjectTagging(new GetObjectTaggingRequest 
            {
                Key = "HappyFace.jpg"
            });

            List<Tag> tagSet = response.TagSet;
            string versionId = response.VersionId;

            #endregion
        }

        public void S3GetObjectTorrent()
        {
            #region to-retrieve-torrent-files-for-an-object-1481834115959

            var client = new AmazonS3Client();
            var response = client.GetObjectTorrent(new GetObjectTorrentRequest 
            {
                Key = "HappyFace.jpg"
            });


            #endregion
        }

        public void S3HeadBucket()
        {
            #region to-determine-if-bucket-exists-1473110292262

            var client = new AmazonS3Client();
            var response = client.HeadBucket(new HeadBucketRequest 
            {
            });


            #endregion
        }

        public void S3InitiateMultipartUpload()
        {
            #region to-initiate-a-multipart-upload-1481836794513

            var client = new AmazonS3Client();
            var response = client.InitiateMultipartUpload(new InitiateMultipartUploadRequest 
            {
            });


            #endregion
        }

        public void S3ListBuckets()
        {
            #region to-list-buckets-1481910996058

            var client = new AmazonS3Client();
            var response = client.ListBuckets(new ListBucketsRequest 
            {
            });

            List<Bucket> buckets = response.Buckets;
            Owner owner = response.Owner;

            #endregion
        }

        public void S3ListMultipartUploads()
        {
            #region to-list-in-progress-multipart-uploads-on-a-bucket-1481852775260

            var client = new AmazonS3Client();
            var response = client.ListMultipartUploads(new ListMultipartUploadsRequest 
            {
            });

            List<MultipartUpload> uploads = response.Uploads;

            #endregion
        }

        public void S3ListMultipartUploads()
        {
            #region list-next-set-of-multipart-uploads-when-previous-result-is-truncated-1482428106748

            var client = new AmazonS3Client();
            var response = client.ListMultipartUploads(new ListMultipartUploadsRequest 
            {
                KeyMarker = "nextkeyfrompreviousresponse",
                MaxUploads = 2,
                UploadIdMarker = "valuefrompreviousresponse"
            });

            bool isTruncated = response.IsTruncated;
            string keyMarker = response.KeyMarker;
            int maxUploads = response.MaxUploads;
            string nextKeyMarker = response.NextKeyMarker;
            string nextUploadIdMarker = response.NextUploadIdMarker;
            string uploadIdMarker = response.UploadIdMarker;
            List<MultipartUpload> uploads = response.Uploads;

            #endregion
        }

        public void S3ListObjects()
        {
            #region to-list-objects-in-a-bucket-1473447646507

            var client = new AmazonS3Client();
            var response = client.ListObjects(new ListObjectsRequest 
            {
                MaxKeys = 2
            });

            List<Object> contents = response.Contents;
            string nextMarker = response.NextMarker;

            #endregion
        }

        public void S3ListObjectsV2()
        {
            #region to-get-object-list

            var client = new AmazonS3Client();
            var response = client.ListObjectsV2(new ListObjectsV2Request 
            {
                MaxKeys = 2
            });

            List<Object> contents = response.Contents;
            bool isTruncated = response.IsTruncated;
            int keyCount = response.KeyCount;
            int maxKeys = response.MaxKeys;
            string name = response.Name;
            string nextContinuationToken = response.NextContinuationToken;
            string prefix = response.Prefix;

            #endregion
        }

        public void S3ListParts()
        {
            #region to-list-parts-of-a-multipart-upload-1481852006923

            var client = new AmazonS3Client();
            var response = client.ListParts(new ListPartsRequest 
            {
                Key = "bigobject",
                UploadId = "example7YPBOJuoFiQ9cz4P3Pe6FIZwO4f7wN93uHsNBEw97pl5eNwzExg0LAT2dUN91cOmrEQHDsP3WA60CEg--"
            });

            Initiator initiator = response.Initiator;
            Owner owner = response.Owner;
            List<Part> parts = response.Parts;
            string storageClass = response.StorageClass;

            #endregion
        }

        public void S3ListVersions()
        {
            #region to-list-object-versions-1481910996058

            var client = new AmazonS3Client();
            var response = client.ListVersions(new ListVersionsRequest 
            {
            });


            #endregion
        }

        public void S3PutBucket()
        {
            #region to-create-a-bucket--1472851826060

            var client = new AmazonS3Client();
            var response = client.PutBucket(new PutBucketRequest 
            {
            });


            #endregion
        }

        public void S3PutBucket()
        {
            #region to-create-a-bucket-in-a-specific-region-1483399072992

            var client = new AmazonS3Client();
            var response = client.PutBucket(new PutBucketRequest 
            {
            });


            #endregion
        }

        public void S3PutBucketAcl()
        {
            #region put-bucket-acl-1482260397033

            var client = new AmazonS3Client();
            var response = client.PutBucketAcl(new PutBucketAclRequest 
            {
                GrantFullControl = "id=examplee7a2f25102679df27bb0ae12b3f85be6f290b936c4393484",
                GrantWrite = "uri=http://acs.amazonaws.com/groups/s3/LogDelivery"
            });


            #endregion
        }

        public void S3PutBucketLogging()
        {
            #region set-logging-configuration-for-a-bucket-1482269119909

            var client = new AmazonS3Client();
            var response = client.PutBucketLogging(new PutBucketLoggingRequest 
            {
                BucketLoggingStatus = new BucketLoggingStatus { LoggingEnabled = new LoggingEnabled {
                    TargetBucket = "targetbucket",
                    TargetGrants = new List<TargetGrant> {
                        new TargetGrant {
                            Grantee = new Grantee {
                                Type = "Group",
                                URI = "http://acs.amazonaws.com/groups/global/AllUsers"
                            },
                            Permission = "READ"
                        }
                    },
                    TargetPrefix = "MyBucketLogs/"
                } }
            });


            #endregion
        }

        public void S3PutBucketNotification()
        {
            #region set-notification-configuration-for-a-bucket-1482270296426

            var client = new AmazonS3Client();
            var response = client.PutBucketNotification(new PutBucketNotificationRequest 
            {
            });


            #endregion
        }

        public void S3PutBucketPolicy()
        {
            #region set-bucket-policy-1482448903302

            var client = new AmazonS3Client();
            var response = client.PutBucketPolicy(new PutBucketPolicyRequest 
            {
                Policy = "{\"Version\": \"2012-10-17\", \"Statement\": [{ \"Sid\": \"id-1\",\"Effect\": \"Allow\",\"Principal\": {\"AWS\": \"arn:aws:iam::123456789012:root\"}, \"Action\": [ \"s3:PutObject\",\"s3:PutObjectAcl\"], \"Resource\": [\"arn:aws:s3:::acl3/*\" ] } ]}"
            });


            #endregion
        }

        public void S3PutBucketReplication()
        {
            #region id-1

            var client = new AmazonS3Client();
            var response = client.PutBucketReplication(new PutBucketReplicationRequest 
            {
                ReplicationConfiguration = new ReplicationConfiguration {
                    Role = "arn:aws:iam::123456789012:role/examplerole",
                    Rules = new List<ReplicationRule> {
                        new ReplicationRule {
                            Destination = new Destination {
                                StorageClass = "STANDARD"
                            },
                            Prefix = "",
                            Status = "Enabled"
                        }
                    }
                }
            });


            #endregion
        }

        public void S3PutBucketRequestPayment()
        {
            #region set-request-payment-configuration-on-a-bucket-1482343596680

            var client = new AmazonS3Client();
            var response = client.PutBucketRequestPayment(new PutBucketRequestPaymentRequest 
            {
                RequestPaymentConfiguration = new RequestPaymentConfiguration { Payer = "Requester" }
            });


            #endregion
        }

        public void S3PutBucketTagging()
        {
            #region set-tags-on-a-bucket-1482346269066

            var client = new AmazonS3Client();
            var response = client.PutBucketTagging(new PutBucketTaggingRequest 
            {
            });


            #endregion
        }

        public void S3PutBucketVersioning()
        {
            #region set-versioning-configuration-on-a-bucket-1482344186279

            var client = new AmazonS3Client();
            var response = client.PutBucketVersioning(new PutBucketVersioningRequest 
            {
            });


            #endregion
        }

        public void S3PutBucketWebsite()
        {
            #region set-website-configuration-on-a-bucket-1482346836261

            var client = new AmazonS3Client();
            var response = client.PutBucketWebsite(new PutBucketWebsiteRequest 
            {
                ContentMD5 = "",
                WebsiteConfiguration = new WebsiteConfiguration {
                    ErrorDocument = new ErrorDocument { Key = "error.html" },
                    IndexDocument = new IndexDocument { Suffix = "index.html" }
                }
            });


            #endregion
        }

        public void S3PutCORSConfiguration()
        {
            #region to-set-cors-configuration-on-a-bucket-1483037818805

            var client = new AmazonS3Client();
            var response = client.PutCORSConfiguration(new PutCORSConfigurationRequest 
            {
            });


            #endregion
        }

        public void S3PutLifecycleConfiguration()
        {
            #region put-bucket-lifecycle-1482264533092

            var client = new AmazonS3Client();
            var response = client.PutLifecycleConfiguration(new PutLifecycleConfigurationRequest 
            {
            });


            #endregion
        }

        public void S3PutObject()
        {
            #region to-upload-an-object-1481760101010

            var client = new AmazonS3Client();
            var response = client.PutObject(new PutObjectRequest 
            {
                Body = new MemoryStream(HappyFace.jpg),
                Key = "HappyFace.jpg"
            });

            string eTag = response.ETag;
            string versionId = response.VersionId;

            #endregion
        }

        public void S3PutObject()
        {
            #region to-upload-an-object-(specify-optional-headers)

            var client = new AmazonS3Client();
            var response = client.PutObject(new PutObjectRequest 
            {
                Body = new MemoryStream(HappyFace.jpg),
                Key = "HappyFace.jpg",
                ServerSideEncryption = "AES256",
                StorageClass = "STANDARD_IA"
            });

            string eTag = response.ETag;
            string serverSideEncryption = response.ServerSideEncryption;
            string versionId = response.VersionId;

            #endregion
        }

        public void S3PutObject()
        {
            #region to-create-an-object-1483147613675

            var client = new AmazonS3Client();
            var response = client.PutObject(new PutObjectRequest 
            {
                Body = new MemoryStream(filetoupload),
                Key = "objectkey"
            });

            string eTag = response.ETag;
            string versionId = response.VersionId;

            #endregion
        }

        public void S3PutObject()
        {
            #region to-upload-an-object-and-specify-optional-tags-1481762310955

            var client = new AmazonS3Client();
            var response = client.PutObject(new PutObjectRequest 
            {
                Body = new MemoryStream(c:\HappyFace.jpg),
                Key = "HappyFace.jpg",
                Tagging = "key1=value1&key2=value2"
            });

            string eTag = response.ETag;
            string versionId = response.VersionId;

            #endregion
        }

        public void S3PutObject()
        {
            #region to-upload-an-object-and-specify-server-side-encryption-and-object-tags-1483398331831

            var client = new AmazonS3Client();
            var response = client.PutObject(new PutObjectRequest 
            {
                Body = new MemoryStream(filetoupload),
                Key = "exampleobject",
                ServerSideEncryption = "AES256",
                Tagging = "key1=value1&key2=value2"
            });

            string eTag = response.ETag;
            string serverSideEncryption = response.ServerSideEncryption;
            string versionId = response.VersionId;

            #endregion
        }

        public void S3PutObject()
        {
            #region to-upload-object-and-specify-user-defined-metadata-1483396974757

            var client = new AmazonS3Client();
            var response = client.PutObject(new PutObjectRequest 
            {
                Body = new MemoryStream(filetoupload),
                Key = "exampleobject",
                Metadata = new Dictionary<string, string> {
                    { "metadata1", "value1" },
                    { "metadata2", "value2" }
                }
            });

            string eTag = response.ETag;
            string versionId = response.VersionId;

            #endregion
        }

        public void S3PutObject()
        {
            #region to-upload-an-object-and-specify-canned-acl-1483397779571

            var client = new AmazonS3Client();
            var response = client.PutObject(new PutObjectRequest 
            {
                ACL = "authenticated-read",
                Body = new MemoryStream(filetoupload),
                Key = "exampleobject"
            });

            string eTag = response.ETag;
            string versionId = response.VersionId;

            #endregion
        }

        public void S3PutObjectAcl()
        {
            #region to-grant-permissions-using-object-acl-1481835549285

            var client = new AmazonS3Client();
            var response = client.PutObjectAcl(new PutObjectAclRequest 
            {
                AccessControlPolicy = new S3AccessControlList {  },
                GrantFullControl = "emailaddress=user1@example.com,emailaddress=user2@example.com",
                GrantRead = "uri=http://acs.amazonaws.com/groups/global/AllUsers",
                Key = "HappyFace.jpg"
            });


            #endregion
        }

        public void S3PutObjectTagging()
        {
            #region to-add-tags-to-an-existing-object-1481764668793

            var client = new AmazonS3Client();
            var response = client.PutObjectTagging(new PutObjectTaggingRequest 
            {
                Key = "HappyFace.jpg",
                Tagging = new Tagging { TagSet = new List<Tag> {
                    new Tag {
                        Key = "Key3",
                        Value = "Value3"
                    },
                    new Tag {
                        Key = "Key4",
                        Value = "Value4"
                    }
                } }
            });

            string versionId = response.VersionId;

            #endregion
        }

        public void S3RestoreObject()
        {
            #region to-restore-an-archived-object-1483049329953

            var client = new AmazonS3Client();
            var response = client.RestoreObject(new RestoreObjectRequest 
            {
                Key = "archivedobjectkey",
            });


            #endregion
        }

        public void S3UploadPart()
        {
            #region to-upload-a-part-1481847914943

            var client = new AmazonS3Client();
            var response = client.UploadPart(new UploadPartRequest 
            {
                Body = new MemoryStream(fileToUpload),
                Key = "examplelargeobject",
                PartNumber = 1,
                UploadId = "xadcOB_7YPBOJuoFiQ9cz4P3Pe6FIZwO4f7wN93uHsNBEw97pl5eNwzExg0LAT2dUN91cOmrEQHDsP3WA60CEg--"
            });

            string eTag = response.ETag;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}