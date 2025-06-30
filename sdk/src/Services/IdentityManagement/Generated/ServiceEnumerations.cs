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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IdentityManagement
{

    /// <summary>
    /// Constants used for properties of type AccessAdvisorUsageGranularityType.
    /// </summary>
    public class AccessAdvisorUsageGranularityType : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_LEVEL for AccessAdvisorUsageGranularityType
        /// </summary>
        public static readonly AccessAdvisorUsageGranularityType ACTION_LEVEL = new AccessAdvisorUsageGranularityType("ACTION_LEVEL");
        /// <summary>
        /// Constant SERVICE_LEVEL for AccessAdvisorUsageGranularityType
        /// </summary>
        public static readonly AccessAdvisorUsageGranularityType SERVICE_LEVEL = new AccessAdvisorUsageGranularityType("SERVICE_LEVEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessAdvisorUsageGranularityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessAdvisorUsageGranularityType FindValue(string value)
        {
            return FindValue<AccessAdvisorUsageGranularityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessAdvisorUsageGranularityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssertionEncryptionModeType.
    /// </summary>
    public class AssertionEncryptionModeType : ConstantClass
    {

        /// <summary>
        /// Constant Allowed for AssertionEncryptionModeType
        /// </summary>
        public static readonly AssertionEncryptionModeType Allowed = new AssertionEncryptionModeType("Allowed");
        /// <summary>
        /// Constant Required for AssertionEncryptionModeType
        /// </summary>
        public static readonly AssertionEncryptionModeType Required = new AssertionEncryptionModeType("Required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssertionEncryptionModeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssertionEncryptionModeType FindValue(string value)
        {
            return FindValue<AssertionEncryptionModeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssertionEncryptionModeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssignmentStatusType.
    /// </summary>
    public class AssignmentStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Any for AssignmentStatusType
        /// </summary>
        public static readonly AssignmentStatusType Any = new AssignmentStatusType("Any");
        /// <summary>
        /// Constant Assigned for AssignmentStatusType
        /// </summary>
        public static readonly AssignmentStatusType Assigned = new AssignmentStatusType("Assigned");
        /// <summary>
        /// Constant Unassigned for AssignmentStatusType
        /// </summary>
        public static readonly AssignmentStatusType Unassigned = new AssignmentStatusType("Unassigned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssignmentStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssignmentStatusType FindValue(string value)
        {
            return FindValue<AssignmentStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssignmentStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContextKeyTypeEnum.
    /// </summary>
    public class ContextKeyTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant Binary for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum Binary = new ContextKeyTypeEnum("binary");
        /// <summary>
        /// Constant BinaryList for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum BinaryList = new ContextKeyTypeEnum("binaryList");
        /// <summary>
        /// Constant Boolean for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum Boolean = new ContextKeyTypeEnum("boolean");
        /// <summary>
        /// Constant BooleanList for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum BooleanList = new ContextKeyTypeEnum("booleanList");
        /// <summary>
        /// Constant Date for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum Date = new ContextKeyTypeEnum("date");
        /// <summary>
        /// Constant DateList for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum DateList = new ContextKeyTypeEnum("dateList");
        /// <summary>
        /// Constant Ip for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum Ip = new ContextKeyTypeEnum("ip");
        /// <summary>
        /// Constant IpList for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum IpList = new ContextKeyTypeEnum("ipList");
        /// <summary>
        /// Constant Numeric for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum Numeric = new ContextKeyTypeEnum("numeric");
        /// <summary>
        /// Constant NumericList for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum NumericList = new ContextKeyTypeEnum("numericList");
        /// <summary>
        /// Constant String for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum String = new ContextKeyTypeEnum("string");
        /// <summary>
        /// Constant StringList for ContextKeyTypeEnum
        /// </summary>
        public static readonly ContextKeyTypeEnum StringList = new ContextKeyTypeEnum("stringList");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContextKeyTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContextKeyTypeEnum FindValue(string value)
        {
            return FindValue<ContextKeyTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContextKeyTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeletionTaskStatusType.
    /// </summary>
    public class DeletionTaskStatusType : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DeletionTaskStatusType
        /// </summary>
        public static readonly DeletionTaskStatusType FAILED = new DeletionTaskStatusType("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for DeletionTaskStatusType
        /// </summary>
        public static readonly DeletionTaskStatusType IN_PROGRESS = new DeletionTaskStatusType("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for DeletionTaskStatusType
        /// </summary>
        public static readonly DeletionTaskStatusType NOT_STARTED = new DeletionTaskStatusType("NOT_STARTED");
        /// <summary>
        /// Constant SUCCEEDED for DeletionTaskStatusType
        /// </summary>
        public static readonly DeletionTaskStatusType SUCCEEDED = new DeletionTaskStatusType("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeletionTaskStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeletionTaskStatusType FindValue(string value)
        {
            return FindValue<DeletionTaskStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeletionTaskStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncodingType.
    /// </summary>
    public class EncodingType : ConstantClass
    {

        /// <summary>
        /// Constant PEM for EncodingType
        /// </summary>
        public static readonly EncodingType PEM = new EncodingType("PEM");
        /// <summary>
        /// Constant SSH for EncodingType
        /// </summary>
        public static readonly EncodingType SSH = new EncodingType("SSH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncodingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncodingType FindValue(string value)
        {
            return FindValue<EncodingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncodingType(string value)
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
        /// Constant AWSManagedPolicy for EntityType
        /// </summary>
        public static readonly EntityType AWSManagedPolicy = new EntityType("AWSManagedPolicy");
        /// <summary>
        /// Constant Group for EntityType
        /// </summary>
        public static readonly EntityType Group = new EntityType("Group");
        /// <summary>
        /// Constant LocalManagedPolicy for EntityType
        /// </summary>
        public static readonly EntityType LocalManagedPolicy = new EntityType("LocalManagedPolicy");
        /// <summary>
        /// Constant Role for EntityType
        /// </summary>
        public static readonly EntityType Role = new EntityType("Role");
        /// <summary>
        /// Constant User for EntityType
        /// </summary>
        public static readonly EntityType User = new EntityType("User");

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
    /// Constants used for properties of type FeatureType.
    /// </summary>
    public class FeatureType : ConstantClass
    {

        /// <summary>
        /// Constant RootCredentialsManagement for FeatureType
        /// </summary>
        public static readonly FeatureType RootCredentialsManagement = new FeatureType("RootCredentialsManagement");
        /// <summary>
        /// Constant RootSessions for FeatureType
        /// </summary>
        public static readonly FeatureType RootSessions = new FeatureType("RootSessions");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureType FindValue(string value)
        {
            return FindValue<FeatureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlobalEndpointTokenVersion.
    /// </summary>
    public class GlobalEndpointTokenVersion : ConstantClass
    {

        /// <summary>
        /// Constant V1Token for GlobalEndpointTokenVersion
        /// </summary>
        public static readonly GlobalEndpointTokenVersion V1Token = new GlobalEndpointTokenVersion("v1Token");
        /// <summary>
        /// Constant V2Token for GlobalEndpointTokenVersion
        /// </summary>
        public static readonly GlobalEndpointTokenVersion V2Token = new GlobalEndpointTokenVersion("v2Token");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlobalEndpointTokenVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlobalEndpointTokenVersion FindValue(string value)
        {
            return FindValue<GlobalEndpointTokenVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlobalEndpointTokenVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatusType.
    /// </summary>
    public class JobStatusType : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for JobStatusType
        /// </summary>
        public static readonly JobStatusType COMPLETED = new JobStatusType("COMPLETED");
        /// <summary>
        /// Constant FAILED for JobStatusType
        /// </summary>
        public static readonly JobStatusType FAILED = new JobStatusType("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobStatusType
        /// </summary>
        public static readonly JobStatusType IN_PROGRESS = new JobStatusType("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatusType FindValue(string value)
        {
            return FindValue<JobStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionsBoundaryAttachmentType.
    /// </summary>
    public class PermissionsBoundaryAttachmentType : ConstantClass
    {

        /// <summary>
        /// Constant PermissionsBoundaryPolicy for PermissionsBoundaryAttachmentType
        /// </summary>
        public static readonly PermissionsBoundaryAttachmentType PermissionsBoundaryPolicy = new PermissionsBoundaryAttachmentType("PermissionsBoundaryPolicy");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionsBoundaryAttachmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionsBoundaryAttachmentType FindValue(string value)
        {
            return FindValue<PermissionsBoundaryAttachmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionsBoundaryAttachmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyEvaluationDecisionType.
    /// </summary>
    public class PolicyEvaluationDecisionType : ConstantClass
    {

        /// <summary>
        /// Constant Allowed for PolicyEvaluationDecisionType
        /// </summary>
        public static readonly PolicyEvaluationDecisionType Allowed = new PolicyEvaluationDecisionType("allowed");
        /// <summary>
        /// Constant ExplicitDeny for PolicyEvaluationDecisionType
        /// </summary>
        public static readonly PolicyEvaluationDecisionType ExplicitDeny = new PolicyEvaluationDecisionType("explicitDeny");
        /// <summary>
        /// Constant ImplicitDeny for PolicyEvaluationDecisionType
        /// </summary>
        public static readonly PolicyEvaluationDecisionType ImplicitDeny = new PolicyEvaluationDecisionType("implicitDeny");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyEvaluationDecisionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyEvaluationDecisionType FindValue(string value)
        {
            return FindValue<PolicyEvaluationDecisionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyEvaluationDecisionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyOwnerEntityType.
    /// </summary>
    public class PolicyOwnerEntityType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for PolicyOwnerEntityType
        /// </summary>
        public static readonly PolicyOwnerEntityType GROUP = new PolicyOwnerEntityType("GROUP");
        /// <summary>
        /// Constant ROLE for PolicyOwnerEntityType
        /// </summary>
        public static readonly PolicyOwnerEntityType ROLE = new PolicyOwnerEntityType("ROLE");
        /// <summary>
        /// Constant USER for PolicyOwnerEntityType
        /// </summary>
        public static readonly PolicyOwnerEntityType USER = new PolicyOwnerEntityType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyOwnerEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyOwnerEntityType FindValue(string value)
        {
            return FindValue<PolicyOwnerEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyOwnerEntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyScopeType.
    /// </summary>
    public class PolicyScopeType : ConstantClass
    {

        /// <summary>
        /// Constant All for PolicyScopeType
        /// </summary>
        public static readonly PolicyScopeType All = new PolicyScopeType("All");
        /// <summary>
        /// Constant AWS for PolicyScopeType
        /// </summary>
        public static readonly PolicyScopeType AWS = new PolicyScopeType("AWS");
        /// <summary>
        /// Constant Local for PolicyScopeType
        /// </summary>
        public static readonly PolicyScopeType Local = new PolicyScopeType("Local");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyScopeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyScopeType FindValue(string value)
        {
            return FindValue<PolicyScopeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyScopeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicySourceType.
    /// </summary>
    public class PolicySourceType : ConstantClass
    {

        /// <summary>
        /// Constant AwsManaged for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType AwsManaged = new PolicySourceType("aws-managed");
        /// <summary>
        /// Constant Group for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType Group = new PolicySourceType("group");
        /// <summary>
        /// Constant None for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType None = new PolicySourceType("none");
        /// <summary>
        /// Constant Resource for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType Resource = new PolicySourceType("resource");
        /// <summary>
        /// Constant Role for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType Role = new PolicySourceType("role");
        /// <summary>
        /// Constant User for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType User = new PolicySourceType("user");
        /// <summary>
        /// Constant UserManaged for PolicySourceType
        /// </summary>
        public static readonly PolicySourceType UserManaged = new PolicySourceType("user-managed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicySourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicySourceType FindValue(string value)
        {
            return FindValue<PolicySourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicySourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyType.
    /// </summary>
    public class PolicyType : ConstantClass
    {

        /// <summary>
        /// Constant INLINE for PolicyType
        /// </summary>
        public static readonly PolicyType INLINE = new PolicyType("INLINE");
        /// <summary>
        /// Constant MANAGED for PolicyType
        /// </summary>
        public static readonly PolicyType MANAGED = new PolicyType("MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyType FindValue(string value)
        {
            return FindValue<PolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyUsageType.
    /// </summary>
    public class PolicyUsageType : ConstantClass
    {

        /// <summary>
        /// Constant PermissionsBoundary for PolicyUsageType
        /// </summary>
        public static readonly PolicyUsageType PermissionsBoundary = new PolicyUsageType("PermissionsBoundary");
        /// <summary>
        /// Constant PermissionsPolicy for PolicyUsageType
        /// </summary>
        public static readonly PolicyUsageType PermissionsPolicy = new PolicyUsageType("PermissionsPolicy");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyUsageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyUsageType FindValue(string value)
        {
            return FindValue<PolicyUsageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyUsageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportFormatType.
    /// </summary>
    public class ReportFormatType : ConstantClass
    {

        /// <summary>
        /// Constant TextCsv for ReportFormatType
        /// </summary>
        public static readonly ReportFormatType TextCsv = new ReportFormatType("text/csv");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportFormatType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportFormatType FindValue(string value)
        {
            return FindValue<ReportFormatType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportFormatType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportStateType.
    /// </summary>
    public class ReportStateType : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ReportStateType
        /// </summary>
        public static readonly ReportStateType COMPLETE = new ReportStateType("COMPLETE");
        /// <summary>
        /// Constant INPROGRESS for ReportStateType
        /// </summary>
        public static readonly ReportStateType INPROGRESS = new ReportStateType("INPROGRESS");
        /// <summary>
        /// Constant STARTED for ReportStateType
        /// </summary>
        public static readonly ReportStateType STARTED = new ReportStateType("STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportStateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportStateType FindValue(string value)
        {
            return FindValue<ReportStateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportStateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortKeyType.
    /// </summary>
    public class SortKeyType : ConstantClass
    {

        /// <summary>
        /// Constant LAST_AUTHENTICATED_TIME_ASCENDING for SortKeyType
        /// </summary>
        public static readonly SortKeyType LAST_AUTHENTICATED_TIME_ASCENDING = new SortKeyType("LAST_AUTHENTICATED_TIME_ASCENDING");
        /// <summary>
        /// Constant LAST_AUTHENTICATED_TIME_DESCENDING for SortKeyType
        /// </summary>
        public static readonly SortKeyType LAST_AUTHENTICATED_TIME_DESCENDING = new SortKeyType("LAST_AUTHENTICATED_TIME_DESCENDING");
        /// <summary>
        /// Constant SERVICE_NAMESPACE_ASCENDING for SortKeyType
        /// </summary>
        public static readonly SortKeyType SERVICE_NAMESPACE_ASCENDING = new SortKeyType("SERVICE_NAMESPACE_ASCENDING");
        /// <summary>
        /// Constant SERVICE_NAMESPACE_DESCENDING for SortKeyType
        /// </summary>
        public static readonly SortKeyType SERVICE_NAMESPACE_DESCENDING = new SortKeyType("SERVICE_NAMESPACE_DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortKeyType FindValue(string value)
        {
            return FindValue<SortKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortKeyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusType.
    /// </summary>
    public class StatusType : ConstantClass
    {

        /// <summary>
        /// Constant Active for StatusType
        /// </summary>
        public static readonly StatusType Active = new StatusType("Active");
        /// <summary>
        /// Constant Expired for StatusType
        /// </summary>
        public static readonly StatusType Expired = new StatusType("Expired");
        /// <summary>
        /// Constant Inactive for StatusType
        /// </summary>
        public static readonly StatusType Inactive = new StatusType("Inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusType FindValue(string value)
        {
            return FindValue<StatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SummaryKeyType.
    /// </summary>
    public class SummaryKeyType : ConstantClass
    {

        /// <summary>
        /// Constant AccessKeysPerUserQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccessKeysPerUserQuota = new SummaryKeyType("AccessKeysPerUserQuota");
        /// <summary>
        /// Constant AccountAccessKeysPresent for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccountAccessKeysPresent = new SummaryKeyType("AccountAccessKeysPresent");
        /// <summary>
        /// Constant AccountMFAEnabled for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccountMFAEnabled = new SummaryKeyType("AccountMFAEnabled");
        /// <summary>
        /// Constant AccountPasswordPresent for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccountPasswordPresent = new SummaryKeyType("AccountPasswordPresent");
        /// <summary>
        /// Constant AccountSigningCertificatesPresent for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccountSigningCertificatesPresent = new SummaryKeyType("AccountSigningCertificatesPresent");
        /// <summary>
        /// Constant AttachedPoliciesPerGroupQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AttachedPoliciesPerGroupQuota = new SummaryKeyType("AttachedPoliciesPerGroupQuota");
        /// <summary>
        /// Constant AttachedPoliciesPerRoleQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AttachedPoliciesPerRoleQuota = new SummaryKeyType("AttachedPoliciesPerRoleQuota");
        /// <summary>
        /// Constant AttachedPoliciesPerUserQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AttachedPoliciesPerUserQuota = new SummaryKeyType("AttachedPoliciesPerUserQuota");
        /// <summary>
        /// Constant GlobalEndpointTokenVersion for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType GlobalEndpointTokenVersion = new SummaryKeyType("GlobalEndpointTokenVersion");
        /// <summary>
        /// Constant GroupPolicySizeQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType GroupPolicySizeQuota = new SummaryKeyType("GroupPolicySizeQuota");
        /// <summary>
        /// Constant Groups for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType Groups = new SummaryKeyType("Groups");
        /// <summary>
        /// Constant GroupsPerUserQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType GroupsPerUserQuota = new SummaryKeyType("GroupsPerUserQuota");
        /// <summary>
        /// Constant GroupsQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType GroupsQuota = new SummaryKeyType("GroupsQuota");
        /// <summary>
        /// Constant MFADevices for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType MFADevices = new SummaryKeyType("MFADevices");
        /// <summary>
        /// Constant MFADevicesInUse for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType MFADevicesInUse = new SummaryKeyType("MFADevicesInUse");
        /// <summary>
        /// Constant Policies for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType Policies = new SummaryKeyType("Policies");
        /// <summary>
        /// Constant PoliciesQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType PoliciesQuota = new SummaryKeyType("PoliciesQuota");
        /// <summary>
        /// Constant PolicySizeQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType PolicySizeQuota = new SummaryKeyType("PolicySizeQuota");
        /// <summary>
        /// Constant PolicyVersionsInUse for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType PolicyVersionsInUse = new SummaryKeyType("PolicyVersionsInUse");
        /// <summary>
        /// Constant PolicyVersionsInUseQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType PolicyVersionsInUseQuota = new SummaryKeyType("PolicyVersionsInUseQuota");
        /// <summary>
        /// Constant ServerCertificates for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType ServerCertificates = new SummaryKeyType("ServerCertificates");
        /// <summary>
        /// Constant ServerCertificatesQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType ServerCertificatesQuota = new SummaryKeyType("ServerCertificatesQuota");
        /// <summary>
        /// Constant SigningCertificatesPerUserQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType SigningCertificatesPerUserQuota = new SummaryKeyType("SigningCertificatesPerUserQuota");
        /// <summary>
        /// Constant UserPolicySizeQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType UserPolicySizeQuota = new SummaryKeyType("UserPolicySizeQuota");
        /// <summary>
        /// Constant Users for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType Users = new SummaryKeyType("Users");
        /// <summary>
        /// Constant UsersQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType UsersQuota = new SummaryKeyType("UsersQuota");
        /// <summary>
        /// Constant VersionsPerPolicyQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType VersionsPerPolicyQuota = new SummaryKeyType("VersionsPerPolicyQuota");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SummaryKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SummaryKeyType FindValue(string value)
        {
            return FindValue<SummaryKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SummaryKeyType(string value)
        {
            return FindValue(value);
        }
    }

}