/*
 * Copyright 2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using System.IO;

namespace Amazon.KeyManagementService
{
    public partial class AmazonKeyManagementServiceClient : AmazonServiceClient, IAmazonKeyManagementService
    {
        byte[] ICoreAmazonKMS.Decrypt(byte[] ciphertextBlob, Dictionary<string, string> encryptionContext)
        {
            var response = Decrypt(new Model.DecryptRequest
            {
                CiphertextBlob = new MemoryStream(ciphertextBlob),
                EncryptionContext = encryptionContext
            });
            return response.Plaintext.ToArray();
        }

        GenerateDataKeyResult ICoreAmazonKMS.GenerateDataKey(string keyID, Dictionary<string, string> encryptionContext, string keySpec)
        {
            var response = GenerateDataKey(new Model.GenerateDataKeyRequest
            {
                KeyId = keyID,
                EncryptionContext = encryptionContext,
                KeySpec = keySpec
            });

            return new GenerateDataKeyResult()
            {
                KeyPlaintext = response.Plaintext.ToArray(),
                KeyCiphertext = response.CiphertextBlob.ToArray()
            };
        }

#if AWS_ASYNC_API

        async System.Threading.Tasks.Task<byte[]> ICoreAmazonKMS.DecryptAsync(
            byte[] ciphertextBlob, Dictionary<string, string> encryptionContext)
        {
            using (var ciphertextBlobMemoryStream = new MemoryStream(ciphertextBlob))
            {
                var response = await DecryptAsync(new Model.DecryptRequest
                {
                    CiphertextBlob = ciphertextBlobMemoryStream,
                    EncryptionContext = encryptionContext
                }).ConfigureAwait(false);

                using (response.Plaintext)
                    return response.Plaintext.ToArray();
            }
        }

        async System.Threading.Tasks.Task<GenerateDataKeyResult> ICoreAmazonKMS.GenerateDataKeyAsync(
            string keyID, Dictionary<string, string> encryptionContext, string keySpec)
        {
            var response = await GenerateDataKeyAsync(new Model.GenerateDataKeyRequest
            {
                KeyId = keyID,
                EncryptionContext = encryptionContext,
                KeySpec = keySpec
            }).ConfigureAwait(false);

            return new GenerateDataKeyResult()
            {
                KeyPlaintext = response.Plaintext.ToArray(),
                KeyCiphertext = response.CiphertextBlob.ToArray()
            };
        }

#endif
    }
}