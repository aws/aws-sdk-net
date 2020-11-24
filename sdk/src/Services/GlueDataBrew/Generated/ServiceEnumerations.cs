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

}