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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.EKS
{

    /// <summary>
    /// Constants used for properties of type AddonIssueCode.
    /// </summary>
    public class AddonIssueCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode AccessDenied = new AddonIssueCode("AccessDenied");
        /// <summary>
        /// Constant ClusterUnreachable for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode ClusterUnreachable = new AddonIssueCode("ClusterUnreachable");
        /// <summary>
        /// Constant ConfigurationConflict for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode ConfigurationConflict = new AddonIssueCode("ConfigurationConflict");
        /// <summary>
        /// Constant InsufficientNumberOfReplicas for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode InsufficientNumberOfReplicas = new AddonIssueCode("InsufficientNumberOfReplicas");
        /// <summary>
        /// Constant InternalFailure for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode InternalFailure = new AddonIssueCode("InternalFailure");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AddonIssueCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AddonIssueCode FindValue(string value)
        {
            return FindValue<AddonIssueCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AddonIssueCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AddonStatus.
    /// </summary>
    public class AddonStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AddonStatus
        /// </summary>
        public static readonly AddonStatus ACTIVE = new AddonStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for AddonStatus
        /// </summary>
        public static readonly AddonStatus CREATE_FAILED = new AddonStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for AddonStatus
        /// </summary>
        public static readonly AddonStatus CREATING = new AddonStatus("CREATING");
        /// <summary>
        /// Constant DEGRADED for AddonStatus
        /// </summary>
        public static readonly AddonStatus DEGRADED = new AddonStatus("DEGRADED");
        /// <summary>
        /// Constant DELETE_FAILED for AddonStatus
        /// </summary>
        public static readonly AddonStatus DELETE_FAILED = new AddonStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for AddonStatus
        /// </summary>
        public static readonly AddonStatus DELETING = new AddonStatus("DELETING");
        /// <summary>
        /// Constant UPDATING for AddonStatus
        /// </summary>
        public static readonly AddonStatus UPDATING = new AddonStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AddonStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AddonStatus FindValue(string value)
        {
            return FindValue<AddonStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AddonStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AMITypes.
    /// </summary>
    public class AMITypes : ConstantClass
    {

        /// <summary>
        /// Constant AL2_ARM_64 for AMITypes
        /// </summary>
        public static readonly AMITypes AL2_ARM_64 = new AMITypes("AL2_ARM_64");
        /// <summary>
        /// Constant AL2_x86_64 for AMITypes
        /// </summary>
        public static readonly AMITypes AL2_x86_64 = new AMITypes("AL2_x86_64");
        /// <summary>
        /// Constant AL2_x86_64_GPU for AMITypes
        /// </summary>
        public static readonly AMITypes AL2_x86_64_GPU = new AMITypes("AL2_x86_64_GPU");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AMITypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AMITypes FindValue(string value)
        {
            return FindValue<AMITypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AMITypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityTypes.
    /// </summary>
    public class CapacityTypes : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for CapacityTypes
        /// </summary>
        public static readonly CapacityTypes ON_DEMAND = new CapacityTypes("ON_DEMAND");
        /// <summary>
        /// Constant SPOT for CapacityTypes
        /// </summary>
        public static readonly CapacityTypes SPOT = new CapacityTypes("SPOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityTypes FindValue(string value)
        {
            return FindValue<CapacityTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterStatus.
    /// </summary>
    public class ClusterStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus ACTIVE = new ClusterStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus CREATING = new ClusterStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus DELETING = new ClusterStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus FAILED = new ClusterStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus UPDATING = new ClusterStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterStatus FindValue(string value)
        {
            return FindValue<ClusterStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterStatus(string value)
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
        /// Constant AccessDenied for ErrorCode
        /// </summary>
        public static readonly ErrorCode AccessDenied = new ErrorCode("AccessDenied");
        /// <summary>
        /// Constant ClusterUnreachable for ErrorCode
        /// </summary>
        public static readonly ErrorCode ClusterUnreachable = new ErrorCode("ClusterUnreachable");
        /// <summary>
        /// Constant ConfigurationConflict for ErrorCode
        /// </summary>
        public static readonly ErrorCode ConfigurationConflict = new ErrorCode("ConfigurationConflict");
        /// <summary>
        /// Constant EniLimitReached for ErrorCode
        /// </summary>
        public static readonly ErrorCode EniLimitReached = new ErrorCode("EniLimitReached");
        /// <summary>
        /// Constant InsufficientFreeAddresses for ErrorCode
        /// </summary>
        public static readonly ErrorCode InsufficientFreeAddresses = new ErrorCode("InsufficientFreeAddresses");
        /// <summary>
        /// Constant InsufficientNumberOfReplicas for ErrorCode
        /// </summary>
        public static readonly ErrorCode InsufficientNumberOfReplicas = new ErrorCode("InsufficientNumberOfReplicas");
        /// <summary>
        /// Constant IpNotAvailable for ErrorCode
        /// </summary>
        public static readonly ErrorCode IpNotAvailable = new ErrorCode("IpNotAvailable");
        /// <summary>
        /// Constant NodeCreationFailure for ErrorCode
        /// </summary>
        public static readonly ErrorCode NodeCreationFailure = new ErrorCode("NodeCreationFailure");
        /// <summary>
        /// Constant OperationNotPermitted for ErrorCode
        /// </summary>
        public static readonly ErrorCode OperationNotPermitted = new ErrorCode("OperationNotPermitted");
        /// <summary>
        /// Constant PodEvictionFailure for ErrorCode
        /// </summary>
        public static readonly ErrorCode PodEvictionFailure = new ErrorCode("PodEvictionFailure");
        /// <summary>
        /// Constant SecurityGroupNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode SecurityGroupNotFound = new ErrorCode("SecurityGroupNotFound");
        /// <summary>
        /// Constant SubnetNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode SubnetNotFound = new ErrorCode("SubnetNotFound");
        /// <summary>
        /// Constant Unknown for ErrorCode
        /// </summary>
        public static readonly ErrorCode Unknown = new ErrorCode("Unknown");
        /// <summary>
        /// Constant VpcIdNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode VpcIdNotFound = new ErrorCode("VpcIdNotFound");

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
    /// Constants used for properties of type FargateProfileStatus.
    /// </summary>
    public class FargateProfileStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FargateProfileStatus
        /// </summary>
        public static readonly FargateProfileStatus ACTIVE = new FargateProfileStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for FargateProfileStatus
        /// </summary>
        public static readonly FargateProfileStatus CREATE_FAILED = new FargateProfileStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for FargateProfileStatus
        /// </summary>
        public static readonly FargateProfileStatus CREATING = new FargateProfileStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for FargateProfileStatus
        /// </summary>
        public static readonly FargateProfileStatus DELETE_FAILED = new FargateProfileStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for FargateProfileStatus
        /// </summary>
        public static readonly FargateProfileStatus DELETING = new FargateProfileStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FargateProfileStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FargateProfileStatus FindValue(string value)
        {
            return FindValue<FargateProfileStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FargateProfileStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogType.
    /// </summary>
    public class LogType : ConstantClass
    {

        /// <summary>
        /// Constant Api for LogType
        /// </summary>
        public static readonly LogType Api = new LogType("api");
        /// <summary>
        /// Constant Audit for LogType
        /// </summary>
        public static readonly LogType Audit = new LogType("audit");
        /// <summary>
        /// Constant Authenticator for LogType
        /// </summary>
        public static readonly LogType Authenticator = new LogType("authenticator");
        /// <summary>
        /// Constant ControllerManager for LogType
        /// </summary>
        public static readonly LogType ControllerManager = new LogType("controllerManager");
        /// <summary>
        /// Constant Scheduler for LogType
        /// </summary>
        public static readonly LogType Scheduler = new LogType("scheduler");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogType FindValue(string value)
        {
            return FindValue<LogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodegroupIssueCode.
    /// </summary>
    public class NodegroupIssueCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode AccessDenied = new NodegroupIssueCode("AccessDenied");
        /// <summary>
        /// Constant AsgInstanceLaunchFailures for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode AsgInstanceLaunchFailures = new NodegroupIssueCode("AsgInstanceLaunchFailures");
        /// <summary>
        /// Constant AutoScalingGroupInvalidConfiguration for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode AutoScalingGroupInvalidConfiguration = new NodegroupIssueCode("AutoScalingGroupInvalidConfiguration");
        /// <summary>
        /// Constant AutoScalingGroupNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode AutoScalingGroupNotFound = new NodegroupIssueCode("AutoScalingGroupNotFound");
        /// <summary>
        /// Constant ClusterUnreachable for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode ClusterUnreachable = new NodegroupIssueCode("ClusterUnreachable");
        /// <summary>
        /// Constant Ec2LaunchTemplateNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2LaunchTemplateNotFound = new NodegroupIssueCode("Ec2LaunchTemplateNotFound");
        /// <summary>
        /// Constant Ec2LaunchTemplateVersionMismatch for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2LaunchTemplateVersionMismatch = new NodegroupIssueCode("Ec2LaunchTemplateVersionMismatch");
        /// <summary>
        /// Constant Ec2SecurityGroupDeletionFailure for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2SecurityGroupDeletionFailure = new NodegroupIssueCode("Ec2SecurityGroupDeletionFailure");
        /// <summary>
        /// Constant Ec2SecurityGroupNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2SecurityGroupNotFound = new NodegroupIssueCode("Ec2SecurityGroupNotFound");
        /// <summary>
        /// Constant Ec2SubnetInvalidConfiguration for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2SubnetInvalidConfiguration = new NodegroupIssueCode("Ec2SubnetInvalidConfiguration");
        /// <summary>
        /// Constant Ec2SubnetNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2SubnetNotFound = new NodegroupIssueCode("Ec2SubnetNotFound");
        /// <summary>
        /// Constant IamInstanceProfileNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode IamInstanceProfileNotFound = new NodegroupIssueCode("IamInstanceProfileNotFound");
        /// <summary>
        /// Constant IamLimitExceeded for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode IamLimitExceeded = new NodegroupIssueCode("IamLimitExceeded");
        /// <summary>
        /// Constant IamNodeRoleNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode IamNodeRoleNotFound = new NodegroupIssueCode("IamNodeRoleNotFound");
        /// <summary>
        /// Constant InstanceLimitExceeded for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode InstanceLimitExceeded = new NodegroupIssueCode("InstanceLimitExceeded");
        /// <summary>
        /// Constant InsufficientFreeAddresses for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode InsufficientFreeAddresses = new NodegroupIssueCode("InsufficientFreeAddresses");
        /// <summary>
        /// Constant InternalFailure for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode InternalFailure = new NodegroupIssueCode("InternalFailure");
        /// <summary>
        /// Constant NodeCreationFailure for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode NodeCreationFailure = new NodegroupIssueCode("NodeCreationFailure");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodegroupIssueCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodegroupIssueCode FindValue(string value)
        {
            return FindValue<NodegroupIssueCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodegroupIssueCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodegroupStatus.
    /// </summary>
    public class NodegroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus ACTIVE = new NodegroupStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus CREATE_FAILED = new NodegroupStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus CREATING = new NodegroupStatus("CREATING");
        /// <summary>
        /// Constant DEGRADED for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus DEGRADED = new NodegroupStatus("DEGRADED");
        /// <summary>
        /// Constant DELETE_FAILED for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus DELETE_FAILED = new NodegroupStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus DELETING = new NodegroupStatus("DELETING");
        /// <summary>
        /// Constant UPDATING for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus UPDATING = new NodegroupStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodegroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodegroupStatus FindValue(string value)
        {
            return FindValue<NodegroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodegroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolveConflicts.
    /// </summary>
    public class ResolveConflicts : ConstantClass
    {

        /// <summary>
        /// Constant NONE for ResolveConflicts
        /// </summary>
        public static readonly ResolveConflicts NONE = new ResolveConflicts("NONE");
        /// <summary>
        /// Constant OVERWRITE for ResolveConflicts
        /// </summary>
        public static readonly ResolveConflicts OVERWRITE = new ResolveConflicts("OVERWRITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolveConflicts(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolveConflicts FindValue(string value)
        {
            return FindValue<ResolveConflicts>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolveConflicts(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateParamType.
    /// </summary>
    public class UpdateParamType : ConstantClass
    {

        /// <summary>
        /// Constant AddonVersion for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType AddonVersion = new UpdateParamType("AddonVersion");
        /// <summary>
        /// Constant ClusterLogging for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType ClusterLogging = new UpdateParamType("ClusterLogging");
        /// <summary>
        /// Constant DesiredSize for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType DesiredSize = new UpdateParamType("DesiredSize");
        /// <summary>
        /// Constant EndpointPrivateAccess for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType EndpointPrivateAccess = new UpdateParamType("EndpointPrivateAccess");
        /// <summary>
        /// Constant EndpointPublicAccess for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType EndpointPublicAccess = new UpdateParamType("EndpointPublicAccess");
        /// <summary>
        /// Constant LabelsToAdd for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType LabelsToAdd = new UpdateParamType("LabelsToAdd");
        /// <summary>
        /// Constant LabelsToRemove for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType LabelsToRemove = new UpdateParamType("LabelsToRemove");
        /// <summary>
        /// Constant MaxSize for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType MaxSize = new UpdateParamType("MaxSize");
        /// <summary>
        /// Constant MinSize for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType MinSize = new UpdateParamType("MinSize");
        /// <summary>
        /// Constant PlatformVersion for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType PlatformVersion = new UpdateParamType("PlatformVersion");
        /// <summary>
        /// Constant PublicAccessCidrs for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType PublicAccessCidrs = new UpdateParamType("PublicAccessCidrs");
        /// <summary>
        /// Constant ReleaseVersion for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType ReleaseVersion = new UpdateParamType("ReleaseVersion");
        /// <summary>
        /// Constant ResolveConflicts for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType ResolveConflicts = new UpdateParamType("ResolveConflicts");
        /// <summary>
        /// Constant ServiceAccountRoleArn for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType ServiceAccountRoleArn = new UpdateParamType("ServiceAccountRoleArn");
        /// <summary>
        /// Constant Version for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType Version = new UpdateParamType("Version");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateParamType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateParamType FindValue(string value)
        {
            return FindValue<UpdateParamType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateParamType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateStatus.
    /// </summary>
    public class UpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus Cancelled = new UpdateStatus("Cancelled");
        /// <summary>
        /// Constant Failed for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus Failed = new UpdateStatus("Failed");
        /// <summary>
        /// Constant InProgress for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus InProgress = new UpdateStatus("InProgress");
        /// <summary>
        /// Constant Successful for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus Successful = new UpdateStatus("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateStatus FindValue(string value)
        {
            return FindValue<UpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateType.
    /// </summary>
    public class UpdateType : ConstantClass
    {

        /// <summary>
        /// Constant AddonUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType AddonUpdate = new UpdateType("AddonUpdate");
        /// <summary>
        /// Constant ConfigUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType ConfigUpdate = new UpdateType("ConfigUpdate");
        /// <summary>
        /// Constant EndpointAccessUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType EndpointAccessUpdate = new UpdateType("EndpointAccessUpdate");
        /// <summary>
        /// Constant LoggingUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType LoggingUpdate = new UpdateType("LoggingUpdate");
        /// <summary>
        /// Constant VersionUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType VersionUpdate = new UpdateType("VersionUpdate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateType FindValue(string value)
        {
            return FindValue<UpdateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateType(string value)
        {
            return FindValue(value);
        }
    }

}