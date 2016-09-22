﻿/*******************************************************************************
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

using System.IO;
using System.Security.Cryptography;

namespace Amazon.Runtime.Internal.Util
{
    public interface IEncryptionWrapper
    {
        void Reset();
        int AppendBlock(byte[] buffer, int offset, int count, byte[] target, int targetOffset);
        byte[] AppendLastBlock(byte[] buffer, int offset, int count);
        void SetEncryptionData(byte[] key, byte[] IV);
        void CreateEncryptor();
    }
}
