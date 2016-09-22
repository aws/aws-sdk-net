/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeDeploy
{

    /// <summary>
    /// Constants used for properties of type ApplicationRevisionSortBy.
    /// </summary>
    public class ApplicationRevisionSortBy : ConstantClass
    {

        /// <summary>
        /// Constant FirstUsedTime for ApplicationRevisionSortBy
        /// </summary>
        public static readonly ApplicationRevisionSortBy FirstUsedTime = new ApplicationRevisionSortBy("firstUsedTime");
        /// <summary>
        /// Constant LastUsedTime for ApplicationRevisionSortBy
        /// </summary>
        public static readonly ApplicationRevisionSortBy LastUsedTime = new ApplicationRevisionSortBy("lastUsedTime");
        /// <summary>
        /// Constant RegisterTime for ApplicationRevisionSortBy
        /// </summary>
        public static readonly ApplicationRevisionSortBy RegisterTime = new ApplicationRevisionSortBy("registerTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationRevisionSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationRevisionSortBy FindValue(string value)
        {
            return FindValue<ApplicationRevisionSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationRevisionSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoRollbackEvent.
    /// </summary>
    public class AutoRollbackEvent : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYMENT_FAILURE for AutoRollbackEvent
        /// </summary>
        public static readonly AutoRollbackEvent DEPLOYMENT_FAILURE = new AutoRollbackEvent("DEPLOYMENT_FAILURE");
        /// <summary>
        /// Constant DEPLOYMENT_STOP_ON_ALARM for AutoRollbackEvent
        /// </summary>
        public static readonly AutoRollbackEvent DEPLOYMENT_STOP_ON_ALARM = new AutoRollbackEvent("DEPLOYMENT_STOP_ON_ALARM");
        /// <summary>
        /// Constant DEPLOYMENT_STOP_ON_REQUEST for AutoRollbackEvent
        /// </summary>
        public static readonly AutoRollbackEvent DEPLOYMENT_STOP_ON_REQUEST = new AutoRollbackEvent("DEPLOYMENT_STOP_ON_REQUEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoRollbackEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoRollbackEvent FindValue(string value)
        {
            return FindValue<AutoRollbackEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoRollbackEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BundleType.
    /// </summary>
    public class BundleType : ConstantClass
    {

        /// <summary>
        /// Constant Tar for BundleType
        /// </summary>
        public static readonly BundleType Tar = new BundleType("tar");
        /// <summary>
        /// Constant Tgz for BundleType
        /// </summary>
        public static readonly BundleType Tgz = new BundleType("tgz");
        /// <summary>
        /// Constant Zip for BundleType
        /// </summary>
        public static readonly BundleType Zip = new BundleType("zip");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BundleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BundleType FindValue(string value)
        {
            return FindValue<BundleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BundleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentCreator.
    /// </summary>
    public class DeploymentCreator : ConstantClass
    {

        /// <summary>
        /// Constant Autoscaling for DeploymentCreator
        /// </summary>
        public static readonly DeploymentCreator Autoscaling = new DeploymentCreator("autoscaling");
        /// <summary>
        /// Constant CodeDeployRollback for DeploymentCreator
        /// </summary>
        public static readonly DeploymentCreator CodeDeployRollback = new DeploymentCreator("codeDeployRollback");
        /// <summary>
        /// Constant User for DeploymentCreator
        /// </summary>
        public static readonly DeploymentCreator User = new DeploymentCreator("user");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentCreator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentCreator FindValue(string value)
        {
            return FindValue<DeploymentCreator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentCreator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentStatus.
    /// </summary>
    public class DeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Created for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus Created = new DeploymentStatus("Created");
        /// <summary>
        /// Constant Failed for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus Failed = new DeploymentStatus("Failed");
        /// <summary>
        /// Constant InProgress for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus InProgress = new DeploymentStatus("InProgress");
        /// <summary>
        /// Constant Queued for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus Queued = new DeploymentStatus("Queued");
        /// <summary>
        /// Constant Stopped for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus Stopped = new DeploymentStatus("Stopped");
        /// <summary>
        /// Constant Succeeded for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus Succeeded = new DeploymentStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentStatus FindValue(string value)
        {
            return FindValue<DeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EC2TagFilterType.
    /// </summary>
    public class EC2TagFilterType : ConstantClass
    {

        /// <summary>
        /// Constant KEY_AND_VALUE for EC2TagFilterType
        /// </summary>
        public static readonly EC2TagFilterType KEY_AND_VALUE = new EC2TagFilterType("KEY_AND_VALUE");
        /// <summary>
        /// Constant KEY_ONLY for EC2TagFilterType
        /// </summary>
        public static readonly EC2TagFilterType KEY_ONLY = new EC2TagFilterType("KEY_ONLY");
        /// <summary>
        /// Constant VALUE_ONLY for EC2TagFilterType
        /// </summary>
        public static readonly EC2TagFilterType VALUE_ONLY = new EC2TagFilterType("VALUE_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EC2TagFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EC2TagFilterType FindValue(string value)
        {
            return FindValue<EC2TagFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EC2TagFilterType(string value)
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
        /// Constant AGENT_ISSUE for ErrorCode
        /// </summary>
        public static readonly ErrorCode AGENT_ISSUE = new ErrorCode("AGENT_ISSUE");
        /// <summary>
        /// Constant ALARM_ACTIVE for ErrorCode
        /// </summary>
        public static readonly ErrorCode ALARM_ACTIVE = new ErrorCode("ALARM_ACTIVE");
        /// <summary>
        /// Constant APPLICATION_MISSING for ErrorCode
        /// </summary>
        public static readonly ErrorCode APPLICATION_MISSING = new ErrorCode("APPLICATION_MISSING");
        /// <summary>
        /// Constant AUTO_SCALING_CONFIGURATION for ErrorCode
        /// </summary>
        public static readonly ErrorCode AUTO_SCALING_CONFIGURATION = new ErrorCode("AUTO_SCALING_CONFIGURATION");
        /// <summary>
        /// Constant AUTO_SCALING_IAM_ROLE_PERMISSIONS for ErrorCode
        /// </summary>
        public static readonly ErrorCode AUTO_SCALING_IAM_ROLE_PERMISSIONS = new ErrorCode("AUTO_SCALING_IAM_ROLE_PERMISSIONS");
        /// <summary>
        /// Constant DEPLOYMENT_GROUP_MISSING for ErrorCode
        /// </summary>
        public static readonly ErrorCode DEPLOYMENT_GROUP_MISSING = new ErrorCode("DEPLOYMENT_GROUP_MISSING");
        /// <summary>
        /// Constant HEALTH_CONSTRAINTS for ErrorCode
        /// </summary>
        public static readonly ErrorCode HEALTH_CONSTRAINTS = new ErrorCode("HEALTH_CONSTRAINTS");
        /// <summary>
        /// Constant HEALTH_CONSTRAINTS_INVALID for ErrorCode
        /// </summary>
        public static readonly ErrorCode HEALTH_CONSTRAINTS_INVALID = new ErrorCode("HEALTH_CONSTRAINTS_INVALID");
        /// <summary>
        /// Constant IAM_ROLE_MISSING for ErrorCode
        /// </summary>
        public static readonly ErrorCode IAM_ROLE_MISSING = new ErrorCode("IAM_ROLE_MISSING");
        /// <summary>
        /// Constant IAM_ROLE_PERMISSIONS for ErrorCode
        /// </summary>
        public static readonly ErrorCode IAM_ROLE_PERMISSIONS = new ErrorCode("IAM_ROLE_PERMISSIONS");
        /// <summary>
        /// Constant INTERNAL_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode INTERNAL_ERROR = new ErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant MANUAL_STOP for ErrorCode
        /// </summary>
        public static readonly ErrorCode MANUAL_STOP = new ErrorCode("MANUAL_STOP");
        /// <summary>
        /// Constant NO_EC2_SUBSCRIPTION for ErrorCode
        /// </summary>
        public static readonly ErrorCode NO_EC2_SUBSCRIPTION = new ErrorCode("NO_EC2_SUBSCRIPTION");
        /// <summary>
        /// Constant NO_INSTANCES for ErrorCode
        /// </summary>
        public static readonly ErrorCode NO_INSTANCES = new ErrorCode("NO_INSTANCES");
        /// <summary>
        /// Constant OVER_MAX_INSTANCES for ErrorCode
        /// </summary>
        public static readonly ErrorCode OVER_MAX_INSTANCES = new ErrorCode("OVER_MAX_INSTANCES");
        /// <summary>
        /// Constant REVISION_MISSING for ErrorCode
        /// </summary>
        public static readonly ErrorCode REVISION_MISSING = new ErrorCode("REVISION_MISSING");
        /// <summary>
        /// Constant THROTTLED for ErrorCode
        /// </summary>
        public static readonly ErrorCode THROTTLED = new ErrorCode("THROTTLED");
        /// <summary>
        /// Constant TIMEOUT for ErrorCode
        /// </summary>
        public static readonly ErrorCode TIMEOUT = new ErrorCode("TIMEOUT");

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
    /// Constants used for properties of type InstanceStatus.
    /// </summary>
    public class InstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus Failed = new InstanceStatus("Failed");
        /// <summary>
        /// Constant InProgress for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus InProgress = new InstanceStatus("InProgress");
        /// <summary>
        /// Constant Pending for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus Pending = new InstanceStatus("Pending");
        /// <summary>
        /// Constant Skipped for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus Skipped = new InstanceStatus("Skipped");
        /// <summary>
        /// Constant Succeeded for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus Succeeded = new InstanceStatus("Succeeded");
        /// <summary>
        /// Constant Unknown for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus Unknown = new InstanceStatus("Unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceStatus FindValue(string value)
        {
            return FindValue<InstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecycleErrorCode.
    /// </summary>
    public class LifecycleErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ScriptFailed for LifecycleErrorCode
        /// </summary>
        public static readonly LifecycleErrorCode ScriptFailed = new LifecycleErrorCode("ScriptFailed");
        /// <summary>
        /// Constant ScriptMissing for LifecycleErrorCode
        /// </summary>
        public static readonly LifecycleErrorCode ScriptMissing = new LifecycleErrorCode("ScriptMissing");
        /// <summary>
        /// Constant ScriptNotExecutable for LifecycleErrorCode
        /// </summary>
        public static readonly LifecycleErrorCode ScriptNotExecutable = new LifecycleErrorCode("ScriptNotExecutable");
        /// <summary>
        /// Constant ScriptTimedOut for LifecycleErrorCode
        /// </summary>
        public static readonly LifecycleErrorCode ScriptTimedOut = new LifecycleErrorCode("ScriptTimedOut");
        /// <summary>
        /// Constant Success for LifecycleErrorCode
        /// </summary>
        public static readonly LifecycleErrorCode Success = new LifecycleErrorCode("Success");
        /// <summary>
        /// Constant UnknownError for LifecycleErrorCode
        /// </summary>
        public static readonly LifecycleErrorCode UnknownError = new LifecycleErrorCode("UnknownError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecycleErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecycleErrorCode FindValue(string value)
        {
            return FindValue<LifecycleErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecycleErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecycleEventStatus.
    /// </summary>
    public class LifecycleEventStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for LifecycleEventStatus
        /// </summary>
        public static readonly LifecycleEventStatus Failed = new LifecycleEventStatus("Failed");
        /// <summary>
        /// Constant InProgress for LifecycleEventStatus
        /// </summary>
        public static readonly LifecycleEventStatus InProgress = new LifecycleEventStatus("InProgress");
        /// <summary>
        /// Constant Pending for LifecycleEventStatus
        /// </summary>
        public static readonly LifecycleEventStatus Pending = new LifecycleEventStatus("Pending");
        /// <summary>
        /// Constant Skipped for LifecycleEventStatus
        /// </summary>
        public static readonly LifecycleEventStatus Skipped = new LifecycleEventStatus("Skipped");
        /// <summary>
        /// Constant Succeeded for LifecycleEventStatus
        /// </summary>
        public static readonly LifecycleEventStatus Succeeded = new LifecycleEventStatus("Succeeded");
        /// <summary>
        /// Constant Unknown for LifecycleEventStatus
        /// </summary>
        public static readonly LifecycleEventStatus Unknown = new LifecycleEventStatus("Unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecycleEventStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecycleEventStatus FindValue(string value)
        {
            return FindValue<LifecycleEventStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecycleEventStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListStateFilterAction.
    /// </summary>
    public class ListStateFilterAction : ConstantClass
    {

        /// <summary>
        /// Constant Exclude for ListStateFilterAction
        /// </summary>
        public static readonly ListStateFilterAction Exclude = new ListStateFilterAction("exclude");
        /// <summary>
        /// Constant Ignore for ListStateFilterAction
        /// </summary>
        public static readonly ListStateFilterAction Ignore = new ListStateFilterAction("ignore");
        /// <summary>
        /// Constant Include for ListStateFilterAction
        /// </summary>
        public static readonly ListStateFilterAction Include = new ListStateFilterAction("include");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListStateFilterAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListStateFilterAction FindValue(string value)
        {
            return FindValue<ListStateFilterAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListStateFilterAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MinimumHealthyHostsType.
    /// </summary>
    public class MinimumHealthyHostsType : ConstantClass
    {

        /// <summary>
        /// Constant FLEET_PERCENT for MinimumHealthyHostsType
        /// </summary>
        public static readonly MinimumHealthyHostsType FLEET_PERCENT = new MinimumHealthyHostsType("FLEET_PERCENT");
        /// <summary>
        /// Constant HOST_COUNT for MinimumHealthyHostsType
        /// </summary>
        public static readonly MinimumHealthyHostsType HOST_COUNT = new MinimumHealthyHostsType("HOST_COUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MinimumHealthyHostsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MinimumHealthyHostsType FindValue(string value)
        {
            return FindValue<MinimumHealthyHostsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MinimumHealthyHostsType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationStatus.
    /// </summary>
    public class RegistrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deregistered for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus Deregistered = new RegistrationStatus("Deregistered");
        /// <summary>
        /// Constant Registered for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus Registered = new RegistrationStatus("Registered");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationStatus FindValue(string value)
        {
            return FindValue<RegistrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RevisionLocationType.
    /// </summary>
    public class RevisionLocationType : ConstantClass
    {

        /// <summary>
        /// Constant GitHub for RevisionLocationType
        /// </summary>
        public static readonly RevisionLocationType GitHub = new RevisionLocationType("GitHub");
        /// <summary>
        /// Constant S3 for RevisionLocationType
        /// </summary>
        public static readonly RevisionLocationType S3 = new RevisionLocationType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RevisionLocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevisionLocationType FindValue(string value)
        {
            return FindValue<RevisionLocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevisionLocationType(string value)
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
        /// Constant Ascending for SortOrder
        /// </summary>
        public static readonly SortOrder Ascending = new SortOrder("ascending");
        /// <summary>
        /// Constant Descending for SortOrder
        /// </summary>
        public static readonly SortOrder Descending = new SortOrder("descending");

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
    /// Constants used for properties of type StopStatus.
    /// </summary>
    public class StopStatus : ConstantClass
    {

        /// <summary>
        /// Constant Pending for StopStatus
        /// </summary>
        public static readonly StopStatus Pending = new StopStatus("Pending");
        /// <summary>
        /// Constant Succeeded for StopStatus
        /// </summary>
        public static readonly StopStatus Succeeded = new StopStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StopStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StopStatus FindValue(string value)
        {
            return FindValue<StopStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StopStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TagFilterType.
    /// </summary>
    public class TagFilterType : ConstantClass
    {

        /// <summary>
        /// Constant KEY_AND_VALUE for TagFilterType
        /// </summary>
        public static readonly TagFilterType KEY_AND_VALUE = new TagFilterType("KEY_AND_VALUE");
        /// <summary>
        /// Constant KEY_ONLY for TagFilterType
        /// </summary>
        public static readonly TagFilterType KEY_ONLY = new TagFilterType("KEY_ONLY");
        /// <summary>
        /// Constant VALUE_ONLY for TagFilterType
        /// </summary>
        public static readonly TagFilterType VALUE_ONLY = new TagFilterType("VALUE_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TagFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TagFilterType FindValue(string value)
        {
            return FindValue<TagFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TagFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TriggerEventType.
    /// </summary>
    public class TriggerEventType : ConstantClass
    {

        /// <summary>
        /// Constant DeploymentFailure for TriggerEventType
        /// </summary>
        public static readonly TriggerEventType DeploymentFailure = new TriggerEventType("DeploymentFailure");
        /// <summary>
        /// Constant DeploymentRollback for TriggerEventType
        /// </summary>
        public static readonly TriggerEventType DeploymentRollback = new TriggerEventType("DeploymentRollback");
        /// <summary>
        /// Constant DeploymentStart for TriggerEventType
        /// </summary>
        public static readonly TriggerEventType DeploymentStart = new TriggerEventType("DeploymentStart");
        /// <summary>
        /// Constant DeploymentStop for TriggerEventType
        /// </summary>
        public static readonly TriggerEventType DeploymentStop = new TriggerEventType("DeploymentStop");
        /// <summary>
        /// Constant DeploymentSuccess for TriggerEventType
        /// </summary>
        public static readonly TriggerEventType DeploymentSuccess = new TriggerEventType("DeploymentSuccess");
        /// <summary>
        /// Constant InstanceFailure for TriggerEventType
        /// </summary>
        public static readonly TriggerEventType InstanceFailure = new TriggerEventType("InstanceFailure");
        /// <summary>
        /// Constant InstanceStart for TriggerEventType
        /// </summary>
        public static readonly TriggerEventType InstanceStart = new TriggerEventType("InstanceStart");
        /// <summary>
        /// Constant InstanceSuccess for TriggerEventType
        /// </summary>
        public static readonly TriggerEventType InstanceSuccess = new TriggerEventType("InstanceSuccess");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriggerEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriggerEventType FindValue(string value)
        {
            return FindValue<TriggerEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriggerEventType(string value)
        {
            return FindValue(value);
        }
    }

}