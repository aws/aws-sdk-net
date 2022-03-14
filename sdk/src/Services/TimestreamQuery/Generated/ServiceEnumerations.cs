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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.TimestreamQuery
{

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
    /// Constants used for properties of type ScalarType.
    /// </summary>
    public class ScalarType : ConstantClass
    {

        /// <summary>
        /// Constant BIGINT for ScalarType
        /// </summary>
        public static readonly ScalarType BIGINT = new ScalarType("BIGINT");
        /// <summary>
        /// Constant BOOLEAN for ScalarType
        /// </summary>
        public static readonly ScalarType BOOLEAN = new ScalarType("BOOLEAN");
        /// <summary>
        /// Constant DATE for ScalarType
        /// </summary>
        public static readonly ScalarType DATE = new ScalarType("DATE");
        /// <summary>
        /// Constant DOUBLE for ScalarType
        /// </summary>
        public static readonly ScalarType DOUBLE = new ScalarType("DOUBLE");
        /// <summary>
        /// Constant INTEGER for ScalarType
        /// </summary>
        public static readonly ScalarType INTEGER = new ScalarType("INTEGER");
        /// <summary>
        /// Constant INTERVAL_DAY_TO_SECOND for ScalarType
        /// </summary>
        public static readonly ScalarType INTERVAL_DAY_TO_SECOND = new ScalarType("INTERVAL_DAY_TO_SECOND");
        /// <summary>
        /// Constant INTERVAL_YEAR_TO_MONTH for ScalarType
        /// </summary>
        public static readonly ScalarType INTERVAL_YEAR_TO_MONTH = new ScalarType("INTERVAL_YEAR_TO_MONTH");
        /// <summary>
        /// Constant TIME for ScalarType
        /// </summary>
        public static readonly ScalarType TIME = new ScalarType("TIME");
        /// <summary>
        /// Constant TIMESTAMP for ScalarType
        /// </summary>
        public static readonly ScalarType TIMESTAMP = new ScalarType("TIMESTAMP");
        /// <summary>
        /// Constant UNKNOWN for ScalarType
        /// </summary>
        public static readonly ScalarType UNKNOWN = new ScalarType("UNKNOWN");
        /// <summary>
        /// Constant VARCHAR for ScalarType
        /// </summary>
        public static readonly ScalarType VARCHAR = new ScalarType("VARCHAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalarType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalarType FindValue(string value)
        {
            return FindValue<ScalarType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalarType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduledQueryRunStatus.
    /// </summary>
    public class ScheduledQueryRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant AUTO_TRIGGER_FAILURE for ScheduledQueryRunStatus
        /// </summary>
        public static readonly ScheduledQueryRunStatus AUTO_TRIGGER_FAILURE = new ScheduledQueryRunStatus("AUTO_TRIGGER_FAILURE");
        /// <summary>
        /// Constant AUTO_TRIGGER_SUCCESS for ScheduledQueryRunStatus
        /// </summary>
        public static readonly ScheduledQueryRunStatus AUTO_TRIGGER_SUCCESS = new ScheduledQueryRunStatus("AUTO_TRIGGER_SUCCESS");
        /// <summary>
        /// Constant MANUAL_TRIGGER_FAILURE for ScheduledQueryRunStatus
        /// </summary>
        public static readonly ScheduledQueryRunStatus MANUAL_TRIGGER_FAILURE = new ScheduledQueryRunStatus("MANUAL_TRIGGER_FAILURE");
        /// <summary>
        /// Constant MANUAL_TRIGGER_SUCCESS for ScheduledQueryRunStatus
        /// </summary>
        public static readonly ScheduledQueryRunStatus MANUAL_TRIGGER_SUCCESS = new ScheduledQueryRunStatus("MANUAL_TRIGGER_SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduledQueryRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduledQueryRunStatus FindValue(string value)
        {
            return FindValue<ScheduledQueryRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduledQueryRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduledQueryState.
    /// </summary>
    public class ScheduledQueryState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ScheduledQueryState
        /// </summary>
        public static readonly ScheduledQueryState DISABLED = new ScheduledQueryState("DISABLED");
        /// <summary>
        /// Constant ENABLED for ScheduledQueryState
        /// </summary>
        public static readonly ScheduledQueryState ENABLED = new ScheduledQueryState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduledQueryState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduledQueryState FindValue(string value)
        {
            return FindValue<ScheduledQueryState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduledQueryState(string value)
        {
            return FindValue(value);
        }
    }

}