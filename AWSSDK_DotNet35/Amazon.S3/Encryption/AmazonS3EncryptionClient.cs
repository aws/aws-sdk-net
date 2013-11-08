/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;
using Amazon.Util;
using System.Collections.Generic;
using System.Globalization;

namespace Amazon.S3.Encryption
{
    public partial class AmazonS3EncryptionClient : AmazonS3Client
    {
        private EncryptionMaterials encryptionMaterials;

        private AmazonS3CryptoConfiguration amazonS3CryptoConfig;

        private AmazonS3Client s3ClientForInstructionFile;
        
        internal AmazonS3Client S3ClientForInstructionFile
	        {
	            get
	            {
	                if (s3ClientForInstructionFile == null)
	                {
                        s3ClientForInstructionFile = new AmazonS3Client(Credentials, amazonS3CryptoConfig);
                    }
	                return s3ClientForInstructionFile;
	            }
	        }

        private Dictionary<string, UploadPartEncryptionContext> currentMultiPartUploadKeys = new Dictionary<string, UploadPartEncryptionContext>();

        private const string S3CryptoStream = "S3-Crypto-Stream";

        #region Constructors
        /// <summary>
        /// Constructs AmazonS3EncryptionClient with the Encryption materials and credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// 
        /// </summary>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(EncryptionMaterials materials)
            : base()
        {
            this.encryptionMaterials = materials;
            amazonS3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with the Encryption materials and credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// 
        /// </summary>
        /// <param name="region">
        /// The region to connect.
        /// </param>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(RegionEndpoint region, EncryptionMaterials materials)
            : base(region)
        {
            this.encryptionMaterials = materials;  
            amazonS3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with the Encryption materials, 
        /// AmazonS3 CryptoConfiguration object and credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// 
        /// </summary>
        /// <param name="config">
        /// The AmazonS3EncryptionClient CryptoConfiguration Object
        /// </param>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(AmazonS3CryptoConfiguration config, EncryptionMaterials materials)
            : base(config)
        {
            this.encryptionMaterials = materials; 
            amazonS3CryptoConfig = config;
        }

        /// <summary>
        ///  Constructs AmazonS3EncryptionClient with AWS Credentials and Encryption materials.
        /// </summary>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3EncryptionClient(AWSCredentials credentials, EncryptionMaterials materials)
            : base(credentials)
        {
            this.encryptionMaterials = materials; 
            amazonS3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Credentials, Region and Encryption materials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(AWSCredentials credentials, RegionEndpoint region, EncryptionMaterials materials)
            : base(credentials, region)
        {
            this.encryptionMaterials = materials; 
            amazonS3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Credentials, AmazonS3CryptoConfiguration Configuration object
        /// and Encryption materials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">The AmazonS3EncryptionClient CryptoConfiguration Object</param>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(AWSCredentials credentials, AmazonS3CryptoConfiguration config, EncryptionMaterials materials)
            : base(credentials, config)
        {
            this.encryptionMaterials = materials; 
            amazonS3CryptoConfig = config;
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Access Key ID,
        /// AWS Secret Key and Encryption materials
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="materials">The encryption materials to be used to encrypt and decrypt envelope key.</param>
        public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, EncryptionMaterials materials)
            : base(awsAccessKeyId, awsSecretAccessKey)
        {
            this.encryptionMaterials = materials;
            amazonS3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Access Key ID,
        /// AWS Secret Key, Region and Encryption materials
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        /// <param name="materials">The encryption materials to be used to encrypt and decrypt envelope key.</param>
        public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region, EncryptionMaterials materials)
            : base(awsAccessKeyId, awsSecretAccessKey, region)
        {
            this.encryptionMaterials = materials; 
            amazonS3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Access Key ID, Secret Key,
        /// AmazonS3 CryptoConfiguration object and Encryption materials.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The AmazonS3EncryptionClient CryptoConfiguration Object</param>
        /// <param name="materials">The encryption materials to be used to encrypt and decrypt envelope key.</param>
        public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3CryptoConfiguration config, EncryptionMaterials materials)
            : base(awsAccessKeyId, awsSecretAccessKey, config)
        {
            this.encryptionMaterials = materials;
            amazonS3CryptoConfig = config;
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Access Key ID, Secret Key,
        /// SessionToken and Encryption materials.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, EncryptionMaterials materials)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken)
        {
            this.encryptionMaterials = materials; 
            amazonS3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Access Key ID, Secret Key,
        ///  SessionToken, Region and Encryption materials.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        /// <param name="materials">The encryption materials to be used to encrypt and decrypt envelope key.</param>
        public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region, EncryptionMaterials materials)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, region)
        {
            this.encryptionMaterials = materials; 
            amazonS3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Access Key ID, Secret Key, SessionToken
        /// AmazonS3EncryptionClient CryptoConfiguration object and Encryption materials.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="config">The AmazonS3EncryptionClient CryptoConfiguration Object</param>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3CryptoConfiguration config, EncryptionMaterials materials)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, config)
        {
            this.encryptionMaterials = materials; 
            amazonS3CryptoConfig = config;
        }        

        #endregion

        /// <summary>
        /// Performs encryption for PutObject and MultiPartUpload,
        /// also adding encryption information to object metadata or
        /// instruction file
        /// </summary>
        /// <param name="request">AmazonWebServiceRequest on which encryption is performed </param>
        protected override void ProcessPreRequestHandlers(AmazonWebServiceRequest request)
        {
            base.ProcessPreRequestHandlers(request);

            var putObjectRequest = request as PutObjectRequest;
            if (putObjectRequest != null)
            {
                if (this.amazonS3CryptoConfig.StorageMode == CryptoStorageMode.InstructionFile)
                {
                    GenerateEncryptedObjectRequestUsingInstructionFile(putObjectRequest);
                }
                else
                {
                    GenerateEncryptedObjectRequestUsingMetadata(putObjectRequest);
                }
            }

            var initiateMultiPartRequest = request as InitiateMultipartUploadRequest;
            if (initiateMultiPartRequest != null)
            {
                EncryptionInstructions instructions = EncryptionUtils.GenerateInstructions(this.encryptionMaterials);

                if (this.amazonS3CryptoConfig.StorageMode == CryptoStorageMode.ObjectMetadata)
                {
                    EncryptionUtils.UpdateMetadataWithEncryptionInstructions(initiateMultiPartRequest, instructions);
                }

                initiateMultiPartRequest.EnvelopeKey = instructions.EnvelopeKey;
                initiateMultiPartRequest.IV = instructions.InitializationVector;
            }

            var uploadPartRequest = request as UploadPartRequest;
            if (uploadPartRequest != null)
            {
                GenerateEncryptedUploadPartRequest(uploadPartRequest);
            }
        }

        /// <summary>
        /// Performs decryption of data by getting encryption information
        /// from object metadata or instruction file.
        /// </summary>
        /// <param name="response">AmazonWebServiceResponse on which decryption is performed</param>
        /// <param name="request">IRequest</param>
        /// <param name="webResponseData">IWebResponseData</param>
        protected override void ProcessResponseHandlers(AmazonWebServiceResponse response, IRequest request, IWebResponseData webResponseData)
        {
            base.ProcessResponseHandlers(response, request, webResponseData);

            var initiateMultiPartUploadRequest = request.OriginalRequest as InitiateMultipartUploadRequest;
            var initiateMultiPartResponse = response as InitiateMultipartUploadResponse;
            if (initiateMultiPartResponse != null)
            {
                byte[] envelopeKey = initiateMultiPartUploadRequest.EnvelopeKey;
                byte[] iv = initiateMultiPartUploadRequest.IV;

                UploadPartEncryptionContext contextForEncryption = new UploadPartEncryptionContext();
                contextForEncryption.EnvelopeKey = envelopeKey;
                contextForEncryption.NextIV = iv;
                contextForEncryption.FirstIV = iv;
                contextForEncryption.PartNumber = 0;

                //Add context for encryption of next part
                currentMultiPartUploadKeys.Add(initiateMultiPartResponse.UploadId, contextForEncryption);
            }

            var uploadPartRequest = request.OriginalRequest as UploadPartRequest;
            var uploadPartResponse = response as UploadPartResponse;
            if (uploadPartResponse != null)
            {
                string uploadID = uploadPartRequest.UploadId;
                UploadPartEncryptionContext encryptedUploadedContext = null;

                if (!currentMultiPartUploadKeys.TryGetValue(uploadID, out encryptedUploadedContext))
                    throw new AmazonS3Exception("encryption context for multi part upload not found");

                if (uploadPartRequest.IsLastPart == false)
                {
                    object stream = null;

                    if (!uploadPartRequest.RequestState.TryGetValue(S3CryptoStream, out stream))
                        throw new AmazonS3Exception("cannot retrieve S3 crypto stream from request state, hence cannot get Initialization vector for next uploadPart ");

                    var encryptionStream = stream as AESEncryptionUploadPartStream;
                    encryptedUploadedContext.NextIV = encryptionStream.InitializationVector;
                }

            }

            var getObjectResponse = response as GetObjectResponse;
            if (getObjectResponse != null)
            {
                if (EncryptionUtils.IsEncryptionInfoInMetadata(getObjectResponse) == true)
                {
                    DecryptObjectUsingMetadata(getObjectResponse);
                }
                else
                {
                    GetObjectResponse instructionFileResponse = null;
                    try
                    {
                        GetObjectRequest instructionFileRequest = EncryptionUtils.GetInstructionFileRequest(getObjectResponse);
                        instructionFileResponse = S3ClientForInstructionFile.GetObject(instructionFileRequest);
                    }
                    catch (AmazonServiceException ace)
                    {
                        throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture, "Unable to decrypt data for object {0} in bucket {1}",
                            getObjectResponse.Key, getObjectResponse.BucketName), ace);
                    }

                    if (EncryptionUtils.IsEncryptionInfoInInstructionFile(instructionFileResponse) == true)
                    {
                        DecryptObjectUsingInstructionFile(getObjectResponse, instructionFileResponse);
                    }
                }
            }

            var completeMultiPartUploadRequest = request.OriginalRequest as CompleteMultipartUploadRequest;
            var completeMultipartUploadResponse = response as CompleteMultipartUploadResponse;
            if (completeMultipartUploadResponse != null)
            {
                if (amazonS3CryptoConfig.StorageMode == CryptoStorageMode.InstructionFile)
                {
                    UploadPartEncryptionContext context = currentMultiPartUploadKeys[completeMultiPartUploadRequest.UploadId];
                    byte[] envelopeKey = context.EnvelopeKey;
                    byte[] iv = context.FirstIV;
                    byte[] encryptedEnvelopeKey = EncryptionUtils.EncryptEnvelopeKey(envelopeKey, this.encryptionMaterials);
                    EncryptionInstructions instructions = new EncryptionInstructions(EncryptionMaterials.EmptyMaterialsDescription, envelopeKey, encryptedEnvelopeKey, iv);

                    PutObjectRequest instructionFileRequest = EncryptionUtils.CreateInstructionFileRequest(completeMultiPartUploadRequest, instructions);

                    S3ClientForInstructionFile.PutObject(instructionFileRequest);
                }

                //Clear Context data since encryption is completed
                currentMultiPartUploadKeys.Clear();
            }
        }


        /// <summary>
        /// Adds user agent to headers
        /// </summary>
        /// <param name="request"></param>
        protected override void ProcessRequestHandlers(IRequest request)
        {
            base.ProcessRequestHandlers(request);
            string currentUserAgent = request.Headers[AWSSDKUtils.UserAgentHeader];
            request.Headers[AWSSDKUtils.UserAgentHeader] = currentUserAgent + " S3Crypto";
        }

        /// <summary>
        /// Updates the request where the metadata contains encryption information 
        /// and the input stream contains the encrypted object contents.
        /// </summary>
        /// <param name="putObjectRequest">
        /// The request whose contents are to be encrypted.
        /// </param>
        private void GenerateEncryptedObjectRequestUsingMetadata(PutObjectRequest putObjectRequest)
        {
            // Create instruction
            EncryptionInstructions instructions = EncryptionUtils.GenerateInstructions(this.encryptionMaterials);

            EncryptionUtils.AddUnencryptedContentLengthToMetadata(putObjectRequest);

            // Encrypt the object data with the instruction
            putObjectRequest.InputStream = EncryptionUtils.EncryptRequestUsingInstruction(putObjectRequest.InputStream, instructions);

            // Update the metadata
            EncryptionUtils.UpdateMetadataWithEncryptionInstructions(putObjectRequest, instructions);
        }

        /// <summary>
        /// Updates the request where the instruction file contains encryption information 
        /// and the input stream contains the encrypted object contents.
        /// </summary>
        /// <param name="putObjectRequest"></param>
        private void GenerateEncryptedObjectRequestUsingInstructionFile(PutObjectRequest putObjectRequest)
        {
            // Create instruction
            EncryptionInstructions instructions = EncryptionUtils.GenerateInstructions(this.encryptionMaterials);

            EncryptionUtils.AddUnencryptedContentLengthToMetadata(putObjectRequest);

            // Encrypt the object data with the instruction
            putObjectRequest.InputStream = EncryptionUtils.EncryptRequestUsingInstruction(putObjectRequest.InputStream, instructions);

            // Create request for uploading instruction file 
            PutObjectRequest instructionFileRequest = EncryptionUtils.CreateInstructionFileRequest(putObjectRequest, instructions);

            S3ClientForInstructionFile.PutObject(instructionFileRequest);
        }

        /// <summary>
        /// Updates the request where the input stream contains the encrypted object contents.
        /// </summary>
        /// <param name="request"></param>
        private void GenerateEncryptedUploadPartRequest(UploadPartRequest request)
        {
            string uploadID = request.UploadId;

            UploadPartEncryptionContext contextForEncryption = currentMultiPartUploadKeys[uploadID];
            byte[] envelopeKey = contextForEncryption.EnvelopeKey;
            byte[] IV = contextForEncryption.NextIV;

            EncryptionInstructions instructions = new EncryptionInstructions(EncryptionMaterials.EmptyMaterialsDescription, envelopeKey, IV);

            if (request.IsLastPart == false)
            {
                if (contextForEncryption.IsFinalPart == true)
                    throw new AmazonClientException("Last part has already been processed, cannot upload this as the last part");

                if (request.PartNumber < contextForEncryption.PartNumber)
                    throw new AmazonClientException("Upload Parts must in correct sequence");

                request.InputStream = EncryptionUtils.EncryptUploadPartRequestUsingInstructions(request.InputStream, instructions);
                contextForEncryption.PartNumber = request.PartNumber;
            }
            else
            {
                request.InputStream = EncryptionUtils.EncryptRequestUsingInstruction(request.InputStream, instructions);
                contextForEncryption.IsFinalPart = true;
            }
            request.RequestState.Add(S3CryptoStream, request.InputStream);
        }

        /// <summary>
        /// Updates object where the object input stream contains the decrypted contents.
        /// </summary>
        /// <param name="instructionFileResponse">
        /// The getObject response of InstructionFile.
        /// </param>
        /// <param name="response">
        /// The getObject response whose contents are to be decrypted.
        /// </param>
        private void DecryptObjectUsingInstructionFile(GetObjectResponse response, GetObjectResponse instructionFileResponse)
        {
            // Create an instruction object from the instruction file response
            EncryptionInstructions instructions = EncryptionUtils.BuildInstructionsUsingInstructionFile(instructionFileResponse, this.encryptionMaterials);

            // Decrypt the object with the instructions
            EncryptionUtils.DecryptObjectUsingInstructions(response, instructions);
        }

        /// <summary>
        /// Updates object where the object input stream contains the decrypted contents.
        /// </summary>
        /// <param name="objectResponse">
        /// The getObject response whose contents are to be decrypted.
        /// </param>
        private void DecryptObjectUsingMetadata(GetObjectResponse objectResponse)
        {
            // Create an instruction object from the object metadata
            EncryptionInstructions instructions = EncryptionUtils.BuildInstructionsFromObjectMetadata(objectResponse, this.encryptionMaterials);

            // Decrypt the object with the instruction
            EncryptionUtils.DecryptObjectUsingInstructions(objectResponse, instructions);
        }

        /// <summary>
        /// Turn off response logging because it will interfer with decrypt of the data coming back from S3.
        /// </summary>
        protected override bool SupportResponseLogging
        {
            get
            {
                return false;
            }
        }
    }
}
