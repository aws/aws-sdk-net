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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.TimestreamWrite
{

    /// <summary>
    /// Constants used for properties of type BatchLoadDataFormat.
    /// </summary>
    public class BatchLoadDataFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for BatchLoadDataFormat
        /// </summary>
        public static readonly BatchLoadDataFormat CSV = new BatchLoadDataFormat("CSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchLoadDataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchLoadDataFormat FindValue(string value)
        {
            return FindValue<BatchLoadDataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchLoadDataFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchLoadStatus.
    /// </summary>
    public class BatchLoadStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for BatchLoadStatus
        /// </summary>
        public static readonly BatchLoadStatus CREATED = new BatchLoadStatus("CREATED");
        /// <summary>
        /// Constant FAILED for BatchLoadStatus
        /// </summary>
        public static readonly BatchLoadStatus FAILED = new BatchLoadStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for BatchLoadStatus
        /// </summary>
        public static readonly BatchLoadStatus IN_PROGRESS = new BatchLoadStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING_RESUME for BatchLoadStatus
        /// </summary>
        public static readonly BatchLoadStatus PENDING_RESUME = new BatchLoadStatus("PENDING_RESUME");
        /// <summary>
        /// Constant PROGRESS_STOPPED for BatchLoadStatus
        /// </summary>
        public static readonly BatchLoadStatus PROGRESS_STOPPED = new BatchLoadStatus("PROGRESS_STOPPED");
        /// <summary>
        /// Constant SUCCEEDED for BatchLoadStatus
        /// </summary>
        public static readonly BatchLoadStatus SUCCEEDED = new BatchLoadStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchLoadStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchLoadStatus FindValue(string value)
        {
            return FindValue<BatchLoadStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchLoadStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DimensionValueType.
    /// </summary>
    public class DimensionValueType : ConstantClass
    {

        /// <summary>
        /// Constant VARCHAR for DimensionValueType
        /// </summary>
        public static readonly DimensionValueType VARCHAR = new DimensionValueType("VARCHAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DimensionValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DimensionValueType FindValue(string value)
        {
            return FindValue<DimensionValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DimensionValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MeasureValueType.
    /// </summary>
    public class MeasureValueType : ConstantClass
    {

        /// <summary>
        /// Constant BIGINT for MeasureValueType
        /// </summary>
        public static readonly MeasureValueType BIGINT = new MeasureValueType("BIGINT");
        /// <summary>
        /// Constant BOOLEAN for MeasureValueType
        /// </summary>
        public static readonly MeasureValueType BOOLEAN = new MeasureValueType("BOOLEAN");
        /// <summary>
        /// Constant DOUBLE for MeasureValueType
        /// </summary>
        public static readonly MeasureValueType DOUBLE = new MeasureValueType("DOUBLE");
        /// <summary>
        /// Constant MULTI for MeasureValueType
        /// </summary>
        public static readonly MeasureValueType MULTI = new MeasureValueType("MULTI");
        /// <summary>
        /// Constant TIMESTAMP for MeasureValueType
        /// </summary>
        public static readonly MeasureValueType TIMESTAMP = new MeasureValueType("TIMESTAMP");
        /// <summary>
        /// Constant VARCHAR for MeasureValueType
        /// </summary>
        public static readonly MeasureValueType VARCHAR = new MeasureValueType("VARCHAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MeasureValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MeasureValueType FindValue(string value)
        {
            return FindValue<MeasureValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MeasureValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3EncryptionOption.
    /// </summary>
    public class S3EncryptionOption : ConstantClass
    {

        /// <summary>
        /// Constant SSE_KMS for S3EncryptionOption
        /// </summary>
        public static readonly S3EncryptionOption SSE_KMS = new S3EncryptionOption("SSE_KMS");
        /// <summary>
        /// Constant SSE_S3 for S3EncryptionOption
        /// </summary>
        public static readonly S3EncryptionOption SSE_S3 = new S3EncryptionOption("SSE_S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3EncryptionOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3EncryptionOption FindValue(string value)
        {
            return FindValue<S3EncryptionOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3EncryptionOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalarMeasureValueType.
    /// </summary>
    public class ScalarMeasureValueType : ConstantClass
    {

        /// <summary>
        /// Constant BIGINT for ScalarMeasureValueType
        /// </summary>
        public static readonly ScalarMeasureValueType BIGINT = new ScalarMeasureValueType("BIGINT");
        /// <summary>
        /// Constant BOOLEAN for ScalarMeasureValueType
        /// </summary>
        public static readonly ScalarMeasureValueType BOOLEAN = new ScalarMeasureValueType("BOOLEAN");
        /// <summary>
        /// Constant DOUBLE for ScalarMeasureValueType
        /// </summary>
        public static readonly ScalarMeasureValueType DOUBLE = new ScalarMeasureValueType("DOUBLE");
        /// <summary>
        /// Constant TIMESTAMP for ScalarMeasureValueType
        /// </summary>
        public static readonly ScalarMeasureValueType TIMESTAMP = new ScalarMeasureValueType("TIMESTAMP");
        /// <summary>
        /// Constant VARCHAR for ScalarMeasureValueType
        /// </summary>
        public static readonly ScalarMeasureValueType VARCHAR = new ScalarMeasureValueType("VARCHAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalarMeasureValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalarMeasureValueType FindValue(string value)
        {
            return FindValue<ScalarMeasureValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalarMeasureValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TableStatus.
    /// </summary>
    public class TableStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TableStatus
        /// </summary>
        public static readonly TableStatus ACTIVE = new TableStatus("ACTIVE");
        /// <summary>
        /// Constant DELETING for TableStatus
        /// </summary>
        public static readonly TableStatus DELETING = new TableStatus("DELETING");
        /// <summary>
        /// Constant RESTORING for TableStatus
        /// </summary>
        public static readonly TableStatus RESTORING = new TableStatus("RESTORING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableStatus FindValue(string value)
        {
            return FindValue<TableStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeUnit.
    /// </summary>
    public class TimeUnit : ConstantClass
    {

        /// <summary>
        /// Constant MICROSECONDS for TimeUnit
        /// </summary>
        public static readonly TimeUnit MICROSECONDS = new TimeUnit("MICROSECONDS");
        /// <summary>
        /// Constant MILLISECONDS for TimeUnit
        /// </summary>
        public static readonly TimeUnit MILLISECONDS = new TimeUnit("MILLISECONDS");
        /// <summary>
        /// Constant NANOSECONDS for TimeUnit
        /// </summary>
        public static readonly TimeUnit NANOSECONDS = new TimeUnit("NANOSECONDS");
        /// <summary>
        /// Constant SECONDS for TimeUnit
        /// </summary>
        public static readonly TimeUnit SECONDS = new TimeUnit("SECONDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeUnit FindValue(string value)
        {
            return FindValue<TimeUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeUnit(string value)
        {
            return FindValue(value);
        }
    }

}