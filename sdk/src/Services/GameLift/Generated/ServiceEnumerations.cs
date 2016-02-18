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
        /// Constant FLEET_DELETED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_DELETED = new EventCode("FLEET_DELETED");
        /// <summary>
        /// Constant FLEET_INITIALIZATION_FAILED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_INITIALIZATION_FAILED = new EventCode("FLEET_INITIALIZATION_FAILED");
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
        /// Constant GENERIC_EVENT for EventCode
        /// </summary>
        public static readonly EventCode GENERIC_EVENT = new EventCode("GENERIC_EVENT");

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

}