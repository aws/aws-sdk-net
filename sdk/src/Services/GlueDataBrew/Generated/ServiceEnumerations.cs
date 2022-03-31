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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GlueDataBrew
{

    /// <summary>
    /// Constants used for properties of type AnalyticsMode.
    /// </summary>
    public class AnalyticsMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE for AnalyticsMode
        /// </summary>
        public static readonly AnalyticsMode DISABLE = new AnalyticsMode("DISABLE");
        /// <summary>
        /// Constant ENABLE for AnalyticsMode
        /// </summary>
        public static readonly AnalyticsMode ENABLE = new AnalyticsMode("ENABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsMode FindValue(string value)
        {
            return FindValue<AnalyticsMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsMode(string value)
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
        /// Constant BROTLI for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat BROTLI = new CompressionFormat("BROTLI");
        /// <summary>
        /// Constant BZIP2 for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat BZIP2 = new CompressionFormat("BZIP2");
        /// <summary>
        /// Constant DEFLATE for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat DEFLATE = new CompressionFormat("DEFLATE");
        /// <summary>
        /// Constant GZIP for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat GZIP = new CompressionFormat("GZIP");
        /// <summary>
        /// Constant LZ4 for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat LZ4 = new CompressionFormat("LZ4");
        /// <summary>
        /// Constant LZO for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat LZO = new CompressionFormat("LZO");
        /// <summary>
        /// Constant SNAPPY for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat SNAPPY = new CompressionFormat("SNAPPY");
        /// <summary>
        /// Constant ZLIB for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat ZLIB = new CompressionFormat("ZLIB");
        /// <summary>
        /// Constant ZSTD for CompressionFormat
        /// </summary>
        public static readonly CompressionFormat ZSTD = new CompressionFormat("ZSTD");

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
    /// Constants used for properties of type DatabaseOutputMode.
    /// </summary>
    public class DatabaseOutputMode : ConstantClass
    {

        /// <summary>
        /// Constant NEW_TABLE for DatabaseOutputMode
        /// </summary>
        public static readonly DatabaseOutputMode NEW_TABLE = new DatabaseOutputMode("NEW_TABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatabaseOutputMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatabaseOutputMode FindValue(string value)
        {
            return FindValue<DatabaseOutputMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatabaseOutputMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionMode.
    /// </summary>
    public class EncryptionMode : ConstantClass
    {

        /// <summary>
        /// Constant SSEKMS for EncryptionMode
        /// </summary>
        public static readonly EncryptionMode SSEKMS = new EncryptionMode("SSE-KMS");
        /// <summary>
        /// Constant SSES3 for EncryptionMode
        /// </summary>
        public static readonly EncryptionMode SSES3 = new EncryptionMode("SSE-S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionMode FindValue(string value)
        {
            return FindValue<EncryptionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputFormat.
    /// </summary>
    public class InputFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for InputFormat
        /// </summary>
        public static readonly InputFormat CSV = new InputFormat("CSV");
        /// <summary>
        /// Constant EXCEL for InputFormat
        /// </summary>
        public static readonly InputFormat EXCEL = new InputFormat("EXCEL");
        /// <summary>
        /// Constant JSON for InputFormat
        /// </summary>
        public static readonly InputFormat JSON = new InputFormat("JSON");
        /// <summary>
        /// Constant ORC for InputFormat
        /// </summary>
        public static readonly InputFormat ORC = new InputFormat("ORC");
        /// <summary>
        /// Constant PARQUET for InputFormat
        /// </summary>
        public static readonly InputFormat PARQUET = new InputFormat("PARQUET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputFormat FindValue(string value)
        {
            return FindValue<InputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputFormat(string value)
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
    /// Constants used for properties of type JobType.
    /// </summary>
    public class JobType : ConstantClass
    {

        /// <summary>
        /// Constant PROFILE for JobType
        /// </summary>
        public static readonly JobType PROFILE = new JobType("PROFILE");
        /// <summary>
        /// Constant RECIPE for JobType
        /// </summary>
        public static readonly JobType RECIPE = new JobType("RECIPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobType FindValue(string value)
        {
            return FindValue<JobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogSubscription.
    /// </summary>
    public class LogSubscription : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE for LogSubscription
        /// </summary>
        public static readonly LogSubscription DISABLE = new LogSubscription("DISABLE");
        /// <summary>
        /// Constant ENABLE for LogSubscription
        /// </summary>
        public static readonly LogSubscription ENABLE = new LogSubscription("ENABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogSubscription(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogSubscription FindValue(string value)
        {
            return FindValue<LogSubscription>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogSubscription(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Order.
    /// </summary>
    public class Order : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for Order
        /// </summary>
        public static readonly Order ASCENDING = new Order("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for Order
        /// </summary>
        public static readonly Order DESCENDING = new Order("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Order(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Order FindValue(string value)
        {
            return FindValue<Order>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Order(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderedBy.
    /// </summary>
    public class OrderedBy : ConstantClass
    {

        /// <summary>
        /// Constant LAST_MODIFIED_DATE for OrderedBy
        /// </summary>
        public static readonly OrderedBy LAST_MODIFIED_DATE = new OrderedBy("LAST_MODIFIED_DATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderedBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderedBy FindValue(string value)
        {
            return FindValue<OrderedBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderedBy(string value)
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
        /// Constant AVRO for OutputFormat
        /// </summary>
        public static readonly OutputFormat AVRO = new OutputFormat("AVRO");
        /// <summary>
        /// Constant CSV for OutputFormat
        /// </summary>
        public static readonly OutputFormat CSV = new OutputFormat("CSV");
        /// <summary>
        /// Constant GLUEPARQUET for OutputFormat
        /// </summary>
        public static readonly OutputFormat GLUEPARQUET = new OutputFormat("GLUEPARQUET");
        /// <summary>
        /// Constant JSON for OutputFormat
        /// </summary>
        public static readonly OutputFormat JSON = new OutputFormat("JSON");
        /// <summary>
        /// Constant ORC for OutputFormat
        /// </summary>
        public static readonly OutputFormat ORC = new OutputFormat("ORC");
        /// <summary>
        /// Constant PARQUET for OutputFormat
        /// </summary>
        public static readonly OutputFormat PARQUET = new OutputFormat("PARQUET");
        /// <summary>
        /// Constant TABLEAUHYPER for OutputFormat
        /// </summary>
        public static readonly OutputFormat TABLEAUHYPER = new OutputFormat("TABLEAUHYPER");
        /// <summary>
        /// Constant XML for OutputFormat
        /// </summary>
        public static readonly OutputFormat XML = new OutputFormat("XML");

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
    /// Constants used for properties of type ParameterType.
    /// </summary>
    public class ParameterType : ConstantClass
    {

        /// <summary>
        /// Constant Datetime for ParameterType
        /// </summary>
        public static readonly ParameterType Datetime = new ParameterType("Datetime");
        /// <summary>
        /// Constant Number for ParameterType
        /// </summary>
        public static readonly ParameterType Number = new ParameterType("Number");
        /// <summary>
        /// Constant String for ParameterType
        /// </summary>
        public static readonly ParameterType String = new ParameterType("String");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterType FindValue(string value)
        {
            return FindValue<ParameterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SampleMode.
    /// </summary>
    public class SampleMode : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM_ROWS for SampleMode
        /// </summary>
        public static readonly SampleMode CUSTOM_ROWS = new SampleMode("CUSTOM_ROWS");
        /// <summary>
        /// Constant FULL_DATASET for SampleMode
        /// </summary>
        public static readonly SampleMode FULL_DATASET = new SampleMode("FULL_DATASET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SampleMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SampleMode FindValue(string value)
        {
            return FindValue<SampleMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SampleMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SampleType.
    /// </summary>
    public class SampleType : ConstantClass
    {

        /// <summary>
        /// Constant FIRST_N for SampleType
        /// </summary>
        public static readonly SampleType FIRST_N = new SampleType("FIRST_N");
        /// <summary>
        /// Constant LAST_N for SampleType
        /// </summary>
        public static readonly SampleType LAST_N = new SampleType("LAST_N");
        /// <summary>
        /// Constant RANDOM for SampleType
        /// </summary>
        public static readonly SampleType RANDOM = new SampleType("RANDOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SampleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SampleType FindValue(string value)
        {
            return FindValue<SampleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SampleType(string value)
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
        /// Constant ASSIGNED for SessionStatus
        /// </summary>
        public static readonly SessionStatus ASSIGNED = new SessionStatus("ASSIGNED");
        /// <summary>
        /// Constant FAILED for SessionStatus
        /// </summary>
        public static readonly SessionStatus FAILED = new SessionStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZING for SessionStatus
        /// </summary>
        public static readonly SessionStatus INITIALIZING = new SessionStatus("INITIALIZING");
        /// <summary>
        /// Constant PROVISIONING for SessionStatus
        /// </summary>
        public static readonly SessionStatus PROVISIONING = new SessionStatus("PROVISIONING");
        /// <summary>
        /// Constant READY for SessionStatus
        /// </summary>
        public static readonly SessionStatus READY = new SessionStatus("READY");
        /// <summary>
        /// Constant RECYCLING for SessionStatus
        /// </summary>
        public static readonly SessionStatus RECYCLING = new SessionStatus("RECYCLING");
        /// <summary>
        /// Constant ROTATING for SessionStatus
        /// </summary>
        public static readonly SessionStatus ROTATING = new SessionStatus("ROTATING");
        /// <summary>
        /// Constant TERMINATED for SessionStatus
        /// </summary>
        public static readonly SessionStatus TERMINATED = new SessionStatus("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for SessionStatus
        /// </summary>
        public static readonly SessionStatus TERMINATING = new SessionStatus("TERMINATING");
        /// <summary>
        /// Constant UPDATING for SessionStatus
        /// </summary>
        public static readonly SessionStatus UPDATING = new SessionStatus("UPDATING");

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
    /// Constants used for properties of type Source.
    /// </summary>
    public class Source : ConstantClass
    {

        /// <summary>
        /// Constant DATABASE for Source
        /// </summary>
        public static readonly Source DATABASE = new Source("DATABASE");
        /// <summary>
        /// Constant DATACATALOG for Source
        /// </summary>
        public static readonly Source DATACATALOG = new Source("DATA-CATALOG");
        /// <summary>
        /// Constant S3 for Source
        /// </summary>
        public static readonly Source S3 = new Source("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Source(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Source FindValue(string value)
        {
            return FindValue<Source>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Source(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThresholdType.
    /// </summary>
    public class ThresholdType : ConstantClass
    {

        /// <summary>
        /// Constant GREATER_THAN for ThresholdType
        /// </summary>
        public static readonly ThresholdType GREATER_THAN = new ThresholdType("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL for ThresholdType
        /// </summary>
        public static readonly ThresholdType GREATER_THAN_OR_EQUAL = new ThresholdType("GREATER_THAN_OR_EQUAL");
        /// <summary>
        /// Constant LESS_THAN for ThresholdType
        /// </summary>
        public static readonly ThresholdType LESS_THAN = new ThresholdType("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL for ThresholdType
        /// </summary>
        public static readonly ThresholdType LESS_THAN_OR_EQUAL = new ThresholdType("LESS_THAN_OR_EQUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThresholdType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThresholdType FindValue(string value)
        {
            return FindValue<ThresholdType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThresholdType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThresholdUnit.
    /// </summary>
    public class ThresholdUnit : ConstantClass
    {

        /// <summary>
        /// Constant COUNT for ThresholdUnit
        /// </summary>
        public static readonly ThresholdUnit COUNT = new ThresholdUnit("COUNT");
        /// <summary>
        /// Constant PERCENTAGE for ThresholdUnit
        /// </summary>
        public static readonly ThresholdUnit PERCENTAGE = new ThresholdUnit("PERCENTAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThresholdUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThresholdUnit FindValue(string value)
        {
            return FindValue<ThresholdUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThresholdUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationMode.
    /// </summary>
    public class ValidationMode : ConstantClass
    {

        /// <summary>
        /// Constant CHECK_ALL for ValidationMode
        /// </summary>
        public static readonly ValidationMode CHECK_ALL = new ValidationMode("CHECK_ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationMode FindValue(string value)
        {
            return FindValue<ValidationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationMode(string value)
        {
            return FindValue(value);
        }
    }

}