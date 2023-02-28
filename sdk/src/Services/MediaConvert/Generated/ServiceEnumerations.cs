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
    /// Constants used for properties of type Ac3DynamicRangeCompressionLine.
    /// </summary>
    public class Ac3DynamicRangeCompressionLine : ConstantClass
    {

        /// <summary>
        /// Constant FILM_LIGHT for Ac3DynamicRangeCompressionLine
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionLine FILM_LIGHT = new Ac3DynamicRangeCompressionLine("FILM_LIGHT");
        /// <summary>
        /// Constant FILM_STANDARD for Ac3DynamicRangeCompressionLine
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionLine FILM_STANDARD = new Ac3DynamicRangeCompressionLine("FILM_STANDARD");
        /// <summary>
        /// Constant MUSIC_LIGHT for Ac3DynamicRangeCompressionLine
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionLine MUSIC_LIGHT = new Ac3DynamicRangeCompressionLine("MUSIC_LIGHT");
        /// <summary>
        /// Constant MUSIC_STANDARD for Ac3DynamicRangeCompressionLine
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionLine MUSIC_STANDARD = new Ac3DynamicRangeCompressionLine("MUSIC_STANDARD");
        /// <summary>
        /// Constant NONE for Ac3DynamicRangeCompressionLine
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionLine NONE = new Ac3DynamicRangeCompressionLine("NONE");
        /// <summary>
        /// Constant SPEECH for Ac3DynamicRangeCompressionLine
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionLine SPEECH = new Ac3DynamicRangeCompressionLine("SPEECH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ac3DynamicRangeCompressionLine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ac3DynamicRangeCompressionLine FindValue(string value)
        {
            return FindValue<Ac3DynamicRangeCompressionLine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ac3DynamicRangeCompressionLine(string value)
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
    /// Constants used for properties of type Ac3DynamicRangeCompressionRf.
    /// </summary>
    public class Ac3DynamicRangeCompressionRf : ConstantClass
    {

        /// <summary>
        /// Constant FILM_LIGHT for Ac3DynamicRangeCompressionRf
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionRf FILM_LIGHT = new Ac3DynamicRangeCompressionRf("FILM_LIGHT");
        /// <summary>
        /// Constant FILM_STANDARD for Ac3DynamicRangeCompressionRf
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionRf FILM_STANDARD = new Ac3DynamicRangeCompressionRf("FILM_STANDARD");
        /// <summary>
        /// Constant MUSIC_LIGHT for Ac3DynamicRangeCompressionRf
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionRf MUSIC_LIGHT = new Ac3DynamicRangeCompressionRf("MUSIC_LIGHT");
        /// <summary>
        /// Constant MUSIC_STANDARD for Ac3DynamicRangeCompressionRf
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionRf MUSIC_STANDARD = new Ac3DynamicRangeCompressionRf("MUSIC_STANDARD");
        /// <summary>
        /// Constant NONE for Ac3DynamicRangeCompressionRf
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionRf NONE = new Ac3DynamicRangeCompressionRf("NONE");
        /// <summary>
        /// Constant SPEECH for Ac3DynamicRangeCompressionRf
        /// </summary>
        public static readonly Ac3DynamicRangeCompressionRf SPEECH = new Ac3DynamicRangeCompressionRf("SPEECH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ac3DynamicRangeCompressionRf(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ac3DynamicRangeCompressionRf FindValue(string value)
        {
            return FindValue<Ac3DynamicRangeCompressionRf>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ac3DynamicRangeCompressionRf(string value)
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
    /// Constants used for properties of type AccelerationMode.
    /// </summary>
    public class AccelerationMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AccelerationMode
        /// </summary>
        public static readonly AccelerationMode DISABLED = new AccelerationMode("DISABLED");
        /// <summary>
        /// Constant ENABLED for AccelerationMode
        /// </summary>
        public static readonly AccelerationMode ENABLED = new AccelerationMode("ENABLED");
        /// <summary>
        /// Constant PREFERRED for AccelerationMode
        /// </summary>
        public static readonly AccelerationMode PREFERRED = new AccelerationMode("PREFERRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccelerationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccelerationMode FindValue(string value)
        {
            return FindValue<AccelerationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccelerationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccelerationStatus.
    /// </summary>
    public class AccelerationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCELERATED for AccelerationStatus
        /// </summary>
        public static readonly AccelerationStatus ACCELERATED = new AccelerationStatus("ACCELERATED");
        /// <summary>
        /// Constant IN_PROGRESS for AccelerationStatus
        /// </summary>
        public static readonly AccelerationStatus IN_PROGRESS = new AccelerationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_ACCELERATED for AccelerationStatus
        /// </summary>
        public static readonly AccelerationStatus NOT_ACCELERATED = new AccelerationStatus("NOT_ACCELERATED");
        /// <summary>
        /// Constant NOT_APPLICABLE for AccelerationStatus
        /// </summary>
        public static readonly AccelerationStatus NOT_APPLICABLE = new AccelerationStatus("NOT_APPLICABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccelerationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccelerationStatus FindValue(string value)
        {
            return FindValue<AccelerationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccelerationStatus(string value)
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
    /// Constants used for properties of type AlphaBehavior.
    /// </summary>
    public class AlphaBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DISCARD for AlphaBehavior
        /// </summary>
        public static readonly AlphaBehavior DISCARD = new AlphaBehavior("DISCARD");
        /// <summary>
        /// Constant REMAP_TO_LUMA for AlphaBehavior
        /// </summary>
        public static readonly AlphaBehavior REMAP_TO_LUMA = new AlphaBehavior("REMAP_TO_LUMA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlphaBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlphaBehavior FindValue(string value)
        {
            return FindValue<AlphaBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlphaBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AncillaryConvert608To708.
    /// </summary>
    public class AncillaryConvert608To708 : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AncillaryConvert608To708
        /// </summary>
        public static readonly AncillaryConvert608To708 DISABLED = new AncillaryConvert608To708("DISABLED");
        /// <summary>
        /// Constant UPCONVERT for AncillaryConvert608To708
        /// </summary>
        public static readonly AncillaryConvert608To708 UPCONVERT = new AncillaryConvert608To708("UPCONVERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AncillaryConvert608To708(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AncillaryConvert608To708 FindValue(string value)
        {
            return FindValue<AncillaryConvert608To708>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AncillaryConvert608To708(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AncillaryTerminateCaptions.
    /// </summary>
    public class AncillaryTerminateCaptions : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AncillaryTerminateCaptions
        /// </summary>
        public static readonly AncillaryTerminateCaptions DISABLED = new AncillaryTerminateCaptions("DISABLED");
        /// <summary>
        /// Constant END_OF_INPUT for AncillaryTerminateCaptions
        /// </summary>
        public static readonly AncillaryTerminateCaptions END_OF_INPUT = new AncillaryTerminateCaptions("END_OF_INPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AncillaryTerminateCaptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AncillaryTerminateCaptions FindValue(string value)
        {
            return FindValue<AncillaryTerminateCaptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AncillaryTerminateCaptions(string value)
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
    /// Constants used for properties of type AudioChannelTag.
    /// </summary>
    public class AudioChannelTag : ConstantClass
    {

        /// <summary>
        /// Constant C for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag C = new AudioChannelTag("C");
        /// <summary>
        /// Constant CS for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag CS = new AudioChannelTag("CS");
        /// <summary>
        /// Constant L for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag L = new AudioChannelTag("L");
        /// <summary>
        /// Constant LC for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag LC = new AudioChannelTag("LC");
        /// <summary>
        /// Constant LFE for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag LFE = new AudioChannelTag("LFE");
        /// <summary>
        /// Constant LS for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag LS = new AudioChannelTag("LS");
        /// <summary>
        /// Constant LSD for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag LSD = new AudioChannelTag("LSD");
        /// <summary>
        /// Constant R for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag R = new AudioChannelTag("R");
        /// <summary>
        /// Constant RC for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag RC = new AudioChannelTag("RC");
        /// <summary>
        /// Constant RS for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag RS = new AudioChannelTag("RS");
        /// <summary>
        /// Constant RSD for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag RSD = new AudioChannelTag("RSD");
        /// <summary>
        /// Constant TCS for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag TCS = new AudioChannelTag("TCS");
        /// <summary>
        /// Constant VHC for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag VHC = new AudioChannelTag("VHC");
        /// <summary>
        /// Constant VHL for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag VHL = new AudioChannelTag("VHL");
        /// <summary>
        /// Constant VHR for AudioChannelTag
        /// </summary>
        public static readonly AudioChannelTag VHR = new AudioChannelTag("VHR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioChannelTag(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioChannelTag FindValue(string value)
        {
            return FindValue<AudioChannelTag>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioChannelTag(string value)
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
        /// Constant EAC3_ATMOS for AudioCodec
        /// </summary>
        public static readonly AudioCodec EAC3_ATMOS = new AudioCodec("EAC3_ATMOS");
        /// <summary>
        /// Constant MP2 for AudioCodec
        /// </summary>
        public static readonly AudioCodec MP2 = new AudioCodec("MP2");
        /// <summary>
        /// Constant MP3 for AudioCodec
        /// </summary>
        public static readonly AudioCodec MP3 = new AudioCodec("MP3");
        /// <summary>
        /// Constant OPUS for AudioCodec
        /// </summary>
        public static readonly AudioCodec OPUS = new AudioCodec("OPUS");
        /// <summary>
        /// Constant PASSTHROUGH for AudioCodec
        /// </summary>
        public static readonly AudioCodec PASSTHROUGH = new AudioCodec("PASSTHROUGH");
        /// <summary>
        /// Constant VORBIS for AudioCodec
        /// </summary>
        public static readonly AudioCodec VORBIS = new AudioCodec("VORBIS");
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
    /// Constants used for properties of type AudioDurationCorrection.
    /// </summary>
    public class AudioDurationCorrection : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for AudioDurationCorrection
        /// </summary>
        public static readonly AudioDurationCorrection AUTO = new AudioDurationCorrection("AUTO");
        /// <summary>
        /// Constant DISABLED for AudioDurationCorrection
        /// </summary>
        public static readonly AudioDurationCorrection DISABLED = new AudioDurationCorrection("DISABLED");
        /// <summary>
        /// Constant FRAME for AudioDurationCorrection
        /// </summary>
        public static readonly AudioDurationCorrection FRAME = new AudioDurationCorrection("FRAME");
        /// <summary>
        /// Constant TRACK for AudioDurationCorrection
        /// </summary>
        public static readonly AudioDurationCorrection TRACK = new AudioDurationCorrection("TRACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioDurationCorrection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioDurationCorrection FindValue(string value)
        {
            return FindValue<AudioDurationCorrection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioDurationCorrection(string value)
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
        /// Constant ITU_BS_1770_3 for AudioNormalizationAlgorithm
        /// </summary>
        public static readonly AudioNormalizationAlgorithm ITU_BS_1770_3 = new AudioNormalizationAlgorithm("ITU_BS_1770_3");
        /// <summary>
        /// Constant ITU_BS_1770_4 for AudioNormalizationAlgorithm
        /// </summary>
        public static readonly AudioNormalizationAlgorithm ITU_BS_1770_4 = new AudioNormalizationAlgorithm("ITU_BS_1770_4");

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
        /// Constant HLS_RENDITION_GROUP for AudioSelectorType
        /// </summary>
        public static readonly AudioSelectorType HLS_RENDITION_GROUP = new AudioSelectorType("HLS_RENDITION_GROUP");
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
    /// Constants used for properties of type Av1AdaptiveQuantization.
    /// </summary>
    public class Av1AdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for Av1AdaptiveQuantization
        /// </summary>
        public static readonly Av1AdaptiveQuantization HIGH = new Av1AdaptiveQuantization("HIGH");
        /// <summary>
        /// Constant HIGHER for Av1AdaptiveQuantization
        /// </summary>
        public static readonly Av1AdaptiveQuantization HIGHER = new Av1AdaptiveQuantization("HIGHER");
        /// <summary>
        /// Constant LOW for Av1AdaptiveQuantization
        /// </summary>
        public static readonly Av1AdaptiveQuantization LOW = new Av1AdaptiveQuantization("LOW");
        /// <summary>
        /// Constant MAX for Av1AdaptiveQuantization
        /// </summary>
        public static readonly Av1AdaptiveQuantization MAX = new Av1AdaptiveQuantization("MAX");
        /// <summary>
        /// Constant MEDIUM for Av1AdaptiveQuantization
        /// </summary>
        public static readonly Av1AdaptiveQuantization MEDIUM = new Av1AdaptiveQuantization("MEDIUM");
        /// <summary>
        /// Constant OFF for Av1AdaptiveQuantization
        /// </summary>
        public static readonly Av1AdaptiveQuantization OFF = new Av1AdaptiveQuantization("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Av1AdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Av1AdaptiveQuantization FindValue(string value)
        {
            return FindValue<Av1AdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Av1AdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Av1BitDepth.
    /// </summary>
    public class Av1BitDepth : ConstantClass
    {

        /// <summary>
        /// Constant BIT_10 for Av1BitDepth
        /// </summary>
        public static readonly Av1BitDepth BIT_10 = new Av1BitDepth("BIT_10");
        /// <summary>
        /// Constant BIT_8 for Av1BitDepth
        /// </summary>
        public static readonly Av1BitDepth BIT_8 = new Av1BitDepth("BIT_8");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Av1BitDepth(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Av1BitDepth FindValue(string value)
        {
            return FindValue<Av1BitDepth>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Av1BitDepth(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Av1FramerateControl.
    /// </summary>
    public class Av1FramerateControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for Av1FramerateControl
        /// </summary>
        public static readonly Av1FramerateControl INITIALIZE_FROM_SOURCE = new Av1FramerateControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for Av1FramerateControl
        /// </summary>
        public static readonly Av1FramerateControl SPECIFIED = new Av1FramerateControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Av1FramerateControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Av1FramerateControl FindValue(string value)
        {
            return FindValue<Av1FramerateControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Av1FramerateControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Av1FramerateConversionAlgorithm.
    /// </summary>
    public class Av1FramerateConversionAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_DROP for Av1FramerateConversionAlgorithm
        /// </summary>
        public static readonly Av1FramerateConversionAlgorithm DUPLICATE_DROP = new Av1FramerateConversionAlgorithm("DUPLICATE_DROP");
        /// <summary>
        /// Constant FRAMEFORMER for Av1FramerateConversionAlgorithm
        /// </summary>
        public static readonly Av1FramerateConversionAlgorithm FRAMEFORMER = new Av1FramerateConversionAlgorithm("FRAMEFORMER");
        /// <summary>
        /// Constant INTERPOLATE for Av1FramerateConversionAlgorithm
        /// </summary>
        public static readonly Av1FramerateConversionAlgorithm INTERPOLATE = new Av1FramerateConversionAlgorithm("INTERPOLATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Av1FramerateConversionAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Av1FramerateConversionAlgorithm FindValue(string value)
        {
            return FindValue<Av1FramerateConversionAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Av1FramerateConversionAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Av1RateControlMode.
    /// </summary>
    public class Av1RateControlMode : ConstantClass
    {

        /// <summary>
        /// Constant QVBR for Av1RateControlMode
        /// </summary>
        public static readonly Av1RateControlMode QVBR = new Av1RateControlMode("QVBR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Av1RateControlMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Av1RateControlMode FindValue(string value)
        {
            return FindValue<Av1RateControlMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Av1RateControlMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Av1SpatialAdaptiveQuantization.
    /// </summary>
    public class Av1SpatialAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Av1SpatialAdaptiveQuantization
        /// </summary>
        public static readonly Av1SpatialAdaptiveQuantization DISABLED = new Av1SpatialAdaptiveQuantization("DISABLED");
        /// <summary>
        /// Constant ENABLED for Av1SpatialAdaptiveQuantization
        /// </summary>
        public static readonly Av1SpatialAdaptiveQuantization ENABLED = new Av1SpatialAdaptiveQuantization("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Av1SpatialAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Av1SpatialAdaptiveQuantization FindValue(string value)
        {
            return FindValue<Av1SpatialAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Av1SpatialAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvcIntraClass.
    /// </summary>
    public class AvcIntraClass : ConstantClass
    {

        /// <summary>
        /// Constant CLASS_100 for AvcIntraClass
        /// </summary>
        public static readonly AvcIntraClass CLASS_100 = new AvcIntraClass("CLASS_100");
        /// <summary>
        /// Constant CLASS_200 for AvcIntraClass
        /// </summary>
        public static readonly AvcIntraClass CLASS_200 = new AvcIntraClass("CLASS_200");
        /// <summary>
        /// Constant CLASS_4K_2K for AvcIntraClass
        /// </summary>
        public static readonly AvcIntraClass CLASS_4K_2K = new AvcIntraClass("CLASS_4K_2K");
        /// <summary>
        /// Constant CLASS_50 for AvcIntraClass
        /// </summary>
        public static readonly AvcIntraClass CLASS_50 = new AvcIntraClass("CLASS_50");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvcIntraClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvcIntraClass FindValue(string value)
        {
            return FindValue<AvcIntraClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvcIntraClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvcIntraFramerateControl.
    /// </summary>
    public class AvcIntraFramerateControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for AvcIntraFramerateControl
        /// </summary>
        public static readonly AvcIntraFramerateControl INITIALIZE_FROM_SOURCE = new AvcIntraFramerateControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for AvcIntraFramerateControl
        /// </summary>
        public static readonly AvcIntraFramerateControl SPECIFIED = new AvcIntraFramerateControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvcIntraFramerateControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvcIntraFramerateControl FindValue(string value)
        {
            return FindValue<AvcIntraFramerateControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvcIntraFramerateControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvcIntraFramerateConversionAlgorithm.
    /// </summary>
    public class AvcIntraFramerateConversionAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_DROP for AvcIntraFramerateConversionAlgorithm
        /// </summary>
        public static readonly AvcIntraFramerateConversionAlgorithm DUPLICATE_DROP = new AvcIntraFramerateConversionAlgorithm("DUPLICATE_DROP");
        /// <summary>
        /// Constant FRAMEFORMER for AvcIntraFramerateConversionAlgorithm
        /// </summary>
        public static readonly AvcIntraFramerateConversionAlgorithm FRAMEFORMER = new AvcIntraFramerateConversionAlgorithm("FRAMEFORMER");
        /// <summary>
        /// Constant INTERPOLATE for AvcIntraFramerateConversionAlgorithm
        /// </summary>
        public static readonly AvcIntraFramerateConversionAlgorithm INTERPOLATE = new AvcIntraFramerateConversionAlgorithm("INTERPOLATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvcIntraFramerateConversionAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvcIntraFramerateConversionAlgorithm FindValue(string value)
        {
            return FindValue<AvcIntraFramerateConversionAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvcIntraFramerateConversionAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvcIntraInterlaceMode.
    /// </summary>
    public class AvcIntraInterlaceMode : ConstantClass
    {

        /// <summary>
        /// Constant BOTTOM_FIELD for AvcIntraInterlaceMode
        /// </summary>
        public static readonly AvcIntraInterlaceMode BOTTOM_FIELD = new AvcIntraInterlaceMode("BOTTOM_FIELD");
        /// <summary>
        /// Constant FOLLOW_BOTTOM_FIELD for AvcIntraInterlaceMode
        /// </summary>
        public static readonly AvcIntraInterlaceMode FOLLOW_BOTTOM_FIELD = new AvcIntraInterlaceMode("FOLLOW_BOTTOM_FIELD");
        /// <summary>
        /// Constant FOLLOW_TOP_FIELD for AvcIntraInterlaceMode
        /// </summary>
        public static readonly AvcIntraInterlaceMode FOLLOW_TOP_FIELD = new AvcIntraInterlaceMode("FOLLOW_TOP_FIELD");
        /// <summary>
        /// Constant PROGRESSIVE for AvcIntraInterlaceMode
        /// </summary>
        public static readonly AvcIntraInterlaceMode PROGRESSIVE = new AvcIntraInterlaceMode("PROGRESSIVE");
        /// <summary>
        /// Constant TOP_FIELD for AvcIntraInterlaceMode
        /// </summary>
        public static readonly AvcIntraInterlaceMode TOP_FIELD = new AvcIntraInterlaceMode("TOP_FIELD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvcIntraInterlaceMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvcIntraInterlaceMode FindValue(string value)
        {
            return FindValue<AvcIntraInterlaceMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvcIntraInterlaceMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvcIntraScanTypeConversionMode.
    /// </summary>
    public class AvcIntraScanTypeConversionMode : ConstantClass
    {

        /// <summary>
        /// Constant INTERLACED for AvcIntraScanTypeConversionMode
        /// </summary>
        public static readonly AvcIntraScanTypeConversionMode INTERLACED = new AvcIntraScanTypeConversionMode("INTERLACED");
        /// <summary>
        /// Constant INTERLACED_OPTIMIZE for AvcIntraScanTypeConversionMode
        /// </summary>
        public static readonly AvcIntraScanTypeConversionMode INTERLACED_OPTIMIZE = new AvcIntraScanTypeConversionMode("INTERLACED_OPTIMIZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvcIntraScanTypeConversionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvcIntraScanTypeConversionMode FindValue(string value)
        {
            return FindValue<AvcIntraScanTypeConversionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvcIntraScanTypeConversionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvcIntraSlowPal.
    /// </summary>
    public class AvcIntraSlowPal : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AvcIntraSlowPal
        /// </summary>
        public static readonly AvcIntraSlowPal DISABLED = new AvcIntraSlowPal("DISABLED");
        /// <summary>
        /// Constant ENABLED for AvcIntraSlowPal
        /// </summary>
        public static readonly AvcIntraSlowPal ENABLED = new AvcIntraSlowPal("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvcIntraSlowPal(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvcIntraSlowPal FindValue(string value)
        {
            return FindValue<AvcIntraSlowPal>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvcIntraSlowPal(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvcIntraTelecine.
    /// </summary>
    public class AvcIntraTelecine : ConstantClass
    {

        /// <summary>
        /// Constant HARD for AvcIntraTelecine
        /// </summary>
        public static readonly AvcIntraTelecine HARD = new AvcIntraTelecine("HARD");
        /// <summary>
        /// Constant NONE for AvcIntraTelecine
        /// </summary>
        public static readonly AvcIntraTelecine NONE = new AvcIntraTelecine("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvcIntraTelecine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvcIntraTelecine FindValue(string value)
        {
            return FindValue<AvcIntraTelecine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvcIntraTelecine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvcIntraUhdQualityTuningLevel.
    /// </summary>
    public class AvcIntraUhdQualityTuningLevel : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_PASS for AvcIntraUhdQualityTuningLevel
        /// </summary>
        public static readonly AvcIntraUhdQualityTuningLevel MULTI_PASS = new AvcIntraUhdQualityTuningLevel("MULTI_PASS");
        /// <summary>
        /// Constant SINGLE_PASS for AvcIntraUhdQualityTuningLevel
        /// </summary>
        public static readonly AvcIntraUhdQualityTuningLevel SINGLE_PASS = new AvcIntraUhdQualityTuningLevel("SINGLE_PASS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvcIntraUhdQualityTuningLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvcIntraUhdQualityTuningLevel FindValue(string value)
        {
            return FindValue<AvcIntraUhdQualityTuningLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvcIntraUhdQualityTuningLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BandwidthReductionFilterSharpening.
    /// </summary>
    public class BandwidthReductionFilterSharpening : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for BandwidthReductionFilterSharpening
        /// </summary>
        public static readonly BandwidthReductionFilterSharpening HIGH = new BandwidthReductionFilterSharpening("HIGH");
        /// <summary>
        /// Constant LOW for BandwidthReductionFilterSharpening
        /// </summary>
        public static readonly BandwidthReductionFilterSharpening LOW = new BandwidthReductionFilterSharpening("LOW");
        /// <summary>
        /// Constant MEDIUM for BandwidthReductionFilterSharpening
        /// </summary>
        public static readonly BandwidthReductionFilterSharpening MEDIUM = new BandwidthReductionFilterSharpening("MEDIUM");
        /// <summary>
        /// Constant OFF for BandwidthReductionFilterSharpening
        /// </summary>
        public static readonly BandwidthReductionFilterSharpening OFF = new BandwidthReductionFilterSharpening("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BandwidthReductionFilterSharpening(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BandwidthReductionFilterSharpening FindValue(string value)
        {
            return FindValue<BandwidthReductionFilterSharpening>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BandwidthReductionFilterSharpening(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BandwidthReductionFilterStrength.
    /// </summary>
    public class BandwidthReductionFilterStrength : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for BandwidthReductionFilterStrength
        /// </summary>
        public static readonly BandwidthReductionFilterStrength AUTO = new BandwidthReductionFilterStrength("AUTO");
        /// <summary>
        /// Constant HIGH for BandwidthReductionFilterStrength
        /// </summary>
        public static readonly BandwidthReductionFilterStrength HIGH = new BandwidthReductionFilterStrength("HIGH");
        /// <summary>
        /// Constant LOW for BandwidthReductionFilterStrength
        /// </summary>
        public static readonly BandwidthReductionFilterStrength LOW = new BandwidthReductionFilterStrength("LOW");
        /// <summary>
        /// Constant MEDIUM for BandwidthReductionFilterStrength
        /// </summary>
        public static readonly BandwidthReductionFilterStrength MEDIUM = new BandwidthReductionFilterStrength("MEDIUM");
        /// <summary>
        /// Constant OFF for BandwidthReductionFilterStrength
        /// </summary>
        public static readonly BandwidthReductionFilterStrength OFF = new BandwidthReductionFilterStrength("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BandwidthReductionFilterStrength(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BandwidthReductionFilterStrength FindValue(string value)
        {
            return FindValue<BandwidthReductionFilterStrength>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BandwidthReductionFilterStrength(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BillingTagsSource.
    /// </summary>
    public class BillingTagsSource : ConstantClass
    {

        /// <summary>
        /// Constant JOB for BillingTagsSource
        /// </summary>
        public static readonly BillingTagsSource JOB = new BillingTagsSource("JOB");
        /// <summary>
        /// Constant JOB_TEMPLATE for BillingTagsSource
        /// </summary>
        public static readonly BillingTagsSource JOB_TEMPLATE = new BillingTagsSource("JOB_TEMPLATE");
        /// <summary>
        /// Constant PRESET for BillingTagsSource
        /// </summary>
        public static readonly BillingTagsSource PRESET = new BillingTagsSource("PRESET");
        /// <summary>
        /// Constant QUEUE for BillingTagsSource
        /// </summary>
        public static readonly BillingTagsSource QUEUE = new BillingTagsSource("QUEUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillingTagsSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillingTagsSource FindValue(string value)
        {
            return FindValue<BillingTagsSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillingTagsSource(string value)
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
        /// Constant AUTO for BurninSubtitleAlignment
        /// </summary>
        public static readonly BurninSubtitleAlignment AUTO = new BurninSubtitleAlignment("AUTO");
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
    /// Constants used for properties of type BurninSubtitleApplyFontColor.
    /// </summary>
    public class BurninSubtitleApplyFontColor : ConstantClass
    {

        /// <summary>
        /// Constant ALL_TEXT for BurninSubtitleApplyFontColor
        /// </summary>
        public static readonly BurninSubtitleApplyFontColor ALL_TEXT = new BurninSubtitleApplyFontColor("ALL_TEXT");
        /// <summary>
        /// Constant WHITE_TEXT_ONLY for BurninSubtitleApplyFontColor
        /// </summary>
        public static readonly BurninSubtitleApplyFontColor WHITE_TEXT_ONLY = new BurninSubtitleApplyFontColor("WHITE_TEXT_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurninSubtitleApplyFontColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurninSubtitleApplyFontColor FindValue(string value)
        {
            return FindValue<BurninSubtitleApplyFontColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurninSubtitleApplyFontColor(string value)
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
        /// Constant AUTO for BurninSubtitleBackgroundColor
        /// </summary>
        public static readonly BurninSubtitleBackgroundColor AUTO = new BurninSubtitleBackgroundColor("AUTO");
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
    /// Constants used for properties of type BurninSubtitleFallbackFont.
    /// </summary>
    public class BurninSubtitleFallbackFont : ConstantClass
    {

        /// <summary>
        /// Constant BEST_MATCH for BurninSubtitleFallbackFont
        /// </summary>
        public static readonly BurninSubtitleFallbackFont BEST_MATCH = new BurninSubtitleFallbackFont("BEST_MATCH");
        /// <summary>
        /// Constant MONOSPACED_SANSSERIF for BurninSubtitleFallbackFont
        /// </summary>
        public static readonly BurninSubtitleFallbackFont MONOSPACED_SANSSERIF = new BurninSubtitleFallbackFont("MONOSPACED_SANSSERIF");
        /// <summary>
        /// Constant MONOSPACED_SERIF for BurninSubtitleFallbackFont
        /// </summary>
        public static readonly BurninSubtitleFallbackFont MONOSPACED_SERIF = new BurninSubtitleFallbackFont("MONOSPACED_SERIF");
        /// <summary>
        /// Constant PROPORTIONAL_SANSSERIF for BurninSubtitleFallbackFont
        /// </summary>
        public static readonly BurninSubtitleFallbackFont PROPORTIONAL_SANSSERIF = new BurninSubtitleFallbackFont("PROPORTIONAL_SANSSERIF");
        /// <summary>
        /// Constant PROPORTIONAL_SERIF for BurninSubtitleFallbackFont
        /// </summary>
        public static readonly BurninSubtitleFallbackFont PROPORTIONAL_SERIF = new BurninSubtitleFallbackFont("PROPORTIONAL_SERIF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurninSubtitleFallbackFont(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurninSubtitleFallbackFont FindValue(string value)
        {
            return FindValue<BurninSubtitleFallbackFont>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurninSubtitleFallbackFont(string value)
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
        /// Constant AUTO for BurninSubtitleFontColor
        /// </summary>
        public static readonly BurninSubtitleFontColor AUTO = new BurninSubtitleFontColor("AUTO");
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
        /// Constant HEX for BurninSubtitleFontColor
        /// </summary>
        public static readonly BurninSubtitleFontColor HEX = new BurninSubtitleFontColor("HEX");
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
        /// Constant AUTO for BurninSubtitleOutlineColor
        /// </summary>
        public static readonly BurninSubtitleOutlineColor AUTO = new BurninSubtitleOutlineColor("AUTO");
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
        /// Constant AUTO for BurninSubtitleShadowColor
        /// </summary>
        public static readonly BurninSubtitleShadowColor AUTO = new BurninSubtitleShadowColor("AUTO");
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
    /// Constants used for properties of type BurnInSubtitleStylePassthrough.
    /// </summary>
    public class BurnInSubtitleStylePassthrough : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for BurnInSubtitleStylePassthrough
        /// </summary>
        public static readonly BurnInSubtitleStylePassthrough DISABLED = new BurnInSubtitleStylePassthrough("DISABLED");
        /// <summary>
        /// Constant ENABLED for BurnInSubtitleStylePassthrough
        /// </summary>
        public static readonly BurnInSubtitleStylePassthrough ENABLED = new BurnInSubtitleStylePassthrough("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurnInSubtitleStylePassthrough(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurnInSubtitleStylePassthrough FindValue(string value)
        {
            return FindValue<BurnInSubtitleStylePassthrough>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurnInSubtitleStylePassthrough(string value)
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
        /// Constant AUTO for BurninSubtitleTeletextSpacing
        /// </summary>
        public static readonly BurninSubtitleTeletextSpacing AUTO = new BurninSubtitleTeletextSpacing("AUTO");
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
        /// Constant EMBEDDED_PLUS_SCTE20 for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType EMBEDDED_PLUS_SCTE20 = new CaptionDestinationType("EMBEDDED_PLUS_SCTE20");
        /// <summary>
        /// Constant IMSC for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType IMSC = new CaptionDestinationType("IMSC");
        /// <summary>
        /// Constant SCC for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType SCC = new CaptionDestinationType("SCC");
        /// <summary>
        /// Constant SCTE20_PLUS_EMBEDDED for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType SCTE20_PLUS_EMBEDDED = new CaptionDestinationType("SCTE20_PLUS_EMBEDDED");
        /// <summary>
        /// Constant SMI for CaptionDestinationType
        /// </summary>
        public static readonly CaptionDestinationType SMI = new CaptionDestinationType("SMI");
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
        /// Constant IMSC for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType IMSC = new CaptionSourceType("IMSC");
        /// <summary>
        /// Constant NULL_SOURCE for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType NULL_SOURCE = new CaptionSourceType("NULL_SOURCE");
        /// <summary>
        /// Constant SCC for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType SCC = new CaptionSourceType("SCC");
        /// <summary>
        /// Constant SCTE20 for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType SCTE20 = new CaptionSourceType("SCTE20");
        /// <summary>
        /// Constant SMI for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType SMI = new CaptionSourceType("SMI");
        /// <summary>
        /// Constant SMPTE_TT for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType SMPTE_TT = new CaptionSourceType("SMPTE_TT");
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
        /// Constant WEBVTT for CaptionSourceType
        /// </summary>
        public static readonly CaptionSourceType WEBVTT = new CaptionSourceType("WEBVTT");

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
        /// Constant AES_CTR for CmafEncryptionType
        /// </summary>
        public static readonly CmafEncryptionType AES_CTR = new CmafEncryptionType("AES_CTR");
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
    /// Constants used for properties of type CmafImageBasedTrickPlay.
    /// </summary>
    public class CmafImageBasedTrickPlay : ConstantClass
    {

        /// <summary>
        /// Constant ADVANCED for CmafImageBasedTrickPlay
        /// </summary>
        public static readonly CmafImageBasedTrickPlay ADVANCED = new CmafImageBasedTrickPlay("ADVANCED");
        /// <summary>
        /// Constant NONE for CmafImageBasedTrickPlay
        /// </summary>
        public static readonly CmafImageBasedTrickPlay NONE = new CmafImageBasedTrickPlay("NONE");
        /// <summary>
        /// Constant THUMBNAIL for CmafImageBasedTrickPlay
        /// </summary>
        public static readonly CmafImageBasedTrickPlay THUMBNAIL = new CmafImageBasedTrickPlay("THUMBNAIL");
        /// <summary>
        /// Constant THUMBNAIL_AND_FULLFRAME for CmafImageBasedTrickPlay
        /// </summary>
        public static readonly CmafImageBasedTrickPlay THUMBNAIL_AND_FULLFRAME = new CmafImageBasedTrickPlay("THUMBNAIL_AND_FULLFRAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafImageBasedTrickPlay(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafImageBasedTrickPlay FindValue(string value)
        {
            return FindValue<CmafImageBasedTrickPlay>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafImageBasedTrickPlay(string value)
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
    /// Constants used for properties of type CmafIntervalCadence.
    /// </summary>
    public class CmafIntervalCadence : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW_CUSTOM for CmafIntervalCadence
        /// </summary>
        public static readonly CmafIntervalCadence FOLLOW_CUSTOM = new CmafIntervalCadence("FOLLOW_CUSTOM");
        /// <summary>
        /// Constant FOLLOW_IFRAME for CmafIntervalCadence
        /// </summary>
        public static readonly CmafIntervalCadence FOLLOW_IFRAME = new CmafIntervalCadence("FOLLOW_IFRAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafIntervalCadence(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafIntervalCadence FindValue(string value)
        {
            return FindValue<CmafIntervalCadence>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafIntervalCadence(string value)
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
        /// Constant SPEKE for CmafKeyProviderType
        /// </summary>
        public static readonly CmafKeyProviderType SPEKE = new CmafKeyProviderType("SPEKE");
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
    /// Constants used for properties of type CmafMpdManifestBandwidthType.
    /// </summary>
    public class CmafMpdManifestBandwidthType : ConstantClass
    {

        /// <summary>
        /// Constant AVERAGE for CmafMpdManifestBandwidthType
        /// </summary>
        public static readonly CmafMpdManifestBandwidthType AVERAGE = new CmafMpdManifestBandwidthType("AVERAGE");
        /// <summary>
        /// Constant MAX for CmafMpdManifestBandwidthType
        /// </summary>
        public static readonly CmafMpdManifestBandwidthType MAX = new CmafMpdManifestBandwidthType("MAX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafMpdManifestBandwidthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafMpdManifestBandwidthType FindValue(string value)
        {
            return FindValue<CmafMpdManifestBandwidthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafMpdManifestBandwidthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafMpdProfile.
    /// </summary>
    public class CmafMpdProfile : ConstantClass
    {

        /// <summary>
        /// Constant MAIN_PROFILE for CmafMpdProfile
        /// </summary>
        public static readonly CmafMpdProfile MAIN_PROFILE = new CmafMpdProfile("MAIN_PROFILE");
        /// <summary>
        /// Constant ON_DEMAND_PROFILE for CmafMpdProfile
        /// </summary>
        public static readonly CmafMpdProfile ON_DEMAND_PROFILE = new CmafMpdProfile("ON_DEMAND_PROFILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafMpdProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafMpdProfile FindValue(string value)
        {
            return FindValue<CmafMpdProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafMpdProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafPtsOffsetHandlingForBFrames.
    /// </summary>
    public class CmafPtsOffsetHandlingForBFrames : ConstantClass
    {

        /// <summary>
        /// Constant MATCH_INITIAL_PTS for CmafPtsOffsetHandlingForBFrames
        /// </summary>
        public static readonly CmafPtsOffsetHandlingForBFrames MATCH_INITIAL_PTS = new CmafPtsOffsetHandlingForBFrames("MATCH_INITIAL_PTS");
        /// <summary>
        /// Constant ZERO_BASED for CmafPtsOffsetHandlingForBFrames
        /// </summary>
        public static readonly CmafPtsOffsetHandlingForBFrames ZERO_BASED = new CmafPtsOffsetHandlingForBFrames("ZERO_BASED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafPtsOffsetHandlingForBFrames(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafPtsOffsetHandlingForBFrames FindValue(string value)
        {
            return FindValue<CmafPtsOffsetHandlingForBFrames>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafPtsOffsetHandlingForBFrames(string value)
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
    /// Constants used for properties of type CmafSegmentLengthControl.
    /// </summary>
    public class CmafSegmentLengthControl : ConstantClass
    {

        /// <summary>
        /// Constant EXACT for CmafSegmentLengthControl
        /// </summary>
        public static readonly CmafSegmentLengthControl EXACT = new CmafSegmentLengthControl("EXACT");
        /// <summary>
        /// Constant GOP_MULTIPLE for CmafSegmentLengthControl
        /// </summary>
        public static readonly CmafSegmentLengthControl GOP_MULTIPLE = new CmafSegmentLengthControl("GOP_MULTIPLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafSegmentLengthControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafSegmentLengthControl FindValue(string value)
        {
            return FindValue<CmafSegmentLengthControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafSegmentLengthControl(string value)
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
    /// Constants used for properties of type CmafTargetDurationCompatibilityMode.
    /// </summary>
    public class CmafTargetDurationCompatibilityMode : ConstantClass
    {

        /// <summary>
        /// Constant LEGACY for CmafTargetDurationCompatibilityMode
        /// </summary>
        public static readonly CmafTargetDurationCompatibilityMode LEGACY = new CmafTargetDurationCompatibilityMode("LEGACY");
        /// <summary>
        /// Constant SPEC_COMPLIANT for CmafTargetDurationCompatibilityMode
        /// </summary>
        public static readonly CmafTargetDurationCompatibilityMode SPEC_COMPLIANT = new CmafTargetDurationCompatibilityMode("SPEC_COMPLIANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafTargetDurationCompatibilityMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafTargetDurationCompatibilityMode FindValue(string value)
        {
            return FindValue<CmafTargetDurationCompatibilityMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafTargetDurationCompatibilityMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafVideoCompositionOffsets.
    /// </summary>
    public class CmafVideoCompositionOffsets : ConstantClass
    {

        /// <summary>
        /// Constant SIGNED for CmafVideoCompositionOffsets
        /// </summary>
        public static readonly CmafVideoCompositionOffsets SIGNED = new CmafVideoCompositionOffsets("SIGNED");
        /// <summary>
        /// Constant UNSIGNED for CmafVideoCompositionOffsets
        /// </summary>
        public static readonly CmafVideoCompositionOffsets UNSIGNED = new CmafVideoCompositionOffsets("UNSIGNED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafVideoCompositionOffsets(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafVideoCompositionOffsets FindValue(string value)
        {
            return FindValue<CmafVideoCompositionOffsets>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafVideoCompositionOffsets(string value)
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
    /// Constants used for properties of type CmafWriteSegmentTimelineInRepresentation.
    /// </summary>
    public class CmafWriteSegmentTimelineInRepresentation : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CmafWriteSegmentTimelineInRepresentation
        /// </summary>
        public static readonly CmafWriteSegmentTimelineInRepresentation DISABLED = new CmafWriteSegmentTimelineInRepresentation("DISABLED");
        /// <summary>
        /// Constant ENABLED for CmafWriteSegmentTimelineInRepresentation
        /// </summary>
        public static readonly CmafWriteSegmentTimelineInRepresentation ENABLED = new CmafWriteSegmentTimelineInRepresentation("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafWriteSegmentTimelineInRepresentation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafWriteSegmentTimelineInRepresentation FindValue(string value)
        {
            return FindValue<CmafWriteSegmentTimelineInRepresentation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafWriteSegmentTimelineInRepresentation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmfcAudioDuration.
    /// </summary>
    public class CmfcAudioDuration : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT_CODEC_DURATION for CmfcAudioDuration
        /// </summary>
        public static readonly CmfcAudioDuration DEFAULT_CODEC_DURATION = new CmfcAudioDuration("DEFAULT_CODEC_DURATION");
        /// <summary>
        /// Constant MATCH_VIDEO_DURATION for CmfcAudioDuration
        /// </summary>
        public static readonly CmfcAudioDuration MATCH_VIDEO_DURATION = new CmfcAudioDuration("MATCH_VIDEO_DURATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmfcAudioDuration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmfcAudioDuration FindValue(string value)
        {
            return FindValue<CmfcAudioDuration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmfcAudioDuration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmfcAudioTrackType.
    /// </summary>
    public class CmfcAudioTrackType : ConstantClass
    {

        /// <summary>
        /// Constant ALTERNATE_AUDIO_AUTO_SELECT for CmfcAudioTrackType
        /// </summary>
        public static readonly CmfcAudioTrackType ALTERNATE_AUDIO_AUTO_SELECT = new CmfcAudioTrackType("ALTERNATE_AUDIO_AUTO_SELECT");
        /// <summary>
        /// Constant ALTERNATE_AUDIO_AUTO_SELECT_DEFAULT for CmfcAudioTrackType
        /// </summary>
        public static readonly CmfcAudioTrackType ALTERNATE_AUDIO_AUTO_SELECT_DEFAULT = new CmfcAudioTrackType("ALTERNATE_AUDIO_AUTO_SELECT_DEFAULT");
        /// <summary>
        /// Constant ALTERNATE_AUDIO_NOT_AUTO_SELECT for CmfcAudioTrackType
        /// </summary>
        public static readonly CmfcAudioTrackType ALTERNATE_AUDIO_NOT_AUTO_SELECT = new CmfcAudioTrackType("ALTERNATE_AUDIO_NOT_AUTO_SELECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmfcAudioTrackType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmfcAudioTrackType FindValue(string value)
        {
            return FindValue<CmfcAudioTrackType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmfcAudioTrackType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmfcDescriptiveVideoServiceFlag.
    /// </summary>
    public class CmfcDescriptiveVideoServiceFlag : ConstantClass
    {

        /// <summary>
        /// Constant DONT_FLAG for CmfcDescriptiveVideoServiceFlag
        /// </summary>
        public static readonly CmfcDescriptiveVideoServiceFlag DONT_FLAG = new CmfcDescriptiveVideoServiceFlag("DONT_FLAG");
        /// <summary>
        /// Constant FLAG for CmfcDescriptiveVideoServiceFlag
        /// </summary>
        public static readonly CmfcDescriptiveVideoServiceFlag FLAG = new CmfcDescriptiveVideoServiceFlag("FLAG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmfcDescriptiveVideoServiceFlag(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmfcDescriptiveVideoServiceFlag FindValue(string value)
        {
            return FindValue<CmfcDescriptiveVideoServiceFlag>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmfcDescriptiveVideoServiceFlag(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmfcIFrameOnlyManifest.
    /// </summary>
    public class CmfcIFrameOnlyManifest : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for CmfcIFrameOnlyManifest
        /// </summary>
        public static readonly CmfcIFrameOnlyManifest EXCLUDE = new CmfcIFrameOnlyManifest("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for CmfcIFrameOnlyManifest
        /// </summary>
        public static readonly CmfcIFrameOnlyManifest INCLUDE = new CmfcIFrameOnlyManifest("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmfcIFrameOnlyManifest(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmfcIFrameOnlyManifest FindValue(string value)
        {
            return FindValue<CmfcIFrameOnlyManifest>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmfcIFrameOnlyManifest(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmfcKlvMetadata.
    /// </summary>
    public class CmfcKlvMetadata : ConstantClass
    {

        /// <summary>
        /// Constant NONE for CmfcKlvMetadata
        /// </summary>
        public static readonly CmfcKlvMetadata NONE = new CmfcKlvMetadata("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for CmfcKlvMetadata
        /// </summary>
        public static readonly CmfcKlvMetadata PASSTHROUGH = new CmfcKlvMetadata("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmfcKlvMetadata(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmfcKlvMetadata FindValue(string value)
        {
            return FindValue<CmfcKlvMetadata>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmfcKlvMetadata(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmfcManifestMetadataSignaling.
    /// </summary>
    public class CmfcManifestMetadataSignaling : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CmfcManifestMetadataSignaling
        /// </summary>
        public static readonly CmfcManifestMetadataSignaling DISABLED = new CmfcManifestMetadataSignaling("DISABLED");
        /// <summary>
        /// Constant ENABLED for CmfcManifestMetadataSignaling
        /// </summary>
        public static readonly CmfcManifestMetadataSignaling ENABLED = new CmfcManifestMetadataSignaling("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmfcManifestMetadataSignaling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmfcManifestMetadataSignaling FindValue(string value)
        {
            return FindValue<CmfcManifestMetadataSignaling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmfcManifestMetadataSignaling(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmfcScte35Esam.
    /// </summary>
    public class CmfcScte35Esam : ConstantClass
    {

        /// <summary>
        /// Constant INSERT for CmfcScte35Esam
        /// </summary>
        public static readonly CmfcScte35Esam INSERT = new CmfcScte35Esam("INSERT");
        /// <summary>
        /// Constant NONE for CmfcScte35Esam
        /// </summary>
        public static readonly CmfcScte35Esam NONE = new CmfcScte35Esam("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmfcScte35Esam(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmfcScte35Esam FindValue(string value)
        {
            return FindValue<CmfcScte35Esam>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmfcScte35Esam(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmfcScte35Source.
    /// </summary>
    public class CmfcScte35Source : ConstantClass
    {

        /// <summary>
        /// Constant NONE for CmfcScte35Source
        /// </summary>
        public static readonly CmfcScte35Source NONE = new CmfcScte35Source("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for CmfcScte35Source
        /// </summary>
        public static readonly CmfcScte35Source PASSTHROUGH = new CmfcScte35Source("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmfcScte35Source(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmfcScte35Source FindValue(string value)
        {
            return FindValue<CmfcScte35Source>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmfcScte35Source(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmfcTimedMetadata.
    /// </summary>
    public class CmfcTimedMetadata : ConstantClass
    {

        /// <summary>
        /// Constant NONE for CmfcTimedMetadata
        /// </summary>
        public static readonly CmfcTimedMetadata NONE = new CmfcTimedMetadata("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for CmfcTimedMetadata
        /// </summary>
        public static readonly CmfcTimedMetadata PASSTHROUGH = new CmfcTimedMetadata("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmfcTimedMetadata(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmfcTimedMetadata FindValue(string value)
        {
            return FindValue<CmfcTimedMetadata>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmfcTimedMetadata(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmfcTimedMetadataBoxVersion.
    /// </summary>
    public class CmfcTimedMetadataBoxVersion : ConstantClass
    {

        /// <summary>
        /// Constant VERSION_0 for CmfcTimedMetadataBoxVersion
        /// </summary>
        public static readonly CmfcTimedMetadataBoxVersion VERSION_0 = new CmfcTimedMetadataBoxVersion("VERSION_0");
        /// <summary>
        /// Constant VERSION_1 for CmfcTimedMetadataBoxVersion
        /// </summary>
        public static readonly CmfcTimedMetadataBoxVersion VERSION_1 = new CmfcTimedMetadataBoxVersion("VERSION_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmfcTimedMetadataBoxVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmfcTimedMetadataBoxVersion FindValue(string value)
        {
            return FindValue<CmfcTimedMetadataBoxVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmfcTimedMetadataBoxVersion(string value)
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
        /// Constant P3D65_SDR for ColorSpace
        /// </summary>
        public static readonly ColorSpace P3D65_SDR = new ColorSpace("P3D65_SDR");
        /// <summary>
        /// Constant P3DCI for ColorSpace
        /// </summary>
        public static readonly ColorSpace P3DCI = new ColorSpace("P3DCI");
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
        /// Constant FORCE_P3D65_SDR for ColorSpaceConversion
        /// </summary>
        public static readonly ColorSpaceConversion FORCE_P3D65_SDR = new ColorSpaceConversion("FORCE_P3D65_SDR");
        /// <summary>
        /// Constant FORCE_P3DCI for ColorSpaceConversion
        /// </summary>
        public static readonly ColorSpaceConversion FORCE_P3DCI = new ColorSpaceConversion("FORCE_P3DCI");
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
    /// Constants used for properties of type Commitment.
    /// </summary>
    public class Commitment : ConstantClass
    {

        /// <summary>
        /// Constant ONE_YEAR for Commitment
        /// </summary>
        public static readonly Commitment ONE_YEAR = new Commitment("ONE_YEAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Commitment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Commitment FindValue(string value)
        {
            return FindValue<Commitment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Commitment(string value)
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
        /// Constant WEBM for ContainerType
        /// </summary>
        public static readonly ContainerType WEBM = new ContainerType("WEBM");

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
    /// Constants used for properties of type CopyProtectionAction.
    /// </summary>
    public class CopyProtectionAction : ConstantClass
    {

        /// <summary>
        /// Constant PASSTHROUGH for CopyProtectionAction
        /// </summary>
        public static readonly CopyProtectionAction PASSTHROUGH = new CopyProtectionAction("PASSTHROUGH");
        /// <summary>
        /// Constant STRIP for CopyProtectionAction
        /// </summary>
        public static readonly CopyProtectionAction STRIP = new CopyProtectionAction("STRIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CopyProtectionAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CopyProtectionAction FindValue(string value)
        {
            return FindValue<CopyProtectionAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CopyProtectionAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashIsoGroupAudioChannelConfigSchemeIdUri.
    /// </summary>
    public class DashIsoGroupAudioChannelConfigSchemeIdUri : ConstantClass
    {

        /// <summary>
        /// Constant DOLBY_CHANNEL_CONFIGURATION for DashIsoGroupAudioChannelConfigSchemeIdUri
        /// </summary>
        public static readonly DashIsoGroupAudioChannelConfigSchemeIdUri DOLBY_CHANNEL_CONFIGURATION = new DashIsoGroupAudioChannelConfigSchemeIdUri("DOLBY_CHANNEL_CONFIGURATION");
        /// <summary>
        /// Constant MPEG_CHANNEL_CONFIGURATION for DashIsoGroupAudioChannelConfigSchemeIdUri
        /// </summary>
        public static readonly DashIsoGroupAudioChannelConfigSchemeIdUri MPEG_CHANNEL_CONFIGURATION = new DashIsoGroupAudioChannelConfigSchemeIdUri("MPEG_CHANNEL_CONFIGURATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashIsoGroupAudioChannelConfigSchemeIdUri(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashIsoGroupAudioChannelConfigSchemeIdUri FindValue(string value)
        {
            return FindValue<DashIsoGroupAudioChannelConfigSchemeIdUri>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashIsoGroupAudioChannelConfigSchemeIdUri(string value)
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
    /// Constants used for properties of type DashIsoImageBasedTrickPlay.
    /// </summary>
    public class DashIsoImageBasedTrickPlay : ConstantClass
    {

        /// <summary>
        /// Constant ADVANCED for DashIsoImageBasedTrickPlay
        /// </summary>
        public static readonly DashIsoImageBasedTrickPlay ADVANCED = new DashIsoImageBasedTrickPlay("ADVANCED");
        /// <summary>
        /// Constant NONE for DashIsoImageBasedTrickPlay
        /// </summary>
        public static readonly DashIsoImageBasedTrickPlay NONE = new DashIsoImageBasedTrickPlay("NONE");
        /// <summary>
        /// Constant THUMBNAIL for DashIsoImageBasedTrickPlay
        /// </summary>
        public static readonly DashIsoImageBasedTrickPlay THUMBNAIL = new DashIsoImageBasedTrickPlay("THUMBNAIL");
        /// <summary>
        /// Constant THUMBNAIL_AND_FULLFRAME for DashIsoImageBasedTrickPlay
        /// </summary>
        public static readonly DashIsoImageBasedTrickPlay THUMBNAIL_AND_FULLFRAME = new DashIsoImageBasedTrickPlay("THUMBNAIL_AND_FULLFRAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashIsoImageBasedTrickPlay(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashIsoImageBasedTrickPlay FindValue(string value)
        {
            return FindValue<DashIsoImageBasedTrickPlay>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashIsoImageBasedTrickPlay(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashIsoIntervalCadence.
    /// </summary>
    public class DashIsoIntervalCadence : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW_CUSTOM for DashIsoIntervalCadence
        /// </summary>
        public static readonly DashIsoIntervalCadence FOLLOW_CUSTOM = new DashIsoIntervalCadence("FOLLOW_CUSTOM");
        /// <summary>
        /// Constant FOLLOW_IFRAME for DashIsoIntervalCadence
        /// </summary>
        public static readonly DashIsoIntervalCadence FOLLOW_IFRAME = new DashIsoIntervalCadence("FOLLOW_IFRAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashIsoIntervalCadence(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashIsoIntervalCadence FindValue(string value)
        {
            return FindValue<DashIsoIntervalCadence>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashIsoIntervalCadence(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashIsoMpdManifestBandwidthType.
    /// </summary>
    public class DashIsoMpdManifestBandwidthType : ConstantClass
    {

        /// <summary>
        /// Constant AVERAGE for DashIsoMpdManifestBandwidthType
        /// </summary>
        public static readonly DashIsoMpdManifestBandwidthType AVERAGE = new DashIsoMpdManifestBandwidthType("AVERAGE");
        /// <summary>
        /// Constant MAX for DashIsoMpdManifestBandwidthType
        /// </summary>
        public static readonly DashIsoMpdManifestBandwidthType MAX = new DashIsoMpdManifestBandwidthType("MAX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashIsoMpdManifestBandwidthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashIsoMpdManifestBandwidthType FindValue(string value)
        {
            return FindValue<DashIsoMpdManifestBandwidthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashIsoMpdManifestBandwidthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashIsoMpdProfile.
    /// </summary>
    public class DashIsoMpdProfile : ConstantClass
    {

        /// <summary>
        /// Constant MAIN_PROFILE for DashIsoMpdProfile
        /// </summary>
        public static readonly DashIsoMpdProfile MAIN_PROFILE = new DashIsoMpdProfile("MAIN_PROFILE");
        /// <summary>
        /// Constant ON_DEMAND_PROFILE for DashIsoMpdProfile
        /// </summary>
        public static readonly DashIsoMpdProfile ON_DEMAND_PROFILE = new DashIsoMpdProfile("ON_DEMAND_PROFILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashIsoMpdProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashIsoMpdProfile FindValue(string value)
        {
            return FindValue<DashIsoMpdProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashIsoMpdProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashIsoPlaybackDeviceCompatibility.
    /// </summary>
    public class DashIsoPlaybackDeviceCompatibility : ConstantClass
    {

        /// <summary>
        /// Constant CENC_V1 for DashIsoPlaybackDeviceCompatibility
        /// </summary>
        public static readonly DashIsoPlaybackDeviceCompatibility CENC_V1 = new DashIsoPlaybackDeviceCompatibility("CENC_V1");
        /// <summary>
        /// Constant UNENCRYPTED_SEI for DashIsoPlaybackDeviceCompatibility
        /// </summary>
        public static readonly DashIsoPlaybackDeviceCompatibility UNENCRYPTED_SEI = new DashIsoPlaybackDeviceCompatibility("UNENCRYPTED_SEI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashIsoPlaybackDeviceCompatibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashIsoPlaybackDeviceCompatibility FindValue(string value)
        {
            return FindValue<DashIsoPlaybackDeviceCompatibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashIsoPlaybackDeviceCompatibility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashIsoPtsOffsetHandlingForBFrames.
    /// </summary>
    public class DashIsoPtsOffsetHandlingForBFrames : ConstantClass
    {

        /// <summary>
        /// Constant MATCH_INITIAL_PTS for DashIsoPtsOffsetHandlingForBFrames
        /// </summary>
        public static readonly DashIsoPtsOffsetHandlingForBFrames MATCH_INITIAL_PTS = new DashIsoPtsOffsetHandlingForBFrames("MATCH_INITIAL_PTS");
        /// <summary>
        /// Constant ZERO_BASED for DashIsoPtsOffsetHandlingForBFrames
        /// </summary>
        public static readonly DashIsoPtsOffsetHandlingForBFrames ZERO_BASED = new DashIsoPtsOffsetHandlingForBFrames("ZERO_BASED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashIsoPtsOffsetHandlingForBFrames(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashIsoPtsOffsetHandlingForBFrames FindValue(string value)
        {
            return FindValue<DashIsoPtsOffsetHandlingForBFrames>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashIsoPtsOffsetHandlingForBFrames(string value)
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
    /// Constants used for properties of type DashIsoSegmentLengthControl.
    /// </summary>
    public class DashIsoSegmentLengthControl : ConstantClass
    {

        /// <summary>
        /// Constant EXACT for DashIsoSegmentLengthControl
        /// </summary>
        public static readonly DashIsoSegmentLengthControl EXACT = new DashIsoSegmentLengthControl("EXACT");
        /// <summary>
        /// Constant GOP_MULTIPLE for DashIsoSegmentLengthControl
        /// </summary>
        public static readonly DashIsoSegmentLengthControl GOP_MULTIPLE = new DashIsoSegmentLengthControl("GOP_MULTIPLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashIsoSegmentLengthControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashIsoSegmentLengthControl FindValue(string value)
        {
            return FindValue<DashIsoSegmentLengthControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashIsoSegmentLengthControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashIsoVideoCompositionOffsets.
    /// </summary>
    public class DashIsoVideoCompositionOffsets : ConstantClass
    {

        /// <summary>
        /// Constant SIGNED for DashIsoVideoCompositionOffsets
        /// </summary>
        public static readonly DashIsoVideoCompositionOffsets SIGNED = new DashIsoVideoCompositionOffsets("SIGNED");
        /// <summary>
        /// Constant UNSIGNED for DashIsoVideoCompositionOffsets
        /// </summary>
        public static readonly DashIsoVideoCompositionOffsets UNSIGNED = new DashIsoVideoCompositionOffsets("UNSIGNED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashIsoVideoCompositionOffsets(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashIsoVideoCompositionOffsets FindValue(string value)
        {
            return FindValue<DashIsoVideoCompositionOffsets>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashIsoVideoCompositionOffsets(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashIsoWriteSegmentTimelineInRepresentation.
    /// </summary>
    public class DashIsoWriteSegmentTimelineInRepresentation : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DashIsoWriteSegmentTimelineInRepresentation
        /// </summary>
        public static readonly DashIsoWriteSegmentTimelineInRepresentation DISABLED = new DashIsoWriteSegmentTimelineInRepresentation("DISABLED");
        /// <summary>
        /// Constant ENABLED for DashIsoWriteSegmentTimelineInRepresentation
        /// </summary>
        public static readonly DashIsoWriteSegmentTimelineInRepresentation ENABLED = new DashIsoWriteSegmentTimelineInRepresentation("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashIsoWriteSegmentTimelineInRepresentation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashIsoWriteSegmentTimelineInRepresentation FindValue(string value)
        {
            return FindValue<DashIsoWriteSegmentTimelineInRepresentation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashIsoWriteSegmentTimelineInRepresentation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashManifestStyle.
    /// </summary>
    public class DashManifestStyle : ConstantClass
    {

        /// <summary>
        /// Constant BASIC for DashManifestStyle
        /// </summary>
        public static readonly DashManifestStyle BASIC = new DashManifestStyle("BASIC");
        /// <summary>
        /// Constant COMPACT for DashManifestStyle
        /// </summary>
        public static readonly DashManifestStyle COMPACT = new DashManifestStyle("COMPACT");
        /// <summary>
        /// Constant DISTINCT for DashManifestStyle
        /// </summary>
        public static readonly DashManifestStyle DISTINCT = new DashManifestStyle("DISTINCT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashManifestStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashManifestStyle FindValue(string value)
        {
            return FindValue<DashManifestStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashManifestStyle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DecryptionMode.
    /// </summary>
    public class DecryptionMode : ConstantClass
    {

        /// <summary>
        /// Constant AES_CBC for DecryptionMode
        /// </summary>
        public static readonly DecryptionMode AES_CBC = new DecryptionMode("AES_CBC");
        /// <summary>
        /// Constant AES_CTR for DecryptionMode
        /// </summary>
        public static readonly DecryptionMode AES_CTR = new DecryptionMode("AES_CTR");
        /// <summary>
        /// Constant AES_GCM for DecryptionMode
        /// </summary>
        public static readonly DecryptionMode AES_GCM = new DecryptionMode("AES_GCM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DecryptionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DecryptionMode FindValue(string value)
        {
            return FindValue<DecryptionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DecryptionMode(string value)
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
    /// Constants used for properties of type DescribeEndpointsMode.
    /// </summary>
    public class DescribeEndpointsMode : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for DescribeEndpointsMode
        /// </summary>
        public static readonly DescribeEndpointsMode DEFAULT = new DescribeEndpointsMode("DEFAULT");
        /// <summary>
        /// Constant GET_ONLY for DescribeEndpointsMode
        /// </summary>
        public static readonly DescribeEndpointsMode GET_ONLY = new DescribeEndpointsMode("GET_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DescribeEndpointsMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DescribeEndpointsMode FindValue(string value)
        {
            return FindValue<DescribeEndpointsMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DescribeEndpointsMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DolbyVisionLevel6Mode.
    /// </summary>
    public class DolbyVisionLevel6Mode : ConstantClass
    {

        /// <summary>
        /// Constant PASSTHROUGH for DolbyVisionLevel6Mode
        /// </summary>
        public static readonly DolbyVisionLevel6Mode PASSTHROUGH = new DolbyVisionLevel6Mode("PASSTHROUGH");
        /// <summary>
        /// Constant RECALCULATE for DolbyVisionLevel6Mode
        /// </summary>
        public static readonly DolbyVisionLevel6Mode RECALCULATE = new DolbyVisionLevel6Mode("RECALCULATE");
        /// <summary>
        /// Constant SPECIFY for DolbyVisionLevel6Mode
        /// </summary>
        public static readonly DolbyVisionLevel6Mode SPECIFY = new DolbyVisionLevel6Mode("SPECIFY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DolbyVisionLevel6Mode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DolbyVisionLevel6Mode FindValue(string value)
        {
            return FindValue<DolbyVisionLevel6Mode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DolbyVisionLevel6Mode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DolbyVisionMapping.
    /// </summary>
    public class DolbyVisionMapping : ConstantClass
    {

        /// <summary>
        /// Constant HDR10_1000 for DolbyVisionMapping
        /// </summary>
        public static readonly DolbyVisionMapping HDR10_1000 = new DolbyVisionMapping("HDR10_1000");
        /// <summary>
        /// Constant HDR10_NOMAP for DolbyVisionMapping
        /// </summary>
        public static readonly DolbyVisionMapping HDR10_NOMAP = new DolbyVisionMapping("HDR10_NOMAP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DolbyVisionMapping(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DolbyVisionMapping FindValue(string value)
        {
            return FindValue<DolbyVisionMapping>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DolbyVisionMapping(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DolbyVisionProfile.
    /// </summary>
    public class DolbyVisionProfile : ConstantClass
    {

        /// <summary>
        /// Constant PROFILE_5 for DolbyVisionProfile
        /// </summary>
        public static readonly DolbyVisionProfile PROFILE_5 = new DolbyVisionProfile("PROFILE_5");
        /// <summary>
        /// Constant PROFILE_8_1 for DolbyVisionProfile
        /// </summary>
        public static readonly DolbyVisionProfile PROFILE_8_1 = new DolbyVisionProfile("PROFILE_8_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DolbyVisionProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DolbyVisionProfile FindValue(string value)
        {
            return FindValue<DolbyVisionProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DolbyVisionProfile(string value)
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
    /// Constants used for properties of type DvbddsHandling.
    /// </summary>
    public class DvbddsHandling : ConstantClass
    {

        /// <summary>
        /// Constant NO_DISPLAY_WINDOW for DvbddsHandling
        /// </summary>
        public static readonly DvbddsHandling NO_DISPLAY_WINDOW = new DvbddsHandling("NO_DISPLAY_WINDOW");
        /// <summary>
        /// Constant NONE for DvbddsHandling
        /// </summary>
        public static readonly DvbddsHandling NONE = new DvbddsHandling("NONE");
        /// <summary>
        /// Constant SPECIFIED for DvbddsHandling
        /// </summary>
        public static readonly DvbddsHandling SPECIFIED = new DvbddsHandling("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbddsHandling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbddsHandling FindValue(string value)
        {
            return FindValue<DvbddsHandling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbddsHandling(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubSubtitleFallbackFont.
    /// </summary>
    public class DvbSubSubtitleFallbackFont : ConstantClass
    {

        /// <summary>
        /// Constant BEST_MATCH for DvbSubSubtitleFallbackFont
        /// </summary>
        public static readonly DvbSubSubtitleFallbackFont BEST_MATCH = new DvbSubSubtitleFallbackFont("BEST_MATCH");
        /// <summary>
        /// Constant MONOSPACED_SANSSERIF for DvbSubSubtitleFallbackFont
        /// </summary>
        public static readonly DvbSubSubtitleFallbackFont MONOSPACED_SANSSERIF = new DvbSubSubtitleFallbackFont("MONOSPACED_SANSSERIF");
        /// <summary>
        /// Constant MONOSPACED_SERIF for DvbSubSubtitleFallbackFont
        /// </summary>
        public static readonly DvbSubSubtitleFallbackFont MONOSPACED_SERIF = new DvbSubSubtitleFallbackFont("MONOSPACED_SERIF");
        /// <summary>
        /// Constant PROPORTIONAL_SANSSERIF for DvbSubSubtitleFallbackFont
        /// </summary>
        public static readonly DvbSubSubtitleFallbackFont PROPORTIONAL_SANSSERIF = new DvbSubSubtitleFallbackFont("PROPORTIONAL_SANSSERIF");
        /// <summary>
        /// Constant PROPORTIONAL_SERIF for DvbSubSubtitleFallbackFont
        /// </summary>
        public static readonly DvbSubSubtitleFallbackFont PROPORTIONAL_SERIF = new DvbSubSubtitleFallbackFont("PROPORTIONAL_SERIF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubSubtitleFallbackFont(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubSubtitleFallbackFont FindValue(string value)
        {
            return FindValue<DvbSubSubtitleFallbackFont>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubSubtitleFallbackFont(string value)
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
        /// Constant AUTO for DvbSubtitleAlignment
        /// </summary>
        public static readonly DvbSubtitleAlignment AUTO = new DvbSubtitleAlignment("AUTO");
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
    /// Constants used for properties of type DvbSubtitleApplyFontColor.
    /// </summary>
    public class DvbSubtitleApplyFontColor : ConstantClass
    {

        /// <summary>
        /// Constant ALL_TEXT for DvbSubtitleApplyFontColor
        /// </summary>
        public static readonly DvbSubtitleApplyFontColor ALL_TEXT = new DvbSubtitleApplyFontColor("ALL_TEXT");
        /// <summary>
        /// Constant WHITE_TEXT_ONLY for DvbSubtitleApplyFontColor
        /// </summary>
        public static readonly DvbSubtitleApplyFontColor WHITE_TEXT_ONLY = new DvbSubtitleApplyFontColor("WHITE_TEXT_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubtitleApplyFontColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubtitleApplyFontColor FindValue(string value)
        {
            return FindValue<DvbSubtitleApplyFontColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubtitleApplyFontColor(string value)
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
        /// Constant AUTO for DvbSubtitleBackgroundColor
        /// </summary>
        public static readonly DvbSubtitleBackgroundColor AUTO = new DvbSubtitleBackgroundColor("AUTO");
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
        /// Constant AUTO for DvbSubtitleFontColor
        /// </summary>
        public static readonly DvbSubtitleFontColor AUTO = new DvbSubtitleFontColor("AUTO");
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
        /// Constant HEX for DvbSubtitleFontColor
        /// </summary>
        public static readonly DvbSubtitleFontColor HEX = new DvbSubtitleFontColor("HEX");
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
        /// Constant AUTO for DvbSubtitleOutlineColor
        /// </summary>
        public static readonly DvbSubtitleOutlineColor AUTO = new DvbSubtitleOutlineColor("AUTO");
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
        /// Constant AUTO for DvbSubtitleShadowColor
        /// </summary>
        public static readonly DvbSubtitleShadowColor AUTO = new DvbSubtitleShadowColor("AUTO");
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
    /// Constants used for properties of type DvbSubtitleStylePassthrough.
    /// </summary>
    public class DvbSubtitleStylePassthrough : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DvbSubtitleStylePassthrough
        /// </summary>
        public static readonly DvbSubtitleStylePassthrough DISABLED = new DvbSubtitleStylePassthrough("DISABLED");
        /// <summary>
        /// Constant ENABLED for DvbSubtitleStylePassthrough
        /// </summary>
        public static readonly DvbSubtitleStylePassthrough ENABLED = new DvbSubtitleStylePassthrough("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubtitleStylePassthrough(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubtitleStylePassthrough FindValue(string value)
        {
            return FindValue<DvbSubtitleStylePassthrough>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubtitleStylePassthrough(string value)
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
        /// Constant AUTO for DvbSubtitleTeletextSpacing
        /// </summary>
        public static readonly DvbSubtitleTeletextSpacing AUTO = new DvbSubtitleTeletextSpacing("AUTO");
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
    /// Constants used for properties of type DvbSubtitlingType.
    /// </summary>
    public class DvbSubtitlingType : ConstantClass
    {

        /// <summary>
        /// Constant HEARING_IMPAIRED for DvbSubtitlingType
        /// </summary>
        public static readonly DvbSubtitlingType HEARING_IMPAIRED = new DvbSubtitlingType("HEARING_IMPAIRED");
        /// <summary>
        /// Constant STANDARD for DvbSubtitlingType
        /// </summary>
        public static readonly DvbSubtitlingType STANDARD = new DvbSubtitlingType("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubtitlingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubtitlingType FindValue(string value)
        {
            return FindValue<DvbSubtitlingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubtitlingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3AtmosBitstreamMode.
    /// </summary>
    public class Eac3AtmosBitstreamMode : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE_MAIN for Eac3AtmosBitstreamMode
        /// </summary>
        public static readonly Eac3AtmosBitstreamMode COMPLETE_MAIN = new Eac3AtmosBitstreamMode("COMPLETE_MAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AtmosBitstreamMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AtmosBitstreamMode FindValue(string value)
        {
            return FindValue<Eac3AtmosBitstreamMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AtmosBitstreamMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3AtmosCodingMode.
    /// </summary>
    public class Eac3AtmosCodingMode : ConstantClass
    {

        /// <summary>
        /// Constant CODING_MODE_5_1_4 for Eac3AtmosCodingMode
        /// </summary>
        public static readonly Eac3AtmosCodingMode CODING_MODE_5_1_4 = new Eac3AtmosCodingMode("CODING_MODE_5_1_4");
        /// <summary>
        /// Constant CODING_MODE_7_1_4 for Eac3AtmosCodingMode
        /// </summary>
        public static readonly Eac3AtmosCodingMode CODING_MODE_7_1_4 = new Eac3AtmosCodingMode("CODING_MODE_7_1_4");
        /// <summary>
        /// Constant CODING_MODE_9_1_6 for Eac3AtmosCodingMode
        /// </summary>
        public static readonly Eac3AtmosCodingMode CODING_MODE_9_1_6 = new Eac3AtmosCodingMode("CODING_MODE_9_1_6");
        /// <summary>
        /// Constant CODING_MODE_AUTO for Eac3AtmosCodingMode
        /// </summary>
        public static readonly Eac3AtmosCodingMode CODING_MODE_AUTO = new Eac3AtmosCodingMode("CODING_MODE_AUTO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AtmosCodingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AtmosCodingMode FindValue(string value)
        {
            return FindValue<Eac3AtmosCodingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AtmosCodingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3AtmosDialogueIntelligence.
    /// </summary>
    public class Eac3AtmosDialogueIntelligence : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Eac3AtmosDialogueIntelligence
        /// </summary>
        public static readonly Eac3AtmosDialogueIntelligence DISABLED = new Eac3AtmosDialogueIntelligence("DISABLED");
        /// <summary>
        /// Constant ENABLED for Eac3AtmosDialogueIntelligence
        /// </summary>
        public static readonly Eac3AtmosDialogueIntelligence ENABLED = new Eac3AtmosDialogueIntelligence("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AtmosDialogueIntelligence(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AtmosDialogueIntelligence FindValue(string value)
        {
            return FindValue<Eac3AtmosDialogueIntelligence>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AtmosDialogueIntelligence(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3AtmosDownmixControl.
    /// </summary>
    public class Eac3AtmosDownmixControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for Eac3AtmosDownmixControl
        /// </summary>
        public static readonly Eac3AtmosDownmixControl INITIALIZE_FROM_SOURCE = new Eac3AtmosDownmixControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for Eac3AtmosDownmixControl
        /// </summary>
        public static readonly Eac3AtmosDownmixControl SPECIFIED = new Eac3AtmosDownmixControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AtmosDownmixControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AtmosDownmixControl FindValue(string value)
        {
            return FindValue<Eac3AtmosDownmixControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AtmosDownmixControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3AtmosDynamicRangeCompressionLine.
    /// </summary>
    public class Eac3AtmosDynamicRangeCompressionLine : ConstantClass
    {

        /// <summary>
        /// Constant FILM_LIGHT for Eac3AtmosDynamicRangeCompressionLine
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeCompressionLine FILM_LIGHT = new Eac3AtmosDynamicRangeCompressionLine("FILM_LIGHT");
        /// <summary>
        /// Constant FILM_STANDARD for Eac3AtmosDynamicRangeCompressionLine
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeCompressionLine FILM_STANDARD = new Eac3AtmosDynamicRangeCompressionLine("FILM_STANDARD");
        /// <summary>
        /// Constant MUSIC_LIGHT for Eac3AtmosDynamicRangeCompressionLine
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeCompressionLine MUSIC_LIGHT = new Eac3AtmosDynamicRangeCompressionLine("MUSIC_LIGHT");
        /// <summary>
        /// Constant MUSIC_STANDARD for Eac3AtmosDynamicRangeCompressionLine
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeCompressionLine MUSIC_STANDARD = new Eac3AtmosDynamicRangeCompressionLine("MUSIC_STANDARD");
        /// <summary>
        /// Constant NONE for Eac3AtmosDynamicRangeCompressionLine
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeCompressionLine NONE = new Eac3AtmosDynamicRangeCompressionLine("NONE");
        /// <summary>
        /// Constant SPEECH for Eac3AtmosDynamicRangeCompressionLine
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeCompressionLine SPEECH = new Eac3AtmosDynamicRangeCompressionLine("SPEECH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AtmosDynamicRangeCompressionLine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AtmosDynamicRangeCompressionLine FindValue(string value)
        {
            return FindValue<Eac3AtmosDynamicRangeCompressionLine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AtmosDynamicRangeCompressionLine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3AtmosDynamicRangeCompressionRf.
    /// </summary>
    public class Eac3AtmosDynamicRangeCompressionRf : ConstantClass
    {

        /// <summary>
        /// Constant FILM_LIGHT for Eac3AtmosDynamicRangeCompressionRf
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeCompressionRf FILM_LIGHT = new Eac3AtmosDynamicRangeCompressionRf("FILM_LIGHT");
        /// <summary>
        /// Constant FILM_STANDARD for Eac3AtmosDynamicRangeCompressionRf
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeCompressionRf FILM_STANDARD = new Eac3AtmosDynamicRangeCompressionRf("FILM_STANDARD");
        /// <summary>
        /// Constant MUSIC_LIGHT for Eac3AtmosDynamicRangeCompressionRf
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeCompressionRf MUSIC_LIGHT = new Eac3AtmosDynamicRangeCompressionRf("MUSIC_LIGHT");
        /// <summary>
        /// Constant MUSIC_STANDARD for Eac3AtmosDynamicRangeCompressionRf
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeCompressionRf MUSIC_STANDARD = new Eac3AtmosDynamicRangeCompressionRf("MUSIC_STANDARD");
        /// <summary>
        /// Constant NONE for Eac3AtmosDynamicRangeCompressionRf
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeCompressionRf NONE = new Eac3AtmosDynamicRangeCompressionRf("NONE");
        /// <summary>
        /// Constant SPEECH for Eac3AtmosDynamicRangeCompressionRf
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeCompressionRf SPEECH = new Eac3AtmosDynamicRangeCompressionRf("SPEECH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AtmosDynamicRangeCompressionRf(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AtmosDynamicRangeCompressionRf FindValue(string value)
        {
            return FindValue<Eac3AtmosDynamicRangeCompressionRf>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AtmosDynamicRangeCompressionRf(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3AtmosDynamicRangeControl.
    /// </summary>
    public class Eac3AtmosDynamicRangeControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for Eac3AtmosDynamicRangeControl
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeControl INITIALIZE_FROM_SOURCE = new Eac3AtmosDynamicRangeControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for Eac3AtmosDynamicRangeControl
        /// </summary>
        public static readonly Eac3AtmosDynamicRangeControl SPECIFIED = new Eac3AtmosDynamicRangeControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AtmosDynamicRangeControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AtmosDynamicRangeControl FindValue(string value)
        {
            return FindValue<Eac3AtmosDynamicRangeControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AtmosDynamicRangeControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3AtmosMeteringMode.
    /// </summary>
    public class Eac3AtmosMeteringMode : ConstantClass
    {

        /// <summary>
        /// Constant ITU_BS_1770_1 for Eac3AtmosMeteringMode
        /// </summary>
        public static readonly Eac3AtmosMeteringMode ITU_BS_1770_1 = new Eac3AtmosMeteringMode("ITU_BS_1770_1");
        /// <summary>
        /// Constant ITU_BS_1770_2 for Eac3AtmosMeteringMode
        /// </summary>
        public static readonly Eac3AtmosMeteringMode ITU_BS_1770_2 = new Eac3AtmosMeteringMode("ITU_BS_1770_2");
        /// <summary>
        /// Constant ITU_BS_1770_3 for Eac3AtmosMeteringMode
        /// </summary>
        public static readonly Eac3AtmosMeteringMode ITU_BS_1770_3 = new Eac3AtmosMeteringMode("ITU_BS_1770_3");
        /// <summary>
        /// Constant ITU_BS_1770_4 for Eac3AtmosMeteringMode
        /// </summary>
        public static readonly Eac3AtmosMeteringMode ITU_BS_1770_4 = new Eac3AtmosMeteringMode("ITU_BS_1770_4");
        /// <summary>
        /// Constant LEQ_A for Eac3AtmosMeteringMode
        /// </summary>
        public static readonly Eac3AtmosMeteringMode LEQ_A = new Eac3AtmosMeteringMode("LEQ_A");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AtmosMeteringMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AtmosMeteringMode FindValue(string value)
        {
            return FindValue<Eac3AtmosMeteringMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AtmosMeteringMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3AtmosStereoDownmix.
    /// </summary>
    public class Eac3AtmosStereoDownmix : ConstantClass
    {

        /// <summary>
        /// Constant DPL2 for Eac3AtmosStereoDownmix
        /// </summary>
        public static readonly Eac3AtmosStereoDownmix DPL2 = new Eac3AtmosStereoDownmix("DPL2");
        /// <summary>
        /// Constant NOT_INDICATED for Eac3AtmosStereoDownmix
        /// </summary>
        public static readonly Eac3AtmosStereoDownmix NOT_INDICATED = new Eac3AtmosStereoDownmix("NOT_INDICATED");
        /// <summary>
        /// Constant STEREO for Eac3AtmosStereoDownmix
        /// </summary>
        public static readonly Eac3AtmosStereoDownmix STEREO = new Eac3AtmosStereoDownmix("STEREO");
        /// <summary>
        /// Constant SURROUND for Eac3AtmosStereoDownmix
        /// </summary>
        public static readonly Eac3AtmosStereoDownmix SURROUND = new Eac3AtmosStereoDownmix("SURROUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AtmosStereoDownmix(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AtmosStereoDownmix FindValue(string value)
        {
            return FindValue<Eac3AtmosStereoDownmix>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AtmosStereoDownmix(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3AtmosSurroundExMode.
    /// </summary>
    public class Eac3AtmosSurroundExMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Eac3AtmosSurroundExMode
        /// </summary>
        public static readonly Eac3AtmosSurroundExMode DISABLED = new Eac3AtmosSurroundExMode("DISABLED");
        /// <summary>
        /// Constant ENABLED for Eac3AtmosSurroundExMode
        /// </summary>
        public static readonly Eac3AtmosSurroundExMode ENABLED = new Eac3AtmosSurroundExMode("ENABLED");
        /// <summary>
        /// Constant NOT_INDICATED for Eac3AtmosSurroundExMode
        /// </summary>
        public static readonly Eac3AtmosSurroundExMode NOT_INDICATED = new Eac3AtmosSurroundExMode("NOT_INDICATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AtmosSurroundExMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AtmosSurroundExMode FindValue(string value)
        {
            return FindValue<Eac3AtmosSurroundExMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AtmosSurroundExMode(string value)
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
    /// Constants used for properties of type EmbeddedTerminateCaptions.
    /// </summary>
    public class EmbeddedTerminateCaptions : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EmbeddedTerminateCaptions
        /// </summary>
        public static readonly EmbeddedTerminateCaptions DISABLED = new EmbeddedTerminateCaptions("DISABLED");
        /// <summary>
        /// Constant END_OF_INPUT for EmbeddedTerminateCaptions
        /// </summary>
        public static readonly EmbeddedTerminateCaptions END_OF_INPUT = new EmbeddedTerminateCaptions("END_OF_INPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmbeddedTerminateCaptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmbeddedTerminateCaptions FindValue(string value)
        {
            return FindValue<EmbeddedTerminateCaptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmbeddedTerminateCaptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EmbeddedTimecodeOverride.
    /// </summary>
    public class EmbeddedTimecodeOverride : ConstantClass
    {

        /// <summary>
        /// Constant NONE for EmbeddedTimecodeOverride
        /// </summary>
        public static readonly EmbeddedTimecodeOverride NONE = new EmbeddedTimecodeOverride("NONE");
        /// <summary>
        /// Constant USE_MDPM for EmbeddedTimecodeOverride
        /// </summary>
        public static readonly EmbeddedTimecodeOverride USE_MDPM = new EmbeddedTimecodeOverride("USE_MDPM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmbeddedTimecodeOverride(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmbeddedTimecodeOverride FindValue(string value)
        {
            return FindValue<EmbeddedTimecodeOverride>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmbeddedTimecodeOverride(string value)
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
    /// Constants used for properties of type FileSourceTimeDeltaUnits.
    /// </summary>
    public class FileSourceTimeDeltaUnits : ConstantClass
    {

        /// <summary>
        /// Constant MILLISECONDS for FileSourceTimeDeltaUnits
        /// </summary>
        public static readonly FileSourceTimeDeltaUnits MILLISECONDS = new FileSourceTimeDeltaUnits("MILLISECONDS");
        /// <summary>
        /// Constant SECONDS for FileSourceTimeDeltaUnits
        /// </summary>
        public static readonly FileSourceTimeDeltaUnits SECONDS = new FileSourceTimeDeltaUnits("SECONDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSourceTimeDeltaUnits(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSourceTimeDeltaUnits FindValue(string value)
        {
            return FindValue<FileSourceTimeDeltaUnits>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSourceTimeDeltaUnits(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FontScript.
    /// </summary>
    public class FontScript : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for FontScript
        /// </summary>
        public static readonly FontScript AUTOMATIC = new FontScript("AUTOMATIC");
        /// <summary>
        /// Constant HANS for FontScript
        /// </summary>
        public static readonly FontScript HANS = new FontScript("HANS");
        /// <summary>
        /// Constant HANT for FontScript
        /// </summary>
        public static readonly FontScript HANT = new FontScript("HANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FontScript(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FontScript FindValue(string value)
        {
            return FindValue<FontScript>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FontScript(string value)
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
        /// Constant AUTO for H264AdaptiveQuantization
        /// </summary>
        public static readonly H264AdaptiveQuantization AUTO = new H264AdaptiveQuantization("AUTO");
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
    /// Constants used for properties of type H264DynamicSubGop.
    /// </summary>
    public class H264DynamicSubGop : ConstantClass
    {

        /// <summary>
        /// Constant ADAPTIVE for H264DynamicSubGop
        /// </summary>
        public static readonly H264DynamicSubGop ADAPTIVE = new H264DynamicSubGop("ADAPTIVE");
        /// <summary>
        /// Constant STATIC for H264DynamicSubGop
        /// </summary>
        public static readonly H264DynamicSubGop STATIC = new H264DynamicSubGop("STATIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264DynamicSubGop(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264DynamicSubGop FindValue(string value)
        {
            return FindValue<H264DynamicSubGop>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264DynamicSubGop(string value)
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
        /// Constant MBAFF for H264FieldEncoding
        /// </summary>
        public static readonly H264FieldEncoding MBAFF = new H264FieldEncoding("MBAFF");
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
        /// Constant FRAMEFORMER for H264FramerateConversionAlgorithm
        /// </summary>
        public static readonly H264FramerateConversionAlgorithm FRAMEFORMER = new H264FramerateConversionAlgorithm("FRAMEFORMER");
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
        /// Constant AUTO for H264GopSizeUnits
        /// </summary>
        public static readonly H264GopSizeUnits AUTO = new H264GopSizeUnits("AUTO");
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
        /// Constant QVBR for H264RateControlMode
        /// </summary>
        public static readonly H264RateControlMode QVBR = new H264RateControlMode("QVBR");
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
    /// Constants used for properties of type H264ScanTypeConversionMode.
    /// </summary>
    public class H264ScanTypeConversionMode : ConstantClass
    {

        /// <summary>
        /// Constant INTERLACED for H264ScanTypeConversionMode
        /// </summary>
        public static readonly H264ScanTypeConversionMode INTERLACED = new H264ScanTypeConversionMode("INTERLACED");
        /// <summary>
        /// Constant INTERLACED_OPTIMIZE for H264ScanTypeConversionMode
        /// </summary>
        public static readonly H264ScanTypeConversionMode INTERLACED_OPTIMIZE = new H264ScanTypeConversionMode("INTERLACED_OPTIMIZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264ScanTypeConversionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264ScanTypeConversionMode FindValue(string value)
        {
            return FindValue<H264ScanTypeConversionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264ScanTypeConversionMode(string value)
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
        /// Constant TRANSITION_DETECTION for H264SceneChangeDetect
        /// </summary>
        public static readonly H264SceneChangeDetect TRANSITION_DETECTION = new H264SceneChangeDetect("TRANSITION_DETECTION");

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
        /// Constant AUTO for H265AdaptiveQuantization
        /// </summary>
        public static readonly H265AdaptiveQuantization AUTO = new H265AdaptiveQuantization("AUTO");
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
    /// Constants used for properties of type H265DynamicSubGop.
    /// </summary>
    public class H265DynamicSubGop : ConstantClass
    {

        /// <summary>
        /// Constant ADAPTIVE for H265DynamicSubGop
        /// </summary>
        public static readonly H265DynamicSubGop ADAPTIVE = new H265DynamicSubGop("ADAPTIVE");
        /// <summary>
        /// Constant STATIC for H265DynamicSubGop
        /// </summary>
        public static readonly H265DynamicSubGop STATIC = new H265DynamicSubGop("STATIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265DynamicSubGop(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265DynamicSubGop FindValue(string value)
        {
            return FindValue<H265DynamicSubGop>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265DynamicSubGop(string value)
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
        /// Constant FRAMEFORMER for H265FramerateConversionAlgorithm
        /// </summary>
        public static readonly H265FramerateConversionAlgorithm FRAMEFORMER = new H265FramerateConversionAlgorithm("FRAMEFORMER");
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
        /// Constant AUTO for H265GopSizeUnits
        /// </summary>
        public static readonly H265GopSizeUnits AUTO = new H265GopSizeUnits("AUTO");
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
        /// Constant QVBR for H265RateControlMode
        /// </summary>
        public static readonly H265RateControlMode QVBR = new H265RateControlMode("QVBR");
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
    /// Constants used for properties of type H265ScanTypeConversionMode.
    /// </summary>
    public class H265ScanTypeConversionMode : ConstantClass
    {

        /// <summary>
        /// Constant INTERLACED for H265ScanTypeConversionMode
        /// </summary>
        public static readonly H265ScanTypeConversionMode INTERLACED = new H265ScanTypeConversionMode("INTERLACED");
        /// <summary>
        /// Constant INTERLACED_OPTIMIZE for H265ScanTypeConversionMode
        /// </summary>
        public static readonly H265ScanTypeConversionMode INTERLACED_OPTIMIZE = new H265ScanTypeConversionMode("INTERLACED_OPTIMIZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265ScanTypeConversionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265ScanTypeConversionMode FindValue(string value)
        {
            return FindValue<H265ScanTypeConversionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265ScanTypeConversionMode(string value)
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
        /// Constant TRANSITION_DETECTION for H265SceneChangeDetect
        /// </summary>
        public static readonly H265SceneChangeDetect TRANSITION_DETECTION = new H265SceneChangeDetect("TRANSITION_DETECTION");

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
    /// Constants used for properties of type HDRToSDRToneMapper.
    /// </summary>
    public class HDRToSDRToneMapper : ConstantClass
    {

        /// <summary>
        /// Constant PRESERVE_DETAILS for HDRToSDRToneMapper
        /// </summary>
        public static readonly HDRToSDRToneMapper PRESERVE_DETAILS = new HDRToSDRToneMapper("PRESERVE_DETAILS");
        /// <summary>
        /// Constant VIBRANT for HDRToSDRToneMapper
        /// </summary>
        public static readonly HDRToSDRToneMapper VIBRANT = new HDRToSDRToneMapper("VIBRANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HDRToSDRToneMapper(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HDRToSDRToneMapper FindValue(string value)
        {
            return FindValue<HDRToSDRToneMapper>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HDRToSDRToneMapper(string value)
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
    /// Constants used for properties of type HlsAudioOnlyContainer.
    /// </summary>
    public class HlsAudioOnlyContainer : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for HlsAudioOnlyContainer
        /// </summary>
        public static readonly HlsAudioOnlyContainer AUTOMATIC = new HlsAudioOnlyContainer("AUTOMATIC");
        /// <summary>
        /// Constant M2TS for HlsAudioOnlyContainer
        /// </summary>
        public static readonly HlsAudioOnlyContainer M2TS = new HlsAudioOnlyContainer("M2TS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsAudioOnlyContainer(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsAudioOnlyContainer FindValue(string value)
        {
            return FindValue<HlsAudioOnlyContainer>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsAudioOnlyContainer(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsAudioOnlyHeader.
    /// </summary>
    public class HlsAudioOnlyHeader : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for HlsAudioOnlyHeader
        /// </summary>
        public static readonly HlsAudioOnlyHeader EXCLUDE = new HlsAudioOnlyHeader("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for HlsAudioOnlyHeader
        /// </summary>
        public static readonly HlsAudioOnlyHeader INCLUDE = new HlsAudioOnlyHeader("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsAudioOnlyHeader(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsAudioOnlyHeader FindValue(string value)
        {
            return FindValue<HlsAudioOnlyHeader>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsAudioOnlyHeader(string value)
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
    /// Constants used for properties of type HlsCaptionSegmentLengthControl.
    /// </summary>
    public class HlsCaptionSegmentLengthControl : ConstantClass
    {

        /// <summary>
        /// Constant LARGE_SEGMENTS for HlsCaptionSegmentLengthControl
        /// </summary>
        public static readonly HlsCaptionSegmentLengthControl LARGE_SEGMENTS = new HlsCaptionSegmentLengthControl("LARGE_SEGMENTS");
        /// <summary>
        /// Constant MATCH_VIDEO for HlsCaptionSegmentLengthControl
        /// </summary>
        public static readonly HlsCaptionSegmentLengthControl MATCH_VIDEO = new HlsCaptionSegmentLengthControl("MATCH_VIDEO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsCaptionSegmentLengthControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsCaptionSegmentLengthControl FindValue(string value)
        {
            return FindValue<HlsCaptionSegmentLengthControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsCaptionSegmentLengthControl(string value)
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
    /// Constants used for properties of type HlsDescriptiveVideoServiceFlag.
    /// </summary>
    public class HlsDescriptiveVideoServiceFlag : ConstantClass
    {

        /// <summary>
        /// Constant DONT_FLAG for HlsDescriptiveVideoServiceFlag
        /// </summary>
        public static readonly HlsDescriptiveVideoServiceFlag DONT_FLAG = new HlsDescriptiveVideoServiceFlag("DONT_FLAG");
        /// <summary>
        /// Constant FLAG for HlsDescriptiveVideoServiceFlag
        /// </summary>
        public static readonly HlsDescriptiveVideoServiceFlag FLAG = new HlsDescriptiveVideoServiceFlag("FLAG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsDescriptiveVideoServiceFlag(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsDescriptiveVideoServiceFlag FindValue(string value)
        {
            return FindValue<HlsDescriptiveVideoServiceFlag>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsDescriptiveVideoServiceFlag(string value)
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
    /// Constants used for properties of type HlsImageBasedTrickPlay.
    /// </summary>
    public class HlsImageBasedTrickPlay : ConstantClass
    {

        /// <summary>
        /// Constant ADVANCED for HlsImageBasedTrickPlay
        /// </summary>
        public static readonly HlsImageBasedTrickPlay ADVANCED = new HlsImageBasedTrickPlay("ADVANCED");
        /// <summary>
        /// Constant NONE for HlsImageBasedTrickPlay
        /// </summary>
        public static readonly HlsImageBasedTrickPlay NONE = new HlsImageBasedTrickPlay("NONE");
        /// <summary>
        /// Constant THUMBNAIL for HlsImageBasedTrickPlay
        /// </summary>
        public static readonly HlsImageBasedTrickPlay THUMBNAIL = new HlsImageBasedTrickPlay("THUMBNAIL");
        /// <summary>
        /// Constant THUMBNAIL_AND_FULLFRAME for HlsImageBasedTrickPlay
        /// </summary>
        public static readonly HlsImageBasedTrickPlay THUMBNAIL_AND_FULLFRAME = new HlsImageBasedTrickPlay("THUMBNAIL_AND_FULLFRAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsImageBasedTrickPlay(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsImageBasedTrickPlay FindValue(string value)
        {
            return FindValue<HlsImageBasedTrickPlay>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsImageBasedTrickPlay(string value)
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
    /// Constants used for properties of type HlsIntervalCadence.
    /// </summary>
    public class HlsIntervalCadence : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW_CUSTOM for HlsIntervalCadence
        /// </summary>
        public static readonly HlsIntervalCadence FOLLOW_CUSTOM = new HlsIntervalCadence("FOLLOW_CUSTOM");
        /// <summary>
        /// Constant FOLLOW_IFRAME for HlsIntervalCadence
        /// </summary>
        public static readonly HlsIntervalCadence FOLLOW_IFRAME = new HlsIntervalCadence("FOLLOW_IFRAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsIntervalCadence(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsIntervalCadence FindValue(string value)
        {
            return FindValue<HlsIntervalCadence>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsIntervalCadence(string value)
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
    /// Constants used for properties of type HlsOfflineEncrypted.
    /// </summary>
    public class HlsOfflineEncrypted : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for HlsOfflineEncrypted
        /// </summary>
        public static readonly HlsOfflineEncrypted DISABLED = new HlsOfflineEncrypted("DISABLED");
        /// <summary>
        /// Constant ENABLED for HlsOfflineEncrypted
        /// </summary>
        public static readonly HlsOfflineEncrypted ENABLED = new HlsOfflineEncrypted("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsOfflineEncrypted(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsOfflineEncrypted FindValue(string value)
        {
            return FindValue<HlsOfflineEncrypted>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsOfflineEncrypted(string value)
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
    /// Constants used for properties of type HlsSegmentLengthControl.
    /// </summary>
    public class HlsSegmentLengthControl : ConstantClass
    {

        /// <summary>
        /// Constant EXACT for HlsSegmentLengthControl
        /// </summary>
        public static readonly HlsSegmentLengthControl EXACT = new HlsSegmentLengthControl("EXACT");
        /// <summary>
        /// Constant GOP_MULTIPLE for HlsSegmentLengthControl
        /// </summary>
        public static readonly HlsSegmentLengthControl GOP_MULTIPLE = new HlsSegmentLengthControl("GOP_MULTIPLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsSegmentLengthControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsSegmentLengthControl FindValue(string value)
        {
            return FindValue<HlsSegmentLengthControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsSegmentLengthControl(string value)
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
    /// Constants used for properties of type HlsTargetDurationCompatibilityMode.
    /// </summary>
    public class HlsTargetDurationCompatibilityMode : ConstantClass
    {

        /// <summary>
        /// Constant LEGACY for HlsTargetDurationCompatibilityMode
        /// </summary>
        public static readonly HlsTargetDurationCompatibilityMode LEGACY = new HlsTargetDurationCompatibilityMode("LEGACY");
        /// <summary>
        /// Constant SPEC_COMPLIANT for HlsTargetDurationCompatibilityMode
        /// </summary>
        public static readonly HlsTargetDurationCompatibilityMode SPEC_COMPLIANT = new HlsTargetDurationCompatibilityMode("SPEC_COMPLIANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsTargetDurationCompatibilityMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsTargetDurationCompatibilityMode FindValue(string value)
        {
            return FindValue<HlsTargetDurationCompatibilityMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsTargetDurationCompatibilityMode(string value)
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
    /// Constants used for properties of type ImscAccessibilitySubs.
    /// </summary>
    public class ImscAccessibilitySubs : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ImscAccessibilitySubs
        /// </summary>
        public static readonly ImscAccessibilitySubs DISABLED = new ImscAccessibilitySubs("DISABLED");
        /// <summary>
        /// Constant ENABLED for ImscAccessibilitySubs
        /// </summary>
        public static readonly ImscAccessibilitySubs ENABLED = new ImscAccessibilitySubs("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImscAccessibilitySubs(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImscAccessibilitySubs FindValue(string value)
        {
            return FindValue<ImscAccessibilitySubs>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImscAccessibilitySubs(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImscStylePassthrough.
    /// </summary>
    public class ImscStylePassthrough : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ImscStylePassthrough
        /// </summary>
        public static readonly ImscStylePassthrough DISABLED = new ImscStylePassthrough("DISABLED");
        /// <summary>
        /// Constant ENABLED for ImscStylePassthrough
        /// </summary>
        public static readonly ImscStylePassthrough ENABLED = new ImscStylePassthrough("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImscStylePassthrough(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImscStylePassthrough FindValue(string value)
        {
            return FindValue<ImscStylePassthrough>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImscStylePassthrough(string value)
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
    /// Constants used for properties of type InputPolicy.
    /// </summary>
    public class InputPolicy : ConstantClass
    {

        /// <summary>
        /// Constant ALLOWED for InputPolicy
        /// </summary>
        public static readonly InputPolicy ALLOWED = new InputPolicy("ALLOWED");
        /// <summary>
        /// Constant DISALLOWED for InputPolicy
        /// </summary>
        public static readonly InputPolicy DISALLOWED = new InputPolicy("DISALLOWED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputPolicy FindValue(string value)
        {
            return FindValue<InputPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputPolicy(string value)
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
    /// Constants used for properties of type InputRotate.
    /// </summary>
    public class InputRotate : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for InputRotate
        /// </summary>
        public static readonly InputRotate AUTO = new InputRotate("AUTO");
        /// <summary>
        /// Constant DEGREE_0 for InputRotate
        /// </summary>
        public static readonly InputRotate DEGREE_0 = new InputRotate("DEGREE_0");
        /// <summary>
        /// Constant DEGREES_180 for InputRotate
        /// </summary>
        public static readonly InputRotate DEGREES_180 = new InputRotate("DEGREES_180");
        /// <summary>
        /// Constant DEGREES_270 for InputRotate
        /// </summary>
        public static readonly InputRotate DEGREES_270 = new InputRotate("DEGREES_270");
        /// <summary>
        /// Constant DEGREES_90 for InputRotate
        /// </summary>
        public static readonly InputRotate DEGREES_90 = new InputRotate("DEGREES_90");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputRotate(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputRotate FindValue(string value)
        {
            return FindValue<InputRotate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputRotate(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputSampleRange.
    /// </summary>
    public class InputSampleRange : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW for InputSampleRange
        /// </summary>
        public static readonly InputSampleRange FOLLOW = new InputSampleRange("FOLLOW");
        /// <summary>
        /// Constant FULL_RANGE for InputSampleRange
        /// </summary>
        public static readonly InputSampleRange FULL_RANGE = new InputSampleRange("FULL_RANGE");
        /// <summary>
        /// Constant LIMITED_RANGE for InputSampleRange
        /// </summary>
        public static readonly InputSampleRange LIMITED_RANGE = new InputSampleRange("LIMITED_RANGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputSampleRange(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputSampleRange FindValue(string value)
        {
            return FindValue<InputSampleRange>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputSampleRange(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputScanType.
    /// </summary>
    public class InputScanType : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for InputScanType
        /// </summary>
        public static readonly InputScanType AUTO = new InputScanType("AUTO");
        /// <summary>
        /// Constant PSF for InputScanType
        /// </summary>
        public static readonly InputScanType PSF = new InputScanType("PSF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputScanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputScanType FindValue(string value)
        {
            return FindValue<InputScanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputScanType(string value)
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
    /// Constants used for properties of type JobPhase.
    /// </summary>
    public class JobPhase : ConstantClass
    {

        /// <summary>
        /// Constant PROBING for JobPhase
        /// </summary>
        public static readonly JobPhase PROBING = new JobPhase("PROBING");
        /// <summary>
        /// Constant TRANSCODING for JobPhase
        /// </summary>
        public static readonly JobPhase TRANSCODING = new JobPhase("TRANSCODING");
        /// <summary>
        /// Constant UPLOADING for JobPhase
        /// </summary>
        public static readonly JobPhase UPLOADING = new JobPhase("UPLOADING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobPhase(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobPhase FindValue(string value)
        {
            return FindValue<JobPhase>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobPhase(string value)
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
        /// Constant SRP for LanguageCode
        /// </summary>
        public static readonly LanguageCode SRP = new LanguageCode("SRP");
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
    /// Constants used for properties of type M2tsAudioDuration.
    /// </summary>
    public class M2tsAudioDuration : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT_CODEC_DURATION for M2tsAudioDuration
        /// </summary>
        public static readonly M2tsAudioDuration DEFAULT_CODEC_DURATION = new M2tsAudioDuration("DEFAULT_CODEC_DURATION");
        /// <summary>
        /// Constant MATCH_VIDEO_DURATION for M2tsAudioDuration
        /// </summary>
        public static readonly M2tsAudioDuration MATCH_VIDEO_DURATION = new M2tsAudioDuration("MATCH_VIDEO_DURATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsAudioDuration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsAudioDuration FindValue(string value)
        {
            return FindValue<M2tsAudioDuration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsAudioDuration(string value)
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
    /// Constants used for properties of type M2tsDataPtsControl.
    /// </summary>
    public class M2tsDataPtsControl : ConstantClass
    {

        /// <summary>
        /// Constant ALIGN_TO_VIDEO for M2tsDataPtsControl
        /// </summary>
        public static readonly M2tsDataPtsControl ALIGN_TO_VIDEO = new M2tsDataPtsControl("ALIGN_TO_VIDEO");
        /// <summary>
        /// Constant AUTO for M2tsDataPtsControl
        /// </summary>
        public static readonly M2tsDataPtsControl AUTO = new M2tsDataPtsControl("AUTO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsDataPtsControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsDataPtsControl FindValue(string value)
        {
            return FindValue<M2tsDataPtsControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsDataPtsControl(string value)
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
    /// Constants used for properties of type M2tsForceTsVideoEbpOrder.
    /// </summary>
    public class M2tsForceTsVideoEbpOrder : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for M2tsForceTsVideoEbpOrder
        /// </summary>
        public static readonly M2tsForceTsVideoEbpOrder DEFAULT = new M2tsForceTsVideoEbpOrder("DEFAULT");
        /// <summary>
        /// Constant FORCE for M2tsForceTsVideoEbpOrder
        /// </summary>
        public static readonly M2tsForceTsVideoEbpOrder FORCE = new M2tsForceTsVideoEbpOrder("FORCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsForceTsVideoEbpOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsForceTsVideoEbpOrder FindValue(string value)
        {
            return FindValue<M2tsForceTsVideoEbpOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsForceTsVideoEbpOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsKlvMetadata.
    /// </summary>
    public class M2tsKlvMetadata : ConstantClass
    {

        /// <summary>
        /// Constant NONE for M2tsKlvMetadata
        /// </summary>
        public static readonly M2tsKlvMetadata NONE = new M2tsKlvMetadata("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for M2tsKlvMetadata
        /// </summary>
        public static readonly M2tsKlvMetadata PASSTHROUGH = new M2tsKlvMetadata("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsKlvMetadata(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsKlvMetadata FindValue(string value)
        {
            return FindValue<M2tsKlvMetadata>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsKlvMetadata(string value)
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
    /// Constants used for properties of type M3u8AudioDuration.
    /// </summary>
    public class M3u8AudioDuration : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT_CODEC_DURATION for M3u8AudioDuration
        /// </summary>
        public static readonly M3u8AudioDuration DEFAULT_CODEC_DURATION = new M3u8AudioDuration("DEFAULT_CODEC_DURATION");
        /// <summary>
        /// Constant MATCH_VIDEO_DURATION for M3u8AudioDuration
        /// </summary>
        public static readonly M3u8AudioDuration MATCH_VIDEO_DURATION = new M3u8AudioDuration("MATCH_VIDEO_DURATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M3u8AudioDuration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M3u8AudioDuration FindValue(string value)
        {
            return FindValue<M3u8AudioDuration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M3u8AudioDuration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M3u8DataPtsControl.
    /// </summary>
    public class M3u8DataPtsControl : ConstantClass
    {

        /// <summary>
        /// Constant ALIGN_TO_VIDEO for M3u8DataPtsControl
        /// </summary>
        public static readonly M3u8DataPtsControl ALIGN_TO_VIDEO = new M3u8DataPtsControl("ALIGN_TO_VIDEO");
        /// <summary>
        /// Constant AUTO for M3u8DataPtsControl
        /// </summary>
        public static readonly M3u8DataPtsControl AUTO = new M3u8DataPtsControl("AUTO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M3u8DataPtsControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M3u8DataPtsControl FindValue(string value)
        {
            return FindValue<M3u8DataPtsControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M3u8DataPtsControl(string value)
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
    /// Constants used for properties of type MotionImageInsertionMode.
    /// </summary>
    public class MotionImageInsertionMode : ConstantClass
    {

        /// <summary>
        /// Constant MOV for MotionImageInsertionMode
        /// </summary>
        public static readonly MotionImageInsertionMode MOV = new MotionImageInsertionMode("MOV");
        /// <summary>
        /// Constant PNG for MotionImageInsertionMode
        /// </summary>
        public static readonly MotionImageInsertionMode PNG = new MotionImageInsertionMode("PNG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MotionImageInsertionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MotionImageInsertionMode FindValue(string value)
        {
            return FindValue<MotionImageInsertionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MotionImageInsertionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MotionImagePlayback.
    /// </summary>
    public class MotionImagePlayback : ConstantClass
    {

        /// <summary>
        /// Constant ONCE for MotionImagePlayback
        /// </summary>
        public static readonly MotionImagePlayback ONCE = new MotionImagePlayback("ONCE");
        /// <summary>
        /// Constant REPEAT for MotionImagePlayback
        /// </summary>
        public static readonly MotionImagePlayback REPEAT = new MotionImagePlayback("REPEAT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MotionImagePlayback(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MotionImagePlayback FindValue(string value)
        {
            return FindValue<MotionImagePlayback>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MotionImagePlayback(string value)
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
    /// Constants used for properties of type Mp3RateControlMode.
    /// </summary>
    public class Mp3RateControlMode : ConstantClass
    {

        /// <summary>
        /// Constant CBR for Mp3RateControlMode
        /// </summary>
        public static readonly Mp3RateControlMode CBR = new Mp3RateControlMode("CBR");
        /// <summary>
        /// Constant VBR for Mp3RateControlMode
        /// </summary>
        public static readonly Mp3RateControlMode VBR = new Mp3RateControlMode("VBR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mp3RateControlMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mp3RateControlMode FindValue(string value)
        {
            return FindValue<Mp3RateControlMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mp3RateControlMode(string value)
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
    /// Constants used for properties of type MpdAccessibilityCaptionHints.
    /// </summary>
    public class MpdAccessibilityCaptionHints : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for MpdAccessibilityCaptionHints
        /// </summary>
        public static readonly MpdAccessibilityCaptionHints EXCLUDE = new MpdAccessibilityCaptionHints("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for MpdAccessibilityCaptionHints
        /// </summary>
        public static readonly MpdAccessibilityCaptionHints INCLUDE = new MpdAccessibilityCaptionHints("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MpdAccessibilityCaptionHints(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MpdAccessibilityCaptionHints FindValue(string value)
        {
            return FindValue<MpdAccessibilityCaptionHints>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MpdAccessibilityCaptionHints(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MpdAudioDuration.
    /// </summary>
    public class MpdAudioDuration : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT_CODEC_DURATION for MpdAudioDuration
        /// </summary>
        public static readonly MpdAudioDuration DEFAULT_CODEC_DURATION = new MpdAudioDuration("DEFAULT_CODEC_DURATION");
        /// <summary>
        /// Constant MATCH_VIDEO_DURATION for MpdAudioDuration
        /// </summary>
        public static readonly MpdAudioDuration MATCH_VIDEO_DURATION = new MpdAudioDuration("MATCH_VIDEO_DURATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MpdAudioDuration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MpdAudioDuration FindValue(string value)
        {
            return FindValue<MpdAudioDuration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MpdAudioDuration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MpdCaptionContainerType.
    /// </summary>
    public class MpdCaptionContainerType : ConstantClass
    {

        /// <summary>
        /// Constant FRAGMENTED_MP4 for MpdCaptionContainerType
        /// </summary>
        public static readonly MpdCaptionContainerType FRAGMENTED_MP4 = new MpdCaptionContainerType("FRAGMENTED_MP4");
        /// <summary>
        /// Constant RAW for MpdCaptionContainerType
        /// </summary>
        public static readonly MpdCaptionContainerType RAW = new MpdCaptionContainerType("RAW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MpdCaptionContainerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MpdCaptionContainerType FindValue(string value)
        {
            return FindValue<MpdCaptionContainerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MpdCaptionContainerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MpdKlvMetadata.
    /// </summary>
    public class MpdKlvMetadata : ConstantClass
    {

        /// <summary>
        /// Constant NONE for MpdKlvMetadata
        /// </summary>
        public static readonly MpdKlvMetadata NONE = new MpdKlvMetadata("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for MpdKlvMetadata
        /// </summary>
        public static readonly MpdKlvMetadata PASSTHROUGH = new MpdKlvMetadata("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MpdKlvMetadata(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MpdKlvMetadata FindValue(string value)
        {
            return FindValue<MpdKlvMetadata>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MpdKlvMetadata(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MpdManifestMetadataSignaling.
    /// </summary>
    public class MpdManifestMetadataSignaling : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for MpdManifestMetadataSignaling
        /// </summary>
        public static readonly MpdManifestMetadataSignaling DISABLED = new MpdManifestMetadataSignaling("DISABLED");
        /// <summary>
        /// Constant ENABLED for MpdManifestMetadataSignaling
        /// </summary>
        public static readonly MpdManifestMetadataSignaling ENABLED = new MpdManifestMetadataSignaling("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MpdManifestMetadataSignaling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MpdManifestMetadataSignaling FindValue(string value)
        {
            return FindValue<MpdManifestMetadataSignaling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MpdManifestMetadataSignaling(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MpdScte35Esam.
    /// </summary>
    public class MpdScte35Esam : ConstantClass
    {

        /// <summary>
        /// Constant INSERT for MpdScte35Esam
        /// </summary>
        public static readonly MpdScte35Esam INSERT = new MpdScte35Esam("INSERT");
        /// <summary>
        /// Constant NONE for MpdScte35Esam
        /// </summary>
        public static readonly MpdScte35Esam NONE = new MpdScte35Esam("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MpdScte35Esam(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MpdScte35Esam FindValue(string value)
        {
            return FindValue<MpdScte35Esam>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MpdScte35Esam(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MpdScte35Source.
    /// </summary>
    public class MpdScte35Source : ConstantClass
    {

        /// <summary>
        /// Constant NONE for MpdScte35Source
        /// </summary>
        public static readonly MpdScte35Source NONE = new MpdScte35Source("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for MpdScte35Source
        /// </summary>
        public static readonly MpdScte35Source PASSTHROUGH = new MpdScte35Source("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MpdScte35Source(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MpdScte35Source FindValue(string value)
        {
            return FindValue<MpdScte35Source>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MpdScte35Source(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MpdTimedMetadata.
    /// </summary>
    public class MpdTimedMetadata : ConstantClass
    {

        /// <summary>
        /// Constant NONE for MpdTimedMetadata
        /// </summary>
        public static readonly MpdTimedMetadata NONE = new MpdTimedMetadata("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for MpdTimedMetadata
        /// </summary>
        public static readonly MpdTimedMetadata PASSTHROUGH = new MpdTimedMetadata("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MpdTimedMetadata(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MpdTimedMetadata FindValue(string value)
        {
            return FindValue<MpdTimedMetadata>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MpdTimedMetadata(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MpdTimedMetadataBoxVersion.
    /// </summary>
    public class MpdTimedMetadataBoxVersion : ConstantClass
    {

        /// <summary>
        /// Constant VERSION_0 for MpdTimedMetadataBoxVersion
        /// </summary>
        public static readonly MpdTimedMetadataBoxVersion VERSION_0 = new MpdTimedMetadataBoxVersion("VERSION_0");
        /// <summary>
        /// Constant VERSION_1 for MpdTimedMetadataBoxVersion
        /// </summary>
        public static readonly MpdTimedMetadataBoxVersion VERSION_1 = new MpdTimedMetadataBoxVersion("VERSION_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MpdTimedMetadataBoxVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MpdTimedMetadataBoxVersion FindValue(string value)
        {
            return FindValue<MpdTimedMetadataBoxVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MpdTimedMetadataBoxVersion(string value)
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
    /// Constants used for properties of type Mpeg2DynamicSubGop.
    /// </summary>
    public class Mpeg2DynamicSubGop : ConstantClass
    {

        /// <summary>
        /// Constant ADAPTIVE for Mpeg2DynamicSubGop
        /// </summary>
        public static readonly Mpeg2DynamicSubGop ADAPTIVE = new Mpeg2DynamicSubGop("ADAPTIVE");
        /// <summary>
        /// Constant STATIC for Mpeg2DynamicSubGop
        /// </summary>
        public static readonly Mpeg2DynamicSubGop STATIC = new Mpeg2DynamicSubGop("STATIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2DynamicSubGop(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2DynamicSubGop FindValue(string value)
        {
            return FindValue<Mpeg2DynamicSubGop>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2DynamicSubGop(string value)
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
        /// Constant FRAMEFORMER for Mpeg2FramerateConversionAlgorithm
        /// </summary>
        public static readonly Mpeg2FramerateConversionAlgorithm FRAMEFORMER = new Mpeg2FramerateConversionAlgorithm("FRAMEFORMER");
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
    /// Constants used for properties of type Mpeg2ScanTypeConversionMode.
    /// </summary>
    public class Mpeg2ScanTypeConversionMode : ConstantClass
    {

        /// <summary>
        /// Constant INTERLACED for Mpeg2ScanTypeConversionMode
        /// </summary>
        public static readonly Mpeg2ScanTypeConversionMode INTERLACED = new Mpeg2ScanTypeConversionMode("INTERLACED");
        /// <summary>
        /// Constant INTERLACED_OPTIMIZE for Mpeg2ScanTypeConversionMode
        /// </summary>
        public static readonly Mpeg2ScanTypeConversionMode INTERLACED_OPTIMIZE = new Mpeg2ScanTypeConversionMode("INTERLACED_OPTIMIZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2ScanTypeConversionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2ScanTypeConversionMode FindValue(string value)
        {
            return FindValue<Mpeg2ScanTypeConversionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2ScanTypeConversionMode(string value)
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
    /// Constants used for properties of type MsSmoothFragmentLengthControl.
    /// </summary>
    public class MsSmoothFragmentLengthControl : ConstantClass
    {

        /// <summary>
        /// Constant EXACT for MsSmoothFragmentLengthControl
        /// </summary>
        public static readonly MsSmoothFragmentLengthControl EXACT = new MsSmoothFragmentLengthControl("EXACT");
        /// <summary>
        /// Constant GOP_MULTIPLE for MsSmoothFragmentLengthControl
        /// </summary>
        public static readonly MsSmoothFragmentLengthControl GOP_MULTIPLE = new MsSmoothFragmentLengthControl("GOP_MULTIPLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MsSmoothFragmentLengthControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MsSmoothFragmentLengthControl FindValue(string value)
        {
            return FindValue<MsSmoothFragmentLengthControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MsSmoothFragmentLengthControl(string value)
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
    /// Constants used for properties of type MxfAfdSignaling.
    /// </summary>
    public class MxfAfdSignaling : ConstantClass
    {

        /// <summary>
        /// Constant COPY_FROM_VIDEO for MxfAfdSignaling
        /// </summary>
        public static readonly MxfAfdSignaling COPY_FROM_VIDEO = new MxfAfdSignaling("COPY_FROM_VIDEO");
        /// <summary>
        /// Constant NO_COPY for MxfAfdSignaling
        /// </summary>
        public static readonly MxfAfdSignaling NO_COPY = new MxfAfdSignaling("NO_COPY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MxfAfdSignaling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MxfAfdSignaling FindValue(string value)
        {
            return FindValue<MxfAfdSignaling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MxfAfdSignaling(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MxfProfile.
    /// </summary>
    public class MxfProfile : ConstantClass
    {

        /// <summary>
        /// Constant D_10 for MxfProfile
        /// </summary>
        public static readonly MxfProfile D_10 = new MxfProfile("D_10");
        /// <summary>
        /// Constant OP1A for MxfProfile
        /// </summary>
        public static readonly MxfProfile OP1A = new MxfProfile("OP1A");
        /// <summary>
        /// Constant XAVC for MxfProfile
        /// </summary>
        public static readonly MxfProfile XAVC = new MxfProfile("XAVC");
        /// <summary>
        /// Constant XDCAM for MxfProfile
        /// </summary>
        public static readonly MxfProfile XDCAM = new MxfProfile("XDCAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MxfProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MxfProfile FindValue(string value)
        {
            return FindValue<MxfProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MxfProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MxfXavcDurationMode.
    /// </summary>
    public class MxfXavcDurationMode : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW_ANY_DURATION for MxfXavcDurationMode
        /// </summary>
        public static readonly MxfXavcDurationMode ALLOW_ANY_DURATION = new MxfXavcDurationMode("ALLOW_ANY_DURATION");
        /// <summary>
        /// Constant DROP_FRAMES_FOR_COMPLIANCE for MxfXavcDurationMode
        /// </summary>
        public static readonly MxfXavcDurationMode DROP_FRAMES_FOR_COMPLIANCE = new MxfXavcDurationMode("DROP_FRAMES_FOR_COMPLIANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MxfXavcDurationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MxfXavcDurationMode FindValue(string value)
        {
            return FindValue<MxfXavcDurationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MxfXavcDurationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NielsenActiveWatermarkProcessType.
    /// </summary>
    public class NielsenActiveWatermarkProcessType : ConstantClass
    {

        /// <summary>
        /// Constant CBET for NielsenActiveWatermarkProcessType
        /// </summary>
        public static readonly NielsenActiveWatermarkProcessType CBET = new NielsenActiveWatermarkProcessType("CBET");
        /// <summary>
        /// Constant NAES2_AND_NW for NielsenActiveWatermarkProcessType
        /// </summary>
        public static readonly NielsenActiveWatermarkProcessType NAES2_AND_NW = new NielsenActiveWatermarkProcessType("NAES2_AND_NW");
        /// <summary>
        /// Constant NAES2_AND_NW_AND_CBET for NielsenActiveWatermarkProcessType
        /// </summary>
        public static readonly NielsenActiveWatermarkProcessType NAES2_AND_NW_AND_CBET = new NielsenActiveWatermarkProcessType("NAES2_AND_NW_AND_CBET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NielsenActiveWatermarkProcessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NielsenActiveWatermarkProcessType FindValue(string value)
        {
            return FindValue<NielsenActiveWatermarkProcessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NielsenActiveWatermarkProcessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NielsenSourceWatermarkStatusType.
    /// </summary>
    public class NielsenSourceWatermarkStatusType : ConstantClass
    {

        /// <summary>
        /// Constant CLEAN for NielsenSourceWatermarkStatusType
        /// </summary>
        public static readonly NielsenSourceWatermarkStatusType CLEAN = new NielsenSourceWatermarkStatusType("CLEAN");
        /// <summary>
        /// Constant WATERMARKED for NielsenSourceWatermarkStatusType
        /// </summary>
        public static readonly NielsenSourceWatermarkStatusType WATERMARKED = new NielsenSourceWatermarkStatusType("WATERMARKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NielsenSourceWatermarkStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NielsenSourceWatermarkStatusType FindValue(string value)
        {
            return FindValue<NielsenSourceWatermarkStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NielsenSourceWatermarkStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NielsenUniqueTicPerAudioTrackType.
    /// </summary>
    public class NielsenUniqueTicPerAudioTrackType : ConstantClass
    {

        /// <summary>
        /// Constant RESERVE_UNIQUE_TICS_PER_TRACK for NielsenUniqueTicPerAudioTrackType
        /// </summary>
        public static readonly NielsenUniqueTicPerAudioTrackType RESERVE_UNIQUE_TICS_PER_TRACK = new NielsenUniqueTicPerAudioTrackType("RESERVE_UNIQUE_TICS_PER_TRACK");
        /// <summary>
        /// Constant SAME_TICS_PER_TRACK for NielsenUniqueTicPerAudioTrackType
        /// </summary>
        public static readonly NielsenUniqueTicPerAudioTrackType SAME_TICS_PER_TRACK = new NielsenUniqueTicPerAudioTrackType("SAME_TICS_PER_TRACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NielsenUniqueTicPerAudioTrackType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NielsenUniqueTicPerAudioTrackType FindValue(string value)
        {
            return FindValue<NielsenUniqueTicPerAudioTrackType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NielsenUniqueTicPerAudioTrackType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NoiseFilterPostTemporalSharpening.
    /// </summary>
    public class NoiseFilterPostTemporalSharpening : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for NoiseFilterPostTemporalSharpening
        /// </summary>
        public static readonly NoiseFilterPostTemporalSharpening AUTO = new NoiseFilterPostTemporalSharpening("AUTO");
        /// <summary>
        /// Constant DISABLED for NoiseFilterPostTemporalSharpening
        /// </summary>
        public static readonly NoiseFilterPostTemporalSharpening DISABLED = new NoiseFilterPostTemporalSharpening("DISABLED");
        /// <summary>
        /// Constant ENABLED for NoiseFilterPostTemporalSharpening
        /// </summary>
        public static readonly NoiseFilterPostTemporalSharpening ENABLED = new NoiseFilterPostTemporalSharpening("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NoiseFilterPostTemporalSharpening(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NoiseFilterPostTemporalSharpening FindValue(string value)
        {
            return FindValue<NoiseFilterPostTemporalSharpening>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NoiseFilterPostTemporalSharpening(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NoiseFilterPostTemporalSharpeningStrength.
    /// </summary>
    public class NoiseFilterPostTemporalSharpeningStrength : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for NoiseFilterPostTemporalSharpeningStrength
        /// </summary>
        public static readonly NoiseFilterPostTemporalSharpeningStrength HIGH = new NoiseFilterPostTemporalSharpeningStrength("HIGH");
        /// <summary>
        /// Constant LOW for NoiseFilterPostTemporalSharpeningStrength
        /// </summary>
        public static readonly NoiseFilterPostTemporalSharpeningStrength LOW = new NoiseFilterPostTemporalSharpeningStrength("LOW");
        /// <summary>
        /// Constant MEDIUM for NoiseFilterPostTemporalSharpeningStrength
        /// </summary>
        public static readonly NoiseFilterPostTemporalSharpeningStrength MEDIUM = new NoiseFilterPostTemporalSharpeningStrength("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NoiseFilterPostTemporalSharpeningStrength(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NoiseFilterPostTemporalSharpeningStrength FindValue(string value)
        {
            return FindValue<NoiseFilterPostTemporalSharpeningStrength>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NoiseFilterPostTemporalSharpeningStrength(string value)
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
        /// Constant TEMPORAL for NoiseReducerFilter
        /// </summary>
        public static readonly NoiseReducerFilter TEMPORAL = new NoiseReducerFilter("TEMPORAL");

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
    /// Constants used for properties of type PadVideo.
    /// </summary>
    public class PadVideo : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for PadVideo
        /// </summary>
        public static readonly PadVideo BLACK = new PadVideo("BLACK");
        /// <summary>
        /// Constant DISABLED for PadVideo
        /// </summary>
        public static readonly PadVideo DISABLED = new PadVideo("DISABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PadVideo(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PadVideo FindValue(string value)
        {
            return FindValue<PadVideo>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PadVideo(string value)
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
    /// Constants used for properties of type PricingPlan.
    /// </summary>
    public class PricingPlan : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for PricingPlan
        /// </summary>
        public static readonly PricingPlan ON_DEMAND = new PricingPlan("ON_DEMAND");
        /// <summary>
        /// Constant RESERVED for PricingPlan
        /// </summary>
        public static readonly PricingPlan RESERVED = new PricingPlan("RESERVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PricingPlan(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PricingPlan FindValue(string value)
        {
            return FindValue<PricingPlan>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PricingPlan(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProresChromaSampling.
    /// </summary>
    public class ProresChromaSampling : ConstantClass
    {

        /// <summary>
        /// Constant PRESERVE_444_SAMPLING for ProresChromaSampling
        /// </summary>
        public static readonly ProresChromaSampling PRESERVE_444_SAMPLING = new ProresChromaSampling("PRESERVE_444_SAMPLING");
        /// <summary>
        /// Constant SUBSAMPLE_TO_422 for ProresChromaSampling
        /// </summary>
        public static readonly ProresChromaSampling SUBSAMPLE_TO_422 = new ProresChromaSampling("SUBSAMPLE_TO_422");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProresChromaSampling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProresChromaSampling FindValue(string value)
        {
            return FindValue<ProresChromaSampling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProresChromaSampling(string value)
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
        /// Constant APPLE_PRORES_4444 for ProresCodecProfile
        /// </summary>
        public static readonly ProresCodecProfile APPLE_PRORES_4444 = new ProresCodecProfile("APPLE_PRORES_4444");
        /// <summary>
        /// Constant APPLE_PRORES_4444_XQ for ProresCodecProfile
        /// </summary>
        public static readonly ProresCodecProfile APPLE_PRORES_4444_XQ = new ProresCodecProfile("APPLE_PRORES_4444_XQ");

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
        /// Constant FRAMEFORMER for ProresFramerateConversionAlgorithm
        /// </summary>
        public static readonly ProresFramerateConversionAlgorithm FRAMEFORMER = new ProresFramerateConversionAlgorithm("FRAMEFORMER");
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
    /// Constants used for properties of type ProresScanTypeConversionMode.
    /// </summary>
    public class ProresScanTypeConversionMode : ConstantClass
    {

        /// <summary>
        /// Constant INTERLACED for ProresScanTypeConversionMode
        /// </summary>
        public static readonly ProresScanTypeConversionMode INTERLACED = new ProresScanTypeConversionMode("INTERLACED");
        /// <summary>
        /// Constant INTERLACED_OPTIMIZE for ProresScanTypeConversionMode
        /// </summary>
        public static readonly ProresScanTypeConversionMode INTERLACED_OPTIMIZE = new ProresScanTypeConversionMode("INTERLACED_OPTIMIZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProresScanTypeConversionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProresScanTypeConversionMode FindValue(string value)
        {
            return FindValue<ProresScanTypeConversionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProresScanTypeConversionMode(string value)
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
    /// Constants used for properties of type RenewalType.
    /// </summary>
    public class RenewalType : ConstantClass
    {

        /// <summary>
        /// Constant AUTO_RENEW for RenewalType
        /// </summary>
        public static readonly RenewalType AUTO_RENEW = new RenewalType("AUTO_RENEW");
        /// <summary>
        /// Constant EXPIRE for RenewalType
        /// </summary>
        public static readonly RenewalType EXPIRE = new RenewalType("EXPIRE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RenewalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RenewalType FindValue(string value)
        {
            return FindValue<RenewalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RenewalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequiredFlag.
    /// </summary>
    public class RequiredFlag : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for RequiredFlag
        /// </summary>
        public static readonly RequiredFlag DISABLED = new RequiredFlag("DISABLED");
        /// <summary>
        /// Constant ENABLED for RequiredFlag
        /// </summary>
        public static readonly RequiredFlag ENABLED = new RequiredFlag("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequiredFlag(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequiredFlag FindValue(string value)
        {
            return FindValue<RequiredFlag>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequiredFlag(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservationPlanStatus.
    /// </summary>
    public class ReservationPlanStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ReservationPlanStatus
        /// </summary>
        public static readonly ReservationPlanStatus ACTIVE = new ReservationPlanStatus("ACTIVE");
        /// <summary>
        /// Constant EXPIRED for ReservationPlanStatus
        /// </summary>
        public static readonly ReservationPlanStatus EXPIRED = new ReservationPlanStatus("EXPIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservationPlanStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservationPlanStatus FindValue(string value)
        {
            return FindValue<ReservationPlanStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservationPlanStatus(string value)
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
    /// Constants used for properties of type RuleType.
    /// </summary>
    public class RuleType : ConstantClass
    {

        /// <summary>
        /// Constant ALLOWED_RENDITIONS for RuleType
        /// </summary>
        public static readonly RuleType ALLOWED_RENDITIONS = new RuleType("ALLOWED_RENDITIONS");
        /// <summary>
        /// Constant FORCE_INCLUDE_RENDITIONS for RuleType
        /// </summary>
        public static readonly RuleType FORCE_INCLUDE_RENDITIONS = new RuleType("FORCE_INCLUDE_RENDITIONS");
        /// <summary>
        /// Constant MIN_BOTTOM_RENDITION_SIZE for RuleType
        /// </summary>
        public static readonly RuleType MIN_BOTTOM_RENDITION_SIZE = new RuleType("MIN_BOTTOM_RENDITION_SIZE");
        /// <summary>
        /// Constant MIN_TOP_RENDITION_SIZE for RuleType
        /// </summary>
        public static readonly RuleType MIN_TOP_RENDITION_SIZE = new RuleType("MIN_TOP_RENDITION_SIZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleType FindValue(string value)
        {
            return FindValue<RuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3ObjectCannedAcl.
    /// </summary>
    public class S3ObjectCannedAcl : ConstantClass
    {

        /// <summary>
        /// Constant AUTHENTICATED_READ for S3ObjectCannedAcl
        /// </summary>
        public static readonly S3ObjectCannedAcl AUTHENTICATED_READ = new S3ObjectCannedAcl("AUTHENTICATED_READ");
        /// <summary>
        /// Constant BUCKET_OWNER_FULL_CONTROL for S3ObjectCannedAcl
        /// </summary>
        public static readonly S3ObjectCannedAcl BUCKET_OWNER_FULL_CONTROL = new S3ObjectCannedAcl("BUCKET_OWNER_FULL_CONTROL");
        /// <summary>
        /// Constant BUCKET_OWNER_READ for S3ObjectCannedAcl
        /// </summary>
        public static readonly S3ObjectCannedAcl BUCKET_OWNER_READ = new S3ObjectCannedAcl("BUCKET_OWNER_READ");
        /// <summary>
        /// Constant PUBLIC_READ for S3ObjectCannedAcl
        /// </summary>
        public static readonly S3ObjectCannedAcl PUBLIC_READ = new S3ObjectCannedAcl("PUBLIC_READ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3ObjectCannedAcl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3ObjectCannedAcl FindValue(string value)
        {
            return FindValue<S3ObjectCannedAcl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3ObjectCannedAcl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3ServerSideEncryptionType.
    /// </summary>
    public class S3ServerSideEncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant SERVER_SIDE_ENCRYPTION_KMS for S3ServerSideEncryptionType
        /// </summary>
        public static readonly S3ServerSideEncryptionType SERVER_SIDE_ENCRYPTION_KMS = new S3ServerSideEncryptionType("SERVER_SIDE_ENCRYPTION_KMS");
        /// <summary>
        /// Constant SERVER_SIDE_ENCRYPTION_S3 for S3ServerSideEncryptionType
        /// </summary>
        public static readonly S3ServerSideEncryptionType SERVER_SIDE_ENCRYPTION_S3 = new S3ServerSideEncryptionType("SERVER_SIDE_ENCRYPTION_S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3ServerSideEncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3ServerSideEncryptionType FindValue(string value)
        {
            return FindValue<S3ServerSideEncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3ServerSideEncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SampleRangeConversion.
    /// </summary>
    public class SampleRangeConversion : ConstantClass
    {

        /// <summary>
        /// Constant LIMITED_RANGE_CLIP for SampleRangeConversion
        /// </summary>
        public static readonly SampleRangeConversion LIMITED_RANGE_CLIP = new SampleRangeConversion("LIMITED_RANGE_CLIP");
        /// <summary>
        /// Constant LIMITED_RANGE_SQUEEZE for SampleRangeConversion
        /// </summary>
        public static readonly SampleRangeConversion LIMITED_RANGE_SQUEEZE = new SampleRangeConversion("LIMITED_RANGE_SQUEEZE");
        /// <summary>
        /// Constant NONE for SampleRangeConversion
        /// </summary>
        public static readonly SampleRangeConversion NONE = new SampleRangeConversion("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SampleRangeConversion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SampleRangeConversion FindValue(string value)
        {
            return FindValue<SampleRangeConversion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SampleRangeConversion(string value)
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
        /// Constant FRAMERATE_25 for SccDestinationFramerate
        /// </summary>
        public static readonly SccDestinationFramerate FRAMERATE_25 = new SccDestinationFramerate("FRAMERATE_25");
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
    /// Constants used for properties of type SimulateReservedQueue.
    /// </summary>
    public class SimulateReservedQueue : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for SimulateReservedQueue
        /// </summary>
        public static readonly SimulateReservedQueue DISABLED = new SimulateReservedQueue("DISABLED");
        /// <summary>
        /// Constant ENABLED for SimulateReservedQueue
        /// </summary>
        public static readonly SimulateReservedQueue ENABLED = new SimulateReservedQueue("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SimulateReservedQueue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SimulateReservedQueue FindValue(string value)
        {
            return FindValue<SimulateReservedQueue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SimulateReservedQueue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SrtStylePassthrough.
    /// </summary>
    public class SrtStylePassthrough : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for SrtStylePassthrough
        /// </summary>
        public static readonly SrtStylePassthrough DISABLED = new SrtStylePassthrough("DISABLED");
        /// <summary>
        /// Constant ENABLED for SrtStylePassthrough
        /// </summary>
        public static readonly SrtStylePassthrough ENABLED = new SrtStylePassthrough("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SrtStylePassthrough(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SrtStylePassthrough FindValue(string value)
        {
            return FindValue<SrtStylePassthrough>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SrtStylePassthrough(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusUpdateInterval.
    /// </summary>
    public class StatusUpdateInterval : ConstantClass
    {

        /// <summary>
        /// Constant SECONDS_10 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_10 = new StatusUpdateInterval("SECONDS_10");
        /// <summary>
        /// Constant SECONDS_12 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_12 = new StatusUpdateInterval("SECONDS_12");
        /// <summary>
        /// Constant SECONDS_120 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_120 = new StatusUpdateInterval("SECONDS_120");
        /// <summary>
        /// Constant SECONDS_15 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_15 = new StatusUpdateInterval("SECONDS_15");
        /// <summary>
        /// Constant SECONDS_180 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_180 = new StatusUpdateInterval("SECONDS_180");
        /// <summary>
        /// Constant SECONDS_20 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_20 = new StatusUpdateInterval("SECONDS_20");
        /// <summary>
        /// Constant SECONDS_240 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_240 = new StatusUpdateInterval("SECONDS_240");
        /// <summary>
        /// Constant SECONDS_30 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_30 = new StatusUpdateInterval("SECONDS_30");
        /// <summary>
        /// Constant SECONDS_300 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_300 = new StatusUpdateInterval("SECONDS_300");
        /// <summary>
        /// Constant SECONDS_360 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_360 = new StatusUpdateInterval("SECONDS_360");
        /// <summary>
        /// Constant SECONDS_420 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_420 = new StatusUpdateInterval("SECONDS_420");
        /// <summary>
        /// Constant SECONDS_480 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_480 = new StatusUpdateInterval("SECONDS_480");
        /// <summary>
        /// Constant SECONDS_540 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_540 = new StatusUpdateInterval("SECONDS_540");
        /// <summary>
        /// Constant SECONDS_60 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_60 = new StatusUpdateInterval("SECONDS_60");
        /// <summary>
        /// Constant SECONDS_600 for StatusUpdateInterval
        /// </summary>
        public static readonly StatusUpdateInterval SECONDS_600 = new StatusUpdateInterval("SECONDS_600");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusUpdateInterval(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusUpdateInterval FindValue(string value)
        {
            return FindValue<StatusUpdateInterval>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusUpdateInterval(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TeletextPageType.
    /// </summary>
    public class TeletextPageType : ConstantClass
    {

        /// <summary>
        /// Constant PAGE_TYPE_ADDL_INFO for TeletextPageType
        /// </summary>
        public static readonly TeletextPageType PAGE_TYPE_ADDL_INFO = new TeletextPageType("PAGE_TYPE_ADDL_INFO");
        /// <summary>
        /// Constant PAGE_TYPE_HEARING_IMPAIRED_SUBTITLE for TeletextPageType
        /// </summary>
        public static readonly TeletextPageType PAGE_TYPE_HEARING_IMPAIRED_SUBTITLE = new TeletextPageType("PAGE_TYPE_HEARING_IMPAIRED_SUBTITLE");
        /// <summary>
        /// Constant PAGE_TYPE_INITIAL for TeletextPageType
        /// </summary>
        public static readonly TeletextPageType PAGE_TYPE_INITIAL = new TeletextPageType("PAGE_TYPE_INITIAL");
        /// <summary>
        /// Constant PAGE_TYPE_PROGRAM_SCHEDULE for TeletextPageType
        /// </summary>
        public static readonly TeletextPageType PAGE_TYPE_PROGRAM_SCHEDULE = new TeletextPageType("PAGE_TYPE_PROGRAM_SCHEDULE");
        /// <summary>
        /// Constant PAGE_TYPE_SUBTITLE for TeletextPageType
        /// </summary>
        public static readonly TeletextPageType PAGE_TYPE_SUBTITLE = new TeletextPageType("PAGE_TYPE_SUBTITLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TeletextPageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TeletextPageType FindValue(string value)
        {
            return FindValue<TeletextPageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TeletextPageType(string value)
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
    /// Constants used for properties of type Vc3Class.
    /// </summary>
    public class Vc3Class : ConstantClass
    {

        /// <summary>
        /// Constant CLASS_145_8BIT for Vc3Class
        /// </summary>
        public static readonly Vc3Class CLASS_145_8BIT = new Vc3Class("CLASS_145_8BIT");
        /// <summary>
        /// Constant CLASS_220_10BIT for Vc3Class
        /// </summary>
        public static readonly Vc3Class CLASS_220_10BIT = new Vc3Class("CLASS_220_10BIT");
        /// <summary>
        /// Constant CLASS_220_8BIT for Vc3Class
        /// </summary>
        public static readonly Vc3Class CLASS_220_8BIT = new Vc3Class("CLASS_220_8BIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vc3Class(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vc3Class FindValue(string value)
        {
            return FindValue<Vc3Class>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vc3Class(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vc3FramerateControl.
    /// </summary>
    public class Vc3FramerateControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for Vc3FramerateControl
        /// </summary>
        public static readonly Vc3FramerateControl INITIALIZE_FROM_SOURCE = new Vc3FramerateControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for Vc3FramerateControl
        /// </summary>
        public static readonly Vc3FramerateControl SPECIFIED = new Vc3FramerateControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vc3FramerateControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vc3FramerateControl FindValue(string value)
        {
            return FindValue<Vc3FramerateControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vc3FramerateControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vc3FramerateConversionAlgorithm.
    /// </summary>
    public class Vc3FramerateConversionAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_DROP for Vc3FramerateConversionAlgorithm
        /// </summary>
        public static readonly Vc3FramerateConversionAlgorithm DUPLICATE_DROP = new Vc3FramerateConversionAlgorithm("DUPLICATE_DROP");
        /// <summary>
        /// Constant FRAMEFORMER for Vc3FramerateConversionAlgorithm
        /// </summary>
        public static readonly Vc3FramerateConversionAlgorithm FRAMEFORMER = new Vc3FramerateConversionAlgorithm("FRAMEFORMER");
        /// <summary>
        /// Constant INTERPOLATE for Vc3FramerateConversionAlgorithm
        /// </summary>
        public static readonly Vc3FramerateConversionAlgorithm INTERPOLATE = new Vc3FramerateConversionAlgorithm("INTERPOLATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vc3FramerateConversionAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vc3FramerateConversionAlgorithm FindValue(string value)
        {
            return FindValue<Vc3FramerateConversionAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vc3FramerateConversionAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vc3InterlaceMode.
    /// </summary>
    public class Vc3InterlaceMode : ConstantClass
    {

        /// <summary>
        /// Constant INTERLACED for Vc3InterlaceMode
        /// </summary>
        public static readonly Vc3InterlaceMode INTERLACED = new Vc3InterlaceMode("INTERLACED");
        /// <summary>
        /// Constant PROGRESSIVE for Vc3InterlaceMode
        /// </summary>
        public static readonly Vc3InterlaceMode PROGRESSIVE = new Vc3InterlaceMode("PROGRESSIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vc3InterlaceMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vc3InterlaceMode FindValue(string value)
        {
            return FindValue<Vc3InterlaceMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vc3InterlaceMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vc3ScanTypeConversionMode.
    /// </summary>
    public class Vc3ScanTypeConversionMode : ConstantClass
    {

        /// <summary>
        /// Constant INTERLACED for Vc3ScanTypeConversionMode
        /// </summary>
        public static readonly Vc3ScanTypeConversionMode INTERLACED = new Vc3ScanTypeConversionMode("INTERLACED");
        /// <summary>
        /// Constant INTERLACED_OPTIMIZE for Vc3ScanTypeConversionMode
        /// </summary>
        public static readonly Vc3ScanTypeConversionMode INTERLACED_OPTIMIZE = new Vc3ScanTypeConversionMode("INTERLACED_OPTIMIZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vc3ScanTypeConversionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vc3ScanTypeConversionMode FindValue(string value)
        {
            return FindValue<Vc3ScanTypeConversionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vc3ScanTypeConversionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vc3SlowPal.
    /// </summary>
    public class Vc3SlowPal : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Vc3SlowPal
        /// </summary>
        public static readonly Vc3SlowPal DISABLED = new Vc3SlowPal("DISABLED");
        /// <summary>
        /// Constant ENABLED for Vc3SlowPal
        /// </summary>
        public static readonly Vc3SlowPal ENABLED = new Vc3SlowPal("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vc3SlowPal(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vc3SlowPal FindValue(string value)
        {
            return FindValue<Vc3SlowPal>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vc3SlowPal(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vc3Telecine.
    /// </summary>
    public class Vc3Telecine : ConstantClass
    {

        /// <summary>
        /// Constant HARD for Vc3Telecine
        /// </summary>
        public static readonly Vc3Telecine HARD = new Vc3Telecine("HARD");
        /// <summary>
        /// Constant NONE for Vc3Telecine
        /// </summary>
        public static readonly Vc3Telecine NONE = new Vc3Telecine("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vc3Telecine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vc3Telecine FindValue(string value)
        {
            return FindValue<Vc3Telecine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vc3Telecine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VchipAction.
    /// </summary>
    public class VchipAction : ConstantClass
    {

        /// <summary>
        /// Constant PASSTHROUGH for VchipAction
        /// </summary>
        public static readonly VchipAction PASSTHROUGH = new VchipAction("PASSTHROUGH");
        /// <summary>
        /// Constant STRIP for VchipAction
        /// </summary>
        public static readonly VchipAction STRIP = new VchipAction("STRIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VchipAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VchipAction FindValue(string value)
        {
            return FindValue<VchipAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VchipAction(string value)
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
        /// Constant AV1 for VideoCodec
        /// </summary>
        public static readonly VideoCodec AV1 = new VideoCodec("AV1");
        /// <summary>
        /// Constant AVC_INTRA for VideoCodec
        /// </summary>
        public static readonly VideoCodec AVC_INTRA = new VideoCodec("AVC_INTRA");
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
        /// Constant VC3 for VideoCodec
        /// </summary>
        public static readonly VideoCodec VC3 = new VideoCodec("VC3");
        /// <summary>
        /// Constant VP8 for VideoCodec
        /// </summary>
        public static readonly VideoCodec VP8 = new VideoCodec("VP8");
        /// <summary>
        /// Constant VP9 for VideoCodec
        /// </summary>
        public static readonly VideoCodec VP9 = new VideoCodec("VP9");
        /// <summary>
        /// Constant XAVC for VideoCodec
        /// </summary>
        public static readonly VideoCodec XAVC = new VideoCodec("XAVC");

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
    /// Constants used for properties of type Vp8FramerateControl.
    /// </summary>
    public class Vp8FramerateControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for Vp8FramerateControl
        /// </summary>
        public static readonly Vp8FramerateControl INITIALIZE_FROM_SOURCE = new Vp8FramerateControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for Vp8FramerateControl
        /// </summary>
        public static readonly Vp8FramerateControl SPECIFIED = new Vp8FramerateControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vp8FramerateControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vp8FramerateControl FindValue(string value)
        {
            return FindValue<Vp8FramerateControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vp8FramerateControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vp8FramerateConversionAlgorithm.
    /// </summary>
    public class Vp8FramerateConversionAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_DROP for Vp8FramerateConversionAlgorithm
        /// </summary>
        public static readonly Vp8FramerateConversionAlgorithm DUPLICATE_DROP = new Vp8FramerateConversionAlgorithm("DUPLICATE_DROP");
        /// <summary>
        /// Constant FRAMEFORMER for Vp8FramerateConversionAlgorithm
        /// </summary>
        public static readonly Vp8FramerateConversionAlgorithm FRAMEFORMER = new Vp8FramerateConversionAlgorithm("FRAMEFORMER");
        /// <summary>
        /// Constant INTERPOLATE for Vp8FramerateConversionAlgorithm
        /// </summary>
        public static readonly Vp8FramerateConversionAlgorithm INTERPOLATE = new Vp8FramerateConversionAlgorithm("INTERPOLATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vp8FramerateConversionAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vp8FramerateConversionAlgorithm FindValue(string value)
        {
            return FindValue<Vp8FramerateConversionAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vp8FramerateConversionAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vp8ParControl.
    /// </summary>
    public class Vp8ParControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for Vp8ParControl
        /// </summary>
        public static readonly Vp8ParControl INITIALIZE_FROM_SOURCE = new Vp8ParControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for Vp8ParControl
        /// </summary>
        public static readonly Vp8ParControl SPECIFIED = new Vp8ParControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vp8ParControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vp8ParControl FindValue(string value)
        {
            return FindValue<Vp8ParControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vp8ParControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vp8QualityTuningLevel.
    /// </summary>
    public class Vp8QualityTuningLevel : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_PASS for Vp8QualityTuningLevel
        /// </summary>
        public static readonly Vp8QualityTuningLevel MULTI_PASS = new Vp8QualityTuningLevel("MULTI_PASS");
        /// <summary>
        /// Constant MULTI_PASS_HQ for Vp8QualityTuningLevel
        /// </summary>
        public static readonly Vp8QualityTuningLevel MULTI_PASS_HQ = new Vp8QualityTuningLevel("MULTI_PASS_HQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vp8QualityTuningLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vp8QualityTuningLevel FindValue(string value)
        {
            return FindValue<Vp8QualityTuningLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vp8QualityTuningLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vp8RateControlMode.
    /// </summary>
    public class Vp8RateControlMode : ConstantClass
    {

        /// <summary>
        /// Constant VBR for Vp8RateControlMode
        /// </summary>
        public static readonly Vp8RateControlMode VBR = new Vp8RateControlMode("VBR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vp8RateControlMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vp8RateControlMode FindValue(string value)
        {
            return FindValue<Vp8RateControlMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vp8RateControlMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vp9FramerateControl.
    /// </summary>
    public class Vp9FramerateControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for Vp9FramerateControl
        /// </summary>
        public static readonly Vp9FramerateControl INITIALIZE_FROM_SOURCE = new Vp9FramerateControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for Vp9FramerateControl
        /// </summary>
        public static readonly Vp9FramerateControl SPECIFIED = new Vp9FramerateControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vp9FramerateControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vp9FramerateControl FindValue(string value)
        {
            return FindValue<Vp9FramerateControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vp9FramerateControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vp9FramerateConversionAlgorithm.
    /// </summary>
    public class Vp9FramerateConversionAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_DROP for Vp9FramerateConversionAlgorithm
        /// </summary>
        public static readonly Vp9FramerateConversionAlgorithm DUPLICATE_DROP = new Vp9FramerateConversionAlgorithm("DUPLICATE_DROP");
        /// <summary>
        /// Constant FRAMEFORMER for Vp9FramerateConversionAlgorithm
        /// </summary>
        public static readonly Vp9FramerateConversionAlgorithm FRAMEFORMER = new Vp9FramerateConversionAlgorithm("FRAMEFORMER");
        /// <summary>
        /// Constant INTERPOLATE for Vp9FramerateConversionAlgorithm
        /// </summary>
        public static readonly Vp9FramerateConversionAlgorithm INTERPOLATE = new Vp9FramerateConversionAlgorithm("INTERPOLATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vp9FramerateConversionAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vp9FramerateConversionAlgorithm FindValue(string value)
        {
            return FindValue<Vp9FramerateConversionAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vp9FramerateConversionAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vp9ParControl.
    /// </summary>
    public class Vp9ParControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for Vp9ParControl
        /// </summary>
        public static readonly Vp9ParControl INITIALIZE_FROM_SOURCE = new Vp9ParControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for Vp9ParControl
        /// </summary>
        public static readonly Vp9ParControl SPECIFIED = new Vp9ParControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vp9ParControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vp9ParControl FindValue(string value)
        {
            return FindValue<Vp9ParControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vp9ParControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vp9QualityTuningLevel.
    /// </summary>
    public class Vp9QualityTuningLevel : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_PASS for Vp9QualityTuningLevel
        /// </summary>
        public static readonly Vp9QualityTuningLevel MULTI_PASS = new Vp9QualityTuningLevel("MULTI_PASS");
        /// <summary>
        /// Constant MULTI_PASS_HQ for Vp9QualityTuningLevel
        /// </summary>
        public static readonly Vp9QualityTuningLevel MULTI_PASS_HQ = new Vp9QualityTuningLevel("MULTI_PASS_HQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vp9QualityTuningLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vp9QualityTuningLevel FindValue(string value)
        {
            return FindValue<Vp9QualityTuningLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vp9QualityTuningLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Vp9RateControlMode.
    /// </summary>
    public class Vp9RateControlMode : ConstantClass
    {

        /// <summary>
        /// Constant VBR for Vp9RateControlMode
        /// </summary>
        public static readonly Vp9RateControlMode VBR = new Vp9RateControlMode("VBR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Vp9RateControlMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Vp9RateControlMode FindValue(string value)
        {
            return FindValue<Vp9RateControlMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Vp9RateControlMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WatermarkingStrength.
    /// </summary>
    public class WatermarkingStrength : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for WatermarkingStrength
        /// </summary>
        public static readonly WatermarkingStrength DEFAULT = new WatermarkingStrength("DEFAULT");
        /// <summary>
        /// Constant LIGHTER for WatermarkingStrength
        /// </summary>
        public static readonly WatermarkingStrength LIGHTER = new WatermarkingStrength("LIGHTER");
        /// <summary>
        /// Constant LIGHTEST for WatermarkingStrength
        /// </summary>
        public static readonly WatermarkingStrength LIGHTEST = new WatermarkingStrength("LIGHTEST");
        /// <summary>
        /// Constant STRONGER for WatermarkingStrength
        /// </summary>
        public static readonly WatermarkingStrength STRONGER = new WatermarkingStrength("STRONGER");
        /// <summary>
        /// Constant STRONGEST for WatermarkingStrength
        /// </summary>
        public static readonly WatermarkingStrength STRONGEST = new WatermarkingStrength("STRONGEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WatermarkingStrength(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WatermarkingStrength FindValue(string value)
        {
            return FindValue<WatermarkingStrength>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WatermarkingStrength(string value)
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


    /// <summary>
    /// Constants used for properties of type WebvttAccessibilitySubs.
    /// </summary>
    public class WebvttAccessibilitySubs : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for WebvttAccessibilitySubs
        /// </summary>
        public static readonly WebvttAccessibilitySubs DISABLED = new WebvttAccessibilitySubs("DISABLED");
        /// <summary>
        /// Constant ENABLED for WebvttAccessibilitySubs
        /// </summary>
        public static readonly WebvttAccessibilitySubs ENABLED = new WebvttAccessibilitySubs("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebvttAccessibilitySubs(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebvttAccessibilitySubs FindValue(string value)
        {
            return FindValue<WebvttAccessibilitySubs>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebvttAccessibilitySubs(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WebvttStylePassthrough.
    /// </summary>
    public class WebvttStylePassthrough : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for WebvttStylePassthrough
        /// </summary>
        public static readonly WebvttStylePassthrough DISABLED = new WebvttStylePassthrough("DISABLED");
        /// <summary>
        /// Constant ENABLED for WebvttStylePassthrough
        /// </summary>
        public static readonly WebvttStylePassthrough ENABLED = new WebvttStylePassthrough("ENABLED");
        /// <summary>
        /// Constant STRICT for WebvttStylePassthrough
        /// </summary>
        public static readonly WebvttStylePassthrough STRICT = new WebvttStylePassthrough("STRICT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebvttStylePassthrough(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebvttStylePassthrough FindValue(string value)
        {
            return FindValue<WebvttStylePassthrough>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebvttStylePassthrough(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Xavc4kIntraCbgProfileClass.
    /// </summary>
    public class Xavc4kIntraCbgProfileClass : ConstantClass
    {

        /// <summary>
        /// Constant CLASS_100 for Xavc4kIntraCbgProfileClass
        /// </summary>
        public static readonly Xavc4kIntraCbgProfileClass CLASS_100 = new Xavc4kIntraCbgProfileClass("CLASS_100");
        /// <summary>
        /// Constant CLASS_300 for Xavc4kIntraCbgProfileClass
        /// </summary>
        public static readonly Xavc4kIntraCbgProfileClass CLASS_300 = new Xavc4kIntraCbgProfileClass("CLASS_300");
        /// <summary>
        /// Constant CLASS_480 for Xavc4kIntraCbgProfileClass
        /// </summary>
        public static readonly Xavc4kIntraCbgProfileClass CLASS_480 = new Xavc4kIntraCbgProfileClass("CLASS_480");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Xavc4kIntraCbgProfileClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Xavc4kIntraCbgProfileClass FindValue(string value)
        {
            return FindValue<Xavc4kIntraCbgProfileClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Xavc4kIntraCbgProfileClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Xavc4kIntraVbrProfileClass.
    /// </summary>
    public class Xavc4kIntraVbrProfileClass : ConstantClass
    {

        /// <summary>
        /// Constant CLASS_100 for Xavc4kIntraVbrProfileClass
        /// </summary>
        public static readonly Xavc4kIntraVbrProfileClass CLASS_100 = new Xavc4kIntraVbrProfileClass("CLASS_100");
        /// <summary>
        /// Constant CLASS_300 for Xavc4kIntraVbrProfileClass
        /// </summary>
        public static readonly Xavc4kIntraVbrProfileClass CLASS_300 = new Xavc4kIntraVbrProfileClass("CLASS_300");
        /// <summary>
        /// Constant CLASS_480 for Xavc4kIntraVbrProfileClass
        /// </summary>
        public static readonly Xavc4kIntraVbrProfileClass CLASS_480 = new Xavc4kIntraVbrProfileClass("CLASS_480");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Xavc4kIntraVbrProfileClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Xavc4kIntraVbrProfileClass FindValue(string value)
        {
            return FindValue<Xavc4kIntraVbrProfileClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Xavc4kIntraVbrProfileClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Xavc4kProfileBitrateClass.
    /// </summary>
    public class Xavc4kProfileBitrateClass : ConstantClass
    {

        /// <summary>
        /// Constant BITRATE_CLASS_100 for Xavc4kProfileBitrateClass
        /// </summary>
        public static readonly Xavc4kProfileBitrateClass BITRATE_CLASS_100 = new Xavc4kProfileBitrateClass("BITRATE_CLASS_100");
        /// <summary>
        /// Constant BITRATE_CLASS_140 for Xavc4kProfileBitrateClass
        /// </summary>
        public static readonly Xavc4kProfileBitrateClass BITRATE_CLASS_140 = new Xavc4kProfileBitrateClass("BITRATE_CLASS_140");
        /// <summary>
        /// Constant BITRATE_CLASS_200 for Xavc4kProfileBitrateClass
        /// </summary>
        public static readonly Xavc4kProfileBitrateClass BITRATE_CLASS_200 = new Xavc4kProfileBitrateClass("BITRATE_CLASS_200");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Xavc4kProfileBitrateClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Xavc4kProfileBitrateClass FindValue(string value)
        {
            return FindValue<Xavc4kProfileBitrateClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Xavc4kProfileBitrateClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Xavc4kProfileCodecProfile.
    /// </summary>
    public class Xavc4kProfileCodecProfile : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for Xavc4kProfileCodecProfile
        /// </summary>
        public static readonly Xavc4kProfileCodecProfile HIGH = new Xavc4kProfileCodecProfile("HIGH");
        /// <summary>
        /// Constant HIGH_422 for Xavc4kProfileCodecProfile
        /// </summary>
        public static readonly Xavc4kProfileCodecProfile HIGH_422 = new Xavc4kProfileCodecProfile("HIGH_422");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Xavc4kProfileCodecProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Xavc4kProfileCodecProfile FindValue(string value)
        {
            return FindValue<Xavc4kProfileCodecProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Xavc4kProfileCodecProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Xavc4kProfileQualityTuningLevel.
    /// </summary>
    public class Xavc4kProfileQualityTuningLevel : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_PASS_HQ for Xavc4kProfileQualityTuningLevel
        /// </summary>
        public static readonly Xavc4kProfileQualityTuningLevel MULTI_PASS_HQ = new Xavc4kProfileQualityTuningLevel("MULTI_PASS_HQ");
        /// <summary>
        /// Constant SINGLE_PASS for Xavc4kProfileQualityTuningLevel
        /// </summary>
        public static readonly Xavc4kProfileQualityTuningLevel SINGLE_PASS = new Xavc4kProfileQualityTuningLevel("SINGLE_PASS");
        /// <summary>
        /// Constant SINGLE_PASS_HQ for Xavc4kProfileQualityTuningLevel
        /// </summary>
        public static readonly Xavc4kProfileQualityTuningLevel SINGLE_PASS_HQ = new Xavc4kProfileQualityTuningLevel("SINGLE_PASS_HQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Xavc4kProfileQualityTuningLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Xavc4kProfileQualityTuningLevel FindValue(string value)
        {
            return FindValue<Xavc4kProfileQualityTuningLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Xavc4kProfileQualityTuningLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcAdaptiveQuantization.
    /// </summary>
    public class XavcAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for XavcAdaptiveQuantization
        /// </summary>
        public static readonly XavcAdaptiveQuantization AUTO = new XavcAdaptiveQuantization("AUTO");
        /// <summary>
        /// Constant HIGH for XavcAdaptiveQuantization
        /// </summary>
        public static readonly XavcAdaptiveQuantization HIGH = new XavcAdaptiveQuantization("HIGH");
        /// <summary>
        /// Constant HIGHER for XavcAdaptiveQuantization
        /// </summary>
        public static readonly XavcAdaptiveQuantization HIGHER = new XavcAdaptiveQuantization("HIGHER");
        /// <summary>
        /// Constant LOW for XavcAdaptiveQuantization
        /// </summary>
        public static readonly XavcAdaptiveQuantization LOW = new XavcAdaptiveQuantization("LOW");
        /// <summary>
        /// Constant MAX for XavcAdaptiveQuantization
        /// </summary>
        public static readonly XavcAdaptiveQuantization MAX = new XavcAdaptiveQuantization("MAX");
        /// <summary>
        /// Constant MEDIUM for XavcAdaptiveQuantization
        /// </summary>
        public static readonly XavcAdaptiveQuantization MEDIUM = new XavcAdaptiveQuantization("MEDIUM");
        /// <summary>
        /// Constant OFF for XavcAdaptiveQuantization
        /// </summary>
        public static readonly XavcAdaptiveQuantization OFF = new XavcAdaptiveQuantization("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcAdaptiveQuantization FindValue(string value)
        {
            return FindValue<XavcAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcEntropyEncoding.
    /// </summary>
    public class XavcEntropyEncoding : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for XavcEntropyEncoding
        /// </summary>
        public static readonly XavcEntropyEncoding AUTO = new XavcEntropyEncoding("AUTO");
        /// <summary>
        /// Constant CABAC for XavcEntropyEncoding
        /// </summary>
        public static readonly XavcEntropyEncoding CABAC = new XavcEntropyEncoding("CABAC");
        /// <summary>
        /// Constant CAVLC for XavcEntropyEncoding
        /// </summary>
        public static readonly XavcEntropyEncoding CAVLC = new XavcEntropyEncoding("CAVLC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcEntropyEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcEntropyEncoding FindValue(string value)
        {
            return FindValue<XavcEntropyEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcEntropyEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcFlickerAdaptiveQuantization.
    /// </summary>
    public class XavcFlickerAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for XavcFlickerAdaptiveQuantization
        /// </summary>
        public static readonly XavcFlickerAdaptiveQuantization DISABLED = new XavcFlickerAdaptiveQuantization("DISABLED");
        /// <summary>
        /// Constant ENABLED for XavcFlickerAdaptiveQuantization
        /// </summary>
        public static readonly XavcFlickerAdaptiveQuantization ENABLED = new XavcFlickerAdaptiveQuantization("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcFlickerAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcFlickerAdaptiveQuantization FindValue(string value)
        {
            return FindValue<XavcFlickerAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcFlickerAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcFramerateControl.
    /// </summary>
    public class XavcFramerateControl : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_SOURCE for XavcFramerateControl
        /// </summary>
        public static readonly XavcFramerateControl INITIALIZE_FROM_SOURCE = new XavcFramerateControl("INITIALIZE_FROM_SOURCE");
        /// <summary>
        /// Constant SPECIFIED for XavcFramerateControl
        /// </summary>
        public static readonly XavcFramerateControl SPECIFIED = new XavcFramerateControl("SPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcFramerateControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcFramerateControl FindValue(string value)
        {
            return FindValue<XavcFramerateControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcFramerateControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcFramerateConversionAlgorithm.
    /// </summary>
    public class XavcFramerateConversionAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_DROP for XavcFramerateConversionAlgorithm
        /// </summary>
        public static readonly XavcFramerateConversionAlgorithm DUPLICATE_DROP = new XavcFramerateConversionAlgorithm("DUPLICATE_DROP");
        /// <summary>
        /// Constant FRAMEFORMER for XavcFramerateConversionAlgorithm
        /// </summary>
        public static readonly XavcFramerateConversionAlgorithm FRAMEFORMER = new XavcFramerateConversionAlgorithm("FRAMEFORMER");
        /// <summary>
        /// Constant INTERPOLATE for XavcFramerateConversionAlgorithm
        /// </summary>
        public static readonly XavcFramerateConversionAlgorithm INTERPOLATE = new XavcFramerateConversionAlgorithm("INTERPOLATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcFramerateConversionAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcFramerateConversionAlgorithm FindValue(string value)
        {
            return FindValue<XavcFramerateConversionAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcFramerateConversionAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcGopBReference.
    /// </summary>
    public class XavcGopBReference : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for XavcGopBReference
        /// </summary>
        public static readonly XavcGopBReference DISABLED = new XavcGopBReference("DISABLED");
        /// <summary>
        /// Constant ENABLED for XavcGopBReference
        /// </summary>
        public static readonly XavcGopBReference ENABLED = new XavcGopBReference("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcGopBReference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcGopBReference FindValue(string value)
        {
            return FindValue<XavcGopBReference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcGopBReference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcHdIntraCbgProfileClass.
    /// </summary>
    public class XavcHdIntraCbgProfileClass : ConstantClass
    {

        /// <summary>
        /// Constant CLASS_100 for XavcHdIntraCbgProfileClass
        /// </summary>
        public static readonly XavcHdIntraCbgProfileClass CLASS_100 = new XavcHdIntraCbgProfileClass("CLASS_100");
        /// <summary>
        /// Constant CLASS_200 for XavcHdIntraCbgProfileClass
        /// </summary>
        public static readonly XavcHdIntraCbgProfileClass CLASS_200 = new XavcHdIntraCbgProfileClass("CLASS_200");
        /// <summary>
        /// Constant CLASS_50 for XavcHdIntraCbgProfileClass
        /// </summary>
        public static readonly XavcHdIntraCbgProfileClass CLASS_50 = new XavcHdIntraCbgProfileClass("CLASS_50");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcHdIntraCbgProfileClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcHdIntraCbgProfileClass FindValue(string value)
        {
            return FindValue<XavcHdIntraCbgProfileClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcHdIntraCbgProfileClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcHdProfileBitrateClass.
    /// </summary>
    public class XavcHdProfileBitrateClass : ConstantClass
    {

        /// <summary>
        /// Constant BITRATE_CLASS_25 for XavcHdProfileBitrateClass
        /// </summary>
        public static readonly XavcHdProfileBitrateClass BITRATE_CLASS_25 = new XavcHdProfileBitrateClass("BITRATE_CLASS_25");
        /// <summary>
        /// Constant BITRATE_CLASS_35 for XavcHdProfileBitrateClass
        /// </summary>
        public static readonly XavcHdProfileBitrateClass BITRATE_CLASS_35 = new XavcHdProfileBitrateClass("BITRATE_CLASS_35");
        /// <summary>
        /// Constant BITRATE_CLASS_50 for XavcHdProfileBitrateClass
        /// </summary>
        public static readonly XavcHdProfileBitrateClass BITRATE_CLASS_50 = new XavcHdProfileBitrateClass("BITRATE_CLASS_50");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcHdProfileBitrateClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcHdProfileBitrateClass FindValue(string value)
        {
            return FindValue<XavcHdProfileBitrateClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcHdProfileBitrateClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcHdProfileQualityTuningLevel.
    /// </summary>
    public class XavcHdProfileQualityTuningLevel : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_PASS_HQ for XavcHdProfileQualityTuningLevel
        /// </summary>
        public static readonly XavcHdProfileQualityTuningLevel MULTI_PASS_HQ = new XavcHdProfileQualityTuningLevel("MULTI_PASS_HQ");
        /// <summary>
        /// Constant SINGLE_PASS for XavcHdProfileQualityTuningLevel
        /// </summary>
        public static readonly XavcHdProfileQualityTuningLevel SINGLE_PASS = new XavcHdProfileQualityTuningLevel("SINGLE_PASS");
        /// <summary>
        /// Constant SINGLE_PASS_HQ for XavcHdProfileQualityTuningLevel
        /// </summary>
        public static readonly XavcHdProfileQualityTuningLevel SINGLE_PASS_HQ = new XavcHdProfileQualityTuningLevel("SINGLE_PASS_HQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcHdProfileQualityTuningLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcHdProfileQualityTuningLevel FindValue(string value)
        {
            return FindValue<XavcHdProfileQualityTuningLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcHdProfileQualityTuningLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcHdProfileTelecine.
    /// </summary>
    public class XavcHdProfileTelecine : ConstantClass
    {

        /// <summary>
        /// Constant HARD for XavcHdProfileTelecine
        /// </summary>
        public static readonly XavcHdProfileTelecine HARD = new XavcHdProfileTelecine("HARD");
        /// <summary>
        /// Constant NONE for XavcHdProfileTelecine
        /// </summary>
        public static readonly XavcHdProfileTelecine NONE = new XavcHdProfileTelecine("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcHdProfileTelecine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcHdProfileTelecine FindValue(string value)
        {
            return FindValue<XavcHdProfileTelecine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcHdProfileTelecine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcInterlaceMode.
    /// </summary>
    public class XavcInterlaceMode : ConstantClass
    {

        /// <summary>
        /// Constant BOTTOM_FIELD for XavcInterlaceMode
        /// </summary>
        public static readonly XavcInterlaceMode BOTTOM_FIELD = new XavcInterlaceMode("BOTTOM_FIELD");
        /// <summary>
        /// Constant FOLLOW_BOTTOM_FIELD for XavcInterlaceMode
        /// </summary>
        public static readonly XavcInterlaceMode FOLLOW_BOTTOM_FIELD = new XavcInterlaceMode("FOLLOW_BOTTOM_FIELD");
        /// <summary>
        /// Constant FOLLOW_TOP_FIELD for XavcInterlaceMode
        /// </summary>
        public static readonly XavcInterlaceMode FOLLOW_TOP_FIELD = new XavcInterlaceMode("FOLLOW_TOP_FIELD");
        /// <summary>
        /// Constant PROGRESSIVE for XavcInterlaceMode
        /// </summary>
        public static readonly XavcInterlaceMode PROGRESSIVE = new XavcInterlaceMode("PROGRESSIVE");
        /// <summary>
        /// Constant TOP_FIELD for XavcInterlaceMode
        /// </summary>
        public static readonly XavcInterlaceMode TOP_FIELD = new XavcInterlaceMode("TOP_FIELD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcInterlaceMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcInterlaceMode FindValue(string value)
        {
            return FindValue<XavcInterlaceMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcInterlaceMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcProfile.
    /// </summary>
    public class XavcProfile : ConstantClass
    {

        /// <summary>
        /// Constant XAVC_4K for XavcProfile
        /// </summary>
        public static readonly XavcProfile XAVC_4K = new XavcProfile("XAVC_4K");
        /// <summary>
        /// Constant XAVC_4K_INTRA_CBG for XavcProfile
        /// </summary>
        public static readonly XavcProfile XAVC_4K_INTRA_CBG = new XavcProfile("XAVC_4K_INTRA_CBG");
        /// <summary>
        /// Constant XAVC_4K_INTRA_VBR for XavcProfile
        /// </summary>
        public static readonly XavcProfile XAVC_4K_INTRA_VBR = new XavcProfile("XAVC_4K_INTRA_VBR");
        /// <summary>
        /// Constant XAVC_HD for XavcProfile
        /// </summary>
        public static readonly XavcProfile XAVC_HD = new XavcProfile("XAVC_HD");
        /// <summary>
        /// Constant XAVC_HD_INTRA_CBG for XavcProfile
        /// </summary>
        public static readonly XavcProfile XAVC_HD_INTRA_CBG = new XavcProfile("XAVC_HD_INTRA_CBG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcProfile FindValue(string value)
        {
            return FindValue<XavcProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcSlowPal.
    /// </summary>
    public class XavcSlowPal : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for XavcSlowPal
        /// </summary>
        public static readonly XavcSlowPal DISABLED = new XavcSlowPal("DISABLED");
        /// <summary>
        /// Constant ENABLED for XavcSlowPal
        /// </summary>
        public static readonly XavcSlowPal ENABLED = new XavcSlowPal("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcSlowPal(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcSlowPal FindValue(string value)
        {
            return FindValue<XavcSlowPal>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcSlowPal(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcSpatialAdaptiveQuantization.
    /// </summary>
    public class XavcSpatialAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for XavcSpatialAdaptiveQuantization
        /// </summary>
        public static readonly XavcSpatialAdaptiveQuantization DISABLED = new XavcSpatialAdaptiveQuantization("DISABLED");
        /// <summary>
        /// Constant ENABLED for XavcSpatialAdaptiveQuantization
        /// </summary>
        public static readonly XavcSpatialAdaptiveQuantization ENABLED = new XavcSpatialAdaptiveQuantization("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcSpatialAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcSpatialAdaptiveQuantization FindValue(string value)
        {
            return FindValue<XavcSpatialAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcSpatialAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type XavcTemporalAdaptiveQuantization.
    /// </summary>
    public class XavcTemporalAdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for XavcTemporalAdaptiveQuantization
        /// </summary>
        public static readonly XavcTemporalAdaptiveQuantization DISABLED = new XavcTemporalAdaptiveQuantization("DISABLED");
        /// <summary>
        /// Constant ENABLED for XavcTemporalAdaptiveQuantization
        /// </summary>
        public static readonly XavcTemporalAdaptiveQuantization ENABLED = new XavcTemporalAdaptiveQuantization("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public XavcTemporalAdaptiveQuantization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static XavcTemporalAdaptiveQuantization FindValue(string value)
        {
            return FindValue<XavcTemporalAdaptiveQuantization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator XavcTemporalAdaptiveQuantization(string value)
        {
            return FindValue(value);
        }
    }

}