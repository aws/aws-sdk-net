using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Net.Http;

namespace AWSSDKDocSamples.S3
{
    public class BaseS3Samples : ISample
    {
        public async Task BucketSamples()
        {
            {
                #region ListBuckets Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Issue call
                ListBucketsResponse response = await client.ListBucketsAsync();

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
    ""Resource"":[""arn:aws:s3:::amzn-s3-demo-bucketname/*""] 
}]}";
                PutBucketPolicyRequest putRequest = new PutBucketPolicyRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Policy = newPolicy
                };
                await client.PutBucketPolicyAsync(putRequest);


                // Retrieve current policy
                GetBucketPolicyRequest getRequest = new GetBucketPolicyRequest
                {
                    BucketName = "amzn-s3-demo-bucket"
                };
                string policy = (await client.GetBucketPolicyAsync(getRequest)).Policy;

                Console.WriteLine(policy);
                Debug.Assert(policy.Contains("BasicPerms"));


                // Delete current policy
                DeleteBucketPolicyRequest deleteRequest = new DeleteBucketPolicyRequest
                {
                    BucketName = "amzn-s3-demo-bucket"
                };
                await client.DeleteBucketPolicyAsync(deleteRequest);


                // Retrieve current policy and verify that it is null
                policy = (await client.GetBucketPolicyAsync(getRequest)).Policy;
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
                    BucketName = "amzn-s3-demo-bucket"
                };

                // Issue call
                GetBucketLocationResponse response = await client.GetBucketLocationAsync(request);

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
                    BucketName = "amzn-s3-demo-bucket",
                    BucketRegion = S3Region.EUWest1         // set region to eu-west-1
                };

                // Issue call
                PutBucketResponse response = await client.PutBucketAsync(request);

                #endregion
            }

            {
                #region DeleteBucket Sample 1

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Construct request
                DeleteBucketRequest request = new DeleteBucketRequest
                {
                    BucketName = "amzn-s3-demo-bucket"
                };

                // Issue call
                DeleteBucketResponse response = await client.DeleteBucketAsync(request);

                #endregion
            }

            {
                #region DeleteBucket Sample 2

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // List and delete all objects
                ListObjectsRequest listRequest = new ListObjectsRequest
                {
                    BucketName = "amzn-s3-demo-bucket"
                };

                ListObjectsResponse listResponse;
                do
                {
                    // Get a list of objects
                    listResponse = await client.ListObjectsAsync(listRequest);

                    if (listResponse.S3Objects != null)
                    {
                        foreach (S3Object obj in listResponse.S3Objects)
                        {
                            // Delete each object
                            await client.DeleteObjectAsync(new DeleteObjectRequest
                            {
                                BucketName = "amzn-s3-demo-bucket",
                                Key = obj.Key
                            });
                        }
                    }

                    // Set the marker property
                    listRequest.Marker = listResponse.NextMarker;
                } while (listResponse.IsTruncated.GetValueOrDefault());

                // Construct DeleteBucket request
                DeleteBucketRequest request = new DeleteBucketRequest
                {
                    BucketName = "amzn-s3-demo-bucket"
                };

                // Issue call
                DeleteBucketResponse response = await client.DeleteBucketAsync(request);

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
                            Filter = new LifecycleFilter
                            {
                                LifecycleFilterPredicate = new LifecyclePrefixPredicate
                                {
                                    Prefix = "Test-"
                                }
                            },
                            Expiration = new LifecycleRuleExpiration { Days = 5 }
                        },
                        // Rule to delete keys in subdirectory "Logs" after 2 days
                        new LifecycleRule
                        {
                            Filter = new LifecycleFilter
                            {
                                LifecycleFilterPredicate = new LifecyclePrefixPredicate
                                {
                                    Prefix = "Logs/",
                                }
                            },
                            Expiration = new LifecycleRuleExpiration  { Days = 2 },
                            Id = "log-file-removal"
                        }
                    }
                };
                PutLifecycleConfigurationRequest putRequest = new PutLifecycleConfigurationRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Configuration = newConfiguration
                };
                await client.PutLifecycleConfigurationAsync(putRequest);


                // Retrieve current configuration
                GetLifecycleConfigurationRequest getRequest = new GetLifecycleConfigurationRequest
                {
                    BucketName = "amzn-s3-demo-bucket"
                };
                LifecycleConfiguration configuration = (await client.GetLifecycleConfigurationAsync(getRequest)).Configuration;

                Console.WriteLine("Configuration contains {0} rules", configuration.Rules?.Count);

                if(configuration.Rules != null)
                {
                    foreach (LifecycleRule rule in configuration.Rules)
                    {
                        Console.WriteLine("Rule");
                        if (rule.Filter.LifecycleFilterPredicate is LifecyclePrefixPredicate prefixFilter)
                            Console.WriteLine(" Prefix = " + prefixFilter.Prefix);

                        Console.WriteLine(" Expiration (days) = " + rule.Expiration.Days);
                        Console.WriteLine(" Id = " + rule.Id);
                        Console.WriteLine(" Status = " + rule.Status);
                    }
                }

                // Put a new configuration and overwrite the existing configuration
                configuration.Rules.RemoveAt(0);    // remove first rule
                await client.PutLifecycleConfigurationAsync(putRequest);

                // Delete current configuration
                DeleteLifecycleConfigurationRequest deleteRequest = new DeleteLifecycleConfigurationRequest
                {
                    BucketName = "amzn-s3-demo-bucket"
                };
                await client.DeleteLifecycleConfigurationAsync(deleteRequest);


                // Retrieve current configuration and verify that it is null
                configuration = (await client.GetLifecycleConfigurationAsync(getRequest)).Configuration;
                Debug.Assert(configuration == null);

                #endregion
            }
        }

        public async Task ObjectSamples()
        {
            {
                #region ListObjects Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // List all objects
                ListObjectsRequest listRequest = new ListObjectsRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                };

                ListObjectsResponse listResponse;
                do
                {
                    // Get a list of objects
                    listResponse = await client.ListObjectsAsync(listRequest);

                    if (listResponse.S3Objects != null)
                    {
                        foreach (S3Object obj in listResponse.S3Objects)
                        {
                            Console.WriteLine("Object - " + obj.Key);
                            Console.WriteLine(" Size - " + obj.Size);
                            Console.WriteLine(" LastModified - " + obj.LastModified);
                            Console.WriteLine(" Storage class - " + obj.StorageClass);
                        }
                    }

                    // Set the marker property
                    listRequest.Marker = listResponse.NextMarker;
                } while (listResponse.IsTruncated.GetValueOrDefault());

                #endregion
            }

            {
                #region GetObject Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a GetObject request
                GetObjectRequest request = new GetObjectRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1"
                };

                // Issue request and remember to dispose of the response
                using (GetObjectResponse response = await client.GetObjectAsync(request))
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
                CancellationTokenSource tokenSource = new CancellationTokenSource();
                var cancellationToken = tokenSource.Token;
                #region GetObject WriteResponseStreamToFile Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a GetObject request
                GetObjectRequest request = new GetObjectRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1"
                };

                // Issue request and remember to dispose of the response
                using (GetObjectResponse response = await client.GetObjectAsync(request))
                {
                    // Save object to local file
                    await response.WriteResponseStreamToFileAsync("Item1.txt", false, cancellationToken);
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
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1"
                };

                // Issue request and view the response
                GetObjectMetadataResponse response = await client.GetObjectMetadataAsync(request);
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
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    ContentBody = "This is sample content..."
                };

                // Put object
                PutObjectResponse response = await client.PutObjectAsync(request);

                #endregion
            }

            {
                #region PutObject Sample 2

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a PutObject request
                PutObjectRequest request = new PutObjectRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    FilePath = "contents.txt"
                };

                // Put object
                PutObjectResponse response = await client.PutObjectAsync(request);

                #endregion
            }

            {
                #region PutObject Sample 3

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a PutObject request
                PutObjectRequest request = new PutObjectRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                };
                using (FileStream stream = new FileStream("contents.txt", FileMode.Open))
                {
                    request.InputStream = stream;

                    // Put object
                    PutObjectResponse response = await client.PutObjectAsync(request);
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
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1"
                };

                // Issue request
                await client.DeleteObjectAsync(request);

                #endregion
            }

            {
                #region DeleteObjects Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a DeleteObject request
                DeleteObjectsRequest request = new DeleteObjectsRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
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
                    DeleteObjectsResponse response = await client.DeleteObjectsAsync(request);
                }
                catch (DeleteObjectsException doe)
                {
                    // Catch error and list error details
                    DeleteObjectsResponse errorResponse = doe.Response;

                    if (errorResponse.DeletedObjects != null)
                    {
                        foreach (DeletedObject deletedObject in errorResponse.DeletedObjects)
                        {
                            Console.WriteLine("Deleted item " + deletedObject.Key);
                        }
                    }

                    if (errorResponse.DeleteErrors != null)
                    {
                        foreach (DeleteError deleteError in errorResponse.DeleteErrors)
                        {
                            Console.WriteLine("Error deleting item " + deleteError.Key);
                            Console.WriteLine(" Code - " + deleteError.Code);
                            Console.WriteLine(" Message - " + deleteError.Message);
                        }
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
                    SourceBucket = "amzn-s3-demo-bucket",
                    SourceKey = "Item1",
                    DestinationBucket = "AnotherBucket",
                    DestinationKey = "Copy1",
                    CannedACL = S3CannedACL.PublicRead
                };

                // Issue request
                await client.CopyObjectAsync(request);

                #endregion
            }

            {
                #region CopyObject Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                CopyObjectRequest request = new CopyObjectRequest
                {
                    SourceBucket = "amzn-s3-demo-bucket",
                    SourceKey = "Item1",
                    DestinationBucket = "AnotherBucket",
                    DestinationKey = "Copy1",
                    CannedACL = S3CannedACL.PublicRead
                };

                // Issue request
                await client.CopyObjectAsync(request);

                #endregion
            }

            {
                #region ListVersions Sample

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Turn versioning on for a bucket
                await client.PutBucketVersioningAsync(new PutBucketVersioningRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    VersioningConfig = new S3BucketVersioningConfig { Status = "Enable" }
                });

                // Populate bucket with multiple items, each with multiple versions
                await PopulateBucket(client, "amzn-s3-demo-bucket");

                // Get versions
                ListVersionsRequest request = new ListVersionsRequest
                {
                    BucketName = "amzn-s3-demo-bucket"
                };

                // Make paged ListVersions calls
                ListVersionsResponse response;
                do
                {
                    response = await client.ListVersionsAsync(request);
                    // View information about versions
                    if (response.Versions != null)
                    {
                        foreach (var version in response.Versions)
                        {
                            Console.WriteLine("Key = {0}, Version = {1}, IsLatest = {2}, LastModified = {3}, Size = {4}",
                                version.Key,
                                version.VersionId,
                                version.IsLatest,
                                version.LastModified,
                                version.Size);
                        }
                    }

                    request.KeyMarker = response.NextKeyMarker;
                    request.VersionIdMarker = response.NextVersionIdMarker;
                } while (response.IsTruncated.GetValueOrDefault());

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
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1"
                };
                InitiateMultipartUploadResponse initResponse = await client.InitiateMultipartUploadAsync(initRequest);

                // Upload part 1
                UploadPartRequest uploadRequest = new UploadPartRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    UploadId = initResponse.UploadId,
                    PartNumber = 1,
                    PartSize = 5 * MB,
                    InputStream = inputStream
                };
                UploadPartResponse up1Response = await client.UploadPartAsync(uploadRequest);

                // Upload part 2
                uploadRequest = new UploadPartRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    UploadId = initResponse.UploadId,
                    PartNumber = 2,
                    PartSize = 5 * MB,
                    InputStream = inputStream
                };
                UploadPartResponse up2Response = await client.UploadPartAsync(uploadRequest);

                // Upload part 3
                uploadRequest = new UploadPartRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    UploadId = initResponse.UploadId,
                    PartNumber = 3,
                    InputStream = inputStream
                };
                UploadPartResponse up3Response = await client.UploadPartAsync(uploadRequest);

                // List parts for current upload
                ListPartsRequest listPartRequest = new ListPartsRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    UploadId = initResponse.UploadId
                };
                ListPartsResponse listPartResponse = await client.ListPartsAsync(listPartRequest);
                Debug.Assert(listPartResponse.Parts.Count == 3);

                // Complete the multipart upload
                CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    UploadId = initResponse.UploadId,
                    PartETags = new List<PartETag>
                    {
                        new PartETag { ETag = up1Response.ETag, PartNumber = 1 },
                        new PartETag { ETag = up2Response.ETag, PartNumber = 2 },
                        new PartETag { ETag = up3Response.ETag, PartNumber = 3 }
                    }
                };
                CompleteMultipartUploadResponse compResponse = await client.CompleteMultipartUploadAsync(compRequest);

                #endregion
            }
        }

        private Stream Create13MBDataStream()
        {
            return null;
        }

        private async Task PopulateBucket(IAmazonS3 client, string bucketName)
        {
            await client.PutObjectAsync(new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "Item",
                ContentBody = "Attempt number one"
            });

            for (int i = 0; i < 20; i++)
            {
                await client.PutObjectAsync(new PutObjectRequest()
                {
                    BucketName = bucketName,
                    Key = "Item",
                    ContentBody = "Atempt " + i
                });
            }
        }

        public async Task PresignedURLSamples()
        {
            {
                #region GetPreSignedURL Sample 1

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    Expires = DateTime.UtcNow.AddMinutes(5)
                };

                // Get path for request
                string path = await client.GetPreSignedURLAsync(request);

                // Test by getting contents
                string contents = await GetContents(path);

                #endregion
            }

            {
                #region GetPreSignedURL Sample 2

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    Expires = DateTime.UtcNow.AddMinutes(5)
                };
                request.ResponseHeaderOverrides.ContentType = "text/xml+zip";
                request.ResponseHeaderOverrides.ContentDisposition = "attachment; filename=dispName.pdf";
                request.ResponseHeaderOverrides.CacheControl = "No-cache";
                request.ResponseHeaderOverrides.ContentLanguage = "mi, en";
                request.ResponseHeaderOverrides.Expires = "Thu, 01 Dec 1994 16:00:00 GMT";
                request.ResponseHeaderOverrides.ContentEncoding = "x-gzip";

                // Get path for request
                string path = await client.GetPreSignedURLAsync(request);

                // Test by getting contents
                string contents = await GetContents(path);

                #endregion
            }

            {
                #region GetPreSignedURL Sample 3

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Expires = DateTime.UtcNow.AddMinutes(5)
                };

                // Get path for request
                string path = await client.GetPreSignedURLAsync(request);

                // Retrieve objects
                string allObjects = await GetContents(path);

                #endregion
            }

            {
                #region GetPreSignedURL Sample 4

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
                {
                    Expires = DateTime.UtcNow.AddMinutes(5)
                };

                // Get path for request
                string path = await client.GetPreSignedURLAsync(request);

                // Retrieve buckets
                string allBuckets = await GetContents(path);

                #endregion
            }

            {
                #region GetPreSignedURL Sample 5

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Create a CopyObject request
                GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    Verb = HttpVerb.PUT,
                    Expires = DateTime.UtcNow.AddDays(10)
                };

                // Get path for request
                string path = await client.GetPreSignedURLAsync(request);

                // Prepare data
                byte[] data = UTF8Encoding.UTF8.GetBytes("Sample text.");

                using var httpClient = new HttpClient();
                using var httpRequest = new HttpRequestMessage(HttpMethod.Put, path)
                {
                    Content = new ByteArrayContent(data)
                };

                using var httpResponse = await httpClient.SendAsync(httpRequest);

                #endregion
            }
        }

        public async Task AclSamples()
        {
            {
                #region PutACL Sample 1

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Set Canned ACL (PublicRead) for an existing item
                await client.PutObjectAclAsync(new PutObjectAclRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    ACL = S3CannedACL.PublicRead
                });

                // Set Canned ACL (PublicRead) for an existing item
                // (This reverts ACL back to default for object)
                await client.PutObjectAclAsync(new PutObjectAclRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    ACL = S3CannedACL.Private
                });

                #endregion
            }

            {
                #region GetACL\PutACL Samples

                // Create a client
                AmazonS3Client client = new AmazonS3Client();

                // Retrieve ACL for object
                var getResponse = (await client.GetObjectAclAsync(new GetObjectAclRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                }));

                // Retrieve owner
                Owner owner = getResponse.Owner;


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
                var putResponse = await client.PutObjectAclAsync(new PutObjectAclRequest
                {
                    BucketName = "amzn-s3-demo-bucket",
                    Key = "Item1",
                    AccessControlPolicy = newAcl
                });

                #endregion
            }
        }

        #region GetContents function

        public static async Task<string> GetContents(string path)
        {
            using var httpClient = new HttpClient();
            return await httpClient.GetStringAsync(path);
        }
        
        #endregion

        #region ISample Members

        public Task Run()
        {
            return Task.CompletedTask;
        }

        #endregion
    }
}
