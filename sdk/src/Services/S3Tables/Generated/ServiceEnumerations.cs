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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IcebergCompactionStrategy(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceStatus(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpenTableFormat(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SSEAlgorithm(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type TableBucketMaintenanceType.
    /// </summary>
    public class TableBucketMaintenanceType : ConstantClass
    {

        /// <summary>
        /// Constant IcebergUnreferencedFileRemoval for TableBucketMaintenanceType
        /// </summary>
        public static readonly TableBucketMaintenanceType IcebergUnreferencedFileRemoval = new TableBucketMaintenanceType("icebergUnreferencedFileRemoval");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableBucketMaintenanceType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableBucketType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableMaintenanceJobType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableMaintenanceType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableType(string value)
            : base(value)
        {
        }

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