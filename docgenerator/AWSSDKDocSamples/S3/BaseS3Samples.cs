using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.S3;
using Amazon.S3.Model;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace AWSSDKDocSamples.S3
{
    public class BaseS3Samples : ISample
    {
        public void BucketSamples()
        {
            {
                #region ListBuckets Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Issue call
                ListBucketsResponse response = client.ListBuckets();

                // View response data
                Console.WriteLine("Buckets owner - {0}", response.Owner.DisplayName);
                foreach (S3Bucket bucket in response.Buckets)
                {
                    Console.WriteLine("Bucket {0}, Created on {1}", bucket.BucketName, bucket.CreationDate);
                }

                #endregion
            }

            {
                #region BucketPolicy Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Put sample bucket policy (overwrite an existing policy)
                string newPolicy = @"{ 
    ""Statement"":[{ 
    ""Sid"":""BasicPerms"", 
    ""Effect"":""Allow"", 
    ""Principal"": ""*"", 
    ""Action"":[""s3:PutObject"",""s3:GetObject""], 
    ""Resource"":[""arn:aws:s3:::samplebucketname/*""] 
}]}";
                PutBucketPolicyRequest putRequest = new PutBucketPolicyRequest
                {
                    BucketName = "SampleBucket",
                    Policy = newPolicy
                };
                client.PutBucketPolicy(putRequest);


                // Retrieve current policy
                GetBucketPolicyRequest getRequest = new GetBucketPolicyRequest
                {
                    BucketName = "SampleBucket"
                };
                string policy = client.GetBucketPolicy(getRequest).Policy;

                Console.WriteLine(policy);
                Debug.Assert(policy.Contains("BasicPerms"));


                // Delete current policy
                DeleteBucketPolicyRequest deleteRequest = new DeleteBucketPolicyRequest
                {
                    BucketName = "SampleBucket"
                };
                client.DeleteBucketPolicy(deleteRequest);


                // Retrieve current policy and verify that it is null
                policy = client.GetBucketPolicy(getRequest).Policy;
                Debug.Assert(policy == null);

                #endregion
            }

            {
                #region GetBucketLocation Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Construct request
                GetBucketLocationRequest request = new GetBucketLocationRequest
                {
                    BucketName = "SampleBucket"
                };

                // Issue call
                GetBucketLocationResponse response = client.GetBucketLocation(request);

                // View response data
                Console.WriteLine("Bucket location - {0}", response.Location);

                #endregion
            }

            {
                #region PutBucket Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Construct request
                PutBucketRequest request = new PutBucketRequest
                {
                    BucketName = "SampleBucket",
                    BucketRegion = S3Region.EU,         // set region to EU
                    CannedACL = S3CannedACL.PublicRead  // make bucket publicly readable
                };

                // Issue call
                PutBucketResponse response = client.PutBucket(request);

                #endregion
            }

            {
                #region DeleteBucket Sample 1

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Construct request
                DeleteBucketRequest request = new DeleteBucketRequest
                {
                    BucketName = "SampleBucket"
                };

                // Issue call
                DeleteBucketResponse response = client.DeleteBucket(request);

                #endregion
            }

            {
                #region DeleteBucket Sample 2

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // List and delete all objects
                ListObjectsRequest listRequest = new ListObjectsRequest
                {
                    BucketName = "SampleBucket"
                };

                ListObjectsResponse listResponse;
                do
                {
                    // Get a list of objects
                    listResponse = client.ListObjects(listRequest);
                    foreach (S3Object obj in listResponse.S3Objects)
                    {
                        // Delete each object
                        client.DeleteObject(new DeleteObjectRequest
                        {
                            BucketName = "SampleBucket",
                            Key = obj.Key
                        });
                    }

                    // Set the marker property
                    listRequest.Marker = listResponse.NextMarker;
                } while (listResponse.IsTruncated);

                // Construct DeleteBucket request
                DeleteBucketRequest request = new DeleteBucketRequest
                {
                    BucketName = "SampleBucket"
                };

                // Issue call
                DeleteBucketResponse response = client.DeleteBucket(request);

                #endregion
            }

            {
                #region LifecycleConfiguration Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();


                // Put sample lifecycle configuration (overwrite an existing configuration)
                LifecycleConfiguration newConfiguration = new LifecycleConfiguration
                {
                    Rules = new List<LifecycleRule>
                    {
                        // Rule to delete keys with prefix "Test-" after 5 days
                        new LifecycleRule
                        {
                            Prefix = "Test-",
                            Expiration = new LifecycleRuleExpiration { Days = 5 }
                        },
                        // Rule to delete keys in subdirectory "Logs" after 2 days
                        new LifecycleRule
                        {
                            Prefix = "Logs/",
                            Expiration = new LifecycleRuleExpiration  { Days = 2 },
                            Id = "log-file-removal"
                        }
                    }
                };
                PutLifecycleConfigurationRequest putRequest = new PutLifecycleConfigurationRequest
                {
                    BucketName = "SampleBucket",
                    Configuration = newConfiguration
                };
                client.PutLifecycleConfiguration(putRequest);


                // Retrieve current configuration
                GetLifecycleConfigurationRequest getRequest = new GetLifecycleConfigurationRequest
                {
                    BucketName = "SampleBucket"
                };
                LifecycleConfiguration configuration = client.GetLifecycleConfiguration(getRequest).Configuration;

                Console.WriteLine("Configuration contains {0} rules", configuration.Rules.Count);
                foreach (LifecycleRule rule in configuration.Rules)
                {
                    Console.WriteLine("Rule");
                    Console.WriteLine(" Prefix = " + rule.Prefix);
                    Console.WriteLine(" Expiration (days) = " + rule.Expiration.Days);
                    Console.WriteLine(" Id = " + rule.Id);
                    Console.WriteLine(" Status = " + rule.Status);
                }


                // Put a new configuration and overwrite the existing configuration
                configuration.Rules.RemoveAt(0);    // remove first rule
                client.PutLifecycleConfiguration(putRequest);

                // Delete current configuration
                DeleteLifecycleConfigurationRequest deleteRequest = new DeleteLifecycleConfigurationRequest
                {
                    BucketName = "SampleBucket"
                };
                client.DeleteLifecycleConfiguration(deleteRequest);


                // Retrieve current configuration and verify that it is null
                configuration = client.GetLifecycleConfiguration(getRequest).Configuration;
                Debug.Assert(configuration == null);

                #endregion
            }
        }

        public void ObjectSamples()
        {
            {
                #region ListObjects Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // List all objects
                ListObjectsRequest listRequest = new ListObjectsRequest
                {
                    BucketName = "SampleBucket",
                };

                ListObjectsResponse listResponse;
                do
                {
                    // Get a list of objects
                    listResponse = client.ListObjects(listRequest);
                    foreach (S3Object obj in listResponse.S3Objects)
                    {
                        Console.WriteLine("Object - " + obj.Key);
                        Console.WriteLine(" Size - " + obj.Size);
                        Console.WriteLine(" LastModified - " + obj.LastModified);
                        Console.WriteLine(" Storage class - " + obj.StorageClass);
                    }

                    // Set the marker property
                    listRequest.Marker = listResponse.NextMarker;
                } while (listResponse.IsTruncated);

                #endregion
            }

            {
                #region GetObject Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a GetObject request
                GetObjectRequest request = new GetObjectRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1"
                };

                // Issue request and remember to dispose of the response
                using (GetObjectResponse response = client.GetObject(request))
                {
                    using (StreamReader reader = new StreamReader(response.ResponseStream))
                    {
                        string contents = reader.ReadToEnd();
                        Console.WriteLine("Object - " + response.Key);
                        Console.WriteLine(" Version Id - " + response.VersionId);
                        Console.WriteLine(" Contents - " + contents);
                    }
                }

                #endregion
            }

            {
                #region GetObjectMetadata Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();


                // Create a GetObjectMetadata request
                GetObjectMetadataRequest request = new GetObjectMetadataRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1"
                };

                // Issue request and view the response
                GetObjectMetadataResponse response = client.GetObjectMetadata(request);
                Console.WriteLine("Content Length - " + response.ContentLength);
                Console.WriteLine("Content Type - " + response.Headers.ContentType);
                if (response.Expiration != null)
                {
                    Console.WriteLine("Expiration Date - " + response.Expiration.ExpiryDate);
                    Console.WriteLine("Expiration Rule Id - " + response.Expiration.RuleId);
                }

                #endregion
            }

            {
                #region PutObject Sample 1

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a PutObject request
                PutObjectRequest request = new PutObjectRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    ContentBody = "This is sample content..."
                };

                // Put object
                PutObjectResponse response = client.PutObject(request);

                #endregion
            }

            {
                #region PutObject Sample 2

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a PutObject request
                PutObjectRequest request = new PutObjectRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    FilePath = "contents.txt"
                };

                // Put object
                PutObjectResponse response = client.PutObject(request);

                #endregion
            }

            {
                #region PutObject Sample 3

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a PutObject request
                PutObjectRequest request = new PutObjectRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                };
                using (FileStream stream = new FileStream("contents.txt", FileMode.Open))
                {
                    request.InputStream = stream;

                    // Put object
                    PutObjectResponse response = client.PutObject(request);
                }

                #endregion
            }

            {
                #region DeleteObject Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a DeleteObject request
                DeleteObjectRequest request = new DeleteObjectRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1"
                };

                // Issue request
                client.DeleteObject(request);

                #endregion
            }

            {
                #region DeleteObjects Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a DeleteObject request
                DeleteObjectsRequest request = new DeleteObjectsRequest
                {
                    BucketName = "SampleBucket",
                    Objects = new List<KeyVersion>
                    {
                        new KeyVersion() {Key = "Item1"},
                        // Versioned item
                        new KeyVersion() { Key = "Item2", VersionId = "Rej8CiBxcZKVK81cLr39j27Y5FVXghDK", },
                        // Item in subdirectory
                        new KeyVersion() { Key = "Logs/error.txt"}
                    }
                };

                try
                {
                    // Issue request
                    DeleteObjectsResponse response = client.DeleteObjects(request);
                }
                catch (DeleteObjectsException doe)
                {
                    // Catch error and list error details
                    DeleteObjectsResponse errorResponse = doe.Response;

                    foreach (DeletedObject deletedObject in errorResponse.DeletedObjects)
                    {
                        Console.WriteLine("Deleted item " + deletedObject.Key);
                    }
                    foreach (DeleteError deleteError in errorResponse.DeleteErrors)
                    {
                        Console.WriteLine("Error deleting item " + deleteError.Key);
                        Console.WriteLine(" Code - " + deleteError.Code);
                        Console.WriteLine(" Message - " + deleteError.Message);
                    }
                }

                #endregion
            }

            {
                #region CopyObject Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                CopyObjectRequest request = new CopyObjectRequest
                {
                    SourceBucket = "SampleBucket",
                    SourceKey = "Item1",
                    DestinationBucket = "AnotherBucket",
                    DestinationKey = "Copy1",
                    CannedACL = S3CannedACL.PublicRead
                };

                // Issue request
                client.CopyObject(request);

                #endregion
            }

            {
                #region CopyObject Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                CopyObjectRequest request = new CopyObjectRequest
                {
                    SourceBucket = "SampleBucket",
                    SourceKey = "Item1",
                    DestinationBucket = "AnotherBucket",
                    DestinationKey = "Copy1",
                    CannedACL = S3CannedACL.PublicRead
                };

                // Issue request
                client.CopyObject(request);

                #endregion
            }

            {
                #region ListVersions Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Turn versioning on for a bucket
                client.PutBucketVersioning(new PutBucketVersioningRequest
                {
                    BucketName = "SampleBucket",
                    VersioningConfig = new S3BucketVersioningConfig { Status = "Enable" }
                });

                // Populate bucket with multiple items, each with multiple versions
                PopulateBucket(client, "SampleBucket");

                // Get versions
                ListVersionsRequest request = new ListVersionsRequest
                {
                    BucketName = "SampleBucket"
                };

                // Make paged ListVersions calls
                ListVersionsResponse response;
                do
                {
                    response = client.ListVersions(request);
                    // View information about versions
                    foreach (var version in response.Versions)
                    {
                        Console.WriteLine("Key = {0}, Version = {1}, IsLatest = {2}, LastModified = {3}, Size = {4}",
                            version.Key,
                            version.VersionId,
                            version.IsLatest,
                            version.LastModified,
                            version.Size);
                    }

                    request.KeyMarker = response.NextKeyMarker;
                    request.VersionIdMarker = response.NextVersionIdMarker;
                } while (response.IsTruncated);

                #endregion
            }

            {
                #region Multipart Upload Sample

                int MB = (int)Math.Pow(2, 20);

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Define input stream
                Stream inputStream = Create13MBDataStream();

                // Initiate multipart upload
                InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1"
                };
                InitiateMultipartUploadResponse initResponse = client.InitiateMultipartUpload(initRequest);

                // Upload part 1
                UploadPartRequest uploadRequest = new UploadPartRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    UploadId = initResponse.UploadId,
                    PartNumber = 1,
                    PartSize = 5 * MB,
                    InputStream = inputStream
                };
                UploadPartResponse up1Response = client.UploadPart(uploadRequest);

                // Upload part 2
                uploadRequest = new UploadPartRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    UploadId = initResponse.UploadId,
                    PartNumber = 2,
                    PartSize = 5 * MB,
                    InputStream = inputStream
                };
                UploadPartResponse up2Response = client.UploadPart(uploadRequest);

                // Upload part 3
                uploadRequest = new UploadPartRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    UploadId = initResponse.UploadId,
                    PartNumber = 3,
                    InputStream = inputStream
                };
                UploadPartResponse up3Response = client.UploadPart(uploadRequest);

                // List parts for current upload
                ListPartsRequest listPartRequest = new ListPartsRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    UploadId = initResponse.UploadId
                };
                ListPartsResponse listPartResponse = client.ListParts(listPartRequest);
                Debug.Assert(listPartResponse.Parts.Count == 3);

                // Complete the multipart upload
                CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    UploadId = initResponse.UploadId,
                    PartETags = new List<PartETag>
                    {
                        new PartETag { ETag = up1Response.ETag, PartNumber = 1 },
                        new PartETag { ETag = up2Response.ETag, PartNumber = 2 },
                        new PartETag { ETag = up3Response.ETag, PartNumber = 3 }
                    }
                };
                CompleteMultipartUploadResponse compResponse = client.CompleteMultipartUpload(compRequest);

                #endregion
            }
        }

        private Stream Create13MBDataStream()
        {
            return null;
        }

        private void PopulateBucket(IAmazonS3 client, string bucketName)
        {
            client.PutObject(new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "Item",
                ContentBody = "Attempt number one"
            });

            for (int i = 0; i < 20; i++)
            {
                client.PutObject(new PutObjectRequest()
                {
                    BucketName = bucketName,
                    Key = "Item",
                    ContentBody = "Atempt " + i
                });
            }
        }

        public void PresignedURLSamples()
        {
            {
                #region GetPreSignedURL Sample 1

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    Expires = DateTime.Now.AddMinutes(5)
                };

                // Get path for request
                string path = client.GetPreSignedURL(request);

                // Test by getting contents
                string contents = GetContents(path);

                #endregion
            }

            {
                #region GetPreSignedURL Sample 2

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    Expires = DateTime.Now.AddMinutes(5)
                };
                request.ResponseHeaderOverrides.ContentType = "text/xml+zip";
                request.ResponseHeaderOverrides.ContentDisposition = "attachment; filename=dispName.pdf";
                request.ResponseHeaderOverrides.CacheControl = "No-cache";
                request.ResponseHeaderOverrides.ContentLanguage = "mi, en";
                request.ResponseHeaderOverrides.Expires = "Thu, 01 Dec 1994 16:00:00 GMT";
                request.ResponseHeaderOverrides.ContentEncoding = "x-gzip";

                // Get path for request
                string path = client.GetPreSignedURL(request);

                // Test by getting contents
                string contents = GetContents(path);

                #endregion
            }

            {
                #region GetPreSignedURL Sample 3

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
                {
                    BucketName = "SampleBucket",
                    Expires = DateTime.Now.AddMinutes(5)
                };

                // Get path for request
                string path = client.GetPreSignedURL(request);

                // Retrieve objects
                string allObjects = GetContents(path);

                #endregion
            }

            {
                #region GetPreSignedURL Sample 4

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
                {
                    Expires = DateTime.Now.AddMinutes(5)
                };

                // Get path for request
                string path = client.GetPreSignedURL(request);

                // Retrieve buckets
                string allBuckets = GetContents(path);

                #endregion
            }

            {
                #region GetPreSignedURL Sample 5

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    Verb = HttpVerb.PUT,
                    Expires = DateTime.Now.AddDays(10)
                };

                // Get path for request
                string path = client.GetPreSignedURL(request);

                // Prepare data
                byte[] data = UTF8Encoding.UTF8.GetBytes("Sample text.");

                // Configure request
                HttpWebRequest httpRequest = WebRequest.Create(path) as HttpWebRequest;
                httpRequest.Method = "PUT";
                httpRequest.ContentLength = data.Length;

                // Write data to stream
                Stream requestStream = httpRequest.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                requestStream.Close();

                // Issue request
                HttpWebResponse response = httpRequest.GetResponse() as HttpWebResponse;

                #endregion
            }
        }

        public void AclSamples()
        {
            {
                #region PutACL Sample 1

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Set Canned ACL (PublicRead) for an existing item
                client.PutACL(new PutACLRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    CannedACL = S3CannedACL.PublicRead
                });

                // Set Canned ACL (PublicRead) for an existing item
                // (This reverts ACL back to default for object)
                client.PutACL(new PutACLRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    CannedACL = S3CannedACL.Private
                });

                #endregion
            }

            {
                #region GetACL\PutACL Samples

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Retrieve ACL for object
                S3AccessControlList acl = client.GetACL(new GetACLRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                }).AccessControlList;

                // Retrieve owner
                Owner owner = acl.Owner;


                // Describe grant
                S3Grant grant = new S3Grant
                {
                    Grantee = new S3Grantee { EmailAddress = "sample@example.com" },
                    Permission = S3Permission.WRITE_ACP
                };

                // Create new ACL
                S3AccessControlList newAcl = new S3AccessControlList
                {
                    Grants = new List<S3Grant> { grant },
                    Owner = owner
                };

                // Set new ACL
                PutACLResponse response = client.PutACL(new PutACLRequest
                {
                    BucketName = "SampleBucket",
                    Key = "Item1",
                    AccessControlList = acl
                });

                #endregion
            }
        }

        #region GetContents function

        public static string GetContents(string path)
        {
            HttpWebRequest request = HttpWebRequest.Create(path) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse; 

            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
        
        #endregion

        #region ISample Members

        public void Run()
        {
        }

        #endregion
    }
}
