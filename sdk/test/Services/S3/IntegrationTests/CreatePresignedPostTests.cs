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
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;


namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for CreatePresignedPost functionality
    /// </summary>
    [TestClass]
    public class CreatePresignedPostTests : TestBase<AmazonS3Client>
    {
        private const string TestContent = "This is the content body!";
        private const string TestKey = "presigned-post-key";
        private Dictionary<RegionEndpoint, string> RegionCodePairs = new Dictionary<RegionEndpoint, string>()
        {
            { RegionEndpoint.USEast1, "use1-az5" },
            { RegionEndpoint.USWest2, "usw2-az1" },
            { RegionEndpoint.EUNorth1, "eun1-az1" }
        };

        private class PresignedPostTestParameters
        {
            public RegionEndpoint Region { get; set; }
            public DateTime Expiration { get; set; }
            public bool IsS3Express { get; set; }
            public string BucketName { get; set; }
            public Dictionary<string, string> Fields { get; set; }
            public List<S3PostCondition> Conditions { get; set; }
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void USEastUnder7Days()
        {
            TestPresignedPost(new PresignedPostTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                IsS3Express = false
            });

            TestPresignedPostWithSessionToken(new PresignedPostTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                IsS3Express = false
            });
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void USEastOver7Days()
        {
            // Unlike GetPreSignedUrl, CreatePresignedPost always uses SigV4 and should throw an exception for expirations > 7 days
            AssertExtensions.ExpectException(() =>
            {
                TestPresignedPost(new PresignedPostTestParameters
                {
                    Region = RegionEndpoint.USEast1,
                    Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2),
                    IsS3Express = false
                });
            }, typeof(ArgumentException), "The maximum expiry period for a presigned url using AWS4 signing is 604800 seconds");

            AssertExtensions.ExpectException(() =>
            {
                TestPresignedPostWithSessionToken(new PresignedPostTestParameters
                {
                    Region = RegionEndpoint.USEast1,
                    Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2),
                    IsS3Express = false
                });
            }, typeof(ArgumentException), "The maximum expiry period for a presigned url using AWS4 signing is 604800 seconds");
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void WithCustomFields()
        {
            TestPresignedPostWithConditions(new PresignedPostTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddHours(1),
                Fields = new Dictionary<string, string>
                {
                    { "Content-Type", "text/plain" },
                    { "success_action_status", "201" },
                    { "x-amz-meta-original-filename", "test.txt" }
                },
                // Add explicit conditions for all fields to match Python SDK behavior
                Conditions = new List<S3PostCondition>
                {
                    S3PostCondition.ExactMatch("Content-Type", "text/plain"),
                    S3PostCondition.ExactMatch("success_action_status", "201"),
                    S3PostCondition.ExactMatch("x-amz-meta-original-filename", "test.txt")
                },
                IsS3Express = false
            });
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void WithCustomConditions()
        {
            var testParams = new PresignedPostTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddHours(1),
                Fields = new Dictionary<string, string>
                {
                    { "Content-Type", "text/plain" }
                },
                Conditions = new List<S3PostCondition>
                {
                    S3PostCondition.StartsWith("Content-Type", "text/"),
                    S3PostCondition.ContentLengthRange(1, 1048576) // 1 byte to 1 MB
                },
                IsS3Express = false
            };

            TestPresignedPostWithConditions(testParams);
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void S3ExpressDirectoryBucket()
        {
            // Test with a directory bucket in US-East-1
            TestPresignedPost(new PresignedPostTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddHours(1),
                IsS3Express = true
            });

            // Test with session token
            TestPresignedPostWithSessionToken(new PresignedPostTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddHours(1),
                IsS3Express = true
            });
        }

        private void TestPresignedPost(PresignedPostTestParameters testParams)
        {
            var client = new AmazonS3Client(testParams.Region);
            try
            {
                if (testParams.IsS3Express)
                {
                    // Create S3 Express directory bucket
                    testParams.BucketName = $"{UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks}--{RegionCodePairs[testParams.Region]}--x-s3";
                    
                    client.PutBucket(new PutBucketRequest 
                    {
                        BucketName = testParams.BucketName,
                        PutBucketConfiguration = new PutBucketConfiguration
                        {
                            BucketInfo = new BucketInfo { DataRedundancy = DataRedundancy.SingleAvailabilityZone, Type = BucketType.Directory },
                            Location = new LocationInfo { Name = RegionCodePairs[testParams.Region], Type = LocationType.AvailabilityZone }
                        }
                    });
                }
                else
                {
                    // Create regular bucket
                    testParams.BucketName = S3TestUtils.CreateBucketWithWait(client);
                }
                AssertPresignedPost(client, testParams);
            }
            finally
            {
                if (testParams.BucketName != null)
                    AmazonS3Util.DeleteS3BucketWithObjects(client, testParams.BucketName);
            }
        }

        private void TestPresignedPostWithSessionToken(PresignedPostTestParameters testParams)
        {
            using (var sts = new Amazon.SecurityToken.AmazonSecurityTokenServiceClient())
            {
                AWSCredentials credentials = sts.GetSessionToken().Credentials;
                var client = new AmazonS3Client(credentials, testParams.Region);
                try
                {
                    if (testParams.IsS3Express)
                    {
                        // Create S3 Express directory bucket
                        testParams.BucketName = $"{UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks}--{RegionCodePairs[testParams.Region]}--x-s3";
                        
                        client.PutBucket(new PutBucketRequest 
                        {
                            BucketName = testParams.BucketName,
                            PutBucketConfiguration = new PutBucketConfiguration
                            {
                                BucketInfo = new BucketInfo { DataRedundancy = DataRedundancy.SingleAvailabilityZone, Type = BucketType.Directory },
                                Location = new LocationInfo { Name = RegionCodePairs[testParams.Region], Type = LocationType.AvailabilityZone }
                            }
                        });
                    }
                    else
                    {
                        // Create regular bucket
                        testParams.BucketName = S3TestUtils.CreateBucketWithWait(client);
                    }
                    AssertPresignedPost(client, testParams);
                }
                finally
                {
                    if (testParams.BucketName != null)
                        AmazonS3Util.DeleteS3BucketWithObjects(client, testParams.BucketName);
                }
            }
        }

        private void TestPresignedPostWithFields(PresignedPostTestParameters testParams)
        {
            var client = new AmazonS3Client(testParams.Region);
            try
            {
                if (testParams.IsS3Express)
                {
                    // Create S3 Express directory bucket
                    testParams.BucketName = $"{UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks}--{RegionCodePairs[testParams.Region]}--x-s3";
                    
                    client.PutBucket(new PutBucketRequest 
                    {
                        BucketName = testParams.BucketName,
                        PutBucketConfiguration = new PutBucketConfiguration
                        {
                            BucketInfo = new BucketInfo { DataRedundancy = DataRedundancy.SingleAvailabilityZone, Type = BucketType.Directory },
                            Location = new LocationInfo { Name = RegionCodePairs[testParams.Region], Type = LocationType.AvailabilityZone }
                        }
                    });
                }
                else
                {
                    // Create regular bucket
                    testParams.BucketName = S3TestUtils.CreateBucketWithWait(client);
                }
                AssertPresignedPostWithFields(client, testParams);
            }
            finally
            {
                if (testParams.BucketName != null)
                    AmazonS3Util.DeleteS3BucketWithObjects(client, testParams.BucketName);
            }
        }

        private void TestPresignedPostWithConditions(PresignedPostTestParameters testParams)
        {
            var client = new AmazonS3Client(testParams.Region);
            try
            {
                if (testParams.IsS3Express)
                {
                    // Create S3 Express directory bucket
                    testParams.BucketName = $"{UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks}--{RegionCodePairs[testParams.Region]}--x-s3";
                    
                    client.PutBucket(new PutBucketRequest 
                    {
                        BucketName = testParams.BucketName,
                        PutBucketConfiguration = new PutBucketConfiguration
                        {
                            BucketInfo = new BucketInfo { DataRedundancy = DataRedundancy.SingleAvailabilityZone, Type = BucketType.Directory },
                            Location = new LocationInfo { Name = RegionCodePairs[testParams.Region], Type = LocationType.AvailabilityZone }
                        }
                    });
                }
                else
                {
                    // Create regular bucket
                    testParams.BucketName = S3TestUtils.CreateBucketWithWait(client);
                }
                AssertPresignedPostWithConditions(client, testParams);
            }
            finally
            {
                if (testParams.BucketName != null)
                    AmazonS3Util.DeleteS3BucketWithObjects(client, testParams.BucketName);
            }
        }

        private void AssertPresignedPost(AmazonS3Client client, PresignedPostTestParameters testParams)
        {
            string objectKey = TestKey + DateTime.UtcNow.Ticks;

            // Generate presigned POST response
            var request = new CreatePresignedPostRequest
            {
                BucketName = testParams.BucketName,
                Key = objectKey,
                Expires = testParams.Expiration
            };

            var response = client.CreatePresignedPost(request);

            // Verify required fields
            Assert.IsNotNull(response.Url);
            Assert.IsNotNull(response.Fields);
            Assert.IsTrue(response.Fields.ContainsKey("key"));
            Assert.IsTrue(response.Fields.ContainsKey("Policy"));
            Assert.IsTrue(response.Fields.ContainsKey("x-amz-algorithm"));
            Assert.IsTrue(response.Fields.ContainsKey("x-amz-credential"));
            Assert.IsTrue(response.Fields.ContainsKey("x-amz-date"));
            Assert.IsTrue(response.Fields.ContainsKey("x-amz-signature"));

            // Use the presigned post form to upload a file
            var formData = new MultipartFormDataContent();

            // Add all form fields
            foreach (var field in response.Fields)
            {
                formData.Add(new StringContent(field.Value), field.Key);
            }

            // Add file content
            formData.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent)), "file", objectKey);

            // Create and configure the HttpClient
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                // Send the POST request
                var httpResponse = httpClient.PostAsync(response.Url, formData).Result;
                
                // Verify the upload was successful
                Assert.AreEqual(HttpStatusCode.NoContent, httpResponse.StatusCode);
                
                // Verify the uploaded object exists and has the correct content
                var getObjectResponse = client.GetObject(testParams.BucketName, objectKey);
                using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                {
                    var content = reader.ReadToEnd();
                    Assert.AreEqual(TestContent, content);
                }
            }
        }

        private void AssertPresignedPostWithFields(AmazonS3Client client, PresignedPostTestParameters testParams)
        {
            string objectKey = TestKey + DateTime.UtcNow.Ticks;

            // Generate presigned POST response
            var request = new CreatePresignedPostRequest
            {
                BucketName = testParams.BucketName,
                Key = objectKey,
                Expires = testParams.Expiration
            };

            // Add custom fields
            foreach (var field in testParams.Fields)
            {
                request.Fields.Add(field.Key, field.Value);
            }

            var response = client.CreatePresignedPost(request);

            // Verify all fields are present in the response
            foreach (var field in testParams.Fields)
            {
                Assert.IsTrue(response.Fields.ContainsKey(field.Key));
                Assert.AreEqual(field.Value, response.Fields[field.Key]);
            }

            // Use the presigned post form to upload a file
            var formData = new MultipartFormDataContent();

            // Add all form fields
            foreach (var field in response.Fields)
            {
                formData.Add(new StringContent(field.Value), field.Key);
            }

            // Add file content
            formData.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent)), "file", objectKey);

            // Create and configure the HttpClient
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                // Send the POST request
                var httpResponse = httpClient.PostAsync(response.Url, formData).Result;
                
                // Verify the upload was successful
                Assert.IsTrue(httpResponse.IsSuccessStatusCode);
                
                // Verify the uploaded object exists and has the correct content
                var getObjectResponse = client.GetObject(testParams.BucketName, objectKey);
                using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                {
                    var content = reader.ReadToEnd();
                    Assert.AreEqual(TestContent, content);
                }

                if (testParams.Fields.ContainsKey("x-amz-meta-original-filename"))
                {
                    var headObjectResponse = client.GetObjectMetadata(testParams.BucketName, objectKey);

                    // Check if the metadata contains the key using the Keys collection
                    Assert.IsTrue(headObjectResponse.Metadata.Keys.Contains("original-filename"),
                                 "Metadata should contain 'original-filename'");
                    Assert.AreEqual(testParams.Fields["x-amz-meta-original-filename"],
                                    headObjectResponse.Metadata["original-filename"]);
                }

            }
        }

        private void AssertPresignedPostWithConditions(AmazonS3Client client, PresignedPostTestParameters testParams)
        {
            string objectKey = TestKey + DateTime.UtcNow.Ticks;

            // Generate presigned POST response
            var request = new CreatePresignedPostRequest
            {
                BucketName = testParams.BucketName,
                Key = objectKey,
                Expires = testParams.Expiration
            };

            // Add custom fields
            foreach (var field in testParams.Fields)
            {
                request.Fields.Add(field.Key, field.Value);
            }

            // Add conditions
            foreach (var condition in testParams.Conditions)
            {
                request.Conditions.Add(condition);
            }

            var response = client.CreatePresignedPost(request);

            // Use the presigned post form to upload a file that meets the conditions
            var validFormData = new MultipartFormDataContent();

            // Add all form fields
            foreach (var field in response.Fields)
            {
                validFormData.Add(new StringContent(field.Value), field.Key);
            }

            // Add file content that meets conditions
            validFormData.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent)), "file", objectKey);

            // Create and configure the HttpClient
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                // Send the valid POST request
                var validResponse = httpClient.PostAsync(response.Url, validFormData).Result;
                
                // Verify the upload was successful
                Assert.IsTrue(validResponse.IsSuccessStatusCode);
                
                // Verify the uploaded object exists and has the correct content
                var getObjectResponse = client.GetObject(testParams.BucketName, objectKey);
                using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                {
                    var content = reader.ReadToEnd();
                    Assert.AreEqual(TestContent, content);
                }

                // Delete the object for the next test
                client.DeleteObject(testParams.BucketName, objectKey);

                // Test a violation of the Content-Type condition if present
                if (testParams.Conditions.Any(c => c is StartsWithCondition && 
                   ((StartsWithCondition)c).FieldName == "Content-Type" && 
                   ((StartsWithCondition)c).Prefix == "text/"))
                {
                    // Create new form data with invalid Content-Type
                    var invalidFormData = new MultipartFormDataContent();
                    
                    // Add all fields but modify Content-Type to violate condition
                    foreach (var field in response.Fields)
                    {
                        if (field.Key == "Content-Type")
                        {
                            invalidFormData.Add(new StringContent("image/jpeg"), field.Key); // This violates the text/ prefix
                        }
                        else
                        {
                            invalidFormData.Add(new StringContent(field.Value), field.Key);
                        }
                    }

                    invalidFormData.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent)), "file", objectKey);
                    
                    // This request should fail with 403 Forbidden
                    var invalidResponse = httpClient.PostAsync(response.Url, invalidFormData).Result;
                    Assert.AreEqual(HttpStatusCode.Forbidden, invalidResponse.StatusCode);
                }

                // Test a violation of the content length range condition if present
                var contentLengthCondition = testParams.Conditions.FirstOrDefault(c => c is ContentLengthRangeCondition) as ContentLengthRangeCondition;
                if (contentLengthCondition != null && contentLengthCondition.MaximumLength < 10 * 1024 * 1024) // Only if max is reasonable
                {
                    // Create new form data with a file that exceeds max size
                    var oversizeFormData = new MultipartFormDataContent();
                    
                    // Add all fields
                    foreach (var field in response.Fields)
                    {
                        oversizeFormData.Add(new StringContent(field.Value), field.Key);
                    }

                    // Generate a file larger than the max size
                    var largeContent = new byte[contentLengthCondition.MaximumLength + 1024]; // Exceed by 1KB
                    new Random().NextBytes(largeContent);
                    
                    oversizeFormData.Add(new ByteArrayContent(largeContent), "file", objectKey);
                    
                    // This request should fail
                    var oversizeResponse = httpClient.PostAsync(response.Url, oversizeFormData).Result;
                    Assert.AreEqual(HttpStatusCode.BadRequest, oversizeResponse.StatusCode);
                }
            }
        }
    }
}
