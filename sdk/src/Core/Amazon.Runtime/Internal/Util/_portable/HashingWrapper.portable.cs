/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Amazon.Runtime;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.Runtime.Internal.Util
{
    public partial class HashingWrapper : IHashingWrapper
    {
        private CryptographicHash _hash;
        private HashAlgorithmProvider _hasher;
        private void Init(string algorithmName)
        {
            _hasher = HashAlgorithmProvider.OpenAlgorithm(algorithmName);
            Clear();
        }

        #region IHashingWrapper Members

        public void Clear()
        {
            _hash = _hasher.CreateHash();
        }

        public byte[] ComputeHash(byte[] buffer)
        {
            IBuffer inputBuffer = CryptographicBuffer.CreateFromByteArray(buffer);

            _hash.Append(inputBuffer);
            var hash = _hash.GetValueAndReset().ToArray();
            return hash;
        }

        public byte[] ComputeHash(Stream stream)
        {
            int bytesRead = 0;
            var cryptoBuffer = CryptographicBuffer.CreateFromByteArray(new byte[AWSSDKUtils.DefaultBufferSize]);
            byte[] buffer = new byte[AWSSDKUtils.DefaultBufferSize];
            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
            {
                if (bytesRead != cryptoBuffer.Length)
                    cryptoBuffer = CryptographicBuffer.CreateFromByteArray(new byte[bytesRead]);

                buffer.CopyTo(0, cryptoBuffer, 0, bytesRead);
                _hash.Append(cryptoBuffer);
            }

            return _hash.GetValueAndReset().ToArray();
        }

        public void AppendBlock(byte[] buffer, int offset, int count)
        {
            if (count > 0)
            {
                var cryptoBuffer = CryptographicBuffer.CreateFromByteArray(new byte[count]);
                buffer.CopyTo(offset, cryptoBuffer, 0, count);
                _hash.Append(cryptoBuffer);
            }
        }

        public byte[] AppendLastBlock(byte[] buffer, int offset, int count)
        {
            AppendBlock(buffer, offset, count);
            return _hash.GetValueAndReset().ToArray();
        }

        #endregion
    }

    public class HashingWrapperMD5 : HashingWrapper
    {
        public HashingWrapperMD5()
            : base(HashAlgorithmNames.Md5)
        { }
    }
}
