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

/*
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.KeyManagementService
{

    /// <summary>
    /// Constants used for properties of type DataKeySpec.
    /// </summary>
    public class DataKeySpec : ConstantClass
    {

        /// <summary>
        /// Constant AES_128 for DataKeySpec
        /// </summary>
        public static readonly DataKeySpec AES_128 = new DataKeySpec("AES_128");
        /// <summary>
        /// Constant AES_256 for DataKeySpec
        /// </summary>
        public static readonly DataKeySpec AES_256 = new DataKeySpec("AES_256");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DataKeySpec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataKeySpec FindValue(string value)
        {
            return FindValue<DataKeySpec>(value);
        }

        public static implicit operator DataKeySpec(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GrantOperation.
    /// </summary>
    public class GrantOperation : ConstantClass
    {

        /// <summary>
        /// Constant CreateGrant for GrantOperation
        /// </summary>
        public static readonly GrantOperation CreateGrant = new GrantOperation("CreateGrant");
        /// <summary>
        /// Constant Decrypt for GrantOperation
        /// </summary>
        public static readonly GrantOperation Decrypt = new GrantOperation("Decrypt");
        /// <summary>
        /// Constant Encrypt for GrantOperation
        /// </summary>
        public static readonly GrantOperation Encrypt = new GrantOperation("Encrypt");
        /// <summary>
        /// Constant GenerateDataKey for GrantOperation
        /// </summary>
        public static readonly GrantOperation GenerateDataKey = new GrantOperation("GenerateDataKey");
        /// <summary>
        /// Constant GenerateDataKeyWithoutPlaintext for GrantOperation
        /// </summary>
        public static readonly GrantOperation GenerateDataKeyWithoutPlaintext = new GrantOperation("GenerateDataKeyWithoutPlaintext");
        /// <summary>
        /// Constant ReEncryptFrom for GrantOperation
        /// </summary>
        public static readonly GrantOperation ReEncryptFrom = new GrantOperation("ReEncryptFrom");
        /// <summary>
        /// Constant ReEncryptTo for GrantOperation
        /// </summary>
        public static readonly GrantOperation ReEncryptTo = new GrantOperation("ReEncryptTo");
        /// <summary>
        /// Constant RetireGrant for GrantOperation
        /// </summary>
        public static readonly GrantOperation RetireGrant = new GrantOperation("RetireGrant");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public GrantOperation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GrantOperation FindValue(string value)
        {
            return FindValue<GrantOperation>(value);
        }

        public static implicit operator GrantOperation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyUsageType.
    /// </summary>
    public class KeyUsageType : ConstantClass
    {

        /// <summary>
        /// Constant ENCRYPT_DECRYPT for KeyUsageType
        /// </summary>
        public static readonly KeyUsageType ENCRYPT_DECRYPT = new KeyUsageType("ENCRYPT_DECRYPT");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public KeyUsageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyUsageType FindValue(string value)
        {
            return FindValue<KeyUsageType>(value);
        }

        public static implicit operator KeyUsageType(string value)
        {
            return FindValue(value);
        }
    }

}