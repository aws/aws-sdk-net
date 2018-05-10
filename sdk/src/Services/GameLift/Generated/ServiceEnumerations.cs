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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GameLift
{

    /// <summary>
    /// Constants used for properties of type AcceptanceType.
    /// </summary>
    public class AcceptanceType : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPT for AcceptanceType
        /// </summary>
        public static readonly AcceptanceType ACCEPT = new AcceptanceType("ACCEPT");
        /// <summary>
        /// Constant REJECT for AcceptanceType
        /// </summary>
        public static readonly AcceptanceType REJECT = new AcceptanceType("REJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceptanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceptanceType FindValue(string value)
        {
            return FindValue<AcceptanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceptanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BuildStatus.
    /// </summary>
    public class BuildStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for BuildStatus
        /// </summary>
        public static readonly BuildStatus FAILED = new BuildStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZED for BuildStatus
        /// </summary>
        public static readonly BuildStatus INITIALIZED = new BuildStatus("INITIALIZED");
        /// <summary>
        /// Constant READY for BuildStatus
        /// </summary>
        public static readonly BuildStatus READY = new BuildStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BuildStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BuildStatus FindValue(string value)
        {
            return FindValue<BuildStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BuildStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonOperatorType.
    /// </summary>
    public class ComparisonOperatorType : ConstantClass
    {

        /// <summary>
        /// Constant GreaterThanOrEqualToThreshold for ComparisonOperatorType
        /// </summary>
        public static readonly ComparisonOperatorType GreaterThanOrEqualToThreshold = new ComparisonOperatorType("GreaterThanOrEqualToThreshold");
        /// <summary>
        /// Constant GreaterThanThreshold for ComparisonOperatorType
        /// </summary>
        public static readonly ComparisonOperatorType GreaterThanThreshold = new ComparisonOperatorType("GreaterThanThreshold");
        /// <summary>
        /// Constant LessThanOrEqualToThreshold for ComparisonOperatorType
        /// </summary>
        public static readonly ComparisonOperatorType LessThanOrEqualToThreshold = new ComparisonOperatorType("LessThanOrEqualToThreshold");
        /// <summary>
        /// Constant LessThanThreshold for ComparisonOperatorType
        /// </summary>
        public static readonly ComparisonOperatorType LessThanThreshold = new ComparisonOperatorType("LessThanThreshold");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperatorType FindValue(string value)
        {
            return FindValue<ComparisonOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EC2InstanceType.
    /// </summary>
    public class EC2InstanceType : ConstantClass
    {

        /// <summary>
        /// Constant C32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C32xlarge = new EC2InstanceType("c3.2xlarge");
        /// <summary>
        /// Constant C34xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C34xlarge = new EC2InstanceType("c3.4xlarge");
        /// <summary>
        /// Constant C38xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C38xlarge = new EC2InstanceType("c3.8xlarge");
        /// <summary>
        /// Constant C3Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C3Large = new EC2InstanceType("c3.large");
        /// <summary>
        /// Constant C3Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C3Xlarge = new EC2InstanceType("c3.xlarge");
        /// <summary>
        /// Constant C42xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C42xlarge = new EC2InstanceType("c4.2xlarge");
        /// <summary>
        /// Constant C44xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C44xlarge = new EC2InstanceType("c4.4xlarge");
        /// <summary>
        /// Constant C48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C48xlarge = new EC2InstanceType("c4.8xlarge");
        /// <summary>
        /// Constant C4Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C4Large = new EC2InstanceType("c4.large");
        /// <summary>
        /// Constant C4Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C4Xlarge = new EC2InstanceType("c4.xlarge");
        /// <summary>
        /// Constant M32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M32xlarge = new EC2InstanceType("m3.2xlarge");
        /// <summary>
        /// Constant M3Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M3Large = new EC2InstanceType("m3.large");
        /// <summary>
        /// Constant M3Medium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M3Medium = new EC2InstanceType("m3.medium");
        /// <summary>
        /// Constant M3Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M3Xlarge = new EC2InstanceType("m3.xlarge");
        /// <summary>
        /// Constant M410xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M410xlarge = new EC2InstanceType("m4.10xlarge");
        /// <summary>
        /// Constant M42xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M42xlarge = new EC2InstanceType("m4.2xlarge");
        /// <summary>
        /// Constant M44xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M44xlarge = new EC2InstanceType("m4.4xlarge");
        /// <summary>
        /// Constant M4Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M4Large = new EC2InstanceType("m4.large");
        /// <summary>
        /// Constant M4Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M4Xlarge = new EC2InstanceType("m4.xlarge");
        /// <summary>
        /// Constant R32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R32xlarge = new EC2InstanceType("r3.2xlarge");
        /// <summary>
        /// Constant R34xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R34xlarge = new EC2InstanceType("r3.4xlarge");
        /// <summary>
        /// Constant R38xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R38xlarge = new EC2InstanceType("r3.8xlarge");
        /// <summary>
        /// Constant R3Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R3Large = new EC2InstanceType("r3.large");
        /// <summary>
        /// Constant R3Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R3Xlarge = new EC2InstanceType("r3.xlarge");
        /// <summary>
        /// Constant R416xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R416xlarge = new EC2InstanceType("r4.16xlarge");
        /// <summary>
        /// Constant R42xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R42xlarge = new EC2InstanceType("r4.2xlarge");
        /// <summary>
        /// Constant R44xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R44xlarge = new EC2InstanceType("r4.4xlarge");
        /// <summary>
        /// Constant R48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R48xlarge = new EC2InstanceType("r4.8xlarge");
        /// <summary>
        /// Constant R4Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R4Large = new EC2InstanceType("r4.large");
        /// <summary>
        /// Constant R4Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R4Xlarge = new EC2InstanceType("r4.xlarge");
        /// <summary>
        /// Constant T2Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType T2Large = new EC2InstanceType("t2.large");
        /// <summary>
        /// Constant T2Medium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType T2Medium = new EC2InstanceType("t2.medium");
        /// <summary>
        /// Constant T2Micro for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType T2Micro = new EC2InstanceType("t2.micro");
        /// <summary>
        /// Constant T2Small for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType T2Small = new EC2InstanceType("t2.small");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EC2InstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EC2InstanceType FindValue(string value)
        {
            return FindValue<EC2InstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EC2InstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventCode.
    /// </summary>
    public class EventCode : ConstantClass
    {

        /// <summary>
        /// Constant FLEET_ACTIVATION_FAILED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_ACTIVATION_FAILED = new EventCode("FLEET_ACTIVATION_FAILED");
        /// <summary>
        /// Constant FLEET_ACTIVATION_FAILED_NO_INSTANCES for EventCode
        /// </summary>
        public static readonly EventCode FLEET_ACTIVATION_FAILED_NO_INSTANCES = new EventCode("FLEET_ACTIVATION_FAILED_NO_INSTANCES");
        /// <summary>
        /// Constant FLEET_BINARY_DOWNLOAD_FAILED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_BINARY_DOWNLOAD_FAILED = new EventCode("FLEET_BINARY_DOWNLOAD_FAILED");
        /// <summary>
        /// Constant FLEET_CREATED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_CREATED = new EventCode("FLEET_CREATED");
        /// <summary>
        /// Constant FLEET_CREATION_EXTRACTING_BUILD for EventCode
        /// </summary>
        public static readonly EventCode FLEET_CREATION_EXTRACTING_BUILD = new EventCode("FLEET_CREATION_EXTRACTING_BUILD");
        /// <summary>
        /// Constant FLEET_CREATION_RUNNING_INSTALLER for EventCode
        /// </summary>
        public static readonly EventCode FLEET_CREATION_RUNNING_INSTALLER = new EventCode("FLEET_CREATION_RUNNING_INSTALLER");
        /// <summary>
        /// Constant FLEET_CREATION_VALIDATING_RUNTIME_CONFIG for EventCode
        /// </summary>
        public static readonly EventCode FLEET_CREATION_VALIDATING_RUNTIME_CONFIG = new EventCode("FLEET_CREATION_VALIDATING_RUNTIME_CONFIG");
        /// <summary>
        /// Constant FLEET_DELETED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_DELETED = new EventCode("FLEET_DELETED");
        /// <summary>
        /// Constant FLEET_INITIALIZATION_FAILED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_INITIALIZATION_FAILED = new EventCode("FLEET_INITIALIZATION_FAILED");
        /// <summary>
        /// Constant FLEET_NEW_GAME_SESSION_PROTECTION_POLICY_UPDATED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_NEW_GAME_SESSION_PROTECTION_POLICY_UPDATED = new EventCode("FLEET_NEW_GAME_SESSION_PROTECTION_POLICY_UPDATED");
        /// <summary>
        /// Constant FLEET_SCALING_EVENT for EventCode
        /// </summary>
        public static readonly EventCode FLEET_SCALING_EVENT = new EventCode("FLEET_SCALING_EVENT");
        /// <summary>
        /// Constant FLEET_STATE_ACTIVATING for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_ACTIVATING = new EventCode("FLEET_STATE_ACTIVATING");
        /// <summary>
        /// Constant FLEET_STATE_ACTIVE for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_ACTIVE = new EventCode("FLEET_STATE_ACTIVE");
        /// <summary>
        /// Constant FLEET_STATE_BUILDING for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_BUILDING = new EventCode("FLEET_STATE_BUILDING");
        /// <summary>
        /// Constant FLEET_STATE_DOWNLOADING for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_DOWNLOADING = new EventCode("FLEET_STATE_DOWNLOADING");
        /// <summary>
        /// Constant FLEET_STATE_ERROR for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_ERROR = new EventCode("FLEET_STATE_ERROR");
        /// <summary>
        /// Constant FLEET_STATE_VALIDATING for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_VALIDATING = new EventCode("FLEET_STATE_VALIDATING");
        /// <summary>
        /// Constant FLEET_VALIDATION_EXECUTABLE_RUNTIME_FAILURE for EventCode
        /// </summary>
        public static readonly EventCode FLEET_VALIDATION_EXECUTABLE_RUNTIME_FAILURE = new EventCode("FLEET_VALIDATION_EXECUTABLE_RUNTIME_FAILURE");
        /// <summary>
        /// Constant FLEET_VALIDATION_LAUNCH_PATH_NOT_FOUND for EventCode
        /// </summary>
        public static readonly EventCode FLEET_VALIDATION_LAUNCH_PATH_NOT_FOUND = new EventCode("FLEET_VALIDATION_LAUNCH_PATH_NOT_FOUND");
        /// <summary>
        /// Constant FLEET_VALIDATION_TIMED_OUT for EventCode
        /// </summary>
        public static readonly EventCode FLEET_VALIDATION_TIMED_OUT = new EventCode("FLEET_VALIDATION_TIMED_OUT");
        /// <summary>
        /// Constant FLEET_VPC_PEERING_DELETED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_VPC_PEERING_DELETED = new EventCode("FLEET_VPC_PEERING_DELETED");
        /// <summary>
        /// Constant FLEET_VPC_PEERING_FAILED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_VPC_PEERING_FAILED = new EventCode("FLEET_VPC_PEERING_FAILED");
        /// <summary>
        /// Constant FLEET_VPC_PEERING_SUCCEEDED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_VPC_PEERING_SUCCEEDED = new EventCode("FLEET_VPC_PEERING_SUCCEEDED");
        /// <summary>
        /// Constant GAME_SESSION_ACTIVATION_TIMEOUT for EventCode
        /// </summary>
        public static readonly EventCode GAME_SESSION_ACTIVATION_TIMEOUT = new EventCode("GAME_SESSION_ACTIVATION_TIMEOUT");
        /// <summary>
        /// Constant GENERIC_EVENT for EventCode
        /// </summary>
        public static readonly EventCode GENERIC_EVENT = new EventCode("GENERIC_EVENT");
        /// <summary>
        /// Constant INSTANCE_INTERRUPTED for EventCode
        /// </summary>
        public static readonly EventCode INSTANCE_INTERRUPTED = new EventCode("INSTANCE_INTERRUPTED");
        /// <summary>
        /// Constant SERVER_PROCESS_CRASHED for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_CRASHED = new EventCode("SERVER_PROCESS_CRASHED");
        /// <summary>
        /// Constant SERVER_PROCESS_FORCE_TERMINATED for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_FORCE_TERMINATED = new EventCode("SERVER_PROCESS_FORCE_TERMINATED");
        /// <summary>
        /// Constant SERVER_PROCESS_INVALID_PATH for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_INVALID_PATH = new EventCode("SERVER_PROCESS_INVALID_PATH");
        /// <summary>
        /// Constant SERVER_PROCESS_PROCESS_EXIT_TIMEOUT for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_PROCESS_EXIT_TIMEOUT = new EventCode("SERVER_PROCESS_PROCESS_EXIT_TIMEOUT");
        /// <summary>
        /// Constant SERVER_PROCESS_PROCESS_READY_TIMEOUT for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_PROCESS_READY_TIMEOUT = new EventCode("SERVER_PROCESS_PROCESS_READY_TIMEOUT");
        /// <summary>
        /// Constant SERVER_PROCESS_SDK_INITIALIZATION_TIMEOUT for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_SDK_INITIALIZATION_TIMEOUT = new EventCode("SERVER_PROCESS_SDK_INITIALIZATION_TIMEOUT");
        /// <summary>
        /// Constant SERVER_PROCESS_TERMINATED_UNHEALTHY for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_TERMINATED_UNHEALTHY = new EventCode("SERVER_PROCESS_TERMINATED_UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventCode FindValue(string value)
        {
            return FindValue<EventCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetAction.
    /// </summary>
    public class FleetAction : ConstantClass
    {

        /// <summary>
        /// Constant AUTO_SCALING for FleetAction
        /// </summary>
        public static readonly FleetAction AUTO_SCALING = new FleetAction("AUTO_SCALING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetAction FindValue(string value)
        {
            return FindValue<FleetAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetStatus.
    /// </summary>
    public class FleetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for FleetStatus
        /// </summary>
        public static readonly FleetStatus ACTIVATING = new FleetStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for FleetStatus
        /// </summary>
        public static readonly FleetStatus ACTIVE = new FleetStatus("ACTIVE");
        /// <summary>
        /// Constant BUILDING for FleetStatus
        /// </summary>
        public static readonly FleetStatus BUILDING = new FleetStatus("BUILDING");
        /// <summary>
        /// Constant DELETING for FleetStatus
        /// </summary>
        public static readonly FleetStatus DELETING = new FleetStatus("DELETING");
        /// <summary>
        /// Constant DOWNLOADING for FleetStatus
        /// </summary>
        public static readonly FleetStatus DOWNLOADING = new FleetStatus("DOWNLOADING");
        /// <summary>
        /// Constant ERROR for FleetStatus
        /// </summary>
        public static readonly FleetStatus ERROR = new FleetStatus("ERROR");
        /// <summary>
        /// Constant NEW for FleetStatus
        /// </summary>
        public static readonly FleetStatus NEW = new FleetStatus("NEW");
        /// <summary>
        /// Constant TERMINATED for FleetStatus
        /// </summary>
        public static readonly FleetStatus TERMINATED = new FleetStatus("TERMINATED");
        /// <summary>
        /// Constant VALIDATING for FleetStatus
        /// </summary>
        public static readonly FleetStatus VALIDATING = new FleetStatus("VALIDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetStatus FindValue(string value)
        {
            return FindValue<FleetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetType.
    /// </summary>
    public class FleetType : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for FleetType
        /// </summary>
        public static readonly FleetType ON_DEMAND = new FleetType("ON_DEMAND");
        /// <summary>
        /// Constant SPOT for FleetType
        /// </summary>
        public static readonly FleetType SPOT = new FleetType("SPOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetType FindValue(string value)
        {
            return FindValue<FleetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameSessionPlacementState.
    /// </summary>
    public class GameSessionPlacementState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for GameSessionPlacementState
        /// </summary>
        public static readonly GameSessionPlacementState CANCELLED = new GameSessionPlacementState("CANCELLED");
        /// <summary>
        /// Constant FULFILLED for GameSessionPlacementState
        /// </summary>
        public static readonly GameSessionPlacementState FULFILLED = new GameSessionPlacementState("FULFILLED");
        /// <summary>
        /// Constant PENDING for GameSessionPlacementState
        /// </summary>
        public static readonly GameSessionPlacementState PENDING = new GameSessionPlacementState("PENDING");
        /// <summary>
        /// Constant TIMED_OUT for GameSessionPlacementState
        /// </summary>
        public static readonly GameSessionPlacementState TIMED_OUT = new GameSessionPlacementState("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameSessionPlacementState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameSessionPlacementState FindValue(string value)
        {
            return FindValue<GameSessionPlacementState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameSessionPlacementState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameSessionStatus.
    /// </summary>
    public class GameSessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for GameSessionStatus
        /// </summary>
        public static readonly GameSessionStatus ACTIVATING = new GameSessionStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for GameSessionStatus
        /// </summary>
        public static readonly GameSessionStatus ACTIVE = new GameSessionStatus("ACTIVE");
        /// <summary>
        /// Constant ERROR for GameSessionStatus
        /// </summary>
        public static readonly GameSessionStatus ERROR = new GameSessionStatus("ERROR");
        /// <summary>
        /// Constant TERMINATED for GameSessionStatus
        /// </summary>
        public static readonly GameSessionStatus TERMINATED = new GameSessionStatus("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for GameSessionStatus
        /// </summary>
        public static readonly GameSessionStatus TERMINATING = new GameSessionStatus("TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameSessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameSessionStatus FindValue(string value)
        {
            return FindValue<GameSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameSessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameSessionStatusReason.
    /// </summary>
    public class GameSessionStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant INTERRUPTED for GameSessionStatusReason
        /// </summary>
        public static readonly GameSessionStatusReason INTERRUPTED = new GameSessionStatusReason("INTERRUPTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameSessionStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameSessionStatusReason FindValue(string value)
        {
            return FindValue<GameSessionStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameSessionStatusReason(string value)
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
        /// Constant ACTIVE for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus ACTIVE = new InstanceStatus("ACTIVE");
        /// <summary>
        /// Constant PENDING for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus PENDING = new InstanceStatus("PENDING");
        /// <summary>
        /// Constant TERMINATING for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus TERMINATING = new InstanceStatus("TERMINATING");

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
    /// Constants used for properties of type IpProtocol.
    /// </summary>
    public class IpProtocol : ConstantClass
    {

        /// <summary>
        /// Constant TCP for IpProtocol
        /// </summary>
        public static readonly IpProtocol TCP = new IpProtocol("TCP");
        /// <summary>
        /// Constant UDP for IpProtocol
        /// </summary>
        public static readonly IpProtocol UDP = new IpProtocol("UDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpProtocol FindValue(string value)
        {
            return FindValue<IpProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MatchmakingConfigurationStatus.
    /// </summary>
    public class MatchmakingConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus CANCELLED = new MatchmakingConfigurationStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus COMPLETED = new MatchmakingConfigurationStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus FAILED = new MatchmakingConfigurationStatus("FAILED");
        /// <summary>
        /// Constant PLACING for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus PLACING = new MatchmakingConfigurationStatus("PLACING");
        /// <summary>
        /// Constant QUEUED for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus QUEUED = new MatchmakingConfigurationStatus("QUEUED");
        /// <summary>
        /// Constant REQUIRES_ACCEPTANCE for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus REQUIRES_ACCEPTANCE = new MatchmakingConfigurationStatus("REQUIRES_ACCEPTANCE");
        /// <summary>
        /// Constant SEARCHING for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus SEARCHING = new MatchmakingConfigurationStatus("SEARCHING");
        /// <summary>
        /// Constant TIMED_OUT for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus TIMED_OUT = new MatchmakingConfigurationStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MatchmakingConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MatchmakingConfigurationStatus FindValue(string value)
        {
            return FindValue<MatchmakingConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MatchmakingConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricName.
    /// </summary>
    public class MetricName : ConstantClass
    {

        /// <summary>
        /// Constant ActivatingGameSessions for MetricName
        /// </summary>
        public static readonly MetricName ActivatingGameSessions = new MetricName("ActivatingGameSessions");
        /// <summary>
        /// Constant ActiveGameSessions for MetricName
        /// </summary>
        public static readonly MetricName ActiveGameSessions = new MetricName("ActiveGameSessions");
        /// <summary>
        /// Constant ActiveInstances for MetricName
        /// </summary>
        public static readonly MetricName ActiveInstances = new MetricName("ActiveInstances");
        /// <summary>
        /// Constant AvailableGameSessions for MetricName
        /// </summary>
        public static readonly MetricName AvailableGameSessions = new MetricName("AvailableGameSessions");
        /// <summary>
        /// Constant AvailablePlayerSessions for MetricName
        /// </summary>
        public static readonly MetricName AvailablePlayerSessions = new MetricName("AvailablePlayerSessions");
        /// <summary>
        /// Constant CurrentPlayerSessions for MetricName
        /// </summary>
        public static readonly MetricName CurrentPlayerSessions = new MetricName("CurrentPlayerSessions");
        /// <summary>
        /// Constant IdleInstances for MetricName
        /// </summary>
        public static readonly MetricName IdleInstances = new MetricName("IdleInstances");
        /// <summary>
        /// Constant PercentAvailableGameSessions for MetricName
        /// </summary>
        public static readonly MetricName PercentAvailableGameSessions = new MetricName("PercentAvailableGameSessions");
        /// <summary>
        /// Constant PercentIdleInstances for MetricName
        /// </summary>
        public static readonly MetricName PercentIdleInstances = new MetricName("PercentIdleInstances");
        /// <summary>
        /// Constant QueueDepth for MetricName
        /// </summary>
        public static readonly MetricName QueueDepth = new MetricName("QueueDepth");
        /// <summary>
        /// Constant WaitTime for MetricName
        /// </summary>
        public static readonly MetricName WaitTime = new MetricName("WaitTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricName FindValue(string value)
        {
            return FindValue<MetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperatingSystem.
    /// </summary>
    public class OperatingSystem : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_LINUX for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem AMAZON_LINUX = new OperatingSystem("AMAZON_LINUX");
        /// <summary>
        /// Constant WINDOWS_2012 for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem WINDOWS_2012 = new OperatingSystem("WINDOWS_2012");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperatingSystem(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperatingSystem FindValue(string value)
        {
            return FindValue<OperatingSystem>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperatingSystem(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlayerSessionCreationPolicy.
    /// </summary>
    public class PlayerSessionCreationPolicy : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPT_ALL for PlayerSessionCreationPolicy
        /// </summary>
        public static readonly PlayerSessionCreationPolicy ACCEPT_ALL = new PlayerSessionCreationPolicy("ACCEPT_ALL");
        /// <summary>
        /// Constant DENY_ALL for PlayerSessionCreationPolicy
        /// </summary>
        public static readonly PlayerSessionCreationPolicy DENY_ALL = new PlayerSessionCreationPolicy("DENY_ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlayerSessionCreationPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlayerSessionCreationPolicy FindValue(string value)
        {
            return FindValue<PlayerSessionCreationPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlayerSessionCreationPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlayerSessionStatus.
    /// </summary>
    public class PlayerSessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PlayerSessionStatus
        /// </summary>
        public static readonly PlayerSessionStatus ACTIVE = new PlayerSessionStatus("ACTIVE");
        /// <summary>
        /// Constant COMPLETED for PlayerSessionStatus
        /// </summary>
        public static readonly PlayerSessionStatus COMPLETED = new PlayerSessionStatus("COMPLETED");
        /// <summary>
        /// Constant RESERVED for PlayerSessionStatus
        /// </summary>
        public static readonly PlayerSessionStatus RESERVED = new PlayerSessionStatus("RESERVED");
        /// <summary>
        /// Constant TIMEDOUT for PlayerSessionStatus
        /// </summary>
        public static readonly PlayerSessionStatus TIMEDOUT = new PlayerSessionStatus("TIMEDOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlayerSessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlayerSessionStatus FindValue(string value)
        {
            return FindValue<PlayerSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlayerSessionStatus(string value)
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
        /// Constant RuleBased for PolicyType
        /// </summary>
        public static readonly PolicyType RuleBased = new PolicyType("RuleBased");
        /// <summary>
        /// Constant TargetBased for PolicyType
        /// </summary>
        public static readonly PolicyType TargetBased = new PolicyType("TargetBased");

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
    /// Constants used for properties of type ProtectionPolicy.
    /// </summary>
    public class ProtectionPolicy : ConstantClass
    {

        /// <summary>
        /// Constant FullProtection for ProtectionPolicy
        /// </summary>
        public static readonly ProtectionPolicy FullProtection = new ProtectionPolicy("FullProtection");
        /// <summary>
        /// Constant NoProtection for ProtectionPolicy
        /// </summary>
        public static readonly ProtectionPolicy NoProtection = new ProtectionPolicy("NoProtection");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectionPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectionPolicy FindValue(string value)
        {
            return FindValue<ProtectionPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectionPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoutingStrategyType.
    /// </summary>
    public class RoutingStrategyType : ConstantClass
    {

        /// <summary>
        /// Constant SIMPLE for RoutingStrategyType
        /// </summary>
        public static readonly RoutingStrategyType SIMPLE = new RoutingStrategyType("SIMPLE");
        /// <summary>
        /// Constant TERMINAL for RoutingStrategyType
        /// </summary>
        public static readonly RoutingStrategyType TERMINAL = new RoutingStrategyType("TERMINAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoutingStrategyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoutingStrategyType FindValue(string value)
        {
            return FindValue<RoutingStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoutingStrategyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingAdjustmentType.
    /// </summary>
    public class ScalingAdjustmentType : ConstantClass
    {

        /// <summary>
        /// Constant ChangeInCapacity for ScalingAdjustmentType
        /// </summary>
        public static readonly ScalingAdjustmentType ChangeInCapacity = new ScalingAdjustmentType("ChangeInCapacity");
        /// <summary>
        /// Constant ExactCapacity for ScalingAdjustmentType
        /// </summary>
        public static readonly ScalingAdjustmentType ExactCapacity = new ScalingAdjustmentType("ExactCapacity");
        /// <summary>
        /// Constant PercentChangeInCapacity for ScalingAdjustmentType
        /// </summary>
        public static readonly ScalingAdjustmentType PercentChangeInCapacity = new ScalingAdjustmentType("PercentChangeInCapacity");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingAdjustmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingAdjustmentType FindValue(string value)
        {
            return FindValue<ScalingAdjustmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingAdjustmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingStatusType.
    /// </summary>
    public class ScalingStatusType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType ACTIVE = new ScalingStatusType("ACTIVE");
        /// <summary>
        /// Constant DELETE_REQUESTED for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType DELETE_REQUESTED = new ScalingStatusType("DELETE_REQUESTED");
        /// <summary>
        /// Constant DELETED for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType DELETED = new ScalingStatusType("DELETED");
        /// <summary>
        /// Constant DELETING for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType DELETING = new ScalingStatusType("DELETING");
        /// <summary>
        /// Constant ERROR for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType ERROR = new ScalingStatusType("ERROR");
        /// <summary>
        /// Constant UPDATE_REQUESTED for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType UPDATE_REQUESTED = new ScalingStatusType("UPDATE_REQUESTED");
        /// <summary>
        /// Constant UPDATING for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType UPDATING = new ScalingStatusType("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingStatusType FindValue(string value)
        {
            return FindValue<ScalingStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingStatusType(string value)
        {
            return FindValue(value);
        }
    }

}