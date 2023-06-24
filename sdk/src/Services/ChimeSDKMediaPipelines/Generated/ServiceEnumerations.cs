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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ChimeSDKMediaPipelines
{

    /// <summary>
    /// Constants used for properties of type ArtifactsConcatenationState.
    /// </summary>
    public class ArtifactsConcatenationState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ArtifactsConcatenationState
        /// </summary>
        public static readonly ArtifactsConcatenationState Disabled = new ArtifactsConcatenationState("Disabled");
        /// <summary>
        /// Constant Enabled for ArtifactsConcatenationState
        /// </summary>
        public static readonly ArtifactsConcatenationState Enabled = new ArtifactsConcatenationState("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactsConcatenationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactsConcatenationState FindValue(string value)
        {
            return FindValue<ArtifactsConcatenationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactsConcatenationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArtifactsState.
    /// </summary>
    public class ArtifactsState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ArtifactsState
        /// </summary>
        public static readonly ArtifactsState Disabled = new ArtifactsState("Disabled");
        /// <summary>
        /// Constant Enabled for ArtifactsState
        /// </summary>
        public static readonly ArtifactsState Enabled = new ArtifactsState("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactsState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactsState FindValue(string value)
        {
            return FindValue<ArtifactsState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactsState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioArtifactsConcatenationState.
    /// </summary>
    public class AudioArtifactsConcatenationState : ConstantClass
    {

        /// <summary>
        /// Constant Enabled for AudioArtifactsConcatenationState
        /// </summary>
        public static readonly AudioArtifactsConcatenationState Enabled = new AudioArtifactsConcatenationState("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioArtifactsConcatenationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioArtifactsConcatenationState FindValue(string value)
        {
            return FindValue<AudioArtifactsConcatenationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioArtifactsConcatenationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioChannelsOption.
    /// </summary>
    public class AudioChannelsOption : ConstantClass
    {

        /// <summary>
        /// Constant Mono for AudioChannelsOption
        /// </summary>
        public static readonly AudioChannelsOption Mono = new AudioChannelsOption("Mono");
        /// <summary>
        /// Constant Stereo for AudioChannelsOption
        /// </summary>
        public static readonly AudioChannelsOption Stereo = new AudioChannelsOption("Stereo");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioChannelsOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioChannelsOption FindValue(string value)
        {
            return FindValue<AudioChannelsOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioChannelsOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioMuxType.
    /// </summary>
    public class AudioMuxType : ConstantClass
    {

        /// <summary>
        /// Constant AudioOnly for AudioMuxType
        /// </summary>
        public static readonly AudioMuxType AudioOnly = new AudioMuxType("AudioOnly");
        /// <summary>
        /// Constant AudioWithActiveSpeakerVideo for AudioMuxType
        /// </summary>
        public static readonly AudioMuxType AudioWithActiveSpeakerVideo = new AudioMuxType("AudioWithActiveSpeakerVideo");
        /// <summary>
        /// Constant AudioWithCompositedVideo for AudioMuxType
        /// </summary>
        public static readonly AudioMuxType AudioWithCompositedVideo = new AudioMuxType("AudioWithCompositedVideo");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioMuxType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioMuxType FindValue(string value)
        {
            return FindValue<AudioMuxType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioMuxType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CallAnalyticsLanguageCode.
    /// </summary>
    public class CallAnalyticsLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant DeDE for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode DeDE = new CallAnalyticsLanguageCode("de-DE");
        /// <summary>
        /// Constant EnAU for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode EnAU = new CallAnalyticsLanguageCode("en-AU");
        /// <summary>
        /// Constant EnGB for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode EnGB = new CallAnalyticsLanguageCode("en-GB");
        /// <summary>
        /// Constant EnUS for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode EnUS = new CallAnalyticsLanguageCode("en-US");
        /// <summary>
        /// Constant EsUS for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode EsUS = new CallAnalyticsLanguageCode("es-US");
        /// <summary>
        /// Constant FrCA for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode FrCA = new CallAnalyticsLanguageCode("fr-CA");
        /// <summary>
        /// Constant FrFR for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode FrFR = new CallAnalyticsLanguageCode("fr-FR");
        /// <summary>
        /// Constant ItIT for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode ItIT = new CallAnalyticsLanguageCode("it-IT");
        /// <summary>
        /// Constant PtBR for CallAnalyticsLanguageCode
        /// </summary>
        public static readonly CallAnalyticsLanguageCode PtBR = new CallAnalyticsLanguageCode("pt-BR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CallAnalyticsLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CallAnalyticsLanguageCode FindValue(string value)
        {
            return FindValue<CallAnalyticsLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CallAnalyticsLanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConcatenationSinkType.
    /// </summary>
    public class ConcatenationSinkType : ConstantClass
    {

        /// <summary>
        /// Constant S3Bucket for ConcatenationSinkType
        /// </summary>
        public static readonly ConcatenationSinkType S3Bucket = new ConcatenationSinkType("S3Bucket");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConcatenationSinkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConcatenationSinkType FindValue(string value)
        {
            return FindValue<ConcatenationSinkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConcatenationSinkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConcatenationSourceType.
    /// </summary>
    public class ConcatenationSourceType : ConstantClass
    {

        /// <summary>
        /// Constant MediaCapturePipeline for ConcatenationSourceType
        /// </summary>
        public static readonly ConcatenationSourceType MediaCapturePipeline = new ConcatenationSourceType("MediaCapturePipeline");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConcatenationSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConcatenationSourceType FindValue(string value)
        {
            return FindValue<ConcatenationSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConcatenationSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentMuxType.
    /// </summary>
    public class ContentMuxType : ConstantClass
    {

        /// <summary>
        /// Constant ContentOnly for ContentMuxType
        /// </summary>
        public static readonly ContentMuxType ContentOnly = new ContentMuxType("ContentOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentMuxType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentMuxType FindValue(string value)
        {
            return FindValue<ContentMuxType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentMuxType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentRedactionOutput.
    /// </summary>
    public class ContentRedactionOutput : ConstantClass
    {

        /// <summary>
        /// Constant Redacted for ContentRedactionOutput
        /// </summary>
        public static readonly ContentRedactionOutput Redacted = new ContentRedactionOutput("redacted");
        /// <summary>
        /// Constant Redacted_and_unredacted for ContentRedactionOutput
        /// </summary>
        public static readonly ContentRedactionOutput Redacted_and_unredacted = new ContentRedactionOutput("redacted_and_unredacted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentRedactionOutput(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentRedactionOutput FindValue(string value)
        {
            return FindValue<ContentRedactionOutput>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentRedactionOutput(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentShareLayoutOption.
    /// </summary>
    public class ContentShareLayoutOption : ConstantClass
    {

        /// <summary>
        /// Constant Horizontal for ContentShareLayoutOption
        /// </summary>
        public static readonly ContentShareLayoutOption Horizontal = new ContentShareLayoutOption("Horizontal");
        /// <summary>
        /// Constant PresenterOnly for ContentShareLayoutOption
        /// </summary>
        public static readonly ContentShareLayoutOption PresenterOnly = new ContentShareLayoutOption("PresenterOnly");
        /// <summary>
        /// Constant Vertical for ContentShareLayoutOption
        /// </summary>
        public static readonly ContentShareLayoutOption Vertical = new ContentShareLayoutOption("Vertical");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentShareLayoutOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentShareLayoutOption FindValue(string value)
        {
            return FindValue<ContentShareLayoutOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentShareLayoutOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentType.
    /// </summary>
    public class ContentType : ConstantClass
    {

        /// <summary>
        /// Constant PII for ContentType
        /// </summary>
        public static readonly ContentType PII = new ContentType("PII");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentType FindValue(string value)
        {
            return FindValue<ContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentType(string value)
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
        /// Constant BadRequest for ErrorCode
        /// </summary>
        public static readonly ErrorCode BadRequest = new ErrorCode("BadRequest");
        /// <summary>
        /// Constant Forbidden for ErrorCode
        /// </summary>
        public static readonly ErrorCode Forbidden = new ErrorCode("Forbidden");
        /// <summary>
        /// Constant NotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode NotFound = new ErrorCode("NotFound");
        /// <summary>
        /// Constant ResourceLimitExceeded for ErrorCode
        /// </summary>
        public static readonly ErrorCode ResourceLimitExceeded = new ErrorCode("ResourceLimitExceeded");
        /// <summary>
        /// Constant ServiceFailure for ErrorCode
        /// </summary>
        public static readonly ErrorCode ServiceFailure = new ErrorCode("ServiceFailure");
        /// <summary>
        /// Constant ServiceUnavailable for ErrorCode
        /// </summary>
        public static readonly ErrorCode ServiceUnavailable = new ErrorCode("ServiceUnavailable");
        /// <summary>
        /// Constant Throttling for ErrorCode
        /// </summary>
        public static readonly ErrorCode Throttling = new ErrorCode("Throttling");

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
    /// Constants used for properties of type FragmentSelectorType.
    /// </summary>
    public class FragmentSelectorType : ConstantClass
    {

        /// <summary>
        /// Constant ProducerTimestamp for FragmentSelectorType
        /// </summary>
        public static readonly FragmentSelectorType ProducerTimestamp = new FragmentSelectorType("ProducerTimestamp");
        /// <summary>
        /// Constant ServerTimestamp for FragmentSelectorType
        /// </summary>
        public static readonly FragmentSelectorType ServerTimestamp = new FragmentSelectorType("ServerTimestamp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FragmentSelectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FragmentSelectorType FindValue(string value)
        {
            return FindValue<FragmentSelectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FragmentSelectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LayoutOption.
    /// </summary>
    public class LayoutOption : ConstantClass
    {

        /// <summary>
        /// Constant GridView for LayoutOption
        /// </summary>
        public static readonly LayoutOption GridView = new LayoutOption("GridView");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LayoutOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LayoutOption FindValue(string value)
        {
            return FindValue<LayoutOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LayoutOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LiveConnectorMuxType.
    /// </summary>
    public class LiveConnectorMuxType : ConstantClass
    {

        /// <summary>
        /// Constant AudioWithActiveSpeakerVideo for LiveConnectorMuxType
        /// </summary>
        public static readonly LiveConnectorMuxType AudioWithActiveSpeakerVideo = new LiveConnectorMuxType("AudioWithActiveSpeakerVideo");
        /// <summary>
        /// Constant AudioWithCompositedVideo for LiveConnectorMuxType
        /// </summary>
        public static readonly LiveConnectorMuxType AudioWithCompositedVideo = new LiveConnectorMuxType("AudioWithCompositedVideo");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LiveConnectorMuxType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LiveConnectorMuxType FindValue(string value)
        {
            return FindValue<LiveConnectorMuxType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LiveConnectorMuxType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LiveConnectorSinkType.
    /// </summary>
    public class LiveConnectorSinkType : ConstantClass
    {

        /// <summary>
        /// Constant RTMP for LiveConnectorSinkType
        /// </summary>
        public static readonly LiveConnectorSinkType RTMP = new LiveConnectorSinkType("RTMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LiveConnectorSinkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LiveConnectorSinkType FindValue(string value)
        {
            return FindValue<LiveConnectorSinkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LiveConnectorSinkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LiveConnectorSourceType.
    /// </summary>
    public class LiveConnectorSourceType : ConstantClass
    {

        /// <summary>
        /// Constant ChimeSdkMeeting for LiveConnectorSourceType
        /// </summary>
        public static readonly LiveConnectorSourceType ChimeSdkMeeting = new LiveConnectorSourceType("ChimeSdkMeeting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LiveConnectorSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LiveConnectorSourceType FindValue(string value)
        {
            return FindValue<LiveConnectorSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LiveConnectorSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaEncoding.
    /// </summary>
    public class MediaEncoding : ConstantClass
    {

        /// <summary>
        /// Constant Pcm for MediaEncoding
        /// </summary>
        public static readonly MediaEncoding Pcm = new MediaEncoding("pcm");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaEncoding FindValue(string value)
        {
            return FindValue<MediaEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaInsightsPipelineConfigurationElementType.
    /// </summary>
    public class MediaInsightsPipelineConfigurationElementType : ConstantClass
    {

        /// <summary>
        /// Constant AmazonTranscribeCallAnalyticsProcessor for MediaInsightsPipelineConfigurationElementType
        /// </summary>
        public static readonly MediaInsightsPipelineConfigurationElementType AmazonTranscribeCallAnalyticsProcessor = new MediaInsightsPipelineConfigurationElementType("AmazonTranscribeCallAnalyticsProcessor");
        /// <summary>
        /// Constant AmazonTranscribeProcessor for MediaInsightsPipelineConfigurationElementType
        /// </summary>
        public static readonly MediaInsightsPipelineConfigurationElementType AmazonTranscribeProcessor = new MediaInsightsPipelineConfigurationElementType("AmazonTranscribeProcessor");
        /// <summary>
        /// Constant KinesisDataStreamSink for MediaInsightsPipelineConfigurationElementType
        /// </summary>
        public static readonly MediaInsightsPipelineConfigurationElementType KinesisDataStreamSink = new MediaInsightsPipelineConfigurationElementType("KinesisDataStreamSink");
        /// <summary>
        /// Constant LambdaFunctionSink for MediaInsightsPipelineConfigurationElementType
        /// </summary>
        public static readonly MediaInsightsPipelineConfigurationElementType LambdaFunctionSink = new MediaInsightsPipelineConfigurationElementType("LambdaFunctionSink");
        /// <summary>
        /// Constant S3RecordingSink for MediaInsightsPipelineConfigurationElementType
        /// </summary>
        public static readonly MediaInsightsPipelineConfigurationElementType S3RecordingSink = new MediaInsightsPipelineConfigurationElementType("S3RecordingSink");
        /// <summary>
        /// Constant SnsTopicSink for MediaInsightsPipelineConfigurationElementType
        /// </summary>
        public static readonly MediaInsightsPipelineConfigurationElementType SnsTopicSink = new MediaInsightsPipelineConfigurationElementType("SnsTopicSink");
        /// <summary>
        /// Constant SqsQueueSink for MediaInsightsPipelineConfigurationElementType
        /// </summary>
        public static readonly MediaInsightsPipelineConfigurationElementType SqsQueueSink = new MediaInsightsPipelineConfigurationElementType("SqsQueueSink");
        /// <summary>
        /// Constant VoiceAnalyticsProcessor for MediaInsightsPipelineConfigurationElementType
        /// </summary>
        public static readonly MediaInsightsPipelineConfigurationElementType VoiceAnalyticsProcessor = new MediaInsightsPipelineConfigurationElementType("VoiceAnalyticsProcessor");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaInsightsPipelineConfigurationElementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaInsightsPipelineConfigurationElementType FindValue(string value)
        {
            return FindValue<MediaInsightsPipelineConfigurationElementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaInsightsPipelineConfigurationElementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaPipelineSinkType.
    /// </summary>
    public class MediaPipelineSinkType : ConstantClass
    {

        /// <summary>
        /// Constant S3Bucket for MediaPipelineSinkType
        /// </summary>
        public static readonly MediaPipelineSinkType S3Bucket = new MediaPipelineSinkType("S3Bucket");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaPipelineSinkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaPipelineSinkType FindValue(string value)
        {
            return FindValue<MediaPipelineSinkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaPipelineSinkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaPipelineSourceType.
    /// </summary>
    public class MediaPipelineSourceType : ConstantClass
    {

        /// <summary>
        /// Constant ChimeSdkMeeting for MediaPipelineSourceType
        /// </summary>
        public static readonly MediaPipelineSourceType ChimeSdkMeeting = new MediaPipelineSourceType("ChimeSdkMeeting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaPipelineSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaPipelineSourceType FindValue(string value)
        {
            return FindValue<MediaPipelineSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaPipelineSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaPipelineStatus.
    /// </summary>
    public class MediaPipelineStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Failed = new MediaPipelineStatus("Failed");
        /// <summary>
        /// Constant Initializing for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Initializing = new MediaPipelineStatus("Initializing");
        /// <summary>
        /// Constant InProgress for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus InProgress = new MediaPipelineStatus("InProgress");
        /// <summary>
        /// Constant Paused for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Paused = new MediaPipelineStatus("Paused");
        /// <summary>
        /// Constant Stopped for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Stopped = new MediaPipelineStatus("Stopped");
        /// <summary>
        /// Constant Stopping for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Stopping = new MediaPipelineStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaPipelineStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaPipelineStatus FindValue(string value)
        {
            return FindValue<MediaPipelineStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaPipelineStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaPipelineStatusUpdate.
    /// </summary>
    public class MediaPipelineStatusUpdate : ConstantClass
    {

        /// <summary>
        /// Constant Pause for MediaPipelineStatusUpdate
        /// </summary>
        public static readonly MediaPipelineStatusUpdate Pause = new MediaPipelineStatusUpdate("Pause");
        /// <summary>
        /// Constant Resume for MediaPipelineStatusUpdate
        /// </summary>
        public static readonly MediaPipelineStatusUpdate Resume = new MediaPipelineStatusUpdate("Resume");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaPipelineStatusUpdate(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaPipelineStatusUpdate FindValue(string value)
        {
            return FindValue<MediaPipelineStatusUpdate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaPipelineStatusUpdate(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PartialResultsStability.
    /// </summary>
    public class PartialResultsStability : ConstantClass
    {

        /// <summary>
        /// Constant High for PartialResultsStability
        /// </summary>
        public static readonly PartialResultsStability High = new PartialResultsStability("high");
        /// <summary>
        /// Constant Low for PartialResultsStability
        /// </summary>
        public static readonly PartialResultsStability Low = new PartialResultsStability("low");
        /// <summary>
        /// Constant Medium for PartialResultsStability
        /// </summary>
        public static readonly PartialResultsStability Medium = new PartialResultsStability("medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartialResultsStability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartialResultsStability FindValue(string value)
        {
            return FindValue<PartialResultsStability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartialResultsStability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantRole.
    /// </summary>
    public class ParticipantRole : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for ParticipantRole
        /// </summary>
        public static readonly ParticipantRole AGENT = new ParticipantRole("AGENT");
        /// <summary>
        /// Constant CUSTOMER for ParticipantRole
        /// </summary>
        public static readonly ParticipantRole CUSTOMER = new ParticipantRole("CUSTOMER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantRole FindValue(string value)
        {
            return FindValue<ParticipantRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PresenterPosition.
    /// </summary>
    public class PresenterPosition : ConstantClass
    {

        /// <summary>
        /// Constant BottomLeft for PresenterPosition
        /// </summary>
        public static readonly PresenterPosition BottomLeft = new PresenterPosition("BottomLeft");
        /// <summary>
        /// Constant BottomRight for PresenterPosition
        /// </summary>
        public static readonly PresenterPosition BottomRight = new PresenterPosition("BottomRight");
        /// <summary>
        /// Constant TopLeft for PresenterPosition
        /// </summary>
        public static readonly PresenterPosition TopLeft = new PresenterPosition("TopLeft");
        /// <summary>
        /// Constant TopRight for PresenterPosition
        /// </summary>
        public static readonly PresenterPosition TopRight = new PresenterPosition("TopRight");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PresenterPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PresenterPosition FindValue(string value)
        {
            return FindValue<PresenterPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PresenterPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RealTimeAlertRuleType.
    /// </summary>
    public class RealTimeAlertRuleType : ConstantClass
    {

        /// <summary>
        /// Constant IssueDetection for RealTimeAlertRuleType
        /// </summary>
        public static readonly RealTimeAlertRuleType IssueDetection = new RealTimeAlertRuleType("IssueDetection");
        /// <summary>
        /// Constant KeywordMatch for RealTimeAlertRuleType
        /// </summary>
        public static readonly RealTimeAlertRuleType KeywordMatch = new RealTimeAlertRuleType("KeywordMatch");
        /// <summary>
        /// Constant Sentiment for RealTimeAlertRuleType
        /// </summary>
        public static readonly RealTimeAlertRuleType Sentiment = new RealTimeAlertRuleType("Sentiment");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RealTimeAlertRuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RealTimeAlertRuleType FindValue(string value)
        {
            return FindValue<RealTimeAlertRuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RealTimeAlertRuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordingFileFormat.
    /// </summary>
    public class RecordingFileFormat : ConstantClass
    {

        /// <summary>
        /// Constant Opus for RecordingFileFormat
        /// </summary>
        public static readonly RecordingFileFormat Opus = new RecordingFileFormat("Opus");
        /// <summary>
        /// Constant Wav for RecordingFileFormat
        /// </summary>
        public static readonly RecordingFileFormat Wav = new RecordingFileFormat("Wav");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordingFileFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordingFileFormat FindValue(string value)
        {
            return FindValue<RecordingFileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordingFileFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolutionOption.
    /// </summary>
    public class ResolutionOption : ConstantClass
    {

        /// <summary>
        /// Constant FHD for ResolutionOption
        /// </summary>
        public static readonly ResolutionOption FHD = new ResolutionOption("FHD");
        /// <summary>
        /// Constant HD for ResolutionOption
        /// </summary>
        public static readonly ResolutionOption HD = new ResolutionOption("HD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolutionOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolutionOption FindValue(string value)
        {
            return FindValue<ResolutionOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolutionOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SentimentType.
    /// </summary>
    public class SentimentType : ConstantClass
    {

        /// <summary>
        /// Constant NEGATIVE for SentimentType
        /// </summary>
        public static readonly SentimentType NEGATIVE = new SentimentType("NEGATIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SentimentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SentimentType FindValue(string value)
        {
            return FindValue<SentimentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SentimentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoMuxType.
    /// </summary>
    public class VideoMuxType : ConstantClass
    {

        /// <summary>
        /// Constant VideoOnly for VideoMuxType
        /// </summary>
        public static readonly VideoMuxType VideoOnly = new VideoMuxType("VideoOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoMuxType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoMuxType FindValue(string value)
        {
            return FindValue<VideoMuxType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoMuxType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VocabularyFilterMethod.
    /// </summary>
    public class VocabularyFilterMethod : ConstantClass
    {

        /// <summary>
        /// Constant Mask for VocabularyFilterMethod
        /// </summary>
        public static readonly VocabularyFilterMethod Mask = new VocabularyFilterMethod("mask");
        /// <summary>
        /// Constant Remove for VocabularyFilterMethod
        /// </summary>
        public static readonly VocabularyFilterMethod Remove = new VocabularyFilterMethod("remove");
        /// <summary>
        /// Constant Tag for VocabularyFilterMethod
        /// </summary>
        public static readonly VocabularyFilterMethod Tag = new VocabularyFilterMethod("tag");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VocabularyFilterMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VocabularyFilterMethod FindValue(string value)
        {
            return FindValue<VocabularyFilterMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VocabularyFilterMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VoiceAnalyticsConfigurationStatus.
    /// </summary>
    public class VoiceAnalyticsConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for VoiceAnalyticsConfigurationStatus
        /// </summary>
        public static readonly VoiceAnalyticsConfigurationStatus Disabled = new VoiceAnalyticsConfigurationStatus("Disabled");
        /// <summary>
        /// Constant Enabled for VoiceAnalyticsConfigurationStatus
        /// </summary>
        public static readonly VoiceAnalyticsConfigurationStatus Enabled = new VoiceAnalyticsConfigurationStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VoiceAnalyticsConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VoiceAnalyticsConfigurationStatus FindValue(string value)
        {
            return FindValue<VoiceAnalyticsConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VoiceAnalyticsConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }

}