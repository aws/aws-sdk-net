using Amazon.S3;
using Amazon.S3.Model;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for CreatePresignedPost functionality
    /// </summary>
    [Trait("Category", "S3")]
    public class CreatePresignedPostTests : IClassFixture<S3BucketFixture>
    {
        private class UploadResult
        {
            public bool IsSuccessful { get; set; }
            public HttpStatusCode StatusCode { get; set; }
            public string ResponseText { get; set; }
        }

        private const string TestContent = "This is the content body!";
        private const string TestKey = "presigned-post-key";
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _testId;

        public CreatePresignedPostTests(S3BucketFixture fixture)
        {
            _client = fixture.Client;
            _bucketName = fixture.BucketName;
            _testId = Guid.NewGuid().ToString("N");
        }

        private class PresignedPostTestParameters
        {
            public DateTime Expiration { get; set; }
            public string BucketName { get; set; }
            public Dictionary<string, string> Fields { get; set; }
            public List<S3PostCondition> Conditions { get; set; }
        }

        [Fact]
        public async Task USEastUnder7Days()
        {
            await TestPresignedPost(new PresignedPostTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2)
            });
        }

        [Fact]
        public async Task USEastOver7Days()
        {
            // Unlike GetPreSignedUrl, CreatePresignedPost always uses SigV4 and should throw an exception for expirations > 7 days
            var actualException = await Assert.ThrowsAsync<ArgumentException>(() =>
                TestPresignedPost(new PresignedPostTestParameters
                {
                    Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2)
                })
            );
            Assert.Equal("The maximum expiry period for a presigned url using AWS4 signing is 604800 seconds", actualException.Message);
        }

        [Fact]
        public async Task WithCustomConditions()
        {
            var testParams = new PresignedPostTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddHours(1),
                Fields = new Dictionary<string, string>
                {
                    // Include Content-Type in Fields even with a starts-with condition
                    // This matches JavaScript SDK behavior - fields and conditions can coexist
                    { "Content-Type", "text/plain" }
                },
                Conditions = new List<S3PostCondition>
                {
                    S3PostCondition.StartsWith("Content-Type", "text/"),
                    S3PostCondition.ContentLengthRange(1, 1048576) // 1 byte to 1 MB
                }
            };

            await TestPresignedPostWithConditions(testParams);
        }

        [Fact]
        public async Task WithContentTypeFieldAndStartsWithCondition()
        {
            var testParams = new PresignedPostTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddHours(1),
                Fields = new Dictionary<string, string>
                {
                    // Include Content-Type in Fields, matching JavaScript SDK behavior
                    { "Content-Type", "text/plain" },
                    { "success_action_status", "201" }
                },
                Conditions = new List<S3PostCondition>
                {
                    // Also add a starts-with condition for Content-Type
                    S3PostCondition.StartsWith("Content-Type", "text/"),
                    S3PostCondition.ContentLengthRange(1, 1048576) // 1 byte to 1 MB
                }
            };

            await TestPresignedPostWithMixedContentType(testParams);
        }
        
        [Fact]
        public async Task FilenameVariableHandling()
        {
            var testParams = new PresignedPostTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddHours(1)
            };

            await TestPresignedPostWithFilenameVariable(testParams);
        }

        private async Task TestPresignedPost(PresignedPostTestParameters testParams)
        {
            testParams.BucketName = _bucketName;
            await AssertPresignedPost(testParams);
        }

        private async Task TestPresignedPostWithConditions(PresignedPostTestParameters testParams)
        {
            testParams.BucketName = _bucketName;
            await AssertPresignedPostWithConditions(testParams);
        }
        
        private CreatePresignedPostResponse GeneratePresignedPostRequest(
            string bucketName, 
            string objectKey, 
            DateTime expiration,
            Dictionary<string, string> fields = null,
            List<S3PostCondition> conditions = null)
        {
            var request = new CreatePresignedPostRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                Expires = expiration
            };

            if (fields != null)
            {
                foreach (var field in fields)
                    request.Fields.Add(field.Key, field.Value);
            }

            if (conditions != null)
            {
                foreach (var condition in conditions)
                    request.Conditions.Add(condition);
            }

            return _client.CreatePresignedPost(request);
        }

        private void ValidateContentTypeFieldPresent(CreatePresignedPostResponse response, string expectedContentType)
        {
            Assert.True(response.Fields.ContainsKey("Content-Type"));
            Assert.Equal(expectedContentType, response.Fields["Content-Type"]);
        }

        private async Task<UploadResult> PerformUpload(
            string url, 
            Dictionary<string, string> fields, 
            string content, 
            string objectKey,
            string contentType)
        {
            var formData = new MultipartFormDataContent();

            foreach (var field in fields)
                formData.Add(new StringContent(field.Value), field.Key);

            var fileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
            fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
            formData.Add(fileContent, "file", objectKey);

            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsync(url, formData);
                
                return new UploadResult
                {
                    IsSuccessful = httpResponse.IsSuccessStatusCode,
                    StatusCode = httpResponse.StatusCode,
                    ResponseText = await httpResponse.Content.ReadAsStringAsync()
                };
            }
        }

        private async Task ValidateObjectContent(string bucketName, string objectKey, string expectedContent)
        {
            var getObjectResponse = await _client.GetObjectAsync(bucketName, objectKey);
            using (var reader = new StreamReader(getObjectResponse.ResponseStream))
            {
                var content = await reader.ReadToEndAsync();
                Assert.Equal(expectedContent, content);
            }
        }

        private async Task<UploadResult> PerformInvalidContentTypeUpload(
            string url,
            Dictionary<string, string> fields,
            string content,
            string objectKey)
        {
            var formData = new MultipartFormDataContent();
            
            foreach (var field in fields)
            {
                if (field.Key == "Content-Type")
                    formData.Add(new StringContent("image/jpeg"), field.Key);
                else
                    formData.Add(new StringContent(field.Value), field.Key);
            }
            
            var invalidFileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
            invalidFileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
            formData.Add(invalidFileContent, "file", objectKey);
            
            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsync(url, formData);
                
                return new UploadResult
                {
                    IsSuccessful = httpResponse.IsSuccessStatusCode,
                    StatusCode = httpResponse.StatusCode,
                    ResponseText = await httpResponse.Content.ReadAsStringAsync()
                };
            }
        }

        private async Task TestPresignedPostWithMixedContentType(PresignedPostTestParameters testParams)
        {
            testParams.BucketName = _bucketName;

            string objectKey = _testId + "-" + TestKey;

            var response = GeneratePresignedPostRequest(
                testParams.BucketName,
                objectKey,
                testParams.Expiration,
                testParams.Fields,
                testParams.Conditions);

            ValidateContentTypeFieldPresent(response, "text/plain");

            var uploadResult = await PerformUpload(
                response.Url,
                response.Fields,
                TestContent,
                objectKey,
                "text/plain");

            Assert.True(uploadResult.IsSuccessful);
            await ValidateObjectContent(testParams.BucketName, objectKey, TestContent);
            await _client.DeleteObjectAsync(testParams.BucketName, objectKey);

            var invalidResult = await PerformInvalidContentTypeUpload(
                response.Url,
                response.Fields,
                TestContent,
                objectKey);

            Assert.Equal(HttpStatusCode.Forbidden, invalidResult.StatusCode);
        }

        private async Task AssertPresignedPost(PresignedPostTestParameters testParams)
        {
            string objectKey = _testId + "-" + TestKey;

            var request = new CreatePresignedPostRequest
            {
                BucketName = testParams.BucketName,
                Key = objectKey,
                Expires = testParams.Expiration
            };

            var response = _client.CreatePresignedPost(request);

            Assert.NotNull(response.Url);
            Assert.NotNull(response.Fields);
            Assert.True(response.Fields.ContainsKey("key"));
            Assert.True(response.Fields.ContainsKey("Policy"));
            Assert.True(response.Fields.ContainsKey("x-amz-algorithm"));
            Assert.True(response.Fields.ContainsKey("x-amz-credential"));
            Assert.True(response.Fields.ContainsKey("x-amz-date"));
            Assert.True(response.Fields.ContainsKey("x-amz-signature"));

            var formData = new MultipartFormDataContent();

            foreach (var field in response.Fields)
                formData.Add(new StringContent(field.Value), field.Key);

            formData.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent)), "file", objectKey);

            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsync(response.Url, formData);
                
                Assert.Equal(HttpStatusCode.NoContent, httpResponse.StatusCode);
                
                var getObjectResponse = await _client.GetObjectAsync(testParams.BucketName, objectKey);
                using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                {
                    var content = await reader.ReadToEndAsync();
                    Assert.Equal(TestContent, content);
                }
            }
        }

        private async Task<UploadResult> PerformUploadWithActualFilename(
            string url, 
            Dictionary<string, string> fields, 
            string content,
            string filename)
        {
            var formData = new MultipartFormDataContent();

            foreach (var field in fields)
                formData.Add(new StringContent(field.Value), field.Key);

            var fileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
            fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/plain");
            formData.Add(fileContent, "file", filename);

            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsync(url, formData);
                
                return new UploadResult
                {
                    IsSuccessful = httpResponse.IsSuccessStatusCode,
                    StatusCode = httpResponse.StatusCode,
                    ResponseText = await httpResponse.Content.ReadAsStringAsync()
                };
            }
        }

        private async Task TestPresignedPostWithFilenameVariable(PresignedPostTestParameters testParams)
        {
            testParams.BucketName = _bucketName;

            string keyPrefix = "uploads/";
            string objectKey = keyPrefix + "${filename}";
            string actualFilename = "test-file-" + _testId + ".txt";

            var response = GeneratePresignedPostRequest(testParams.BucketName, objectKey, testParams.Expiration);
            var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
            var policyJson = Encoding.UTF8.GetString(policyBytes);
            var policyDoc = JsonDocument.Parse(policyJson);

            bool hasStartsWithCondition = false;
            foreach (var condition in policyDoc.RootElement.GetProperty("conditions").EnumerateArray())
            {
                if (condition.ValueKind == JsonValueKind.Array &&
                    condition.GetArrayLength() == 3 &&
                    condition[0].GetString() == "starts-with" &&
                    condition[1].GetString() == "$key")
                {
                    string foundPrefix = condition[2].GetString();
                    Assert.Equal(keyPrefix, foundPrefix);
                    hasStartsWithCondition = true;
                    break;
                }
            }

            Assert.True(hasStartsWithCondition);

            string expectedFinalKey = keyPrefix + actualFilename;
            var uploadResult = await PerformUploadWithActualFilename(
                response.Url,
                response.Fields,
                TestContent,
                actualFilename);

            Assert.True(uploadResult.IsSuccessful);

            try
            {
                var objectMetadata = await _client.GetObjectMetadataAsync(testParams.BucketName, expectedFinalKey);
                Assert.NotNull(objectMetadata);

                var getObjectResponse = await _client.GetObjectAsync(testParams.BucketName, expectedFinalKey);
                using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                {
                    var content = await reader.ReadToEndAsync();
                    Assert.Equal(TestContent, content);
                }
            }
            catch (AmazonS3Exception ex)
            {
                Assert.Fail($"Failed to get object with key '{expectedFinalKey}': {ex.Message}");
            }
        }

        private async Task AssertPresignedPostWithConditions(PresignedPostTestParameters testParams)
        {
            string objectKey = _testId + "-" + TestKey;

            var request = new CreatePresignedPostRequest
            {
                BucketName = testParams.BucketName,
                Key = objectKey,
                Expires = testParams.Expiration
            };

            foreach (var field in testParams.Fields)
                request.Fields.Add(field.Key, field.Value);

            foreach (var condition in testParams.Conditions)
                request.Conditions.Add(condition);

            var response = _client.CreatePresignedPost(request);

            var validFormData = new MultipartFormDataContent();

            foreach (var field in response.Fields)
                validFormData.Add(new StringContent(field.Value), field.Key);

            var contentTypeCondition = testParams.Conditions.FirstOrDefault(c => c is StartsWithCondition && 
                ((StartsWithCondition)c).FieldName == "Content-Type") as StartsWithCondition;

            if (contentTypeCondition != null)
            {
                var fileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent));
                string contentTypeToUse = "text/plain";
                fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentTypeToUse);
                
                if (!response.Fields.ContainsKey("Content-Type"))
                    validFormData.Add(new StringContent(contentTypeToUse), "Content-Type");
                
                validFormData.Add(fileContent, "file", objectKey);
            }
            else
            {
                validFormData.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent)), "file", objectKey);
            }

            using (var httpClient = new HttpClient())
            {
                var validResponse = await httpClient.PostAsync(response.Url, validFormData);
                
                Assert.True(validResponse.IsSuccessStatusCode);
                
                var getObjectResponse = await _client.GetObjectAsync(testParams.BucketName, objectKey);
                using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                {
                    var content = await reader.ReadToEndAsync();
                    Assert.Equal(TestContent, content);
                }

                await _client.DeleteObjectAsync(testParams.BucketName, objectKey);

                var invalidContentTypeCondition = testParams.Conditions.FirstOrDefault(c => c is StartsWithCondition && 
                   ((StartsWithCondition)c).FieldName == "Content-Type") as StartsWithCondition;
                   
                if (invalidContentTypeCondition != null)
                {
                    var invalidFormData = new MultipartFormDataContent();
                    foreach (var field in response.Fields)
                    {
                        invalidFormData.Add(new StringContent(field.Value), field.Key);
                    }

                    // Manually add a Content-Type that violates the condition
                    // Note: With JavaScript-like behavior, Content-Type might not be in response.Fields
                    // if there's a starts-with condition for it
                    invalidFormData.Add(new StringContent("image/jpeg"), "Content-Type");

                    var fileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent));
                    fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                    invalidFormData.Add(fileContent, "file", objectKey);
                    
                    var invalidResponse = await httpClient.PostAsync(response.Url, invalidFormData);
                    Assert.Equal(HttpStatusCode.Forbidden, invalidResponse.StatusCode);
                }

                var contentLengthCondition = testParams.Conditions.FirstOrDefault(c => c is ContentLengthRangeCondition) as ContentLengthRangeCondition;
                if (contentLengthCondition != null && contentLengthCondition.MaximumLength < 10 * 1024 * 1024)
                {
                    var oversizeFormData = new MultipartFormDataContent();
                    
                    foreach (var field in response.Fields)
                    {
                        oversizeFormData.Add(new StringContent(field.Value), field.Key);
                    }

                    // Generate a file larger than the max size
                    var largeContent = new byte[contentLengthCondition.MaximumLength + 1024]; // Exceed by 1KB
                    new Random().NextBytes(largeContent);

                    oversizeFormData.Add(new ByteArrayContent(largeContent), "file", objectKey);
                    
                    var oversizeResponse = await httpClient.PostAsync(response.Url, oversizeFormData);
                    Assert.Equal(HttpStatusCode.BadRequest, oversizeResponse.StatusCode);
                }
            }
        }
    }
}
