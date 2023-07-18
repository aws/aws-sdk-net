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
    /// Constants used for properties of type AnomalyType.
    /// </summary>
    public class AnomalyType : ConstantClass
    {

        /// <summary>
        /// Constant CAUSAL for AnomalyType
        /// </summary>
        public static readonly AnomalyType CAUSAL = new AnomalyType("CAUSAL");
        /// <summary>
        /// Constant CONTEXTUAL for AnomalyType
        /// </summary>
        public static readonly AnomalyType CONTEXTUAL = new AnomalyType("CONTEXTUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnomalyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnomalyType FindValue(string value)
        {
            return FindValue<AnomalyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnomalyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloudWatchMetricDataStatusCode.
    /// </summary>
    public class CloudWatchMetricDataStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Complete for CloudWatchMetricDataStatusCode
        /// </summary>
        public static readonly CloudWatchMetricDataStatusCode Complete = new CloudWatchMetricDataStatusCode("Complete");
        /// <summary>
        /// Constant InternalError for CloudWatchMetricDataStatusCode
        /// </summary>
        public static readonly CloudWatchMetricDataStatusCode InternalError = new CloudWatchMetricDataStatusCode("InternalError");
        /// <summary>
        /// Constant PartialData for CloudWatchMetricDataStatusCode
        /// </summary>
        public static readonly CloudWatchMetricDataStatusCode PartialData = new CloudWatchMetricDataStatusCode("PartialData");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudWatchMetricDataStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudWatchMetricDataStatusCode FindValue(string value)
        {
            return FindValue<CloudWatchMetricDataStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudWatchMetricDataStatusCode(string value)
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
    /// Constants used for properties of type CostEstimationServiceResourceState.
    /// </summary>
    public class CostEstimationServiceResourceState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CostEstimationServiceResourceState
        /// </summary>
        public static readonly CostEstimationServiceResourceState ACTIVE = new CostEstimationServiceResourceState("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for CostEstimationServiceResourceState
        /// </summary>
        public static readonly CostEstimationServiceResourceState INACTIVE = new CostEstimationServiceResourceState("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostEstimationServiceResourceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostEstimationServiceResourceState FindValue(string value)
        {
            return FindValue<CostEstimationServiceResourceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostEstimationServiceResourceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CostEstimationStatus.
    /// </summary>
    public class CostEstimationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for CostEstimationStatus
        /// </summary>
        public static readonly CostEstimationStatus COMPLETED = new CostEstimationStatus("COMPLETED");
        /// <summary>
        /// Constant ONGOING for CostEstimationStatus
        /// </summary>
        public static readonly CostEstimationStatus ONGOING = new CostEstimationStatus("ONGOING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CostEstimationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CostEstimationStatus FindValue(string value)
        {
            return FindValue<CostEstimationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CostEstimationStatus(string value)
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
    /// Constants used for properties of type EventSourceOptInStatus.
    /// </summary>
    public class EventSourceOptInStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EventSourceOptInStatus
        /// </summary>
        public static readonly EventSourceOptInStatus DISABLED = new EventSourceOptInStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for EventSourceOptInStatus
        /// </summary>
        public static readonly EventSourceOptInStatus ENABLED = new EventSourceOptInStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSourceOptInStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSourceOptInStatus FindValue(string value)
        {
            return FindValue<EventSourceOptInStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSourceOptInStatus(string value)
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
    /// Constants used for properties of type Locale.
    /// </summary>
    public class Locale : ConstantClass
    {

        /// <summary>
        /// Constant DE_DE for Locale
        /// </summary>
        public static readonly Locale DE_DE = new Locale("DE_DE");
        /// <summary>
        /// Constant EN_GB for Locale
        /// </summary>
        public static readonly Locale EN_GB = new Locale("EN_GB");
        /// <summary>
        /// Constant EN_US for Locale
        /// </summary>
        public static readonly Locale EN_US = new Locale("EN_US");
        /// <summary>
        /// Constant ES_ES for Locale
        /// </summary>
        public static readonly Locale ES_ES = new Locale("ES_ES");
        /// <summary>
        /// Constant FR_FR for Locale
        /// </summary>
        public static readonly Locale FR_FR = new Locale("FR_FR");
        /// <summary>
        /// Constant IT_IT for Locale
        /// </summary>
        public static readonly Locale IT_IT = new Locale("IT_IT");
        /// <summary>
        /// Constant JA_JP for Locale
        /// </summary>
        public static readonly Locale JA_JP = new Locale("JA_JP");
        /// <summary>
        /// Constant KO_KR for Locale
        /// </summary>
        public static readonly Locale KO_KR = new Locale("KO_KR");
        /// <summary>
        /// Constant PT_BR for Locale
        /// </summary>
        public static readonly Locale PT_BR = new Locale("PT_BR");
        /// <summary>
        /// Constant ZH_CN for Locale
        /// </summary>
        public static readonly Locale ZH_CN = new Locale("ZH_CN");
        /// <summary>
        /// Constant ZH_TW for Locale
        /// </summary>
        public static readonly Locale ZH_TW = new Locale("ZH_TW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Locale(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Locale FindValue(string value)
        {
            return FindValue<Locale>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Locale(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogAnomalyType.
    /// </summary>
    public class LogAnomalyType : ConstantClass
    {

        /// <summary>
        /// Constant BLOCK_FORMAT for LogAnomalyType
        /// </summary>
        public static readonly LogAnomalyType BLOCK_FORMAT = new LogAnomalyType("BLOCK_FORMAT");
        /// <summary>
        /// Constant FORMAT for LogAnomalyType
        /// </summary>
        public static readonly LogAnomalyType FORMAT = new LogAnomalyType("FORMAT");
        /// <summary>
        /// Constant HTTP_CODE for LogAnomalyType
        /// </summary>
        public static readonly LogAnomalyType HTTP_CODE = new LogAnomalyType("HTTP_CODE");
        /// <summary>
        /// Constant KEYWORD for LogAnomalyType
        /// </summary>
        public static readonly LogAnomalyType KEYWORD = new LogAnomalyType("KEYWORD");
        /// <summary>
        /// Constant KEYWORD_TOKEN for LogAnomalyType
        /// </summary>
        public static readonly LogAnomalyType KEYWORD_TOKEN = new LogAnomalyType("KEYWORD_TOKEN");
        /// <summary>
        /// Constant NEW_FIELD_NAME for LogAnomalyType
        /// </summary>
        public static readonly LogAnomalyType NEW_FIELD_NAME = new LogAnomalyType("NEW_FIELD_NAME");
        /// <summary>
        /// Constant NUMERICAL_NAN for LogAnomalyType
        /// </summary>
        public static readonly LogAnomalyType NUMERICAL_NAN = new LogAnomalyType("NUMERICAL_NAN");
        /// <summary>
        /// Constant NUMERICAL_POINT for LogAnomalyType
        /// </summary>
        public static readonly LogAnomalyType NUMERICAL_POINT = new LogAnomalyType("NUMERICAL_POINT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogAnomalyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogAnomalyType FindValue(string value)
        {
            return FindValue<LogAnomalyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogAnomalyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationMessageType.
    /// </summary>
    public class NotificationMessageType : ConstantClass
    {

        /// <summary>
        /// Constant CLOSED_INSIGHT for NotificationMessageType
        /// </summary>
        public static readonly NotificationMessageType CLOSED_INSIGHT = new NotificationMessageType("CLOSED_INSIGHT");
        /// <summary>
        /// Constant NEW_ASSOCIATION for NotificationMessageType
        /// </summary>
        public static readonly NotificationMessageType NEW_ASSOCIATION = new NotificationMessageType("NEW_ASSOCIATION");
        /// <summary>
        /// Constant NEW_INSIGHT for NotificationMessageType
        /// </summary>
        public static readonly NotificationMessageType NEW_INSIGHT = new NotificationMessageType("NEW_INSIGHT");
        /// <summary>
        /// Constant NEW_RECOMMENDATION for NotificationMessageType
        /// </summary>
        public static readonly NotificationMessageType NEW_RECOMMENDATION = new NotificationMessageType("NEW_RECOMMENDATION");
        /// <summary>
        /// Constant SEVERITY_UPGRADED for NotificationMessageType
        /// </summary>
        public static readonly NotificationMessageType SEVERITY_UPGRADED = new NotificationMessageType("SEVERITY_UPGRADED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationMessageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationMessageType FindValue(string value)
        {
            return FindValue<NotificationMessageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationMessageType(string value)
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
    /// Constants used for properties of type OrganizationResourceCollectionType.
    /// </summary>
    public class OrganizationResourceCollectionType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_ACCOUNT for OrganizationResourceCollectionType
        /// </summary>
        public static readonly OrganizationResourceCollectionType AWS_ACCOUNT = new OrganizationResourceCollectionType("AWS_ACCOUNT");
        /// <summary>
        /// Constant AWS_CLOUD_FORMATION for OrganizationResourceCollectionType
        /// </summary>
        public static readonly OrganizationResourceCollectionType AWS_CLOUD_FORMATION = new OrganizationResourceCollectionType("AWS_CLOUD_FORMATION");
        /// <summary>
        /// Constant AWS_SERVICE for OrganizationResourceCollectionType
        /// </summary>
        public static readonly OrganizationResourceCollectionType AWS_SERVICE = new OrganizationResourceCollectionType("AWS_SERVICE");
        /// <summary>
        /// Constant AWS_TAGS for OrganizationResourceCollectionType
        /// </summary>
        public static readonly OrganizationResourceCollectionType AWS_TAGS = new OrganizationResourceCollectionType("AWS_TAGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationResourceCollectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationResourceCollectionType FindValue(string value)
        {
            return FindValue<OrganizationResourceCollectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationResourceCollectionType(string value)
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
        /// Constant AWS_SERVICE for ResourceCollectionType
        /// </summary>
        public static readonly ResourceCollectionType AWS_SERVICE = new ResourceCollectionType("AWS_SERVICE");
        /// <summary>
        /// Constant AWS_TAGS for ResourceCollectionType
        /// </summary>
        public static readonly ResourceCollectionType AWS_TAGS = new ResourceCollectionType("AWS_TAGS");

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
    /// Constants used for properties of type ResourcePermission.
    /// </summary>
    public class ResourcePermission : ConstantClass
    {

        /// <summary>
        /// Constant FULL_PERMISSION for ResourcePermission
        /// </summary>
        public static readonly ResourcePermission FULL_PERMISSION = new ResourcePermission("FULL_PERMISSION");
        /// <summary>
        /// Constant MISSING_PERMISSION for ResourcePermission
        /// </summary>
        public static readonly ResourcePermission MISSING_PERMISSION = new ResourcePermission("MISSING_PERMISSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourcePermission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourcePermission FindValue(string value)
        {
            return FindValue<ResourcePermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourcePermission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceTypeFilter.
    /// </summary>
    public class ResourceTypeFilter : ConstantClass
    {

        /// <summary>
        /// Constant CLOUDFRONT_DISTRIBUTION for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter CLOUDFRONT_DISTRIBUTION = new ResourceTypeFilter("CLOUDFRONT_DISTRIBUTION");
        /// <summary>
        /// Constant DYNAMODB_TABLE for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter DYNAMODB_TABLE = new ResourceTypeFilter("DYNAMODB_TABLE");
        /// <summary>
        /// Constant EC2_NAT_GATEWAY for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter EC2_NAT_GATEWAY = new ResourceTypeFilter("EC2_NAT_GATEWAY");
        /// <summary>
        /// Constant ECS_CLUSTER for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter ECS_CLUSTER = new ResourceTypeFilter("ECS_CLUSTER");
        /// <summary>
        /// Constant ECS_SERVICE for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter ECS_SERVICE = new ResourceTypeFilter("ECS_SERVICE");
        /// <summary>
        /// Constant EKS_CLUSTER for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter EKS_CLUSTER = new ResourceTypeFilter("EKS_CLUSTER");
        /// <summary>
        /// Constant ELASTIC_BEANSTALK_ENVIRONMENT for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter ELASTIC_BEANSTALK_ENVIRONMENT = new ResourceTypeFilter("ELASTIC_BEANSTALK_ENVIRONMENT");
        /// <summary>
        /// Constant ELASTIC_LOAD_BALANCER_LOAD_BALANCER for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter ELASTIC_LOAD_BALANCER_LOAD_BALANCER = new ResourceTypeFilter("ELASTIC_LOAD_BALANCER_LOAD_BALANCER");
        /// <summary>
        /// Constant ELASTIC_LOAD_BALANCING_V2_LOAD_BALANCER for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter ELASTIC_LOAD_BALANCING_V2_LOAD_BALANCER = new ResourceTypeFilter("ELASTIC_LOAD_BALANCING_V2_LOAD_BALANCER");
        /// <summary>
        /// Constant ELASTIC_LOAD_BALANCING_V2_TARGET_GROUP for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter ELASTIC_LOAD_BALANCING_V2_TARGET_GROUP = new ResourceTypeFilter("ELASTIC_LOAD_BALANCING_V2_TARGET_GROUP");
        /// <summary>
        /// Constant ELASTICACHE_CACHE_CLUSTER for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter ELASTICACHE_CACHE_CLUSTER = new ResourceTypeFilter("ELASTICACHE_CACHE_CLUSTER");
        /// <summary>
        /// Constant ELASTICSEARCH_DOMAIN for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter ELASTICSEARCH_DOMAIN = new ResourceTypeFilter("ELASTICSEARCH_DOMAIN");
        /// <summary>
        /// Constant KINESIS_STREAM for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter KINESIS_STREAM = new ResourceTypeFilter("KINESIS_STREAM");
        /// <summary>
        /// Constant LAMBDA_FUNCTION for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter LAMBDA_FUNCTION = new ResourceTypeFilter("LAMBDA_FUNCTION");
        /// <summary>
        /// Constant LOG_GROUPS for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter LOG_GROUPS = new ResourceTypeFilter("LOG_GROUPS");
        /// <summary>
        /// Constant OPEN_SEARCH_SERVICE_DOMAIN for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter OPEN_SEARCH_SERVICE_DOMAIN = new ResourceTypeFilter("OPEN_SEARCH_SERVICE_DOMAIN");
        /// <summary>
        /// Constant RDS_DB_CLUSTER for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter RDS_DB_CLUSTER = new ResourceTypeFilter("RDS_DB_CLUSTER");
        /// <summary>
        /// Constant RDS_DB_INSTANCE for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter RDS_DB_INSTANCE = new ResourceTypeFilter("RDS_DB_INSTANCE");
        /// <summary>
        /// Constant REDSHIFT_CLUSTER for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter REDSHIFT_CLUSTER = new ResourceTypeFilter("REDSHIFT_CLUSTER");
        /// <summary>
        /// Constant ROUTE53_HEALTH_CHECK for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter ROUTE53_HEALTH_CHECK = new ResourceTypeFilter("ROUTE53_HEALTH_CHECK");
        /// <summary>
        /// Constant ROUTE53_HOSTED_ZONE for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter ROUTE53_HOSTED_ZONE = new ResourceTypeFilter("ROUTE53_HOSTED_ZONE");
        /// <summary>
        /// Constant S3_BUCKET for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter S3_BUCKET = new ResourceTypeFilter("S3_BUCKET");
        /// <summary>
        /// Constant SAGEMAKER_ENDPOINT for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter SAGEMAKER_ENDPOINT = new ResourceTypeFilter("SAGEMAKER_ENDPOINT");
        /// <summary>
        /// Constant SNS_TOPIC for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter SNS_TOPIC = new ResourceTypeFilter("SNS_TOPIC");
        /// <summary>
        /// Constant SQS_QUEUE for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter SQS_QUEUE = new ResourceTypeFilter("SQS_QUEUE");
        /// <summary>
        /// Constant STEP_FUNCTIONS_ACTIVITY for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter STEP_FUNCTIONS_ACTIVITY = new ResourceTypeFilter("STEP_FUNCTIONS_ACTIVITY");
        /// <summary>
        /// Constant STEP_FUNCTIONS_STATE_MACHINE for ResourceTypeFilter
        /// </summary>
        public static readonly ResourceTypeFilter STEP_FUNCTIONS_STATE_MACHINE = new ResourceTypeFilter("STEP_FUNCTIONS_STATE_MACHINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceTypeFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceTypeFilter FindValue(string value)
        {
            return FindValue<ResourceTypeFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceTypeFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerSideEncryptionType.
    /// </summary>
    public class ServerSideEncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED_KMS_KEY for ServerSideEncryptionType
        /// </summary>
        public static readonly ServerSideEncryptionType AWS_OWNED_KMS_KEY = new ServerSideEncryptionType("AWS_OWNED_KMS_KEY");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_KEY for ServerSideEncryptionType
        /// </summary>
        public static readonly ServerSideEncryptionType CUSTOMER_MANAGED_KEY = new ServerSideEncryptionType("CUSTOMER_MANAGED_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerSideEncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerSideEncryptionType FindValue(string value)
        {
            return FindValue<ServerSideEncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerSideEncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceName.
    /// </summary>
    public class ServiceName : ConstantClass
    {

        /// <summary>
        /// Constant API_GATEWAY for ServiceName
        /// </summary>
        public static readonly ServiceName API_GATEWAY = new ServiceName("API_GATEWAY");
        /// <summary>
        /// Constant APPLICATION_ELB for ServiceName
        /// </summary>
        public static readonly ServiceName APPLICATION_ELB = new ServiceName("APPLICATION_ELB");
        /// <summary>
        /// Constant AUTO_SCALING_GROUP for ServiceName
        /// </summary>
        public static readonly ServiceName AUTO_SCALING_GROUP = new ServiceName("AUTO_SCALING_GROUP");
        /// <summary>
        /// Constant CLOUD_FRONT for ServiceName
        /// </summary>
        public static readonly ServiceName CLOUD_FRONT = new ServiceName("CLOUD_FRONT");
        /// <summary>
        /// Constant DYNAMO_DB for ServiceName
        /// </summary>
        public static readonly ServiceName DYNAMO_DB = new ServiceName("DYNAMO_DB");
        /// <summary>
        /// Constant EC2 for ServiceName
        /// </summary>
        public static readonly ServiceName EC2 = new ServiceName("EC2");
        /// <summary>
        /// Constant ECS for ServiceName
        /// </summary>
        public static readonly ServiceName ECS = new ServiceName("ECS");
        /// <summary>
        /// Constant EKS for ServiceName
        /// </summary>
        public static readonly ServiceName EKS = new ServiceName("EKS");
        /// <summary>
        /// Constant ELASTI_CACHE for ServiceName
        /// </summary>
        public static readonly ServiceName ELASTI_CACHE = new ServiceName("ELASTI_CACHE");
        /// <summary>
        /// Constant ELASTIC_BEANSTALK for ServiceName
        /// </summary>
        public static readonly ServiceName ELASTIC_BEANSTALK = new ServiceName("ELASTIC_BEANSTALK");
        /// <summary>
        /// Constant ELB for ServiceName
        /// </summary>
        public static readonly ServiceName ELB = new ServiceName("ELB");
        /// <summary>
        /// Constant ES for ServiceName
        /// </summary>
        public static readonly ServiceName ES = new ServiceName("ES");
        /// <summary>
        /// Constant KINESIS for ServiceName
        /// </summary>
        public static readonly ServiceName KINESIS = new ServiceName("KINESIS");
        /// <summary>
        /// Constant LAMBDA for ServiceName
        /// </summary>
        public static readonly ServiceName LAMBDA = new ServiceName("LAMBDA");
        /// <summary>
        /// Constant NAT_GATEWAY for ServiceName
        /// </summary>
        public static readonly ServiceName NAT_GATEWAY = new ServiceName("NAT_GATEWAY");
        /// <summary>
        /// Constant NETWORK_ELB for ServiceName
        /// </summary>
        public static readonly ServiceName NETWORK_ELB = new ServiceName("NETWORK_ELB");
        /// <summary>
        /// Constant RDS for ServiceName
        /// </summary>
        public static readonly ServiceName RDS = new ServiceName("RDS");
        /// <summary>
        /// Constant REDSHIFT for ServiceName
        /// </summary>
        public static readonly ServiceName REDSHIFT = new ServiceName("REDSHIFT");
        /// <summary>
        /// Constant ROUTE_53 for ServiceName
        /// </summary>
        public static readonly ServiceName ROUTE_53 = new ServiceName("ROUTE_53");
        /// <summary>
        /// Constant S3 for ServiceName
        /// </summary>
        public static readonly ServiceName S3 = new ServiceName("S3");
        /// <summary>
        /// Constant SAGE_MAKER for ServiceName
        /// </summary>
        public static readonly ServiceName SAGE_MAKER = new ServiceName("SAGE_MAKER");
        /// <summary>
        /// Constant SNS for ServiceName
        /// </summary>
        public static readonly ServiceName SNS = new ServiceName("SNS");
        /// <summary>
        /// Constant SQS for ServiceName
        /// </summary>
        public static readonly ServiceName SQS = new ServiceName("SQS");
        /// <summary>
        /// Constant STEP_FUNCTIONS for ServiceName
        /// </summary>
        public static readonly ServiceName STEP_FUNCTIONS = new ServiceName("STEP_FUNCTIONS");
        /// <summary>
        /// Constant SWF for ServiceName
        /// </summary>
        public static readonly ServiceName SWF = new ServiceName("SWF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceName FindValue(string value)
        {
            return FindValue<ServiceName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceName(string value)
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
        /// Constant INVALID_PARAMETER_COMBINATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_PARAMETER_COMBINATION = new ValidationExceptionReason("INVALID_PARAMETER_COMBINATION");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant PARAMETER_INCONSISTENT_WITH_SERVICE_STATE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason PARAMETER_INCONSISTENT_WITH_SERVICE_STATE = new ValidationExceptionReason("PARAMETER_INCONSISTENT_WITH_SERVICE_STATE");
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