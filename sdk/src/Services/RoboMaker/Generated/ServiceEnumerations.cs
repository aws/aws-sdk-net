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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.RoboMaker
{

    /// <summary>
    /// Constants used for properties of type Architecture.
    /// </summary>
    public class Architecture : ConstantClass
    {

        /// <summary>
        /// Constant ARM64 for Architecture
        /// </summary>
        public static readonly Architecture ARM64 = new Architecture("ARM64");
        /// <summary>
        /// Constant ARMHF for Architecture
        /// </summary>
        public static readonly Architecture ARMHF = new Architecture("ARMHF");
        /// <summary>
        /// Constant X86_64 for Architecture
        /// </summary>
        public static readonly Architecture X86_64 = new Architecture("X86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Architecture(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Architecture FindValue(string value)
        {
            return FindValue<Architecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Architecture(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeType.
    /// </summary>
    public class ComputeType : ConstantClass
    {

        /// <summary>
        /// Constant CPU for ComputeType
        /// </summary>
        public static readonly ComputeType CPU = new ComputeType("CPU");
        /// <summary>
        /// Constant GPU_AND_CPU for ComputeType
        /// </summary>
        public static readonly ComputeType GPU_AND_CPU = new ComputeType("GPU_AND_CPU");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeType FindValue(string value)
        {
            return FindValue<ComputeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceType.
    /// </summary>
    public class DataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant Archive for DataSourceType
        /// </summary>
        public static readonly DataSourceType Archive = new DataSourceType("Archive");
        /// <summary>
        /// Constant File for DataSourceType
        /// </summary>
        public static readonly DataSourceType File = new DataSourceType("File");
        /// <summary>
        /// Constant Prefix for DataSourceType
        /// </summary>
        public static readonly DataSourceType Prefix = new DataSourceType("Prefix");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceType FindValue(string value)
        {
            return FindValue<DataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentJobErrorCode.
    /// </summary>
    public class DeploymentJobErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BadLambdaAssociated for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode BadLambdaAssociated = new DeploymentJobErrorCode("BadLambdaAssociated");
        /// <summary>
        /// Constant BadPermissionError for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode BadPermissionError = new DeploymentJobErrorCode("BadPermissionError");
        /// <summary>
        /// Constant DeploymentFleetDoesNotExist for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode DeploymentFleetDoesNotExist = new DeploymentJobErrorCode("DeploymentFleetDoesNotExist");
        /// <summary>
        /// Constant DownloadConditionFailed for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode DownloadConditionFailed = new DeploymentJobErrorCode("DownloadConditionFailed");
        /// <summary>
        /// Constant EnvironmentSetupError for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode EnvironmentSetupError = new DeploymentJobErrorCode("EnvironmentSetupError");
        /// <summary>
        /// Constant EtagMismatch for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode EtagMismatch = new DeploymentJobErrorCode("EtagMismatch");
        /// <summary>
        /// Constant ExtractingBundleFailure for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode ExtractingBundleFailure = new DeploymentJobErrorCode("ExtractingBundleFailure");
        /// <summary>
        /// Constant FailureThresholdBreached for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode FailureThresholdBreached = new DeploymentJobErrorCode("FailureThresholdBreached");
        /// <summary>
        /// Constant FleetDeploymentTimeout for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode FleetDeploymentTimeout = new DeploymentJobErrorCode("FleetDeploymentTimeout");
        /// <summary>
        /// Constant GreengrassDeploymentFailed for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode GreengrassDeploymentFailed = new DeploymentJobErrorCode("GreengrassDeploymentFailed");
        /// <summary>
        /// Constant GreengrassGroupVersionDoesNotExist for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode GreengrassGroupVersionDoesNotExist = new DeploymentJobErrorCode("GreengrassGroupVersionDoesNotExist");
        /// <summary>
        /// Constant InternalServerError for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode InternalServerError = new DeploymentJobErrorCode("InternalServerError");
        /// <summary>
        /// Constant InvalidGreengrassGroup for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode InvalidGreengrassGroup = new DeploymentJobErrorCode("InvalidGreengrassGroup");
        /// <summary>
        /// Constant LambdaDeleted for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode LambdaDeleted = new DeploymentJobErrorCode("LambdaDeleted");
        /// <summary>
        /// Constant MissingRobotApplicationArchitecture for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode MissingRobotApplicationArchitecture = new DeploymentJobErrorCode("MissingRobotApplicationArchitecture");
        /// <summary>
        /// Constant MissingRobotArchitecture for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode MissingRobotArchitecture = new DeploymentJobErrorCode("MissingRobotArchitecture");
        /// <summary>
        /// Constant MissingRobotDeploymentResource for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode MissingRobotDeploymentResource = new DeploymentJobErrorCode("MissingRobotDeploymentResource");
        /// <summary>
        /// Constant PostLaunchFileFailure for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode PostLaunchFileFailure = new DeploymentJobErrorCode("PostLaunchFileFailure");
        /// <summary>
        /// Constant PreLaunchFileFailure for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode PreLaunchFileFailure = new DeploymentJobErrorCode("PreLaunchFileFailure");
        /// <summary>
        /// Constant ResourceNotFound for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode ResourceNotFound = new DeploymentJobErrorCode("ResourceNotFound");
        /// <summary>
        /// Constant RobotAgentConnectionTimeout for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode RobotAgentConnectionTimeout = new DeploymentJobErrorCode("RobotAgentConnectionTimeout");
        /// <summary>
        /// Constant RobotApplicationDoesNotExist for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode RobotApplicationDoesNotExist = new DeploymentJobErrorCode("RobotApplicationDoesNotExist");
        /// <summary>
        /// Constant RobotDeploymentAborted for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode RobotDeploymentAborted = new DeploymentJobErrorCode("RobotDeploymentAborted");
        /// <summary>
        /// Constant RobotDeploymentNoResponse for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode RobotDeploymentNoResponse = new DeploymentJobErrorCode("RobotDeploymentNoResponse");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentJobErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentJobErrorCode FindValue(string value)
        {
            return FindValue<DeploymentJobErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentJobErrorCode(string value)
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
        /// Constant Canceled for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus Canceled = new DeploymentStatus("Canceled");
        /// <summary>
        /// Constant Failed for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus Failed = new DeploymentStatus("Failed");
        /// <summary>
        /// Constant InProgress for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus InProgress = new DeploymentStatus("InProgress");
        /// <summary>
        /// Constant Pending for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus Pending = new DeploymentStatus("Pending");
        /// <summary>
        /// Constant Preparing for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus Preparing = new DeploymentStatus("Preparing");
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
    /// Constants used for properties of type ExitBehavior.
    /// </summary>
    public class ExitBehavior : ConstantClass
    {

        /// <summary>
        /// Constant FAIL for ExitBehavior
        /// </summary>
        public static readonly ExitBehavior FAIL = new ExitBehavior("FAIL");
        /// <summary>
        /// Constant RESTART for ExitBehavior
        /// </summary>
        public static readonly ExitBehavior RESTART = new ExitBehavior("RESTART");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExitBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExitBehavior FindValue(string value)
        {
            return FindValue<ExitBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExitBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailureBehavior.
    /// </summary>
    public class FailureBehavior : ConstantClass
    {

        /// <summary>
        /// Constant Continue for FailureBehavior
        /// </summary>
        public static readonly FailureBehavior Continue = new FailureBehavior("Continue");
        /// <summary>
        /// Constant Fail for FailureBehavior
        /// </summary>
        public static readonly FailureBehavior Fail = new FailureBehavior("Fail");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailureBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureBehavior FindValue(string value)
        {
            return FindValue<FailureBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RenderingEngineType.
    /// </summary>
    public class RenderingEngineType : ConstantClass
    {

        /// <summary>
        /// Constant OGRE for RenderingEngineType
        /// </summary>
        public static readonly RenderingEngineType OGRE = new RenderingEngineType("OGRE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RenderingEngineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RenderingEngineType FindValue(string value)
        {
            return FindValue<RenderingEngineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RenderingEngineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RobotDeploymentStep.
    /// </summary>
    public class RobotDeploymentStep : ConstantClass
    {

        /// <summary>
        /// Constant DownloadingExtracting for RobotDeploymentStep
        /// </summary>
        public static readonly RobotDeploymentStep DownloadingExtracting = new RobotDeploymentStep("DownloadingExtracting");
        /// <summary>
        /// Constant ExecutingDownloadCondition for RobotDeploymentStep
        /// </summary>
        public static readonly RobotDeploymentStep ExecutingDownloadCondition = new RobotDeploymentStep("ExecutingDownloadCondition");
        /// <summary>
        /// Constant ExecutingPostLaunch for RobotDeploymentStep
        /// </summary>
        public static readonly RobotDeploymentStep ExecutingPostLaunch = new RobotDeploymentStep("ExecutingPostLaunch");
        /// <summary>
        /// Constant ExecutingPreLaunch for RobotDeploymentStep
        /// </summary>
        public static readonly RobotDeploymentStep ExecutingPreLaunch = new RobotDeploymentStep("ExecutingPreLaunch");
        /// <summary>
        /// Constant Finished for RobotDeploymentStep
        /// </summary>
        public static readonly RobotDeploymentStep Finished = new RobotDeploymentStep("Finished");
        /// <summary>
        /// Constant Launching for RobotDeploymentStep
        /// </summary>
        public static readonly RobotDeploymentStep Launching = new RobotDeploymentStep("Launching");
        /// <summary>
        /// Constant Validating for RobotDeploymentStep
        /// </summary>
        public static readonly RobotDeploymentStep Validating = new RobotDeploymentStep("Validating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RobotDeploymentStep(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RobotDeploymentStep FindValue(string value)
        {
            return FindValue<RobotDeploymentStep>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RobotDeploymentStep(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RobotSoftwareSuiteType.
    /// </summary>
    public class RobotSoftwareSuiteType : ConstantClass
    {

        /// <summary>
        /// Constant General for RobotSoftwareSuiteType
        /// </summary>
        public static readonly RobotSoftwareSuiteType General = new RobotSoftwareSuiteType("General");
        /// <summary>
        /// Constant ROS for RobotSoftwareSuiteType
        /// </summary>
        public static readonly RobotSoftwareSuiteType ROS = new RobotSoftwareSuiteType("ROS");
        /// <summary>
        /// Constant ROS2 for RobotSoftwareSuiteType
        /// </summary>
        public static readonly RobotSoftwareSuiteType ROS2 = new RobotSoftwareSuiteType("ROS2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RobotSoftwareSuiteType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RobotSoftwareSuiteType FindValue(string value)
        {
            return FindValue<RobotSoftwareSuiteType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RobotSoftwareSuiteType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RobotSoftwareSuiteVersionType.
    /// </summary>
    public class RobotSoftwareSuiteVersionType : ConstantClass
    {

        /// <summary>
        /// Constant Dashing for RobotSoftwareSuiteVersionType
        /// </summary>
        public static readonly RobotSoftwareSuiteVersionType Dashing = new RobotSoftwareSuiteVersionType("Dashing");
        /// <summary>
        /// Constant Foxy for RobotSoftwareSuiteVersionType
        /// </summary>
        public static readonly RobotSoftwareSuiteVersionType Foxy = new RobotSoftwareSuiteVersionType("Foxy");
        /// <summary>
        /// Constant Kinetic for RobotSoftwareSuiteVersionType
        /// </summary>
        public static readonly RobotSoftwareSuiteVersionType Kinetic = new RobotSoftwareSuiteVersionType("Kinetic");
        /// <summary>
        /// Constant Melodic for RobotSoftwareSuiteVersionType
        /// </summary>
        public static readonly RobotSoftwareSuiteVersionType Melodic = new RobotSoftwareSuiteVersionType("Melodic");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RobotSoftwareSuiteVersionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RobotSoftwareSuiteVersionType FindValue(string value)
        {
            return FindValue<RobotSoftwareSuiteVersionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RobotSoftwareSuiteVersionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RobotStatus.
    /// </summary>
    public class RobotStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for RobotStatus
        /// </summary>
        public static readonly RobotStatus Available = new RobotStatus("Available");
        /// <summary>
        /// Constant Deploying for RobotStatus
        /// </summary>
        public static readonly RobotStatus Deploying = new RobotStatus("Deploying");
        /// <summary>
        /// Constant Failed for RobotStatus
        /// </summary>
        public static readonly RobotStatus Failed = new RobotStatus("Failed");
        /// <summary>
        /// Constant InSync for RobotStatus
        /// </summary>
        public static readonly RobotStatus InSync = new RobotStatus("InSync");
        /// <summary>
        /// Constant NoResponse for RobotStatus
        /// </summary>
        public static readonly RobotStatus NoResponse = new RobotStatus("NoResponse");
        /// <summary>
        /// Constant PendingNewDeployment for RobotStatus
        /// </summary>
        public static readonly RobotStatus PendingNewDeployment = new RobotStatus("PendingNewDeployment");
        /// <summary>
        /// Constant Registered for RobotStatus
        /// </summary>
        public static readonly RobotStatus Registered = new RobotStatus("Registered");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RobotStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RobotStatus FindValue(string value)
        {
            return FindValue<RobotStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RobotStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SimulationJobBatchErrorCode.
    /// </summary>
    public class SimulationJobBatchErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant InternalServiceError for SimulationJobBatchErrorCode
        /// </summary>
        public static readonly SimulationJobBatchErrorCode InternalServiceError = new SimulationJobBatchErrorCode("InternalServiceError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SimulationJobBatchErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SimulationJobBatchErrorCode FindValue(string value)
        {
            return FindValue<SimulationJobBatchErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SimulationJobBatchErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SimulationJobBatchStatus.
    /// </summary>
    public class SimulationJobBatchStatus : ConstantClass
    {

        /// <summary>
        /// Constant Canceled for SimulationJobBatchStatus
        /// </summary>
        public static readonly SimulationJobBatchStatus Canceled = new SimulationJobBatchStatus("Canceled");
        /// <summary>
        /// Constant Canceling for SimulationJobBatchStatus
        /// </summary>
        public static readonly SimulationJobBatchStatus Canceling = new SimulationJobBatchStatus("Canceling");
        /// <summary>
        /// Constant Completed for SimulationJobBatchStatus
        /// </summary>
        public static readonly SimulationJobBatchStatus Completed = new SimulationJobBatchStatus("Completed");
        /// <summary>
        /// Constant Completing for SimulationJobBatchStatus
        /// </summary>
        public static readonly SimulationJobBatchStatus Completing = new SimulationJobBatchStatus("Completing");
        /// <summary>
        /// Constant Failed for SimulationJobBatchStatus
        /// </summary>
        public static readonly SimulationJobBatchStatus Failed = new SimulationJobBatchStatus("Failed");
        /// <summary>
        /// Constant InProgress for SimulationJobBatchStatus
        /// </summary>
        public static readonly SimulationJobBatchStatus InProgress = new SimulationJobBatchStatus("InProgress");
        /// <summary>
        /// Constant Pending for SimulationJobBatchStatus
        /// </summary>
        public static readonly SimulationJobBatchStatus Pending = new SimulationJobBatchStatus("Pending");
        /// <summary>
        /// Constant TimedOut for SimulationJobBatchStatus
        /// </summary>
        public static readonly SimulationJobBatchStatus TimedOut = new SimulationJobBatchStatus("TimedOut");
        /// <summary>
        /// Constant TimingOut for SimulationJobBatchStatus
        /// </summary>
        public static readonly SimulationJobBatchStatus TimingOut = new SimulationJobBatchStatus("TimingOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SimulationJobBatchStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SimulationJobBatchStatus FindValue(string value)
        {
            return FindValue<SimulationJobBatchStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SimulationJobBatchStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SimulationJobErrorCode.
    /// </summary>
    public class SimulationJobErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BadPermissionsCloudwatchLogs for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode BadPermissionsCloudwatchLogs = new SimulationJobErrorCode("BadPermissionsCloudwatchLogs");
        /// <summary>
        /// Constant BadPermissionsRobotApplication for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode BadPermissionsRobotApplication = new SimulationJobErrorCode("BadPermissionsRobotApplication");
        /// <summary>
        /// Constant BadPermissionsS3Object for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode BadPermissionsS3Object = new SimulationJobErrorCode("BadPermissionsS3Object");
        /// <summary>
        /// Constant BadPermissionsS3Output for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode BadPermissionsS3Output = new SimulationJobErrorCode("BadPermissionsS3Output");
        /// <summary>
        /// Constant BadPermissionsSimulationApplication for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode BadPermissionsSimulationApplication = new SimulationJobErrorCode("BadPermissionsSimulationApplication");
        /// <summary>
        /// Constant BadPermissionsUserCredentials for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode BadPermissionsUserCredentials = new SimulationJobErrorCode("BadPermissionsUserCredentials");
        /// <summary>
        /// Constant BatchCanceled for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode BatchCanceled = new SimulationJobErrorCode("BatchCanceled");
        /// <summary>
        /// Constant BatchTimedOut for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode BatchTimedOut = new SimulationJobErrorCode("BatchTimedOut");
        /// <summary>
        /// Constant ENILimitExceeded for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode ENILimitExceeded = new SimulationJobErrorCode("ENILimitExceeded");
        /// <summary>
        /// Constant InternalServiceError for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode InternalServiceError = new SimulationJobErrorCode("InternalServiceError");
        /// <summary>
        /// Constant InvalidBundleRobotApplication for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode InvalidBundleRobotApplication = new SimulationJobErrorCode("InvalidBundleRobotApplication");
        /// <summary>
        /// Constant InvalidBundleSimulationApplication for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode InvalidBundleSimulationApplication = new SimulationJobErrorCode("InvalidBundleSimulationApplication");
        /// <summary>
        /// Constant InvalidInput for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode InvalidInput = new SimulationJobErrorCode("InvalidInput");
        /// <summary>
        /// Constant InvalidS3Resource for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode InvalidS3Resource = new SimulationJobErrorCode("InvalidS3Resource");
        /// <summary>
        /// Constant LimitExceeded for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode LimitExceeded = new SimulationJobErrorCode("LimitExceeded");
        /// <summary>
        /// Constant MismatchedEtag for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode MismatchedEtag = new SimulationJobErrorCode("MismatchedEtag");
        /// <summary>
        /// Constant RequestThrottled for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode RequestThrottled = new SimulationJobErrorCode("RequestThrottled");
        /// <summary>
        /// Constant ResourceNotFound for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode ResourceNotFound = new SimulationJobErrorCode("ResourceNotFound");
        /// <summary>
        /// Constant RobotApplicationCrash for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode RobotApplicationCrash = new SimulationJobErrorCode("RobotApplicationCrash");
        /// <summary>
        /// Constant RobotApplicationHealthCheckFailure for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode RobotApplicationHealthCheckFailure = new SimulationJobErrorCode("RobotApplicationHealthCheckFailure");
        /// <summary>
        /// Constant RobotApplicationVersionMismatchedEtag for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode RobotApplicationVersionMismatchedEtag = new SimulationJobErrorCode("RobotApplicationVersionMismatchedEtag");
        /// <summary>
        /// Constant SimulationApplicationCrash for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode SimulationApplicationCrash = new SimulationJobErrorCode("SimulationApplicationCrash");
        /// <summary>
        /// Constant SimulationApplicationHealthCheckFailure for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode SimulationApplicationHealthCheckFailure = new SimulationJobErrorCode("SimulationApplicationHealthCheckFailure");
        /// <summary>
        /// Constant SimulationApplicationVersionMismatchedEtag for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode SimulationApplicationVersionMismatchedEtag = new SimulationJobErrorCode("SimulationApplicationVersionMismatchedEtag");
        /// <summary>
        /// Constant SubnetIpLimitExceeded for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode SubnetIpLimitExceeded = new SimulationJobErrorCode("SubnetIpLimitExceeded");
        /// <summary>
        /// Constant ThrottlingError for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode ThrottlingError = new SimulationJobErrorCode("ThrottlingError");
        /// <summary>
        /// Constant UploadContentMismatchError for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode UploadContentMismatchError = new SimulationJobErrorCode("UploadContentMismatchError");
        /// <summary>
        /// Constant WrongRegionRobotApplication for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode WrongRegionRobotApplication = new SimulationJobErrorCode("WrongRegionRobotApplication");
        /// <summary>
        /// Constant WrongRegionS3Bucket for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode WrongRegionS3Bucket = new SimulationJobErrorCode("WrongRegionS3Bucket");
        /// <summary>
        /// Constant WrongRegionS3Output for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode WrongRegionS3Output = new SimulationJobErrorCode("WrongRegionS3Output");
        /// <summary>
        /// Constant WrongRegionSimulationApplication for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode WrongRegionSimulationApplication = new SimulationJobErrorCode("WrongRegionSimulationApplication");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SimulationJobErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SimulationJobErrorCode FindValue(string value)
        {
            return FindValue<SimulationJobErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SimulationJobErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SimulationJobStatus.
    /// </summary>
    public class SimulationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Canceled for SimulationJobStatus
        /// </summary>
        public static readonly SimulationJobStatus Canceled = new SimulationJobStatus("Canceled");
        /// <summary>
        /// Constant Completed for SimulationJobStatus
        /// </summary>
        public static readonly SimulationJobStatus Completed = new SimulationJobStatus("Completed");
        /// <summary>
        /// Constant Failed for SimulationJobStatus
        /// </summary>
        public static readonly SimulationJobStatus Failed = new SimulationJobStatus("Failed");
        /// <summary>
        /// Constant Pending for SimulationJobStatus
        /// </summary>
        public static readonly SimulationJobStatus Pending = new SimulationJobStatus("Pending");
        /// <summary>
        /// Constant Preparing for SimulationJobStatus
        /// </summary>
        public static readonly SimulationJobStatus Preparing = new SimulationJobStatus("Preparing");
        /// <summary>
        /// Constant Restarting for SimulationJobStatus
        /// </summary>
        public static readonly SimulationJobStatus Restarting = new SimulationJobStatus("Restarting");
        /// <summary>
        /// Constant Running for SimulationJobStatus
        /// </summary>
        public static readonly SimulationJobStatus Running = new SimulationJobStatus("Running");
        /// <summary>
        /// Constant RunningFailed for SimulationJobStatus
        /// </summary>
        public static readonly SimulationJobStatus RunningFailed = new SimulationJobStatus("RunningFailed");
        /// <summary>
        /// Constant Terminated for SimulationJobStatus
        /// </summary>
        public static readonly SimulationJobStatus Terminated = new SimulationJobStatus("Terminated");
        /// <summary>
        /// Constant Terminating for SimulationJobStatus
        /// </summary>
        public static readonly SimulationJobStatus Terminating = new SimulationJobStatus("Terminating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SimulationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SimulationJobStatus FindValue(string value)
        {
            return FindValue<SimulationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SimulationJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SimulationSoftwareSuiteType.
    /// </summary>
    public class SimulationSoftwareSuiteType : ConstantClass
    {

        /// <summary>
        /// Constant Gazebo for SimulationSoftwareSuiteType
        /// </summary>
        public static readonly SimulationSoftwareSuiteType Gazebo = new SimulationSoftwareSuiteType("Gazebo");
        /// <summary>
        /// Constant RosbagPlay for SimulationSoftwareSuiteType
        /// </summary>
        public static readonly SimulationSoftwareSuiteType RosbagPlay = new SimulationSoftwareSuiteType("RosbagPlay");
        /// <summary>
        /// Constant SimulationRuntime for SimulationSoftwareSuiteType
        /// </summary>
        public static readonly SimulationSoftwareSuiteType SimulationRuntime = new SimulationSoftwareSuiteType("SimulationRuntime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SimulationSoftwareSuiteType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SimulationSoftwareSuiteType FindValue(string value)
        {
            return FindValue<SimulationSoftwareSuiteType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SimulationSoftwareSuiteType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UploadBehavior.
    /// </summary>
    public class UploadBehavior : ConstantClass
    {

        /// <summary>
        /// Constant UPLOAD_ON_TERMINATE for UploadBehavior
        /// </summary>
        public static readonly UploadBehavior UPLOAD_ON_TERMINATE = new UploadBehavior("UPLOAD_ON_TERMINATE");
        /// <summary>
        /// Constant UPLOAD_ROLLING_AUTO_REMOVE for UploadBehavior
        /// </summary>
        public static readonly UploadBehavior UPLOAD_ROLLING_AUTO_REMOVE = new UploadBehavior("UPLOAD_ROLLING_AUTO_REMOVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UploadBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UploadBehavior FindValue(string value)
        {
            return FindValue<UploadBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UploadBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorldExportJobErrorCode.
    /// </summary>
    public class WorldExportJobErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for WorldExportJobErrorCode
        /// </summary>
        public static readonly WorldExportJobErrorCode AccessDenied = new WorldExportJobErrorCode("AccessDenied");
        /// <summary>
        /// Constant InternalServiceError for WorldExportJobErrorCode
        /// </summary>
        public static readonly WorldExportJobErrorCode InternalServiceError = new WorldExportJobErrorCode("InternalServiceError");
        /// <summary>
        /// Constant InvalidInput for WorldExportJobErrorCode
        /// </summary>
        public static readonly WorldExportJobErrorCode InvalidInput = new WorldExportJobErrorCode("InvalidInput");
        /// <summary>
        /// Constant LimitExceeded for WorldExportJobErrorCode
        /// </summary>
        public static readonly WorldExportJobErrorCode LimitExceeded = new WorldExportJobErrorCode("LimitExceeded");
        /// <summary>
        /// Constant RequestThrottled for WorldExportJobErrorCode
        /// </summary>
        public static readonly WorldExportJobErrorCode RequestThrottled = new WorldExportJobErrorCode("RequestThrottled");
        /// <summary>
        /// Constant ResourceNotFound for WorldExportJobErrorCode
        /// </summary>
        public static readonly WorldExportJobErrorCode ResourceNotFound = new WorldExportJobErrorCode("ResourceNotFound");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorldExportJobErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorldExportJobErrorCode FindValue(string value)
        {
            return FindValue<WorldExportJobErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorldExportJobErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorldExportJobStatus.
    /// </summary>
    public class WorldExportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Canceled for WorldExportJobStatus
        /// </summary>
        public static readonly WorldExportJobStatus Canceled = new WorldExportJobStatus("Canceled");
        /// <summary>
        /// Constant Canceling for WorldExportJobStatus
        /// </summary>
        public static readonly WorldExportJobStatus Canceling = new WorldExportJobStatus("Canceling");
        /// <summary>
        /// Constant Completed for WorldExportJobStatus
        /// </summary>
        public static readonly WorldExportJobStatus Completed = new WorldExportJobStatus("Completed");
        /// <summary>
        /// Constant Failed for WorldExportJobStatus
        /// </summary>
        public static readonly WorldExportJobStatus Failed = new WorldExportJobStatus("Failed");
        /// <summary>
        /// Constant Pending for WorldExportJobStatus
        /// </summary>
        public static readonly WorldExportJobStatus Pending = new WorldExportJobStatus("Pending");
        /// <summary>
        /// Constant Running for WorldExportJobStatus
        /// </summary>
        public static readonly WorldExportJobStatus Running = new WorldExportJobStatus("Running");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorldExportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorldExportJobStatus FindValue(string value)
        {
            return FindValue<WorldExportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorldExportJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorldGenerationJobErrorCode.
    /// </summary>
    public class WorldGenerationJobErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AllWorldGenerationFailed for WorldGenerationJobErrorCode
        /// </summary>
        public static readonly WorldGenerationJobErrorCode AllWorldGenerationFailed = new WorldGenerationJobErrorCode("AllWorldGenerationFailed");
        /// <summary>
        /// Constant InternalServiceError for WorldGenerationJobErrorCode
        /// </summary>
        public static readonly WorldGenerationJobErrorCode InternalServiceError = new WorldGenerationJobErrorCode("InternalServiceError");
        /// <summary>
        /// Constant InvalidInput for WorldGenerationJobErrorCode
        /// </summary>
        public static readonly WorldGenerationJobErrorCode InvalidInput = new WorldGenerationJobErrorCode("InvalidInput");
        /// <summary>
        /// Constant LimitExceeded for WorldGenerationJobErrorCode
        /// </summary>
        public static readonly WorldGenerationJobErrorCode LimitExceeded = new WorldGenerationJobErrorCode("LimitExceeded");
        /// <summary>
        /// Constant RequestThrottled for WorldGenerationJobErrorCode
        /// </summary>
        public static readonly WorldGenerationJobErrorCode RequestThrottled = new WorldGenerationJobErrorCode("RequestThrottled");
        /// <summary>
        /// Constant ResourceNotFound for WorldGenerationJobErrorCode
        /// </summary>
        public static readonly WorldGenerationJobErrorCode ResourceNotFound = new WorldGenerationJobErrorCode("ResourceNotFound");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorldGenerationJobErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorldGenerationJobErrorCode FindValue(string value)
        {
            return FindValue<WorldGenerationJobErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorldGenerationJobErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorldGenerationJobStatus.
    /// </summary>
    public class WorldGenerationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Canceled for WorldGenerationJobStatus
        /// </summary>
        public static readonly WorldGenerationJobStatus Canceled = new WorldGenerationJobStatus("Canceled");
        /// <summary>
        /// Constant Canceling for WorldGenerationJobStatus
        /// </summary>
        public static readonly WorldGenerationJobStatus Canceling = new WorldGenerationJobStatus("Canceling");
        /// <summary>
        /// Constant Completed for WorldGenerationJobStatus
        /// </summary>
        public static readonly WorldGenerationJobStatus Completed = new WorldGenerationJobStatus("Completed");
        /// <summary>
        /// Constant Failed for WorldGenerationJobStatus
        /// </summary>
        public static readonly WorldGenerationJobStatus Failed = new WorldGenerationJobStatus("Failed");
        /// <summary>
        /// Constant PartialFailed for WorldGenerationJobStatus
        /// </summary>
        public static readonly WorldGenerationJobStatus PartialFailed = new WorldGenerationJobStatus("PartialFailed");
        /// <summary>
        /// Constant Pending for WorldGenerationJobStatus
        /// </summary>
        public static readonly WorldGenerationJobStatus Pending = new WorldGenerationJobStatus("Pending");
        /// <summary>
        /// Constant Running for WorldGenerationJobStatus
        /// </summary>
        public static readonly WorldGenerationJobStatus Running = new WorldGenerationJobStatus("Running");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorldGenerationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorldGenerationJobStatus FindValue(string value)
        {
            return FindValue<WorldGenerationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorldGenerationJobStatus(string value)
        {
            return FindValue(value);
        }
    }

}