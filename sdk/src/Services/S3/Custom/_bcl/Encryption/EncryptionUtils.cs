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

using System;
using System.IO;
using System.Security.Cryptography;
using Amazon.S3.Model;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime;
using ThirdParty.Json.LitJson;
using System.Collections.Generic;
using System.Globalization;

namespace Amazon.S3.Encryption
{
    /// <summary>
    /// The EncryptionUtils class encrypts and decrypts data stored in S3.
    /// It can be used to prepare requests for encryption before they are stored in S3
    /// and to decrypt objects that are retrieved from S3.
    /// </summary>
    public static class EncryptionUtils
    {
        /// <summary>
        /// Encrypts a Envelope key using the provided encryption materials
        /// and returns it in raw byte array form.
        /// </summary>

        private const string instructionfileSuffix = "INSTRUCTION_SUFFIX";
        private const string keyInMetadata = "x-amz-key";
        private const string initVectorInMetadata = "x-amz-iv";
        private const string encryptionMaterialsDescription = "x-amz-matdesc";
        private const string instructionFileInfo = "x-amz-crypto-instr-file";
        private const string unEncryptedContentLength = "x-amz-unencrypted-content-length";

        internal static byte[] EncryptEnvelopeKey(byte[] envelopeKey, EncryptionMaterials materials)
        {
            if (materials.AsymmetricProvider != null)
            {
                return (EncryptEnvelopeKeyUsingAsymmetricKeyPair(materials.AsymmetricProvider, envelopeKey));
            }
            else
            {
                return (EncryptEnvelopeKeyUsingSymmetricKey(materials.SymmetricProvider, envelopeKey));
            }
        }

        private static byte[] EncryptEnvelopeKeyUsingAsymmetricKeyPair(AsymmetricAlgorithm asymmetricAlgorithm, byte[] envelopeKey)
        {
            RSACryptoServiceProvider rsaCrypto = asymmetricAlgorithm as RSACryptoServiceProvider;
            return (rsaCrypto.Encrypt(envelopeKey, false));
        }

        private static byte[] EncryptEnvelopeKeyUsingSymmetricKey(SymmetricAlgorithm symmetricAlgorithm, byte[] envelopeKey)
        {
            symmetricAlgorithm.Mode = CipherMode.ECB;
            using (ICryptoTransform encryptor = symmetricAlgorithm.CreateEncryptor())
            {
                return (encryptor.TransformFinalBlock(envelopeKey, 0, envelopeKey.Length));
            }
        }

        /// <summary>
        /// Decrypts an encrypted Envelope key using the provided encryption materials
        /// and returns it in raw byte array form.
        /// </summary>
        /// <param name="encryptedEnvelopeKey"> Encrypted envelope key</param>
        /// <param name="materials">Encryption materials needed to decrypt the encrypted envlelope key</param>
        /// <returns></returns>
        internal static byte[] DecryptEnvelopeKey(byte[] encryptedEnvelopeKey, EncryptionMaterials materials)
        {
            if (materials.AsymmetricProvider != null)
            {
                return (DecryptEnvelopeKeyUsingAsymmetricKeyPair(materials.AsymmetricProvider, encryptedEnvelopeKey));
            }
            else
            {
                return (DecryptEnvelopeKeyUsingSymmetricKey(materials.SymmetricProvider, encryptedEnvelopeKey));
            }
        }

        private static byte[] DecryptEnvelopeKeyUsingAsymmetricKeyPair(AsymmetricAlgorithm asymmetricAlgorithm, byte[] encryptedEnvelopeKey)
        {
            RSACryptoServiceProvider rsaCrypto = asymmetricAlgorithm as RSACryptoServiceProvider;
            return (rsaCrypto.Decrypt(encryptedEnvelopeKey, false));
        }

        private static byte[] DecryptEnvelopeKeyUsingSymmetricKey(SymmetricAlgorithm symmetricAlgorithm, byte[] encryptedEnvelopeKey)
        {
            symmetricAlgorithm.Mode = CipherMode.ECB;
            using (ICryptoTransform decryptor = symmetricAlgorithm.CreateDecryptor())
            {
                return (decryptor.TransformFinalBlock(encryptedEnvelopeKey, 0, encryptedEnvelopeKey.Length));
            }
        }

        #region StreamEncryption

        /// <summary>
        /// Returns an updated stream where the stream contains the encrypted object contents.
        /// The specified instruction will be used to encrypt data.
        /// </summary>
        /// <param name="toBeEncrypted">
        /// The stream whose contents are to be encrypted.
        /// </param>
        /// <param name="instructions">
        /// The instruction that will be used to encrypt the object data.
        /// </param>
        /// <returns>
        /// Encrypted stream, i.e input stream wrapped into encrypted stream
        /// </returns>
        internal static Stream EncryptRequestUsingInstruction(Stream toBeEncrypted, EncryptionInstructions instructions)
        {
            //wrap input stream into AESEncryptionPutObjectStream wrapper
            AESEncryptionPutObjectStream aesEStream;
            aesEStream = new AESEncryptionPutObjectStream(toBeEncrypted, instructions.EnvelopeKey, instructions.InitializationVector);
            return aesEStream;

        }

        /// <summary>
        /// Returns an updated input stream where the input stream contains the encrypted object contents.
        /// The specified instruction will be used to encrypt data.
        /// </summary>
        /// <param name="toBeEncrypted">
        /// The stream whose contents are to be encrypted.
        /// </param>
        /// <param name="instructions">
        /// The instruction that will be used to encrypt the object data.
        /// </param>
        /// <returns>
        /// Encrypted stream, i.e input stream wrapped into encrypted stream
        /// </returns>
        internal static Stream EncryptUploadPartRequestUsingInstructions(Stream toBeEncrypted, EncryptionInstructions instructions)
        {
            //wrap input stream into AESEncryptionStreamForUploadPart wrapper
            AESEncryptionUploadPartStream aesEStream;
            aesEStream = new AESEncryptionUploadPartStream(toBeEncrypted, instructions.EnvelopeKey, instructions.InitializationVector);
            return aesEStream;
        }
        #endregion

        #region StreamDecrption

        /// <summary>
        /// Updates object where the object
        /// input stream contains the decrypted contents.
        /// </summary>
        /// <param name="response">
        /// The getObject response whose contents are to be decrypted.
        /// </param>
        /// <param name="instructions">
        /// The instruction that will be used to encrypt the object data.
        /// </param>
        internal static void DecryptObjectUsingInstructions(GetObjectResponse response, EncryptionInstructions instructions)
        {
            response.ResponseStream = DecryptStream(response.ResponseStream, instructions);
        }

        //wrap encrypted stream into AESDecriptionStream wrapper
        internal static Stream DecryptStream(Stream encryptedStream, EncryptionInstructions encryptionInstructions)
        {
            AESDecryptionStream aesDecryptStream;
            aesDecryptStream = new AESDecryptionStream(encryptedStream, encryptionInstructions.EnvelopeKey, encryptionInstructions.InitializationVector);
            return aesDecryptStream;
        }


        #endregion

        #region InstructionGeneration

        /// <summary>
        ///  Generates an instruction that will be used to encrypt an object.
        /// </summary>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt data.
        /// </param>
        /// <returns>
        /// The instruction that will be used to encrypt an object.
        /// </returns>
        internal static EncryptionInstructions GenerateInstructions(EncryptionMaterials materials)
        {
            Aes AesObject = Aes.Create();
            byte[] encryptedEnvelopeKey = EncryptEnvelopeKey(AesObject.Key, materials);
            return new EncryptionInstructions(EncryptionMaterials.EmptyMaterialsDescription, AesObject.Key, encryptedEnvelopeKey, AesObject.IV);
        }

        internal static GetObjectRequest GetInstructionFileRequest(GetObjectResponse response)
        {
            GetObjectRequest request = new GetObjectRequest
            {
                BucketName = response.BucketName,
                Key = response.Key + instructionfileSuffix
            };
            return request;
        }

        /// <summary>
        ///  Builds an instruction object from the object metadata.
        /// </summary>
        /// <param name="response">
        /// A non-null object response that contains encryption information in its metadata.
        /// </param>
        /// <param name="materials">
        /// The non-null encryption materials to be used to encrypt and decrypt Envelope key.
        /// </param>
        /// <returns>
        /// </returns>
        internal static EncryptionInstructions BuildInstructionsFromObjectMetadata(GetObjectResponse response, EncryptionMaterials materials)
        {
            MetadataCollection metadata = response.Metadata;

            string base64EncodedEncryptedEnvelopeKey = metadata[keyInMetadata];
            byte[] encryptedEvelopeKey = Convert.FromBase64String(base64EncodedEncryptedEnvelopeKey);
            byte[] decryptedEnvelopeKey = DecryptEnvelopeKey(encryptedEvelopeKey, materials);

            string base64EncodedIV = metadata[initVectorInMetadata];
            byte[] IV = Convert.FromBase64String(base64EncodedIV);

            return new EncryptionInstructions(EncryptionMaterials.EmptyMaterialsDescription, decryptedEnvelopeKey, encryptedEvelopeKey, IV);
        }

        /// <summary>
        /// Builds an instruction object from the instruction file.
        /// </summary>
        /// <param name="response"> Instruction file GetObject response</param>
        /// <param name="materials">
        /// The non-null encryption materials to be used to encrypt and decrypt Envelope key.
        /// </param>
        /// <returns>     
        /// A non-null instruction object containing encryption information.
        /// </returns>
        internal static EncryptionInstructions BuildInstructionsUsingInstructionFile(GetObjectResponse response, EncryptionMaterials materials)
        {
            using (TextReader textReader = new StreamReader(response.ResponseStream))
            {
                JsonData jsonData = JsonMapper.ToObject(textReader);

                var base64EncodedEncryptedEnvelopeKey = jsonData["EncryptedEnvelopeKey"];
                byte[] encryptedEvelopeKey = Convert.FromBase64String((string)base64EncodedEncryptedEnvelopeKey);
                byte[] decryptedEnvelopeKey = DecryptEnvelopeKey(encryptedEvelopeKey, materials);

                var base64EncodedIV = jsonData["IV"];
                byte[] IV = Convert.FromBase64String((string)base64EncodedIV);

                return new EncryptionInstructions(EncryptionMaterials.EmptyMaterialsDescription, decryptedEnvelopeKey, IV);
            }
        }

        #endregion

        #region UpdateMetadata

        /// <summary>
        /// Update the request's ObjectMetadata with the necessary information for decrypting the object.
        /// </summary>
        /// <param name="request">
        /// AmazonWebServiceRequest  encrypted using the given instruction
        /// </param>
        /// <param name="instructions">
        /// Non-null instruction used to encrypt the data in this AmazonWebServiceRequest .
        /// </param>
        internal static void UpdateMetadataWithEncryptionInstructions(AmazonWebServiceRequest request, EncryptionInstructions instructions)
        {
            byte[] keyBytesToStoreInMetadata = instructions.EncryptedEnvelopeKey;
            string base64EncodedEnvelopeKey = Convert.ToBase64String(keyBytesToStoreInMetadata);

            byte[] IVToStoreInMetadata = instructions.InitializationVector;
            string base64EncodedIV = Convert.ToBase64String(IVToStoreInMetadata);

            var putObjectRequest = request as PutObjectRequest;
            if (putObjectRequest != null)
            {
                MetadataCollection metadata = putObjectRequest.Metadata;
                metadata.Add(keyInMetadata, base64EncodedEnvelopeKey);
                metadata.Add(initVectorInMetadata, base64EncodedIV);

                Dictionary<string, string> materialsDescription = instructions.MaterialsDescription;
                if (materialsDescription.Count == 0)
                    metadata.Add(encryptionMaterialsDescription, "{}");

                putObjectRequest.Metadata = metadata;
            }

            var initiateMultipartrequest = request as InitiateMultipartUploadRequest;
            if (initiateMultipartrequest != null)
            {
                MetadataCollection metadata = initiateMultipartrequest.Metadata;
                metadata.Add(keyInMetadata, base64EncodedEnvelopeKey);
                metadata.Add(initVectorInMetadata, base64EncodedIV);

                Dictionary<string, string> materialsDescription = instructions.MaterialsDescription;
                if (materialsDescription.Count == 0)
                    metadata.Add(encryptionMaterialsDescription, "{}");

                initiateMultipartrequest.Metadata = metadata;
            }
        }

        internal static PutObjectRequest CreateInstructionFileRequest(AmazonWebServiceRequest request, EncryptionInstructions instructions)
        {
            byte[] keyBytesToStoreInInstructionFile = instructions.EncryptedEnvelopeKey;
            string base64EncodedEnvelopeKey = Convert.ToBase64String(keyBytesToStoreInInstructionFile);

            byte[] IVToStoreInInstructionFile = instructions.InitializationVector;
            string base64EncodedIV = Convert.ToBase64String(IVToStoreInInstructionFile);

            JsonData jsonData = new JsonData();
            jsonData["EncryptedEnvelopeKey"] = base64EncodedEnvelopeKey;
            jsonData["IV"] = base64EncodedIV;

            string credentials = jsonData.ToJson();

            var putObjectRequest = request as PutObjectRequest;
            if (putObjectRequest != null)
            {
                PutObjectRequest requestforInstructionFile = new PutObjectRequest()
                {
                    BucketName = putObjectRequest.BucketName,
                    Key = putObjectRequest.Key + instructionfileSuffix,
                    ContentBody = credentials
                };
                requestforInstructionFile.Metadata.Add(instructionFileInfo, "");
                return requestforInstructionFile;
            }

            var completeMultiPartRequest = request as CompleteMultipartUploadRequest;
            if (completeMultiPartRequest != null)
            {
                PutObjectRequest requestforInstructionFile = new PutObjectRequest()
                {
                    BucketName = completeMultiPartRequest.BucketName,
                    Key = completeMultiPartRequest.Key + instructionfileSuffix,
                    ContentBody = credentials
                };
                requestforInstructionFile.Metadata.Add(instructionFileInfo, "");
                return requestforInstructionFile;
            }

            else
                return null;
        }

        /// <summary>
        /// Adds UnEncrypted content length to object metadata
        /// </summary>
        /// <param name="request"></param>
        internal static void AddUnencryptedContentLengthToMetadata(PutObjectRequest request)
        {
            long originalLength = request.InputStream.Length;
            request.Metadata.Add(unEncryptedContentLength, originalLength.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// checks if encryption credentials are in object metadata
        /// </summary>
        /// <param name="response">Response of the object</param>
        /// <returns></returns>
        internal static bool IsEncryptionInfoInMetadata(GetObjectResponse response)
        {
            MetadataCollection metadata = response.Metadata;

            if (metadata[keyInMetadata] != null && metadata[initVectorInMetadata] != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// checks if encryption credentials are in the instructionfile
        /// </summary>
        /// <param name="response">Instruction file response that contains encryption information</param>
        /// <returns></returns>
        internal static bool IsEncryptionInfoInInstructionFile(GetObjectResponse response)
        {
            MetadataCollection metadata = response.Metadata;

            if (metadata[instructionFileInfo] != null)
                return true;
            else
                return false;
        }
        #endregion
    }
}
