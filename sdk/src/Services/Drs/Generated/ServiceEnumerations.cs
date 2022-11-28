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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Drs
{

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
        /// Constant RESCAN for DataReplicationState
        /// </summary>
        public static readonly DataReplicationState RESCAN = new DataReplicationState("RESCAN");
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
    /// Constants used for properties of type EC2InstanceState.
    /// </summary>
    public class EC2InstanceState : ConstantClass
    {

        /// <summary>
        /// Constant NOT_FOUND for EC2InstanceState
        /// </summary>
        public static readonly EC2InstanceState NOT_FOUND = new EC2InstanceState("NOT_FOUND");
        /// <summary>
        /// Constant PENDING for EC2InstanceState
        /// </summary>
        public static readonly EC2InstanceState PENDING = new EC2InstanceState("PENDING");
        /// <summary>
        /// Constant RUNNING for EC2InstanceState
        /// </summary>
        public static readonly EC2InstanceState RUNNING = new EC2InstanceState("RUNNING");
        /// <summary>
        /// Constant SHUTTINGDOWN for EC2InstanceState
        /// </summary>
        public static readonly EC2InstanceState SHUTTINGDOWN = new EC2InstanceState("SHUTTING-DOWN");
        /// <summary>
        /// Constant STOPPED for EC2InstanceState
        /// </summary>
        public static readonly EC2InstanceState STOPPED = new EC2InstanceState("STOPPED");
        /// <summary>
        /// Constant STOPPING for EC2InstanceState
        /// </summary>
        public static readonly EC2InstanceState STOPPING = new EC2InstanceState("STOPPING");
        /// <summary>
        /// Constant TERMINATED for EC2InstanceState
        /// </summary>
        public static readonly EC2InstanceState TERMINATED = new EC2InstanceState("TERMINATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EC2InstanceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EC2InstanceState FindValue(string value)
        {
            return FindValue<EC2InstanceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EC2InstanceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExtensionStatus.
    /// </summary>
    public class ExtensionStatus : ConstantClass
    {

        /// <summary>
        /// Constant EXTENDED for ExtensionStatus
        /// </summary>
        public static readonly ExtensionStatus EXTENDED = new ExtensionStatus("EXTENDED");
        /// <summary>
        /// Constant EXTENSION_ERROR for ExtensionStatus
        /// </summary>
        public static readonly ExtensionStatus EXTENSION_ERROR = new ExtensionStatus("EXTENSION_ERROR");
        /// <summary>
        /// Constant NOT_EXTENDED for ExtensionStatus
        /// </summary>
        public static readonly ExtensionStatus NOT_EXTENDED = new ExtensionStatus("NOT_EXTENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExtensionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExtensionStatus FindValue(string value)
        {
            return FindValue<ExtensionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExtensionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailbackLaunchType.
    /// </summary>
    public class FailbackLaunchType : ConstantClass
    {

        /// <summary>
        /// Constant DRILL for FailbackLaunchType
        /// </summary>
        public static readonly FailbackLaunchType DRILL = new FailbackLaunchType("DRILL");
        /// <summary>
        /// Constant RECOVERY for FailbackLaunchType
        /// </summary>
        public static readonly FailbackLaunchType RECOVERY = new FailbackLaunchType("RECOVERY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailbackLaunchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailbackLaunchType FindValue(string value)
        {
            return FindValue<FailbackLaunchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailbackLaunchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailbackReplicationError.
    /// </summary>
    public class FailbackReplicationError : ConstantClass
    {

        /// <summary>
        /// Constant AGENT_NOT_SEEN for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError AGENT_NOT_SEEN = new FailbackReplicationError("AGENT_NOT_SEEN");
        /// <summary>
        /// Constant FAILBACK_CLIENT_NOT_SEEN for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILBACK_CLIENT_NOT_SEEN = new FailbackReplicationError("FAILBACK_CLIENT_NOT_SEEN");
        /// <summary>
        /// Constant FAILED_GETTING_REPLICATION_STATE for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_GETTING_REPLICATION_STATE = new FailbackReplicationError("FAILED_GETTING_REPLICATION_STATE");
        /// <summary>
        /// Constant FAILED_TO_ATTACH_STAGING_DISKS for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_ATTACH_STAGING_DISKS = new FailbackReplicationError("FAILED_TO_ATTACH_STAGING_DISKS");
        /// <summary>
        /// Constant FAILED_TO_AUTHENTICATE_WITH_SERVICE for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_AUTHENTICATE_WITH_SERVICE = new FailbackReplicationError("FAILED_TO_AUTHENTICATE_WITH_SERVICE");
        /// <summary>
        /// Constant FAILED_TO_BOOT_REPLICATION_SERVER for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_BOOT_REPLICATION_SERVER = new FailbackReplicationError("FAILED_TO_BOOT_REPLICATION_SERVER");
        /// <summary>
        /// Constant FAILED_TO_CONFIGURE_REPLICATION_SOFTWARE for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_CONFIGURE_REPLICATION_SOFTWARE = new FailbackReplicationError("FAILED_TO_CONFIGURE_REPLICATION_SOFTWARE");
        /// <summary>
        /// Constant FAILED_TO_CONNECT_AGENT_TO_REPLICATION_SERVER for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_CONNECT_AGENT_TO_REPLICATION_SERVER = new FailbackReplicationError("FAILED_TO_CONNECT_AGENT_TO_REPLICATION_SERVER");
        /// <summary>
        /// Constant FAILED_TO_CREATE_SECURITY_GROUP for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_CREATE_SECURITY_GROUP = new FailbackReplicationError("FAILED_TO_CREATE_SECURITY_GROUP");
        /// <summary>
        /// Constant FAILED_TO_CREATE_STAGING_DISKS for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_CREATE_STAGING_DISKS = new FailbackReplicationError("FAILED_TO_CREATE_STAGING_DISKS");
        /// <summary>
        /// Constant FAILED_TO_DOWNLOAD_REPLICATION_SOFTWARE for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_DOWNLOAD_REPLICATION_SOFTWARE = new FailbackReplicationError("FAILED_TO_DOWNLOAD_REPLICATION_SOFTWARE");
        /// <summary>
        /// Constant FAILED_TO_DOWNLOAD_REPLICATION_SOFTWARE_TO_FAILBACK_CLIENT for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_DOWNLOAD_REPLICATION_SOFTWARE_TO_FAILBACK_CLIENT = new FailbackReplicationError("FAILED_TO_DOWNLOAD_REPLICATION_SOFTWARE_TO_FAILBACK_CLIENT");
        /// <summary>
        /// Constant FAILED_TO_ESTABLISH_AGENT_REPLICATOR_SOFTWARE_COMMUNICATION for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_ESTABLISH_AGENT_REPLICATOR_SOFTWARE_COMMUNICATION = new FailbackReplicationError("FAILED_TO_ESTABLISH_AGENT_REPLICATOR_SOFTWARE_COMMUNICATION");
        /// <summary>
        /// Constant FAILED_TO_ESTABLISH_RECOVERY_INSTANCE_COMMUNICATION for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_ESTABLISH_RECOVERY_INSTANCE_COMMUNICATION = new FailbackReplicationError("FAILED_TO_ESTABLISH_RECOVERY_INSTANCE_COMMUNICATION");
        /// <summary>
        /// Constant FAILED_TO_LAUNCH_REPLICATION_SERVER for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_LAUNCH_REPLICATION_SERVER = new FailbackReplicationError("FAILED_TO_LAUNCH_REPLICATION_SERVER");
        /// <summary>
        /// Constant FAILED_TO_PAIR_AGENT_WITH_REPLICATION_SOFTWARE for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_PAIR_AGENT_WITH_REPLICATION_SOFTWARE = new FailbackReplicationError("FAILED_TO_PAIR_AGENT_WITH_REPLICATION_SOFTWARE");
        /// <summary>
        /// Constant FAILED_TO_PAIR_REPLICATION_SERVER_WITH_AGENT for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_PAIR_REPLICATION_SERVER_WITH_AGENT = new FailbackReplicationError("FAILED_TO_PAIR_REPLICATION_SERVER_WITH_AGENT");
        /// <summary>
        /// Constant FAILED_TO_START_DATA_TRANSFER for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError FAILED_TO_START_DATA_TRANSFER = new FailbackReplicationError("FAILED_TO_START_DATA_TRANSFER");
        /// <summary>
        /// Constant NOT_CONVERGING for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError NOT_CONVERGING = new FailbackReplicationError("NOT_CONVERGING");
        /// <summary>
        /// Constant SNAPSHOTS_FAILURE for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError SNAPSHOTS_FAILURE = new FailbackReplicationError("SNAPSHOTS_FAILURE");
        /// <summary>
        /// Constant UNSTABLE_NETWORK for FailbackReplicationError
        /// </summary>
        public static readonly FailbackReplicationError UNSTABLE_NETWORK = new FailbackReplicationError("UNSTABLE_NETWORK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailbackReplicationError(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailbackReplicationError FindValue(string value)
        {
            return FindValue<FailbackReplicationError>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailbackReplicationError(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailbackState.
    /// </summary>
    public class FailbackState : ConstantClass
    {

        /// <summary>
        /// Constant FAILBACK_COMPLETED for FailbackState
        /// </summary>
        public static readonly FailbackState FAILBACK_COMPLETED = new FailbackState("FAILBACK_COMPLETED");
        /// <summary>
        /// Constant FAILBACK_ERROR for FailbackState
        /// </summary>
        public static readonly FailbackState FAILBACK_ERROR = new FailbackState("FAILBACK_ERROR");
        /// <summary>
        /// Constant FAILBACK_IN_PROGRESS for FailbackState
        /// </summary>
        public static readonly FailbackState FAILBACK_IN_PROGRESS = new FailbackState("FAILBACK_IN_PROGRESS");
        /// <summary>
        /// Constant FAILBACK_LAUNCH_STATE_NOT_AVAILABLE for FailbackState
        /// </summary>
        public static readonly FailbackState FAILBACK_LAUNCH_STATE_NOT_AVAILABLE = new FailbackState("FAILBACK_LAUNCH_STATE_NOT_AVAILABLE");
        /// <summary>
        /// Constant FAILBACK_NOT_READY_FOR_LAUNCH for FailbackState
        /// </summary>
        public static readonly FailbackState FAILBACK_NOT_READY_FOR_LAUNCH = new FailbackState("FAILBACK_NOT_READY_FOR_LAUNCH");
        /// <summary>
        /// Constant FAILBACK_NOT_STARTED for FailbackState
        /// </summary>
        public static readonly FailbackState FAILBACK_NOT_STARTED = new FailbackState("FAILBACK_NOT_STARTED");
        /// <summary>
        /// Constant FAILBACK_READY_FOR_LAUNCH for FailbackState
        /// </summary>
        public static readonly FailbackState FAILBACK_READY_FOR_LAUNCH = new FailbackState("FAILBACK_READY_FOR_LAUNCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailbackState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailbackState FindValue(string value)
        {
            return FindValue<FailbackState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailbackState(string value)
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
        /// Constant FAILBACK for InitiatedBy
        /// </summary>
        public static readonly InitiatedBy FAILBACK = new InitiatedBy("FAILBACK");
        /// <summary>
        /// Constant START_DRILL for InitiatedBy
        /// </summary>
        public static readonly InitiatedBy START_DRILL = new InitiatedBy("START_DRILL");
        /// <summary>
        /// Constant START_RECOVERY for InitiatedBy
        /// </summary>
        public static readonly InitiatedBy START_RECOVERY = new InitiatedBy("START_RECOVERY");
        /// <summary>
        /// Constant TARGET_ACCOUNT for InitiatedBy
        /// </summary>
        public static readonly InitiatedBy TARGET_ACCOUNT = new InitiatedBy("TARGET_ACCOUNT");
        /// <summary>
        /// Constant TERMINATE_RECOVERY_INSTANCES for InitiatedBy
        /// </summary>
        public static readonly InitiatedBy TERMINATE_RECOVERY_INSTANCES = new InitiatedBy("TERMINATE_RECOVERY_INSTANCES");

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
        /// Constant USING_PREVIOUS_SNAPSHOT_FAILED for JobLogEvent
        /// </summary>
        public static readonly JobLogEvent USING_PREVIOUS_SNAPSHOT_FAILED = new JobLogEvent("USING_PREVIOUS_SNAPSHOT_FAILED");

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
        /// Constant CREATE_CONVERTED_SNAPSHOT for JobType
        /// </summary>
        public static readonly JobType CREATE_CONVERTED_SNAPSHOT = new JobType("CREATE_CONVERTED_SNAPSHOT");
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
    /// Constants used for properties of type LastLaunchResult.
    /// </summary>
    public class LastLaunchResult : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for LastLaunchResult
        /// </summary>
        public static readonly LastLaunchResult FAILED = new LastLaunchResult("FAILED");
        /// <summary>
        /// Constant NOT_STARTED for LastLaunchResult
        /// </summary>
        public static readonly LastLaunchResult NOT_STARTED = new LastLaunchResult("NOT_STARTED");
        /// <summary>
        /// Constant PENDING for LastLaunchResult
        /// </summary>
        public static readonly LastLaunchResult PENDING = new LastLaunchResult("PENDING");
        /// <summary>
        /// Constant SUCCEEDED for LastLaunchResult
        /// </summary>
        public static readonly LastLaunchResult SUCCEEDED = new LastLaunchResult("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastLaunchResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastLaunchResult FindValue(string value)
        {
            return FindValue<LastLaunchResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastLaunchResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LastLaunchType.
    /// </summary>
    public class LastLaunchType : ConstantClass
    {

        /// <summary>
        /// Constant DRILL for LastLaunchType
        /// </summary>
        public static readonly LastLaunchType DRILL = new LastLaunchType("DRILL");
        /// <summary>
        /// Constant RECOVERY for LastLaunchType
        /// </summary>
        public static readonly LastLaunchType RECOVERY = new LastLaunchType("RECOVERY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastLaunchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastLaunchType FindValue(string value)
        {
            return FindValue<LastLaunchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastLaunchType(string value)
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
    /// Constants used for properties of type OriginEnvironment.
    /// </summary>
    public class OriginEnvironment : ConstantClass
    {

        /// <summary>
        /// Constant AWS for OriginEnvironment
        /// </summary>
        public static readonly OriginEnvironment AWS = new OriginEnvironment("AWS");
        /// <summary>
        /// Constant ON_PREMISES for OriginEnvironment
        /// </summary>
        public static readonly OriginEnvironment ON_PREMISES = new OriginEnvironment("ON_PREMISES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginEnvironment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginEnvironment FindValue(string value)
        {
            return FindValue<OriginEnvironment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginEnvironment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PITPolicyRuleUnits.
    /// </summary>
    public class PITPolicyRuleUnits : ConstantClass
    {

        /// <summary>
        /// Constant DAY for PITPolicyRuleUnits
        /// </summary>
        public static readonly PITPolicyRuleUnits DAY = new PITPolicyRuleUnits("DAY");
        /// <summary>
        /// Constant HOUR for PITPolicyRuleUnits
        /// </summary>
        public static readonly PITPolicyRuleUnits HOUR = new PITPolicyRuleUnits("HOUR");
        /// <summary>
        /// Constant MINUTE for PITPolicyRuleUnits
        /// </summary>
        public static readonly PITPolicyRuleUnits MINUTE = new PITPolicyRuleUnits("MINUTE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PITPolicyRuleUnits(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PITPolicyRuleUnits FindValue(string value)
        {
            return FindValue<PITPolicyRuleUnits>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PITPolicyRuleUnits(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecoveryInstanceDataReplicationInitiationStepName.
    /// </summary>
    public class RecoveryInstanceDataReplicationInitiationStepName : ConstantClass
    {

        /// <summary>
        /// Constant ATTACH_STAGING_DISKS for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName ATTACH_STAGING_DISKS = new RecoveryInstanceDataReplicationInitiationStepName("ATTACH_STAGING_DISKS");
        /// <summary>
        /// Constant AUTHENTICATE_WITH_SERVICE for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName AUTHENTICATE_WITH_SERVICE = new RecoveryInstanceDataReplicationInitiationStepName("AUTHENTICATE_WITH_SERVICE");
        /// <summary>
        /// Constant BOOT_REPLICATION_SERVER for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName BOOT_REPLICATION_SERVER = new RecoveryInstanceDataReplicationInitiationStepName("BOOT_REPLICATION_SERVER");
        /// <summary>
        /// Constant COMPLETE_VOLUME_MAPPING for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName COMPLETE_VOLUME_MAPPING = new RecoveryInstanceDataReplicationInitiationStepName("COMPLETE_VOLUME_MAPPING");
        /// <summary>
        /// Constant CONFIGURE_REPLICATION_SOFTWARE for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName CONFIGURE_REPLICATION_SOFTWARE = new RecoveryInstanceDataReplicationInitiationStepName("CONFIGURE_REPLICATION_SOFTWARE");
        /// <summary>
        /// Constant CONNECT_AGENT_TO_REPLICATION_SERVER for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName CONNECT_AGENT_TO_REPLICATION_SERVER = new RecoveryInstanceDataReplicationInitiationStepName("CONNECT_AGENT_TO_REPLICATION_SERVER");
        /// <summary>
        /// Constant CREATE_SECURITY_GROUP for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName CREATE_SECURITY_GROUP = new RecoveryInstanceDataReplicationInitiationStepName("CREATE_SECURITY_GROUP");
        /// <summary>
        /// Constant CREATE_STAGING_DISKS for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName CREATE_STAGING_DISKS = new RecoveryInstanceDataReplicationInitiationStepName("CREATE_STAGING_DISKS");
        /// <summary>
        /// Constant DOWNLOAD_REPLICATION_SOFTWARE for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName DOWNLOAD_REPLICATION_SOFTWARE = new RecoveryInstanceDataReplicationInitiationStepName("DOWNLOAD_REPLICATION_SOFTWARE");
        /// <summary>
        /// Constant DOWNLOAD_REPLICATION_SOFTWARE_TO_FAILBACK_CLIENT for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName DOWNLOAD_REPLICATION_SOFTWARE_TO_FAILBACK_CLIENT = new RecoveryInstanceDataReplicationInitiationStepName("DOWNLOAD_REPLICATION_SOFTWARE_TO_FAILBACK_CLIENT");
        /// <summary>
        /// Constant ESTABLISH_AGENT_REPLICATOR_SOFTWARE_COMMUNICATION for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName ESTABLISH_AGENT_REPLICATOR_SOFTWARE_COMMUNICATION = new RecoveryInstanceDataReplicationInitiationStepName("ESTABLISH_AGENT_REPLICATOR_SOFTWARE_COMMUNICATION");
        /// <summary>
        /// Constant ESTABLISH_RECOVERY_INSTANCE_COMMUNICATION for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName ESTABLISH_RECOVERY_INSTANCE_COMMUNICATION = new RecoveryInstanceDataReplicationInitiationStepName("ESTABLISH_RECOVERY_INSTANCE_COMMUNICATION");
        /// <summary>
        /// Constant LAUNCH_REPLICATION_SERVER for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName LAUNCH_REPLICATION_SERVER = new RecoveryInstanceDataReplicationInitiationStepName("LAUNCH_REPLICATION_SERVER");
        /// <summary>
        /// Constant LINK_FAILBACK_CLIENT_WITH_RECOVERY_INSTANCE for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName LINK_FAILBACK_CLIENT_WITH_RECOVERY_INSTANCE = new RecoveryInstanceDataReplicationInitiationStepName("LINK_FAILBACK_CLIENT_WITH_RECOVERY_INSTANCE");
        /// <summary>
        /// Constant PAIR_AGENT_WITH_REPLICATION_SOFTWARE for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName PAIR_AGENT_WITH_REPLICATION_SOFTWARE = new RecoveryInstanceDataReplicationInitiationStepName("PAIR_AGENT_WITH_REPLICATION_SOFTWARE");
        /// <summary>
        /// Constant PAIR_REPLICATION_SERVER_WITH_AGENT for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName PAIR_REPLICATION_SERVER_WITH_AGENT = new RecoveryInstanceDataReplicationInitiationStepName("PAIR_REPLICATION_SERVER_WITH_AGENT");
        /// <summary>
        /// Constant START_DATA_TRANSFER for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName START_DATA_TRANSFER = new RecoveryInstanceDataReplicationInitiationStepName("START_DATA_TRANSFER");
        /// <summary>
        /// Constant WAIT for RecoveryInstanceDataReplicationInitiationStepName
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepName WAIT = new RecoveryInstanceDataReplicationInitiationStepName("WAIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecoveryInstanceDataReplicationInitiationStepName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecoveryInstanceDataReplicationInitiationStepName FindValue(string value)
        {
            return FindValue<RecoveryInstanceDataReplicationInitiationStepName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecoveryInstanceDataReplicationInitiationStepName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecoveryInstanceDataReplicationInitiationStepStatus.
    /// </summary>
    public class RecoveryInstanceDataReplicationInitiationStepStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for RecoveryInstanceDataReplicationInitiationStepStatus
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepStatus FAILED = new RecoveryInstanceDataReplicationInitiationStepStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for RecoveryInstanceDataReplicationInitiationStepStatus
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepStatus IN_PROGRESS = new RecoveryInstanceDataReplicationInitiationStepStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for RecoveryInstanceDataReplicationInitiationStepStatus
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepStatus NOT_STARTED = new RecoveryInstanceDataReplicationInitiationStepStatus("NOT_STARTED");
        /// <summary>
        /// Constant SKIPPED for RecoveryInstanceDataReplicationInitiationStepStatus
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepStatus SKIPPED = new RecoveryInstanceDataReplicationInitiationStepStatus("SKIPPED");
        /// <summary>
        /// Constant SUCCEEDED for RecoveryInstanceDataReplicationInitiationStepStatus
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationInitiationStepStatus SUCCEEDED = new RecoveryInstanceDataReplicationInitiationStepStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecoveryInstanceDataReplicationInitiationStepStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecoveryInstanceDataReplicationInitiationStepStatus FindValue(string value)
        {
            return FindValue<RecoveryInstanceDataReplicationInitiationStepStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecoveryInstanceDataReplicationInitiationStepStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecoveryInstanceDataReplicationState.
    /// </summary>
    public class RecoveryInstanceDataReplicationState : ConstantClass
    {

        /// <summary>
        /// Constant BACKLOG for RecoveryInstanceDataReplicationState
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationState BACKLOG = new RecoveryInstanceDataReplicationState("BACKLOG");
        /// <summary>
        /// Constant CONTINUOUS for RecoveryInstanceDataReplicationState
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationState CONTINUOUS = new RecoveryInstanceDataReplicationState("CONTINUOUS");
        /// <summary>
        /// Constant CREATING_SNAPSHOT for RecoveryInstanceDataReplicationState
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationState CREATING_SNAPSHOT = new RecoveryInstanceDataReplicationState("CREATING_SNAPSHOT");
        /// <summary>
        /// Constant DISCONNECTED for RecoveryInstanceDataReplicationState
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationState DISCONNECTED = new RecoveryInstanceDataReplicationState("DISCONNECTED");
        /// <summary>
        /// Constant INITIAL_SYNC for RecoveryInstanceDataReplicationState
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationState INITIAL_SYNC = new RecoveryInstanceDataReplicationState("INITIAL_SYNC");
        /// <summary>
        /// Constant INITIATING for RecoveryInstanceDataReplicationState
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationState INITIATING = new RecoveryInstanceDataReplicationState("INITIATING");
        /// <summary>
        /// Constant NOT_STARTED for RecoveryInstanceDataReplicationState
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationState NOT_STARTED = new RecoveryInstanceDataReplicationState("NOT_STARTED");
        /// <summary>
        /// Constant PAUSED for RecoveryInstanceDataReplicationState
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationState PAUSED = new RecoveryInstanceDataReplicationState("PAUSED");
        /// <summary>
        /// Constant REPLICATION_STATE_NOT_AVAILABLE for RecoveryInstanceDataReplicationState
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationState REPLICATION_STATE_NOT_AVAILABLE = new RecoveryInstanceDataReplicationState("REPLICATION_STATE_NOT_AVAILABLE");
        /// <summary>
        /// Constant RESCAN for RecoveryInstanceDataReplicationState
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationState RESCAN = new RecoveryInstanceDataReplicationState("RESCAN");
        /// <summary>
        /// Constant STALLED for RecoveryInstanceDataReplicationState
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationState STALLED = new RecoveryInstanceDataReplicationState("STALLED");
        /// <summary>
        /// Constant STOPPED for RecoveryInstanceDataReplicationState
        /// </summary>
        public static readonly RecoveryInstanceDataReplicationState STOPPED = new RecoveryInstanceDataReplicationState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecoveryInstanceDataReplicationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecoveryInstanceDataReplicationState FindValue(string value)
        {
            return FindValue<RecoveryInstanceDataReplicationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecoveryInstanceDataReplicationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecoverySnapshotsOrder.
    /// </summary>
    public class RecoverySnapshotsOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASC for RecoverySnapshotsOrder
        /// </summary>
        public static readonly RecoverySnapshotsOrder ASC = new RecoverySnapshotsOrder("ASC");
        /// <summary>
        /// Constant DESC for RecoverySnapshotsOrder
        /// </summary>
        public static readonly RecoverySnapshotsOrder DESC = new RecoverySnapshotsOrder("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecoverySnapshotsOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecoverySnapshotsOrder FindValue(string value)
        {
            return FindValue<RecoverySnapshotsOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecoverySnapshotsOrder(string value)
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
        /// Constant AUTO for ReplicationConfigurationDefaultLargeStagingDiskType
        /// </summary>
        public static readonly ReplicationConfigurationDefaultLargeStagingDiskType AUTO = new ReplicationConfigurationDefaultLargeStagingDiskType("AUTO");
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
    /// Constants used for properties of type ReplicationDirection.
    /// </summary>
    public class ReplicationDirection : ConstantClass
    {

        /// <summary>
        /// Constant FAILBACK for ReplicationDirection
        /// </summary>
        public static readonly ReplicationDirection FAILBACK = new ReplicationDirection("FAILBACK");
        /// <summary>
        /// Constant FAILOVER for ReplicationDirection
        /// </summary>
        public static readonly ReplicationDirection FAILOVER = new ReplicationDirection("FAILOVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationDirection FindValue(string value)
        {
            return FindValue<ReplicationDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationDirection(string value)
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

}