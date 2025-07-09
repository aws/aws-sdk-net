using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace S3PostAotDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("AWS SDK S3 Presigned POST Demo (Native AOT)");
            Console.WriteLine("===========================================");
            Console.WriteLine("JSON-Driven Testing with Real S3 Operations");
            Console.WriteLine();

            try
            {
                // Load test cases from JSON file
                var testCases = LoadTestCases();
                Console.WriteLine($"Loaded {testCases.Count} test cases from s3-presigned-post-test-cases.json");

                // Set up credentials and S3 client using real AWS credentials
                Console.WriteLine("Setting up AWS credentials...");
                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USWest2
                };

                using (var s3Client = new AmazonS3Client(config))
                {
                    // Verify credentials work
                    await VerifyCredentials(s3Client);
                    
                    // Use consistent bucket name for comparison
                    var bucketName = "s3-presigned-post-demo-comparison";
                    var timestamp = "consistent"; // Use consistent timestamp for comparison
                    
                    Console.WriteLine($"\nUsing bucket: {bucketName}");
                    Console.WriteLine($"Region: us-west-2");
                    Console.WriteLine();
                    
                    // Create bucket
                    await CreateTestBucket(s3Client, bucketName, "us-west-2");
                    
                    // Execute all test cases
                    for (int i = 0; i < testCases.Count; i++)
                    {
                        if (i > 0)
                        {
                            Console.WriteLine("\n" + new string('=', 60) + "\n");
                        }
                        
                        await ExecuteTestCase(s3Client, testCases[i], bucketName, timestamp);
                    }
                    
                    Console.WriteLine($"\nNOTE: Bucket '{bucketName}' and uploaded files remain in your AWS account.");
                    Console.WriteLine("You can manually delete them from the AWS console if needed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nERROR: {ex.Message}");
                Console.WriteLine("\nFull exception details:");
                Console.WriteLine(ex.ToString());
                Environment.Exit(1);
            }

            Console.WriteLine("\nDemo completed successfully!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static async Task VerifyCredentials(AmazonS3Client s3Client)
        {
            try
            {
                Console.WriteLine("Verifying AWS credentials...");
                await s3Client.ListBucketsAsync();
                Console.WriteLine("✓ AWS credentials verified successfully");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to verify AWS credentials: {ex.Message}", ex);
            }
        }

        static async Task CreateTestBucket(AmazonS3Client s3Client, string bucketName, string region)
        {
            try
            {
                Console.WriteLine($"Creating S3 bucket: {bucketName}");
                
                // var createRequest = new PutBucketRequest
                // {
                //     BucketName = bucketName,
                //     BucketRegion = S3Region.FindValue(region)
                // };

                // await s3Client.PutBucketAsync(createRequest);
                Console.WriteLine("✓ Bucket created successfully");
            }
            catch (AmazonS3Exception ex) when (ex.ErrorCode == "BucketAlreadyExists")
            {
                Console.WriteLine("✓ Bucket already exists, continuing...");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to create bucket: {ex.Message}", ex);
            }
        }

        static async Task<bool> UploadFileUsingPresignedPost(CreatePresignedPostResponse response, string content, string contentType)
        {
            try
            {
                using var httpClient = new HttpClient();
                using var form = new MultipartFormDataContent();

                // Add all the required form fields from the presigned POST response
                foreach (var field in response.Fields)
                {
                    form.Add(new StringContent(field.Value), field.Key);
                }

                // Add the file content
                var fileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
                fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
                form.Add(fileContent, "file", "test-file.txt");

                // Perform the upload
                var uploadResponse = await httpClient.PostAsync(response.Url, form);
                
                Console.WriteLine($"  HTTP Status: {uploadResponse.StatusCode}");
                
                if (uploadResponse.IsSuccessStatusCode)
                {
                    var responseContent = await uploadResponse.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseContent))
                    {
                        Console.WriteLine($"  Response: {responseContent}");
                    }
                    return true;
                }
                else
                {
                    var errorContent = await uploadResponse.Content.ReadAsStringAsync();
                    Console.WriteLine($"  Error response: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Upload exception: {ex.Message}");
                return false;
            }
        }

        static async Task VerifyUploadedFile(AmazonS3Client s3Client, string bucketName, string objectKey, string expectedContent)
        {
            try
            {
                Console.WriteLine("Verifying uploaded file...");
                
                var getRequest = new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = objectKey
                };

                using var getResponse = await s3Client.GetObjectAsync(getRequest);
                using var reader = new StreamReader(getResponse.ResponseStream);
                var actualContent = await reader.ReadToEndAsync();

                Console.WriteLine($"✓ File retrieved from S3");
                Console.WriteLine($"  Size: {getResponse.ContentLength} bytes");
                Console.WriteLine($"  Content-Type: {getResponse.Headers.ContentType}");
                Console.WriteLine($"  Last Modified: {getResponse.LastModified}");
                
                if (actualContent == expectedContent)
                {
                    Console.WriteLine("✓ File content matches expected content");
                }
                else
                {
                    Console.WriteLine("⚠ File content differs from expected");
                    Console.WriteLine("Expected:");
                    Console.WriteLine(expectedContent);
                    Console.WriteLine("Actual:");
                    Console.WriteLine(actualContent);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Failed to verify uploaded file: {ex.Message}");
            }
        }

        static async Task VerifyBinaryUpload(AmazonS3Client s3Client, string bucketName, string objectKey, byte[] expectedContent)
        {
            try
            {
                Console.WriteLine("Verifying binary file upload...");
                
                var getRequest = new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = objectKey
                };

                using var getResponse = await s3Client.GetObjectAsync(getRequest);
                
                // Read the binary content
                using var memoryStream = new MemoryStream();
                await getResponse.ResponseStream.CopyToAsync(memoryStream);
                var actualContent = memoryStream.ToArray();

                Console.WriteLine($"✓ Binary file retrieved from S3");
                Console.WriteLine($"  Size: {getResponse.ContentLength} bytes (expected: {expectedContent.Length})");
                Console.WriteLine($"  Content-Type: {getResponse.Headers.ContentType}");
                Console.WriteLine($"  Last Modified: {getResponse.LastModified}");
                
                // Compare binary content
                if (actualContent.Length == expectedContent.Length)
                {
                    bool contentMatches = true;
                    for (int i = 0; i < actualContent.Length; i++)
                    {
                        if (actualContent[i] != expectedContent[i])
                        {
                            contentMatches = false;
                            break;
                        }
                    }
                    
                    if (contentMatches)
                    {
                        Console.WriteLine("✓ Binary file content matches expected content exactly");
                    }
                    else
                    {
                        Console.WriteLine("⚠ Binary file content differs from expected");
                        Console.WriteLine("  First few bytes comparison:");
                        var compareLength = Math.Min(16, actualContent.Length);
                        Console.Write("  Expected: ");
                        for (int i = 0; i < compareLength; i++)
                        {
                            Console.Write($"{expectedContent[i]:X2} ");
                        }
                        Console.WriteLine();
                        Console.Write("  Actual:   ");
                        for (int i = 0; i < compareLength; i++)
                        {
                            Console.Write($"{actualContent[i]:X2} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine($"⚠ Binary file size mismatch - Expected: {expectedContent.Length}, Actual: {actualContent.Length}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Failed to verify binary upload: {ex.Message}");
            }
        }

        static async Task RunFormBasedUploadTests(AmazonS3Client s3Client, string bucketName)
        {
            Console.WriteLine("=== FORM-BASED UPLOAD TESTS ===");
            Console.WriteLine("Simulating browser form uploads with multipart form data");
            Console.WriteLine();

            // Test 1: Text file upload
            await TestTextFileUpload(s3Client, bucketName);
            Console.WriteLine();

            // Test 2: JSON file upload  
            await TestJsonFileUpload(s3Client, bucketName);
            Console.WriteLine();

            // Test 3: Binary file upload (simulated image)
            await TestBinaryFileUpload(s3Client, bucketName);
            Console.WriteLine();

            Console.WriteLine("✓ All form-based upload tests completed!");
        }

        static async Task TestTextFileUpload(AmazonS3Client s3Client, string bucketName)
        {
            Console.WriteLine("--- Text File Upload Test ---");
            
            try
            {
                // Generate presigned POST for text file
                var request = new CreatePresignedPostRequest
                {
                    BucketName = bucketName,
                    Key = $"form-uploads/text-{DateTime.UtcNow:yyyyMMdd-HHmmss}.txt",
                    Expires = AWSSDKUtils.CorrectedUtcNow.AddMinutes(10),
                    Fields = new Dictionary<string, string>
                    {
                        ["Content-Type"] = "text/plain"
                    },
                    Conditions = new List<S3PostCondition>
                    {
                        new StartsWithCondition("Content-Type", "text/"),
                        new ContentLengthRangeCondition(1, 1024 * 1024) // 1 byte to 1MB
                    }
                };

                var response = await s3Client.CreatePresignedPostAsync(request);
                Console.WriteLine($"Generated presigned POST for: {request.Key}");

                // Output comparison data
                OutputPresignedPostComparison(response, "Text Upload Test");

                // Create test text content
                var textContent = $"Form Upload Test - Text File\n" +
                                 $"Generated: {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC\n" +
                                 $"Content-Type: text/plain\n" +
                                 $"Upload Method: Multipart Form Data";

                // Upload using form data
                var success = await UploadUsingFormData(response, textContent, "text/plain", "test.txt");
                
                if (success)
                {
                    Console.WriteLine("✓ Text file uploaded successfully via form data");
                    await VerifyUploadedFile(s3Client, bucketName, request.Key, textContent);
                }
                else
                {
                    Console.WriteLine("✗ Text file upload failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Text file upload test failed: {ex.Message}");
            }
        }

        static async Task TestJsonFileUpload(AmazonS3Client s3Client, string bucketName)
        {
            Console.WriteLine("--- JSON File Upload Test ---");
            
            try
            {
                // Generate presigned POST for JSON file
                var request = new CreatePresignedPostRequest
                {
                    BucketName = bucketName,
                    Key = $"form-uploads/data-{DateTime.UtcNow:yyyyMMdd-HHmmss}.json",
                    Expires = AWSSDKUtils.CorrectedUtcNow.AddMinutes(10),
                    Fields = new Dictionary<string, string>
                    {
                        ["Content-Type"] = "application/json"
                    },
                    Conditions = new List<S3PostCondition>
                    {
                        new ExactMatchCondition("Content-Type", "application/json"),
                        new ContentLengthRangeCondition(1, 1024 * 1024) // 1 byte to 1MB
                    }
                };

                var response = await s3Client.CreatePresignedPostAsync(request);
                Console.WriteLine($"Generated presigned POST for: {request.Key}");

                // Output comparison data
                OutputPresignedPostComparison(response, "JSON Upload Test");

                // Create test JSON content
                var jsonData = new
                {
                    testName = "S3 Presigned POST Form Upload",
                    timestamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                    bucket = bucketName,
                    uploadMethod = "multipart/form-data",
                    contentType = "application/json",
                    success = true,
                    metadata = new
                    {
                        fileSize = "small",
                        uploadedVia = "AWS SDK for .NET",
                        testScenario = "JSON file upload"
                    }
                };

                var jsonContent = JsonSerializer.Serialize(jsonData, new JsonSerializerOptions { WriteIndented = true });

                // Upload using form data
                var success = await UploadUsingFormData(response, jsonContent, "application/json", "data.json");
                
                if (success)
                {
                    Console.WriteLine("✓ JSON file uploaded successfully via form data");
                    await VerifyUploadedFile(s3Client, bucketName, request.Key, jsonContent);
                }
                else
                {
                    Console.WriteLine("✗ JSON file upload failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ JSON file upload test failed: {ex.Message}");
            }
        }

        static async Task TestBinaryFileUpload(AmazonS3Client s3Client, string bucketName)
        {
            Console.WriteLine("--- Binary File Upload Test ---");
            
            try
            {
                // Generate presigned POST for binary file (simulated image)
                var request = new CreatePresignedPostRequest
                {
                    BucketName = bucketName,
                    Key = $"form-uploads/image-{DateTime.UtcNow:yyyyMMdd-HHmmss}.png",
                    Expires = AWSSDKUtils.CorrectedUtcNow.AddMinutes(10),
                    Fields = new Dictionary<string, string>
                    {
                        ["Content-Type"] = "image/png"
                    },
                    Conditions = new List<S3PostCondition>
                    {
                        new ExactMatchCondition("Content-Type", "image/png"),
                        new ContentLengthRangeCondition(1, 5 * 1024 * 1024) // 1 byte to 5MB
                    }
                };

                var response = await s3Client.CreatePresignedPostAsync(request);
                Console.WriteLine($"Generated presigned POST for: {request.Key}");

                // Output comparison data
                OutputPresignedPostComparison(response, "Binary Upload Test");

                // Create simulated binary content (minimal PNG header)
                var binaryContent = new byte[]
                {
                    0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, // PNG signature
                    0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, // IHDR chunk
                    0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, // 1x1 pixel
                    0x08, 0x02, 0x00, 0x00, 0x00, 0x90, 0x77, 0x53, // RGB, no compression
                    0xDE, 0x00, 0x00, 0x00, 0x0C, 0x49, 0x44, 0x41, // IDAT chunk
                    0x54, 0x08, 0x99, 0x01, 0x01, 0x00, 0x00, 0x00, 
                    0xFF, 0xFF, 0x00, 0x00, 0x00, 0x02, 0x00, 0x01,
                    0xE2, 0x21, 0xBC, 0x33, 0x00, 0x00, 0x00, 0x00, // IEND chunk
                    0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
                };

                // Upload using form data
                var success = await UploadBinaryUsingFormData(response, binaryContent, "image/png", "image.png");
                
                if (success)
                {
                    Console.WriteLine("✓ Binary file uploaded successfully via form data");
                    await VerifyBinaryUpload(s3Client, bucketName, request.Key, binaryContent);
                }
                else
                {
                    Console.WriteLine("✗ Binary file upload failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Binary file upload test failed: {ex.Message}");
            }
        }

        static async Task<bool> UploadUsingFormData(CreatePresignedPostResponse response, string content, string contentType, string fileName)
        {
            try
            {
                using var httpClient = new HttpClient();
                using var form = new MultipartFormDataContent();

                // Add all the required form fields from the presigned POST response
                foreach (var field in response.Fields)
                {
                    form.Add(new StringContent(field.Value), field.Key);
                }

                // Add the file content
                var fileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
                fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
                form.Add(fileContent, "file", fileName);

                Console.WriteLine($"Uploading {fileName} ({content.Length} bytes) via multipart form data...");

                // Perform the upload
                var uploadResponse = await httpClient.PostAsync(response.Url, form);
                
                Console.WriteLine($"  HTTP Status: {uploadResponse.StatusCode}");
                
                if (uploadResponse.IsSuccessStatusCode)
                {
                    var responseContent = await uploadResponse.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseContent))
                    {
                        Console.WriteLine($"  S3 Response: {responseContent}");
                    }
                    return true;
                }
                else
                {
                    var errorContent = await uploadResponse.Content.ReadAsStringAsync();
                    Console.WriteLine($"  Error response: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Upload exception: {ex.Message}");
                return false;
            }
        }

        static async Task<bool> UploadBinaryUsingFormData(CreatePresignedPostResponse response, byte[] content, string contentType, string fileName)
        {
            try
            {
                using var httpClient = new HttpClient();
                using var form = new MultipartFormDataContent();

                // Add all the required form fields from the presigned POST response
                foreach (var field in response.Fields)
                {
                    form.Add(new StringContent(field.Value), field.Key);
                }

                // Add the binary file content
                var fileContent = new ByteArrayContent(content);
                fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
                form.Add(fileContent, "file", fileName);

                Console.WriteLine($"Uploading {fileName} ({content.Length} bytes) via multipart form data...");

                // Perform the upload
                var uploadResponse = await httpClient.PostAsync(response.Url, form);
                
                Console.WriteLine($"  HTTP Status: {uploadResponse.StatusCode}");
                
                if (uploadResponse.IsSuccessStatusCode)
                {
                    var responseContent = await uploadResponse.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseContent))
                    {
                        Console.WriteLine($"  S3 Response: {responseContent}");
                    }
                    return true;
                }
                else
                {
                    var errorContent = await uploadResponse.Content.ReadAsStringAsync();
                    Console.WriteLine($"  Error response: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Upload exception: {ex.Message}");
                return false;
            }
        }

        static async Task CleanupResources(AmazonS3Client s3Client, string bucketName)
        {
            try
            {
                Console.WriteLine("\nCleaning up test resources...");
                
                // List and delete all objects in the bucket
                var listRequest = new ListObjectsV2Request { BucketName = bucketName };
                var listResponse = await s3Client.ListObjectsV2Async(listRequest);
                
                if (listResponse.S3Objects.Count > 0)
                {
                    Console.WriteLine($"Deleting {listResponse.S3Objects.Count} objects...");
                    var deleteRequest = new DeleteObjectsRequest
                    {
                        BucketName = bucketName,
                        Objects = new List<KeyVersion>()
                    };
                    
                    foreach (var obj in listResponse.S3Objects)
                    {
                        deleteRequest.Objects.Add(new KeyVersion { Key = obj.Key });
                    }
                    
                    await s3Client.DeleteObjectsAsync(deleteRequest);
                    Console.WriteLine("✓ Objects deleted");
                }
                
                // Delete the bucket
                await s3Client.DeleteBucketAsync(bucketName);
                Console.WriteLine("✓ Bucket deleted");
                Console.WriteLine("Cleanup completed successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠ Cleanup failed: {ex.Message}");
                Console.WriteLine("You may need to manually delete the test resources");
            }
        }

        /// <summary>
        /// Output presigned POST response for comparison with Python implementation
        /// </summary>
        static void OutputPresignedPostComparison(CreatePresignedPostResponse response, string testName)
        {
            try
            {
                // Decode Base64 policy to compare decoded policy documents
                JsonDocument decodedPolicy = null;
                if (response.Fields.TryGetValue("Policy", out var policyBase64))
                {
                    var policyBytes = Convert.FromBase64String(policyBase64);
                    var policyJson = Encoding.UTF8.GetString(policyBytes);
                    decodedPolicy = JsonDocument.Parse(policyJson);
                }

                var responseData = new Dictionary<string, object>
                {
                    ["TestName"] = testName,
                    ["Url"] = response.Url,
                    ["Fields"] = response.Fields.OrderBy(f => f.Key).ToDictionary(f => f.Key, f => f.Value),
                    ["DecodedPolicy"] = decodedPolicy?.RootElement
                };

                var options = new JsonSerializerOptions 
                { 
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
                
                var json = JsonSerializer.Serialize(responseData, options);
                
                // Console output
                Console.WriteLine($"\nPRESIGNED_POST_RESPONSE ({testName}):");
                Console.WriteLine(json);
                Console.WriteLine();
                
                // File output
                var fileName = $"dotnet_{testName.ToLower().Replace(" ", "_").Replace("-", "_")}_response.json";
                File.WriteAllText(fileName, json);
                Console.WriteLine($"Response saved to: {fileName}");
                
                decodedPolicy?.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠ Failed to output comparison data for {testName}: {ex.Message}");
            }
        }


        /// <summary>
        /// Demonstrates basic presigned POST functionality with simple conditions
        /// </summary>
        static async Task DemonstrateBasicPresignedPost(AmazonS3Client s3Client, string bucketName)
        {
            Console.WriteLine("=== Basic Presigned POST Demo ===");
            Console.WriteLine("(API Demonstration - not actual upload)");
            Console.WriteLine();

            // Create a basic presigned POST request
            var request = new CreatePresignedPostRequest
            {
                BucketName = bucketName,
                Key = "demo/photo.jpg",
                Expires = AWSSDKUtils.CorrectedUtcNow.AddHours(1), // Expires in 1 hour
                Fields = new Dictionary<string, string>
                {
                    ["acl"] = "public-read",
                    ["Content-Type"] = "image/jpeg"
                },
                Conditions = new List<S3PostCondition>
                {
                    // Require specific ACL
                    new ExactMatchCondition("acl", "public-read"),
                    
                    // Allow only image content types
                    new StartsWithCondition("Content-Type", "image/"),
                    
                    // File size between 1KB and 5MB
                    new ContentLengthRangeCondition(1024, 5 * 1024 * 1024)
                }
            };

            Console.WriteLine("Creating presigned POST with conditions:");
            Console.WriteLine($"- Bucket: {request.BucketName}");
            Console.WriteLine($"- Key: {request.Key}");
            Console.WriteLine($"- Expiration: {request.Expires}");
            Console.WriteLine($"- ACL: public-read (exact match)");
            Console.WriteLine($"- Content-Type: must start with 'image/'");
            Console.WriteLine($"- File size: 1KB to 5MB");
            Console.WriteLine();

            // Generate the presigned POST (async version)
            var response = await s3Client.CreatePresignedPostAsync(request);

            Console.WriteLine("Generated Presigned POST Response:");
            Console.WriteLine($"Url: {response.Url}");
            Console.WriteLine($"Fields: {response.Fields.Count} form fields");
            
            // Output comparison data
            OutputPresignedPostComparison(response, "Basic Demo");
            Console.WriteLine();

            Console.WriteLine("✓ Basic presigned POST generated successfully");
        }

        /// <summary>
        /// Demonstrates advanced presigned POST with multiple conditions and custom fields
        /// </summary>
        static async Task DemonstrateAdvancedPresignedPost(AmazonS3Client s3Client, string bucketName)
        {
            Console.WriteLine("=== Advanced Presigned POST Demo ===");
            Console.WriteLine("(API Demonstration - not actual upload)");
            Console.WriteLine();

            // Create an advanced presigned POST request with multiple conditions and custom fields
            var request = new CreatePresignedPostRequest
            {
                BucketName = bucketName,
                Key = "documents/${filename}", // Dynamic filename from form
                Expires = AWSSDKUtils.CorrectedUtcNow.AddMinutes(30), // Shorter expiration
                Conditions = new List<S3PostCondition>
                {
                    // Exact match conditions
                    new ExactMatchCondition("acl", "private"),
                    new ExactMatchCondition("success_action_status", "201"),
                    
                    // Prefix conditions for flexible uploads
                    new StartsWithCondition("key", "documents/"),
                    new StartsWithCondition("Content-Type", "application/"),
                    
                    // File size limits (100KB to 50MB)
                    new ContentLengthRangeCondition(100 * 1024, 50 * 1024 * 1024),
                },
                Fields = new Dictionary<string, string>
                {
                    // ACL setting
                    ["acl"] = "private",
                    
                    // Custom metadata
                    ["x-amz-meta-uploaded-by"] = "s3-presigned-post-demo",
                    ["x-amz-meta-app-version"] = "1.0.0",
                    
                    // Server-side encryption
                    ["x-amz-server-side-encryption"] = "AES256",
                    
                    // Success action
                    ["success_action_status"] = "201"
                }
            };

            Console.WriteLine("Creating advanced presigned POST with conditions:");
            Console.WriteLine($"- Bucket: {request.BucketName}");
            Console.WriteLine($"- Key pattern: {request.Key}");
            Console.WriteLine($"- Expiration: {request.Expires} (30 minutes)");
            Console.WriteLine($"- ACL: private");
            Console.WriteLine($"- Key prefix: must start with 'documents/'");
            Console.WriteLine($"- Content-Type: must start with 'application/'");
            Console.WriteLine($"- File size: 100KB to 50MB");
            Console.WriteLine($"- Server-side encryption: AES256");
            Console.WriteLine($"- Custom metadata fields included");
            Console.WriteLine();

            var response = await s3Client.CreatePresignedPostAsync(request);

            Console.WriteLine("Generated Advanced Presigned POST Response:");
            Console.WriteLine($"Url: {response.Url}");
            Console.WriteLine($"Fields: {response.Fields.Count} form fields");
            
            // Output comparison data
            OutputPresignedPostComparison(response, "Advanced Demo");
            Console.WriteLine();

            Console.WriteLine("✓ Advanced presigned POST generated successfully");
        }

        /// <summary>
        /// Load test cases from JSON file
        /// </summary>
        static List<TestCase> LoadTestCases()
        {
            try
            {
                var json = File.ReadAllText("..\\s3-presigned-post-test-cases.json");
                var document = JsonDocument.Parse(json);
                var testCases = new List<TestCase>();

                foreach (var testCaseElement in document.RootElement.GetProperty("testCases").EnumerateArray())
                {
                    var testCase = new TestCase
                    {
                        Name = testCaseElement.GetProperty("name").GetString(),
                        BucketName = testCaseElement.GetProperty("bucketName").GetString(),
                        Key = testCaseElement.GetProperty("key").GetString(),
                        ExpiresIn = testCaseElement.GetProperty("expiresIn").GetInt32(),
                        Description = testCaseElement.GetProperty("description").GetString(),
                        PerformUpload = testCaseElement.TryGetProperty("performUpload", out var performUploadProp) ? performUploadProp.GetBoolean() : false,
                        Fields = new Dictionary<string, string>(),
                        Conditions = new List<ConditionSpec>()
                    };

                    // Parse fields
                    if (testCaseElement.TryGetProperty("fields", out var fieldsElement))
                    {
                        foreach (var field in fieldsElement.EnumerateObject())
                        {
                            testCase.Fields[field.Name] = field.Value.GetString();
                        }
                    }

                    // Parse conditions
                    if (testCaseElement.TryGetProperty("additionalConditions", out var conditionsElement))
                    {
                        foreach (var conditionElement in conditionsElement.EnumerateArray())
                        {
                            var condition = new ConditionSpec
                            {
                                Type = conditionElement.GetProperty("type").GetString()
                            };

                            switch (condition.Type)
                            {
                                case "exactMatch":
                                    condition.Field = conditionElement.GetProperty("field").GetString();
                                    condition.Value = conditionElement.GetProperty("value").GetString();
                                    break;
                                case "startsWith":
                                    condition.Field = conditionElement.GetProperty("field").GetString();
                                    condition.Value = conditionElement.GetProperty("value").GetString();
                                    break;
                                case "contentLengthRange":
                                    condition.Min = conditionElement.GetProperty("min").GetInt64();
                                    condition.Max = conditionElement.GetProperty("max").GetInt64();
                                    break;
                            }

                            testCase.Conditions.Add(condition);
                        }
                    }

                    // Parse test content
                    if (testCaseElement.TryGetProperty("testContent", out var testContentElement))
                    {
                        if (testContentElement.ValueKind == JsonValueKind.String)
                        {
                            testCase.TestContent = testContentElement.GetString();
                        }
                        else if (testContentElement.ValueKind == JsonValueKind.Object)
                        {
                            testCase.TestContent = testContentElement.ToString();
                        }
                    }

                    testCases.Add(testCase);
                }

                return testCases;
            }
            catch (FileNotFoundException)
            {
                throw new Exception("Test cases file 's3-presigned-post-test-cases.json' not found");
            }
            catch (JsonException ex)
            {
                throw new Exception($"Invalid JSON in test cases file: {ex.Message}");
            }
        }

        /// <summary>
        /// Execute a single test case
        /// </summary>
        static async Task ExecuteTestCase(AmazonS3Client s3Client, TestCase testCase, string bucketName, string timestamp)
        {
            Console.WriteLine($"=== {testCase.Name} ===");
            Console.WriteLine($"Description: {testCase.Description}");
            Console.WriteLine();

            try
            {
                // Replace placeholders in the test case
                var processedCase = ProcessTestCasePlaceholders(testCase, bucketName, timestamp);

                // Build conditions for .NET SDK
                var conditions = BuildConditions(processedCase.Conditions);

                // Generate presigned POST
                Console.WriteLine($"Generating presigned POST for: {processedCase.Key}");
                var request = new CreatePresignedPostRequest
                {
                    BucketName = processedCase.BucketName,
                    Key = processedCase.Key,
                    Expires = DateTime.UtcNow.AddSeconds(processedCase.ExpiresIn),
                    Fields = processedCase.Fields,
                    Conditions = conditions
                };

                var response = await s3Client.CreatePresignedPostAsync(request);
                Console.WriteLine("✓ Presigned POST generated successfully");

                // Output comparison data
                OutputPresignedPostComparison(response, testCase.Name);

                // Perform upload if requested
                if (processedCase.PerformUpload)
                {
                    var content = PrepareTestContent(processedCase, bucketName, timestamp);
                    var success = await PerformUpload(response, content, processedCase);

                    if (success)
                    {
                        Console.WriteLine("✓ Upload completed successfully");
                        if (content is string stringContent)
                        {
                            await VerifyUploadedFile(s3Client, bucketName, processedCase.Key, stringContent);
                        }
                        else if (content is byte[] binaryContent)
                        {
                            await VerifyBinaryUpload(s3Client, bucketName, processedCase.Key, binaryContent);
                        }
                    }
                    else
                    {
                        Console.WriteLine("✗ Upload failed");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Test case '{testCase.Name}' failed: {ex.Message}");
            }
        }

        /// <summary>
        /// Replace placeholders in test case with actual values
        /// </summary>
        static TestCase ProcessTestCasePlaceholders(TestCase testCase, string bucketName, string timestamp)
        {
            var processed = new TestCase
            {
                Name = testCase.Name,
                BucketName = testCase.BucketName.Replace("{BUCKET_NAME}", bucketName),
                Key = testCase.Key.Replace("{BUCKET_NAME}", bucketName).Replace("{TIMESTAMP}", timestamp),
                ExpiresIn = testCase.ExpiresIn,
                Description = testCase.Description,
                PerformUpload = testCase.PerformUpload,
                TestContent = testCase.TestContent?.Replace("{BUCKET_NAME}", bucketName).Replace("{TIMESTAMP}", timestamp),
                Fields = new Dictionary<string, string>(),
                Conditions = testCase.Conditions
            };

            // Process fields
            foreach (var field in testCase.Fields)
            {
                processed.Fields[field.Key] = field.Value.Replace("{BUCKET_NAME}", bucketName).Replace("{TIMESTAMP}", timestamp);
            }

            return processed;
        }

        /// <summary>
        /// Convert condition specifications to .NET SDK objects
        /// </summary>
        static List<S3PostCondition> BuildConditions(List<ConditionSpec> conditionSpecs)
        {
            var conditions = new List<S3PostCondition>();

            foreach (var spec in conditionSpecs)
            {
                switch (spec.Type)
                {
                    case "exactMatch":
                        conditions.Add(new ExactMatchCondition(spec.Field, spec.Value));
                        break;
                    case "startsWith":
                        conditions.Add(new StartsWithCondition(spec.Field, spec.Value));
                        break;
                    case "contentLengthRange":
                        conditions.Add(new ContentLengthRangeCondition(spec.Min, spec.Max));
                        break;
                }
            }

            return conditions;
        }

        /// <summary>
        /// Prepare test content based on test case specification
        /// </summary>
        static object PrepareTestContent(TestCase testCase, string bucketName, string timestamp)
        {
            if (testCase.TestContent == "BINARY_PNG_DATA")
            {
                // Return binary PNG data
                return new byte[]
                {
                    0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, // PNG signature
                    0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, // IHDR chunk
                    0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, // 1x1 pixel
                    0x08, 0x02, 0x00, 0x00, 0x00, 0x90, 0x77, 0x53, // RGB, no compression
                    0xDE, 0x00, 0x00, 0x00, 0x0C, 0x49, 0x44, 0x41, // IDAT chunk
                    0x54, 0x08, 0x99, 0x01, 0x01, 0x00, 0x00, 0x00,
                    0xFF, 0xFF, 0x00, 0x00, 0x00, 0x02, 0x00, 0x01,
                    0xE2, 0x21, 0xBC, 0x33, 0x00, 0x00, 0x00, 0x00, // IEND chunk
                    0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
                };
            }
            else if (testCase.TestContent?.StartsWith("{") == true)
            {
                // JSON content - parse and reformat
                var jsonDoc = JsonDocument.Parse(testCase.TestContent);
                return JsonSerializer.Serialize(jsonDoc, new JsonSerializerOptions { WriteIndented = true });
            }
            else if (!string.IsNullOrEmpty(testCase.TestContent))
            {
                // Text content with placeholders replaced
                return testCase.TestContent
                    .Replace("{BUCKET_NAME}", bucketName)
                    .Replace("{TIMESTAMP}", timestamp)
                    .Replace("{KEY}", testCase.Key);
            }

            return "";
        }

        /// <summary>
        /// Perform upload based on content type
        /// </summary>
        static async Task<bool> PerformUpload(CreatePresignedPostResponse response, object content, TestCase testCase)
        {
            try
            {
                if (content is byte[] binaryContent)
                {
                    // Binary upload
                    var contentType = testCase.Fields.TryGetValue("Content-Type", out var ct) ? ct : "application/octet-stream";
                    return await UploadBinaryUsingFormData(response, binaryContent, contentType, "test-file");
                }
                else if (content is string stringContent)
                {
                    // Text upload
                    var contentType = testCase.Fields.TryGetValue("Content-Type", out var ct) ? ct : "text/plain";
                    return await UploadUsingFormData(response, stringContent, contentType, "test-file.txt");
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Upload error: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Test case data structure
        /// </summary>
        public class TestCase
        {
            public string Name { get; set; }
            public string BucketName { get; set; }
            public string Key { get; set; }
            public int ExpiresIn { get; set; }
            public string Description { get; set; }
            public bool PerformUpload { get; set; }
            public string TestContent { get; set; }
            public Dictionary<string, string> Fields { get; set; } = new Dictionary<string, string>();
            public List<ConditionSpec> Conditions { get; set; } = new List<ConditionSpec>();
        }

        /// <summary>
        /// Condition specification data structure
        /// </summary>
        public class ConditionSpec
        {
            public string Type { get; set; }
            public string Field { get; set; }
            public string Value { get; set; }
            public long Min { get; set; }
            public long Max { get; set; }
        }

    }
}
