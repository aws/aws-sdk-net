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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.KinesisFirehose
{

    /// <summary>
    /// Constants used for properties of type AmazonOpenSearchServerlessS3BackupMode.
    /// </summary>
    public class AmazonOpenSearchServerlessS3BackupMode : ConstantClass
    {

        /// <summary>
        /// Constant AllDocuments for AmazonOpenSearchServerlessS3BackupMode
        /// </summary>
        public static readonly AmazonOpenSearchServerlessS3BackupMode AllDocuments = new AmazonOpenSearchServerlessS3BackupMode("AllDocuments");
        /// <summary>
        /// Constant FailedDocumentsOnly for AmazonOpenSearchServerlessS3BackupMode
        /// </summary>
        public static readonly AmazonOpenSearchServerlessS3BackupMode FailedDocumentsOnly = new AmazonOpenSearchServerlessS3BackupMode("FailedDocumentsOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AmazonOpenSearchServerlessS3BackupMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AmazonOpenSearchServerlessS3BackupMode FindValue(string value)
        {
            return FindValue<AmazonOpenSearchServerlessS3BackupMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AmazonOpenSearchServerlessS3BackupMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AmazonopensearchserviceIndexRotationPeriod.
    /// </summary>
    public class AmazonopensearchserviceIndexRotationPeriod : ConstantClass
    {

        /// <summary>
        /// Constant NoRotation for AmazonopensearchserviceIndexRotationPeriod
        /// </summary>
        public static readonly AmazonopensearchserviceIndexRotationPeriod NoRotation = new AmazonopensearchserviceIndexRotationPeriod("NoRotation");
        /// <summary>
        /// Constant OneDay for AmazonopensearchserviceIndexRotationPeriod
        /// </summary>
        public static readonly AmazonopensearchserviceIndexRotationPeriod OneDay = new AmazonopensearchserviceIndexRotationPeriod("OneDay");
        /// <summary>
        /// Constant OneHour for AmazonopensearchserviceIndexRotationPeriod
        /// </summary>
        public static readonly AmazonopensearchserviceIndexRotationPeriod OneHour = new AmazonopensearchserviceIndexRotationPeriod("OneHour");
        /// <summary>
        /// Constant OneMonth for AmazonopensearchserviceIndexRotationPeriod
        /// </summary>
        public static readonly AmazonopensearchserviceIndexRotationPeriod OneMonth = new AmazonopensearchserviceIndexRotationPeriod("OneMonth");
        /// <summary>
        /// Constant OneWeek for AmazonopensearchserviceIndexRotationPeriod
        /// </summary>
        public static readonly AmazonopensearchserviceIndexRotationPeriod OneWeek = new AmazonopensearchserviceIndexRotationPeriod("OneWeek");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AmazonopensearchserviceIndexRotationPeriod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AmazonopensearchserviceIndexRotationPeriod FindValue(string value)
        {
            return FindValue<AmazonopensearchserviceIndexRotationPeriod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AmazonopensearchserviceIndexRotationPeriod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AmazonopensearchserviceS3BackupMode.
    /// </summary>
    public class AmazonopensearchserviceS3BackupMode : ConstantClass
    {

        /// <summary>
        /// Constant AllDocuments for AmazonopensearchserviceS3BackupMode
        /// </summary>
        public static readonly AmazonopensearchserviceS3BackupMode AllDocuments = new AmazonopensearchserviceS3BackupMode("AllDocuments");
        /// <summary>
        /// Constant FailedDocumentsOnly for AmazonopensearchserviceS3BackupMode
        /// </summary>
        public static readonly AmazonopensearchserviceS3BackupMode FailedDocumentsOnly = new AmazonopensearchserviceS3BackupMode("FailedDocumentsOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AmazonopensearchserviceS3BackupMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AmazonopensearchserviceS3BackupMode FindValue(string value)
        {
            return FindValue<AmazonopensearchserviceS3BackupMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AmazonopensearchserviceS3BackupMode(string value)
        {
            return FindValue(value);
        }
    }


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
        /// Constant HADOOP_SNAPPY for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat HADOOP_SNAPPY = new CompressionFormat("HADOOP_SNAPPY");
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
    /// Constants used for properties of type Connectivity.
    /// </summary>
    public class Connectivity : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for Connectivity
        /// </summary>
        public static readonly Connectivity PRIVATE = new Connectivity("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for Connectivity
        /// </summary>
        public static readonly Connectivity PUBLIC = new Connectivity("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Connectivity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Connectivity FindValue(string value)
        {
            return FindValue<Connectivity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Connectivity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentEncoding.
    /// </summary>
    public class ContentEncoding : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for ContentEncoding
        /// </summary>
        public static readonly ContentEncoding GZIP = new ContentEncoding("GZIP");
        /// <summary>
        /// Constant NONE for ContentEncoding
        /// </summary>
        public static readonly ContentEncoding NONE = new ContentEncoding("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentEncoding FindValue(string value)
        {
            return FindValue<ContentEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatabaseType.
    /// </summary>
    public class DatabaseType : ConstantClass
    {

        /// <summary>
        /// Constant MySQL for DatabaseType
        /// </summary>
        public static readonly DatabaseType MySQL = new DatabaseType("MySQL");
        /// <summary>
        /// Constant PostgreSQL for DatabaseType
        /// </summary>
        public static readonly DatabaseType PostgreSQL = new DatabaseType("PostgreSQL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatabaseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatabaseType FindValue(string value)
        {
            return FindValue<DatabaseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatabaseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DefaultDocumentIdFormat.
    /// </summary>
    public class DefaultDocumentIdFormat : ConstantClass
    {

        /// <summary>
        /// Constant FIREHOSE_DEFAULT for DefaultDocumentIdFormat
        /// </summary>
        public static readonly DefaultDocumentIdFormat FIREHOSE_DEFAULT = new DefaultDocumentIdFormat("FIREHOSE_DEFAULT");
        /// <summary>
        /// Constant NO_DOCUMENT_ID for DefaultDocumentIdFormat
        /// </summary>
        public static readonly DefaultDocumentIdFormat NO_DOCUMENT_ID = new DefaultDocumentIdFormat("NO_DOCUMENT_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultDocumentIdFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultDocumentIdFormat FindValue(string value)
        {
            return FindValue<DefaultDocumentIdFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultDocumentIdFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliveryStreamEncryptionStatus.
    /// </summary>
    public class DeliveryStreamEncryptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DeliveryStreamEncryptionStatus
        /// </summary>
        public static readonly DeliveryStreamEncryptionStatus DISABLED = new DeliveryStreamEncryptionStatus("DISABLED");
        /// <summary>
        /// Constant DISABLING for DeliveryStreamEncryptionStatus
        /// </summary>
        public static readonly DeliveryStreamEncryptionStatus DISABLING = new DeliveryStreamEncryptionStatus("DISABLING");
        /// <summary>
        /// Constant DISABLING_FAILED for DeliveryStreamEncryptionStatus
        /// </summary>
        public static readonly DeliveryStreamEncryptionStatus DISABLING_FAILED = new DeliveryStreamEncryptionStatus("DISABLING_FAILED");
        /// <summary>
        /// Constant ENABLED for DeliveryStreamEncryptionStatus
        /// </summary>
        public static readonly DeliveryStreamEncryptionStatus ENABLED = new DeliveryStreamEncryptionStatus("ENABLED");
        /// <summary>
        /// Constant ENABLING for DeliveryStreamEncryptionStatus
        /// </summary>
        public static readonly DeliveryStreamEncryptionStatus ENABLING = new DeliveryStreamEncryptionStatus("ENABLING");
        /// <summary>
        /// Constant ENABLING_FAILED for DeliveryStreamEncryptionStatus
        /// </summary>
        public static readonly DeliveryStreamEncryptionStatus ENABLING_FAILED = new DeliveryStreamEncryptionStatus("ENABLING_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliveryStreamEncryptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryStreamEncryptionStatus FindValue(string value)
        {
            return FindValue<DeliveryStreamEncryptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryStreamEncryptionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliveryStreamFailureType.
    /// </summary>
    public class DeliveryStreamFailureType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_ENI_FAILED for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType CREATE_ENI_FAILED = new DeliveryStreamFailureType("CREATE_ENI_FAILED");
        /// <summary>
        /// Constant CREATE_KMS_GRANT_FAILED for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType CREATE_KMS_GRANT_FAILED = new DeliveryStreamFailureType("CREATE_KMS_GRANT_FAILED");
        /// <summary>
        /// Constant DELETE_ENI_FAILED for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType DELETE_ENI_FAILED = new DeliveryStreamFailureType("DELETE_ENI_FAILED");
        /// <summary>
        /// Constant DISABLED_KMS_KEY for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType DISABLED_KMS_KEY = new DeliveryStreamFailureType("DISABLED_KMS_KEY");
        /// <summary>
        /// Constant ENI_ACCESS_DENIED for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType ENI_ACCESS_DENIED = new DeliveryStreamFailureType("ENI_ACCESS_DENIED");
        /// <summary>
        /// Constant INVALID_KMS_KEY for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType INVALID_KMS_KEY = new DeliveryStreamFailureType("INVALID_KMS_KEY");
        /// <summary>
        /// Constant KMS_ACCESS_DENIED for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType KMS_ACCESS_DENIED = new DeliveryStreamFailureType("KMS_ACCESS_DENIED");
        /// <summary>
        /// Constant KMS_KEY_NOT_FOUND for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType KMS_KEY_NOT_FOUND = new DeliveryStreamFailureType("KMS_KEY_NOT_FOUND");
        /// <summary>
        /// Constant KMS_OPT_IN_REQUIRED for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType KMS_OPT_IN_REQUIRED = new DeliveryStreamFailureType("KMS_OPT_IN_REQUIRED");
        /// <summary>
        /// Constant RETIRE_KMS_GRANT_FAILED for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType RETIRE_KMS_GRANT_FAILED = new DeliveryStreamFailureType("RETIRE_KMS_GRANT_FAILED");
        /// <summary>
        /// Constant SECURITY_GROUP_ACCESS_DENIED for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType SECURITY_GROUP_ACCESS_DENIED = new DeliveryStreamFailureType("SECURITY_GROUP_ACCESS_DENIED");
        /// <summary>
        /// Constant SECURITY_GROUP_NOT_FOUND for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType SECURITY_GROUP_NOT_FOUND = new DeliveryStreamFailureType("SECURITY_GROUP_NOT_FOUND");
        /// <summary>
        /// Constant SUBNET_ACCESS_DENIED for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType SUBNET_ACCESS_DENIED = new DeliveryStreamFailureType("SUBNET_ACCESS_DENIED");
        /// <summary>
        /// Constant SUBNET_NOT_FOUND for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType SUBNET_NOT_FOUND = new DeliveryStreamFailureType("SUBNET_NOT_FOUND");
        /// <summary>
        /// Constant UNKNOWN_ERROR for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType UNKNOWN_ERROR = new DeliveryStreamFailureType("UNKNOWN_ERROR");
        /// <summary>
        /// Constant VPC_ENDPOINT_SERVICE_NAME_NOT_FOUND for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType VPC_ENDPOINT_SERVICE_NAME_NOT_FOUND = new DeliveryStreamFailureType("VPC_ENDPOINT_SERVICE_NAME_NOT_FOUND");
        /// <summary>
        /// Constant VPC_INTERFACE_ENDPOINT_SERVICE_ACCESS_DENIED for DeliveryStreamFailureType
        /// </summary>
        public static readonly DeliveryStreamFailureType VPC_INTERFACE_ENDPOINT_SERVICE_ACCESS_DENIED = new DeliveryStreamFailureType("VPC_INTERFACE_ENDPOINT_SERVICE_ACCESS_DENIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliveryStreamFailureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryStreamFailureType FindValue(string value)
        {
            return FindValue<DeliveryStreamFailureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryStreamFailureType(string value)
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
        /// Constant CREATING_FAILED for DeliveryStreamStatus
        /// </summary>
        public static readonly DeliveryStreamStatus CREATING_FAILED = new DeliveryStreamStatus("CREATING_FAILED");
        /// <summary>
        /// Constant DELETING for DeliveryStreamStatus
        /// </summary>
        public static readonly DeliveryStreamStatus DELETING = new DeliveryStreamStatus("DELETING");
        /// <summary>
        /// Constant DELETING_FAILED for DeliveryStreamStatus
        /// </summary>
        public static readonly DeliveryStreamStatus DELETING_FAILED = new DeliveryStreamStatus("DELETING_FAILED");

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
        /// Constant DatabaseAsSource for DeliveryStreamType
        /// </summary>
        public static readonly DeliveryStreamType DatabaseAsSource = new DeliveryStreamType("DatabaseAsSource");
        /// <summary>
        /// Constant DirectPut for DeliveryStreamType
        /// </summary>
        public static readonly DeliveryStreamType DirectPut = new DeliveryStreamType("DirectPut");
        /// <summary>
        /// Constant KinesisStreamAsSource for DeliveryStreamType
        /// </summary>
        public static readonly DeliveryStreamType KinesisStreamAsSource = new DeliveryStreamType("KinesisStreamAsSource");
        /// <summary>
        /// Constant MSKAsSource for DeliveryStreamType
        /// </summary>
        public static readonly DeliveryStreamType MSKAsSource = new DeliveryStreamType("MSKAsSource");

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
    /// Constants used for properties of type HttpEndpointS3BackupMode.
    /// </summary>
    public class HttpEndpointS3BackupMode : ConstantClass
    {

        /// <summary>
        /// Constant AllData for HttpEndpointS3BackupMode
        /// </summary>
        public static readonly HttpEndpointS3BackupMode AllData = new HttpEndpointS3BackupMode("AllData");
        /// <summary>
        /// Constant FailedDataOnly for HttpEndpointS3BackupMode
        /// </summary>
        public static readonly HttpEndpointS3BackupMode FailedDataOnly = new HttpEndpointS3BackupMode("FailedDataOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HttpEndpointS3BackupMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HttpEndpointS3BackupMode FindValue(string value)
        {
            return FindValue<HttpEndpointS3BackupMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HttpEndpointS3BackupMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IcebergS3BackupMode.
    /// </summary>
    public class IcebergS3BackupMode : ConstantClass
    {

        /// <summary>
        /// Constant AllData for IcebergS3BackupMode
        /// </summary>
        public static readonly IcebergS3BackupMode AllData = new IcebergS3BackupMode("AllData");
        /// <summary>
        /// Constant FailedDataOnly for IcebergS3BackupMode
        /// </summary>
        public static readonly IcebergS3BackupMode FailedDataOnly = new IcebergS3BackupMode("FailedDataOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IcebergS3BackupMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IcebergS3BackupMode FindValue(string value)
        {
            return FindValue<IcebergS3BackupMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IcebergS3BackupMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyType.
    /// </summary>
    public class KeyType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED_CMK for KeyType
        /// </summary>
        public static readonly KeyType AWS_OWNED_CMK = new KeyType("AWS_OWNED_CMK");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_CMK for KeyType
        /// </summary>
        public static readonly KeyType CUSTOMER_MANAGED_CMK = new KeyType("CUSTOMER_MANAGED_CMK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyType FindValue(string value)
        {
            return FindValue<KeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyType(string value)
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
        /// Constant CompressionFormat for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName CompressionFormat = new ProcessorParameterName("CompressionFormat");
        /// <summary>
        /// Constant DataMessageExtraction for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName DataMessageExtraction = new ProcessorParameterName("DataMessageExtraction");
        /// <summary>
        /// Constant Delimiter for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName Delimiter = new ProcessorParameterName("Delimiter");
        /// <summary>
        /// Constant JsonParsingEngine for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName JsonParsingEngine = new ProcessorParameterName("JsonParsingEngine");
        /// <summary>
        /// Constant LambdaArn for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName LambdaArn = new ProcessorParameterName("LambdaArn");
        /// <summary>
        /// Constant MetadataExtractionQuery for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName MetadataExtractionQuery = new ProcessorParameterName("MetadataExtractionQuery");
        /// <summary>
        /// Constant NumberOfRetries for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName NumberOfRetries = new ProcessorParameterName("NumberOfRetries");
        /// <summary>
        /// Constant RoleArn for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName RoleArn = new ProcessorParameterName("RoleArn");
        /// <summary>
        /// Constant SubRecordType for ProcessorParameterName
        /// </summary>
        public static readonly ProcessorParameterName SubRecordType = new ProcessorParameterName("SubRecordType");

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
        /// Constant AppendDelimiterToRecord for ProcessorType
        /// </summary>
        public static readonly ProcessorType AppendDelimiterToRecord = new ProcessorType("AppendDelimiterToRecord");
        /// <summary>
        /// Constant CloudWatchLogProcessing for ProcessorType
        /// </summary>
        public static readonly ProcessorType CloudWatchLogProcessing = new ProcessorType("CloudWatchLogProcessing");
        /// <summary>
        /// Constant Decompression for ProcessorType
        /// </summary>
        public static readonly ProcessorType Decompression = new ProcessorType("Decompression");
        /// <summary>
        /// Constant Lambda for ProcessorType
        /// </summary>
        public static readonly ProcessorType Lambda = new ProcessorType("Lambda");
        /// <summary>
        /// Constant MetadataExtraction for ProcessorType
        /// </summary>
        public static readonly ProcessorType MetadataExtraction = new ProcessorType("MetadataExtraction");
        /// <summary>
        /// Constant RecordDeAggregation for ProcessorType
        /// </summary>
        public static readonly ProcessorType RecordDeAggregation = new ProcessorType("RecordDeAggregation");

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
    /// Constants used for properties of type SnapshotRequestedBy.
    /// </summary>
    public class SnapshotRequestedBy : ConstantClass
    {

        /// <summary>
        /// Constant FIREHOSE for SnapshotRequestedBy
        /// </summary>
        public static readonly SnapshotRequestedBy FIREHOSE = new SnapshotRequestedBy("FIREHOSE");
        /// <summary>
        /// Constant USER for SnapshotRequestedBy
        /// </summary>
        public static readonly SnapshotRequestedBy USER = new SnapshotRequestedBy("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotRequestedBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotRequestedBy FindValue(string value)
        {
            return FindValue<SnapshotRequestedBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotRequestedBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotStatus.
    /// </summary>
    public class SnapshotStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus COMPLETE = new SnapshotStatus("COMPLETE");
        /// <summary>
        /// Constant IN_PROGRESS for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus IN_PROGRESS = new SnapshotStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUSPENDED for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus SUSPENDED = new SnapshotStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotStatus FindValue(string value)
        {
            return FindValue<SnapshotStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnowflakeDataLoadingOption.
    /// </summary>
    public class SnowflakeDataLoadingOption : ConstantClass
    {

        /// <summary>
        /// Constant JSON_MAPPING for SnowflakeDataLoadingOption
        /// </summary>
        public static readonly SnowflakeDataLoadingOption JSON_MAPPING = new SnowflakeDataLoadingOption("JSON_MAPPING");
        /// <summary>
        /// Constant VARIANT_CONTENT_AND_METADATA_MAPPING for SnowflakeDataLoadingOption
        /// </summary>
        public static readonly SnowflakeDataLoadingOption VARIANT_CONTENT_AND_METADATA_MAPPING = new SnowflakeDataLoadingOption("VARIANT_CONTENT_AND_METADATA_MAPPING");
        /// <summary>
        /// Constant VARIANT_CONTENT_MAPPING for SnowflakeDataLoadingOption
        /// </summary>
        public static readonly SnowflakeDataLoadingOption VARIANT_CONTENT_MAPPING = new SnowflakeDataLoadingOption("VARIANT_CONTENT_MAPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnowflakeDataLoadingOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnowflakeDataLoadingOption FindValue(string value)
        {
            return FindValue<SnowflakeDataLoadingOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnowflakeDataLoadingOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnowflakeS3BackupMode.
    /// </summary>
    public class SnowflakeS3BackupMode : ConstantClass
    {

        /// <summary>
        /// Constant AllData for SnowflakeS3BackupMode
        /// </summary>
        public static readonly SnowflakeS3BackupMode AllData = new SnowflakeS3BackupMode("AllData");
        /// <summary>
        /// Constant FailedDataOnly for SnowflakeS3BackupMode
        /// </summary>
        public static readonly SnowflakeS3BackupMode FailedDataOnly = new SnowflakeS3BackupMode("FailedDataOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnowflakeS3BackupMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnowflakeS3BackupMode FindValue(string value)
        {
            return FindValue<SnowflakeS3BackupMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnowflakeS3BackupMode(string value)
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


    /// <summary>
    /// Constants used for properties of type SSLMode.
    /// </summary>
    public class SSLMode : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for SSLMode
        /// </summary>
        public static readonly SSLMode Disabled = new SSLMode("Disabled");
        /// <summary>
        /// Constant Enabled for SSLMode
        /// </summary>
        public static readonly SSLMode Enabled = new SSLMode("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SSLMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SSLMode FindValue(string value)
        {
            return FindValue<SSLMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SSLMode(string value)
        {
            return FindValue(value);
        }
    }

}