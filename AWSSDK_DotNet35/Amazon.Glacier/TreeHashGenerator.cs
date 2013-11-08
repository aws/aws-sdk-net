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
using System.Collections.Generic;
using System.IO;
using System.Text;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Globalization;

namespace Amazon.Glacier
{
    /// <summary>
    /// This class computes the tree hash that is set on the CheckSum property on UploadArchiveRequest, UploadMultipartPartRequest and CompleteMultipartUploadRequest.
    /// </summary>
    public static class TreeHashGenerator
    {
        private const long MB = 1024 * 1024;

        /// <summary>
        /// This method computes the tree hash used by glacier.  It reads the whole stream and then resets the
        /// position of the stream back to the beginning.
        /// </summary>
        /// <param name="stream">The stream to read and compute the tree hash for.</param>
        /// <returns>The tree hash that can be used to set the the Checksum property.</returns>
        public static string CalculateTreeHash(Stream stream)
        {
            List<byte[]> hashes = computePartHashs(stream);
            byte[] treeHash = computeTreehHash(hashes);
            return BitConverter.ToString(treeHash).Replace("-", "").ToLower(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// This method computes the final tree hash used on the CompleteMultipartUploadRequest from the tree hashes of
        /// the individual part uploaded.
        /// </summary>
        /// <param name="partsTreeHash">The list of tree hashes for the individual parts.</param>
        /// <returns>The tree hash that can be used to set the the Checksum property.</returns>
        public static string CalculateTreeHash(IEnumerable<string> partsTreeHash)
        {
            List<byte[]> hashes = new List<byte[]>();
            foreach (var partTreeHash in partsTreeHash)
            {
                hashes.Add(stringToByteArrayFastest(partTreeHash));
            }

            byte[] treeHash = computeTreehHash(hashes);
            return BitConverter.ToString(treeHash).Replace("-", "").ToLower(CultureInfo.InvariantCulture);
        }

        static List<byte[]> computePartHashs(Stream stream)
        {
            long initialPosition = stream.Position;
            List<byte[]> hashes = new List<byte[]>();

            while (stream.Position < stream.Length)
            {
                Stream wrapper = new PartialWrapperStream(stream, MB);
                byte[] currentHash = CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(wrapper);
                hashes.Add(currentHash);
            }

            stream.Seek(initialPosition, SeekOrigin.Begin);
            return hashes;
        }

        static byte[] computeTreehHash(List<byte[]> partHashsums)
        {
            /*
             * The tree hash algorithm involves concatenating adjacent pairs of
             * individual SHA256 sums, then taking the SHA256 sum of the resulting bytes
             * and storing it, then recursing on this new list until there is only
             * one element. Any final odd-numbered parts at each step are carried
             * over to the next iteration as-is.
             */
            while (partHashsums.Count > 1)
            {
                List<byte[]> treeHashes = new List<byte[]>();
                for (int i = 0; i < partHashsums.Count / 2; i++)
                {
                    byte[] firstPart = partHashsums[2 * i];
                    byte[] secondPart = partHashsums[2 * i + 1];
                    byte[] concatenation = new byte[firstPart.Length + secondPart.Length];
                    Array.Copy(firstPart, 0, concatenation, 0, firstPart.Length);
                    Array.Copy(secondPart, 0, concatenation, firstPart.Length, secondPart.Length);

                    treeHashes.Add(CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(concatenation));
                }
                if (partHashsums.Count % 2 == 1)
                {
                    treeHashes.Add(partHashsums[partHashsums.Count - 1]);
                }
                partHashsums = treeHashes;
            }

            return partHashsums[0];
        }

        static byte[] stringToByteArrayFastest(string hex)
        {
            if (hex.Length % 2 == 1)
                throw new ArgumentOutOfRangeException("hex", "The binary key cannot have an odd number of digits");

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((getHexVal(hex[i << 1]) << 4) + (getHexVal(hex[(i << 1) + 1])));
            }

            return arr;
        }

        static int getHexVal(char hex)
        {
            int val = (int)hex;
            return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }
    }
}
