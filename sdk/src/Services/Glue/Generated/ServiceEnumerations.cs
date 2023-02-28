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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Glue
{

    /// <summary>
    /// Constants used for properties of type AggFunction.
    /// </summary>
    public class AggFunction : ConstantClass
    {

        /// <summary>
        /// Constant Avg for AggFunction
        /// </summary>
        public static readonly AggFunction Avg = new AggFunction("avg");
        /// <summary>
        /// Constant Count for AggFunction
        /// </summary>
        public static readonly AggFunction Count = new AggFunction("count");
        /// <summary>
        /// Constant CountDistinct for AggFunction
        /// </summary>
        public static readonly AggFunction CountDistinct = new AggFunction("countDistinct");
        /// <summary>
        /// Constant First for AggFunction
        /// </summary>
        public static readonly AggFunction First = new AggFunction("first");
        /// <summary>
        /// Constant Kurtosis for AggFunction
        /// </summary>
        public static readonly AggFunction Kurtosis = new AggFunction("kurtosis");
        /// <summary>
        /// Constant Last for AggFunction
        /// </summary>
        public static readonly AggFunction Last = new AggFunction("last");
        /// <summary>
        /// Constant Max for AggFunction
        /// </summary>
        public static readonly AggFunction Max = new AggFunction("max");
        /// <summary>
        /// Constant Min for AggFunction
        /// </summary>
        public static readonly AggFunction Min = new AggFunction("min");
        /// <summary>
        /// Constant Skewness for AggFunction
        /// </summary>
        public static readonly AggFunction Skewness = new AggFunction("skewness");
        /// <summary>
        /// Constant Stddev_pop for AggFunction
        /// </summary>
        public static readonly AggFunction Stddev_pop = new AggFunction("stddev_pop");
        /// <summary>
        /// Constant Stddev_samp for AggFunction
        /// </summary>
        public static readonly AggFunction Stddev_samp = new AggFunction("stddev_samp");
        /// <summary>
        /// Constant Sum for AggFunction
        /// </summary>
        public static readonly AggFunction Sum = new AggFunction("sum");
        /// <summary>
        /// Constant SumDistinct for AggFunction
        /// </summary>
        public static readonly AggFunction SumDistinct = new AggFunction("sumDistinct");
        /// <summary>
        /// Constant Var_pop for AggFunction
        /// </summary>
        public static readonly AggFunction Var_pop = new AggFunction("var_pop");
        /// <summary>
        /// Constant Var_samp for AggFunction
        /// </summary>
        public static readonly AggFunction Var_samp = new AggFunction("var_samp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggFunction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggFunction FindValue(string value)
        {
            return FindValue<AggFunction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggFunction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BackfillErrorCode.
    /// </summary>
    public class BackfillErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ENCRYPTED_PARTITION_ERROR for BackfillErrorCode
        /// </summary>
        public static readonly BackfillErrorCode ENCRYPTED_PARTITION_ERROR = new BackfillErrorCode("ENCRYPTED_PARTITION_ERROR");
        /// <summary>
        /// Constant INTERNAL_ERROR for BackfillErrorCode
        /// </summary>
        public static readonly BackfillErrorCode INTERNAL_ERROR = new BackfillErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_PARTITION_TYPE_DATA_ERROR for BackfillErrorCode
        /// </summary>
        public static readonly BackfillErrorCode INVALID_PARTITION_TYPE_DATA_ERROR = new BackfillErrorCode("INVALID_PARTITION_TYPE_DATA_ERROR");
        /// <summary>
        /// Constant MISSING_PARTITION_VALUE_ERROR for BackfillErrorCode
        /// </summary>
        public static readonly BackfillErrorCode MISSING_PARTITION_VALUE_ERROR = new BackfillErrorCode("MISSING_PARTITION_VALUE_ERROR");
        /// <summary>
        /// Constant UNSUPPORTED_PARTITION_CHARACTER_ERROR for BackfillErrorCode
        /// </summary>
        public static readonly BackfillErrorCode UNSUPPORTED_PARTITION_CHARACTER_ERROR = new BackfillErrorCode("UNSUPPORTED_PARTITION_CHARACTER_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackfillErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackfillErrorCode FindValue(string value)
        {
            return FindValue<BackfillErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackfillErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BlueprintRunState.
    /// </summary>
    public class BlueprintRunState : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for BlueprintRunState
        /// </summary>
        public static readonly BlueprintRunState FAILED = new BlueprintRunState("FAILED");
        /// <summary>
        /// Constant ROLLING_BACK for BlueprintRunState
        /// </summary>
        public static readonly BlueprintRunState ROLLING_BACK = new BlueprintRunState("ROLLING_BACK");
        /// <summary>
        /// Constant RUNNING for BlueprintRunState
        /// </summary>
        public static readonly BlueprintRunState RUNNING = new BlueprintRunState("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for BlueprintRunState
        /// </summary>
        public static readonly BlueprintRunState SUCCEEDED = new BlueprintRunState("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlueprintRunState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlueprintRunState FindValue(string value)
        {
            return FindValue<BlueprintRunState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlueprintRunState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BlueprintStatus.
    /// </summary>
    public class BlueprintStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for BlueprintStatus
        /// </summary>
        public static readonly BlueprintStatus ACTIVE = new BlueprintStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for BlueprintStatus
        /// </summary>
        public static readonly BlueprintStatus CREATING = new BlueprintStatus("CREATING");
        /// <summary>
        /// Constant FAILED for BlueprintStatus
        /// </summary>
        public static readonly BlueprintStatus FAILED = new BlueprintStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for BlueprintStatus
        /// </summary>
        public static readonly BlueprintStatus UPDATING = new BlueprintStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlueprintStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlueprintStatus FindValue(string value)
        {
            return FindValue<BlueprintStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlueprintStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CatalogEncryptionMode.
    /// </summary>
    public class CatalogEncryptionMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CatalogEncryptionMode
        /// </summary>
        public static readonly CatalogEncryptionMode DISABLED = new CatalogEncryptionMode("DISABLED");
        /// <summary>
        /// Constant SSEKMS for CatalogEncryptionMode
        /// </summary>
        public static readonly CatalogEncryptionMode SSEKMS = new CatalogEncryptionMode("SSE-KMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CatalogEncryptionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CatalogEncryptionMode FindValue(string value)
        {
            return FindValue<CatalogEncryptionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CatalogEncryptionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloudWatchEncryptionMode.
    /// </summary>
    public class CloudWatchEncryptionMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CloudWatchEncryptionMode
        /// </summary>
        public static readonly CloudWatchEncryptionMode DISABLED = new CloudWatchEncryptionMode("DISABLED");
        /// <summary>
        /// Constant SSEKMS for CloudWatchEncryptionMode
        /// </summary>
        public static readonly CloudWatchEncryptionMode SSEKMS = new CloudWatchEncryptionMode("SSE-KMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudWatchEncryptionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudWatchEncryptionMode FindValue(string value)
        {
            return FindValue<CloudWatchEncryptionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudWatchEncryptionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ColumnStatisticsType.
    /// </summary>
    public class ColumnStatisticsType : ConstantClass
    {

        /// <summary>
        /// Constant BINARY for ColumnStatisticsType
        /// </summary>
        public static readonly ColumnStatisticsType BINARY = new ColumnStatisticsType("BINARY");
        /// <summary>
        /// Constant BOOLEAN for ColumnStatisticsType
        /// </summary>
        public static readonly ColumnStatisticsType BOOLEAN = new ColumnStatisticsType("BOOLEAN");
        /// <summary>
        /// Constant DATE for ColumnStatisticsType
        /// </summary>
        public static readonly ColumnStatisticsType DATE = new ColumnStatisticsType("DATE");
        /// <summary>
        /// Constant DECIMAL for ColumnStatisticsType
        /// </summary>
        public static readonly ColumnStatisticsType DECIMAL = new ColumnStatisticsType("DECIMAL");
        /// <summary>
        /// Constant DOUBLE for ColumnStatisticsType
        /// </summary>
        public static readonly ColumnStatisticsType DOUBLE = new ColumnStatisticsType("DOUBLE");
        /// <summary>
        /// Constant LONG for ColumnStatisticsType
        /// </summary>
        public static readonly ColumnStatisticsType LONG = new ColumnStatisticsType("LONG");
        /// <summary>
        /// Constant STRING for ColumnStatisticsType
        /// </summary>
        public static readonly ColumnStatisticsType STRING = new ColumnStatisticsType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColumnStatisticsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColumnStatisticsType FindValue(string value)
        {
            return FindValue<ColumnStatisticsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColumnStatisticsType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Comparator.
    /// </summary>
    public class Comparator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for Comparator
        /// </summary>
        public static readonly Comparator EQUALS = new Comparator("EQUALS");
        /// <summary>
        /// Constant GREATER_THAN for Comparator
        /// </summary>
        public static readonly Comparator GREATER_THAN = new Comparator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_EQUALS for Comparator
        /// </summary>
        public static readonly Comparator GREATER_THAN_EQUALS = new Comparator("GREATER_THAN_EQUALS");
        /// <summary>
        /// Constant LESS_THAN for Comparator
        /// </summary>
        public static readonly Comparator LESS_THAN = new Comparator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_EQUALS for Comparator
        /// </summary>
        public static readonly Comparator LESS_THAN_EQUALS = new Comparator("LESS_THAN_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Comparator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Comparator FindValue(string value)
        {
            return FindValue<Comparator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Comparator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Compatibility.
    /// </summary>
    public class Compatibility : ConstantClass
    {

        /// <summary>
        /// Constant BACKWARD for Compatibility
        /// </summary>
        public static readonly Compatibility BACKWARD = new Compatibility("BACKWARD");
        /// <summary>
        /// Constant BACKWARD_ALL for Compatibility
        /// </summary>
        public static readonly Compatibility BACKWARD_ALL = new Compatibility("BACKWARD_ALL");
        /// <summary>
        /// Constant DISABLED for Compatibility
        /// </summary>
        public static readonly Compatibility DISABLED = new Compatibility("DISABLED");
        /// <summary>
        /// Constant FORWARD for Compatibility
        /// </summary>
        public static readonly Compatibility FORWARD = new Compatibility("FORWARD");
        /// <summary>
        /// Constant FORWARD_ALL for Compatibility
        /// </summary>
        public static readonly Compatibility FORWARD_ALL = new Compatibility("FORWARD_ALL");
        /// <summary>
        /// Constant FULL for Compatibility
        /// </summary>
        public static readonly Compatibility FULL = new Compatibility("FULL");
        /// <summary>
        /// Constant FULL_ALL for Compatibility
        /// </summary>
        public static readonly Compatibility FULL_ALL = new Compatibility("FULL_ALL");
        /// <summary>
        /// Constant NONE for Compatibility
        /// </summary>
        public static readonly Compatibility NONE = new Compatibility("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Compatibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Compatibility FindValue(string value)
        {
            return FindValue<Compatibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Compatibility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompressionType.
    /// </summary>
    public class CompressionType : ConstantClass
    {

        /// <summary>
        /// Constant Bzip2 for CompressionType
        /// </summary>
        public static readonly CompressionType Bzip2 = new CompressionType("bzip2");
        /// <summary>
        /// Constant Gzip for CompressionType
        /// </summary>
        public static readonly CompressionType Gzip = new CompressionType("gzip");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompressionType FindValue(string value)
        {
            return FindValue<CompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionPropertyKey.
    /// </summary>
    public class ConnectionPropertyKey : ConstantClass
    {

        /// <summary>
        /// Constant CONFIG_FILES for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey CONFIG_FILES = new ConnectionPropertyKey("CONFIG_FILES");
        /// <summary>
        /// Constant CONNECTION_URL for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey CONNECTION_URL = new ConnectionPropertyKey("CONNECTION_URL");
        /// <summary>
        /// Constant CONNECTOR_CLASS_NAME for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey CONNECTOR_CLASS_NAME = new ConnectionPropertyKey("CONNECTOR_CLASS_NAME");
        /// <summary>
        /// Constant CONNECTOR_TYPE for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey CONNECTOR_TYPE = new ConnectionPropertyKey("CONNECTOR_TYPE");
        /// <summary>
        /// Constant CONNECTOR_URL for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey CONNECTOR_URL = new ConnectionPropertyKey("CONNECTOR_URL");
        /// <summary>
        /// Constant CUSTOM_JDBC_CERT for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey CUSTOM_JDBC_CERT = new ConnectionPropertyKey("CUSTOM_JDBC_CERT");
        /// <summary>
        /// Constant CUSTOM_JDBC_CERT_STRING for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey CUSTOM_JDBC_CERT_STRING = new ConnectionPropertyKey("CUSTOM_JDBC_CERT_STRING");
        /// <summary>
        /// Constant ENCRYPTED_KAFKA_CLIENT_KEY_PASSWORD for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey ENCRYPTED_KAFKA_CLIENT_KEY_PASSWORD = new ConnectionPropertyKey("ENCRYPTED_KAFKA_CLIENT_KEY_PASSWORD");
        /// <summary>
        /// Constant ENCRYPTED_KAFKA_CLIENT_KEYSTORE_PASSWORD for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey ENCRYPTED_KAFKA_CLIENT_KEYSTORE_PASSWORD = new ConnectionPropertyKey("ENCRYPTED_KAFKA_CLIENT_KEYSTORE_PASSWORD");
        /// <summary>
        /// Constant ENCRYPTED_PASSWORD for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey ENCRYPTED_PASSWORD = new ConnectionPropertyKey("ENCRYPTED_PASSWORD");
        /// <summary>
        /// Constant HOST for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey HOST = new ConnectionPropertyKey("HOST");
        /// <summary>
        /// Constant INSTANCE_ID for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey INSTANCE_ID = new ConnectionPropertyKey("INSTANCE_ID");
        /// <summary>
        /// Constant JDBC_CONNECTION_URL for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey JDBC_CONNECTION_URL = new ConnectionPropertyKey("JDBC_CONNECTION_URL");
        /// <summary>
        /// Constant JDBC_DRIVER_CLASS_NAME for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey JDBC_DRIVER_CLASS_NAME = new ConnectionPropertyKey("JDBC_DRIVER_CLASS_NAME");
        /// <summary>
        /// Constant JDBC_DRIVER_JAR_URI for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey JDBC_DRIVER_JAR_URI = new ConnectionPropertyKey("JDBC_DRIVER_JAR_URI");
        /// <summary>
        /// Constant JDBC_ENFORCE_SSL for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey JDBC_ENFORCE_SSL = new ConnectionPropertyKey("JDBC_ENFORCE_SSL");
        /// <summary>
        /// Constant JDBC_ENGINE for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey JDBC_ENGINE = new ConnectionPropertyKey("JDBC_ENGINE");
        /// <summary>
        /// Constant JDBC_ENGINE_VERSION for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey JDBC_ENGINE_VERSION = new ConnectionPropertyKey("JDBC_ENGINE_VERSION");
        /// <summary>
        /// Constant KAFKA_BOOTSTRAP_SERVERS for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey KAFKA_BOOTSTRAP_SERVERS = new ConnectionPropertyKey("KAFKA_BOOTSTRAP_SERVERS");
        /// <summary>
        /// Constant KAFKA_CLIENT_KEY_PASSWORD for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey KAFKA_CLIENT_KEY_PASSWORD = new ConnectionPropertyKey("KAFKA_CLIENT_KEY_PASSWORD");
        /// <summary>
        /// Constant KAFKA_CLIENT_KEYSTORE for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey KAFKA_CLIENT_KEYSTORE = new ConnectionPropertyKey("KAFKA_CLIENT_KEYSTORE");
        /// <summary>
        /// Constant KAFKA_CLIENT_KEYSTORE_PASSWORD for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey KAFKA_CLIENT_KEYSTORE_PASSWORD = new ConnectionPropertyKey("KAFKA_CLIENT_KEYSTORE_PASSWORD");
        /// <summary>
        /// Constant KAFKA_CUSTOM_CERT for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey KAFKA_CUSTOM_CERT = new ConnectionPropertyKey("KAFKA_CUSTOM_CERT");
        /// <summary>
        /// Constant KAFKA_SKIP_CUSTOM_CERT_VALIDATION for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey KAFKA_SKIP_CUSTOM_CERT_VALIDATION = new ConnectionPropertyKey("KAFKA_SKIP_CUSTOM_CERT_VALIDATION");
        /// <summary>
        /// Constant KAFKA_SSL_ENABLED for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey KAFKA_SSL_ENABLED = new ConnectionPropertyKey("KAFKA_SSL_ENABLED");
        /// <summary>
        /// Constant PASSWORD for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey PASSWORD = new ConnectionPropertyKey("PASSWORD");
        /// <summary>
        /// Constant PORT for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey PORT = new ConnectionPropertyKey("PORT");
        /// <summary>
        /// Constant SECRET_ID for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey SECRET_ID = new ConnectionPropertyKey("SECRET_ID");
        /// <summary>
        /// Constant SKIP_CUSTOM_JDBC_CERT_VALIDATION for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey SKIP_CUSTOM_JDBC_CERT_VALIDATION = new ConnectionPropertyKey("SKIP_CUSTOM_JDBC_CERT_VALIDATION");
        /// <summary>
        /// Constant USERNAME for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey USERNAME = new ConnectionPropertyKey("USERNAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionPropertyKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionPropertyKey FindValue(string value)
        {
            return FindValue<ConnectionPropertyKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionPropertyKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionType.
    /// </summary>
    public class ConnectionType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for ConnectionType
        /// </summary>
        public static readonly ConnectionType CUSTOM = new ConnectionType("CUSTOM");
        /// <summary>
        /// Constant JDBC for ConnectionType
        /// </summary>
        public static readonly ConnectionType JDBC = new ConnectionType("JDBC");
        /// <summary>
        /// Constant KAFKA for ConnectionType
        /// </summary>
        public static readonly ConnectionType KAFKA = new ConnectionType("KAFKA");
        /// <summary>
        /// Constant MARKETPLACE for ConnectionType
        /// </summary>
        public static readonly ConnectionType MARKETPLACE = new ConnectionType("MARKETPLACE");
        /// <summary>
        /// Constant MONGODB for ConnectionType
        /// </summary>
        public static readonly ConnectionType MONGODB = new ConnectionType("MONGODB");
        /// <summary>
        /// Constant NETWORK for ConnectionType
        /// </summary>
        public static readonly ConnectionType NETWORK = new ConnectionType("NETWORK");
        /// <summary>
        /// Constant SFTP for ConnectionType
        /// </summary>
        public static readonly ConnectionType SFTP = new ConnectionType("SFTP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionType FindValue(string value)
        {
            return FindValue<ConnectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CrawlerHistoryState.
    /// </summary>
    public class CrawlerHistoryState : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for CrawlerHistoryState
        /// </summary>
        public static readonly CrawlerHistoryState COMPLETED = new CrawlerHistoryState("COMPLETED");
        /// <summary>
        /// Constant FAILED for CrawlerHistoryState
        /// </summary>
        public static readonly CrawlerHistoryState FAILED = new CrawlerHistoryState("FAILED");
        /// <summary>
        /// Constant RUNNING for CrawlerHistoryState
        /// </summary>
        public static readonly CrawlerHistoryState RUNNING = new CrawlerHistoryState("RUNNING");
        /// <summary>
        /// Constant STOPPED for CrawlerHistoryState
        /// </summary>
        public static readonly CrawlerHistoryState STOPPED = new CrawlerHistoryState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CrawlerHistoryState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CrawlerHistoryState FindValue(string value)
        {
            return FindValue<CrawlerHistoryState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CrawlerHistoryState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CrawlerLineageSettings.
    /// </summary>
    public class CrawlerLineageSettings : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE for CrawlerLineageSettings
        /// </summary>
        public static readonly CrawlerLineageSettings DISABLE = new CrawlerLineageSettings("DISABLE");
        /// <summary>
        /// Constant ENABLE for CrawlerLineageSettings
        /// </summary>
        public static readonly CrawlerLineageSettings ENABLE = new CrawlerLineageSettings("ENABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CrawlerLineageSettings(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CrawlerLineageSettings FindValue(string value)
        {
            return FindValue<CrawlerLineageSettings>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CrawlerLineageSettings(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CrawlerState.
    /// </summary>
    public class CrawlerState : ConstantClass
    {

        /// <summary>
        /// Constant READY for CrawlerState
        /// </summary>
        public static readonly CrawlerState READY = new CrawlerState("READY");
        /// <summary>
        /// Constant RUNNING for CrawlerState
        /// </summary>
        public static readonly CrawlerState RUNNING = new CrawlerState("RUNNING");
        /// <summary>
        /// Constant STOPPING for CrawlerState
        /// </summary>
        public static readonly CrawlerState STOPPING = new CrawlerState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CrawlerState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CrawlerState FindValue(string value)
        {
            return FindValue<CrawlerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CrawlerState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CrawlState.
    /// </summary>
    public class CrawlState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for CrawlState
        /// </summary>
        public static readonly CrawlState CANCELLED = new CrawlState("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for CrawlState
        /// </summary>
        public static readonly CrawlState CANCELLING = new CrawlState("CANCELLING");
        /// <summary>
        /// Constant ERROR for CrawlState
        /// </summary>
        public static readonly CrawlState ERROR = new CrawlState("ERROR");
        /// <summary>
        /// Constant FAILED for CrawlState
        /// </summary>
        public static readonly CrawlState FAILED = new CrawlState("FAILED");
        /// <summary>
        /// Constant RUNNING for CrawlState
        /// </summary>
        public static readonly CrawlState RUNNING = new CrawlState("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for CrawlState
        /// </summary>
        public static readonly CrawlState SUCCEEDED = new CrawlState("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CrawlState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CrawlState FindValue(string value)
        {
            return FindValue<CrawlState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CrawlState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CsvHeaderOption.
    /// </summary>
    public class CsvHeaderOption : ConstantClass
    {

        /// <summary>
        /// Constant ABSENT for CsvHeaderOption
        /// </summary>
        public static readonly CsvHeaderOption ABSENT = new CsvHeaderOption("ABSENT");
        /// <summary>
        /// Constant PRESENT for CsvHeaderOption
        /// </summary>
        public static readonly CsvHeaderOption PRESENT = new CsvHeaderOption("PRESENT");
        /// <summary>
        /// Constant UNKNOWN for CsvHeaderOption
        /// </summary>
        public static readonly CsvHeaderOption UNKNOWN = new CsvHeaderOption("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CsvHeaderOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CsvHeaderOption FindValue(string value)
        {
            return FindValue<CsvHeaderOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CsvHeaderOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataFormat.
    /// </summary>
    public class DataFormat : ConstantClass
    {

        /// <summary>
        /// Constant AVRO for DataFormat
        /// </summary>
        public static readonly DataFormat AVRO = new DataFormat("AVRO");
        /// <summary>
        /// Constant JSON for DataFormat
        /// </summary>
        public static readonly DataFormat JSON = new DataFormat("JSON");
        /// <summary>
        /// Constant PROTOBUF for DataFormat
        /// </summary>
        public static readonly DataFormat PROTOBUF = new DataFormat("PROTOBUF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataFormat FindValue(string value)
        {
            return FindValue<DataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataQualityRuleResultStatus.
    /// </summary>
    public class DataQualityRuleResultStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for DataQualityRuleResultStatus
        /// </summary>
        public static readonly DataQualityRuleResultStatus ERROR = new DataQualityRuleResultStatus("ERROR");
        /// <summary>
        /// Constant FAIL for DataQualityRuleResultStatus
        /// </summary>
        public static readonly DataQualityRuleResultStatus FAIL = new DataQualityRuleResultStatus("FAIL");
        /// <summary>
        /// Constant PASS for DataQualityRuleResultStatus
        /// </summary>
        public static readonly DataQualityRuleResultStatus PASS = new DataQualityRuleResultStatus("PASS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataQualityRuleResultStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataQualityRuleResultStatus FindValue(string value)
        {
            return FindValue<DataQualityRuleResultStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataQualityRuleResultStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeleteBehavior.
    /// </summary>
    public class DeleteBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_FROM_DATABASE for DeleteBehavior
        /// </summary>
        public static readonly DeleteBehavior DELETE_FROM_DATABASE = new DeleteBehavior("DELETE_FROM_DATABASE");
        /// <summary>
        /// Constant DEPRECATE_IN_DATABASE for DeleteBehavior
        /// </summary>
        public static readonly DeleteBehavior DEPRECATE_IN_DATABASE = new DeleteBehavior("DEPRECATE_IN_DATABASE");
        /// <summary>
        /// Constant LOG for DeleteBehavior
        /// </summary>
        public static readonly DeleteBehavior LOG = new DeleteBehavior("LOG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeleteBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeleteBehavior FindValue(string value)
        {
            return FindValue<DeleteBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeleteBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeltaTargetCompressionType.
    /// </summary>
    public class DeltaTargetCompressionType : ConstantClass
    {

        /// <summary>
        /// Constant Snappy for DeltaTargetCompressionType
        /// </summary>
        public static readonly DeltaTargetCompressionType Snappy = new DeltaTargetCompressionType("snappy");
        /// <summary>
        /// Constant Uncompressed for DeltaTargetCompressionType
        /// </summary>
        public static readonly DeltaTargetCompressionType Uncompressed = new DeltaTargetCompressionType("uncompressed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeltaTargetCompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeltaTargetCompressionType FindValue(string value)
        {
            return FindValue<DeltaTargetCompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeltaTargetCompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DQStopJobOnFailureTiming.
    /// </summary>
    public class DQStopJobOnFailureTiming : ConstantClass
    {

        /// <summary>
        /// Constant AfterDataLoad for DQStopJobOnFailureTiming
        /// </summary>
        public static readonly DQStopJobOnFailureTiming AfterDataLoad = new DQStopJobOnFailureTiming("AfterDataLoad");
        /// <summary>
        /// Constant Immediate for DQStopJobOnFailureTiming
        /// </summary>
        public static readonly DQStopJobOnFailureTiming Immediate = new DQStopJobOnFailureTiming("Immediate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DQStopJobOnFailureTiming(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DQStopJobOnFailureTiming FindValue(string value)
        {
            return FindValue<DQStopJobOnFailureTiming>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DQStopJobOnFailureTiming(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DQTransformOutput.
    /// </summary>
    public class DQTransformOutput : ConstantClass
    {

        /// <summary>
        /// Constant EvaluationResults for DQTransformOutput
        /// </summary>
        public static readonly DQTransformOutput EvaluationResults = new DQTransformOutput("EvaluationResults");
        /// <summary>
        /// Constant PrimaryInput for DQTransformOutput
        /// </summary>
        public static readonly DQTransformOutput PrimaryInput = new DQTransformOutput("PrimaryInput");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DQTransformOutput(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DQTransformOutput FindValue(string value)
        {
            return FindValue<DQTransformOutput>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DQTransformOutput(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnableHybridValues.
    /// </summary>
    public class EnableHybridValues : ConstantClass
    {

        /// <summary>
        /// Constant FALSE for EnableHybridValues
        /// </summary>
        public static readonly EnableHybridValues FALSE = new EnableHybridValues("FALSE");
        /// <summary>
        /// Constant TRUE for EnableHybridValues
        /// </summary>
        public static readonly EnableHybridValues TRUE = new EnableHybridValues("TRUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnableHybridValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnableHybridValues FindValue(string value)
        {
            return FindValue<EnableHybridValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnableHybridValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionClass.
    /// </summary>
    public class ExecutionClass : ConstantClass
    {

        /// <summary>
        /// Constant FLEX for ExecutionClass
        /// </summary>
        public static readonly ExecutionClass FLEX = new ExecutionClass("FLEX");
        /// <summary>
        /// Constant STANDARD for ExecutionClass
        /// </summary>
        public static readonly ExecutionClass STANDARD = new ExecutionClass("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionClass FindValue(string value)
        {
            return FindValue<ExecutionClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExistCondition.
    /// </summary>
    public class ExistCondition : ConstantClass
    {

        /// <summary>
        /// Constant MUST_EXIST for ExistCondition
        /// </summary>
        public static readonly ExistCondition MUST_EXIST = new ExistCondition("MUST_EXIST");
        /// <summary>
        /// Constant NONE for ExistCondition
        /// </summary>
        public static readonly ExistCondition NONE = new ExistCondition("NONE");
        /// <summary>
        /// Constant NOT_EXIST for ExistCondition
        /// </summary>
        public static readonly ExistCondition NOT_EXIST = new ExistCondition("NOT_EXIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExistCondition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExistCondition FindValue(string value)
        {
            return FindValue<ExistCondition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExistCondition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FieldName.
    /// </summary>
    public class FieldName : ConstantClass
    {

        /// <summary>
        /// Constant CRAWL_ID for FieldName
        /// </summary>
        public static readonly FieldName CRAWL_ID = new FieldName("CRAWL_ID");
        /// <summary>
        /// Constant DPU_HOUR for FieldName
        /// </summary>
        public static readonly FieldName DPU_HOUR = new FieldName("DPU_HOUR");
        /// <summary>
        /// Constant END_TIME for FieldName
        /// </summary>
        public static readonly FieldName END_TIME = new FieldName("END_TIME");
        /// <summary>
        /// Constant START_TIME for FieldName
        /// </summary>
        public static readonly FieldName START_TIME = new FieldName("START_TIME");
        /// <summary>
        /// Constant STATE for FieldName
        /// </summary>
        public static readonly FieldName STATE = new FieldName("STATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldName FindValue(string value)
        {
            return FindValue<FieldName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterLogicalOperator.
    /// </summary>
    public class FilterLogicalOperator : ConstantClass
    {

        /// <summary>
        /// Constant AND for FilterLogicalOperator
        /// </summary>
        public static readonly FilterLogicalOperator AND = new FilterLogicalOperator("AND");
        /// <summary>
        /// Constant OR for FilterLogicalOperator
        /// </summary>
        public static readonly FilterLogicalOperator OR = new FilterLogicalOperator("OR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterLogicalOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterLogicalOperator FindValue(string value)
        {
            return FindValue<FilterLogicalOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterLogicalOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterOperation.
    /// </summary>
    public class FilterOperation : ConstantClass
    {

        /// <summary>
        /// Constant EQ for FilterOperation
        /// </summary>
        public static readonly FilterOperation EQ = new FilterOperation("EQ");
        /// <summary>
        /// Constant GT for FilterOperation
        /// </summary>
        public static readonly FilterOperation GT = new FilterOperation("GT");
        /// <summary>
        /// Constant GTE for FilterOperation
        /// </summary>
        public static readonly FilterOperation GTE = new FilterOperation("GTE");
        /// <summary>
        /// Constant ISNULL for FilterOperation
        /// </summary>
        public static readonly FilterOperation ISNULL = new FilterOperation("ISNULL");
        /// <summary>
        /// Constant LT for FilterOperation
        /// </summary>
        public static readonly FilterOperation LT = new FilterOperation("LT");
        /// <summary>
        /// Constant LTE for FilterOperation
        /// </summary>
        public static readonly FilterOperation LTE = new FilterOperation("LTE");
        /// <summary>
        /// Constant REGEX for FilterOperation
        /// </summary>
        public static readonly FilterOperation REGEX = new FilterOperation("REGEX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterOperation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterOperation FindValue(string value)
        {
            return FindValue<FilterOperation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterOperation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterOperator.
    /// </summary>
    public class FilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQ for FilterOperator
        /// </summary>
        public static readonly FilterOperator EQ = new FilterOperator("EQ");
        /// <summary>
        /// Constant GE for FilterOperator
        /// </summary>
        public static readonly FilterOperator GE = new FilterOperator("GE");
        /// <summary>
        /// Constant GT for FilterOperator
        /// </summary>
        public static readonly FilterOperator GT = new FilterOperator("GT");
        /// <summary>
        /// Constant LE for FilterOperator
        /// </summary>
        public static readonly FilterOperator LE = new FilterOperator("LE");
        /// <summary>
        /// Constant LT for FilterOperator
        /// </summary>
        public static readonly FilterOperator LT = new FilterOperator("LT");
        /// <summary>
        /// Constant NE for FilterOperator
        /// </summary>
        public static readonly FilterOperator NE = new FilterOperator("NE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterOperator FindValue(string value)
        {
            return FindValue<FilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterValueType.
    /// </summary>
    public class FilterValueType : ConstantClass
    {

        /// <summary>
        /// Constant COLUMNEXTRACTED for FilterValueType
        /// </summary>
        public static readonly FilterValueType COLUMNEXTRACTED = new FilterValueType("COLUMNEXTRACTED");
        /// <summary>
        /// Constant CONSTANT for FilterValueType
        /// </summary>
        public static readonly FilterValueType CONSTANT = new FilterValueType("CONSTANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterValueType FindValue(string value)
        {
            return FindValue<FilterValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlueRecordType.
    /// </summary>
    public class GlueRecordType : ConstantClass
    {

        /// <summary>
        /// Constant BIGDECIMAL for GlueRecordType
        /// </summary>
        public static readonly GlueRecordType BIGDECIMAL = new GlueRecordType("BIGDECIMAL");
        /// <summary>
        /// Constant BYTE for GlueRecordType
        /// </summary>
        public static readonly GlueRecordType BYTE = new GlueRecordType("BYTE");
        /// <summary>
        /// Constant DATE for GlueRecordType
        /// </summary>
        public static readonly GlueRecordType DATE = new GlueRecordType("DATE");
        /// <summary>
        /// Constant DOUBLE for GlueRecordType
        /// </summary>
        public static readonly GlueRecordType DOUBLE = new GlueRecordType("DOUBLE");
        /// <summary>
        /// Constant FLOAT for GlueRecordType
        /// </summary>
        public static readonly GlueRecordType FLOAT = new GlueRecordType("FLOAT");
        /// <summary>
        /// Constant INT for GlueRecordType
        /// </summary>
        public static readonly GlueRecordType INT = new GlueRecordType("INT");
        /// <summary>
        /// Constant LONG for GlueRecordType
        /// </summary>
        public static readonly GlueRecordType LONG = new GlueRecordType("LONG");
        /// <summary>
        /// Constant SHORT for GlueRecordType
        /// </summary>
        public static readonly GlueRecordType SHORT = new GlueRecordType("SHORT");
        /// <summary>
        /// Constant STRING for GlueRecordType
        /// </summary>
        public static readonly GlueRecordType STRING = new GlueRecordType("STRING");
        /// <summary>
        /// Constant TIMESTAMP for GlueRecordType
        /// </summary>
        public static readonly GlueRecordType TIMESTAMP = new GlueRecordType("TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlueRecordType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlueRecordType FindValue(string value)
        {
            return FindValue<GlueRecordType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlueRecordType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HudiTargetCompressionType.
    /// </summary>
    public class HudiTargetCompressionType : ConstantClass
    {

        /// <summary>
        /// Constant Gzip for HudiTargetCompressionType
        /// </summary>
        public static readonly HudiTargetCompressionType Gzip = new HudiTargetCompressionType("gzip");
        /// <summary>
        /// Constant Lzo for HudiTargetCompressionType
        /// </summary>
        public static readonly HudiTargetCompressionType Lzo = new HudiTargetCompressionType("lzo");
        /// <summary>
        /// Constant Snappy for HudiTargetCompressionType
        /// </summary>
        public static readonly HudiTargetCompressionType Snappy = new HudiTargetCompressionType("snappy");
        /// <summary>
        /// Constant Uncompressed for HudiTargetCompressionType
        /// </summary>
        public static readonly HudiTargetCompressionType Uncompressed = new HudiTargetCompressionType("uncompressed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HudiTargetCompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HudiTargetCompressionType FindValue(string value)
        {
            return FindValue<HudiTargetCompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HudiTargetCompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JDBCConnectionType.
    /// </summary>
    public class JDBCConnectionType : ConstantClass
    {

        /// <summary>
        /// Constant Mysql for JDBCConnectionType
        /// </summary>
        public static readonly JDBCConnectionType Mysql = new JDBCConnectionType("mysql");
        /// <summary>
        /// Constant Oracle for JDBCConnectionType
        /// </summary>
        public static readonly JDBCConnectionType Oracle = new JDBCConnectionType("oracle");
        /// <summary>
        /// Constant Postgresql for JDBCConnectionType
        /// </summary>
        public static readonly JDBCConnectionType Postgresql = new JDBCConnectionType("postgresql");
        /// <summary>
        /// Constant Redshift for JDBCConnectionType
        /// </summary>
        public static readonly JDBCConnectionType Redshift = new JDBCConnectionType("redshift");
        /// <summary>
        /// Constant Sqlserver for JDBCConnectionType
        /// </summary>
        public static readonly JDBCConnectionType Sqlserver = new JDBCConnectionType("sqlserver");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JDBCConnectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JDBCConnectionType FindValue(string value)
        {
            return FindValue<JDBCConnectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JDBCConnectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JDBCDataType.
    /// </summary>
    public class JDBCDataType : ConstantClass
    {

        /// <summary>
        /// Constant ARRAY for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType ARRAY = new JDBCDataType("ARRAY");
        /// <summary>
        /// Constant BIGINT for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType BIGINT = new JDBCDataType("BIGINT");
        /// <summary>
        /// Constant BINARY for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType BINARY = new JDBCDataType("BINARY");
        /// <summary>
        /// Constant BIT for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType BIT = new JDBCDataType("BIT");
        /// <summary>
        /// Constant BLOB for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType BLOB = new JDBCDataType("BLOB");
        /// <summary>
        /// Constant BOOLEAN for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType BOOLEAN = new JDBCDataType("BOOLEAN");
        /// <summary>
        /// Constant CHAR for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType CHAR = new JDBCDataType("CHAR");
        /// <summary>
        /// Constant CLOB for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType CLOB = new JDBCDataType("CLOB");
        /// <summary>
        /// Constant DATALINK for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType DATALINK = new JDBCDataType("DATALINK");
        /// <summary>
        /// Constant DATE for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType DATE = new JDBCDataType("DATE");
        /// <summary>
        /// Constant DECIMAL for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType DECIMAL = new JDBCDataType("DECIMAL");
        /// <summary>
        /// Constant DISTINCT for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType DISTINCT = new JDBCDataType("DISTINCT");
        /// <summary>
        /// Constant DOUBLE for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType DOUBLE = new JDBCDataType("DOUBLE");
        /// <summary>
        /// Constant FLOAT for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType FLOAT = new JDBCDataType("FLOAT");
        /// <summary>
        /// Constant INTEGER for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType INTEGER = new JDBCDataType("INTEGER");
        /// <summary>
        /// Constant JAVA_OBJECT for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType JAVA_OBJECT = new JDBCDataType("JAVA_OBJECT");
        /// <summary>
        /// Constant LONGNVARCHAR for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType LONGNVARCHAR = new JDBCDataType("LONGNVARCHAR");
        /// <summary>
        /// Constant LONGVARBINARY for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType LONGVARBINARY = new JDBCDataType("LONGVARBINARY");
        /// <summary>
        /// Constant LONGVARCHAR for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType LONGVARCHAR = new JDBCDataType("LONGVARCHAR");
        /// <summary>
        /// Constant NCHAR for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType NCHAR = new JDBCDataType("NCHAR");
        /// <summary>
        /// Constant NCLOB for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType NCLOB = new JDBCDataType("NCLOB");
        /// <summary>
        /// Constant NULL for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType NULL = new JDBCDataType("NULL");
        /// <summary>
        /// Constant NUMERIC for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType NUMERIC = new JDBCDataType("NUMERIC");
        /// <summary>
        /// Constant NVARCHAR for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType NVARCHAR = new JDBCDataType("NVARCHAR");
        /// <summary>
        /// Constant OTHER for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType OTHER = new JDBCDataType("OTHER");
        /// <summary>
        /// Constant REAL for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType REAL = new JDBCDataType("REAL");
        /// <summary>
        /// Constant REF for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType REF = new JDBCDataType("REF");
        /// <summary>
        /// Constant REF_CURSOR for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType REF_CURSOR = new JDBCDataType("REF_CURSOR");
        /// <summary>
        /// Constant ROWID for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType ROWID = new JDBCDataType("ROWID");
        /// <summary>
        /// Constant SMALLINT for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType SMALLINT = new JDBCDataType("SMALLINT");
        /// <summary>
        /// Constant SQLXML for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType SQLXML = new JDBCDataType("SQLXML");
        /// <summary>
        /// Constant STRUCT for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType STRUCT = new JDBCDataType("STRUCT");
        /// <summary>
        /// Constant TIME for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType TIME = new JDBCDataType("TIME");
        /// <summary>
        /// Constant TIME_WITH_TIMEZONE for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType TIME_WITH_TIMEZONE = new JDBCDataType("TIME_WITH_TIMEZONE");
        /// <summary>
        /// Constant TIMESTAMP for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType TIMESTAMP = new JDBCDataType("TIMESTAMP");
        /// <summary>
        /// Constant TIMESTAMP_WITH_TIMEZONE for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType TIMESTAMP_WITH_TIMEZONE = new JDBCDataType("TIMESTAMP_WITH_TIMEZONE");
        /// <summary>
        /// Constant TINYINT for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType TINYINT = new JDBCDataType("TINYINT");
        /// <summary>
        /// Constant VARBINARY for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType VARBINARY = new JDBCDataType("VARBINARY");
        /// <summary>
        /// Constant VARCHAR for JDBCDataType
        /// </summary>
        public static readonly JDBCDataType VARCHAR = new JDBCDataType("VARCHAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JDBCDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JDBCDataType FindValue(string value)
        {
            return FindValue<JDBCDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JDBCDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JdbcMetadataEntry.
    /// </summary>
    public class JdbcMetadataEntry : ConstantClass
    {

        /// <summary>
        /// Constant COMMENTS for JdbcMetadataEntry
        /// </summary>
        public static readonly JdbcMetadataEntry COMMENTS = new JdbcMetadataEntry("COMMENTS");
        /// <summary>
        /// Constant RAWTYPES for JdbcMetadataEntry
        /// </summary>
        public static readonly JdbcMetadataEntry RAWTYPES = new JdbcMetadataEntry("RAWTYPES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JdbcMetadataEntry(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JdbcMetadataEntry FindValue(string value)
        {
            return FindValue<JdbcMetadataEntry>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JdbcMetadataEntry(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobBookmarksEncryptionMode.
    /// </summary>
    public class JobBookmarksEncryptionMode : ConstantClass
    {

        /// <summary>
        /// Constant CSEKMS for JobBookmarksEncryptionMode
        /// </summary>
        public static readonly JobBookmarksEncryptionMode CSEKMS = new JobBookmarksEncryptionMode("CSE-KMS");
        /// <summary>
        /// Constant DISABLED for JobBookmarksEncryptionMode
        /// </summary>
        public static readonly JobBookmarksEncryptionMode DISABLED = new JobBookmarksEncryptionMode("DISABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobBookmarksEncryptionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobBookmarksEncryptionMode FindValue(string value)
        {
            return FindValue<JobBookmarksEncryptionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobBookmarksEncryptionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobRunState.
    /// </summary>
    public class JobRunState : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for JobRunState
        /// </summary>
        public static readonly JobRunState ERROR = new JobRunState("ERROR");
        /// <summary>
        /// Constant FAILED for JobRunState
        /// </summary>
        public static readonly JobRunState FAILED = new JobRunState("FAILED");
        /// <summary>
        /// Constant RUNNING for JobRunState
        /// </summary>
        public static readonly JobRunState RUNNING = new JobRunState("RUNNING");
        /// <summary>
        /// Constant STARTING for JobRunState
        /// </summary>
        public static readonly JobRunState STARTING = new JobRunState("STARTING");
        /// <summary>
        /// Constant STOPPED for JobRunState
        /// </summary>
        public static readonly JobRunState STOPPED = new JobRunState("STOPPED");
        /// <summary>
        /// Constant STOPPING for JobRunState
        /// </summary>
        public static readonly JobRunState STOPPING = new JobRunState("STOPPING");
        /// <summary>
        /// Constant SUCCEEDED for JobRunState
        /// </summary>
        public static readonly JobRunState SUCCEEDED = new JobRunState("SUCCEEDED");
        /// <summary>
        /// Constant TIMEOUT for JobRunState
        /// </summary>
        public static readonly JobRunState TIMEOUT = new JobRunState("TIMEOUT");
        /// <summary>
        /// Constant WAITING for JobRunState
        /// </summary>
        public static readonly JobRunState WAITING = new JobRunState("WAITING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobRunState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobRunState FindValue(string value)
        {
            return FindValue<JobRunState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobRunState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JoinType.
    /// </summary>
    public class JoinType : ConstantClass
    {

        /// <summary>
        /// Constant Equijoin for JoinType
        /// </summary>
        public static readonly JoinType Equijoin = new JoinType("equijoin");
        /// <summary>
        /// Constant Left for JoinType
        /// </summary>
        public static readonly JoinType Left = new JoinType("left");
        /// <summary>
        /// Constant Leftanti for JoinType
        /// </summary>
        public static readonly JoinType Leftanti = new JoinType("leftanti");
        /// <summary>
        /// Constant Leftsemi for JoinType
        /// </summary>
        public static readonly JoinType Leftsemi = new JoinType("leftsemi");
        /// <summary>
        /// Constant Outer for JoinType
        /// </summary>
        public static readonly JoinType Outer = new JoinType("outer");
        /// <summary>
        /// Constant Right for JoinType
        /// </summary>
        public static readonly JoinType Right = new JoinType("right");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JoinType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JoinType FindValue(string value)
        {
            return FindValue<JoinType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JoinType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Language.
    /// </summary>
    public class Language : ConstantClass
    {

        /// <summary>
        /// Constant PYTHON for Language
        /// </summary>
        public static readonly Language PYTHON = new Language("PYTHON");
        /// <summary>
        /// Constant SCALA for Language
        /// </summary>
        public static readonly Language SCALA = new Language("SCALA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Language(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Language FindValue(string value)
        {
            return FindValue<Language>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Language(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LastCrawlStatus.
    /// </summary>
    public class LastCrawlStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for LastCrawlStatus
        /// </summary>
        public static readonly LastCrawlStatus CANCELLED = new LastCrawlStatus("CANCELLED");
        /// <summary>
        /// Constant FAILED for LastCrawlStatus
        /// </summary>
        public static readonly LastCrawlStatus FAILED = new LastCrawlStatus("FAILED");
        /// <summary>
        /// Constant SUCCEEDED for LastCrawlStatus
        /// </summary>
        public static readonly LastCrawlStatus SUCCEEDED = new LastCrawlStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastCrawlStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastCrawlStatus FindValue(string value)
        {
            return FindValue<LastCrawlStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastCrawlStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Logical.
    /// </summary>
    public class Logical : ConstantClass
    {

        /// <summary>
        /// Constant AND for Logical
        /// </summary>
        public static readonly Logical AND = new Logical("AND");
        /// <summary>
        /// Constant ANY for Logical
        /// </summary>
        public static readonly Logical ANY = new Logical("ANY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Logical(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Logical FindValue(string value)
        {
            return FindValue<Logical>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Logical(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogicalOperator.
    /// </summary>
    public class LogicalOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for LogicalOperator
        /// </summary>
        public static readonly LogicalOperator EQUALS = new LogicalOperator("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogicalOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogicalOperator FindValue(string value)
        {
            return FindValue<LogicalOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogicalOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MLUserDataEncryptionModeString.
    /// </summary>
    public class MLUserDataEncryptionModeString : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for MLUserDataEncryptionModeString
        /// </summary>
        public static readonly MLUserDataEncryptionModeString DISABLED = new MLUserDataEncryptionModeString("DISABLED");
        /// <summary>
        /// Constant SSEKMS for MLUserDataEncryptionModeString
        /// </summary>
        public static readonly MLUserDataEncryptionModeString SSEKMS = new MLUserDataEncryptionModeString("SSE-KMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MLUserDataEncryptionModeString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MLUserDataEncryptionModeString FindValue(string value)
        {
            return FindValue<MLUserDataEncryptionModeString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MLUserDataEncryptionModeString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeType.
    /// </summary>
    public class NodeType : ConstantClass
    {

        /// <summary>
        /// Constant CRAWLER for NodeType
        /// </summary>
        public static readonly NodeType CRAWLER = new NodeType("CRAWLER");
        /// <summary>
        /// Constant JOB for NodeType
        /// </summary>
        public static readonly NodeType JOB = new NodeType("JOB");
        /// <summary>
        /// Constant TRIGGER for NodeType
        /// </summary>
        public static readonly NodeType TRIGGER = new NodeType("TRIGGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeType FindValue(string value)
        {
            return FindValue<NodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParamType.
    /// </summary>
    public class ParamType : ConstantClass
    {

        /// <summary>
        /// Constant Bool for ParamType
        /// </summary>
        public static readonly ParamType Bool = new ParamType("bool");
        /// <summary>
        /// Constant Complex for ParamType
        /// </summary>
        public static readonly ParamType Complex = new ParamType("complex");
        /// <summary>
        /// Constant Float for ParamType
        /// </summary>
        public static readonly ParamType Float = new ParamType("float");
        /// <summary>
        /// Constant Int for ParamType
        /// </summary>
        public static readonly ParamType Int = new ParamType("int");
        /// <summary>
        /// Constant List for ParamType
        /// </summary>
        public static readonly ParamType List = new ParamType("list");
        /// <summary>
        /// Constant Null for ParamType
        /// </summary>
        public static readonly ParamType Null = new ParamType("null");
        /// <summary>
        /// Constant Str for ParamType
        /// </summary>
        public static readonly ParamType Str = new ParamType("str");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParamType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParamType FindValue(string value)
        {
            return FindValue<ParamType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParamType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParquetCompressionType.
    /// </summary>
    public class ParquetCompressionType : ConstantClass
    {

        /// <summary>
        /// Constant Gzip for ParquetCompressionType
        /// </summary>
        public static readonly ParquetCompressionType Gzip = new ParquetCompressionType("gzip");
        /// <summary>
        /// Constant Lzo for ParquetCompressionType
        /// </summary>
        public static readonly ParquetCompressionType Lzo = new ParquetCompressionType("lzo");
        /// <summary>
        /// Constant None for ParquetCompressionType
        /// </summary>
        public static readonly ParquetCompressionType None = new ParquetCompressionType("none");
        /// <summary>
        /// Constant Snappy for ParquetCompressionType
        /// </summary>
        public static readonly ParquetCompressionType Snappy = new ParquetCompressionType("snappy");
        /// <summary>
        /// Constant Uncompressed for ParquetCompressionType
        /// </summary>
        public static readonly ParquetCompressionType Uncompressed = new ParquetCompressionType("uncompressed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParquetCompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParquetCompressionType FindValue(string value)
        {
            return FindValue<ParquetCompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParquetCompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PartitionIndexStatus.
    /// </summary>
    public class PartitionIndexStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PartitionIndexStatus
        /// </summary>
        public static readonly PartitionIndexStatus ACTIVE = new PartitionIndexStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for PartitionIndexStatus
        /// </summary>
        public static readonly PartitionIndexStatus CREATING = new PartitionIndexStatus("CREATING");
        /// <summary>
        /// Constant DELETING for PartitionIndexStatus
        /// </summary>
        public static readonly PartitionIndexStatus DELETING = new PartitionIndexStatus("DELETING");
        /// <summary>
        /// Constant FAILED for PartitionIndexStatus
        /// </summary>
        public static readonly PartitionIndexStatus FAILED = new PartitionIndexStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartitionIndexStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartitionIndexStatus FindValue(string value)
        {
            return FindValue<PartitionIndexStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartitionIndexStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Permission.
    /// </summary>
    public class Permission : ConstantClass
    {

        /// <summary>
        /// Constant ALL for Permission
        /// </summary>
        public static readonly Permission ALL = new Permission("ALL");
        /// <summary>
        /// Constant ALTER for Permission
        /// </summary>
        public static readonly Permission ALTER = new Permission("ALTER");
        /// <summary>
        /// Constant CREATE_DATABASE for Permission
        /// </summary>
        public static readonly Permission CREATE_DATABASE = new Permission("CREATE_DATABASE");
        /// <summary>
        /// Constant CREATE_TABLE for Permission
        /// </summary>
        public static readonly Permission CREATE_TABLE = new Permission("CREATE_TABLE");
        /// <summary>
        /// Constant DATA_LOCATION_ACCESS for Permission
        /// </summary>
        public static readonly Permission DATA_LOCATION_ACCESS = new Permission("DATA_LOCATION_ACCESS");
        /// <summary>
        /// Constant DELETE for Permission
        /// </summary>
        public static readonly Permission DELETE = new Permission("DELETE");
        /// <summary>
        /// Constant DROP for Permission
        /// </summary>
        public static readonly Permission DROP = new Permission("DROP");
        /// <summary>
        /// Constant INSERT for Permission
        /// </summary>
        public static readonly Permission INSERT = new Permission("INSERT");
        /// <summary>
        /// Constant SELECT for Permission
        /// </summary>
        public static readonly Permission SELECT = new Permission("SELECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Permission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Permission FindValue(string value)
        {
            return FindValue<Permission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Permission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionType.
    /// </summary>
    public class PermissionType : ConstantClass
    {

        /// <summary>
        /// Constant CELL_FILTER_PERMISSION for PermissionType
        /// </summary>
        public static readonly PermissionType CELL_FILTER_PERMISSION = new PermissionType("CELL_FILTER_PERMISSION");
        /// <summary>
        /// Constant COLUMN_PERMISSION for PermissionType
        /// </summary>
        public static readonly PermissionType COLUMN_PERMISSION = new PermissionType("COLUMN_PERMISSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionType FindValue(string value)
        {
            return FindValue<PermissionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PiiType.
    /// </summary>
    public class PiiType : ConstantClass
    {

        /// <summary>
        /// Constant ColumnAudit for PiiType
        /// </summary>
        public static readonly PiiType ColumnAudit = new PiiType("ColumnAudit");
        /// <summary>
        /// Constant ColumnMasking for PiiType
        /// </summary>
        public static readonly PiiType ColumnMasking = new PiiType("ColumnMasking");
        /// <summary>
        /// Constant RowAudit for PiiType
        /// </summary>
        public static readonly PiiType RowAudit = new PiiType("RowAudit");
        /// <summary>
        /// Constant RowMasking for PiiType
        /// </summary>
        public static readonly PiiType RowMasking = new PiiType("RowMasking");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PiiType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PiiType FindValue(string value)
        {
            return FindValue<PiiType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PiiType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrincipalType.
    /// </summary>
    public class PrincipalType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for PrincipalType
        /// </summary>
        public static readonly PrincipalType GROUP = new PrincipalType("GROUP");
        /// <summary>
        /// Constant ROLE for PrincipalType
        /// </summary>
        public static readonly PrincipalType ROLE = new PrincipalType("ROLE");
        /// <summary>
        /// Constant USER for PrincipalType
        /// </summary>
        public static readonly PrincipalType USER = new PrincipalType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrincipalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrincipalType FindValue(string value)
        {
            return FindValue<PrincipalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrincipalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuoteChar.
    /// </summary>
    public class QuoteChar : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for QuoteChar
        /// </summary>
        public static readonly QuoteChar Disabled = new QuoteChar("disabled");
        /// <summary>
        /// Constant Quillemet for QuoteChar
        /// </summary>
        public static readonly QuoteChar Quillemet = new QuoteChar("quillemet");
        /// <summary>
        /// Constant Quote for QuoteChar
        /// </summary>
        public static readonly QuoteChar Quote = new QuoteChar("quote");
        /// <summary>
        /// Constant Single_quote for QuoteChar
        /// </summary>
        public static readonly QuoteChar Single_quote = new QuoteChar("single_quote");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuoteChar(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuoteChar FindValue(string value)
        {
            return FindValue<QuoteChar>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuoteChar(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecrawlBehavior.
    /// </summary>
    public class RecrawlBehavior : ConstantClass
    {

        /// <summary>
        /// Constant CRAWL_EVENT_MODE for RecrawlBehavior
        /// </summary>
        public static readonly RecrawlBehavior CRAWL_EVENT_MODE = new RecrawlBehavior("CRAWL_EVENT_MODE");
        /// <summary>
        /// Constant CRAWL_EVERYTHING for RecrawlBehavior
        /// </summary>
        public static readonly RecrawlBehavior CRAWL_EVERYTHING = new RecrawlBehavior("CRAWL_EVERYTHING");
        /// <summary>
        /// Constant CRAWL_NEW_FOLDERS_ONLY for RecrawlBehavior
        /// </summary>
        public static readonly RecrawlBehavior CRAWL_NEW_FOLDERS_ONLY = new RecrawlBehavior("CRAWL_NEW_FOLDERS_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecrawlBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecrawlBehavior FindValue(string value)
        {
            return FindValue<RecrawlBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecrawlBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistryStatus.
    /// </summary>
    public class RegistryStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for RegistryStatus
        /// </summary>
        public static readonly RegistryStatus AVAILABLE = new RegistryStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETING for RegistryStatus
        /// </summary>
        public static readonly RegistryStatus DELETING = new RegistryStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryStatus FindValue(string value)
        {
            return FindValue<RegistryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceShareType.
    /// </summary>
    public class ResourceShareType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ResourceShareType
        /// </summary>
        public static readonly ResourceShareType ALL = new ResourceShareType("ALL");
        /// <summary>
        /// Constant FOREIGN for ResourceShareType
        /// </summary>
        public static readonly ResourceShareType FOREIGN = new ResourceShareType("FOREIGN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceShareType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceShareType FindValue(string value)
        {
            return FindValue<ResourceShareType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceShareType(string value)
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
        /// Constant ARCHIVE for ResourceType
        /// </summary>
        public static readonly ResourceType ARCHIVE = new ResourceType("ARCHIVE");
        /// <summary>
        /// Constant FILE for ResourceType
        /// </summary>
        public static readonly ResourceType FILE = new ResourceType("FILE");
        /// <summary>
        /// Constant JAR for ResourceType
        /// </summary>
        public static readonly ResourceType JAR = new ResourceType("JAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type S3EncryptionMode.
    /// </summary>
    public class S3EncryptionMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for S3EncryptionMode
        /// </summary>
        public static readonly S3EncryptionMode DISABLED = new S3EncryptionMode("DISABLED");
        /// <summary>
        /// Constant SSEKMS for S3EncryptionMode
        /// </summary>
        public static readonly S3EncryptionMode SSEKMS = new S3EncryptionMode("SSE-KMS");
        /// <summary>
        /// Constant SSES3 for S3EncryptionMode
        /// </summary>
        public static readonly S3EncryptionMode SSES3 = new S3EncryptionMode("SSE-S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3EncryptionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3EncryptionMode FindValue(string value)
        {
            return FindValue<S3EncryptionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3EncryptionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduleState.
    /// </summary>
    public class ScheduleState : ConstantClass
    {

        /// <summary>
        /// Constant NOT_SCHEDULED for ScheduleState
        /// </summary>
        public static readonly ScheduleState NOT_SCHEDULED = new ScheduleState("NOT_SCHEDULED");
        /// <summary>
        /// Constant SCHEDULED for ScheduleState
        /// </summary>
        public static readonly ScheduleState SCHEDULED = new ScheduleState("SCHEDULED");
        /// <summary>
        /// Constant TRANSITIONING for ScheduleState
        /// </summary>
        public static readonly ScheduleState TRANSITIONING = new ScheduleState("TRANSITIONING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduleState FindValue(string value)
        {
            return FindValue<ScheduleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaDiffType.
    /// </summary>
    public class SchemaDiffType : ConstantClass
    {

        /// <summary>
        /// Constant SYNTAX_DIFF for SchemaDiffType
        /// </summary>
        public static readonly SchemaDiffType SYNTAX_DIFF = new SchemaDiffType("SYNTAX_DIFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaDiffType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaDiffType FindValue(string value)
        {
            return FindValue<SchemaDiffType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaDiffType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaStatus.
    /// </summary>
    public class SchemaStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus AVAILABLE = new SchemaStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETING for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus DELETING = new SchemaStatus("DELETING");
        /// <summary>
        /// Constant PENDING for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus PENDING = new SchemaStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaStatus FindValue(string value)
        {
            return FindValue<SchemaStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaVersionStatus.
    /// </summary>
    public class SchemaVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for SchemaVersionStatus
        /// </summary>
        public static readonly SchemaVersionStatus AVAILABLE = new SchemaVersionStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETING for SchemaVersionStatus
        /// </summary>
        public static readonly SchemaVersionStatus DELETING = new SchemaVersionStatus("DELETING");
        /// <summary>
        /// Constant FAILURE for SchemaVersionStatus
        /// </summary>
        public static readonly SchemaVersionStatus FAILURE = new SchemaVersionStatus("FAILURE");
        /// <summary>
        /// Constant PENDING for SchemaVersionStatus
        /// </summary>
        public static readonly SchemaVersionStatus PENDING = new SchemaVersionStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaVersionStatus FindValue(string value)
        {
            return FindValue<SchemaVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Separator.
    /// </summary>
    public class Separator : ConstantClass
    {

        /// <summary>
        /// Constant Comma for Separator
        /// </summary>
        public static readonly Separator Comma = new Separator("comma");
        /// <summary>
        /// Constant Ctrla for Separator
        /// </summary>
        public static readonly Separator Ctrla = new Separator("ctrla");
        /// <summary>
        /// Constant Pipe for Separator
        /// </summary>
        public static readonly Separator Pipe = new Separator("pipe");
        /// <summary>
        /// Constant Semicolon for Separator
        /// </summary>
        public static readonly Separator Semicolon = new Separator("semicolon");
        /// <summary>
        /// Constant Tab for Separator
        /// </summary>
        public static readonly Separator Tab = new Separator("tab");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Separator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Separator FindValue(string value)
        {
            return FindValue<Separator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Separator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionStatus.
    /// </summary>
    public class SessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for SessionStatus
        /// </summary>
        public static readonly SessionStatus FAILED = new SessionStatus("FAILED");
        /// <summary>
        /// Constant PROVISIONING for SessionStatus
        /// </summary>
        public static readonly SessionStatus PROVISIONING = new SessionStatus("PROVISIONING");
        /// <summary>
        /// Constant READY for SessionStatus
        /// </summary>
        public static readonly SessionStatus READY = new SessionStatus("READY");
        /// <summary>
        /// Constant STOPPED for SessionStatus
        /// </summary>
        public static readonly SessionStatus STOPPED = new SessionStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for SessionStatus
        /// </summary>
        public static readonly SessionStatus STOPPING = new SessionStatus("STOPPING");
        /// <summary>
        /// Constant TIMEOUT for SessionStatus
        /// </summary>
        public static readonly SessionStatus TIMEOUT = new SessionStatus("TIMEOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionStatus FindValue(string value)
        {
            return FindValue<SessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Sort.
    /// </summary>
    public class Sort : ConstantClass
    {

        /// <summary>
        /// Constant ASC for Sort
        /// </summary>
        public static readonly Sort ASC = new Sort("ASC");
        /// <summary>
        /// Constant DESC for Sort
        /// </summary>
        public static readonly Sort DESC = new Sort("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Sort(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Sort FindValue(string value)
        {
            return FindValue<Sort>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Sort(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortDirectionType.
    /// </summary>
    public class SortDirectionType : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortDirectionType
        /// </summary>
        public static readonly SortDirectionType ASCENDING = new SortDirectionType("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortDirectionType
        /// </summary>
        public static readonly SortDirectionType DESCENDING = new SortDirectionType("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortDirectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortDirectionType FindValue(string value)
        {
            return FindValue<SortDirectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortDirectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceControlAuthStrategy.
    /// </summary>
    public class SourceControlAuthStrategy : ConstantClass
    {

        /// <summary>
        /// Constant AWS_SECRETS_MANAGER for SourceControlAuthStrategy
        /// </summary>
        public static readonly SourceControlAuthStrategy AWS_SECRETS_MANAGER = new SourceControlAuthStrategy("AWS_SECRETS_MANAGER");
        /// <summary>
        /// Constant PERSONAL_ACCESS_TOKEN for SourceControlAuthStrategy
        /// </summary>
        public static readonly SourceControlAuthStrategy PERSONAL_ACCESS_TOKEN = new SourceControlAuthStrategy("PERSONAL_ACCESS_TOKEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceControlAuthStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceControlAuthStrategy FindValue(string value)
        {
            return FindValue<SourceControlAuthStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceControlAuthStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceControlProvider.
    /// </summary>
    public class SourceControlProvider : ConstantClass
    {

        /// <summary>
        /// Constant AWS_CODE_COMMIT for SourceControlProvider
        /// </summary>
        public static readonly SourceControlProvider AWS_CODE_COMMIT = new SourceControlProvider("AWS_CODE_COMMIT");
        /// <summary>
        /// Constant GITHUB for SourceControlProvider
        /// </summary>
        public static readonly SourceControlProvider GITHUB = new SourceControlProvider("GITHUB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceControlProvider(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceControlProvider FindValue(string value)
        {
            return FindValue<SourceControlProvider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceControlProvider(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StartingPosition.
    /// </summary>
    public class StartingPosition : ConstantClass
    {

        /// <summary>
        /// Constant Earliest for StartingPosition
        /// </summary>
        public static readonly StartingPosition Earliest = new StartingPosition("earliest");
        /// <summary>
        /// Constant Latest for StartingPosition
        /// </summary>
        public static readonly StartingPosition Latest = new StartingPosition("latest");
        /// <summary>
        /// Constant Trim_horizon for StartingPosition
        /// </summary>
        public static readonly StartingPosition Trim_horizon = new StartingPosition("trim_horizon");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StartingPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StartingPosition FindValue(string value)
        {
            return FindValue<StartingPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StartingPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatementState.
    /// </summary>
    public class StatementState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for StatementState
        /// </summary>
        public static readonly StatementState AVAILABLE = new StatementState("AVAILABLE");
        /// <summary>
        /// Constant CANCELLED for StatementState
        /// </summary>
        public static readonly StatementState CANCELLED = new StatementState("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for StatementState
        /// </summary>
        public static readonly StatementState CANCELLING = new StatementState("CANCELLING");
        /// <summary>
        /// Constant ERROR for StatementState
        /// </summary>
        public static readonly StatementState ERROR = new StatementState("ERROR");
        /// <summary>
        /// Constant RUNNING for StatementState
        /// </summary>
        public static readonly StatementState RUNNING = new StatementState("RUNNING");
        /// <summary>
        /// Constant WAITING for StatementState
        /// </summary>
        public static readonly StatementState WAITING = new StatementState("WAITING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatementState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatementState FindValue(string value)
        {
            return FindValue<StatementState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatementState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetFormat.
    /// </summary>
    public class TargetFormat : ConstantClass
    {

        /// <summary>
        /// Constant Avro for TargetFormat
        /// </summary>
        public static readonly TargetFormat Avro = new TargetFormat("avro");
        /// <summary>
        /// Constant Csv for TargetFormat
        /// </summary>
        public static readonly TargetFormat Csv = new TargetFormat("csv");
        /// <summary>
        /// Constant Delta for TargetFormat
        /// </summary>
        public static readonly TargetFormat Delta = new TargetFormat("delta");
        /// <summary>
        /// Constant Hudi for TargetFormat
        /// </summary>
        public static readonly TargetFormat Hudi = new TargetFormat("hudi");
        /// <summary>
        /// Constant Json for TargetFormat
        /// </summary>
        public static readonly TargetFormat Json = new TargetFormat("json");
        /// <summary>
        /// Constant Orc for TargetFormat
        /// </summary>
        public static readonly TargetFormat Orc = new TargetFormat("orc");
        /// <summary>
        /// Constant Parquet for TargetFormat
        /// </summary>
        public static readonly TargetFormat Parquet = new TargetFormat("parquet");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetFormat FindValue(string value)
        {
            return FindValue<TargetFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskRunSortColumnType.
    /// </summary>
    public class TaskRunSortColumnType : ConstantClass
    {

        /// <summary>
        /// Constant STARTED for TaskRunSortColumnType
        /// </summary>
        public static readonly TaskRunSortColumnType STARTED = new TaskRunSortColumnType("STARTED");
        /// <summary>
        /// Constant STATUS for TaskRunSortColumnType
        /// </summary>
        public static readonly TaskRunSortColumnType STATUS = new TaskRunSortColumnType("STATUS");
        /// <summary>
        /// Constant TASK_RUN_TYPE for TaskRunSortColumnType
        /// </summary>
        public static readonly TaskRunSortColumnType TASK_RUN_TYPE = new TaskRunSortColumnType("TASK_RUN_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskRunSortColumnType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskRunSortColumnType FindValue(string value)
        {
            return FindValue<TaskRunSortColumnType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskRunSortColumnType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskStatusType.
    /// </summary>
    public class TaskStatusType : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for TaskStatusType
        /// </summary>
        public static readonly TaskStatusType FAILED = new TaskStatusType("FAILED");
        /// <summary>
        /// Constant RUNNING for TaskStatusType
        /// </summary>
        public static readonly TaskStatusType RUNNING = new TaskStatusType("RUNNING");
        /// <summary>
        /// Constant STARTING for TaskStatusType
        /// </summary>
        public static readonly TaskStatusType STARTING = new TaskStatusType("STARTING");
        /// <summary>
        /// Constant STOPPED for TaskStatusType
        /// </summary>
        public static readonly TaskStatusType STOPPED = new TaskStatusType("STOPPED");
        /// <summary>
        /// Constant STOPPING for TaskStatusType
        /// </summary>
        public static readonly TaskStatusType STOPPING = new TaskStatusType("STOPPING");
        /// <summary>
        /// Constant SUCCEEDED for TaskStatusType
        /// </summary>
        public static readonly TaskStatusType SUCCEEDED = new TaskStatusType("SUCCEEDED");
        /// <summary>
        /// Constant TIMEOUT for TaskStatusType
        /// </summary>
        public static readonly TaskStatusType TIMEOUT = new TaskStatusType("TIMEOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskStatusType FindValue(string value)
        {
            return FindValue<TaskStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskType.
    /// </summary>
    public class TaskType : ConstantClass
    {

        /// <summary>
        /// Constant EVALUATION for TaskType
        /// </summary>
        public static readonly TaskType EVALUATION = new TaskType("EVALUATION");
        /// <summary>
        /// Constant EXPORT_LABELS for TaskType
        /// </summary>
        public static readonly TaskType EXPORT_LABELS = new TaskType("EXPORT_LABELS");
        /// <summary>
        /// Constant FIND_MATCHES for TaskType
        /// </summary>
        public static readonly TaskType FIND_MATCHES = new TaskType("FIND_MATCHES");
        /// <summary>
        /// Constant IMPORT_LABELS for TaskType
        /// </summary>
        public static readonly TaskType IMPORT_LABELS = new TaskType("IMPORT_LABELS");
        /// <summary>
        /// Constant LABELING_SET_GENERATION for TaskType
        /// </summary>
        public static readonly TaskType LABELING_SET_GENERATION = new TaskType("LABELING_SET_GENERATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskType FindValue(string value)
        {
            return FindValue<TaskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformSortColumnType.
    /// </summary>
    public class TransformSortColumnType : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for TransformSortColumnType
        /// </summary>
        public static readonly TransformSortColumnType CREATED = new TransformSortColumnType("CREATED");
        /// <summary>
        /// Constant LAST_MODIFIED for TransformSortColumnType
        /// </summary>
        public static readonly TransformSortColumnType LAST_MODIFIED = new TransformSortColumnType("LAST_MODIFIED");
        /// <summary>
        /// Constant NAME for TransformSortColumnType
        /// </summary>
        public static readonly TransformSortColumnType NAME = new TransformSortColumnType("NAME");
        /// <summary>
        /// Constant STATUS for TransformSortColumnType
        /// </summary>
        public static readonly TransformSortColumnType STATUS = new TransformSortColumnType("STATUS");
        /// <summary>
        /// Constant TRANSFORM_TYPE for TransformSortColumnType
        /// </summary>
        public static readonly TransformSortColumnType TRANSFORM_TYPE = new TransformSortColumnType("TRANSFORM_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformSortColumnType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformSortColumnType FindValue(string value)
        {
            return FindValue<TransformSortColumnType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformSortColumnType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformStatusType.
    /// </summary>
    public class TransformStatusType : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for TransformStatusType
        /// </summary>
        public static readonly TransformStatusType DELETING = new TransformStatusType("DELETING");
        /// <summary>
        /// Constant NOT_READY for TransformStatusType
        /// </summary>
        public static readonly TransformStatusType NOT_READY = new TransformStatusType("NOT_READY");
        /// <summary>
        /// Constant READY for TransformStatusType
        /// </summary>
        public static readonly TransformStatusType READY = new TransformStatusType("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformStatusType FindValue(string value)
        {
            return FindValue<TransformStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformType.
    /// </summary>
    public class TransformType : ConstantClass
    {

        /// <summary>
        /// Constant FIND_MATCHES for TransformType
        /// </summary>
        public static readonly TransformType FIND_MATCHES = new TransformType("FIND_MATCHES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformType FindValue(string value)
        {
            return FindValue<TransformType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TriggerState.
    /// </summary>
    public class TriggerState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for TriggerState
        /// </summary>
        public static readonly TriggerState ACTIVATED = new TriggerState("ACTIVATED");
        /// <summary>
        /// Constant ACTIVATING for TriggerState
        /// </summary>
        public static readonly TriggerState ACTIVATING = new TriggerState("ACTIVATING");
        /// <summary>
        /// Constant CREATED for TriggerState
        /// </summary>
        public static readonly TriggerState CREATED = new TriggerState("CREATED");
        /// <summary>
        /// Constant CREATING for TriggerState
        /// </summary>
        public static readonly TriggerState CREATING = new TriggerState("CREATING");
        /// <summary>
        /// Constant DEACTIVATED for TriggerState
        /// </summary>
        public static readonly TriggerState DEACTIVATED = new TriggerState("DEACTIVATED");
        /// <summary>
        /// Constant DEACTIVATING for TriggerState
        /// </summary>
        public static readonly TriggerState DEACTIVATING = new TriggerState("DEACTIVATING");
        /// <summary>
        /// Constant DELETING for TriggerState
        /// </summary>
        public static readonly TriggerState DELETING = new TriggerState("DELETING");
        /// <summary>
        /// Constant UPDATING for TriggerState
        /// </summary>
        public static readonly TriggerState UPDATING = new TriggerState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriggerState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriggerState FindValue(string value)
        {
            return FindValue<TriggerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriggerState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TriggerType.
    /// </summary>
    public class TriggerType : ConstantClass
    {

        /// <summary>
        /// Constant CONDITIONAL for TriggerType
        /// </summary>
        public static readonly TriggerType CONDITIONAL = new TriggerType("CONDITIONAL");
        /// <summary>
        /// Constant EVENT for TriggerType
        /// </summary>
        public static readonly TriggerType EVENT = new TriggerType("EVENT");
        /// <summary>
        /// Constant ON_DEMAND for TriggerType
        /// </summary>
        public static readonly TriggerType ON_DEMAND = new TriggerType("ON_DEMAND");
        /// <summary>
        /// Constant SCHEDULED for TriggerType
        /// </summary>
        public static readonly TriggerType SCHEDULED = new TriggerType("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriggerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriggerType FindValue(string value)
        {
            return FindValue<TriggerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriggerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UnionType.
    /// </summary>
    public class UnionType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for UnionType
        /// </summary>
        public static readonly UnionType ALL = new UnionType("ALL");
        /// <summary>
        /// Constant DISTINCT for UnionType
        /// </summary>
        public static readonly UnionType DISTINCT = new UnionType("DISTINCT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UnionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnionType FindValue(string value)
        {
            return FindValue<UnionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateBehavior.
    /// </summary>
    public class UpdateBehavior : ConstantClass
    {

        /// <summary>
        /// Constant LOG for UpdateBehavior
        /// </summary>
        public static readonly UpdateBehavior LOG = new UpdateBehavior("LOG");
        /// <summary>
        /// Constant UPDATE_IN_DATABASE for UpdateBehavior
        /// </summary>
        public static readonly UpdateBehavior UPDATE_IN_DATABASE = new UpdateBehavior("UPDATE_IN_DATABASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateBehavior FindValue(string value)
        {
            return FindValue<UpdateBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateCatalogBehavior.
    /// </summary>
    public class UpdateCatalogBehavior : ConstantClass
    {

        /// <summary>
        /// Constant LOG for UpdateCatalogBehavior
        /// </summary>
        public static readonly UpdateCatalogBehavior LOG = new UpdateCatalogBehavior("LOG");
        /// <summary>
        /// Constant UPDATE_IN_DATABASE for UpdateCatalogBehavior
        /// </summary>
        public static readonly UpdateCatalogBehavior UPDATE_IN_DATABASE = new UpdateCatalogBehavior("UPDATE_IN_DATABASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateCatalogBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateCatalogBehavior FindValue(string value)
        {
            return FindValue<UpdateCatalogBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateCatalogBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkerType.
    /// </summary>
    public class WorkerType : ConstantClass
    {

        /// <summary>
        /// Constant G025X for WorkerType
        /// </summary>
        public static readonly WorkerType G025X = new WorkerType("G.025X");
        /// <summary>
        /// Constant G1X for WorkerType
        /// </summary>
        public static readonly WorkerType G1X = new WorkerType("G.1X");
        /// <summary>
        /// Constant G2X for WorkerType
        /// </summary>
        public static readonly WorkerType G2X = new WorkerType("G.2X");
        /// <summary>
        /// Constant Standard for WorkerType
        /// </summary>
        public static readonly WorkerType Standard = new WorkerType("Standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkerType FindValue(string value)
        {
            return FindValue<WorkerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowRunStatus.
    /// </summary>
    public class WorkflowRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus COMPLETED = new WorkflowRunStatus("COMPLETED");
        /// <summary>
        /// Constant ERROR for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus ERROR = new WorkflowRunStatus("ERROR");
        /// <summary>
        /// Constant RUNNING for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus RUNNING = new WorkflowRunStatus("RUNNING");
        /// <summary>
        /// Constant STOPPED for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus STOPPED = new WorkflowRunStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus STOPPING = new WorkflowRunStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowRunStatus FindValue(string value)
        {
            return FindValue<WorkflowRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowRunStatus(string value)
        {
            return FindValue(value);
        }
    }

}