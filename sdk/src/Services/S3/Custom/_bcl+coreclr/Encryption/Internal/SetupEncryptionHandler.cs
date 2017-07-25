using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Runtime;
using Amazon.S3.Model;
using System.IO;

using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.S3.Encryption.Internal
{
    /// <summary>
    /// Custom pipeline handler to encrypt the data as it is being uploaded to S3.
    /// </summary>
    public class SetupEncryptionHandler : PipelineHandler
    {
        /// <summary>
        /// Construct an instance SetupEncryptionHandler.
        /// </summary>
        /// <param name="encryptionClient"></param>
        public SetupEncryptionHandler(AmazonS3EncryptionClient encryptionClient)
        {
            this.EncryptionClient = encryptionClient;
        }

        /// <summary>
        /// Gets the EncryptionClient property which is the AmazonS3EncryptionClient that is encrypting the object.
        /// </summary>
        public AmazonS3EncryptionClient EncryptionClient
        {
            get;
            private set;
        }

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }

        /// <summary>
        /// Encrypts the S3 object being uploaded.
        /// </summary>
        /// <param name="executionContext"></param>
        protected void PreInvoke(IExecutionContext executionContext)
        {
            EncryptionInstructions instructions = null;
            if (NeedToGenerateKMSInstructions(executionContext))
                instructions = EncryptionUtils.GenerateInstructionsForKMSMaterials(
                    EncryptionClient.KMSClient, EncryptionClient.EncryptionMaterials);

            PreInvokeSynchronous(executionContext, instructions);
        }

#if AWS_ASYNC_API

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            await PreInvokeAsync(executionContext).ConfigureAwait(false);
            return await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
        }

        /// <summary>
        /// Encrypts the S3 object being uploaded.
        /// </summary>
        /// <param name="executionContext"></param>
        protected async System.Threading.Tasks.Task PreInvokeAsync(IExecutionContext executionContext)
        {
            EncryptionInstructions instructions = null;
            if (NeedToGenerateKMSInstructions(executionContext))
                instructions = await EncryptionUtils.GenerateInstructionsForKMSMaterialsAsync(
                    EncryptionClient.KMSClient, EncryptionClient.EncryptionMaterials).ConfigureAwait(false);

            PreInvokeSynchronous(executionContext, instructions);
        }

#elif AWS_APM_API

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent an async operation.</returns>
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            IExecutionContext syncExecutionContext = ExecutionContext.CreateFromAsyncContext(executionContext);

            if (NeedToGenerateKMSInstructions(syncExecutionContext))
                throw new NotSupportedException("The AWS SDK for .NET Framework 3.5 version of " +
                    typeof(AmazonS3EncryptionClient).Name + " does not support KMS key wrapping via the async programming model.  " +
                    "Please use the synchronous version instead.");

            PreInvokeSynchronous(syncExecutionContext, null);
            return base.InvokeAsync(executionContext);
        }

#endif

        private bool NeedToGenerateKMSInstructions(IExecutionContext executionContext)
        {
            return EncryptionClient.EncryptionMaterials.KMSKeyID != null &&
                NeedToGenerateInstructions(executionContext);
        }

        private static bool NeedToGenerateInstructions(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.OriginalRequest;
            var putObjectRequest = request as PutObjectRequest;
            var initiateMultiPartUploadRequest = request as InitiateMultipartUploadRequest;
            return putObjectRequest != null || initiateMultiPartUploadRequest != null;
        }

        private void PreInvokeSynchronous(IExecutionContext executionContext, EncryptionInstructions instructions)
        {
            var request = executionContext.RequestContext.OriginalRequest;
            var putObjectRequest = request as PutObjectRequest;
            var initiateMultiPartUploadRequest = request as InitiateMultipartUploadRequest;
            var uploadPartRequest = request as UploadPartRequest;
            var useKMSKeyWrapping = this.EncryptionClient.EncryptionMaterials.KMSKeyID != null;

            if (instructions == null && NeedToGenerateInstructions(executionContext))
                instructions = EncryptionUtils.GenerateInstructionsForNonKMSMaterials(
                    EncryptionClient.EncryptionMaterials);

            if (putObjectRequest != null)
            {
                ValidateConfigAndMaterials();
                if (EncryptionClient.S3CryptoConfig.StorageMode == CryptoStorageMode.ObjectMetadata)
                    GenerateEncryptedObjectRequestUsingMetadata(putObjectRequest, instructions);
                else
                    GenerateEncryptedObjectRequestUsingInstructionFile(putObjectRequest, instructions);
            }

            if (initiateMultiPartUploadRequest != null)
            {
                ValidateConfigAndMaterials();
                if (EncryptionClient.S3CryptoConfig.StorageMode == CryptoStorageMode.ObjectMetadata)
                {
                    EncryptionUtils.UpdateMetadataWithEncryptionInstructions(
                        initiateMultiPartUploadRequest, instructions, useKMSKeyWrapping);
                }

                initiateMultiPartUploadRequest.StorageMode = EncryptionClient.S3CryptoConfig.StorageMode;
                initiateMultiPartUploadRequest.EncryptedEnvelopeKey = instructions.EncryptedEnvelopeKey;
                initiateMultiPartUploadRequest.EnvelopeKey = instructions.EnvelopeKey;
                initiateMultiPartUploadRequest.IV = instructions.InitializationVector;
            }

            if (uploadPartRequest != null)
            {
                GenerateEncryptedUploadPartRequest(uploadPartRequest);
            }
        }

        /// <summary>
        /// Make sure that the storage mode and encryption materials are compatible.
        /// The client only supports KMS key wrapping in metadata storage mode.
        /// </summary>
        private void ValidateConfigAndMaterials()
        {
            var usingKMSKeyWrapping = this.EncryptionClient.EncryptionMaterials.KMSKeyID != null;
            var usingMetadataStorageMode = EncryptionClient.S3CryptoConfig.StorageMode == CryptoStorageMode.ObjectMetadata;
            if (usingKMSKeyWrapping && !usingMetadataStorageMode)
                throw new AmazonClientException("AmazonS3EncryptionClient only supports KMS key wrapping in metadata storage mode. " +
                    "Please set StorageMode to CryptoStorageMode.ObjectMetadata or refrain from using KMS EncryptionMaterials.");
        }

        /// <summary>
        /// Updates the request where the metadata contains encryption information 
        /// and the input stream contains the encrypted object contents.
        /// </summary>
        /// <param name="putObjectRequest">
        /// The request whose contents are to be encrypted.
        /// </param>
        private void GenerateEncryptedObjectRequestUsingMetadata(PutObjectRequest putObjectRequest, EncryptionInstructions instructions)
        {
            EncryptionUtils.AddUnencryptedContentLengthToMetadata(putObjectRequest);

            // Encrypt the object data with the instruction
            putObjectRequest.InputStream = EncryptionUtils.EncryptRequestUsingInstruction(putObjectRequest.InputStream, instructions);

            // Update the metadata
            EncryptionUtils.UpdateMetadataWithEncryptionInstructions(
                putObjectRequest, instructions, this.EncryptionClient.EncryptionMaterials.KMSKeyID != null);
        }

        /// <summary>
        /// Updates the request where the instruction file contains encryption information 
        /// and the input stream contains the encrypted object contents.
        /// </summary>
        /// <param name="putObjectRequest"></param>
        private void GenerateEncryptedObjectRequestUsingInstructionFile(PutObjectRequest putObjectRequest, EncryptionInstructions instructions)
        {
            EncryptionUtils.AddUnencryptedContentLengthToMetadata(putObjectRequest);

            // Encrypt the object data with the instruction
            putObjectRequest.InputStream = EncryptionUtils.EncryptRequestUsingInstruction(putObjectRequest.InputStream, instructions);

            // Create request for uploading instruction file 
            PutObjectRequest instructionFileRequest = EncryptionUtils.CreateInstructionFileRequest(putObjectRequest, instructions);

            this.EncryptionClient.S3ClientForInstructionFile.PutObject(instructionFileRequest);
        }

        /// <summary>
        /// Updates the request where the input stream contains the encrypted object contents.
        /// </summary>
        /// <param name="request"></param>
        private void GenerateEncryptedUploadPartRequest(UploadPartRequest request)
        {
            string uploadID = request.UploadId;

            UploadPartEncryptionContext contextForEncryption = this.EncryptionClient.CurrentMultiPartUploadKeys[uploadID];
            byte[] envelopeKey = contextForEncryption.EnvelopeKey;
            byte[] IV = contextForEncryption.NextIV;

            EncryptionInstructions instructions = new EncryptionInstructions(EncryptionClient.EncryptionMaterials.MaterialsDescription, envelopeKey, IV);

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
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).RequestState.Add(AmazonS3EncryptionClient.S3CryptoStream, request.InputStream);
        }
    }
}
