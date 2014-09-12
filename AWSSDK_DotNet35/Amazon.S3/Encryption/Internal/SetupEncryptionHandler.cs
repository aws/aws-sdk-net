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
    public class SetupEncryptionHandler : GenericHandler
    {
        public SetupEncryptionHandler(AmazonS3EncryptionClient encryptionClient)
        {
            this.EncryptionClient = encryptionClient;
        }

        public AmazonS3EncryptionClient EncryptionClient
        {
            get;
            private set;
        }

        protected override void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.OriginalRequest;
            var putObjectRequest = request as PutObjectRequest;

            if (putObjectRequest != null)
            {
                if (EncryptionClient.S3CryptoConfig.StorageMode == CryptoStorageMode.InstructionFile)
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
                EncryptionInstructions instructions = EncryptionUtils.GenerateInstructions(this.EncryptionClient.EncryptionMaterials);

                if (EncryptionClient.S3CryptoConfig.StorageMode == CryptoStorageMode.ObjectMetadata)
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
        /// Updates the request where the metadata contains encryption information 
        /// and the input stream contains the encrypted object contents.
        /// </summary>
        /// <param name="putObjectRequest">
        /// The request whose contents are to be encrypted.
        /// </param>
        private void GenerateEncryptedObjectRequestUsingMetadata(PutObjectRequest putObjectRequest)
        {
            // Create instruction
            EncryptionInstructions instructions = EncryptionUtils.GenerateInstructions(this.EncryptionClient.EncryptionMaterials);

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
            EncryptionInstructions instructions = EncryptionUtils.GenerateInstructions(this.EncryptionClient.EncryptionMaterials);

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
            request.RequestState.Add(AmazonS3EncryptionClient.S3CryptoStream, request.InputStream);
        }
    }
}
