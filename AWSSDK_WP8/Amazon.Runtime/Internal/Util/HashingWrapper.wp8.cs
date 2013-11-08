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
using System.Security.Cryptography;
using Windows.Storage.Streams;
using ThirdParty.MD5;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Util
{
    public partial class HashingWrapper : IHashingWrapper
    {
        protected static string MD5ManagedName = typeof(MD5Managed).FullName;

        private HashAlgorithm _algorithm;
        private void Init(string algorithmName)
        {
            if (string.Equals(MD5ManagedName, algorithmName, StringComparison.Ordinal))
                _algorithm = new MD5Managed();
            else
                throw new ArgumentOutOfRangeException("Unsupported hashing algorithm");
        }

        #region IHashingWrapper Members

        public void Clear()
        {
            _algorithm.Initialize();
        }

        public byte[] ComputeHash(byte[] buffer)
        {
            return _algorithm.ComputeHash(buffer);
        }

        public byte[] ComputeHash(Stream stream)
        {
            return _algorithm.ComputeHash(stream);
        }

        public void AppendBlock(byte[] buffer, int offset, int count)
        {
            _algorithm.TransformBlock(buffer, offset, count, null, 0);
        }

        public byte[] AppendLastBlock(byte[] buffer, int offset, int count)
        {
            _algorithm.TransformFinalBlock(buffer, offset, count);
            return _algorithm.Hash;
        }

        #endregion
    }

    public class HashingWrapperMD5 : HashingWrapper
    {
        public HashingWrapperMD5()
            : base(HashingWrapper.MD5ManagedName)
        { }
    }
}
