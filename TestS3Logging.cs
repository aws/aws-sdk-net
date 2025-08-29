using System;
using System.IO;
using System.Text;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.Runtime.Internal.Util;

namespace TestS3Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Testing SigV4 to SigV2 Downgrade Logging ===\n");
            
            // Capture console output to verify logging
            var originalOut = Console.Out;
            var stringWriter = new StringWriter();
            var multiWriter = new MultiTextWriter(originalOut, stringWriter);
            Console.SetOut(multiWriter);
            
            // Configure logging to console
            AWSConfigs.LoggingConfig.LogTo = LoggingOptions.Console;
            AWSConfigs.LoggingConfig.LogMetrics = true;
            AWSConfigs.LoggingConfig.LogResponses = ResponseLoggingOption.Always;
            
            try
            {
                Console.WriteLine("Test 1: SigV4 to SigV2 downgrade in supported region (us-east-1)");
                TestDowngradeInSupportedRegion();
                
                Console.WriteLine("\nTest 2: Exception in unsupported region (eu-north-1)");
                TestExceptionInUnsupportedRegion();
                
                // Check if our logging message appeared
                var output = stringWriter.ToString();
                if (output.Contains("Presigned URL expiration") && 
                    output.Contains("exceeds SigV4 maximum") &&
                    output.Contains("Automatically using SigV2"))
                {
                    Console.WriteLine("\n✅ SUCCESS: Logging message found in output!");
                }
                else
                {
                    Console.WriteLine("\n❌ FAILURE: Expected logging message not found");
                    Console.WriteLine("Captured output:");
                    Console.WriteLine(output);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Test failed with exception: {ex.Message}");
            }
            finally
            {
                Console.SetOut(originalOut);
                stringWriter.Dispose();
            }
            
            Console.WriteLine("\n=== Test completed ===");
        }
        
        static void TestDowngradeInSupportedRegion()
        {
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1, // Supports SigV2
                UseHttp = true // Use HTTP to avoid SSL issues
            };

            using (var client = new AmazonS3Client("test-access-key", "test-secret-key", config))
            {
                var request = new GetPreSignedUrlRequest
                {
                    BucketName = "test-bucket",
                    Key = "test-key",
                    Verb = HttpVerb.GET,
                    Expires = DateTime.UtcNow.AddDays(8) // Exceeds SigV4 limit
                };

                var presignedUrl = client.GetPreSignedURL(request);
                
                Console.WriteLine($"Generated URL: {presignedUrl.Substring(0, Math.Min(100, presignedUrl.Length))}...");
                
                // Verify SigV2 signature format
                if (presignedUrl.Contains("Signature="))
                {
                    Console.WriteLine("✅ URL contains SigV2 Signature parameter");
                }
                else
                {
                    Console.WriteLine("❌ URL missing SigV2 Signature parameter");
                }
                
                if (!presignedUrl.Contains("X-Amz-Signature"))
                {
                    Console.WriteLine("✅ URL does not contain SigV4 X-Amz-Signature parameter");
                }
                else
                {
                    Console.WriteLine("❌ URL contains SigV4 signature (downgrade failed)");
                }
            }
        }
        
        static void TestExceptionInUnsupportedRegion()
        {
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.EUNorth1, // Does not support SigV2
                UseHttp = true
            };

            using (var client = new AmazonS3Client("test-access-key", "test-secret-key", config))
            {
                var request = new GetPreSignedUrlRequest
                {
                    BucketName = "test-bucket",
                    Key = "test-key",
                    Verb = HttpVerb.GET,
                    Expires = DateTime.UtcNow.AddDays(8) // Exceeds SigV4 limit
                };

                try
                {
                    var presignedUrl = client.GetPreSignedURL(request);
                    Console.WriteLine("❌ Expected exception but URL was generated");
                }
                catch (ArgumentException ex)
                {
                    if (ex.Message.Contains("604800 seconds") || 
                        ex.Message.Contains("7 days") ||
                        ex.Message.Contains("AWS4 signing"))
                    {
                        Console.WriteLine("✅ Expected exception thrown with correct message");
                    }
                    else
                    {
                        Console.WriteLine($"❌ Exception thrown but with unexpected message: {ex.Message}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Unexpected exception type: {ex.GetType().Name}: {ex.Message}");
                }
            }
        }
    }
    
    // Helper class to write to multiple TextWriters
    public class MultiTextWriter : TextWriter
    {
        private readonly TextWriter[] writers;
        
        public MultiTextWriter(params TextWriter[] writers)
        {
            this.writers = writers;
        }
        
        public override Encoding Encoding => Encoding.UTF8;
        
        public override void Write(char value)
        {
            foreach (var writer in writers)
                writer.Write(value);
        }
        
        public override void Write(string value)
        {
            foreach (var writer in writers)
                writer.Write(value);
        }
        
        public override void WriteLine(string value)
        {
            foreach (var writer in writers)
                writer.WriteLine(value);
        }
    }
}
