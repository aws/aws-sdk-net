using System.Security.Cryptography;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.KeyManagementService;
using Amazon.KeyManagementService.Model;
using Amazon;
using System;
using Amazon.S3.Encryption;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Text.RegularExpressions;
using Amazon.Runtime;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// This is a test to verify that .NET's AmazonS3EncryptionClient is interoparable with Java's
    /// To verify interoperability you must successfully run this test and EncryptionInteropTest.java.
    /// This test puts objects to be read by the Java test, and the Java test puts object to be read by this test.
    /// 
    /// This test needs to be run manually so remember to remove the [Ignore] attribute from the class before attempting to run.
    /// 
    /// EncryptionInteropTest.java isn't included in the Visual Studio project but can be found on disk at the same location as this file.
    /// </summary>
    [TestClass]
    [Ignore]
    public class EncryptionInteropTest
    {
        private const string InstructionAndKMSErrorMessage = "AmazonS3EncryptionClient only supports KMS key wrapping in metadata storage mode. " +
            "Please set StorageMode to CryptoStorageMode.ObjectMetadata or refrain from using KMS EncryptionMaterials.";

        private const string InteropBucketRoot = "java-dotnet-s3-interop-test-do-not-delete-";
        private const string KeyKMSKeyId = "KMSKeyId";
        private const string KeySymmetricKey = "SymmetricKey";

        private const string KeyJavaMetaKMSEncryptionOnly = "JavaMetaKMSEncryptionOnly";
        private const string KeyJavaMetaKMSAuthenticatedEncryption = "JavaMetaKMSAuthenticatedEncryption";
        private const string KeyJavaFileKMSEncryptionOnly = "JavaFileKMSEncryptionOnly";
        private const string KeyJavaFileKMSAuthenticatedEncryption = "JavaFileKMSAuthenticatedEncryption";
        private const string KeyJavaMetaAESEncryptionOnly = "JavaMetaAESEncryptionOnly";
        private const string KeyJavaMetaAESAuthenticatedEncryption = "JavaMetaAESAuthenticatedEncryption";
        private const string KeyJavaFileAESEncryptionOnly = "JavaFileAESEncryptionOnly";
        private const string KeyJavaFileAESAuthenticatedEncryption = "JavaFileAESAuthenticatedEncryption";

        private const string KeyDotNetMetaKMSEncryptionOnly = "DotNetMetaKMSEncryptionOnly";
        private const string KeyDotNetFileKMSEncryptionOnly = "DotNetFileKMSEncryptionOnly";
        private const string KeyDotNetMetaAESEncryptionOnly = "DotNetMetaAESEncryptionOnly";
        private const string KeyDotNetFileAESEncryptionOnly = "DotNetFileAESEncryptionOnly";

        private const string NoSuchKeyErrorCode = "NoSuchKey";
        private const string TestObjectContents = "JavaDotnetS3EncryptionInteropTestContents";

        private static readonly Regex ContentAlgorithmErrorRegex = new Regex("AmazonS3EncryptionClient only supports 'AES/CBC/PKCS5Padding' as the content encryption algorithm.");
        private static readonly Regex WrapAlgorithmErrorRegex = new Regex("AmazonS3EncryptionClient only supports 'kms' as the key wrap algorithm.");
        private static readonly Regex MissingInstructionFileErrorRegex = new Regex("Unable to decrypt data for object");
        private readonly byte[] TestObjectContentsBytes = Encoding.UTF8.GetBytes(TestObjectContents);

        private AmazonS3Client s3Client;
        private AmazonKeyManagementServiceClient kmsClient;
        private AmazonS3EncryptionClient s3EncryptionClientMetadataMode;
        private AmazonS3EncryptionClient s3EncryptionClientFileMode;
        private AmazonS3EncryptionClient s3EncryptionClientMetadataModeKMS;
        private AmazonS3EncryptionClient s3EncryptionClientFileModeKMS;

        private string kmsKeyID;
        private string bucketName;
        private SymmetricAlgorithm symmetricAlgorithm;

        [TestInitialize]
        public void Initialize()
        {
            kmsClient = new AmazonKeyManagementServiceClient(RegionEndpoint.USEast1);
            s3Client = new AmazonS3Client(RegionEndpoint.USEast1);

            // Create a bucket to store objects related to this test.
            bucketName = GetOrCreateBucket(s3Client);
            // Create a KMS key, and an S3 object with the KMSKeyID.
            kmsKeyID = GetOrCreateKMSKey(s3Client, kmsClient, bucketName);
            // Create an S3 object with a symmetric key used for testing.
            symmetricAlgorithm = GetOrCreateSymmetricAlgorithm(s3Client, bucketName);

            var encryptionMaterials = new EncryptionMaterials(symmetricAlgorithm);
            var kmsEncryptionMaterials = new EncryptionMaterials(kmsKeyID);

            AmazonS3CryptoConfiguration config = new AmazonS3CryptoConfiguration()
            {
                StorageMode = CryptoStorageMode.InstructionFile
            };

            s3EncryptionClientMetadataMode = new AmazonS3EncryptionClient(encryptionMaterials);
            RetryUtilities.ForceConfigureClient(s3EncryptionClientMetadataMode);

            s3EncryptionClientFileMode = new AmazonS3EncryptionClient(config, encryptionMaterials);
            RetryUtilities.ForceConfigureClient(s3EncryptionClientFileMode);

            s3EncryptionClientMetadataModeKMS = new AmazonS3EncryptionClient(kmsEncryptionMaterials);
            RetryUtilities.ForceConfigureClient(s3EncryptionClientMetadataModeKMS);

            s3EncryptionClientFileModeKMS = new AmazonS3EncryptionClient(config, kmsEncryptionMaterials);
            RetryUtilities.ForceConfigureClient(s3EncryptionClientFileModeKMS);

        }

        [TestCleanup]
        public void Cleanup()
        {
            kmsClient.Dispose();
            s3Client.Dispose();
            s3EncryptionClientMetadataMode.Dispose();
            s3EncryptionClientFileMode.Dispose();
            s3EncryptionClientMetadataModeKMS.Dispose();
            s3EncryptionClientFileModeKMS.Dispose();

        }

        [TestMethod]
        public void TestReadJavaMetaKMSEncryptionOnlyObject()
        {
            TestReadJavaObject(s3EncryptionClientMetadataModeKMS, KeyJavaMetaKMSEncryptionOnly, null, null);
        }

        [TestMethod]
        public void TestReadJavaMetaKMSAuthenticatedEncryptionObject()
        {
            TestReadJavaObject(s3EncryptionClientMetadataModeKMS, KeyJavaMetaKMSAuthenticatedEncryption,
                typeof(InvalidDataException), ContentAlgorithmErrorRegex);
        }

        [TestMethod]
        public void TestReadJavaFileKMSEncryptionOnlyObject()
        {
            TestReadJavaObject(s3EncryptionClientMetadataModeKMS, KeyJavaFileKMSEncryptionOnly,
                typeof(AmazonServiceException), MissingInstructionFileErrorRegex);
        }

        [TestMethod]
        public void TestReadJavaFileKMSAuthenticatedEncryptionObject()
        {
            TestReadJavaObject(s3EncryptionClientMetadataModeKMS, KeyJavaFileKMSAuthenticatedEncryption,
                typeof(AmazonServiceException), MissingInstructionFileErrorRegex);
        }

        [TestMethod]
        public void TestReadJavaMetaAESEncryptionOnlyObject()
        {
            TestReadJavaObject(s3EncryptionClientMetadataMode, KeyJavaMetaAESEncryptionOnly, null, null);
        }

        [TestMethod]
        public void TestReadJavaMetaAESAuthenticatedEncryptionObject()
        {
            TestReadJavaObject(s3EncryptionClientMetadataMode, KeyJavaMetaAESAuthenticatedEncryption,
                typeof(InvalidDataException), WrapAlgorithmErrorRegex);
        }

        [TestMethod]
        public void TestReadJavaFileAESEncryptionOnlyObject()
        {
            TestReadJavaObject(s3EncryptionClientMetadataMode, KeyJavaFileAESEncryptionOnly,
                typeof(AmazonServiceException), MissingInstructionFileErrorRegex);
        }

        [TestMethod]
        public void TestReadJavaFileAESAuthenticatedEncryptionObject()
        {
            TestReadJavaObject(s3EncryptionClientMetadataMode, KeyJavaFileAESAuthenticatedEncryption,
                typeof(AmazonServiceException), MissingInstructionFileErrorRegex);
        }

        [TestMethod]
        public void TestWriteDotNetObjectsForJavaToRead()
        {
            WriteDotNetObject(s3EncryptionClientMetadataModeKMS, KeyDotNetMetaKMSEncryptionOnly);
            WriteDotNetObject(s3EncryptionClientMetadataMode, KeyDotNetMetaAESEncryptionOnly);
            WriteDotNetObject(s3EncryptionClientFileMode, KeyDotNetFileAESEncryptionOnly);

            AssertExtensions.ExpectException(() =>
            {
                WriteDotNetObject(s3EncryptionClientFileModeKMS, KeyDotNetFileKMSEncryptionOnly);
            }, typeof(AmazonClientException), InstructionAndKMSErrorMessage);
        }

        private void TestReadJavaObject(AmazonS3EncryptionClient encryptionClient, string s3Key,
            Type exceptionType, Regex errorMessageRegex)
        {
            var request = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = s3Key
            };
            GetObjectResponse response = null;

            if (exceptionType == null && errorMessageRegex == null)
            {
                response = WrapNoSuchKeyException(encryptionClient, request);
                using (var stream = response.ResponseStream)
                using (var reader = new StreamReader(stream))
                {
                    Assert.AreEqual(TestObjectContents, reader.ReadToEnd());
                }
                response.Dispose();
            }
            else
            {
                AssertExtensions.ExpectException(() =>
                {
                    response = WrapNoSuchKeyException(encryptionClient, request);
                }, exceptionType, errorMessageRegex);
            }
        }

        private void WriteDotNetObject(AmazonS3EncryptionClient client, string s3Key)
        {
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = s3Key,
                ContentBody = TestObjectContents
            };
            client.PutObject(request);
        }

        private static GetObjectResponse WrapNoSuchKeyException(AmazonS3EncryptionClient encryptionClient, GetObjectRequest request)
        {
            GetObjectResponse response;
            try
            {
                response = encryptionClient.GetObject(request);
            }
            catch (Exception e)
            {
                AmazonS3Exception s3Exception = e as AmazonS3Exception;
                if (s3Exception != null && NoSuchKeyErrorCode.Equals(s3Exception.ErrorCode))
                    throw new Exception("One or more of the objects expected to be written by the Java test are missing.  " +
                        "Please run EncryptionInteropTest.java and then re-run this test.");
                else
                    throw;
            }
            return response;
        }

        private static string GetOrCreateKMSKey(AmazonS3Client s3Client,
            AmazonKeyManagementServiceClient kmsClient, string bucketName)
        {
            try
            {
                // look for the s3 object that tells us the KMS key has been created
                GetObjectRequest getObjectRequest = new GetObjectRequest()
                {
                    BucketName = bucketName,
                    Key = KeyKMSKeyId
                };

                using (var getObjectResponse = s3Client.GetObject(getObjectRequest))
                using (var stream = getObjectResponse.ResponseStream)
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (AmazonS3Exception e)
            {
                if (NoSuchKeyErrorCode.Equals(e.ErrorCode))
                {
                    //create the KMS key
                    CreateKeyRequest createKeyRequest = new CreateKeyRequest();
                    createKeyRequest.Description = "Key used for Java/.NET S3 encryption client interoperability tests.";
                    CreateKeyResponse createKeyResponse = kmsClient.CreateKey(createKeyRequest);
                    String kmsKeyId = createKeyResponse.KeyMetadata.KeyId;

                    //save the KMS key ID into s3
                    PutObjectRequest putObjectRequest = new PutObjectRequest
                    {
                        BucketName = bucketName,
                        Key = KeyKMSKeyId,
                        ContentBody = kmsKeyId
                    };
                    s3Client.PutObject(putObjectRequest);
                    return kmsKeyId;
                }
                else
                {
                    throw;
                }
            }
        }

        private static string GetOrCreateBucket(AmazonS3Client s3Client)
        {
            foreach (var bucket in s3Client.ListBuckets().Buckets)
            {
                if (bucket.BucketName.StartsWith(InteropBucketRoot))
                    return bucket.BucketName;
            }

            var newBucketName = InteropBucketRoot + DateTime.UtcNow.ToFileTime();
            s3Client.PutBucket(newBucketName);
            return newBucketName;
        }

        private static SymmetricAlgorithm GetOrCreateSymmetricAlgorithm(AmazonS3Client s3Client, string bucketName)
        {
            SymmetricAlgorithm result = AesManaged.Create();
            try
            {
                // look for the s3 object that tells us the KMS key has been created
                GetObjectRequest getObjectRequest = new GetObjectRequest()
                {
                    BucketName = bucketName,
                    Key = KeySymmetricKey
                };

                using (var getObjectResponse = s3Client.GetObject(getObjectRequest))
                using (var stream = getObjectResponse.ResponseStream)
                {
                    byte[] keyBytes = new byte[32];
                    stream.Read(keyBytes, 0, keyBytes.Length);
                    result.Key = keyBytes;
                    return result;
                }
            }
            catch (AmazonS3Exception e)
            {
                if (NoSuchKeyErrorCode.Equals(e.ErrorCode))
                {
                    //create the symmetric key
                    result.GenerateKey();

                    //save the KMS key ID into s3
                    PutObjectRequest putObjectRequest = new PutObjectRequest
                    {
                        BucketName = bucketName,
                        Key = KeySymmetricKey,
                        InputStream = new MemoryStream(result.Key)
                    };
                    s3Client.PutObject(putObjectRequest);
                    return result;
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
