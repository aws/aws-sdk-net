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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LookoutMetrics
{

    /// <summary>
    /// Constants used for properties of type AggregationFunction.
    /// </summary>
    public class AggregationFunction : ConstantClass
    {

        /// <summary>
        /// Constant AVG for AggregationFunction
        /// </summary>
        public static readonly AggregationFunction AVG = new AggregationFunction("AVG");
        /// <summary>
        /// Constant SUM for AggregationFunction
        /// </summary>
        public static readonly AggregationFunction SUM = new AggregationFunction("SUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregationFunction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregationFunction FindValue(string value)
        {
            return FindValue<AggregationFunction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregationFunction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlertStatus.
    /// </summary>
    public class AlertStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AlertStatus
        /// </summary>
        public static readonly AlertStatus ACTIVE = new AlertStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for AlertStatus
        /// </summary>
        public static readonly AlertStatus INACTIVE = new AlertStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlertStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlertStatus FindValue(string value)
        {
            return FindValue<AlertStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlertStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlertType.
    /// </summary>
    public class AlertType : ConstantClass
    {

        /// <summary>
        /// Constant LAMBDA for AlertType
        /// </summary>
        public static readonly AlertType LAMBDA = new AlertType("LAMBDA");
        /// <summary>
        /// Constant SNS for AlertType
        /// </summary>
        public static readonly AlertType SNS = new AlertType("SNS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlertType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlertType FindValue(string value)
        {
            return FindValue<AlertType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlertType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnomalyDetectionTaskStatus.
    /// </summary>
    public class AnomalyDetectionTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for AnomalyDetectionTaskStatus
        /// </summary>
        public static readonly AnomalyDetectionTaskStatus COMPLETED = new AnomalyDetectionTaskStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for AnomalyDetectionTaskStatus
        /// </summary>
        public static readonly AnomalyDetectionTaskStatus FAILED = new AnomalyDetectionTaskStatus("FAILED");
        /// <summary>
        /// Constant FAILED_TO_SCHEDULE for AnomalyDetectionTaskStatus
        /// </summary>
        public static readonly AnomalyDetectionTaskStatus FAILED_TO_SCHEDULE = new AnomalyDetectionTaskStatus("FAILED_TO_SCHEDULE");
        /// <summary>
        /// Constant IN_PROGRESS for AnomalyDetectionTaskStatus
        /// </summary>
        public static readonly AnomalyDetectionTaskStatus IN_PROGRESS = new AnomalyDetectionTaskStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for AnomalyDetectionTaskStatus
        /// </summary>
        public static readonly AnomalyDetectionTaskStatus PENDING = new AnomalyDetectionTaskStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnomalyDetectionTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnomalyDetectionTaskStatus FindValue(string value)
        {
            return FindValue<AnomalyDetectionTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnomalyDetectionTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnomalyDetectorStatus.
    /// </summary>
    public class AnomalyDetectorStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus ACTIVATING = new AnomalyDetectorStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus ACTIVE = new AnomalyDetectorStatus("ACTIVE");
        /// <summary>
        /// Constant BACK_TEST_ACTIVATING for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus BACK_TEST_ACTIVATING = new AnomalyDetectorStatus("BACK_TEST_ACTIVATING");
        /// <summary>
        /// Constant BACK_TEST_ACTIVE for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus BACK_TEST_ACTIVE = new AnomalyDetectorStatus("BACK_TEST_ACTIVE");
        /// <summary>
        /// Constant BACK_TEST_COMPLETE for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus BACK_TEST_COMPLETE = new AnomalyDetectorStatus("BACK_TEST_COMPLETE");
        /// <summary>
        /// Constant DELETING for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus DELETING = new AnomalyDetectorStatus("DELETING");
        /// <summary>
        /// Constant FAILED for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus FAILED = new AnomalyDetectorStatus("FAILED");
        /// <summary>
        /// Constant INACTIVE for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus INACTIVE = new AnomalyDetectorStatus("INACTIVE");
        /// <summary>
        /// Constant LEARNING for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus LEARNING = new AnomalyDetectorStatus("LEARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnomalyDetectorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnomalyDetectorStatus FindValue(string value)
        {
            return FindValue<AnomalyDetectorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnomalyDetectorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CSVFileCompression.
    /// </summary>
    public class CSVFileCompression : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for CSVFileCompression
        /// </summary>
        public static readonly CSVFileCompression GZIP = new CSVFileCompression("GZIP");
        /// <summary>
        /// Constant NONE for CSVFileCompression
        /// </summary>
        public static readonly CSVFileCompression NONE = new CSVFileCompression("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CSVFileCompression(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CSVFileCompression FindValue(string value)
        {
            return FindValue<CSVFileCompression>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CSVFileCompression(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Frequency.
    /// </summary>
    public class Frequency : ConstantClass
    {

        /// <summary>
        /// Constant P1D for Frequency
        /// </summary>
        public static readonly Frequency P1D = new Frequency("P1D");
        /// <summary>
        /// Constant PT10M for Frequency
        /// </summary>
        public static readonly Frequency PT10M = new Frequency("PT10M");
        /// <summary>
        /// Constant PT1H for Frequency
        /// </summary>
        public static readonly Frequency PT1H = new Frequency("PT1H");
        /// <summary>
        /// Constant PT5M for Frequency
        /// </summary>
        public static readonly Frequency PT5M = new Frequency("PT5M");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Frequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Frequency FindValue(string value)
        {
            return FindValue<Frequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Frequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JsonFileCompression.
    /// </summary>
    public class JsonFileCompression : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for JsonFileCompression
        /// </summary>
        public static readonly JsonFileCompression GZIP = new JsonFileCompression("GZIP");
        /// <summary>
        /// Constant NONE for JsonFileCompression
        /// </summary>
        public static readonly JsonFileCompression NONE = new JsonFileCompression("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JsonFileCompression(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JsonFileCompression FindValue(string value)
        {
            return FindValue<JsonFileCompression>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JsonFileCompression(string value)
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
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

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