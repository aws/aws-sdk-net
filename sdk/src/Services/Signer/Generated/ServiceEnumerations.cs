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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Signer
{

    /// <summary>
    /// Constants used for properties of type Category.
    /// </summary>
    public class Category : ConstantClass
    {

        /// <summary>
        /// Constant AWSIoT for Category
        /// </summary>
        public static readonly Category AWSIoT = new Category("AWSIoT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Category(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Category FindValue(string value)
        {
            return FindValue<Category>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Category(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionAlgorithm.
    /// </summary>
    public class EncryptionAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant ECDSA for EncryptionAlgorithm
        /// </summary>
        public static readonly EncryptionAlgorithm ECDSA = new EncryptionAlgorithm("ECDSA");
        /// <summary>
        /// Constant RSA for EncryptionAlgorithm
        /// </summary>
        public static readonly EncryptionAlgorithm RSA = new EncryptionAlgorithm("RSA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionAlgorithm FindValue(string value)
        {
            return FindValue<EncryptionAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HashAlgorithm.
    /// </summary>
    public class HashAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant SHA1 for HashAlgorithm
        /// </summary>
        public static readonly HashAlgorithm SHA1 = new HashAlgorithm("SHA1");
        /// <summary>
        /// Constant SHA256 for HashAlgorithm
        /// </summary>
        public static readonly HashAlgorithm SHA256 = new HashAlgorithm("SHA256");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HashAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HashAlgorithm FindValue(string value)
        {
            return FindValue<HashAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HashAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageFormat.
    /// </summary>
    public class ImageFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for ImageFormat
        /// </summary>
        public static readonly ImageFormat JSON = new ImageFormat("JSON");
        /// <summary>
        /// Constant JSONDetached for ImageFormat
        /// </summary>
        public static readonly ImageFormat JSONDetached = new ImageFormat("JSONDetached");
        /// <summary>
        /// Constant JSONEmbedded for ImageFormat
        /// </summary>
        public static readonly ImageFormat JSONEmbedded = new ImageFormat("JSONEmbedded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageFormat FindValue(string value)
        {
            return FindValue<ImageFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SigningProfileStatus.
    /// </summary>
    public class SigningProfileStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for SigningProfileStatus
        /// </summary>
        public static readonly SigningProfileStatus Active = new SigningProfileStatus("Active");
        /// <summary>
        /// Constant Canceled for SigningProfileStatus
        /// </summary>
        public static readonly SigningProfileStatus Canceled = new SigningProfileStatus("Canceled");
        /// <summary>
        /// Constant Revoked for SigningProfileStatus
        /// </summary>
        public static readonly SigningProfileStatus Revoked = new SigningProfileStatus("Revoked");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SigningProfileStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SigningProfileStatus FindValue(string value)
        {
            return FindValue<SigningProfileStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SigningProfileStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SigningStatus.
    /// </summary>
    public class SigningStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for SigningStatus
        /// </summary>
        public static readonly SigningStatus Failed = new SigningStatus("Failed");
        /// <summary>
        /// Constant InProgress for SigningStatus
        /// </summary>
        public static readonly SigningStatus InProgress = new SigningStatus("InProgress");
        /// <summary>
        /// Constant Succeeded for SigningStatus
        /// </summary>
        public static readonly SigningStatus Succeeded = new SigningStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SigningStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SigningStatus FindValue(string value)
        {
            return FindValue<SigningStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SigningStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidityType.
    /// </summary>
    public class ValidityType : ConstantClass
    {

        /// <summary>
        /// Constant DAYS for ValidityType
        /// </summary>
        public static readonly ValidityType DAYS = new ValidityType("DAYS");
        /// <summary>
        /// Constant MONTHS for ValidityType
        /// </summary>
        public static readonly ValidityType MONTHS = new ValidityType("MONTHS");
        /// <summary>
        /// Constant YEARS for ValidityType
        /// </summary>
        public static readonly ValidityType YEARS = new ValidityType("YEARS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidityType FindValue(string value)
        {
            return FindValue<ValidityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidityType(string value)
        {
            return FindValue(value);
        }
    }

}