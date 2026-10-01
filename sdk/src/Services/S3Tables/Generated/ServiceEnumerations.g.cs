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

namespace Amazon.S3Tables
{
    /// <summary>
    /// Constants used for properties of type IcebergCompactionStrategy.
    /// </summary>
    public class IcebergCompactionStrategy : ConstantClass
    {
        /// <summary>
        /// Constant Auto for IcebergCompactionStrategy
        /// </summary>
        public static readonly IcebergCompactionStrategy Auto = new IcebergCompactionStrategy("auto");

        /// <summary>
        /// Constant Binpack for IcebergCompactionStrategy
        /// </summary>
        public static readonly IcebergCompactionStrategy Binpack = new IcebergCompactionStrategy("binpack");

        /// <summary>
        /// Constant Sort for IcebergCompactionStrategy
        /// </summary>
        public static readonly IcebergCompactionStrategy Sort = new IcebergCompactionStrategy("sort");

        /// <summary>
        /// Constant ZOrder for IcebergCompactionStrategy
        /// </summary>
        public static readonly IcebergCompactionStrategy ZOrder = new IcebergCompactionStrategy("z-order");

        /// <summary>
        /// Constructs a custom IcebergCompactionStrategy for a value not among the defined constants.
        /// </summary>
        public IcebergCompactionStrategy(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IcebergCompactionStrategy FindValue(string value)
        {
            return FindValue<IcebergCompactionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IcebergCompactionStrategy(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IcebergNullOrder.
    /// </summary>
    public class IcebergNullOrder : ConstantClass
    {
        /// <summary>
        /// Constant NullsFirst for IcebergNullOrder
        /// </summary>
        public static readonly IcebergNullOrder NullsFirst = new IcebergNullOrder("nulls-first");

        /// <summary>
        /// Constant NullsLast for IcebergNullOrder
        /// </summary>
        public static readonly IcebergNullOrder NullsLast = new IcebergNullOrder("nulls-last");

        /// <summary>
        /// Constructs a custom IcebergNullOrder for a value not among the defined constants.
        /// </summary>
        public IcebergNullOrder(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IcebergNullOrder FindValue(string value)
        {
            return FindValue<IcebergNullOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IcebergNullOrder(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IcebergSortDirection.
    /// </summary>
    public class IcebergSortDirection : ConstantClass
    {
        /// <summary>
        /// Constant Asc for IcebergSortDirection
        /// </summary>
        public static readonly IcebergSortDirection Asc = new IcebergSortDirection("asc");

        /// <summary>
        /// Constant Desc for IcebergSortDirection
        /// </summary>
        public static readonly IcebergSortDirection Desc = new IcebergSortDirection("desc");

        /// <summary>
        /// Constructs a custom IcebergSortDirection for a value not among the defined constants.
        /// </summary>
        public IcebergSortDirection(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IcebergSortDirection FindValue(string value)
        {
            return FindValue<IcebergSortDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IcebergSortDirection(string value)
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
        /// Constant Disabled for JobStatus
        /// </summary>
        public static readonly JobStatus Disabled = new JobStatus("Disabled");

        /// <summary>
        /// Constant Failed for JobStatus
        /// </summary>
        public static readonly JobStatus Failed = new JobStatus("Failed");

        /// <summary>
        /// Constant Not_Yet_Run for JobStatus
        /// </summary>
        public static readonly JobStatus Not_Yet_Run = new JobStatus("Not_Yet_Run");

        /// <summary>
        /// Constant Successful for JobStatus
        /// </summary>
        public static readonly JobStatus Successful = new JobStatus("Successful");

        /// <summary>
        /// Constructs a custom JobStatus for a value not among the defined constants.
        /// </summary>
        public JobStatus(string value) : base(value) { }

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
    /// Constants used for properties of type MaintenanceStatus.
    /// </summary>
    public class MaintenanceStatus : ConstantClass
    {
        /// <summary>
        /// Constant Disabled for MaintenanceStatus
        /// </summary>
        public static readonly MaintenanceStatus Disabled = new MaintenanceStatus("disabled");

        /// <summary>
        /// Constant Enabled for MaintenanceStatus
        /// </summary>
        public static readonly MaintenanceStatus Enabled = new MaintenanceStatus("enabled");

        /// <summary>
        /// Constructs a custom MaintenanceStatus for a value not among the defined constants.
        /// </summary>
        public MaintenanceStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceStatus FindValue(string value)
        {
            return FindValue<MaintenanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type OpenTableFormat.
    /// </summary>
    public class OpenTableFormat : ConstantClass
    {
        /// <summary>
        /// Constant ICEBERG for OpenTableFormat
        /// </summary>
        public static readonly OpenTableFormat ICEBERG = new OpenTableFormat("ICEBERG");

        /// <summary>
        /// Constructs a custom OpenTableFormat for a value not among the defined constants.
        /// </summary>
        public OpenTableFormat(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenTableFormat FindValue(string value)
        {
            return FindValue<OpenTableFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenTableFormat(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ReplicationStatus.
    /// </summary>
    public class ReplicationStatus : ConstantClass
    {
        /// <summary>
        /// Constant Completed for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus Completed = new ReplicationStatus("completed");

        /// <summary>
        /// Constant Failed for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus Failed = new ReplicationStatus("failed");

        /// <summary>
        /// Constant Pending for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus Pending = new ReplicationStatus("pending");

        /// <summary>
        /// Constructs a custom ReplicationStatus for a value not among the defined constants.
        /// </summary>
        public ReplicationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationStatus FindValue(string value)
        {
            return FindValue<ReplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SSEAlgorithm.
    /// </summary>
    public class SSEAlgorithm : ConstantClass
    {
        /// <summary>
        /// Constant AES256 for SSEAlgorithm
        /// </summary>
        public static readonly SSEAlgorithm AES256 = new SSEAlgorithm("AES256");

        /// <summary>
        /// Constant AwsKms for SSEAlgorithm
        /// </summary>
        public static readonly SSEAlgorithm AwsKms = new SSEAlgorithm("aws:kms");

        /// <summary>
        /// Constructs a custom SSEAlgorithm for a value not among the defined constants.
        /// </summary>
        public SSEAlgorithm(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SSEAlgorithm FindValue(string value)
        {
            return FindValue<SSEAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SSEAlgorithm(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SchemaV2FieldType.
    /// </summary>
    public class SchemaV2FieldType : ConstantClass
    {
        /// <summary>
        /// Constant Struct for SchemaV2FieldType
        /// </summary>
        public static readonly SchemaV2FieldType Struct = new SchemaV2FieldType("struct");

        /// <summary>
        /// Constructs a custom SchemaV2FieldType for a value not among the defined constants.
        /// </summary>
        public SchemaV2FieldType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaV2FieldType FindValue(string value)
        {
            return FindValue<SchemaV2FieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaV2FieldType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type StorageClass.
    /// </summary>
    public class StorageClass : ConstantClass
    {
        /// <summary>
        /// Constant INTELLIGENT_TIERING for StorageClass
        /// </summary>
        public static readonly StorageClass INTELLIGENT_TIERING = new StorageClass("INTELLIGENT_TIERING");

        /// <summary>
        /// Constant STANDARD for StorageClass
        /// </summary>
        public static readonly StorageClass STANDARD = new StorageClass("STANDARD");

        /// <summary>
        /// Constructs a custom StorageClass for a value not among the defined constants.
        /// </summary>
        public StorageClass(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageClass FindValue(string value)
        {
            return FindValue<StorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageClass(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TableBucketMaintenanceType.
    /// </summary>
    public class TableBucketMaintenanceType : ConstantClass
    {
        /// <summary>
        /// Constant IcebergUnreferencedFileRemoval for TableBucketMaintenanceType
        /// </summary>
        public static readonly TableBucketMaintenanceType IcebergUnreferencedFileRemoval = new TableBucketMaintenanceType("icebergUnreferencedFileRemoval");

        /// <summary>
        /// Constructs a custom TableBucketMaintenanceType for a value not among the defined constants.
        /// </summary>
        public TableBucketMaintenanceType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableBucketMaintenanceType FindValue(string value)
        {
            return FindValue<TableBucketMaintenanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableBucketMaintenanceType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TableBucketType.
    /// </summary>
    public class TableBucketType : ConstantClass
    {
        /// <summary>
        /// Constant Aws for TableBucketType
        /// </summary>
        public static readonly TableBucketType Aws = new TableBucketType("aws");

        /// <summary>
        /// Constant Customer for TableBucketType
        /// </summary>
        public static readonly TableBucketType Customer = new TableBucketType("customer");

        /// <summary>
        /// Constructs a custom TableBucketType for a value not among the defined constants.
        /// </summary>
        public TableBucketType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableBucketType FindValue(string value)
        {
            return FindValue<TableBucketType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableBucketType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TableMaintenanceJobType.
    /// </summary>
    public class TableMaintenanceJobType : ConstantClass
    {
        /// <summary>
        /// Constant IcebergCompaction for TableMaintenanceJobType
        /// </summary>
        public static readonly TableMaintenanceJobType IcebergCompaction = new TableMaintenanceJobType("icebergCompaction");

        /// <summary>
        /// Constant IcebergSnapshotManagement for TableMaintenanceJobType
        /// </summary>
        public static readonly TableMaintenanceJobType IcebergSnapshotManagement = new TableMaintenanceJobType("icebergSnapshotManagement");

        /// <summary>
        /// Constant IcebergUnreferencedFileRemoval for TableMaintenanceJobType
        /// </summary>
        public static readonly TableMaintenanceJobType IcebergUnreferencedFileRemoval = new TableMaintenanceJobType("icebergUnreferencedFileRemoval");

        /// <summary>
        /// Constructs a custom TableMaintenanceJobType for a value not among the defined constants.
        /// </summary>
        public TableMaintenanceJobType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableMaintenanceJobType FindValue(string value)
        {
            return FindValue<TableMaintenanceJobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableMaintenanceJobType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TableMaintenanceType.
    /// </summary>
    public class TableMaintenanceType : ConstantClass
    {
        /// <summary>
        /// Constant IcebergCompaction for TableMaintenanceType
        /// </summary>
        public static readonly TableMaintenanceType IcebergCompaction = new TableMaintenanceType("icebergCompaction");

        /// <summary>
        /// Constant IcebergSnapshotManagement for TableMaintenanceType
        /// </summary>
        public static readonly TableMaintenanceType IcebergSnapshotManagement = new TableMaintenanceType("icebergSnapshotManagement");

        /// <summary>
        /// Constructs a custom TableMaintenanceType for a value not among the defined constants.
        /// </summary>
        public TableMaintenanceType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableMaintenanceType FindValue(string value)
        {
            return FindValue<TableMaintenanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableMaintenanceType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TableRecordExpirationJobStatus.
    /// </summary>
    public class TableRecordExpirationJobStatus : ConstantClass
    {
        /// <summary>
        /// Constant Disabled for TableRecordExpirationJobStatus
        /// </summary>
        public static readonly TableRecordExpirationJobStatus Disabled = new TableRecordExpirationJobStatus("Disabled");

        /// <summary>
        /// Constant Failed for TableRecordExpirationJobStatus
        /// </summary>
        public static readonly TableRecordExpirationJobStatus Failed = new TableRecordExpirationJobStatus("Failed");

        /// <summary>
        /// Constant NotYetRun for TableRecordExpirationJobStatus
        /// </summary>
        public static readonly TableRecordExpirationJobStatus NotYetRun = new TableRecordExpirationJobStatus("NotYetRun");

        /// <summary>
        /// Constant Successful for TableRecordExpirationJobStatus
        /// </summary>
        public static readonly TableRecordExpirationJobStatus Successful = new TableRecordExpirationJobStatus("Successful");

        /// <summary>
        /// Constructs a custom TableRecordExpirationJobStatus for a value not among the defined constants.
        /// </summary>
        public TableRecordExpirationJobStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableRecordExpirationJobStatus FindValue(string value)
        {
            return FindValue<TableRecordExpirationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableRecordExpirationJobStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TableRecordExpirationStatus.
    /// </summary>
    public class TableRecordExpirationStatus : ConstantClass
    {
        /// <summary>
        /// Constant Disabled for TableRecordExpirationStatus
        /// </summary>
        public static readonly TableRecordExpirationStatus Disabled = new TableRecordExpirationStatus("disabled");

        /// <summary>
        /// Constant Enabled for TableRecordExpirationStatus
        /// </summary>
        public static readonly TableRecordExpirationStatus Enabled = new TableRecordExpirationStatus("enabled");

        /// <summary>
        /// Constructs a custom TableRecordExpirationStatus for a value not among the defined constants.
        /// </summary>
        public TableRecordExpirationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableRecordExpirationStatus FindValue(string value)
        {
            return FindValue<TableRecordExpirationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableRecordExpirationStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TableType.
    /// </summary>
    public class TableType : ConstantClass
    {
        /// <summary>
        /// Constant Aws for TableType
        /// </summary>
        public static readonly TableType Aws = new TableType("aws");

        /// <summary>
        /// Constant Customer for TableType
        /// </summary>
        public static readonly TableType Customer = new TableType("customer");

        /// <summary>
        /// Constructs a custom TableType for a value not among the defined constants.
        /// </summary>
        public TableType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableType FindValue(string value)
        {
            return FindValue<TableType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableType(string value)
        {
            return FindValue(value);
        }
    }
}
