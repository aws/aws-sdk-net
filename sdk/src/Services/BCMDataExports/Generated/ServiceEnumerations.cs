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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BCMDataExports
{

    /// <summary>
    /// Constants used for properties of type CompressionOption.
    /// </summary>
    public class CompressionOption : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for CompressionOption
        /// </summary>
        public static readonly CompressionOption GZIP = new CompressionOption("GZIP");
        /// <summary>
        /// Constant PARQUET for CompressionOption
        /// </summary>
        public static readonly CompressionOption PARQUET = new CompressionOption("PARQUET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompressionOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompressionOption FindValue(string value)
        {
            return FindValue<CompressionOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompressionOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatusCode.
    /// </summary>
    public class ExecutionStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant DELIVERY_FAILURE for ExecutionStatusCode
        /// </summary>
        public static readonly ExecutionStatusCode DELIVERY_FAILURE = new ExecutionStatusCode("DELIVERY_FAILURE");
        /// <summary>
        /// Constant DELIVERY_IN_PROCESS for ExecutionStatusCode
        /// </summary>
        public static readonly ExecutionStatusCode DELIVERY_IN_PROCESS = new ExecutionStatusCode("DELIVERY_IN_PROCESS");
        /// <summary>
        /// Constant DELIVERY_SUCCESS for ExecutionStatusCode
        /// </summary>
        public static readonly ExecutionStatusCode DELIVERY_SUCCESS = new ExecutionStatusCode("DELIVERY_SUCCESS");
        /// <summary>
        /// Constant INITIATION_IN_PROCESS for ExecutionStatusCode
        /// </summary>
        public static readonly ExecutionStatusCode INITIATION_IN_PROCESS = new ExecutionStatusCode("INITIATION_IN_PROCESS");
        /// <summary>
        /// Constant QUERY_FAILURE for ExecutionStatusCode
        /// </summary>
        public static readonly ExecutionStatusCode QUERY_FAILURE = new ExecutionStatusCode("QUERY_FAILURE");
        /// <summary>
        /// Constant QUERY_IN_PROCESS for ExecutionStatusCode
        /// </summary>
        public static readonly ExecutionStatusCode QUERY_IN_PROCESS = new ExecutionStatusCode("QUERY_IN_PROCESS");
        /// <summary>
        /// Constant QUERY_QUEUED for ExecutionStatusCode
        /// </summary>
        public static readonly ExecutionStatusCode QUERY_QUEUED = new ExecutionStatusCode("QUERY_QUEUED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatusCode FindValue(string value)
        {
            return FindValue<ExecutionStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatusReason.
    /// </summary>
    public class ExecutionStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant BILL_OWNER_CHANGED for ExecutionStatusReason
        /// </summary>
        public static readonly ExecutionStatusReason BILL_OWNER_CHANGED = new ExecutionStatusReason("BILL_OWNER_CHANGED");
        /// <summary>
        /// Constant INSUFFICIENT_PERMISSION for ExecutionStatusReason
        /// </summary>
        public static readonly ExecutionStatusReason INSUFFICIENT_PERMISSION = new ExecutionStatusReason("INSUFFICIENT_PERMISSION");
        /// <summary>
        /// Constant INTERNAL_FAILURE for ExecutionStatusReason
        /// </summary>
        public static readonly ExecutionStatusReason INTERNAL_FAILURE = new ExecutionStatusReason("INTERNAL_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatusReason FindValue(string value)
        {
            return FindValue<ExecutionStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportStatusCode.
    /// </summary>
    public class ExportStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for ExportStatusCode
        /// </summary>
        public static readonly ExportStatusCode HEALTHY = new ExportStatusCode("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for ExportStatusCode
        /// </summary>
        public static readonly ExportStatusCode UNHEALTHY = new ExportStatusCode("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportStatusCode FindValue(string value)
        {
            return FindValue<ExportStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FormatOption.
    /// </summary>
    public class FormatOption : ConstantClass
    {

        /// <summary>
        /// Constant PARQUET for FormatOption
        /// </summary>
        public static readonly FormatOption PARQUET = new FormatOption("PARQUET");
        /// <summary>
        /// Constant TEXT_OR_CSV for FormatOption
        /// </summary>
        public static readonly FormatOption TEXT_OR_CSV = new FormatOption("TEXT_OR_CSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FormatOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FormatOption FindValue(string value)
        {
            return FindValue<FormatOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FormatOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FrequencyOption.
    /// </summary>
    public class FrequencyOption : ConstantClass
    {

        /// <summary>
        /// Constant SYNCHRONOUS for FrequencyOption
        /// </summary>
        public static readonly FrequencyOption SYNCHRONOUS = new FrequencyOption("SYNCHRONOUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FrequencyOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FrequencyOption FindValue(string value)
        {
            return FindValue<FrequencyOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FrequencyOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OverwriteOption.
    /// </summary>
    public class OverwriteOption : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_NEW_REPORT for OverwriteOption
        /// </summary>
        public static readonly OverwriteOption CREATE_NEW_REPORT = new OverwriteOption("CREATE_NEW_REPORT");
        /// <summary>
        /// Constant OVERWRITE_REPORT for OverwriteOption
        /// </summary>
        public static readonly OverwriteOption OVERWRITE_REPORT = new OverwriteOption("OVERWRITE_REPORT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OverwriteOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OverwriteOption FindValue(string value)
        {
            return FindValue<OverwriteOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OverwriteOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3OutputType.
    /// </summary>
    public class S3OutputType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for S3OutputType
        /// </summary>
        public static readonly S3OutputType CUSTOM = new S3OutputType("CUSTOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3OutputType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3OutputType FindValue(string value)
        {
            return FindValue<S3OutputType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3OutputType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}