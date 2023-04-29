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
    /// Constants used for properties of type ImportExportFileFormat.
    /// </summary>
    public class ImportExportFileFormat : ConstantClass
    {

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
    /// Constants used for properties of type VoiceEngine.
    /// </summary>
    public class VoiceEngine : ConstantClass
    {

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