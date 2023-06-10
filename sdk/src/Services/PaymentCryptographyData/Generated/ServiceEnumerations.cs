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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PaymentCryptographyData
{

    /// <summary>
    /// Constants used for properties of type DukptDerivationType.
    /// </summary>
    public class DukptDerivationType : ConstantClass
    {

        /// <summary>
        /// Constant AES_128 for DukptDerivationType
        /// </summary>
        public static readonly DukptDerivationType AES_128 = new DukptDerivationType("AES_128");
        /// <summary>
        /// Constant AES_192 for DukptDerivationType
        /// </summary>
        public static readonly DukptDerivationType AES_192 = new DukptDerivationType("AES_192");
        /// <summary>
        /// Constant AES_256 for DukptDerivationType
        /// </summary>
        public static readonly DukptDerivationType AES_256 = new DukptDerivationType("AES_256");
        /// <summary>
        /// Constant TDES_2KEY for DukptDerivationType
        /// </summary>
        public static readonly DukptDerivationType TDES_2KEY = new DukptDerivationType("TDES_2KEY");
        /// <summary>
        /// Constant TDES_3KEY for DukptDerivationType
        /// </summary>
        public static readonly DukptDerivationType TDES_3KEY = new DukptDerivationType("TDES_3KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DukptDerivationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DukptDerivationType FindValue(string value)
        {
            return FindValue<DukptDerivationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DukptDerivationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DukptEncryptionMode.
    /// </summary>
    public class DukptEncryptionMode : ConstantClass
    {

        /// <summary>
        /// Constant CBC for DukptEncryptionMode
        /// </summary>
        public static readonly DukptEncryptionMode CBC = new DukptEncryptionMode("CBC");
        /// <summary>
        /// Constant ECB for DukptEncryptionMode
        /// </summary>
        public static readonly DukptEncryptionMode ECB = new DukptEncryptionMode("ECB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DukptEncryptionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DukptEncryptionMode FindValue(string value)
        {
            return FindValue<DukptEncryptionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DukptEncryptionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DukptKeyVariant.
    /// </summary>
    public class DukptKeyVariant : ConstantClass
    {

        /// <summary>
        /// Constant BIDIRECTIONAL for DukptKeyVariant
        /// </summary>
        public static readonly DukptKeyVariant BIDIRECTIONAL = new DukptKeyVariant("BIDIRECTIONAL");
        /// <summary>
        /// Constant REQUEST for DukptKeyVariant
        /// </summary>
        public static readonly DukptKeyVariant REQUEST = new DukptKeyVariant("REQUEST");
        /// <summary>
        /// Constant RESPONSE for DukptKeyVariant
        /// </summary>
        public static readonly DukptKeyVariant RESPONSE = new DukptKeyVariant("RESPONSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DukptKeyVariant(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DukptKeyVariant FindValue(string value)
        {
            return FindValue<DukptKeyVariant>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DukptKeyVariant(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionMode.
    /// </summary>
    public class EncryptionMode : ConstantClass
    {

        /// <summary>
        /// Constant CBC for EncryptionMode
        /// </summary>
        public static readonly EncryptionMode CBC = new EncryptionMode("CBC");
        /// <summary>
        /// Constant CFB for EncryptionMode
        /// </summary>
        public static readonly EncryptionMode CFB = new EncryptionMode("CFB");
        /// <summary>
        /// Constant CFB1 for EncryptionMode
        /// </summary>
        public static readonly EncryptionMode CFB1 = new EncryptionMode("CFB1");
        /// <summary>
        /// Constant CFB128 for EncryptionMode
        /// </summary>
        public static readonly EncryptionMode CFB128 = new EncryptionMode("CFB128");
        /// <summary>
        /// Constant CFB64 for EncryptionMode
        /// </summary>
        public static readonly EncryptionMode CFB64 = new EncryptionMode("CFB64");
        /// <summary>
        /// Constant CFB8 for EncryptionMode
        /// </summary>
        public static readonly EncryptionMode CFB8 = new EncryptionMode("CFB8");
        /// <summary>
        /// Constant ECB for EncryptionMode
        /// </summary>
        public static readonly EncryptionMode ECB = new EncryptionMode("ECB");
        /// <summary>
        /// Constant OFB for EncryptionMode
        /// </summary>
        public static readonly EncryptionMode OFB = new EncryptionMode("OFB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionMode FindValue(string value)
        {
            return FindValue<EncryptionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MacAlgorithm.
    /// </summary>
    public class MacAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant CMAC for MacAlgorithm
        /// </summary>
        public static readonly MacAlgorithm CMAC = new MacAlgorithm("CMAC");
        /// <summary>
        /// Constant HMAC_SHA224 for MacAlgorithm
        /// </summary>
        public static readonly MacAlgorithm HMAC_SHA224 = new MacAlgorithm("HMAC_SHA224");
        /// <summary>
        /// Constant HMAC_SHA256 for MacAlgorithm
        /// </summary>
        public static readonly MacAlgorithm HMAC_SHA256 = new MacAlgorithm("HMAC_SHA256");
        /// <summary>
        /// Constant HMAC_SHA384 for MacAlgorithm
        /// </summary>
        public static readonly MacAlgorithm HMAC_SHA384 = new MacAlgorithm("HMAC_SHA384");
        /// <summary>
        /// Constant HMAC_SHA512 for MacAlgorithm
        /// </summary>
        public static readonly MacAlgorithm HMAC_SHA512 = new MacAlgorithm("HMAC_SHA512");
        /// <summary>
        /// Constant ISO9797_ALGORITHM1 for MacAlgorithm
        /// </summary>
        public static readonly MacAlgorithm ISO9797_ALGORITHM1 = new MacAlgorithm("ISO9797_ALGORITHM1");
        /// <summary>
        /// Constant ISO9797_ALGORITHM3 for MacAlgorithm
        /// </summary>
        public static readonly MacAlgorithm ISO9797_ALGORITHM3 = new MacAlgorithm("ISO9797_ALGORITHM3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MacAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MacAlgorithm FindValue(string value)
        {
            return FindValue<MacAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MacAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MajorKeyDerivationMode.
    /// </summary>
    public class MajorKeyDerivationMode : ConstantClass
    {

        /// <summary>
        /// Constant EMV_OPTION_A for MajorKeyDerivationMode
        /// </summary>
        public static readonly MajorKeyDerivationMode EMV_OPTION_A = new MajorKeyDerivationMode("EMV_OPTION_A");
        /// <summary>
        /// Constant EMV_OPTION_B for MajorKeyDerivationMode
        /// </summary>
        public static readonly MajorKeyDerivationMode EMV_OPTION_B = new MajorKeyDerivationMode("EMV_OPTION_B");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MajorKeyDerivationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MajorKeyDerivationMode FindValue(string value)
        {
            return FindValue<MajorKeyDerivationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MajorKeyDerivationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PaddingType.
    /// </summary>
    public class PaddingType : ConstantClass
    {

        /// <summary>
        /// Constant OAEP_SHA1 for PaddingType
        /// </summary>
        public static readonly PaddingType OAEP_SHA1 = new PaddingType("OAEP_SHA1");
        /// <summary>
        /// Constant OAEP_SHA256 for PaddingType
        /// </summary>
        public static readonly PaddingType OAEP_SHA256 = new PaddingType("OAEP_SHA256");
        /// <summary>
        /// Constant OAEP_SHA512 for PaddingType
        /// </summary>
        public static readonly PaddingType OAEP_SHA512 = new PaddingType("OAEP_SHA512");
        /// <summary>
        /// Constant PKCS1 for PaddingType
        /// </summary>
        public static readonly PaddingType PKCS1 = new PaddingType("PKCS1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaddingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaddingType FindValue(string value)
        {
            return FindValue<PaddingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaddingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PinBlockFormatForPinData.
    /// </summary>
    public class PinBlockFormatForPinData : ConstantClass
    {

        /// <summary>
        /// Constant ISO_FORMAT_0 for PinBlockFormatForPinData
        /// </summary>
        public static readonly PinBlockFormatForPinData ISO_FORMAT_0 = new PinBlockFormatForPinData("ISO_FORMAT_0");
        /// <summary>
        /// Constant ISO_FORMAT_3 for PinBlockFormatForPinData
        /// </summary>
        public static readonly PinBlockFormatForPinData ISO_FORMAT_3 = new PinBlockFormatForPinData("ISO_FORMAT_3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PinBlockFormatForPinData(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PinBlockFormatForPinData FindValue(string value)
        {
            return FindValue<PinBlockFormatForPinData>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PinBlockFormatForPinData(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionKeyDerivationMode.
    /// </summary>
    public class SessionKeyDerivationMode : ConstantClass
    {

        /// <summary>
        /// Constant AMEX for SessionKeyDerivationMode
        /// </summary>
        public static readonly SessionKeyDerivationMode AMEX = new SessionKeyDerivationMode("AMEX");
        /// <summary>
        /// Constant EMV_COMMON_SESSION_KEY for SessionKeyDerivationMode
        /// </summary>
        public static readonly SessionKeyDerivationMode EMV_COMMON_SESSION_KEY = new SessionKeyDerivationMode("EMV_COMMON_SESSION_KEY");
        /// <summary>
        /// Constant EMV2000 for SessionKeyDerivationMode
        /// </summary>
        public static readonly SessionKeyDerivationMode EMV2000 = new SessionKeyDerivationMode("EMV2000");
        /// <summary>
        /// Constant MASTERCARD_SESSION_KEY for SessionKeyDerivationMode
        /// </summary>
        public static readonly SessionKeyDerivationMode MASTERCARD_SESSION_KEY = new SessionKeyDerivationMode("MASTERCARD_SESSION_KEY");
        /// <summary>
        /// Constant VISA for SessionKeyDerivationMode
        /// </summary>
        public static readonly SessionKeyDerivationMode VISA = new SessionKeyDerivationMode("VISA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionKeyDerivationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionKeyDerivationMode FindValue(string value)
        {
            return FindValue<SessionKeyDerivationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionKeyDerivationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VerificationFailedReason.
    /// </summary>
    public class VerificationFailedReason : ConstantClass
    {

        /// <summary>
        /// Constant INVALID_AUTH_REQUEST_CRYPTOGRAM for VerificationFailedReason
        /// </summary>
        public static readonly VerificationFailedReason INVALID_AUTH_REQUEST_CRYPTOGRAM = new VerificationFailedReason("INVALID_AUTH_REQUEST_CRYPTOGRAM");
        /// <summary>
        /// Constant INVALID_MAC for VerificationFailedReason
        /// </summary>
        public static readonly VerificationFailedReason INVALID_MAC = new VerificationFailedReason("INVALID_MAC");
        /// <summary>
        /// Constant INVALID_PIN for VerificationFailedReason
        /// </summary>
        public static readonly VerificationFailedReason INVALID_PIN = new VerificationFailedReason("INVALID_PIN");
        /// <summary>
        /// Constant INVALID_VALIDATION_DATA for VerificationFailedReason
        /// </summary>
        public static readonly VerificationFailedReason INVALID_VALIDATION_DATA = new VerificationFailedReason("INVALID_VALIDATION_DATA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerificationFailedReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerificationFailedReason FindValue(string value)
        {
            return FindValue<VerificationFailedReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerificationFailedReason(string value)
        {
            return FindValue(value);
        }
    }

}