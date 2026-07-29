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
    /// Constants used for properties of type ApplicationStatus.
    /// </summary>
    public class ApplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus ACTIVE = new ApplicationStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus CREATING = new ApplicationStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus DELETING = new ApplicationStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationStatus FindValue(string value)
        {
            return FindValue<ApplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationStatus(string value)
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
    /// Constants used for properties of type ComputeNodeErrorCode.
    /// </summary>
    public class ComputeNodeErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant EXECUTION_ERROR for ComputeNodeErrorCode
        /// </summary>
        public static readonly ComputeNodeErrorCode EXECUTION_ERROR = new ComputeNodeErrorCode("EXECUTION_ERROR");
        /// <summary>
        /// Constant INTERNAL_FAILURE for ComputeNodeErrorCode
        /// </summary>
        public static readonly ComputeNodeErrorCode INTERNAL_FAILURE = new ComputeNodeErrorCode("INTERNAL_FAILURE");
        /// <summary>
        /// Constant TIMED_OUT for ComputeNodeErrorCode
        /// </summary>
        public static readonly ComputeNodeErrorCode TIMED_OUT = new ComputeNodeErrorCode("TIMED_OUT");
        /// <summary>
        /// Constant VALIDATION_ERROR for ComputeNodeErrorCode
        /// </summary>
        public static readonly ComputeNodeErrorCode VALIDATION_ERROR = new ComputeNodeErrorCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeNodeErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeNodeErrorCode FindValue(string value)
        {
            return FindValue<ComputeNodeErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeNodeErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeNodeExecutionState.
    /// </summary>
    public class ComputeNodeExecutionState : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ComputeNodeExecutionState
        /// </summary>
        public static readonly ComputeNodeExecutionState FAILED = new ComputeNodeExecutionState("FAILED");
        /// <summary>
        /// Constant NOT_STARTED for ComputeNodeExecutionState
        /// </summary>
        public static readonly ComputeNodeExecutionState NOT_STARTED = new ComputeNodeExecutionState("NOT_STARTED");
        /// <summary>
        /// Constant QUEUED for ComputeNodeExecutionState
        /// </summary>
        public static readonly ComputeNodeExecutionState QUEUED = new ComputeNodeExecutionState("QUEUED");
        /// <summary>
        /// Constant RUNNING for ComputeNodeExecutionState
        /// </summary>
        public static readonly ComputeNodeExecutionState RUNNING = new ComputeNodeExecutionState("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for ComputeNodeExecutionState
        /// </summary>
        public static readonly ComputeNodeExecutionState SUCCEEDED = new ComputeNodeExecutionState("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeNodeExecutionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeNodeExecutionState FindValue(string value)
        {
            return FindValue<ComputeNodeExecutionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeNodeExecutionState(string value)
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
    /// Constants used for properties of type DataSegmentErrorCode.
    /// </summary>
    public class DataSegmentErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant CONFLICTING_OPERATION for DataSegmentErrorCode
        /// </summary>
        public static readonly DataSegmentErrorCode CONFLICTING_OPERATION = new DataSegmentErrorCode("CONFLICTING_OPERATION");
        /// <summary>
        /// Constant INTERNAL_FAILURE for DataSegmentErrorCode
        /// </summary>
        public static readonly DataSegmentErrorCode INTERNAL_FAILURE = new DataSegmentErrorCode("INTERNAL_FAILURE");
        /// <summary>
        /// Constant LIMIT_EXCEEDED for DataSegmentErrorCode
        /// </summary>
        public static readonly DataSegmentErrorCode LIMIT_EXCEEDED = new DataSegmentErrorCode("LIMIT_EXCEEDED");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for DataSegmentErrorCode
        /// </summary>
        public static readonly DataSegmentErrorCode RESOURCE_NOT_FOUND = new DataSegmentErrorCode("RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant VALIDATION_ERROR for DataSegmentErrorCode
        /// </summary>
        public static readonly DataSegmentErrorCode VALIDATION_ERROR = new DataSegmentErrorCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSegmentErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSegmentErrorCode FindValue(string value)
        {
            return FindValue<DataSegmentErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSegmentErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetEnrichmentStatus.
    /// </summary>
    public class DatasetEnrichmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant FULLY_ENRICHED for DatasetEnrichmentStatus
        /// </summary>
        public static readonly DatasetEnrichmentStatus FULLY_ENRICHED = new DatasetEnrichmentStatus("FULLY_ENRICHED");
        /// <summary>
        /// Constant NOT_ENRICHED for DatasetEnrichmentStatus
        /// </summary>
        public static readonly DatasetEnrichmentStatus NOT_ENRICHED = new DatasetEnrichmentStatus("NOT_ENRICHED");
        /// <summary>
        /// Constant PARTIALLY_ENRICHED for DatasetEnrichmentStatus
        /// </summary>
        public static readonly DatasetEnrichmentStatus PARTIALLY_ENRICHED = new DatasetEnrichmentStatus("PARTIALLY_ENRICHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetEnrichmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetEnrichmentStatus FindValue(string value)
        {
            return FindValue<DatasetEnrichmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetEnrichmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetExportJobFilter.
    /// </summary>
    public class DatasetExportJobFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for DatasetExportJobFilter
        /// </summary>
        public static readonly DatasetExportJobFilter ALL = new DatasetExportJobFilter("ALL");
        /// <summary>
        /// Constant COMPLETED for DatasetExportJobFilter
        /// </summary>
        public static readonly DatasetExportJobFilter COMPLETED = new DatasetExportJobFilter("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_ERRORS for DatasetExportJobFilter
        /// </summary>
        public static readonly DatasetExportJobFilter COMPLETED_WITH_ERRORS = new DatasetExportJobFilter("COMPLETED_WITH_ERRORS");
        /// <summary>
        /// Constant FAILED for DatasetExportJobFilter
        /// </summary>
        public static readonly DatasetExportJobFilter FAILED = new DatasetExportJobFilter("FAILED");
        /// <summary>
        /// Constant RUNNING for DatasetExportJobFilter
        /// </summary>
        public static readonly DatasetExportJobFilter RUNNING = new DatasetExportJobFilter("RUNNING");
        /// <summary>
        /// Constant SUBMITTED for DatasetExportJobFilter
        /// </summary>
        public static readonly DatasetExportJobFilter SUBMITTED = new DatasetExportJobFilter("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetExportJobFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetExportJobFilter FindValue(string value)
        {
            return FindValue<DatasetExportJobFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetExportJobFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetExportJobStatus.
    /// </summary>
    public class DatasetExportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for DatasetExportJobStatus
        /// </summary>
        public static readonly DatasetExportJobStatus COMPLETED = new DatasetExportJobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_ERRORS for DatasetExportJobStatus
        /// </summary>
        public static readonly DatasetExportJobStatus COMPLETED_WITH_ERRORS = new DatasetExportJobStatus("COMPLETED_WITH_ERRORS");
        /// <summary>
        /// Constant FAILED for DatasetExportJobStatus
        /// </summary>
        public static readonly DatasetExportJobStatus FAILED = new DatasetExportJobStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for DatasetExportJobStatus
        /// </summary>
        public static readonly DatasetExportJobStatus RUNNING = new DatasetExportJobStatus("RUNNING");
        /// <summary>
        /// Constant SUBMITTED for DatasetExportJobStatus
        /// </summary>
        public static readonly DatasetExportJobStatus SUBMITTED = new DatasetExportJobStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetExportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetExportJobStatus FindValue(string value)
        {
            return FindValue<DatasetExportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetExportJobStatus(string value)
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
        /// Constant TIMESERIES for DatasetSourceFormat
        /// </summary>
        public static readonly DatasetSourceFormat TIMESERIES = new DatasetSourceFormat("TIMESERIES");

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
        /// Constant SITEWISE for DatasetSourceType
        /// </summary>
        public static readonly DatasetSourceType SITEWISE = new DatasetSourceType("SITEWISE");

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
    /// Constants used for properties of type DatasetTypeEnum.
    /// </summary>
    public class DatasetTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant CURATED for DatasetTypeEnum
        /// </summary>
        public static readonly DatasetTypeEnum CURATED = new DatasetTypeEnum("CURATED");
        /// <summary>
        /// Constant EXTERNAL for DatasetTypeEnum
        /// </summary>
        public static readonly DatasetTypeEnum EXTERNAL = new DatasetTypeEnum("EXTERNAL");
        /// <summary>
        /// Constant SESSION for DatasetTypeEnum
        /// </summary>
        public static readonly DatasetTypeEnum SESSION = new DatasetTypeEnum("SESSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetTypeEnum FindValue(string value)
        {
            return FindValue<DatasetTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetTypeEnum(string value)
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
    /// Constants used for properties of type DetailedPipelineErrorCode.
    /// </summary>
    public class DetailedPipelineErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant EXECUTION_ERROR for DetailedPipelineErrorCode
        /// </summary>
        public static readonly DetailedPipelineErrorCode EXECUTION_ERROR = new DetailedPipelineErrorCode("EXECUTION_ERROR");
        /// <summary>
        /// Constant INTERNAL_FAILURE for DetailedPipelineErrorCode
        /// </summary>
        public static readonly DetailedPipelineErrorCode INTERNAL_FAILURE = new DetailedPipelineErrorCode("INTERNAL_FAILURE");
        /// <summary>
        /// Constant TIMED_OUT for DetailedPipelineErrorCode
        /// </summary>
        public static readonly DetailedPipelineErrorCode TIMED_OUT = new DetailedPipelineErrorCode("TIMED_OUT");
        /// <summary>
        /// Constant VALIDATION_ERROR for DetailedPipelineErrorCode
        /// </summary>
        public static readonly DetailedPipelineErrorCode VALIDATION_ERROR = new DetailedPipelineErrorCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetailedPipelineErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetailedPipelineErrorCode FindValue(string value)
        {
            return FindValue<DetailedPipelineErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetailedPipelineErrorCode(string value)
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
    /// Constants used for properties of type EnrichmentJobStatus.
    /// </summary>
    public class EnrichmentJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for EnrichmentJobStatus
        /// </summary>
        public static readonly EnrichmentJobStatus CANCELLED = new EnrichmentJobStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for EnrichmentJobStatus
        /// </summary>
        public static readonly EnrichmentJobStatus COMPLETED = new EnrichmentJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for EnrichmentJobStatus
        /// </summary>
        public static readonly EnrichmentJobStatus FAILED = new EnrichmentJobStatus("FAILED");
        /// <summary>
        /// Constant PENDING for EnrichmentJobStatus
        /// </summary>
        public static readonly EnrichmentJobStatus PENDING = new EnrichmentJobStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for EnrichmentJobStatus
        /// </summary>
        public static readonly EnrichmentJobStatus RUNNING = new EnrichmentJobStatus("RUNNING");
        /// <summary>
        /// Constant TIMED_OUT for EnrichmentJobStatus
        /// </summary>
        public static readonly EnrichmentJobStatus TIMED_OUT = new EnrichmentJobStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnrichmentJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnrichmentJobStatus FindValue(string value)
        {
            return FindValue<EnrichmentJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnrichmentJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnrichmentStatus.
    /// </summary>
    public class EnrichmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant ENRICHED for EnrichmentStatus
        /// </summary>
        public static readonly EnrichmentStatus ENRICHED = new EnrichmentStatus("ENRICHED");
        /// <summary>
        /// Constant NOT_ENRICHED for EnrichmentStatus
        /// </summary>
        public static readonly EnrichmentStatus NOT_ENRICHED = new EnrichmentStatus("NOT_ENRICHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnrichmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnrichmentStatus FindValue(string value)
        {
            return FindValue<EnrichmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnrichmentStatus(string value)
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
    /// Constants used for properties of type ExportDataType.
    /// </summary>
    public class ExportDataType : ConstantClass
    {

        /// <summary>
        /// Constant ANNOTATION for ExportDataType
        /// </summary>
        public static readonly ExportDataType ANNOTATION = new ExportDataType("ANNOTATION");
        /// <summary>
        /// Constant TELEMETRY for ExportDataType
        /// </summary>
        public static readonly ExportDataType TELEMETRY = new ExportDataType("TELEMETRY");
        /// <summary>
        /// Constant VIDEO for ExportDataType
        /// </summary>
        public static readonly ExportDataType VIDEO = new ExportDataType("VIDEO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportDataType FindValue(string value)
        {
            return FindValue<ExportDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportDataType(string value)
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
    /// Constants used for properties of type JobType.
    /// </summary>
    public class JobType : ConstantClass
    {

        /// <summary>
        /// Constant EVENT_DETECTION for JobType
        /// </summary>
        public static readonly JobType EVENT_DETECTION = new JobType("EVENT_DETECTION");

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
    /// Constants used for properties of type PipelineErrorCode.
    /// </summary>
    public class PipelineErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant EXECUTION_ERROR for PipelineErrorCode
        /// </summary>
        public static readonly PipelineErrorCode EXECUTION_ERROR = new PipelineErrorCode("EXECUTION_ERROR");
        /// <summary>
        /// Constant INTERNAL_FAILURE for PipelineErrorCode
        /// </summary>
        public static readonly PipelineErrorCode INTERNAL_FAILURE = new PipelineErrorCode("INTERNAL_FAILURE");
        /// <summary>
        /// Constant TIMED_OUT for PipelineErrorCode
        /// </summary>
        public static readonly PipelineErrorCode TIMED_OUT = new PipelineErrorCode("TIMED_OUT");
        /// <summary>
        /// Constant VALIDATION_ERROR for PipelineErrorCode
        /// </summary>
        public static readonly PipelineErrorCode VALIDATION_ERROR = new PipelineErrorCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineErrorCode FindValue(string value)
        {
            return FindValue<PipelineErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipelineExecutionState.
    /// </summary>
    public class PipelineExecutionState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for PipelineExecutionState
        /// </summary>
        public static readonly PipelineExecutionState CANCELLED = new PipelineExecutionState("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for PipelineExecutionState
        /// </summary>
        public static readonly PipelineExecutionState CANCELLING = new PipelineExecutionState("CANCELLING");
        /// <summary>
        /// Constant FAILED for PipelineExecutionState
        /// </summary>
        public static readonly PipelineExecutionState FAILED = new PipelineExecutionState("FAILED");
        /// <summary>
        /// Constant NOT_STARTED for PipelineExecutionState
        /// </summary>
        public static readonly PipelineExecutionState NOT_STARTED = new PipelineExecutionState("NOT_STARTED");
        /// <summary>
        /// Constant RUNNING for PipelineExecutionState
        /// </summary>
        public static readonly PipelineExecutionState RUNNING = new PipelineExecutionState("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for PipelineExecutionState
        /// </summary>
        public static readonly PipelineExecutionState SUCCEEDED = new PipelineExecutionState("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineExecutionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineExecutionState FindValue(string value)
        {
            return FindValue<PipelineExecutionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineExecutionState(string value)
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
    /// Constants used for properties of type ProcessingType.
    /// </summary>
    public class ProcessingType : ConstantClass
    {

        /// <summary>
        /// Constant GENERIC_COMPUTE_PROCESSING for ProcessingType
        /// </summary>
        public static readonly ProcessingType GENERIC_COMPUTE_PROCESSING = new ProcessingType("GENERIC_COMPUTE_PROCESSING");
        /// <summary>
        /// Constant HARDWARE_ACCELERATED_PROCESSING for ProcessingType
        /// </summary>
        public static readonly ProcessingType HARDWARE_ACCELERATED_PROCESSING = new ProcessingType("HARDWARE_ACCELERATED_PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessingType FindValue(string value)
        {
            return FindValue<ProcessingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcessingUnit.
    /// </summary>
    public class ProcessingUnit : ConstantClass
    {

        /// <summary>
        /// Constant UNITS_12 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_12 = new ProcessingUnit("UNITS_12");
        /// <summary>
        /// Constant UNITS_16 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_16 = new ProcessingUnit("UNITS_16");
        /// <summary>
        /// Constant UNITS_2 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_2 = new ProcessingUnit("UNITS_2");
        /// <summary>
        /// Constant UNITS_24 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_24 = new ProcessingUnit("UNITS_24");
        /// <summary>
        /// Constant UNITS_32 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_32 = new ProcessingUnit("UNITS_32");
        /// <summary>
        /// Constant UNITS_36 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_36 = new ProcessingUnit("UNITS_36");
        /// <summary>
        /// Constant UNITS_4 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_4 = new ProcessingUnit("UNITS_4");
        /// <summary>
        /// Constant UNITS_48 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_48 = new ProcessingUnit("UNITS_48");
        /// <summary>
        /// Constant UNITS_60 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_60 = new ProcessingUnit("UNITS_60");
        /// <summary>
        /// Constant UNITS_64 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_64 = new ProcessingUnit("UNITS_64");
        /// <summary>
        /// Constant UNITS_72 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_72 = new ProcessingUnit("UNITS_72");
        /// <summary>
        /// Constant UNITS_8 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_8 = new ProcessingUnit("UNITS_8");
        /// <summary>
        /// Constant UNITS_84 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_84 = new ProcessingUnit("UNITS_84");
        /// <summary>
        /// Constant UNITS_96 for ProcessingUnit
        /// </summary>
        public static readonly ProcessingUnit UNITS_96 = new ProcessingUnit("UNITS_96");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessingUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessingUnit FindValue(string value)
        {
            return FindValue<ProcessingUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessingUnit(string value)
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
        /// Constant ANNOTATION for PropertyDataType
        /// </summary>
        public static readonly PropertyDataType ANNOTATION = new PropertyDataType("ANNOTATION");
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
        /// Constant JSON for PropertyDataType
        /// </summary>
        public static readonly PropertyDataType JSON = new PropertyDataType("JSON");
        /// <summary>
        /// Constant STRING for PropertyDataType
        /// </summary>
        public static readonly PropertyDataType STRING = new PropertyDataType("STRING");
        /// <summary>
        /// Constant STRUCT for PropertyDataType
        /// </summary>
        public static readonly PropertyDataType STRUCT = new PropertyDataType("STRUCT");
        /// <summary>
        /// Constant VIDEO for PropertyDataType
        /// </summary>
        public static readonly PropertyDataType VIDEO = new PropertyDataType("VIDEO");

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
    /// Constants used for properties of type QueryStatus.
    /// </summary>
    public class QueryStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for QueryStatus
        /// </summary>
        public static readonly QueryStatus CANCELED = new QueryStatus("CANCELED");
        /// <summary>
        /// Constant CANCELING for QueryStatus
        /// </summary>
        public static readonly QueryStatus CANCELING = new QueryStatus("CANCELING");
        /// <summary>
        /// Constant COMPLETED for QueryStatus
        /// </summary>
        public static readonly QueryStatus COMPLETED = new QueryStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for QueryStatus
        /// </summary>
        public static readonly QueryStatus FAILED = new QueryStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for QueryStatus
        /// </summary>
        public static readonly QueryStatus RUNNING = new QueryStatus("RUNNING");
        /// <summary>
        /// Constant SUBMITTED for QueryStatus
        /// </summary>
        public static readonly QueryStatus SUBMITTED = new QueryStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryStatus FindValue(string value)
        {
            return FindValue<QueryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryStatus(string value)
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
    /// Constants used for properties of type ResourceErrorCode.
    /// </summary>
    public class ResourceErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_FAILURE for ResourceErrorCode
        /// </summary>
        public static readonly ResourceErrorCode INTERNAL_FAILURE = new ResourceErrorCode("INTERNAL_FAILURE");
        /// <summary>
        /// Constant VALIDATION_ERROR for ResourceErrorCode
        /// </summary>
        public static readonly ResourceErrorCode VALIDATION_ERROR = new ResourceErrorCode("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceErrorCode FindValue(string value)
        {
            return FindValue<ResourceErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceState.
    /// </summary>
    public class ResourceState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ResourceState
        /// </summary>
        public static readonly ResourceState ACTIVE = new ResourceState("ACTIVE");
        /// <summary>
        /// Constant CREATING for ResourceState
        /// </summary>
        public static readonly ResourceState CREATING = new ResourceState("CREATING");
        /// <summary>
        /// Constant DELETING for ResourceState
        /// </summary>
        public static readonly ResourceState DELETING = new ResourceState("DELETING");
        /// <summary>
        /// Constant FAILED for ResourceState
        /// </summary>
        public static readonly ResourceState FAILED = new ResourceState("FAILED");
        /// <summary>
        /// Constant UPDATING for ResourceState
        /// </summary>
        public static readonly ResourceState UPDATING = new ResourceState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceState FindValue(string value)
        {
            return FindValue<ResourceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceState(string value)
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
    /// Constants used for properties of type SearchStatus.
    /// </summary>
    public class SearchStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for SearchStatus
        /// </summary>
        public static readonly SearchStatus FAILED = new SearchStatus("FAILED");
        /// <summary>
        /// Constant QUEUED for SearchStatus
        /// </summary>
        public static readonly SearchStatus QUEUED = new SearchStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for SearchStatus
        /// </summary>
        public static readonly SearchStatus RUNNING = new SearchStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for SearchStatus
        /// </summary>
        public static readonly SearchStatus SUCCEEDED = new SearchStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchStatus FindValue(string value)
        {
            return FindValue<SearchStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchType.
    /// </summary>
    public class SearchType : ConstantClass
    {

        /// <summary>
        /// Constant DEEP for SearchType
        /// </summary>
        public static readonly SearchType DEEP = new SearchType("DEEP");
        /// <summary>
        /// Constant QUICK for SearchType
        /// </summary>
        public static readonly SearchType QUICK = new SearchType("QUICK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchType FindValue(string value)
        {
            return FindValue<SearchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchType(string value)
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
    /// Constants used for properties of type VideoDataType.
    /// </summary>
    public class VideoDataType : ConstantClass
    {

        /// <summary>
        /// Constant VIDEOMP4 for VideoDataType
        /// </summary>
        public static readonly VideoDataType VIDEOMP4 = new VideoDataType("VIDEO-MP4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoDataType FindValue(string value)
        {
            return FindValue<VideoDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoDataType(string value)
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


    /// <summary>
    /// Constants used for properties of type WorkspaceState.
    /// </summary>
    public class WorkspaceState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState ACTIVE = new WorkspaceState("ACTIVE");
        /// <summary>
        /// Constant CREATING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState CREATING = new WorkspaceState("CREATING");
        /// <summary>
        /// Constant DELETING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState DELETING = new WorkspaceState("DELETING");
        /// <summary>
        /// Constant FAILED for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState FAILED = new WorkspaceState("FAILED");
        /// <summary>
        /// Constant UPDATING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState UPDATING = new WorkspaceState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceState FindValue(string value)
        {
            return FindValue<WorkspaceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceState(string value)
        {
            return FindValue(value);
        }
    }

}