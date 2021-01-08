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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoTSiteWise
{

    /// <summary>
    /// Constants used for properties of type AggregateType.
    /// </summary>
    public class AggregateType : ConstantClass
    {

        /// <summary>
        /// Constant AVERAGE for AggregateType
        /// </summary>
        public static readonly AggregateType AVERAGE = new AggregateType("AVERAGE");
        /// <summary>
        /// Constant COUNT for AggregateType
        /// </summary>
        public static readonly AggregateType COUNT = new AggregateType("COUNT");
        /// <summary>
        /// Constant MAXIMUM for AggregateType
        /// </summary>
        public static readonly AggregateType MAXIMUM = new AggregateType("MAXIMUM");
        /// <summary>
        /// Constant MINIMUM for AggregateType
        /// </summary>
        public static readonly AggregateType MINIMUM = new AggregateType("MINIMUM");
        /// <summary>
        /// Constant STANDARD_DEVIATION for AggregateType
        /// </summary>
        public static readonly AggregateType STANDARD_DEVIATION = new AggregateType("STANDARD_DEVIATION");
        /// <summary>
        /// Constant SUM for AggregateType
        /// </summary>
        public static readonly AggregateType SUM = new AggregateType("SUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregateType FindValue(string value)
        {
            return FindValue<AggregateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssetErrorCode.
    /// </summary>
    public class AssetErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_FAILURE for AssetErrorCode
        /// </summary>
        public static readonly AssetErrorCode INTERNAL_FAILURE = new AssetErrorCode("INTERNAL_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssetErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetErrorCode FindValue(string value)
        {
            return FindValue<AssetErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssetModelState.
    /// </summary>
    public class AssetModelState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AssetModelState
        /// </summary>
        public static readonly AssetModelState ACTIVE = new AssetModelState("ACTIVE");
        /// <summary>
        /// Constant CREATING for AssetModelState
        /// </summary>
        public static readonly AssetModelState CREATING = new AssetModelState("CREATING");
        /// <summary>
        /// Constant DELETING for AssetModelState
        /// </summary>
        public static readonly AssetModelState DELETING = new AssetModelState("DELETING");
        /// <summary>
        /// Constant FAILED for AssetModelState
        /// </summary>
        public static readonly AssetModelState FAILED = new AssetModelState("FAILED");
        /// <summary>
        /// Constant PROPAGATING for AssetModelState
        /// </summary>
        public static readonly AssetModelState PROPAGATING = new AssetModelState("PROPAGATING");
        /// <summary>
        /// Constant UPDATING for AssetModelState
        /// </summary>
        public static readonly AssetModelState UPDATING = new AssetModelState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssetModelState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetModelState FindValue(string value)
        {
            return FindValue<AssetModelState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetModelState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssetRelationshipType.
    /// </summary>
    public class AssetRelationshipType : ConstantClass
    {

        /// <summary>
        /// Constant HIERARCHY for AssetRelationshipType
        /// </summary>
        public static readonly AssetRelationshipType HIERARCHY = new AssetRelationshipType("HIERARCHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssetRelationshipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetRelationshipType FindValue(string value)
        {
            return FindValue<AssetRelationshipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetRelationshipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssetState.
    /// </summary>
    public class AssetState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AssetState
        /// </summary>
        public static readonly AssetState ACTIVE = new AssetState("ACTIVE");
        /// <summary>
        /// Constant CREATING for AssetState
        /// </summary>
        public static readonly AssetState CREATING = new AssetState("CREATING");
        /// <summary>
        /// Constant DELETING for AssetState
        /// </summary>
        public static readonly AssetState DELETING = new AssetState("DELETING");
        /// <summary>
        /// Constant FAILED for AssetState
        /// </summary>
        public static readonly AssetState FAILED = new AssetState("FAILED");
        /// <summary>
        /// Constant UPDATING for AssetState
        /// </summary>
        public static readonly AssetState UPDATING = new AssetState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetState FindValue(string value)
        {
            return FindValue<AssetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthMode.
    /// </summary>
    public class AuthMode : ConstantClass
    {

        /// <summary>
        /// Constant IAM for AuthMode
        /// </summary>
        public static readonly AuthMode IAM = new AuthMode("IAM");
        /// <summary>
        /// Constant SSO for AuthMode
        /// </summary>
        public static readonly AuthMode SSO = new AuthMode("SSO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthMode FindValue(string value)
        {
            return FindValue<AuthMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchPutAssetPropertyValueErrorCode.
    /// </summary>
    public class BatchPutAssetPropertyValueErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDeniedException for BatchPutAssetPropertyValueErrorCode
        /// </summary>
        public static readonly BatchPutAssetPropertyValueErrorCode AccessDeniedException = new BatchPutAssetPropertyValueErrorCode("AccessDeniedException");
        /// <summary>
        /// Constant ConflictingOperationException for BatchPutAssetPropertyValueErrorCode
        /// </summary>
        public static readonly BatchPutAssetPropertyValueErrorCode ConflictingOperationException = new BatchPutAssetPropertyValueErrorCode("ConflictingOperationException");
        /// <summary>
        /// Constant InternalFailureException for BatchPutAssetPropertyValueErrorCode
        /// </summary>
        public static readonly BatchPutAssetPropertyValueErrorCode InternalFailureException = new BatchPutAssetPropertyValueErrorCode("InternalFailureException");
        /// <summary>
        /// Constant InvalidRequestException for BatchPutAssetPropertyValueErrorCode
        /// </summary>
        public static readonly BatchPutAssetPropertyValueErrorCode InvalidRequestException = new BatchPutAssetPropertyValueErrorCode("InvalidRequestException");
        /// <summary>
        /// Constant LimitExceededException for BatchPutAssetPropertyValueErrorCode
        /// </summary>
        public static readonly BatchPutAssetPropertyValueErrorCode LimitExceededException = new BatchPutAssetPropertyValueErrorCode("LimitExceededException");
        /// <summary>
        /// Constant ResourceNotFoundException for BatchPutAssetPropertyValueErrorCode
        /// </summary>
        public static readonly BatchPutAssetPropertyValueErrorCode ResourceNotFoundException = new BatchPutAssetPropertyValueErrorCode("ResourceNotFoundException");
        /// <summary>
        /// Constant ServiceUnavailableException for BatchPutAssetPropertyValueErrorCode
        /// </summary>
        public static readonly BatchPutAssetPropertyValueErrorCode ServiceUnavailableException = new BatchPutAssetPropertyValueErrorCode("ServiceUnavailableException");
        /// <summary>
        /// Constant ThrottlingException for BatchPutAssetPropertyValueErrorCode
        /// </summary>
        public static readonly BatchPutAssetPropertyValueErrorCode ThrottlingException = new BatchPutAssetPropertyValueErrorCode("ThrottlingException");
        /// <summary>
        /// Constant TimestampOutOfRangeException for BatchPutAssetPropertyValueErrorCode
        /// </summary>
        public static readonly BatchPutAssetPropertyValueErrorCode TimestampOutOfRangeException = new BatchPutAssetPropertyValueErrorCode("TimestampOutOfRangeException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchPutAssetPropertyValueErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchPutAssetPropertyValueErrorCode FindValue(string value)
        {
            return FindValue<BatchPutAssetPropertyValueErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchPutAssetPropertyValueErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapabilitySyncStatus.
    /// </summary>
    public class CapabilitySyncStatus : ConstantClass
    {

        /// <summary>
        /// Constant IN_SYNC for CapabilitySyncStatus
        /// </summary>
        public static readonly CapabilitySyncStatus IN_SYNC = new CapabilitySyncStatus("IN_SYNC");
        /// <summary>
        /// Constant OUT_OF_SYNC for CapabilitySyncStatus
        /// </summary>
        public static readonly CapabilitySyncStatus OUT_OF_SYNC = new CapabilitySyncStatus("OUT_OF_SYNC");
        /// <summary>
        /// Constant SYNC_FAILED for CapabilitySyncStatus
        /// </summary>
        public static readonly CapabilitySyncStatus SYNC_FAILED = new CapabilitySyncStatus("SYNC_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapabilitySyncStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapabilitySyncStatus FindValue(string value)
        {
            return FindValue<CapabilitySyncStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapabilitySyncStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationState.
    /// </summary>
    public class ConfigurationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ConfigurationState
        /// </summary>
        public static readonly ConfigurationState ACTIVE = new ConfigurationState("ACTIVE");
        /// <summary>
        /// Constant UPDATE_FAILED for ConfigurationState
        /// </summary>
        public static readonly ConfigurationState UPDATE_FAILED = new ConfigurationState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ConfigurationState
        /// </summary>
        public static readonly ConfigurationState UPDATE_IN_PROGRESS = new ConfigurationState("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationState FindValue(string value)
        {
            return FindValue<ConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationState(string value)
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
        /// Constant KMS_BASED_ENCRYPTION for EncryptionType
        /// </summary>
        public static readonly EncryptionType KMS_BASED_ENCRYPTION = new EncryptionType("KMS_BASED_ENCRYPTION");
        /// <summary>
        /// Constant SITEWISE_DEFAULT_ENCRYPTION for EncryptionType
        /// </summary>
        public static readonly EncryptionType SITEWISE_DEFAULT_ENCRYPTION = new EncryptionType("SITEWISE_DEFAULT_ENCRYPTION");

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
        /// Constant INTERNAL_FAILURE for ErrorCode
        /// </summary>
        public static readonly ErrorCode INTERNAL_FAILURE = new ErrorCode("INTERNAL_FAILURE");
        /// <summary>
        /// Constant VALIDATION_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode VALIDATION_ERROR = new ErrorCode("VALIDATION_ERROR");

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
    /// Constants used for properties of type IdentityType.
    /// </summary>
    public class IdentityType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for IdentityType
        /// </summary>
        public static readonly IdentityType GROUP = new IdentityType("GROUP");
        /// <summary>
        /// Constant IAM for IdentityType
        /// </summary>
        public static readonly IdentityType IAM = new IdentityType("IAM");
        /// <summary>
        /// Constant USER for IdentityType
        /// </summary>
        public static readonly IdentityType USER = new IdentityType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityType FindValue(string value)
        {
            return FindValue<IdentityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageFileType.
    /// </summary>
    public class ImageFileType : ConstantClass
    {

        /// <summary>
        /// Constant PNG for ImageFileType
        /// </summary>
        public static readonly ImageFileType PNG = new ImageFileType("PNG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageFileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageFileType FindValue(string value)
        {
            return FindValue<ImageFileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageFileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListAssetsFilter.
    /// </summary>
    public class ListAssetsFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ListAssetsFilter
        /// </summary>
        public static readonly ListAssetsFilter ALL = new ListAssetsFilter("ALL");
        /// <summary>
        /// Constant TOP_LEVEL for ListAssetsFilter
        /// </summary>
        public static readonly ListAssetsFilter TOP_LEVEL = new ListAssetsFilter("TOP_LEVEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListAssetsFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListAssetsFilter FindValue(string value)
        {
            return FindValue<ListAssetsFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListAssetsFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoggingLevel.
    /// </summary>
    public class LoggingLevel : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel ERROR = new LoggingLevel("ERROR");
        /// <summary>
        /// Constant INFO for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel INFO = new LoggingLevel("INFO");
        /// <summary>
        /// Constant OFF for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel OFF = new LoggingLevel("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoggingLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggingLevel FindValue(string value)
        {
            return FindValue<LoggingLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggingLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitorErrorCode.
    /// </summary>
    public class MonitorErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_FAILURE for MonitorErrorCode
        /// </summary>
        public static readonly MonitorErrorCode INTERNAL_FAILURE = new MonitorErrorCode("INTERNAL_FAILURE");
        /// <summary>
        /// Constant LIMIT_EXCEEDED for MonitorErrorCode
        /// </summary>
        public static readonly MonitorErrorCode LIMIT_EXCEEDED = new MonitorErrorCode("LIMIT_EXCEEDED");
        /// <summary>
        /// Constant VALIDATION_ERROR for MonitorErrorCode
        /// </summary>
        public static readonly MonitorErrorCode VALIDATION_ERROR = new MonitorErrorCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitorErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitorErrorCode FindValue(string value)
        {
            return FindValue<MonitorErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitorErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Permission.
    /// </summary>
    public class Permission : ConstantClass
    {

        /// <summary>
        /// Constant ADMINISTRATOR for Permission
        /// </summary>
        public static readonly Permission ADMINISTRATOR = new Permission("ADMINISTRATOR");
        /// <summary>
        /// Constant VIEWER for Permission
        /// </summary>
        public static readonly Permission VIEWER = new Permission("VIEWER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Permission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Permission FindValue(string value)
        {
            return FindValue<Permission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Permission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PortalState.
    /// </summary>
    public class PortalState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PortalState
        /// </summary>
        public static readonly PortalState ACTIVE = new PortalState("ACTIVE");
        /// <summary>
        /// Constant CREATING for PortalState
        /// </summary>
        public static readonly PortalState CREATING = new PortalState("CREATING");
        /// <summary>
        /// Constant DELETING for PortalState
        /// </summary>
        public static readonly PortalState DELETING = new PortalState("DELETING");
        /// <summary>
        /// Constant FAILED for PortalState
        /// </summary>
        public static readonly PortalState FAILED = new PortalState("FAILED");
        /// <summary>
        /// Constant UPDATING for PortalState
        /// </summary>
        public static readonly PortalState UPDATING = new PortalState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PortalState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PortalState FindValue(string value)
        {
            return FindValue<PortalState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PortalState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PropertyDataType.
    /// </summary>
    public class PropertyDataType : ConstantClass
    {

        /// <summary>
        /// Constant BOOLEAN for PropertyDataType
        /// </summary>
        public static readonly PropertyDataType BOOLEAN = new PropertyDataType("BOOLEAN");
        /// <summary>
        /// Constant DOUBLE for PropertyDataType
        /// </summary>
        public static readonly PropertyDataType DOUBLE = new PropertyDataType("DOUBLE");
        /// <summary>
        /// Constant INTEGER for PropertyDataType
        /// </summary>
        public static readonly PropertyDataType INTEGER = new PropertyDataType("INTEGER");
        /// <summary>
        /// Constant STRING for PropertyDataType
        /// </summary>
        public static readonly PropertyDataType STRING = new PropertyDataType("STRING");
        /// <summary>
        /// Constant STRUCT for PropertyDataType
        /// </summary>
        public static readonly PropertyDataType STRUCT = new PropertyDataType("STRUCT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PropertyDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PropertyDataType FindValue(string value)
        {
            return FindValue<PropertyDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PropertyDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PropertyNotificationState.
    /// </summary>
    public class PropertyNotificationState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for PropertyNotificationState
        /// </summary>
        public static readonly PropertyNotificationState DISABLED = new PropertyNotificationState("DISABLED");
        /// <summary>
        /// Constant ENABLED for PropertyNotificationState
        /// </summary>
        public static readonly PropertyNotificationState ENABLED = new PropertyNotificationState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PropertyNotificationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PropertyNotificationState FindValue(string value)
        {
            return FindValue<PropertyNotificationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PropertyNotificationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Quality.
    /// </summary>
    public class Quality : ConstantClass
    {

        /// <summary>
        /// Constant BAD for Quality
        /// </summary>
        public static readonly Quality BAD = new Quality("BAD");
        /// <summary>
        /// Constant GOOD for Quality
        /// </summary>
        public static readonly Quality GOOD = new Quality("GOOD");
        /// <summary>
        /// Constant UNCERTAIN for Quality
        /// </summary>
        public static readonly Quality UNCERTAIN = new Quality("UNCERTAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Quality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Quality FindValue(string value)
        {
            return FindValue<Quality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Quality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant PORTAL for ResourceType
        /// </summary>
        public static readonly ResourceType PORTAL = new ResourceType("PORTAL");
        /// <summary>
        /// Constant PROJECT for ResourceType
        /// </summary>
        public static readonly ResourceType PROJECT = new ResourceType("PROJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeOrdering.
    /// </summary>
    public class TimeOrdering : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for TimeOrdering
        /// </summary>
        public static readonly TimeOrdering ASCENDING = new TimeOrdering("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for TimeOrdering
        /// </summary>
        public static readonly TimeOrdering DESCENDING = new TimeOrdering("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeOrdering(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeOrdering FindValue(string value)
        {
            return FindValue<TimeOrdering>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeOrdering(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TraversalDirection.
    /// </summary>
    public class TraversalDirection : ConstantClass
    {

        /// <summary>
        /// Constant CHILD for TraversalDirection
        /// </summary>
        public static readonly TraversalDirection CHILD = new TraversalDirection("CHILD");
        /// <summary>
        /// Constant PARENT for TraversalDirection
        /// </summary>
        public static readonly TraversalDirection PARENT = new TraversalDirection("PARENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TraversalDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TraversalDirection FindValue(string value)
        {
            return FindValue<TraversalDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TraversalDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TraversalType.
    /// </summary>
    public class TraversalType : ConstantClass
    {

        /// <summary>
        /// Constant PATH_TO_ROOT for TraversalType
        /// </summary>
        public static readonly TraversalType PATH_TO_ROOT = new TraversalType("PATH_TO_ROOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TraversalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TraversalType FindValue(string value)
        {
            return FindValue<TraversalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TraversalType(string value)
        {
            return FindValue(value);
        }
    }

}