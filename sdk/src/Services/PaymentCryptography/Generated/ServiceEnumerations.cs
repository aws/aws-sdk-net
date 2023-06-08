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
    /// Constants used for properties of type KeyMaterialType.
    /// </summary>
    public class KeyMaterialType : ConstantClass
    {

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

}