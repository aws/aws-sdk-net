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

}