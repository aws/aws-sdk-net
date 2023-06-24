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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Macie2
{

    /// <summary>
    /// Constants used for properties of type AdminStatus.
    /// </summary>
    public class AdminStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLING_IN_PROGRESS for AdminStatus
        /// </summary>
        public static readonly AdminStatus DISABLING_IN_PROGRESS = new AdminStatus("DISABLING_IN_PROGRESS");
        /// <summary>
        /// Constant ENABLED for AdminStatus
        /// </summary>
        public static readonly AdminStatus ENABLED = new AdminStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdminStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdminStatus FindValue(string value)
        {
            return FindValue<AdminStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdminStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AllowListStatusCode.
    /// </summary>
    public class AllowListStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant OK for AllowListStatusCode
        /// </summary>
        public static readonly AllowListStatusCode OK = new AllowListStatusCode("OK");
        /// <summary>
        /// Constant S3_OBJECT_ACCESS_DENIED for AllowListStatusCode
        /// </summary>
        public static readonly AllowListStatusCode S3_OBJECT_ACCESS_DENIED = new AllowListStatusCode("S3_OBJECT_ACCESS_DENIED");
        /// <summary>
        /// Constant S3_OBJECT_EMPTY for AllowListStatusCode
        /// </summary>
        public static readonly AllowListStatusCode S3_OBJECT_EMPTY = new AllowListStatusCode("S3_OBJECT_EMPTY");
        /// <summary>
        /// Constant S3_OBJECT_NOT_FOUND for AllowListStatusCode
        /// </summary>
        public static readonly AllowListStatusCode S3_OBJECT_NOT_FOUND = new AllowListStatusCode("S3_OBJECT_NOT_FOUND");
        /// <summary>
        /// Constant S3_OBJECT_OVERSIZE for AllowListStatusCode
        /// </summary>
        public static readonly AllowListStatusCode S3_OBJECT_OVERSIZE = new AllowListStatusCode("S3_OBJECT_OVERSIZE");
        /// <summary>
        /// Constant S3_THROTTLED for AllowListStatusCode
        /// </summary>
        public static readonly AllowListStatusCode S3_THROTTLED = new AllowListStatusCode("S3_THROTTLED");
        /// <summary>
        /// Constant S3_USER_ACCESS_DENIED for AllowListStatusCode
        /// </summary>
        public static readonly AllowListStatusCode S3_USER_ACCESS_DENIED = new AllowListStatusCode("S3_USER_ACCESS_DENIED");
        /// <summary>
        /// Constant UNKNOWN_ERROR for AllowListStatusCode
        /// </summary>
        public static readonly AllowListStatusCode UNKNOWN_ERROR = new AllowListStatusCode("UNKNOWN_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllowListStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllowListStatusCode FindValue(string value)
        {
            return FindValue<AllowListStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllowListStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AllowsUnencryptedObjectUploads.
    /// </summary>
    public class AllowsUnencryptedObjectUploads : ConstantClass
    {

        /// <summary>
        /// Constant FALSE for AllowsUnencryptedObjectUploads
        /// </summary>
        public static readonly AllowsUnencryptedObjectUploads FALSE = new AllowsUnencryptedObjectUploads("FALSE");
        /// <summary>
        /// Constant TRUE for AllowsUnencryptedObjectUploads
        /// </summary>
        public static readonly AllowsUnencryptedObjectUploads TRUE = new AllowsUnencryptedObjectUploads("TRUE");
        /// <summary>
        /// Constant UNKNOWN for AllowsUnencryptedObjectUploads
        /// </summary>
        public static readonly AllowsUnencryptedObjectUploads UNKNOWN = new AllowsUnencryptedObjectUploads("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllowsUnencryptedObjectUploads(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllowsUnencryptedObjectUploads FindValue(string value)
        {
            return FindValue<AllowsUnencryptedObjectUploads>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllowsUnencryptedObjectUploads(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomatedDiscoveryStatus.
    /// </summary>
    public class AutomatedDiscoveryStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AutomatedDiscoveryStatus
        /// </summary>
        public static readonly AutomatedDiscoveryStatus DISABLED = new AutomatedDiscoveryStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for AutomatedDiscoveryStatus
        /// </summary>
        public static readonly AutomatedDiscoveryStatus ENABLED = new AutomatedDiscoveryStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomatedDiscoveryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomatedDiscoveryStatus FindValue(string value)
        {
            return FindValue<AutomatedDiscoveryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomatedDiscoveryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvailabilityCode.
    /// </summary>
    public class AvailabilityCode : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for AvailabilityCode
        /// </summary>
        public static readonly AvailabilityCode AVAILABLE = new AvailabilityCode("AVAILABLE");
        /// <summary>
        /// Constant UNAVAILABLE for AvailabilityCode
        /// </summary>
        public static readonly AvailabilityCode UNAVAILABLE = new AvailabilityCode("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvailabilityCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvailabilityCode FindValue(string value)
        {
            return FindValue<AvailabilityCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvailabilityCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BucketMetadataErrorCode.
    /// </summary>
    public class BucketMetadataErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for BucketMetadataErrorCode
        /// </summary>
        public static readonly BucketMetadataErrorCode ACCESS_DENIED = new BucketMetadataErrorCode("ACCESS_DENIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BucketMetadataErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BucketMetadataErrorCode FindValue(string value)
        {
            return FindValue<BucketMetadataErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BucketMetadataErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClassificationScopeUpdateOperation.
    /// </summary>
    public class ClassificationScopeUpdateOperation : ConstantClass
    {

        /// <summary>
        /// Constant ADD for ClassificationScopeUpdateOperation
        /// </summary>
        public static readonly ClassificationScopeUpdateOperation ADD = new ClassificationScopeUpdateOperation("ADD");
        /// <summary>
        /// Constant REMOVE for ClassificationScopeUpdateOperation
        /// </summary>
        public static readonly ClassificationScopeUpdateOperation REMOVE = new ClassificationScopeUpdateOperation("REMOVE");
        /// <summary>
        /// Constant REPLACE for ClassificationScopeUpdateOperation
        /// </summary>
        public static readonly ClassificationScopeUpdateOperation REPLACE = new ClassificationScopeUpdateOperation("REPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClassificationScopeUpdateOperation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClassificationScopeUpdateOperation FindValue(string value)
        {
            return FindValue<ClassificationScopeUpdateOperation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClassificationScopeUpdateOperation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Currency.
    /// </summary>
    public class Currency : ConstantClass
    {

        /// <summary>
        /// Constant USD for Currency
        /// </summary>
        public static readonly Currency USD = new Currency("USD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Currency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Currency FindValue(string value)
        {
            return FindValue<Currency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Currency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataIdentifierSeverity.
    /// </summary>
    public class DataIdentifierSeverity : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for DataIdentifierSeverity
        /// </summary>
        public static readonly DataIdentifierSeverity HIGH = new DataIdentifierSeverity("HIGH");
        /// <summary>
        /// Constant LOW for DataIdentifierSeverity
        /// </summary>
        public static readonly DataIdentifierSeverity LOW = new DataIdentifierSeverity("LOW");
        /// <summary>
        /// Constant MEDIUM for DataIdentifierSeverity
        /// </summary>
        public static readonly DataIdentifierSeverity MEDIUM = new DataIdentifierSeverity("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataIdentifierSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIdentifierSeverity FindValue(string value)
        {
            return FindValue<DataIdentifierSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIdentifierSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataIdentifierType.
    /// </summary>
    public class DataIdentifierType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for DataIdentifierType
        /// </summary>
        public static readonly DataIdentifierType CUSTOM = new DataIdentifierType("CUSTOM");
        /// <summary>
        /// Constant MANAGED for DataIdentifierType
        /// </summary>
        public static readonly DataIdentifierType MANAGED = new DataIdentifierType("MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataIdentifierType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIdentifierType FindValue(string value)
        {
            return FindValue<DataIdentifierType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIdentifierType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DayOfWeek.
    /// </summary>
    public class DayOfWeek : ConstantClass
    {

        /// <summary>
        /// Constant FRIDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek FRIDAY = new DayOfWeek("FRIDAY");
        /// <summary>
        /// Constant MONDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek MONDAY = new DayOfWeek("MONDAY");
        /// <summary>
        /// Constant SATURDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SATURDAY = new DayOfWeek("SATURDAY");
        /// <summary>
        /// Constant SUNDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SUNDAY = new DayOfWeek("SUNDAY");
        /// <summary>
        /// Constant THURSDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek THURSDAY = new DayOfWeek("THURSDAY");
        /// <summary>
        /// Constant TUESDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek TUESDAY = new DayOfWeek("TUESDAY");
        /// <summary>
        /// Constant WEDNESDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek WEDNESDAY = new DayOfWeek("WEDNESDAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DayOfWeek(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DayOfWeek FindValue(string value)
        {
            return FindValue<DayOfWeek>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DayOfWeek(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EffectivePermission.
    /// </summary>
    public class EffectivePermission : ConstantClass
    {

        /// <summary>
        /// Constant NOT_PUBLIC for EffectivePermission
        /// </summary>
        public static readonly EffectivePermission NOT_PUBLIC = new EffectivePermission("NOT_PUBLIC");
        /// <summary>
        /// Constant PUBLIC for EffectivePermission
        /// </summary>
        public static readonly EffectivePermission PUBLIC = new EffectivePermission("PUBLIC");
        /// <summary>
        /// Constant UNKNOWN for EffectivePermission
        /// </summary>
        public static readonly EffectivePermission UNKNOWN = new EffectivePermission("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EffectivePermission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EffectivePermission FindValue(string value)
        {
            return FindValue<EffectivePermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EffectivePermission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant AES256 for EncryptionType
        /// </summary>
        public static readonly EncryptionType AES256 = new EncryptionType("AES256");
        /// <summary>
        /// Constant AwsKms for EncryptionType
        /// </summary>
        public static readonly EncryptionType AwsKms = new EncryptionType("aws:kms");
        /// <summary>
        /// Constant NONE for EncryptionType
        /// </summary>
        public static readonly EncryptionType NONE = new EncryptionType("NONE");
        /// <summary>
        /// Constant UNKNOWN for EncryptionType
        /// </summary>
        public static readonly EncryptionType UNKNOWN = new EncryptionType("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ClientError for ErrorCode
        /// </summary>
        public static readonly ErrorCode ClientError = new ErrorCode("ClientError");
        /// <summary>
        /// Constant InternalError for ErrorCode
        /// </summary>
        public static readonly ErrorCode InternalError = new ErrorCode("InternalError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingActionType.
    /// </summary>
    public class FindingActionType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_API_CALL for FindingActionType
        /// </summary>
        public static readonly FindingActionType AWS_API_CALL = new FindingActionType("AWS_API_CALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingActionType FindValue(string value)
        {
            return FindValue<FindingActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingCategory.
    /// </summary>
    public class FindingCategory : ConstantClass
    {

        /// <summary>
        /// Constant CLASSIFICATION for FindingCategory
        /// </summary>
        public static readonly FindingCategory CLASSIFICATION = new FindingCategory("CLASSIFICATION");
        /// <summary>
        /// Constant POLICY for FindingCategory
        /// </summary>
        public static readonly FindingCategory POLICY = new FindingCategory("POLICY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingCategory FindValue(string value)
        {
            return FindValue<FindingCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingPublishingFrequency.
    /// </summary>
    public class FindingPublishingFrequency : ConstantClass
    {

        /// <summary>
        /// Constant FIFTEEN_MINUTES for FindingPublishingFrequency
        /// </summary>
        public static readonly FindingPublishingFrequency FIFTEEN_MINUTES = new FindingPublishingFrequency("FIFTEEN_MINUTES");
        /// <summary>
        /// Constant ONE_HOUR for FindingPublishingFrequency
        /// </summary>
        public static readonly FindingPublishingFrequency ONE_HOUR = new FindingPublishingFrequency("ONE_HOUR");
        /// <summary>
        /// Constant SIX_HOURS for FindingPublishingFrequency
        /// </summary>
        public static readonly FindingPublishingFrequency SIX_HOURS = new FindingPublishingFrequency("SIX_HOURS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingPublishingFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingPublishingFrequency FindValue(string value)
        {
            return FindValue<FindingPublishingFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingPublishingFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingsFilterAction.
    /// </summary>
    public class FindingsFilterAction : ConstantClass
    {

        /// <summary>
        /// Constant ARCHIVE for FindingsFilterAction
        /// </summary>
        public static readonly FindingsFilterAction ARCHIVE = new FindingsFilterAction("ARCHIVE");
        /// <summary>
        /// Constant NOOP for FindingsFilterAction
        /// </summary>
        public static readonly FindingsFilterAction NOOP = new FindingsFilterAction("NOOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingsFilterAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingsFilterAction FindValue(string value)
        {
            return FindValue<FindingsFilterAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingsFilterAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingStatisticsSortAttributeName.
    /// </summary>
    public class FindingStatisticsSortAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant Count for FindingStatisticsSortAttributeName
        /// </summary>
        public static readonly FindingStatisticsSortAttributeName Count = new FindingStatisticsSortAttributeName("count");
        /// <summary>
        /// Constant GroupKey for FindingStatisticsSortAttributeName
        /// </summary>
        public static readonly FindingStatisticsSortAttributeName GroupKey = new FindingStatisticsSortAttributeName("groupKey");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingStatisticsSortAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingStatisticsSortAttributeName FindValue(string value)
        {
            return FindValue<FindingStatisticsSortAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingStatisticsSortAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingType.
    /// </summary>
    public class FindingType : ConstantClass
    {

        /// <summary>
        /// Constant PolicyIAMUserS3BlockPublicAccessDisabled for FindingType
        /// </summary>
        public static readonly FindingType PolicyIAMUserS3BlockPublicAccessDisabled = new FindingType("Policy:IAMUser/S3BlockPublicAccessDisabled");
        /// <summary>
        /// Constant PolicyIAMUserS3BucketEncryptionDisabled for FindingType
        /// </summary>
        public static readonly FindingType PolicyIAMUserS3BucketEncryptionDisabled = new FindingType("Policy:IAMUser/S3BucketEncryptionDisabled");
        /// <summary>
        /// Constant PolicyIAMUserS3BucketPublic for FindingType
        /// </summary>
        public static readonly FindingType PolicyIAMUserS3BucketPublic = new FindingType("Policy:IAMUser/S3BucketPublic");
        /// <summary>
        /// Constant PolicyIAMUserS3BucketReplicatedExternally for FindingType
        /// </summary>
        public static readonly FindingType PolicyIAMUserS3BucketReplicatedExternally = new FindingType("Policy:IAMUser/S3BucketReplicatedExternally");
        /// <summary>
        /// Constant PolicyIAMUserS3BucketSharedExternally for FindingType
        /// </summary>
        public static readonly FindingType PolicyIAMUserS3BucketSharedExternally = new FindingType("Policy:IAMUser/S3BucketSharedExternally");
        /// <summary>
        /// Constant PolicyIAMUserS3BucketSharedWithCloudFront for FindingType
        /// </summary>
        public static readonly FindingType PolicyIAMUserS3BucketSharedWithCloudFront = new FindingType("Policy:IAMUser/S3BucketSharedWithCloudFront");
        /// <summary>
        /// Constant SensitiveDataS3ObjectCredentials for FindingType
        /// </summary>
        public static readonly FindingType SensitiveDataS3ObjectCredentials = new FindingType("SensitiveData:S3Object/Credentials");
        /// <summary>
        /// Constant SensitiveDataS3ObjectCustomIdentifier for FindingType
        /// </summary>
        public static readonly FindingType SensitiveDataS3ObjectCustomIdentifier = new FindingType("SensitiveData:S3Object/CustomIdentifier");
        /// <summary>
        /// Constant SensitiveDataS3ObjectFinancial for FindingType
        /// </summary>
        public static readonly FindingType SensitiveDataS3ObjectFinancial = new FindingType("SensitiveData:S3Object/Financial");
        /// <summary>
        /// Constant SensitiveDataS3ObjectMultiple for FindingType
        /// </summary>
        public static readonly FindingType SensitiveDataS3ObjectMultiple = new FindingType("SensitiveData:S3Object/Multiple");
        /// <summary>
        /// Constant SensitiveDataS3ObjectPersonal for FindingType
        /// </summary>
        public static readonly FindingType SensitiveDataS3ObjectPersonal = new FindingType("SensitiveData:S3Object/Personal");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingType FindValue(string value)
        {
            return FindValue<FindingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupBy.
    /// </summary>
    public class GroupBy : ConstantClass
    {

        /// <summary>
        /// Constant ClassificationDetailsJobId for GroupBy
        /// </summary>
        public static readonly GroupBy ClassificationDetailsJobId = new GroupBy("classificationDetails.jobId");
        /// <summary>
        /// Constant ResourcesAffectedS3BucketName for GroupBy
        /// </summary>
        public static readonly GroupBy ResourcesAffectedS3BucketName = new GroupBy("resourcesAffected.s3Bucket.name");
        /// <summary>
        /// Constant SeverityDescription for GroupBy
        /// </summary>
        public static readonly GroupBy SeverityDescription = new GroupBy("severity.description");
        /// <summary>
        /// Constant Type for GroupBy
        /// </summary>
        public static readonly GroupBy Type = new GroupBy("type");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupBy FindValue(string value)
        {
            return FindValue<GroupBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IsDefinedInJob.
    /// </summary>
    public class IsDefinedInJob : ConstantClass
    {

        /// <summary>
        /// Constant FALSE for IsDefinedInJob
        /// </summary>
        public static readonly IsDefinedInJob FALSE = new IsDefinedInJob("FALSE");
        /// <summary>
        /// Constant TRUE for IsDefinedInJob
        /// </summary>
        public static readonly IsDefinedInJob TRUE = new IsDefinedInJob("TRUE");
        /// <summary>
        /// Constant UNKNOWN for IsDefinedInJob
        /// </summary>
        public static readonly IsDefinedInJob UNKNOWN = new IsDefinedInJob("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IsDefinedInJob(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IsDefinedInJob FindValue(string value)
        {
            return FindValue<IsDefinedInJob>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IsDefinedInJob(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IsMonitoredByJob.
    /// </summary>
    public class IsMonitoredByJob : ConstantClass
    {

        /// <summary>
        /// Constant FALSE for IsMonitoredByJob
        /// </summary>
        public static readonly IsMonitoredByJob FALSE = new IsMonitoredByJob("FALSE");
        /// <summary>
        /// Constant TRUE for IsMonitoredByJob
        /// </summary>
        public static readonly IsMonitoredByJob TRUE = new IsMonitoredByJob("TRUE");
        /// <summary>
        /// Constant UNKNOWN for IsMonitoredByJob
        /// </summary>
        public static readonly IsMonitoredByJob UNKNOWN = new IsMonitoredByJob("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IsMonitoredByJob(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IsMonitoredByJob FindValue(string value)
        {
            return FindValue<IsMonitoredByJob>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IsMonitoredByJob(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobComparator.
    /// </summary>
    public class JobComparator : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for JobComparator
        /// </summary>
        public static readonly JobComparator CONTAINS = new JobComparator("CONTAINS");
        /// <summary>
        /// Constant EQ for JobComparator
        /// </summary>
        public static readonly JobComparator EQ = new JobComparator("EQ");
        /// <summary>
        /// Constant GT for JobComparator
        /// </summary>
        public static readonly JobComparator GT = new JobComparator("GT");
        /// <summary>
        /// Constant GTE for JobComparator
        /// </summary>
        public static readonly JobComparator GTE = new JobComparator("GTE");
        /// <summary>
        /// Constant LT for JobComparator
        /// </summary>
        public static readonly JobComparator LT = new JobComparator("LT");
        /// <summary>
        /// Constant LTE for JobComparator
        /// </summary>
        public static readonly JobComparator LTE = new JobComparator("LTE");
        /// <summary>
        /// Constant NE for JobComparator
        /// </summary>
        public static readonly JobComparator NE = new JobComparator("NE");
        /// <summary>
        /// Constant STARTS_WITH for JobComparator
        /// </summary>
        public static readonly JobComparator STARTS_WITH = new JobComparator("STARTS_WITH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobComparator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobComparator FindValue(string value)
        {
            return FindValue<JobComparator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobComparator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for JobStatus
        /// </summary>
        public static readonly JobStatus CANCELLED = new JobStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETE for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETE = new JobStatus("COMPLETE");
        /// <summary>
        /// Constant IDLE for JobStatus
        /// </summary>
        public static readonly JobStatus IDLE = new JobStatus("IDLE");
        /// <summary>
        /// Constant PAUSED for JobStatus
        /// </summary>
        public static readonly JobStatus PAUSED = new JobStatus("PAUSED");
        /// <summary>
        /// Constant RUNNING for JobStatus
        /// </summary>
        public static readonly JobStatus RUNNING = new JobStatus("RUNNING");
        /// <summary>
        /// Constant USER_PAUSED for JobStatus
        /// </summary>
        public static readonly JobStatus USER_PAUSED = new JobStatus("USER_PAUSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatus FindValue(string value)
        {
            return FindValue<JobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobType.
    /// </summary>
    public class JobType : ConstantClass
    {

        /// <summary>
        /// Constant ONE_TIME for JobType
        /// </summary>
        public static readonly JobType ONE_TIME = new JobType("ONE_TIME");
        /// <summary>
        /// Constant SCHEDULED for JobType
        /// </summary>
        public static readonly JobType SCHEDULED = new JobType("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobType FindValue(string value)
        {
            return FindValue<JobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LastRunErrorStatusCode.
    /// </summary>
    public class LastRunErrorStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for LastRunErrorStatusCode
        /// </summary>
        public static readonly LastRunErrorStatusCode ERROR = new LastRunErrorStatusCode("ERROR");
        /// <summary>
        /// Constant NONE for LastRunErrorStatusCode
        /// </summary>
        public static readonly LastRunErrorStatusCode NONE = new LastRunErrorStatusCode("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastRunErrorStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastRunErrorStatusCode FindValue(string value)
        {
            return FindValue<LastRunErrorStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastRunErrorStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListJobsFilterKey.
    /// </summary>
    public class ListJobsFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant CreatedAt for ListJobsFilterKey
        /// </summary>
        public static readonly ListJobsFilterKey CreatedAt = new ListJobsFilterKey("createdAt");
        /// <summary>
        /// Constant JobStatus for ListJobsFilterKey
        /// </summary>
        public static readonly ListJobsFilterKey JobStatus = new ListJobsFilterKey("jobStatus");
        /// <summary>
        /// Constant JobType for ListJobsFilterKey
        /// </summary>
        public static readonly ListJobsFilterKey JobType = new ListJobsFilterKey("jobType");
        /// <summary>
        /// Constant Name for ListJobsFilterKey
        /// </summary>
        public static readonly ListJobsFilterKey Name = new ListJobsFilterKey("name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListJobsFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListJobsFilterKey FindValue(string value)
        {
            return FindValue<ListJobsFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListJobsFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListJobsSortAttributeName.
    /// </summary>
    public class ListJobsSortAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant CreatedAt for ListJobsSortAttributeName
        /// </summary>
        public static readonly ListJobsSortAttributeName CreatedAt = new ListJobsSortAttributeName("createdAt");
        /// <summary>
        /// Constant JobStatus for ListJobsSortAttributeName
        /// </summary>
        public static readonly ListJobsSortAttributeName JobStatus = new ListJobsSortAttributeName("jobStatus");
        /// <summary>
        /// Constant JobType for ListJobsSortAttributeName
        /// </summary>
        public static readonly ListJobsSortAttributeName JobType = new ListJobsSortAttributeName("jobType");
        /// <summary>
        /// Constant Name for ListJobsSortAttributeName
        /// </summary>
        public static readonly ListJobsSortAttributeName Name = new ListJobsSortAttributeName("name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListJobsSortAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListJobsSortAttributeName FindValue(string value)
        {
            return FindValue<ListJobsSortAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListJobsSortAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MacieStatus.
    /// </summary>
    public class MacieStatus : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for MacieStatus
        /// </summary>
        public static readonly MacieStatus ENABLED = new MacieStatus("ENABLED");
        /// <summary>
        /// Constant PAUSED for MacieStatus
        /// </summary>
        public static readonly MacieStatus PAUSED = new MacieStatus("PAUSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MacieStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MacieStatus FindValue(string value)
        {
            return FindValue<MacieStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MacieStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManagedDataIdentifierSelector.
    /// </summary>
    public class ManagedDataIdentifierSelector : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ManagedDataIdentifierSelector
        /// </summary>
        public static readonly ManagedDataIdentifierSelector ALL = new ManagedDataIdentifierSelector("ALL");
        /// <summary>
        /// Constant EXCLUDE for ManagedDataIdentifierSelector
        /// </summary>
        public static readonly ManagedDataIdentifierSelector EXCLUDE = new ManagedDataIdentifierSelector("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for ManagedDataIdentifierSelector
        /// </summary>
        public static readonly ManagedDataIdentifierSelector INCLUDE = new ManagedDataIdentifierSelector("INCLUDE");
        /// <summary>
        /// Constant NONE for ManagedDataIdentifierSelector
        /// </summary>
        public static readonly ManagedDataIdentifierSelector NONE = new ManagedDataIdentifierSelector("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManagedDataIdentifierSelector(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagedDataIdentifierSelector FindValue(string value)
        {
            return FindValue<ManagedDataIdentifierSelector>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagedDataIdentifierSelector(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderBy.
    /// </summary>
    public class OrderBy : ConstantClass
    {

        /// <summary>
        /// Constant ASC for OrderBy
        /// </summary>
        public static readonly OrderBy ASC = new OrderBy("ASC");
        /// <summary>
        /// Constant DESC for OrderBy
        /// </summary>
        public static readonly OrderBy DESC = new OrderBy("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderBy FindValue(string value)
        {
            return FindValue<OrderBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderBy(string value)
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
        /// Constant AUTOMATED_SENSITIVE_DATA_DISCOVERY for OriginType
        /// </summary>
        public static readonly OriginType AUTOMATED_SENSITIVE_DATA_DISCOVERY = new OriginType("AUTOMATED_SENSITIVE_DATA_DISCOVERY");
        /// <summary>
        /// Constant SENSITIVE_DATA_DISCOVERY_JOB for OriginType
        /// </summary>
        public static readonly OriginType SENSITIVE_DATA_DISCOVERY_JOB = new OriginType("SENSITIVE_DATA_DISCOVERY_JOB");

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
    /// Constants used for properties of type RelationshipStatus.
    /// </summary>
    public class RelationshipStatus : ConstantClass
    {

        /// <summary>
        /// Constant AccountSuspended for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus AccountSuspended = new RelationshipStatus("AccountSuspended");
        /// <summary>
        /// Constant Created for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus Created = new RelationshipStatus("Created");
        /// <summary>
        /// Constant EmailVerificationFailed for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus EmailVerificationFailed = new RelationshipStatus("EmailVerificationFailed");
        /// <summary>
        /// Constant EmailVerificationInProgress for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus EmailVerificationInProgress = new RelationshipStatus("EmailVerificationInProgress");
        /// <summary>
        /// Constant Enabled for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus Enabled = new RelationshipStatus("Enabled");
        /// <summary>
        /// Constant Invited for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus Invited = new RelationshipStatus("Invited");
        /// <summary>
        /// Constant Paused for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus Paused = new RelationshipStatus("Paused");
        /// <summary>
        /// Constant RegionDisabled for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus RegionDisabled = new RelationshipStatus("RegionDisabled");
        /// <summary>
        /// Constant Removed for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus Removed = new RelationshipStatus("Removed");
        /// <summary>
        /// Constant Resigned for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus Resigned = new RelationshipStatus("Resigned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelationshipStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelationshipStatus FindValue(string value)
        {
            return FindValue<RelationshipStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelationshipStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RevealRequestStatus.
    /// </summary>
    public class RevealRequestStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for RevealRequestStatus
        /// </summary>
        public static readonly RevealRequestStatus ERROR = new RevealRequestStatus("ERROR");
        /// <summary>
        /// Constant PROCESSING for RevealRequestStatus
        /// </summary>
        public static readonly RevealRequestStatus PROCESSING = new RevealRequestStatus("PROCESSING");
        /// <summary>
        /// Constant SUCCESS for RevealRequestStatus
        /// </summary>
        public static readonly RevealRequestStatus SUCCESS = new RevealRequestStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RevealRequestStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevealRequestStatus FindValue(string value)
        {
            return FindValue<RevealRequestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevealRequestStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RevealStatus.
    /// </summary>
    public class RevealStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for RevealStatus
        /// </summary>
        public static readonly RevealStatus DISABLED = new RevealStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for RevealStatus
        /// </summary>
        public static readonly RevealStatus ENABLED = new RevealStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RevealStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevealStatus FindValue(string value)
        {
            return FindValue<RevealStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevealStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScopeFilterKey.
    /// </summary>
    public class ScopeFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant OBJECT_EXTENSION for ScopeFilterKey
        /// </summary>
        public static readonly ScopeFilterKey OBJECT_EXTENSION = new ScopeFilterKey("OBJECT_EXTENSION");
        /// <summary>
        /// Constant OBJECT_KEY for ScopeFilterKey
        /// </summary>
        public static readonly ScopeFilterKey OBJECT_KEY = new ScopeFilterKey("OBJECT_KEY");
        /// <summary>
        /// Constant OBJECT_LAST_MODIFIED_DATE for ScopeFilterKey
        /// </summary>
        public static readonly ScopeFilterKey OBJECT_LAST_MODIFIED_DATE = new ScopeFilterKey("OBJECT_LAST_MODIFIED_DATE");
        /// <summary>
        /// Constant OBJECT_SIZE for ScopeFilterKey
        /// </summary>
        public static readonly ScopeFilterKey OBJECT_SIZE = new ScopeFilterKey("OBJECT_SIZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScopeFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScopeFilterKey FindValue(string value)
        {
            return FindValue<ScopeFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScopeFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchResourcesComparator.
    /// </summary>
    public class SearchResourcesComparator : ConstantClass
    {

        /// <summary>
        /// Constant EQ for SearchResourcesComparator
        /// </summary>
        public static readonly SearchResourcesComparator EQ = new SearchResourcesComparator("EQ");
        /// <summary>
        /// Constant NE for SearchResourcesComparator
        /// </summary>
        public static readonly SearchResourcesComparator NE = new SearchResourcesComparator("NE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchResourcesComparator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchResourcesComparator FindValue(string value)
        {
            return FindValue<SearchResourcesComparator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchResourcesComparator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchResourcesSimpleCriterionKey.
    /// </summary>
    public class SearchResourcesSimpleCriterionKey : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ID for SearchResourcesSimpleCriterionKey
        /// </summary>
        public static readonly SearchResourcesSimpleCriterionKey ACCOUNT_ID = new SearchResourcesSimpleCriterionKey("ACCOUNT_ID");
        /// <summary>
        /// Constant S3_BUCKET_EFFECTIVE_PERMISSION for SearchResourcesSimpleCriterionKey
        /// </summary>
        public static readonly SearchResourcesSimpleCriterionKey S3_BUCKET_EFFECTIVE_PERMISSION = new SearchResourcesSimpleCriterionKey("S3_BUCKET_EFFECTIVE_PERMISSION");
        /// <summary>
        /// Constant S3_BUCKET_NAME for SearchResourcesSimpleCriterionKey
        /// </summary>
        public static readonly SearchResourcesSimpleCriterionKey S3_BUCKET_NAME = new SearchResourcesSimpleCriterionKey("S3_BUCKET_NAME");
        /// <summary>
        /// Constant S3_BUCKET_SHARED_ACCESS for SearchResourcesSimpleCriterionKey
        /// </summary>
        public static readonly SearchResourcesSimpleCriterionKey S3_BUCKET_SHARED_ACCESS = new SearchResourcesSimpleCriterionKey("S3_BUCKET_SHARED_ACCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchResourcesSimpleCriterionKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchResourcesSimpleCriterionKey FindValue(string value)
        {
            return FindValue<SearchResourcesSimpleCriterionKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchResourcesSimpleCriterionKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchResourcesSortAttributeName.
    /// </summary>
    public class SearchResourcesSortAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ID for SearchResourcesSortAttributeName
        /// </summary>
        public static readonly SearchResourcesSortAttributeName ACCOUNT_ID = new SearchResourcesSortAttributeName("ACCOUNT_ID");
        /// <summary>
        /// Constant RESOURCE_NAME for SearchResourcesSortAttributeName
        /// </summary>
        public static readonly SearchResourcesSortAttributeName RESOURCE_NAME = new SearchResourcesSortAttributeName("RESOURCE_NAME");
        /// <summary>
        /// Constant S3_CLASSIFIABLE_OBJECT_COUNT for SearchResourcesSortAttributeName
        /// </summary>
        public static readonly SearchResourcesSortAttributeName S3_CLASSIFIABLE_OBJECT_COUNT = new SearchResourcesSortAttributeName("S3_CLASSIFIABLE_OBJECT_COUNT");
        /// <summary>
        /// Constant S3_CLASSIFIABLE_SIZE_IN_BYTES for SearchResourcesSortAttributeName
        /// </summary>
        public static readonly SearchResourcesSortAttributeName S3_CLASSIFIABLE_SIZE_IN_BYTES = new SearchResourcesSortAttributeName("S3_CLASSIFIABLE_SIZE_IN_BYTES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchResourcesSortAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchResourcesSortAttributeName FindValue(string value)
        {
            return FindValue<SearchResourcesSortAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchResourcesSortAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SensitiveDataItemCategory.
    /// </summary>
    public class SensitiveDataItemCategory : ConstantClass
    {

        /// <summary>
        /// Constant CREDENTIALS for SensitiveDataItemCategory
        /// </summary>
        public static readonly SensitiveDataItemCategory CREDENTIALS = new SensitiveDataItemCategory("CREDENTIALS");
        /// <summary>
        /// Constant CUSTOM_IDENTIFIER for SensitiveDataItemCategory
        /// </summary>
        public static readonly SensitiveDataItemCategory CUSTOM_IDENTIFIER = new SensitiveDataItemCategory("CUSTOM_IDENTIFIER");
        /// <summary>
        /// Constant FINANCIAL_INFORMATION for SensitiveDataItemCategory
        /// </summary>
        public static readonly SensitiveDataItemCategory FINANCIAL_INFORMATION = new SensitiveDataItemCategory("FINANCIAL_INFORMATION");
        /// <summary>
        /// Constant PERSONAL_INFORMATION for SensitiveDataItemCategory
        /// </summary>
        public static readonly SensitiveDataItemCategory PERSONAL_INFORMATION = new SensitiveDataItemCategory("PERSONAL_INFORMATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SensitiveDataItemCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SensitiveDataItemCategory FindValue(string value)
        {
            return FindValue<SensitiveDataItemCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SensitiveDataItemCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SeverityDescription.
    /// </summary>
    public class SeverityDescription : ConstantClass
    {

        /// <summary>
        /// Constant High for SeverityDescription
        /// </summary>
        public static readonly SeverityDescription High = new SeverityDescription("High");
        /// <summary>
        /// Constant Low for SeverityDescription
        /// </summary>
        public static readonly SeverityDescription Low = new SeverityDescription("Low");
        /// <summary>
        /// Constant Medium for SeverityDescription
        /// </summary>
        public static readonly SeverityDescription Medium = new SeverityDescription("Medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SeverityDescription(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SeverityDescription FindValue(string value)
        {
            return FindValue<SeverityDescription>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SeverityDescription(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SharedAccess.
    /// </summary>
    public class SharedAccess : ConstantClass
    {

        /// <summary>
        /// Constant EXTERNAL for SharedAccess
        /// </summary>
        public static readonly SharedAccess EXTERNAL = new SharedAccess("EXTERNAL");
        /// <summary>
        /// Constant INTERNAL for SharedAccess
        /// </summary>
        public static readonly SharedAccess INTERNAL = new SharedAccess("INTERNAL");
        /// <summary>
        /// Constant NOT_SHARED for SharedAccess
        /// </summary>
        public static readonly SharedAccess NOT_SHARED = new SharedAccess("NOT_SHARED");
        /// <summary>
        /// Constant UNKNOWN for SharedAccess
        /// </summary>
        public static readonly SharedAccess UNKNOWN = new SharedAccess("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SharedAccess(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SharedAccess FindValue(string value)
        {
            return FindValue<SharedAccess>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SharedAccess(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SimpleCriterionKeyForJob.
    /// </summary>
    public class SimpleCriterionKeyForJob : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ID for SimpleCriterionKeyForJob
        /// </summary>
        public static readonly SimpleCriterionKeyForJob ACCOUNT_ID = new SimpleCriterionKeyForJob("ACCOUNT_ID");
        /// <summary>
        /// Constant S3_BUCKET_EFFECTIVE_PERMISSION for SimpleCriterionKeyForJob
        /// </summary>
        public static readonly SimpleCriterionKeyForJob S3_BUCKET_EFFECTIVE_PERMISSION = new SimpleCriterionKeyForJob("S3_BUCKET_EFFECTIVE_PERMISSION");
        /// <summary>
        /// Constant S3_BUCKET_NAME for SimpleCriterionKeyForJob
        /// </summary>
        public static readonly SimpleCriterionKeyForJob S3_BUCKET_NAME = new SimpleCriterionKeyForJob("S3_BUCKET_NAME");
        /// <summary>
        /// Constant S3_BUCKET_SHARED_ACCESS for SimpleCriterionKeyForJob
        /// </summary>
        public static readonly SimpleCriterionKeyForJob S3_BUCKET_SHARED_ACCESS = new SimpleCriterionKeyForJob("S3_BUCKET_SHARED_ACCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SimpleCriterionKeyForJob(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SimpleCriterionKeyForJob FindValue(string value)
        {
            return FindValue<SimpleCriterionKeyForJob>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SimpleCriterionKeyForJob(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageClass.
    /// </summary>
    public class StorageClass : ConstantClass
    {

        /// <summary>
        /// Constant DEEP_ARCHIVE for StorageClass
        /// </summary>
        public static readonly StorageClass DEEP_ARCHIVE = new StorageClass("DEEP_ARCHIVE");
        /// <summary>
        /// Constant GLACIER for StorageClass
        /// </summary>
        public static readonly StorageClass GLACIER = new StorageClass("GLACIER");
        /// <summary>
        /// Constant GLACIER_IR for StorageClass
        /// </summary>
        public static readonly StorageClass GLACIER_IR = new StorageClass("GLACIER_IR");
        /// <summary>
        /// Constant INTELLIGENT_TIERING for StorageClass
        /// </summary>
        public static readonly StorageClass INTELLIGENT_TIERING = new StorageClass("INTELLIGENT_TIERING");
        /// <summary>
        /// Constant ONEZONE_IA for StorageClass
        /// </summary>
        public static readonly StorageClass ONEZONE_IA = new StorageClass("ONEZONE_IA");
        /// <summary>
        /// Constant OUTPOSTS for StorageClass
        /// </summary>
        public static readonly StorageClass OUTPOSTS = new StorageClass("OUTPOSTS");
        /// <summary>
        /// Constant REDUCED_REDUNDANCY for StorageClass
        /// </summary>
        public static readonly StorageClass REDUCED_REDUNDANCY = new StorageClass("REDUCED_REDUNDANCY");
        /// <summary>
        /// Constant STANDARD for StorageClass
        /// </summary>
        public static readonly StorageClass STANDARD = new StorageClass("STANDARD");
        /// <summary>
        /// Constant STANDARD_IA for StorageClass
        /// </summary>
        public static readonly StorageClass STANDARD_IA = new StorageClass("STANDARD_IA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageClass FindValue(string value)
        {
            return FindValue<StorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TagTarget.
    /// </summary>
    public class TagTarget : ConstantClass
    {

        /// <summary>
        /// Constant S3_OBJECT for TagTarget
        /// </summary>
        public static readonly TagTarget S3_OBJECT = new TagTarget("S3_OBJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TagTarget(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TagTarget FindValue(string value)
        {
            return FindValue<TagTarget>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TagTarget(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeRange.
    /// </summary>
    public class TimeRange : ConstantClass
    {

        /// <summary>
        /// Constant MONTH_TO_DATE for TimeRange
        /// </summary>
        public static readonly TimeRange MONTH_TO_DATE = new TimeRange("MONTH_TO_DATE");
        /// <summary>
        /// Constant PAST_30_DAYS for TimeRange
        /// </summary>
        public static readonly TimeRange PAST_30_DAYS = new TimeRange("PAST_30_DAYS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeRange(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeRange FindValue(string value)
        {
            return FindValue<TimeRange>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeRange(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant AES256 for Type
        /// </summary>
        public static readonly Type AES256 = new Type("AES256");
        /// <summary>
        /// Constant AwsKms for Type
        /// </summary>
        public static readonly Type AwsKms = new Type("aws:kms");
        /// <summary>
        /// Constant NONE for Type
        /// </summary>
        public static readonly Type NONE = new Type("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Type FindValue(string value)
        {
            return FindValue<Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Type(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UnavailabilityReasonCode.
    /// </summary>
    public class UnavailabilityReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant INVALID_CLASSIFICATION_RESULT for UnavailabilityReasonCode
        /// </summary>
        public static readonly UnavailabilityReasonCode INVALID_CLASSIFICATION_RESULT = new UnavailabilityReasonCode("INVALID_CLASSIFICATION_RESULT");
        /// <summary>
        /// Constant OBJECT_EXCEEDS_SIZE_QUOTA for UnavailabilityReasonCode
        /// </summary>
        public static readonly UnavailabilityReasonCode OBJECT_EXCEEDS_SIZE_QUOTA = new UnavailabilityReasonCode("OBJECT_EXCEEDS_SIZE_QUOTA");
        /// <summary>
        /// Constant OBJECT_UNAVAILABLE for UnavailabilityReasonCode
        /// </summary>
        public static readonly UnavailabilityReasonCode OBJECT_UNAVAILABLE = new UnavailabilityReasonCode("OBJECT_UNAVAILABLE");
        /// <summary>
        /// Constant UNSUPPORTED_FINDING_TYPE for UnavailabilityReasonCode
        /// </summary>
        public static readonly UnavailabilityReasonCode UNSUPPORTED_FINDING_TYPE = new UnavailabilityReasonCode("UNSUPPORTED_FINDING_TYPE");
        /// <summary>
        /// Constant UNSUPPORTED_OBJECT_TYPE for UnavailabilityReasonCode
        /// </summary>
        public static readonly UnavailabilityReasonCode UNSUPPORTED_OBJECT_TYPE = new UnavailabilityReasonCode("UNSUPPORTED_OBJECT_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UnavailabilityReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnavailabilityReasonCode FindValue(string value)
        {
            return FindValue<UnavailabilityReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnavailabilityReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Unit.
    /// </summary>
    public class Unit : ConstantClass
    {

        /// <summary>
        /// Constant TERABYTES for Unit
        /// </summary>
        public static readonly Unit TERABYTES = new Unit("TERABYTES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Unit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Unit FindValue(string value)
        {
            return FindValue<Unit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Unit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageStatisticsFilterComparator.
    /// </summary>
    public class UsageStatisticsFilterComparator : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for UsageStatisticsFilterComparator
        /// </summary>
        public static readonly UsageStatisticsFilterComparator CONTAINS = new UsageStatisticsFilterComparator("CONTAINS");
        /// <summary>
        /// Constant EQ for UsageStatisticsFilterComparator
        /// </summary>
        public static readonly UsageStatisticsFilterComparator EQ = new UsageStatisticsFilterComparator("EQ");
        /// <summary>
        /// Constant GT for UsageStatisticsFilterComparator
        /// </summary>
        public static readonly UsageStatisticsFilterComparator GT = new UsageStatisticsFilterComparator("GT");
        /// <summary>
        /// Constant GTE for UsageStatisticsFilterComparator
        /// </summary>
        public static readonly UsageStatisticsFilterComparator GTE = new UsageStatisticsFilterComparator("GTE");
        /// <summary>
        /// Constant LT for UsageStatisticsFilterComparator
        /// </summary>
        public static readonly UsageStatisticsFilterComparator LT = new UsageStatisticsFilterComparator("LT");
        /// <summary>
        /// Constant LTE for UsageStatisticsFilterComparator
        /// </summary>
        public static readonly UsageStatisticsFilterComparator LTE = new UsageStatisticsFilterComparator("LTE");
        /// <summary>
        /// Constant NE for UsageStatisticsFilterComparator
        /// </summary>
        public static readonly UsageStatisticsFilterComparator NE = new UsageStatisticsFilterComparator("NE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageStatisticsFilterComparator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageStatisticsFilterComparator FindValue(string value)
        {
            return FindValue<UsageStatisticsFilterComparator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageStatisticsFilterComparator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageStatisticsFilterKey.
    /// </summary>
    public class UsageStatisticsFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for UsageStatisticsFilterKey
        /// </summary>
        public static readonly UsageStatisticsFilterKey AccountId = new UsageStatisticsFilterKey("accountId");
        /// <summary>
        /// Constant FreeTrialStartDate for UsageStatisticsFilterKey
        /// </summary>
        public static readonly UsageStatisticsFilterKey FreeTrialStartDate = new UsageStatisticsFilterKey("freeTrialStartDate");
        /// <summary>
        /// Constant ServiceLimit for UsageStatisticsFilterKey
        /// </summary>
        public static readonly UsageStatisticsFilterKey ServiceLimit = new UsageStatisticsFilterKey("serviceLimit");
        /// <summary>
        /// Constant Total for UsageStatisticsFilterKey
        /// </summary>
        public static readonly UsageStatisticsFilterKey Total = new UsageStatisticsFilterKey("total");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageStatisticsFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageStatisticsFilterKey FindValue(string value)
        {
            return FindValue<UsageStatisticsFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageStatisticsFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageStatisticsSortKey.
    /// </summary>
    public class UsageStatisticsSortKey : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for UsageStatisticsSortKey
        /// </summary>
        public static readonly UsageStatisticsSortKey AccountId = new UsageStatisticsSortKey("accountId");
        /// <summary>
        /// Constant FreeTrialStartDate for UsageStatisticsSortKey
        /// </summary>
        public static readonly UsageStatisticsSortKey FreeTrialStartDate = new UsageStatisticsSortKey("freeTrialStartDate");
        /// <summary>
        /// Constant ServiceLimitValue for UsageStatisticsSortKey
        /// </summary>
        public static readonly UsageStatisticsSortKey ServiceLimitValue = new UsageStatisticsSortKey("serviceLimitValue");
        /// <summary>
        /// Constant Total for UsageStatisticsSortKey
        /// </summary>
        public static readonly UsageStatisticsSortKey Total = new UsageStatisticsSortKey("total");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageStatisticsSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageStatisticsSortKey FindValue(string value)
        {
            return FindValue<UsageStatisticsSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageStatisticsSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageType.
    /// </summary>
    public class UsageType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATED_OBJECT_MONITORING for UsageType
        /// </summary>
        public static readonly UsageType AUTOMATED_OBJECT_MONITORING = new UsageType("AUTOMATED_OBJECT_MONITORING");
        /// <summary>
        /// Constant AUTOMATED_SENSITIVE_DATA_DISCOVERY for UsageType
        /// </summary>
        public static readonly UsageType AUTOMATED_SENSITIVE_DATA_DISCOVERY = new UsageType("AUTOMATED_SENSITIVE_DATA_DISCOVERY");
        /// <summary>
        /// Constant DATA_INVENTORY_EVALUATION for UsageType
        /// </summary>
        public static readonly UsageType DATA_INVENTORY_EVALUATION = new UsageType("DATA_INVENTORY_EVALUATION");
        /// <summary>
        /// Constant SENSITIVE_DATA_DISCOVERY for UsageType
        /// </summary>
        public static readonly UsageType SENSITIVE_DATA_DISCOVERY = new UsageType("SENSITIVE_DATA_DISCOVERY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageType FindValue(string value)
        {
            return FindValue<UsageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserIdentityType.
    /// </summary>
    public class UserIdentityType : ConstantClass
    {

        /// <summary>
        /// Constant AssumedRole for UserIdentityType
        /// </summary>
        public static readonly UserIdentityType AssumedRole = new UserIdentityType("AssumedRole");
        /// <summary>
        /// Constant AWSAccount for UserIdentityType
        /// </summary>
        public static readonly UserIdentityType AWSAccount = new UserIdentityType("AWSAccount");
        /// <summary>
        /// Constant AWSService for UserIdentityType
        /// </summary>
        public static readonly UserIdentityType AWSService = new UserIdentityType("AWSService");
        /// <summary>
        /// Constant FederatedUser for UserIdentityType
        /// </summary>
        public static readonly UserIdentityType FederatedUser = new UserIdentityType("FederatedUser");
        /// <summary>
        /// Constant IAMUser for UserIdentityType
        /// </summary>
        public static readonly UserIdentityType IAMUser = new UserIdentityType("IAMUser");
        /// <summary>
        /// Constant Root for UserIdentityType
        /// </summary>
        public static readonly UserIdentityType Root = new UserIdentityType("Root");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserIdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserIdentityType FindValue(string value)
        {
            return FindValue<UserIdentityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserIdentityType(string value)
        {
            return FindValue(value);
        }
    }

}