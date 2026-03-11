using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class TransferUtilityTests : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);
        public static readonly long KILO_SIZE = (int)Math.Pow(2, 10);
        public static readonly string BasePath = @"c:\temp\test\transferutility\";

        private static string bucketName;
        private static string ssecBucketName;
        private static string octetStreamContentType = "application/octet-stream";
        private static string plainTextContentType = "text/plain";
        private static string fullPath;

        private const string testContent = "This is the content body!";
        private const string testFile = "PutObjectFile.txt";

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext a)
        {
            // Create standard bucket for operations
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);

            // Create a bucket specifically for the SSE-C tests as a bucket policy has to be set on it to require SSE-C.
            ssecBucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);

            // Apply the bucket policy to SSE-C: https://docs.aws.amazon.com/AmazonS3/latest/userguide/ServerSideEncryptionCustomerKeys.html
            await Client.PutBucketPolicyAsync(new PutBucketPolicyRequest
            {
                Policy =
                @"{
                    ""Version"": ""2012-10-17"",
                    ""Id"": ""PutObjectPolicy"",
                    ""Statement"": [
                        {
                            ""Sid"": ""RequireSSECObjectUploads"",
                            ""Effect"": ""Deny"",
                            ""Principal"": ""*"",
                            ""Action"": ""s3:PutObject"",
                            ""Resource"": ""arn:aws:s3:::" + ssecBucketName + @"/*"",
                            ""Condition"": {
                                ""Null"": {
                                    ""s3:x-amz-server-side-encryption-customer-algorithm"": ""true""
                                }
                            }
                        }
                    ]
                }",
                BucketName = ssecBucketName
            });

            fullPath = Path.GetFullPath(testFile);
            File.WriteAllText(fullPath, testContent);
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await Task.WhenAll(
                AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName),
                AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, ssecBucketName)
            );
            
            BaseClean();
            if (Directory.Exists(BasePath))
            {
                Directory.Delete(BasePath, true);
            }
        }

        [TestMethod]
        public async Task SimpleUploadTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\SmallFile");
            await Upload(fileName, 10 * MEG_SIZE, null);
        }

        [TestMethod]
        public async Task SimpleUploadProgressTest()
        {
            var context = SynchronizationContext.Current;
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\SmallFile");
            var progressValidator = new TransferProgressValidator<UploadProgressArgs>
            {
                Validate = (p) =>
                {
                    Assert.AreEqual(p.FilePath, Path.Combine(BasePath, fileName));
                }
            };

            await Upload(fileName, 10 * MEG_SIZE, progressValidator);
            progressValidator.AssertOnCompletion();
        }

        [TestMethod]
        public async Task SimpleUploadInitiatedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\InitiatedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsTrue(args.TotalBytes > 0);
                    Assert.AreEqual(10 * MEG_SIZE, args.TotalBytes);
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName));
                }
            };

            await UploadWithLifecycleEvents(fileName, 10 * MEG_SIZE, eventValidator, null, null);
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task SimpleUploadCompletedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\CompletedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Response);
                    Assert.AreEqual(args.TransferredBytes, args.TotalBytes);
                    Assert.AreEqual(10 * MEG_SIZE, args.TotalBytes);
                    Assert.IsTrue(!string.IsNullOrEmpty(args.Response.ETag));
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName));
                }
            };

            await UploadWithLifecycleEvents(fileName, 10 * MEG_SIZE, null, eventValidator, null);
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task SimpleUploadFailedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\FailedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadFailedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsTrue(args.TotalBytes > 0);
                    Assert.AreEqual(5 * MEG_SIZE, args.TotalBytes);
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName));
                    // For failed uploads, transferred bytes should be less than or equal to total bytes
                    Assert.IsTrue(args.TransferredBytes <= args.TotalBytes);
                }
            };
            
            // Use invalid bucket name to force failure
            var invalidBucketName = "invalid-bucket-name-" + Guid.NewGuid().ToString();
            
            try
            {
                await UploadWithLifecycleEventsAndBucket(fileName, 5 * MEG_SIZE, invalidBucketName, null, null, eventValidator);
                Assert.Fail("Expected an exception to be thrown for invalid bucket");
            }
            catch (AmazonS3Exception)
            {
                // Expected exception - the failed event should have been fired
                eventValidator.AssertEventFired();
            }
        }

        [TestMethod]
        public async Task SimpleUploadCompleteLifecycleTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\CompleteLifecycle");
            var initiatedValidator = new TransferLifecycleEventValidator<UploadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.AreEqual(8 * MEG_SIZE, args.TotalBytes);
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName));
                }
            };
            
            var completedValidator = new TransferLifecycleEventValidator<UploadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Response);
                    Assert.AreEqual(args.TransferredBytes, args.TotalBytes);
                    Assert.AreEqual(8 * MEG_SIZE, args.TotalBytes);
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName));
                }
            };

            await UploadWithLifecycleEvents(fileName, 8 * MEG_SIZE, initiatedValidator, completedValidator, null);
            initiatedValidator.AssertEventFired();
            completedValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task SimpleUpload()
        {
            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.UploadAsync(fullPath, bucketName);
                var response = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = testFile
                });
                Assert.IsTrue(response.ETag.Length > 0);

                var downloadPath = fullPath + ".download";
                var downloadRequest = new TransferUtilityDownloadRequest
                {
                    BucketName = bucketName,
                    Key = testFile,
                    FilePath = downloadPath
                };
                await transferUtility.DownloadAsync(downloadRequest);
                TestDownloadedFile(downloadPath);

                // empty out file, except for 1 byte
                File.WriteAllText(downloadPath, testContent.Substring(0, 1));
                Assert.IsTrue(File.Exists(downloadPath));

                await transferUtility.DownloadAsync(downloadRequest);
                TestDownloadedFile(downloadPath);
            }
        }

        [TestMethod]
        public async Task SimpleUploadWithPrecalculatedChecksum()
        {
            // If a pre-calculated checksum is provided for a file uploaded in a single PutObject call,
            // the TransferUtility will set the appropriate header (i.e. x-amz-checksum-<algorithm_name>).
            // An invalid header exception would be thrown if the value does not match the checksum calculated by S3.
            var precalculatedChecksum = CryptoUtilFactory.CryptoInstance.ComputeCRC32Hash(File.ReadAllBytes(fullPath));

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.UploadAsync(new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    Key = testFile,
                    FilePath = fullPath,
                    ChecksumCRC32 = precalculatedChecksum,
                });
            }
        }

        [TestMethod]
        public async Task LargeUploadWithPrecalculatedValues()
        {
            var fileName = UtilityMethods.GenerateName();
            var fullFilePath = Path.Combine(BasePath, fileName);
            UtilityMethods.GenerateFile(fullFilePath, 20 * MEG_SIZE);

            // If a pre-calculated checksum is provided for a file uploaded via multi-part uploads, the TransferUtility
            // will set both the appropriate header (i.e. x-amz-checksum-<algorithm_name>) and the checksum type to full object.
            // An invalid header exception would be thrown if the value does not match the checksum calculated by S3.
            var precalculatedChecksum = CryptoUtilFactory.CryptoInstance.ComputeCRC32CHash(File.ReadAllBytes(fullFilePath));

            // For multi-part uploads only, the size of the object can also be specified.
            // Another invalid header exception would be thrown if the value does not match the size calculated by S3.
            var precalculatedObjectSize = new FileInfo(fullFilePath).Length;

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.UploadAsync(new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    Key = fileName,
                    FilePath = fullFilePath,
                    ChecksumCRC32C = precalculatedChecksum,
                    MpuObjectSize = precalculatedObjectSize,
                });
            }
        }

        [DataTestMethod]
        [DataRow(20, null, "SmallFile", false, false)]
        [DataRow(4, null, "SmallerThanMinPart", false, false)]
        [DataRow(5, null, "EqualToMinPartSize", false, false)]
        [DataRow(5, 8192, "EqualToPartBufferSize", false, false)]
        [DataRow(5, 1, "BetweenMinPartSizeAndPartBufferSize", false, false)]
        [DataRow(0, null, "EmptyFileFromDisk", false, false)]
        [DataRow(0, null, "EmptyStreamDirect", false, true)]
        [DataRow(20, null, "WithMetadataAndHeaders", true, false)]
        public async Task UploadUnseekableStreamTest(long sizeInMbs, int? padding, string name, bool includeHeaders, bool useZeroLengthConstructor)
        {
            var fileName = UtilityMethods.GenerateName(name);
            var path = Path.Combine(BasePath, fileName);

            var fileSize = sizeInMbs * MEG_SIZE;
            if (padding.HasValue)
            {
                fileSize += padding.Value;
            }

            Stream stream;
            if (useZeroLengthConstructor)
            {
                stream = new UnseekableStream(setZeroLengthStream: true);
            }
            else
            {
                UtilityMethods.GenerateFile(path, fileSize);
                stream = GenerateUnseekableStreamFromFile(path);
            }

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = fileName,
                InputStream = stream,

                // This test makes the assumption that the part size is 5MB, but the default value in the
                // request was changed (to 8MB) in order to match the other SDKs.
                PartSize = 5 * MEG_SIZE,
            };

            if (includeHeaders)
            {
                uploadRequest.Metadata.Add("testmetadata", "testmetadatavalue");
                uploadRequest.Headers["Content-Disposition"] = "attachment; filename=\"" + fileName + "\"";
            }

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.UploadAsync(uploadRequest);

                var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = fileName
                });
                Assert.AreEqual(fileSize, metadata.ContentLength);

                if (includeHeaders)
                {
                    Assert.IsTrue(metadata.Metadata.Count > 0);
                    Assert.AreEqual("testmetadatavalue", metadata.Metadata["testmetadata"]);
                    Assert.IsTrue(metadata.Headers.Count > 0);
                    Assert.AreEqual("attachment; filename=\"" + fileName + "\"", metadata.Headers["Content-Disposition"]);
                }

                if (fileSize > 0)
                {
                    // Download the file and validate content of downloaded file is equal.
                    var downloadPath = path + ".download";
                    await transferUtility.DownloadAsync(new TransferUtilityDownloadRequest
                    {
                        BucketName = bucketName,
                        Key = fileName,
                        FilePath = downloadPath
                    });
                    UtilityMethods.CompareFiles(path, downloadPath);
                }
            }
        }

        [TestMethod]
        public async Task SimpleUploadProgressTotalBytesTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadProgressTotalBytes\TestFile");
            var filePath = Path.Combine(BasePath, fileName);
            var fileSize = 10 * MEG_SIZE;
            UtilityMethods.GenerateFile(filePath, fileSize);

            var progressValidator = new TransferProgressValidator<UploadProgressArgs>
            {
                Validate = (progress) =>
                {
                    Assert.IsTrue(progress.TotalBytes > 0, "TotalBytes should be greater than 0");
                    Assert.AreEqual(fileSize, progress.TotalBytes, "TotalBytes should equal file size");
                    Assert.AreEqual(filePath, progress.FilePath, "FilePath should match expected path");
                }
            };

            var transferConfig = new TransferUtilityConfig
            {
                MinSizeBeforePartUpload = 20 * MEG_SIZE,
            };

            using (var fileTransferUtility = new TransferUtility(Client, transferConfig))
            {
                var request = new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    FilePath = filePath,
                    Key = fileName
                };

                request.UploadProgressEvent += progressValidator.OnProgressEvent;
                await fileTransferUtility.UploadAsync(request);
                progressValidator.AssertOnCompletion();
            }
        }

        private UnseekableStream GenerateUnseekableStreamFromFile(string filePath)
        {
            try
            {
                var fileBytes = File.ReadAllBytes(filePath);
                return new UnseekableStream(fileBytes)
                {
                    Position = 0
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while generating the stream: {ex.Message}");
                throw;
            }
        }

        private async Task UploadWithSSE_C(long fileSize, string name)
        {
            // Create a fileSize file to upload
            var fileName = UtilityMethods.GenerateName(name);
            var fullFilePath = Path.Combine(BasePath, fileName);
            UtilityMethods.GenerateFile(fullFilePath, fileSize);

            // Create an encryption key                
            Aes aesEncryption = Aes.Create();
            aesEncryption.KeySize = 256;
            aesEncryption.GenerateKey();
            string base64Key = Convert.ToBase64String(aesEncryption.Key);

            using (var transferUtility = new TransferUtility(Client))
            {
                // Upload the file. A permission denied exception would be thrown if an incorrect request is made
                // missing the required ServerSideEncryptionCustomerMethod and ServerSideEncryptionCustomerProvidedKey
                // values.
                await transferUtility.UploadAsync(new TransferUtilityUploadRequest
                {
                    BucketName = ssecBucketName,
                    FilePath = fullFilePath,
                    Key = fileName,
                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = base64Key
                });
            }
        }

        [TestMethod]
        public async Task SimpleUploadWithSSE_C_SmallFile()
        {
            await UploadWithSSE_C(KILO_SIZE, @"SimpleUploadTest\SmallFile");
        }

        [TestMethod]
        public async Task SimpleUploadWithSSE_C_LargeFile()
        {
            await UploadWithSSE_C(16 * MEG_SIZE, @"SimpleUploadTest\LargeFile");
        }

        [TestMethod]
        public async Task DirectoryUploadDonwloadWithSSE_C()
        {
            var directoryTest = CreateTestDirectory();
            var directoryTestPath = directoryTest.FullName;
            var remoteDirectory = directoryTest.Name;

            // Create an encryption key
            Aes aesEncryption = Aes.Create();
            aesEncryption.KeySize = 256;
            aesEncryption.GenerateKey();
            string base64Key = Convert.ToBase64String(aesEncryption.Key);

            var downloadPath = GenerateDirectoryPath();
            using (var transferUtility = new TransferUtility(Client))
            {
                // Upload test directory with SSE-C
                await transferUtility.UploadDirectoryAsync(new TransferUtilityUploadDirectoryRequest
                {
                    BucketName = bucketName,
                    Directory = directoryTestPath,
                    KeyPrefix = remoteDirectory,
                    SearchPattern = "*",
                    SearchOption = SearchOption.AllDirectories,
                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = base64Key
                });

                // Download remote test directory with SSE-C
                await transferUtility.DownloadDirectoryAsync(new TransferUtilityDownloadDirectoryRequest
                {
                    BucketName = bucketName,
                    S3Directory = remoteDirectory,
                    LocalDirectory = downloadPath,
                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = base64Key
                });
            }

            // Compare each file in both directories
            var sourceFiles = Directory.EnumerateFiles(directoryTestPath, "*", SearchOption.AllDirectories).ToList();
            var downloadedFiles = Directory.EnumerateFiles(downloadPath, "*", SearchOption.AllDirectories).ToList();
            Assert.AreEqual(sourceFiles.Count, downloadedFiles.Count);

            sourceFiles.Sort();
            downloadedFiles.Sort();
            for (var i = 0; i < sourceFiles.Count(); i++)
            {
                UtilityMethods.CompareFiles(sourceFiles[i], downloadedFiles[i]);
            }
        }

        private void TestDownloadedFile(string downloadPath)
        {
            var fileExists = File.Exists(downloadPath);
            Assert.IsTrue(fileExists);
            var fileContent = File.ReadAllText(downloadPath);
            Assert.AreEqual(testContent, fileContent);
        }

        [TestMethod]
        public async Task MultipartUploadProgressTest()
        {
            // disable clock skew testing, this is a multithreaded test
            using (RetryUtilities.DisableClockSkewCorrection())
            {
                var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\File");
                var progressValidator = new TransferProgressValidator<UploadProgressArgs>
                {
                    ValidateProgressInterval = false,
                    Validate = (p) =>
                    {
                        Assert.AreEqual(p.FilePath, Path.Combine(BasePath, fileName));
                    }
                };

                await Upload(fileName, 20 * MEG_SIZE, progressValidator);
                progressValidator.AssertOnCompletion();
            }
        }

        [TestMethod]
        public async Task MultipartUploadInitiatedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\InitiatedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsTrue(args.TotalBytes > 0);
                    Assert.AreEqual(20 * MEG_SIZE, args.TotalBytes);
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName));
                }
            };

            // Use 20MB+ to trigger multipart upload
            await UploadWithLifecycleEvents(fileName, 20 * MEG_SIZE, eventValidator, null, null);
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task MultipartUploadCompletedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\CompletedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Response);
                    Assert.AreEqual(args.TransferredBytes, args.TotalBytes);
                    Assert.AreEqual(25 * MEG_SIZE, args.TotalBytes);
                    Assert.IsTrue(!string.IsNullOrEmpty(args.Response.ETag));
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName));
                }
            };

            // Use 25MB to trigger multipart upload
            await UploadWithLifecycleEvents(fileName, 25 * MEG_SIZE, null, eventValidator, null);
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task MultipartUploadFailedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\FailedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadFailedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsTrue(args.TotalBytes > 0);
                    Assert.AreEqual(22 * MEG_SIZE, args.TotalBytes);
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName));
                    // For failed uploads, transferred bytes should be less than or equal to total bytes
                    Assert.IsTrue(args.TransferredBytes <= args.TotalBytes);
                }
            };
            
            // Use invalid bucket name to force failure with multipart upload size
            var invalidBucketName = "invalid-bucket-name-" + Guid.NewGuid().ToString();
            
            try
            {
                // Use 22MB to trigger multipart upload
                await UploadWithLifecycleEventsAndBucket(fileName, 22 * MEG_SIZE, invalidBucketName, null, null, eventValidator);
                Assert.Fail("Expected an exception to be thrown for invalid bucket");
            }
            catch (AmazonS3Exception)
            {
                // Expected exception - the failed event should have been fired
                eventValidator.AssertEventFired();
            }
        }

        [TestMethod]
        public async Task MultipartUploadCompleteLifecycleTest()
        {
            var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\CompleteLifecycle");
            var initiatedValidator = new TransferLifecycleEventValidator<UploadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.AreEqual(30 * MEG_SIZE, args.TotalBytes);
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName));
                }
            };
            
            var completedValidator = new TransferLifecycleEventValidator<UploadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Response);
                    Assert.AreEqual(args.TransferredBytes, args.TotalBytes);
                    Assert.AreEqual(30 * MEG_SIZE, args.TotalBytes);
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName));
                }
            };

            // Use 30MB to trigger multipart upload
            await UploadWithLifecycleEvents(fileName, 30 * MEG_SIZE, initiatedValidator, completedValidator, null);
            initiatedValidator.AssertEventFired();
            completedValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task MultipartUploadUnseekableStreamInitiatedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\UnseekableStreamInitiatedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.AreEqual(-1, args.TotalBytes); // Unseekable streams have unknown length
                }
            };

            await UploadUnseekableStreamWithLifecycleEvents(20 * MEG_SIZE, eventValidator, null, null);
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task MultipartUploadUnseekableStreamCompletedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<UploadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Response);
                    Assert.AreEqual(-1, args.TotalBytes); // Unseekable streams have unknown length
                    Assert.AreEqual(0, args.TransferredBytes); // unseekable streams we dont attach and progress listeners so we wont have transferredbytes.
                }
            };

            await UploadUnseekableStreamWithLifecycleEvents(20 * MEG_SIZE, null, eventValidator, null);
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task MultipartUploadUnseekableStreamFailedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<UploadFailedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.AreEqual(-1, args.TotalBytes); // Unseekable streams have unknown length
                }
            };
            
            // Use invalid bucket name to force failure with multipart upload size
            var invalidBucketName = "invalid-bucket-name-" + Guid.NewGuid().ToString();
            
            try
            {
                await UploadUnseekableStreamWithLifecycleEventsAndBucket(20 * MEG_SIZE, invalidBucketName, null, null, eventValidator);
                Assert.Fail("Expected an exception to be thrown for invalid bucket");
            }
            catch (AmazonS3Exception)
            {
                // Expected exception - the failed event should have been fired
                eventValidator.AssertEventFired();
            }
        }

        [TestMethod]
        public async Task MultipartUploadUnseekableStreamCompleteLifecycleTest()
        {            
            var initiatedValidator = new TransferLifecycleEventValidator<UploadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.AreEqual(-1, args.TotalBytes); // Unseekable streams have unknown length
                }
            };
            
            var completedValidator = new TransferLifecycleEventValidator<UploadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Response);
                    Assert.AreEqual(-1, args.TotalBytes); // Unseekable streams have unknown length
                    Assert.AreEqual(0, args.TransferredBytes); // unseekable streams we dont attach and progress listeners so we wont have transferredbytes.
                }
            };

            await UploadUnseekableStreamWithLifecycleEvents(18 * MEG_SIZE, initiatedValidator, completedValidator, null);
            initiatedValidator.AssertEventFired();
            completedValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task MultipartGetNumberTest()
        {
            string key = "SomeTest";
            await Upload(key, 20 * MEG_SIZE, null);

            try
            {
                var objectMetadataResponse = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    PartNumber = 1,
                });
                Assert.IsTrue(objectMetadataResponse.PartsCount > 1);

                int? count = objectMetadataResponse.PartsCount;
                for (int i = 1; i <= count; i++)
                {
                    var objectResponse = await Client.GetObjectAsync(new GetObjectRequest
                    {
                        BucketName = bucketName,
                        Key = key,
                        PartNumber = i
                    });
                    Assert.AreEqual(objectResponse.PartsCount, count);
                }
            }
            finally
            {
                await Client.DeleteObjectAsync(new DeleteObjectRequest
                {
                    BucketName = bucketName,
                    Key = key
                });
            }
        }

        [TestMethod]
        public async Task MultipartValidatePartSize8MbTest()
        {
            string key = "MultipartValidatePartSizeTest";
            await Upload(key, 20 * MEG_SIZE, null);
            
            var objectMetadataResponse = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key,
                PartNumber = 1,
            });
            Assert.AreEqual(3, objectMetadataResponse.PartsCount);
            Assert.AreEqual(8 * MEG_SIZE, objectMetadataResponse.ContentLength);
        }

        async Task Upload(string fileName, long size, TransferProgressValidator<UploadProgressArgs> progressValidator)
        {
            var key = fileName;
            await Client.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = key
            });

            var path = Path.Combine(BasePath, fileName);
            UtilityMethods.GenerateFile(path, size);

            var request = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                FilePath = path,
                Key = key,
                ContentType = octetStreamContentType
            };

            if (progressValidator != null)
            {
                request.UploadProgressEvent += progressValidator.OnProgressEvent;
            }

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.UploadAsync(request);
            }

            var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });
            Assert.AreEqual(octetStreamContentType, metadata.Headers.ContentType);
            Assert.AreEqual(size, metadata.ContentLength);
            await ValidateFileContents(bucketName, key, path);
        }

        [TestMethod]
        public async Task UploadDirectoryWithProgressTracker()
        {
            var progressValidator = new DirectoryProgressValidator<UploadDirectoryProgressArgs>();
            ConfigureProgressValidator(progressValidator);

            await UploadDirectory(10 * MEG_SIZE, progressValidator, true);
            progressValidator.AssertOnCompletion();
        }

        async Task<DirectoryInfo> UploadDirectory(long size,
             DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator, bool validate = true)
        {
            var directory = CreateTestDirectory(size);
            var keyPrefix = directory.Name;
            var directoryPath = directory.FullName;

            var concurrentTu = new TransferUtility(Client, new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10,
            });

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directoryPath,
                KeyPrefix = keyPrefix,
                ContentType = plainTextContentType,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
            };

            if (progressValidator != null)
            {
                request.UploadDirectoryProgressEvent += progressValidator.OnProgressEvent;
            }

            HashSet<string> files = new HashSet<string>();
            request.UploadDirectoryProgressEvent += (s, e) =>
            {
                files.Add(e.CurrentFile);
                Console.WriteLine("Progress callback = " + e.ToString());
            };

            await concurrentTu.UploadDirectoryAsync(request);
            Assert.AreEqual(5, files.Count);

            if (validate)
            {
                await ValidateDirectoryContents(bucketName, keyPrefix, directory, plainTextContentType);
            }

            return directory;
        }

        [TestMethod]
        public async Task DownloadNonExistentS3Directory()
        {
            var downloadPath = GenerateDirectoryPath();
            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.DownloadDirectoryAsync(new TransferUtilityDownloadDirectoryRequest
                {
                    BucketName = bucketName,
                    S3Directory = "NonExistentS3Directory",
                    LocalDirectory = downloadPath,
                });
            }

            var downloadedFiles = Directory.EnumerateFiles(downloadPath, "*", SearchOption.AllDirectories).ToList();
            Assert.AreEqual(0, downloadedFiles.Count);
        }

        [TestMethod]
        public async Task DownloadDirectoryProgressTest()
        {
            // disable clock skew testing, this is a multithreaded test
            using (RetryUtilities.DisableClockSkewCorrection())
            {
                var progressValidator = new DirectoryProgressValidator<DownloadDirectoryProgressArgs>();
                ConfigureProgressValidator(progressValidator);

                await DownloadDirectory(progressValidator);
                progressValidator.AssertOnCompletion();
            }
        }

        async Task DownloadDirectory(DirectoryProgressValidator<DownloadDirectoryProgressArgs> progressValidator, bool concurrent = true)
        {
            var directory = await UploadDirectory(20 * MEG_SIZE, null, false);
            var directoryPath = directory.FullName;
            var keyPrefix = directory.Name;
            Directory.Delete(directoryPath, true);

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = bucketName,
                LocalDirectory = directoryPath,
                S3Directory = keyPrefix
            };

            if (progressValidator != null)
            {
                request.DownloadedDirectoryProgressEvent += progressValidator.OnProgressEvent;
            }

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.DownloadDirectoryAsync(request);
            }

            await ValidateDirectoryContents(bucketName, keyPrefix, directory);
        }

        [TestMethod]
        public async Task DownloadDirectoryWithDisableSlashCorrectionForS3DirectoryProgressTest()
        {
            // disable clock skew testing, this is a multithreaded test
            using (RetryUtilities.DisableClockSkewCorrection())
            {
                var progressValidator = new DirectoryProgressValidator<DownloadDirectoryProgressArgs>();
                ConfigureProgressValidator(progressValidator);

                int numberOfTestFiles = 5;
                var downloadDirectory = await DownloadDirectoryWithDisableSlashCorrectionForS3Directory(numberOfTestFiles, progressValidator);
                progressValidator.AssertOnCompletion();

                Assert.AreEqual(numberOfTestFiles, downloadDirectory.GetFiles("*", SearchOption.AllDirectories).Count());
                await ValidateDirectoryContents(bucketName, string.Empty, downloadDirectory);
            }
        }

        async Task<DirectoryInfo> DownloadDirectoryWithDisableSlashCorrectionForS3Directory(int numberOfTestFiles, DirectoryProgressValidator<DownloadDirectoryProgressArgs> progressValidator)
        {
            var keyPrefix = DateTime.UtcNow.ToString("yyyy-MM-dd");
            var directory = await UploadDirectoryWithKeyPrefix(1 * KILO_SIZE, null, keyPrefix, numberOfTestFiles, false);
            var directoryPath = directory.FullName;
            Directory.Delete(directoryPath, true);

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = bucketName,
                LocalDirectory = directoryPath,
                S3Directory = keyPrefix,
                DisableSlashCorrection = true
            };

            if (progressValidator != null)
            {
                request.DownloadedDirectoryProgressEvent += progressValidator.OnProgressEvent;
            }

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.DownloadDirectoryAsync(request);
            }

            return directory;
        }

        async Task<DirectoryInfo> UploadDirectoryWithKeyPrefix(long size, DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator, string keyPrefix, int numberOfTestFiles, bool validate = true)
        {
            var directory = CreateTestDirectoryWithFilePrefix(size, keyPrefix, numberOfTestFiles);
            var directoryPath = directory.FullName;
            var concurrentTu = new TransferUtility(Client, new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10,
            });
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directoryPath,
                ContentType = plainTextContentType,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
            };

            if (progressValidator != null)
            {
                request.UploadDirectoryProgressEvent += progressValidator.OnProgressEvent;
            }

            HashSet<string> files = new HashSet<string>();
            request.UploadDirectoryProgressEvent += (s, e) =>
            {
                files.Add(e.CurrentFile);
                Console.WriteLine("Progress callback = " + e.ToString());
            };

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.UploadDirectoryAsync(request);
            }

            if (validate)
            {
                await ValidateDirectoryContents(bucketName, string.Empty, directory, plainTextContentType);
            }

            return directory;
        }

        [TestMethod]
        public async Task DownloadProgressTest()
        {
            var fileName = UtilityMethods.GenerateName(@"DownloadTest\File");
            var progressValidator = new TransferProgressValidator<WriteObjectProgressArgs>
            {
                Validate = (p) =>
                {
                    Assert.AreEqual(p.BucketName, bucketName);
                    Assert.AreEqual(p.Key, fileName);
                    Assert.IsNotNull(p.FilePath);
                    Assert.IsTrue(p.FilePath.Contains(fileName));
                }
            };

            await Download(fileName, 10 * MEG_SIZE, progressValidator);
            progressValidator.AssertOnCompletion();
        }

        [TestMethod]
        public async Task DownloadProgressZeroLengthFileTest()
        {
            var fileName = UtilityMethods.GenerateName(@"DownloadTest\File");
            var progressValidator = new TransferProgressValidator<WriteObjectProgressArgs>
            {
                Validate = (p) =>
                {
                    Assert.AreEqual(p.BucketName, bucketName);
                    Assert.AreEqual(p.Key, fileName);
                    Assert.IsNotNull(p.FilePath);
                    Assert.IsTrue(p.FilePath.Contains(fileName));
                    Assert.AreEqual(p.TotalBytes, 0);
                    Assert.AreEqual(p.TransferredBytes, 0);
                    Assert.AreEqual(p.PercentDone, 100);
                }
            };

            await Download(fileName, 0, progressValidator);
            progressValidator.AssertOnCompletion();
        }

        [TestMethod]
        public async Task SimpleDownloadInitiatedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleDownloadTest\InitiatedEvent");
            var eventValidator = new TransferLifecycleEventValidator<DownloadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName + ".download"));
                    // Note: DownloadInitiatedEventArgs does not have TotalBytes since we don't know the size until GetObjectResponse
                }
            };
            
            await DownloadWithLifecycleEvents(fileName, 10 * MEG_SIZE, eventValidator, null, null);
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task SimpleDownloadCompletedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleDownloadTest\CompletedEvent");
            var eventValidator = new TransferLifecycleEventValidator<DownloadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Response);
                    Assert.AreEqual(args.TransferredBytes, args.TotalBytes);
                    Assert.AreEqual(10 * MEG_SIZE, args.TotalBytes);
                    Assert.IsTrue(!string.IsNullOrEmpty(args.Response.ETag));
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName + ".download"));
                }
            };

            await DownloadWithLifecycleEvents(fileName, 10 * MEG_SIZE, null, eventValidator, null);
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task SimpleDownloadFailedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleDownloadTest\FailedEvent");
            var eventValidator = new TransferLifecycleEventValidator<DownloadFailedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName + ".download"));
                    
                    // Non-existent key should always be early failure with unknown total bytes
                    Assert.AreEqual(-1, args.TotalBytes, "Non-existent key should result in TotalBytes = -1");
                    Assert.AreEqual(0, args.TransferredBytes, "No bytes should be transferred for non-existent key");
                }
            };
            
            // Use non-existent key to force failure
            var nonExistentKey = "non-existent-key-" + Guid.NewGuid().ToString();
            
            try
            {
                await DownloadWithLifecycleEventsAndKey(fileName, nonExistentKey, null, null, eventValidator);
                Assert.Fail("Expected an exception to be thrown for non-existent key");
            }
            catch (AmazonS3Exception)
            {
                // Expected exception - the failed event should have been fired
                eventValidator.AssertEventFired();
            }
        }

        [TestMethod]
        public async Task SimpleDownloadCompleteLifecycleTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleDownloadTest\CompleteLifecycle");
            var initiatedValidator = new TransferLifecycleEventValidator<DownloadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName + ".download"));
                    // Note: DownloadInitiatedEventArgs does not have TotalBytes since we don't know the size until GetObjectResponse
                }
            };
            
            var completedValidator = new TransferLifecycleEventValidator<DownloadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Response);
                    Assert.AreEqual(args.TransferredBytes, args.TotalBytes);
                    Assert.AreEqual(8 * MEG_SIZE, args.TotalBytes);
                    Assert.AreEqual(args.FilePath, Path.Combine(BasePath, fileName + ".download"));
                }
            };

            await DownloadWithLifecycleEvents(fileName, 8 * MEG_SIZE, initiatedValidator, completedValidator, null);
            initiatedValidator.AssertEventFired();
            completedValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task MultipartDownloadProgressTest()
        {
            var fileName = UtilityMethods.GenerateName("MultipartDownloadProgress");
            var originalFilePath = Path.Combine(BasePath, fileName);
            var downloadedFilePath = originalFilePath + ".dn";
            
            // Upload a large file (20MB to ensure multipart)
            UtilityMethods.GenerateFile(originalFilePath, 20 * MEG_SIZE);
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = fileName,
                FilePath = originalFilePath
            });

            int inProgressEventCount = 0;
            int completedEventCount = 0;
            long lastTransferredBytes = 0;

            var progressValidator = new TransferProgressValidator<WriteObjectProgressArgs>
            {
                ValidateProgressInterval = true,  // Enable interval validation to ensure events fire
                Validate = (p) =>
                {
                    Assert.AreEqual(bucketName, p.BucketName);
                    Assert.AreEqual(fileName, p.Key);
                    Assert.IsNotNull(p.FilePath);
                    Assert.IsTrue(p.TransferredBytes >= lastTransferredBytes);
                    
                    if (p.IsCompleted)
                    {
                        completedEventCount++;
                        Assert.AreEqual(p.TotalBytes, p.TransferredBytes);
                    }
                    else
                    {
                        inProgressEventCount++;
                        Assert.IsTrue(p.TransferredBytes < p.TotalBytes);
                    }
                    
                    lastTransferredBytes = p.TransferredBytes;
                }
            };

            var request = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                FilePath = downloadedFilePath,
                Key = fileName
            };
            request.WriteObjectProgressEvent += progressValidator.OnProgressEvent;

            // Use DownloadWithResponseAsync to trigger MultipartDownloadCommand
            using (var transferUtility = new TransferUtility(Client))
            {
                var response = await transferUtility.DownloadWithResponseAsync(request);
                Assert.IsNotNull(response);
            }

            progressValidator.AssertOnCompletion();
            
            // Validate that in-progress events actually fired during the download
            Assert.IsTrue(inProgressEventCount > 0, $"Expected in-progress events to fire during multipart download, but got {inProgressEventCount}");
            Assert.AreEqual(1, completedEventCount);
            UtilityMethods.CompareFiles(originalFilePath, downloadedFilePath);
        }

        [TestMethod]
        public async Task MultipartDownloadInitiatedCompletedEventsTest()
        {
            var fileName = UtilityMethods.GenerateName("MultipartDownloadEvents");
            var originalFilePath = Path.Combine(BasePath, fileName);
            var downloadedFilePath = originalFilePath + ".dn";
            long expectedSize = 20 * MEG_SIZE;
            
            // Upload large file
            UtilityMethods.GenerateFile(originalFilePath, expectedSize);
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = fileName,
                FilePath = originalFilePath
            });

            bool initiatedEventFired = false;
            bool completedEventFired = false;
            
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                FilePath = downloadedFilePath,
                Key = fileName
            };
            
            request.DownloadInitiatedEvent += (s, e) =>
            {
                Assert.IsFalse(initiatedEventFired, "Initiated event should fire only once");
                initiatedEventFired = true;
                Assert.AreEqual(fileName, e.Request.Key);
            };
            
            request.DownloadCompletedEvent += (s, e) =>
            {
                Assert.IsFalse(completedEventFired, "Completed event should fire only once");
                completedEventFired = true;
                Assert.AreEqual(expectedSize, e.TotalBytes);
                Assert.AreEqual(expectedSize, e.TransferredBytes);
            };

            using (var transferUtility = new TransferUtility(Client))
            {
                var response = await transferUtility.DownloadWithResponseAsync(request);
                Assert.IsNotNull(response);
            }

            Assert.IsTrue(initiatedEventFired, "Initiated event should have fired");
            Assert.IsTrue(completedEventFired, "Completed event should have fired");
        }

        [TestMethod]
        public async Task MultipartDownloadFailedEventTest()
        {
            var fileName = UtilityMethods.GenerateName("MultipartDownloadFailed");
            var downloadedFilePath = Path.Combine(BasePath, fileName + ".dn");
            bool failedEventFired = false;
            
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                FilePath = downloadedFilePath,
                Key = "non-existent-key-" + Guid.NewGuid() // Intentionally non-existent
            };
            
            request.DownloadFailedEvent += (s, e) =>
            {
                failedEventFired = true;
                Assert.IsNotNull(e.FilePath);
            };

            try
            {
                using (var transferUtility = new TransferUtility(Client))
                {
                    await transferUtility.DownloadWithResponseAsync(request);
                }

                Assert.Fail("Expected an exception to be thrown for non-existent key");
            }
            catch (AmazonS3Exception)
            {
                // Expected exception - the failed event should have been fired
                Assert.IsTrue(failedEventFired, "Failed event should have fired");
            }
        }

        async Task Download(string fileName, long size, TransferProgressValidator<WriteObjectProgressArgs> progressValidator)
        {
            var key = fileName;
            var originalFilePath = Path.Combine(BasePath, fileName);
            UtilityMethods.GenerateFile(originalFilePath, size);

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = originalFilePath
            });

            var downloadedFilePath = originalFilePath + ".dn";
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                FilePath = downloadedFilePath,
                Key = key
            };
            if (progressValidator != null)
            {
                request.WriteObjectProgressEvent += progressValidator.OnProgressEvent;
            }

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.DownloadAsync(request);
            }

            UtilityMethods.CompareFiles(originalFilePath, downloadedFilePath);
        }

        [TestMethod]
        public async Task OpenStreamTest()
        {
            var fileName = UtilityMethods.GenerateName(@"OpenStreamTest\File");
            var key = fileName;
            var originalFilePath = Path.Combine(BasePath, fileName);
            UtilityMethods.GenerateFile(originalFilePath, 2 * MEG_SIZE);

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = originalFilePath
            });

            using (var transferUtility = new TransferUtility(Client))
            {
                var stream = await transferUtility.OpenStreamAsync(bucketName, key);
                Assert.IsNotNull(stream);
                Assert.IsTrue(stream.CanRead);
                stream.Close();
            }
        }

        /// <summary>
        /// Partial download resumption support can erroneously trigger retry with
        /// byte range of 0 to Long.MaxValue if a zero length object is the first object
        /// to be download to a new folder path - S3 then yields an invalid byte range 
        /// error on the retry.
        /// Test ensures the fix, to test that the folder path exists before trying to
        /// access it, so we don't trigger a retry.
        /// </summary>
        [TestMethod]
        public async Task TestZeroLengthDownloadToNonExistingPath()
        {
            var objectKey = "folder1/folder2/empty_file.txt";
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                ContentBody = ""
            });

            var filename = UtilityMethods.GenerateName(objectKey.Replace('/', '\\'));
            var filePath = Path.Combine(BasePath, filename);

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.DownloadAsync(new TransferUtilityDownloadRequest
                {
                    BucketName = bucketName,
                    FilePath = filePath,
                    Key = objectKey
                });
            }

            Assert.IsTrue(File.Exists(filePath));
        }

        [TestMethod]
        public async Task TestMultipartUploadWithSetContentTypeNotOverwritten()
        {
            var fileName = UtilityMethods.GenerateName(@"SetContentType");
            var path = Path.Combine(BasePath, fileName);
            UtilityMethods.GenerateFile(path, 20 * MEG_SIZE);

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.UploadAsync(new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    FilePath = path,
                    Key = "test-content-type",
                    ContentType = MediaTypeNames.Text.Plain,
                    Headers =
                    {
                        ContentEncoding = "gzip",
                    },
                });
            }

            var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            { 
                BucketName = bucketName,
                Key = "test-content-type" 
            });
            Assert.AreEqual(MediaTypeNames.Text.Plain, metadata.Headers.ContentType);
        }

        [TestMethod]
        public async Task UploadWithResponseAsyncSmallFileTest()
        {
            var fileName = UtilityMethods.GenerateName(@"UploadWithResponseTest\SmallFile");
            var path = Path.Combine(BasePath, fileName);
            var fileSize = 1 * MEG_SIZE; // Small file for single-part upload
            UtilityMethods.GenerateFile(path, fileSize);

            var request = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                FilePath = path,
                Key = fileName,
                ContentType = octetStreamContentType
            };

            using (var transferUtility = new TransferUtility(Client))
            {
                var response = await transferUtility.UploadWithResponseAsync(request);
                Assert.IsNotNull(response, "Response should not be null");

                // Validate essential response fields that should always be present
                Assert.IsNotNull(response.ETag, "ETag should not be null");
                Assert.IsTrue(response.ETag.Length > 0, "ETag should not be empty");

                // Validate file was actually uploaded by checking metadata
                var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = fileName
                });
                Assert.AreEqual(fileSize, metadata.ContentLength, "Uploaded file size should match original");
                Assert.AreEqual(response.ETag, metadata.ETag, "ETag from response should match object metadata");
            }
        }

        [TestMethod]
        public async Task UploadWithResponseAsyncLargeFileTest()
        {
            var fileName = UtilityMethods.GenerateName(@"UploadWithResponseTest\LargeFile");
            var path = Path.Combine(BasePath, fileName);
            var fileSize = 20 * MEG_SIZE; // Large file for multipart upload
            UtilityMethods.GenerateFile(path, fileSize);

            var request = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                FilePath = path,
                Key = fileName,
                ContentType = octetStreamContentType
            };

            using (var transferUtility = new TransferUtility(Client))
            {
                var response = await transferUtility.UploadWithResponseAsync(request);
                Assert.IsNotNull(response, "Response should not be null");

                // Validate essential response fields that should always be present
                Assert.IsNotNull(response.ETag, "ETag should not be null");
                Assert.IsTrue(response.ETag.Length > 0, "ETag should not be empty");

                // Validate file was actually uploaded by checking metadata
                var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = fileName
                });
                Assert.AreEqual(fileSize, metadata.ContentLength, "Uploaded file size should match original");
                Assert.AreEqual(response.ETag, metadata.ETag, "ETag from response should match object metadata");
            }
        }

        [TestMethod]
        public async Task UploadWithResponseAsyncStreamTest()
        {
            var fileName = UtilityMethods.GenerateName(@"UploadWithResponseTest\StreamFile");
            var path = Path.Combine(BasePath, fileName);
            var fileSize = 5 * MEG_SIZE;
            UtilityMethods.GenerateFile(path, fileSize);

            using (var fileStream = File.OpenRead(path))
            {
                var request = new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    InputStream = fileStream,
                    Key = fileName,
                    ContentType = octetStreamContentType
                };

                using (var transferUtility = new TransferUtility(Client))
                {
                    var response = await transferUtility.UploadWithResponseAsync(request);
                    Assert.IsNotNull(response, "Response should not be null");

                    // Validate essential response fields that should always be present
                    Assert.IsNotNull(response.ETag, "ETag should not be null");
                    Assert.IsTrue(response.ETag.Length > 0, "ETag should not be empty");

                    // Validate file was actually streamed and uploaded correctly
                    var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                    {
                        BucketName = bucketName,
                        Key = fileName
                    });
                    Assert.AreEqual(fileSize, metadata.ContentLength, "Uploaded stream size should match original");
                    Assert.AreEqual(response.ETag, metadata.ETag, "ETag from response should match object metadata");

                    // Validate content by downloading and comparing
                    var downloadPath = path + ".download";
                    await transferUtility.DownloadAsync(new TransferUtilityDownloadRequest
                    {
                        BucketName = bucketName,
                        Key = fileName,
                        FilePath = downloadPath
                    });
                    UtilityMethods.CompareFiles(path, downloadPath);
                }
            }
        }

        [TestMethod]
        public async Task UploadWithResponseAsyncWithChecksumTest()
        {
            var fileName = UtilityMethods.GenerateName(@"UploadWithResponseTest\ChecksumFile");
            var path = Path.Combine(BasePath, fileName);
            var fileSize = 2 * MEG_SIZE;
            UtilityMethods.GenerateFile(path, fileSize);

            // Calculate checksum for the file
            var fileBytes = File.ReadAllBytes(path);
            var precalculatedChecksum = CryptoUtilFactory.CryptoInstance.ComputeCRC32Hash(fileBytes);

            var request = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                FilePath = path,
                Key = fileName,
                ContentType = octetStreamContentType,
                ChecksumCRC32 = precalculatedChecksum
            };

            using (var transferUtility = new TransferUtility(Client))
            {
                var response = await transferUtility.UploadWithResponseAsync(request);
                Assert.IsNotNull(response, "Response should not be null");
                Assert.IsNotNull(response.ETag, "ETag should not be null");
                Assert.IsTrue(response.ETag.Length > 0, "ETag should not be empty");
            }
        }

        [TestMethod]
        public async Task UploadWithResponseAsyncCompareWithLegacyUploadTest()
        {
            var fileName = UtilityMethods.GenerateName(@"UploadWithResponseTest\CompareFile");
            var path = Path.Combine(BasePath, fileName);
            var fileSize = 8 * MEG_SIZE;
            UtilityMethods.GenerateFile(path, fileSize);

            // Test the new UploadWithResponseAsync method
            var responseRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                FilePath = path,
                Key = fileName + "-with-response",
                ContentType = octetStreamContentType
            };

            using (var transferUtility = new TransferUtility(Client))
            {
                var response = await transferUtility.UploadWithResponseAsync(responseRequest);

                // Test the legacy Upload method for comparison
                var legacyRequest = new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    FilePath = path,
                    Key = fileName + "-legacy",
                    ContentType = octetStreamContentType
                };

                await transferUtility.UploadAsync(legacyRequest);

                // Validate that both uploads resulted in the same file being uploaded
                var responseMetadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = fileName + "-with-response"
                });

                var legacyMetadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = fileName + "-legacy"
                });

                // Both should have the same file size and content type
                Assert.AreEqual(responseMetadata.ContentLength, legacyMetadata.ContentLength, "File sizes should match");
                Assert.AreEqual(responseMetadata.Headers.ContentType, legacyMetadata.Headers.ContentType, "Content types should match");

                // Validate the response contains the expected ETag
                Assert.IsNotNull(response.ETag, "Response ETag should not be null");
                Assert.AreEqual(response.ETag, responseMetadata.ETag, "Response ETag should match metadata ETag");
            }
        }

        [TestMethod]
        public async Task UploadAsyncCancellationTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\CancellationTest");
            var path = Path.Combine(BasePath, fileName);
            UtilityMethods.GenerateFile(path, 20 * MEG_SIZE);

            TransferUtilityUploadRequest uploadRequest = new TransferUtilityUploadRequest()
            {
                BucketName = bucketName,
                Key = fileName,
                FilePath = path
            };

            var tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            Task uploadTask = null;
            try
            {
                using (var transferUtility = new TransferUtility(Client))
                {
                    uploadTask = transferUtility.UploadAsync(uploadRequest, token);
                    tokenSource.CancelAfter(100);
                    await uploadTask;
                }
            }
            catch (OperationCanceledException)
            {
                Assert.IsTrue(uploadTask.IsCanceled);
                return;
            }
            Assert.Fail("An OperationCanceledException was not thrown.");
        }

        [TestMethod]
        public async Task UploadDirectoryWithMixedFileTypesContentTypeTest()
        {
            var directory = CreateMixedFileTypeTestDirectory();
            var keyPrefix = directory.Name;

            // Upload directory without setting explicit ContentType
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directory.FullName,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
                // Note: No ContentType set - should auto-detect per file
            };

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.UploadDirectoryAsync(request);
            }

            // Validate each file got correct content type based on extension
            await ValidateDirectoryContentTypes(bucketName, keyPrefix, directory);
        }

        public static DirectoryInfo CreateMixedFileTypeTestDirectory()
        {
            var directoryPath = GenerateDirectoryPath("MixedFileTypeTest");

            var testFiles = new Dictionary<string, string>
            {
                { "test.html", "<html><body>Test HTML</body></html>" },
                { "test.css", "body { color: red; }" },
                { "test.js", "console.log('test');" },
                { "test.json", "{ \"test\": \"value\" }" },
                { "test.txt", "Plain text content" },
                { "test.xml", "<?xml version=\"1.0\"?><root>test</root>" },
                { "test.pdf", "PDF content placeholder" },
                { "test.svg", "<svg><rect width=\"100\" height=\"100\"/></svg>" }
            };

            foreach (var file in testFiles)
            {
                var filePath = Path.Combine(directoryPath, file.Key);
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, file.Value);
            }

            return new DirectoryInfo(directoryPath);
        }

        private static async Task ValidateDirectoryContentTypes(string bucketName, string keyPrefix, DirectoryInfo directory)
        {
            var expectedContentTypes = new Dictionary<string, string>
            {
                { ".html", "text/html" },
                { ".css", "text/css" },
                { ".js", "application/x-javascript" },
                { ".json", "application/json" },
                { ".txt", "text/plain" },
                { ".xml", "text/xml" },
                { ".pdf", "application/pdf" },
                { ".svg", "image/svg+xml" }
            };

            var files = directory.GetFiles("*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var filePath = file.FullName;
                var relativePath = filePath.Substring(directory.FullName.Length + 1);
                var key = (!string.IsNullOrEmpty(keyPrefix) ? keyPrefix + "/" : string.Empty) + relativePath.Replace("\\", "/");

                var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = key
                });

                var extension = Path.GetExtension(file.Name).ToLowerInvariant();
                var expectedContentType = expectedContentTypes[extension];

                Assert.AreEqual(expectedContentType, metadata.Headers.ContentType,
                    $"File {file.Name} should have content type {expectedContentType} but got {metadata.Headers.ContentType}");
            }
        }

        public static void ConfigureProgressValidator(DirectoryProgressValidator<DownloadDirectoryProgressArgs> progressValidator)
        {
            progressValidator.Validate = (progress, lastProgress) =>
            {
                if (lastProgress != null)
                {
                    Assert.IsTrue(progress.NumberOfFilesDownloaded >= lastProgress.NumberOfFilesDownloaded);
                    Assert.IsTrue(progress.TransferredBytes >= lastProgress.TransferredBytes);
                    if (progress.NumberOfFilesDownloaded == lastProgress.NumberOfFilesDownloaded)
                    {
                        Assert.IsTrue(progress.TransferredBytes - lastProgress.TransferredBytes >= 100 * KILO_SIZE);
                    }
                }

                if (progress.NumberOfFilesDownloaded == progress.TotalNumberOfFiles)
                {
                    Assert.AreEqual(progress.TransferredBytes, progress.TotalBytes);
                    progressValidator.IsProgressEventComplete = true;
                }

                Console.WriteLine(progress.ToString());
            };
        }

        public static void ConfigureProgressValidator(DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator)
        {
            progressValidator.Validate = (progress, lastProgress) =>
            {
                // Skip validation if testing clock skew correction
                if (RetryUtilities.TestClockSkewCorrection)
                    return;

                Assert.IsFalse(string.IsNullOrEmpty(progress.CurrentFile));
                Assert.IsTrue(progress.TotalNumberOfBytesForCurrentFile > 0);
                Assert.IsTrue(progress.TransferredBytesForCurrentFile > 0);

                if (lastProgress != null)
                {
                    Assert.IsTrue(progress.NumberOfFilesUploaded >= lastProgress.NumberOfFilesUploaded);
                    Assert.IsTrue(progress.TransferredBytes > lastProgress.TransferredBytes);
                    if (progress.NumberOfFilesUploaded == lastProgress.NumberOfFilesUploaded)
                    {
                        Assert.IsTrue(progress.TransferredBytes - lastProgress.TransferredBytes >= 100 * KILO_SIZE);
                    }
                    else
                    {
                        Assert.AreEqual(progress.TransferredBytesForCurrentFile, progress.TotalNumberOfBytesForCurrentFile);
                    }
                }

                if (progress.NumberOfFilesUploaded == progress.TotalNumberOfFiles)
                {
                    Assert.AreEqual(progress.TransferredBytes, progress.TotalBytes);
                    progressValidator.IsProgressEventComplete = true;
                }

                Console.Write("\t{0} : {1}/{2}\t", progress.CurrentFile,
                    progress.TransferredBytesForCurrentFile, progress.TotalNumberOfBytesForCurrentFile);
                Console.WriteLine(progress.ToString());
            };
        }

        public static async Task ValidateFileContents(string bucketName, string key, string path)
        {
            // test assumes we used a known extension and added it to the file key
            var ext = Path.GetExtension(key);
            await ValidateFileContents(bucketName, key, path, AmazonS3Util.MimeTypeFromExtension(ext));
        }

        public static async Task ValidateFileContents(string bucketName, string key, string path, string contentType)
        {
            var downloadPath = path + ".chk";
            var request = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key,
            };

            await UtilityMethods.WaitUntilAsync(async () =>
            {
                using (var response = await Client.GetObjectAsync(request))
                {
                    if (!string.IsNullOrEmpty(contentType))
                    {
                        Assert.AreEqual(contentType, response.Headers.ContentType);
                    }

                    await response.WriteResponseStreamToFileAsync(downloadPath, append: false, cancellationToken: default);
                }
                return true;
            }, sleepSeconds: 2, maxWaitSeconds: 10);
            
            UtilityMethods.CompareFiles(path, downloadPath);
        }

        public static async Task ValidateDirectoryContents(string bucketName, string keyPrefix, DirectoryInfo sourceDirectory)
        {
            await ValidateDirectoryContents(bucketName, keyPrefix, sourceDirectory, null);
        }

        public static async Task ValidateDirectoryContents(string bucketName, string keyPrefix, DirectoryInfo sourceDirectory, string contentType)
        {
            var directoryPath = sourceDirectory.FullName;
            var files = sourceDirectory.GetFiles("*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var filePath = file.FullName;
                var key = filePath.Substring(directoryPath.Length + 1);
                key = (!string.IsNullOrEmpty(keyPrefix) ? keyPrefix + "/" : string.Empty) + key.Replace("\\", "/");
                await ValidateFileContents(bucketName, key, filePath, contentType);
            }
        }

        public static DirectoryInfo CreateTestDirectory(long size = 0, int numberOfTestFiles = 5)
        {
            if (size == 0)
            {
                size = 1 * MEG_SIZE;
            }

            var directoryPath = GenerateDirectoryPath();
            for (int i = 0; i < numberOfTestFiles; i++)
            {
                var filePath = Path.Combine(Path.Combine(directoryPath, i.ToString()), "file.txt");
                UtilityMethods.GenerateFile(filePath, size);
            }

            return new DirectoryInfo(directoryPath);
        }

        public static DirectoryInfo CreateTestDirectoryWithFilePrefix(long size = 0, string filePrefix = null, int numberOfTestFiles = 5)
        {
            if (string.IsNullOrWhiteSpace(filePrefix))
            {
                return CreateTestDirectory(size, numberOfTestFiles);
            }

            int numberOfTestFilesInChildDirectory = numberOfTestFiles / 2;
            int numberOfTestFilesInParentDirectory = numberOfTestFiles - numberOfTestFilesInChildDirectory;

            if (size == 0)
            {
                size = 1 * KILO_SIZE;
            }

            var parentDirectory = GenerateDirectoryPath();
            for (int i = 0; i < numberOfTestFilesInParentDirectory; i++)
            {
                var parentDirectoryFilePath = Path.Combine(parentDirectory, filePrefix.Trim() + i.ToString() + "file.txt");
                UtilityMethods.GenerateFile(parentDirectoryFilePath, size);
            }

            var childDirectory = Path.Combine(parentDirectory, filePrefix);
            for (int i = 0; i < numberOfTestFilesInChildDirectory; i++)
            {
                var childDirectoryFilePath = Path.Combine(childDirectory, i.ToString() + "file.txt");
                UtilityMethods.GenerateFile(childDirectoryFilePath, size);
            }

            return new DirectoryInfo(parentDirectory);
        }

        public static string GenerateDirectoryPath(string baseName = "DirectoryTest")
        {
            var directoryName = UtilityMethods.GenerateName(baseName);
            var directoryPath = Path.Combine(BasePath, directoryName);
            return directoryPath;
        }

        public abstract class ProgressValidator<T>
        {
            public T LastProgressEventValue { get; set; }

            public bool IsProgressEventComplete { get; set; }

            public Exception ProgressEventException { get; set; }

            public void AssertOnCompletion()
            {
                // Skip validation if testing clock skew correction
                if (RetryUtilities.TestClockSkewCorrection)
                    return;

                if (this.ProgressEventException != null)
                    throw this.ProgressEventException;

                // Since  AWSSDKUtils.InvokeInBackground fires the event in the background it is possible that we check too early that the event has fired. In this case, we sleep and check again.
                for (int retries = 1; retries < 5 && !this.IsProgressEventComplete; retries++)
                {
                    Thread.Sleep(1000 * retries);
                }
                Assert.IsTrue(this.IsProgressEventComplete, "IsProgressEventComplete is false");
            }
        }

        class TransferProgressValidator<T> : ProgressValidator<T> where T : TransferProgressArgs
        {
            public Action<T> Validate { get; set; }

            public bool ValidateProgressInterval { get; set; }

            public TransferProgressValidator()
            {
                this.ValidateProgressInterval = true;
            }

            public void OnProgressEvent(object sender, T progress)
            {
                try
                {
                    Console.WriteLine("Progress Event : {0}%\t{1}/{2}", progress.PercentDone, progress.TransferredBytes, progress.TotalBytes);
                    Assert.IsFalse(progress.PercentDone > 100, "Progress percent done cannot be greater than 100%");
                    if (this.IsProgressEventComplete)
                        Assert.Fail("A progress event was received after completion.");

                    if (progress.TransferredBytes == progress.TotalBytes)
                    {
                        Assert.AreEqual(progress.PercentDone, 100);
                        this.IsProgressEventComplete = true;
                    }

                    if (this.LastProgressEventValue != null)
                    {
                        if (progress.PercentDone < this.LastProgressEventValue.PercentDone)
                            Console.WriteLine("Progress Event : --------------------------");

                        Assert.IsTrue(progress.PercentDone >= this.LastProgressEventValue.PercentDone);
                        Assert.IsTrue(progress.TransferredBytes > this.LastProgressEventValue.TransferredBytes);

                        if (progress.TransferredBytes < progress.TotalBytes)
                        {
                            if (progress.TransferredBytes - this.LastProgressEventValue.TransferredBytes < 100 * KILO_SIZE)
                                Console.WriteLine("Progress Event : *******Part Uploaded********");

                            if (this.ValidateProgressInterval)
                            {
                                // When TransferUtility uploads using multipart upload, the TransferredBytes
                                // will be less than the interval for last chunk of each upload part request.
                                Assert.IsTrue(progress.TransferredBytes - this.LastProgressEventValue.TransferredBytes >= 100 * KILO_SIZE);
                            }
                        }
                    }

                    Validate(progress);
                    this.LastProgressEventValue = progress;
                }
                catch (Exception ex)
                {
                    this.ProgressEventException = ex;
                    Console.WriteLine("Exception caught: {0}", ex.Message);
                    throw;
                }
            }
        }

        public class DirectoryProgressValidator<T> : ProgressValidator<T>
        {
            public Action<T, T> Validate { get; set; }

            public void OnProgressEvent(object sender, T progress)
            {
                try
                {
                    Validate(progress, this.LastProgressEventValue);
                }
                catch (Exception ex)
                {
                    this.ProgressEventException = ex;
                    Console.WriteLine("Exception caught: {0}", ex.Message);
                    throw;
                }
                finally
                {
                    this.LastProgressEventValue = progress;
                }
            }
        }

        class TransferLifecycleEventValidator<T>
        {
            public Action<T> Validate { get; set; }
            public bool EventFired { get; private set; }
            public Exception EventException { get; private set; }

            public void OnEventFired(object sender, T eventArgs)
            {
                try
                {
                    Console.WriteLine("Lifecycle Event Fired: {0}", typeof(T).Name);
                    Validate?.Invoke(eventArgs);
                    EventFired = true;  // Only set if validation passes
                }
                catch (Exception ex)
                {
                    EventException = ex;
                    EventFired = false;  // Ensure we don't mark as fired on failure
                    Console.WriteLine("Exception caught in lifecycle event: {0}", ex.Message);
                    // Don't re-throw, let AssertEventFired() handle it
                }
            }

            public void AssertEventFired()
            {
                if (EventException != null)
                    throw EventException;

                // Since events are now fired synchronously, we can check immediately without retries
                Assert.IsTrue(EventFired, $"{typeof(T).Name} event was not fired");
            }
        }
        
        async Task UploadWithLifecycleEvents(string fileName, long size,
            TransferLifecycleEventValidator<UploadInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<UploadCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<UploadFailedEventArgs> failedValidator)
        {
            await UploadWithLifecycleEventsAndBucket(fileName, size, bucketName, initiatedValidator, completedValidator, failedValidator);
        }

        async Task UploadWithLifecycleEventsAndBucket(string fileName, long size, string targetBucketName,
            TransferLifecycleEventValidator<UploadInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<UploadCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<UploadFailedEventArgs> failedValidator)
        {
            var key = fileName;
            var path = Path.Combine(BasePath, fileName);
            UtilityMethods.GenerateFile(path, size);
            
            var request = new TransferUtilityUploadRequest
            {
                BucketName = targetBucketName,
                FilePath = path,
                Key = key,
                ContentType = octetStreamContentType
            };

            if (initiatedValidator != null)
            {
                request.UploadInitiatedEvent += initiatedValidator.OnEventFired;
            }

            if (completedValidator != null)
            {
                request.UploadCompletedEvent += completedValidator.OnEventFired;
            }

            if (failedValidator != null)
            {
                request.UploadFailedEvent += failedValidator.OnEventFired;
            }

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.UploadAsync(request);
            }
        }

        async Task UploadUnseekableStreamWithLifecycleEvents(long size,
            TransferLifecycleEventValidator<UploadInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<UploadCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<UploadFailedEventArgs> failedValidator)
        {
            await UploadUnseekableStreamWithLifecycleEventsAndBucket(size, bucketName, initiatedValidator, completedValidator, failedValidator);
        }

        async Task UploadUnseekableStreamWithLifecycleEventsAndBucket(long size, string targetBucketName,
            TransferLifecycleEventValidator<UploadInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<UploadCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<UploadFailedEventArgs> failedValidator)
        {
            var fileName = UtilityMethods.GenerateName(@"UnseekableStreamUpload\File");
            var key = fileName;
            var path = Path.Combine(BasePath, fileName);
            UtilityMethods.GenerateFile(path, size);
            
            // Convert file to unseekable stream
            var stream = GenerateUnseekableStreamFromFile(path);
            
            var request = new TransferUtilityUploadRequest
            {
                BucketName = targetBucketName,
                InputStream = stream,
                Key = key,
                ContentType = octetStreamContentType
            };

            if (initiatedValidator != null)
            {
                request.UploadInitiatedEvent += initiatedValidator.OnEventFired;
            }

            if (completedValidator != null)
            {
                request.UploadCompletedEvent += completedValidator.OnEventFired;
            }

            if (failedValidator != null)
            {
                request.UploadFailedEvent += failedValidator.OnEventFired;
            }

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.UploadAsync(request);
            }
        }

        async Task DownloadWithLifecycleEvents(string fileName, long size,
            TransferLifecycleEventValidator<DownloadInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<DownloadCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<DownloadFailedEventArgs> failedValidator)
        {
            // First upload the file so we have something to download
            var key = fileName;
            var originalFilePath = Path.Combine(BasePath, fileName);
            UtilityMethods.GenerateFile(originalFilePath, size);

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = originalFilePath
            });

            var downloadedFilePath = originalFilePath + ".download";
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                FilePath = downloadedFilePath,
                Key = key
            };

            if (initiatedValidator != null)
            {
                request.DownloadInitiatedEvent += initiatedValidator.OnEventFired;
            }

            if (completedValidator != null)
            {
                request.DownloadCompletedEvent += completedValidator.OnEventFired;
            }

            if (failedValidator != null)
            {
                request.DownloadFailedEvent += failedValidator.OnEventFired;
            }

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.DownloadAsync(request);
            }
        }

        async Task DownloadWithLifecycleEventsAndKey(string fileName, string keyToDownload,
            TransferLifecycleEventValidator<DownloadInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<DownloadCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<DownloadFailedEventArgs> failedValidator)
        {
            var downloadedFilePath = Path.Combine(BasePath, fileName + ".download");

            var request = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                FilePath = downloadedFilePath,
                Key = keyToDownload
            };

            if (initiatedValidator != null)
            {
                request.DownloadInitiatedEvent += initiatedValidator.OnEventFired;
            }

            if (completedValidator != null)
            {
                request.DownloadCompletedEvent += completedValidator.OnEventFired;
            }

            if (failedValidator != null)
            {
                request.DownloadFailedEvent += failedValidator.OnEventFired;
            }

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.DownloadAsync(request);
            }
        }
        
        [TestMethod]
        public async Task UploadDirectoryFailurePolicy_ContinueOnFailure_AllFailures()
        {
            var nonExistentBucket = "non-existent-" + Guid.NewGuid().ToString("N");
            var directory = CreateTestDirectory(1 * KILO_SIZE, numberOfTestFiles: 3);

            try
            {
                var request = new TransferUtilityUploadDirectoryRequest
                {
                    BucketName = nonExistentBucket,
                    Directory = directory.FullName,
                    SearchPattern = "*",
                    SearchOption = SearchOption.AllDirectories,
                    FailurePolicy = FailurePolicy.ContinueOnFailure,
                    UploadFilesConcurrently = true
                };

                using (var transferUtility = new TransferUtility(Client))
                {
                    // ContinueOnFailure should not throw even if all uploads fail
                    var response = await transferUtility.UploadDirectoryWithResponseAsync(request);
                    Assert.IsNotNull(response);
                    Assert.AreEqual(0, response.ObjectsUploaded);
                    Assert.AreEqual(3, response.ObjectsFailed);
                    Assert.AreEqual(DirectoryResult.Failure, response.Result);
                }
            }
            finally
            {
                try { Directory.Delete(directory.FullName, true); } catch { }
            }
        }

        [TestMethod]
        public async Task UploadDirectoryFailurePolicy_ContinueOnFailure_AllSuccess()
        {
            var directory = CreateTestDirectory(1 * KILO_SIZE, numberOfTestFiles: 3);
            try
            {
                var request = new TransferUtilityUploadDirectoryRequest
                {
                    BucketName = bucketName,
                    Directory = directory.FullName,
                    KeyPrefix = directory.Name,
                    SearchPattern = "*",
                    SearchOption = SearchOption.AllDirectories,
                    FailurePolicy = FailurePolicy.ContinueOnFailure,
                    UploadFilesConcurrently = true
                };

                using (var transferUtility = new TransferUtility(Client))
                {
                    var response = await transferUtility.UploadDirectoryWithResponseAsync(request);
                    Assert.IsNotNull(response);
                    Assert.AreEqual(3, response.ObjectsUploaded);
                    Assert.AreEqual(0, response.ObjectsFailed);
                    Assert.AreEqual(DirectoryResult.Success, response.Result);
                }

                // Validate uploaded contents
                await ValidateDirectoryContents(bucketName, directory.Name, directory, plainTextContentType);
            }
            finally
            {
                try { Directory.Delete(directory.FullName, true); } catch { }
            }
        }

        [TestMethod]
        public async Task UploadDirectoryFailurePolicy_AbortOnFailure_Throws()
        {
            var nonExistentBucket = "non-existent-" + Guid.NewGuid().ToString("N");
            var directory = CreateTestDirectory(1 * KILO_SIZE, numberOfTestFiles: 2);

            try
            {
                var request = new TransferUtilityUploadDirectoryRequest
                {
                    BucketName = nonExistentBucket,
                    Directory = directory.FullName,
                    SearchPattern = "*",
                    SearchOption = SearchOption.AllDirectories,
                    FailurePolicy = FailurePolicy.AbortOnFailure,
                    UploadFilesConcurrently = true
                };

                using (var transferUtility = new TransferUtility(Client))
                {
                    await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => 
                        transferUtility.UploadDirectoryWithResponseAsync(request)
                    );
                }
            }
            finally
            {
                try { Directory.Delete(directory.FullName, true); } catch { }
            }
        }

        private class UnseekableStream : MemoryStream
        {
            private readonly bool _setZeroLengthStream;

            public UnseekableStream(byte[] buffer) : base(buffer) { }
            
            public UnseekableStream(bool setZeroLengthStream) : base()
            {
                _setZeroLengthStream = setZeroLengthStream;
            }

            public override bool CanSeek => false;
            
            public override long Length
            {
                get
                {
                    if (_setZeroLengthStream)
                    {
                        return 0;
                    }

                    throw new NotSupportedException();
                }
            }
        }
    }
}
