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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.TimestreamInfluxDB
{
    /// <summary>
    /// Constants used for properties of type AutomatedDbBackupType.
    /// </summary>
    public class AutomatedDbBackupType : ConstantClass
    {
        /// <summary>
        /// Constant CONTINUOUS for AutomatedDbBackupType
        /// </summary>
        public static readonly AutomatedDbBackupType CONTINUOUS = new AutomatedDbBackupType("CONTINUOUS");

        /// <summary>
        /// Constant CUSTOM_SCHEDULE for AutomatedDbBackupType
        /// </summary>
        public static readonly AutomatedDbBackupType CUSTOM_SCHEDULE = new AutomatedDbBackupType("CUSTOM_SCHEDULE");

        /// <summary>
        /// Constant DAILY for AutomatedDbBackupType
        /// </summary>
        public static readonly AutomatedDbBackupType DAILY = new AutomatedDbBackupType("DAILY");

        /// <summary>
        /// Constant HOURLY for AutomatedDbBackupType
        /// </summary>
        public static readonly AutomatedDbBackupType HOURLY = new AutomatedDbBackupType("HOURLY");

        /// <summary>
        /// Constant MONTHLY for AutomatedDbBackupType
        /// </summary>
        public static readonly AutomatedDbBackupType MONTHLY = new AutomatedDbBackupType("MONTHLY");

        /// <summary>
        /// Constant WEEKLY for AutomatedDbBackupType
        /// </summary>
        public static readonly AutomatedDbBackupType WEEKLY = new AutomatedDbBackupType("WEEKLY");

        /// <summary>
        /// Constructs a custom AutomatedDbBackupType for a value not among the defined constants.
        /// </summary>
        public AutomatedDbBackupType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomatedDbBackupType FindValue(string value)
        {
            return FindValue<AutomatedDbBackupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomatedDbBackupType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ClusterDeploymentType.
    /// </summary>
    public class ClusterDeploymentType : ConstantClass
    {
        /// <summary>
        /// Constant MULTI_NODE_READ_REPLICAS for ClusterDeploymentType
        /// </summary>
        public static readonly ClusterDeploymentType MULTI_NODE_READ_REPLICAS = new ClusterDeploymentType("MULTI_NODE_READ_REPLICAS");

        /// <summary>
        /// Constructs a custom ClusterDeploymentType for a value not among the defined constants.
        /// </summary>
        public ClusterDeploymentType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterDeploymentType FindValue(string value)
        {
            return FindValue<ClusterDeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterDeploymentType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ClusterStatus.
    /// </summary>
    public class ClusterStatus : ConstantClass
    {
        /// <summary>
        /// Constant AVAILABLE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus AVAILABLE = new ClusterStatus("AVAILABLE");

        /// <summary>
        /// Constant CREATING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus CREATING = new ClusterStatus("CREATING");

        /// <summary>
        /// Constant DELETED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus DELETED = new ClusterStatus("DELETED");

        /// <summary>
        /// Constant DELETING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus DELETING = new ClusterStatus("DELETING");

        /// <summary>
        /// Constant FAILED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus FAILED = new ClusterStatus("FAILED");

        /// <summary>
        /// Constant MAINTENANCE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus MAINTENANCE = new ClusterStatus("MAINTENANCE");

        /// <summary>
        /// Constant PARTIALLY_AVAILABLE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus PARTIALLY_AVAILABLE = new ClusterStatus("PARTIALLY_AVAILABLE");

        /// <summary>
        /// Constant REBOOTING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus REBOOTING = new ClusterStatus("REBOOTING");

        /// <summary>
        /// Constant REBOOT_FAILED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus REBOOT_FAILED = new ClusterStatus("REBOOT_FAILED");

        /// <summary>
        /// Constant RESTORE_FAILED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus RESTORE_FAILED = new ClusterStatus("RESTORE_FAILED");

        /// <summary>
        /// Constant RESTORING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus RESTORING = new ClusterStatus("RESTORING");

        /// <summary>
        /// Constant UPDATING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus UPDATING = new ClusterStatus("UPDATING");

        /// <summary>
        /// Constant UPDATING_INSTANCE_TYPE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus UPDATING_INSTANCE_TYPE = new ClusterStatus("UPDATING_INSTANCE_TYPE");

        /// <summary>
        /// Constructs a custom ClusterStatus for a value not among the defined constants.
        /// </summary>
        public ClusterStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterStatus FindValue(string value)
        {
            return FindValue<ClusterStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataFusionRuntimeType.
    /// </summary>
    public class DataFusionRuntimeType : ConstantClass
    {
        /// <summary>
        /// Constant MultiThread for DataFusionRuntimeType
        /// </summary>
        public static readonly DataFusionRuntimeType MultiThread = new DataFusionRuntimeType("multi-thread");

        /// <summary>
        /// Constant MultiThreadAlt for DataFusionRuntimeType
        /// </summary>
        public static readonly DataFusionRuntimeType MultiThreadAlt = new DataFusionRuntimeType("multi-thread-alt");

        /// <summary>
        /// Constructs a custom DataFusionRuntimeType for a value not among the defined constants.
        /// </summary>
        public DataFusionRuntimeType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataFusionRuntimeType FindValue(string value)
        {
            return FindValue<DataFusionRuntimeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataFusionRuntimeType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DbBackupStatus.
    /// </summary>
    public class DbBackupStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETED for DbBackupStatus
        /// </summary>
        public static readonly DbBackupStatus COMPLETED = new DbBackupStatus("COMPLETED");

        /// <summary>
        /// Constant DELETED for DbBackupStatus
        /// </summary>
        public static readonly DbBackupStatus DELETED = new DbBackupStatus("DELETED");

        /// <summary>
        /// Constant DELETING for DbBackupStatus
        /// </summary>
        public static readonly DbBackupStatus DELETING = new DbBackupStatus("DELETING");

        /// <summary>
        /// Constant FAILED for DbBackupStatus
        /// </summary>
        public static readonly DbBackupStatus FAILED = new DbBackupStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for DbBackupStatus
        /// </summary>
        public static readonly DbBackupStatus IN_PROGRESS = new DbBackupStatus("IN_PROGRESS");

        /// <summary>
        /// Constructs a custom DbBackupStatus for a value not among the defined constants.
        /// </summary>
        public DbBackupStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DbBackupStatus FindValue(string value)
        {
            return FindValue<DbBackupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DbBackupStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DbBackupType.
    /// </summary>
    public class DbBackupType : ConstantClass
    {
        /// <summary>
        /// Constant CONTINUOUS for DbBackupType
        /// </summary>
        public static readonly DbBackupType CONTINUOUS = new DbBackupType("CONTINUOUS");

        /// <summary>
        /// Constant CUSTOM_SCHEDULE for DbBackupType
        /// </summary>
        public static readonly DbBackupType CUSTOM_SCHEDULE = new DbBackupType("CUSTOM_SCHEDULE");

        /// <summary>
        /// Constant DAILY for DbBackupType
        /// </summary>
        public static readonly DbBackupType DAILY = new DbBackupType("DAILY");

        /// <summary>
        /// Constant HOURLY for DbBackupType
        /// </summary>
        public static readonly DbBackupType HOURLY = new DbBackupType("HOURLY");

        /// <summary>
        /// Constant MONTHLY for DbBackupType
        /// </summary>
        public static readonly DbBackupType MONTHLY = new DbBackupType("MONTHLY");

        /// <summary>
        /// Constant ON_DEMAND for DbBackupType
        /// </summary>
        public static readonly DbBackupType ON_DEMAND = new DbBackupType("ON_DEMAND");

        /// <summary>
        /// Constant WEEKLY for DbBackupType
        /// </summary>
        public static readonly DbBackupType WEEKLY = new DbBackupType("WEEKLY");

        /// <summary>
        /// Constructs a custom DbBackupType for a value not among the defined constants.
        /// </summary>
        public DbBackupType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DbBackupType FindValue(string value)
        {
            return FindValue<DbBackupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DbBackupType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DbInstanceType.
    /// </summary>
    public class DbInstanceType : ConstantClass
    {
        /// <summary>
        /// Constant DbInflux12xlarge for DbInstanceType
        /// </summary>
        public static readonly DbInstanceType DbInflux12xlarge = new DbInstanceType("db.influx.12xlarge");

        /// <summary>
        /// Constant DbInflux16xlarge for DbInstanceType
        /// </summary>
        public static readonly DbInstanceType DbInflux16xlarge = new DbInstanceType("db.influx.16xlarge");

        /// <summary>
        /// Constant DbInflux24xlarge for DbInstanceType
        /// </summary>
        public static readonly DbInstanceType DbInflux24xlarge = new DbInstanceType("db.influx.24xlarge");

        /// <summary>
        /// Constant DbInflux2xlarge for DbInstanceType
        /// </summary>
        public static readonly DbInstanceType DbInflux2xlarge = new DbInstanceType("db.influx.2xlarge");

        /// <summary>
        /// Constant DbInflux4xlarge for DbInstanceType
        /// </summary>
        public static readonly DbInstanceType DbInflux4xlarge = new DbInstanceType("db.influx.4xlarge");

        /// <summary>
        /// Constant DbInflux8xlarge for DbInstanceType
        /// </summary>
        public static readonly DbInstanceType DbInflux8xlarge = new DbInstanceType("db.influx.8xlarge");

        /// <summary>
        /// Constant DbInfluxLarge for DbInstanceType
        /// </summary>
        public static readonly DbInstanceType DbInfluxLarge = new DbInstanceType("db.influx.large");

        /// <summary>
        /// Constant DbInfluxMedium for DbInstanceType
        /// </summary>
        public static readonly DbInstanceType DbInfluxMedium = new DbInstanceType("db.influx.medium");

        /// <summary>
        /// Constant DbInfluxXlarge for DbInstanceType
        /// </summary>
        public static readonly DbInstanceType DbInfluxXlarge = new DbInstanceType("db.influx.xlarge");

        /// <summary>
        /// Constructs a custom DbInstanceType for a value not among the defined constants.
        /// </summary>
        public DbInstanceType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DbInstanceType FindValue(string value)
        {
            return FindValue<DbInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DbInstanceType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DbStorageType.
    /// </summary>
    public class DbStorageType : ConstantClass
    {
        /// <summary>
        /// Constant InfluxIOIncludedT1 for DbStorageType
        /// </summary>
        public static readonly DbStorageType InfluxIOIncludedT1 = new DbStorageType("InfluxIOIncludedT1");

        /// <summary>
        /// Constant InfluxIOIncludedT2 for DbStorageType
        /// </summary>
        public static readonly DbStorageType InfluxIOIncludedT2 = new DbStorageType("InfluxIOIncludedT2");

        /// <summary>
        /// Constant InfluxIOIncludedT3 for DbStorageType
        /// </summary>
        public static readonly DbStorageType InfluxIOIncludedT3 = new DbStorageType("InfluxIOIncludedT3");

        /// <summary>
        /// Constructs a custom DbStorageType for a value not among the defined constants.
        /// </summary>
        public DbStorageType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DbStorageType FindValue(string value)
        {
            return FindValue<DbStorageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DbStorageType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DeploymentType.
    /// </summary>
    public class DeploymentType : ConstantClass
    {
        /// <summary>
        /// Constant SINGLE_AZ for DeploymentType
        /// </summary>
        public static readonly DeploymentType SINGLE_AZ = new DeploymentType("SINGLE_AZ");

        /// <summary>
        /// Constant WITH_MULTIAZ_STANDBY for DeploymentType
        /// </summary>
        public static readonly DeploymentType WITH_MULTIAZ_STANDBY = new DeploymentType("WITH_MULTIAZ_STANDBY");

        /// <summary>
        /// Constructs a custom DeploymentType for a value not among the defined constants.
        /// </summary>
        public DeploymentType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentType FindValue(string value)
        {
            return FindValue<DeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DurationType.
    /// </summary>
    public class DurationType : ConstantClass
    {
        /// <summary>
        /// Constant Days for DurationType
        /// </summary>
        public static readonly DurationType Days = new DurationType("days");

        /// <summary>
        /// Constant Hours for DurationType
        /// </summary>
        public static readonly DurationType Hours = new DurationType("hours");

        /// <summary>
        /// Constant Milliseconds for DurationType
        /// </summary>
        public static readonly DurationType Milliseconds = new DurationType("milliseconds");

        /// <summary>
        /// Constant Minutes for DurationType
        /// </summary>
        public static readonly DurationType Minutes = new DurationType("minutes");

        /// <summary>
        /// Constant Seconds for DurationType
        /// </summary>
        public static readonly DurationType Seconds = new DurationType("seconds");

        /// <summary>
        /// Constructs a custom DurationType for a value not among the defined constants.
        /// </summary>
        public DurationType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DurationType FindValue(string value)
        {
            return FindValue<DurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DurationType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type EngineType.
    /// </summary>
    public class EngineType : ConstantClass
    {
        /// <summary>
        /// Constant INFLUXDB_V2 for EngineType
        /// </summary>
        public static readonly EngineType INFLUXDB_V2 = new EngineType("INFLUXDB_V2");

        /// <summary>
        /// Constant INFLUXDB_V3_CORE for EngineType
        /// </summary>
        public static readonly EngineType INFLUXDB_V3_CORE = new EngineType("INFLUXDB_V3_CORE");

        /// <summary>
        /// Constant INFLUXDB_V3_ENTERPRISE for EngineType
        /// </summary>
        public static readonly EngineType INFLUXDB_V3_ENTERPRISE = new EngineType("INFLUXDB_V3_ENTERPRISE");

        /// <summary>
        /// Constructs a custom EngineType for a value not among the defined constants.
        /// </summary>
        public EngineType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EngineType FindValue(string value)
        {
            return FindValue<EngineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EngineType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FailoverMode.
    /// </summary>
    public class FailoverMode : ConstantClass
    {
        /// <summary>
        /// Constant AUTOMATIC for FailoverMode
        /// </summary>
        public static readonly FailoverMode AUTOMATIC = new FailoverMode("AUTOMATIC");

        /// <summary>
        /// Constant NO_FAILOVER for FailoverMode
        /// </summary>
        public static readonly FailoverMode NO_FAILOVER = new FailoverMode("NO_FAILOVER");

        /// <summary>
        /// Constructs a custom FailoverMode for a value not among the defined constants.
        /// </summary>
        public FailoverMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailoverMode FindValue(string value)
        {
            return FindValue<FailoverMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailoverMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type InstanceMode.
    /// </summary>
    public class InstanceMode : ConstantClass
    {
        /// <summary>
        /// Constant COMPACT for InstanceMode
        /// </summary>
        public static readonly InstanceMode COMPACT = new InstanceMode("COMPACT");

        /// <summary>
        /// Constant INGEST for InstanceMode
        /// </summary>
        public static readonly InstanceMode INGEST = new InstanceMode("INGEST");

        /// <summary>
        /// Constant PRIMARY for InstanceMode
        /// </summary>
        public static readonly InstanceMode PRIMARY = new InstanceMode("PRIMARY");

        /// <summary>
        /// Constant PROCESS for InstanceMode
        /// </summary>
        public static readonly InstanceMode PROCESS = new InstanceMode("PROCESS");

        /// <summary>
        /// Constant QUERY for InstanceMode
        /// </summary>
        public static readonly InstanceMode QUERY = new InstanceMode("QUERY");

        /// <summary>
        /// Constant REPLICA for InstanceMode
        /// </summary>
        public static readonly InstanceMode REPLICA = new InstanceMode("REPLICA");

        /// <summary>
        /// Constant STANDBY for InstanceMode
        /// </summary>
        public static readonly InstanceMode STANDBY = new InstanceMode("STANDBY");

        /// <summary>
        /// Constructs a custom InstanceMode for a value not among the defined constants.
        /// </summary>
        public InstanceMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceMode FindValue(string value)
        {
            return FindValue<InstanceMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LogFormats.
    /// </summary>
    public class LogFormats : ConstantClass
    {
        /// <summary>
        /// Constant Full for LogFormats
        /// </summary>
        public static readonly LogFormats Full = new LogFormats("full");

        /// <summary>
        /// Constructs a custom LogFormats for a value not among the defined constants.
        /// </summary>
        public LogFormats(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogFormats FindValue(string value)
        {
            return FindValue<LogFormats>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogFormats(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LogLevel.
    /// </summary>
    public class LogLevel : ConstantClass
    {
        /// <summary>
        /// Constant Debug for LogLevel
        /// </summary>
        public static readonly LogLevel Debug = new LogLevel("debug");

        /// <summary>
        /// Constant Error for LogLevel
        /// </summary>
        public static readonly LogLevel Error = new LogLevel("error");

        /// <summary>
        /// Constant Info for LogLevel
        /// </summary>
        public static readonly LogLevel Info = new LogLevel("info");

        /// <summary>
        /// Constructs a custom LogLevel for a value not among the defined constants.
        /// </summary>
        public LogLevel(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogLevel FindValue(string value)
        {
            return FindValue<LogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogLevel(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type NetworkType.
    /// </summary>
    public class NetworkType : ConstantClass
    {
        /// <summary>
        /// Constant DUAL for NetworkType
        /// </summary>
        public static readonly NetworkType DUAL = new NetworkType("DUAL");

        /// <summary>
        /// Constant IPV4 for NetworkType
        /// </summary>
        public static readonly NetworkType IPV4 = new NetworkType("IPV4");

        /// <summary>
        /// Constructs a custom NetworkType for a value not among the defined constants.
        /// </summary>
        public NetworkType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkType FindValue(string value)
        {
            return FindValue<NetworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ResourceDeploymentType.
    /// </summary>
    public class ResourceDeploymentType : ConstantClass
    {
        /// <summary>
        /// Constant MULTI_NODE_READ_REPLICAS for ResourceDeploymentType
        /// </summary>
        public static readonly ResourceDeploymentType MULTI_NODE_READ_REPLICAS = new ResourceDeploymentType("MULTI_NODE_READ_REPLICAS");

        /// <summary>
        /// Constant SINGLE_AZ for ResourceDeploymentType
        /// </summary>
        public static readonly ResourceDeploymentType SINGLE_AZ = new ResourceDeploymentType("SINGLE_AZ");

        /// <summary>
        /// Constant WITH_MULTIAZ_STANDBY for ResourceDeploymentType
        /// </summary>
        public static readonly ResourceDeploymentType WITH_MULTIAZ_STANDBY = new ResourceDeploymentType("WITH_MULTIAZ_STANDBY");

        /// <summary>
        /// Constructs a custom ResourceDeploymentType for a value not among the defined constants.
        /// </summary>
        public ResourceDeploymentType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceDeploymentType FindValue(string value)
        {
            return FindValue<ResourceDeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceDeploymentType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {
        /// <summary>
        /// Constant DB_CLUSTER for ResourceType
        /// </summary>
        public static readonly ResourceType DB_CLUSTER = new ResourceType("DB_CLUSTER");

        /// <summary>
        /// Constant DB_INSTANCE for ResourceType
        /// </summary>
        public static readonly ResourceType DB_INSTANCE = new ResourceType("DB_INSTANCE");

        /// <summary>
        /// Constructs a custom ResourceType for a value not among the defined constants.
        /// </summary>
        public ResourceType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RestoreMode.
    /// </summary>
    public class RestoreMode : ConstantClass
    {
        /// <summary>
        /// Constant NEW_RESOURCE for RestoreMode
        /// </summary>
        public static readonly RestoreMode NEW_RESOURCE = new RestoreMode("NEW_RESOURCE");

        /// <summary>
        /// Constant REPLACE_EXISTING for RestoreMode
        /// </summary>
        public static readonly RestoreMode REPLACE_EXISTING = new RestoreMode("REPLACE_EXISTING");

        /// <summary>
        /// Constructs a custom RestoreMode for a value not among the defined constants.
        /// </summary>
        public RestoreMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RestoreMode FindValue(string value)
        {
            return FindValue<RestoreMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RestoreMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RestoreStatus.
    /// </summary>
    public class RestoreStatus : ConstantClass
    {
        /// <summary>
        /// Constant RESTORING for RestoreStatus
        /// </summary>
        public static readonly RestoreStatus RESTORING = new RestoreStatus("RESTORING");

        /// <summary>
        /// Constructs a custom RestoreStatus for a value not among the defined constants.
        /// </summary>
        public RestoreStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RestoreStatus FindValue(string value)
        {
            return FindValue<RestoreStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RestoreStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {
        /// <summary>
        /// Constant AVAILABLE for Status
        /// </summary>
        public static readonly Status AVAILABLE = new Status("AVAILABLE");

        /// <summary>
        /// Constant CREATING for Status
        /// </summary>
        public static readonly Status CREATING = new Status("CREATING");

        /// <summary>
        /// Constant DELETED for Status
        /// </summary>
        public static readonly Status DELETED = new Status("DELETED");

        /// <summary>
        /// Constant DELETING for Status
        /// </summary>
        public static readonly Status DELETING = new Status("DELETING");

        /// <summary>
        /// Constant FAILED for Status
        /// </summary>
        public static readonly Status FAILED = new Status("FAILED");

        /// <summary>
        /// Constant MAINTENANCE for Status
        /// </summary>
        public static readonly Status MAINTENANCE = new Status("MAINTENANCE");

        /// <summary>
        /// Constant MODIFYING for Status
        /// </summary>
        public static readonly Status MODIFYING = new Status("MODIFYING");

        /// <summary>
        /// Constant REBOOTING for Status
        /// </summary>
        public static readonly Status REBOOTING = new Status("REBOOTING");

        /// <summary>
        /// Constant REBOOT_FAILED for Status
        /// </summary>
        public static readonly Status REBOOT_FAILED = new Status("REBOOT_FAILED");

        /// <summary>
        /// Constant RESTORE_FAILED for Status
        /// </summary>
        public static readonly Status RESTORE_FAILED = new Status("RESTORE_FAILED");

        /// <summary>
        /// Constant RESTORING for Status
        /// </summary>
        public static readonly Status RESTORING = new Status("RESTORING");

        /// <summary>
        /// Constant UPDATING for Status
        /// </summary>
        public static readonly Status UPDATING = new Status("UPDATING");

        /// <summary>
        /// Constant UPDATING_DEPLOYMENT_TYPE for Status
        /// </summary>
        public static readonly Status UPDATING_DEPLOYMENT_TYPE = new Status("UPDATING_DEPLOYMENT_TYPE");

        /// <summary>
        /// Constant UPDATING_INSTANCE_TYPE for Status
        /// </summary>
        public static readonly Status UPDATING_INSTANCE_TYPE = new Status("UPDATING_INSTANCE_TYPE");

        /// <summary>
        /// Constructs a custom Status for a value not among the defined constants.
        /// </summary>
        public Status(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TracingType.
    /// </summary>
    public class TracingType : ConstantClass
    {
        /// <summary>
        /// Constant Disabled for TracingType
        /// </summary>
        public static readonly TracingType Disabled = new TracingType("disabled");

        /// <summary>
        /// Constant Jaeger for TracingType
        /// </summary>
        public static readonly TracingType Jaeger = new TracingType("jaeger");

        /// <summary>
        /// Constant Log for TracingType
        /// </summary>
        public static readonly TracingType Log = new TracingType("log");

        /// <summary>
        /// Constructs a custom TracingType for a value not among the defined constants.
        /// </summary>
        public TracingType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TracingType FindValue(string value)
        {
            return FindValue<TracingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TracingType(string value)
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
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");

        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");

        /// <summary>
        /// Constructs a custom ValidationExceptionReason for a value not among the defined constants.
        /// </summary>
        public ValidationExceptionReason(string value) : base(value) { }

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
