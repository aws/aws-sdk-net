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
    /// Constants used for properties of type DeploymentJobErrorCode.
    /// </summary>
    public class DeploymentJobErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BadPermissionError for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode BadPermissionError = new DeploymentJobErrorCode("BadPermissionError");
        /// <summary>
        /// Constant ExtractingBundleFailure for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode ExtractingBundleFailure = new DeploymentJobErrorCode("ExtractingBundleFailure");
        /// <summary>
        /// Constant FailureThresholdBreached for DeploymentJobErrorCode
        /// </summary>
        public static readonly DeploymentJobErrorCode FailureThresholdBreached = new DeploymentJobErrorCode("FailureThresholdBreached");
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
    /// Constants used for properties of type RobotSoftwareSuiteType.
    /// </summary>
    public class RobotSoftwareSuiteType : ConstantClass
    {

        /// <summary>
        /// Constant ROS for RobotSoftwareSuiteType
        /// </summary>
        public static readonly RobotSoftwareSuiteType ROS = new RobotSoftwareSuiteType("ROS");

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
        /// Constant Kinetic for RobotSoftwareSuiteVersionType
        /// </summary>
        public static readonly RobotSoftwareSuiteVersionType Kinetic = new RobotSoftwareSuiteVersionType("Kinetic");

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
        /// Constant RobotApplicationCrash for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode RobotApplicationCrash = new SimulationJobErrorCode("RobotApplicationCrash");
        /// <summary>
        /// Constant RobotApplicationVersionMismatchedEtag for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode RobotApplicationVersionMismatchedEtag = new SimulationJobErrorCode("RobotApplicationVersionMismatchedEtag");
        /// <summary>
        /// Constant SimulationApplicationCrash for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode SimulationApplicationCrash = new SimulationJobErrorCode("SimulationApplicationCrash");
        /// <summary>
        /// Constant SimulationApplicationVersionMismatchedEtag for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode SimulationApplicationVersionMismatchedEtag = new SimulationJobErrorCode("SimulationApplicationVersionMismatchedEtag");
        /// <summary>
        /// Constant SubnetIpLimitExceeded for SimulationJobErrorCode
        /// </summary>
        public static readonly SimulationJobErrorCode SubnetIpLimitExceeded = new SimulationJobErrorCode("SubnetIpLimitExceeded");

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

}