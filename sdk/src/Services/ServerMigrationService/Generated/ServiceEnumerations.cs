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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ServerMigrationService
{

    /// <summary>
    /// Constants used for properties of type AppLaunchStatus.
    /// </summary>
    public class AppLaunchStatus : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURATION_IN_PROGRESS for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus CONFIGURATION_IN_PROGRESS = new AppLaunchStatus("CONFIGURATION_IN_PROGRESS");
        /// <summary>
        /// Constant CONFIGURATION_INVALID for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus CONFIGURATION_INVALID = new AppLaunchStatus("CONFIGURATION_INVALID");
        /// <summary>
        /// Constant DELTA_LAUNCH_FAILED for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus DELTA_LAUNCH_FAILED = new AppLaunchStatus("DELTA_LAUNCH_FAILED");
        /// <summary>
        /// Constant DELTA_LAUNCH_IN_PROGRESS for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus DELTA_LAUNCH_IN_PROGRESS = new AppLaunchStatus("DELTA_LAUNCH_IN_PROGRESS");
        /// <summary>
        /// Constant LAUNCH_FAILED for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus LAUNCH_FAILED = new AppLaunchStatus("LAUNCH_FAILED");
        /// <summary>
        /// Constant LAUNCH_IN_PROGRESS for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus LAUNCH_IN_PROGRESS = new AppLaunchStatus("LAUNCH_IN_PROGRESS");
        /// <summary>
        /// Constant LAUNCH_PENDING for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus LAUNCH_PENDING = new AppLaunchStatus("LAUNCH_PENDING");
        /// <summary>
        /// Constant LAUNCHED for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus LAUNCHED = new AppLaunchStatus("LAUNCHED");
        /// <summary>
        /// Constant READY_FOR_CONFIGURATION for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus READY_FOR_CONFIGURATION = new AppLaunchStatus("READY_FOR_CONFIGURATION");
        /// <summary>
        /// Constant READY_FOR_LAUNCH for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus READY_FOR_LAUNCH = new AppLaunchStatus("READY_FOR_LAUNCH");
        /// <summary>
        /// Constant TERMINATE_FAILED for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus TERMINATE_FAILED = new AppLaunchStatus("TERMINATE_FAILED");
        /// <summary>
        /// Constant TERMINATE_IN_PROGRESS for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus TERMINATE_IN_PROGRESS = new AppLaunchStatus("TERMINATE_IN_PROGRESS");
        /// <summary>
        /// Constant TERMINATED for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus TERMINATED = new AppLaunchStatus("TERMINATED");
        /// <summary>
        /// Constant VALIDATION_IN_PROGRESS for AppLaunchStatus
        /// </summary>
        public static readonly AppLaunchStatus VALIDATION_IN_PROGRESS = new AppLaunchStatus("VALIDATION_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppLaunchStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppLaunchStatus FindValue(string value)
        {
            return FindValue<AppLaunchStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppLaunchStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppReplicationStatus.
    /// </summary>
    public class AppReplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURATION_IN_PROGRESS for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus CONFIGURATION_IN_PROGRESS = new AppReplicationStatus("CONFIGURATION_IN_PROGRESS");
        /// <summary>
        /// Constant CONFIGURATION_INVALID for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus CONFIGURATION_INVALID = new AppReplicationStatus("CONFIGURATION_INVALID");
        /// <summary>
        /// Constant DELTA_REPLICATED for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus DELTA_REPLICATED = new AppReplicationStatus("DELTA_REPLICATED");
        /// <summary>
        /// Constant DELTA_REPLICATION_FAILED for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus DELTA_REPLICATION_FAILED = new AppReplicationStatus("DELTA_REPLICATION_FAILED");
        /// <summary>
        /// Constant DELTA_REPLICATION_IN_PROGRESS for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus DELTA_REPLICATION_IN_PROGRESS = new AppReplicationStatus("DELTA_REPLICATION_IN_PROGRESS");
        /// <summary>
        /// Constant READY_FOR_CONFIGURATION for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus READY_FOR_CONFIGURATION = new AppReplicationStatus("READY_FOR_CONFIGURATION");
        /// <summary>
        /// Constant READY_FOR_REPLICATION for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus READY_FOR_REPLICATION = new AppReplicationStatus("READY_FOR_REPLICATION");
        /// <summary>
        /// Constant REPLICATED for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus REPLICATED = new AppReplicationStatus("REPLICATED");
        /// <summary>
        /// Constant REPLICATION_FAILED for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus REPLICATION_FAILED = new AppReplicationStatus("REPLICATION_FAILED");
        /// <summary>
        /// Constant REPLICATION_IN_PROGRESS for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus REPLICATION_IN_PROGRESS = new AppReplicationStatus("REPLICATION_IN_PROGRESS");
        /// <summary>
        /// Constant REPLICATION_PENDING for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus REPLICATION_PENDING = new AppReplicationStatus("REPLICATION_PENDING");
        /// <summary>
        /// Constant REPLICATION_STOP_FAILED for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus REPLICATION_STOP_FAILED = new AppReplicationStatus("REPLICATION_STOP_FAILED");
        /// <summary>
        /// Constant REPLICATION_STOPPED for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus REPLICATION_STOPPED = new AppReplicationStatus("REPLICATION_STOPPED");
        /// <summary>
        /// Constant REPLICATION_STOPPING for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus REPLICATION_STOPPING = new AppReplicationStatus("REPLICATION_STOPPING");
        /// <summary>
        /// Constant VALIDATION_IN_PROGRESS for AppReplicationStatus
        /// </summary>
        public static readonly AppReplicationStatus VALIDATION_IN_PROGRESS = new AppReplicationStatus("VALIDATION_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppReplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppReplicationStatus FindValue(string value)
        {
            return FindValue<AppReplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppReplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppStatus.
    /// </summary>
    public class AppStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AppStatus
        /// </summary>
        public static readonly AppStatus ACTIVE = new AppStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for AppStatus
        /// </summary>
        public static readonly AppStatus CREATING = new AppStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for AppStatus
        /// </summary>
        public static readonly AppStatus DELETE_FAILED = new AppStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for AppStatus
        /// </summary>
        public static readonly AppStatus DELETED = new AppStatus("DELETED");
        /// <summary>
        /// Constant DELETING for AppStatus
        /// </summary>
        public static readonly AppStatus DELETING = new AppStatus("DELETING");
        /// <summary>
        /// Constant UPDATING for AppStatus
        /// </summary>
        public static readonly AppStatus UPDATING = new AppStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppStatus FindValue(string value)
        {
            return FindValue<AppStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorCapability.
    /// </summary>
    public class ConnectorCapability : ConstantClass
    {

        /// <summary>
        /// Constant HYPERVMANAGER for ConnectorCapability
        /// </summary>
        public static readonly ConnectorCapability HYPERVMANAGER = new ConnectorCapability("HYPERV-MANAGER");
        /// <summary>
        /// Constant SCVMM for ConnectorCapability
        /// </summary>
        public static readonly ConnectorCapability SCVMM = new ConnectorCapability("SCVMM");
        /// <summary>
        /// Constant SNAPSHOT_BATCHING for ConnectorCapability
        /// </summary>
        public static readonly ConnectorCapability SNAPSHOT_BATCHING = new ConnectorCapability("SNAPSHOT_BATCHING");
        /// <summary>
        /// Constant VSPHERE for ConnectorCapability
        /// </summary>
        public static readonly ConnectorCapability VSPHERE = new ConnectorCapability("VSPHERE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorCapability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorCapability FindValue(string value)
        {
            return FindValue<ConnectorCapability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorCapability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorStatus.
    /// </summary>
    public class ConnectorStatus : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus HEALTHY = new ConnectorStatus("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus UNHEALTHY = new ConnectorStatus("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorStatus FindValue(string value)
        {
            return FindValue<ConnectorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseType.
    /// </summary>
    public class LicenseType : ConstantClass
    {

        /// <summary>
        /// Constant AWS for LicenseType
        /// </summary>
        public static readonly LicenseType AWS = new LicenseType("AWS");
        /// <summary>
        /// Constant BYOL for LicenseType
        /// </summary>
        public static readonly LicenseType BYOL = new LicenseType("BYOL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseType FindValue(string value)
        {
            return FindValue<LicenseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputFormat.
    /// </summary>
    public class OutputFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for OutputFormat
        /// </summary>
        public static readonly OutputFormat JSON = new OutputFormat("JSON");
        /// <summary>
        /// Constant YAML for OutputFormat
        /// </summary>
        public static readonly OutputFormat YAML = new OutputFormat("YAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputFormat FindValue(string value)
        {
            return FindValue<OutputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationJobState.
    /// </summary>
    public class ReplicationJobState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState ACTIVE = new ReplicationJobState("ACTIVE");
        /// <summary>
        /// Constant COMPLETED for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState COMPLETED = new ReplicationJobState("COMPLETED");
        /// <summary>
        /// Constant DELETED for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState DELETED = new ReplicationJobState("DELETED");
        /// <summary>
        /// Constant DELETING for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState DELETING = new ReplicationJobState("DELETING");
        /// <summary>
        /// Constant FAILED for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState FAILED = new ReplicationJobState("FAILED");
        /// <summary>
        /// Constant FAILING for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState FAILING = new ReplicationJobState("FAILING");
        /// <summary>
        /// Constant PAUSED_ON_FAILURE for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState PAUSED_ON_FAILURE = new ReplicationJobState("PAUSED_ON_FAILURE");
        /// <summary>
        /// Constant PENDING for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState PENDING = new ReplicationJobState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationJobState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationJobState FindValue(string value)
        {
            return FindValue<ReplicationJobState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationJobState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationRunState.
    /// </summary>
    public class ReplicationRunState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState ACTIVE = new ReplicationRunState("ACTIVE");
        /// <summary>
        /// Constant COMPLETED for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState COMPLETED = new ReplicationRunState("COMPLETED");
        /// <summary>
        /// Constant DELETED for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState DELETED = new ReplicationRunState("DELETED");
        /// <summary>
        /// Constant DELETING for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState DELETING = new ReplicationRunState("DELETING");
        /// <summary>
        /// Constant FAILED for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState FAILED = new ReplicationRunState("FAILED");
        /// <summary>
        /// Constant MISSED for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState MISSED = new ReplicationRunState("MISSED");
        /// <summary>
        /// Constant PENDING for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState PENDING = new ReplicationRunState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationRunState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationRunState FindValue(string value)
        {
            return FindValue<ReplicationRunState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationRunState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationRunType.
    /// </summary>
    public class ReplicationRunType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for ReplicationRunType
        /// </summary>
        public static readonly ReplicationRunType AUTOMATIC = new ReplicationRunType("AUTOMATIC");
        /// <summary>
        /// Constant ON_DEMAND for ReplicationRunType
        /// </summary>
        public static readonly ReplicationRunType ON_DEMAND = new ReplicationRunType("ON_DEMAND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationRunType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationRunType FindValue(string value)
        {
            return FindValue<ReplicationRunType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationRunType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerCatalogStatus.
    /// </summary>
    public class ServerCatalogStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ServerCatalogStatus
        /// </summary>
        public static readonly ServerCatalogStatus AVAILABLE = new ServerCatalogStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETED for ServerCatalogStatus
        /// </summary>
        public static readonly ServerCatalogStatus DELETED = new ServerCatalogStatus("DELETED");
        /// <summary>
        /// Constant EXPIRED for ServerCatalogStatus
        /// </summary>
        public static readonly ServerCatalogStatus EXPIRED = new ServerCatalogStatus("EXPIRED");
        /// <summary>
        /// Constant IMPORTING for ServerCatalogStatus
        /// </summary>
        public static readonly ServerCatalogStatus IMPORTING = new ServerCatalogStatus("IMPORTING");
        /// <summary>
        /// Constant NOT_IMPORTED for ServerCatalogStatus
        /// </summary>
        public static readonly ServerCatalogStatus NOT_IMPORTED = new ServerCatalogStatus("NOT_IMPORTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerCatalogStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerCatalogStatus FindValue(string value)
        {
            return FindValue<ServerCatalogStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerCatalogStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerType.
    /// </summary>
    public class ServerType : ConstantClass
    {

        /// <summary>
        /// Constant VIRTUAL_MACHINE for ServerType
        /// </summary>
        public static readonly ServerType VIRTUAL_MACHINE = new ServerType("VIRTUAL_MACHINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerType FindValue(string value)
        {
            return FindValue<ServerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VmManagerType.
    /// </summary>
    public class VmManagerType : ConstantClass
    {

        /// <summary>
        /// Constant HYPERVMANAGER for VmManagerType
        /// </summary>
        public static readonly VmManagerType HYPERVMANAGER = new VmManagerType("HYPERV-MANAGER");
        /// <summary>
        /// Constant SCVMM for VmManagerType
        /// </summary>
        public static readonly VmManagerType SCVMM = new VmManagerType("SCVMM");
        /// <summary>
        /// Constant VSPHERE for VmManagerType
        /// </summary>
        public static readonly VmManagerType VSPHERE = new VmManagerType("VSPHERE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VmManagerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VmManagerType FindValue(string value)
        {
            return FindValue<VmManagerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VmManagerType(string value)
        {
            return FindValue(value);
        }
    }

}