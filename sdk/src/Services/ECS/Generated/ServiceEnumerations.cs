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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ECS
{

    /// <summary>
    /// Constants used for properties of type AgentUpdateStatus.
    /// </summary>
    public class AgentUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus FAILED = new AgentUpdateStatus("FAILED");
        /// <summary>
        /// Constant PENDING for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus PENDING = new AgentUpdateStatus("PENDING");
        /// <summary>
        /// Constant STAGED for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus STAGED = new AgentUpdateStatus("STAGED");
        /// <summary>
        /// Constant STAGING for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus STAGING = new AgentUpdateStatus("STAGING");
        /// <summary>
        /// Constant UPDATED for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus UPDATED = new AgentUpdateStatus("UPDATED");
        /// <summary>
        /// Constant UPDATING for AgentUpdateStatus
        /// </summary>
        public static readonly AgentUpdateStatus UPDATING = new AgentUpdateStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentUpdateStatus FindValue(string value)
        {
            return FindValue<AgentUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DesiredStatus.
    /// </summary>
    public class DesiredStatus : ConstantClass
    {

        /// <summary>
        /// Constant PENDING for DesiredStatus
        /// </summary>
        public static readonly DesiredStatus PENDING = new DesiredStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for DesiredStatus
        /// </summary>
        public static readonly DesiredStatus RUNNING = new DesiredStatus("RUNNING");
        /// <summary>
        /// Constant STOPPED for DesiredStatus
        /// </summary>
        public static readonly DesiredStatus STOPPED = new DesiredStatus("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DesiredStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DesiredStatus FindValue(string value)
        {
            return FindValue<DesiredStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DesiredStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogDriver.
    /// </summary>
    public class LogDriver : ConstantClass
    {

        /// <summary>
        /// Constant Awslogs for LogDriver
        /// </summary>
        public static readonly LogDriver Awslogs = new LogDriver("awslogs");
        /// <summary>
        /// Constant Fluentd for LogDriver
        /// </summary>
        public static readonly LogDriver Fluentd = new LogDriver("fluentd");
        /// <summary>
        /// Constant Gelf for LogDriver
        /// </summary>
        public static readonly LogDriver Gelf = new LogDriver("gelf");
        /// <summary>
        /// Constant Journald for LogDriver
        /// </summary>
        public static readonly LogDriver Journald = new LogDriver("journald");
        /// <summary>
        /// Constant JsonFile for LogDriver
        /// </summary>
        public static readonly LogDriver JsonFile = new LogDriver("json-file");
        /// <summary>
        /// Constant Splunk for LogDriver
        /// </summary>
        public static readonly LogDriver Splunk = new LogDriver("splunk");
        /// <summary>
        /// Constant Syslog for LogDriver
        /// </summary>
        public static readonly LogDriver Syslog = new LogDriver("syslog");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogDriver(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogDriver FindValue(string value)
        {
            return FindValue<LogDriver>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogDriver(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkMode.
    /// </summary>
    public class NetworkMode : ConstantClass
    {

        /// <summary>
        /// Constant Bridge for NetworkMode
        /// </summary>
        public static readonly NetworkMode Bridge = new NetworkMode("bridge");
        /// <summary>
        /// Constant Host for NetworkMode
        /// </summary>
        public static readonly NetworkMode Host = new NetworkMode("host");
        /// <summary>
        /// Constant None for NetworkMode
        /// </summary>
        public static readonly NetworkMode None = new NetworkMode("none");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkMode FindValue(string value)
        {
            return FindValue<NetworkMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlacementConstraintType.
    /// </summary>
    public class PlacementConstraintType : ConstantClass
    {

        /// <summary>
        /// Constant DistinctInstance for PlacementConstraintType
        /// </summary>
        public static readonly PlacementConstraintType DistinctInstance = new PlacementConstraintType("distinctInstance");
        /// <summary>
        /// Constant MemberOf for PlacementConstraintType
        /// </summary>
        public static readonly PlacementConstraintType MemberOf = new PlacementConstraintType("memberOf");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlacementConstraintType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementConstraintType FindValue(string value)
        {
            return FindValue<PlacementConstraintType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlacementConstraintType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlacementStrategyType.
    /// </summary>
    public class PlacementStrategyType : ConstantClass
    {

        /// <summary>
        /// Constant Binpack for PlacementStrategyType
        /// </summary>
        public static readonly PlacementStrategyType Binpack = new PlacementStrategyType("binpack");
        /// <summary>
        /// Constant Random for PlacementStrategyType
        /// </summary>
        public static readonly PlacementStrategyType Random = new PlacementStrategyType("random");
        /// <summary>
        /// Constant Spread for PlacementStrategyType
        /// </summary>
        public static readonly PlacementStrategyType Spread = new PlacementStrategyType("spread");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlacementStrategyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementStrategyType FindValue(string value)
        {
            return FindValue<PlacementStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlacementStrategyType(string value)
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
        /// Constant ASC for SortOrder
        /// </summary>
        public static readonly SortOrder ASC = new SortOrder("ASC");
        /// <summary>
        /// Constant DESC for SortOrder
        /// </summary>
        public static readonly SortOrder DESC = new SortOrder("DESC");

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
    /// Constants used for properties of type TargetType.
    /// </summary>
    public class TargetType : ConstantClass
    {

        /// <summary>
        /// Constant ContainerInstance for TargetType
        /// </summary>
        public static readonly TargetType ContainerInstance = new TargetType("container-instance");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetType FindValue(string value)
        {
            return FindValue<TargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskDefinitionFamilyStatus.
    /// </summary>
    public class TaskDefinitionFamilyStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TaskDefinitionFamilyStatus
        /// </summary>
        public static readonly TaskDefinitionFamilyStatus ACTIVE = new TaskDefinitionFamilyStatus("ACTIVE");
        /// <summary>
        /// Constant ALL for TaskDefinitionFamilyStatus
        /// </summary>
        public static readonly TaskDefinitionFamilyStatus ALL = new TaskDefinitionFamilyStatus("ALL");
        /// <summary>
        /// Constant INACTIVE for TaskDefinitionFamilyStatus
        /// </summary>
        public static readonly TaskDefinitionFamilyStatus INACTIVE = new TaskDefinitionFamilyStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskDefinitionFamilyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskDefinitionFamilyStatus FindValue(string value)
        {
            return FindValue<TaskDefinitionFamilyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskDefinitionFamilyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskDefinitionPlacementConstraintType.
    /// </summary>
    public class TaskDefinitionPlacementConstraintType : ConstantClass
    {

        /// <summary>
        /// Constant MemberOf for TaskDefinitionPlacementConstraintType
        /// </summary>
        public static readonly TaskDefinitionPlacementConstraintType MemberOf = new TaskDefinitionPlacementConstraintType("memberOf");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskDefinitionPlacementConstraintType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskDefinitionPlacementConstraintType FindValue(string value)
        {
            return FindValue<TaskDefinitionPlacementConstraintType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskDefinitionPlacementConstraintType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskDefinitionStatus.
    /// </summary>
    public class TaskDefinitionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TaskDefinitionStatus
        /// </summary>
        public static readonly TaskDefinitionStatus ACTIVE = new TaskDefinitionStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for TaskDefinitionStatus
        /// </summary>
        public static readonly TaskDefinitionStatus INACTIVE = new TaskDefinitionStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskDefinitionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskDefinitionStatus FindValue(string value)
        {
            return FindValue<TaskDefinitionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskDefinitionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransportProtocol.
    /// </summary>
    public class TransportProtocol : ConstantClass
    {

        /// <summary>
        /// Constant Tcp for TransportProtocol
        /// </summary>
        public static readonly TransportProtocol Tcp = new TransportProtocol("tcp");
        /// <summary>
        /// Constant Udp for TransportProtocol
        /// </summary>
        public static readonly TransportProtocol Udp = new TransportProtocol("udp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransportProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransportProtocol FindValue(string value)
        {
            return FindValue<TransportProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransportProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UlimitName.
    /// </summary>
    public class UlimitName : ConstantClass
    {

        /// <summary>
        /// Constant Core for UlimitName
        /// </summary>
        public static readonly UlimitName Core = new UlimitName("core");
        /// <summary>
        /// Constant Cpu for UlimitName
        /// </summary>
        public static readonly UlimitName Cpu = new UlimitName("cpu");
        /// <summary>
        /// Constant Data for UlimitName
        /// </summary>
        public static readonly UlimitName Data = new UlimitName("data");
        /// <summary>
        /// Constant Fsize for UlimitName
        /// </summary>
        public static readonly UlimitName Fsize = new UlimitName("fsize");
        /// <summary>
        /// Constant Locks for UlimitName
        /// </summary>
        public static readonly UlimitName Locks = new UlimitName("locks");
        /// <summary>
        /// Constant Memlock for UlimitName
        /// </summary>
        public static readonly UlimitName Memlock = new UlimitName("memlock");
        /// <summary>
        /// Constant Msgqueue for UlimitName
        /// </summary>
        public static readonly UlimitName Msgqueue = new UlimitName("msgqueue");
        /// <summary>
        /// Constant Nice for UlimitName
        /// </summary>
        public static readonly UlimitName Nice = new UlimitName("nice");
        /// <summary>
        /// Constant Nofile for UlimitName
        /// </summary>
        public static readonly UlimitName Nofile = new UlimitName("nofile");
        /// <summary>
        /// Constant Nproc for UlimitName
        /// </summary>
        public static readonly UlimitName Nproc = new UlimitName("nproc");
        /// <summary>
        /// Constant Rss for UlimitName
        /// </summary>
        public static readonly UlimitName Rss = new UlimitName("rss");
        /// <summary>
        /// Constant Rtprio for UlimitName
        /// </summary>
        public static readonly UlimitName Rtprio = new UlimitName("rtprio");
        /// <summary>
        /// Constant Rttime for UlimitName
        /// </summary>
        public static readonly UlimitName Rttime = new UlimitName("rttime");
        /// <summary>
        /// Constant Sigpending for UlimitName
        /// </summary>
        public static readonly UlimitName Sigpending = new UlimitName("sigpending");
        /// <summary>
        /// Constant Stack for UlimitName
        /// </summary>
        public static readonly UlimitName Stack = new UlimitName("stack");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UlimitName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UlimitName FindValue(string value)
        {
            return FindValue<UlimitName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UlimitName(string value)
        {
            return FindValue(value);
        }
    }

}