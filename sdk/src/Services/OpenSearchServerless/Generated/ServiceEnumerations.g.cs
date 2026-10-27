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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.OpenSearchServerless
{
    /// <summary>
    /// Constants used for properties of type AccessPolicyType.
    /// </summary>
    public class AccessPolicyType : ConstantClass
    {
        /// <summary>
        /// Constant Data for AccessPolicyType
        /// </summary>
        public static readonly AccessPolicyType Data = new AccessPolicyType("data");

        /// <summary>
        /// Constructs a custom AccessPolicyType for a value not among the defined constants.
        /// </summary>
        public AccessPolicyType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessPolicyType FindValue(string value)
        {
            return FindValue<AccessPolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessPolicyType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AutoscalingStatus.
    /// </summary>
    public class AutoscalingStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTION_SCALING_DOWN for AutoscalingStatus
        /// </summary>
        public static readonly AutoscalingStatus ACTION_SCALING_DOWN = new AutoscalingStatus("ACTION_SCALING_DOWN");

        /// <summary>
        /// Constant ACTION_SCALING_UP for AutoscalingStatus
        /// </summary>
        public static readonly AutoscalingStatus ACTION_SCALING_UP = new AutoscalingStatus("ACTION_SCALING_UP");

        /// <summary>
        /// Constant NO_ACTION for AutoscalingStatus
        /// </summary>
        public static readonly AutoscalingStatus NO_ACTION = new AutoscalingStatus("NO_ACTION");

        /// <summary>
        /// Constructs a custom AutoscalingStatus for a value not among the defined constants.
        /// </summary>
        public AutoscalingStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoscalingStatus FindValue(string value)
        {
            return FindValue<AutoscalingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoscalingStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CollectionStatus.
    /// </summary>
    public class CollectionStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for CollectionStatus
        /// </summary>
        public static readonly CollectionStatus ACTIVE = new CollectionStatus("ACTIVE");

        /// <summary>
        /// Constant CREATING for CollectionStatus
        /// </summary>
        public static readonly CollectionStatus CREATING = new CollectionStatus("CREATING");

        /// <summary>
        /// Constant DELETING for CollectionStatus
        /// </summary>
        public static readonly CollectionStatus DELETING = new CollectionStatus("DELETING");

        /// <summary>
        /// Constant FAILED for CollectionStatus
        /// </summary>
        public static readonly CollectionStatus FAILED = new CollectionStatus("FAILED");

        /// <summary>
        /// Constant UPDATE_FAILED for CollectionStatus
        /// </summary>
        public static readonly CollectionStatus UPDATE_FAILED = new CollectionStatus("UPDATE_FAILED");

        /// <summary>
        /// Constant UPDATING for CollectionStatus
        /// </summary>
        public static readonly CollectionStatus UPDATING = new CollectionStatus("UPDATING");

        /// <summary>
        /// Constructs a custom CollectionStatus for a value not among the defined constants.
        /// </summary>
        public CollectionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CollectionStatus FindValue(string value)
        {
            return FindValue<CollectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CollectionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CollectionType.
    /// </summary>
    public class CollectionType : ConstantClass
    {
        /// <summary>
        /// Constant SEARCH for CollectionType
        /// </summary>
        public static readonly CollectionType SEARCH = new CollectionType("SEARCH");

        /// <summary>
        /// Constant TIMESERIES for CollectionType
        /// </summary>
        public static readonly CollectionType TIMESERIES = new CollectionType("TIMESERIES");

        /// <summary>
        /// Constant VECTORSEARCH for CollectionType
        /// </summary>
        public static readonly CollectionType VECTORSEARCH = new CollectionType("VECTORSEARCH");

        /// <summary>
        /// Constructs a custom CollectionType for a value not among the defined constants.
        /// </summary>
        public CollectionType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CollectionType FindValue(string value)
        {
            return FindValue<CollectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CollectionType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DeletionProtection.
    /// </summary>
    public class DeletionProtection : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for DeletionProtection
        /// </summary>
        public static readonly DeletionProtection DISABLED = new DeletionProtection("DISABLED");

        /// <summary>
        /// Constant ENABLED for DeletionProtection
        /// </summary>
        public static readonly DeletionProtection ENABLED = new DeletionProtection("ENABLED");

        /// <summary>
        /// Constructs a custom DeletionProtection for a value not among the defined constants.
        /// </summary>
        public DeletionProtection(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeletionProtection FindValue(string value)
        {
            return FindValue<DeletionProtection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeletionProtection(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IamIdentityCenterGroupAttribute.
    /// </summary>
    public class IamIdentityCenterGroupAttribute : ConstantClass
    {
        /// <summary>
        /// Constant GroupId for IamIdentityCenterGroupAttribute
        /// </summary>
        public static readonly IamIdentityCenterGroupAttribute GroupId = new IamIdentityCenterGroupAttribute("GroupId");

        /// <summary>
        /// Constant GroupName for IamIdentityCenterGroupAttribute
        /// </summary>
        public static readonly IamIdentityCenterGroupAttribute GroupName = new IamIdentityCenterGroupAttribute("GroupName");

        /// <summary>
        /// Constructs a custom IamIdentityCenterGroupAttribute for a value not among the defined constants.
        /// </summary>
        public IamIdentityCenterGroupAttribute(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IamIdentityCenterGroupAttribute FindValue(string value)
        {
            return FindValue<IamIdentityCenterGroupAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IamIdentityCenterGroupAttribute(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IamIdentityCenterUserAttribute.
    /// </summary>
    public class IamIdentityCenterUserAttribute : ConstantClass
    {
        /// <summary>
        /// Constant Email for IamIdentityCenterUserAttribute
        /// </summary>
        public static readonly IamIdentityCenterUserAttribute Email = new IamIdentityCenterUserAttribute("Email");

        /// <summary>
        /// Constant UserId for IamIdentityCenterUserAttribute
        /// </summary>
        public static readonly IamIdentityCenterUserAttribute UserId = new IamIdentityCenterUserAttribute("UserId");

        /// <summary>
        /// Constant UserName for IamIdentityCenterUserAttribute
        /// </summary>
        public static readonly IamIdentityCenterUserAttribute UserName = new IamIdentityCenterUserAttribute("UserName");

        /// <summary>
        /// Constructs a custom IamIdentityCenterUserAttribute for a value not among the defined constants.
        /// </summary>
        public IamIdentityCenterUserAttribute(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IamIdentityCenterUserAttribute FindValue(string value)
        {
            return FindValue<IamIdentityCenterUserAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IamIdentityCenterUserAttribute(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IngestionAlertCode.
    /// </summary>
    public class IngestionAlertCode : ConstantClass
    {
        /// <summary>
        /// Constant DESTINATION_ACCESS_DENIED for IngestionAlertCode
        /// </summary>
        public static readonly IngestionAlertCode DESTINATION_ACCESS_DENIED = new IngestionAlertCode("DESTINATION_ACCESS_DENIED");

        /// <summary>
        /// Constant DESTINATION_RESOURCE_NOT_FOUND for IngestionAlertCode
        /// </summary>
        public static readonly IngestionAlertCode DESTINATION_RESOURCE_NOT_FOUND = new IngestionAlertCode("DESTINATION_RESOURCE_NOT_FOUND");

        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for IngestionAlertCode
        /// </summary>
        public static readonly IngestionAlertCode INTERNAL_SERVER_ERROR = new IngestionAlertCode("INTERNAL_SERVER_ERROR");

        /// <summary>
        /// Constant SOURCE_ACCESS_DENIED for IngestionAlertCode
        /// </summary>
        public static readonly IngestionAlertCode SOURCE_ACCESS_DENIED = new IngestionAlertCode("SOURCE_ACCESS_DENIED");

        /// <summary>
        /// Constant SOURCE_RESOURCE_NOT_FOUND for IngestionAlertCode
        /// </summary>
        public static readonly IngestionAlertCode SOURCE_RESOURCE_NOT_FOUND = new IngestionAlertCode("SOURCE_RESOURCE_NOT_FOUND");

        /// <summary>
        /// Constructs a custom IngestionAlertCode for a value not among the defined constants.
        /// </summary>
        public IngestionAlertCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionAlertCode FindValue(string value)
        {
            return FindValue<IngestionAlertCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionAlertCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IngestionFailureCode.
    /// </summary>
    public class IngestionFailureCode : ConstantClass
    {
        /// <summary>
        /// Constant DESTINATION_ACCESS_DENIED for IngestionFailureCode
        /// </summary>
        public static readonly IngestionFailureCode DESTINATION_ACCESS_DENIED = new IngestionFailureCode("DESTINATION_ACCESS_DENIED");

        /// <summary>
        /// Constant DESTINATION_RESOURCE_NOT_FOUND for IngestionFailureCode
        /// </summary>
        public static readonly IngestionFailureCode DESTINATION_RESOURCE_NOT_FOUND = new IngestionFailureCode("DESTINATION_RESOURCE_NOT_FOUND");

        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for IngestionFailureCode
        /// </summary>
        public static readonly IngestionFailureCode INTERNAL_SERVER_ERROR = new IngestionFailureCode("INTERNAL_SERVER_ERROR");

        /// <summary>
        /// Constant SOURCE_ACCESS_DENIED for IngestionFailureCode
        /// </summary>
        public static readonly IngestionFailureCode SOURCE_ACCESS_DENIED = new IngestionFailureCode("SOURCE_ACCESS_DENIED");

        /// <summary>
        /// Constant SOURCE_RESOURCE_NOT_FOUND for IngestionFailureCode
        /// </summary>
        public static readonly IngestionFailureCode SOURCE_RESOURCE_NOT_FOUND = new IngestionFailureCode("SOURCE_RESOURCE_NOT_FOUND");

        /// <summary>
        /// Constructs a custom IngestionFailureCode for a value not among the defined constants.
        /// </summary>
        public IngestionFailureCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionFailureCode FindValue(string value)
        {
            return FindValue<IngestionFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionFailureCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IngestionJobStatus.
    /// </summary>
    public class IngestionJobStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus ACTIVE = new IngestionJobStatus("ACTIVE");

        /// <summary>
        /// Constant CANCELLED for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus CANCELLED = new IngestionJobStatus("CANCELLED");

        /// <summary>
        /// Constant CANCELLING for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus CANCELLING = new IngestionJobStatus("CANCELLING");

        /// <summary>
        /// Constant CANCEL_FAILED for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus CANCEL_FAILED = new IngestionJobStatus("CANCEL_FAILED");

        /// <summary>
        /// Constant COMPLETED for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus COMPLETED = new IngestionJobStatus("COMPLETED");

        /// <summary>
        /// Constant CREATE_FAILED for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus CREATE_FAILED = new IngestionJobStatus("CREATE_FAILED");

        /// <summary>
        /// Constant CREATING for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus CREATING = new IngestionJobStatus("CREATING");

        /// <summary>
        /// Constant FAILED for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus FAILED = new IngestionJobStatus("FAILED");

        /// <summary>
        /// Constructs a custom IngestionJobStatus for a value not among the defined constants.
        /// </summary>
        public IngestionJobStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionJobStatus FindValue(string value)
        {
            return FindValue<IngestionJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionJobStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IngestionState.
    /// </summary>
    public class IngestionState : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for IngestionState
        /// </summary>
        public static readonly IngestionState FAILED = new IngestionState("FAILED");

        /// <summary>
        /// Constant INGESTION_COMPLETE for IngestionState
        /// </summary>
        public static readonly IngestionState INGESTION_COMPLETE = new IngestionState("INGESTION_COMPLETE");

        /// <summary>
        /// Constant INGESTION_IN_PROGRESS for IngestionState
        /// </summary>
        public static readonly IngestionState INGESTION_IN_PROGRESS = new IngestionState("INGESTION_IN_PROGRESS");

        /// <summary>
        /// Constant SCANNING for IngestionState
        /// </summary>
        public static readonly IngestionState SCANNING = new IngestionState("SCANNING");

        /// <summary>
        /// Constant STARTING for IngestionState
        /// </summary>
        public static readonly IngestionState STARTING = new IngestionState("STARTING");

        /// <summary>
        /// Constant STOPPED for IngestionState
        /// </summary>
        public static readonly IngestionState STOPPED = new IngestionState("STOPPED");

        /// <summary>
        /// Constructs a custom IngestionState for a value not among the defined constants.
        /// </summary>
        public IngestionState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionState FindValue(string value)
        {
            return FindValue<IngestionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IngestionStreamStatus.
    /// </summary>
    public class IngestionStreamStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for IngestionStreamStatus
        /// </summary>
        public static readonly IngestionStreamStatus ACTIVE = new IngestionStreamStatus("ACTIVE");

        /// <summary>
        /// Constant CREATE_FAILED for IngestionStreamStatus
        /// </summary>
        public static readonly IngestionStreamStatus CREATE_FAILED = new IngestionStreamStatus("CREATE_FAILED");

        /// <summary>
        /// Constant CREATING for IngestionStreamStatus
        /// </summary>
        public static readonly IngestionStreamStatus CREATING = new IngestionStreamStatus("CREATING");

        /// <summary>
        /// Constant DELETED for IngestionStreamStatus
        /// </summary>
        public static readonly IngestionStreamStatus DELETED = new IngestionStreamStatus("DELETED");

        /// <summary>
        /// Constant DELETE_FAILED for IngestionStreamStatus
        /// </summary>
        public static readonly IngestionStreamStatus DELETE_FAILED = new IngestionStreamStatus("DELETE_FAILED");

        /// <summary>
        /// Constant DELETING for IngestionStreamStatus
        /// </summary>
        public static readonly IngestionStreamStatus DELETING = new IngestionStreamStatus("DELETING");

        /// <summary>
        /// Constructs a custom IngestionStreamStatus for a value not among the defined constants.
        /// </summary>
        public IngestionStreamStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionStreamStatus FindValue(string value)
        {
            return FindValue<IngestionStreamStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionStreamStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type InitialScan.
    /// </summary>
    public class InitialScan : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for InitialScan
        /// </summary>
        public static readonly InitialScan DISABLED = new InitialScan("DISABLED");

        /// <summary>
        /// Constant ENABLED for InitialScan
        /// </summary>
        public static readonly InitialScan ENABLED = new InitialScan("ENABLED");

        /// <summary>
        /// Constructs a custom InitialScan for a value not among the defined constants.
        /// </summary>
        public InitialScan(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InitialScan FindValue(string value)
        {
            return FindValue<InitialScan>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InitialScan(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LifecyclePolicyType.
    /// </summary>
    public class LifecyclePolicyType : ConstantClass
    {
        /// <summary>
        /// Constant Retention for LifecyclePolicyType
        /// </summary>
        public static readonly LifecyclePolicyType Retention = new LifecyclePolicyType("retention");

        /// <summary>
        /// Constructs a custom LifecyclePolicyType for a value not among the defined constants.
        /// </summary>
        public LifecyclePolicyType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecyclePolicyType FindValue(string value)
        {
            return FindValue<LifecyclePolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecyclePolicyType(string value)
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
        /// Constant Index for ResourceType
        /// </summary>
        public static readonly ResourceType Index = new ResourceType("index");

        /// <summary>
        /// Constructs a custom ResourceType for a value not among the defined constants.
        /// </summary>
        public ResourceType(string value) : base(value) { }

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
    /// Constants used for properties of type SecurityConfigType.
    /// </summary>
    public class SecurityConfigType : ConstantClass
    {
        /// <summary>
        /// Constant Iamfederation for SecurityConfigType
        /// </summary>
        public static readonly SecurityConfigType Iamfederation = new SecurityConfigType("iamfederation");

        /// <summary>
        /// Constant Iamidentitycenter for SecurityConfigType
        /// </summary>
        public static readonly SecurityConfigType Iamidentitycenter = new SecurityConfigType("iamidentitycenter");

        /// <summary>
        /// Constant Saml for SecurityConfigType
        /// </summary>
        public static readonly SecurityConfigType Saml = new SecurityConfigType("saml");

        /// <summary>
        /// Constructs a custom SecurityConfigType for a value not among the defined constants.
        /// </summary>
        public SecurityConfigType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityConfigType FindValue(string value)
        {
            return FindValue<SecurityConfigType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityConfigType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SecurityPolicyType.
    /// </summary>
    public class SecurityPolicyType : ConstantClass
    {
        /// <summary>
        /// Constant Encryption for SecurityPolicyType
        /// </summary>
        public static readonly SecurityPolicyType Encryption = new SecurityPolicyType("encryption");

        /// <summary>
        /// Constant Network for SecurityPolicyType
        /// </summary>
        public static readonly SecurityPolicyType Network = new SecurityPolicyType("network");

        /// <summary>
        /// Constructs a custom SecurityPolicyType for a value not among the defined constants.
        /// </summary>
        public SecurityPolicyType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityPolicyType FindValue(string value)
        {
            return FindValue<SecurityPolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityPolicyType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ServerlessGeneration.
    /// </summary>
    public class ServerlessGeneration : ConstantClass
    {
        /// <summary>
        /// Constant CLASSIC for ServerlessGeneration
        /// </summary>
        public static readonly ServerlessGeneration CLASSIC = new ServerlessGeneration("CLASSIC");

        /// <summary>
        /// Constant NEXTGEN for ServerlessGeneration
        /// </summary>
        public static readonly ServerlessGeneration NEXTGEN = new ServerlessGeneration("NEXTGEN");

        /// <summary>
        /// Constructs a custom ServerlessGeneration for a value not among the defined constants.
        /// </summary>
        public ServerlessGeneration(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerlessGeneration FindValue(string value)
        {
            return FindValue<ServerlessGeneration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerlessGeneration(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ServerlessVectorAccelerationStatus.
    /// </summary>
    public class ServerlessVectorAccelerationStatus : ConstantClass
    {
        /// <summary>
        /// Constant ALLOWED for ServerlessVectorAccelerationStatus
        /// </summary>
        public static readonly ServerlessVectorAccelerationStatus ALLOWED = new ServerlessVectorAccelerationStatus("ALLOWED");

        /// <summary>
        /// Constant DISABLED for ServerlessVectorAccelerationStatus
        /// </summary>
        public static readonly ServerlessVectorAccelerationStatus DISABLED = new ServerlessVectorAccelerationStatus("DISABLED");

        /// <summary>
        /// Constant ENABLED for ServerlessVectorAccelerationStatus
        /// </summary>
        public static readonly ServerlessVectorAccelerationStatus ENABLED = new ServerlessVectorAccelerationStatus("ENABLED");

        /// <summary>
        /// Constructs a custom ServerlessVectorAccelerationStatus for a value not among the defined constants.
        /// </summary>
        public ServerlessVectorAccelerationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerlessVectorAccelerationStatus FindValue(string value)
        {
            return FindValue<ServerlessVectorAccelerationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerlessVectorAccelerationStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type StandbyReplicas.
    /// </summary>
    public class StandbyReplicas : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for StandbyReplicas
        /// </summary>
        public static readonly StandbyReplicas DISABLED = new StandbyReplicas("DISABLED");

        /// <summary>
        /// Constant ENABLED for StandbyReplicas
        /// </summary>
        public static readonly StandbyReplicas ENABLED = new StandbyReplicas("ENABLED");

        /// <summary>
        /// Constructs a custom StandbyReplicas for a value not among the defined constants.
        /// </summary>
        public StandbyReplicas(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandbyReplicas FindValue(string value)
        {
            return FindValue<StandbyReplicas>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StandbyReplicas(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type VpcEndpointStatus.
    /// </summary>
    public class VpcEndpointStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus ACTIVE = new VpcEndpointStatus("ACTIVE");

        /// <summary>
        /// Constant DELETING for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus DELETING = new VpcEndpointStatus("DELETING");

        /// <summary>
        /// Constant FAILED for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus FAILED = new VpcEndpointStatus("FAILED");

        /// <summary>
        /// Constant PENDING for VpcEndpointStatus
        /// </summary>
        public static readonly VpcEndpointStatus PENDING = new VpcEndpointStatus("PENDING");

        /// <summary>
        /// Constructs a custom VpcEndpointStatus for a value not among the defined constants.
        /// </summary>
        public VpcEndpointStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcEndpointStatus FindValue(string value)
        {
            return FindValue<VpcEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }
}
