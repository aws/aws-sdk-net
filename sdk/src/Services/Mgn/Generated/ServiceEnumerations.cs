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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Mgn
{

    /// <summary>
    /// Constants used for properties of type ApplicationHealthStatus.
    /// </summary>
    public class ApplicationHealthStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for ApplicationHealthStatus
        /// </summary>
        public static readonly ApplicationHealthStatus ERROR = new ApplicationHealthStatus("ERROR");
        /// <summary>
        /// Constant HEALTHY for ApplicationHealthStatus
        /// </summary>
        public static readonly ApplicationHealthStatus HEALTHY = new ApplicationHealthStatus("HEALTHY");
        /// <summary>
        /// Constant LAGGING for ApplicationHealthStatus
        /// </summary>
        public static readonly ApplicationHealthStatus LAGGING = new ApplicationHealthStatus("LAGGING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationHealthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationHealthStatus FindValue(string value)
        {
            return FindValue<ApplicationHealthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationHealthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationProgressStatus.
    /// </summary>
    public class ApplicationProgressStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ApplicationProgressStatus
        /// </summary>
        public static readonly ApplicationProgressStatus COMPLETED = new ApplicationProgressStatus("COMPLETED");
        /// <summary>
        /// Constant IN_PROGRESS for ApplicationProgressStatus
        /// </summary>
        public static readonly ApplicationProgressStatus IN_PROGRESS = new ApplicationProgressStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for ApplicationProgressStatus
        /// </summary>
        public static readonly ApplicationProgressStatus NOT_STARTED = new ApplicationProgressStatus("NOT_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationProgressStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationProgressStatus FindValue(string value)
        {
            return FindValue<ApplicationProgressStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationProgressStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BootMode.
    /// </summary>
    public class BootMode : ConstantClass
    {

        /// <summary>
        /// Constant LEGACY_BIOS for BootMode
        /// </summary>
        public static readonly BootMode LEGACY_BIOS = new BootMode("LEGACY_BIOS");
        /// <summary>
        /// Constant UEFI for BootMode
        /// </summary>
        public static readonly BootMode UEFI = new BootMode("UEFI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BootMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BootMode FindValue(string value)
        {
            return FindValue<BootMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BootMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeServerLifeCycleStateSourceServerLifecycleState.
    /// </summary>
    public class ChangeServerLifeCycleStateSourceServerLifecycleState : ConstantClass
    {

        /// <summary>
        /// Constant CUTOVER for ChangeServerLifeCycleStateSourceServerLifecycleState
        /// </summary>
        public static readonly ChangeServerLifeCycleStateSourceServerLifecycleState CUTOVER = new ChangeServerLifeCycleStateSourceServerLifecycleState("CUTOVER");
        /// <summary>
        /// Constant READY_FOR_CUTOVER for ChangeServerLifeCycleStateSourceServerLifecycleState
        /// </summary>
        public static readonly ChangeServerLifeCycleStateSourceServerLifecycleState READY_FOR_CUTOVER = new ChangeServerLifeCycleStateSourceServerLifecycleState("READY_FOR_CUTOVER");
        /// <summary>
        /// Constant READY_FOR_TEST for ChangeServerLifeCycleStateSourceServerLifecycleState
        /// </summary>
        public static readonly ChangeServerLifeCycleStateSourceServerLifecycleState READY_FOR_TEST = new ChangeServerLifeCycleStateSourceServerLifecycleState("READY_FOR_TEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeServerLifeCycleStateSourceServerLifecycleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeServerLifeCycleStateSourceServerLifecycleState FindValue(string value)
        {
            return FindValue<ChangeServerLifeCycleStateSourceServerLifecycleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeServerLifeCycleStateSourceServerLifecycleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataReplicationErrorString.
    /// </summary>
    public class DataReplicationErrorString : ConstantClass
    {

        /// <summary>
        /// Constant AGENT_NOT_SEEN for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString AGENT_NOT_SEEN = new DataReplicationErrorString("AGENT_NOT_SEEN");
        /// <summary>
        /// Constant FAILED_TO_ATTACH_STAGING_DISKS for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString FAILED_TO_ATTACH_STAGING_DISKS = new DataReplicationErrorString("FAILED_TO_ATTACH_STAGING_DISKS");
        /// <summary>
        /// Constant FAILED_TO_AUTHENTICATE_WITH_SERVICE for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString FAILED_TO_AUTHENTICATE_WITH_SERVICE = new DataReplicationErrorString("FAILED_TO_AUTHENTICATE_WITH_SERVICE");
        /// <summary>
        /// Constant FAILED_TO_BOOT_REPLICATION_SERVER for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString FAILED_TO_BOOT_REPLICATION_SERVER = new DataReplicationErrorString("FAILED_TO_BOOT_REPLICATION_SERVER");
        /// <summary>
        /// Constant FAILED_TO_CONNECT_AGENT_TO_REPLICATION_SERVER for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString FAILED_TO_CONNECT_AGENT_TO_REPLICATION_SERVER = new DataReplicationErrorString("FAILED_TO_CONNECT_AGENT_TO_REPLICATION_SERVER");
        /// <summary>
        /// Constant FAILED_TO_CREATE_SECURITY_GROUP for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString FAILED_TO_CREATE_SECURITY_GROUP = new DataReplicationErrorString("FAILED_TO_CREATE_SECURITY_GROUP");
        /// <summary>
        /// Constant FAILED_TO_CREATE_STAGING_DISKS for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString FAILED_TO_CREATE_STAGING_DISKS = new DataReplicationErrorString("FAILED_TO_CREATE_STAGING_DISKS");
        /// <summary>
        /// Constant FAILED_TO_DOWNLOAD_REPLICATION_SOFTWARE for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString FAILED_TO_DOWNLOAD_REPLICATION_SOFTWARE = new DataReplicationErrorString("FAILED_TO_DOWNLOAD_REPLICATION_SOFTWARE");
        /// <summary>
        /// Constant FAILED_TO_LAUNCH_REPLICATION_SERVER for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString FAILED_TO_LAUNCH_REPLICATION_SERVER = new DataReplicationErrorString("FAILED_TO_LAUNCH_REPLICATION_SERVER");
        /// <summary>
        /// Constant FAILED_TO_PAIR_REPLICATION_SERVER_WITH_AGENT for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString FAILED_TO_PAIR_REPLICATION_SERVER_WITH_AGENT = new DataReplicationErrorString("FAILED_TO_PAIR_REPLICATION_SERVER_WITH_AGENT");
        /// <summary>
        /// Constant FAILED_TO_START_DATA_TRANSFER for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString FAILED_TO_START_DATA_TRANSFER = new DataReplicationErrorString("FAILED_TO_START_DATA_TRANSFER");
        /// <summary>
        /// Constant LAST_SNAPSHOT_JOB_FAILED for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString LAST_SNAPSHOT_JOB_FAILED = new DataReplicationErrorString("LAST_SNAPSHOT_JOB_FAILED");
        /// <summary>
        /// Constant NOT_CONVERGING for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString NOT_CONVERGING = new DataReplicationErrorString("NOT_CONVERGING");
        /// <summary>
        /// Constant SNAPSHOTS_FAILURE for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString SNAPSHOTS_FAILURE = new DataReplicationErrorString("SNAPSHOTS_FAILURE");
        /// <summary>
        /// Constant UNSTABLE_NETWORK for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString UNSTABLE_NETWORK = new DataReplicationErrorString("UNSTABLE_NETWORK");
        /// <summary>
        /// Constant UNSUPPORTED_VM_CONFIGURATION for DataReplicationErrorString
        /// </summary>
        public static readonly DataReplicationErrorString UNSUPPORTED_VM_CONFIGURATION = new DataReplicationErrorString("UNSUPPORTED_VM_CONFIGURATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataReplicationErrorString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataReplicationErrorString FindValue(string value)
        {
            return FindValue<DataReplicationErrorString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataReplicationErrorString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataReplicationInitiationStepName.
    /// </summary>
    public class DataReplicationInitiationStepName : ConstantClass
    {

        /// <summary>
        /// Constant ATTACH_STAGING_DISKS for DataReplicationInitiationStepName
        /// </summary>
        public static readonly DataReplicationInitiationStepName ATTACH_STAGING_DISKS = new DataReplicationInitiationStepName("ATTACH_STAGING_DISKS");
        /// <summary>
        /// Constant AUTHENTICATE_WITH_SERVICE for DataReplicationInitiationStepName
        /// </summary>
        public static readonly DataReplicationInitiationStepName AUTHENTICATE_WITH_SERVICE = new DataReplicationInitiationStepName("AUTHENTICATE_WITH_SERVICE");
        /// <summary>
        /// Constant BOOT_REPLICATION_SERVER for DataReplicationInitiationStepName
        /// </summary>
        public static readonly DataReplicationInitiationStepName BOOT_REPLICATION_SERVER = new DataReplicationInitiationStepName("BOOT_REPLICATION_SERVER");
        /// <summary>
        /// Constant CONNECT_AGENT_TO_REPLICATION_SERVER for DataReplicationInitiationStepName
        /// </summary>
        public static readonly DataReplicationInitiationStepName CONNECT_AGENT_TO_REPLICATION_SERVER = new DataReplicationInitiationStepName("CONNECT_AGENT_TO_REPLICATION_SERVER");
        /// <summary>
        /// Constant CREATE_SECURITY_GROUP for DataReplicationInitiationStepName
        /// </summary>
        public static readonly DataReplicationInitiationStepName CREATE_SECURITY_GROUP = new DataReplicationInitiationStepName("CREATE_SECURITY_GROUP");
        /// <summary>
        /// Constant CREATE_STAGING_DISKS for DataReplicationInitiationStepName
        /// </summary>
        public static readonly DataReplicationInitiationStepName CREATE_STAGING_DISKS = new DataReplicationInitiationStepName("CREATE_STAGING_DISKS");
        /// <summary>
        /// Constant DOWNLOAD_REPLICATION_SOFTWARE for DataReplicationInitiationStepName
        /// </summary>
        public static readonly DataReplicationInitiationStepName DOWNLOAD_REPLICATION_SOFTWARE = new DataReplicationInitiationStepName("DOWNLOAD_REPLICATION_SOFTWARE");
        /// <summary>
        /// Constant LAUNCH_REPLICATION_SERVER for DataReplicationInitiationStepName
        /// </summary>
        public static readonly DataReplicationInitiationStepName LAUNCH_REPLICATION_SERVER = new DataReplicationInitiationStepName("LAUNCH_REPLICATION_SERVER");
        /// <summary>
        /// Constant PAIR_REPLICATION_SERVER_WITH_AGENT for DataReplicationInitiationStepName
        /// </summary>
        public static readonly DataReplicationInitiationStepName PAIR_REPLICATION_SERVER_WITH_AGENT = new DataReplicationInitiationStepName("PAIR_REPLICATION_SERVER_WITH_AGENT");
        /// <summary>
        /// Constant START_DATA_TRANSFER for DataReplicationInitiationStepName
        /// </summary>
        public static readonly DataReplicationInitiationStepName START_DATA_TRANSFER = new DataReplicationInitiationStepName("START_DATA_TRANSFER");
        /// <summary>
        /// Constant WAIT for DataReplicationInitiationStepName
        /// </summary>
        public static readonly DataReplicationInitiationStepName WAIT = new DataReplicationInitiationStepName("WAIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataReplicationInitiationStepName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataReplicationInitiationStepName FindValue(string value)
        {
            return FindValue<DataReplicationInitiationStepName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataReplicationInitiationStepName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataReplicationInitiationStepStatus.
    /// </summary>
    public class DataReplicationInitiationStepStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DataReplicationInitiationStepStatus
        /// </summary>
        public static readonly DataReplicationInitiationStepStatus FAILED = new DataReplicationInitiationStepStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for DataReplicationInitiationStepStatus
        /// </summary>
        public static readonly DataReplicationInitiationStepStatus IN_PROGRESS = new DataReplicationInitiationStepStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for DataReplicationInitiationStepStatus
        /// </summary>
        public static readonly DataReplicationInitiationStepStatus NOT_STARTED = new DataReplicationInitiationStepStatus("NOT_STARTED");
        /// <summary>
        /// Constant SKIPPED for DataReplicationInitiationStepStatus
        /// </summary>
        public static readonly DataReplicationInitiationStepStatus SKIPPED = new DataReplicationInitiationStepStatus("SKIPPED");
        /// <summary>
        /// Constant SUCCEEDED for DataReplicationInitiationStepStatus
        /// </summary>
        public static readonly DataReplicationInitiationStepStatus SUCCEEDED = new DataReplicationInitiationStepStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataReplicationInitiationStepStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataReplicationInitiationStepStatus FindValue(string value)
        {
            return FindValue<DataReplicationInitiationStepStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataReplicationInitiationStepStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataReplicationState.
    /// </summary>
    public class DataReplicationState : ConstantClass
    {

        /// <summary>
        /// Constant BACKLOG for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState BACKLOG = new DataReplicationState("BACKLOG");
        /// <summary>
        /// Constant CONTINUOUS for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState CONTINUOUS = new DataReplicationState("CONTINUOUS");
        /// <summary>
        /// Constant CREATING_SNAPSHOT for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState CREATING_SNAPSHOT = new DataReplicationState("CREATING_SNAPSHOT");
        /// <summary>
        /// Constant DISCONNECTED for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState DISCONNECTED = new DataReplicationState("DISCONNECTED");
        /// <summary>
        /// Constant INITIAL_SYNC for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState INITIAL_SYNC = new DataReplicationState("INITIAL_SYNC");
        /// <summary>
        /// Constant INITIATING for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState INITIATING = new DataReplicationState("INITIATING");
        /// <summary>
        /// Constant PAUSED for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState PAUSED = new DataReplicationState("PAUSED");
        /// <summary>
        /// Constant PENDING_SNAPSHOT_SHIPPING for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState PENDING_SNAPSHOT_SHIPPING = new DataReplicationState("PENDING_SNAPSHOT_SHIPPING");
        /// <summary>
        /// Constant RESCAN for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState RESCAN = new DataReplicationState("RESCAN");
        /// <summary>
        /// Constant SHIPPING_SNAPSHOT for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState SHIPPING_SNAPSHOT = new DataReplicationState("SHIPPING_SNAPSHOT");
        /// <summary>
        /// Constant STALLED for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState STALLED = new DataReplicationState("STALLED");
        /// <summary>
        /// Constant STOPPED for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState STOPPED = new DataReplicationState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataReplicationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataReplicationState FindValue(string value)
        {
            return FindValue<DataReplicationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataReplicationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FirstBoot.
    /// </summary>
    public class FirstBoot : ConstantClass
    {

        /// <summary>
        /// Constant STOPPED for FirstBoot
        /// </summary>
        public static readonly FirstBoot STOPPED = new FirstBoot("STOPPED");
        /// <summary>
        /// Constant SUCCEEDED for FirstBoot
        /// </summary>
        public static readonly FirstBoot SUCCEEDED = new FirstBoot("SUCCEEDED");
        /// <summary>
        /// Constant UNKNOWN for FirstBoot
        /// </summary>
        public static readonly FirstBoot UNKNOWN = new FirstBoot("UNKNOWN");
        /// <summary>
        /// Constant WAITING for FirstBoot
        /// </summary>
        public static readonly FirstBoot WAITING = new FirstBoot("WAITING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FirstBoot(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FirstBoot FindValue(string value)
        {
            return FindValue<FirstBoot>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FirstBoot(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InitiatedBy.
    /// </summary>
    public class InitiatedBy : ConstantClass
    {

        /// <summary>
        /// Constant DIAGNOSTIC for InitiatedBy
        /// </summary>
        public static readonly InitiatedBy DIAGNOSTIC = new InitiatedBy("DIAGNOSTIC");
        /// <summary>
        /// Constant START_CUTOVER for InitiatedBy
        /// </summary>
        public static readonly InitiatedBy START_CUTOVER = new InitiatedBy("START_CUTOVER");
        /// <summary>
        /// Constant START_TEST for InitiatedBy
        /// </summary>
        public static readonly InitiatedBy START_TEST = new InitiatedBy("START_TEST");
        /// <summary>
        /// Constant TERMINATE for InitiatedBy
        /// </summary>
        public static readonly InitiatedBy TERMINATE = new InitiatedBy("TERMINATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InitiatedBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InitiatedBy FindValue(string value)
        {
            return FindValue<InitiatedBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InitiatedBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobLogEvent.
    /// </summary>
    public class JobLogEvent : ConstantClass
    {

        /// <summary>
        /// Constant CLEANUP_END for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent CLEANUP_END = new JobLogEvent("CLEANUP_END");
        /// <summary>
        /// Constant CLEANUP_FAIL for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent CLEANUP_FAIL = new JobLogEvent("CLEANUP_FAIL");
        /// <summary>
        /// Constant CLEANUP_START for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent CLEANUP_START = new JobLogEvent("CLEANUP_START");
        /// <summary>
        /// Constant CONVERSION_END for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent CONVERSION_END = new JobLogEvent("CONVERSION_END");
        /// <summary>
        /// Constant CONVERSION_FAIL for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent CONVERSION_FAIL = new JobLogEvent("CONVERSION_FAIL");
        /// <summary>
        /// Constant CONVERSION_START for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent CONVERSION_START = new JobLogEvent("CONVERSION_START");
        /// <summary>
        /// Constant JOB_CANCEL for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent JOB_CANCEL = new JobLogEvent("JOB_CANCEL");
        /// <summary>
        /// Constant JOB_END for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent JOB_END = new JobLogEvent("JOB_END");
        /// <summary>
        /// Constant JOB_START for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent JOB_START = new JobLogEvent("JOB_START");
        /// <summary>
        /// Constant LAUNCH_FAILED for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent LAUNCH_FAILED = new JobLogEvent("LAUNCH_FAILED");
        /// <summary>
        /// Constant LAUNCH_START for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent LAUNCH_START = new JobLogEvent("LAUNCH_START");
        /// <summary>
        /// Constant SERVER_SKIPPED for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent SERVER_SKIPPED = new JobLogEvent("SERVER_SKIPPED");
        /// <summary>
        /// Constant SNAPSHOT_END for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent SNAPSHOT_END = new JobLogEvent("SNAPSHOT_END");
        /// <summary>
        /// Constant SNAPSHOT_FAIL for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent SNAPSHOT_FAIL = new JobLogEvent("SNAPSHOT_FAIL");
        /// <summary>
        /// Constant SNAPSHOT_START for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent SNAPSHOT_START = new JobLogEvent("SNAPSHOT_START");
        /// <summary>
        /// Constant USING_PREVIOUS_SNAPSHOT for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent USING_PREVIOUS_SNAPSHOT = new JobLogEvent("USING_PREVIOUS_SNAPSHOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobLogEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobLogEvent FindValue(string value)
        {
            return FindValue<JobLogEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobLogEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant PENDING for JobStatus
        /// </summary>
        public static readonly JobStatus PENDING = new JobStatus("PENDING");
        /// <summary>
        /// Constant STARTED for JobStatus
        /// </summary>
        public static readonly JobStatus STARTED = new JobStatus("STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatus FindValue(string value)
        {
            return FindValue<JobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobType.
    /// </summary>
    public class JobType : ConstantClass
    {

        /// <summary>
        /// Constant LAUNCH for JobType
        /// </summary>
        public static readonly JobType LAUNCH = new JobType("LAUNCH");
        /// <summary>
        /// Constant TERMINATE for JobType
        /// </summary>
        public static readonly JobType TERMINATE = new JobType("TERMINATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobType FindValue(string value)
        {
            return FindValue<JobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchDisposition.
    /// </summary>
    public class LaunchDisposition : ConstantClass
    {

        /// <summary>
        /// Constant STARTED for LaunchDisposition
        /// </summary>
        public static readonly LaunchDisposition STARTED = new LaunchDisposition("STARTED");
        /// <summary>
        /// Constant STOPPED for LaunchDisposition
        /// </summary>
        public static readonly LaunchDisposition STOPPED = new LaunchDisposition("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchDisposition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchDisposition FindValue(string value)
        {
            return FindValue<LaunchDisposition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchDisposition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchStatus.
    /// </summary>
    public class LaunchStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for LaunchStatus
        /// </summary>
        public static readonly LaunchStatus FAILED = new LaunchStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for LaunchStatus
        /// </summary>
        public static readonly LaunchStatus IN_PROGRESS = new LaunchStatus("IN_PROGRESS");
        /// <summary>
        /// Constant LAUNCHED for LaunchStatus
        /// </summary>
        public static readonly LaunchStatus LAUNCHED = new LaunchStatus("LAUNCHED");
        /// <summary>
        /// Constant PENDING for LaunchStatus
        /// </summary>
        public static readonly LaunchStatus PENDING = new LaunchStatus("PENDING");
        /// <summary>
        /// Constant TERMINATED for LaunchStatus
        /// </summary>
        public static readonly LaunchStatus TERMINATED = new LaunchStatus("TERMINATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchStatus FindValue(string value)
        {
            return FindValue<LaunchStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifeCycleState.
    /// </summary>
    public class LifeCycleState : ConstantClass
    {

        /// <summary>
        /// Constant CUTOVER for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState CUTOVER = new LifeCycleState("CUTOVER");
        /// <summary>
        /// Constant CUTTING_OVER for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState CUTTING_OVER = new LifeCycleState("CUTTING_OVER");
        /// <summary>
        /// Constant DISCONNECTED for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState DISCONNECTED = new LifeCycleState("DISCONNECTED");
        /// <summary>
        /// Constant DISCOVERED for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState DISCOVERED = new LifeCycleState("DISCOVERED");
        /// <summary>
        /// Constant NOT_READY for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState NOT_READY = new LifeCycleState("NOT_READY");
        /// <summary>
        /// Constant READY_FOR_CUTOVER for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState READY_FOR_CUTOVER = new LifeCycleState("READY_FOR_CUTOVER");
        /// <summary>
        /// Constant READY_FOR_TEST for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState READY_FOR_TEST = new LifeCycleState("READY_FOR_TEST");
        /// <summary>
        /// Constant STOPPED for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState STOPPED = new LifeCycleState("STOPPED");
        /// <summary>
        /// Constant TESTING for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState TESTING = new LifeCycleState("TESTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifeCycleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifeCycleState FindValue(string value)
        {
            return FindValue<LifeCycleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifeCycleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PostLaunchActionExecutionStatus.
    /// </summary>
    public class PostLaunchActionExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for PostLaunchActionExecutionStatus
        /// </summary>
        public static readonly PostLaunchActionExecutionStatus FAILED = new PostLaunchActionExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for PostLaunchActionExecutionStatus
        /// </summary>
        public static readonly PostLaunchActionExecutionStatus IN_PROGRESS = new PostLaunchActionExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCESS for PostLaunchActionExecutionStatus
        /// </summary>
        public static readonly PostLaunchActionExecutionStatus SUCCESS = new PostLaunchActionExecutionStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PostLaunchActionExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PostLaunchActionExecutionStatus FindValue(string value)
        {
            return FindValue<PostLaunchActionExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PostLaunchActionExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PostLaunchActionsDeploymentType.
    /// </summary>
    public class PostLaunchActionsDeploymentType : ConstantClass
    {

        /// <summary>
        /// Constant CUTOVER_ONLY for PostLaunchActionsDeploymentType
        /// </summary>
        public static readonly PostLaunchActionsDeploymentType CUTOVER_ONLY = new PostLaunchActionsDeploymentType("CUTOVER_ONLY");
        /// <summary>
        /// Constant TEST_AND_CUTOVER for PostLaunchActionsDeploymentType
        /// </summary>
        public static readonly PostLaunchActionsDeploymentType TEST_AND_CUTOVER = new PostLaunchActionsDeploymentType("TEST_AND_CUTOVER");
        /// <summary>
        /// Constant TEST_ONLY for PostLaunchActionsDeploymentType
        /// </summary>
        public static readonly PostLaunchActionsDeploymentType TEST_ONLY = new PostLaunchActionsDeploymentType("TEST_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PostLaunchActionsDeploymentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PostLaunchActionsDeploymentType FindValue(string value)
        {
            return FindValue<PostLaunchActionsDeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PostLaunchActionsDeploymentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationConfigurationDataPlaneRouting.
    /// </summary>
    public class ReplicationConfigurationDataPlaneRouting : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE_IP for ReplicationConfigurationDataPlaneRouting
        /// </summary>
        public static readonly ReplicationConfigurationDataPlaneRouting PRIVATE_IP = new ReplicationConfigurationDataPlaneRouting("PRIVATE_IP");
        /// <summary>
        /// Constant PUBLIC_IP for ReplicationConfigurationDataPlaneRouting
        /// </summary>
        public static readonly ReplicationConfigurationDataPlaneRouting PUBLIC_IP = new ReplicationConfigurationDataPlaneRouting("PUBLIC_IP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationConfigurationDataPlaneRouting(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationConfigurationDataPlaneRouting FindValue(string value)
        {
            return FindValue<ReplicationConfigurationDataPlaneRouting>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationConfigurationDataPlaneRouting(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationConfigurationDefaultLargeStagingDiskType.
    /// </summary>
    public class ReplicationConfigurationDefaultLargeStagingDiskType : ConstantClass
    {

        /// <summary>
        /// Constant GP2 for ReplicationConfigurationDefaultLargeStagingDiskType
        /// </summary>
        public static readonly ReplicationConfigurationDefaultLargeStagingDiskType GP2 = new ReplicationConfigurationDefaultLargeStagingDiskType("GP2");
        /// <summary>
        /// Constant GP3 for ReplicationConfigurationDefaultLargeStagingDiskType
        /// </summary>
        public static readonly ReplicationConfigurationDefaultLargeStagingDiskType GP3 = new ReplicationConfigurationDefaultLargeStagingDiskType("GP3");
        /// <summary>
        /// Constant ST1 for ReplicationConfigurationDefaultLargeStagingDiskType
        /// </summary>
        public static readonly ReplicationConfigurationDefaultLargeStagingDiskType ST1 = new ReplicationConfigurationDefaultLargeStagingDiskType("ST1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationConfigurationDefaultLargeStagingDiskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationConfigurationDefaultLargeStagingDiskType FindValue(string value)
        {
            return FindValue<ReplicationConfigurationDefaultLargeStagingDiskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationConfigurationDefaultLargeStagingDiskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationConfigurationEbsEncryption.
    /// </summary>
    public class ReplicationConfigurationEbsEncryption : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for ReplicationConfigurationEbsEncryption
        /// </summary>
        public static readonly ReplicationConfigurationEbsEncryption CUSTOM = new ReplicationConfigurationEbsEncryption("CUSTOM");
        /// <summary>
        /// Constant DEFAULT for ReplicationConfigurationEbsEncryption
        /// </summary>
        public static readonly ReplicationConfigurationEbsEncryption DEFAULT = new ReplicationConfigurationEbsEncryption("DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationConfigurationEbsEncryption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationConfigurationEbsEncryption FindValue(string value)
        {
            return FindValue<ReplicationConfigurationEbsEncryption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationConfigurationEbsEncryption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationConfigurationReplicatedDiskStagingDiskType.
    /// </summary>
    public class ReplicationConfigurationReplicatedDiskStagingDiskType : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for ReplicationConfigurationReplicatedDiskStagingDiskType
        /// </summary>
        public static readonly ReplicationConfigurationReplicatedDiskStagingDiskType AUTO = new ReplicationConfigurationReplicatedDiskStagingDiskType("AUTO");
        /// <summary>
        /// Constant GP2 for ReplicationConfigurationReplicatedDiskStagingDiskType
        /// </summary>
        public static readonly ReplicationConfigurationReplicatedDiskStagingDiskType GP2 = new ReplicationConfigurationReplicatedDiskStagingDiskType("GP2");
        /// <summary>
        /// Constant GP3 for ReplicationConfigurationReplicatedDiskStagingDiskType
        /// </summary>
        public static readonly ReplicationConfigurationReplicatedDiskStagingDiskType GP3 = new ReplicationConfigurationReplicatedDiskStagingDiskType("GP3");
        /// <summary>
        /// Constant IO1 for ReplicationConfigurationReplicatedDiskStagingDiskType
        /// </summary>
        public static readonly ReplicationConfigurationReplicatedDiskStagingDiskType IO1 = new ReplicationConfigurationReplicatedDiskStagingDiskType("IO1");
        /// <summary>
        /// Constant IO2 for ReplicationConfigurationReplicatedDiskStagingDiskType
        /// </summary>
        public static readonly ReplicationConfigurationReplicatedDiskStagingDiskType IO2 = new ReplicationConfigurationReplicatedDiskStagingDiskType("IO2");
        /// <summary>
        /// Constant SC1 for ReplicationConfigurationReplicatedDiskStagingDiskType
        /// </summary>
        public static readonly ReplicationConfigurationReplicatedDiskStagingDiskType SC1 = new ReplicationConfigurationReplicatedDiskStagingDiskType("SC1");
        /// <summary>
        /// Constant ST1 for ReplicationConfigurationReplicatedDiskStagingDiskType
        /// </summary>
        public static readonly ReplicationConfigurationReplicatedDiskStagingDiskType ST1 = new ReplicationConfigurationReplicatedDiskStagingDiskType("ST1");
        /// <summary>
        /// Constant STANDARD for ReplicationConfigurationReplicatedDiskStagingDiskType
        /// </summary>
        public static readonly ReplicationConfigurationReplicatedDiskStagingDiskType STANDARD = new ReplicationConfigurationReplicatedDiskStagingDiskType("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationConfigurationReplicatedDiskStagingDiskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationConfigurationReplicatedDiskStagingDiskType FindValue(string value)
        {
            return FindValue<ReplicationConfigurationReplicatedDiskStagingDiskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationConfigurationReplicatedDiskStagingDiskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationType.
    /// </summary>
    public class ReplicationType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT_BASED for ReplicationType
        /// </summary>
        public static readonly ReplicationType AGENT_BASED = new ReplicationType("AGENT_BASED");
        /// <summary>
        /// Constant SNAPSHOT_SHIPPING for ReplicationType
        /// </summary>
        public static readonly ReplicationType SNAPSHOT_SHIPPING = new ReplicationType("SNAPSHOT_SHIPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationType FindValue(string value)
        {
            return FindValue<ReplicationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SsmDocumentType.
    /// </summary>
    public class SsmDocumentType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATION for SsmDocumentType
        /// </summary>
        public static readonly SsmDocumentType AUTOMATION = new SsmDocumentType("AUTOMATION");
        /// <summary>
        /// Constant COMMAND for SsmDocumentType
        /// </summary>
        public static readonly SsmDocumentType COMMAND = new SsmDocumentType("COMMAND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SsmDocumentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SsmDocumentType FindValue(string value)
        {
            return FindValue<SsmDocumentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SsmDocumentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SsmParameterStoreParameterType.
    /// </summary>
    public class SsmParameterStoreParameterType : ConstantClass
    {

        /// <summary>
        /// Constant STRING for SsmParameterStoreParameterType
        /// </summary>
        public static readonly SsmParameterStoreParameterType STRING = new SsmParameterStoreParameterType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SsmParameterStoreParameterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SsmParameterStoreParameterType FindValue(string value)
        {
            return FindValue<SsmParameterStoreParameterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SsmParameterStoreParameterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetInstanceTypeRightSizingMethod.
    /// </summary>
    public class TargetInstanceTypeRightSizingMethod : ConstantClass
    {

        /// <summary>
        /// Constant BASIC for TargetInstanceTypeRightSizingMethod
        /// </summary>
        public static readonly TargetInstanceTypeRightSizingMethod BASIC = new TargetInstanceTypeRightSizingMethod("BASIC");
        /// <summary>
        /// Constant NONE for TargetInstanceTypeRightSizingMethod
        /// </summary>
        public static readonly TargetInstanceTypeRightSizingMethod NONE = new TargetInstanceTypeRightSizingMethod("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetInstanceTypeRightSizingMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetInstanceTypeRightSizingMethod FindValue(string value)
        {
            return FindValue<TargetInstanceTypeRightSizingMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetInstanceTypeRightSizingMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeType.
    /// </summary>
    public class VolumeType : ConstantClass
    {

        /// <summary>
        /// Constant Gp2 for VolumeType
        /// </summary>
        public static readonly VolumeType Gp2 = new VolumeType("gp2");
        /// <summary>
        /// Constant Gp3 for VolumeType
        /// </summary>
        public static readonly VolumeType Gp3 = new VolumeType("gp3");
        /// <summary>
        /// Constant Io1 for VolumeType
        /// </summary>
        public static readonly VolumeType Io1 = new VolumeType("io1");
        /// <summary>
        /// Constant Io2 for VolumeType
        /// </summary>
        public static readonly VolumeType Io2 = new VolumeType("io2");
        /// <summary>
        /// Constant Sc1 for VolumeType
        /// </summary>
        public static readonly VolumeType Sc1 = new VolumeType("sc1");
        /// <summary>
        /// Constant St1 for VolumeType
        /// </summary>
        public static readonly VolumeType St1 = new VolumeType("st1");
        /// <summary>
        /// Constant Standard for VolumeType
        /// </summary>
        public static readonly VolumeType Standard = new VolumeType("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeType FindValue(string value)
        {
            return FindValue<VolumeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WaveHealthStatus.
    /// </summary>
    public class WaveHealthStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for WaveHealthStatus
        /// </summary>
        public static readonly WaveHealthStatus ERROR = new WaveHealthStatus("ERROR");
        /// <summary>
        /// Constant HEALTHY for WaveHealthStatus
        /// </summary>
        public static readonly WaveHealthStatus HEALTHY = new WaveHealthStatus("HEALTHY");
        /// <summary>
        /// Constant LAGGING for WaveHealthStatus
        /// </summary>
        public static readonly WaveHealthStatus LAGGING = new WaveHealthStatus("LAGGING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WaveHealthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WaveHealthStatus FindValue(string value)
        {
            return FindValue<WaveHealthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WaveHealthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WaveProgressStatus.
    /// </summary>
    public class WaveProgressStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for WaveProgressStatus
        /// </summary>
        public static readonly WaveProgressStatus COMPLETED = new WaveProgressStatus("COMPLETED");
        /// <summary>
        /// Constant IN_PROGRESS for WaveProgressStatus
        /// </summary>
        public static readonly WaveProgressStatus IN_PROGRESS = new WaveProgressStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for WaveProgressStatus
        /// </summary>
        public static readonly WaveProgressStatus NOT_STARTED = new WaveProgressStatus("NOT_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WaveProgressStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WaveProgressStatus FindValue(string value)
        {
            return FindValue<WaveProgressStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WaveProgressStatus(string value)
        {
            return FindValue(value);
        }
    }

}