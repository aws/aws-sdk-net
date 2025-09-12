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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PaymentCryptography
{

    /// <summary>
    /// Constants used for properties of type DeriveKeyUsage.
    /// </summary>
    public class DeriveKeyUsage : ConstantClass
    {

        /// <summary>
        /// Constant TR31_B0_BASE_DERIVATION_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_B0_BASE_DERIVATION_KEY = new DeriveKeyUsage("TR31_B0_BASE_DERIVATION_KEY");
        /// <summary>
        /// Constant TR31_C0_CARD_VERIFICATION_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_C0_CARD_VERIFICATION_KEY = new DeriveKeyUsage("TR31_C0_CARD_VERIFICATION_KEY");
        /// <summary>
        /// Constant TR31_D0_SYMMETRIC_DATA_ENCRYPTION_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_D0_SYMMETRIC_DATA_ENCRYPTION_KEY = new DeriveKeyUsage("TR31_D0_SYMMETRIC_DATA_ENCRYPTION_KEY");
        /// <summary>
        /// Constant TR31_E0_EMV_MKEY_APP_CRYPTOGRAMS for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_E0_EMV_MKEY_APP_CRYPTOGRAMS = new DeriveKeyUsage("TR31_E0_EMV_MKEY_APP_CRYPTOGRAMS");
        /// <summary>
        /// Constant TR31_E1_EMV_MKEY_CONFIDENTIALITY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_E1_EMV_MKEY_CONFIDENTIALITY = new DeriveKeyUsage("TR31_E1_EMV_MKEY_CONFIDENTIALITY");
        /// <summary>
        /// Constant TR31_E2_EMV_MKEY_INTEGRITY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_E2_EMV_MKEY_INTEGRITY = new DeriveKeyUsage("TR31_E2_EMV_MKEY_INTEGRITY");
        /// <summary>
        /// Constant TR31_E4_EMV_MKEY_DYNAMIC_NUMBERS for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_E4_EMV_MKEY_DYNAMIC_NUMBERS = new DeriveKeyUsage("TR31_E4_EMV_MKEY_DYNAMIC_NUMBERS");
        /// <summary>
        /// Constant TR31_E5_EMV_MKEY_CARD_PERSONALIZATION for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_E5_EMV_MKEY_CARD_PERSONALIZATION = new DeriveKeyUsage("TR31_E5_EMV_MKEY_CARD_PERSONALIZATION");
        /// <summary>
        /// Constant TR31_E6_EMV_MKEY_OTHER for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_E6_EMV_MKEY_OTHER = new DeriveKeyUsage("TR31_E6_EMV_MKEY_OTHER");
        /// <summary>
        /// Constant TR31_K0_KEY_ENCRYPTION_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_K0_KEY_ENCRYPTION_KEY = new DeriveKeyUsage("TR31_K0_KEY_ENCRYPTION_KEY");
        /// <summary>
        /// Constant TR31_K1_KEY_BLOCK_PROTECTION_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_K1_KEY_BLOCK_PROTECTION_KEY = new DeriveKeyUsage("TR31_K1_KEY_BLOCK_PROTECTION_KEY");
        /// <summary>
        /// Constant TR31_M1_ISO_9797_1_MAC_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_M1_ISO_9797_1_MAC_KEY = new DeriveKeyUsage("TR31_M1_ISO_9797_1_MAC_KEY");
        /// <summary>
        /// Constant TR31_M3_ISO_9797_3_MAC_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_M3_ISO_9797_3_MAC_KEY = new DeriveKeyUsage("TR31_M3_ISO_9797_3_MAC_KEY");
        /// <summary>
        /// Constant TR31_M6_ISO_9797_5_CMAC_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_M6_ISO_9797_5_CMAC_KEY = new DeriveKeyUsage("TR31_M6_ISO_9797_5_CMAC_KEY");
        /// <summary>
        /// Constant TR31_M7_HMAC_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_M7_HMAC_KEY = new DeriveKeyUsage("TR31_M7_HMAC_KEY");
        /// <summary>
        /// Constant TR31_P0_PIN_ENCRYPTION_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_P0_PIN_ENCRYPTION_KEY = new DeriveKeyUsage("TR31_P0_PIN_ENCRYPTION_KEY");
        /// <summary>
        /// Constant TR31_P1_PIN_GENERATION_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_P1_PIN_GENERATION_KEY = new DeriveKeyUsage("TR31_P1_PIN_GENERATION_KEY");
        /// <summary>
        /// Constant TR31_V1_IBM3624_PIN_VERIFICATION_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_V1_IBM3624_PIN_VERIFICATION_KEY = new DeriveKeyUsage("TR31_V1_IBM3624_PIN_VERIFICATION_KEY");
        /// <summary>
        /// Constant TR31_V2_VISA_PIN_VERIFICATION_KEY for DeriveKeyUsage
        /// </summary>
        public static readonly DeriveKeyUsage TR31_V2_VISA_PIN_VERIFICATION_KEY = new DeriveKeyUsage("TR31_V2_VISA_PIN_VERIFICATION_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeriveKeyUsage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeriveKeyUsage FindValue(string value)
        {
            return FindValue<DeriveKeyUsage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeriveKeyUsage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyAlgorithm.
    /// </summary>
    public class KeyAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant AES_128 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm AES_128 = new KeyAlgorithm("AES_128");
        /// <summary>
        /// Constant AES_192 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm AES_192 = new KeyAlgorithm("AES_192");
        /// <summary>
        /// Constant AES_256 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm AES_256 = new KeyAlgorithm("AES_256");
        /// <summary>
        /// Constant ECC_NIST_P256 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm ECC_NIST_P256 = new KeyAlgorithm("ECC_NIST_P256");
        /// <summary>
        /// Constant ECC_NIST_P384 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm ECC_NIST_P384 = new KeyAlgorithm("ECC_NIST_P384");
        /// <summary>
        /// Constant ECC_NIST_P521 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm ECC_NIST_P521 = new KeyAlgorithm("ECC_NIST_P521");
        /// <summary>
        /// Constant HMAC_SHA224 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm HMAC_SHA224 = new KeyAlgorithm("HMAC_SHA224");
        /// <summary>
        /// Constant HMAC_SHA256 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm HMAC_SHA256 = new KeyAlgorithm("HMAC_SHA256");
        /// <summary>
        /// Constant HMAC_SHA384 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm HMAC_SHA384 = new KeyAlgorithm("HMAC_SHA384");
        /// <summary>
        /// Constant HMAC_SHA512 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm HMAC_SHA512 = new KeyAlgorithm("HMAC_SHA512");
        /// <summary>
        /// Constant RSA_2048 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm RSA_2048 = new KeyAlgorithm("RSA_2048");
        /// <summary>
        /// Constant RSA_3072 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm RSA_3072 = new KeyAlgorithm("RSA_3072");
        /// <summary>
        /// Constant RSA_4096 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm RSA_4096 = new KeyAlgorithm("RSA_4096");
        /// <summary>
        /// Constant TDES_2KEY for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm TDES_2KEY = new KeyAlgorithm("TDES_2KEY");
        /// <summary>
        /// Constant TDES_3KEY for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm TDES_3KEY = new KeyAlgorithm("TDES_3KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyAlgorithm FindValue(string value)
        {
            return FindValue<KeyAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyCheckValueAlgorithm.
    /// </summary>
    public class KeyCheckValueAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant ANSI_X9_24 for KeyCheckValueAlgorithm
        /// </summary>
        public static readonly KeyCheckValueAlgorithm ANSI_X9_24 = new KeyCheckValueAlgorithm("ANSI_X9_24");
        /// <summary>
        /// Constant CMAC for KeyCheckValueAlgorithm
        /// </summary>
        public static readonly KeyCheckValueAlgorithm CMAC = new KeyCheckValueAlgorithm("CMAC");
        /// <summary>
        /// Constant HMAC for KeyCheckValueAlgorithm
        /// </summary>
        public static readonly KeyCheckValueAlgorithm HMAC = new KeyCheckValueAlgorithm("HMAC");
        /// <summary>
        /// Constant SHA_1 for KeyCheckValueAlgorithm
        /// </summary>
        public static readonly KeyCheckValueAlgorithm SHA_1 = new KeyCheckValueAlgorithm("SHA_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyCheckValueAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyCheckValueAlgorithm FindValue(string value)
        {
            return FindValue<KeyCheckValueAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyCheckValueAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyClass.
    /// </summary>
    public class KeyClass : ConstantClass
    {

        /// <summary>
        /// Constant ASYMMETRIC_KEY_PAIR for KeyClass
        /// </summary>
        public static readonly KeyClass ASYMMETRIC_KEY_PAIR = new KeyClass("ASYMMETRIC_KEY_PAIR");
        /// <summary>
        /// Constant PRIVATE_KEY for KeyClass
        /// </summary>
        public static readonly KeyClass PRIVATE_KEY = new KeyClass("PRIVATE_KEY");
        /// <summary>
        /// Constant PUBLIC_KEY for KeyClass
        /// </summary>
        public static readonly KeyClass PUBLIC_KEY = new KeyClass("PUBLIC_KEY");
        /// <summary>
        /// Constant SYMMETRIC_KEY for KeyClass
        /// </summary>
        public static readonly KeyClass SYMMETRIC_KEY = new KeyClass("SYMMETRIC_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyClass FindValue(string value)
        {
            return FindValue<KeyClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyDerivationFunction.
    /// </summary>
    public class KeyDerivationFunction : ConstantClass
    {

        /// <summary>
        /// Constant ANSI_X963 for KeyDerivationFunction
        /// </summary>
        public static readonly KeyDerivationFunction ANSI_X963 = new KeyDerivationFunction("ANSI_X963");
        /// <summary>
        /// Constant NIST_SP800 for KeyDerivationFunction
        /// </summary>
        public static readonly KeyDerivationFunction NIST_SP800 = new KeyDerivationFunction("NIST_SP800");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyDerivationFunction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyDerivationFunction FindValue(string value)
        {
            return FindValue<KeyDerivationFunction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyDerivationFunction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyDerivationHashAlgorithm.
    /// </summary>
    public class KeyDerivationHashAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant SHA_256 for KeyDerivationHashAlgorithm
        /// </summary>
        public static readonly KeyDerivationHashAlgorithm SHA_256 = new KeyDerivationHashAlgorithm("SHA_256");
        /// <summary>
        /// Constant SHA_384 for KeyDerivationHashAlgorithm
        /// </summary>
        public static readonly KeyDerivationHashAlgorithm SHA_384 = new KeyDerivationHashAlgorithm("SHA_384");
        /// <summary>
        /// Constant SHA_512 for KeyDerivationHashAlgorithm
        /// </summary>
        public static readonly KeyDerivationHashAlgorithm SHA_512 = new KeyDerivationHashAlgorithm("SHA_512");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyDerivationHashAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyDerivationHashAlgorithm FindValue(string value)
        {
            return FindValue<KeyDerivationHashAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyDerivationHashAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyExportability.
    /// </summary>
    public class KeyExportability : ConstantClass
    {

        /// <summary>
        /// Constant EXPORTABLE for KeyExportability
        /// </summary>
        public static readonly KeyExportability EXPORTABLE = new KeyExportability("EXPORTABLE");
        /// <summary>
        /// Constant NON_EXPORTABLE for KeyExportability
        /// </summary>
        public static readonly KeyExportability NON_EXPORTABLE = new KeyExportability("NON_EXPORTABLE");
        /// <summary>
        /// Constant SENSITIVE for KeyExportability
        /// </summary>
        public static readonly KeyExportability SENSITIVE = new KeyExportability("SENSITIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyExportability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyExportability FindValue(string value)
        {
            return FindValue<KeyExportability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyExportability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyMaterialType.
    /// </summary>
    public class KeyMaterialType : ConstantClass
    {

        /// <summary>
        /// Constant KEY_CRYPTOGRAM for KeyMaterialType
        /// </summary>
        public static readonly KeyMaterialType KEY_CRYPTOGRAM = new KeyMaterialType("KEY_CRYPTOGRAM");
        /// <summary>
        /// Constant ROOT_PUBLIC_KEY_CERTIFICATE for KeyMaterialType
        /// </summary>
        public static readonly KeyMaterialType ROOT_PUBLIC_KEY_CERTIFICATE = new KeyMaterialType("ROOT_PUBLIC_KEY_CERTIFICATE");
        /// <summary>
        /// Constant TR31_KEY_BLOCK for KeyMaterialType
        /// </summary>
        public static readonly KeyMaterialType TR31_KEY_BLOCK = new KeyMaterialType("TR31_KEY_BLOCK");
        /// <summary>
        /// Constant TR34_KEY_BLOCK for KeyMaterialType
        /// </summary>
        public static readonly KeyMaterialType TR34_KEY_BLOCK = new KeyMaterialType("TR34_KEY_BLOCK");
        /// <summary>
        /// Constant TRUSTED_PUBLIC_KEY_CERTIFICATE for KeyMaterialType
        /// </summary>
        public static readonly KeyMaterialType TRUSTED_PUBLIC_KEY_CERTIFICATE = new KeyMaterialType("TRUSTED_PUBLIC_KEY_CERTIFICATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyMaterialType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyMaterialType FindValue(string value)
        {
            return FindValue<KeyMaterialType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyMaterialType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyOrigin.
    /// </summary>
    public class KeyOrigin : ConstantClass
    {

        /// <summary>
        /// Constant AWS_PAYMENT_CRYPTOGRAPHY for KeyOrigin
        /// </summary>
        public static readonly KeyOrigin AWS_PAYMENT_CRYPTOGRAPHY = new KeyOrigin("AWS_PAYMENT_CRYPTOGRAPHY");
        /// <summary>
        /// Constant EXTERNAL for KeyOrigin
        /// </summary>
        public static readonly KeyOrigin EXTERNAL = new KeyOrigin("EXTERNAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyOrigin(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyOrigin FindValue(string value)
        {
            return FindValue<KeyOrigin>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyOrigin(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyReplicationState.
    /// </summary>
    public class KeyReplicationState : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_IN_PROGRESS for KeyReplicationState
        /// </summary>
        public static readonly KeyReplicationState DELETE_IN_PROGRESS = new KeyReplicationState("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant FAILED for KeyReplicationState
        /// </summary>
        public static readonly KeyReplicationState FAILED = new KeyReplicationState("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for KeyReplicationState
        /// </summary>
        public static readonly KeyReplicationState IN_PROGRESS = new KeyReplicationState("IN_PROGRESS");
        /// <summary>
        /// Constant SYNCHRONIZED for KeyReplicationState
        /// </summary>
        public static readonly KeyReplicationState SYNCHRONIZED = new KeyReplicationState("SYNCHRONIZED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyReplicationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyReplicationState FindValue(string value)
        {
            return FindValue<KeyReplicationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyReplicationState(string value)
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
        /// Constant CREATE_COMPLETE for KeyState
        /// </summary>
        public static readonly KeyState CREATE_COMPLETE = new KeyState("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for KeyState
        /// </summary>
        public static readonly KeyState CREATE_IN_PROGRESS = new KeyState("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_COMPLETE for KeyState
        /// </summary>
        public static readonly KeyState DELETE_COMPLETE = new KeyState("DELETE_COMPLETE");
        /// <summary>
        /// Constant DELETE_PENDING for KeyState
        /// </summary>
        public static readonly KeyState DELETE_PENDING = new KeyState("DELETE_PENDING");

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
    /// Constants used for properties of type KeyUsage.
    /// </summary>
    public class KeyUsage : ConstantClass
    {

        /// <summary>
        /// Constant TR31_B0_BASE_DERIVATION_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_B0_BASE_DERIVATION_KEY = new KeyUsage("TR31_B0_BASE_DERIVATION_KEY");
        /// <summary>
        /// Constant TR31_C0_CARD_VERIFICATION_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_C0_CARD_VERIFICATION_KEY = new KeyUsage("TR31_C0_CARD_VERIFICATION_KEY");
        /// <summary>
        /// Constant TR31_D0_SYMMETRIC_DATA_ENCRYPTION_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_D0_SYMMETRIC_DATA_ENCRYPTION_KEY = new KeyUsage("TR31_D0_SYMMETRIC_DATA_ENCRYPTION_KEY");
        /// <summary>
        /// Constant TR31_D1_ASYMMETRIC_KEY_FOR_DATA_ENCRYPTION for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_D1_ASYMMETRIC_KEY_FOR_DATA_ENCRYPTION = new KeyUsage("TR31_D1_ASYMMETRIC_KEY_FOR_DATA_ENCRYPTION");
        /// <summary>
        /// Constant TR31_E0_EMV_MKEY_APP_CRYPTOGRAMS for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_E0_EMV_MKEY_APP_CRYPTOGRAMS = new KeyUsage("TR31_E0_EMV_MKEY_APP_CRYPTOGRAMS");
        /// <summary>
        /// Constant TR31_E1_EMV_MKEY_CONFIDENTIALITY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_E1_EMV_MKEY_CONFIDENTIALITY = new KeyUsage("TR31_E1_EMV_MKEY_CONFIDENTIALITY");
        /// <summary>
        /// Constant TR31_E2_EMV_MKEY_INTEGRITY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_E2_EMV_MKEY_INTEGRITY = new KeyUsage("TR31_E2_EMV_MKEY_INTEGRITY");
        /// <summary>
        /// Constant TR31_E4_EMV_MKEY_DYNAMIC_NUMBERS for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_E4_EMV_MKEY_DYNAMIC_NUMBERS = new KeyUsage("TR31_E4_EMV_MKEY_DYNAMIC_NUMBERS");
        /// <summary>
        /// Constant TR31_E5_EMV_MKEY_CARD_PERSONALIZATION for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_E5_EMV_MKEY_CARD_PERSONALIZATION = new KeyUsage("TR31_E5_EMV_MKEY_CARD_PERSONALIZATION");
        /// <summary>
        /// Constant TR31_E6_EMV_MKEY_OTHER for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_E6_EMV_MKEY_OTHER = new KeyUsage("TR31_E6_EMV_MKEY_OTHER");
        /// <summary>
        /// Constant TR31_K0_KEY_ENCRYPTION_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_K0_KEY_ENCRYPTION_KEY = new KeyUsage("TR31_K0_KEY_ENCRYPTION_KEY");
        /// <summary>
        /// Constant TR31_K1_KEY_BLOCK_PROTECTION_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_K1_KEY_BLOCK_PROTECTION_KEY = new KeyUsage("TR31_K1_KEY_BLOCK_PROTECTION_KEY");
        /// <summary>
        /// Constant TR31_K2_TR34_ASYMMETRIC_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_K2_TR34_ASYMMETRIC_KEY = new KeyUsage("TR31_K2_TR34_ASYMMETRIC_KEY");
        /// <summary>
        /// Constant TR31_K3_ASYMMETRIC_KEY_FOR_KEY_AGREEMENT for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_K3_ASYMMETRIC_KEY_FOR_KEY_AGREEMENT = new KeyUsage("TR31_K3_ASYMMETRIC_KEY_FOR_KEY_AGREEMENT");
        /// <summary>
        /// Constant TR31_M1_ISO_9797_1_MAC_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_M1_ISO_9797_1_MAC_KEY = new KeyUsage("TR31_M1_ISO_9797_1_MAC_KEY");
        /// <summary>
        /// Constant TR31_M3_ISO_9797_3_MAC_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_M3_ISO_9797_3_MAC_KEY = new KeyUsage("TR31_M3_ISO_9797_3_MAC_KEY");
        /// <summary>
        /// Constant TR31_M6_ISO_9797_5_CMAC_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_M6_ISO_9797_5_CMAC_KEY = new KeyUsage("TR31_M6_ISO_9797_5_CMAC_KEY");
        /// <summary>
        /// Constant TR31_M7_HMAC_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_M7_HMAC_KEY = new KeyUsage("TR31_M7_HMAC_KEY");
        /// <summary>
        /// Constant TR31_P0_PIN_ENCRYPTION_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_P0_PIN_ENCRYPTION_KEY = new KeyUsage("TR31_P0_PIN_ENCRYPTION_KEY");
        /// <summary>
        /// Constant TR31_P1_PIN_GENERATION_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_P1_PIN_GENERATION_KEY = new KeyUsage("TR31_P1_PIN_GENERATION_KEY");
        /// <summary>
        /// Constant TR31_S0_ASYMMETRIC_KEY_FOR_DIGITAL_SIGNATURE for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_S0_ASYMMETRIC_KEY_FOR_DIGITAL_SIGNATURE = new KeyUsage("TR31_S0_ASYMMETRIC_KEY_FOR_DIGITAL_SIGNATURE");
        /// <summary>
        /// Constant TR31_V1_IBM3624_PIN_VERIFICATION_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_V1_IBM3624_PIN_VERIFICATION_KEY = new KeyUsage("TR31_V1_IBM3624_PIN_VERIFICATION_KEY");
        /// <summary>
        /// Constant TR31_V2_VISA_PIN_VERIFICATION_KEY for KeyUsage
        /// </summary>
        public static readonly KeyUsage TR31_V2_VISA_PIN_VERIFICATION_KEY = new KeyUsage("TR31_V2_VISA_PIN_VERIFICATION_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyUsage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyUsage FindValue(string value)
        {
            return FindValue<KeyUsage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyUsage(string value)
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
    /// Constants used for properties of type SigningAlgorithmType.
    /// </summary>
    public class SigningAlgorithmType : ConstantClass
    {

        /// <summary>
        /// Constant SHA224 for SigningAlgorithmType
        /// </summary>
        public static readonly SigningAlgorithmType SHA224 = new SigningAlgorithmType("SHA224");
        /// <summary>
        /// Constant SHA256 for SigningAlgorithmType
        /// </summary>
        public static readonly SigningAlgorithmType SHA256 = new SigningAlgorithmType("SHA256");
        /// <summary>
        /// Constant SHA384 for SigningAlgorithmType
        /// </summary>
        public static readonly SigningAlgorithmType SHA384 = new SigningAlgorithmType("SHA384");
        /// <summary>
        /// Constant SHA512 for SigningAlgorithmType
        /// </summary>
        public static readonly SigningAlgorithmType SHA512 = new SigningAlgorithmType("SHA512");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SigningAlgorithmType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SigningAlgorithmType FindValue(string value)
        {
            return FindValue<SigningAlgorithmType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SigningAlgorithmType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SymmetricKeyAlgorithm.
    /// </summary>
    public class SymmetricKeyAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant AES_128 for SymmetricKeyAlgorithm
        /// </summary>
        public static readonly SymmetricKeyAlgorithm AES_128 = new SymmetricKeyAlgorithm("AES_128");
        /// <summary>
        /// Constant AES_192 for SymmetricKeyAlgorithm
        /// </summary>
        public static readonly SymmetricKeyAlgorithm AES_192 = new SymmetricKeyAlgorithm("AES_192");
        /// <summary>
        /// Constant AES_256 for SymmetricKeyAlgorithm
        /// </summary>
        public static readonly SymmetricKeyAlgorithm AES_256 = new SymmetricKeyAlgorithm("AES_256");
        /// <summary>
        /// Constant HMAC_SHA224 for SymmetricKeyAlgorithm
        /// </summary>
        public static readonly SymmetricKeyAlgorithm HMAC_SHA224 = new SymmetricKeyAlgorithm("HMAC_SHA224");
        /// <summary>
        /// Constant HMAC_SHA256 for SymmetricKeyAlgorithm
        /// </summary>
        public static readonly SymmetricKeyAlgorithm HMAC_SHA256 = new SymmetricKeyAlgorithm("HMAC_SHA256");
        /// <summary>
        /// Constant HMAC_SHA384 for SymmetricKeyAlgorithm
        /// </summary>
        public static readonly SymmetricKeyAlgorithm HMAC_SHA384 = new SymmetricKeyAlgorithm("HMAC_SHA384");
        /// <summary>
        /// Constant HMAC_SHA512 for SymmetricKeyAlgorithm
        /// </summary>
        public static readonly SymmetricKeyAlgorithm HMAC_SHA512 = new SymmetricKeyAlgorithm("HMAC_SHA512");
        /// <summary>
        /// Constant TDES_2KEY for SymmetricKeyAlgorithm
        /// </summary>
        public static readonly SymmetricKeyAlgorithm TDES_2KEY = new SymmetricKeyAlgorithm("TDES_2KEY");
        /// <summary>
        /// Constant TDES_3KEY for SymmetricKeyAlgorithm
        /// </summary>
        public static readonly SymmetricKeyAlgorithm TDES_3KEY = new SymmetricKeyAlgorithm("TDES_3KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SymmetricKeyAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SymmetricKeyAlgorithm FindValue(string value)
        {
            return FindValue<SymmetricKeyAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SymmetricKeyAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Tr34KeyBlockFormat.
    /// </summary>
    public class Tr34KeyBlockFormat : ConstantClass
    {

        /// <summary>
        /// Constant X9_TR34_2012 for Tr34KeyBlockFormat
        /// </summary>
        public static readonly Tr34KeyBlockFormat X9_TR34_2012 = new Tr34KeyBlockFormat("X9_TR34_2012");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Tr34KeyBlockFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Tr34KeyBlockFormat FindValue(string value)
        {
            return FindValue<Tr34KeyBlockFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Tr34KeyBlockFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WrappedKeyMaterialFormat.
    /// </summary>
    public class WrappedKeyMaterialFormat : ConstantClass
    {

        /// <summary>
        /// Constant KEY_CRYPTOGRAM for WrappedKeyMaterialFormat
        /// </summary>
        public static readonly WrappedKeyMaterialFormat KEY_CRYPTOGRAM = new WrappedKeyMaterialFormat("KEY_CRYPTOGRAM");
        /// <summary>
        /// Constant TR31_KEY_BLOCK for WrappedKeyMaterialFormat
        /// </summary>
        public static readonly WrappedKeyMaterialFormat TR31_KEY_BLOCK = new WrappedKeyMaterialFormat("TR31_KEY_BLOCK");
        /// <summary>
        /// Constant TR34_KEY_BLOCK for WrappedKeyMaterialFormat
        /// </summary>
        public static readonly WrappedKeyMaterialFormat TR34_KEY_BLOCK = new WrappedKeyMaterialFormat("TR34_KEY_BLOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WrappedKeyMaterialFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WrappedKeyMaterialFormat FindValue(string value)
        {
            return FindValue<WrappedKeyMaterialFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WrappedKeyMaterialFormat(string value)
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
        /// Constant RSA_OAEP_SHA_256 for WrappingKeySpec
        /// </summary>
        public static readonly WrappingKeySpec RSA_OAEP_SHA_256 = new WrappingKeySpec("RSA_OAEP_SHA_256");
        /// <summary>
        /// Constant RSA_OAEP_SHA_512 for WrappingKeySpec
        /// </summary>
        public static readonly WrappingKeySpec RSA_OAEP_SHA_512 = new WrappingKeySpec("RSA_OAEP_SHA_512");

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