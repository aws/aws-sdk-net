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
    /// Constants used for properties of type CompressionCodec.
    /// </summary>
    public class CompressionCodec : ConstantClass
    {
        /// <summary>
        /// Constant Gzip for CompressionCodec
        /// </summary>
        public static readonly CompressionCodec Gzip = new CompressionCodec("gzip");

        /// <summary>
        /// Constant Snappy for CompressionCodec
        /// </summary>
        public static readonly CompressionCodec Snappy = new CompressionCodec("snappy");

        /// <summary>
        /// Constant Uncompressed for CompressionCodec
        /// </summary>
        public static readonly CompressionCodec Uncompressed = new CompressionCodec("uncompressed");

        /// <summary>
        /// Constant Zstd for CompressionCodec
        /// </summary>
        public static readonly CompressionCodec Zstd = new CompressionCodec("zstd");

        /// <summary>
        /// Constructs a custom CompressionCodec for a value not among the defined constants.
        /// </summary>
        public CompressionCodec(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompressionCodec FindValue(string value)
        {
            return FindValue<CompressionCodec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompressionCodec(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataFileFormat.
    /// </summary>
    public class DataFileFormat : ConstantClass
    {
        /// <summary>
        /// Constant Parquet for DataFileFormat
        /// </summary>
        public static readonly DataFileFormat Parquet = new DataFileFormat("parquet");

        /// <summary>
        /// Constructs a custom DataFileFormat for a value not among the defined constants.
        /// </summary>
        public DataFileFormat(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataFileFormat FindValue(string value)
        {
            return FindValue<DataFileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataFileFormat(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FindingCategory.
    /// </summary>
    public class FindingCategory : ConstantClass
    {
        /// <summary>
        /// Constant Access for FindingCategory
        /// </summary>
        public static readonly FindingCategory Access = new FindingCategory("access");

        /// <summary>
        /// Constant Data for FindingCategory
        /// </summary>
        public static readonly FindingCategory Data = new FindingCategory("data");

        /// <summary>
        /// Constant Internal for FindingCategory
        /// </summary>
        public static readonly FindingCategory Internal = new FindingCategory("internal");

        /// <summary>
        /// Constant Metadata for FindingCategory
        /// </summary>
        public static readonly FindingCategory Metadata = new FindingCategory("metadata");

        /// <summary>
        /// Constructs a custom FindingCategory for a value not among the defined constants.
        /// </summary>
        public FindingCategory(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingCategory FindValue(string value)
        {
            return FindValue<FindingCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingCategory(string value)
        {
            return FindValue(value);
        }
    }

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
    /// Constants used for properties of type IncompatibleValuesPolicy.
    /// </summary>
    public class IncompatibleValuesPolicy : ConstantClass
    {
        /// <summary>
        /// Constant Fail for IncompatibleValuesPolicy
        /// </summary>
        public static readonly IncompatibleValuesPolicy Fail = new IncompatibleValuesPolicy("fail");

        /// <summary>
        /// Constant SetNull for IncompatibleValuesPolicy
        /// </summary>
        public static readonly IncompatibleValuesPolicy SetNull = new IncompatibleValuesPolicy("setNull");

        /// <summary>
        /// Constructs a custom IncompatibleValuesPolicy for a value not among the defined constants.
        /// </summary>
        public IncompatibleValuesPolicy(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IncompatibleValuesPolicy FindValue(string value)
        {
            return FindValue<IncompatibleValuesPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IncompatibleValuesPolicy(string value)
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
    /// Constants used for properties of type MigrationFailureCode.
    /// </summary>
    public class MigrationFailureCode : ConstantClass
    {
        /// <summary>
        /// Constant DestinationPermissions for MigrationFailureCode
        /// </summary>
        public static readonly MigrationFailureCode DestinationPermissions = new MigrationFailureCode("destinationPermissions");

        /// <summary>
        /// Constant InternalError for MigrationFailureCode
        /// </summary>
        public static readonly MigrationFailureCode InternalError = new MigrationFailureCode("internalError");

        /// <summary>
        /// Constant ObjectCompatibilityReport for MigrationFailureCode
        /// </summary>
        public static readonly MigrationFailureCode ObjectCompatibilityReport = new MigrationFailureCode("objectCompatibilityReport");

        /// <summary>
        /// Constant ObjectMigrationReport for MigrationFailureCode
        /// </summary>
        public static readonly MigrationFailureCode ObjectMigrationReport = new MigrationFailureCode("objectMigrationReport");

        /// <summary>
        /// Constant ReportBucketNotSupported for MigrationFailureCode
        /// </summary>
        public static readonly MigrationFailureCode ReportBucketNotSupported = new MigrationFailureCode("reportBucketNotSupported");

        /// <summary>
        /// Constant ResourceNotFound for MigrationFailureCode
        /// </summary>
        public static readonly MigrationFailureCode ResourceNotFound = new MigrationFailureCode("resourceNotFound");

        /// <summary>
        /// Constant RolePermissions for MigrationFailureCode
        /// </summary>
        public static readonly MigrationFailureCode RolePermissions = new MigrationFailureCode("rolePermissions");

        /// <summary>
        /// Constant SourceNotSupported for MigrationFailureCode
        /// </summary>
        public static readonly MigrationFailureCode SourceNotSupported = new MigrationFailureCode("sourceNotSupported");

        /// <summary>
        /// Constant SourcePermissions for MigrationFailureCode
        /// </summary>
        public static readonly MigrationFailureCode SourcePermissions = new MigrationFailureCode("sourcePermissions");

        /// <summary>
        /// Constant TableCompatibilityReport for MigrationFailureCode
        /// </summary>
        public static readonly MigrationFailureCode TableCompatibilityReport = new MigrationFailureCode("tableCompatibilityReport");

        /// <summary>
        /// Constructs a custom MigrationFailureCode for a value not among the defined constants.
        /// </summary>
        public MigrationFailureCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationFailureCode FindValue(string value)
        {
            return FindValue<MigrationFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationFailureCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MigrationRequestedState.
    /// </summary>
    public class MigrationRequestedState : ConstantClass
    {
        /// <summary>
        /// Constant Cancelled for MigrationRequestedState
        /// </summary>
        public static readonly MigrationRequestedState Cancelled = new MigrationRequestedState("cancelled");

        /// <summary>
        /// Constant Queued for MigrationRequestedState
        /// </summary>
        public static readonly MigrationRequestedState Queued = new MigrationRequestedState("queued");

        /// <summary>
        /// Constructs a custom MigrationRequestedState for a value not among the defined constants.
        /// </summary>
        public MigrationRequestedState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationRequestedState FindValue(string value)
        {
            return FindValue<MigrationRequestedState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationRequestedState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MigrationSourceType.
    /// </summary>
    public class MigrationSourceType : ConstantClass
    {
        /// <summary>
        /// Constant GlueTable for MigrationSourceType
        /// </summary>
        public static readonly MigrationSourceType GlueTable = new MigrationSourceType("glueTable");

        /// <summary>
        /// Constructs a custom MigrationSourceType for a value not among the defined constants.
        /// </summary>
        public MigrationSourceType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationSourceType FindValue(string value)
        {
            return FindValue<MigrationSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationSourceType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MigrationState.
    /// </summary>
    public class MigrationState : ConstantClass
    {
        /// <summary>
        /// Constant Cancelled for MigrationState
        /// </summary>
        public static readonly MigrationState Cancelled = new MigrationState("cancelled");

        /// <summary>
        /// Constant Cancelling for MigrationState
        /// </summary>
        public static readonly MigrationState Cancelling = new MigrationState("cancelling");

        /// <summary>
        /// Constant Failed for MigrationState
        /// </summary>
        public static readonly MigrationState Failed = new MigrationState("failed");

        /// <summary>
        /// Constant Migrating for MigrationState
        /// </summary>
        public static readonly MigrationState Migrating = new MigrationState("migrating");

        /// <summary>
        /// Constant New for MigrationState
        /// </summary>
        public static readonly MigrationState New = new MigrationState("new");

        /// <summary>
        /// Constant PendingReview for MigrationState
        /// </summary>
        public static readonly MigrationState PendingReview = new MigrationState("pendingReview");

        /// <summary>
        /// Constant Planning for MigrationState
        /// </summary>
        public static readonly MigrationState Planning = new MigrationState("planning");

        /// <summary>
        /// Constant Queued for MigrationState
        /// </summary>
        public static readonly MigrationState Queued = new MigrationState("queued");

        /// <summary>
        /// Constant Succeeded for MigrationState
        /// </summary>
        public static readonly MigrationState Succeeded = new MigrationState("succeeded");

        /// <summary>
        /// Constructs a custom MigrationState for a value not among the defined constants.
        /// </summary>
        public MigrationState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationState FindValue(string value)
        {
            return FindValue<MigrationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MigrationType.
    /// </summary>
    public class MigrationType : ConstantClass
    {
        /// <summary>
        /// Constant Start for MigrationType
        /// </summary>
        public static readonly MigrationType Start = new MigrationType("start");

        /// <summary>
        /// Constant Sync for MigrationType
        /// </summary>
        public static readonly MigrationType Sync = new MigrationType("sync");

        /// <summary>
        /// Constructs a custom MigrationType for a value not among the defined constants.
        /// </summary>
        public MigrationType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationType FindValue(string value)
        {
            return FindValue<MigrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationType(string value)
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

    /// <summary>
    /// Constants used for properties of type UnmatchedSourceFieldsPolicy.
    /// </summary>
    public class UnmatchedSourceFieldsPolicy : ConstantClass
    {
        /// <summary>
        /// Constant Drop for UnmatchedSourceFieldsPolicy
        /// </summary>
        public static readonly UnmatchedSourceFieldsPolicy Drop = new UnmatchedSourceFieldsPolicy("drop");

        /// <summary>
        /// Constant Fail for UnmatchedSourceFieldsPolicy
        /// </summary>
        public static readonly UnmatchedSourceFieldsPolicy Fail = new UnmatchedSourceFieldsPolicy("fail");

        /// <summary>
        /// Constructs a custom UnmatchedSourceFieldsPolicy for a value not among the defined constants.
        /// </summary>
        public UnmatchedSourceFieldsPolicy(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnmatchedSourceFieldsPolicy FindValue(string value)
        {
            return FindValue<UnmatchedSourceFieldsPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnmatchedSourceFieldsPolicy(string value)
        {
            return FindValue(value);
        }
    }
}
