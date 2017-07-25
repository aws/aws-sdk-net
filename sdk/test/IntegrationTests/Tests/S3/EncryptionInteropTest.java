import java.io.ByteArrayInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.nio.charset.StandardCharsets;
import java.security.NoSuchAlgorithmException;
import java.util.Date;

import javax.crypto.KeyGenerator;
import javax.crypto.SecretKey;
import javax.crypto.spec.SecretKeySpec;

import com.amazonaws.regions.Regions;
import com.amazonaws.services.kms.AWSKMS;
import com.amazonaws.services.kms.AWSKMSClientBuilder;
import com.amazonaws.services.kms.model.CreateKeyRequest;
import com.amazonaws.services.kms.model.CreateKeyResult;
import com.amazonaws.services.s3.AmazonS3;
import com.amazonaws.services.s3.AmazonS3ClientBuilder;
import com.amazonaws.services.s3.AmazonS3EncryptionClientBuilder;
import com.amazonaws.services.s3.model.AmazonS3Exception;
import com.amazonaws.services.s3.model.Bucket;
import com.amazonaws.services.s3.model.CreateBucketRequest;
import com.amazonaws.services.s3.model.CryptoConfiguration;
import com.amazonaws.services.s3.model.CryptoMode;
import com.amazonaws.services.s3.model.CryptoStorageMode;
import com.amazonaws.services.s3.model.EncryptionMaterials;
import com.amazonaws.services.s3.model.EncryptionMaterialsProvider;
import com.amazonaws.services.s3.model.GetObjectRequest;
import com.amazonaws.services.s3.model.KMSEncryptionMaterialsProvider;
import com.amazonaws.services.s3.model.ObjectMetadata;
import com.amazonaws.services.s3.model.PutObjectRequest;
import com.amazonaws.services.s3.model.S3Object;
import com.amazonaws.services.s3.model.StaticEncryptionMaterialsProvider;
import com.amazonaws.util.IOUtils;

/**
 * This is a test to verify that .NET's AmazonS3EncryptionClient is interoparable with Java's.
 * To verify interoperability you must successfully run this test and EncryptionInteropTest.cs.
 * This test puts objects to be read by the .NET test, and the .NET test puts object to be read by this test.
 *
 * This test was originally written and run against the AWS SDK for Java Version 1.11.144.
 * This file is included as a stand alone java file in the .NET SDK repo; in order to run it you must set up the dependencies on your own.
 */
public class EncryptionInteropTest {

    // bucket name
    private static final String InteropBucketRoot = "java-dotnet-s3-interop-test-do-not-delete-";

    // key information S3 keys
    private static final String KeyKMSKeyId = "KMSKeyId";
    private static final String KeySymmetricKey = "SymmetricKey";

    // S3 objects written by this test and read by the .NET test
    private static final String KeyJavaMetaKMSEncryptionOnly = "JavaMetaKMSEncryptionOnly";
    private static final String KeyJavaMetaKMSAuthenticatedEncryption = "JavaMetaKMSAuthenticatedEncryption";
    private static final String KeyJavaFileKMSEncryptionOnly = "JavaFileKMSEncryptionOnly";
    private static final String KeyJavaFileKMSAuthenticatedEncryption = "JavaFileKMSAuthenticatedEncryption";
    private static final String KeyJavaMetaAESEncryptionOnly = "JavaMetaAESEncryptionOnly";
    private static final String KeyJavaMetaAESAuthenticatedEncryption = "JavaMetaAESAuthenticatedEncryption";
    private static final String KeyJavaFileAESEncryptionOnly = "JavaFileAESEncryptionOnly";
    private static final String KeyJavaFileAESAuthenticatedEncryption = "JavaFileAESAuthenticatedEncryption";
    private static final String NoSuchKeyErrorCode = "NoSuchKey";

    // S3 objects written by the .NET test and read by this test
    private static final String KeyDotNetMetaKMSEncryptionOnly = "DotNetMetaKMSEncryptionOnly";
    // The .NET client doesn't support instruction files with KMS key wrapping yet.
    //private static final String KeyDotNetFileKMSEncryptionOnly = "DotNetFileKMSEncryptionOnly";
    private static final String KeyDotNetMetaAESEncryptionOnly = "DotNetMetaAESEncryptionOnly";
    private static final String KeyDotNetFileAESEncryptionOnly = "DotNetFileAESEncryptionOnly";

    private static final String TestObjectContents = "JavaDotnetS3EncryptionInteropTestContents";
    private static final byte[] TestObjectContentsBytes = TestObjectContents.getBytes();

    private static AmazonS3 s3Client;
    private static AWSKMS kmsClient;
    private static String bucketName;
    private static String kmsKeyId;
    private static SecretKey secretKey;

    /**
     * This method:
     * 1. Sets up resources shared with the .NET test if they're not already set up.
     * 2. Writes objects to S3 that will be read and verified by the .NET counterpart to this test.
     * 3. Reads and verifies S3 objects that were written by the .NET counterpart to this test.
     * @param args
     * @throws Exception
     */
    public static void main(String[] args) throws Exception {
        setupSharedResources();
        putObjectsForDotNetToRead();
        getAndVerifyObjectsWrittenByDotNet();

        System.out.println("All tests passed.");
    }

    private static void setupSharedResources() throws Exception {
        s3Client = AmazonS3ClientBuilder.standard().withRegion(Regions.US_EAST_1.getName()).build();
        kmsClient = AWSKMSClientBuilder.standard().withRegion(Regions.US_EAST_1.getName()).build();

        bucketName = getOrCreateBucket(s3Client);
        kmsKeyId = getOrCreateKMSKey(s3Client, kmsClient, bucketName);
        secretKey = getOrCreateSecretKey(s3Client, bucketName);
    }

    private static void putObjectsForDotNetToRead() throws IOException {
        putObjectForDotNetToRead(KeyJavaMetaKMSAuthenticatedEncryption, CryptoStorageMode.ObjectMetadata, CryptoMode.AuthenticatedEncryption, true);
        putObjectForDotNetToRead(KeyJavaMetaKMSEncryptionOnly, CryptoStorageMode.ObjectMetadata, CryptoMode.EncryptionOnly, true);
        putObjectForDotNetToRead(KeyJavaFileKMSAuthenticatedEncryption, CryptoStorageMode.InstructionFile, CryptoMode.AuthenticatedEncryption, true);
        putObjectForDotNetToRead(KeyJavaFileKMSEncryptionOnly, CryptoStorageMode.InstructionFile, CryptoMode.EncryptionOnly, true);
        putObjectForDotNetToRead(KeyJavaMetaAESAuthenticatedEncryption, CryptoStorageMode.ObjectMetadata, CryptoMode.AuthenticatedEncryption, false);
        putObjectForDotNetToRead(KeyJavaMetaAESEncryptionOnly, CryptoStorageMode.ObjectMetadata, CryptoMode.EncryptionOnly, false);
        putObjectForDotNetToRead(KeyJavaFileAESAuthenticatedEncryption, CryptoStorageMode.InstructionFile, CryptoMode.AuthenticatedEncryption, false);
        putObjectForDotNetToRead(KeyJavaFileAESEncryptionOnly, CryptoStorageMode.InstructionFile, CryptoMode.EncryptionOnly,  false);
    }

    private static void getAndVerifyObjectsWrittenByDotNet() throws IOException {
        getAndVerifyObjectWrittenByDotNet(KeyDotNetMetaKMSEncryptionOnly, CryptoStorageMode.ObjectMetadata, true, true);
        // The .NET client doesn't support instruction files with KMS key wrapping yet.
        //getAndVerifyObjectWrittenByDotNet(KeyDotNetFileKMSEncryptionOnly, CryptoStorageMode.InstructionFile, true, true);
        getAndVerifyObjectWrittenByDotNet(KeyDotNetMetaAESEncryptionOnly, CryptoStorageMode.ObjectMetadata, false, true);
        getAndVerifyObjectWrittenByDotNet(KeyDotNetFileAESEncryptionOnly, CryptoStorageMode.InstructionFile, false, false);
    }

    private static void putObjectForDotNetToRead(String s3Key, CryptoStorageMode storageMode, CryptoMode cryptoMode,  boolean useKMS) throws IOException {
        AmazonS3 encryptionClient = buildEncryptionClient(storageMode, cryptoMode, useKMS);
        PutObjectRequest putObjectRequest = new PutObjectRequest(bucketName, s3Key, new ByteArrayInputStream(TestObjectContentsBytes), new ObjectMetadata());
        encryptionClient.putObject(putObjectRequest);
    }

    private static void getAndVerifyObjectWrittenByDotNet(String s3Key, CryptoStorageMode storageMode, boolean useKms, boolean contentShouldMatch) throws IOException {
        AmazonS3 encryptionClient = buildEncryptionClient(storageMode, CryptoMode.EncryptionOnly, useKms);
        S3Object s3Object;
        try {
            s3Object = encryptionClient.getObject(bucketName, s3Key);
            String content = new String(IOUtils.toByteArray(s3Object.getObjectContent()), StandardCharsets.UTF_8);
            boolean contentMatches = TestObjectContents.equals(content);
            if (contentMatches != contentShouldMatch) {
                if (contentShouldMatch)
                    throw new RuntimeException("Expected <" + TestObjectContents + "> got <" + content + ">");
                else
                    throw new RuntimeException("Expected content to still be encrypted.");
            }
        } catch (AmazonS3Exception e) {
            if (NoSuchKeyErrorCode.equals(e.getErrorCode())) {
                throw new RuntimeException("One or more of the objects expected to be written by the .NET test are missing.  Please run EncryptionInteropTest.cs and then re-run this test.");
            }
        }
    }

    private static AmazonS3 buildEncryptionClient(CryptoStorageMode storageMode, CryptoMode cryptoMode, boolean useKMS) {
        EncryptionMaterialsProvider encryptionMaterials = useKMS ?
                new KMSEncryptionMaterialsProvider(kmsKeyId) :
                new StaticEncryptionMaterialsProvider(new EncryptionMaterials(secretKey));

        return  AmazonS3EncryptionClientBuilder.standard()
                .withRegion(Regions.US_EAST_1.getName())
                .withEncryptionMaterials(encryptionMaterials)
                .withCryptoConfiguration(new CryptoConfiguration()
                        .withCryptoMode(cryptoMode)
                        .withStorageMode(storageMode))
                .build();
    }

    private static String getOrCreateKMSKey(AmazonS3 s3Client, AWSKMS kmsClient, String bucketName) throws IOException {
        try {
            // look for the s3 object that tells us the KMS key has been created
            GetObjectRequest getObjectRequest = new GetObjectRequest(bucketName, KeyKMSKeyId);
            S3Object kmsKeyIdObject = s3Client.getObject(getObjectRequest);
            return new String(IOUtils.toByteArray(kmsKeyIdObject.getObjectContent()), StandardCharsets.UTF_8);
        } catch (AmazonS3Exception e) {
            if (NoSuchKeyErrorCode.equals(e.getErrorCode())) {
                //create the KMS key
                CreateKeyRequest createKeyRequest = new CreateKeyRequest();
                createKeyRequest.setDescription("Key used for Java/.NET S3 encryption client interoperability tests.");
                CreateKeyResult createKeyResult = kmsClient.createKey(createKeyRequest);
                String kmsKeyId = createKeyResult.getKeyMetadata().getKeyId();

                //save the KMS key ID into s3
                InputStream inputStream = new ByteArrayInputStream(kmsKeyId.getBytes());
                PutObjectRequest putObjectRequest = new PutObjectRequest(bucketName, KeyKMSKeyId, inputStream, new ObjectMetadata());
                s3Client.putObject(putObjectRequest);

                return kmsKeyId;
            } else {
                throw e;
            }
        }
    }

    private static SecretKey getOrCreateSecretKey(AmazonS3 s3Client, String bucketName) throws IOException, NoSuchAlgorithmException {
        try {
            // look for the secret key s3 object
            GetObjectRequest getObjectRequest = new GetObjectRequest(bucketName, KeySymmetricKey);
            S3Object secretKeyObject = s3Client.getObject(getObjectRequest);
            return new SecretKeySpec(IOUtils.toByteArray(secretKeyObject.getObjectContent()), "AES");
        } catch (AmazonS3Exception e) {
            if (NoSuchKeyErrorCode.equals(e.getErrorCode())) {
                //create the secret key
                KeyGenerator keyGenerator = KeyGenerator.getInstance("AES");
                keyGenerator.init(256);
                SecretKey secretKey = keyGenerator.generateKey();

                //save the secret key into s3
                InputStream inputStream = new ByteArrayInputStream(secretKey.getEncoded());
                PutObjectRequest putObjectRequest = new PutObjectRequest(bucketName, KeySymmetricKey, inputStream, new ObjectMetadata());
                s3Client.putObject(putObjectRequest);

                return secretKey;
            } else {
                throw e;
            }
        }
    }

    private static String getOrCreateBucket(AmazonS3 s3Client) {
        for(Bucket bucket : s3Client.listBuckets()) {
           if (bucket.getName().startsWith(InteropBucketRoot)) {
                return bucket.getName();
            }
        }

        CreateBucketRequest request = new CreateBucketRequest(InteropBucketRoot + (new Date().getTime()));
        Bucket bucket = s3Client.createBucket(request);
        return bucket.getName();
    }
}