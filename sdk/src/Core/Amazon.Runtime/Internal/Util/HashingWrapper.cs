/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */
using Amazon.Util;
using System;
using System.Security.Cryptography;

namespace Amazon.Runtime.Internal.Util
{
    public partial class HashingWrapper : IHashingWrapper
    {
        public HashingWrapper(string algorithmName)
        {
            if (string.IsNullOrEmpty(algorithmName))
                throw new ArgumentNullException("algorithmName");

            Init(algorithmName);
        }

        public HashingWrapper(HashAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }

         #region IHashingWrapper Members
        public void AppendBlock(byte[] buffer)
        {
            AppendBlock(buffer, 0, buffer.Length);
        }

        public byte[] AppendLastBlock(byte[] buffer)
        {
            return AppendLastBlock(buffer, 0, buffer.Length);
        }

        #endregion


        #region Dispose Pattern Implementation

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    public class HashingWrapperCRC64NVME : HashingWrapper
    {
        public HashingWrapperCRC64NVME()
            : base(CryptoUtilFactory.GetChecksumInstance(CoreChecksumAlgorithm.CRC64NVME))
        { }
    }

    public class HashingWrapperCRC32C : HashingWrapper
    {
        public HashingWrapperCRC32C()
            : base(CryptoUtilFactory.GetChecksumInstance(CoreChecksumAlgorithm.CRC32C))
        { }
    }

    public class HashingWrapperCRC32 : HashingWrapper
    {
        public HashingWrapperCRC32()
            : base(CryptoUtilFactory.GetChecksumInstance(CoreChecksumAlgorithm.CRC32))
        { }
    }

    public class HashingWrapperSHA256 : HashingWrapper
    {
        public HashingWrapperSHA256()
            : base(CryptoUtilFactory.GetChecksumInstance(CoreChecksumAlgorithm.SHA256))
        { }
    }

    public class HashingWrapperSHA1 : HashingWrapper
    {
        public HashingWrapperSHA1()
            : base(CryptoUtilFactory.GetChecksumInstance(CoreChecksumAlgorithm.SHA1))
        { }
    }
}
