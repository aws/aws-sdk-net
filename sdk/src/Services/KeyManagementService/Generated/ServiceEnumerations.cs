/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Constants used for properties of type ConnectionErrorCodeType.
    /// </summary>
    public class ConnectionErrorCodeType : ConstantClass
    {

        /// <summary>
        /// Constant CLUSTER_NOT_FOUND for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType CLUSTER_NOT_FOUND = new ConnectionErrorCodeType("CLUSTER_NOT_FOUND");
        /// <summary>
        /// Constant INSUFFICIENT_CLOUDHSM_HSMS for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType INSUFFICIENT_CLOUDHSM_HSMS = new ConnectionErrorCodeType("INSUFFICIENT_CLOUDHSM_HSMS");
        /// <summary>
        /// Constant INSUFFICIENT_FREE_ADDRESSES_IN_SUBNET for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType INSUFFICIENT_FREE_ADDRESSES_IN_SUBNET = new ConnectionErrorCodeType("INSUFFICIENT_FREE_ADDRESSES_IN_SUBNET");
        /// <summary>
        /// Constant INTERNAL_ERROR for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType INTERNAL_ERROR = new ConnectionErrorCodeType("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_CREDENTIALS for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType INVALID_CREDENTIALS = new ConnectionErrorCodeType("INVALID_CREDENTIALS");
        /// <summary>
        /// Constant NETWORK_ERRORS for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType NETWORK_ERRORS = new ConnectionErrorCodeType("NETWORK_ERRORS");
        /// <summary>
        /// Constant SUBNET_NOT_FOUND for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType SUBNET_NOT_FOUND = new ConnectionErrorCodeType("SUBNET_NOT_FOUND");
        /// <summary>
        /// Constant USER_LOCKED_OUT for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType USER_LOCKED_OUT = new ConnectionErrorCodeType("USER_LOCKED_OUT");
        /// <summary>
        /// Constant USER_LOGGED_IN for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType USER_LOGGED_IN = new ConnectionErrorCodeType("USER_LOGGED_IN");
        /// <summary>
        /// Constant USER_NOT_FOUND for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType USER_NOT_FOUND = new ConnectionErrorCodeType("USER_NOT_FOUND");
        /// <summary>
        /// Constant XKS_PROXY_ACCESS_DENIED for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType XKS_PROXY_ACCESS_DENIED = new ConnectionErrorCodeType("XKS_PROXY_ACCESS_DENIED");
        /// <summary>
        /// Constant XKS_PROXY_INVALID_CONFIGURATION for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType XKS_PROXY_INVALID_CONFIGURATION = new ConnectionErrorCodeType("XKS_PROXY_INVALID_CONFIGURATION");
        /// <summary>
        /// Constant XKS_PROXY_INVALID_RESPONSE for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType XKS_PROXY_INVALID_RESPONSE = new ConnectionErrorCodeType("XKS_PROXY_INVALID_RESPONSE");
        /// <summary>
        /// Constant XKS_PROXY_INVALID_TLS_CONFIGURATION for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType XKS_PROXY_INVALID_TLS_CONFIGURATION = new ConnectionErrorCodeType("XKS_PROXY_INVALID_TLS_CONFIGURATION");
        /// <summary>
        /// Constant XKS_PROXY_NOT_REACHABLE for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType XKS_PROXY_NOT_REACHABLE = new ConnectionErrorCodeType("XKS_PROXY_NOT_REACHABLE");
        /// <summary>
        /// Constant XKS_PROXY_TIMED_OUT for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType XKS_PROXY_TIMED_OUT = new ConnectionErrorCodeType("XKS_PROXY_TIMED_OUT");
        /// <summary>
        /// Constant XKS_VPC_ENDPOINT_SERVICE_INVALID_CONFIGURATION for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType XKS_VPC_ENDPOINT_SERVICE_INVALID_CONFIGURATION = new ConnectionErrorCodeType("XKS_VPC_ENDPOINT_SERVICE_INVALID_CONFIGURATION");
        /// <summary>
        /// Constant XKS_VPC_ENDPOINT_SERVICE_NOT_FOUND for ConnectionErrorCodeType
        /// </summary>
        public static readonly ConnectionErrorCodeType XKS_VPC_ENDPOINT_SERVICE_NOT_FOUND = new ConnectionErrorCodeType("XKS_VPC_ENDPOINT_SERVICE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionErrorCodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionErrorCodeType FindValue(string value)
        {
            return FindValue<ConnectionErrorCodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionErrorCodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionStateType.
    /// </summary>
    public class ConnectionStateType : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for ConnectionStateType
        /// </summary>
        public static readonly ConnectionStateType CONNECTED = new ConnectionStateType("CONNECTED");
        /// <summary>
        /// Constant CONNECTING for ConnectionStateType
        /// </summary>
        public static readonly ConnectionStateType CONNECTING = new ConnectionStateType("CONNECTING");
        /// <summary>
        /// Constant DISCONNECTED for ConnectionStateType
        /// </summary>
        public static readonly ConnectionStateType DISCONNECTED = new ConnectionStateType("DISCONNECTED");
        /// <summary>
        /// Constant DISCONNECTING for ConnectionStateType
        /// </summary>
        public static readonly ConnectionStateType DISCONNECTING = new ConnectionStateType("DISCONNECTING");
        /// <summary>
        /// Constant FAILED for ConnectionStateType
        /// </summary>
        public static readonly ConnectionStateType FAILED = new ConnectionStateType("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionStateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionStateType FindValue(string value)
        {
            return FindValue<ConnectionStateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionStateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomerMasterKeySpec.
    /// </summary>
    public class CustomerMasterKeySpec : ConstantClass
    {

        /// <summary>
        /// Constant ECC_NIST_P256 for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec ECC_NIST_P256 = new CustomerMasterKeySpec("ECC_NIST_P256");
        /// <summary>
        /// Constant ECC_NIST_P384 for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec ECC_NIST_P384 = new CustomerMasterKeySpec("ECC_NIST_P384");
        /// <summary>
        /// Constant ECC_NIST_P521 for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec ECC_NIST_P521 = new CustomerMasterKeySpec("ECC_NIST_P521");
        /// <summary>
        /// Constant ECC_SECG_P256K1 for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec ECC_SECG_P256K1 = new CustomerMasterKeySpec("ECC_SECG_P256K1");
        /// <summary>
        /// Constant HMAC_224 for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec HMAC_224 = new CustomerMasterKeySpec("HMAC_224");
        /// <summary>
        /// Constant HMAC_256 for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec HMAC_256 = new CustomerMasterKeySpec("HMAC_256");
        /// <summary>
        /// Constant HMAC_384 for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec HMAC_384 = new CustomerMasterKeySpec("HMAC_384");
        /// <summary>
        /// Constant HMAC_512 for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec HMAC_512 = new CustomerMasterKeySpec("HMAC_512");
        /// <summary>
        /// Constant RSA_2048 for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec RSA_2048 = new CustomerMasterKeySpec("RSA_2048");
        /// <summary>
        /// Constant RSA_3072 for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec RSA_3072 = new CustomerMasterKeySpec("RSA_3072");
        /// <summary>
        /// Constant RSA_4096 for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec RSA_4096 = new CustomerMasterKeySpec("RSA_4096");
        /// <summary>
        /// Constant SM2 for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec SM2 = new CustomerMasterKeySpec("SM2");
        /// <summary>
        /// Constant SYMMETRIC_DEFAULT for CustomerMasterKeySpec
        /// </summary>
        public static readonly CustomerMasterKeySpec SYMMETRIC_DEFAULT = new CustomerMasterKeySpec("SYMMETRIC_DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomerMasterKeySpec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomerMasterKeySpec FindValue(string value)
        {
            return FindValue<CustomerMasterKeySpec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomerMasterKeySpec(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomKeyStoreType.
    /// </summary>
    public class CustomKeyStoreType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_CLOUDHSM for CustomKeyStoreType
        /// </summary>
        public static readonly CustomKeyStoreType AWS_CLOUDHSM = new CustomKeyStoreType("AWS_CLOUDHSM");
        /// <summary>
        /// Constant EXTERNAL_KEY_STORE for CustomKeyStoreType
        /// </summary>
        public static readonly CustomKeyStoreType EXTERNAL_KEY_STORE = new CustomKeyStoreType("EXTERNAL_KEY_STORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomKeyStoreType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomKeyStoreType FindValue(string value)
        {
            return FindValue<CustomKeyStoreType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomKeyStoreType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataKeyPairSpec.
    /// </summary>
    public class DataKeyPairSpec : ConstantClass
    {

        /// <summary>
        /// Constant ECC_NIST_P256 for DataKeyPairSpec
        /// </summary>
        public static readonly DataKeyPairSpec ECC_NIST_P256 = new DataKeyPairSpec("ECC_NIST_P256");
        /// <summary>
        /// Constant ECC_NIST_P384 for DataKeyPairSpec
        /// </summary>
        public static readonly DataKeyPairSpec ECC_NIST_P384 = new DataKeyPairSpec("ECC_NIST_P384");
        /// <summary>
        /// Constant ECC_NIST_P521 for DataKeyPairSpec
        /// </summary>
        public static readonly DataKeyPairSpec ECC_NIST_P521 = new DataKeyPairSpec("ECC_NIST_P521");
        /// <summary>
        /// Constant ECC_SECG_P256K1 for DataKeyPairSpec
        /// </summary>
        public static readonly DataKeyPairSpec ECC_SECG_P256K1 = new DataKeyPairSpec("ECC_SECG_P256K1");
        /// <summary>
        /// Constant RSA_2048 for DataKeyPairSpec
        /// </summary>
        public static readonly DataKeyPairSpec RSA_2048 = new DataKeyPairSpec("RSA_2048");
        /// <summary>
        /// Constant RSA_3072 for DataKeyPairSpec
        /// </summary>
        public static readonly DataKeyPairSpec RSA_3072 = new DataKeyPairSpec("RSA_3072");
        /// <summary>
        /// Constant RSA_4096 for DataKeyPairSpec
        /// </summary>
        public static readonly DataKeyPairSpec RSA_4096 = new DataKeyPairSpec("RSA_4096");
        /// <summary>
        /// Constant SM2 for DataKeyPairSpec
        /// </summary>
        public static readonly DataKeyPairSpec SM2 = new DataKeyPairSpec("SM2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataKeyPairSpec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataKeyPairSpec FindValue(string value)
        {
            return FindValue<DataKeyPairSpec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataKeyPairSpec(string value)
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
    /// Constants used for properties of type EncryptionAlgorithmSpec.
    /// </summary>
    public class EncryptionAlgorithmSpec : ConstantClass
    {

        /// <summary>
        /// Constant RSAES_OAEP_SHA_1 for EncryptionAlgorithmSpec
        /// </summary>
        public static readonly EncryptionAlgorithmSpec RSAES_OAEP_SHA_1 = new EncryptionAlgorithmSpec("RSAES_OAEP_SHA_1");
        /// <summary>
        /// Constant RSAES_OAEP_SHA_256 for EncryptionAlgorithmSpec
        /// </summary>
        public static readonly EncryptionAlgorithmSpec RSAES_OAEP_SHA_256 = new EncryptionAlgorithmSpec("RSAES_OAEP_SHA_256");
        /// <summary>
        /// Constant SM2PKE for EncryptionAlgorithmSpec
        /// </summary>
        public static readonly EncryptionAlgorithmSpec SM2PKE = new EncryptionAlgorithmSpec("SM2PKE");
        /// <summary>
        /// Constant SYMMETRIC_DEFAULT for EncryptionAlgorithmSpec
        /// </summary>
        public static readonly EncryptionAlgorithmSpec SYMMETRIC_DEFAULT = new EncryptionAlgorithmSpec("SYMMETRIC_DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionAlgorithmSpec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionAlgorithmSpec FindValue(string value)
        {
            return FindValue<EncryptionAlgorithmSpec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionAlgorithmSpec(string value)
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
        /// Constant GenerateDataKeyPair for GrantOperation
        /// </summary>
        public static readonly GrantOperation GenerateDataKeyPair = new GrantOperation("GenerateDataKeyPair");
        /// <summary>
        /// Constant GenerateDataKeyPairWithoutPlaintext for GrantOperation
        /// </summary>
        public static readonly GrantOperation GenerateDataKeyPairWithoutPlaintext = new GrantOperation("GenerateDataKeyPairWithoutPlaintext");
        /// <summary>
        /// Constant GenerateDataKeyWithoutPlaintext for GrantOperation
        /// </summary>
        public static readonly GrantOperation GenerateDataKeyWithoutPlaintext = new GrantOperation("GenerateDataKeyWithoutPlaintext");
        /// <summary>
        /// Constant GenerateMac for GrantOperation
        /// </summary>
        public static readonly GrantOperation GenerateMac = new GrantOperation("GenerateMac");
        /// <summary>
        /// Constant GetPublicKey for GrantOperation
        /// </summary>
        public static readonly GrantOperation GetPublicKey = new GrantOperation("GetPublicKey");
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
        /// Constant Sign for GrantOperation
        /// </summary>
        public static readonly GrantOperation Sign = new GrantOperation("Sign");
        /// <summary>
        /// Constant Verify for GrantOperation
        /// </summary>
        public static readonly GrantOperation Verify = new GrantOperation("Verify");
        /// <summary>
        /// Constant VerifyMac for GrantOperation
        /// </summary>
        public static readonly GrantOperation VerifyMac = new GrantOperation("VerifyMac");

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
    /// Constants used for properties of type KeySpec.
    /// </summary>
    public class KeySpec : ConstantClass
    {

        /// <summary>
        /// Constant ECC_NIST_P256 for KeySpec
        /// </summary>
        public static readonly KeySpec ECC_NIST_P256 = new KeySpec("ECC_NIST_P256");
        /// <summary>
        /// Constant ECC_NIST_P384 for KeySpec
        /// </summary>
        public static readonly KeySpec ECC_NIST_P384 = new KeySpec("ECC_NIST_P384");
        /// <summary>
        /// Constant ECC_NIST_P521 for KeySpec
        /// </summary>
        public static readonly KeySpec ECC_NIST_P521 = new KeySpec("ECC_NIST_P521");
        /// <summary>
        /// Constant ECC_SECG_P256K1 for KeySpec
        /// </summary>
        public static readonly KeySpec ECC_SECG_P256K1 = new KeySpec("ECC_SECG_P256K1");
        /// <summary>
        /// Constant HMAC_224 for KeySpec
        /// </summary>
        public static readonly KeySpec HMAC_224 = new KeySpec("HMAC_224");
        /// <summary>
        /// Constant HMAC_256 for KeySpec
        /// </summary>
        public static readonly KeySpec HMAC_256 = new KeySpec("HMAC_256");
        /// <summary>
        /// Constant HMAC_384 for KeySpec
        /// </summary>
        public static readonly KeySpec HMAC_384 = new KeySpec("HMAC_384");
        /// <summary>
        /// Constant HMAC_512 for KeySpec
        /// </summary>
        public static readonly KeySpec HMAC_512 = new KeySpec("HMAC_512");
        /// <summary>
        /// Constant RSA_2048 for KeySpec
        /// </summary>
        public static readonly KeySpec RSA_2048 = new KeySpec("RSA_2048");
        /// <summary>
        /// Constant RSA_3072 for KeySpec
        /// </summary>
        public static readonly KeySpec RSA_3072 = new KeySpec("RSA_3072");
        /// <summary>
        /// Constant RSA_4096 for KeySpec
        /// </summary>
        public static readonly KeySpec RSA_4096 = new KeySpec("RSA_4096");
        /// <summary>
        /// Constant SM2 for KeySpec
        /// </summary>
        public static readonly KeySpec SM2 = new KeySpec("SM2");
        /// <summary>
        /// Constant SYMMETRIC_DEFAULT for KeySpec
        /// </summary>
        public static readonly KeySpec SYMMETRIC_DEFAULT = new KeySpec("SYMMETRIC_DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeySpec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeySpec FindValue(string value)
        {
            return FindValue<KeySpec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeySpec(string value)
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
        /// Constant Creating for KeyState
        /// </summary>
        public static readonly KeyState Creating = new KeyState("Creating");
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
        /// Constant PendingReplicaDeletion for KeyState
        /// </summary>
        public static readonly KeyState PendingReplicaDeletion = new KeyState("PendingReplicaDeletion");
        /// <summary>
        /// Constant Unavailable for KeyState
        /// </summary>
        public static readonly KeyState Unavailable = new KeyState("Unavailable");
        /// <summary>
        /// Constant Updating for KeyState
        /// </summary>
        public static readonly KeyState Updating = new KeyState("Updating");

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
        /// Constant GENERATE_VERIFY_MAC for KeyUsageType
        /// </summary>
        public static readonly KeyUsageType GENERATE_VERIFY_MAC = new KeyUsageType("GENERATE_VERIFY_MAC");
        /// <summary>
        /// Constant SIGN_VERIFY for KeyUsageType
        /// </summary>
        public static readonly KeyUsageType SIGN_VERIFY = new KeyUsageType("SIGN_VERIFY");

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
    /// Constants used for properties of type MacAlgorithmSpec.
    /// </summary>
    public class MacAlgorithmSpec : ConstantClass
    {

        /// <summary>
        /// Constant HMAC_SHA_224 for MacAlgorithmSpec
        /// </summary>
        public static readonly MacAlgorithmSpec HMAC_SHA_224 = new MacAlgorithmSpec("HMAC_SHA_224");
        /// <summary>
        /// Constant HMAC_SHA_256 for MacAlgorithmSpec
        /// </summary>
        public static readonly MacAlgorithmSpec HMAC_SHA_256 = new MacAlgorithmSpec("HMAC_SHA_256");
        /// <summary>
        /// Constant HMAC_SHA_384 for MacAlgorithmSpec
        /// </summary>
        public static readonly MacAlgorithmSpec HMAC_SHA_384 = new MacAlgorithmSpec("HMAC_SHA_384");
        /// <summary>
        /// Constant HMAC_SHA_512 for MacAlgorithmSpec
        /// </summary>
        public static readonly MacAlgorithmSpec HMAC_SHA_512 = new MacAlgorithmSpec("HMAC_SHA_512");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MacAlgorithmSpec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MacAlgorithmSpec FindValue(string value)
        {
            return FindValue<MacAlgorithmSpec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MacAlgorithmSpec(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageType.
    /// </summary>
    public class MessageType : ConstantClass
    {

        /// <summary>
        /// Constant DIGEST for MessageType
        /// </summary>
        public static readonly MessageType DIGEST = new MessageType("DIGEST");
        /// <summary>
        /// Constant RAW for MessageType
        /// </summary>
        public static readonly MessageType RAW = new MessageType("RAW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageType FindValue(string value)
        {
            return FindValue<MessageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MultiRegionKeyType.
    /// </summary>
    public class MultiRegionKeyType : ConstantClass
    {

        /// <summary>
        /// Constant PRIMARY for MultiRegionKeyType
        /// </summary>
        public static readonly MultiRegionKeyType PRIMARY = new MultiRegionKeyType("PRIMARY");
        /// <summary>
        /// Constant REPLICA for MultiRegionKeyType
        /// </summary>
        public static readonly MultiRegionKeyType REPLICA = new MultiRegionKeyType("REPLICA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MultiRegionKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MultiRegionKeyType FindValue(string value)
        {
            return FindValue<MultiRegionKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MultiRegionKeyType(string value)
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
        /// Constant AWS_CLOUDHSM for OriginType
        /// </summary>
        public static readonly OriginType AWS_CLOUDHSM = new OriginType("AWS_CLOUDHSM");
        /// <summary>
        /// Constant AWS_KMS for OriginType
        /// </summary>
        public static readonly OriginType AWS_KMS = new OriginType("AWS_KMS");
        /// <summary>
        /// Constant EXTERNAL for OriginType
        /// </summary>
        public static readonly OriginType EXTERNAL = new OriginType("EXTERNAL");
        /// <summary>
        /// Constant EXTERNAL_KEY_STORE for OriginType
        /// </summary>
        public static readonly OriginType EXTERNAL_KEY_STORE = new OriginType("EXTERNAL_KEY_STORE");

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
    /// Constants used for properties of type SigningAlgorithmSpec.
    /// </summary>
    public class SigningAlgorithmSpec : ConstantClass
    {

        /// <summary>
        /// Constant ECDSA_SHA_256 for SigningAlgorithmSpec
        /// </summary>
        public static readonly SigningAlgorithmSpec ECDSA_SHA_256 = new SigningAlgorithmSpec("ECDSA_SHA_256");
        /// <summary>
        /// Constant ECDSA_SHA_384 for SigningAlgorithmSpec
        /// </summary>
        public static readonly SigningAlgorithmSpec ECDSA_SHA_384 = new SigningAlgorithmSpec("ECDSA_SHA_384");
        /// <summary>
        /// Constant ECDSA_SHA_512 for SigningAlgorithmSpec
        /// </summary>
        public static readonly SigningAlgorithmSpec ECDSA_SHA_512 = new SigningAlgorithmSpec("ECDSA_SHA_512");
        /// <summary>
        /// Constant RSASSA_PKCS1_V1_5_SHA_256 for SigningAlgorithmSpec
        /// </summary>
        public static readonly SigningAlgorithmSpec RSASSA_PKCS1_V1_5_SHA_256 = new SigningAlgorithmSpec("RSASSA_PKCS1_V1_5_SHA_256");
        /// <summary>
        /// Constant RSASSA_PKCS1_V1_5_SHA_384 for SigningAlgorithmSpec
        /// </summary>
        public static readonly SigningAlgorithmSpec RSASSA_PKCS1_V1_5_SHA_384 = new SigningAlgorithmSpec("RSASSA_PKCS1_V1_5_SHA_384");
        /// <summary>
        /// Constant RSASSA_PKCS1_V1_5_SHA_512 for SigningAlgorithmSpec
        /// </summary>
        public static readonly SigningAlgorithmSpec RSASSA_PKCS1_V1_5_SHA_512 = new SigningAlgorithmSpec("RSASSA_PKCS1_V1_5_SHA_512");
        /// <summary>
        /// Constant RSASSA_PSS_SHA_256 for SigningAlgorithmSpec
        /// </summary>
        public static readonly SigningAlgorithmSpec RSASSA_PSS_SHA_256 = new SigningAlgorithmSpec("RSASSA_PSS_SHA_256");
        /// <summary>
        /// Constant RSASSA_PSS_SHA_384 for SigningAlgorithmSpec
        /// </summary>
        public static readonly SigningAlgorithmSpec RSASSA_PSS_SHA_384 = new SigningAlgorithmSpec("RSASSA_PSS_SHA_384");
        /// <summary>
        /// Constant RSASSA_PSS_SHA_512 for SigningAlgorithmSpec
        /// </summary>
        public static readonly SigningAlgorithmSpec RSASSA_PSS_SHA_512 = new SigningAlgorithmSpec("RSASSA_PSS_SHA_512");
        /// <summary>
        /// Constant SM2DSA for SigningAlgorithmSpec
        /// </summary>
        public static readonly SigningAlgorithmSpec SM2DSA = new SigningAlgorithmSpec("SM2DSA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SigningAlgorithmSpec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SigningAlgorithmSpec FindValue(string value)
        {
            return FindValue<SigningAlgorithmSpec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SigningAlgorithmSpec(string value)
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


    /// <summary>
    /// Constants used for properties of type XksProxyConnectivityType.
    /// </summary>
    public class XksProxyConnectivityType : ConstantClass
    {

        /// <summary>
        /// Constant PUBLIC_ENDPOINT for XksProxyConnectivityType
        /// </summary>
        public static readonly XksProxyConnectivityType PUBLIC_ENDPOINT = new XksProxyConnectivityType("PUBLIC_ENDPOINT");
        /// <summary>
        /// Constant VPC_ENDPOINT_SERVICE for XksProxyConnectivityType
        /// </summary>
        public static readonly XksProxyConnectivityType VPC_ENDPOINT_SERVICE = new XksProxyConnectivityType("VPC_ENDPOINT_SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XksProxyConnectivityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XksProxyConnectivityType FindValue(string value)
        {
            return FindValue<XksProxyConnectivityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XksProxyConnectivityType(string value)
        {
            return FindValue(value);
        }
    }

}