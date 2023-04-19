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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.RAM
{

    /// <summary>
    /// Constants used for properties of type PermissionFeatureSet.
    /// </summary>
    public class PermissionFeatureSet : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_FROM_POLICY for PermissionFeatureSet
        /// </summary>
        public static readonly PermissionFeatureSet CREATED_FROM_POLICY = new PermissionFeatureSet("CREATED_FROM_POLICY");
        /// <summary>
        /// Constant PROMOTING_TO_STANDARD for PermissionFeatureSet
        /// </summary>
        public static readonly PermissionFeatureSet PROMOTING_TO_STANDARD = new PermissionFeatureSet("PROMOTING_TO_STANDARD");
        /// <summary>
        /// Constant STANDARD for PermissionFeatureSet
        /// </summary>
        public static readonly PermissionFeatureSet STANDARD = new PermissionFeatureSet("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionFeatureSet(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionFeatureSet FindValue(string value)
        {
            return FindValue<PermissionFeatureSet>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionFeatureSet(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionStatus.
    /// </summary>
    public class PermissionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHABLE for PermissionStatus
        /// </summary>
        public static readonly PermissionStatus ATTACHABLE = new PermissionStatus("ATTACHABLE");
        /// <summary>
        /// Constant DELETED for PermissionStatus
        /// </summary>
        public static readonly PermissionStatus DELETED = new PermissionStatus("DELETED");
        /// <summary>
        /// Constant DELETING for PermissionStatus
        /// </summary>
        public static readonly PermissionStatus DELETING = new PermissionStatus("DELETING");
        /// <summary>
        /// Constant UNATTACHABLE for PermissionStatus
        /// </summary>
        public static readonly PermissionStatus UNATTACHABLE = new PermissionStatus("UNATTACHABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionStatus FindValue(string value)
        {
            return FindValue<PermissionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionType.
    /// </summary>
    public class PermissionType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_MANAGED for PermissionType
        /// </summary>
        public static readonly PermissionType AWS_MANAGED = new PermissionType("AWS_MANAGED");
        /// <summary>
        /// Constant CUSTOMER_MANAGED for PermissionType
        /// </summary>
        public static readonly PermissionType CUSTOMER_MANAGED = new PermissionType("CUSTOMER_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionType FindValue(string value)
        {
            return FindValue<PermissionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionTypeFilter.
    /// </summary>
    public class PermissionTypeFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for PermissionTypeFilter
        /// </summary>
        public static readonly PermissionTypeFilter ALL = new PermissionTypeFilter("ALL");
        /// <summary>
        /// Constant AWS_MANAGED for PermissionTypeFilter
        /// </summary>
        public static readonly PermissionTypeFilter AWS_MANAGED = new PermissionTypeFilter("AWS_MANAGED");
        /// <summary>
        /// Constant CUSTOMER_MANAGED for PermissionTypeFilter
        /// </summary>
        public static readonly PermissionTypeFilter CUSTOMER_MANAGED = new PermissionTypeFilter("CUSTOMER_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionTypeFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionTypeFilter FindValue(string value)
        {
            return FindValue<PermissionTypeFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionTypeFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplacePermissionAssociationsWorkStatus.
    /// </summary>
    public class ReplacePermissionAssociationsWorkStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ReplacePermissionAssociationsWorkStatus
        /// </summary>
        public static readonly ReplacePermissionAssociationsWorkStatus COMPLETED = new ReplacePermissionAssociationsWorkStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ReplacePermissionAssociationsWorkStatus
        /// </summary>
        public static readonly ReplacePermissionAssociationsWorkStatus FAILED = new ReplacePermissionAssociationsWorkStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ReplacePermissionAssociationsWorkStatus
        /// </summary>
        public static readonly ReplacePermissionAssociationsWorkStatus IN_PROGRESS = new ReplacePermissionAssociationsWorkStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplacePermissionAssociationsWorkStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplacePermissionAssociationsWorkStatus FindValue(string value)
        {
            return FindValue<ReplacePermissionAssociationsWorkStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplacePermissionAssociationsWorkStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceOwner.
    /// </summary>
    public class ResourceOwner : ConstantClass
    {

        /// <summary>
        /// Constant OTHERACCOUNTS for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner OTHERACCOUNTS = new ResourceOwner("OTHER-ACCOUNTS");
        /// <summary>
        /// Constant SELF for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner SELF = new ResourceOwner("SELF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceOwner(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceOwner FindValue(string value)
        {
            return FindValue<ResourceOwner>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceOwner(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceRegionScope.
    /// </summary>
    public class ResourceRegionScope : ConstantClass
    {

        /// <summary>
        /// Constant GLOBAL for ResourceRegionScope
        /// </summary>
        public static readonly ResourceRegionScope GLOBAL = new ResourceRegionScope("GLOBAL");
        /// <summary>
        /// Constant REGIONAL for ResourceRegionScope
        /// </summary>
        public static readonly ResourceRegionScope REGIONAL = new ResourceRegionScope("REGIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceRegionScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceRegionScope FindValue(string value)
        {
            return FindValue<ResourceRegionScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceRegionScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceRegionScopeFilter.
    /// </summary>
    public class ResourceRegionScopeFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ResourceRegionScopeFilter
        /// </summary>
        public static readonly ResourceRegionScopeFilter ALL = new ResourceRegionScopeFilter("ALL");
        /// <summary>
        /// Constant GLOBAL for ResourceRegionScopeFilter
        /// </summary>
        public static readonly ResourceRegionScopeFilter GLOBAL = new ResourceRegionScopeFilter("GLOBAL");
        /// <summary>
        /// Constant REGIONAL for ResourceRegionScopeFilter
        /// </summary>
        public static readonly ResourceRegionScopeFilter REGIONAL = new ResourceRegionScopeFilter("REGIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceRegionScopeFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceRegionScopeFilter FindValue(string value)
        {
            return FindValue<ResourceRegionScopeFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceRegionScopeFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceShareAssociationStatus.
    /// </summary>
    public class ResourceShareAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ASSOCIATED for ResourceShareAssociationStatus
        /// </summary>
        public static readonly ResourceShareAssociationStatus ASSOCIATED = new ResourceShareAssociationStatus("ASSOCIATED");
        /// <summary>
        /// Constant ASSOCIATING for ResourceShareAssociationStatus
        /// </summary>
        public static readonly ResourceShareAssociationStatus ASSOCIATING = new ResourceShareAssociationStatus("ASSOCIATING");
        /// <summary>
        /// Constant DISASSOCIATED for ResourceShareAssociationStatus
        /// </summary>
        public static readonly ResourceShareAssociationStatus DISASSOCIATED = new ResourceShareAssociationStatus("DISASSOCIATED");
        /// <summary>
        /// Constant DISASSOCIATING for ResourceShareAssociationStatus
        /// </summary>
        public static readonly ResourceShareAssociationStatus DISASSOCIATING = new ResourceShareAssociationStatus("DISASSOCIATING");
        /// <summary>
        /// Constant FAILED for ResourceShareAssociationStatus
        /// </summary>
        public static readonly ResourceShareAssociationStatus FAILED = new ResourceShareAssociationStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceShareAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceShareAssociationStatus FindValue(string value)
        {
            return FindValue<ResourceShareAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceShareAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceShareAssociationType.
    /// </summary>
    public class ResourceShareAssociationType : ConstantClass
    {

        /// <summary>
        /// Constant PRINCIPAL for ResourceShareAssociationType
        /// </summary>
        public static readonly ResourceShareAssociationType PRINCIPAL = new ResourceShareAssociationType("PRINCIPAL");
        /// <summary>
        /// Constant RESOURCE for ResourceShareAssociationType
        /// </summary>
        public static readonly ResourceShareAssociationType RESOURCE = new ResourceShareAssociationType("RESOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceShareAssociationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceShareAssociationType FindValue(string value)
        {
            return FindValue<ResourceShareAssociationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceShareAssociationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceShareFeatureSet.
    /// </summary>
    public class ResourceShareFeatureSet : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_FROM_POLICY for ResourceShareFeatureSet
        /// </summary>
        public static readonly ResourceShareFeatureSet CREATED_FROM_POLICY = new ResourceShareFeatureSet("CREATED_FROM_POLICY");
        /// <summary>
        /// Constant PROMOTING_TO_STANDARD for ResourceShareFeatureSet
        /// </summary>
        public static readonly ResourceShareFeatureSet PROMOTING_TO_STANDARD = new ResourceShareFeatureSet("PROMOTING_TO_STANDARD");
        /// <summary>
        /// Constant STANDARD for ResourceShareFeatureSet
        /// </summary>
        public static readonly ResourceShareFeatureSet STANDARD = new ResourceShareFeatureSet("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceShareFeatureSet(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceShareFeatureSet FindValue(string value)
        {
            return FindValue<ResourceShareFeatureSet>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceShareFeatureSet(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceShareInvitationStatus.
    /// </summary>
    public class ResourceShareInvitationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for ResourceShareInvitationStatus
        /// </summary>
        public static readonly ResourceShareInvitationStatus ACCEPTED = new ResourceShareInvitationStatus("ACCEPTED");
        /// <summary>
        /// Constant EXPIRED for ResourceShareInvitationStatus
        /// </summary>
        public static readonly ResourceShareInvitationStatus EXPIRED = new ResourceShareInvitationStatus("EXPIRED");
        /// <summary>
        /// Constant PENDING for ResourceShareInvitationStatus
        /// </summary>
        public static readonly ResourceShareInvitationStatus PENDING = new ResourceShareInvitationStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for ResourceShareInvitationStatus
        /// </summary>
        public static readonly ResourceShareInvitationStatus REJECTED = new ResourceShareInvitationStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceShareInvitationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceShareInvitationStatus FindValue(string value)
        {
            return FindValue<ResourceShareInvitationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceShareInvitationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceShareStatus.
    /// </summary>
    public class ResourceShareStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ResourceShareStatus
        /// </summary>
        public static readonly ResourceShareStatus ACTIVE = new ResourceShareStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for ResourceShareStatus
        /// </summary>
        public static readonly ResourceShareStatus DELETED = new ResourceShareStatus("DELETED");
        /// <summary>
        /// Constant DELETING for ResourceShareStatus
        /// </summary>
        public static readonly ResourceShareStatus DELETING = new ResourceShareStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ResourceShareStatus
        /// </summary>
        public static readonly ResourceShareStatus FAILED = new ResourceShareStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ResourceShareStatus
        /// </summary>
        public static readonly ResourceShareStatus PENDING = new ResourceShareStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceShareStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceShareStatus FindValue(string value)
        {
            return FindValue<ResourceShareStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceShareStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceStatus.
    /// </summary>
    public class ResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus AVAILABLE = new ResourceStatus("AVAILABLE");
        /// <summary>
        /// Constant LIMIT_EXCEEDED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus LIMIT_EXCEEDED = new ResourceStatus("LIMIT_EXCEEDED");
        /// <summary>
        /// Constant PENDING for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus PENDING = new ResourceStatus("PENDING");
        /// <summary>
        /// Constant UNAVAILABLE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UNAVAILABLE = new ResourceStatus("UNAVAILABLE");
        /// <summary>
        /// Constant ZONAL_RESOURCE_INACCESSIBLE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus ZONAL_RESOURCE_INACCESSIBLE = new ResourceStatus("ZONAL_RESOURCE_INACCESSIBLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceStatus FindValue(string value)
        {
            return FindValue<ResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceStatus(string value)
        {
            return FindValue(value);
        }
    }

}