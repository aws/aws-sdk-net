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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DevOpsGuru
{

    /// <summary>
    /// Constants used for properties of type AnomalySeverity.
    /// </summary>
    public class AnomalySeverity : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for AnomalySeverity
        /// </summary>
        public static readonly AnomalySeverity HIGH = new AnomalySeverity("HIGH");
        /// <summary>
        /// Constant LOW for AnomalySeverity
        /// </summary>
        public static readonly AnomalySeverity LOW = new AnomalySeverity("LOW");
        /// <summary>
        /// Constant MEDIUM for AnomalySeverity
        /// </summary>
        public static readonly AnomalySeverity MEDIUM = new AnomalySeverity("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnomalySeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnomalySeverity FindValue(string value)
        {
            return FindValue<AnomalySeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnomalySeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnomalyStatus.
    /// </summary>
    public class AnomalyStatus : ConstantClass
    {

        /// <summary>
        /// Constant CLOSED for AnomalyStatus
        /// </summary>
        public static readonly AnomalyStatus CLOSED = new AnomalyStatus("CLOSED");
        /// <summary>
        /// Constant ONGOING for AnomalyStatus
        /// </summary>
        public static readonly AnomalyStatus ONGOING = new AnomalyStatus("ONGOING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnomalyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnomalyStatus FindValue(string value)
        {
            return FindValue<AnomalyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnomalyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloudWatchMetricsStat.
    /// </summary>
    public class CloudWatchMetricsStat : ConstantClass
    {

        /// <summary>
        /// Constant Average for CloudWatchMetricsStat
        /// </summary>
        public static readonly CloudWatchMetricsStat Average = new CloudWatchMetricsStat("Average");
        /// <summary>
        /// Constant Maximum for CloudWatchMetricsStat
        /// </summary>
        public static readonly CloudWatchMetricsStat Maximum = new CloudWatchMetricsStat("Maximum");
        /// <summary>
        /// Constant Minimum for CloudWatchMetricsStat
        /// </summary>
        public static readonly CloudWatchMetricsStat Minimum = new CloudWatchMetricsStat("Minimum");
        /// <summary>
        /// Constant P50 for CloudWatchMetricsStat
        /// </summary>
        public static readonly CloudWatchMetricsStat P50 = new CloudWatchMetricsStat("p50");
        /// <summary>
        /// Constant P90 for CloudWatchMetricsStat
        /// </summary>
        public static readonly CloudWatchMetricsStat P90 = new CloudWatchMetricsStat("p90");
        /// <summary>
        /// Constant P99 for CloudWatchMetricsStat
        /// </summary>
        public static readonly CloudWatchMetricsStat P99 = new CloudWatchMetricsStat("p99");
        /// <summary>
        /// Constant SampleCount for CloudWatchMetricsStat
        /// </summary>
        public static readonly CloudWatchMetricsStat SampleCount = new CloudWatchMetricsStat("SampleCount");
        /// <summary>
        /// Constant Sum for CloudWatchMetricsStat
        /// </summary>
        public static readonly CloudWatchMetricsStat Sum = new CloudWatchMetricsStat("Sum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudWatchMetricsStat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudWatchMetricsStat FindValue(string value)
        {
            return FindValue<CloudWatchMetricsStat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudWatchMetricsStat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventClass.
    /// </summary>
    public class EventClass : ConstantClass
    {

        /// <summary>
        /// Constant CONFIG_CHANGE for EventClass
        /// </summary>
        public static readonly EventClass CONFIG_CHANGE = new EventClass("CONFIG_CHANGE");
        /// <summary>
        /// Constant DEPLOYMENT for EventClass
        /// </summary>
        public static readonly EventClass DEPLOYMENT = new EventClass("DEPLOYMENT");
        /// <summary>
        /// Constant INFRASTRUCTURE for EventClass
        /// </summary>
        public static readonly EventClass INFRASTRUCTURE = new EventClass("INFRASTRUCTURE");
        /// <summary>
        /// Constant SCHEMA_CHANGE for EventClass
        /// </summary>
        public static readonly EventClass SCHEMA_CHANGE = new EventClass("SCHEMA_CHANGE");
        /// <summary>
        /// Constant SECURITY_CHANGE for EventClass
        /// </summary>
        public static readonly EventClass SECURITY_CHANGE = new EventClass("SECURITY_CHANGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventClass FindValue(string value)
        {
            return FindValue<EventClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventDataSource.
    /// </summary>
    public class EventDataSource : ConstantClass
    {

        /// <summary>
        /// Constant AWS_CLOUD_TRAIL for EventDataSource
        /// </summary>
        public static readonly EventDataSource AWS_CLOUD_TRAIL = new EventDataSource("AWS_CLOUD_TRAIL");
        /// <summary>
        /// Constant AWS_CODE_DEPLOY for EventDataSource
        /// </summary>
        public static readonly EventDataSource AWS_CODE_DEPLOY = new EventDataSource("AWS_CODE_DEPLOY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventDataSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventDataSource FindValue(string value)
        {
            return FindValue<EventDataSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventDataSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InsightFeedbackOption.
    /// </summary>
    public class InsightFeedbackOption : ConstantClass
    {

        /// <summary>
        /// Constant ALERT_TOO_SENSITIVE for InsightFeedbackOption
        /// </summary>
        public static readonly InsightFeedbackOption ALERT_TOO_SENSITIVE = new InsightFeedbackOption("ALERT_TOO_SENSITIVE");
        /// <summary>
        /// Constant DATA_INCORRECT for InsightFeedbackOption
        /// </summary>
        public static readonly InsightFeedbackOption DATA_INCORRECT = new InsightFeedbackOption("DATA_INCORRECT");
        /// <summary>
        /// Constant DATA_NOISY_ANOMALY for InsightFeedbackOption
        /// </summary>
        public static readonly InsightFeedbackOption DATA_NOISY_ANOMALY = new InsightFeedbackOption("DATA_NOISY_ANOMALY");
        /// <summary>
        /// Constant RECOMMENDATION_USEFUL for InsightFeedbackOption
        /// </summary>
        public static readonly InsightFeedbackOption RECOMMENDATION_USEFUL = new InsightFeedbackOption("RECOMMENDATION_USEFUL");
        /// <summary>
        /// Constant VALID_COLLECTION for InsightFeedbackOption
        /// </summary>
        public static readonly InsightFeedbackOption VALID_COLLECTION = new InsightFeedbackOption("VALID_COLLECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsightFeedbackOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightFeedbackOption FindValue(string value)
        {
            return FindValue<InsightFeedbackOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightFeedbackOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InsightSeverity.
    /// </summary>
    public class InsightSeverity : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for InsightSeverity
        /// </summary>
        public static readonly InsightSeverity HIGH = new InsightSeverity("HIGH");
        /// <summary>
        /// Constant LOW for InsightSeverity
        /// </summary>
        public static readonly InsightSeverity LOW = new InsightSeverity("LOW");
        /// <summary>
        /// Constant MEDIUM for InsightSeverity
        /// </summary>
        public static readonly InsightSeverity MEDIUM = new InsightSeverity("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsightSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightSeverity FindValue(string value)
        {
            return FindValue<InsightSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InsightStatus.
    /// </summary>
    public class InsightStatus : ConstantClass
    {

        /// <summary>
        /// Constant CLOSED for InsightStatus
        /// </summary>
        public static readonly InsightStatus CLOSED = new InsightStatus("CLOSED");
        /// <summary>
        /// Constant ONGOING for InsightStatus
        /// </summary>
        public static readonly InsightStatus ONGOING = new InsightStatus("ONGOING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsightStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightStatus FindValue(string value)
        {
            return FindValue<InsightStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InsightType.
    /// </summary>
    public class InsightType : ConstantClass
    {

        /// <summary>
        /// Constant PROACTIVE for InsightType
        /// </summary>
        public static readonly InsightType PROACTIVE = new InsightType("PROACTIVE");
        /// <summary>
        /// Constant REACTIVE for InsightType
        /// </summary>
        public static readonly InsightType REACTIVE = new InsightType("REACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsightType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightType FindValue(string value)
        {
            return FindValue<InsightType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OptInStatus.
    /// </summary>
    public class OptInStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for OptInStatus
        /// </summary>
        public static readonly OptInStatus DISABLED = new OptInStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for OptInStatus
        /// </summary>
        public static readonly OptInStatus ENABLED = new OptInStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OptInStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OptInStatus FindValue(string value)
        {
            return FindValue<OptInStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OptInStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceCollectionType.
    /// </summary>
    public class ResourceCollectionType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_CLOUD_FORMATION for ResourceCollectionType
        /// </summary>
        public static readonly ResourceCollectionType AWS_CLOUD_FORMATION = new ResourceCollectionType("AWS_CLOUD_FORMATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceCollectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceCollectionType FindValue(string value)
        {
            return FindValue<ResourceCollectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceCollectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateResourceCollectionAction.
    /// </summary>
    public class UpdateResourceCollectionAction : ConstantClass
    {

        /// <summary>
        /// Constant ADD for UpdateResourceCollectionAction
        /// </summary>
        public static readonly UpdateResourceCollectionAction ADD = new UpdateResourceCollectionAction("ADD");
        /// <summary>
        /// Constant REMOVE for UpdateResourceCollectionAction
        /// </summary>
        public static readonly UpdateResourceCollectionAction REMOVE = new UpdateResourceCollectionAction("REMOVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateResourceCollectionAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateResourceCollectionAction FindValue(string value)
        {
            return FindValue<UpdateResourceCollectionAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateResourceCollectionAction(string value)
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