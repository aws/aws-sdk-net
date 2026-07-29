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
 * Do not modify this file. This file is generated from the partnercentral-revenue-measurement-2022-07-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PartnerCentralRevenueMeasurement
{

    /// <summary>
    /// Constants used for properties of type AccessDeniedExceptionReason.
    /// </summary>
    public class AccessDeniedExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason ACCESS_DENIED = new AccessDeniedExceptionReason("ACCESS_DENIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessDeniedExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessDeniedExceptionReason FindValue(string value)
        {
            return FindValue<AccessDeniedExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessDeniedExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AllocationStatus.
    /// </summary>
    public class AllocationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AllocationStatus
        /// </summary>
        public static readonly AllocationStatus ACTIVE = new AllocationStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for AllocationStatus
        /// </summary>
        public static readonly AllocationStatus INACTIVE = new AllocationStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllocationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllocationStatus FindValue(string value)
        {
            return FindValue<AllocationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllocationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttributionSortBy.
    /// </summary>
    public class AttributionSortBy : ConstantClass
    {

        /// <summary>
        /// Constant LastModifiedDate for AttributionSortBy
        /// </summary>
        public static readonly AttributionSortBy LastModifiedDate = new AttributionSortBy("LastModifiedDate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttributionSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttributionSortBy FindValue(string value)
        {
            return FindValue<AttributionSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttributionSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CatalogName.
    /// </summary>
    public class CatalogName : ConstantClass
    {

        /// <summary>
        /// Constant AWS for CatalogName
        /// </summary>
        public static readonly CatalogName AWS = new CatalogName("AWS");
        /// <summary>
        /// Constant Sandbox for CatalogName
        /// </summary>
        public static readonly CatalogName Sandbox = new CatalogName("Sandbox");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CatalogName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CatalogName FindValue(string value)
        {
            return FindValue<CatalogName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CatalogName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictExceptionReason.
    /// </summary>
    public class ConflictExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CONCURRENT_MODIFICATION for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason CONCURRENT_MODIFICATION = new ConflictExceptionReason("CONCURRENT_MODIFICATION");
        /// <summary>
        /// Constant CONFLICT_CLIENT_TOKEN for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason CONFLICT_CLIENT_TOKEN = new ConflictExceptionReason("CONFLICT_CLIENT_TOKEN");
        /// <summary>
        /// Constant RESOURCE_ALREADY_EXISTS for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason RESOURCE_ALREADY_EXISTS = new ConflictExceptionReason("RESOURCE_ALREADY_EXISTS");
        /// <summary>
        /// Constant REVISION_MISMATCH for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason REVISION_MISMATCH = new ConflictExceptionReason("REVISION_MISMATCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictExceptionReason FindValue(string value)
        {
            return FindValue<ConflictExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityType.
    /// </summary>
    public class EntityType : ConstantClass
    {

        /// <summary>
        /// Constant OFFER for EntityType
        /// </summary>
        public static readonly EntityType OFFER = new EntityType("OFFER");
        /// <summary>
        /// Constant OPPORTUNITY for EntityType
        /// </summary>
        public static readonly EntityType OPPORTUNITY = new EntityType("OPPORTUNITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityType FindValue(string value)
        {
            return FindValue<EntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FieldValidationCode.
    /// </summary>
    public class FieldValidationCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_NOT_PERMITTED for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode ACTION_NOT_PERMITTED = new FieldValidationCode("ACTION_NOT_PERMITTED");
        /// <summary>
        /// Constant DUPLICATE_VALUE for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode DUPLICATE_VALUE = new FieldValidationCode("DUPLICATE_VALUE");
        /// <summary>
        /// Constant INVALID_ENUM_VALUE for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode INVALID_ENUM_VALUE = new FieldValidationCode("INVALID_ENUM_VALUE");
        /// <summary>
        /// Constant INVALID_NUMBER_FORMAT for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode INVALID_NUMBER_FORMAT = new FieldValidationCode("INVALID_NUMBER_FORMAT");
        /// <summary>
        /// Constant INVALID_STRING_FORMAT for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode INVALID_STRING_FORMAT = new FieldValidationCode("INVALID_STRING_FORMAT");
        /// <summary>
        /// Constant INVALID_STRING_LENGTH for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode INVALID_STRING_LENGTH = new FieldValidationCode("INVALID_STRING_LENGTH");
        /// <summary>
        /// Constant INVALID_VALUE for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode INVALID_VALUE = new FieldValidationCode("INVALID_VALUE");
        /// <summary>
        /// Constant REQUIRED_FIELD_MISSING for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode REQUIRED_FIELD_MISSING = new FieldValidationCode("REQUIRED_FIELD_MISSING");
        /// <summary>
        /// Constant TOO_MANY_VALUES for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode TOO_MANY_VALUES = new FieldValidationCode("TOO_MANY_VALUES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldValidationCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldValidationCode FindValue(string value)
        {
            return FindValue<FieldValidationCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldValidationCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MarketplaceRevenueShareAllocationSortField.
    /// </summary>
    public class MarketplaceRevenueShareAllocationSortField : ConstantClass
    {

        /// <summary>
        /// Constant EffectiveFrom for MarketplaceRevenueShareAllocationSortField
        /// </summary>
        public static readonly MarketplaceRevenueShareAllocationSortField EffectiveFrom = new MarketplaceRevenueShareAllocationSortField("EffectiveFrom");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MarketplaceRevenueShareAllocationSortField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MarketplaceRevenueShareAllocationSortField FindValue(string value)
        {
            return FindValue<MarketplaceRevenueShareAllocationSortField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MarketplaceRevenueShareAllocationSortField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MarketplaceRevenueShareSortBy.
    /// </summary>
    public class MarketplaceRevenueShareSortBy : ConstantClass
    {

        /// <summary>
        /// Constant LastModifiedDate for MarketplaceRevenueShareSortBy
        /// </summary>
        public static readonly MarketplaceRevenueShareSortBy LastModifiedDate = new MarketplaceRevenueShareSortBy("LastModifiedDate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MarketplaceRevenueShareSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MarketplaceRevenueShareSortBy FindValue(string value)
        {
            return FindValue<MarketplaceRevenueShareSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MarketplaceRevenueShareSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceNotFoundExceptionReason.
    /// </summary>
    public class ResourceNotFoundExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason RESOURCE_NOT_FOUND = new ResourceNotFoundExceptionReason("RESOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceNotFoundExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceNotFoundExceptionReason FindValue(string value)
        {
            return FindValue<ResourceNotFoundExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceNotFoundExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RevenueAttributionAllocationAction.
    /// </summary>
    public class RevenueAttributionAllocationAction : ConstantClass
    {

        /// <summary>
        /// Constant CREATE for RevenueAttributionAllocationAction
        /// </summary>
        public static readonly RevenueAttributionAllocationAction CREATE = new RevenueAttributionAllocationAction("CREATE");
        /// <summary>
        /// Constant UPDATE for RevenueAttributionAllocationAction
        /// </summary>
        public static readonly RevenueAttributionAllocationAction UPDATE = new RevenueAttributionAllocationAction("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RevenueAttributionAllocationAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevenueAttributionAllocationAction FindValue(string value)
        {
            return FindValue<RevenueAttributionAllocationAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevenueAttributionAllocationAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RevenueAttributionAllocationErrorCode.
    /// </summary>
    public class RevenueAttributionAllocationErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for RevenueAttributionAllocationErrorCode
        /// </summary>
        public static readonly RevenueAttributionAllocationErrorCode ACCESS_DENIED = new RevenueAttributionAllocationErrorCode("ACCESS_DENIED");
        /// <summary>
        /// Constant ALLOCATION_CAP_EXCEEDED for RevenueAttributionAllocationErrorCode
        /// </summary>
        public static readonly RevenueAttributionAllocationErrorCode ALLOCATION_CAP_EXCEEDED = new RevenueAttributionAllocationErrorCode("ALLOCATION_CAP_EXCEEDED");
        /// <summary>
        /// Constant CONCURRENT_MODIFICATION for RevenueAttributionAllocationErrorCode
        /// </summary>
        public static readonly RevenueAttributionAllocationErrorCode CONCURRENT_MODIFICATION = new RevenueAttributionAllocationErrorCode("CONCURRENT_MODIFICATION");
        /// <summary>
        /// Constant IMMUTABLE_ALLOCATION for RevenueAttributionAllocationErrorCode
        /// </summary>
        public static readonly RevenueAttributionAllocationErrorCode IMMUTABLE_ALLOCATION = new RevenueAttributionAllocationErrorCode("IMMUTABLE_ALLOCATION");
        /// <summary>
        /// Constant INTERNAL_ERROR for RevenueAttributionAllocationErrorCode
        /// </summary>
        public static readonly RevenueAttributionAllocationErrorCode INTERNAL_ERROR = new RevenueAttributionAllocationErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_VALUE for RevenueAttributionAllocationErrorCode
        /// </summary>
        public static readonly RevenueAttributionAllocationErrorCode INVALID_VALUE = new RevenueAttributionAllocationErrorCode("INVALID_VALUE");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for RevenueAttributionAllocationErrorCode
        /// </summary>
        public static readonly RevenueAttributionAllocationErrorCode RESOURCE_NOT_FOUND = new RevenueAttributionAllocationErrorCode("RESOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RevenueAttributionAllocationErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevenueAttributionAllocationErrorCode FindValue(string value)
        {
            return FindValue<RevenueAttributionAllocationErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevenueAttributionAllocationErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RevenueAttributionAllocationSortField.
    /// </summary>
    public class RevenueAttributionAllocationSortField : ConstantClass
    {

        /// <summary>
        /// Constant EffectiveFrom for RevenueAttributionAllocationSortField
        /// </summary>
        public static readonly RevenueAttributionAllocationSortField EffectiveFrom = new RevenueAttributionAllocationSortField("EffectiveFrom");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RevenueAttributionAllocationSortField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevenueAttributionAllocationSortField FindValue(string value)
        {
            return FindValue<RevenueAttributionAllocationSortField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevenueAttributionAllocationSortField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RevenueAttributionAllocationTaskStatus.
    /// </summary>
    public class RevenueAttributionAllocationTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for RevenueAttributionAllocationTaskStatus
        /// </summary>
        public static readonly RevenueAttributionAllocationTaskStatus COMPLETE = new RevenueAttributionAllocationTaskStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for RevenueAttributionAllocationTaskStatus
        /// </summary>
        public static readonly RevenueAttributionAllocationTaskStatus FAILED = new RevenueAttributionAllocationTaskStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for RevenueAttributionAllocationTaskStatus
        /// </summary>
        public static readonly RevenueAttributionAllocationTaskStatus IN_PROGRESS = new RevenueAttributionAllocationTaskStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RevenueAttributionAllocationTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevenueAttributionAllocationTaskStatus FindValue(string value)
        {
            return FindValue<RevenueAttributionAllocationTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevenueAttributionAllocationTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceQuotaExceededExceptionReason.
    /// </summary>
    public class ServiceQuotaExceededExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant ATTRIBUTION_LIMIT_EXCEEDED for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason ATTRIBUTION_LIMIT_EXCEEDED = new ServiceQuotaExceededExceptionReason("ATTRIBUTION_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant TAG_LIMIT_EXCEEDED for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason TAG_LIMIT_EXCEEDED = new ServiceQuotaExceededExceptionReason("TAG_LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceQuotaExceededExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceQuotaExceededExceptionReason FindValue(string value)
        {
            return FindValue<ServiceQuotaExceededExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceQuotaExceededExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TenancyModel.
    /// </summary>
    public class TenancyModel : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_TENANT for TenancyModel
        /// </summary>
        public static readonly TenancyModel MULTI_TENANT = new TenancyModel("MULTI_TENANT");
        /// <summary>
        /// Constant SINGLE_TENANT for TenancyModel
        /// </summary>
        public static readonly TenancyModel SINGLE_TENANT = new TenancyModel("SINGLE_TENANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TenancyModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TenancyModel FindValue(string value)
        {
            return FindValue<TenancyModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TenancyModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant BUSINESS_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason BUSINESS_VALIDATION_FAILED = new ValidationExceptionReason("BUSINESS_VALIDATION_FAILED");
        /// <summary>
        /// Constant REQUEST_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason REQUEST_VALIDATION_FAILED = new ValidationExceptionReason("REQUEST_VALIDATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}