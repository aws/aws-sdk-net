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
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Amazon.S3.Encryption
{
    public class EncryptionMaterials
    {
        public EncryptionMaterials(AsymmetricAlgorithm algorithm)
        {
            AsymmetricProvider = algorithm;
            SymmetricProvider = null;
        }

        public EncryptionMaterials(SymmetricAlgorithm algorithm)
        {
            SymmetricProvider = algorithm;
            AsymmetricProvider = null;
        }

        internal AsymmetricAlgorithm AsymmetricProvider { get; private set; }

        internal SymmetricAlgorithm SymmetricProvider { get; private set; }

        internal static Dictionary<string, string> EmptyMaterialsDescription { get { return new Dictionary<string, string>(); } }
    }
}
