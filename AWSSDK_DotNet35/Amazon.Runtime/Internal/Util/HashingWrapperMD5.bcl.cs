/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.MD5;

namespace Amazon.Runtime.Internal.Util
{
    public class HashingWrapperMD5 : IHashingWrapper
    {
        private MD5Managed algorithm = new MD5Managed();

        #region IHashingWrapper members

        public void Clear()
        {
            algorithm.Initialize();
        }

        public byte[] ComputeHash(byte[] buffer)
        {
            return algorithm.ComputeHash(buffer);
        }

        public byte[] ComputeHash(System.IO.Stream stream)
        {
            return algorithm.ComputeHash(stream);
        }

        public void AppendBlock(byte[] buffer, int offset, int count)
        {
            algorithm.TransformBlock(buffer, offset, count, null, 0);
        }

        public byte[] AppendLastBlock(byte[] buffer, int offset, int count)
        {
            algorithm.TransformFinalBlock(buffer, offset, count);
            return algorithm.Hash;
        }

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
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            var disposable = algorithm as IDisposable;

            if (disposing && disposable != null)
            {
                disposable.Dispose();
                algorithm = null;
            }
        }

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
}
