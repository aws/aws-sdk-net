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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudWatchEvidently
{

    /// <summary>
    /// Constants used for properties of type ChangeDirectionEnum.
    /// </summary>
    public class ChangeDirectionEnum : ConstantClass
    {

        /// <summary>
        /// Constant DECREASE for ChangeDirectionEnum
        /// </summary>
        public static readonly ChangeDirectionEnum DECREASE = new ChangeDirectionEnum("DECREASE");
        /// <summary>
        /// Constant INCREASE for ChangeDirectionEnum
        /// </summary>
        public static readonly ChangeDirectionEnum INCREASE = new ChangeDirectionEnum("INCREASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeDirectionEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeDirectionEnum FindValue(string value)
        {
            return FindValue<ChangeDirectionEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeDirectionEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant AwsEvidentlyCustom for EventType
        /// </summary>
        public static readonly EventType AwsEvidentlyCustom = new EventType("aws.evidently.custom");
        /// <summary>
        /// Constant AwsEvidentlyEvaluation for EventType
        /// </summary>
        public static readonly EventType AwsEvidentlyEvaluation = new EventType("aws.evidently.evaluation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExperimentBaseStat.
    /// </summary>
    public class ExperimentBaseStat : ConstantClass
    {

        /// <summary>
        /// Constant Mean for ExperimentBaseStat
        /// </summary>
        public static readonly ExperimentBaseStat Mean = new ExperimentBaseStat("Mean");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExperimentBaseStat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExperimentBaseStat FindValue(string value)
        {
            return FindValue<ExperimentBaseStat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExperimentBaseStat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExperimentReportName.
    /// </summary>
    public class ExperimentReportName : ConstantClass
    {

        /// <summary>
        /// Constant BayesianInference for ExperimentReportName
        /// </summary>
        public static readonly ExperimentReportName BayesianInference = new ExperimentReportName("BayesianInference");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExperimentReportName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExperimentReportName FindValue(string value)
        {
            return FindValue<ExperimentReportName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExperimentReportName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExperimentResultRequestType.
    /// </summary>
    public class ExperimentResultRequestType : ConstantClass
    {

        /// <summary>
        /// Constant BaseStat for ExperimentResultRequestType
        /// </summary>
        public static readonly ExperimentResultRequestType BaseStat = new ExperimentResultRequestType("BaseStat");
        /// <summary>
        /// Constant ConfidenceInterval for ExperimentResultRequestType
        /// </summary>
        public static readonly ExperimentResultRequestType ConfidenceInterval = new ExperimentResultRequestType("ConfidenceInterval");
        /// <summary>
        /// Constant PValue for ExperimentResultRequestType
        /// </summary>
        public static readonly ExperimentResultRequestType PValue = new ExperimentResultRequestType("PValue");
        /// <summary>
        /// Constant TreatmentEffect for ExperimentResultRequestType
        /// </summary>
        public static readonly ExperimentResultRequestType TreatmentEffect = new ExperimentResultRequestType("TreatmentEffect");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExperimentResultRequestType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExperimentResultRequestType FindValue(string value)
        {
            return FindValue<ExperimentResultRequestType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExperimentResultRequestType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExperimentResultResponseType.
    /// </summary>
    public class ExperimentResultResponseType : ConstantClass
    {

        /// <summary>
        /// Constant ConfidenceIntervalLowerBound for ExperimentResultResponseType
        /// </summary>
        public static readonly ExperimentResultResponseType ConfidenceIntervalLowerBound = new ExperimentResultResponseType("ConfidenceIntervalLowerBound");
        /// <summary>
        /// Constant ConfidenceIntervalUpperBound for ExperimentResultResponseType
        /// </summary>
        public static readonly ExperimentResultResponseType ConfidenceIntervalUpperBound = new ExperimentResultResponseType("ConfidenceIntervalUpperBound");
        /// <summary>
        /// Constant Mean for ExperimentResultResponseType
        /// </summary>
        public static readonly ExperimentResultResponseType Mean = new ExperimentResultResponseType("Mean");
        /// <summary>
        /// Constant PValue for ExperimentResultResponseType
        /// </summary>
        public static readonly ExperimentResultResponseType PValue = new ExperimentResultResponseType("PValue");
        /// <summary>
        /// Constant TreatmentEffect for ExperimentResultResponseType
        /// </summary>
        public static readonly ExperimentResultResponseType TreatmentEffect = new ExperimentResultResponseType("TreatmentEffect");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExperimentResultResponseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExperimentResultResponseType FindValue(string value)
        {
            return FindValue<ExperimentResultResponseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExperimentResultResponseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExperimentStatus.
    /// </summary>
    public class ExperimentStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus CANCELLED = new ExperimentStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus COMPLETED = new ExperimentStatus("COMPLETED");
        /// <summary>
        /// Constant CREATED for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus CREATED = new ExperimentStatus("CREATED");
        /// <summary>
        /// Constant RUNNING for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus RUNNING = new ExperimentStatus("RUNNING");
        /// <summary>
        /// Constant UPDATING for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus UPDATING = new ExperimentStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExperimentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExperimentStatus FindValue(string value)
        {
            return FindValue<ExperimentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExperimentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExperimentStopDesiredState.
    /// </summary>
    public class ExperimentStopDesiredState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ExperimentStopDesiredState
        /// </summary>
        public static readonly ExperimentStopDesiredState CANCELLED = new ExperimentStopDesiredState("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for ExperimentStopDesiredState
        /// </summary>
        public static readonly ExperimentStopDesiredState COMPLETED = new ExperimentStopDesiredState("COMPLETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExperimentStopDesiredState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExperimentStopDesiredState FindValue(string value)
        {
            return FindValue<ExperimentStopDesiredState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExperimentStopDesiredState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExperimentType.
    /// </summary>
    public class ExperimentType : ConstantClass
    {

        /// <summary>
        /// Constant AwsEvidentlyOnlineab for ExperimentType
        /// </summary>
        public static readonly ExperimentType AwsEvidentlyOnlineab = new ExperimentType("aws.evidently.onlineab");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExperimentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExperimentType FindValue(string value)
        {
            return FindValue<ExperimentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExperimentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureEvaluationStrategy.
    /// </summary>
    public class FeatureEvaluationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant ALL_RULES for FeatureEvaluationStrategy
        /// </summary>
        public static readonly FeatureEvaluationStrategy ALL_RULES = new FeatureEvaluationStrategy("ALL_RULES");
        /// <summary>
        /// Constant DEFAULT_VARIATION for FeatureEvaluationStrategy
        /// </summary>
        public static readonly FeatureEvaluationStrategy DEFAULT_VARIATION = new FeatureEvaluationStrategy("DEFAULT_VARIATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureEvaluationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureEvaluationStrategy FindValue(string value)
        {
            return FindValue<FeatureEvaluationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureEvaluationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureStatus.
    /// </summary>
    public class FeatureStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus AVAILABLE = new FeatureStatus("AVAILABLE");
        /// <summary>
        /// Constant UPDATING for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus UPDATING = new FeatureStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureStatus FindValue(string value)
        {
            return FindValue<FeatureStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchStatus.
    /// </summary>
    public class LaunchStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for LaunchStatus
        /// </summary>
        public static readonly LaunchStatus CANCELLED = new LaunchStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for LaunchStatus
        /// </summary>
        public static readonly LaunchStatus COMPLETED = new LaunchStatus("COMPLETED");
        /// <summary>
        /// Constant CREATED for LaunchStatus
        /// </summary>
        public static readonly LaunchStatus CREATED = new LaunchStatus("CREATED");
        /// <summary>
        /// Constant RUNNING for LaunchStatus
        /// </summary>
        public static readonly LaunchStatus RUNNING = new LaunchStatus("RUNNING");
        /// <summary>
        /// Constant UPDATING for LaunchStatus
        /// </summary>
        public static readonly LaunchStatus UPDATING = new LaunchStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchStatus FindValue(string value)
        {
            return FindValue<LaunchStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchStopDesiredState.
    /// </summary>
    public class LaunchStopDesiredState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for LaunchStopDesiredState
        /// </summary>
        public static readonly LaunchStopDesiredState CANCELLED = new LaunchStopDesiredState("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for LaunchStopDesiredState
        /// </summary>
        public static readonly LaunchStopDesiredState COMPLETED = new LaunchStopDesiredState("COMPLETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchStopDesiredState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchStopDesiredState FindValue(string value)
        {
            return FindValue<LaunchStopDesiredState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchStopDesiredState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchType.
    /// </summary>
    public class LaunchType : ConstantClass
    {

        /// <summary>
        /// Constant AwsEvidentlySplits for LaunchType
        /// </summary>
        public static readonly LaunchType AwsEvidentlySplits = new LaunchType("aws.evidently.splits");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchType FindValue(string value)
        {
            return FindValue<LaunchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProjectStatus.
    /// </summary>
    public class ProjectStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus AVAILABLE = new ProjectStatus("AVAILABLE");
        /// <summary>
        /// Constant UPDATING for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus UPDATING = new ProjectStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProjectStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectStatus FindValue(string value)
        {
            return FindValue<ProjectStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SegmentReferenceResourceType.
    /// </summary>
    public class SegmentReferenceResourceType : ConstantClass
    {

        /// <summary>
        /// Constant EXPERIMENT for SegmentReferenceResourceType
        /// </summary>
        public static readonly SegmentReferenceResourceType EXPERIMENT = new SegmentReferenceResourceType("EXPERIMENT");
        /// <summary>
        /// Constant LAUNCH for SegmentReferenceResourceType
        /// </summary>
        public static readonly SegmentReferenceResourceType LAUNCH = new SegmentReferenceResourceType("LAUNCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SegmentReferenceResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SegmentReferenceResourceType FindValue(string value)
        {
            return FindValue<SegmentReferenceResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SegmentReferenceResourceType(string value)
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


    /// <summary>
    /// Constants used for properties of type VariationValueType.
    /// </summary>
    public class VariationValueType : ConstantClass
    {

        /// <summary>
        /// Constant BOOLEAN for VariationValueType
        /// </summary>
        public static readonly VariationValueType BOOLEAN = new VariationValueType("BOOLEAN");
        /// <summary>
        /// Constant DOUBLE for VariationValueType
        /// </summary>
        public static readonly VariationValueType DOUBLE = new VariationValueType("DOUBLE");
        /// <summary>
        /// Constant LONG for VariationValueType
        /// </summary>
        public static readonly VariationValueType LONG = new VariationValueType("LONG");
        /// <summary>
        /// Constant STRING for VariationValueType
        /// </summary>
        public static readonly VariationValueType STRING = new VariationValueType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VariationValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VariationValueType FindValue(string value)
        {
            return FindValue<VariationValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VariationValueType(string value)
        {
            return FindValue(value);
        }
    }

}