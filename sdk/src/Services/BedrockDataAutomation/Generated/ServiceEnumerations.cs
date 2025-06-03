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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BedrockDataAutomation
{

    /// <summary>
    /// Constants used for properties of type AudioExtractionCategoryType.
    /// </summary>
    public class AudioExtractionCategoryType : ConstantClass
    {

        /// <summary>
        /// Constant AUDIO_CONTENT_MODERATION for AudioExtractionCategoryType
        /// </summary>
        public static readonly AudioExtractionCategoryType AUDIO_CONTENT_MODERATION = new AudioExtractionCategoryType("AUDIO_CONTENT_MODERATION");
        /// <summary>
        /// Constant TOPIC_CONTENT_MODERATION for AudioExtractionCategoryType
        /// </summary>
        public static readonly AudioExtractionCategoryType TOPIC_CONTENT_MODERATION = new AudioExtractionCategoryType("TOPIC_CONTENT_MODERATION");
        /// <summary>
        /// Constant TRANSCRIPT for AudioExtractionCategoryType
        /// </summary>
        public static readonly AudioExtractionCategoryType TRANSCRIPT = new AudioExtractionCategoryType("TRANSCRIPT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioExtractionCategoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioExtractionCategoryType FindValue(string value)
        {
            return FindValue<AudioExtractionCategoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioExtractionCategoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioStandardGenerativeFieldType.
    /// </summary>
    public class AudioStandardGenerativeFieldType : ConstantClass
    {

        /// <summary>
        /// Constant AUDIO_SUMMARY for AudioStandardGenerativeFieldType
        /// </summary>
        public static readonly AudioStandardGenerativeFieldType AUDIO_SUMMARY = new AudioStandardGenerativeFieldType("AUDIO_SUMMARY");
        /// <summary>
        /// Constant IAB for AudioStandardGenerativeFieldType
        /// </summary>
        public static readonly AudioStandardGenerativeFieldType IAB = new AudioStandardGenerativeFieldType("IAB");
        /// <summary>
        /// Constant TOPIC_SUMMARY for AudioStandardGenerativeFieldType
        /// </summary>
        public static readonly AudioStandardGenerativeFieldType TOPIC_SUMMARY = new AudioStandardGenerativeFieldType("TOPIC_SUMMARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioStandardGenerativeFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioStandardGenerativeFieldType FindValue(string value)
        {
            return FindValue<AudioStandardGenerativeFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioStandardGenerativeFieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BlueprintStage.
    /// </summary>
    public class BlueprintStage : ConstantClass
    {

        /// <summary>
        /// Constant DEVELOPMENT for BlueprintStage
        /// </summary>
        public static readonly BlueprintStage DEVELOPMENT = new BlueprintStage("DEVELOPMENT");
        /// <summary>
        /// Constant LIVE for BlueprintStage
        /// </summary>
        public static readonly BlueprintStage LIVE = new BlueprintStage("LIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlueprintStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlueprintStage FindValue(string value)
        {
            return FindValue<BlueprintStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlueprintStage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BlueprintStageFilter.
    /// </summary>
    public class BlueprintStageFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for BlueprintStageFilter
        /// </summary>
        public static readonly BlueprintStageFilter ALL = new BlueprintStageFilter("ALL");
        /// <summary>
        /// Constant DEVELOPMENT for BlueprintStageFilter
        /// </summary>
        public static readonly BlueprintStageFilter DEVELOPMENT = new BlueprintStageFilter("DEVELOPMENT");
        /// <summary>
        /// Constant LIVE for BlueprintStageFilter
        /// </summary>
        public static readonly BlueprintStageFilter LIVE = new BlueprintStageFilter("LIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlueprintStageFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlueprintStageFilter FindValue(string value)
        {
            return FindValue<BlueprintStageFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlueprintStageFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataAutomationProjectStage.
    /// </summary>
    public class DataAutomationProjectStage : ConstantClass
    {

        /// <summary>
        /// Constant DEVELOPMENT for DataAutomationProjectStage
        /// </summary>
        public static readonly DataAutomationProjectStage DEVELOPMENT = new DataAutomationProjectStage("DEVELOPMENT");
        /// <summary>
        /// Constant LIVE for DataAutomationProjectStage
        /// </summary>
        public static readonly DataAutomationProjectStage LIVE = new DataAutomationProjectStage("LIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataAutomationProjectStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataAutomationProjectStage FindValue(string value)
        {
            return FindValue<DataAutomationProjectStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataAutomationProjectStage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataAutomationProjectStageFilter.
    /// </summary>
    public class DataAutomationProjectStageFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for DataAutomationProjectStageFilter
        /// </summary>
        public static readonly DataAutomationProjectStageFilter ALL = new DataAutomationProjectStageFilter("ALL");
        /// <summary>
        /// Constant DEVELOPMENT for DataAutomationProjectStageFilter
        /// </summary>
        public static readonly DataAutomationProjectStageFilter DEVELOPMENT = new DataAutomationProjectStageFilter("DEVELOPMENT");
        /// <summary>
        /// Constant LIVE for DataAutomationProjectStageFilter
        /// </summary>
        public static readonly DataAutomationProjectStageFilter LIVE = new DataAutomationProjectStageFilter("LIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataAutomationProjectStageFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataAutomationProjectStageFilter FindValue(string value)
        {
            return FindValue<DataAutomationProjectStageFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataAutomationProjectStageFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataAutomationProjectStatus.
    /// </summary>
    public class DataAutomationProjectStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for DataAutomationProjectStatus
        /// </summary>
        public static readonly DataAutomationProjectStatus COMPLETED = new DataAutomationProjectStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for DataAutomationProjectStatus
        /// </summary>
        public static readonly DataAutomationProjectStatus FAILED = new DataAutomationProjectStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for DataAutomationProjectStatus
        /// </summary>
        public static readonly DataAutomationProjectStatus IN_PROGRESS = new DataAutomationProjectStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataAutomationProjectStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataAutomationProjectStatus FindValue(string value)
        {
            return FindValue<DataAutomationProjectStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataAutomationProjectStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DesiredModality.
    /// </summary>
    public class DesiredModality : ConstantClass
    {

        /// <summary>
        /// Constant AUDIO for DesiredModality
        /// </summary>
        public static readonly DesiredModality AUDIO = new DesiredModality("AUDIO");
        /// <summary>
        /// Constant DOCUMENT for DesiredModality
        /// </summary>
        public static readonly DesiredModality DOCUMENT = new DesiredModality("DOCUMENT");
        /// <summary>
        /// Constant IMAGE for DesiredModality
        /// </summary>
        public static readonly DesiredModality IMAGE = new DesiredModality("IMAGE");
        /// <summary>
        /// Constant VIDEO for DesiredModality
        /// </summary>
        public static readonly DesiredModality VIDEO = new DesiredModality("VIDEO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DesiredModality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DesiredModality FindValue(string value)
        {
            return FindValue<DesiredModality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DesiredModality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentExtractionGranularityType.
    /// </summary>
    public class DocumentExtractionGranularityType : ConstantClass
    {

        /// <summary>
        /// Constant DOCUMENT for DocumentExtractionGranularityType
        /// </summary>
        public static readonly DocumentExtractionGranularityType DOCUMENT = new DocumentExtractionGranularityType("DOCUMENT");
        /// <summary>
        /// Constant ELEMENT for DocumentExtractionGranularityType
        /// </summary>
        public static readonly DocumentExtractionGranularityType ELEMENT = new DocumentExtractionGranularityType("ELEMENT");
        /// <summary>
        /// Constant LINE for DocumentExtractionGranularityType
        /// </summary>
        public static readonly DocumentExtractionGranularityType LINE = new DocumentExtractionGranularityType("LINE");
        /// <summary>
        /// Constant PAGE for DocumentExtractionGranularityType
        /// </summary>
        public static readonly DocumentExtractionGranularityType PAGE = new DocumentExtractionGranularityType("PAGE");
        /// <summary>
        /// Constant WORD for DocumentExtractionGranularityType
        /// </summary>
        public static readonly DocumentExtractionGranularityType WORD = new DocumentExtractionGranularityType("WORD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentExtractionGranularityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentExtractionGranularityType FindValue(string value)
        {
            return FindValue<DocumentExtractionGranularityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentExtractionGranularityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentOutputTextFormatType.
    /// </summary>
    public class DocumentOutputTextFormatType : ConstantClass
    {

        /// <summary>
        /// Constant CSV for DocumentOutputTextFormatType
        /// </summary>
        public static readonly DocumentOutputTextFormatType CSV = new DocumentOutputTextFormatType("CSV");
        /// <summary>
        /// Constant HTML for DocumentOutputTextFormatType
        /// </summary>
        public static readonly DocumentOutputTextFormatType HTML = new DocumentOutputTextFormatType("HTML");
        /// <summary>
        /// Constant MARKDOWN for DocumentOutputTextFormatType
        /// </summary>
        public static readonly DocumentOutputTextFormatType MARKDOWN = new DocumentOutputTextFormatType("MARKDOWN");
        /// <summary>
        /// Constant PLAIN_TEXT for DocumentOutputTextFormatType
        /// </summary>
        public static readonly DocumentOutputTextFormatType PLAIN_TEXT = new DocumentOutputTextFormatType("PLAIN_TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentOutputTextFormatType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentOutputTextFormatType FindValue(string value)
        {
            return FindValue<DocumentOutputTextFormatType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentOutputTextFormatType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageExtractionCategoryType.
    /// </summary>
    public class ImageExtractionCategoryType : ConstantClass
    {

        /// <summary>
        /// Constant CONTENT_MODERATION for ImageExtractionCategoryType
        /// </summary>
        public static readonly ImageExtractionCategoryType CONTENT_MODERATION = new ImageExtractionCategoryType("CONTENT_MODERATION");
        /// <summary>
        /// Constant LOGOS for ImageExtractionCategoryType
        /// </summary>
        public static readonly ImageExtractionCategoryType LOGOS = new ImageExtractionCategoryType("LOGOS");
        /// <summary>
        /// Constant TEXT_DETECTION for ImageExtractionCategoryType
        /// </summary>
        public static readonly ImageExtractionCategoryType TEXT_DETECTION = new ImageExtractionCategoryType("TEXT_DETECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageExtractionCategoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageExtractionCategoryType FindValue(string value)
        {
            return FindValue<ImageExtractionCategoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageExtractionCategoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageStandardGenerativeFieldType.
    /// </summary>
    public class ImageStandardGenerativeFieldType : ConstantClass
    {

        /// <summary>
        /// Constant IAB for ImageStandardGenerativeFieldType
        /// </summary>
        public static readonly ImageStandardGenerativeFieldType IAB = new ImageStandardGenerativeFieldType("IAB");
        /// <summary>
        /// Constant IMAGE_SUMMARY for ImageStandardGenerativeFieldType
        /// </summary>
        public static readonly ImageStandardGenerativeFieldType IMAGE_SUMMARY = new ImageStandardGenerativeFieldType("IMAGE_SUMMARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageStandardGenerativeFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageStandardGenerativeFieldType FindValue(string value)
        {
            return FindValue<ImageStandardGenerativeFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageStandardGenerativeFieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceOwner.
    /// </summary>
    public class ResourceOwner : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner ACCOUNT = new ResourceOwner("ACCOUNT");
        /// <summary>
        /// Constant SERVICE for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner SERVICE = new ResourceOwner("SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceOwner(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceOwner FindValue(string value)
        {
            return FindValue<ResourceOwner>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceOwner(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for State
        /// </summary>
        public static readonly State DISABLED = new State("DISABLED");
        /// <summary>
        /// Constant ENABLED for State
        /// </summary>
        public static readonly State ENABLED = new State("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant AUDIO for Type
        /// </summary>
        public static readonly Type AUDIO = new Type("AUDIO");
        /// <summary>
        /// Constant DOCUMENT for Type
        /// </summary>
        public static readonly Type DOCUMENT = new Type("DOCUMENT");
        /// <summary>
        /// Constant IMAGE for Type
        /// </summary>
        public static readonly Type IMAGE = new Type("IMAGE");
        /// <summary>
        /// Constant VIDEO for Type
        /// </summary>
        public static readonly Type VIDEO = new Type("VIDEO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Type FindValue(string value)
        {
            return FindValue<Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Type(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoExtractionCategoryType.
    /// </summary>
    public class VideoExtractionCategoryType : ConstantClass
    {

        /// <summary>
        /// Constant CONTENT_MODERATION for VideoExtractionCategoryType
        /// </summary>
        public static readonly VideoExtractionCategoryType CONTENT_MODERATION = new VideoExtractionCategoryType("CONTENT_MODERATION");
        /// <summary>
        /// Constant LOGOS for VideoExtractionCategoryType
        /// </summary>
        public static readonly VideoExtractionCategoryType LOGOS = new VideoExtractionCategoryType("LOGOS");
        /// <summary>
        /// Constant TEXT_DETECTION for VideoExtractionCategoryType
        /// </summary>
        public static readonly VideoExtractionCategoryType TEXT_DETECTION = new VideoExtractionCategoryType("TEXT_DETECTION");
        /// <summary>
        /// Constant TRANSCRIPT for VideoExtractionCategoryType
        /// </summary>
        public static readonly VideoExtractionCategoryType TRANSCRIPT = new VideoExtractionCategoryType("TRANSCRIPT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoExtractionCategoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoExtractionCategoryType FindValue(string value)
        {
            return FindValue<VideoExtractionCategoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoExtractionCategoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoStandardGenerativeFieldType.
    /// </summary>
    public class VideoStandardGenerativeFieldType : ConstantClass
    {

        /// <summary>
        /// Constant CHAPTER_SUMMARY for VideoStandardGenerativeFieldType
        /// </summary>
        public static readonly VideoStandardGenerativeFieldType CHAPTER_SUMMARY = new VideoStandardGenerativeFieldType("CHAPTER_SUMMARY");
        /// <summary>
        /// Constant IAB for VideoStandardGenerativeFieldType
        /// </summary>
        public static readonly VideoStandardGenerativeFieldType IAB = new VideoStandardGenerativeFieldType("IAB");
        /// <summary>
        /// Constant VIDEO_SUMMARY for VideoStandardGenerativeFieldType
        /// </summary>
        public static readonly VideoStandardGenerativeFieldType VIDEO_SUMMARY = new VideoStandardGenerativeFieldType("VIDEO_SUMMARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoStandardGenerativeFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoStandardGenerativeFieldType FindValue(string value)
        {
            return FindValue<VideoStandardGenerativeFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoStandardGenerativeFieldType(string value)
        {
            return FindValue(value);
        }
    }

}