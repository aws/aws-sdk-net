using System;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.Runtime.Internal.Util;

namespace TestLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing SigV4 to SigV2 downgrade logging...");
            
            // Configure logging to console
            AWSConfigs.LoggingConfig.LogTo = LoggingOptions.Console;
            AWSConfigs.LoggingConfig.LogMetrics = true;
            AWSConfigs.LoggingConfig.LogResponses = ResponseLoggingOption.Always;
            AWSConfigs.LoggingConfig.LogResponsesSizeLimit = 4096;
            
            try
            {
                // Create S3 client with a region that supports SigV2 (us-east-1)
                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USEast1,
                    UseHttp = true // Use HTTP to avoid SSL issues in test
                };

                using (var client = new AmazonS3Client("test-access-key", "test-secret-key", config))
                {
                    Console.WriteLine("Creating presigned URL with 8-day expiration (exceeds SigV4 limit)...");
                    
                    // Create a presigned URL request with expiration > 7 days (SigV4 limit)
                    var request = new GetPreSignedUrlRequest
                    {
                        BucketName = "test-bucket",
                        Key = "test-key",
                        Verb = HttpVerb.GET,
                        Expires = DateTime.UtcNow.AddDays(8) // Exceeds SigV4 limit
                    };

                    // Generate presigned URL (this should trigger the downgrade and logging)
                    var presignedUrl = client.GetPreSignedURL(request);

                    Console.WriteLine($"Generated presigned URL: {presignedUrl}");
                    
                    // Verify the URL contains SigV2 signature parameters
                    if (presignedUrl.Contains("Signature="))
                    {
                        Console.WriteLine("✓ SUCCESS: URL contains SigV2 Signature parameter");
                    }
                    else
                    {
                        Console.WriteLine("✗ FAILURE: URL does not contain expected SigV2 signature");
                    }
                    
                    if (!presignedUrl.Contains("X-Amz-Signature"))
                    {
                        Console.WriteLine("✓ SUCCESS: URL does not contain SigV4 X-Amz-Signature parameter");
                    }
                    else
                    {
                        Console.WriteLine("✗ FAILURE: URL contains SigV4 signature (downgrade did not occur)");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
            Console.WriteLine("\nTest completed. Check the log output above for the downgrade message.");
        }
    }
}
