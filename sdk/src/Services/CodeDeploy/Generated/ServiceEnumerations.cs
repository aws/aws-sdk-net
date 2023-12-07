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
        /// Constant JSON for BundleType
        /// </summary>
        public static readonly BundleType JSON = new BundleType("JSON");
        /// <summary>
        /// Constant Tar for BundleType
        /// </summary>
        public static readonly BundleType Tar = new BundleType("tar");
        /// <summary>
        /// Constant Tgz for BundleType
        /// </summary>
        public static readonly BundleType Tgz = new BundleType("tgz");
        /// <summary>
        /// Constant YAML for BundleType
        /// </summary>
        public static readonly BundleType YAML = new BundleType("YAML");
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
    /// Constants used for properties of type ComputePlatform.
    /// </summary>
    public class ComputePlatform : ConstantClass
    {

        /// <summary>
        /// Constant ECS for ComputePlatform
        /// </summary>
        public static readonly ComputePlatform ECS = new ComputePlatform("ECS");
        /// <summary>
        /// Constant Lambda for ComputePlatform
        /// </summary>
        public static readonly ComputePlatform Lambda = new ComputePlatform("Lambda");
        /// <summary>
        /// Constant Server for ComputePlatform
        /// </summary>
        public static readonly ComputePlatform Server = new ComputePlatform("Server");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputePlatform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputePlatform FindValue(string value)
        {
            return FindValue<ComputePlatform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputePlatform(string value)
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
        /// Constant AutoscalingTermination for DeploymentCreator
        /// </summary>
        public static readonly DeploymentCreator AutoscalingTermination = new DeploymentCreator("autoscalingTermination");
        /// <summary>
        /// Constant CloudFormation for DeploymentCreator
        /// </summary>
        public static readonly DeploymentCreator CloudFormation = new DeploymentCreator("CloudFormation");
        /// <summary>
        /// Constant CloudFormationRollback for DeploymentCreator
        /// </summary>
        public static readonly DeploymentCreator CloudFormationRollback = new DeploymentCreator("CloudFormationRollback");
        /// <summary>
        /// Constant CodeDeploy for DeploymentCreator
        /// </summary>
        public static readonly DeploymentCreator CodeDeploy = new DeploymentCreator("CodeDeploy");
        /// <summary>
        /// Constant CodeDeployAutoUpdate for DeploymentCreator
        /// </summary>
        public static readonly DeploymentCreator CodeDeployAutoUpdate = new DeploymentCreator("CodeDeployAutoUpdate");
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
    /// Constants used for properties of type DeploymentOption.
    /// </summary>
    public class DeploymentOption : ConstantClass
    {

        /// <summary>
        /// Constant WITH_TRAFFIC_CONTROL for DeploymentOption
        /// </summary>
        public static readonly DeploymentOption WITH_TRAFFIC_CONTROL = new DeploymentOption("WITH_TRAFFIC_CONTROL");
        /// <summary>
        /// Constant WITHOUT_TRAFFIC_CONTROL for DeploymentOption
        /// </summary>
        public static readonly DeploymentOption WITHOUT_TRAFFIC_CONTROL = new DeploymentOption("WITHOUT_TRAFFIC_CONTROL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentOption FindValue(string value)
        {
            return FindValue<DeploymentOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentReadyAction.
    /// </summary>
    public class DeploymentReadyAction : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUE_DEPLOYMENT for DeploymentReadyAction
        /// </summary>
        public static readonly DeploymentReadyAction CONTINUE_DEPLOYMENT = new DeploymentReadyAction("CONTINUE_DEPLOYMENT");
        /// <summary>
        /// Constant STOP_DEPLOYMENT for DeploymentReadyAction
        /// </summary>
        public static readonly DeploymentReadyAction STOP_DEPLOYMENT = new DeploymentReadyAction("STOP_DEPLOYMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentReadyAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentReadyAction FindValue(string value)
        {
            return FindValue<DeploymentReadyAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentReadyAction(string value)
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
        /// Constant Baking for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus Baking = new DeploymentStatus("Baking");
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
        /// Constant Ready for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus Ready = new DeploymentStatus("Ready");
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
    /// Constants used for properties of type DeploymentTargetType.
    /// </summary>
    public class DeploymentTargetType : ConstantClass
    {

        /// <summary>
        /// Constant CloudFormationTarget for DeploymentTargetType
        /// </summary>
        public static readonly DeploymentTargetType CloudFormationTarget = new DeploymentTargetType("CloudFormationTarget");
        /// <summary>
        /// Constant ECSTarget for DeploymentTargetType
        /// </summary>
        public static readonly DeploymentTargetType ECSTarget = new DeploymentTargetType("ECSTarget");
        /// <summary>
        /// Constant InstanceTarget for DeploymentTargetType
        /// </summary>
        public static readonly DeploymentTargetType InstanceTarget = new DeploymentTargetType("InstanceTarget");
        /// <summary>
        /// Constant LambdaTarget for DeploymentTargetType
        /// </summary>
        public static readonly DeploymentTargetType LambdaTarget = new DeploymentTargetType("LambdaTarget");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentTargetType FindValue(string value)
        {
            return FindValue<DeploymentTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentType.
    /// </summary>
    public class DeploymentType : ConstantClass
    {

        /// <summary>
        /// Constant BLUE_GREEN for DeploymentType
        /// </summary>
        public static readonly DeploymentType BLUE_GREEN = new DeploymentType("BLUE_GREEN");
        /// <summary>
        /// Constant IN_PLACE for DeploymentType
        /// </summary>
        public static readonly DeploymentType IN_PLACE = new DeploymentType("IN_PLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentType FindValue(string value)
        {
            return FindValue<DeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentWaitType.
    /// </summary>
    public class DeploymentWaitType : ConstantClass
    {

        /// <summary>
        /// Constant READY_WAIT for DeploymentWaitType
        /// </summary>
        public static readonly DeploymentWaitType READY_WAIT = new DeploymentWaitType("READY_WAIT");
        /// <summary>
        /// Constant TERMINATION_WAIT for DeploymentWaitType
        /// </summary>
        public static readonly DeploymentWaitType TERMINATION_WAIT = new DeploymentWaitType("TERMINATION_WAIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentWaitType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentWaitType FindValue(string value)
        {
            return FindValue<DeploymentWaitType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentWaitType(string value)
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
        /// Constant AUTOSCALING_VALIDATION_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode AUTOSCALING_VALIDATION_ERROR = new ErrorCode("AUTOSCALING_VALIDATION_ERROR");
        /// <summary>
        /// Constant CLOUDFORMATION_STACK_FAILURE for ErrorCode
        /// </summary>
        public static readonly ErrorCode CLOUDFORMATION_STACK_FAILURE = new ErrorCode("CLOUDFORMATION_STACK_FAILURE");
        /// <summary>
        /// Constant CODEDEPLOY_RESOURCE_CANNOT_BE_FOUND for ErrorCode
        /// </summary>
        public static readonly ErrorCode CODEDEPLOY_RESOURCE_CANNOT_BE_FOUND = new ErrorCode("CODEDEPLOY_RESOURCE_CANNOT_BE_FOUND");
        /// <summary>
        /// Constant CUSTOMER_APPLICATION_UNHEALTHY for ErrorCode
        /// </summary>
        public static readonly ErrorCode CUSTOMER_APPLICATION_UNHEALTHY = new ErrorCode("CUSTOMER_APPLICATION_UNHEALTHY");
        /// <summary>
        /// Constant DEPLOYMENT_GROUP_MISSING for ErrorCode
        /// </summary>
        public static readonly ErrorCode DEPLOYMENT_GROUP_MISSING = new ErrorCode("DEPLOYMENT_GROUP_MISSING");
        /// <summary>
        /// Constant ECS_UPDATE_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode ECS_UPDATE_ERROR = new ErrorCode("ECS_UPDATE_ERROR");
        /// <summary>
        /// Constant ELASTIC_LOAD_BALANCING_INVALID for ErrorCode
        /// </summary>
        public static readonly ErrorCode ELASTIC_LOAD_BALANCING_INVALID = new ErrorCode("ELASTIC_LOAD_BALANCING_INVALID");
        /// <summary>
        /// Constant ELB_INVALID_INSTANCE for ErrorCode
        /// </summary>
        public static readonly ErrorCode ELB_INVALID_INSTANCE = new ErrorCode("ELB_INVALID_INSTANCE");
        /// <summary>
        /// Constant HEALTH_CONSTRAINTS for ErrorCode
        /// </summary>
        public static readonly ErrorCode HEALTH_CONSTRAINTS = new ErrorCode("HEALTH_CONSTRAINTS");
        /// <summary>
        /// Constant HEALTH_CONSTRAINTS_INVALID for ErrorCode
        /// </summary>
        public static readonly ErrorCode HEALTH_CONSTRAINTS_INVALID = new ErrorCode("HEALTH_CONSTRAINTS_INVALID");
        /// <summary>
        /// Constant HOOK_EXECUTION_FAILURE for ErrorCode
        /// </summary>
        public static readonly ErrorCode HOOK_EXECUTION_FAILURE = new ErrorCode("HOOK_EXECUTION_FAILURE");
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
        /// Constant INVALID_ECS_SERVICE for ErrorCode
        /// </summary>
        public static readonly ErrorCode INVALID_ECS_SERVICE = new ErrorCode("INVALID_ECS_SERVICE");
        /// <summary>
        /// Constant INVALID_LAMBDA_CONFIGURATION for ErrorCode
        /// </summary>
        public static readonly ErrorCode INVALID_LAMBDA_CONFIGURATION = new ErrorCode("INVALID_LAMBDA_CONFIGURATION");
        /// <summary>
        /// Constant INVALID_LAMBDA_FUNCTION for ErrorCode
        /// </summary>
        public static readonly ErrorCode INVALID_LAMBDA_FUNCTION = new ErrorCode("INVALID_LAMBDA_FUNCTION");
        /// <summary>
        /// Constant INVALID_REVISION for ErrorCode
        /// </summary>
        public static readonly ErrorCode INVALID_REVISION = new ErrorCode("INVALID_REVISION");
        /// <summary>
        /// Constant MANUAL_STOP for ErrorCode
        /// </summary>
        public static readonly ErrorCode MANUAL_STOP = new ErrorCode("MANUAL_STOP");
        /// <summary>
        /// Constant MISSING_BLUE_GREEN_DEPLOYMENT_CONFIGURATION for ErrorCode
        /// </summary>
        public static readonly ErrorCode MISSING_BLUE_GREEN_DEPLOYMENT_CONFIGURATION = new ErrorCode("MISSING_BLUE_GREEN_DEPLOYMENT_CONFIGURATION");
        /// <summary>
        /// Constant MISSING_ELB_INFORMATION for ErrorCode
        /// </summary>
        public static readonly ErrorCode MISSING_ELB_INFORMATION = new ErrorCode("MISSING_ELB_INFORMATION");
        /// <summary>
        /// Constant MISSING_GITHUB_TOKEN for ErrorCode
        /// </summary>
        public static readonly ErrorCode MISSING_GITHUB_TOKEN = new ErrorCode("MISSING_GITHUB_TOKEN");
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
        /// Constant RESOURCE_LIMIT_EXCEEDED for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_LIMIT_EXCEEDED = new ErrorCode("RESOURCE_LIMIT_EXCEEDED");
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
    /// Constants used for properties of type FileExistsBehavior.
    /// </summary>
    public class FileExistsBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DISALLOW for FileExistsBehavior
        /// </summary>
        public static readonly FileExistsBehavior DISALLOW = new FileExistsBehavior("DISALLOW");
        /// <summary>
        /// Constant OVERWRITE for FileExistsBehavior
        /// </summary>
        public static readonly FileExistsBehavior OVERWRITE = new FileExistsBehavior("OVERWRITE");
        /// <summary>
        /// Constant RETAIN for FileExistsBehavior
        /// </summary>
        public static readonly FileExistsBehavior RETAIN = new FileExistsBehavior("RETAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileExistsBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileExistsBehavior FindValue(string value)
        {
            return FindValue<FileExistsBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileExistsBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GreenFleetProvisioningAction.
    /// </summary>
    public class GreenFleetProvisioningAction : ConstantClass
    {

        /// <summary>
        /// Constant COPY_AUTO_SCALING_GROUP for GreenFleetProvisioningAction
        /// </summary>
        public static readonly GreenFleetProvisioningAction COPY_AUTO_SCALING_GROUP = new GreenFleetProvisioningAction("COPY_AUTO_SCALING_GROUP");
        /// <summary>
        /// Constant DISCOVER_EXISTING for GreenFleetProvisioningAction
        /// </summary>
        public static readonly GreenFleetProvisioningAction DISCOVER_EXISTING = new GreenFleetProvisioningAction("DISCOVER_EXISTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GreenFleetProvisioningAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GreenFleetProvisioningAction FindValue(string value)
        {
            return FindValue<GreenFleetProvisioningAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GreenFleetProvisioningAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceAction.
    /// </summary>
    public class InstanceAction : ConstantClass
    {

        /// <summary>
        /// Constant KEEP_ALIVE for InstanceAction
        /// </summary>
        public static readonly InstanceAction KEEP_ALIVE = new InstanceAction("KEEP_ALIVE");
        /// <summary>
        /// Constant TERMINATE for InstanceAction
        /// </summary>
        public static readonly InstanceAction TERMINATE = new InstanceAction("TERMINATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceAction FindValue(string value)
        {
            return FindValue<InstanceAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceAction(string value)
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
        /// Constant Ready for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus Ready = new InstanceStatus("Ready");
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
    /// Constants used for properties of type InstanceType.
    /// </summary>
    public class InstanceType : ConstantClass
    {

        /// <summary>
        /// Constant Blue for InstanceType
        /// </summary>
        public static readonly InstanceType Blue = new InstanceType("Blue");
        /// <summary>
        /// Constant Green for InstanceType
        /// </summary>
        public static readonly InstanceType Green = new InstanceType("Green");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceType FindValue(string value)
        {
            return FindValue<InstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceType(string value)
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
    /// Constants used for properties of type MinimumHealthyHostsPerZoneType.
    /// </summary>
    public class MinimumHealthyHostsPerZoneType : ConstantClass
    {

        /// <summary>
        /// Constant FLEET_PERCENT for MinimumHealthyHostsPerZoneType
        /// </summary>
        public static readonly MinimumHealthyHostsPerZoneType FLEET_PERCENT = new MinimumHealthyHostsPerZoneType("FLEET_PERCENT");
        /// <summary>
        /// Constant HOST_COUNT for MinimumHealthyHostsPerZoneType
        /// </summary>
        public static readonly MinimumHealthyHostsPerZoneType HOST_COUNT = new MinimumHealthyHostsPerZoneType("HOST_COUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MinimumHealthyHostsPerZoneType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MinimumHealthyHostsPerZoneType FindValue(string value)
        {
            return FindValue<MinimumHealthyHostsPerZoneType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MinimumHealthyHostsPerZoneType(string value)
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
    /// Constants used for properties of type OutdatedInstancesStrategy.
    /// </summary>
    public class OutdatedInstancesStrategy : ConstantClass
    {

        /// <summary>
        /// Constant IGNORE for OutdatedInstancesStrategy
        /// </summary>
        public static readonly OutdatedInstancesStrategy IGNORE = new OutdatedInstancesStrategy("IGNORE");
        /// <summary>
        /// Constant UPDATE for OutdatedInstancesStrategy
        /// </summary>
        public static readonly OutdatedInstancesStrategy UPDATE = new OutdatedInstancesStrategy("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutdatedInstancesStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutdatedInstancesStrategy FindValue(string value)
        {
            return FindValue<OutdatedInstancesStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutdatedInstancesStrategy(string value)
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
        /// Constant AppSpecContent for RevisionLocationType
        /// </summary>
        public static readonly RevisionLocationType AppSpecContent = new RevisionLocationType("AppSpecContent");
        /// <summary>
        /// Constant GitHub for RevisionLocationType
        /// </summary>
        public static readonly RevisionLocationType GitHub = new RevisionLocationType("GitHub");
        /// <summary>
        /// Constant S3 for RevisionLocationType
        /// </summary>
        public static readonly RevisionLocationType S3 = new RevisionLocationType("S3");
        /// <summary>
        /// Constant String for RevisionLocationType
        /// </summary>
        public static readonly RevisionLocationType String = new RevisionLocationType("String");

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
    /// Constants used for properties of type TargetFilterName.
    /// </summary>
    public class TargetFilterName : ConstantClass
    {

        /// <summary>
        /// Constant ServerInstanceLabel for TargetFilterName
        /// </summary>
        public static readonly TargetFilterName ServerInstanceLabel = new TargetFilterName("ServerInstanceLabel");
        /// <summary>
        /// Constant TargetStatus for TargetFilterName
        /// </summary>
        public static readonly TargetFilterName TargetStatus = new TargetFilterName("TargetStatus");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetFilterName FindValue(string value)
        {
            return FindValue<TargetFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetLabel.
    /// </summary>
    public class TargetLabel : ConstantClass
    {

        /// <summary>
        /// Constant Blue for TargetLabel
        /// </summary>
        public static readonly TargetLabel Blue = new TargetLabel("Blue");
        /// <summary>
        /// Constant Green for TargetLabel
        /// </summary>
        public static readonly TargetLabel Green = new TargetLabel("Green");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetLabel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetLabel FindValue(string value)
        {
            return FindValue<TargetLabel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetLabel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetStatus.
    /// </summary>
    public class TargetStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for TargetStatus
        /// </summary>
        public static readonly TargetStatus Failed = new TargetStatus("Failed");
        /// <summary>
        /// Constant InProgress for TargetStatus
        /// </summary>
        public static readonly TargetStatus InProgress = new TargetStatus("InProgress");
        /// <summary>
        /// Constant Pending for TargetStatus
        /// </summary>
        public static readonly TargetStatus Pending = new TargetStatus("Pending");
        /// <summary>
        /// Constant Ready for TargetStatus
        /// </summary>
        public static readonly TargetStatus Ready = new TargetStatus("Ready");
        /// <summary>
        /// Constant Skipped for TargetStatus
        /// </summary>
        public static readonly TargetStatus Skipped = new TargetStatus("Skipped");
        /// <summary>
        /// Constant Succeeded for TargetStatus
        /// </summary>
        public static readonly TargetStatus Succeeded = new TargetStatus("Succeeded");
        /// <summary>
        /// Constant Unknown for TargetStatus
        /// </summary>
        public static readonly TargetStatus Unknown = new TargetStatus("Unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetStatus FindValue(string value)
        {
            return FindValue<TargetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficRoutingType.
    /// </summary>
    public class TrafficRoutingType : ConstantClass
    {

        /// <summary>
        /// Constant AllAtOnce for TrafficRoutingType
        /// </summary>
        public static readonly TrafficRoutingType AllAtOnce = new TrafficRoutingType("AllAtOnce");
        /// <summary>
        /// Constant TimeBasedCanary for TrafficRoutingType
        /// </summary>
        public static readonly TrafficRoutingType TimeBasedCanary = new TrafficRoutingType("TimeBasedCanary");
        /// <summary>
        /// Constant TimeBasedLinear for TrafficRoutingType
        /// </summary>
        public static readonly TrafficRoutingType TimeBasedLinear = new TrafficRoutingType("TimeBasedLinear");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficRoutingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficRoutingType FindValue(string value)
        {
            return FindValue<TrafficRoutingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficRoutingType(string value)
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
        /// Constant DeploymentReady for TriggerEventType
        /// </summary>
        public static readonly TriggerEventType DeploymentReady = new TriggerEventType("DeploymentReady");
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
        /// Constant InstanceReady for TriggerEventType
        /// </summary>
        public static readonly TriggerEventType InstanceReady = new TriggerEventType("InstanceReady");
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