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
using System.Security.Cryptography;

namespace Amazon.Extensions.CognitoAuthentication
{
    /// <summary>
    /// Class used to carry out the HKDF protocol
    /// Adapted from https://tools.ietf.org/html/rfc5869
    /// </summary>
    internal class Hkdf
    {
        /// <summary>
        /// The pseudorandom key for the HKDF protocol. Prk is generated in the
        /// constructor of Hkdf and once set cannot be changed.
        /// </summary>
        internal byte[] Prk { get; private set; }

        /// <summary>
        /// The HMACSHA256 hashing algorithm object to compute hashes while carrying out
        /// the HKDF protocol
        /// </summary>
        private HMACSHA256 HmacSha256 { get; set; }

        /// <summary>
        /// Creates an instance of Hkdf and performs the "Extract" portion of the HKDF protocol
        /// to generate the pseudorandom key property
        /// </summary>
        /// <param name="salt">The salt for the extraction hash</param>
        /// <param name="ikm">The input key material for the extraction hash</param>
        internal Hkdf(byte[] salt, byte[] ikm)
        {
            HmacSha256 = new HMACSHA256(salt);

            Prk = HmacSha256.ComputeHash(ikm);
        }

        /// <summary>
        /// Performs the "Expand" portion of the Hkdf protocol to make
        /// the ouput key material of the desired length
        /// </summary>
        /// <param name="info">Contextual information for the expansion hash</param>
        /// <param name="length">The desired length of the output key material in bytes</param>
        /// <returns>Returns the output key material for the expansion protion of the HKDF protocol</returns>
        internal byte[] Expand(byte[] info, int length)
        {
            byte[] outputKeyMaterial = new byte[length];
            HmacSha256 = new HMACSHA256(Prk);

            byte currentByte;
            byte[] hashedBlock = new byte[0];
            byte[] currentBlock;
            int bytesRemaining = length; 

            for (int i = 0; bytesRemaining > 0; i++)
            {
                currentByte = Convert.ToByte(i+1);
                currentBlock = Util.CombineBytes(new byte[][] { hashedBlock, info, new byte[] { currentByte } });
                hashedBlock = HmacSha256.ComputeHash(currentBlock);

                Buffer.BlockCopy(hashedBlock, 0, outputKeyMaterial, length-bytesRemaining, Math.Min(hashedBlock.Length, bytesRemaining));
                bytesRemaining -= hashedBlock.Length;
            }

            return outputKeyMaterial;
        }
    }
}
