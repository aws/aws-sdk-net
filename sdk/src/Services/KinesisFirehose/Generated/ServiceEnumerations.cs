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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.KinesisFirehose
{

    /// <summary>
    /// Constants used for properties of type CompressionFormat.
    /// </summary>
    public class CompressionFormat : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat GZIP = new CompressionFormat("GZIP");
        /// <summary>
        /// Constant Snappy for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat Snappy = new CompressionFormat("Snappy");
        /// <summary>
        /// Constant UNCOMPRESSED for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat UNCOMPRESSED = new CompressionFormat("UNCOMPRESSED");
        /// <summary>
        /// Constant ZIP for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat ZIP = new CompressionFormat("ZIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompressionFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompressionFormat FindValue(string value)
        {
            return FindValue<CompressionFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompressionFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliveryStreamStatus.
    /// </summary>
    public class DeliveryStreamStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DeliveryStreamStatus
        /// </summary>
        public static readonly DeliveryStreamStatus ACTIVE = new DeliveryStreamStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for DeliveryStreamStatus
        /// </summary>
        public static readonly DeliveryStreamStatus CREATING = new DeliveryStreamStatus("CREATING");
        /// <summary>
        /// Constant DELETING for DeliveryStreamStatus
        /// </summary>
        public static readonly DeliveryStreamStatus DELETING = new DeliveryStreamStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliveryStreamStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryStreamStatus FindValue(string value)
        {
            return FindValue<DeliveryStreamStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryStreamStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliveryStreamType.
    /// </summary>
    public class DeliveryStreamType : ConstantClass
    {

        /// <summary>
        /// Constant DirectPut for DeliveryStreamType
        /// </summary>
        public static readonly DeliveryStreamType DirectPut = new DeliveryStreamType("DirectPut");
        /// <summary>
        /// Constant KinesisStreamAsSource for DeliveryStreamType
        /// </summary>
        public static readonly DeliveryStreamType KinesisStreamAsSource = new DeliveryStreamType("KinesisStreamAsSource");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliveryStreamType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryStreamType FindValue(string value)
        {
            return FindValue<DeliveryStreamType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryStreamType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ElasticsearchIndexRotationPeriod.
    /// </summary>
    public class ElasticsearchIndexRotationPeriod : ConstantClass
    {

        /// <summary>
        /// Constant NoRotation for ElasticsearchIndexRotationPeriod
        /// </summary>
        public static readonly ElasticsearchIndexRotationPeriod NoRotation = new ElasticsearchIndexRotationPeriod("NoRotation");
        /// <summary>
        /// Constant OneDay for ElasticsearchIndexRotationPeriod
        /// </summary>
        public static readonly ElasticsearchIndexRotationPeriod OneDay = new ElasticsearchIndexRotationPeriod("OneDay");
        /// <summary>
        /// Constant OneHour for ElasticsearchIndexRotationPeriod
        /// </summary>
        public static readonly ElasticsearchIndexRotationPeriod OneHour = new ElasticsearchIndexRotationPeriod("OneHour");
        /// <summary>
        /// Constant OneMonth for ElasticsearchIndexRotationPeriod
        /// </summary>
        public static readonly ElasticsearchIndexRotationPeriod OneMonth = new ElasticsearchIndexRotationPeriod("OneMonth");
        /// <summary>
        /// Constant OneWeek for ElasticsearchIndexRotationPeriod
        /// </summary>
        public static readonly ElasticsearchIndexRotationPeriod OneWeek = new ElasticsearchIndexRotationPeriod("OneWeek");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ElasticsearchIndexRotationPeriod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ElasticsearchIndexRotationPeriod FindValue(string value)
        {
            return FindValue<ElasticsearchIndexRotationPeriod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ElasticsearchIndexRotationPeriod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ElasticsearchS3BackupMode.
    /// </summary>
    public class ElasticsearchS3BackupMode : ConstantClass
    {

        /// <summary>
        /// Constant AllDocuments for ElasticsearchS3BackupMode
        /// </summary>
        public static readonly ElasticsearchS3BackupMode AllDocuments = new ElasticsearchS3BackupMode("AllDocuments");
        /// <summary>
        /// Constant FailedDocumentsOnly for ElasticsearchS3BackupMode
        /// </summary>
        public static readonly ElasticsearchS3BackupMode FailedDocumentsOnly = new ElasticsearchS3BackupMode("FailedDocumentsOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ElasticsearchS3BackupMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ElasticsearchS3BackupMode FindValue(string value)
        {
            return FindValue<ElasticsearchS3BackupMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ElasticsearchS3BackupMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HECEndpointType.
    /// </summary>
    public class HECEndpointType : ConstantClass
    {

        /// <summary>
        /// Constant Event for HECEndpointType
        /// </summary>
        public static readonly HECEndpointType Event = new HECEndpointType("Event");
        /// <summary>
        /// Constant Raw for HECEndpointType
        /// </summary>
        public static readonly HECEndpointType Raw = new HECEndpointType("Raw");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HECEndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HECEndpointType FindValue(string value)
        {
            return FindValue<HECEndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HECEndpointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NoEncryptionConfig.
    /// </summary>
    public class NoEncryptionConfig : ConstantClass
    {

        /// <summary>
        /// Constant NoEncryption for NoEncryptionConfig
        /// </summary>
        public static readonly NoEncryptionConfig NoEncryption = new NoEncryptionConfig("NoEncryption");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NoEncryptionConfig(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NoEncryptionConfig FindValue(string value)
        {
            return FindValue<NoEncryptionConfig>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NoEncryptionConfig(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrcCompression.
    /// </summary>
    public class OrcCompression : ConstantClass
    {

        /// <summary>
        /// Constant NONE for OrcCompression
        /// </summary>
        public static readonly OrcCompression NONE = new OrcCompression("NONE");
        /// <summary>
        /// Constant SNAPPY for OrcCompression
        /// </summary>
        public static readonly OrcCompression SNAPPY = new OrcCompression("SNAPPY");
        /// <summary>
        /// Constant ZLIB for OrcCompression
        /// </summary>
        public static readonly OrcCompression ZLIB = new OrcCompression("ZLIB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrcCompression(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrcCompression FindValue(string value)
        {
            return FindValue<OrcCompression>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrcCompression(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrcFormatVersion.
    /// </summary>
    public class OrcFormatVersion : ConstantClass
    {

        /// <summary>
        /// Constant V0_11 for OrcFormatVersion
        /// </summary>
        public static readonly OrcFormatVersion V0_11 = new OrcFormatVersion("V0_11");
        /// <summary>
        /// Constant V0_12 for OrcFormatVersion
        /// </summary>
        public static readonly OrcFormatVersion V0_12 = new OrcFormatVersion("V0_12");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrcFormatVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrcFormatVersion FindValue(string value)
        {
            return FindValue<OrcFormatVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrcFormatVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParquetCompression.
    /// </summary>
    public class ParquetCompression : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for ParquetCompression
        /// </summary>
        public static readonly ParquetCompression GZIP = new ParquetCompression("GZIP");
        /// <summary>
        /// Constant SNAPPY for ParquetCompression
        /// </summary>
        public static readonly ParquetCompression SNAPPY = new ParquetCompression("SNAPPY");
        /// <summary>
        /// Constant UNCOMPRESSED for ParquetCompression
        /// </summary>
        public static readonly ParquetCompression UNCOMPRESSED = new ParquetCompression("UNCOMPRESSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParquetCompression(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParquetCompression FindValue(string value)
        {
            return FindValue<ParquetCompression>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParquetCompression(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParquetWriterVersion.
    /// </summary>
    public class ParquetWriterVersion : ConstantClass
    {

        /// <summary>
        /// Constant V1 for ParquetWriterVersion
        /// </summary>
        public static readonly ParquetWriterVersion V1 = new ParquetWriterVersion("V1");
        /// <summary>
        /// Constant V2 for ParquetWriterVersion
        /// </summary>
        public static readonly ParquetWriterVersion V2 = new ParquetWriterVersion("V2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParquetWriterVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParquetWriterVersion FindValue(string value)
        {
            return FindValue<ParquetWriterVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParquetWriterVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcessorParameterName.
    /// </summary>
    public class ProcessorParameterName : ConstantClass
    {

        /// <summary>
        /// Constant BufferIntervalInSeconds for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName BufferIntervalInSeconds = new ProcessorParameterName("BufferIntervalInSeconds");
        /// <summary>
        /// Constant BufferSizeInMBs for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName BufferSizeInMBs = new ProcessorParameterName("BufferSizeInMBs");
        /// <summary>
        /// Constant LambdaArn for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName LambdaArn = new ProcessorParameterName("LambdaArn");
        /// <summary>
        /// Constant NumberOfRetries for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName NumberOfRetries = new ProcessorParameterName("NumberOfRetries");
        /// <summary>
        /// Constant RoleArn for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName RoleArn = new ProcessorParameterName("RoleArn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessorParameterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessorParameterName FindValue(string value)
        {
            return FindValue<ProcessorParameterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessorParameterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProcessorType.
    /// </summary>
    public class ProcessorType : ConstantClass
    {

        /// <summary>
        /// Constant Lambda for ProcessorType
        /// </summary>
        public static readonly ProcessorType Lambda = new ProcessorType("Lambda");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProcessorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProcessorType FindValue(string value)
        {
            return FindValue<ProcessorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProcessorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RedshiftS3BackupMode.
    /// </summary>
    public class RedshiftS3BackupMode : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for RedshiftS3BackupMode
        /// </summary>
        public static readonly RedshiftS3BackupMode Disabled = new RedshiftS3BackupMode("Disabled");
        /// <summary>
        /// Constant Enabled for RedshiftS3BackupMode
        /// </summary>
        public static readonly RedshiftS3BackupMode Enabled = new RedshiftS3BackupMode("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RedshiftS3BackupMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RedshiftS3BackupMode FindValue(string value)
        {
            return FindValue<RedshiftS3BackupMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RedshiftS3BackupMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3BackupMode.
    /// </summary>
    public class S3BackupMode : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for S3BackupMode
        /// </summary>
        public static readonly S3BackupMode Disabled = new S3BackupMode("Disabled");
        /// <summary>
        /// Constant Enabled for S3BackupMode
        /// </summary>
        public static readonly S3BackupMode Enabled = new S3BackupMode("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3BackupMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3BackupMode FindValue(string value)
        {
            return FindValue<S3BackupMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3BackupMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SplunkS3BackupMode.
    /// </summary>
    public class SplunkS3BackupMode : ConstantClass
    {

        /// <summary>
        /// Constant AllEvents for SplunkS3BackupMode
        /// </summary>
        public static readonly SplunkS3BackupMode AllEvents = new SplunkS3BackupMode("AllEvents");
        /// <summary>
        /// Constant FailedEventsOnly for SplunkS3BackupMode
        /// </summary>
        public static readonly SplunkS3BackupMode FailedEventsOnly = new SplunkS3BackupMode("FailedEventsOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SplunkS3BackupMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SplunkS3BackupMode FindValue(string value)
        {
            return FindValue<SplunkS3BackupMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SplunkS3BackupMode(string value)
        {
            return FindValue(value);
        }
    }

}