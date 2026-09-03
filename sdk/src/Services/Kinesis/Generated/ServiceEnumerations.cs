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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Kinesis
{

    /// <summary>
    /// Constants used for properties of type ChannelDestinationType.
    /// </summary>
    public class ChannelDestinationType : ConstantClass
    {

        /// <summary>
        /// Constant S3 for ChannelDestinationType
        /// </summary>
        public static readonly ChannelDestinationType S3 = new ChannelDestinationType("S3");
        /// <summary>
        /// Constant S3_TABLES for ChannelDestinationType
        /// </summary>
        public static readonly ChannelDestinationType S3_TABLES = new ChannelDestinationType("S3_TABLES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelDestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelDestinationType FindValue(string value)
        {
            return FindValue<ChannelDestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelDestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelEncryptionType.
    /// </summary>
    public class ChannelEncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant KMS for ChannelEncryptionType
        /// </summary>
        public static readonly ChannelEncryptionType KMS = new ChannelEncryptionType("KMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelEncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelEncryptionType FindValue(string value)
        {
            return FindValue<ChannelEncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelEncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelStatus.
    /// </summary>
    public class ChannelStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus ACTIVE = new ChannelStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus CREATING = new ChannelStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus DELETING = new ChannelStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus FAILED = new ChannelStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus UPDATING = new ChannelStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelStatus FindValue(string value)
        {
            return FindValue<ChannelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConsumerStatus.
    /// </summary>
    public class ConsumerStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ConsumerStatus
        /// </summary>
        public static readonly ConsumerStatus ACTIVE = new ConsumerStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ConsumerStatus
        /// </summary>
        public static readonly ConsumerStatus CREATING = new ConsumerStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ConsumerStatus
        /// </summary>
        public static readonly ConsumerStatus DELETING = new ConsumerStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConsumerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConsumerStatus FindValue(string value)
        {
            return FindValue<ConsumerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConsumerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant KMS for EncryptionType
        /// </summary>
        public static readonly EncryptionType KMS = new EncryptionType("KMS");
        /// <summary>
        /// Constant NONE for EncryptionType
        /// </summary>
        public static readonly EncryptionType NONE = new EncryptionType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricsName.
    /// </summary>
    public class MetricsName : ConstantClass
    {

        /// <summary>
        /// Constant ALL for MetricsName
        /// </summary>
        public static readonly MetricsName ALL = new MetricsName("ALL");
        /// <summary>
        /// Constant IncomingBytes for MetricsName
        /// </summary>
        public static readonly MetricsName IncomingBytes = new MetricsName("IncomingBytes");
        /// <summary>
        /// Constant IncomingRecords for MetricsName
        /// </summary>
        public static readonly MetricsName IncomingRecords = new MetricsName("IncomingRecords");
        /// <summary>
        /// Constant IteratorAgeMilliseconds for MetricsName
        /// </summary>
        public static readonly MetricsName IteratorAgeMilliseconds = new MetricsName("IteratorAgeMilliseconds");
        /// <summary>
        /// Constant OutgoingBytes for MetricsName
        /// </summary>
        public static readonly MetricsName OutgoingBytes = new MetricsName("OutgoingBytes");
        /// <summary>
        /// Constant OutgoingRecords for MetricsName
        /// </summary>
        public static readonly MetricsName OutgoingRecords = new MetricsName("OutgoingRecords");
        /// <summary>
        /// Constant ReadProvisionedThroughputExceeded for MetricsName
        /// </summary>
        public static readonly MetricsName ReadProvisionedThroughputExceeded = new MetricsName("ReadProvisionedThroughputExceeded");
        /// <summary>
        /// Constant WriteProvisionedThroughputExceeded for MetricsName
        /// </summary>
        public static readonly MetricsName WriteProvisionedThroughputExceeded = new MetricsName("WriteProvisionedThroughputExceeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricsName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricsName FindValue(string value)
        {
            return FindValue<MetricsName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricsName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MinimumThroughputBillingCommitmentInputStatus.
    /// </summary>
    public class MinimumThroughputBillingCommitmentInputStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for MinimumThroughputBillingCommitmentInputStatus
        /// </summary>
        public static readonly MinimumThroughputBillingCommitmentInputStatus DISABLED = new MinimumThroughputBillingCommitmentInputStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for MinimumThroughputBillingCommitmentInputStatus
        /// </summary>
        public static readonly MinimumThroughputBillingCommitmentInputStatus ENABLED = new MinimumThroughputBillingCommitmentInputStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MinimumThroughputBillingCommitmentInputStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MinimumThroughputBillingCommitmentInputStatus FindValue(string value)
        {
            return FindValue<MinimumThroughputBillingCommitmentInputStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MinimumThroughputBillingCommitmentInputStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MinimumThroughputBillingCommitmentOutputStatus.
    /// </summary>
    public class MinimumThroughputBillingCommitmentOutputStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for MinimumThroughputBillingCommitmentOutputStatus
        /// </summary>
        public static readonly MinimumThroughputBillingCommitmentOutputStatus DISABLED = new MinimumThroughputBillingCommitmentOutputStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for MinimumThroughputBillingCommitmentOutputStatus
        /// </summary>
        public static readonly MinimumThroughputBillingCommitmentOutputStatus ENABLED = new MinimumThroughputBillingCommitmentOutputStatus("ENABLED");
        /// <summary>
        /// Constant ENABLED_UNTIL_EARLIEST_ALLOWED_END for MinimumThroughputBillingCommitmentOutputStatus
        /// </summary>
        public static readonly MinimumThroughputBillingCommitmentOutputStatus ENABLED_UNTIL_EARLIEST_ALLOWED_END = new MinimumThroughputBillingCommitmentOutputStatus("ENABLED_UNTIL_EARLIEST_ALLOWED_END");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MinimumThroughputBillingCommitmentOutputStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MinimumThroughputBillingCommitmentOutputStatus FindValue(string value)
        {
            return FindValue<MinimumThroughputBillingCommitmentOutputStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MinimumThroughputBillingCommitmentOutputStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PartitionTransform.
    /// </summary>
    public class PartitionTransform : ConstantClass
    {

        /// <summary>
        /// Constant TIME_HOUR for PartitionTransform
        /// </summary>
        public static readonly PartitionTransform TIME_HOUR = new PartitionTransform("TIME_HOUR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartitionTransform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartitionTransform FindValue(string value)
        {
            return FindValue<PartitionTransform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartitionTransform(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordFormatType.
    /// </summary>
    public class RecordFormatType : ConstantClass
    {

        /// <summary>
        /// Constant BYTE_ARRAY for RecordFormatType
        /// </summary>
        public static readonly RecordFormatType BYTE_ARRAY = new RecordFormatType("BYTE_ARRAY");
        /// <summary>
        /// Constant GSR_JSON for RecordFormatType
        /// </summary>
        public static readonly RecordFormatType GSR_JSON = new RecordFormatType("GSR_JSON");
        /// <summary>
        /// Constant JSON for RecordFormatType
        /// </summary>
        public static readonly RecordFormatType JSON = new RecordFormatType("JSON");
        /// <summary>
        /// Constant STRING for RecordFormatType
        /// </summary>
        public static readonly RecordFormatType STRING = new RecordFormatType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordFormatType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordFormatType FindValue(string value)
        {
            return FindValue<RecordFormatType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordFormatType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3CompressionType.
    /// </summary>
    public class S3CompressionType : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for S3CompressionType
        /// </summary>
        public static readonly S3CompressionType GZIP = new S3CompressionType("GZIP");
        /// <summary>
        /// Constant NONE for S3CompressionType
        /// </summary>
        public static readonly S3CompressionType NONE = new S3CompressionType("NONE");
        /// <summary>
        /// Constant ZSTD for S3CompressionType
        /// </summary>
        public static readonly S3CompressionType ZSTD = new S3CompressionType("ZSTD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3CompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3CompressionType FindValue(string value)
        {
            return FindValue<S3CompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3CompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3StorageClass.
    /// </summary>
    public class S3StorageClass : ConstantClass
    {

        /// <summary>
        /// Constant GLACIER_IR for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass GLACIER_IR = new S3StorageClass("GLACIER_IR");
        /// <summary>
        /// Constant INTELLIGENT_TIERING for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass INTELLIGENT_TIERING = new S3StorageClass("INTELLIGENT_TIERING");
        /// <summary>
        /// Constant STANDARD for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass STANDARD = new S3StorageClass("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3StorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3StorageClass FindValue(string value)
        {
            return FindValue<S3StorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3StorageClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3TablesCompressionType.
    /// </summary>
    public class S3TablesCompressionType : ConstantClass
    {

        /// <summary>
        /// Constant NONE for S3TablesCompressionType
        /// </summary>
        public static readonly S3TablesCompressionType NONE = new S3TablesCompressionType("NONE");
        /// <summary>
        /// Constant SNAPPY for S3TablesCompressionType
        /// </summary>
        public static readonly S3TablesCompressionType SNAPPY = new S3TablesCompressionType("SNAPPY");
        /// <summary>
        /// Constant ZSTD for S3TablesCompressionType
        /// </summary>
        public static readonly S3TablesCompressionType ZSTD = new S3TablesCompressionType("ZSTD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3TablesCompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3TablesCompressionType FindValue(string value)
        {
            return FindValue<S3TablesCompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3TablesCompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingType.
    /// </summary>
    public class ScalingType : ConstantClass
    {

        /// <summary>
        /// Constant UNIFORM_SCALING for ScalingType
        /// </summary>
        public static readonly ScalingType UNIFORM_SCALING = new ScalingType("UNIFORM_SCALING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingType FindValue(string value)
        {
            return FindValue<ScalingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShardFilterType.
    /// </summary>
    public class ShardFilterType : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_SHARD_ID for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType AFTER_SHARD_ID = new ShardFilterType("AFTER_SHARD_ID");
        /// <summary>
        /// Constant AT_LATEST for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType AT_LATEST = new ShardFilterType("AT_LATEST");
        /// <summary>
        /// Constant AT_TIMESTAMP for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType AT_TIMESTAMP = new ShardFilterType("AT_TIMESTAMP");
        /// <summary>
        /// Constant AT_TRIM_HORIZON for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType AT_TRIM_HORIZON = new ShardFilterType("AT_TRIM_HORIZON");
        /// <summary>
        /// Constant FROM_TIMESTAMP for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType FROM_TIMESTAMP = new ShardFilterType("FROM_TIMESTAMP");
        /// <summary>
        /// Constant FROM_TRIM_HORIZON for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType FROM_TRIM_HORIZON = new ShardFilterType("FROM_TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShardFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShardFilterType FindValue(string value)
        {
            return FindValue<ShardFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShardFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShardIteratorType.
    /// </summary>
    public class ShardIteratorType : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_SEQUENCE_NUMBER for ShardIteratorType
        /// </summary>
        public static readonly ShardIteratorType AFTER_SEQUENCE_NUMBER = new ShardIteratorType("AFTER_SEQUENCE_NUMBER");
        /// <summary>
        /// Constant AT_SEQUENCE_NUMBER for ShardIteratorType
        /// </summary>
        public static readonly ShardIteratorType AT_SEQUENCE_NUMBER = new ShardIteratorType("AT_SEQUENCE_NUMBER");
        /// <summary>
        /// Constant AT_TIMESTAMP for ShardIteratorType
        /// </summary>
        public static readonly ShardIteratorType AT_TIMESTAMP = new ShardIteratorType("AT_TIMESTAMP");
        /// <summary>
        /// Constant LATEST for ShardIteratorType
        /// </summary>
        public static readonly ShardIteratorType LATEST = new ShardIteratorType("LATEST");
        /// <summary>
        /// Constant TRIM_HORIZON for ShardIteratorType
        /// </summary>
        public static readonly ShardIteratorType TRIM_HORIZON = new ShardIteratorType("TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShardIteratorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShardIteratorType FindValue(string value)
        {
            return FindValue<ShardIteratorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShardIteratorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamMode.
    /// </summary>
    public class StreamMode : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for StreamMode
        /// </summary>
        public static readonly StreamMode ON_DEMAND = new StreamMode("ON_DEMAND");
        /// <summary>
        /// Constant PROVISIONED for StreamMode
        /// </summary>
        public static readonly StreamMode PROVISIONED = new StreamMode("PROVISIONED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamMode FindValue(string value)
        {
            return FindValue<StreamMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamStatus.
    /// </summary>
    public class StreamStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for StreamStatus
        /// </summary>
        public static readonly StreamStatus ACTIVE = new StreamStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for StreamStatus
        /// </summary>
        public static readonly StreamStatus CREATING = new StreamStatus("CREATING");
        /// <summary>
        /// Constant DELETING for StreamStatus
        /// </summary>
        public static readonly StreamStatus DELETING = new StreamStatus("DELETING");
        /// <summary>
        /// Constant UPDATING for StreamStatus
        /// </summary>
        public static readonly StreamStatus UPDATING = new StreamStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamStatus FindValue(string value)
        {
            return FindValue<StreamStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamStatus(string value)
        {
            return FindValue(value);
        }
    }

}