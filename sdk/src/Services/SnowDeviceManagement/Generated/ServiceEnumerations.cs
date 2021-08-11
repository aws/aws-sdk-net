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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SnowDeviceManagement
{

    /// <summary>
    /// Constants used for properties of type AttachmentStatus.
    /// </summary>
    public class AttachmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHED for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus ATTACHED = new AttachmentStatus("ATTACHED");
        /// <summary>
        /// Constant ATTACHING for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus ATTACHING = new AttachmentStatus("ATTACHING");
        /// <summary>
        /// Constant DETACHED for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus DETACHED = new AttachmentStatus("DETACHED");
        /// <summary>
        /// Constant DETACHING for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus DETACHING = new AttachmentStatus("DETACHING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentStatus FindValue(string value)
        {
            return FindValue<AttachmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionState.
    /// </summary>
    public class ExecutionState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for ExecutionState
        /// </summary>
        public static readonly ExecutionState CANCELED = new ExecutionState("CANCELED");
        /// <summary>
        /// Constant FAILED for ExecutionState
        /// </summary>
        public static readonly ExecutionState FAILED = new ExecutionState("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ExecutionState
        /// </summary>
        public static readonly ExecutionState IN_PROGRESS = new ExecutionState("IN_PROGRESS");
        /// <summary>
        /// Constant QUEUED for ExecutionState
        /// </summary>
        public static readonly ExecutionState QUEUED = new ExecutionState("QUEUED");
        /// <summary>
        /// Constant REJECTED for ExecutionState
        /// </summary>
        public static readonly ExecutionState REJECTED = new ExecutionState("REJECTED");
        /// <summary>
        /// Constant SUCCEEDED for ExecutionState
        /// </summary>
        public static readonly ExecutionState SUCCEEDED = new ExecutionState("SUCCEEDED");
        /// <summary>
        /// Constant TIMED_OUT for ExecutionState
        /// </summary>
        public static readonly ExecutionState TIMED_OUT = new ExecutionState("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionState FindValue(string value)
        {
            return FindValue<ExecutionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceStateName.
    /// </summary>
    public class InstanceStateName : ConstantClass
    {

        /// <summary>
        /// Constant PENDING for InstanceStateName
        /// </summary>
        public static readonly InstanceStateName PENDING = new InstanceStateName("PENDING");
        /// <summary>
        /// Constant RUNNING for InstanceStateName
        /// </summary>
        public static readonly InstanceStateName RUNNING = new InstanceStateName("RUNNING");
        /// <summary>
        /// Constant SHUTTING_DOWN for InstanceStateName
        /// </summary>
        public static readonly InstanceStateName SHUTTING_DOWN = new InstanceStateName("SHUTTING_DOWN");
        /// <summary>
        /// Constant STOPPED for InstanceStateName
        /// </summary>
        public static readonly InstanceStateName STOPPED = new InstanceStateName("STOPPED");
        /// <summary>
        /// Constant STOPPING for InstanceStateName
        /// </summary>
        public static readonly InstanceStateName STOPPING = new InstanceStateName("STOPPING");
        /// <summary>
        /// Constant TERMINATED for InstanceStateName
        /// </summary>
        public static readonly InstanceStateName TERMINATED = new InstanceStateName("TERMINATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceStateName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceStateName FindValue(string value)
        {
            return FindValue<InstanceStateName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceStateName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpAddressAssignment.
    /// </summary>
    public class IpAddressAssignment : ConstantClass
    {

        /// <summary>
        /// Constant DHCP for IpAddressAssignment
        /// </summary>
        public static readonly IpAddressAssignment DHCP = new IpAddressAssignment("DHCP");
        /// <summary>
        /// Constant STATIC for IpAddressAssignment
        /// </summary>
        public static readonly IpAddressAssignment STATIC = new IpAddressAssignment("STATIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpAddressAssignment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpAddressAssignment FindValue(string value)
        {
            return FindValue<IpAddressAssignment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpAddressAssignment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhysicalConnectorType.
    /// </summary>
    public class PhysicalConnectorType : ConstantClass
    {

        /// <summary>
        /// Constant QSFP for PhysicalConnectorType
        /// </summary>
        public static readonly PhysicalConnectorType QSFP = new PhysicalConnectorType("QSFP");
        /// <summary>
        /// Constant RJ45 for PhysicalConnectorType
        /// </summary>
        public static readonly PhysicalConnectorType RJ45 = new PhysicalConnectorType("RJ45");
        /// <summary>
        /// Constant RJ45_2 for PhysicalConnectorType
        /// </summary>
        public static readonly PhysicalConnectorType RJ45_2 = new PhysicalConnectorType("RJ45_2");
        /// <summary>
        /// Constant SFP_PLUS for PhysicalConnectorType
        /// </summary>
        public static readonly PhysicalConnectorType SFP_PLUS = new PhysicalConnectorType("SFP_PLUS");
        /// <summary>
        /// Constant WIFI for PhysicalConnectorType
        /// </summary>
        public static readonly PhysicalConnectorType WIFI = new PhysicalConnectorType("WIFI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhysicalConnectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhysicalConnectorType FindValue(string value)
        {
            return FindValue<PhysicalConnectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhysicalConnectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskState.
    /// </summary>
    public class TaskState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for TaskState
        /// </summary>
        public static readonly TaskState CANCELED = new TaskState("CANCELED");
        /// <summary>
        /// Constant COMPLETED for TaskState
        /// </summary>
        public static readonly TaskState COMPLETED = new TaskState("COMPLETED");
        /// <summary>
        /// Constant IN_PROGRESS for TaskState
        /// </summary>
        public static readonly TaskState IN_PROGRESS = new TaskState("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskState FindValue(string value)
        {
            return FindValue<TaskState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UnlockState.
    /// </summary>
    public class UnlockState : ConstantClass
    {

        /// <summary>
        /// Constant LOCKED for UnlockState
        /// </summary>
        public static readonly UnlockState LOCKED = new UnlockState("LOCKED");
        /// <summary>
        /// Constant UNLOCKED for UnlockState
        /// </summary>
        public static readonly UnlockState UNLOCKED = new UnlockState("UNLOCKED");
        /// <summary>
        /// Constant UNLOCKING for UnlockState
        /// </summary>
        public static readonly UnlockState UNLOCKING = new UnlockState("UNLOCKING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UnlockState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnlockState FindValue(string value)
        {
            return FindValue<UnlockState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnlockState(string value)
        {
            return FindValue(value);
        }
    }

}