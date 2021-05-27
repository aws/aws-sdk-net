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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoTEvents
{

    /// <summary>
    /// Constants used for properties of type AlarmModelVersionStatus.
    /// </summary>
    public class AlarmModelVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for AlarmModelVersionStatus
        /// </summary>
        public static readonly AlarmModelVersionStatus ACTIVATING = new AlarmModelVersionStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for AlarmModelVersionStatus
        /// </summary>
        public static readonly AlarmModelVersionStatus ACTIVE = new AlarmModelVersionStatus("ACTIVE");
        /// <summary>
        /// Constant FAILED for AlarmModelVersionStatus
        /// </summary>
        public static readonly AlarmModelVersionStatus FAILED = new AlarmModelVersionStatus("FAILED");
        /// <summary>
        /// Constant INACTIVE for AlarmModelVersionStatus
        /// </summary>
        public static readonly AlarmModelVersionStatus INACTIVE = new AlarmModelVersionStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlarmModelVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlarmModelVersionStatus FindValue(string value)
        {
            return FindValue<AlarmModelVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlarmModelVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalysisResultLevel.
    /// </summary>
    public class AnalysisResultLevel : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for AnalysisResultLevel
        /// </summary>
        public static readonly AnalysisResultLevel ERROR = new AnalysisResultLevel("ERROR");
        /// <summary>
        /// Constant INFO for AnalysisResultLevel
        /// </summary>
        public static readonly AnalysisResultLevel INFO = new AnalysisResultLevel("INFO");
        /// <summary>
        /// Constant WARNING for AnalysisResultLevel
        /// </summary>
        public static readonly AnalysisResultLevel WARNING = new AnalysisResultLevel("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisResultLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisResultLevel FindValue(string value)
        {
            return FindValue<AnalysisResultLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisResultLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalysisStatus.
    /// </summary>
    public class AnalysisStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for AnalysisStatus
        /// </summary>
        public static readonly AnalysisStatus COMPLETE = new AnalysisStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for AnalysisStatus
        /// </summary>
        public static readonly AnalysisStatus FAILED = new AnalysisStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for AnalysisStatus
        /// </summary>
        public static readonly AnalysisStatus RUNNING = new AnalysisStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisStatus FindValue(string value)
        {
            return FindValue<AnalysisStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator EQUAL = new ComparisonOperator("EQUAL");
        /// <summary>
        /// Constant GREATER for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GREATER = new ComparisonOperator("GREATER");
        /// <summary>
        /// Constant GREATER_OR_EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GREATER_OR_EQUAL = new ComparisonOperator("GREATER_OR_EQUAL");
        /// <summary>
        /// Constant LESS for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LESS = new ComparisonOperator("LESS");
        /// <summary>
        /// Constant LESS_OR_EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LESS_OR_EQUAL = new ComparisonOperator("LESS_OR_EQUAL");
        /// <summary>
        /// Constant NOT_EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NOT_EQUAL = new ComparisonOperator("NOT_EQUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperator FindValue(string value)
        {
            return FindValue<ComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetectorModelVersionStatus.
    /// </summary>
    public class DetectorModelVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus ACTIVATING = new DetectorModelVersionStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus ACTIVE = new DetectorModelVersionStatus("ACTIVE");
        /// <summary>
        /// Constant DEPRECATED for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus DEPRECATED = new DetectorModelVersionStatus("DEPRECATED");
        /// <summary>
        /// Constant DRAFT for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus DRAFT = new DetectorModelVersionStatus("DRAFT");
        /// <summary>
        /// Constant FAILED for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus FAILED = new DetectorModelVersionStatus("FAILED");
        /// <summary>
        /// Constant INACTIVE for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus INACTIVE = new DetectorModelVersionStatus("INACTIVE");
        /// <summary>
        /// Constant PAUSED for DetectorModelVersionStatus
        /// </summary>
        public static readonly DetectorModelVersionStatus PAUSED = new DetectorModelVersionStatus("PAUSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetectorModelVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetectorModelVersionStatus FindValue(string value)
        {
            return FindValue<DetectorModelVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetectorModelVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationMethod.
    /// </summary>
    public class EvaluationMethod : ConstantClass
    {

        /// <summary>
        /// Constant BATCH for EvaluationMethod
        /// </summary>
        public static readonly EvaluationMethod BATCH = new EvaluationMethod("BATCH");
        /// <summary>
        /// Constant SERIAL for EvaluationMethod
        /// </summary>
        public static readonly EvaluationMethod SERIAL = new EvaluationMethod("SERIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationMethod FindValue(string value)
        {
            return FindValue<EvaluationMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputStatus.
    /// </summary>
    public class InputStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for InputStatus
        /// </summary>
        public static readonly InputStatus ACTIVE = new InputStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for InputStatus
        /// </summary>
        public static readonly InputStatus CREATING = new InputStatus("CREATING");
        /// <summary>
        /// Constant DELETING for InputStatus
        /// </summary>
        public static readonly InputStatus DELETING = new InputStatus("DELETING");
        /// <summary>
        /// Constant UPDATING for InputStatus
        /// </summary>
        public static readonly InputStatus UPDATING = new InputStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputStatus FindValue(string value)
        {
            return FindValue<InputStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoggingLevel.
    /// </summary>
    public class LoggingLevel : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel DEBUG = new LoggingLevel("DEBUG");
        /// <summary>
        /// Constant ERROR for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel ERROR = new LoggingLevel("ERROR");
        /// <summary>
        /// Constant INFO for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel INFO = new LoggingLevel("INFO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoggingLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggingLevel FindValue(string value)
        {
            return FindValue<LoggingLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggingLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PayloadType.
    /// </summary>
    public class PayloadType : ConstantClass
    {

        /// <summary>
        /// Constant JSON for PayloadType
        /// </summary>
        public static readonly PayloadType JSON = new PayloadType("JSON");
        /// <summary>
        /// Constant STRING for PayloadType
        /// </summary>
        public static readonly PayloadType STRING = new PayloadType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PayloadType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PayloadType FindValue(string value)
        {
            return FindValue<PayloadType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PayloadType(string value)
        {
            return FindValue(value);
        }
    }

}