/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MediaConvert
{

    /// <summary>
    /// Constants used for properties of type AacAudioDescriptionBroadcasterMix.
    /// </summary>
    public class AacAudioDescriptionBroadcasterMix : ConstantClass
    {

        /// <summary>
        /// Constant BROADCASTER_MIXED_AD for AacAudioDescriptionBroadcasterMix
        /// </summary>
        public static readonly AacAudioDescriptionBroadcasterMix BROADCASTER_MIXED_AD = new AacAudioDescriptionBroadcasterMix("BROADCASTER_MIXED_AD");
        /// <summary>
        /// Constant NORMAL for AacAudioDescriptionBroadcasterMix
        /// </summary>
        public static readonly AacAudioDescriptionBroadcasterMix NORMAL = new AacAudioDescriptionBroadcasterMix("NORMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AacAudioDescriptionBroadcasterMix(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AacAudioDescriptionBroadcasterMix FindValue(string value)
        {
            return FindValue<AacAudioDescriptionBroadcasterMix>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AacAudioDescriptionBroadcasterMix(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AacCodecProfile.
    /// </summary>
    public class AacCodecProfile : ConstantClass
    {

        /// <summary>
        /// Constant HEV1 for AacCodecProfile
        /// </summary>
        public static readonly AacCodecProfile HEV1 = new AacCodecProfile("HEV1");
        /// <summary>
        /// Constant HEV2 for AacCodecProfile
        /// </summary>
        public static readonly AacCodecProfile HEV2 = new AacCodecProfile("HEV2");
        /// <summary>
        /// Constant LC for AacCodecProfile
        /// </summary>
        public static readonly AacCodecProfile LC = new AacCodecProfile("LC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AacCodecProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AacCodecProfile FindValue(string value)
        {
            return FindValue<AacCodecProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AacCodecProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AacCodingMode.
    /// </summary>
    public class AacCodingMode : ConstantClass
    {

        /// <summary>
        /// Constant AD_RECEIVER_MIX for AacCodingMode
        /// </summary>
        public static readonly AacCodingMode AD_RECEIVER_MIX = new AacCodingMode("AD_RECEIVER_MIX");
        /// <summary>
        /// Constant CODING_MODE_1_0 for AacCodingMode
        /// </summary>
        public static readonly AacCodingMode CODING_MODE_1_0 = new AacCodingMode("CODING_MODE_1_0");
        /// <summary>
        /// Constant CODING_MODE_1_1 for AacCodingMode
        /// </summary>
        public static readonly AacCodingMode CODING_MODE_1_1 = new AacCodingMode("CODING_MODE_1_1");
        /// <summary>
        /// Constant CODING_MODE_2_0 for AacCodingMode
        /// </summary>
        public static readonly AacCodingMode CODING_MODE_2_0 = new AacCodingMode("CODING_MODE_2_0");
        /// <summary>
        /// Constant CODING_MODE_5_1 for AacCodingMode
        /// </summary>
        public static readonly AacCodingMode CODING_MODE_5_1 = new AacCodingMode("CODING_MODE_5_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AacCodingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AacCodingMode FindValue(string value)
        {
            return FindValue<AacCodingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AacCodingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AacRateControlMode.
    /// </summary>
    public class AacRateControlMode : ConstantClass
    {

        /// <summary>
        /// Constant CBR for AacRateControlMode
        /// </summary>
        public static readonly AacRateControlMode CBR = new AacRateControlMode("CBR");
        /// <summary>
        /// Constant VBR for AacRateControlMode
        /// </summary>
        public static readonly AacRateControlMode VBR = new AacRateControlMode("VBR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AacRateControlMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AacRateControlMode FindValue(string value)
        {
            return FindValue<AacRateControlMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AacRateControlMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AacRawFormat.
    /// </summary>
    public class AacRawFormat : ConstantClass
    {

        /// <summary>
        /// Constant LATM_LOAS for AacRawFormat
        /// </summary>
        public static readonly AacRawFormat LATM_LOAS = new AacRawFormat("LATM_LOAS");
        /// <summary>
        /// Constant NONE for AacRawFormat
        /// </summary>
        public static readonly AacRawFormat NONE = new AacRawFormat("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AacRawFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AacRawFormat FindValue(string value)
        {
            return FindValue<AacRawFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AacRawFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AacSpecification.
    /// </summary>
    public class AacSpecification : ConstantClass
    {

        /// <summary>
        /// Constant MPEG2 for AacSpecification
        /// </summary>
        public static readonly AacSpecification MPEG2 = new AacSpecification("MPEG2");
        /// <summary>
        /// Constant MPEG4 for AacSpecification
        /// </summary>
        public static readonly AacSpecification MPEG4 = new AacSpecification("MPEG4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AacSpecification(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AacSpecification FindValue(string value)
        {
            return FindValue<AacSpecification>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AacSpecification(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AacVbrQuality.
    /// </summary>
    public class AacVbrQuality : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for AacVbrQuality
        /// </summary>
        public static readonly AacVbrQuality HIGH = new AacVbrQuality("HIGH");
        /// <summary>
        /// Constant LOW for AacVbrQuality
        /// </summary>
        public static readonly AacVbrQuality LOW = new AacVbrQuality("LOW");
        /// <summary>
        /// Constant MEDIUM_HIGH for AacVbrQuality
        /// </summary>
        public static readonly AacVbrQuality MEDIUM_HIGH = new AacVbrQuality("MEDIUM_HIGH");
        /// <summary>
        /// Constant MEDIUM_LOW for AacVbrQuality
        /// </summary>
        public static readonly AacVbrQuality MEDIUM_LOW = new AacVbrQuality("MEDIUM_LOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AacVbrQuality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AacVbrQuality FindValue(string value)
        {
            return FindValue<AacVbrQuality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AacVbrQuality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ac3BitstreamMode.
    /// </summary>
    public class Ac3BitstreamMode : ConstantClass
    {

        /// <summary>
        /// Constant COMMENTARY for Ac3BitstreamMode
        /// </summary>
        public static readonly Ac3BitstreamMode COMMENTARY = new Ac3BitstreamMode("COMMENTARY");
        /// <summary>
        /// Constant COMPLETE_MAIN for Ac3BitstreamMode
        /// </summary>
        public static readonly Ac3BitstreamMode COMPLETE_MAIN = new Ac3BitstreamMode("COMPLETE_MAIN");
        /// <summary>
        /// Constant DIALOGUE for Ac3BitstreamMode
        /// </summary>
        public static readonly Ac3BitstreamMode DIALOGUE = new Ac3BitstreamMode("DIALOGUE");
        /// <summary>
        /// Constant EMERGENCY for Ac3BitstreamMode
        /// </summary>
        public static readonly Ac3BitstreamMode EMERGENCY = new Ac3BitstreamMode("EMERGENCY");
        /// <summary>
        /// Constant HEARING_IMPAIRED for Ac3BitstreamMode
        /// </summary>
        public static readonly Ac3BitstreamMode HEARING_IMPAIRED = new Ac3BitstreamMode("HEARING_IMPAIRED");
        /// <summary>
        /// Constant MUSIC_AND_EFFECTS for Ac3BitstreamMode
        /// </summary>
        public static readonly Ac3BitstreamMode MUSIC_AND_EFFECTS = new Ac3BitstreamMode("MUSIC_AND_EFFECTS");
        /// <summary>
        /// Constant VISUALLY_IMPAIRED for Ac3BitstreamMode
        /// </summary>
        public static readonly Ac3BitstreamMode VISUALLY_IMPAIRED = new Ac3BitstreamMode("VISUALLY_IMPAIRED");
        /// <summary>
        /// Constant VOICE_OVER for Ac3BitstreamMode
        /// </summary>
        public static readonly Ac3BitstreamMode VOICE_OVER = new Ac3BitstreamMode("VOICE_OVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ac3BitstreamMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ac3BitstreamMode FindValue(string value)
        {
            return FindValue<Ac3BitstreamMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ac3BitstreamMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ac3CodingMode.
    /// </summary>
    public class Ac3CodingMode : ConstantClass
    {

        /// <summary>
        /// Constant CODING_MODE_1_0 for Ac3CodingMode
        /// </summary>
        public static readonly Ac3CodingMode CODING_MODE_1_0 = new Ac3CodingMode("CODING_MODE_1_0");
        /// <summary>
        /// Constant CODING_MODE_1_1 for Ac3CodingMode
        /// </summary>
        public static readonly Ac3CodingMode CODING_MODE_1_1 = new Ac3CodingMode("CODING_MODE_1_1");
        /// <summary>
        /// Constant CODING_MODE_2_0 for Ac3CodingMode
        /// </summary>
        public static readonly Ac3CodingMode CODING_MODE_2_0 = new Ac3CodingMode("CODING_MODE_2_0");
        /// <summary>
        /// Constant CODING_MODE_3_2_LFE for Ac3CodingMode
        /// </summary>
        public static readonly Ac3CodingMode CODING_MODE_3_2_LFE = new Ac3CodingMode("CODING_MODE_3_2_LFE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ac3CodingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ac3CodingMode FindValue(string value)
        {
            return FindValue<Ac3CodingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ac3CodingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ac3DynamicRangeCompressionProfile.
    /// </summary>
    public class Ac3DynamicRangeCompressionProfile : ConstantClass
    {

        /// <summary>
        /// Constant FILM_STANDARD for Ac3DynamicRangeCompressionProfile
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionProfile FILM_STANDARD = new Ac3DynamicRangeCompressionProfile("FILM_STANDARD");
        /// <summary>
        /// Constant NONE for Ac3DynamicRangeCompressionProfile
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionProfile NONE = new Ac3DynamicRangeCompressionProfile("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ac3DynamicRangeCompressionProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ac3DynamicRangeCompressionProfile FindValue(string value)
        {
            return FindValue<Ac3DynamicRangeCompressionProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ac3DynamicRangeCompressionProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ac3LfeFilter.
    /// </summary>
    public class Ac3LfeFilter : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Ac3LfeFilter
        /// </summary>
        public static readonly Ac3LfeFilter DISABLED = new Ac3LfeFilter("DISABLED");
        /// <summary>
        /// Constant ENABLED for Ac3LfeFilter
        /// </summary>
        public static readonly Ac3LfeFilter ENABLED = new Ac3LfeFilter("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ac3LfeFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ac3LfeFilter FindValue(string value)
        {
            return FindValue<Ac3LfeFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ac3LfeFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ac3MetadataControl.
    /// </summary>
    public class Ac3MetadataControl : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW_INPUT for Ac3MetadataControl
        /// </summary>
        public static readonly Ac3MetadataControl FOLLOW_INPUT = new Ac3MetadataControl("FOLLOW_INPUT");
        /// <summary>
        /// Constant USE_CONFIGURED for Ac3MetadataControl
        /// </summary>
        public static readonly Ac3MetadataControl USE_CONFIGURED = new Ac3MetadataControl("USE_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ac3MetadataControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ac3MetadataControl FindValue(string value)
        {
            return FindValue<Ac3MetadataControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ac3MetadataControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AfdSignaling.
    /// </summary>
    public class AfdSignaling : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for AfdSignaling
        /// </summary>
        public static readonly AfdSignaling AUTO = new AfdSignaling("AUTO");
        /// <summary>
        /// Constant FIXED for AfdSignaling
        /// </summary>
        public static readonly AfdSignaling FIXED = new AfdSignaling("FIXED");
        /// <summary>
        /// Constant NONE for AfdSignaling
        /// </summary>
        public static readonly AfdSignaling NONE = new AfdSignaling("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AfdSignaling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AfdSignaling FindValue(string value)
        {
            return FindValue<AfdSignaling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AfdSignaling(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AntiAlias.
    /// </summary>
    public class AntiAlias : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AntiAlias
        /// </summary>
        public static readonly AntiAlias DISABLED = new AntiAlias("DISABLED");
        /// <summary>
        /// Constant ENABLED for AntiAlias
        /// </summary>
        public static readonly AntiAlias ENABLED = new AntiAlias("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AntiAlias(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AntiAlias FindValue(string value)
        {
            return FindValue<AntiAlias>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AntiAlias(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioCodec.
    /// </summary>
    public class AudioCodec : ConstantClass
    {

        /// <summary>
        /// Constant AAC for AudioCodec
        /// </summary>
        public static readonly AudioCodec AAC = new AudioCodec("AAC");
        /// <summary>
        /// Constant AC3 for AudioCodec
        /// </summary>
        public static readonly AudioCodec AC3 = new AudioCodec("AC3");
        /// <summary>
        /// Constant AIFF for AudioCodec
        /// </summary>
        public static readonly AudioCodec AIFF = new AudioCodec("AIFF");
        /// <summary>
        /// Constant EAC3 for AudioCodec
        /// </summary>
        public static readonly AudioCodec EAC3 = new AudioCodec("EAC3");
        /// <summary>
        /// Constant MP2 for AudioCodec
        /// </summary>
        public static readonly AudioCodec MP2 = new AudioCodec("MP2");
        /// <summary>
        /// Constant PASSTHROUGH for AudioCodec
        /// </summary>
        public static readonly AudioCodec PASSTHROUGH = new AudioCodec("PASSTHROUGH");
        /// <summary>
        /// Constant WAV for AudioCodec
        /// </summary>
        public static readonly AudioCodec WAV = new AudioCodec("WAV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioCodec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioCodec FindValue(string value)
        {
            return FindValue<AudioCodec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioCodec(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioDefaultSelection.
    /// </summary>
    public class AudioDefaultSelection : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for AudioDefaultSelection
        /// </summary>
        public static readonly AudioDefaultSelection DEFAULT = new AudioDefaultSelection("DEFAULT");
        /// <summary>
        /// Constant NOT_DEFAULT for AudioDefaultSelection
        /// </summary>
        public static readonly AudioDefaultSelection NOT_DEFAULT = new AudioDefaultSelection("NOT_DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioDefaultSelection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioDefaultSelection FindValue(string value)
        {
            return FindValue<AudioDefaultSelection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioDefaultSelection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioLanguageCodeControl.
    /// </summary>
    public class AudioLanguageCodeControl : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW_INPUT for AudioLanguageCodeControl
        /// </summary>
        public static readonly AudioLanguageCodeControl FOLLOW_INPUT = new AudioLanguageCodeControl("FOLLOW_INPUT");
        /// <summary>
        /// Constant USE_CONFIGURED for AudioLanguageCodeControl
        /// </summary>
        public static readonly AudioLanguageCodeControl USE_CONFIGURED = new AudioLanguageCodeControl("USE_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioLanguageCodeControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioLanguageCodeControl FindValue(string value)
        {
            return FindValue<AudioLanguageCodeControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioLanguageCodeControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioNormalizationAlgorithm.
    /// </summary>
    public class AudioNormalizationAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant ITU_BS_1770_1 for AudioNormalizationAlgorithm
        /// </summary>
        public static readonly AudioNormalizationAlgorithm ITU_BS_1770_1 = new AudioNormalizationAlgorithm("ITU_BS_1770_1");
        /// <summary>
        /// Constant ITU_BS_1770_2 for AudioNormalizationAlgorithm
        /// </summary>
        public static readonly AudioNormalizationAlgorithm ITU_BS_1770_2 = new AudioNormalizationAlgorithm("ITU_BS_1770_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioNormalizationAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioNormalizationAlgorithm FindValue(string value)
        {
            return FindValue<AudioNormalizationAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioNormalizationAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioNormalizationAlgorithmControl.
    /// </summary>
    public class AudioNormalizationAlgorithmControl : ConstantClass
    {

        /// <summary>
        /// Constant CORRECT_AUDIO for AudioNormalizationAlgorithmControl
        /// </summary>
        public static readonly AudioNormalizationAlgorithmControl CORRECT_AUDIO = new AudioNormalizationAlgorithmControl("CORRECT_AUDIO");
        /// <summary>
        /// Constant MEASURE_ONLY for AudioNormalizationAlgorithmControl
        /// </summary>
        public static readonly AudioNormalizationAlgorithmControl MEASURE_ONLY = new AudioNormalizationAlgorithmControl("MEASURE_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioNormalizationAlgorithmControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioNormalizationAlgorithmControl FindValue(string value)
        {
            return FindValue<AudioNormalizationAlgorithmControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioNormalizationAlgorithmControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioNormalizationLoudnessLogging.
    /// </summary>
    public class AudioNormalizationLoudnessLogging : ConstantClass
    {

        /// <summary>
        /// Constant DONT_LOG for AudioNormalizationLoudnessLogging
        /// </summary>
        public static readonly AudioNormalizationLoudnessLogging DONT_LOG = new AudioNormalizationLoudnessLogging("DONT_LOG");
        /// <summary>
        /// Constant LOG for AudioNormalizationLoudnessLogging
        /// </summary>
        public static readonly AudioNormalizationLoudnessLogging LOG = new AudioNormalizationLoudnessLogging("LOG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioNormalizationLoudnessLogging(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioNormalizationLoudnessLogging FindValue(string value)
        {
            return FindValue<AudioNormalizationLoudnessLogging>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioNormalizationLoudnessLogging(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioNormalizationPeakCalculation.
    /// </summary>
    public class AudioNormalizationPeakCalculation : ConstantClass
    {

        /// <summary>
        /// Constant NONE for AudioNormalizationPeakCalculation
        /// </summary>
        public static readonly AudioNormalizationPeakCalculation NONE = new AudioNormalizationPeakCalculation("NONE");
        /// <summary>
        /// Constant TRUE_PEAK for AudioNormalizationPeakCalculation
        /// </summary>
        public static readonly AudioNormalizationPeakCalculation TRUE_PEAK = new AudioNormalizationPeakCalculation("TRUE_PEAK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioNormalizationPeakCalculation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioNormalizationPeakCalculation FindValue(string value)
        {
            return FindValue<AudioNormalizationPeakCalculation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioNormalizationPeakCalculation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioSelectorType.
    /// </summary>
    public class AudioSelectorType : ConstantClass
    {

        /// <summary>
        /// Constant LANGUAGE_CODE for AudioSelectorType
        /// </summary>
        public static readonly AudioSelectorType LANGUAGE_CODE = new AudioSelectorType("LANGUAGE_CODE");
        /// <summary>
        /// Constant PID for AudioSelectorType
        /// </summary>
        public static readonly AudioSelectorType PID = new AudioSelectorType("PID");
        /// <summary>
        /// Constant TRACK for AudioSelectorType
        /// </summary>
        public static readonly AudioSelectorType TRACK = new AudioSelectorType("TRACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioSelectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioSelectorType FindValue(string value)
        {
            return FindValue<AudioSelectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioSelectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioTypeControl.
    /// </summary>
    public class AudioTypeControl : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW_INPUT for AudioTypeControl
        /// </summary>
        public static readonly AudioTypeControl FOLLOW_INPUT = new AudioTypeControl("FOLLOW_INPUT");
        /// <summary>
        /// Constant USE_CONFIGURED for AudioTypeControl
        /// </summary>
        public static readonly AudioTypeControl USE_CONFIGURED = new AudioTypeControl("USE_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioTypeControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioTypeControl FindValue(string value)
        {
            return FindValue<AudioTypeControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioTypeControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurninSubtitleAlignment.
    /// </summary>
    public class BurninSubtitleAlignment : ConstantClass
    {

        /// <summary>
        /// Constant CENTERED for BurninSubtitleAlignment
        /// </summary>
        public static readonly BurninSubtitleAlignment CENTERED = new BurninSubtitleAlignment("CENTERED");
        /// <summary>
        /// Constant LEFT for BurninSubtitleAlignment
        /// </summary>
        public static readonly BurninSubtitleAlignment LEFT = new BurninSubtitleAlignment("LEFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurninSubtitleAlignment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurninSubtitleAlignment FindValue(string value)
        {
            return FindValue<BurninSubtitleAlignment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurninSubtitleAlignment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurninSubtitleBackgroundColor.
    /// </summary>
    public class BurninSubtitleBackgroundColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for BurninSubtitleBackgroundColor
        /// </summary>
        public static readonly BurninSubtitleBackgroundColor BLACK = new BurninSubtitleBackgroundColor("BLACK");
        /// <summary>
        /// Constant NONE for BurninSubtitleBackgroundColor
        /// </summary>
        public static readonly BurninSubtitleBackgroundColor NONE = new BurninSubtitleBackgroundColor("NONE");
        /// <summary>
        /// Constant WHITE for BurninSubtitleBackgroundColor
        /// </summary>
        public static readonly BurninSubtitleBackgroundColor WHITE = new BurninSubtitleBackgroundColor("WHITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurninSubtitleBackgroundColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurninSubtitleBackgroundColor FindValue(string value)
        {
            return FindValue<BurninSubtitleBackgroundColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurninSubtitleBackgroundColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurninSubtitleFontColor.
    /// </summary>
    public class BurninSubtitleFontColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for BurninSubtitleFontColor
        /// </summary>
        public static readonly BurninSubtitleFontColor BLACK = new BurninSubtitleFontColor("BLACK");
        /// <summary>
        /// Constant BLUE for BurninSubtitleFontColor
        /// </summary>
        public static readonly BurninSubtitleFontColor BLUE = new BurninSubtitleFontColor("BLUE");
        /// <summary>
        /// Constant GREEN for BurninSubtitleFontColor
        /// </summary>
        public static readonly BurninSubtitleFontColor GREEN = new BurninSubtitleFontColor("GREEN");
        /// <summary>
        /// Constant RED for BurninSubtitleFontColor
        /// </summary>
        public static readonly BurninSubtitleFontColor RED = new BurninSubtitleFontColor("RED");
        /// <summary>
        /// Constant WHITE for BurninSubtitleFontColor
        /// </summary>
        public static readonly BurninSubtitleFontColor WHITE = new BurninSubtitleFontColor("WHITE");
        /// <summary>
        /// Constant YELLOW for BurninSubtitleFontColor
        /// </summary>
        public static readonly BurninSubtitleFontColor YELLOW = new BurninSubtitleFontColor("YELLOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurninSubtitleFontColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurninSubtitleFontColor FindValue(string value)
        {
            return FindValue<BurninSubtitleFontColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurninSubtitleFontColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurninSubtitleOutlineColor.
    /// </summary>
    public class BurninSubtitleOutlineColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for BurninSubtitleOutlineColor
        /// </summary>
        public static readonly BurninSubtitleOutlineColor BLACK = new BurninSubtitleOutlineColor("BLACK");
        /// <summary>
        /// Constant BLUE for BurninSubtitleOutlineColor
        /// </summary>
        public static readonly BurninSubtitleOutlineColor BLUE = new BurninSubtitleOutlineColor("BLUE");
        /// <summary>
        /// Constant GREEN for BurninSubtitleOutlineColor
        /// </summary>
        public static readonly BurninSubtitleOutlineColor GREEN = new BurninSubtitleOutlineColor("GREEN");
        /// <summary>
        /// Constant RED for BurninSubtitleOutlineColor
        /// </summary>
        public static readonly BurninSubtitleOutlineColor RED = new BurninSubtitleOutlineColor("RED");
        /// <summary>
        /// Constant WHITE for BurninSubtitleOutlineColor
        /// </summary>
        public static readonly BurninSubtitleOutlineColor WHITE = new BurninSubtitleOutlineColor("WHITE");
        /// <summary>
        /// Constant YELLOW for BurninSubtitleOutlineColor
        /// </summary>
        public static readonly BurninSubtitleOutlineColor YELLOW = new BurninSubtitleOutlineColor("YELLOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurninSubtitleOutlineColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurninSubtitleOutlineColor FindValue(string value)
        {
            return FindValue<BurninSubtitleOutlineColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurninSubtitleOutlineColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurninSubtitleShadowColor.
    /// </summary>
    public class BurninSubtitleShadowColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for BurninSubtitleShadowColor
        /// </summary>
        public static readonly BurninSubtitleShadowColor BLACK = new BurninSubtitleShadowColor("BLACK");
        /// <summary>
        /// Constant NONE for BurninSubtitleShadowColor
        /// </summary>
        public static readonly BurninSubtitleShadowColor NONE = new BurninSubtitleShadowColor("NONE");
        /// <summary>
        /// Constant WHITE for BurninSubtitleShadowColor
        /// </summary>
        public static readonly BurninSubtitleShadowColor WHITE = new BurninSubtitleShadowColor("WHITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurninSubtitleShadowColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurninSubtitleShadowColor FindValue(string value)
        {
            return FindValue<BurninSubtitleShadowColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurninSubtitleShadowColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurninSubtitleTeletextSpacing.
    /// </summary>
    public class BurninSubtitleTeletextSpacing : ConstantClass
    {

        /// <summary>
        /// Constant FIXED_GRID for BurninSubtitleTeletextSpacing
        /// </summary>
        public static readonly BurninSubtitleTeletextSpacing FIXED_GRID = new BurninSubtitleTeletextSpacing("FIXED_GRID");
        /// <summary>
        /// Constant PROPORTIONAL for BurninSubtitleTeletextSpacing
        /// </summary>
        public static readonly BurninSubtitleTeletextSpacing PROPORTIONAL = new BurninSubtitleTeletextSpacing("PROPORTIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurninSubtitleTeletextSpacing(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurninSubtitleTeletextSpacing FindValue(string value)
        {
            return FindValue<BurninSubtitleTeletextSpacing>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurninSubtitleTeletextSpacing(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CaptionDestinationType.
    /// </summary>
    public class CaptionDestinationType : ConstantClass
    {

        /// <summary>
        /// Constant BURN_IN for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType BURN_IN = new CaptionDestinationType("BURN_IN");
        /// <summary>
        /// Constant DVB_SUB for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType DVB_SUB = new CaptionDestinationType("DVB_SUB");
        /// <summary>
        /// Constant EMBEDDED for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType EMBEDDED = new CaptionDestinationType("EMBEDDED");
        /// <summary>
        /// Constant SCC for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType SCC = new CaptionDestinationType("SCC");
        /// <summary>
        /// Constant SRT for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType SRT = new CaptionDestinationType("SRT");
        /// <summary>
        /// Constant TELETEXT for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType TELETEXT = new CaptionDestinationType("TELETEXT");
        /// <summary>
        /// Constant TTML for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType TTML = new CaptionDestinationType("TTML");
        /// <summary>
        /// Constant WEBVTT for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType WEBVTT = new CaptionDestinationType("WEBVTT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CaptionDestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CaptionDestinationType FindValue(string value)
        {
            return FindValue<CaptionDestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CaptionDestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CaptionSourceType.
    /// </summary>
    public class CaptionSourceType : ConstantClass
    {

        /// <summary>
        /// Constant ANCILLARY for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType ANCILLARY = new CaptionSourceType("ANCILLARY");
        /// <summary>
        /// Constant DVB_SUB for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType DVB_SUB = new CaptionSourceType("DVB_SUB");
        /// <summary>
        /// Constant EMBEDDED for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType EMBEDDED = new CaptionSourceType("EMBEDDED");
        /// <summary>
        /// Constant NULL_SOURCE for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType NULL_SOURCE = new CaptionSourceType("NULL_SOURCE");
        /// <summary>
        /// Constant SCC for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType SCC = new CaptionSourceType("SCC");
        /// <summary>
        /// Constant SRT for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType SRT = new CaptionSourceType("SRT");
        /// <summary>
        /// Constant STL for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType STL = new CaptionSourceType("STL");
        /// <summary>
        /// Constant TELETEXT for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType TELETEXT = new CaptionSourceType("TELETEXT");
        /// <summary>
        /// Constant TTML for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType TTML = new CaptionSourceType("TTML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CaptionSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CaptionSourceType FindValue(string value)
        {
            return FindValue<CaptionSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CaptionSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafClientCache.
    /// </summary>
    public class CmafClientCache : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CmafClientCache
        /// </summary>
        public static readonly CmafClientCache DISABLED = new CmafClientCache("DISABLED");
        /// <summary>
        /// Constant ENABLED for CmafClientCache
        /// </summary>
        public static readonly CmafClientCache ENABLED = new CmafClientCache("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafClientCache(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafClientCache FindValue(string value)
        {
            return FindValue<CmafClientCache>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafClientCache(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafCodecSpecification.
    /// </summary>
    public class CmafCodecSpecification : ConstantClass
    {

        /// <summary>
        /// Constant RFC_4281 for CmafCodecSpecification
        /// </summary>
        public static readonly CmafCodecSpecification RFC_4281 = new CmafCodecSpecification("RFC_4281");
        /// <summary>
        /// Constant RFC_6381 for CmafCodecSpecification
        /// </summary>
        public static readonly CmafCodecSpecification RFC_6381 = new CmafCodecSpecification("RFC_6381");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafCodecSpecification(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafCodecSpecification FindValue(string value)
        {
            return FindValue<CmafCodecSpecification>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafCodecSpecification(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafEncryptionType.
    /// </summary>
    public class CmafEncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant SAMPLE_AES for CmafEncryptionType
        /// </summary>
        public static readonly CmafEncryptionType SAMPLE_AES = new CmafEncryptionType("SAMPLE_AES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafEncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafEncryptionType FindValue(string value)
        {
            return FindValue<CmafEncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafEncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafInitializationVectorInManifest.
    /// </summary>
    public class CmafInitializationVectorInManifest : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for CmafInitializationVectorInManifest
        /// </summary>
        public static readonly CmafInitializationVectorInManifest EXCLUDE = new CmafInitializationVectorInManifest("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for CmafInitializationVectorInManifest
        /// </summary>
        public static readonly CmafInitializationVectorInManifest INCLUDE = new CmafInitializationVectorInManifest("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafInitializationVectorInManifest(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafInitializationVectorInManifest FindValue(string value)
        {
            return FindValue<CmafInitializationVectorInManifest>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafInitializationVectorInManifest(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafKeyProviderType.
    /// </summary>
    public class CmafKeyProviderType : ConstantClass
    {

        /// <summary>
        /// Constant STATIC_KEY for CmafKeyProviderType
        /// </summary>
        public static readonly CmafKeyProviderType STATIC_KEY = new CmafKeyProviderType("STATIC_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafKeyProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafKeyProviderType FindValue(string value)
        {
            return FindValue<CmafKeyProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafKeyProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafManifestCompression.
    /// </summary>
    public class CmafManifestCompression : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for CmafManifestCompression
        /// </summary>
        public static readonly CmafManifestCompression GZIP = new CmafManifestCompression("GZIP");
        /// <summary>
        /// Constant NONE for CmafManifestCompression
        /// </summary>
        public static readonly CmafManifestCompression NONE = new CmafManifestCompression("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafManifestCompression(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafManifestCompression FindValue(string value)
        {
            return FindValue<CmafManifestCompression>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafManifestCompression(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafManifestDurationFormat.
    /// </summary>
    public class CmafManifestDurationFormat : ConstantClass
    {

        /// <summary>
        /// Constant FLOATING_POINT for CmafManifestDurationFormat
        /// </summary>
        public static readonly CmafManifestDurationFormat FLOATING_POINT = new CmafManifestDurationFormat("FLOATING_POINT");
        /// <summary>
        /// Constant INTEGER for CmafManifestDurationFormat
        /// </summary>
        public static readonly CmafManifestDurationFormat INTEGER = new CmafManifestDurationFormat("INTEGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafManifestDurationFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafManifestDurationFormat FindValue(string value)
        {
            return FindValue<CmafManifestDurationFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafManifestDurationFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafSegmentControl.
    /// </summary>
    public class CmafSegmentControl : ConstantClass
    {

        /// <summary>
        /// Constant SEGMENTED_FILES for CmafSegmentControl
        /// </summary>
        public static readonly CmafSegmentControl SEGMENTED_FILES = new CmafSegmentControl("SEGMENTED_FILES");
        /// <summary>
        /// Constant SINGLE_FILE for CmafSegmentControl
        /// </summary>
        public static readonly CmafSegmentControl SINGLE_FILE = new CmafSegmentControl("SINGLE_FILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafSegmentControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafSegmentControl FindValue(string value)
        {
            return FindValue<CmafSegmentControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafSegmentControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafStreamInfResolution.
    /// </summary>
    public class CmafStreamInfResolution : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for CmafStreamInfResolution
        /// </summary>
        public static readonly CmafStreamInfResolution EXCLUDE = new CmafStreamInfResolution("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for CmafStreamInfResolution
        /// </summary>
        public static readonly CmafStreamInfResolution INCLUDE = new CmafStreamInfResolution("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafStreamInfResolution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafStreamInfResolution FindValue(string value)
        {
            return FindValue<CmafStreamInfResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafStreamInfResolution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafWriteDASHManifest.
    /// </summary>
    public class CmafWriteDASHManifest : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CmafWriteDASHManifest
        /// </summary>
        public static readonly CmafWriteDASHManifest DISABLED = new CmafWriteDASHManifest("DISABLED");
        /// <summary>
        /// Constant ENABLED for CmafWriteDASHManifest
        /// </summary>
        public static readonly CmafWriteDASHManifest ENABLED = new CmafWriteDASHManifest("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafWriteDASHManifest(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafWriteDASHManifest FindValue(string value)
        {
            return FindValue<CmafWriteDASHManifest>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafWriteDASHManifest(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafWriteHLSManifest.
    /// </summary>
    public class CmafWriteHLSManifest : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CmafWriteHLSManifest
        /// </summary>
        public static readonly CmafWriteHLSManifest DISABLED = new CmafWriteHLSManifest("DISABLED");
        /// <summary>
        /// Constant ENABLED for CmafWriteHLSManifest
        /// </summary>
        public static readonly CmafWriteHLSManifest ENABLED = new CmafWriteHLSManifest("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafWriteHLSManifest(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafWriteHLSManifest FindValue(string value)
        {
            return FindValue<CmafWriteHLSManifest>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafWriteHLSManifest(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ColorMetadata.
    /// </summary>
    public class ColorMetadata : ConstantClass
    {

        /// <summary>
        /// Constant IGNORE for ColorMetadata
        /// </summary>
        public static readonly ColorMetadata IGNORE = new ColorMetadata("IGNORE");
        /// <summary>
        /// Constant INSERT for ColorMetadata
        /// </summary>
        public static readonly ColorMetadata INSERT = new ColorMetadata("INSERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColorMetadata(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColorMetadata FindValue(string value)
        {
            return FindValue<ColorMetadata>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColorMetadata(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ColorSpace.
    /// </summary>
    public class ColorSpace : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW for ColorSpace
        /// </summary>
        public static readonly ColorSpace FOLLOW = new ColorSpace("FOLLOW");
        /// <summary>
        /// Constant HDR10 for ColorSpace
        /// </summary>
        public static readonly ColorSpace HDR10 = new ColorSpace("HDR10");
        /// <summary>
        /// Constant HLG_2020 for ColorSpace
        /// </summary>
        public static readonly ColorSpace HLG_2020 = new ColorSpace("HLG_2020");
        /// <summary>
        /// Constant REC_601 for ColorSpace
        /// </summary>
        public static readonly ColorSpace REC_601 = new ColorSpace("REC_601");
        /// <summary>
        /// Constant REC_709 for ColorSpace
        /// </summary>
        public static readonly ColorSpace REC_709 = new ColorSpace("REC_709");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColorSpace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColorSpace FindValue(string value)
        {
            return FindValue<ColorSpace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColorSpace(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ColorSpaceConversion.
    /// </summary>
    public class ColorSpaceConversion : ConstantClass
    {

        /// <summary>
        /// Constant FORCE_601 for ColorSpaceConversion
        /// </summary>
        public static readonly ColorSpaceConversion FORCE_601 = new ColorSpaceConversion("FORCE_601");
        /// <summary>
        /// Constant FORCE_709 for ColorSpaceConversion
        /// </summary>
        public static readonly ColorSpaceConversion FORCE_709 = new ColorSpaceConversion("FORCE_709");
        /// <summary>
        /// Constant FORCE_HDR10 for ColorSpaceConversion
        /// </summary>
        public static readonly ColorSpaceConversion FORCE_HDR10 = new ColorSpaceConversion("FORCE_HDR10");
        /// <summary>
        /// Constant FORCE_HLG_2020 for ColorSpaceConversion
        /// </summary>
        public static readonly ColorSpaceConversion FORCE_HLG_2020 = new ColorSpaceConversion("FORCE_HLG_2020");
        /// <summary>
        /// Constant NONE for ColorSpaceConversion
        /// </summary>
        public static readonly ColorSpaceConversion NONE = new ColorSpaceConversion("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColorSpaceConversion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColorSpaceConversion FindValue(string value)
        {
            return FindValue<ColorSpaceConversion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColorSpaceConversion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ColorSpaceUsage.
    /// </summary>
    public class ColorSpaceUsage : ConstantClass
    {

        /// <summary>
        /// Constant FALLBACK for ColorSpaceUsage
        /// </summary>
        public static readonly ColorSpaceUsage FALLBACK = new ColorSpaceUsage("FALLBACK");
        /// <summary>
        /// Constant FORCE for ColorSpaceUsage
        /// </summary>
        public static readonly ColorSpaceUsage FORCE = new ColorSpaceUsage("FORCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColorSpaceUsage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColorSpaceUsage FindValue(string value)
        {
            return FindValue<ColorSpaceUsage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColorSpaceUsage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerType.
    /// </summary>
    public class ContainerType : ConstantClass
    {

        /// <summary>
        /// Constant CMFC for ContainerType
        /// </summary>
        public static readonly ContainerType CMFC = new ContainerType("CMFC");
        /// <summary>
        /// Constant F4V for ContainerType
        /// </summary>
        public static readonly ContainerType F4V = new ContainerType("F4V");
        /// <summary>
        /// Constant ISMV for ContainerType
        /// </summary>
        public static readonly ContainerType ISMV = new ContainerType("ISMV");
        /// <summary>
        /// Constant M2TS for ContainerType
        /// </summary>
        public static readonly ContainerType M2TS = new ContainerType("M2TS");
        /// <summary>
        /// Constant M3U8 for ContainerType
        /// </summary>
        public static readonly ContainerType M3U8 = new ContainerType("M3U8");
        /// <summary>
        /// Constant MOV for ContainerType
        /// </summary>
        public static readonly ContainerType MOV = new ContainerType("MOV");
        /// <summary>
        /// Constant MP4 for ContainerType
        /// </summary>
        public static readonly ContainerType MP4 = new ContainerType("MP4");
        /// <summary>
        /// Constant MPD for ContainerType
        /// </summary>
        public static readonly ContainerType MPD = new ContainerType("MPD");
        /// <summary>
        /// Constant MXF for ContainerType
        /// </summary>
        public static readonly ContainerType MXF = new ContainerType("MXF");
        /// <summary>
        /// Constant RAW for ContainerType
        /// </summary>
        public static readonly ContainerType RAW = new ContainerType("RAW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerType FindValue(string value)
        {
            return FindValue<ContainerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashIsoHbbtvCompliance.
    /// </summary>
    public class DashIsoHbbtvCompliance : ConstantClass
    {

        /// <summary>
        /// Constant HBBTV_1_5 for DashIsoHbbtvCompliance
        /// </summary>
        public static readonly DashIsoHbbtvCompliance HBBTV_1_5 = new DashIsoHbbtvCompliance("HBBTV_1_5");
        /// <summary>
        /// Constant NONE for DashIsoHbbtvCompliance
        /// </summary>
        public static readonly DashIsoHbbtvCompliance NONE = new DashIsoHbbtvCompliance("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashIsoHbbtvCompliance(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashIsoHbbtvCompliance FindValue(string value)
        {
            return FindValue<DashIsoHbbtvCompliance>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashIsoHbbtvCompliance(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashIsoSegmentControl.
    /// </summary>
    public class DashIsoSegmentControl : ConstantClass
    {

        /// <summary>
        /// Constant SEGMENTED_FILES for DashIsoSegmentControl
        /// </summary>
        public static readonly DashIsoSegmentControl SEGMENTED_FILES = new DashIsoSegmentControl("SEGMENTED_FILES");
        /// <summary>
        /// Constant SINGLE_FILE for DashIsoSegmentControl
        /// </summary>
        public static readonly DashIsoSegmentControl SINGLE_FILE = new DashIsoSegmentControl("SINGLE_FILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashIsoSegmentControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashIsoSegmentControl FindValue(string value)
        {
            return FindValue<DashIsoSegmentControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashIsoSegmentControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeinterlaceAlgorithm.
    /// </summary>
    public class DeinterlaceAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant BLEND for DeinterlaceAlgorithm
        /// </summary>
        public static readonly DeinterlaceAlgorithm BLEND = new DeinterlaceAlgorithm("BLEND");
        /// <summary>
        /// Constant BLEND_TICKER for DeinterlaceAlgorithm
        /// </summary>
        public static readonly DeinterlaceAlgorithm BLEND_TICKER = new DeinterlaceAlgorithm("BLEND_TICKER");
        /// <summary>
        /// Constant INTERPOLATE for DeinterlaceAlgorithm
        /// </summary>
        public static readonly DeinterlaceAlgorithm INTERPOLATE = new DeinterlaceAlgorithm("INTERPOLATE");
        /// <summary>
        /// Constant INTERPOLATE_TICKER for DeinterlaceAlgorithm
        /// </summary>
        public static readonly DeinterlaceAlgorithm INTERPOLATE_TICKER = new DeinterlaceAlgorithm("INTERPOLATE_TICKER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeinterlaceAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeinterlaceAlgorithm FindValue(string value)
        {
            return FindValue<DeinterlaceAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeinterlaceAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeinterlacerControl.
    /// </summary>
    public class DeinterlacerControl : ConstantClass
    {

        /// <summary>
        /// Constant FORCE_ALL_FRAMES for DeinterlacerControl
        /// </summary>
        public static readonly DeinterlacerControl FORCE_ALL_FRAMES = new DeinterlacerControl("FORCE_ALL_FRAMES");
        /// <summary>
        /// Constant NORMAL for DeinterlacerControl
        /// </summary>
        public static readonly DeinterlacerControl NORMAL = new DeinterlacerControl("NORMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeinterlacerControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeinterlacerControl FindValue(string value)
        {
            return FindValue<DeinterlacerControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeinterlacerControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeinterlacerMode.
    /// </summary>
    public class DeinterlacerMode : ConstantClass
    {

        /// <summary>
        /// Constant ADAPTIVE for DeinterlacerMode
        /// </summary>
        public static readonly DeinterlacerMode ADAPTIVE = new DeinterlacerMode("ADAPTIVE");
        /// <summary>
        /// Constant DEINTERLACE for DeinterlacerMode
        /// </summary>
        public static readonly DeinterlacerMode DEINTERLACE = new DeinterlacerMode("DEINTERLACE");
        /// <summary>
        /// Constant INVERSE_TELECINE for DeinterlacerMode
        /// </summary>
        public static readonly DeinterlacerMode INVERSE_TELECINE = new DeinterlacerMode("INVERSE_TELECINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeinterlacerMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeinterlacerMode FindValue(string value)
        {
            return FindValue<DeinterlacerMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeinterlacerMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DropFrameTimecode.
    /// </summary>
    public class DropFrameTimecode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DropFrameTimecode
        /// </summary>
        public static readonly DropFrameTimecode DISABLED = new DropFrameTimecode("DISABLED");
        /// <summary>
        /// Constant ENABLED for DropFrameTimecode
        /// </summary>
        public static readonly DropFrameTimecode ENABLED = new DropFrameTimecode("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DropFrameTimecode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DropFrameTimecode FindValue(string value)
        {
            return FindValue<DropFrameTimecode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DropFrameTimecode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubtitleAlignment.
    /// </summary>
    public class DvbSubtitleAlignment : ConstantClass
    {

        /// <summary>
        /// Constant CENTERED for DvbSubtitleAlignment
        /// </summary>
        public static readonly DvbSubtitleAlignment CENTERED = new DvbSubtitleAlignment("CENTERED");
        /// <summary>
        /// Constant LEFT for DvbSubtitleAlignment
        /// </summary>
        public static readonly DvbSubtitleAlignment LEFT = new DvbSubtitleAlignment("LEFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubtitleAlignment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubtitleAlignment FindValue(string value)
        {
            return FindValue<DvbSubtitleAlignment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubtitleAlignment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubtitleBackgroundColor.
    /// </summary>
    public class DvbSubtitleBackgroundColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for DvbSubtitleBackgroundColor
        /// </summary>
        public static readonly DvbSubtitleBackgroundColor BLACK = new DvbSubtitleBackgroundColor("BLACK");
        /// <summary>
        /// Constant NONE for DvbSubtitleBackgroundColor
        /// </summary>
        public static readonly DvbSubtitleBackgroundColor NONE = new DvbSubtitleBackgroundColor("NONE");
        /// <summary>
        /// Constant WHITE for DvbSubtitleBackgroundColor
        /// </summary>
        public static readonly DvbSubtitleBackgroundColor WHITE = new DvbSubtitleBackgroundColor("WHITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubtitleBackgroundColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubtitleBackgroundColor FindValue(string value)
        {
            return FindValue<DvbSubtitleBackgroundColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubtitleBackgroundColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubtitleFontColor.
    /// </summary>
    public class DvbSubtitleFontColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for DvbSubtitleFontColor
        /// </summary>
        public static readonly DvbSubtitleFontColor BLACK = new DvbSubtitleFontColor("BLACK");
        /// <summary>
        /// Constant BLUE for DvbSubtitleFontColor
        /// </summary>
        public static readonly DvbSubtitleFontColor BLUE = new DvbSubtitleFontColor("BLUE");
        /// <summary>
        /// Constant GREEN for DvbSubtitleFontColor
        /// </summary>
        public static readonly DvbSubtitleFontColor GREEN = new DvbSubtitleFontColor("GREEN");
        /// <summary>
        /// Constant RED for DvbSubtitleFontColor
        /// </summary>
        public static readonly DvbSubtitleFontColor RED = new DvbSubtitleFontColor("RED");
        /// <summary>
        /// Constant WHITE for DvbSubtitleFontColor
        /// </summary>
        public static readonly DvbSubtitleFontColor WHITE = new DvbSubtitleFontColor("WHITE");
        /// <summary>
        /// Constant YELLOW for DvbSubtitleFontColor
        /// </summary>
        public static readonly DvbSubtitleFontColor YELLOW = new DvbSubtitleFontColor("YELLOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubtitleFontColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubtitleFontColor FindValue(string value)
        {
            return FindValue<DvbSubtitleFontColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubtitleFontColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubtitleOutlineColor.
    /// </summary>
    public class DvbSubtitleOutlineColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for DvbSubtitleOutlineColor
        /// </summary>
        public static readonly DvbSubtitleOutlineColor BLACK = new DvbSubtitleOutlineColor("BLACK");
        /// <summary>
        /// Constant BLUE for DvbSubtitleOutlineColor
        /// </summary>
        public static readonly DvbSubtitleOutlineColor BLUE = new DvbSubtitleOutlineColor("BLUE");
        /// <summary>
        /// Constant GREEN for DvbSubtitleOutlineColor
        /// </summary>
        public static readonly DvbSubtitleOutlineColor GREEN = new DvbSubtitleOutlineColor("GREEN");
        /// <summary>
        /// Constant RED for DvbSubtitleOutlineColor
        /// </summary>
        public static readonly DvbSubtitleOutlineColor RED = new DvbSubtitleOutlineColor("RED");
        /// <summary>
        /// Constant WHITE for DvbSubtitleOutlineColor
        /// </summary>
        public static readonly DvbSubtitleOutlineColor WHITE = new DvbSubtitleOutlineColor("WHITE");
        /// <summary>
        /// Constant YELLOW for DvbSubtitleOutlineColor
        /// </summary>
        public static readonly DvbSubtitleOutlineColor YELLOW = new DvbSubtitleOutlineColor("YELLOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubtitleOutlineColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubtitleOutlineColor FindValue(string value)
        {
            return FindValue<DvbSubtitleOutlineColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubtitleOutlineColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubtitleShadowColor.
    /// </summary>
    public class DvbSubtitleShadowColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for DvbSubtitleShadowColor
        /// </summary>
        public static readonly DvbSubtitleShadowColor BLACK = new DvbSubtitleShadowColor("BLACK");
        /// <summary>
        /// Constant NONE for DvbSubtitleShadowColor
        /// </summary>
        public static readonly DvbSubtitleShadowColor NONE = new DvbSubtitleShadowColor("NONE");
        /// <summary>
        /// Constant WHITE for DvbSubtitleShadowColor
        /// </summary>
        public static readonly DvbSubtitleShadowColor WHITE = new DvbSubtitleShadowColor("WHITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubtitleShadowColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubtitleShadowColor FindValue(string value)
        {
            return FindValue<DvbSubtitleShadowColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubtitleShadowColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubtitleTeletextSpacing.
    /// </summary>
    public class DvbSubtitleTeletextSpacing : ConstantClass
    {

        /// <summary>
        /// Constant FIXED_GRID for DvbSubtitleTeletextSpacing
        /// </summary>
        public static readonly DvbSubtitleTeletextSpacing FIXED_GRID = new DvbSubtitleTeletextSpacing("FIXED_GRID");
        /// <summary>
        /// Constant PROPORTIONAL for DvbSubtitleTeletextSpacing
        /// </summary>
        public static readonly DvbSubtitleTeletextSpacing PROPORTIONAL = new DvbSubtitleTeletextSpacing("PROPORTIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubtitleTeletextSpacing(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubtitleTeletextSpacing FindValue(string value)
        {
            return FindValue<DvbSubtitleTeletextSpacing>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubtitleTeletextSpacing(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3AttenuationControl.
    /// </summary>
    public class Eac3AttenuationControl : ConstantClass
    {

        /// <summary>
        /// Constant ATTENUATE_3_DB for Eac3AttenuationControl
        /// </summary>
        public static readonly Eac3AttenuationControl ATTENUATE_3_DB = new Eac3AttenuationControl("ATTENUATE_3_DB");
        /// <summary>
        /// Constant NONE for Eac3AttenuationControl
        /// </summary>
        public static readonly Eac3AttenuationControl NONE = new Eac3AttenuationControl("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AttenuationControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AttenuationControl FindValue(string value)
        {
            return FindValue<Eac3AttenuationControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AttenuationControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3BitstreamMode.
    /// </summary>
    public class Eac3BitstreamMode : ConstantClass
    {

        /// <summary>
        /// Constant COMMENTARY for Eac3BitstreamMode
        /// </summary>
        public static readonly Eac3BitstreamMode COMMENTARY = new Eac3BitstreamMode("COMMENTARY");
        /// <summary>
        /// Constant COMPLETE_MAIN for Eac3BitstreamMode
        /// </summary>
        public static readonly Eac3BitstreamMode COMPLETE_MAIN = new Eac3BitstreamMode("COMPLETE_MAIN");
        /// <summary>
        /// Constant EMERGENCY for Eac3BitstreamMode
        /// </summary>
        public static readonly Eac3BitstreamMode EMERGENCY = new Eac3BitstreamMode("EMERGENCY");
        /// <summary>
        /// Constant HEARING_IMPAIRED for Eac3BitstreamMode
        /// </summary>
        public static readonly Eac3BitstreamMode HEARING_IMPAIRED = new Eac3BitstreamMode("HEARING_IMPAIRED");
        /// <summary>
        /// Constant VISUALLY_IMPAIRED for Eac3BitstreamMode
        /// </summary>
        public static readonly Eac3BitstreamMode VISUALLY_IMPAIRED = new Eac3BitstreamMode("VISUALLY_IMPAIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3BitstreamMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3BitstreamMode FindValue(string value)
        {
            return FindValue<Eac3BitstreamMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3BitstreamMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3CodingMode.
    /// </summary>
    public class Eac3CodingMode : ConstantClass
    {

        /// <summary>
        /// Constant CODING_MODE_1_0 for Eac3CodingMode
        /// </summary>
        public static readonly Eac3CodingMode CODING_MODE_1_0 = new Eac3CodingMode("CODING_MODE_1_0");
        /// <summary>
        /// Constant CODING_MODE_2_0 for Eac3CodingMode
        /// </summary>
        public static readonly Eac3CodingMode CODING_MODE_2_0 = new Eac3CodingMode("CODING_MODE_2_0");
        /// <summary>
        /// Constant CODING_MODE_3_2 for Eac3CodingMode
        /// </summary>
        public static readonly Eac3CodingMode CODING_MODE_3_2 = new Eac3CodingMode("CODING_MODE_3_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3CodingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3CodingMode FindValue(string value)
        {
            return FindValue<Eac3CodingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3CodingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3DcFilter.
    /// </summary>
    public class Eac3DcFilter : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Eac3DcFilter
        /// </summary>
        public static readonly Eac3DcFilter DISABLED = new Eac3DcFilter("DISABLED");
        /// <summary>
        /// Constant ENABLED for Eac3DcFilter
        /// </summary>
        public static readonly Eac3DcFilter ENABLED = new Eac3DcFilter("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3DcFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3DcFilter FindValue(string value)
        {
            return FindValue<Eac3DcFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3DcFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3DynamicRangeCompressionLine.
    /// </summary>
    public class Eac3DynamicRangeCompressionLine : ConstantClass
    {

        /// <summary>
        /// Constant FILM_LIGHT for Eac3DynamicRangeCompressionLine
        /// </summary>
        public static readonly Eac3DynamicRangeCompressionLine FILM_LIGHT = new Eac3DynamicRangeCompressionLine("FILM_LIGHT");
        /// <summary>
        /// Constant FILM_STANDARD for Eac3DynamicRangeCompressionLine
        /// </summary>
        public static readonly Eac3DynamicRangeCompressionLine FILM_STANDARD = new Eac3DynamicRangeCompressionLine("FILM_STANDARD");
        /// <summary>
        /// Constant MUSIC_LIGHT for Eac3DynamicRangeCompressionLine
        /// </summary>
        public static readonly Eac3DynamicRangeCompressionLine MUSIC_LIGHT = new Eac3DynamicRangeCompressionLine("MUSIC_LIGHT");
        /// <summary>
        /// Constant MUSIC_STANDARD for Eac3DynamicRangeCompressionLine
        /// </summary>
        public static readonly Eac3DynamicRangeCompressionLine MUSIC_STANDARD = new Eac3DynamicRangeCompressionLine("MUSIC_STANDARD");
        /// <summary>
        /// Constant NONE for Eac3DynamicRangeCompressionLine
        /// </summary>
        public static readonly Eac3DynamicRangeCompressionLine NONE = new Eac3DynamicRangeCompressionLine("NONE");
        /// <summary>
        /// Constant SPEECH for Eac3DynamicRangeCompressionLine
        /// </summary>
        public static readonly Eac3DynamicRangeCompressionLine SPEECH = new Eac3DynamicRangeCompressionLine("SPEECH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3DynamicRangeCompressionLine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3DynamicRangeCompressionLine FindValue(string value)
        {
            return FindValue<Eac3DynamicRangeCompressionLine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3DynamicRangeCompressionLine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3DynamicRangeCompressionRf.
    /// </summary>
    public class Eac3DynamicRangeCompressionRf : ConstantClass
    {

        /// <summary>
        /// Constant FILM_LIGHT for Eac3DynamicRangeCompressionRf
        /// </summary>
        public static readonly Eac3DynamicRangeCompressionRf FILM_LIGHT = new Eac3DynamicRangeCompressionRf("FILM_LIGHT");
        /// <summary>
        /// Constant FILM_STANDARD for Eac3DynamicRangeCompressionRf
        /// </summary>
        public static readonly Eac3DynamicRangeCompressionRf FILM_STANDARD = new Eac3DynamicRangeCompressionRf("FILM_STANDARD");
        /// <summary>
        /// Constant MUSIC_LIGHT for Eac3DynamicRangeCompressionRf
        /// </summary>
        public static readonly Eac3DynamicRangeCompressionRf MUSIC_LIGHT = new Eac3DynamicRangeCompressionRf("MUSIC_LIGHT");
        /// <summary>
        /// Constant MUSIC_STANDARD for Eac3DynamicRangeCompressionRf
        /// </summary>
        public static readonly Eac3DynamicRangeCompressionRf MUSIC_STANDARD = new Eac3DynamicRangeCompressionRf("MUSIC_STANDARD");
        /// <summary>
        /// Constant NONE for Eac3DynamicRangeCompressionRf
        /// </summary>
        public static readonly Eac3DynamicRangeCompressionRf NONE = new Eac3DynamicRangeCompressionRf("NONE");
        /// <summary>
        /// Constant SPEECH for Eac3DynamicRangeCompressionRf
        /// </summary>
        public static readonly Eac3DynamicRangeCompressionRf SPEECH = new Eac3DynamicRangeCompressionRf("SPEECH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3DynamicRangeCompressionRf(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3DynamicRangeCompressionRf FindValue(string value)
        {
            return FindValue<Eac3DynamicRangeCompressionRf>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3DynamicRangeCompressionRf(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3LfeControl.
    /// </summary>
    public class Eac3LfeControl : ConstantClass
    {

        /// <summary>
        /// Constant LFE for Eac3LfeControl
        /// </summary>
        public static readonly Eac3LfeControl LFE = new Eac3LfeControl("LFE");
        /// <summary>
        /// Constant NO_LFE for Eac3LfeControl
        /// </summary>
        public static readonly Eac3LfeControl NO_LFE = new Eac3LfeControl("NO_LFE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3LfeControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3LfeControl FindValue(string value)
        {
            return FindValue<Eac3LfeControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3LfeControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3LfeFilter.
    /// </summary>
    public class Eac3LfeFilter : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Eac3LfeFilter
        /// </summary>
        public static readonly Eac3LfeFilter DISABLED = new Eac3LfeFilter("DISABLED");
        /// <summary>
        /// Constant ENABLED for Eac3LfeFilter
        /// </summary>
        public static readonly Eac3LfeFilter ENABLED = new Eac3LfeFilter("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3LfeFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3LfeFilter FindValue(string value)
        {
            return FindValue<Eac3LfeFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3LfeFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3MetadataControl.
    /// </summary>
    public class Eac3MetadataControl : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW_INPUT for Eac3MetadataControl
        /// </summary>
        public static readonly Eac3MetadataControl FOLLOW_INPUT = new Eac3MetadataControl("FOLLOW_INPUT");
        /// <summary>
        /// Constant USE_CONFIGURED for Eac3MetadataControl
        /// </summary>
        public static readonly Eac3MetadataControl USE_CONFIGURED = new Eac3MetadataControl("USE_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3MetadataControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3MetadataControl FindValue(string value)
        {
            return FindValue<Eac3MetadataControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3MetadataControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3PassthroughControl.
    /// </summary>
    public class Eac3PassthroughControl : ConstantClass
    {

        /// <summary>
        /// Constant NO_PASSTHROUGH for Eac3PassthroughControl
        /// </summary>
        public static readonly Eac3PassthroughControl NO_PASSTHROUGH = new Eac3PassthroughControl("NO_PASSTHROUGH");
        /// <summary>
        /// Constant WHEN_POSSIBLE for Eac3PassthroughControl
        /// </summary>
        public static readonly Eac3PassthroughControl WHEN_POSSIBLE = new Eac3PassthroughControl("WHEN_POSSIBLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3PassthroughControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3PassthroughControl FindValue(string value)
        {
            return FindValue<Eac3PassthroughControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3PassthroughControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3PhaseControl.
    /// </summary>
    public class Eac3PhaseControl : ConstantClass
    {

        /// <summary>
        /// Constant NO_SHIFT for Eac3PhaseControl
        /// </summary>
        public static readonly Eac3PhaseControl NO_SHIFT = new Eac3PhaseControl("NO_SHIFT");
        /// <summary>
        /// Constant SHIFT_90_DEGREES for Eac3PhaseControl
        /// </summary>
        public static readonly Eac3PhaseControl SHIFT_90_DEGREES = new Eac3PhaseControl("SHIFT_90_DEGREES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3PhaseControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3PhaseControl FindValue(string value)
        {
            return FindValue<Eac3PhaseControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3PhaseControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3StereoDownmix.
    /// </summary>
    public class Eac3StereoDownmix : ConstantClass
    {

        /// <summary>
        /// Constant DPL2 for Eac3StereoDownmix
        /// </summary>
        public static readonly Eac3StereoDownmix DPL2 = new Eac3StereoDownmix("DPL2");
        /// <summary>
        /// Constant LO_RO for Eac3StereoDownmix
        /// </summary>
        public static readonly Eac3StereoDownmix LO_RO = new Eac3StereoDownmix("LO_RO");
        /// <summary>
        /// Constant LT_RT for Eac3StereoDownmix
        /// </summary>
        public static readonly Eac3StereoDownmix LT_RT = new Eac3StereoDownmix("LT_RT");
        /// <summary>
        /// Constant NOT_INDICATED for Eac3StereoDownmix
        /// </summary>
        public static readonly Eac3StereoDownmix NOT_INDICATED = new Eac3StereoDownmix("NOT_INDICATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3StereoDownmix(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3StereoDownmix FindValue(string value)
        {
            return FindValue<Eac3StereoDownmix>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3StereoDownmix(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3SurroundExMode.
    /// </summary>
    public class Eac3SurroundExMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Eac3SurroundExMode
        /// </summary>
        public static readonly Eac3SurroundExMode DISABLED = new Eac3SurroundExMode("DISABLED");
        /// <summary>
        /// Constant ENABLED for Eac3SurroundExMode
        /// </summary>
        public static readonly Eac3SurroundExMode ENABLED = new Eac3SurroundExMode("ENABLED");
        /// <summary>
        /// Constant NOT_INDICATED for Eac3SurroundExMode
        /// </summary>
        public static readonly Eac3SurroundExMode NOT_INDICATED = new Eac3SurroundExMode("NOT_INDICATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3SurroundExMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3SurroundExMode FindValue(string value)
        {
            return FindValue<Eac3SurroundExMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3SurroundExMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3SurroundMode.
    /// </summary>
    public class Eac3SurroundMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Eac3SurroundMode
        /// </summary>
        public static readonly Eac3SurroundMode DISABLED = new Eac3SurroundMode("DISABLED");
        /// <summary>
        /// Constant ENABLED for Eac3SurroundMode
        /// </summary>
        public static readonly Eac3SurroundMode ENABLED = new Eac3SurroundMode("ENABLED");
        /// <summary>
        /// Constant NOT_INDICATED for Eac3SurroundMode
        /// </summary>
        public static readonly Eac3SurroundMode NOT_INDICATED = new Eac3SurroundMode("NOT_INDICATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3SurroundMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3SurroundMode FindValue(string value)
        {
            return FindValue<Eac3SurroundMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3SurroundMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EmbeddedConvert608To708.
    /// </summary>
    public class EmbeddedConvert608To708 : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EmbeddedConvert608To708
        /// </summary>
        public static readonly EmbeddedConvert608To708 DISABLED = new EmbeddedConvert608To708("DISABLED");
        /// <summary>
        /// Constant UPCONVERT for EmbeddedConvert608To708
        /// </summary>
        public static readonly EmbeddedConvert608To708 UPCONVERT = new EmbeddedConvert608To708("UPCONVERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmbeddedConvert608To708(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmbeddedConvert608To708 FindValue(string value)
        {
            return FindValue<EmbeddedConvert608To708>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmbeddedConvert608To708(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type F4vMoovPlacement.
    /// </summary>
    public class F4vMoovPlacement : ConstantClass
    {

        /// <summary>
        /// Constant NORMAL for F4vMoovPlacement
        /// </summary>
        public static readonly F4vMoovPlacement NORMAL = new F4vMoovPlacement("NORMAL");
        /// <summary>
        /// Constant PROGRESSIVE_DOWNLOAD for F4vMoovPlacement
        /// </summary>
        public static readonly F4vMoovPlacement PROGRESSIVE_DOWNLOAD = new F4vMoovPlacement("PROGRESSIVE_DOWNLOAD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public F4vMoovPlacement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static F4vMoovPlacement FindValue(string value)
        {
            return FindValue<F4vMoovPlacement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator F4vMoovPlacement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSourceConvert608To708.
    /// </summary>
    public class FileSourceConvert608To708 : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FileSourceConvert608To708
        /// </summary>
        public static readonly FileSourceConvert608To708 DISABLED = new FileSourceConvert608To708("DISABLED");
        /// <summary>
        /// Constant UPCONVERT for FileSourceConvert608To708
        /// </summary>
        public static readonly FileSourceConvert608To708 UPCONVERT = new FileSourceConvert608To708("UPCONVERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSourceConvert608To708(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSourceConvert608To708 FindValue(string value)
        {
            return FindValue<FileSourceConvert608To708>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSourceConvert608To708(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264AdaptiveQuantization.
    /// </summary>
    public class H264AdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for H264AdaptiveQuantization
        /// </summary>
        public static readonly H264AdaptiveQuantization HIGH = new H264AdaptiveQuantization("HIGH");
        /// <summary>
        /// Constant HIGHER for H264AdaptiveQuantization
        /// </summary>
        public static readonly H264AdaptiveQuantization HIGHER = new H264AdaptiveQuantization("HIGHER");
        /// <summary>
        /// Constant LOW for H264AdaptiveQuantization
        /// </summary>
        public static readonly H264AdaptiveQuantization LOW = new H264AdaptiveQuantization("LOW");
        /// <summary>
        /// Constant MAX for H264AdaptiveQuantization
        /// </summary>
        public static readonly H264AdaptiveQuantization MAX = new H264AdaptiveQuantization("MAX");
        /// <summary>
        /// Constant MEDIUM for H264AdaptiveQuantization
        /// </summary>
        public static readonly H264AdaptiveQuantization MEDIUM = new H264AdaptiveQuantization("MEDIUM");
        /// <summary>
        /// Constant OFF for H264AdaptiveQuantization
        /// </summary>
        public static readonly H264AdaptiveQuantization OFF = new H264AdaptiveQuantization("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264AdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264AdaptiveQuantization FindValue(string value)
        {
            return FindValue<H264AdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264AdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264CodecLevel.
    /// </summary>
    public class H264CodecLevel : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel AUTO = new H264CodecLevel("AUTO");
        /// <summary>
        /// Constant LEVEL_1 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_1 = new H264CodecLevel("LEVEL_1");
        /// <summary>
        /// Constant LEVEL_1_1 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_1_1 = new H264CodecLevel("LEVEL_1_1");
        /// <summary>
        /// Constant LEVEL_1_2 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_1_2 = new H264CodecLevel("LEVEL_1_2");
        /// <summary>
        /// Constant LEVEL_1_3 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_1_3 = new H264CodecLevel("LEVEL_1_3");
        /// <summary>
        /// Constant LEVEL_2 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_2 = new H264CodecLevel("LEVEL_2");
        /// <summary>
        /// Constant LEVEL_2_1 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_2_1 = new H264CodecLevel("LEVEL_2_1");
        /// <summary>
        /// Constant LEVEL_2_2 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_2_2 = new H264CodecLevel("LEVEL_2_2");
        /// <summary>
        /// Constant LEVEL_3 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_3 = new H264CodecLevel("LEVEL_3");
        /// <summary>
        /// Constant LEVEL_3_1 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_3_1 = new H264CodecLevel("LEVEL_3_1");
        /// <summary>
        /// Constant LEVEL_3_2 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_3_2 = new H264CodecLevel("LEVEL_3_2");
        /// <summary>
        /// Constant LEVEL_4 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_4 = new H264CodecLevel("LEVEL_4");
        /// <summary>
        /// Constant LEVEL_4_1 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_4_1 = new H264CodecLevel("LEVEL_4_1");
        /// <summary>
        /// Constant LEVEL_4_2 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_4_2 = new H264CodecLevel("LEVEL_4_2");
        /// <summary>
        /// Constant LEVEL_5 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_5 = new H264CodecLevel("LEVEL_5");
        /// <summary>
        /// Constant LEVEL_5_1 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_5_1 = new H264CodecLevel("LEVEL_5_1");
        /// <summary>
        /// Constant LEVEL_5_2 for H264CodecLevel
        /// </summary>
        public static readonly H264CodecLevel LEVEL_5_2 = new H264CodecLevel("LEVEL_5_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264CodecLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264CodecLevel FindValue(string value)
        {
            return FindValue<H264CodecLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264CodecLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264CodecProfile.
    /// </summary>
    public class H264CodecProfile : ConstantClass
    {

        /// <summary>
        /// Constant BASELINE for H264CodecProfile
        /// </summary>
        public static readonly H264CodecProfile BASELINE = new H264CodecProfile("BASELINE");
        /// <summary>
        /// Constant HIGH for H264CodecProfile
        /// </summary>
        public static readonly H264CodecProfile HIGH = new H264CodecProfile("HIGH");
        /// <summary>
        /// Constant HIGH_10BIT for H264CodecProfile
        /// </summary>
        public static readonly H264CodecProfile HIGH_10BIT = new H264CodecProfile("HIGH_10BIT");
        /// <summary>
        /// Constant HIGH_422 for H264CodecProfile
        /// </summary>
        public static readonly H264CodecProfile HIGH_422 = new H264CodecProfile("HIGH_422");
        /// <summary>
        /// Constant HIGH_422_10BIT for H264CodecProfile
        /// </summary>
        public static readonly H264CodecProfile HIGH_422_10BIT = new H264CodecProfile("HIGH_422_10BIT");
        /// <summary>
        /// Constant MAIN for H264CodecProfile
        /// </summary>
        public static readonly H264CodecProfile MAIN = new H264CodecProfile("MAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264CodecProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264CodecProfile FindValue(string value)
        {
            return FindValue<H264CodecProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264CodecProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264EntropyEncoding.
    /// </summary>
    public class H264EntropyEncoding : ConstantClass
    {

        /// <summary>
        /// Constant CABAC for H264EntropyEncoding
        /// </summary>
        public static readonly H264EntropyEncoding CABAC = new H264EntropyEncoding("CABAC");
        /// <summary>
        /// Constant CAVLC for H264EntropyEncoding
        /// </summary>
        public static readonly H264EntropyEncoding CAVLC = new H264EntropyEncoding("CAVLC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264EntropyEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264EntropyEncoding FindValue(string value)
        {
            return FindValue<H264EntropyEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264EntropyEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264FieldEncoding.
    /// </summary>
    public class H264FieldEncoding : ConstantClass
    {

        /// <summary>
        /// Constant FORCE_FIELD for H264FieldEncoding
        /// </summary>
        public static readonly H264FieldEncoding FORCE_FIELD = new H264FieldEncoding("FORCE_FIELD");
        /// <summary>
        /// Constant PAFF for H264FieldEncoding
        /// </summary>
        public static readonly H264FieldEncoding PAFF = new H264FieldEncoding("PAFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264FieldEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264FieldEncoding FindValue(string value)
        {
            return FindValue<H264FieldEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264FieldEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264FlickerAdaptiveQuantization.
    /// </summary>
    public class H264FlickerAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264FlickerAdaptiveQuantization
        /// </summary>
        public static readonly H264FlickerAdaptiveQuantization DISABLED = new H264FlickerAdaptiveQuantization("DISABLED");
        /// <summary>
        /// Constant ENABLED for H264FlickerAdaptiveQuantization
        /// </summary>
        public static readonly H264FlickerAdaptiveQuantization ENABLED = new H264FlickerAdaptiveQuantization("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264FlickerAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264FlickerAdaptiveQuantization FindValue(string value)
        {
            return FindValue<H264FlickerAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264FlickerAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264FramerateControl.
    /// </summary>
    public class H264FramerateControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for H264FramerateControl
        /// </summary>
        public static readonly H264FramerateControl INITIALIZE_FROM_SOURCE = new H264FramerateControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for H264FramerateControl
        /// </summary>
        public static readonly H264FramerateControl SPECIFIED = new H264FramerateControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264FramerateControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264FramerateControl FindValue(string value)
        {
            return FindValue<H264FramerateControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264FramerateControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264FramerateConversionAlgorithm.
    /// </summary>
    public class H264FramerateConversionAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_DROP for H264FramerateConversionAlgorithm
        /// </summary>
        public static readonly H264FramerateConversionAlgorithm DUPLICATE_DROP = new H264FramerateConversionAlgorithm("DUPLICATE_DROP");
        /// <summary>
        /// Constant INTERPOLATE for H264FramerateConversionAlgorithm
        /// </summary>
        public static readonly H264FramerateConversionAlgorithm INTERPOLATE = new H264FramerateConversionAlgorithm("INTERPOLATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264FramerateConversionAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264FramerateConversionAlgorithm FindValue(string value)
        {
            return FindValue<H264FramerateConversionAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264FramerateConversionAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264GopBReference.
    /// </summary>
    public class H264GopBReference : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264GopBReference
        /// </summary>
        public static readonly H264GopBReference DISABLED = new H264GopBReference("DISABLED");
        /// <summary>
        /// Constant ENABLED for H264GopBReference
        /// </summary>
        public static readonly H264GopBReference ENABLED = new H264GopBReference("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264GopBReference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264GopBReference FindValue(string value)
        {
            return FindValue<H264GopBReference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264GopBReference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264GopSizeUnits.
    /// </summary>
    public class H264GopSizeUnits : ConstantClass
    {

        /// <summary>
        /// Constant FRAMES for H264GopSizeUnits
        /// </summary>
        public static readonly H264GopSizeUnits FRAMES = new H264GopSizeUnits("FRAMES");
        /// <summary>
        /// Constant SECONDS for H264GopSizeUnits
        /// </summary>
        public static readonly H264GopSizeUnits SECONDS = new H264GopSizeUnits("SECONDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264GopSizeUnits(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264GopSizeUnits FindValue(string value)
        {
            return FindValue<H264GopSizeUnits>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264GopSizeUnits(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264InterlaceMode.
    /// </summary>
    public class H264InterlaceMode : ConstantClass
    {

        /// <summary>
        /// Constant BOTTOM_FIELD for H264InterlaceMode
        /// </summary>
        public static readonly H264InterlaceMode BOTTOM_FIELD = new H264InterlaceMode("BOTTOM_FIELD");
        /// <summary>
        /// Constant FOLLOW_BOTTOM_FIELD for H264InterlaceMode
        /// </summary>
        public static readonly H264InterlaceMode FOLLOW_BOTTOM_FIELD = new H264InterlaceMode("FOLLOW_BOTTOM_FIELD");
        /// <summary>
        /// Constant FOLLOW_TOP_FIELD for H264InterlaceMode
        /// </summary>
        public static readonly H264InterlaceMode FOLLOW_TOP_FIELD = new H264InterlaceMode("FOLLOW_TOP_FIELD");
        /// <summary>
        /// Constant PROGRESSIVE for H264InterlaceMode
        /// </summary>
        public static readonly H264InterlaceMode PROGRESSIVE = new H264InterlaceMode("PROGRESSIVE");
        /// <summary>
        /// Constant TOP_FIELD for H264InterlaceMode
        /// </summary>
        public static readonly H264InterlaceMode TOP_FIELD = new H264InterlaceMode("TOP_FIELD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264InterlaceMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264InterlaceMode FindValue(string value)
        {
            return FindValue<H264InterlaceMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264InterlaceMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264ParControl.
    /// </summary>
    public class H264ParControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for H264ParControl
        /// </summary>
        public static readonly H264ParControl INITIALIZE_FROM_SOURCE = new H264ParControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for H264ParControl
        /// </summary>
        public static readonly H264ParControl SPECIFIED = new H264ParControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264ParControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264ParControl FindValue(string value)
        {
            return FindValue<H264ParControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264ParControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264QualityTuningLevel.
    /// </summary>
    public class H264QualityTuningLevel : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_PASS_HQ for H264QualityTuningLevel
        /// </summary>
        public static readonly H264QualityTuningLevel MULTI_PASS_HQ = new H264QualityTuningLevel("MULTI_PASS_HQ");
        /// <summary>
        /// Constant SINGLE_PASS for H264QualityTuningLevel
        /// </summary>
        public static readonly H264QualityTuningLevel SINGLE_PASS = new H264QualityTuningLevel("SINGLE_PASS");
        /// <summary>
        /// Constant SINGLE_PASS_HQ for H264QualityTuningLevel
        /// </summary>
        public static readonly H264QualityTuningLevel SINGLE_PASS_HQ = new H264QualityTuningLevel("SINGLE_PASS_HQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264QualityTuningLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264QualityTuningLevel FindValue(string value)
        {
            return FindValue<H264QualityTuningLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264QualityTuningLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264RateControlMode.
    /// </summary>
    public class H264RateControlMode : ConstantClass
    {

        /// <summary>
        /// Constant CBR for H264RateControlMode
        /// </summary>
        public static readonly H264RateControlMode CBR = new H264RateControlMode("CBR");
        /// <summary>
        /// Constant VBR for H264RateControlMode
        /// </summary>
        public static readonly H264RateControlMode VBR = new H264RateControlMode("VBR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264RateControlMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264RateControlMode FindValue(string value)
        {
            return FindValue<H264RateControlMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264RateControlMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264RepeatPps.
    /// </summary>
    public class H264RepeatPps : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264RepeatPps
        /// </summary>
        public static readonly H264RepeatPps DISABLED = new H264RepeatPps("DISABLED");
        /// <summary>
        /// Constant ENABLED for H264RepeatPps
        /// </summary>
        public static readonly H264RepeatPps ENABLED = new H264RepeatPps("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264RepeatPps(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264RepeatPps FindValue(string value)
        {
            return FindValue<H264RepeatPps>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264RepeatPps(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264SceneChangeDetect.
    /// </summary>
    public class H264SceneChangeDetect : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264SceneChangeDetect
        /// </summary>
        public static readonly H264SceneChangeDetect DISABLED = new H264SceneChangeDetect("DISABLED");
        /// <summary>
        /// Constant ENABLED for H264SceneChangeDetect
        /// </summary>
        public static readonly H264SceneChangeDetect ENABLED = new H264SceneChangeDetect("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264SceneChangeDetect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264SceneChangeDetect FindValue(string value)
        {
            return FindValue<H264SceneChangeDetect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264SceneChangeDetect(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264SlowPal.
    /// </summary>
    public class H264SlowPal : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264SlowPal
        /// </summary>
        public static readonly H264SlowPal DISABLED = new H264SlowPal("DISABLED");
        /// <summary>
        /// Constant ENABLED for H264SlowPal
        /// </summary>
        public static readonly H264SlowPal ENABLED = new H264SlowPal("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264SlowPal(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264SlowPal FindValue(string value)
        {
            return FindValue<H264SlowPal>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264SlowPal(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264SpatialAdaptiveQuantization.
    /// </summary>
    public class H264SpatialAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264SpatialAdaptiveQuantization
        /// </summary>
        public static readonly H264SpatialAdaptiveQuantization DISABLED = new H264SpatialAdaptiveQuantization("DISABLED");
        /// <summary>
        /// Constant ENABLED for H264SpatialAdaptiveQuantization
        /// </summary>
        public static readonly H264SpatialAdaptiveQuantization ENABLED = new H264SpatialAdaptiveQuantization("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264SpatialAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264SpatialAdaptiveQuantization FindValue(string value)
        {
            return FindValue<H264SpatialAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264SpatialAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264Syntax.
    /// </summary>
    public class H264Syntax : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for H264Syntax
        /// </summary>
        public static readonly H264Syntax DEFAULT = new H264Syntax("DEFAULT");
        /// <summary>
        /// Constant RP2027 for H264Syntax
        /// </summary>
        public static readonly H264Syntax RP2027 = new H264Syntax("RP2027");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264Syntax(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264Syntax FindValue(string value)
        {
            return FindValue<H264Syntax>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264Syntax(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264Telecine.
    /// </summary>
    public class H264Telecine : ConstantClass
    {

        /// <summary>
        /// Constant HARD for H264Telecine
        /// </summary>
        public static readonly H264Telecine HARD = new H264Telecine("HARD");
        /// <summary>
        /// Constant NONE for H264Telecine
        /// </summary>
        public static readonly H264Telecine NONE = new H264Telecine("NONE");
        /// <summary>
        /// Constant SOFT for H264Telecine
        /// </summary>
        public static readonly H264Telecine SOFT = new H264Telecine("SOFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264Telecine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264Telecine FindValue(string value)
        {
            return FindValue<H264Telecine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264Telecine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264TemporalAdaptiveQuantization.
    /// </summary>
    public class H264TemporalAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264TemporalAdaptiveQuantization
        /// </summary>
        public static readonly H264TemporalAdaptiveQuantization DISABLED = new H264TemporalAdaptiveQuantization("DISABLED");
        /// <summary>
        /// Constant ENABLED for H264TemporalAdaptiveQuantization
        /// </summary>
        public static readonly H264TemporalAdaptiveQuantization ENABLED = new H264TemporalAdaptiveQuantization("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264TemporalAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264TemporalAdaptiveQuantization FindValue(string value)
        {
            return FindValue<H264TemporalAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264TemporalAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264UnregisteredSeiTimecode.
    /// </summary>
    public class H264UnregisteredSeiTimecode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264UnregisteredSeiTimecode
        /// </summary>
        public static readonly H264UnregisteredSeiTimecode DISABLED = new H264UnregisteredSeiTimecode("DISABLED");
        /// <summary>
        /// Constant ENABLED for H264UnregisteredSeiTimecode
        /// </summary>
        public static readonly H264UnregisteredSeiTimecode ENABLED = new H264UnregisteredSeiTimecode("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264UnregisteredSeiTimecode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264UnregisteredSeiTimecode FindValue(string value)
        {
            return FindValue<H264UnregisteredSeiTimecode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264UnregisteredSeiTimecode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265AdaptiveQuantization.
    /// </summary>
    public class H265AdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for H265AdaptiveQuantization
        /// </summary>
        public static readonly H265AdaptiveQuantization HIGH = new H265AdaptiveQuantization("HIGH");
        /// <summary>
        /// Constant HIGHER for H265AdaptiveQuantization
        /// </summary>
        public static readonly H265AdaptiveQuantization HIGHER = new H265AdaptiveQuantization("HIGHER");
        /// <summary>
        /// Constant LOW for H265AdaptiveQuantization
        /// </summary>
        public static readonly H265AdaptiveQuantization LOW = new H265AdaptiveQuantization("LOW");
        /// <summary>
        /// Constant MAX for H265AdaptiveQuantization
        /// </summary>
        public static readonly H265AdaptiveQuantization MAX = new H265AdaptiveQuantization("MAX");
        /// <summary>
        /// Constant MEDIUM for H265AdaptiveQuantization
        /// </summary>
        public static readonly H265AdaptiveQuantization MEDIUM = new H265AdaptiveQuantization("MEDIUM");
        /// <summary>
        /// Constant OFF for H265AdaptiveQuantization
        /// </summary>
        public static readonly H265AdaptiveQuantization OFF = new H265AdaptiveQuantization("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265AdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265AdaptiveQuantization FindValue(string value)
        {
            return FindValue<H265AdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265AdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265AlternateTransferFunctionSei.
    /// </summary>
    public class H265AlternateTransferFunctionSei : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H265AlternateTransferFunctionSei
        /// </summary>
        public static readonly H265AlternateTransferFunctionSei DISABLED = new H265AlternateTransferFunctionSei("DISABLED");
        /// <summary>
        /// Constant ENABLED for H265AlternateTransferFunctionSei
        /// </summary>
        public static readonly H265AlternateTransferFunctionSei ENABLED = new H265AlternateTransferFunctionSei("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265AlternateTransferFunctionSei(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265AlternateTransferFunctionSei FindValue(string value)
        {
            return FindValue<H265AlternateTransferFunctionSei>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265AlternateTransferFunctionSei(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265CodecLevel.
    /// </summary>
    public class H265CodecLevel : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel AUTO = new H265CodecLevel("AUTO");
        /// <summary>
        /// Constant LEVEL_1 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_1 = new H265CodecLevel("LEVEL_1");
        /// <summary>
        /// Constant LEVEL_2 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_2 = new H265CodecLevel("LEVEL_2");
        /// <summary>
        /// Constant LEVEL_2_1 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_2_1 = new H265CodecLevel("LEVEL_2_1");
        /// <summary>
        /// Constant LEVEL_3 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_3 = new H265CodecLevel("LEVEL_3");
        /// <summary>
        /// Constant LEVEL_3_1 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_3_1 = new H265CodecLevel("LEVEL_3_1");
        /// <summary>
        /// Constant LEVEL_4 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_4 = new H265CodecLevel("LEVEL_4");
        /// <summary>
        /// Constant LEVEL_4_1 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_4_1 = new H265CodecLevel("LEVEL_4_1");
        /// <summary>
        /// Constant LEVEL_5 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_5 = new H265CodecLevel("LEVEL_5");
        /// <summary>
        /// Constant LEVEL_5_1 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_5_1 = new H265CodecLevel("LEVEL_5_1");
        /// <summary>
        /// Constant LEVEL_5_2 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_5_2 = new H265CodecLevel("LEVEL_5_2");
        /// <summary>
        /// Constant LEVEL_6 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_6 = new H265CodecLevel("LEVEL_6");
        /// <summary>
        /// Constant LEVEL_6_1 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_6_1 = new H265CodecLevel("LEVEL_6_1");
        /// <summary>
        /// Constant LEVEL_6_2 for H265CodecLevel
        /// </summary>
        public static readonly H265CodecLevel LEVEL_6_2 = new H265CodecLevel("LEVEL_6_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265CodecLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265CodecLevel FindValue(string value)
        {
            return FindValue<H265CodecLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265CodecLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265CodecProfile.
    /// </summary>
    public class H265CodecProfile : ConstantClass
    {

        /// <summary>
        /// Constant MAIN_422_10BIT_HIGH for H265CodecProfile
        /// </summary>
        public static readonly H265CodecProfile MAIN_422_10BIT_HIGH = new H265CodecProfile("MAIN_422_10BIT_HIGH");
        /// <summary>
        /// Constant MAIN_422_10BIT_MAIN for H265CodecProfile
        /// </summary>
        public static readonly H265CodecProfile MAIN_422_10BIT_MAIN = new H265CodecProfile("MAIN_422_10BIT_MAIN");
        /// <summary>
        /// Constant MAIN_422_8BIT_HIGH for H265CodecProfile
        /// </summary>
        public static readonly H265CodecProfile MAIN_422_8BIT_HIGH = new H265CodecProfile("MAIN_422_8BIT_HIGH");
        /// <summary>
        /// Constant MAIN_422_8BIT_MAIN for H265CodecProfile
        /// </summary>
        public static readonly H265CodecProfile MAIN_422_8BIT_MAIN = new H265CodecProfile("MAIN_422_8BIT_MAIN");
        /// <summary>
        /// Constant MAIN_HIGH for H265CodecProfile
        /// </summary>
        public static readonly H265CodecProfile MAIN_HIGH = new H265CodecProfile("MAIN_HIGH");
        /// <summary>
        /// Constant MAIN_MAIN for H265CodecProfile
        /// </summary>
        public static readonly H265CodecProfile MAIN_MAIN = new H265CodecProfile("MAIN_MAIN");
        /// <summary>
        /// Constant MAIN10_HIGH for H265CodecProfile
        /// </summary>
        public static readonly H265CodecProfile MAIN10_HIGH = new H265CodecProfile("MAIN10_HIGH");
        /// <summary>
        /// Constant MAIN10_MAIN for H265CodecProfile
        /// </summary>
        public static readonly H265CodecProfile MAIN10_MAIN = new H265CodecProfile("MAIN10_MAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265CodecProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265CodecProfile FindValue(string value)
        {
            return FindValue<H265CodecProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265CodecProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265FlickerAdaptiveQuantization.
    /// </summary>
    public class H265FlickerAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H265FlickerAdaptiveQuantization
        /// </summary>
        public static readonly H265FlickerAdaptiveQuantization DISABLED = new H265FlickerAdaptiveQuantization("DISABLED");
        /// <summary>
        /// Constant ENABLED for H265FlickerAdaptiveQuantization
        /// </summary>
        public static readonly H265FlickerAdaptiveQuantization ENABLED = new H265FlickerAdaptiveQuantization("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265FlickerAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265FlickerAdaptiveQuantization FindValue(string value)
        {
            return FindValue<H265FlickerAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265FlickerAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265FramerateControl.
    /// </summary>
    public class H265FramerateControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for H265FramerateControl
        /// </summary>
        public static readonly H265FramerateControl INITIALIZE_FROM_SOURCE = new H265FramerateControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for H265FramerateControl
        /// </summary>
        public static readonly H265FramerateControl SPECIFIED = new H265FramerateControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265FramerateControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265FramerateControl FindValue(string value)
        {
            return FindValue<H265FramerateControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265FramerateControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265FramerateConversionAlgorithm.
    /// </summary>
    public class H265FramerateConversionAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_DROP for H265FramerateConversionAlgorithm
        /// </summary>
        public static readonly H265FramerateConversionAlgorithm DUPLICATE_DROP = new H265FramerateConversionAlgorithm("DUPLICATE_DROP");
        /// <summary>
        /// Constant INTERPOLATE for H265FramerateConversionAlgorithm
        /// </summary>
        public static readonly H265FramerateConversionAlgorithm INTERPOLATE = new H265FramerateConversionAlgorithm("INTERPOLATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265FramerateConversionAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265FramerateConversionAlgorithm FindValue(string value)
        {
            return FindValue<H265FramerateConversionAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265FramerateConversionAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265GopBReference.
    /// </summary>
    public class H265GopBReference : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H265GopBReference
        /// </summary>
        public static readonly H265GopBReference DISABLED = new H265GopBReference("DISABLED");
        /// <summary>
        /// Constant ENABLED for H265GopBReference
        /// </summary>
        public static readonly H265GopBReference ENABLED = new H265GopBReference("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265GopBReference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265GopBReference FindValue(string value)
        {
            return FindValue<H265GopBReference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265GopBReference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265GopSizeUnits.
    /// </summary>
    public class H265GopSizeUnits : ConstantClass
    {

        /// <summary>
        /// Constant FRAMES for H265GopSizeUnits
        /// </summary>
        public static readonly H265GopSizeUnits FRAMES = new H265GopSizeUnits("FRAMES");
        /// <summary>
        /// Constant SECONDS for H265GopSizeUnits
        /// </summary>
        public static readonly H265GopSizeUnits SECONDS = new H265GopSizeUnits("SECONDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265GopSizeUnits(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265GopSizeUnits FindValue(string value)
        {
            return FindValue<H265GopSizeUnits>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265GopSizeUnits(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265InterlaceMode.
    /// </summary>
    public class H265InterlaceMode : ConstantClass
    {

        /// <summary>
        /// Constant BOTTOM_FIELD for H265InterlaceMode
        /// </summary>
        public static readonly H265InterlaceMode BOTTOM_FIELD = new H265InterlaceMode("BOTTOM_FIELD");
        /// <summary>
        /// Constant FOLLOW_BOTTOM_FIELD for H265InterlaceMode
        /// </summary>
        public static readonly H265InterlaceMode FOLLOW_BOTTOM_FIELD = new H265InterlaceMode("FOLLOW_BOTTOM_FIELD");
        /// <summary>
        /// Constant FOLLOW_TOP_FIELD for H265InterlaceMode
        /// </summary>
        public static readonly H265InterlaceMode FOLLOW_TOP_FIELD = new H265InterlaceMode("FOLLOW_TOP_FIELD");
        /// <summary>
        /// Constant PROGRESSIVE for H265InterlaceMode
        /// </summary>
        public static readonly H265InterlaceMode PROGRESSIVE = new H265InterlaceMode("PROGRESSIVE");
        /// <summary>
        /// Constant TOP_FIELD for H265InterlaceMode
        /// </summary>
        public static readonly H265InterlaceMode TOP_FIELD = new H265InterlaceMode("TOP_FIELD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265InterlaceMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265InterlaceMode FindValue(string value)
        {
            return FindValue<H265InterlaceMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265InterlaceMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265ParControl.
    /// </summary>
    public class H265ParControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for H265ParControl
        /// </summary>
        public static readonly H265ParControl INITIALIZE_FROM_SOURCE = new H265ParControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for H265ParControl
        /// </summary>
        public static readonly H265ParControl SPECIFIED = new H265ParControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265ParControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265ParControl FindValue(string value)
        {
            return FindValue<H265ParControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265ParControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265QualityTuningLevel.
    /// </summary>
    public class H265QualityTuningLevel : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_PASS_HQ for H265QualityTuningLevel
        /// </summary>
        public static readonly H265QualityTuningLevel MULTI_PASS_HQ = new H265QualityTuningLevel("MULTI_PASS_HQ");
        /// <summary>
        /// Constant SINGLE_PASS for H265QualityTuningLevel
        /// </summary>
        public static readonly H265QualityTuningLevel SINGLE_PASS = new H265QualityTuningLevel("SINGLE_PASS");
        /// <summary>
        /// Constant SINGLE_PASS_HQ for H265QualityTuningLevel
        /// </summary>
        public static readonly H265QualityTuningLevel SINGLE_PASS_HQ = new H265QualityTuningLevel("SINGLE_PASS_HQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265QualityTuningLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265QualityTuningLevel FindValue(string value)
        {
            return FindValue<H265QualityTuningLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265QualityTuningLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265RateControlMode.
    /// </summary>
    public class H265RateControlMode : ConstantClass
    {

        /// <summary>
        /// Constant CBR for H265RateControlMode
        /// </summary>
        public static readonly H265RateControlMode CBR = new H265RateControlMode("CBR");
        /// <summary>
        /// Constant VBR for H265RateControlMode
        /// </summary>
        public static readonly H265RateControlMode VBR = new H265RateControlMode("VBR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265RateControlMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265RateControlMode FindValue(string value)
        {
            return FindValue<H265RateControlMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265RateControlMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265SampleAdaptiveOffsetFilterMode.
    /// </summary>
    public class H265SampleAdaptiveOffsetFilterMode : ConstantClass
    {

        /// <summary>
        /// Constant ADAPTIVE for H265SampleAdaptiveOffsetFilterMode
        /// </summary>
        public static readonly H265SampleAdaptiveOffsetFilterMode ADAPTIVE = new H265SampleAdaptiveOffsetFilterMode("ADAPTIVE");
        /// <summary>
        /// Constant DEFAULT for H265SampleAdaptiveOffsetFilterMode
        /// </summary>
        public static readonly H265SampleAdaptiveOffsetFilterMode DEFAULT = new H265SampleAdaptiveOffsetFilterMode("DEFAULT");
        /// <summary>
        /// Constant OFF for H265SampleAdaptiveOffsetFilterMode
        /// </summary>
        public static readonly H265SampleAdaptiveOffsetFilterMode OFF = new H265SampleAdaptiveOffsetFilterMode("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265SampleAdaptiveOffsetFilterMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265SampleAdaptiveOffsetFilterMode FindValue(string value)
        {
            return FindValue<H265SampleAdaptiveOffsetFilterMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265SampleAdaptiveOffsetFilterMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265SceneChangeDetect.
    /// </summary>
    public class H265SceneChangeDetect : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H265SceneChangeDetect
        /// </summary>
        public static readonly H265SceneChangeDetect DISABLED = new H265SceneChangeDetect("DISABLED");
        /// <summary>
        /// Constant ENABLED for H265SceneChangeDetect
        /// </summary>
        public static readonly H265SceneChangeDetect ENABLED = new H265SceneChangeDetect("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265SceneChangeDetect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265SceneChangeDetect FindValue(string value)
        {
            return FindValue<H265SceneChangeDetect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265SceneChangeDetect(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265SlowPal.
    /// </summary>
    public class H265SlowPal : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H265SlowPal
        /// </summary>
        public static readonly H265SlowPal DISABLED = new H265SlowPal("DISABLED");
        /// <summary>
        /// Constant ENABLED for H265SlowPal
        /// </summary>
        public static readonly H265SlowPal ENABLED = new H265SlowPal("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265SlowPal(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265SlowPal FindValue(string value)
        {
            return FindValue<H265SlowPal>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265SlowPal(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265SpatialAdaptiveQuantization.
    /// </summary>
    public class H265SpatialAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H265SpatialAdaptiveQuantization
        /// </summary>
        public static readonly H265SpatialAdaptiveQuantization DISABLED = new H265SpatialAdaptiveQuantization("DISABLED");
        /// <summary>
        /// Constant ENABLED for H265SpatialAdaptiveQuantization
        /// </summary>
        public static readonly H265SpatialAdaptiveQuantization ENABLED = new H265SpatialAdaptiveQuantization("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265SpatialAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265SpatialAdaptiveQuantization FindValue(string value)
        {
            return FindValue<H265SpatialAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265SpatialAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265Telecine.
    /// </summary>
    public class H265Telecine : ConstantClass
    {

        /// <summary>
        /// Constant HARD for H265Telecine
        /// </summary>
        public static readonly H265Telecine HARD = new H265Telecine("HARD");
        /// <summary>
        /// Constant NONE for H265Telecine
        /// </summary>
        public static readonly H265Telecine NONE = new H265Telecine("NONE");
        /// <summary>
        /// Constant SOFT for H265Telecine
        /// </summary>
        public static readonly H265Telecine SOFT = new H265Telecine("SOFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265Telecine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265Telecine FindValue(string value)
        {
            return FindValue<H265Telecine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265Telecine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265TemporalAdaptiveQuantization.
    /// </summary>
    public class H265TemporalAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H265TemporalAdaptiveQuantization
        /// </summary>
        public static readonly H265TemporalAdaptiveQuantization DISABLED = new H265TemporalAdaptiveQuantization("DISABLED");
        /// <summary>
        /// Constant ENABLED for H265TemporalAdaptiveQuantization
        /// </summary>
        public static readonly H265TemporalAdaptiveQuantization ENABLED = new H265TemporalAdaptiveQuantization("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265TemporalAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265TemporalAdaptiveQuantization FindValue(string value)
        {
            return FindValue<H265TemporalAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265TemporalAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265TemporalIds.
    /// </summary>
    public class H265TemporalIds : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H265TemporalIds
        /// </summary>
        public static readonly H265TemporalIds DISABLED = new H265TemporalIds("DISABLED");
        /// <summary>
        /// Constant ENABLED for H265TemporalIds
        /// </summary>
        public static readonly H265TemporalIds ENABLED = new H265TemporalIds("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265TemporalIds(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265TemporalIds FindValue(string value)
        {
            return FindValue<H265TemporalIds>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265TemporalIds(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265Tiles.
    /// </summary>
    public class H265Tiles : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H265Tiles
        /// </summary>
        public static readonly H265Tiles DISABLED = new H265Tiles("DISABLED");
        /// <summary>
        /// Constant ENABLED for H265Tiles
        /// </summary>
        public static readonly H265Tiles ENABLED = new H265Tiles("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265Tiles(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265Tiles FindValue(string value)
        {
            return FindValue<H265Tiles>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265Tiles(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265UnregisteredSeiTimecode.
    /// </summary>
    public class H265UnregisteredSeiTimecode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H265UnregisteredSeiTimecode
        /// </summary>
        public static readonly H265UnregisteredSeiTimecode DISABLED = new H265UnregisteredSeiTimecode("DISABLED");
        /// <summary>
        /// Constant ENABLED for H265UnregisteredSeiTimecode
        /// </summary>
        public static readonly H265UnregisteredSeiTimecode ENABLED = new H265UnregisteredSeiTimecode("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265UnregisteredSeiTimecode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265UnregisteredSeiTimecode FindValue(string value)
        {
            return FindValue<H265UnregisteredSeiTimecode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265UnregisteredSeiTimecode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265WriteMp4PackagingType.
    /// </summary>
    public class H265WriteMp4PackagingType : ConstantClass
    {

        /// <summary>
        /// Constant HEV1 for H265WriteMp4PackagingType
        /// </summary>
        public static readonly H265WriteMp4PackagingType HEV1 = new H265WriteMp4PackagingType("HEV1");
        /// <summary>
        /// Constant HVC1 for H265WriteMp4PackagingType
        /// </summary>
        public static readonly H265WriteMp4PackagingType HVC1 = new H265WriteMp4PackagingType("HVC1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265WriteMp4PackagingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265WriteMp4PackagingType FindValue(string value)
        {
            return FindValue<H265WriteMp4PackagingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265WriteMp4PackagingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsAdMarkers.
    /// </summary>
    public class HlsAdMarkers : ConstantClass
    {

        /// <summary>
        /// Constant ELEMENTAL for HlsAdMarkers
        /// </summary>
        public static readonly HlsAdMarkers ELEMENTAL = new HlsAdMarkers("ELEMENTAL");
        /// <summary>
        /// Constant ELEMENTAL_SCTE35 for HlsAdMarkers
        /// </summary>
        public static readonly HlsAdMarkers ELEMENTAL_SCTE35 = new HlsAdMarkers("ELEMENTAL_SCTE35");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsAdMarkers(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsAdMarkers FindValue(string value)
        {
            return FindValue<HlsAdMarkers>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsAdMarkers(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsAudioTrackType.
    /// </summary>
    public class HlsAudioTrackType : ConstantClass
    {

        /// <summary>
        /// Constant ALTERNATE_AUDIO_AUTO_SELECT for HlsAudioTrackType
        /// </summary>
        public static readonly HlsAudioTrackType ALTERNATE_AUDIO_AUTO_SELECT = new HlsAudioTrackType("ALTERNATE_AUDIO_AUTO_SELECT");
        /// <summary>
        /// Constant ALTERNATE_AUDIO_AUTO_SELECT_DEFAULT for HlsAudioTrackType
        /// </summary>
        public static readonly HlsAudioTrackType ALTERNATE_AUDIO_AUTO_SELECT_DEFAULT = new HlsAudioTrackType("ALTERNATE_AUDIO_AUTO_SELECT_DEFAULT");
        /// <summary>
        /// Constant ALTERNATE_AUDIO_NOT_AUTO_SELECT for HlsAudioTrackType
        /// </summary>
        public static readonly HlsAudioTrackType ALTERNATE_AUDIO_NOT_AUTO_SELECT = new HlsAudioTrackType("ALTERNATE_AUDIO_NOT_AUTO_SELECT");
        /// <summary>
        /// Constant AUDIO_ONLY_VARIANT_STREAM for HlsAudioTrackType
        /// </summary>
        public static readonly HlsAudioTrackType AUDIO_ONLY_VARIANT_STREAM = new HlsAudioTrackType("AUDIO_ONLY_VARIANT_STREAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsAudioTrackType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsAudioTrackType FindValue(string value)
        {
            return FindValue<HlsAudioTrackType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsAudioTrackType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsCaptionLanguageSetting.
    /// </summary>
    public class HlsCaptionLanguageSetting : ConstantClass
    {

        /// <summary>
        /// Constant INSERT for HlsCaptionLanguageSetting
        /// </summary>
        public static readonly HlsCaptionLanguageSetting INSERT = new HlsCaptionLanguageSetting("INSERT");
        /// <summary>
        /// Constant NONE for HlsCaptionLanguageSetting
        /// </summary>
        public static readonly HlsCaptionLanguageSetting NONE = new HlsCaptionLanguageSetting("NONE");
        /// <summary>
        /// Constant OMIT for HlsCaptionLanguageSetting
        /// </summary>
        public static readonly HlsCaptionLanguageSetting OMIT = new HlsCaptionLanguageSetting("OMIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsCaptionLanguageSetting(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsCaptionLanguageSetting FindValue(string value)
        {
            return FindValue<HlsCaptionLanguageSetting>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsCaptionLanguageSetting(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsClientCache.
    /// </summary>
    public class HlsClientCache : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for HlsClientCache
        /// </summary>
        public static readonly HlsClientCache DISABLED = new HlsClientCache("DISABLED");
        /// <summary>
        /// Constant ENABLED for HlsClientCache
        /// </summary>
        public static readonly HlsClientCache ENABLED = new HlsClientCache("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsClientCache(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsClientCache FindValue(string value)
        {
            return FindValue<HlsClientCache>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsClientCache(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsCodecSpecification.
    /// </summary>
    public class HlsCodecSpecification : ConstantClass
    {

        /// <summary>
        /// Constant RFC_4281 for HlsCodecSpecification
        /// </summary>
        public static readonly HlsCodecSpecification RFC_4281 = new HlsCodecSpecification("RFC_4281");
        /// <summary>
        /// Constant RFC_6381 for HlsCodecSpecification
        /// </summary>
        public static readonly HlsCodecSpecification RFC_6381 = new HlsCodecSpecification("RFC_6381");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsCodecSpecification(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsCodecSpecification FindValue(string value)
        {
            return FindValue<HlsCodecSpecification>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsCodecSpecification(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsDirectoryStructure.
    /// </summary>
    public class HlsDirectoryStructure : ConstantClass
    {

        /// <summary>
        /// Constant SINGLE_DIRECTORY for HlsDirectoryStructure
        /// </summary>
        public static readonly HlsDirectoryStructure SINGLE_DIRECTORY = new HlsDirectoryStructure("SINGLE_DIRECTORY");
        /// <summary>
        /// Constant SUBDIRECTORY_PER_STREAM for HlsDirectoryStructure
        /// </summary>
        public static readonly HlsDirectoryStructure SUBDIRECTORY_PER_STREAM = new HlsDirectoryStructure("SUBDIRECTORY_PER_STREAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsDirectoryStructure(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsDirectoryStructure FindValue(string value)
        {
            return FindValue<HlsDirectoryStructure>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsDirectoryStructure(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsEncryptionType.
    /// </summary>
    public class HlsEncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant AES128 for HlsEncryptionType
        /// </summary>
        public static readonly HlsEncryptionType AES128 = new HlsEncryptionType("AES128");
        /// <summary>
        /// Constant SAMPLE_AES for HlsEncryptionType
        /// </summary>
        public static readonly HlsEncryptionType SAMPLE_AES = new HlsEncryptionType("SAMPLE_AES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsEncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsEncryptionType FindValue(string value)
        {
            return FindValue<HlsEncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsEncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsIFrameOnlyManifest.
    /// </summary>
    public class HlsIFrameOnlyManifest : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for HlsIFrameOnlyManifest
        /// </summary>
        public static readonly HlsIFrameOnlyManifest EXCLUDE = new HlsIFrameOnlyManifest("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for HlsIFrameOnlyManifest
        /// </summary>
        public static readonly HlsIFrameOnlyManifest INCLUDE = new HlsIFrameOnlyManifest("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsIFrameOnlyManifest(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsIFrameOnlyManifest FindValue(string value)
        {
            return FindValue<HlsIFrameOnlyManifest>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsIFrameOnlyManifest(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsInitializationVectorInManifest.
    /// </summary>
    public class HlsInitializationVectorInManifest : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for HlsInitializationVectorInManifest
        /// </summary>
        public static readonly HlsInitializationVectorInManifest EXCLUDE = new HlsInitializationVectorInManifest("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for HlsInitializationVectorInManifest
        /// </summary>
        public static readonly HlsInitializationVectorInManifest INCLUDE = new HlsInitializationVectorInManifest("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsInitializationVectorInManifest(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsInitializationVectorInManifest FindValue(string value)
        {
            return FindValue<HlsInitializationVectorInManifest>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsInitializationVectorInManifest(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsKeyProviderType.
    /// </summary>
    public class HlsKeyProviderType : ConstantClass
    {

        /// <summary>
        /// Constant SPEKE for HlsKeyProviderType
        /// </summary>
        public static readonly HlsKeyProviderType SPEKE = new HlsKeyProviderType("SPEKE");
        /// <summary>
        /// Constant STATIC_KEY for HlsKeyProviderType
        /// </summary>
        public static readonly HlsKeyProviderType STATIC_KEY = new HlsKeyProviderType("STATIC_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsKeyProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsKeyProviderType FindValue(string value)
        {
            return FindValue<HlsKeyProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsKeyProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsManifestCompression.
    /// </summary>
    public class HlsManifestCompression : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for HlsManifestCompression
        /// </summary>
        public static readonly HlsManifestCompression GZIP = new HlsManifestCompression("GZIP");
        /// <summary>
        /// Constant NONE for HlsManifestCompression
        /// </summary>
        public static readonly HlsManifestCompression NONE = new HlsManifestCompression("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsManifestCompression(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsManifestCompression FindValue(string value)
        {
            return FindValue<HlsManifestCompression>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsManifestCompression(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsManifestDurationFormat.
    /// </summary>
    public class HlsManifestDurationFormat : ConstantClass
    {

        /// <summary>
        /// Constant FLOATING_POINT for HlsManifestDurationFormat
        /// </summary>
        public static readonly HlsManifestDurationFormat FLOATING_POINT = new HlsManifestDurationFormat("FLOATING_POINT");
        /// <summary>
        /// Constant INTEGER for HlsManifestDurationFormat
        /// </summary>
        public static readonly HlsManifestDurationFormat INTEGER = new HlsManifestDurationFormat("INTEGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsManifestDurationFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsManifestDurationFormat FindValue(string value)
        {
            return FindValue<HlsManifestDurationFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsManifestDurationFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsOutputSelection.
    /// </summary>
    public class HlsOutputSelection : ConstantClass
    {

        /// <summary>
        /// Constant MANIFESTS_AND_SEGMENTS for HlsOutputSelection
        /// </summary>
        public static readonly HlsOutputSelection MANIFESTS_AND_SEGMENTS = new HlsOutputSelection("MANIFESTS_AND_SEGMENTS");
        /// <summary>
        /// Constant SEGMENTS_ONLY for HlsOutputSelection
        /// </summary>
        public static readonly HlsOutputSelection SEGMENTS_ONLY = new HlsOutputSelection("SEGMENTS_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsOutputSelection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsOutputSelection FindValue(string value)
        {
            return FindValue<HlsOutputSelection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsOutputSelection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsProgramDateTime.
    /// </summary>
    public class HlsProgramDateTime : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for HlsProgramDateTime
        /// </summary>
        public static readonly HlsProgramDateTime EXCLUDE = new HlsProgramDateTime("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for HlsProgramDateTime
        /// </summary>
        public static readonly HlsProgramDateTime INCLUDE = new HlsProgramDateTime("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsProgramDateTime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsProgramDateTime FindValue(string value)
        {
            return FindValue<HlsProgramDateTime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsProgramDateTime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsSegmentControl.
    /// </summary>
    public class HlsSegmentControl : ConstantClass
    {

        /// <summary>
        /// Constant SEGMENTED_FILES for HlsSegmentControl
        /// </summary>
        public static readonly HlsSegmentControl SEGMENTED_FILES = new HlsSegmentControl("SEGMENTED_FILES");
        /// <summary>
        /// Constant SINGLE_FILE for HlsSegmentControl
        /// </summary>
        public static readonly HlsSegmentControl SINGLE_FILE = new HlsSegmentControl("SINGLE_FILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsSegmentControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsSegmentControl FindValue(string value)
        {
            return FindValue<HlsSegmentControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsSegmentControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsStreamInfResolution.
    /// </summary>
    public class HlsStreamInfResolution : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for HlsStreamInfResolution
        /// </summary>
        public static readonly HlsStreamInfResolution EXCLUDE = new HlsStreamInfResolution("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for HlsStreamInfResolution
        /// </summary>
        public static readonly HlsStreamInfResolution INCLUDE = new HlsStreamInfResolution("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsStreamInfResolution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsStreamInfResolution FindValue(string value)
        {
            return FindValue<HlsStreamInfResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsStreamInfResolution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsTimedMetadataId3Frame.
    /// </summary>
    public class HlsTimedMetadataId3Frame : ConstantClass
    {

        /// <summary>
        /// Constant NONE for HlsTimedMetadataId3Frame
        /// </summary>
        public static readonly HlsTimedMetadataId3Frame NONE = new HlsTimedMetadataId3Frame("NONE");
        /// <summary>
        /// Constant PRIV for HlsTimedMetadataId3Frame
        /// </summary>
        public static readonly HlsTimedMetadataId3Frame PRIV = new HlsTimedMetadataId3Frame("PRIV");
        /// <summary>
        /// Constant TDRL for HlsTimedMetadataId3Frame
        /// </summary>
        public static readonly HlsTimedMetadataId3Frame TDRL = new HlsTimedMetadataId3Frame("TDRL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsTimedMetadataId3Frame(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsTimedMetadataId3Frame FindValue(string value)
        {
            return FindValue<HlsTimedMetadataId3Frame>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsTimedMetadataId3Frame(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputDeblockFilter.
    /// </summary>
    public class InputDeblockFilter : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for InputDeblockFilter
        /// </summary>
        public static readonly InputDeblockFilter DISABLED = new InputDeblockFilter("DISABLED");
        /// <summary>
        /// Constant ENABLED for InputDeblockFilter
        /// </summary>
        public static readonly InputDeblockFilter ENABLED = new InputDeblockFilter("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputDeblockFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputDeblockFilter FindValue(string value)
        {
            return FindValue<InputDeblockFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputDeblockFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputDenoiseFilter.
    /// </summary>
    public class InputDenoiseFilter : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for InputDenoiseFilter
        /// </summary>
        public static readonly InputDenoiseFilter DISABLED = new InputDenoiseFilter("DISABLED");
        /// <summary>
        /// Constant ENABLED for InputDenoiseFilter
        /// </summary>
        public static readonly InputDenoiseFilter ENABLED = new InputDenoiseFilter("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputDenoiseFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputDenoiseFilter FindValue(string value)
        {
            return FindValue<InputDenoiseFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputDenoiseFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputFilterEnable.
    /// </summary>
    public class InputFilterEnable : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for InputFilterEnable
        /// </summary>
        public static readonly InputFilterEnable AUTO = new InputFilterEnable("AUTO");
        /// <summary>
        /// Constant DISABLE for InputFilterEnable
        /// </summary>
        public static readonly InputFilterEnable DISABLE = new InputFilterEnable("DISABLE");
        /// <summary>
        /// Constant FORCE for InputFilterEnable
        /// </summary>
        public static readonly InputFilterEnable FORCE = new InputFilterEnable("FORCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputFilterEnable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputFilterEnable FindValue(string value)
        {
            return FindValue<InputFilterEnable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputFilterEnable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputPsiControl.
    /// </summary>
    public class InputPsiControl : ConstantClass
    {

        /// <summary>
        /// Constant IGNORE_PSI for InputPsiControl
        /// </summary>
        public static readonly InputPsiControl IGNORE_PSI = new InputPsiControl("IGNORE_PSI");
        /// <summary>
        /// Constant USE_PSI for InputPsiControl
        /// </summary>
        public static readonly InputPsiControl USE_PSI = new InputPsiControl("USE_PSI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputPsiControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputPsiControl FindValue(string value)
        {
            return FindValue<InputPsiControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputPsiControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputTimecodeSource.
    /// </summary>
    public class InputTimecodeSource : ConstantClass
    {

        /// <summary>
        /// Constant EMBEDDED for InputTimecodeSource
        /// </summary>
        public static readonly InputTimecodeSource EMBEDDED = new InputTimecodeSource("EMBEDDED");
        /// <summary>
        /// Constant SPECIFIEDSTART for InputTimecodeSource
        /// </summary>
        public static readonly InputTimecodeSource SPECIFIEDSTART = new InputTimecodeSource("SPECIFIEDSTART");
        /// <summary>
        /// Constant ZEROBASED for InputTimecodeSource
        /// </summary>
        public static readonly InputTimecodeSource ZEROBASED = new InputTimecodeSource("ZEROBASED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputTimecodeSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputTimecodeSource FindValue(string value)
        {
            return FindValue<InputTimecodeSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputTimecodeSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for JobStatus
        /// </summary>
        public static readonly JobStatus CANCELED = new JobStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETE for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETE = new JobStatus("COMPLETE");
        /// <summary>
        /// Constant ERROR for JobStatus
        /// </summary>
        public static readonly JobStatus ERROR = new JobStatus("ERROR");
        /// <summary>
        /// Constant PROGRESSING for JobStatus
        /// </summary>
        public static readonly JobStatus PROGRESSING = new JobStatus("PROGRESSING");
        /// <summary>
        /// Constant SUBMITTED for JobStatus
        /// </summary>
        public static readonly JobStatus SUBMITTED = new JobStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatus FindValue(string value)
        {
            return FindValue<JobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobTemplateListBy.
    /// </summary>
    public class JobTemplateListBy : ConstantClass
    {

        /// <summary>
        /// Constant CREATION_DATE for JobTemplateListBy
        /// </summary>
        public static readonly JobTemplateListBy CREATION_DATE = new JobTemplateListBy("CREATION_DATE");
        /// <summary>
        /// Constant NAME for JobTemplateListBy
        /// </summary>
        public static readonly JobTemplateListBy NAME = new JobTemplateListBy("NAME");
        /// <summary>
        /// Constant SYSTEM for JobTemplateListBy
        /// </summary>
        public static readonly JobTemplateListBy SYSTEM = new JobTemplateListBy("SYSTEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobTemplateListBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobTemplateListBy FindValue(string value)
        {
            return FindValue<JobTemplateListBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobTemplateListBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LanguageCode.
    /// </summary>
    public class LanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant AAR for LanguageCode
        /// </summary>
        public static readonly LanguageCode AAR = new LanguageCode("AAR");
        /// <summary>
        /// Constant ABK for LanguageCode
        /// </summary>
        public static readonly LanguageCode ABK = new LanguageCode("ABK");
        /// <summary>
        /// Constant AFR for LanguageCode
        /// </summary>
        public static readonly LanguageCode AFR = new LanguageCode("AFR");
        /// <summary>
        /// Constant AKA for LanguageCode
        /// </summary>
        public static readonly LanguageCode AKA = new LanguageCode("AKA");
        /// <summary>
        /// Constant AMH for LanguageCode
        /// </summary>
        public static readonly LanguageCode AMH = new LanguageCode("AMH");
        /// <summary>
        /// Constant ARA for LanguageCode
        /// </summary>
        public static readonly LanguageCode ARA = new LanguageCode("ARA");
        /// <summary>
        /// Constant ARG for LanguageCode
        /// </summary>
        public static readonly LanguageCode ARG = new LanguageCode("ARG");
        /// <summary>
        /// Constant ASM for LanguageCode
        /// </summary>
        public static readonly LanguageCode ASM = new LanguageCode("ASM");
        /// <summary>
        /// Constant AVA for LanguageCode
        /// </summary>
        public static readonly LanguageCode AVA = new LanguageCode("AVA");
        /// <summary>
        /// Constant AVE for LanguageCode
        /// </summary>
        public static readonly LanguageCode AVE = new LanguageCode("AVE");
        /// <summary>
        /// Constant AYM for LanguageCode
        /// </summary>
        public static readonly LanguageCode AYM = new LanguageCode("AYM");
        /// <summary>
        /// Constant AZE for LanguageCode
        /// </summary>
        public static readonly LanguageCode AZE = new LanguageCode("AZE");
        /// <summary>
        /// Constant BAK for LanguageCode
        /// </summary>
        public static readonly LanguageCode BAK = new LanguageCode("BAK");
        /// <summary>
        /// Constant BAM for LanguageCode
        /// </summary>
        public static readonly LanguageCode BAM = new LanguageCode("BAM");
        /// <summary>
        /// Constant BEL for LanguageCode
        /// </summary>
        public static readonly LanguageCode BEL = new LanguageCode("BEL");
        /// <summary>
        /// Constant BEN for LanguageCode
        /// </summary>
        public static readonly LanguageCode BEN = new LanguageCode("BEN");
        /// <summary>
        /// Constant BIH for LanguageCode
        /// </summary>
        public static readonly LanguageCode BIH = new LanguageCode("BIH");
        /// <summary>
        /// Constant BIS for LanguageCode
        /// </summary>
        public static readonly LanguageCode BIS = new LanguageCode("BIS");
        /// <summary>
        /// Constant BOD for LanguageCode
        /// </summary>
        public static readonly LanguageCode BOD = new LanguageCode("BOD");
        /// <summary>
        /// Constant BOS for LanguageCode
        /// </summary>
        public static readonly LanguageCode BOS = new LanguageCode("BOS");
        /// <summary>
        /// Constant BRE for LanguageCode
        /// </summary>
        public static readonly LanguageCode BRE = new LanguageCode("BRE");
        /// <summary>
        /// Constant BUL for LanguageCode
        /// </summary>
        public static readonly LanguageCode BUL = new LanguageCode("BUL");
        /// <summary>
        /// Constant CAT for LanguageCode
        /// </summary>
        public static readonly LanguageCode CAT = new LanguageCode("CAT");
        /// <summary>
        /// Constant CES for LanguageCode
        /// </summary>
        public static readonly LanguageCode CES = new LanguageCode("CES");
        /// <summary>
        /// Constant CHA for LanguageCode
        /// </summary>
        public static readonly LanguageCode CHA = new LanguageCode("CHA");
        /// <summary>
        /// Constant CHE for LanguageCode
        /// </summary>
        public static readonly LanguageCode CHE = new LanguageCode("CHE");
        /// <summary>
        /// Constant CHU for LanguageCode
        /// </summary>
        public static readonly LanguageCode CHU = new LanguageCode("CHU");
        /// <summary>
        /// Constant CHV for LanguageCode
        /// </summary>
        public static readonly LanguageCode CHV = new LanguageCode("CHV");
        /// <summary>
        /// Constant COR for LanguageCode
        /// </summary>
        public static readonly LanguageCode COR = new LanguageCode("COR");
        /// <summary>
        /// Constant COS for LanguageCode
        /// </summary>
        public static readonly LanguageCode COS = new LanguageCode("COS");
        /// <summary>
        /// Constant CRE for LanguageCode
        /// </summary>
        public static readonly LanguageCode CRE = new LanguageCode("CRE");
        /// <summary>
        /// Constant CYM for LanguageCode
        /// </summary>
        public static readonly LanguageCode CYM = new LanguageCode("CYM");
        /// <summary>
        /// Constant DAN for LanguageCode
        /// </summary>
        public static readonly LanguageCode DAN = new LanguageCode("DAN");
        /// <summary>
        /// Constant DEU for LanguageCode
        /// </summary>
        public static readonly LanguageCode DEU = new LanguageCode("DEU");
        /// <summary>
        /// Constant DIV for LanguageCode
        /// </summary>
        public static readonly LanguageCode DIV = new LanguageCode("DIV");
        /// <summary>
        /// Constant DZO for LanguageCode
        /// </summary>
        public static readonly LanguageCode DZO = new LanguageCode("DZO");
        /// <summary>
        /// Constant ELL for LanguageCode
        /// </summary>
        public static readonly LanguageCode ELL = new LanguageCode("ELL");
        /// <summary>
        /// Constant ENG for LanguageCode
        /// </summary>
        public static readonly LanguageCode ENG = new LanguageCode("ENG");
        /// <summary>
        /// Constant ENM for LanguageCode
        /// </summary>
        public static readonly LanguageCode ENM = new LanguageCode("ENM");
        /// <summary>
        /// Constant EPO for LanguageCode
        /// </summary>
        public static readonly LanguageCode EPO = new LanguageCode("EPO");
        /// <summary>
        /// Constant EST for LanguageCode
        /// </summary>
        public static readonly LanguageCode EST = new LanguageCode("EST");
        /// <summary>
        /// Constant EUS for LanguageCode
        /// </summary>
        public static readonly LanguageCode EUS = new LanguageCode("EUS");
        /// <summary>
        /// Constant EWE for LanguageCode
        /// </summary>
        public static readonly LanguageCode EWE = new LanguageCode("EWE");
        /// <summary>
        /// Constant FAO for LanguageCode
        /// </summary>
        public static readonly LanguageCode FAO = new LanguageCode("FAO");
        /// <summary>
        /// Constant FAS for LanguageCode
        /// </summary>
        public static readonly LanguageCode FAS = new LanguageCode("FAS");
        /// <summary>
        /// Constant FIJ for LanguageCode
        /// </summary>
        public static readonly LanguageCode FIJ = new LanguageCode("FIJ");
        /// <summary>
        /// Constant FIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode FIN = new LanguageCode("FIN");
        /// <summary>
        /// Constant FRA for LanguageCode
        /// </summary>
        public static readonly LanguageCode FRA = new LanguageCode("FRA");
        /// <summary>
        /// Constant FRM for LanguageCode
        /// </summary>
        public static readonly LanguageCode FRM = new LanguageCode("FRM");
        /// <summary>
        /// Constant FRY for LanguageCode
        /// </summary>
        public static readonly LanguageCode FRY = new LanguageCode("FRY");
        /// <summary>
        /// Constant FUL for LanguageCode
        /// </summary>
        public static readonly LanguageCode FUL = new LanguageCode("FUL");
        /// <summary>
        /// Constant GER for LanguageCode
        /// </summary>
        public static readonly LanguageCode GER = new LanguageCode("GER");
        /// <summary>
        /// Constant GLA for LanguageCode
        /// </summary>
        public static readonly LanguageCode GLA = new LanguageCode("GLA");
        /// <summary>
        /// Constant GLE for LanguageCode
        /// </summary>
        public static readonly LanguageCode GLE = new LanguageCode("GLE");
        /// <summary>
        /// Constant GLG for LanguageCode
        /// </summary>
        public static readonly LanguageCode GLG = new LanguageCode("GLG");
        /// <summary>
        /// Constant GLV for LanguageCode
        /// </summary>
        public static readonly LanguageCode GLV = new LanguageCode("GLV");
        /// <summary>
        /// Constant GRN for LanguageCode
        /// </summary>
        public static readonly LanguageCode GRN = new LanguageCode("GRN");
        /// <summary>
        /// Constant GUJ for LanguageCode
        /// </summary>
        public static readonly LanguageCode GUJ = new LanguageCode("GUJ");
        /// <summary>
        /// Constant HAT for LanguageCode
        /// </summary>
        public static readonly LanguageCode HAT = new LanguageCode("HAT");
        /// <summary>
        /// Constant HAU for LanguageCode
        /// </summary>
        public static readonly LanguageCode HAU = new LanguageCode("HAU");
        /// <summary>
        /// Constant HEB for LanguageCode
        /// </summary>
        public static readonly LanguageCode HEB = new LanguageCode("HEB");
        /// <summary>
        /// Constant HER for LanguageCode
        /// </summary>
        public static readonly LanguageCode HER = new LanguageCode("HER");
        /// <summary>
        /// Constant HIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode HIN = new LanguageCode("HIN");
        /// <summary>
        /// Constant HMO for LanguageCode
        /// </summary>
        public static readonly LanguageCode HMO = new LanguageCode("HMO");
        /// <summary>
        /// Constant HRV for LanguageCode
        /// </summary>
        public static readonly LanguageCode HRV = new LanguageCode("HRV");
        /// <summary>
        /// Constant HUN for LanguageCode
        /// </summary>
        public static readonly LanguageCode HUN = new LanguageCode("HUN");
        /// <summary>
        /// Constant HYE for LanguageCode
        /// </summary>
        public static readonly LanguageCode HYE = new LanguageCode("HYE");
        /// <summary>
        /// Constant IBO for LanguageCode
        /// </summary>
        public static readonly LanguageCode IBO = new LanguageCode("IBO");
        /// <summary>
        /// Constant IDO for LanguageCode
        /// </summary>
        public static readonly LanguageCode IDO = new LanguageCode("IDO");
        /// <summary>
        /// Constant III for LanguageCode
        /// </summary>
        public static readonly LanguageCode III = new LanguageCode("III");
        /// <summary>
        /// Constant IKU for LanguageCode
        /// </summary>
        public static readonly LanguageCode IKU = new LanguageCode("IKU");
        /// <summary>
        /// Constant ILE for LanguageCode
        /// </summary>
        public static readonly LanguageCode ILE = new LanguageCode("ILE");
        /// <summary>
        /// Constant INA for LanguageCode
        /// </summary>
        public static readonly LanguageCode INA = new LanguageCode("INA");
        /// <summary>
        /// Constant IND for LanguageCode
        /// </summary>
        public static readonly LanguageCode IND = new LanguageCode("IND");
        /// <summary>
        /// Constant IPK for LanguageCode
        /// </summary>
        public static readonly LanguageCode IPK = new LanguageCode("IPK");
        /// <summary>
        /// Constant ISL for LanguageCode
        /// </summary>
        public static readonly LanguageCode ISL = new LanguageCode("ISL");
        /// <summary>
        /// Constant ITA for LanguageCode
        /// </summary>
        public static readonly LanguageCode ITA = new LanguageCode("ITA");
        /// <summary>
        /// Constant JAV for LanguageCode
        /// </summary>
        public static readonly LanguageCode JAV = new LanguageCode("JAV");
        /// <summary>
        /// Constant JPN for LanguageCode
        /// </summary>
        public static readonly LanguageCode JPN = new LanguageCode("JPN");
        /// <summary>
        /// Constant KAL for LanguageCode
        /// </summary>
        public static readonly LanguageCode KAL = new LanguageCode("KAL");
        /// <summary>
        /// Constant KAN for LanguageCode
        /// </summary>
        public static readonly LanguageCode KAN = new LanguageCode("KAN");
        /// <summary>
        /// Constant KAS for LanguageCode
        /// </summary>
        public static readonly LanguageCode KAS = new LanguageCode("KAS");
        /// <summary>
        /// Constant KAT for LanguageCode
        /// </summary>
        public static readonly LanguageCode KAT = new LanguageCode("KAT");
        /// <summary>
        /// Constant KAU for LanguageCode
        /// </summary>
        public static readonly LanguageCode KAU = new LanguageCode("KAU");
        /// <summary>
        /// Constant KAZ for LanguageCode
        /// </summary>
        public static readonly LanguageCode KAZ = new LanguageCode("KAZ");
        /// <summary>
        /// Constant KHM for LanguageCode
        /// </summary>
        public static readonly LanguageCode KHM = new LanguageCode("KHM");
        /// <summary>
        /// Constant KIK for LanguageCode
        /// </summary>
        public static readonly LanguageCode KIK = new LanguageCode("KIK");
        /// <summary>
        /// Constant KIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode KIN = new LanguageCode("KIN");
        /// <summary>
        /// Constant KIR for LanguageCode
        /// </summary>
        public static readonly LanguageCode KIR = new LanguageCode("KIR");
        /// <summary>
        /// Constant KOM for LanguageCode
        /// </summary>
        public static readonly LanguageCode KOM = new LanguageCode("KOM");
        /// <summary>
        /// Constant KON for LanguageCode
        /// </summary>
        public static readonly LanguageCode KON = new LanguageCode("KON");
        /// <summary>
        /// Constant KOR for LanguageCode
        /// </summary>
        public static readonly LanguageCode KOR = new LanguageCode("KOR");
        /// <summary>
        /// Constant KUA for LanguageCode
        /// </summary>
        public static readonly LanguageCode KUA = new LanguageCode("KUA");
        /// <summary>
        /// Constant KUR for LanguageCode
        /// </summary>
        public static readonly LanguageCode KUR = new LanguageCode("KUR");
        /// <summary>
        /// Constant LAO for LanguageCode
        /// </summary>
        public static readonly LanguageCode LAO = new LanguageCode("LAO");
        /// <summary>
        /// Constant LAT for LanguageCode
        /// </summary>
        public static readonly LanguageCode LAT = new LanguageCode("LAT");
        /// <summary>
        /// Constant LAV for LanguageCode
        /// </summary>
        public static readonly LanguageCode LAV = new LanguageCode("LAV");
        /// <summary>
        /// Constant LIM for LanguageCode
        /// </summary>
        public static readonly LanguageCode LIM = new LanguageCode("LIM");
        /// <summary>
        /// Constant LIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode LIN = new LanguageCode("LIN");
        /// <summary>
        /// Constant LIT for LanguageCode
        /// </summary>
        public static readonly LanguageCode LIT = new LanguageCode("LIT");
        /// <summary>
        /// Constant LTZ for LanguageCode
        /// </summary>
        public static readonly LanguageCode LTZ = new LanguageCode("LTZ");
        /// <summary>
        /// Constant LUB for LanguageCode
        /// </summary>
        public static readonly LanguageCode LUB = new LanguageCode("LUB");
        /// <summary>
        /// Constant LUG for LanguageCode
        /// </summary>
        public static readonly LanguageCode LUG = new LanguageCode("LUG");
        /// <summary>
        /// Constant MAH for LanguageCode
        /// </summary>
        public static readonly LanguageCode MAH = new LanguageCode("MAH");
        /// <summary>
        /// Constant MAL for LanguageCode
        /// </summary>
        public static readonly LanguageCode MAL = new LanguageCode("MAL");
        /// <summary>
        /// Constant MAR for LanguageCode
        /// </summary>
        public static readonly LanguageCode MAR = new LanguageCode("MAR");
        /// <summary>
        /// Constant MKD for LanguageCode
        /// </summary>
        public static readonly LanguageCode MKD = new LanguageCode("MKD");
        /// <summary>
        /// Constant MLG for LanguageCode
        /// </summary>
        public static readonly LanguageCode MLG = new LanguageCode("MLG");
        /// <summary>
        /// Constant MLT for LanguageCode
        /// </summary>
        public static readonly LanguageCode MLT = new LanguageCode("MLT");
        /// <summary>
        /// Constant MON for LanguageCode
        /// </summary>
        public static readonly LanguageCode MON = new LanguageCode("MON");
        /// <summary>
        /// Constant MRI for LanguageCode
        /// </summary>
        public static readonly LanguageCode MRI = new LanguageCode("MRI");
        /// <summary>
        /// Constant MSA for LanguageCode
        /// </summary>
        public static readonly LanguageCode MSA = new LanguageCode("MSA");
        /// <summary>
        /// Constant MYA for LanguageCode
        /// </summary>
        public static readonly LanguageCode MYA = new LanguageCode("MYA");
        /// <summary>
        /// Constant NAU for LanguageCode
        /// </summary>
        public static readonly LanguageCode NAU = new LanguageCode("NAU");
        /// <summary>
        /// Constant NAV for LanguageCode
        /// </summary>
        public static readonly LanguageCode NAV = new LanguageCode("NAV");
        /// <summary>
        /// Constant NBL for LanguageCode
        /// </summary>
        public static readonly LanguageCode NBL = new LanguageCode("NBL");
        /// <summary>
        /// Constant NDE for LanguageCode
        /// </summary>
        public static readonly LanguageCode NDE = new LanguageCode("NDE");
        /// <summary>
        /// Constant NDO for LanguageCode
        /// </summary>
        public static readonly LanguageCode NDO = new LanguageCode("NDO");
        /// <summary>
        /// Constant NEP for LanguageCode
        /// </summary>
        public static readonly LanguageCode NEP = new LanguageCode("NEP");
        /// <summary>
        /// Constant NLD for LanguageCode
        /// </summary>
        public static readonly LanguageCode NLD = new LanguageCode("NLD");
        /// <summary>
        /// Constant NNO for LanguageCode
        /// </summary>
        public static readonly LanguageCode NNO = new LanguageCode("NNO");
        /// <summary>
        /// Constant NOB for LanguageCode
        /// </summary>
        public static readonly LanguageCode NOB = new LanguageCode("NOB");
        /// <summary>
        /// Constant NOR for LanguageCode
        /// </summary>
        public static readonly LanguageCode NOR = new LanguageCode("NOR");
        /// <summary>
        /// Constant NYA for LanguageCode
        /// </summary>
        public static readonly LanguageCode NYA = new LanguageCode("NYA");
        /// <summary>
        /// Constant OCI for LanguageCode
        /// </summary>
        public static readonly LanguageCode OCI = new LanguageCode("OCI");
        /// <summary>
        /// Constant OJI for LanguageCode
        /// </summary>
        public static readonly LanguageCode OJI = new LanguageCode("OJI");
        /// <summary>
        /// Constant ORI for LanguageCode
        /// </summary>
        public static readonly LanguageCode ORI = new LanguageCode("ORI");
        /// <summary>
        /// Constant ORJ for LanguageCode
        /// </summary>
        public static readonly LanguageCode ORJ = new LanguageCode("ORJ");
        /// <summary>
        /// Constant ORM for LanguageCode
        /// </summary>
        public static readonly LanguageCode ORM = new LanguageCode("ORM");
        /// <summary>
        /// Constant OSS for LanguageCode
        /// </summary>
        public static readonly LanguageCode OSS = new LanguageCode("OSS");
        /// <summary>
        /// Constant PAN for LanguageCode
        /// </summary>
        public static readonly LanguageCode PAN = new LanguageCode("PAN");
        /// <summary>
        /// Constant PLI for LanguageCode
        /// </summary>
        public static readonly LanguageCode PLI = new LanguageCode("PLI");
        /// <summary>
        /// Constant POL for LanguageCode
        /// </summary>
        public static readonly LanguageCode POL = new LanguageCode("POL");
        /// <summary>
        /// Constant POR for LanguageCode
        /// </summary>
        public static readonly LanguageCode POR = new LanguageCode("POR");
        /// <summary>
        /// Constant PUS for LanguageCode
        /// </summary>
        public static readonly LanguageCode PUS = new LanguageCode("PUS");
        /// <summary>
        /// Constant QAA for LanguageCode
        /// </summary>
        public static readonly LanguageCode QAA = new LanguageCode("QAA");
        /// <summary>
        /// Constant QPC for LanguageCode
        /// </summary>
        public static readonly LanguageCode QPC = new LanguageCode("QPC");
        /// <summary>
        /// Constant QUE for LanguageCode
        /// </summary>
        public static readonly LanguageCode QUE = new LanguageCode("QUE");
        /// <summary>
        /// Constant ROH for LanguageCode
        /// </summary>
        public static readonly LanguageCode ROH = new LanguageCode("ROH");
        /// <summary>
        /// Constant RON for LanguageCode
        /// </summary>
        public static readonly LanguageCode RON = new LanguageCode("RON");
        /// <summary>
        /// Constant RUN for LanguageCode
        /// </summary>
        public static readonly LanguageCode RUN = new LanguageCode("RUN");
        /// <summary>
        /// Constant RUS for LanguageCode
        /// </summary>
        public static readonly LanguageCode RUS = new LanguageCode("RUS");
        /// <summary>
        /// Constant SAG for LanguageCode
        /// </summary>
        public static readonly LanguageCode SAG = new LanguageCode("SAG");
        /// <summary>
        /// Constant SAN for LanguageCode
        /// </summary>
        public static readonly LanguageCode SAN = new LanguageCode("SAN");
        /// <summary>
        /// Constant SIN for LanguageCode
        /// </summary>
        public static readonly LanguageCode SIN = new LanguageCode("SIN");
        /// <summary>
        /// Constant SLK for LanguageCode
        /// </summary>
        public static readonly LanguageCode SLK = new LanguageCode("SLK");
        /// <summary>
        /// Constant SLV for LanguageCode
        /// </summary>
        public static readonly LanguageCode SLV = new LanguageCode("SLV");
        /// <summary>
        /// Constant SME for LanguageCode
        /// </summary>
        public static readonly LanguageCode SME = new LanguageCode("SME");
        /// <summary>
        /// Constant SMO for LanguageCode
        /// </summary>
        public static readonly LanguageCode SMO = new LanguageCode("SMO");
        /// <summary>
        /// Constant SNA for LanguageCode
        /// </summary>
        public static readonly LanguageCode SNA = new LanguageCode("SNA");
        /// <summary>
        /// Constant SND for LanguageCode
        /// </summary>
        public static readonly LanguageCode SND = new LanguageCode("SND");
        /// <summary>
        /// Constant SOM for LanguageCode
        /// </summary>
        public static readonly LanguageCode SOM = new LanguageCode("SOM");
        /// <summary>
        /// Constant SOT for LanguageCode
        /// </summary>
        public static readonly LanguageCode SOT = new LanguageCode("SOT");
        /// <summary>
        /// Constant SPA for LanguageCode
        /// </summary>
        public static readonly LanguageCode SPA = new LanguageCode("SPA");
        /// <summary>
        /// Constant SQI for LanguageCode
        /// </summary>
        public static readonly LanguageCode SQI = new LanguageCode("SQI");
        /// <summary>
        /// Constant SRB for LanguageCode
        /// </summary>
        public static readonly LanguageCode SRB = new LanguageCode("SRB");
        /// <summary>
        /// Constant SRD for LanguageCode
        /// </summary>
        public static readonly LanguageCode SRD = new LanguageCode("SRD");
        /// <summary>
        /// Constant SSW for LanguageCode
        /// </summary>
        public static readonly LanguageCode SSW = new LanguageCode("SSW");
        /// <summary>
        /// Constant SUN for LanguageCode
        /// </summary>
        public static readonly LanguageCode SUN = new LanguageCode("SUN");
        /// <summary>
        /// Constant SWA for LanguageCode
        /// </summary>
        public static readonly LanguageCode SWA = new LanguageCode("SWA");
        /// <summary>
        /// Constant SWE for LanguageCode
        /// </summary>
        public static readonly LanguageCode SWE = new LanguageCode("SWE");
        /// <summary>
        /// Constant TAH for LanguageCode
        /// </summary>
        public static readonly LanguageCode TAH = new LanguageCode("TAH");
        /// <summary>
        /// Constant TAM for LanguageCode
        /// </summary>
        public static readonly LanguageCode TAM = new LanguageCode("TAM");
        /// <summary>
        /// Constant TAT for LanguageCode
        /// </summary>
        public static readonly LanguageCode TAT = new LanguageCode("TAT");
        /// <summary>
        /// Constant TEL for LanguageCode
        /// </summary>
        public static readonly LanguageCode TEL = new LanguageCode("TEL");
        /// <summary>
        /// Constant TGK for LanguageCode
        /// </summary>
        public static readonly LanguageCode TGK = new LanguageCode("TGK");
        /// <summary>
        /// Constant TGL for LanguageCode
        /// </summary>
        public static readonly LanguageCode TGL = new LanguageCode("TGL");
        /// <summary>
        /// Constant THA for LanguageCode
        /// </summary>
        public static readonly LanguageCode THA = new LanguageCode("THA");
        /// <summary>
        /// Constant TIR for LanguageCode
        /// </summary>
        public static readonly LanguageCode TIR = new LanguageCode("TIR");
        /// <summary>
        /// Constant TNG for LanguageCode
        /// </summary>
        public static readonly LanguageCode TNG = new LanguageCode("TNG");
        /// <summary>
        /// Constant TON for LanguageCode
        /// </summary>
        public static readonly LanguageCode TON = new LanguageCode("TON");
        /// <summary>
        /// Constant TSN for LanguageCode
        /// </summary>
        public static readonly LanguageCode TSN = new LanguageCode("TSN");
        /// <summary>
        /// Constant TSO for LanguageCode
        /// </summary>
        public static readonly LanguageCode TSO = new LanguageCode("TSO");
        /// <summary>
        /// Constant TUK for LanguageCode
        /// </summary>
        public static readonly LanguageCode TUK = new LanguageCode("TUK");
        /// <summary>
        /// Constant TUR for LanguageCode
        /// </summary>
        public static readonly LanguageCode TUR = new LanguageCode("TUR");
        /// <summary>
        /// Constant TWI for LanguageCode
        /// </summary>
        public static readonly LanguageCode TWI = new LanguageCode("TWI");
        /// <summary>
        /// Constant UIG for LanguageCode
        /// </summary>
        public static readonly LanguageCode UIG = new LanguageCode("UIG");
        /// <summary>
        /// Constant UKR for LanguageCode
        /// </summary>
        public static readonly LanguageCode UKR = new LanguageCode("UKR");
        /// <summary>
        /// Constant URD for LanguageCode
        /// </summary>
        public static readonly LanguageCode URD = new LanguageCode("URD");
        /// <summary>
        /// Constant UZB for LanguageCode
        /// </summary>
        public static readonly LanguageCode UZB = new LanguageCode("UZB");
        /// <summary>
        /// Constant VEN for LanguageCode
        /// </summary>
        public static readonly LanguageCode VEN = new LanguageCode("VEN");
        /// <summary>
        /// Constant VIE for LanguageCode
        /// </summary>
        public static readonly LanguageCode VIE = new LanguageCode("VIE");
        /// <summary>
        /// Constant VOL for LanguageCode
        /// </summary>
        public static readonly LanguageCode VOL = new LanguageCode("VOL");
        /// <summary>
        /// Constant WLN for LanguageCode
        /// </summary>
        public static readonly LanguageCode WLN = new LanguageCode("WLN");
        /// <summary>
        /// Constant WOL for LanguageCode
        /// </summary>
        public static readonly LanguageCode WOL = new LanguageCode("WOL");
        /// <summary>
        /// Constant XHO for LanguageCode
        /// </summary>
        public static readonly LanguageCode XHO = new LanguageCode("XHO");
        /// <summary>
        /// Constant YID for LanguageCode
        /// </summary>
        public static readonly LanguageCode YID = new LanguageCode("YID");
        /// <summary>
        /// Constant YOR for LanguageCode
        /// </summary>
        public static readonly LanguageCode YOR = new LanguageCode("YOR");
        /// <summary>
        /// Constant ZHA for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZHA = new LanguageCode("ZHA");
        /// <summary>
        /// Constant ZHO for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZHO = new LanguageCode("ZHO");
        /// <summary>
        /// Constant ZUL for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZUL = new LanguageCode("ZUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LanguageCode FindValue(string value)
        {
            return FindValue<LanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsAudioBufferModel.
    /// </summary>
    public class M2tsAudioBufferModel : ConstantClass
    {

        /// <summary>
        /// Constant ATSC for M2tsAudioBufferModel
        /// </summary>
        public static readonly M2tsAudioBufferModel ATSC = new M2tsAudioBufferModel("ATSC");
        /// <summary>
        /// Constant DVB for M2tsAudioBufferModel
        /// </summary>
        public static readonly M2tsAudioBufferModel DVB = new M2tsAudioBufferModel("DVB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsAudioBufferModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsAudioBufferModel FindValue(string value)
        {
            return FindValue<M2tsAudioBufferModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsAudioBufferModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsBufferModel.
    /// </summary>
    public class M2tsBufferModel : ConstantClass
    {

        /// <summary>
        /// Constant MULTIPLEX for M2tsBufferModel
        /// </summary>
        public static readonly M2tsBufferModel MULTIPLEX = new M2tsBufferModel("MULTIPLEX");
        /// <summary>
        /// Constant NONE for M2tsBufferModel
        /// </summary>
        public static readonly M2tsBufferModel NONE = new M2tsBufferModel("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsBufferModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsBufferModel FindValue(string value)
        {
            return FindValue<M2tsBufferModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsBufferModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsEbpAudioInterval.
    /// </summary>
    public class M2tsEbpAudioInterval : ConstantClass
    {

        /// <summary>
        /// Constant VIDEO_AND_FIXED_INTERVALS for M2tsEbpAudioInterval
        /// </summary>
        public static readonly M2tsEbpAudioInterval VIDEO_AND_FIXED_INTERVALS = new M2tsEbpAudioInterval("VIDEO_AND_FIXED_INTERVALS");
        /// <summary>
        /// Constant VIDEO_INTERVAL for M2tsEbpAudioInterval
        /// </summary>
        public static readonly M2tsEbpAudioInterval VIDEO_INTERVAL = new M2tsEbpAudioInterval("VIDEO_INTERVAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsEbpAudioInterval(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsEbpAudioInterval FindValue(string value)
        {
            return FindValue<M2tsEbpAudioInterval>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsEbpAudioInterval(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsEbpPlacement.
    /// </summary>
    public class M2tsEbpPlacement : ConstantClass
    {

        /// <summary>
        /// Constant VIDEO_AND_AUDIO_PIDS for M2tsEbpPlacement
        /// </summary>
        public static readonly M2tsEbpPlacement VIDEO_AND_AUDIO_PIDS = new M2tsEbpPlacement("VIDEO_AND_AUDIO_PIDS");
        /// <summary>
        /// Constant VIDEO_PID for M2tsEbpPlacement
        /// </summary>
        public static readonly M2tsEbpPlacement VIDEO_PID = new M2tsEbpPlacement("VIDEO_PID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsEbpPlacement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsEbpPlacement FindValue(string value)
        {
            return FindValue<M2tsEbpPlacement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsEbpPlacement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsEsRateInPes.
    /// </summary>
    public class M2tsEsRateInPes : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for M2tsEsRateInPes
        /// </summary>
        public static readonly M2tsEsRateInPes EXCLUDE = new M2tsEsRateInPes("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for M2tsEsRateInPes
        /// </summary>
        public static readonly M2tsEsRateInPes INCLUDE = new M2tsEsRateInPes("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsEsRateInPes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsEsRateInPes FindValue(string value)
        {
            return FindValue<M2tsEsRateInPes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsEsRateInPes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsNielsenId3.
    /// </summary>
    public class M2tsNielsenId3 : ConstantClass
    {

        /// <summary>
        /// Constant INSERT for M2tsNielsenId3
        /// </summary>
        public static readonly M2tsNielsenId3 INSERT = new M2tsNielsenId3("INSERT");
        /// <summary>
        /// Constant NONE for M2tsNielsenId3
        /// </summary>
        public static readonly M2tsNielsenId3 NONE = new M2tsNielsenId3("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsNielsenId3(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsNielsenId3 FindValue(string value)
        {
            return FindValue<M2tsNielsenId3>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsNielsenId3(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsPcrControl.
    /// </summary>
    public class M2tsPcrControl : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURED_PCR_PERIOD for M2tsPcrControl
        /// </summary>
        public static readonly M2tsPcrControl CONFIGURED_PCR_PERIOD = new M2tsPcrControl("CONFIGURED_PCR_PERIOD");
        /// <summary>
        /// Constant PCR_EVERY_PES_PACKET for M2tsPcrControl
        /// </summary>
        public static readonly M2tsPcrControl PCR_EVERY_PES_PACKET = new M2tsPcrControl("PCR_EVERY_PES_PACKET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsPcrControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsPcrControl FindValue(string value)
        {
            return FindValue<M2tsPcrControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsPcrControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsRateMode.
    /// </summary>
    public class M2tsRateMode : ConstantClass
    {

        /// <summary>
        /// Constant CBR for M2tsRateMode
        /// </summary>
        public static readonly M2tsRateMode CBR = new M2tsRateMode("CBR");
        /// <summary>
        /// Constant VBR for M2tsRateMode
        /// </summary>
        public static readonly M2tsRateMode VBR = new M2tsRateMode("VBR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsRateMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsRateMode FindValue(string value)
        {
            return FindValue<M2tsRateMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsRateMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsScte35Source.
    /// </summary>
    public class M2tsScte35Source : ConstantClass
    {

        /// <summary>
        /// Constant NONE for M2tsScte35Source
        /// </summary>
        public static readonly M2tsScte35Source NONE = new M2tsScte35Source("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for M2tsScte35Source
        /// </summary>
        public static readonly M2tsScte35Source PASSTHROUGH = new M2tsScte35Source("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsScte35Source(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsScte35Source FindValue(string value)
        {
            return FindValue<M2tsScte35Source>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsScte35Source(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsSegmentationMarkers.
    /// </summary>
    public class M2tsSegmentationMarkers : ConstantClass
    {

        /// <summary>
        /// Constant EBP for M2tsSegmentationMarkers
        /// </summary>
        public static readonly M2tsSegmentationMarkers EBP = new M2tsSegmentationMarkers("EBP");
        /// <summary>
        /// Constant EBP_LEGACY for M2tsSegmentationMarkers
        /// </summary>
        public static readonly M2tsSegmentationMarkers EBP_LEGACY = new M2tsSegmentationMarkers("EBP_LEGACY");
        /// <summary>
        /// Constant NONE for M2tsSegmentationMarkers
        /// </summary>
        public static readonly M2tsSegmentationMarkers NONE = new M2tsSegmentationMarkers("NONE");
        /// <summary>
        /// Constant PSI_SEGSTART for M2tsSegmentationMarkers
        /// </summary>
        public static readonly M2tsSegmentationMarkers PSI_SEGSTART = new M2tsSegmentationMarkers("PSI_SEGSTART");
        /// <summary>
        /// Constant RAI_ADAPT for M2tsSegmentationMarkers
        /// </summary>
        public static readonly M2tsSegmentationMarkers RAI_ADAPT = new M2tsSegmentationMarkers("RAI_ADAPT");
        /// <summary>
        /// Constant RAI_SEGSTART for M2tsSegmentationMarkers
        /// </summary>
        public static readonly M2tsSegmentationMarkers RAI_SEGSTART = new M2tsSegmentationMarkers("RAI_SEGSTART");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsSegmentationMarkers(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsSegmentationMarkers FindValue(string value)
        {
            return FindValue<M2tsSegmentationMarkers>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsSegmentationMarkers(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsSegmentationStyle.
    /// </summary>
    public class M2tsSegmentationStyle : ConstantClass
    {

        /// <summary>
        /// Constant MAINTAIN_CADENCE for M2tsSegmentationStyle
        /// </summary>
        public static readonly M2tsSegmentationStyle MAINTAIN_CADENCE = new M2tsSegmentationStyle("MAINTAIN_CADENCE");
        /// <summary>
        /// Constant RESET_CADENCE for M2tsSegmentationStyle
        /// </summary>
        public static readonly M2tsSegmentationStyle RESET_CADENCE = new M2tsSegmentationStyle("RESET_CADENCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsSegmentationStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsSegmentationStyle FindValue(string value)
        {
            return FindValue<M2tsSegmentationStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsSegmentationStyle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M3u8NielsenId3.
    /// </summary>
    public class M3u8NielsenId3 : ConstantClass
    {

        /// <summary>
        /// Constant INSERT for M3u8NielsenId3
        /// </summary>
        public static readonly M3u8NielsenId3 INSERT = new M3u8NielsenId3("INSERT");
        /// <summary>
        /// Constant NONE for M3u8NielsenId3
        /// </summary>
        public static readonly M3u8NielsenId3 NONE = new M3u8NielsenId3("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M3u8NielsenId3(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M3u8NielsenId3 FindValue(string value)
        {
            return FindValue<M3u8NielsenId3>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M3u8NielsenId3(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M3u8PcrControl.
    /// </summary>
    public class M3u8PcrControl : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURED_PCR_PERIOD for M3u8PcrControl
        /// </summary>
        public static readonly M3u8PcrControl CONFIGURED_PCR_PERIOD = new M3u8PcrControl("CONFIGURED_PCR_PERIOD");
        /// <summary>
        /// Constant PCR_EVERY_PES_PACKET for M3u8PcrControl
        /// </summary>
        public static readonly M3u8PcrControl PCR_EVERY_PES_PACKET = new M3u8PcrControl("PCR_EVERY_PES_PACKET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M3u8PcrControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M3u8PcrControl FindValue(string value)
        {
            return FindValue<M3u8PcrControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M3u8PcrControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M3u8Scte35Source.
    /// </summary>
    public class M3u8Scte35Source : ConstantClass
    {

        /// <summary>
        /// Constant NONE for M3u8Scte35Source
        /// </summary>
        public static readonly M3u8Scte35Source NONE = new M3u8Scte35Source("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for M3u8Scte35Source
        /// </summary>
        public static readonly M3u8Scte35Source PASSTHROUGH = new M3u8Scte35Source("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M3u8Scte35Source(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M3u8Scte35Source FindValue(string value)
        {
            return FindValue<M3u8Scte35Source>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M3u8Scte35Source(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MovClapAtom.
    /// </summary>
    public class MovClapAtom : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for MovClapAtom
        /// </summary>
        public static readonly MovClapAtom EXCLUDE = new MovClapAtom("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for MovClapAtom
        /// </summary>
        public static readonly MovClapAtom INCLUDE = new MovClapAtom("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MovClapAtom(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MovClapAtom FindValue(string value)
        {
            return FindValue<MovClapAtom>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MovClapAtom(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MovCslgAtom.
    /// </summary>
    public class MovCslgAtom : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for MovCslgAtom
        /// </summary>
        public static readonly MovCslgAtom EXCLUDE = new MovCslgAtom("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for MovCslgAtom
        /// </summary>
        public static readonly MovCslgAtom INCLUDE = new MovCslgAtom("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MovCslgAtom(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MovCslgAtom FindValue(string value)
        {
            return FindValue<MovCslgAtom>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MovCslgAtom(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MovMpeg2FourCCControl.
    /// </summary>
    public class MovMpeg2FourCCControl : ConstantClass
    {

        /// <summary>
        /// Constant MPEG for MovMpeg2FourCCControl
        /// </summary>
        public static readonly MovMpeg2FourCCControl MPEG = new MovMpeg2FourCCControl("MPEG");
        /// <summary>
        /// Constant XDCAM for MovMpeg2FourCCControl
        /// </summary>
        public static readonly MovMpeg2FourCCControl XDCAM = new MovMpeg2FourCCControl("XDCAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MovMpeg2FourCCControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MovMpeg2FourCCControl FindValue(string value)
        {
            return FindValue<MovMpeg2FourCCControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MovMpeg2FourCCControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MovPaddingControl.
    /// </summary>
    public class MovPaddingControl : ConstantClass
    {

        /// <summary>
        /// Constant NONE for MovPaddingControl
        /// </summary>
        public static readonly MovPaddingControl NONE = new MovPaddingControl("NONE");
        /// <summary>
        /// Constant OMNEON for MovPaddingControl
        /// </summary>
        public static readonly MovPaddingControl OMNEON = new MovPaddingControl("OMNEON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MovPaddingControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MovPaddingControl FindValue(string value)
        {
            return FindValue<MovPaddingControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MovPaddingControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MovReference.
    /// </summary>
    public class MovReference : ConstantClass
    {

        /// <summary>
        /// Constant EXTERNAL for MovReference
        /// </summary>
        public static readonly MovReference EXTERNAL = new MovReference("EXTERNAL");
        /// <summary>
        /// Constant SELF_CONTAINED for MovReference
        /// </summary>
        public static readonly MovReference SELF_CONTAINED = new MovReference("SELF_CONTAINED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MovReference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MovReference FindValue(string value)
        {
            return FindValue<MovReference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MovReference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mp4CslgAtom.
    /// </summary>
    public class Mp4CslgAtom : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for Mp4CslgAtom
        /// </summary>
        public static readonly Mp4CslgAtom EXCLUDE = new Mp4CslgAtom("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for Mp4CslgAtom
        /// </summary>
        public static readonly Mp4CslgAtom INCLUDE = new Mp4CslgAtom("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mp4CslgAtom(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mp4CslgAtom FindValue(string value)
        {
            return FindValue<Mp4CslgAtom>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mp4CslgAtom(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mp4FreeSpaceBox.
    /// </summary>
    public class Mp4FreeSpaceBox : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for Mp4FreeSpaceBox
        /// </summary>
        public static readonly Mp4FreeSpaceBox EXCLUDE = new Mp4FreeSpaceBox("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for Mp4FreeSpaceBox
        /// </summary>
        public static readonly Mp4FreeSpaceBox INCLUDE = new Mp4FreeSpaceBox("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mp4FreeSpaceBox(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mp4FreeSpaceBox FindValue(string value)
        {
            return FindValue<Mp4FreeSpaceBox>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mp4FreeSpaceBox(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mp4MoovPlacement.
    /// </summary>
    public class Mp4MoovPlacement : ConstantClass
    {

        /// <summary>
        /// Constant NORMAL for Mp4MoovPlacement
        /// </summary>
        public static readonly Mp4MoovPlacement NORMAL = new Mp4MoovPlacement("NORMAL");
        /// <summary>
        /// Constant PROGRESSIVE_DOWNLOAD for Mp4MoovPlacement
        /// </summary>
        public static readonly Mp4MoovPlacement PROGRESSIVE_DOWNLOAD = new Mp4MoovPlacement("PROGRESSIVE_DOWNLOAD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mp4MoovPlacement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mp4MoovPlacement FindValue(string value)
        {
            return FindValue<Mp4MoovPlacement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mp4MoovPlacement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2AdaptiveQuantization.
    /// </summary>
    public class Mpeg2AdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for Mpeg2AdaptiveQuantization
        /// </summary>
        public static readonly Mpeg2AdaptiveQuantization HIGH = new Mpeg2AdaptiveQuantization("HIGH");
        /// <summary>
        /// Constant LOW for Mpeg2AdaptiveQuantization
        /// </summary>
        public static readonly Mpeg2AdaptiveQuantization LOW = new Mpeg2AdaptiveQuantization("LOW");
        /// <summary>
        /// Constant MEDIUM for Mpeg2AdaptiveQuantization
        /// </summary>
        public static readonly Mpeg2AdaptiveQuantization MEDIUM = new Mpeg2AdaptiveQuantization("MEDIUM");
        /// <summary>
        /// Constant OFF for Mpeg2AdaptiveQuantization
        /// </summary>
        public static readonly Mpeg2AdaptiveQuantization OFF = new Mpeg2AdaptiveQuantization("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2AdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2AdaptiveQuantization FindValue(string value)
        {
            return FindValue<Mpeg2AdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2AdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2CodecLevel.
    /// </summary>
    public class Mpeg2CodecLevel : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for Mpeg2CodecLevel
        /// </summary>
        public static readonly Mpeg2CodecLevel AUTO = new Mpeg2CodecLevel("AUTO");
        /// <summary>
        /// Constant HIGH for Mpeg2CodecLevel
        /// </summary>
        public static readonly Mpeg2CodecLevel HIGH = new Mpeg2CodecLevel("HIGH");
        /// <summary>
        /// Constant HIGH1440 for Mpeg2CodecLevel
        /// </summary>
        public static readonly Mpeg2CodecLevel HIGH1440 = new Mpeg2CodecLevel("HIGH1440");
        /// <summary>
        /// Constant LOW for Mpeg2CodecLevel
        /// </summary>
        public static readonly Mpeg2CodecLevel LOW = new Mpeg2CodecLevel("LOW");
        /// <summary>
        /// Constant MAIN for Mpeg2CodecLevel
        /// </summary>
        public static readonly Mpeg2CodecLevel MAIN = new Mpeg2CodecLevel("MAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2CodecLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2CodecLevel FindValue(string value)
        {
            return FindValue<Mpeg2CodecLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2CodecLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2CodecProfile.
    /// </summary>
    public class Mpeg2CodecProfile : ConstantClass
    {

        /// <summary>
        /// Constant MAIN for Mpeg2CodecProfile
        /// </summary>
        public static readonly Mpeg2CodecProfile MAIN = new Mpeg2CodecProfile("MAIN");
        /// <summary>
        /// Constant PROFILE_422 for Mpeg2CodecProfile
        /// </summary>
        public static readonly Mpeg2CodecProfile PROFILE_422 = new Mpeg2CodecProfile("PROFILE_422");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2CodecProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2CodecProfile FindValue(string value)
        {
            return FindValue<Mpeg2CodecProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2CodecProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2FramerateControl.
    /// </summary>
    public class Mpeg2FramerateControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for Mpeg2FramerateControl
        /// </summary>
        public static readonly Mpeg2FramerateControl INITIALIZE_FROM_SOURCE = new Mpeg2FramerateControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for Mpeg2FramerateControl
        /// </summary>
        public static readonly Mpeg2FramerateControl SPECIFIED = new Mpeg2FramerateControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2FramerateControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2FramerateControl FindValue(string value)
        {
            return FindValue<Mpeg2FramerateControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2FramerateControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2FramerateConversionAlgorithm.
    /// </summary>
    public class Mpeg2FramerateConversionAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_DROP for Mpeg2FramerateConversionAlgorithm
        /// </summary>
        public static readonly Mpeg2FramerateConversionAlgorithm DUPLICATE_DROP = new Mpeg2FramerateConversionAlgorithm("DUPLICATE_DROP");
        /// <summary>
        /// Constant INTERPOLATE for Mpeg2FramerateConversionAlgorithm
        /// </summary>
        public static readonly Mpeg2FramerateConversionAlgorithm INTERPOLATE = new Mpeg2FramerateConversionAlgorithm("INTERPOLATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2FramerateConversionAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2FramerateConversionAlgorithm FindValue(string value)
        {
            return FindValue<Mpeg2FramerateConversionAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2FramerateConversionAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2GopSizeUnits.
    /// </summary>
    public class Mpeg2GopSizeUnits : ConstantClass
    {

        /// <summary>
        /// Constant FRAMES for Mpeg2GopSizeUnits
        /// </summary>
        public static readonly Mpeg2GopSizeUnits FRAMES = new Mpeg2GopSizeUnits("FRAMES");
        /// <summary>
        /// Constant SECONDS for Mpeg2GopSizeUnits
        /// </summary>
        public static readonly Mpeg2GopSizeUnits SECONDS = new Mpeg2GopSizeUnits("SECONDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2GopSizeUnits(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2GopSizeUnits FindValue(string value)
        {
            return FindValue<Mpeg2GopSizeUnits>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2GopSizeUnits(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2InterlaceMode.
    /// </summary>
    public class Mpeg2InterlaceMode : ConstantClass
    {

        /// <summary>
        /// Constant BOTTOM_FIELD for Mpeg2InterlaceMode
        /// </summary>
        public static readonly Mpeg2InterlaceMode BOTTOM_FIELD = new Mpeg2InterlaceMode("BOTTOM_FIELD");
        /// <summary>
        /// Constant FOLLOW_BOTTOM_FIELD for Mpeg2InterlaceMode
        /// </summary>
        public static readonly Mpeg2InterlaceMode FOLLOW_BOTTOM_FIELD = new Mpeg2InterlaceMode("FOLLOW_BOTTOM_FIELD");
        /// <summary>
        /// Constant FOLLOW_TOP_FIELD for Mpeg2InterlaceMode
        /// </summary>
        public static readonly Mpeg2InterlaceMode FOLLOW_TOP_FIELD = new Mpeg2InterlaceMode("FOLLOW_TOP_FIELD");
        /// <summary>
        /// Constant PROGRESSIVE for Mpeg2InterlaceMode
        /// </summary>
        public static readonly Mpeg2InterlaceMode PROGRESSIVE = new Mpeg2InterlaceMode("PROGRESSIVE");
        /// <summary>
        /// Constant TOP_FIELD for Mpeg2InterlaceMode
        /// </summary>
        public static readonly Mpeg2InterlaceMode TOP_FIELD = new Mpeg2InterlaceMode("TOP_FIELD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2InterlaceMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2InterlaceMode FindValue(string value)
        {
            return FindValue<Mpeg2InterlaceMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2InterlaceMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2IntraDcPrecision.
    /// </summary>
    public class Mpeg2IntraDcPrecision : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for Mpeg2IntraDcPrecision
        /// </summary>
        public static readonly Mpeg2IntraDcPrecision AUTO = new Mpeg2IntraDcPrecision("AUTO");
        /// <summary>
        /// Constant INTRA_DC_PRECISION_10 for Mpeg2IntraDcPrecision
        /// </summary>
        public static readonly Mpeg2IntraDcPrecision INTRA_DC_PRECISION_10 = new Mpeg2IntraDcPrecision("INTRA_DC_PRECISION_10");
        /// <summary>
        /// Constant INTRA_DC_PRECISION_11 for Mpeg2IntraDcPrecision
        /// </summary>
        public static readonly Mpeg2IntraDcPrecision INTRA_DC_PRECISION_11 = new Mpeg2IntraDcPrecision("INTRA_DC_PRECISION_11");
        /// <summary>
        /// Constant INTRA_DC_PRECISION_8 for Mpeg2IntraDcPrecision
        /// </summary>
        public static readonly Mpeg2IntraDcPrecision INTRA_DC_PRECISION_8 = new Mpeg2IntraDcPrecision("INTRA_DC_PRECISION_8");
        /// <summary>
        /// Constant INTRA_DC_PRECISION_9 for Mpeg2IntraDcPrecision
        /// </summary>
        public static readonly Mpeg2IntraDcPrecision INTRA_DC_PRECISION_9 = new Mpeg2IntraDcPrecision("INTRA_DC_PRECISION_9");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2IntraDcPrecision(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2IntraDcPrecision FindValue(string value)
        {
            return FindValue<Mpeg2IntraDcPrecision>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2IntraDcPrecision(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2ParControl.
    /// </summary>
    public class Mpeg2ParControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for Mpeg2ParControl
        /// </summary>
        public static readonly Mpeg2ParControl INITIALIZE_FROM_SOURCE = new Mpeg2ParControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for Mpeg2ParControl
        /// </summary>
        public static readonly Mpeg2ParControl SPECIFIED = new Mpeg2ParControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2ParControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2ParControl FindValue(string value)
        {
            return FindValue<Mpeg2ParControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2ParControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2QualityTuningLevel.
    /// </summary>
    public class Mpeg2QualityTuningLevel : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_PASS for Mpeg2QualityTuningLevel
        /// </summary>
        public static readonly Mpeg2QualityTuningLevel MULTI_PASS = new Mpeg2QualityTuningLevel("MULTI_PASS");
        /// <summary>
        /// Constant SINGLE_PASS for Mpeg2QualityTuningLevel
        /// </summary>
        public static readonly Mpeg2QualityTuningLevel SINGLE_PASS = new Mpeg2QualityTuningLevel("SINGLE_PASS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2QualityTuningLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2QualityTuningLevel FindValue(string value)
        {
            return FindValue<Mpeg2QualityTuningLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2QualityTuningLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2RateControlMode.
    /// </summary>
    public class Mpeg2RateControlMode : ConstantClass
    {

        /// <summary>
        /// Constant CBR for Mpeg2RateControlMode
        /// </summary>
        public static readonly Mpeg2RateControlMode CBR = new Mpeg2RateControlMode("CBR");
        /// <summary>
        /// Constant VBR for Mpeg2RateControlMode
        /// </summary>
        public static readonly Mpeg2RateControlMode VBR = new Mpeg2RateControlMode("VBR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2RateControlMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2RateControlMode FindValue(string value)
        {
            return FindValue<Mpeg2RateControlMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2RateControlMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2SceneChangeDetect.
    /// </summary>
    public class Mpeg2SceneChangeDetect : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Mpeg2SceneChangeDetect
        /// </summary>
        public static readonly Mpeg2SceneChangeDetect DISABLED = new Mpeg2SceneChangeDetect("DISABLED");
        /// <summary>
        /// Constant ENABLED for Mpeg2SceneChangeDetect
        /// </summary>
        public static readonly Mpeg2SceneChangeDetect ENABLED = new Mpeg2SceneChangeDetect("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2SceneChangeDetect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2SceneChangeDetect FindValue(string value)
        {
            return FindValue<Mpeg2SceneChangeDetect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2SceneChangeDetect(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2SlowPal.
    /// </summary>
    public class Mpeg2SlowPal : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Mpeg2SlowPal
        /// </summary>
        public static readonly Mpeg2SlowPal DISABLED = new Mpeg2SlowPal("DISABLED");
        /// <summary>
        /// Constant ENABLED for Mpeg2SlowPal
        /// </summary>
        public static readonly Mpeg2SlowPal ENABLED = new Mpeg2SlowPal("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2SlowPal(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2SlowPal FindValue(string value)
        {
            return FindValue<Mpeg2SlowPal>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2SlowPal(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2SpatialAdaptiveQuantization.
    /// </summary>
    public class Mpeg2SpatialAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Mpeg2SpatialAdaptiveQuantization
        /// </summary>
        public static readonly Mpeg2SpatialAdaptiveQuantization DISABLED = new Mpeg2SpatialAdaptiveQuantization("DISABLED");
        /// <summary>
        /// Constant ENABLED for Mpeg2SpatialAdaptiveQuantization
        /// </summary>
        public static readonly Mpeg2SpatialAdaptiveQuantization ENABLED = new Mpeg2SpatialAdaptiveQuantization("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2SpatialAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2SpatialAdaptiveQuantization FindValue(string value)
        {
            return FindValue<Mpeg2SpatialAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2SpatialAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2Syntax.
    /// </summary>
    public class Mpeg2Syntax : ConstantClass
    {

        /// <summary>
        /// Constant D_10 for Mpeg2Syntax
        /// </summary>
        public static readonly Mpeg2Syntax D_10 = new Mpeg2Syntax("D_10");
        /// <summary>
        /// Constant DEFAULT for Mpeg2Syntax
        /// </summary>
        public static readonly Mpeg2Syntax DEFAULT = new Mpeg2Syntax("DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2Syntax(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2Syntax FindValue(string value)
        {
            return FindValue<Mpeg2Syntax>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2Syntax(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2Telecine.
    /// </summary>
    public class Mpeg2Telecine : ConstantClass
    {

        /// <summary>
        /// Constant HARD for Mpeg2Telecine
        /// </summary>
        public static readonly Mpeg2Telecine HARD = new Mpeg2Telecine("HARD");
        /// <summary>
        /// Constant NONE for Mpeg2Telecine
        /// </summary>
        public static readonly Mpeg2Telecine NONE = new Mpeg2Telecine("NONE");
        /// <summary>
        /// Constant SOFT for Mpeg2Telecine
        /// </summary>
        public static readonly Mpeg2Telecine SOFT = new Mpeg2Telecine("SOFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2Telecine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2Telecine FindValue(string value)
        {
            return FindValue<Mpeg2Telecine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2Telecine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2TemporalAdaptiveQuantization.
    /// </summary>
    public class Mpeg2TemporalAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Mpeg2TemporalAdaptiveQuantization
        /// </summary>
        public static readonly Mpeg2TemporalAdaptiveQuantization DISABLED = new Mpeg2TemporalAdaptiveQuantization("DISABLED");
        /// <summary>
        /// Constant ENABLED for Mpeg2TemporalAdaptiveQuantization
        /// </summary>
        public static readonly Mpeg2TemporalAdaptiveQuantization ENABLED = new Mpeg2TemporalAdaptiveQuantization("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2TemporalAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2TemporalAdaptiveQuantization FindValue(string value)
        {
            return FindValue<Mpeg2TemporalAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2TemporalAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MsSmoothAudioDeduplication.
    /// </summary>
    public class MsSmoothAudioDeduplication : ConstantClass
    {

        /// <summary>
        /// Constant COMBINE_DUPLICATE_STREAMS for MsSmoothAudioDeduplication
        /// </summary>
        public static readonly MsSmoothAudioDeduplication COMBINE_DUPLICATE_STREAMS = new MsSmoothAudioDeduplication("COMBINE_DUPLICATE_STREAMS");
        /// <summary>
        /// Constant NONE for MsSmoothAudioDeduplication
        /// </summary>
        public static readonly MsSmoothAudioDeduplication NONE = new MsSmoothAudioDeduplication("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MsSmoothAudioDeduplication(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MsSmoothAudioDeduplication FindValue(string value)
        {
            return FindValue<MsSmoothAudioDeduplication>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MsSmoothAudioDeduplication(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MsSmoothManifestEncoding.
    /// </summary>
    public class MsSmoothManifestEncoding : ConstantClass
    {

        /// <summary>
        /// Constant UTF16 for MsSmoothManifestEncoding
        /// </summary>
        public static readonly MsSmoothManifestEncoding UTF16 = new MsSmoothManifestEncoding("UTF16");
        /// <summary>
        /// Constant UTF8 for MsSmoothManifestEncoding
        /// </summary>
        public static readonly MsSmoothManifestEncoding UTF8 = new MsSmoothManifestEncoding("UTF8");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MsSmoothManifestEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MsSmoothManifestEncoding FindValue(string value)
        {
            return FindValue<MsSmoothManifestEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MsSmoothManifestEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NoiseReducerFilter.
    /// </summary>
    public class NoiseReducerFilter : ConstantClass
    {

        /// <summary>
        /// Constant BILATERAL for NoiseReducerFilter
        /// </summary>
        public static readonly NoiseReducerFilter BILATERAL = new NoiseReducerFilter("BILATERAL");
        /// <summary>
        /// Constant CONSERVE for NoiseReducerFilter
        /// </summary>
        public static readonly NoiseReducerFilter CONSERVE = new NoiseReducerFilter("CONSERVE");
        /// <summary>
        /// Constant GAUSSIAN for NoiseReducerFilter
        /// </summary>
        public static readonly NoiseReducerFilter GAUSSIAN = new NoiseReducerFilter("GAUSSIAN");
        /// <summary>
        /// Constant LANCZOS for NoiseReducerFilter
        /// </summary>
        public static readonly NoiseReducerFilter LANCZOS = new NoiseReducerFilter("LANCZOS");
        /// <summary>
        /// Constant MEAN for NoiseReducerFilter
        /// </summary>
        public static readonly NoiseReducerFilter MEAN = new NoiseReducerFilter("MEAN");
        /// <summary>
        /// Constant SHARPEN for NoiseReducerFilter
        /// </summary>
        public static readonly NoiseReducerFilter SHARPEN = new NoiseReducerFilter("SHARPEN");
        /// <summary>
        /// Constant SPATIAL for NoiseReducerFilter
        /// </summary>
        public static readonly NoiseReducerFilter SPATIAL = new NoiseReducerFilter("SPATIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NoiseReducerFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NoiseReducerFilter FindValue(string value)
        {
            return FindValue<NoiseReducerFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NoiseReducerFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Order.
    /// </summary>
    public class Order : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for Order
        /// </summary>
        public static readonly Order ASCENDING = new Order("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for Order
        /// </summary>
        public static readonly Order DESCENDING = new Order("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Order(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Order FindValue(string value)
        {
            return FindValue<Order>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Order(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputGroupType.
    /// </summary>
    public class OutputGroupType : ConstantClass
    {

        /// <summary>
        /// Constant CMAF_GROUP_SETTINGS for OutputGroupType
        /// </summary>
        public static readonly OutputGroupType CMAF_GROUP_SETTINGS = new OutputGroupType("CMAF_GROUP_SETTINGS");
        /// <summary>
        /// Constant DASH_ISO_GROUP_SETTINGS for OutputGroupType
        /// </summary>
        public static readonly OutputGroupType DASH_ISO_GROUP_SETTINGS = new OutputGroupType("DASH_ISO_GROUP_SETTINGS");
        /// <summary>
        /// Constant FILE_GROUP_SETTINGS for OutputGroupType
        /// </summary>
        public static readonly OutputGroupType FILE_GROUP_SETTINGS = new OutputGroupType("FILE_GROUP_SETTINGS");
        /// <summary>
        /// Constant HLS_GROUP_SETTINGS for OutputGroupType
        /// </summary>
        public static readonly OutputGroupType HLS_GROUP_SETTINGS = new OutputGroupType("HLS_GROUP_SETTINGS");
        /// <summary>
        /// Constant MS_SMOOTH_GROUP_SETTINGS for OutputGroupType
        /// </summary>
        public static readonly OutputGroupType MS_SMOOTH_GROUP_SETTINGS = new OutputGroupType("MS_SMOOTH_GROUP_SETTINGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputGroupType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputGroupType FindValue(string value)
        {
            return FindValue<OutputGroupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputGroupType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputSdt.
    /// </summary>
    public class OutputSdt : ConstantClass
    {

        /// <summary>
        /// Constant SDT_FOLLOW for OutputSdt
        /// </summary>
        public static readonly OutputSdt SDT_FOLLOW = new OutputSdt("SDT_FOLLOW");
        /// <summary>
        /// Constant SDT_FOLLOW_IF_PRESENT for OutputSdt
        /// </summary>
        public static readonly OutputSdt SDT_FOLLOW_IF_PRESENT = new OutputSdt("SDT_FOLLOW_IF_PRESENT");
        /// <summary>
        /// Constant SDT_MANUAL for OutputSdt
        /// </summary>
        public static readonly OutputSdt SDT_MANUAL = new OutputSdt("SDT_MANUAL");
        /// <summary>
        /// Constant SDT_NONE for OutputSdt
        /// </summary>
        public static readonly OutputSdt SDT_NONE = new OutputSdt("SDT_NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputSdt(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputSdt FindValue(string value)
        {
            return FindValue<OutputSdt>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputSdt(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PresetListBy.
    /// </summary>
    public class PresetListBy : ConstantClass
    {

        /// <summary>
        /// Constant CREATION_DATE for PresetListBy
        /// </summary>
        public static readonly PresetListBy CREATION_DATE = new PresetListBy("CREATION_DATE");
        /// <summary>
        /// Constant NAME for PresetListBy
        /// </summary>
        public static readonly PresetListBy NAME = new PresetListBy("NAME");
        /// <summary>
        /// Constant SYSTEM for PresetListBy
        /// </summary>
        public static readonly PresetListBy SYSTEM = new PresetListBy("SYSTEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PresetListBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PresetListBy FindValue(string value)
        {
            return FindValue<PresetListBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PresetListBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProresCodecProfile.
    /// </summary>
    public class ProresCodecProfile : ConstantClass
    {

        /// <summary>
        /// Constant APPLE_PRORES_422 for ProresCodecProfile
        /// </summary>
        public static readonly ProresCodecProfile APPLE_PRORES_422 = new ProresCodecProfile("APPLE_PRORES_422");
        /// <summary>
        /// Constant APPLE_PRORES_422_HQ for ProresCodecProfile
        /// </summary>
        public static readonly ProresCodecProfile APPLE_PRORES_422_HQ = new ProresCodecProfile("APPLE_PRORES_422_HQ");
        /// <summary>
        /// Constant APPLE_PRORES_422_LT for ProresCodecProfile
        /// </summary>
        public static readonly ProresCodecProfile APPLE_PRORES_422_LT = new ProresCodecProfile("APPLE_PRORES_422_LT");
        /// <summary>
        /// Constant APPLE_PRORES_422_PROXY for ProresCodecProfile
        /// </summary>
        public static readonly ProresCodecProfile APPLE_PRORES_422_PROXY = new ProresCodecProfile("APPLE_PRORES_422_PROXY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProresCodecProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProresCodecProfile FindValue(string value)
        {
            return FindValue<ProresCodecProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProresCodecProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProresFramerateControl.
    /// </summary>
    public class ProresFramerateControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for ProresFramerateControl
        /// </summary>
        public static readonly ProresFramerateControl INITIALIZE_FROM_SOURCE = new ProresFramerateControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for ProresFramerateControl
        /// </summary>
        public static readonly ProresFramerateControl SPECIFIED = new ProresFramerateControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProresFramerateControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProresFramerateControl FindValue(string value)
        {
            return FindValue<ProresFramerateControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProresFramerateControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProresFramerateConversionAlgorithm.
    /// </summary>
    public class ProresFramerateConversionAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_DROP for ProresFramerateConversionAlgorithm
        /// </summary>
        public static readonly ProresFramerateConversionAlgorithm DUPLICATE_DROP = new ProresFramerateConversionAlgorithm("DUPLICATE_DROP");
        /// <summary>
        /// Constant INTERPOLATE for ProresFramerateConversionAlgorithm
        /// </summary>
        public static readonly ProresFramerateConversionAlgorithm INTERPOLATE = new ProresFramerateConversionAlgorithm("INTERPOLATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProresFramerateConversionAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProresFramerateConversionAlgorithm FindValue(string value)
        {
            return FindValue<ProresFramerateConversionAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProresFramerateConversionAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProresInterlaceMode.
    /// </summary>
    public class ProresInterlaceMode : ConstantClass
    {

        /// <summary>
        /// Constant BOTTOM_FIELD for ProresInterlaceMode
        /// </summary>
        public static readonly ProresInterlaceMode BOTTOM_FIELD = new ProresInterlaceMode("BOTTOM_FIELD");
        /// <summary>
        /// Constant FOLLOW_BOTTOM_FIELD for ProresInterlaceMode
        /// </summary>
        public static readonly ProresInterlaceMode FOLLOW_BOTTOM_FIELD = new ProresInterlaceMode("FOLLOW_BOTTOM_FIELD");
        /// <summary>
        /// Constant FOLLOW_TOP_FIELD for ProresInterlaceMode
        /// </summary>
        public static readonly ProresInterlaceMode FOLLOW_TOP_FIELD = new ProresInterlaceMode("FOLLOW_TOP_FIELD");
        /// <summary>
        /// Constant PROGRESSIVE for ProresInterlaceMode
        /// </summary>
        public static readonly ProresInterlaceMode PROGRESSIVE = new ProresInterlaceMode("PROGRESSIVE");
        /// <summary>
        /// Constant TOP_FIELD for ProresInterlaceMode
        /// </summary>
        public static readonly ProresInterlaceMode TOP_FIELD = new ProresInterlaceMode("TOP_FIELD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProresInterlaceMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProresInterlaceMode FindValue(string value)
        {
            return FindValue<ProresInterlaceMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProresInterlaceMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProresParControl.
    /// </summary>
    public class ProresParControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for ProresParControl
        /// </summary>
        public static readonly ProresParControl INITIALIZE_FROM_SOURCE = new ProresParControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for ProresParControl
        /// </summary>
        public static readonly ProresParControl SPECIFIED = new ProresParControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProresParControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProresParControl FindValue(string value)
        {
            return FindValue<ProresParControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProresParControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProresSlowPal.
    /// </summary>
    public class ProresSlowPal : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ProresSlowPal
        /// </summary>
        public static readonly ProresSlowPal DISABLED = new ProresSlowPal("DISABLED");
        /// <summary>
        /// Constant ENABLED for ProresSlowPal
        /// </summary>
        public static readonly ProresSlowPal ENABLED = new ProresSlowPal("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProresSlowPal(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProresSlowPal FindValue(string value)
        {
            return FindValue<ProresSlowPal>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProresSlowPal(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProresTelecine.
    /// </summary>
    public class ProresTelecine : ConstantClass
    {

        /// <summary>
        /// Constant HARD for ProresTelecine
        /// </summary>
        public static readonly ProresTelecine HARD = new ProresTelecine("HARD");
        /// <summary>
        /// Constant NONE for ProresTelecine
        /// </summary>
        public static readonly ProresTelecine NONE = new ProresTelecine("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProresTelecine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProresTelecine FindValue(string value)
        {
            return FindValue<ProresTelecine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProresTelecine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueueListBy.
    /// </summary>
    public class QueueListBy : ConstantClass
    {

        /// <summary>
        /// Constant CREATION_DATE for QueueListBy
        /// </summary>
        public static readonly QueueListBy CREATION_DATE = new QueueListBy("CREATION_DATE");
        /// <summary>
        /// Constant NAME for QueueListBy
        /// </summary>
        public static readonly QueueListBy NAME = new QueueListBy("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueueListBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueueListBy FindValue(string value)
        {
            return FindValue<QueueListBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueueListBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueueStatus.
    /// </summary>
    public class QueueStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for QueueStatus
        /// </summary>
        public static readonly QueueStatus ACTIVE = new QueueStatus("ACTIVE");
        /// <summary>
        /// Constant PAUSED for QueueStatus
        /// </summary>
        public static readonly QueueStatus PAUSED = new QueueStatus("PAUSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueueStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueueStatus FindValue(string value)
        {
            return FindValue<QueueStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueueStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RespondToAfd.
    /// </summary>
    public class RespondToAfd : ConstantClass
    {

        /// <summary>
        /// Constant NONE for RespondToAfd
        /// </summary>
        public static readonly RespondToAfd NONE = new RespondToAfd("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for RespondToAfd
        /// </summary>
        public static readonly RespondToAfd PASSTHROUGH = new RespondToAfd("PASSTHROUGH");
        /// <summary>
        /// Constant RESPOND for RespondToAfd
        /// </summary>
        public static readonly RespondToAfd RESPOND = new RespondToAfd("RESPOND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RespondToAfd(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RespondToAfd FindValue(string value)
        {
            return FindValue<RespondToAfd>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RespondToAfd(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingBehavior.
    /// </summary>
    public class ScalingBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for ScalingBehavior
        /// </summary>
        public static readonly ScalingBehavior DEFAULT = new ScalingBehavior("DEFAULT");
        /// <summary>
        /// Constant STRETCH_TO_OUTPUT for ScalingBehavior
        /// </summary>
        public static readonly ScalingBehavior STRETCH_TO_OUTPUT = new ScalingBehavior("STRETCH_TO_OUTPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingBehavior FindValue(string value)
        {
            return FindValue<ScalingBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SccDestinationFramerate.
    /// </summary>
    public class SccDestinationFramerate : ConstantClass
    {

        /// <summary>
        /// Constant FRAMERATE_23_97 for SccDestinationFramerate
        /// </summary>
        public static readonly SccDestinationFramerate FRAMERATE_23_97 = new SccDestinationFramerate("FRAMERATE_23_97");
        /// <summary>
        /// Constant FRAMERATE_24 for SccDestinationFramerate
        /// </summary>
        public static readonly SccDestinationFramerate FRAMERATE_24 = new SccDestinationFramerate("FRAMERATE_24");
        /// <summary>
        /// Constant FRAMERATE_29_97_DROPFRAME for SccDestinationFramerate
        /// </summary>
        public static readonly SccDestinationFramerate FRAMERATE_29_97_DROPFRAME = new SccDestinationFramerate("FRAMERATE_29_97_DROPFRAME");
        /// <summary>
        /// Constant FRAMERATE_29_97_NON_DROPFRAME for SccDestinationFramerate
        /// </summary>
        public static readonly SccDestinationFramerate FRAMERATE_29_97_NON_DROPFRAME = new SccDestinationFramerate("FRAMERATE_29_97_NON_DROPFRAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SccDestinationFramerate(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SccDestinationFramerate FindValue(string value)
        {
            return FindValue<SccDestinationFramerate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SccDestinationFramerate(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimecodeBurninPosition.
    /// </summary>
    public class TimecodeBurninPosition : ConstantClass
    {

        /// <summary>
        /// Constant BOTTOM_CENTER for TimecodeBurninPosition
        /// </summary>
        public static readonly TimecodeBurninPosition BOTTOM_CENTER = new TimecodeBurninPosition("BOTTOM_CENTER");
        /// <summary>
        /// Constant BOTTOM_LEFT for TimecodeBurninPosition
        /// </summary>
        public static readonly TimecodeBurninPosition BOTTOM_LEFT = new TimecodeBurninPosition("BOTTOM_LEFT");
        /// <summary>
        /// Constant BOTTOM_RIGHT for TimecodeBurninPosition
        /// </summary>
        public static readonly TimecodeBurninPosition BOTTOM_RIGHT = new TimecodeBurninPosition("BOTTOM_RIGHT");
        /// <summary>
        /// Constant MIDDLE_CENTER for TimecodeBurninPosition
        /// </summary>
        public static readonly TimecodeBurninPosition MIDDLE_CENTER = new TimecodeBurninPosition("MIDDLE_CENTER");
        /// <summary>
        /// Constant MIDDLE_LEFT for TimecodeBurninPosition
        /// </summary>
        public static readonly TimecodeBurninPosition MIDDLE_LEFT = new TimecodeBurninPosition("MIDDLE_LEFT");
        /// <summary>
        /// Constant MIDDLE_RIGHT for TimecodeBurninPosition
        /// </summary>
        public static readonly TimecodeBurninPosition MIDDLE_RIGHT = new TimecodeBurninPosition("MIDDLE_RIGHT");
        /// <summary>
        /// Constant TOP_CENTER for TimecodeBurninPosition
        /// </summary>
        public static readonly TimecodeBurninPosition TOP_CENTER = new TimecodeBurninPosition("TOP_CENTER");
        /// <summary>
        /// Constant TOP_LEFT for TimecodeBurninPosition
        /// </summary>
        public static readonly TimecodeBurninPosition TOP_LEFT = new TimecodeBurninPosition("TOP_LEFT");
        /// <summary>
        /// Constant TOP_RIGHT for TimecodeBurninPosition
        /// </summary>
        public static readonly TimecodeBurninPosition TOP_RIGHT = new TimecodeBurninPosition("TOP_RIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimecodeBurninPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimecodeBurninPosition FindValue(string value)
        {
            return FindValue<TimecodeBurninPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimecodeBurninPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimecodeSource.
    /// </summary>
    public class TimecodeSource : ConstantClass
    {

        /// <summary>
        /// Constant EMBEDDED for TimecodeSource
        /// </summary>
        public static readonly TimecodeSource EMBEDDED = new TimecodeSource("EMBEDDED");
        /// <summary>
        /// Constant SPECIFIEDSTART for TimecodeSource
        /// </summary>
        public static readonly TimecodeSource SPECIFIEDSTART = new TimecodeSource("SPECIFIEDSTART");
        /// <summary>
        /// Constant ZEROBASED for TimecodeSource
        /// </summary>
        public static readonly TimecodeSource ZEROBASED = new TimecodeSource("ZEROBASED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimecodeSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimecodeSource FindValue(string value)
        {
            return FindValue<TimecodeSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimecodeSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimedMetadata.
    /// </summary>
    public class TimedMetadata : ConstantClass
    {

        /// <summary>
        /// Constant NONE for TimedMetadata
        /// </summary>
        public static readonly TimedMetadata NONE = new TimedMetadata("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for TimedMetadata
        /// </summary>
        public static readonly TimedMetadata PASSTHROUGH = new TimedMetadata("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimedMetadata(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimedMetadata FindValue(string value)
        {
            return FindValue<TimedMetadata>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimedMetadata(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TtmlStylePassthrough.
    /// </summary>
    public class TtmlStylePassthrough : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for TtmlStylePassthrough
        /// </summary>
        public static readonly TtmlStylePassthrough DISABLED = new TtmlStylePassthrough("DISABLED");
        /// <summary>
        /// Constant ENABLED for TtmlStylePassthrough
        /// </summary>
        public static readonly TtmlStylePassthrough ENABLED = new TtmlStylePassthrough("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TtmlStylePassthrough(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TtmlStylePassthrough FindValue(string value)
        {
            return FindValue<TtmlStylePassthrough>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TtmlStylePassthrough(string value)
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
        /// Constant CUSTOM for Type
        /// </summary>
        public static readonly Type CUSTOM = new Type("CUSTOM");
        /// <summary>
        /// Constant SYSTEM for Type
        /// </summary>
        public static readonly Type SYSTEM = new Type("SYSTEM");

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
    /// Constants used for properties of type VideoCodec.
    /// </summary>
    public class VideoCodec : ConstantClass
    {

        /// <summary>
        /// Constant FRAME_CAPTURE for VideoCodec
        /// </summary>
        public static readonly VideoCodec FRAME_CAPTURE = new VideoCodec("FRAME_CAPTURE");
        /// <summary>
        /// Constant H_264 for VideoCodec
        /// </summary>
        public static readonly VideoCodec H_264 = new VideoCodec("H_264");
        /// <summary>
        /// Constant H_265 for VideoCodec
        /// </summary>
        public static readonly VideoCodec H_265 = new VideoCodec("H_265");
        /// <summary>
        /// Constant MPEG2 for VideoCodec
        /// </summary>
        public static readonly VideoCodec MPEG2 = new VideoCodec("MPEG2");
        /// <summary>
        /// Constant PRORES for VideoCodec
        /// </summary>
        public static readonly VideoCodec PRORES = new VideoCodec("PRORES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoCodec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoCodec FindValue(string value)
        {
            return FindValue<VideoCodec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoCodec(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoTimecodeInsertion.
    /// </summary>
    public class VideoTimecodeInsertion : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for VideoTimecodeInsertion
        /// </summary>
        public static readonly VideoTimecodeInsertion DISABLED = new VideoTimecodeInsertion("DISABLED");
        /// <summary>
        /// Constant PIC_TIMING_SEI for VideoTimecodeInsertion
        /// </summary>
        public static readonly VideoTimecodeInsertion PIC_TIMING_SEI = new VideoTimecodeInsertion("PIC_TIMING_SEI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoTimecodeInsertion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoTimecodeInsertion FindValue(string value)
        {
            return FindValue<VideoTimecodeInsertion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoTimecodeInsertion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WavFormat.
    /// </summary>
    public class WavFormat : ConstantClass
    {

        /// <summary>
        /// Constant RF64 for WavFormat
        /// </summary>
        public static readonly WavFormat RF64 = new WavFormat("RF64");
        /// <summary>
        /// Constant RIFF for WavFormat
        /// </summary>
        public static readonly WavFormat RIFF = new WavFormat("RIFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WavFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WavFormat FindValue(string value)
        {
            return FindValue<WavFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WavFormat(string value)
        {
            return FindValue(value);
        }
    }

}