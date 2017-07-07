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
    /// Constants used for properties of type AlgorithmSpec.
    /// </summary>
    public class AlgorithmSpec : ConstantClass
    {

        /// <summary>
        /// Constant RSAES_OAEP_SHA_1 for AlgorithmSpec
        /// </summary>
        public static readonly AlgorithmSpec RSAES_OAEP_SHA_1 = new AlgorithmSpec("RSAES_OAEP_SHA_1");
        /// <summary>
        /// Constant RSAES_OAEP_SHA_256 for AlgorithmSpec
        /// </summary>
        public static readonly AlgorithmSpec RSAES_OAEP_SHA_256 = new AlgorithmSpec("RSAES_OAEP_SHA_256");
        /// <summary>
        /// Constant RSAES_PKCS1_V1_5 for AlgorithmSpec
        /// </summary>
        public static readonly AlgorithmSpec RSAES_PKCS1_V1_5 = new AlgorithmSpec("RSAES_PKCS1_V1_5");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlgorithmSpec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlgorithmSpec FindValue(string value)
        {
            return FindValue<AlgorithmSpec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlgorithmSpec(string value)
        {
            return FindValue(value);
        }
    }


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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataKeySpec(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExpirationModelType.
    /// </summary>
    public class ExpirationModelType : ConstantClass
    {

        /// <summary>
        /// Constant KEY_MATERIAL_DOES_NOT_EXPIRE for ExpirationModelType
        /// </summary>
        public static readonly ExpirationModelType KEY_MATERIAL_DOES_NOT_EXPIRE = new ExpirationModelType("KEY_MATERIAL_DOES_NOT_EXPIRE");
        /// <summary>
        /// Constant KEY_MATERIAL_EXPIRES for ExpirationModelType
        /// </summary>
        public static readonly ExpirationModelType KEY_MATERIAL_EXPIRES = new ExpirationModelType("KEY_MATERIAL_EXPIRES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExpirationModelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExpirationModelType FindValue(string value)
        {
            return FindValue<ExpirationModelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExpirationModelType(string value)
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
        /// Constant DescribeKey for GrantOperation
        /// </summary>
        public static readonly GrantOperation DescribeKey = new GrantOperation("DescribeKey");
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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GrantOperation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyManagerType.
    /// </summary>
    public class KeyManagerType : ConstantClass
    {

        /// <summary>
        /// Constant AWS for KeyManagerType
        /// </summary>
        public static readonly KeyManagerType AWS = new KeyManagerType("AWS");
        /// <summary>
        /// Constant CUSTOMER for KeyManagerType
        /// </summary>
        public static readonly KeyManagerType CUSTOMER = new KeyManagerType("CUSTOMER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyManagerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyManagerType FindValue(string value)
        {
            return FindValue<KeyManagerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyManagerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyState.
    /// </summary>
    public class KeyState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for KeyState
        /// </summary>
        public static readonly KeyState Disabled = new KeyState("Disabled");
        /// <summary>
        /// Constant Enabled for KeyState
        /// </summary>
        public static readonly KeyState Enabled = new KeyState("Enabled");
        /// <summary>
        /// Constant PendingDeletion for KeyState
        /// </summary>
        public static readonly KeyState PendingDeletion = new KeyState("PendingDeletion");
        /// <summary>
        /// Constant PendingImport for KeyState
        /// </summary>
        public static readonly KeyState PendingImport = new KeyState("PendingImport");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyState FindValue(string value)
        {
            return FindValue<KeyState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyState(string value)
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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyUsageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OriginType.
    /// </summary>
    public class OriginType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_KMS for OriginType
        /// </summary>
        public static readonly OriginType AWS_KMS = new OriginType("AWS_KMS");
        /// <summary>
        /// Constant EXTERNAL for OriginType
        /// </summary>
        public static readonly OriginType EXTERNAL = new OriginType("EXTERNAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginType FindValue(string value)
        {
            return FindValue<OriginType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WrappingKeySpec.
    /// </summary>
    public class WrappingKeySpec : ConstantClass
    {

        /// <summary>
        /// Constant RSA_2048 for WrappingKeySpec
        /// </summary>
        public static readonly WrappingKeySpec RSA_2048 = new WrappingKeySpec("RSA_2048");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WrappingKeySpec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WrappingKeySpec FindValue(string value)
        {
            return FindValue<WrappingKeySpec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WrappingKeySpec(string value)
        {
            return FindValue(value);
        }
    }

}