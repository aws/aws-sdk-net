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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.WorkSpaces
{

    /// <summary>
    /// Constants used for properties of type Compute.
    /// </summary>
    public class Compute : ConstantClass
    {

        /// <summary>
        /// Constant GRAPHICS for Compute
        /// </summary>
        public static readonly Compute GRAPHICS = new Compute("GRAPHICS");
        /// <summary>
        /// Constant PERFORMANCE for Compute
        /// </summary>
        public static readonly Compute PERFORMANCE = new Compute("PERFORMANCE");
        /// <summary>
        /// Constant POWER for Compute
        /// </summary>
        public static readonly Compute POWER = new Compute("POWER");
        /// <summary>
        /// Constant STANDARD for Compute
        /// </summary>
        public static readonly Compute STANDARD = new Compute("STANDARD");
        /// <summary>
        /// Constant VALUE_TYPE for Compute
        /// </summary>
        public static readonly Compute VALUE_TYPE = new Compute("VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Compute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Compute FindValue(string value)
        {
            return FindValue<Compute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Compute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionState.
    /// </summary>
    public class ConnectionState : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for ConnectionState
        /// </summary>
        public static readonly ConnectionState CONNECTED = new ConnectionState("CONNECTED");
        /// <summary>
        /// Constant DISCONNECTED for ConnectionState
        /// </summary>
        public static readonly ConnectionState DISCONNECTED = new ConnectionState("DISCONNECTED");
        /// <summary>
        /// Constant UNKNOWN for ConnectionState
        /// </summary>
        public static readonly ConnectionState UNKNOWN = new ConnectionState("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionState FindValue(string value)
        {
            return FindValue<ConnectionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModificationResourceEnum.
    /// </summary>
    public class ModificationResourceEnum : ConstantClass
    {

        /// <summary>
        /// Constant COMPUTE_TYPE for ModificationResourceEnum
        /// </summary>
        public static readonly ModificationResourceEnum COMPUTE_TYPE = new ModificationResourceEnum("COMPUTE_TYPE");
        /// <summary>
        /// Constant ROOT_VOLUME for ModificationResourceEnum
        /// </summary>
        public static readonly ModificationResourceEnum ROOT_VOLUME = new ModificationResourceEnum("ROOT_VOLUME");
        /// <summary>
        /// Constant USER_VOLUME for ModificationResourceEnum
        /// </summary>
        public static readonly ModificationResourceEnum USER_VOLUME = new ModificationResourceEnum("USER_VOLUME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModificationResourceEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModificationResourceEnum FindValue(string value)
        {
            return FindValue<ModificationResourceEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModificationResourceEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModificationStateEnum.
    /// </summary>
    public class ModificationStateEnum : ConstantClass
    {

        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ModificationStateEnum
        /// </summary>
        public static readonly ModificationStateEnum UPDATE_IN_PROGRESS = new ModificationStateEnum("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_INITIATED for ModificationStateEnum
        /// </summary>
        public static readonly ModificationStateEnum UPDATE_INITIATED = new ModificationStateEnum("UPDATE_INITIATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModificationStateEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModificationStateEnum FindValue(string value)
        {
            return FindValue<ModificationStateEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModificationStateEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RunningMode.
    /// </summary>
    public class RunningMode : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS_ON for RunningMode
        /// </summary>
        public static readonly RunningMode ALWAYS_ON = new RunningMode("ALWAYS_ON");
        /// <summary>
        /// Constant AUTO_STOP for RunningMode
        /// </summary>
        public static readonly RunningMode AUTO_STOP = new RunningMode("AUTO_STOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RunningMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RunningMode FindValue(string value)
        {
            return FindValue<RunningMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RunningMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetWorkspaceState.
    /// </summary>
    public class TargetWorkspaceState : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN_MAINTENANCE for TargetWorkspaceState
        /// </summary>
        public static readonly TargetWorkspaceState ADMIN_MAINTENANCE = new TargetWorkspaceState("ADMIN_MAINTENANCE");
        /// <summary>
        /// Constant AVAILABLE for TargetWorkspaceState
        /// </summary>
        public static readonly TargetWorkspaceState AVAILABLE = new TargetWorkspaceState("AVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetWorkspaceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetWorkspaceState FindValue(string value)
        {
            return FindValue<TargetWorkspaceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetWorkspaceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceDirectoryState.
    /// </summary>
    public class WorkspaceDirectoryState : ConstantClass
    {

        /// <summary>
        /// Constant DEREGISTERED for WorkspaceDirectoryState
        /// </summary>
        public static readonly WorkspaceDirectoryState DEREGISTERED = new WorkspaceDirectoryState("DEREGISTERED");
        /// <summary>
        /// Constant DEREGISTERING for WorkspaceDirectoryState
        /// </summary>
        public static readonly WorkspaceDirectoryState DEREGISTERING = new WorkspaceDirectoryState("DEREGISTERING");
        /// <summary>
        /// Constant ERROR for WorkspaceDirectoryState
        /// </summary>
        public static readonly WorkspaceDirectoryState ERROR = new WorkspaceDirectoryState("ERROR");
        /// <summary>
        /// Constant REGISTERED for WorkspaceDirectoryState
        /// </summary>
        public static readonly WorkspaceDirectoryState REGISTERED = new WorkspaceDirectoryState("REGISTERED");
        /// <summary>
        /// Constant REGISTERING for WorkspaceDirectoryState
        /// </summary>
        public static readonly WorkspaceDirectoryState REGISTERING = new WorkspaceDirectoryState("REGISTERING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceDirectoryState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceDirectoryState FindValue(string value)
        {
            return FindValue<WorkspaceDirectoryState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceDirectoryState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceDirectoryType.
    /// </summary>
    public class WorkspaceDirectoryType : ConstantClass
    {

        /// <summary>
        /// Constant AD_CONNECTOR for WorkspaceDirectoryType
        /// </summary>
        public static readonly WorkspaceDirectoryType AD_CONNECTOR = new WorkspaceDirectoryType("AD_CONNECTOR");
        /// <summary>
        /// Constant SIMPLE_AD for WorkspaceDirectoryType
        /// </summary>
        public static readonly WorkspaceDirectoryType SIMPLE_AD = new WorkspaceDirectoryType("SIMPLE_AD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceDirectoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceDirectoryType FindValue(string value)
        {
            return FindValue<WorkspaceDirectoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceDirectoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceState.
    /// </summary>
    public class WorkspaceState : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN_MAINTENANCE for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState ADMIN_MAINTENANCE = new WorkspaceState("ADMIN_MAINTENANCE");
        /// <summary>
        /// Constant AVAILABLE for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState AVAILABLE = new WorkspaceState("AVAILABLE");
        /// <summary>
        /// Constant ERROR for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState ERROR = new WorkspaceState("ERROR");
        /// <summary>
        /// Constant IMPAIRED for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState IMPAIRED = new WorkspaceState("IMPAIRED");
        /// <summary>
        /// Constant MAINTENANCE for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState MAINTENANCE = new WorkspaceState("MAINTENANCE");
        /// <summary>
        /// Constant PENDING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState PENDING = new WorkspaceState("PENDING");
        /// <summary>
        /// Constant REBOOTING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState REBOOTING = new WorkspaceState("REBOOTING");
        /// <summary>
        /// Constant REBUILDING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState REBUILDING = new WorkspaceState("REBUILDING");
        /// <summary>
        /// Constant STARTING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState STARTING = new WorkspaceState("STARTING");
        /// <summary>
        /// Constant STOPPED for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState STOPPED = new WorkspaceState("STOPPED");
        /// <summary>
        /// Constant STOPPING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState STOPPING = new WorkspaceState("STOPPING");
        /// <summary>
        /// Constant SUSPENDED for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState SUSPENDED = new WorkspaceState("SUSPENDED");
        /// <summary>
        /// Constant TERMINATED for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState TERMINATED = new WorkspaceState("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState TERMINATING = new WorkspaceState("TERMINATING");
        /// <summary>
        /// Constant UNHEALTHY for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState UNHEALTHY = new WorkspaceState("UNHEALTHY");
        /// <summary>
        /// Constant UPDATING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState UPDATING = new WorkspaceState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceState FindValue(string value)
        {
            return FindValue<WorkspaceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceState(string value)
        {
            return FindValue(value);
        }
    }

}