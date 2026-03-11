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
    /// Constants used for properties of type AssetModelType.
    /// </summary>
    public class AssetModelType : ConstantClass
    {

        /// <summary>
        /// Constant ASSET_MODEL for AssetModelType
        /// </summary>
        public static readonly AssetModelType ASSET_MODEL = new AssetModelType("ASSET_MODEL");
        /// <summary>
        /// Constant COMPONENT_MODEL for AssetModelType
        /// </summary>
        public static readonly AssetModelType COMPONENT_MODEL = new AssetModelType("COMPONENT_MODEL");
        /// <summary>
        /// Constant INTERFACE for AssetModelType
        /// </summary>
        public static readonly AssetModelType INTERFACE = new AssetModelType("INTERFACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssetModelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetModelType FindValue(string value)
        {
            return FindValue<AssetModelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetModelType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssetModelVersionType.
    /// </summary>
    public class AssetModelVersionType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AssetModelVersionType
        /// </summary>
        public static readonly AssetModelVersionType ACTIVE = new AssetModelVersionType("ACTIVE");
        /// <summary>
        /// Constant LATEST for AssetModelVersionType
        /// </summary>
        public static readonly AssetModelVersionType LATEST = new AssetModelVersionType("LATEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssetModelVersionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetModelVersionType FindValue(string value)
        {
            return FindValue<AssetModelVersionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetModelVersionType(string value)
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
    /// Constants used for properties of type BatchEntryCompletionStatus.
    /// </summary>
    public class BatchEntryCompletionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for BatchEntryCompletionStatus
        /// </summary>
        public static readonly BatchEntryCompletionStatus ERROR = new BatchEntryCompletionStatus("ERROR");
        /// <summary>
        /// Constant SUCCESS for BatchEntryCompletionStatus
        /// </summary>
        public static readonly BatchEntryCompletionStatus SUCCESS = new BatchEntryCompletionStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchEntryCompletionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchEntryCompletionStatus FindValue(string value)
        {
            return FindValue<BatchEntryCompletionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchEntryCompletionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchGetAssetPropertyAggregatesErrorCode.
    /// </summary>
    public class BatchGetAssetPropertyAggregatesErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDeniedException for BatchGetAssetPropertyAggregatesErrorCode
        /// </summary>
        public static readonly BatchGetAssetPropertyAggregatesErrorCode AccessDeniedException = new BatchGetAssetPropertyAggregatesErrorCode("AccessDeniedException");
        /// <summary>
        /// Constant InvalidRequestException for BatchGetAssetPropertyAggregatesErrorCode
        /// </summary>
        public static readonly BatchGetAssetPropertyAggregatesErrorCode InvalidRequestException = new BatchGetAssetPropertyAggregatesErrorCode("InvalidRequestException");
        /// <summary>
        /// Constant ResourceNotFoundException for BatchGetAssetPropertyAggregatesErrorCode
        /// </summary>
        public static readonly BatchGetAssetPropertyAggregatesErrorCode ResourceNotFoundException = new BatchGetAssetPropertyAggregatesErrorCode("ResourceNotFoundException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchGetAssetPropertyAggregatesErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchGetAssetPropertyAggregatesErrorCode FindValue(string value)
        {
            return FindValue<BatchGetAssetPropertyAggregatesErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchGetAssetPropertyAggregatesErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchGetAssetPropertyValueErrorCode.
    /// </summary>
    public class BatchGetAssetPropertyValueErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDeniedException for BatchGetAssetPropertyValueErrorCode
        /// </summary>
        public static readonly BatchGetAssetPropertyValueErrorCode AccessDeniedException = new BatchGetAssetPropertyValueErrorCode("AccessDeniedException");
        /// <summary>
        /// Constant InvalidRequestException for BatchGetAssetPropertyValueErrorCode
        /// </summary>
        public static readonly BatchGetAssetPropertyValueErrorCode InvalidRequestException = new BatchGetAssetPropertyValueErrorCode("InvalidRequestException");
        /// <summary>
        /// Constant ResourceNotFoundException for BatchGetAssetPropertyValueErrorCode
        /// </summary>
        public static readonly BatchGetAssetPropertyValueErrorCode ResourceNotFoundException = new BatchGetAssetPropertyValueErrorCode("ResourceNotFoundException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchGetAssetPropertyValueErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchGetAssetPropertyValueErrorCode FindValue(string value)
        {
            return FindValue<BatchGetAssetPropertyValueErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchGetAssetPropertyValueErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchGetAssetPropertyValueHistoryErrorCode.
    /// </summary>
    public class BatchGetAssetPropertyValueHistoryErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDeniedException for BatchGetAssetPropertyValueHistoryErrorCode
        /// </summary>
        public static readonly BatchGetAssetPropertyValueHistoryErrorCode AccessDeniedException = new BatchGetAssetPropertyValueHistoryErrorCode("AccessDeniedException");
        /// <summary>
        /// Constant InvalidRequestException for BatchGetAssetPropertyValueHistoryErrorCode
        /// </summary>
        public static readonly BatchGetAssetPropertyValueHistoryErrorCode InvalidRequestException = new BatchGetAssetPropertyValueHistoryErrorCode("InvalidRequestException");
        /// <summary>
        /// Constant ResourceNotFoundException for BatchGetAssetPropertyValueHistoryErrorCode
        /// </summary>
        public static readonly BatchGetAssetPropertyValueHistoryErrorCode ResourceNotFoundException = new BatchGetAssetPropertyValueHistoryErrorCode("ResourceNotFoundException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchGetAssetPropertyValueHistoryErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchGetAssetPropertyValueHistoryErrorCode FindValue(string value)
        {
            return FindValue<BatchGetAssetPropertyValueHistoryErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchGetAssetPropertyValueHistoryErrorCode(string value)
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
        /// Constant NOT_APPLICABLE for CapabilitySyncStatus
        /// </summary>
        public static readonly CapabilitySyncStatus NOT_APPLICABLE = new CapabilitySyncStatus("NOT_APPLICABLE");
        /// <summary>
        /// Constant OUT_OF_SYNC for CapabilitySyncStatus
        /// </summary>
        public static readonly CapabilitySyncStatus OUT_OF_SYNC = new CapabilitySyncStatus("OUT_OF_SYNC");
        /// <summary>
        /// Constant SYNC_FAILED for CapabilitySyncStatus
        /// </summary>
        public static readonly CapabilitySyncStatus SYNC_FAILED = new CapabilitySyncStatus("SYNC_FAILED");
        /// <summary>
        /// Constant UNKNOWN for CapabilitySyncStatus
        /// </summary>
        public static readonly CapabilitySyncStatus UNKNOWN = new CapabilitySyncStatus("UNKNOWN");

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
    /// Constants used for properties of type ColumnName.
    /// </summary>
    public class ColumnName : ConstantClass
    {

        /// <summary>
        /// Constant ALIAS for ColumnName
        /// </summary>
        public static readonly ColumnName ALIAS = new ColumnName("ALIAS");
        /// <summary>
        /// Constant ASSET_ID for ColumnName
        /// </summary>
        public static readonly ColumnName ASSET_ID = new ColumnName("ASSET_ID");
        /// <summary>
        /// Constant DATA_TYPE for ColumnName
        /// </summary>
        public static readonly ColumnName DATA_TYPE = new ColumnName("DATA_TYPE");
        /// <summary>
        /// Constant PROPERTY_ID for ColumnName
        /// </summary>
        public static readonly ColumnName PROPERTY_ID = new ColumnName("PROPERTY_ID");
        /// <summary>
        /// Constant QUALITY for ColumnName
        /// </summary>
        public static readonly ColumnName QUALITY = new ColumnName("QUALITY");
        /// <summary>
        /// Constant TIMESTAMP_NANO_OFFSET for ColumnName
        /// </summary>
        public static readonly ColumnName TIMESTAMP_NANO_OFFSET = new ColumnName("TIMESTAMP_NANO_OFFSET");
        /// <summary>
        /// Constant TIMESTAMP_SECONDS for ColumnName
        /// </summary>
        public static readonly ColumnName TIMESTAMP_SECONDS = new ColumnName("TIMESTAMP_SECONDS");
        /// <summary>
        /// Constant VALUE for ColumnName
        /// </summary>
        public static readonly ColumnName VALUE = new ColumnName("VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColumnName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColumnName FindValue(string value)
        {
            return FindValue<ColumnName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColumnName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputationModelState.
    /// </summary>
    public class ComputationModelState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ComputationModelState
        /// </summary>
        public static readonly ComputationModelState ACTIVE = new ComputationModelState("ACTIVE");
        /// <summary>
        /// Constant CREATING for ComputationModelState
        /// </summary>
        public static readonly ComputationModelState CREATING = new ComputationModelState("CREATING");
        /// <summary>
        /// Constant DELETING for ComputationModelState
        /// </summary>
        public static readonly ComputationModelState DELETING = new ComputationModelState("DELETING");
        /// <summary>
        /// Constant FAILED for ComputationModelState
        /// </summary>
        public static readonly ComputationModelState FAILED = new ComputationModelState("FAILED");
        /// <summary>
        /// Constant UPDATING for ComputationModelState
        /// </summary>
        public static readonly ComputationModelState UPDATING = new ComputationModelState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputationModelState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputationModelState FindValue(string value)
        {
            return FindValue<ComputationModelState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputationModelState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputationModelType.
    /// </summary>
    public class ComputationModelType : ConstantClass
    {

        /// <summary>
        /// Constant ANOMALY_DETECTION for ComputationModelType
        /// </summary>
        public static readonly ComputationModelType ANOMALY_DETECTION = new ComputationModelType("ANOMALY_DETECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputationModelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputationModelType FindValue(string value)
        {
            return FindValue<ComputationModelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputationModelType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeLocation.
    /// </summary>
    public class ComputeLocation : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD for ComputeLocation
        /// </summary>
        public static readonly ComputeLocation CLOUD = new ComputeLocation("CLOUD");
        /// <summary>
        /// Constant EDGE for ComputeLocation
        /// </summary>
        public static readonly ComputeLocation EDGE = new ComputeLocation("EDGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeLocation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeLocation FindValue(string value)
        {
            return FindValue<ComputeLocation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeLocation(string value)
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
    /// Constants used for properties of type CoreDeviceOperatingSystem.
    /// </summary>
    public class CoreDeviceOperatingSystem : ConstantClass
    {

        /// <summary>
        /// Constant LINUX_AARCH64 for CoreDeviceOperatingSystem
        /// </summary>
        public static readonly CoreDeviceOperatingSystem LINUX_AARCH64 = new CoreDeviceOperatingSystem("LINUX_AARCH64");
        /// <summary>
        /// Constant LINUX_AMD64 for CoreDeviceOperatingSystem
        /// </summary>
        public static readonly CoreDeviceOperatingSystem LINUX_AMD64 = new CoreDeviceOperatingSystem("LINUX_AMD64");
        /// <summary>
        /// Constant WINDOWS_AMD64 for CoreDeviceOperatingSystem
        /// </summary>
        public static readonly CoreDeviceOperatingSystem WINDOWS_AMD64 = new CoreDeviceOperatingSystem("WINDOWS_AMD64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CoreDeviceOperatingSystem(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CoreDeviceOperatingSystem FindValue(string value)
        {
            return FindValue<CoreDeviceOperatingSystem>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CoreDeviceOperatingSystem(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetSourceFormat.
    /// </summary>
    public class DatasetSourceFormat : ConstantClass
    {

        /// <summary>
        /// Constant KNOWLEDGE_BASE for DatasetSourceFormat
        /// </summary>
        public static readonly DatasetSourceFormat KNOWLEDGE_BASE = new DatasetSourceFormat("KNOWLEDGE_BASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetSourceFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetSourceFormat FindValue(string value)
        {
            return FindValue<DatasetSourceFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetSourceFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetSourceType.
    /// </summary>
    public class DatasetSourceType : ConstantClass
    {

        /// <summary>
        /// Constant KENDRA for DatasetSourceType
        /// </summary>
        public static readonly DatasetSourceType KENDRA = new DatasetSourceType("KENDRA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetSourceType FindValue(string value)
        {
            return FindValue<DatasetSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetState.
    /// </summary>
    public class DatasetState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DatasetState
        /// </summary>
        public static readonly DatasetState ACTIVE = new DatasetState("ACTIVE");
        /// <summary>
        /// Constant CREATING for DatasetState
        /// </summary>
        public static readonly DatasetState CREATING = new DatasetState("CREATING");
        /// <summary>
        /// Constant DELETING for DatasetState
        /// </summary>
        public static readonly DatasetState DELETING = new DatasetState("DELETING");
        /// <summary>
        /// Constant FAILED for DatasetState
        /// </summary>
        public static readonly DatasetState FAILED = new DatasetState("FAILED");
        /// <summary>
        /// Constant UPDATING for DatasetState
        /// </summary>
        public static readonly DatasetState UPDATING = new DatasetState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetState FindValue(string value)
        {
            return FindValue<DatasetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetailedErrorCode.
    /// </summary>
    public class DetailedErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INCOMPATIBLE_COMPUTE_LOCATION for DetailedErrorCode
        /// </summary>
        public static readonly DetailedErrorCode INCOMPATIBLE_COMPUTE_LOCATION = new DetailedErrorCode("INCOMPATIBLE_COMPUTE_LOCATION");
        /// <summary>
        /// Constant INCOMPATIBLE_FORWARDING_CONFIGURATION for DetailedErrorCode
        /// </summary>
        public static readonly DetailedErrorCode INCOMPATIBLE_FORWARDING_CONFIGURATION = new DetailedErrorCode("INCOMPATIBLE_FORWARDING_CONFIGURATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetailedErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetailedErrorCode FindValue(string value)
        {
            return FindValue<DetailedErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetailedErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DisassociatedDataStorageState.
    /// </summary>
    public class DisassociatedDataStorageState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DisassociatedDataStorageState
        /// </summary>
        public static readonly DisassociatedDataStorageState DISABLED = new DisassociatedDataStorageState("DISABLED");
        /// <summary>
        /// Constant ENABLED for DisassociatedDataStorageState
        /// </summary>
        public static readonly DisassociatedDataStorageState ENABLED = new DisassociatedDataStorageState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DisassociatedDataStorageState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DisassociatedDataStorageState FindValue(string value)
        {
            return FindValue<DisassociatedDataStorageState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DisassociatedDataStorageState(string value)
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
    /// Constants used for properties of type ExecutionState.
    /// </summary>
    public class ExecutionState : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ExecutionState
        /// </summary>
        public static readonly ExecutionState COMPLETED = new ExecutionState("COMPLETED");
        /// <summary>
        /// Constant FAILED for ExecutionState
        /// </summary>
        public static readonly ExecutionState FAILED = new ExecutionState("FAILED");
        /// <summary>
        /// Constant RUNNING for ExecutionState
        /// </summary>
        public static readonly ExecutionState RUNNING = new ExecutionState("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionState FindValue(string value)
        {
            return FindValue<ExecutionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ForwardingConfigState.
    /// </summary>
    public class ForwardingConfigState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ForwardingConfigState
        /// </summary>
        public static readonly ForwardingConfigState DISABLED = new ForwardingConfigState("DISABLED");
        /// <summary>
        /// Constant ENABLED for ForwardingConfigState
        /// </summary>
        public static readonly ForwardingConfigState ENABLED = new ForwardingConfigState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ForwardingConfigState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ForwardingConfigState FindValue(string value)
        {
            return FindValue<ForwardingConfigState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ForwardingConfigState(string value)
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
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for JobStatus
        /// </summary>
        public static readonly JobStatus CANCELLED = new JobStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_FAILURES for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED_WITH_FAILURES = new JobStatus("COMPLETED_WITH_FAILURES");
        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant PENDING for JobStatus
        /// </summary>
        public static readonly JobStatus PENDING = new JobStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for JobStatus
        /// </summary>
        public static readonly JobStatus RUNNING = new JobStatus("RUNNING");

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
    /// Constants used for properties of type ListAssetModelPropertiesFilter.
    /// </summary>
    public class ListAssetModelPropertiesFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ListAssetModelPropertiesFilter
        /// </summary>
        public static readonly ListAssetModelPropertiesFilter ALL = new ListAssetModelPropertiesFilter("ALL");
        /// <summary>
        /// Constant BASE for ListAssetModelPropertiesFilter
        /// </summary>
        public static readonly ListAssetModelPropertiesFilter BASE = new ListAssetModelPropertiesFilter("BASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListAssetModelPropertiesFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListAssetModelPropertiesFilter FindValue(string value)
        {
            return FindValue<ListAssetModelPropertiesFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListAssetModelPropertiesFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListAssetPropertiesFilter.
    /// </summary>
    public class ListAssetPropertiesFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ListAssetPropertiesFilter
        /// </summary>
        public static readonly ListAssetPropertiesFilter ALL = new ListAssetPropertiesFilter("ALL");
        /// <summary>
        /// Constant BASE for ListAssetPropertiesFilter
        /// </summary>
        public static readonly ListAssetPropertiesFilter BASE = new ListAssetPropertiesFilter("BASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListAssetPropertiesFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListAssetPropertiesFilter FindValue(string value)
        {
            return FindValue<ListAssetPropertiesFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListAssetPropertiesFilter(string value)
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
    /// Constants used for properties of type ListBulkImportJobsFilter.
    /// </summary>
    public class ListBulkImportJobsFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ListBulkImportJobsFilter
        /// </summary>
        public static readonly ListBulkImportJobsFilter ALL = new ListBulkImportJobsFilter("ALL");
        /// <summary>
        /// Constant CANCELLED for ListBulkImportJobsFilter
        /// </summary>
        public static readonly ListBulkImportJobsFilter CANCELLED = new ListBulkImportJobsFilter("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for ListBulkImportJobsFilter
        /// </summary>
        public static readonly ListBulkImportJobsFilter COMPLETED = new ListBulkImportJobsFilter("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_FAILURES for ListBulkImportJobsFilter
        /// </summary>
        public static readonly ListBulkImportJobsFilter COMPLETED_WITH_FAILURES = new ListBulkImportJobsFilter("COMPLETED_WITH_FAILURES");
        /// <summary>
        /// Constant FAILED for ListBulkImportJobsFilter
        /// </summary>
        public static readonly ListBulkImportJobsFilter FAILED = new ListBulkImportJobsFilter("FAILED");
        /// <summary>
        /// Constant PENDING for ListBulkImportJobsFilter
        /// </summary>
        public static readonly ListBulkImportJobsFilter PENDING = new ListBulkImportJobsFilter("PENDING");
        /// <summary>
        /// Constant RUNNING for ListBulkImportJobsFilter
        /// </summary>
        public static readonly ListBulkImportJobsFilter RUNNING = new ListBulkImportJobsFilter("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListBulkImportJobsFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListBulkImportJobsFilter FindValue(string value)
        {
            return FindValue<ListBulkImportJobsFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListBulkImportJobsFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListTimeSeriesType.
    /// </summary>
    public class ListTimeSeriesType : ConstantClass
    {

        /// <summary>
        /// Constant ASSOCIATED for ListTimeSeriesType
        /// </summary>
        public static readonly ListTimeSeriesType ASSOCIATED = new ListTimeSeriesType("ASSOCIATED");
        /// <summary>
        /// Constant DISASSOCIATED for ListTimeSeriesType
        /// </summary>
        public static readonly ListTimeSeriesType DISASSOCIATED = new ListTimeSeriesType("DISASSOCIATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListTimeSeriesType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListTimeSeriesType FindValue(string value)
        {
            return FindValue<ListTimeSeriesType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListTimeSeriesType(string value)
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
        /// Constant PENDING for PortalState
        /// </summary>
        public static readonly PortalState PENDING = new PortalState("PENDING");
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
    /// Constants used for properties of type PortalType.
    /// </summary>
    public class PortalType : ConstantClass
    {

        /// <summary>
        /// Constant SITEWISE_PORTAL_V1 for PortalType
        /// </summary>
        public static readonly PortalType SITEWISE_PORTAL_V1 = new PortalType("SITEWISE_PORTAL_V1");
        /// <summary>
        /// Constant SITEWISE_PORTAL_V2 for PortalType
        /// </summary>
        public static readonly PortalType SITEWISE_PORTAL_V2 = new PortalType("SITEWISE_PORTAL_V2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PortalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PortalType FindValue(string value)
        {
            return FindValue<PortalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PortalType(string value)
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
    /// Constants used for properties of type RawValueType.
    /// </summary>
    public class RawValueType : ConstantClass
    {

        /// <summary>
        /// Constant B for RawValueType
        /// </summary>
        public static readonly RawValueType B = new RawValueType("B");
        /// <summary>
        /// Constant D for RawValueType
        /// </summary>
        public static readonly RawValueType D = new RawValueType("D");
        /// <summary>
        /// Constant I for RawValueType
        /// </summary>
        public static readonly RawValueType I = new RawValueType("I");
        /// <summary>
        /// Constant S for RawValueType
        /// </summary>
        public static readonly RawValueType S = new RawValueType("S");
        /// <summary>
        /// Constant U for RawValueType
        /// </summary>
        public static readonly RawValueType U = new RawValueType("U");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RawValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RawValueType FindValue(string value)
        {
            return FindValue<RawValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RawValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolveToResourceType.
    /// </summary>
    public class ResolveToResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ASSET for ResolveToResourceType
        /// </summary>
        public static readonly ResolveToResourceType ASSET = new ResolveToResourceType("ASSET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolveToResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolveToResourceType FindValue(string value)
        {
            return FindValue<ResolveToResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolveToResourceType(string value)
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
    /// Constants used for properties of type ScalarType.
    /// </summary>
    public class ScalarType : ConstantClass
    {

        /// <summary>
        /// Constant BOOLEAN for ScalarType
        /// </summary>
        public static readonly ScalarType BOOLEAN = new ScalarType("BOOLEAN");
        /// <summary>
        /// Constant DOUBLE for ScalarType
        /// </summary>
        public static readonly ScalarType DOUBLE = new ScalarType("DOUBLE");
        /// <summary>
        /// Constant INT for ScalarType
        /// </summary>
        public static readonly ScalarType INT = new ScalarType("INT");
        /// <summary>
        /// Constant STRING for ScalarType
        /// </summary>
        public static readonly ScalarType STRING = new ScalarType("STRING");
        /// <summary>
        /// Constant TIMESTAMP for ScalarType
        /// </summary>
        public static readonly ScalarType TIMESTAMP = new ScalarType("TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalarType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalarType FindValue(string value)
        {
            return FindValue<ScalarType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalarType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageType.
    /// </summary>
    public class StorageType : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_LAYER_STORAGE for StorageType
        /// </summary>
        public static readonly StorageType MULTI_LAYER_STORAGE = new StorageType("MULTI_LAYER_STORAGE");
        /// <summary>
        /// Constant SITEWISE_DEFAULT_STORAGE for StorageType
        /// </summary>
        public static readonly StorageType SITEWISE_DEFAULT_STORAGE = new StorageType("SITEWISE_DEFAULT_STORAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageType FindValue(string value)
        {
            return FindValue<StorageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetResourceType.
    /// </summary>
    public class TargetResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ASSET for TargetResourceType
        /// </summary>
        public static readonly TargetResourceType ASSET = new TargetResourceType("ASSET");
        /// <summary>
        /// Constant COMPUTATION_MODEL for TargetResourceType
        /// </summary>
        public static readonly TargetResourceType COMPUTATION_MODEL = new TargetResourceType("COMPUTATION_MODEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetResourceType FindValue(string value)
        {
            return FindValue<TargetResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetResourceType(string value)
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


    /// <summary>
    /// Constants used for properties of type WarmTierState.
    /// </summary>
    public class WarmTierState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for WarmTierState
        /// </summary>
        public static readonly WarmTierState DISABLED = new WarmTierState("DISABLED");
        /// <summary>
        /// Constant ENABLED for WarmTierState
        /// </summary>
        public static readonly WarmTierState ENABLED = new WarmTierState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WarmTierState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WarmTierState FindValue(string value)
        {
            return FindValue<WarmTierState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WarmTierState(string value)
        {
            return FindValue(value);
        }
    }

}