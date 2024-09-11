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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LexModelsV2
{

    /// <summary>
    /// Constants used for properties of type AggregatedUtterancesFilterName.
    /// </summary>
    public class AggregatedUtterancesFilterName : ConstantClass
    {

        /// <summary>
        /// Constant Utterance for AggregatedUtterancesFilterName
        /// </summary>
        public static readonly AggregatedUtterancesFilterName Utterance = new AggregatedUtterancesFilterName("Utterance");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregatedUtterancesFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregatedUtterancesFilterName FindValue(string value)
        {
            return FindValue<AggregatedUtterancesFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregatedUtterancesFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AggregatedUtterancesFilterOperator.
    /// </summary>
    public class AggregatedUtterancesFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant CO for AggregatedUtterancesFilterOperator
        /// </summary>
        public static readonly AggregatedUtterancesFilterOperator CO = new AggregatedUtterancesFilterOperator("CO");
        /// <summary>
        /// Constant EQ for AggregatedUtterancesFilterOperator
        /// </summary>
        public static readonly AggregatedUtterancesFilterOperator EQ = new AggregatedUtterancesFilterOperator("EQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregatedUtterancesFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregatedUtterancesFilterOperator FindValue(string value)
        {
            return FindValue<AggregatedUtterancesFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregatedUtterancesFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AggregatedUtterancesSortAttribute.
    /// </summary>
    public class AggregatedUtterancesSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant HitCount for AggregatedUtterancesSortAttribute
        /// </summary>
        public static readonly AggregatedUtterancesSortAttribute HitCount = new AggregatedUtterancesSortAttribute("HitCount");
        /// <summary>
        /// Constant MissedCount for AggregatedUtterancesSortAttribute
        /// </summary>
        public static readonly AggregatedUtterancesSortAttribute MissedCount = new AggregatedUtterancesSortAttribute("MissedCount");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregatedUtterancesSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregatedUtterancesSortAttribute FindValue(string value)
        {
            return FindValue<AggregatedUtterancesSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregatedUtterancesSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsBinByName.
    /// </summary>
    public class AnalyticsBinByName : ConstantClass
    {

        /// <summary>
        /// Constant ConversationStartTime for AnalyticsBinByName
        /// </summary>
        public static readonly AnalyticsBinByName ConversationStartTime = new AnalyticsBinByName("ConversationStartTime");
        /// <summary>
        /// Constant UtteranceTimestamp for AnalyticsBinByName
        /// </summary>
        public static readonly AnalyticsBinByName UtteranceTimestamp = new AnalyticsBinByName("UtteranceTimestamp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsBinByName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsBinByName FindValue(string value)
        {
            return FindValue<AnalyticsBinByName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsBinByName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsCommonFilterName.
    /// </summary>
    public class AnalyticsCommonFilterName : ConstantClass
    {

        /// <summary>
        /// Constant BotAliasId for AnalyticsCommonFilterName
        /// </summary>
        public static readonly AnalyticsCommonFilterName BotAliasId = new AnalyticsCommonFilterName("BotAliasId");
        /// <summary>
        /// Constant BotVersion for AnalyticsCommonFilterName
        /// </summary>
        public static readonly AnalyticsCommonFilterName BotVersion = new AnalyticsCommonFilterName("BotVersion");
        /// <summary>
        /// Constant Channel for AnalyticsCommonFilterName
        /// </summary>
        public static readonly AnalyticsCommonFilterName Channel = new AnalyticsCommonFilterName("Channel");
        /// <summary>
        /// Constant LocaleId for AnalyticsCommonFilterName
        /// </summary>
        public static readonly AnalyticsCommonFilterName LocaleId = new AnalyticsCommonFilterName("LocaleId");
        /// <summary>
        /// Constant Modality for AnalyticsCommonFilterName
        /// </summary>
        public static readonly AnalyticsCommonFilterName Modality = new AnalyticsCommonFilterName("Modality");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsCommonFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsCommonFilterName FindValue(string value)
        {
            return FindValue<AnalyticsCommonFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsCommonFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsFilterOperator.
    /// </summary>
    public class AnalyticsFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQ for AnalyticsFilterOperator
        /// </summary>
        public static readonly AnalyticsFilterOperator EQ = new AnalyticsFilterOperator("EQ");
        /// <summary>
        /// Constant GT for AnalyticsFilterOperator
        /// </summary>
        public static readonly AnalyticsFilterOperator GT = new AnalyticsFilterOperator("GT");
        /// <summary>
        /// Constant LT for AnalyticsFilterOperator
        /// </summary>
        public static readonly AnalyticsFilterOperator LT = new AnalyticsFilterOperator("LT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsFilterOperator FindValue(string value)
        {
            return FindValue<AnalyticsFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsIntentField.
    /// </summary>
    public class AnalyticsIntentField : ConstantClass
    {

        /// <summary>
        /// Constant IntentEndState for AnalyticsIntentField
        /// </summary>
        public static readonly AnalyticsIntentField IntentEndState = new AnalyticsIntentField("IntentEndState");
        /// <summary>
        /// Constant IntentLevel for AnalyticsIntentField
        /// </summary>
        public static readonly AnalyticsIntentField IntentLevel = new AnalyticsIntentField("IntentLevel");
        /// <summary>
        /// Constant IntentName for AnalyticsIntentField
        /// </summary>
        public static readonly AnalyticsIntentField IntentName = new AnalyticsIntentField("IntentName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsIntentField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsIntentField FindValue(string value)
        {
            return FindValue<AnalyticsIntentField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsIntentField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsIntentFilterName.
    /// </summary>
    public class AnalyticsIntentFilterName : ConstantClass
    {

        /// <summary>
        /// Constant BotAliasId for AnalyticsIntentFilterName
        /// </summary>
        public static readonly AnalyticsIntentFilterName BotAliasId = new AnalyticsIntentFilterName("BotAliasId");
        /// <summary>
        /// Constant BotVersion for AnalyticsIntentFilterName
        /// </summary>
        public static readonly AnalyticsIntentFilterName BotVersion = new AnalyticsIntentFilterName("BotVersion");
        /// <summary>
        /// Constant Channel for AnalyticsIntentFilterName
        /// </summary>
        public static readonly AnalyticsIntentFilterName Channel = new AnalyticsIntentFilterName("Channel");
        /// <summary>
        /// Constant IntentEndState for AnalyticsIntentFilterName
        /// </summary>
        public static readonly AnalyticsIntentFilterName IntentEndState = new AnalyticsIntentFilterName("IntentEndState");
        /// <summary>
        /// Constant IntentName for AnalyticsIntentFilterName
        /// </summary>
        public static readonly AnalyticsIntentFilterName IntentName = new AnalyticsIntentFilterName("IntentName");
        /// <summary>
        /// Constant LocaleId for AnalyticsIntentFilterName
        /// </summary>
        public static readonly AnalyticsIntentFilterName LocaleId = new AnalyticsIntentFilterName("LocaleId");
        /// <summary>
        /// Constant Modality for AnalyticsIntentFilterName
        /// </summary>
        public static readonly AnalyticsIntentFilterName Modality = new AnalyticsIntentFilterName("Modality");
        /// <summary>
        /// Constant OriginatingRequestId for AnalyticsIntentFilterName
        /// </summary>
        public static readonly AnalyticsIntentFilterName OriginatingRequestId = new AnalyticsIntentFilterName("OriginatingRequestId");
        /// <summary>
        /// Constant SessionId for AnalyticsIntentFilterName
        /// </summary>
        public static readonly AnalyticsIntentFilterName SessionId = new AnalyticsIntentFilterName("SessionId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsIntentFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsIntentFilterName FindValue(string value)
        {
            return FindValue<AnalyticsIntentFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsIntentFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsIntentMetricName.
    /// </summary>
    public class AnalyticsIntentMetricName : ConstantClass
    {

        /// <summary>
        /// Constant Count for AnalyticsIntentMetricName
        /// </summary>
        public static readonly AnalyticsIntentMetricName Count = new AnalyticsIntentMetricName("Count");
        /// <summary>
        /// Constant Dropped for AnalyticsIntentMetricName
        /// </summary>
        public static readonly AnalyticsIntentMetricName Dropped = new AnalyticsIntentMetricName("Dropped");
        /// <summary>
        /// Constant Failure for AnalyticsIntentMetricName
        /// </summary>
        public static readonly AnalyticsIntentMetricName Failure = new AnalyticsIntentMetricName("Failure");
        /// <summary>
        /// Constant Success for AnalyticsIntentMetricName
        /// </summary>
        public static readonly AnalyticsIntentMetricName Success = new AnalyticsIntentMetricName("Success");
        /// <summary>
        /// Constant Switched for AnalyticsIntentMetricName
        /// </summary>
        public static readonly AnalyticsIntentMetricName Switched = new AnalyticsIntentMetricName("Switched");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsIntentMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsIntentMetricName FindValue(string value)
        {
            return FindValue<AnalyticsIntentMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsIntentMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsIntentStageField.
    /// </summary>
    public class AnalyticsIntentStageField : ConstantClass
    {

        /// <summary>
        /// Constant IntentStageName for AnalyticsIntentStageField
        /// </summary>
        public static readonly AnalyticsIntentStageField IntentStageName = new AnalyticsIntentStageField("IntentStageName");
        /// <summary>
        /// Constant SwitchedToIntent for AnalyticsIntentStageField
        /// </summary>
        public static readonly AnalyticsIntentStageField SwitchedToIntent = new AnalyticsIntentStageField("SwitchedToIntent");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsIntentStageField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsIntentStageField FindValue(string value)
        {
            return FindValue<AnalyticsIntentStageField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsIntentStageField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsIntentStageFilterName.
    /// </summary>
    public class AnalyticsIntentStageFilterName : ConstantClass
    {

        /// <summary>
        /// Constant BotAliasId for AnalyticsIntentStageFilterName
        /// </summary>
        public static readonly AnalyticsIntentStageFilterName BotAliasId = new AnalyticsIntentStageFilterName("BotAliasId");
        /// <summary>
        /// Constant BotVersion for AnalyticsIntentStageFilterName
        /// </summary>
        public static readonly AnalyticsIntentStageFilterName BotVersion = new AnalyticsIntentStageFilterName("BotVersion");
        /// <summary>
        /// Constant Channel for AnalyticsIntentStageFilterName
        /// </summary>
        public static readonly AnalyticsIntentStageFilterName Channel = new AnalyticsIntentStageFilterName("Channel");
        /// <summary>
        /// Constant IntentName for AnalyticsIntentStageFilterName
        /// </summary>
        public static readonly AnalyticsIntentStageFilterName IntentName = new AnalyticsIntentStageFilterName("IntentName");
        /// <summary>
        /// Constant IntentStageName for AnalyticsIntentStageFilterName
        /// </summary>
        public static readonly AnalyticsIntentStageFilterName IntentStageName = new AnalyticsIntentStageFilterName("IntentStageName");
        /// <summary>
        /// Constant LocaleId for AnalyticsIntentStageFilterName
        /// </summary>
        public static readonly AnalyticsIntentStageFilterName LocaleId = new AnalyticsIntentStageFilterName("LocaleId");
        /// <summary>
        /// Constant Modality for AnalyticsIntentStageFilterName
        /// </summary>
        public static readonly AnalyticsIntentStageFilterName Modality = new AnalyticsIntentStageFilterName("Modality");
        /// <summary>
        /// Constant OriginatingRequestId for AnalyticsIntentStageFilterName
        /// </summary>
        public static readonly AnalyticsIntentStageFilterName OriginatingRequestId = new AnalyticsIntentStageFilterName("OriginatingRequestId");
        /// <summary>
        /// Constant SessionId for AnalyticsIntentStageFilterName
        /// </summary>
        public static readonly AnalyticsIntentStageFilterName SessionId = new AnalyticsIntentStageFilterName("SessionId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsIntentStageFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsIntentStageFilterName FindValue(string value)
        {
            return FindValue<AnalyticsIntentStageFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsIntentStageFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsIntentStageMetricName.
    /// </summary>
    public class AnalyticsIntentStageMetricName : ConstantClass
    {

        /// <summary>
        /// Constant Count for AnalyticsIntentStageMetricName
        /// </summary>
        public static readonly AnalyticsIntentStageMetricName Count = new AnalyticsIntentStageMetricName("Count");
        /// <summary>
        /// Constant Dropped for AnalyticsIntentStageMetricName
        /// </summary>
        public static readonly AnalyticsIntentStageMetricName Dropped = new AnalyticsIntentStageMetricName("Dropped");
        /// <summary>
        /// Constant Failed for AnalyticsIntentStageMetricName
        /// </summary>
        public static readonly AnalyticsIntentStageMetricName Failed = new AnalyticsIntentStageMetricName("Failed");
        /// <summary>
        /// Constant Retry for AnalyticsIntentStageMetricName
        /// </summary>
        public static readonly AnalyticsIntentStageMetricName Retry = new AnalyticsIntentStageMetricName("Retry");
        /// <summary>
        /// Constant Success for AnalyticsIntentStageMetricName
        /// </summary>
        public static readonly AnalyticsIntentStageMetricName Success = new AnalyticsIntentStageMetricName("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsIntentStageMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsIntentStageMetricName FindValue(string value)
        {
            return FindValue<AnalyticsIntentStageMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsIntentStageMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsInterval.
    /// </summary>
    public class AnalyticsInterval : ConstantClass
    {

        /// <summary>
        /// Constant OneDay for AnalyticsInterval
        /// </summary>
        public static readonly AnalyticsInterval OneDay = new AnalyticsInterval("OneDay");
        /// <summary>
        /// Constant OneHour for AnalyticsInterval
        /// </summary>
        public static readonly AnalyticsInterval OneHour = new AnalyticsInterval("OneHour");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsInterval(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsInterval FindValue(string value)
        {
            return FindValue<AnalyticsInterval>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsInterval(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsMetricStatistic.
    /// </summary>
    public class AnalyticsMetricStatistic : ConstantClass
    {

        /// <summary>
        /// Constant Avg for AnalyticsMetricStatistic
        /// </summary>
        public static readonly AnalyticsMetricStatistic Avg = new AnalyticsMetricStatistic("Avg");
        /// <summary>
        /// Constant Max for AnalyticsMetricStatistic
        /// </summary>
        public static readonly AnalyticsMetricStatistic Max = new AnalyticsMetricStatistic("Max");
        /// <summary>
        /// Constant Sum for AnalyticsMetricStatistic
        /// </summary>
        public static readonly AnalyticsMetricStatistic Sum = new AnalyticsMetricStatistic("Sum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsMetricStatistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsMetricStatistic FindValue(string value)
        {
            return FindValue<AnalyticsMetricStatistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsMetricStatistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsModality.
    /// </summary>
    public class AnalyticsModality : ConstantClass
    {

        /// <summary>
        /// Constant DTMF for AnalyticsModality
        /// </summary>
        public static readonly AnalyticsModality DTMF = new AnalyticsModality("DTMF");
        /// <summary>
        /// Constant MultiMode for AnalyticsModality
        /// </summary>
        public static readonly AnalyticsModality MultiMode = new AnalyticsModality("MultiMode");
        /// <summary>
        /// Constant Speech for AnalyticsModality
        /// </summary>
        public static readonly AnalyticsModality Speech = new AnalyticsModality("Speech");
        /// <summary>
        /// Constant Text for AnalyticsModality
        /// </summary>
        public static readonly AnalyticsModality Text = new AnalyticsModality("Text");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsModality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsModality FindValue(string value)
        {
            return FindValue<AnalyticsModality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsModality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsNodeType.
    /// </summary>
    public class AnalyticsNodeType : ConstantClass
    {

        /// <summary>
        /// Constant Exit for AnalyticsNodeType
        /// </summary>
        public static readonly AnalyticsNodeType Exit = new AnalyticsNodeType("Exit");
        /// <summary>
        /// Constant Inner for AnalyticsNodeType
        /// </summary>
        public static readonly AnalyticsNodeType Inner = new AnalyticsNodeType("Inner");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsNodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsNodeType FindValue(string value)
        {
            return FindValue<AnalyticsNodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsNodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsSessionField.
    /// </summary>
    public class AnalyticsSessionField : ConstantClass
    {

        /// <summary>
        /// Constant ConversationEndState for AnalyticsSessionField
        /// </summary>
        public static readonly AnalyticsSessionField ConversationEndState = new AnalyticsSessionField("ConversationEndState");
        /// <summary>
        /// Constant LocaleId for AnalyticsSessionField
        /// </summary>
        public static readonly AnalyticsSessionField LocaleId = new AnalyticsSessionField("LocaleId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsSessionField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsSessionField FindValue(string value)
        {
            return FindValue<AnalyticsSessionField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsSessionField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsSessionFilterName.
    /// </summary>
    public class AnalyticsSessionFilterName : ConstantClass
    {

        /// <summary>
        /// Constant BotAliasId for AnalyticsSessionFilterName
        /// </summary>
        public static readonly AnalyticsSessionFilterName BotAliasId = new AnalyticsSessionFilterName("BotAliasId");
        /// <summary>
        /// Constant BotVersion for AnalyticsSessionFilterName
        /// </summary>
        public static readonly AnalyticsSessionFilterName BotVersion = new AnalyticsSessionFilterName("BotVersion");
        /// <summary>
        /// Constant Channel for AnalyticsSessionFilterName
        /// </summary>
        public static readonly AnalyticsSessionFilterName Channel = new AnalyticsSessionFilterName("Channel");
        /// <summary>
        /// Constant ConversationEndState for AnalyticsSessionFilterName
        /// </summary>
        public static readonly AnalyticsSessionFilterName ConversationEndState = new AnalyticsSessionFilterName("ConversationEndState");
        /// <summary>
        /// Constant Duration for AnalyticsSessionFilterName
        /// </summary>
        public static readonly AnalyticsSessionFilterName Duration = new AnalyticsSessionFilterName("Duration");
        /// <summary>
        /// Constant IntentPath for AnalyticsSessionFilterName
        /// </summary>
        public static readonly AnalyticsSessionFilterName IntentPath = new AnalyticsSessionFilterName("IntentPath");
        /// <summary>
        /// Constant LocaleId for AnalyticsSessionFilterName
        /// </summary>
        public static readonly AnalyticsSessionFilterName LocaleId = new AnalyticsSessionFilterName("LocaleId");
        /// <summary>
        /// Constant Modality for AnalyticsSessionFilterName
        /// </summary>
        public static readonly AnalyticsSessionFilterName Modality = new AnalyticsSessionFilterName("Modality");
        /// <summary>
        /// Constant OriginatingRequestId for AnalyticsSessionFilterName
        /// </summary>
        public static readonly AnalyticsSessionFilterName OriginatingRequestId = new AnalyticsSessionFilterName("OriginatingRequestId");
        /// <summary>
        /// Constant SessionId for AnalyticsSessionFilterName
        /// </summary>
        public static readonly AnalyticsSessionFilterName SessionId = new AnalyticsSessionFilterName("SessionId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsSessionFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsSessionFilterName FindValue(string value)
        {
            return FindValue<AnalyticsSessionFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsSessionFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsSessionMetricName.
    /// </summary>
    public class AnalyticsSessionMetricName : ConstantClass
    {

        /// <summary>
        /// Constant Concurrency for AnalyticsSessionMetricName
        /// </summary>
        public static readonly AnalyticsSessionMetricName Concurrency = new AnalyticsSessionMetricName("Concurrency");
        /// <summary>
        /// Constant Count for AnalyticsSessionMetricName
        /// </summary>
        public static readonly AnalyticsSessionMetricName Count = new AnalyticsSessionMetricName("Count");
        /// <summary>
        /// Constant Dropped for AnalyticsSessionMetricName
        /// </summary>
        public static readonly AnalyticsSessionMetricName Dropped = new AnalyticsSessionMetricName("Dropped");
        /// <summary>
        /// Constant Duration for AnalyticsSessionMetricName
        /// </summary>
        public static readonly AnalyticsSessionMetricName Duration = new AnalyticsSessionMetricName("Duration");
        /// <summary>
        /// Constant Failure for AnalyticsSessionMetricName
        /// </summary>
        public static readonly AnalyticsSessionMetricName Failure = new AnalyticsSessionMetricName("Failure");
        /// <summary>
        /// Constant Success for AnalyticsSessionMetricName
        /// </summary>
        public static readonly AnalyticsSessionMetricName Success = new AnalyticsSessionMetricName("Success");
        /// <summary>
        /// Constant TurnsPerConversation for AnalyticsSessionMetricName
        /// </summary>
        public static readonly AnalyticsSessionMetricName TurnsPerConversation = new AnalyticsSessionMetricName("TurnsPerConversation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsSessionMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsSessionMetricName FindValue(string value)
        {
            return FindValue<AnalyticsSessionMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsSessionMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsSessionSortByName.
    /// </summary>
    public class AnalyticsSessionSortByName : ConstantClass
    {

        /// <summary>
        /// Constant ConversationStartTime for AnalyticsSessionSortByName
        /// </summary>
        public static readonly AnalyticsSessionSortByName ConversationStartTime = new AnalyticsSessionSortByName("ConversationStartTime");
        /// <summary>
        /// Constant Duration for AnalyticsSessionSortByName
        /// </summary>
        public static readonly AnalyticsSessionSortByName Duration = new AnalyticsSessionSortByName("Duration");
        /// <summary>
        /// Constant NumberOfTurns for AnalyticsSessionSortByName
        /// </summary>
        public static readonly AnalyticsSessionSortByName NumberOfTurns = new AnalyticsSessionSortByName("NumberOfTurns");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsSessionSortByName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsSessionSortByName FindValue(string value)
        {
            return FindValue<AnalyticsSessionSortByName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsSessionSortByName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsSortOrder.
    /// </summary>
    public class AnalyticsSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for AnalyticsSortOrder
        /// </summary>
        public static readonly AnalyticsSortOrder Ascending = new AnalyticsSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for AnalyticsSortOrder
        /// </summary>
        public static readonly AnalyticsSortOrder Descending = new AnalyticsSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsSortOrder FindValue(string value)
        {
            return FindValue<AnalyticsSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsUtteranceAttributeName.
    /// </summary>
    public class AnalyticsUtteranceAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant LastUsedIntent for AnalyticsUtteranceAttributeName
        /// </summary>
        public static readonly AnalyticsUtteranceAttributeName LastUsedIntent = new AnalyticsUtteranceAttributeName("LastUsedIntent");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsUtteranceAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsUtteranceAttributeName FindValue(string value)
        {
            return FindValue<AnalyticsUtteranceAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsUtteranceAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsUtteranceField.
    /// </summary>
    public class AnalyticsUtteranceField : ConstantClass
    {

        /// <summary>
        /// Constant UtteranceState for AnalyticsUtteranceField
        /// </summary>
        public static readonly AnalyticsUtteranceField UtteranceState = new AnalyticsUtteranceField("UtteranceState");
        /// <summary>
        /// Constant UtteranceText for AnalyticsUtteranceField
        /// </summary>
        public static readonly AnalyticsUtteranceField UtteranceText = new AnalyticsUtteranceField("UtteranceText");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsUtteranceField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsUtteranceField FindValue(string value)
        {
            return FindValue<AnalyticsUtteranceField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsUtteranceField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsUtteranceFilterName.
    /// </summary>
    public class AnalyticsUtteranceFilterName : ConstantClass
    {

        /// <summary>
        /// Constant BotAliasId for AnalyticsUtteranceFilterName
        /// </summary>
        public static readonly AnalyticsUtteranceFilterName BotAliasId = new AnalyticsUtteranceFilterName("BotAliasId");
        /// <summary>
        /// Constant BotVersion for AnalyticsUtteranceFilterName
        /// </summary>
        public static readonly AnalyticsUtteranceFilterName BotVersion = new AnalyticsUtteranceFilterName("BotVersion");
        /// <summary>
        /// Constant Channel for AnalyticsUtteranceFilterName
        /// </summary>
        public static readonly AnalyticsUtteranceFilterName Channel = new AnalyticsUtteranceFilterName("Channel");
        /// <summary>
        /// Constant LocaleId for AnalyticsUtteranceFilterName
        /// </summary>
        public static readonly AnalyticsUtteranceFilterName LocaleId = new AnalyticsUtteranceFilterName("LocaleId");
        /// <summary>
        /// Constant Modality for AnalyticsUtteranceFilterName
        /// </summary>
        public static readonly AnalyticsUtteranceFilterName Modality = new AnalyticsUtteranceFilterName("Modality");
        /// <summary>
        /// Constant OriginatingRequestId for AnalyticsUtteranceFilterName
        /// </summary>
        public static readonly AnalyticsUtteranceFilterName OriginatingRequestId = new AnalyticsUtteranceFilterName("OriginatingRequestId");
        /// <summary>
        /// Constant SessionId for AnalyticsUtteranceFilterName
        /// </summary>
        public static readonly AnalyticsUtteranceFilterName SessionId = new AnalyticsUtteranceFilterName("SessionId");
        /// <summary>
        /// Constant UtteranceState for AnalyticsUtteranceFilterName
        /// </summary>
        public static readonly AnalyticsUtteranceFilterName UtteranceState = new AnalyticsUtteranceFilterName("UtteranceState");
        /// <summary>
        /// Constant UtteranceText for AnalyticsUtteranceFilterName
        /// </summary>
        public static readonly AnalyticsUtteranceFilterName UtteranceText = new AnalyticsUtteranceFilterName("UtteranceText");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsUtteranceFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsUtteranceFilterName FindValue(string value)
        {
            return FindValue<AnalyticsUtteranceFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsUtteranceFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsUtteranceMetricName.
    /// </summary>
    public class AnalyticsUtteranceMetricName : ConstantClass
    {

        /// <summary>
        /// Constant Count for AnalyticsUtteranceMetricName
        /// </summary>
        public static readonly AnalyticsUtteranceMetricName Count = new AnalyticsUtteranceMetricName("Count");
        /// <summary>
        /// Constant Detected for AnalyticsUtteranceMetricName
        /// </summary>
        public static readonly AnalyticsUtteranceMetricName Detected = new AnalyticsUtteranceMetricName("Detected");
        /// <summary>
        /// Constant Missed for AnalyticsUtteranceMetricName
        /// </summary>
        public static readonly AnalyticsUtteranceMetricName Missed = new AnalyticsUtteranceMetricName("Missed");
        /// <summary>
        /// Constant UtteranceTimestamp for AnalyticsUtteranceMetricName
        /// </summary>
        public static readonly AnalyticsUtteranceMetricName UtteranceTimestamp = new AnalyticsUtteranceMetricName("UtteranceTimestamp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsUtteranceMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsUtteranceMetricName FindValue(string value)
        {
            return FindValue<AnalyticsUtteranceMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsUtteranceMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalyticsUtteranceSortByName.
    /// </summary>
    public class AnalyticsUtteranceSortByName : ConstantClass
    {

        /// <summary>
        /// Constant UtteranceTimestamp for AnalyticsUtteranceSortByName
        /// </summary>
        public static readonly AnalyticsUtteranceSortByName UtteranceTimestamp = new AnalyticsUtteranceSortByName("UtteranceTimestamp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsUtteranceSortByName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsUtteranceSortByName FindValue(string value)
        {
            return FindValue<AnalyticsUtteranceSortByName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsUtteranceSortByName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociatedTranscriptFilterName.
    /// </summary>
    public class AssociatedTranscriptFilterName : ConstantClass
    {

        /// <summary>
        /// Constant IntentId for AssociatedTranscriptFilterName
        /// </summary>
        public static readonly AssociatedTranscriptFilterName IntentId = new AssociatedTranscriptFilterName("IntentId");
        /// <summary>
        /// Constant SlotTypeId for AssociatedTranscriptFilterName
        /// </summary>
        public static readonly AssociatedTranscriptFilterName SlotTypeId = new AssociatedTranscriptFilterName("SlotTypeId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociatedTranscriptFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociatedTranscriptFilterName FindValue(string value)
        {
            return FindValue<AssociatedTranscriptFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociatedTranscriptFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioRecognitionStrategy.
    /// </summary>
    public class AudioRecognitionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant UseSlotValuesAsCustomVocabulary for AudioRecognitionStrategy
        /// </summary>
        public static readonly AudioRecognitionStrategy UseSlotValuesAsCustomVocabulary = new AudioRecognitionStrategy("UseSlotValuesAsCustomVocabulary");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioRecognitionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioRecognitionStrategy FindValue(string value)
        {
            return FindValue<AudioRecognitionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioRecognitionStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BedrockTraceStatus.
    /// </summary>
    public class BedrockTraceStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for BedrockTraceStatus
        /// </summary>
        public static readonly BedrockTraceStatus DISABLED = new BedrockTraceStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for BedrockTraceStatus
        /// </summary>
        public static readonly BedrockTraceStatus ENABLED = new BedrockTraceStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BedrockTraceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BedrockTraceStatus FindValue(string value)
        {
            return FindValue<BedrockTraceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BedrockTraceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotAliasReplicationStatus.
    /// </summary>
    public class BotAliasReplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for BotAliasReplicationStatus
        /// </summary>
        public static readonly BotAliasReplicationStatus Available = new BotAliasReplicationStatus("Available");
        /// <summary>
        /// Constant Creating for BotAliasReplicationStatus
        /// </summary>
        public static readonly BotAliasReplicationStatus Creating = new BotAliasReplicationStatus("Creating");
        /// <summary>
        /// Constant Deleting for BotAliasReplicationStatus
        /// </summary>
        public static readonly BotAliasReplicationStatus Deleting = new BotAliasReplicationStatus("Deleting");
        /// <summary>
        /// Constant Failed for BotAliasReplicationStatus
        /// </summary>
        public static readonly BotAliasReplicationStatus Failed = new BotAliasReplicationStatus("Failed");
        /// <summary>
        /// Constant Updating for BotAliasReplicationStatus
        /// </summary>
        public static readonly BotAliasReplicationStatus Updating = new BotAliasReplicationStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotAliasReplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotAliasReplicationStatus FindValue(string value)
        {
            return FindValue<BotAliasReplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotAliasReplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotAliasStatus.
    /// </summary>
    public class BotAliasStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for BotAliasStatus
        /// </summary>
        public static readonly BotAliasStatus Available = new BotAliasStatus("Available");
        /// <summary>
        /// Constant Creating for BotAliasStatus
        /// </summary>
        public static readonly BotAliasStatus Creating = new BotAliasStatus("Creating");
        /// <summary>
        /// Constant Deleting for BotAliasStatus
        /// </summary>
        public static readonly BotAliasStatus Deleting = new BotAliasStatus("Deleting");
        /// <summary>
        /// Constant Failed for BotAliasStatus
        /// </summary>
        public static readonly BotAliasStatus Failed = new BotAliasStatus("Failed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotAliasStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotAliasStatus FindValue(string value)
        {
            return FindValue<BotAliasStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotAliasStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotFilterName.
    /// </summary>
    public class BotFilterName : ConstantClass
    {

        /// <summary>
        /// Constant BotName for BotFilterName
        /// </summary>
        public static readonly BotFilterName BotName = new BotFilterName("BotName");
        /// <summary>
        /// Constant BotType for BotFilterName
        /// </summary>
        public static readonly BotFilterName BotType = new BotFilterName("BotType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotFilterName FindValue(string value)
        {
            return FindValue<BotFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotFilterOperator.
    /// </summary>
    public class BotFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant CO for BotFilterOperator
        /// </summary>
        public static readonly BotFilterOperator CO = new BotFilterOperator("CO");
        /// <summary>
        /// Constant EQ for BotFilterOperator
        /// </summary>
        public static readonly BotFilterOperator EQ = new BotFilterOperator("EQ");
        /// <summary>
        /// Constant NE for BotFilterOperator
        /// </summary>
        public static readonly BotFilterOperator NE = new BotFilterOperator("NE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotFilterOperator FindValue(string value)
        {
            return FindValue<BotFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotLocaleFilterName.
    /// </summary>
    public class BotLocaleFilterName : ConstantClass
    {

        /// <summary>
        /// Constant BotLocaleName for BotLocaleFilterName
        /// </summary>
        public static readonly BotLocaleFilterName BotLocaleName = new BotLocaleFilterName("BotLocaleName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotLocaleFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotLocaleFilterName FindValue(string value)
        {
            return FindValue<BotLocaleFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotLocaleFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotLocaleFilterOperator.
    /// </summary>
    public class BotLocaleFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant CO for BotLocaleFilterOperator
        /// </summary>
        public static readonly BotLocaleFilterOperator CO = new BotLocaleFilterOperator("CO");
        /// <summary>
        /// Constant EQ for BotLocaleFilterOperator
        /// </summary>
        public static readonly BotLocaleFilterOperator EQ = new BotLocaleFilterOperator("EQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotLocaleFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotLocaleFilterOperator FindValue(string value)
        {
            return FindValue<BotLocaleFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotLocaleFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotLocaleSortAttribute.
    /// </summary>
    public class BotLocaleSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant BotLocaleName for BotLocaleSortAttribute
        /// </summary>
        public static readonly BotLocaleSortAttribute BotLocaleName = new BotLocaleSortAttribute("BotLocaleName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotLocaleSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotLocaleSortAttribute FindValue(string value)
        {
            return FindValue<BotLocaleSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotLocaleSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotLocaleStatus.
    /// </summary>
    public class BotLocaleStatus : ConstantClass
    {

        /// <summary>
        /// Constant Building for BotLocaleStatus
        /// </summary>
        public static readonly BotLocaleStatus Building = new BotLocaleStatus("Building");
        /// <summary>
        /// Constant Built for BotLocaleStatus
        /// </summary>
        public static readonly BotLocaleStatus Built = new BotLocaleStatus("Built");
        /// <summary>
        /// Constant Creating for BotLocaleStatus
        /// </summary>
        public static readonly BotLocaleStatus Creating = new BotLocaleStatus("Creating");
        /// <summary>
        /// Constant Deleting for BotLocaleStatus
        /// </summary>
        public static readonly BotLocaleStatus Deleting = new BotLocaleStatus("Deleting");
        /// <summary>
        /// Constant Failed for BotLocaleStatus
        /// </summary>
        public static readonly BotLocaleStatus Failed = new BotLocaleStatus("Failed");
        /// <summary>
        /// Constant Importing for BotLocaleStatus
        /// </summary>
        public static readonly BotLocaleStatus Importing = new BotLocaleStatus("Importing");
        /// <summary>
        /// Constant NotBuilt for BotLocaleStatus
        /// </summary>
        public static readonly BotLocaleStatus NotBuilt = new BotLocaleStatus("NotBuilt");
        /// <summary>
        /// Constant Processing for BotLocaleStatus
        /// </summary>
        public static readonly BotLocaleStatus Processing = new BotLocaleStatus("Processing");
        /// <summary>
        /// Constant ReadyExpressTesting for BotLocaleStatus
        /// </summary>
        public static readonly BotLocaleStatus ReadyExpressTesting = new BotLocaleStatus("ReadyExpressTesting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotLocaleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotLocaleStatus FindValue(string value)
        {
            return FindValue<BotLocaleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotLocaleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotRecommendationStatus.
    /// </summary>
    public class BotRecommendationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for BotRecommendationStatus
        /// </summary>
        public static readonly BotRecommendationStatus Available = new BotRecommendationStatus("Available");
        /// <summary>
        /// Constant Deleted for BotRecommendationStatus
        /// </summary>
        public static readonly BotRecommendationStatus Deleted = new BotRecommendationStatus("Deleted");
        /// <summary>
        /// Constant Deleting for BotRecommendationStatus
        /// </summary>
        public static readonly BotRecommendationStatus Deleting = new BotRecommendationStatus("Deleting");
        /// <summary>
        /// Constant Downloading for BotRecommendationStatus
        /// </summary>
        public static readonly BotRecommendationStatus Downloading = new BotRecommendationStatus("Downloading");
        /// <summary>
        /// Constant Failed for BotRecommendationStatus
        /// </summary>
        public static readonly BotRecommendationStatus Failed = new BotRecommendationStatus("Failed");
        /// <summary>
        /// Constant Processing for BotRecommendationStatus
        /// </summary>
        public static readonly BotRecommendationStatus Processing = new BotRecommendationStatus("Processing");
        /// <summary>
        /// Constant Stopped for BotRecommendationStatus
        /// </summary>
        public static readonly BotRecommendationStatus Stopped = new BotRecommendationStatus("Stopped");
        /// <summary>
        /// Constant Stopping for BotRecommendationStatus
        /// </summary>
        public static readonly BotRecommendationStatus Stopping = new BotRecommendationStatus("Stopping");
        /// <summary>
        /// Constant Updating for BotRecommendationStatus
        /// </summary>
        public static readonly BotRecommendationStatus Updating = new BotRecommendationStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotRecommendationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotRecommendationStatus FindValue(string value)
        {
            return FindValue<BotRecommendationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotRecommendationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotReplicaStatus.
    /// </summary>
    public class BotReplicaStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deleting for BotReplicaStatus
        /// </summary>
        public static readonly BotReplicaStatus Deleting = new BotReplicaStatus("Deleting");
        /// <summary>
        /// Constant Enabled for BotReplicaStatus
        /// </summary>
        public static readonly BotReplicaStatus Enabled = new BotReplicaStatus("Enabled");
        /// <summary>
        /// Constant Enabling for BotReplicaStatus
        /// </summary>
        public static readonly BotReplicaStatus Enabling = new BotReplicaStatus("Enabling");
        /// <summary>
        /// Constant Failed for BotReplicaStatus
        /// </summary>
        public static readonly BotReplicaStatus Failed = new BotReplicaStatus("Failed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotReplicaStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotReplicaStatus FindValue(string value)
        {
            return FindValue<BotReplicaStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotReplicaStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotSortAttribute.
    /// </summary>
    public class BotSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant BotName for BotSortAttribute
        /// </summary>
        public static readonly BotSortAttribute BotName = new BotSortAttribute("BotName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotSortAttribute FindValue(string value)
        {
            return FindValue<BotSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotStatus.
    /// </summary>
    public class BotStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for BotStatus
        /// </summary>
        public static readonly BotStatus Available = new BotStatus("Available");
        /// <summary>
        /// Constant Creating for BotStatus
        /// </summary>
        public static readonly BotStatus Creating = new BotStatus("Creating");
        /// <summary>
        /// Constant Deleting for BotStatus
        /// </summary>
        public static readonly BotStatus Deleting = new BotStatus("Deleting");
        /// <summary>
        /// Constant Failed for BotStatus
        /// </summary>
        public static readonly BotStatus Failed = new BotStatus("Failed");
        /// <summary>
        /// Constant Importing for BotStatus
        /// </summary>
        public static readonly BotStatus Importing = new BotStatus("Importing");
        /// <summary>
        /// Constant Inactive for BotStatus
        /// </summary>
        public static readonly BotStatus Inactive = new BotStatus("Inactive");
        /// <summary>
        /// Constant Updating for BotStatus
        /// </summary>
        public static readonly BotStatus Updating = new BotStatus("Updating");
        /// <summary>
        /// Constant Versioning for BotStatus
        /// </summary>
        public static readonly BotStatus Versioning = new BotStatus("Versioning");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotStatus FindValue(string value)
        {
            return FindValue<BotStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotType.
    /// </summary>
    public class BotType : ConstantClass
    {

        /// <summary>
        /// Constant Bot for BotType
        /// </summary>
        public static readonly BotType Bot = new BotType("Bot");
        /// <summary>
        /// Constant BotNetwork for BotType
        /// </summary>
        public static readonly BotType BotNetwork = new BotType("BotNetwork");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotType FindValue(string value)
        {
            return FindValue<BotType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotVersionReplicaSortAttribute.
    /// </summary>
    public class BotVersionReplicaSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant BotVersion for BotVersionReplicaSortAttribute
        /// </summary>
        public static readonly BotVersionReplicaSortAttribute BotVersion = new BotVersionReplicaSortAttribute("BotVersion");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotVersionReplicaSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotVersionReplicaSortAttribute FindValue(string value)
        {
            return FindValue<BotVersionReplicaSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotVersionReplicaSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotVersionReplicationStatus.
    /// </summary>
    public class BotVersionReplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for BotVersionReplicationStatus
        /// </summary>
        public static readonly BotVersionReplicationStatus Available = new BotVersionReplicationStatus("Available");
        /// <summary>
        /// Constant Creating for BotVersionReplicationStatus
        /// </summary>
        public static readonly BotVersionReplicationStatus Creating = new BotVersionReplicationStatus("Creating");
        /// <summary>
        /// Constant Deleting for BotVersionReplicationStatus
        /// </summary>
        public static readonly BotVersionReplicationStatus Deleting = new BotVersionReplicationStatus("Deleting");
        /// <summary>
        /// Constant Failed for BotVersionReplicationStatus
        /// </summary>
        public static readonly BotVersionReplicationStatus Failed = new BotVersionReplicationStatus("Failed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotVersionReplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotVersionReplicationStatus FindValue(string value)
        {
            return FindValue<BotVersionReplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotVersionReplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotVersionSortAttribute.
    /// </summary>
    public class BotVersionSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant BotVersion for BotVersionSortAttribute
        /// </summary>
        public static readonly BotVersionSortAttribute BotVersion = new BotVersionSortAttribute("BotVersion");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotVersionSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotVersionSortAttribute FindValue(string value)
        {
            return FindValue<BotVersionSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotVersionSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BuiltInIntentSortAttribute.
    /// </summary>
    public class BuiltInIntentSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant IntentSignature for BuiltInIntentSortAttribute
        /// </summary>
        public static readonly BuiltInIntentSortAttribute IntentSignature = new BuiltInIntentSortAttribute("IntentSignature");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BuiltInIntentSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BuiltInIntentSortAttribute FindValue(string value)
        {
            return FindValue<BuiltInIntentSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BuiltInIntentSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BuiltInSlotTypeSortAttribute.
    /// </summary>
    public class BuiltInSlotTypeSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant SlotTypeSignature for BuiltInSlotTypeSortAttribute
        /// </summary>
        public static readonly BuiltInSlotTypeSortAttribute SlotTypeSignature = new BuiltInSlotTypeSortAttribute("SlotTypeSignature");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BuiltInSlotTypeSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BuiltInSlotTypeSortAttribute FindValue(string value)
        {
            return FindValue<BuiltInSlotTypeSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BuiltInSlotTypeSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConversationEndState.
    /// </summary>
    public class ConversationEndState : ConstantClass
    {

        /// <summary>
        /// Constant Dropped for ConversationEndState
        /// </summary>
        public static readonly ConversationEndState Dropped = new ConversationEndState("Dropped");
        /// <summary>
        /// Constant Failure for ConversationEndState
        /// </summary>
        public static readonly ConversationEndState Failure = new ConversationEndState("Failure");
        /// <summary>
        /// Constant Success for ConversationEndState
        /// </summary>
        public static readonly ConversationEndState Success = new ConversationEndState("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConversationEndState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConversationEndState FindValue(string value)
        {
            return FindValue<ConversationEndState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConversationEndState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConversationLogsInputModeFilter.
    /// </summary>
    public class ConversationLogsInputModeFilter : ConstantClass
    {

        /// <summary>
        /// Constant Speech for ConversationLogsInputModeFilter
        /// </summary>
        public static readonly ConversationLogsInputModeFilter Speech = new ConversationLogsInputModeFilter("Speech");
        /// <summary>
        /// Constant Text for ConversationLogsInputModeFilter
        /// </summary>
        public static readonly ConversationLogsInputModeFilter Text = new ConversationLogsInputModeFilter("Text");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConversationLogsInputModeFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConversationLogsInputModeFilter FindValue(string value)
        {
            return FindValue<ConversationLogsInputModeFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConversationLogsInputModeFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomVocabularyStatus.
    /// </summary>
    public class CustomVocabularyStatus : ConstantClass
    {

        /// <summary>
        /// Constant Creating for CustomVocabularyStatus
        /// </summary>
        public static readonly CustomVocabularyStatus Creating = new CustomVocabularyStatus("Creating");
        /// <summary>
        /// Constant Deleting for CustomVocabularyStatus
        /// </summary>
        public static readonly CustomVocabularyStatus Deleting = new CustomVocabularyStatus("Deleting");
        /// <summary>
        /// Constant Exporting for CustomVocabularyStatus
        /// </summary>
        public static readonly CustomVocabularyStatus Exporting = new CustomVocabularyStatus("Exporting");
        /// <summary>
        /// Constant Importing for CustomVocabularyStatus
        /// </summary>
        public static readonly CustomVocabularyStatus Importing = new CustomVocabularyStatus("Importing");
        /// <summary>
        /// Constant Ready for CustomVocabularyStatus
        /// </summary>
        public static readonly CustomVocabularyStatus Ready = new CustomVocabularyStatus("Ready");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomVocabularyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomVocabularyStatus FindValue(string value)
        {
            return FindValue<CustomVocabularyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomVocabularyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DialogActionType.
    /// </summary>
    public class DialogActionType : ConstantClass
    {

        /// <summary>
        /// Constant CloseIntent for DialogActionType
        /// </summary>
        public static readonly DialogActionType CloseIntent = new DialogActionType("CloseIntent");
        /// <summary>
        /// Constant ConfirmIntent for DialogActionType
        /// </summary>
        public static readonly DialogActionType ConfirmIntent = new DialogActionType("ConfirmIntent");
        /// <summary>
        /// Constant ElicitIntent for DialogActionType
        /// </summary>
        public static readonly DialogActionType ElicitIntent = new DialogActionType("ElicitIntent");
        /// <summary>
        /// Constant ElicitSlot for DialogActionType
        /// </summary>
        public static readonly DialogActionType ElicitSlot = new DialogActionType("ElicitSlot");
        /// <summary>
        /// Constant EndConversation for DialogActionType
        /// </summary>
        public static readonly DialogActionType EndConversation = new DialogActionType("EndConversation");
        /// <summary>
        /// Constant EvaluateConditional for DialogActionType
        /// </summary>
        public static readonly DialogActionType EvaluateConditional = new DialogActionType("EvaluateConditional");
        /// <summary>
        /// Constant FulfillIntent for DialogActionType
        /// </summary>
        public static readonly DialogActionType FulfillIntent = new DialogActionType("FulfillIntent");
        /// <summary>
        /// Constant InvokeDialogCodeHook for DialogActionType
        /// </summary>
        public static readonly DialogActionType InvokeDialogCodeHook = new DialogActionType("InvokeDialogCodeHook");
        /// <summary>
        /// Constant StartIntent for DialogActionType
        /// </summary>
        public static readonly DialogActionType StartIntent = new DialogActionType("StartIntent");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DialogActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DialogActionType FindValue(string value)
        {
            return FindValue<DialogActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DialogActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Effect.
    /// </summary>
    public class Effect : ConstantClass
    {

        /// <summary>
        /// Constant Allow for Effect
        /// </summary>
        public static readonly Effect Allow = new Effect("Allow");
        /// <summary>
        /// Constant Deny for Effect
        /// </summary>
        public static readonly Effect Deny = new Effect("Deny");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Effect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Effect FindValue(string value)
        {
            return FindValue<Effect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Effect(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_INPUT for ErrorCode
        /// </summary>
        public static readonly ErrorCode DUPLICATE_INPUT = new ErrorCode("DUPLICATE_INPUT");
        /// <summary>
        /// Constant INTERNAL_SERVER_FAILURE for ErrorCode
        /// </summary>
        public static readonly ErrorCode INTERNAL_SERVER_FAILURE = new ErrorCode("INTERNAL_SERVER_FAILURE");
        /// <summary>
        /// Constant RESOURCE_ALREADY_EXISTS for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_ALREADY_EXISTS = new ErrorCode("RESOURCE_ALREADY_EXISTS");
        /// <summary>
        /// Constant RESOURCE_DOES_NOT_EXIST for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_DOES_NOT_EXIST = new ErrorCode("RESOURCE_DOES_NOT_EXIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportFilterName.
    /// </summary>
    public class ExportFilterName : ConstantClass
    {

        /// <summary>
        /// Constant ExportResourceType for ExportFilterName
        /// </summary>
        public static readonly ExportFilterName ExportResourceType = new ExportFilterName("ExportResourceType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportFilterName FindValue(string value)
        {
            return FindValue<ExportFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportFilterOperator.
    /// </summary>
    public class ExportFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant CO for ExportFilterOperator
        /// </summary>
        public static readonly ExportFilterOperator CO = new ExportFilterOperator("CO");
        /// <summary>
        /// Constant EQ for ExportFilterOperator
        /// </summary>
        public static readonly ExportFilterOperator EQ = new ExportFilterOperator("EQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportFilterOperator FindValue(string value)
        {
            return FindValue<ExportFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportSortAttribute.
    /// </summary>
    public class ExportSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant LastUpdatedDateTime for ExportSortAttribute
        /// </summary>
        public static readonly ExportSortAttribute LastUpdatedDateTime = new ExportSortAttribute("LastUpdatedDateTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportSortAttribute FindValue(string value)
        {
            return FindValue<ExportSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportStatus.
    /// </summary>
    public class ExportStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for ExportStatus
        /// </summary>
        public static readonly ExportStatus Completed = new ExportStatus("Completed");
        /// <summary>
        /// Constant Deleting for ExportStatus
        /// </summary>
        public static readonly ExportStatus Deleting = new ExportStatus("Deleting");
        /// <summary>
        /// Constant Failed for ExportStatus
        /// </summary>
        public static readonly ExportStatus Failed = new ExportStatus("Failed");
        /// <summary>
        /// Constant InProgress for ExportStatus
        /// </summary>
        public static readonly ExportStatus InProgress = new ExportStatus("InProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportStatus FindValue(string value)
        {
            return FindValue<ExportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GenerationSortByAttribute.
    /// </summary>
    public class GenerationSortByAttribute : ConstantClass
    {

        /// <summary>
        /// Constant CreationStartTime for GenerationSortByAttribute
        /// </summary>
        public static readonly GenerationSortByAttribute CreationStartTime = new GenerationSortByAttribute("creationStartTime");
        /// <summary>
        /// Constant LastUpdatedTime for GenerationSortByAttribute
        /// </summary>
        public static readonly GenerationSortByAttribute LastUpdatedTime = new GenerationSortByAttribute("lastUpdatedTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GenerationSortByAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GenerationSortByAttribute FindValue(string value)
        {
            return FindValue<GenerationSortByAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GenerationSortByAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GenerationStatus.
    /// </summary>
    public class GenerationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Complete for GenerationStatus
        /// </summary>
        public static readonly GenerationStatus Complete = new GenerationStatus("Complete");
        /// <summary>
        /// Constant Failed for GenerationStatus
        /// </summary>
        public static readonly GenerationStatus Failed = new GenerationStatus("Failed");
        /// <summary>
        /// Constant InProgress for GenerationStatus
        /// </summary>
        public static readonly GenerationStatus InProgress = new GenerationStatus("InProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GenerationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GenerationStatus FindValue(string value)
        {
            return FindValue<GenerationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GenerationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportExportFileFormat.
    /// </summary>
    public class ImportExportFileFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for ImportExportFileFormat
        /// </summary>
        public static readonly ImportExportFileFormat CSV = new ImportExportFileFormat("CSV");
        /// <summary>
        /// Constant LexJson for ImportExportFileFormat
        /// </summary>
        public static readonly ImportExportFileFormat LexJson = new ImportExportFileFormat("LexJson");
        /// <summary>
        /// Constant TSV for ImportExportFileFormat
        /// </summary>
        public static readonly ImportExportFileFormat TSV = new ImportExportFileFormat("TSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportExportFileFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportExportFileFormat FindValue(string value)
        {
            return FindValue<ImportExportFileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportExportFileFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportFilterName.
    /// </summary>
    public class ImportFilterName : ConstantClass
    {

        /// <summary>
        /// Constant ImportResourceType for ImportFilterName
        /// </summary>
        public static readonly ImportFilterName ImportResourceType = new ImportFilterName("ImportResourceType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportFilterName FindValue(string value)
        {
            return FindValue<ImportFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportFilterOperator.
    /// </summary>
    public class ImportFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant CO for ImportFilterOperator
        /// </summary>
        public static readonly ImportFilterOperator CO = new ImportFilterOperator("CO");
        /// <summary>
        /// Constant EQ for ImportFilterOperator
        /// </summary>
        public static readonly ImportFilterOperator EQ = new ImportFilterOperator("EQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportFilterOperator FindValue(string value)
        {
            return FindValue<ImportFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportResourceType.
    /// </summary>
    public class ImportResourceType : ConstantClass
    {

        /// <summary>
        /// Constant Bot for ImportResourceType
        /// </summary>
        public static readonly ImportResourceType Bot = new ImportResourceType("Bot");
        /// <summary>
        /// Constant BotLocale for ImportResourceType
        /// </summary>
        public static readonly ImportResourceType BotLocale = new ImportResourceType("BotLocale");
        /// <summary>
        /// Constant CustomVocabulary for ImportResourceType
        /// </summary>
        public static readonly ImportResourceType CustomVocabulary = new ImportResourceType("CustomVocabulary");
        /// <summary>
        /// Constant TestSet for ImportResourceType
        /// </summary>
        public static readonly ImportResourceType TestSet = new ImportResourceType("TestSet");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportResourceType FindValue(string value)
        {
            return FindValue<ImportResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportSortAttribute.
    /// </summary>
    public class ImportSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant LastUpdatedDateTime for ImportSortAttribute
        /// </summary>
        public static readonly ImportSortAttribute LastUpdatedDateTime = new ImportSortAttribute("LastUpdatedDateTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportSortAttribute FindValue(string value)
        {
            return FindValue<ImportSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportStatus.
    /// </summary>
    public class ImportStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for ImportStatus
        /// </summary>
        public static readonly ImportStatus Completed = new ImportStatus("Completed");
        /// <summary>
        /// Constant Deleting for ImportStatus
        /// </summary>
        public static readonly ImportStatus Deleting = new ImportStatus("Deleting");
        /// <summary>
        /// Constant Failed for ImportStatus
        /// </summary>
        public static readonly ImportStatus Failed = new ImportStatus("Failed");
        /// <summary>
        /// Constant InProgress for ImportStatus
        /// </summary>
        public static readonly ImportStatus InProgress = new ImportStatus("InProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportStatus FindValue(string value)
        {
            return FindValue<ImportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntentFilterName.
    /// </summary>
    public class IntentFilterName : ConstantClass
    {

        /// <summary>
        /// Constant IntentName for IntentFilterName
        /// </summary>
        public static readonly IntentFilterName IntentName = new IntentFilterName("IntentName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntentFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntentFilterName FindValue(string value)
        {
            return FindValue<IntentFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntentFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntentFilterOperator.
    /// </summary>
    public class IntentFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant CO for IntentFilterOperator
        /// </summary>
        public static readonly IntentFilterOperator CO = new IntentFilterOperator("CO");
        /// <summary>
        /// Constant EQ for IntentFilterOperator
        /// </summary>
        public static readonly IntentFilterOperator EQ = new IntentFilterOperator("EQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntentFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntentFilterOperator FindValue(string value)
        {
            return FindValue<IntentFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntentFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntentSortAttribute.
    /// </summary>
    public class IntentSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant IntentName for IntentSortAttribute
        /// </summary>
        public static readonly IntentSortAttribute IntentName = new IntentSortAttribute("IntentName");
        /// <summary>
        /// Constant LastUpdatedDateTime for IntentSortAttribute
        /// </summary>
        public static readonly IntentSortAttribute LastUpdatedDateTime = new IntentSortAttribute("LastUpdatedDateTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntentSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntentSortAttribute FindValue(string value)
        {
            return FindValue<IntentSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntentSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntentState.
    /// </summary>
    public class IntentState : ConstantClass
    {

        /// <summary>
        /// Constant Failed for IntentState
        /// </summary>
        public static readonly IntentState Failed = new IntentState("Failed");
        /// <summary>
        /// Constant Fulfilled for IntentState
        /// </summary>
        public static readonly IntentState Fulfilled = new IntentState("Fulfilled");
        /// <summary>
        /// Constant FulfillmentInProgress for IntentState
        /// </summary>
        public static readonly IntentState FulfillmentInProgress = new IntentState("FulfillmentInProgress");
        /// <summary>
        /// Constant InProgress for IntentState
        /// </summary>
        public static readonly IntentState InProgress = new IntentState("InProgress");
        /// <summary>
        /// Constant ReadyForFulfillment for IntentState
        /// </summary>
        public static readonly IntentState ReadyForFulfillment = new IntentState("ReadyForFulfillment");
        /// <summary>
        /// Constant Waiting for IntentState
        /// </summary>
        public static readonly IntentState Waiting = new IntentState("Waiting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntentState FindValue(string value)
        {
            return FindValue<IntentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MergeStrategy.
    /// </summary>
    public class MergeStrategy : ConstantClass
    {

        /// <summary>
        /// Constant Append for MergeStrategy
        /// </summary>
        public static readonly MergeStrategy Append = new MergeStrategy("Append");
        /// <summary>
        /// Constant FailOnConflict for MergeStrategy
        /// </summary>
        public static readonly MergeStrategy FailOnConflict = new MergeStrategy("FailOnConflict");
        /// <summary>
        /// Constant Overwrite for MergeStrategy
        /// </summary>
        public static readonly MergeStrategy Overwrite = new MergeStrategy("Overwrite");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MergeStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MergeStrategy FindValue(string value)
        {
            return FindValue<MergeStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MergeStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageSelectionStrategy.
    /// </summary>
    public class MessageSelectionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant Ordered for MessageSelectionStrategy
        /// </summary>
        public static readonly MessageSelectionStrategy Ordered = new MessageSelectionStrategy("Ordered");
        /// <summary>
        /// Constant Random for MessageSelectionStrategy
        /// </summary>
        public static readonly MessageSelectionStrategy Random = new MessageSelectionStrategy("Random");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageSelectionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageSelectionStrategy FindValue(string value)
        {
            return FindValue<MessageSelectionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageSelectionStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObfuscationSettingType.
    /// </summary>
    public class ObfuscationSettingType : ConstantClass
    {

        /// <summary>
        /// Constant DefaultObfuscation for ObfuscationSettingType
        /// </summary>
        public static readonly ObfuscationSettingType DefaultObfuscation = new ObfuscationSettingType("DefaultObfuscation");
        /// <summary>
        /// Constant None for ObfuscationSettingType
        /// </summary>
        public static readonly ObfuscationSettingType None = new ObfuscationSettingType("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObfuscationSettingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObfuscationSettingType FindValue(string value)
        {
            return FindValue<ObfuscationSettingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObfuscationSettingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PromptAttempt.
    /// </summary>
    public class PromptAttempt : ConstantClass
    {

        /// <summary>
        /// Constant Initial for PromptAttempt
        /// </summary>
        public static readonly PromptAttempt Initial = new PromptAttempt("Initial");
        /// <summary>
        /// Constant Retry1 for PromptAttempt
        /// </summary>
        public static readonly PromptAttempt Retry1 = new PromptAttempt("Retry1");
        /// <summary>
        /// Constant Retry2 for PromptAttempt
        /// </summary>
        public static readonly PromptAttempt Retry2 = new PromptAttempt("Retry2");
        /// <summary>
        /// Constant Retry3 for PromptAttempt
        /// </summary>
        public static readonly PromptAttempt Retry3 = new PromptAttempt("Retry3");
        /// <summary>
        /// Constant Retry4 for PromptAttempt
        /// </summary>
        public static readonly PromptAttempt Retry4 = new PromptAttempt("Retry4");
        /// <summary>
        /// Constant Retry5 for PromptAttempt
        /// </summary>
        public static readonly PromptAttempt Retry5 = new PromptAttempt("Retry5");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PromptAttempt(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PromptAttempt FindValue(string value)
        {
            return FindValue<PromptAttempt>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PromptAttempt(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchOrder.
    /// </summary>
    public class SearchOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for SearchOrder
        /// </summary>
        public static readonly SearchOrder Ascending = new SearchOrder("Ascending");
        /// <summary>
        /// Constant Descending for SearchOrder
        /// </summary>
        public static readonly SearchOrder Descending = new SearchOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchOrder FindValue(string value)
        {
            return FindValue<SearchOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotConstraint.
    /// </summary>
    public class SlotConstraint : ConstantClass
    {

        /// <summary>
        /// Constant Optional for SlotConstraint
        /// </summary>
        public static readonly SlotConstraint Optional = new SlotConstraint("Optional");
        /// <summary>
        /// Constant Required for SlotConstraint
        /// </summary>
        public static readonly SlotConstraint Required = new SlotConstraint("Required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotConstraint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotConstraint FindValue(string value)
        {
            return FindValue<SlotConstraint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotConstraint(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotFilterName.
    /// </summary>
    public class SlotFilterName : ConstantClass
    {

        /// <summary>
        /// Constant SlotName for SlotFilterName
        /// </summary>
        public static readonly SlotFilterName SlotName = new SlotFilterName("SlotName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotFilterName FindValue(string value)
        {
            return FindValue<SlotFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotFilterOperator.
    /// </summary>
    public class SlotFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant CO for SlotFilterOperator
        /// </summary>
        public static readonly SlotFilterOperator CO = new SlotFilterOperator("CO");
        /// <summary>
        /// Constant EQ for SlotFilterOperator
        /// </summary>
        public static readonly SlotFilterOperator EQ = new SlotFilterOperator("EQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotFilterOperator FindValue(string value)
        {
            return FindValue<SlotFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotResolutionStrategy.
    /// </summary>
    public class SlotResolutionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant Default for SlotResolutionStrategy
        /// </summary>
        public static readonly SlotResolutionStrategy Default = new SlotResolutionStrategy("Default");
        /// <summary>
        /// Constant EnhancedFallback for SlotResolutionStrategy
        /// </summary>
        public static readonly SlotResolutionStrategy EnhancedFallback = new SlotResolutionStrategy("EnhancedFallback");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotResolutionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotResolutionStrategy FindValue(string value)
        {
            return FindValue<SlotResolutionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotResolutionStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotShape.
    /// </summary>
    public class SlotShape : ConstantClass
    {

        /// <summary>
        /// Constant List for SlotShape
        /// </summary>
        public static readonly SlotShape List = new SlotShape("List");
        /// <summary>
        /// Constant Scalar for SlotShape
        /// </summary>
        public static readonly SlotShape Scalar = new SlotShape("Scalar");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotShape(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotShape FindValue(string value)
        {
            return FindValue<SlotShape>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotShape(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotSortAttribute.
    /// </summary>
    public class SlotSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant LastUpdatedDateTime for SlotSortAttribute
        /// </summary>
        public static readonly SlotSortAttribute LastUpdatedDateTime = new SlotSortAttribute("LastUpdatedDateTime");
        /// <summary>
        /// Constant SlotName for SlotSortAttribute
        /// </summary>
        public static readonly SlotSortAttribute SlotName = new SlotSortAttribute("SlotName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotSortAttribute FindValue(string value)
        {
            return FindValue<SlotSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotTypeCategory.
    /// </summary>
    public class SlotTypeCategory : ConstantClass
    {

        /// <summary>
        /// Constant Composite for SlotTypeCategory
        /// </summary>
        public static readonly SlotTypeCategory Composite = new SlotTypeCategory("Composite");
        /// <summary>
        /// Constant Custom for SlotTypeCategory
        /// </summary>
        public static readonly SlotTypeCategory Custom = new SlotTypeCategory("Custom");
        /// <summary>
        /// Constant Extended for SlotTypeCategory
        /// </summary>
        public static readonly SlotTypeCategory Extended = new SlotTypeCategory("Extended");
        /// <summary>
        /// Constant ExternalGrammar for SlotTypeCategory
        /// </summary>
        public static readonly SlotTypeCategory ExternalGrammar = new SlotTypeCategory("ExternalGrammar");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotTypeCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotTypeCategory FindValue(string value)
        {
            return FindValue<SlotTypeCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotTypeCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotTypeFilterName.
    /// </summary>
    public class SlotTypeFilterName : ConstantClass
    {

        /// <summary>
        /// Constant ExternalSourceType for SlotTypeFilterName
        /// </summary>
        public static readonly SlotTypeFilterName ExternalSourceType = new SlotTypeFilterName("ExternalSourceType");
        /// <summary>
        /// Constant SlotTypeName for SlotTypeFilterName
        /// </summary>
        public static readonly SlotTypeFilterName SlotTypeName = new SlotTypeFilterName("SlotTypeName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotTypeFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotTypeFilterName FindValue(string value)
        {
            return FindValue<SlotTypeFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotTypeFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotTypeFilterOperator.
    /// </summary>
    public class SlotTypeFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant CO for SlotTypeFilterOperator
        /// </summary>
        public static readonly SlotTypeFilterOperator CO = new SlotTypeFilterOperator("CO");
        /// <summary>
        /// Constant EQ for SlotTypeFilterOperator
        /// </summary>
        public static readonly SlotTypeFilterOperator EQ = new SlotTypeFilterOperator("EQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotTypeFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotTypeFilterOperator FindValue(string value)
        {
            return FindValue<SlotTypeFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotTypeFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotTypeSortAttribute.
    /// </summary>
    public class SlotTypeSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant LastUpdatedDateTime for SlotTypeSortAttribute
        /// </summary>
        public static readonly SlotTypeSortAttribute LastUpdatedDateTime = new SlotTypeSortAttribute("LastUpdatedDateTime");
        /// <summary>
        /// Constant SlotTypeName for SlotTypeSortAttribute
        /// </summary>
        public static readonly SlotTypeSortAttribute SlotTypeName = new SlotTypeSortAttribute("SlotTypeName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotTypeSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotTypeSortAttribute FindValue(string value)
        {
            return FindValue<SlotTypeSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotTypeSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlotValueResolutionStrategy.
    /// </summary>
    public class SlotValueResolutionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant Concatenation for SlotValueResolutionStrategy
        /// </summary>
        public static readonly SlotValueResolutionStrategy Concatenation = new SlotValueResolutionStrategy("Concatenation");
        /// <summary>
        /// Constant OriginalValue for SlotValueResolutionStrategy
        /// </summary>
        public static readonly SlotValueResolutionStrategy OriginalValue = new SlotValueResolutionStrategy("OriginalValue");
        /// <summary>
        /// Constant TopResolution for SlotValueResolutionStrategy
        /// </summary>
        public static readonly SlotValueResolutionStrategy TopResolution = new SlotValueResolutionStrategy("TopResolution");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlotValueResolutionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlotValueResolutionStrategy FindValue(string value)
        {
            return FindValue<SlotValueResolutionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlotValueResolutionStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for SortOrder
        /// </summary>
        public static readonly SortOrder Ascending = new SortOrder("Ascending");
        /// <summary>
        /// Constant Descending for SortOrder
        /// </summary>
        public static readonly SortOrder Descending = new SortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestExecutionApiMode.
    /// </summary>
    public class TestExecutionApiMode : ConstantClass
    {

        /// <summary>
        /// Constant NonStreaming for TestExecutionApiMode
        /// </summary>
        public static readonly TestExecutionApiMode NonStreaming = new TestExecutionApiMode("NonStreaming");
        /// <summary>
        /// Constant Streaming for TestExecutionApiMode
        /// </summary>
        public static readonly TestExecutionApiMode Streaming = new TestExecutionApiMode("Streaming");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestExecutionApiMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestExecutionApiMode FindValue(string value)
        {
            return FindValue<TestExecutionApiMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestExecutionApiMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestExecutionModality.
    /// </summary>
    public class TestExecutionModality : ConstantClass
    {

        /// <summary>
        /// Constant Audio for TestExecutionModality
        /// </summary>
        public static readonly TestExecutionModality Audio = new TestExecutionModality("Audio");
        /// <summary>
        /// Constant Text for TestExecutionModality
        /// </summary>
        public static readonly TestExecutionModality Text = new TestExecutionModality("Text");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestExecutionModality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestExecutionModality FindValue(string value)
        {
            return FindValue<TestExecutionModality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestExecutionModality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestExecutionSortAttribute.
    /// </summary>
    public class TestExecutionSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant CreationDateTime for TestExecutionSortAttribute
        /// </summary>
        public static readonly TestExecutionSortAttribute CreationDateTime = new TestExecutionSortAttribute("CreationDateTime");
        /// <summary>
        /// Constant TestSetName for TestExecutionSortAttribute
        /// </summary>
        public static readonly TestExecutionSortAttribute TestSetName = new TestExecutionSortAttribute("TestSetName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestExecutionSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestExecutionSortAttribute FindValue(string value)
        {
            return FindValue<TestExecutionSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestExecutionSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestExecutionStatus.
    /// </summary>
    public class TestExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for TestExecutionStatus
        /// </summary>
        public static readonly TestExecutionStatus Completed = new TestExecutionStatus("Completed");
        /// <summary>
        /// Constant Failed for TestExecutionStatus
        /// </summary>
        public static readonly TestExecutionStatus Failed = new TestExecutionStatus("Failed");
        /// <summary>
        /// Constant InProgress for TestExecutionStatus
        /// </summary>
        public static readonly TestExecutionStatus InProgress = new TestExecutionStatus("InProgress");
        /// <summary>
        /// Constant Pending for TestExecutionStatus
        /// </summary>
        public static readonly TestExecutionStatus Pending = new TestExecutionStatus("Pending");
        /// <summary>
        /// Constant Stopped for TestExecutionStatus
        /// </summary>
        public static readonly TestExecutionStatus Stopped = new TestExecutionStatus("Stopped");
        /// <summary>
        /// Constant Stopping for TestExecutionStatus
        /// </summary>
        public static readonly TestExecutionStatus Stopping = new TestExecutionStatus("Stopping");
        /// <summary>
        /// Constant Waiting for TestExecutionStatus
        /// </summary>
        public static readonly TestExecutionStatus Waiting = new TestExecutionStatus("Waiting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestExecutionStatus FindValue(string value)
        {
            return FindValue<TestExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestResultMatchStatus.
    /// </summary>
    public class TestResultMatchStatus : ConstantClass
    {

        /// <summary>
        /// Constant ExecutionError for TestResultMatchStatus
        /// </summary>
        public static readonly TestResultMatchStatus ExecutionError = new TestResultMatchStatus("ExecutionError");
        /// <summary>
        /// Constant Matched for TestResultMatchStatus
        /// </summary>
        public static readonly TestResultMatchStatus Matched = new TestResultMatchStatus("Matched");
        /// <summary>
        /// Constant Mismatched for TestResultMatchStatus
        /// </summary>
        public static readonly TestResultMatchStatus Mismatched = new TestResultMatchStatus("Mismatched");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestResultMatchStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestResultMatchStatus FindValue(string value)
        {
            return FindValue<TestResultMatchStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestResultMatchStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestResultTypeFilter.
    /// </summary>
    public class TestResultTypeFilter : ConstantClass
    {

        /// <summary>
        /// Constant ConversationLevelTestResults for TestResultTypeFilter
        /// </summary>
        public static readonly TestResultTypeFilter ConversationLevelTestResults = new TestResultTypeFilter("ConversationLevelTestResults");
        /// <summary>
        /// Constant IntentClassificationTestResults for TestResultTypeFilter
        /// </summary>
        public static readonly TestResultTypeFilter IntentClassificationTestResults = new TestResultTypeFilter("IntentClassificationTestResults");
        /// <summary>
        /// Constant OverallTestResults for TestResultTypeFilter
        /// </summary>
        public static readonly TestResultTypeFilter OverallTestResults = new TestResultTypeFilter("OverallTestResults");
        /// <summary>
        /// Constant SlotResolutionTestResults for TestResultTypeFilter
        /// </summary>
        public static readonly TestResultTypeFilter SlotResolutionTestResults = new TestResultTypeFilter("SlotResolutionTestResults");
        /// <summary>
        /// Constant UtteranceLevelResults for TestResultTypeFilter
        /// </summary>
        public static readonly TestResultTypeFilter UtteranceLevelResults = new TestResultTypeFilter("UtteranceLevelResults");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestResultTypeFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestResultTypeFilter FindValue(string value)
        {
            return FindValue<TestResultTypeFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestResultTypeFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestSetDiscrepancyReportStatus.
    /// </summary>
    public class TestSetDiscrepancyReportStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for TestSetDiscrepancyReportStatus
        /// </summary>
        public static readonly TestSetDiscrepancyReportStatus Completed = new TestSetDiscrepancyReportStatus("Completed");
        /// <summary>
        /// Constant Failed for TestSetDiscrepancyReportStatus
        /// </summary>
        public static readonly TestSetDiscrepancyReportStatus Failed = new TestSetDiscrepancyReportStatus("Failed");
        /// <summary>
        /// Constant InProgress for TestSetDiscrepancyReportStatus
        /// </summary>
        public static readonly TestSetDiscrepancyReportStatus InProgress = new TestSetDiscrepancyReportStatus("InProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestSetDiscrepancyReportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestSetDiscrepancyReportStatus FindValue(string value)
        {
            return FindValue<TestSetDiscrepancyReportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestSetDiscrepancyReportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestSetGenerationStatus.
    /// </summary>
    public class TestSetGenerationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for TestSetGenerationStatus
        /// </summary>
        public static readonly TestSetGenerationStatus Failed = new TestSetGenerationStatus("Failed");
        /// <summary>
        /// Constant Generating for TestSetGenerationStatus
        /// </summary>
        public static readonly TestSetGenerationStatus Generating = new TestSetGenerationStatus("Generating");
        /// <summary>
        /// Constant Pending for TestSetGenerationStatus
        /// </summary>
        public static readonly TestSetGenerationStatus Pending = new TestSetGenerationStatus("Pending");
        /// <summary>
        /// Constant Ready for TestSetGenerationStatus
        /// </summary>
        public static readonly TestSetGenerationStatus Ready = new TestSetGenerationStatus("Ready");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestSetGenerationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestSetGenerationStatus FindValue(string value)
        {
            return FindValue<TestSetGenerationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestSetGenerationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestSetModality.
    /// </summary>
    public class TestSetModality : ConstantClass
    {

        /// <summary>
        /// Constant Audio for TestSetModality
        /// </summary>
        public static readonly TestSetModality Audio = new TestSetModality("Audio");
        /// <summary>
        /// Constant Text for TestSetModality
        /// </summary>
        public static readonly TestSetModality Text = new TestSetModality("Text");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestSetModality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestSetModality FindValue(string value)
        {
            return FindValue<TestSetModality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestSetModality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestSetSortAttribute.
    /// </summary>
    public class TestSetSortAttribute : ConstantClass
    {

        /// <summary>
        /// Constant LastUpdatedDateTime for TestSetSortAttribute
        /// </summary>
        public static readonly TestSetSortAttribute LastUpdatedDateTime = new TestSetSortAttribute("LastUpdatedDateTime");
        /// <summary>
        /// Constant TestSetName for TestSetSortAttribute
        /// </summary>
        public static readonly TestSetSortAttribute TestSetName = new TestSetSortAttribute("TestSetName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestSetSortAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestSetSortAttribute FindValue(string value)
        {
            return FindValue<TestSetSortAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestSetSortAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestSetStatus.
    /// </summary>
    public class TestSetStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deleting for TestSetStatus
        /// </summary>
        public static readonly TestSetStatus Deleting = new TestSetStatus("Deleting");
        /// <summary>
        /// Constant Importing for TestSetStatus
        /// </summary>
        public static readonly TestSetStatus Importing = new TestSetStatus("Importing");
        /// <summary>
        /// Constant PendingAnnotation for TestSetStatus
        /// </summary>
        public static readonly TestSetStatus PendingAnnotation = new TestSetStatus("PendingAnnotation");
        /// <summary>
        /// Constant Ready for TestSetStatus
        /// </summary>
        public static readonly TestSetStatus Ready = new TestSetStatus("Ready");
        /// <summary>
        /// Constant ValidationError for TestSetStatus
        /// </summary>
        public static readonly TestSetStatus ValidationError = new TestSetStatus("ValidationError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestSetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestSetStatus FindValue(string value)
        {
            return FindValue<TestSetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestSetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeDimension.
    /// </summary>
    public class TimeDimension : ConstantClass
    {

        /// <summary>
        /// Constant Days for TimeDimension
        /// </summary>
        public static readonly TimeDimension Days = new TimeDimension("Days");
        /// <summary>
        /// Constant Hours for TimeDimension
        /// </summary>
        public static readonly TimeDimension Hours = new TimeDimension("Hours");
        /// <summary>
        /// Constant Weeks for TimeDimension
        /// </summary>
        public static readonly TimeDimension Weeks = new TimeDimension("Weeks");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeDimension(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeDimension FindValue(string value)
        {
            return FindValue<TimeDimension>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeDimension(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscriptFormat.
    /// </summary>
    public class TranscriptFormat : ConstantClass
    {

        /// <summary>
        /// Constant Lex for TranscriptFormat
        /// </summary>
        public static readonly TranscriptFormat Lex = new TranscriptFormat("Lex");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscriptFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscriptFormat FindValue(string value)
        {
            return FindValue<TranscriptFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscriptFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UtteranceContentType.
    /// </summary>
    public class UtteranceContentType : ConstantClass
    {

        /// <summary>
        /// Constant CustomPayload for UtteranceContentType
        /// </summary>
        public static readonly UtteranceContentType CustomPayload = new UtteranceContentType("CustomPayload");
        /// <summary>
        /// Constant ImageResponseCard for UtteranceContentType
        /// </summary>
        public static readonly UtteranceContentType ImageResponseCard = new UtteranceContentType("ImageResponseCard");
        /// <summary>
        /// Constant PlainText for UtteranceContentType
        /// </summary>
        public static readonly UtteranceContentType PlainText = new UtteranceContentType("PlainText");
        /// <summary>
        /// Constant SSML for UtteranceContentType
        /// </summary>
        public static readonly UtteranceContentType SSML = new UtteranceContentType("SSML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UtteranceContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UtteranceContentType FindValue(string value)
        {
            return FindValue<UtteranceContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UtteranceContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VoiceEngine.
    /// </summary>
    public class VoiceEngine : ConstantClass
    {

        /// <summary>
        /// Constant Generative for VoiceEngine
        /// </summary>
        public static readonly VoiceEngine Generative = new VoiceEngine("generative");
        /// <summary>
        /// Constant LongForm for VoiceEngine
        /// </summary>
        public static readonly VoiceEngine LongForm = new VoiceEngine("long-form");
        /// <summary>
        /// Constant Neural for VoiceEngine
        /// </summary>
        public static readonly VoiceEngine Neural = new VoiceEngine("neural");
        /// <summary>
        /// Constant Standard for VoiceEngine
        /// </summary>
        public static readonly VoiceEngine Standard = new VoiceEngine("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VoiceEngine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VoiceEngine FindValue(string value)
        {
            return FindValue<VoiceEngine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VoiceEngine(string value)
        {
            return FindValue(value);
        }
    }

}