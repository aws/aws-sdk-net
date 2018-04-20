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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MediaLive
{

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
    /// Constants used for properties of type AacInputType.
    /// </summary>
    public class AacInputType : ConstantClass
    {

        /// <summary>
        /// Constant BROADCASTER_MIXED_AD for AacInputType
        /// </summary>
        public static readonly AacInputType BROADCASTER_MIXED_AD = new AacInputType("BROADCASTER_MIXED_AD");
        /// <summary>
        /// Constant NORMAL for AacInputType
        /// </summary>
        public static readonly AacInputType NORMAL = new AacInputType("NORMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AacInputType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AacInputType FindValue(string value)
        {
            return FindValue<AacInputType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AacInputType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AacProfile.
    /// </summary>
    public class AacProfile : ConstantClass
    {

        /// <summary>
        /// Constant HEV1 for AacProfile
        /// </summary>
        public static readonly AacProfile HEV1 = new AacProfile("HEV1");
        /// <summary>
        /// Constant HEV2 for AacProfile
        /// </summary>
        public static readonly AacProfile HEV2 = new AacProfile("HEV2");
        /// <summary>
        /// Constant LC for AacProfile
        /// </summary>
        public static readonly AacProfile LC = new AacProfile("LC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AacProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AacProfile FindValue(string value)
        {
            return FindValue<AacProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AacProfile(string value)
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
    /// Constants used for properties of type AacSpec.
    /// </summary>
    public class AacSpec : ConstantClass
    {

        /// <summary>
        /// Constant MPEG2 for AacSpec
        /// </summary>
        public static readonly AacSpec MPEG2 = new AacSpec("MPEG2");
        /// <summary>
        /// Constant MPEG4 for AacSpec
        /// </summary>
        public static readonly AacSpec MPEG4 = new AacSpec("MPEG4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AacSpec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AacSpec FindValue(string value)
        {
            return FindValue<AacSpec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AacSpec(string value)
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
    /// Constants used for properties of type Ac3DrcProfile.
    /// </summary>
    public class Ac3DrcProfile : ConstantClass
    {

        /// <summary>
        /// Constant FILM_STANDARD for Ac3DrcProfile
        /// </summary>
        public static readonly Ac3DrcProfile FILM_STANDARD = new Ac3DrcProfile("FILM_STANDARD");
        /// <summary>
        /// Constant NONE for Ac3DrcProfile
        /// </summary>
        public static readonly Ac3DrcProfile NONE = new Ac3DrcProfile("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ac3DrcProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ac3DrcProfile FindValue(string value)
        {
            return FindValue<Ac3DrcProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ac3DrcProfile(string value)
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
    /// Constants used for properties of type AudioDescriptionAudioTypeControl.
    /// </summary>
    public class AudioDescriptionAudioTypeControl : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW_INPUT for AudioDescriptionAudioTypeControl
        /// </summary>
        public static readonly AudioDescriptionAudioTypeControl FOLLOW_INPUT = new AudioDescriptionAudioTypeControl("FOLLOW_INPUT");
        /// <summary>
        /// Constant USE_CONFIGURED for AudioDescriptionAudioTypeControl
        /// </summary>
        public static readonly AudioDescriptionAudioTypeControl USE_CONFIGURED = new AudioDescriptionAudioTypeControl("USE_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioDescriptionAudioTypeControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioDescriptionAudioTypeControl FindValue(string value)
        {
            return FindValue<AudioDescriptionAudioTypeControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioDescriptionAudioTypeControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioDescriptionLanguageCodeControl.
    /// </summary>
    public class AudioDescriptionLanguageCodeControl : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW_INPUT for AudioDescriptionLanguageCodeControl
        /// </summary>
        public static readonly AudioDescriptionLanguageCodeControl FOLLOW_INPUT = new AudioDescriptionLanguageCodeControl("FOLLOW_INPUT");
        /// <summary>
        /// Constant USE_CONFIGURED for AudioDescriptionLanguageCodeControl
        /// </summary>
        public static readonly AudioDescriptionLanguageCodeControl USE_CONFIGURED = new AudioDescriptionLanguageCodeControl("USE_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioDescriptionLanguageCodeControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioDescriptionLanguageCodeControl FindValue(string value)
        {
            return FindValue<AudioDescriptionLanguageCodeControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioDescriptionLanguageCodeControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioLanguageSelectionPolicy.
    /// </summary>
    public class AudioLanguageSelectionPolicy : ConstantClass
    {

        /// <summary>
        /// Constant LOOSE for AudioLanguageSelectionPolicy
        /// </summary>
        public static readonly AudioLanguageSelectionPolicy LOOSE = new AudioLanguageSelectionPolicy("LOOSE");
        /// <summary>
        /// Constant STRICT for AudioLanguageSelectionPolicy
        /// </summary>
        public static readonly AudioLanguageSelectionPolicy STRICT = new AudioLanguageSelectionPolicy("STRICT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioLanguageSelectionPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioLanguageSelectionPolicy FindValue(string value)
        {
            return FindValue<AudioLanguageSelectionPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioLanguageSelectionPolicy(string value)
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
        /// Constant ITU_1770_1 for AudioNormalizationAlgorithm
        /// </summary>
        public static readonly AudioNormalizationAlgorithm ITU_1770_1 = new AudioNormalizationAlgorithm("ITU_1770_1");
        /// <summary>
        /// Constant ITU_1770_2 for AudioNormalizationAlgorithm
        /// </summary>
        public static readonly AudioNormalizationAlgorithm ITU_1770_2 = new AudioNormalizationAlgorithm("ITU_1770_2");

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
    /// Constants used for properties of type AudioOnlyHlsTrackType.
    /// </summary>
    public class AudioOnlyHlsTrackType : ConstantClass
    {

        /// <summary>
        /// Constant ALTERNATE_AUDIO_AUTO_SELECT for AudioOnlyHlsTrackType
        /// </summary>
        public static readonly AudioOnlyHlsTrackType ALTERNATE_AUDIO_AUTO_SELECT = new AudioOnlyHlsTrackType("ALTERNATE_AUDIO_AUTO_SELECT");
        /// <summary>
        /// Constant ALTERNATE_AUDIO_AUTO_SELECT_DEFAULT for AudioOnlyHlsTrackType
        /// </summary>
        public static readonly AudioOnlyHlsTrackType ALTERNATE_AUDIO_AUTO_SELECT_DEFAULT = new AudioOnlyHlsTrackType("ALTERNATE_AUDIO_AUTO_SELECT_DEFAULT");
        /// <summary>
        /// Constant ALTERNATE_AUDIO_NOT_AUTO_SELECT for AudioOnlyHlsTrackType
        /// </summary>
        public static readonly AudioOnlyHlsTrackType ALTERNATE_AUDIO_NOT_AUTO_SELECT = new AudioOnlyHlsTrackType("ALTERNATE_AUDIO_NOT_AUTO_SELECT");
        /// <summary>
        /// Constant AUDIO_ONLY_VARIANT_STREAM for AudioOnlyHlsTrackType
        /// </summary>
        public static readonly AudioOnlyHlsTrackType AUDIO_ONLY_VARIANT_STREAM = new AudioOnlyHlsTrackType("AUDIO_ONLY_VARIANT_STREAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioOnlyHlsTrackType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioOnlyHlsTrackType FindValue(string value)
        {
            return FindValue<AudioOnlyHlsTrackType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioOnlyHlsTrackType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioType.
    /// </summary>
    public class AudioType : ConstantClass
    {

        /// <summary>
        /// Constant CLEAN_EFFECTS for AudioType
        /// </summary>
        public static readonly AudioType CLEAN_EFFECTS = new AudioType("CLEAN_EFFECTS");
        /// <summary>
        /// Constant HEARING_IMPAIRED for AudioType
        /// </summary>
        public static readonly AudioType HEARING_IMPAIRED = new AudioType("HEARING_IMPAIRED");
        /// <summary>
        /// Constant UNDEFINED for AudioType
        /// </summary>
        public static readonly AudioType UNDEFINED = new AudioType("UNDEFINED");
        /// <summary>
        /// Constant VISUAL_IMPAIRED_COMMENTARY for AudioType
        /// </summary>
        public static readonly AudioType VISUAL_IMPAIRED_COMMENTARY = new AudioType("VISUAL_IMPAIRED_COMMENTARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioType FindValue(string value)
        {
            return FindValue<AudioType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthenticationScheme.
    /// </summary>
    public class AuthenticationScheme : ConstantClass
    {

        /// <summary>
        /// Constant AKAMAI for AuthenticationScheme
        /// </summary>
        public static readonly AuthenticationScheme AKAMAI = new AuthenticationScheme("AKAMAI");
        /// <summary>
        /// Constant COMMON for AuthenticationScheme
        /// </summary>
        public static readonly AuthenticationScheme COMMON = new AuthenticationScheme("COMMON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationScheme(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationScheme FindValue(string value)
        {
            return FindValue<AuthenticationScheme>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationScheme(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvailBlankingState.
    /// </summary>
    public class AvailBlankingState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AvailBlankingState
        /// </summary>
        public static readonly AvailBlankingState DISABLED = new AvailBlankingState("DISABLED");
        /// <summary>
        /// Constant ENABLED for AvailBlankingState
        /// </summary>
        public static readonly AvailBlankingState ENABLED = new AvailBlankingState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvailBlankingState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvailBlankingState FindValue(string value)
        {
            return FindValue<AvailBlankingState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvailBlankingState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BlackoutSlateNetworkEndBlackout.
    /// </summary>
    public class BlackoutSlateNetworkEndBlackout : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for BlackoutSlateNetworkEndBlackout
        /// </summary>
        public static readonly BlackoutSlateNetworkEndBlackout DISABLED = new BlackoutSlateNetworkEndBlackout("DISABLED");
        /// <summary>
        /// Constant ENABLED for BlackoutSlateNetworkEndBlackout
        /// </summary>
        public static readonly BlackoutSlateNetworkEndBlackout ENABLED = new BlackoutSlateNetworkEndBlackout("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlackoutSlateNetworkEndBlackout(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlackoutSlateNetworkEndBlackout FindValue(string value)
        {
            return FindValue<BlackoutSlateNetworkEndBlackout>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlackoutSlateNetworkEndBlackout(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BlackoutSlateState.
    /// </summary>
    public class BlackoutSlateState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for BlackoutSlateState
        /// </summary>
        public static readonly BlackoutSlateState DISABLED = new BlackoutSlateState("DISABLED");
        /// <summary>
        /// Constant ENABLED for BlackoutSlateState
        /// </summary>
        public static readonly BlackoutSlateState ENABLED = new BlackoutSlateState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlackoutSlateState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlackoutSlateState FindValue(string value)
        {
            return FindValue<BlackoutSlateState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlackoutSlateState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurnInAlignment.
    /// </summary>
    public class BurnInAlignment : ConstantClass
    {

        /// <summary>
        /// Constant CENTERED for BurnInAlignment
        /// </summary>
        public static readonly BurnInAlignment CENTERED = new BurnInAlignment("CENTERED");
        /// <summary>
        /// Constant LEFT for BurnInAlignment
        /// </summary>
        public static readonly BurnInAlignment LEFT = new BurnInAlignment("LEFT");
        /// <summary>
        /// Constant SMART for BurnInAlignment
        /// </summary>
        public static readonly BurnInAlignment SMART = new BurnInAlignment("SMART");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurnInAlignment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurnInAlignment FindValue(string value)
        {
            return FindValue<BurnInAlignment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurnInAlignment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurnInBackgroundColor.
    /// </summary>
    public class BurnInBackgroundColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for BurnInBackgroundColor
        /// </summary>
        public static readonly BurnInBackgroundColor BLACK = new BurnInBackgroundColor("BLACK");
        /// <summary>
        /// Constant NONE for BurnInBackgroundColor
        /// </summary>
        public static readonly BurnInBackgroundColor NONE = new BurnInBackgroundColor("NONE");
        /// <summary>
        /// Constant WHITE for BurnInBackgroundColor
        /// </summary>
        public static readonly BurnInBackgroundColor WHITE = new BurnInBackgroundColor("WHITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurnInBackgroundColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurnInBackgroundColor FindValue(string value)
        {
            return FindValue<BurnInBackgroundColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurnInBackgroundColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurnInFontColor.
    /// </summary>
    public class BurnInFontColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for BurnInFontColor
        /// </summary>
        public static readonly BurnInFontColor BLACK = new BurnInFontColor("BLACK");
        /// <summary>
        /// Constant BLUE for BurnInFontColor
        /// </summary>
        public static readonly BurnInFontColor BLUE = new BurnInFontColor("BLUE");
        /// <summary>
        /// Constant GREEN for BurnInFontColor
        /// </summary>
        public static readonly BurnInFontColor GREEN = new BurnInFontColor("GREEN");
        /// <summary>
        /// Constant RED for BurnInFontColor
        /// </summary>
        public static readonly BurnInFontColor RED = new BurnInFontColor("RED");
        /// <summary>
        /// Constant WHITE for BurnInFontColor
        /// </summary>
        public static readonly BurnInFontColor WHITE = new BurnInFontColor("WHITE");
        /// <summary>
        /// Constant YELLOW for BurnInFontColor
        /// </summary>
        public static readonly BurnInFontColor YELLOW = new BurnInFontColor("YELLOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurnInFontColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurnInFontColor FindValue(string value)
        {
            return FindValue<BurnInFontColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurnInFontColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurnInOutlineColor.
    /// </summary>
    public class BurnInOutlineColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for BurnInOutlineColor
        /// </summary>
        public static readonly BurnInOutlineColor BLACK = new BurnInOutlineColor("BLACK");
        /// <summary>
        /// Constant BLUE for BurnInOutlineColor
        /// </summary>
        public static readonly BurnInOutlineColor BLUE = new BurnInOutlineColor("BLUE");
        /// <summary>
        /// Constant GREEN for BurnInOutlineColor
        /// </summary>
        public static readonly BurnInOutlineColor GREEN = new BurnInOutlineColor("GREEN");
        /// <summary>
        /// Constant RED for BurnInOutlineColor
        /// </summary>
        public static readonly BurnInOutlineColor RED = new BurnInOutlineColor("RED");
        /// <summary>
        /// Constant WHITE for BurnInOutlineColor
        /// </summary>
        public static readonly BurnInOutlineColor WHITE = new BurnInOutlineColor("WHITE");
        /// <summary>
        /// Constant YELLOW for BurnInOutlineColor
        /// </summary>
        public static readonly BurnInOutlineColor YELLOW = new BurnInOutlineColor("YELLOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurnInOutlineColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurnInOutlineColor FindValue(string value)
        {
            return FindValue<BurnInOutlineColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurnInOutlineColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurnInShadowColor.
    /// </summary>
    public class BurnInShadowColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for BurnInShadowColor
        /// </summary>
        public static readonly BurnInShadowColor BLACK = new BurnInShadowColor("BLACK");
        /// <summary>
        /// Constant NONE for BurnInShadowColor
        /// </summary>
        public static readonly BurnInShadowColor NONE = new BurnInShadowColor("NONE");
        /// <summary>
        /// Constant WHITE for BurnInShadowColor
        /// </summary>
        public static readonly BurnInShadowColor WHITE = new BurnInShadowColor("WHITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurnInShadowColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurnInShadowColor FindValue(string value)
        {
            return FindValue<BurnInShadowColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurnInShadowColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BurnInTeletextGridControl.
    /// </summary>
    public class BurnInTeletextGridControl : ConstantClass
    {

        /// <summary>
        /// Constant FIXED for BurnInTeletextGridControl
        /// </summary>
        public static readonly BurnInTeletextGridControl FIXED = new BurnInTeletextGridControl("FIXED");
        /// <summary>
        /// Constant SCALED for BurnInTeletextGridControl
        /// </summary>
        public static readonly BurnInTeletextGridControl SCALED = new BurnInTeletextGridControl("SCALED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BurnInTeletextGridControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BurnInTeletextGridControl FindValue(string value)
        {
            return FindValue<BurnInTeletextGridControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BurnInTeletextGridControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelState.
    /// </summary>
    public class ChannelState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for ChannelState
        /// </summary>
        public static readonly ChannelState CREATE_FAILED = new ChannelState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for ChannelState
        /// </summary>
        public static readonly ChannelState CREATING = new ChannelState("CREATING");
        /// <summary>
        /// Constant DELETED for ChannelState
        /// </summary>
        public static readonly ChannelState DELETED = new ChannelState("DELETED");
        /// <summary>
        /// Constant DELETING for ChannelState
        /// </summary>
        public static readonly ChannelState DELETING = new ChannelState("DELETING");
        /// <summary>
        /// Constant IDLE for ChannelState
        /// </summary>
        public static readonly ChannelState IDLE = new ChannelState("IDLE");
        /// <summary>
        /// Constant RECOVERING for ChannelState
        /// </summary>
        public static readonly ChannelState RECOVERING = new ChannelState("RECOVERING");
        /// <summary>
        /// Constant RUNNING for ChannelState
        /// </summary>
        public static readonly ChannelState RUNNING = new ChannelState("RUNNING");
        /// <summary>
        /// Constant STARTING for ChannelState
        /// </summary>
        public static readonly ChannelState STARTING = new ChannelState("STARTING");
        /// <summary>
        /// Constant STOPPING for ChannelState
        /// </summary>
        public static readonly ChannelState STOPPING = new ChannelState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelState FindValue(string value)
        {
            return FindValue<ChannelState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSdtOutputSdt.
    /// </summary>
    public class DvbSdtOutputSdt : ConstantClass
    {

        /// <summary>
        /// Constant SDT_FOLLOW for DvbSdtOutputSdt
        /// </summary>
        public static readonly DvbSdtOutputSdt SDT_FOLLOW = new DvbSdtOutputSdt("SDT_FOLLOW");
        /// <summary>
        /// Constant SDT_FOLLOW_IF_PRESENT for DvbSdtOutputSdt
        /// </summary>
        public static readonly DvbSdtOutputSdt SDT_FOLLOW_IF_PRESENT = new DvbSdtOutputSdt("SDT_FOLLOW_IF_PRESENT");
        /// <summary>
        /// Constant SDT_MANUAL for DvbSdtOutputSdt
        /// </summary>
        public static readonly DvbSdtOutputSdt SDT_MANUAL = new DvbSdtOutputSdt("SDT_MANUAL");
        /// <summary>
        /// Constant SDT_NONE for DvbSdtOutputSdt
        /// </summary>
        public static readonly DvbSdtOutputSdt SDT_NONE = new DvbSdtOutputSdt("SDT_NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSdtOutputSdt(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSdtOutputSdt FindValue(string value)
        {
            return FindValue<DvbSdtOutputSdt>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSdtOutputSdt(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubDestinationAlignment.
    /// </summary>
    public class DvbSubDestinationAlignment : ConstantClass
    {

        /// <summary>
        /// Constant CENTERED for DvbSubDestinationAlignment
        /// </summary>
        public static readonly DvbSubDestinationAlignment CENTERED = new DvbSubDestinationAlignment("CENTERED");
        /// <summary>
        /// Constant LEFT for DvbSubDestinationAlignment
        /// </summary>
        public static readonly DvbSubDestinationAlignment LEFT = new DvbSubDestinationAlignment("LEFT");
        /// <summary>
        /// Constant SMART for DvbSubDestinationAlignment
        /// </summary>
        public static readonly DvbSubDestinationAlignment SMART = new DvbSubDestinationAlignment("SMART");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubDestinationAlignment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubDestinationAlignment FindValue(string value)
        {
            return FindValue<DvbSubDestinationAlignment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubDestinationAlignment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubDestinationBackgroundColor.
    /// </summary>
    public class DvbSubDestinationBackgroundColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for DvbSubDestinationBackgroundColor
        /// </summary>
        public static readonly DvbSubDestinationBackgroundColor BLACK = new DvbSubDestinationBackgroundColor("BLACK");
        /// <summary>
        /// Constant NONE for DvbSubDestinationBackgroundColor
        /// </summary>
        public static readonly DvbSubDestinationBackgroundColor NONE = new DvbSubDestinationBackgroundColor("NONE");
        /// <summary>
        /// Constant WHITE for DvbSubDestinationBackgroundColor
        /// </summary>
        public static readonly DvbSubDestinationBackgroundColor WHITE = new DvbSubDestinationBackgroundColor("WHITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubDestinationBackgroundColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubDestinationBackgroundColor FindValue(string value)
        {
            return FindValue<DvbSubDestinationBackgroundColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubDestinationBackgroundColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubDestinationFontColor.
    /// </summary>
    public class DvbSubDestinationFontColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for DvbSubDestinationFontColor
        /// </summary>
        public static readonly DvbSubDestinationFontColor BLACK = new DvbSubDestinationFontColor("BLACK");
        /// <summary>
        /// Constant BLUE for DvbSubDestinationFontColor
        /// </summary>
        public static readonly DvbSubDestinationFontColor BLUE = new DvbSubDestinationFontColor("BLUE");
        /// <summary>
        /// Constant GREEN for DvbSubDestinationFontColor
        /// </summary>
        public static readonly DvbSubDestinationFontColor GREEN = new DvbSubDestinationFontColor("GREEN");
        /// <summary>
        /// Constant RED for DvbSubDestinationFontColor
        /// </summary>
        public static readonly DvbSubDestinationFontColor RED = new DvbSubDestinationFontColor("RED");
        /// <summary>
        /// Constant WHITE for DvbSubDestinationFontColor
        /// </summary>
        public static readonly DvbSubDestinationFontColor WHITE = new DvbSubDestinationFontColor("WHITE");
        /// <summary>
        /// Constant YELLOW for DvbSubDestinationFontColor
        /// </summary>
        public static readonly DvbSubDestinationFontColor YELLOW = new DvbSubDestinationFontColor("YELLOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubDestinationFontColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubDestinationFontColor FindValue(string value)
        {
            return FindValue<DvbSubDestinationFontColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubDestinationFontColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubDestinationOutlineColor.
    /// </summary>
    public class DvbSubDestinationOutlineColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for DvbSubDestinationOutlineColor
        /// </summary>
        public static readonly DvbSubDestinationOutlineColor BLACK = new DvbSubDestinationOutlineColor("BLACK");
        /// <summary>
        /// Constant BLUE for DvbSubDestinationOutlineColor
        /// </summary>
        public static readonly DvbSubDestinationOutlineColor BLUE = new DvbSubDestinationOutlineColor("BLUE");
        /// <summary>
        /// Constant GREEN for DvbSubDestinationOutlineColor
        /// </summary>
        public static readonly DvbSubDestinationOutlineColor GREEN = new DvbSubDestinationOutlineColor("GREEN");
        /// <summary>
        /// Constant RED for DvbSubDestinationOutlineColor
        /// </summary>
        public static readonly DvbSubDestinationOutlineColor RED = new DvbSubDestinationOutlineColor("RED");
        /// <summary>
        /// Constant WHITE for DvbSubDestinationOutlineColor
        /// </summary>
        public static readonly DvbSubDestinationOutlineColor WHITE = new DvbSubDestinationOutlineColor("WHITE");
        /// <summary>
        /// Constant YELLOW for DvbSubDestinationOutlineColor
        /// </summary>
        public static readonly DvbSubDestinationOutlineColor YELLOW = new DvbSubDestinationOutlineColor("YELLOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubDestinationOutlineColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubDestinationOutlineColor FindValue(string value)
        {
            return FindValue<DvbSubDestinationOutlineColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubDestinationOutlineColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubDestinationShadowColor.
    /// </summary>
    public class DvbSubDestinationShadowColor : ConstantClass
    {

        /// <summary>
        /// Constant BLACK for DvbSubDestinationShadowColor
        /// </summary>
        public static readonly DvbSubDestinationShadowColor BLACK = new DvbSubDestinationShadowColor("BLACK");
        /// <summary>
        /// Constant NONE for DvbSubDestinationShadowColor
        /// </summary>
        public static readonly DvbSubDestinationShadowColor NONE = new DvbSubDestinationShadowColor("NONE");
        /// <summary>
        /// Constant WHITE for DvbSubDestinationShadowColor
        /// </summary>
        public static readonly DvbSubDestinationShadowColor WHITE = new DvbSubDestinationShadowColor("WHITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubDestinationShadowColor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubDestinationShadowColor FindValue(string value)
        {
            return FindValue<DvbSubDestinationShadowColor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubDestinationShadowColor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DvbSubDestinationTeletextGridControl.
    /// </summary>
    public class DvbSubDestinationTeletextGridControl : ConstantClass
    {

        /// <summary>
        /// Constant FIXED for DvbSubDestinationTeletextGridControl
        /// </summary>
        public static readonly DvbSubDestinationTeletextGridControl FIXED = new DvbSubDestinationTeletextGridControl("FIXED");
        /// <summary>
        /// Constant SCALED for DvbSubDestinationTeletextGridControl
        /// </summary>
        public static readonly DvbSubDestinationTeletextGridControl SCALED = new DvbSubDestinationTeletextGridControl("SCALED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubDestinationTeletextGridControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubDestinationTeletextGridControl FindValue(string value)
        {
            return FindValue<DvbSubDestinationTeletextGridControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubDestinationTeletextGridControl(string value)
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
    /// Constants used for properties of type Eac3DrcLine.
    /// </summary>
    public class Eac3DrcLine : ConstantClass
    {

        /// <summary>
        /// Constant FILM_LIGHT for Eac3DrcLine
        /// </summary>
        public static readonly Eac3DrcLine FILM_LIGHT = new Eac3DrcLine("FILM_LIGHT");
        /// <summary>
        /// Constant FILM_STANDARD for Eac3DrcLine
        /// </summary>
        public static readonly Eac3DrcLine FILM_STANDARD = new Eac3DrcLine("FILM_STANDARD");
        /// <summary>
        /// Constant MUSIC_LIGHT for Eac3DrcLine
        /// </summary>
        public static readonly Eac3DrcLine MUSIC_LIGHT = new Eac3DrcLine("MUSIC_LIGHT");
        /// <summary>
        /// Constant MUSIC_STANDARD for Eac3DrcLine
        /// </summary>
        public static readonly Eac3DrcLine MUSIC_STANDARD = new Eac3DrcLine("MUSIC_STANDARD");
        /// <summary>
        /// Constant NONE for Eac3DrcLine
        /// </summary>
        public static readonly Eac3DrcLine NONE = new Eac3DrcLine("NONE");
        /// <summary>
        /// Constant SPEECH for Eac3DrcLine
        /// </summary>
        public static readonly Eac3DrcLine SPEECH = new Eac3DrcLine("SPEECH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3DrcLine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3DrcLine FindValue(string value)
        {
            return FindValue<Eac3DrcLine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3DrcLine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3DrcRf.
    /// </summary>
    public class Eac3DrcRf : ConstantClass
    {

        /// <summary>
        /// Constant FILM_LIGHT for Eac3DrcRf
        /// </summary>
        public static readonly Eac3DrcRf FILM_LIGHT = new Eac3DrcRf("FILM_LIGHT");
        /// <summary>
        /// Constant FILM_STANDARD for Eac3DrcRf
        /// </summary>
        public static readonly Eac3DrcRf FILM_STANDARD = new Eac3DrcRf("FILM_STANDARD");
        /// <summary>
        /// Constant MUSIC_LIGHT for Eac3DrcRf
        /// </summary>
        public static readonly Eac3DrcRf MUSIC_LIGHT = new Eac3DrcRf("MUSIC_LIGHT");
        /// <summary>
        /// Constant MUSIC_STANDARD for Eac3DrcRf
        /// </summary>
        public static readonly Eac3DrcRf MUSIC_STANDARD = new Eac3DrcRf("MUSIC_STANDARD");
        /// <summary>
        /// Constant NONE for Eac3DrcRf
        /// </summary>
        public static readonly Eac3DrcRf NONE = new Eac3DrcRf("NONE");
        /// <summary>
        /// Constant SPEECH for Eac3DrcRf
        /// </summary>
        public static readonly Eac3DrcRf SPEECH = new Eac3DrcRf("SPEECH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3DrcRf(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3DrcRf FindValue(string value)
        {
            return FindValue<Eac3DrcRf>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3DrcRf(string value)
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
    /// Constants used for properties of type EmbeddedScte20Detection.
    /// </summary>
    public class EmbeddedScte20Detection : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for EmbeddedScte20Detection
        /// </summary>
        public static readonly EmbeddedScte20Detection AUTO = new EmbeddedScte20Detection("AUTO");
        /// <summary>
        /// Constant OFF for EmbeddedScte20Detection
        /// </summary>
        public static readonly EmbeddedScte20Detection OFF = new EmbeddedScte20Detection("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmbeddedScte20Detection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmbeddedScte20Detection FindValue(string value)
        {
            return FindValue<EmbeddedScte20Detection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmbeddedScte20Detection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FecOutputIncludeFec.
    /// </summary>
    public class FecOutputIncludeFec : ConstantClass
    {

        /// <summary>
        /// Constant COLUMN for FecOutputIncludeFec
        /// </summary>
        public static readonly FecOutputIncludeFec COLUMN = new FecOutputIncludeFec("COLUMN");
        /// <summary>
        /// Constant COLUMN_AND_ROW for FecOutputIncludeFec
        /// </summary>
        public static readonly FecOutputIncludeFec COLUMN_AND_ROW = new FecOutputIncludeFec("COLUMN_AND_ROW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FecOutputIncludeFec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FecOutputIncludeFec FindValue(string value)
        {
            return FindValue<FecOutputIncludeFec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FecOutputIncludeFec(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FixedAfd.
    /// </summary>
    public class FixedAfd : ConstantClass
    {

        /// <summary>
        /// Constant AFD_0000 for FixedAfd
        /// </summary>
        public static readonly FixedAfd AFD_0000 = new FixedAfd("AFD_0000");
        /// <summary>
        /// Constant AFD_0010 for FixedAfd
        /// </summary>
        public static readonly FixedAfd AFD_0010 = new FixedAfd("AFD_0010");
        /// <summary>
        /// Constant AFD_0011 for FixedAfd
        /// </summary>
        public static readonly FixedAfd AFD_0011 = new FixedAfd("AFD_0011");
        /// <summary>
        /// Constant AFD_0100 for FixedAfd
        /// </summary>
        public static readonly FixedAfd AFD_0100 = new FixedAfd("AFD_0100");
        /// <summary>
        /// Constant AFD_1000 for FixedAfd
        /// </summary>
        public static readonly FixedAfd AFD_1000 = new FixedAfd("AFD_1000");
        /// <summary>
        /// Constant AFD_1001 for FixedAfd
        /// </summary>
        public static readonly FixedAfd AFD_1001 = new FixedAfd("AFD_1001");
        /// <summary>
        /// Constant AFD_1010 for FixedAfd
        /// </summary>
        public static readonly FixedAfd AFD_1010 = new FixedAfd("AFD_1010");
        /// <summary>
        /// Constant AFD_1011 for FixedAfd
        /// </summary>
        public static readonly FixedAfd AFD_1011 = new FixedAfd("AFD_1011");
        /// <summary>
        /// Constant AFD_1101 for FixedAfd
        /// </summary>
        public static readonly FixedAfd AFD_1101 = new FixedAfd("AFD_1101");
        /// <summary>
        /// Constant AFD_1110 for FixedAfd
        /// </summary>
        public static readonly FixedAfd AFD_1110 = new FixedAfd("AFD_1110");
        /// <summary>
        /// Constant AFD_1111 for FixedAfd
        /// </summary>
        public static readonly FixedAfd AFD_1111 = new FixedAfd("AFD_1111");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FixedAfd(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FixedAfd FindValue(string value)
        {
            return FindValue<FixedAfd>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FixedAfd(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlobalConfigurationInputEndAction.
    /// </summary>
    public class GlobalConfigurationInputEndAction : ConstantClass
    {

        /// <summary>
        /// Constant NONE for GlobalConfigurationInputEndAction
        /// </summary>
        public static readonly GlobalConfigurationInputEndAction NONE = new GlobalConfigurationInputEndAction("NONE");
        /// <summary>
        /// Constant SWITCH_AND_LOOP_INPUTS for GlobalConfigurationInputEndAction
        /// </summary>
        public static readonly GlobalConfigurationInputEndAction SWITCH_AND_LOOP_INPUTS = new GlobalConfigurationInputEndAction("SWITCH_AND_LOOP_INPUTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlobalConfigurationInputEndAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlobalConfigurationInputEndAction FindValue(string value)
        {
            return FindValue<GlobalConfigurationInputEndAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlobalConfigurationInputEndAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlobalConfigurationLowFramerateInputs.
    /// </summary>
    public class GlobalConfigurationLowFramerateInputs : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for GlobalConfigurationLowFramerateInputs
        /// </summary>
        public static readonly GlobalConfigurationLowFramerateInputs DISABLED = new GlobalConfigurationLowFramerateInputs("DISABLED");
        /// <summary>
        /// Constant ENABLED for GlobalConfigurationLowFramerateInputs
        /// </summary>
        public static readonly GlobalConfigurationLowFramerateInputs ENABLED = new GlobalConfigurationLowFramerateInputs("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlobalConfigurationLowFramerateInputs(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlobalConfigurationLowFramerateInputs FindValue(string value)
        {
            return FindValue<GlobalConfigurationLowFramerateInputs>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlobalConfigurationLowFramerateInputs(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlobalConfigurationOutputTimingSource.
    /// </summary>
    public class GlobalConfigurationOutputTimingSource : ConstantClass
    {

        /// <summary>
        /// Constant INPUT_CLOCK for GlobalConfigurationOutputTimingSource
        /// </summary>
        public static readonly GlobalConfigurationOutputTimingSource INPUT_CLOCK = new GlobalConfigurationOutputTimingSource("INPUT_CLOCK");
        /// <summary>
        /// Constant SYSTEM_CLOCK for GlobalConfigurationOutputTimingSource
        /// </summary>
        public static readonly GlobalConfigurationOutputTimingSource SYSTEM_CLOCK = new GlobalConfigurationOutputTimingSource("SYSTEM_CLOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlobalConfigurationOutputTimingSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlobalConfigurationOutputTimingSource FindValue(string value)
        {
            return FindValue<GlobalConfigurationOutputTimingSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlobalConfigurationOutputTimingSource(string value)
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
    /// Constants used for properties of type H264ColorMetadata.
    /// </summary>
    public class H264ColorMetadata : ConstantClass
    {

        /// <summary>
        /// Constant IGNORE for H264ColorMetadata
        /// </summary>
        public static readonly H264ColorMetadata IGNORE = new H264ColorMetadata("IGNORE");
        /// <summary>
        /// Constant INSERT for H264ColorMetadata
        /// </summary>
        public static readonly H264ColorMetadata INSERT = new H264ColorMetadata("INSERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264ColorMetadata(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264ColorMetadata FindValue(string value)
        {
            return FindValue<H264ColorMetadata>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264ColorMetadata(string value)
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
    /// Constants used for properties of type H264FlickerAq.
    /// </summary>
    public class H264FlickerAq : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264FlickerAq
        /// </summary>
        public static readonly H264FlickerAq DISABLED = new H264FlickerAq("DISABLED");
        /// <summary>
        /// Constant ENABLED for H264FlickerAq
        /// </summary>
        public static readonly H264FlickerAq ENABLED = new H264FlickerAq("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264FlickerAq(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264FlickerAq FindValue(string value)
        {
            return FindValue<H264FlickerAq>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264FlickerAq(string value)
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
    /// Constants used for properties of type H264Level.
    /// </summary>
    public class H264Level : ConstantClass
    {

        /// <summary>
        /// Constant H264_LEVEL_1 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_1 = new H264Level("H264_LEVEL_1");
        /// <summary>
        /// Constant H264_LEVEL_1_1 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_1_1 = new H264Level("H264_LEVEL_1_1");
        /// <summary>
        /// Constant H264_LEVEL_1_2 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_1_2 = new H264Level("H264_LEVEL_1_2");
        /// <summary>
        /// Constant H264_LEVEL_1_3 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_1_3 = new H264Level("H264_LEVEL_1_3");
        /// <summary>
        /// Constant H264_LEVEL_2 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_2 = new H264Level("H264_LEVEL_2");
        /// <summary>
        /// Constant H264_LEVEL_2_1 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_2_1 = new H264Level("H264_LEVEL_2_1");
        /// <summary>
        /// Constant H264_LEVEL_2_2 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_2_2 = new H264Level("H264_LEVEL_2_2");
        /// <summary>
        /// Constant H264_LEVEL_3 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_3 = new H264Level("H264_LEVEL_3");
        /// <summary>
        /// Constant H264_LEVEL_3_1 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_3_1 = new H264Level("H264_LEVEL_3_1");
        /// <summary>
        /// Constant H264_LEVEL_3_2 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_3_2 = new H264Level("H264_LEVEL_3_2");
        /// <summary>
        /// Constant H264_LEVEL_4 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_4 = new H264Level("H264_LEVEL_4");
        /// <summary>
        /// Constant H264_LEVEL_4_1 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_4_1 = new H264Level("H264_LEVEL_4_1");
        /// <summary>
        /// Constant H264_LEVEL_4_2 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_4_2 = new H264Level("H264_LEVEL_4_2");
        /// <summary>
        /// Constant H264_LEVEL_5 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_5 = new H264Level("H264_LEVEL_5");
        /// <summary>
        /// Constant H264_LEVEL_5_1 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_5_1 = new H264Level("H264_LEVEL_5_1");
        /// <summary>
        /// Constant H264_LEVEL_5_2 for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_5_2 = new H264Level("H264_LEVEL_5_2");
        /// <summary>
        /// Constant H264_LEVEL_AUTO for H264Level
        /// </summary>
        public static readonly H264Level H264_LEVEL_AUTO = new H264Level("H264_LEVEL_AUTO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264Level(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264Level FindValue(string value)
        {
            return FindValue<H264Level>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264Level(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264LookAheadRateControl.
    /// </summary>
    public class H264LookAheadRateControl : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for H264LookAheadRateControl
        /// </summary>
        public static readonly H264LookAheadRateControl HIGH = new H264LookAheadRateControl("HIGH");
        /// <summary>
        /// Constant LOW for H264LookAheadRateControl
        /// </summary>
        public static readonly H264LookAheadRateControl LOW = new H264LookAheadRateControl("LOW");
        /// <summary>
        /// Constant MEDIUM for H264LookAheadRateControl
        /// </summary>
        public static readonly H264LookAheadRateControl MEDIUM = new H264LookAheadRateControl("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264LookAheadRateControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264LookAheadRateControl FindValue(string value)
        {
            return FindValue<H264LookAheadRateControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264LookAheadRateControl(string value)
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
    /// Constants used for properties of type H264Profile.
    /// </summary>
    public class H264Profile : ConstantClass
    {

        /// <summary>
        /// Constant BASELINE for H264Profile
        /// </summary>
        public static readonly H264Profile BASELINE = new H264Profile("BASELINE");
        /// <summary>
        /// Constant HIGH for H264Profile
        /// </summary>
        public static readonly H264Profile HIGH = new H264Profile("HIGH");
        /// <summary>
        /// Constant HIGH_10BIT for H264Profile
        /// </summary>
        public static readonly H264Profile HIGH_10BIT = new H264Profile("HIGH_10BIT");
        /// <summary>
        /// Constant HIGH_422 for H264Profile
        /// </summary>
        public static readonly H264Profile HIGH_422 = new H264Profile("HIGH_422");
        /// <summary>
        /// Constant HIGH_422_10BIT for H264Profile
        /// </summary>
        public static readonly H264Profile HIGH_422_10BIT = new H264Profile("HIGH_422_10BIT");
        /// <summary>
        /// Constant MAIN for H264Profile
        /// </summary>
        public static readonly H264Profile MAIN = new H264Profile("MAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264Profile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264Profile FindValue(string value)
        {
            return FindValue<H264Profile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264Profile(string value)
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
    /// Constants used for properties of type H264ScanType.
    /// </summary>
    public class H264ScanType : ConstantClass
    {

        /// <summary>
        /// Constant INTERLACED for H264ScanType
        /// </summary>
        public static readonly H264ScanType INTERLACED = new H264ScanType("INTERLACED");
        /// <summary>
        /// Constant PROGRESSIVE for H264ScanType
        /// </summary>
        public static readonly H264ScanType PROGRESSIVE = new H264ScanType("PROGRESSIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264ScanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264ScanType FindValue(string value)
        {
            return FindValue<H264ScanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264ScanType(string value)
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
    /// Constants used for properties of type H264SpatialAq.
    /// </summary>
    public class H264SpatialAq : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264SpatialAq
        /// </summary>
        public static readonly H264SpatialAq DISABLED = new H264SpatialAq("DISABLED");
        /// <summary>
        /// Constant ENABLED for H264SpatialAq
        /// </summary>
        public static readonly H264SpatialAq ENABLED = new H264SpatialAq("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264SpatialAq(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264SpatialAq FindValue(string value)
        {
            return FindValue<H264SpatialAq>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264SpatialAq(string value)
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
    /// Constants used for properties of type H264TemporalAq.
    /// </summary>
    public class H264TemporalAq : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264TemporalAq
        /// </summary>
        public static readonly H264TemporalAq DISABLED = new H264TemporalAq("DISABLED");
        /// <summary>
        /// Constant ENABLED for H264TemporalAq
        /// </summary>
        public static readonly H264TemporalAq ENABLED = new H264TemporalAq("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264TemporalAq(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264TemporalAq FindValue(string value)
        {
            return FindValue<H264TemporalAq>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264TemporalAq(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H264TimecodeInsertionBehavior.
    /// </summary>
    public class H264TimecodeInsertionBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264TimecodeInsertionBehavior
        /// </summary>
        public static readonly H264TimecodeInsertionBehavior DISABLED = new H264TimecodeInsertionBehavior("DISABLED");
        /// <summary>
        /// Constant PIC_TIMING_SEI for H264TimecodeInsertionBehavior
        /// </summary>
        public static readonly H264TimecodeInsertionBehavior PIC_TIMING_SEI = new H264TimecodeInsertionBehavior("PIC_TIMING_SEI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264TimecodeInsertionBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264TimecodeInsertionBehavior FindValue(string value)
        {
            return FindValue<H264TimecodeInsertionBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264TimecodeInsertionBehavior(string value)
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
        /// Constant ADOBE for HlsAdMarkers
        /// </summary>
        public static readonly HlsAdMarkers ADOBE = new HlsAdMarkers("ADOBE");
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
    /// Constants used for properties of type HlsAkamaiHttpTransferMode.
    /// </summary>
    public class HlsAkamaiHttpTransferMode : ConstantClass
    {

        /// <summary>
        /// Constant CHUNKED for HlsAkamaiHttpTransferMode
        /// </summary>
        public static readonly HlsAkamaiHttpTransferMode CHUNKED = new HlsAkamaiHttpTransferMode("CHUNKED");
        /// <summary>
        /// Constant NON_CHUNKED for HlsAkamaiHttpTransferMode
        /// </summary>
        public static readonly HlsAkamaiHttpTransferMode NON_CHUNKED = new HlsAkamaiHttpTransferMode("NON_CHUNKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsAkamaiHttpTransferMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsAkamaiHttpTransferMode FindValue(string value)
        {
            return FindValue<HlsAkamaiHttpTransferMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsAkamaiHttpTransferMode(string value)
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
    /// Constants used for properties of type HlsIvInManifest.
    /// </summary>
    public class HlsIvInManifest : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for HlsIvInManifest
        /// </summary>
        public static readonly HlsIvInManifest EXCLUDE = new HlsIvInManifest("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for HlsIvInManifest
        /// </summary>
        public static readonly HlsIvInManifest INCLUDE = new HlsIvInManifest("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsIvInManifest(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsIvInManifest FindValue(string value)
        {
            return FindValue<HlsIvInManifest>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsIvInManifest(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsIvSource.
    /// </summary>
    public class HlsIvSource : ConstantClass
    {

        /// <summary>
        /// Constant EXPLICIT for HlsIvSource
        /// </summary>
        public static readonly HlsIvSource EXPLICIT = new HlsIvSource("EXPLICIT");
        /// <summary>
        /// Constant FOLLOWS_SEGMENT_NUMBER for HlsIvSource
        /// </summary>
        public static readonly HlsIvSource FOLLOWS_SEGMENT_NUMBER = new HlsIvSource("FOLLOWS_SEGMENT_NUMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsIvSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsIvSource FindValue(string value)
        {
            return FindValue<HlsIvSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsIvSource(string value)
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
    /// Constants used for properties of type HlsMediaStoreStorageClass.
    /// </summary>
    public class HlsMediaStoreStorageClass : ConstantClass
    {

        /// <summary>
        /// Constant TEMPORAL for HlsMediaStoreStorageClass
        /// </summary>
        public static readonly HlsMediaStoreStorageClass TEMPORAL = new HlsMediaStoreStorageClass("TEMPORAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsMediaStoreStorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsMediaStoreStorageClass FindValue(string value)
        {
            return FindValue<HlsMediaStoreStorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsMediaStoreStorageClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsMode.
    /// </summary>
    public class HlsMode : ConstantClass
    {

        /// <summary>
        /// Constant LIVE for HlsMode
        /// </summary>
        public static readonly HlsMode LIVE = new HlsMode("LIVE");
        /// <summary>
        /// Constant VOD for HlsMode
        /// </summary>
        public static readonly HlsMode VOD = new HlsMode("VOD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsMode FindValue(string value)
        {
            return FindValue<HlsMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsMode(string value)
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
    /// Constants used for properties of type HlsSegmentationMode.
    /// </summary>
    public class HlsSegmentationMode : ConstantClass
    {

        /// <summary>
        /// Constant USE_INPUT_SEGMENTATION for HlsSegmentationMode
        /// </summary>
        public static readonly HlsSegmentationMode USE_INPUT_SEGMENTATION = new HlsSegmentationMode("USE_INPUT_SEGMENTATION");
        /// <summary>
        /// Constant USE_SEGMENT_DURATION for HlsSegmentationMode
        /// </summary>
        public static readonly HlsSegmentationMode USE_SEGMENT_DURATION = new HlsSegmentationMode("USE_SEGMENT_DURATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsSegmentationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsSegmentationMode FindValue(string value)
        {
            return FindValue<HlsSegmentationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsSegmentationMode(string value)
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
    /// Constants used for properties of type HlsTsFileMode.
    /// </summary>
    public class HlsTsFileMode : ConstantClass
    {

        /// <summary>
        /// Constant SEGMENTED_FILES for HlsTsFileMode
        /// </summary>
        public static readonly HlsTsFileMode SEGMENTED_FILES = new HlsTsFileMode("SEGMENTED_FILES");
        /// <summary>
        /// Constant SINGLE_FILE for HlsTsFileMode
        /// </summary>
        public static readonly HlsTsFileMode SINGLE_FILE = new HlsTsFileMode("SINGLE_FILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsTsFileMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsTsFileMode FindValue(string value)
        {
            return FindValue<HlsTsFileMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsTsFileMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsWebdavHttpTransferMode.
    /// </summary>
    public class HlsWebdavHttpTransferMode : ConstantClass
    {

        /// <summary>
        /// Constant CHUNKED for HlsWebdavHttpTransferMode
        /// </summary>
        public static readonly HlsWebdavHttpTransferMode CHUNKED = new HlsWebdavHttpTransferMode("CHUNKED");
        /// <summary>
        /// Constant NON_CHUNKED for HlsWebdavHttpTransferMode
        /// </summary>
        public static readonly HlsWebdavHttpTransferMode NON_CHUNKED = new HlsWebdavHttpTransferMode("NON_CHUNKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsWebdavHttpTransferMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsWebdavHttpTransferMode FindValue(string value)
        {
            return FindValue<HlsWebdavHttpTransferMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsWebdavHttpTransferMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputCodec.
    /// </summary>
    public class InputCodec : ConstantClass
    {

        /// <summary>
        /// Constant AVC for InputCodec
        /// </summary>
        public static readonly InputCodec AVC = new InputCodec("AVC");
        /// <summary>
        /// Constant HEVC for InputCodec
        /// </summary>
        public static readonly InputCodec HEVC = new InputCodec("HEVC");
        /// <summary>
        /// Constant MPEG2 for InputCodec
        /// </summary>
        public static readonly InputCodec MPEG2 = new InputCodec("MPEG2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputCodec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputCodec FindValue(string value)
        {
            return FindValue<InputCodec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputCodec(string value)
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
    /// Constants used for properties of type InputFilter.
    /// </summary>
    public class InputFilter : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for InputFilter
        /// </summary>
        public static readonly InputFilter AUTO = new InputFilter("AUTO");
        /// <summary>
        /// Constant DISABLED for InputFilter
        /// </summary>
        public static readonly InputFilter DISABLED = new InputFilter("DISABLED");
        /// <summary>
        /// Constant FORCED for InputFilter
        /// </summary>
        public static readonly InputFilter FORCED = new InputFilter("FORCED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputFilter FindValue(string value)
        {
            return FindValue<InputFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputLossActionForHlsOut.
    /// </summary>
    public class InputLossActionForHlsOut : ConstantClass
    {

        /// <summary>
        /// Constant EMIT_OUTPUT for InputLossActionForHlsOut
        /// </summary>
        public static readonly InputLossActionForHlsOut EMIT_OUTPUT = new InputLossActionForHlsOut("EMIT_OUTPUT");
        /// <summary>
        /// Constant PAUSE_OUTPUT for InputLossActionForHlsOut
        /// </summary>
        public static readonly InputLossActionForHlsOut PAUSE_OUTPUT = new InputLossActionForHlsOut("PAUSE_OUTPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputLossActionForHlsOut(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputLossActionForHlsOut FindValue(string value)
        {
            return FindValue<InputLossActionForHlsOut>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputLossActionForHlsOut(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputLossActionForMsSmoothOut.
    /// </summary>
    public class InputLossActionForMsSmoothOut : ConstantClass
    {

        /// <summary>
        /// Constant EMIT_OUTPUT for InputLossActionForMsSmoothOut
        /// </summary>
        public static readonly InputLossActionForMsSmoothOut EMIT_OUTPUT = new InputLossActionForMsSmoothOut("EMIT_OUTPUT");
        /// <summary>
        /// Constant PAUSE_OUTPUT for InputLossActionForMsSmoothOut
        /// </summary>
        public static readonly InputLossActionForMsSmoothOut PAUSE_OUTPUT = new InputLossActionForMsSmoothOut("PAUSE_OUTPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputLossActionForMsSmoothOut(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputLossActionForMsSmoothOut FindValue(string value)
        {
            return FindValue<InputLossActionForMsSmoothOut>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputLossActionForMsSmoothOut(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputLossActionForUdpOut.
    /// </summary>
    public class InputLossActionForUdpOut : ConstantClass
    {

        /// <summary>
        /// Constant DROP_PROGRAM for InputLossActionForUdpOut
        /// </summary>
        public static readonly InputLossActionForUdpOut DROP_PROGRAM = new InputLossActionForUdpOut("DROP_PROGRAM");
        /// <summary>
        /// Constant DROP_TS for InputLossActionForUdpOut
        /// </summary>
        public static readonly InputLossActionForUdpOut DROP_TS = new InputLossActionForUdpOut("DROP_TS");
        /// <summary>
        /// Constant EMIT_PROGRAM for InputLossActionForUdpOut
        /// </summary>
        public static readonly InputLossActionForUdpOut EMIT_PROGRAM = new InputLossActionForUdpOut("EMIT_PROGRAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputLossActionForUdpOut(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputLossActionForUdpOut FindValue(string value)
        {
            return FindValue<InputLossActionForUdpOut>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputLossActionForUdpOut(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputLossImageType.
    /// </summary>
    public class InputLossImageType : ConstantClass
    {

        /// <summary>
        /// Constant COLOR for InputLossImageType
        /// </summary>
        public static readonly InputLossImageType COLOR = new InputLossImageType("COLOR");
        /// <summary>
        /// Constant SLATE for InputLossImageType
        /// </summary>
        public static readonly InputLossImageType SLATE = new InputLossImageType("SLATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputLossImageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputLossImageType FindValue(string value)
        {
            return FindValue<InputLossImageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputLossImageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputMaximumBitrate.
    /// </summary>
    public class InputMaximumBitrate : ConstantClass
    {

        /// <summary>
        /// Constant MAX_10_MBPS for InputMaximumBitrate
        /// </summary>
        public static readonly InputMaximumBitrate MAX_10_MBPS = new InputMaximumBitrate("MAX_10_MBPS");
        /// <summary>
        /// Constant MAX_20_MBPS for InputMaximumBitrate
        /// </summary>
        public static readonly InputMaximumBitrate MAX_20_MBPS = new InputMaximumBitrate("MAX_20_MBPS");
        /// <summary>
        /// Constant MAX_50_MBPS for InputMaximumBitrate
        /// </summary>
        public static readonly InputMaximumBitrate MAX_50_MBPS = new InputMaximumBitrate("MAX_50_MBPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputMaximumBitrate(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputMaximumBitrate FindValue(string value)
        {
            return FindValue<InputMaximumBitrate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputMaximumBitrate(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputResolution.
    /// </summary>
    public class InputResolution : ConstantClass
    {

        /// <summary>
        /// Constant HD for InputResolution
        /// </summary>
        public static readonly InputResolution HD = new InputResolution("HD");
        /// <summary>
        /// Constant SD for InputResolution
        /// </summary>
        public static readonly InputResolution SD = new InputResolution("SD");
        /// <summary>
        /// Constant UHD for InputResolution
        /// </summary>
        public static readonly InputResolution UHD = new InputResolution("UHD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputResolution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputResolution FindValue(string value)
        {
            return FindValue<InputResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputResolution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputSecurityGroupState.
    /// </summary>
    public class InputSecurityGroupState : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for InputSecurityGroupState
        /// </summary>
        public static readonly InputSecurityGroupState DELETED = new InputSecurityGroupState("DELETED");
        /// <summary>
        /// Constant IDLE for InputSecurityGroupState
        /// </summary>
        public static readonly InputSecurityGroupState IDLE = new InputSecurityGroupState("IDLE");
        /// <summary>
        /// Constant IN_USE for InputSecurityGroupState
        /// </summary>
        public static readonly InputSecurityGroupState IN_USE = new InputSecurityGroupState("IN_USE");
        /// <summary>
        /// Constant UPDATING for InputSecurityGroupState
        /// </summary>
        public static readonly InputSecurityGroupState UPDATING = new InputSecurityGroupState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputSecurityGroupState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputSecurityGroupState FindValue(string value)
        {
            return FindValue<InputSecurityGroupState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputSecurityGroupState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputSourceEndBehavior.
    /// </summary>
    public class InputSourceEndBehavior : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUE for InputSourceEndBehavior
        /// </summary>
        public static readonly InputSourceEndBehavior CONTINUE = new InputSourceEndBehavior("CONTINUE");
        /// <summary>
        /// Constant LOOP for InputSourceEndBehavior
        /// </summary>
        public static readonly InputSourceEndBehavior LOOP = new InputSourceEndBehavior("LOOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputSourceEndBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputSourceEndBehavior FindValue(string value)
        {
            return FindValue<InputSourceEndBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputSourceEndBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputState.
    /// </summary>
    public class InputState : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHED for InputState
        /// </summary>
        public static readonly InputState ATTACHED = new InputState("ATTACHED");
        /// <summary>
        /// Constant CREATING for InputState
        /// </summary>
        public static readonly InputState CREATING = new InputState("CREATING");
        /// <summary>
        /// Constant DELETED for InputState
        /// </summary>
        public static readonly InputState DELETED = new InputState("DELETED");
        /// <summary>
        /// Constant DELETING for InputState
        /// </summary>
        public static readonly InputState DELETING = new InputState("DELETING");
        /// <summary>
        /// Constant DETACHED for InputState
        /// </summary>
        public static readonly InputState DETACHED = new InputState("DETACHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputState FindValue(string value)
        {
            return FindValue<InputState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputType.
    /// </summary>
    public class InputType : ConstantClass
    {

        /// <summary>
        /// Constant RTMP_PULL for InputType
        /// </summary>
        public static readonly InputType RTMP_PULL = new InputType("RTMP_PULL");
        /// <summary>
        /// Constant RTMP_PUSH for InputType
        /// </summary>
        public static readonly InputType RTMP_PUSH = new InputType("RTMP_PUSH");
        /// <summary>
        /// Constant RTP_PUSH for InputType
        /// </summary>
        public static readonly InputType RTP_PUSH = new InputType("RTP_PUSH");
        /// <summary>
        /// Constant UDP_PUSH for InputType
        /// </summary>
        public static readonly InputType UDP_PUSH = new InputType("UDP_PUSH");
        /// <summary>
        /// Constant URL_PULL for InputType
        /// </summary>
        public static readonly InputType URL_PULL = new InputType("URL_PULL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputType FindValue(string value)
        {
            return FindValue<InputType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsAbsentInputAudioBehavior.
    /// </summary>
    public class M2tsAbsentInputAudioBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DROP for M2tsAbsentInputAudioBehavior
        /// </summary>
        public static readonly M2tsAbsentInputAudioBehavior DROP = new M2tsAbsentInputAudioBehavior("DROP");
        /// <summary>
        /// Constant ENCODE_SILENCE for M2tsAbsentInputAudioBehavior
        /// </summary>
        public static readonly M2tsAbsentInputAudioBehavior ENCODE_SILENCE = new M2tsAbsentInputAudioBehavior("ENCODE_SILENCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsAbsentInputAudioBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsAbsentInputAudioBehavior FindValue(string value)
        {
            return FindValue<M2tsAbsentInputAudioBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsAbsentInputAudioBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsArib.
    /// </summary>
    public class M2tsArib : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for M2tsArib
        /// </summary>
        public static readonly M2tsArib DISABLED = new M2tsArib("DISABLED");
        /// <summary>
        /// Constant ENABLED for M2tsArib
        /// </summary>
        public static readonly M2tsArib ENABLED = new M2tsArib("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsArib(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsArib FindValue(string value)
        {
            return FindValue<M2tsArib>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsArib(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsAribCaptionsPidControl.
    /// </summary>
    public class M2tsAribCaptionsPidControl : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for M2tsAribCaptionsPidControl
        /// </summary>
        public static readonly M2tsAribCaptionsPidControl AUTO = new M2tsAribCaptionsPidControl("AUTO");
        /// <summary>
        /// Constant USE_CONFIGURED for M2tsAribCaptionsPidControl
        /// </summary>
        public static readonly M2tsAribCaptionsPidControl USE_CONFIGURED = new M2tsAribCaptionsPidControl("USE_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsAribCaptionsPidControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsAribCaptionsPidControl FindValue(string value)
        {
            return FindValue<M2tsAribCaptionsPidControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsAribCaptionsPidControl(string value)
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
    /// Constants used for properties of type M2tsAudioInterval.
    /// </summary>
    public class M2tsAudioInterval : ConstantClass
    {

        /// <summary>
        /// Constant VIDEO_AND_FIXED_INTERVALS for M2tsAudioInterval
        /// </summary>
        public static readonly M2tsAudioInterval VIDEO_AND_FIXED_INTERVALS = new M2tsAudioInterval("VIDEO_AND_FIXED_INTERVALS");
        /// <summary>
        /// Constant VIDEO_INTERVAL for M2tsAudioInterval
        /// </summary>
        public static readonly M2tsAudioInterval VIDEO_INTERVAL = new M2tsAudioInterval("VIDEO_INTERVAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsAudioInterval(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsAudioInterval FindValue(string value)
        {
            return FindValue<M2tsAudioInterval>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsAudioInterval(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsAudioStreamType.
    /// </summary>
    public class M2tsAudioStreamType : ConstantClass
    {

        /// <summary>
        /// Constant ATSC for M2tsAudioStreamType
        /// </summary>
        public static readonly M2tsAudioStreamType ATSC = new M2tsAudioStreamType("ATSC");
        /// <summary>
        /// Constant DVB for M2tsAudioStreamType
        /// </summary>
        public static readonly M2tsAudioStreamType DVB = new M2tsAudioStreamType("DVB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsAudioStreamType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsAudioStreamType FindValue(string value)
        {
            return FindValue<M2tsAudioStreamType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsAudioStreamType(string value)
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
    /// Constants used for properties of type M2tsCcDescriptor.
    /// </summary>
    public class M2tsCcDescriptor : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for M2tsCcDescriptor
        /// </summary>
        public static readonly M2tsCcDescriptor DISABLED = new M2tsCcDescriptor("DISABLED");
        /// <summary>
        /// Constant ENABLED for M2tsCcDescriptor
        /// </summary>
        public static readonly M2tsCcDescriptor ENABLED = new M2tsCcDescriptor("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsCcDescriptor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsCcDescriptor FindValue(string value)
        {
            return FindValue<M2tsCcDescriptor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsCcDescriptor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2tsEbifControl.
    /// </summary>
    public class M2tsEbifControl : ConstantClass
    {

        /// <summary>
        /// Constant NONE for M2tsEbifControl
        /// </summary>
        public static readonly M2tsEbifControl NONE = new M2tsEbifControl("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for M2tsEbifControl
        /// </summary>
        public static readonly M2tsEbifControl PASSTHROUGH = new M2tsEbifControl("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsEbifControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsEbifControl FindValue(string value)
        {
            return FindValue<M2tsEbifControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsEbifControl(string value)
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
    /// Constants used for properties of type M2tsKlv.
    /// </summary>
    public class M2tsKlv : ConstantClass
    {

        /// <summary>
        /// Constant NONE for M2tsKlv
        /// </summary>
        public static readonly M2tsKlv NONE = new M2tsKlv("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for M2tsKlv
        /// </summary>
        public static readonly M2tsKlv PASSTHROUGH = new M2tsKlv("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsKlv(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsKlv FindValue(string value)
        {
            return FindValue<M2tsKlv>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsKlv(string value)
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
    /// Constants used for properties of type M2tsScte35Control.
    /// </summary>
    public class M2tsScte35Control : ConstantClass
    {

        /// <summary>
        /// Constant NONE for M2tsScte35Control
        /// </summary>
        public static readonly M2tsScte35Control NONE = new M2tsScte35Control("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for M2tsScte35Control
        /// </summary>
        public static readonly M2tsScte35Control PASSTHROUGH = new M2tsScte35Control("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsScte35Control(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsScte35Control FindValue(string value)
        {
            return FindValue<M2tsScte35Control>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsScte35Control(string value)
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
    /// Constants used for properties of type M2tsTimedMetadataBehavior.
    /// </summary>
    public class M2tsTimedMetadataBehavior : ConstantClass
    {

        /// <summary>
        /// Constant NO_PASSTHROUGH for M2tsTimedMetadataBehavior
        /// </summary>
        public static readonly M2tsTimedMetadataBehavior NO_PASSTHROUGH = new M2tsTimedMetadataBehavior("NO_PASSTHROUGH");
        /// <summary>
        /// Constant PASSTHROUGH for M2tsTimedMetadataBehavior
        /// </summary>
        public static readonly M2tsTimedMetadataBehavior PASSTHROUGH = new M2tsTimedMetadataBehavior("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsTimedMetadataBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsTimedMetadataBehavior FindValue(string value)
        {
            return FindValue<M2tsTimedMetadataBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsTimedMetadataBehavior(string value)
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
    /// Constants used for properties of type M3u8Scte35Behavior.
    /// </summary>
    public class M3u8Scte35Behavior : ConstantClass
    {

        /// <summary>
        /// Constant NO_PASSTHROUGH for M3u8Scte35Behavior
        /// </summary>
        public static readonly M3u8Scte35Behavior NO_PASSTHROUGH = new M3u8Scte35Behavior("NO_PASSTHROUGH");
        /// <summary>
        /// Constant PASSTHROUGH for M3u8Scte35Behavior
        /// </summary>
        public static readonly M3u8Scte35Behavior PASSTHROUGH = new M3u8Scte35Behavior("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M3u8Scte35Behavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M3u8Scte35Behavior FindValue(string value)
        {
            return FindValue<M3u8Scte35Behavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M3u8Scte35Behavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M3u8TimedMetadataBehavior.
    /// </summary>
    public class M3u8TimedMetadataBehavior : ConstantClass
    {

        /// <summary>
        /// Constant NO_PASSTHROUGH for M3u8TimedMetadataBehavior
        /// </summary>
        public static readonly M3u8TimedMetadataBehavior NO_PASSTHROUGH = new M3u8TimedMetadataBehavior("NO_PASSTHROUGH");
        /// <summary>
        /// Constant PASSTHROUGH for M3u8TimedMetadataBehavior
        /// </summary>
        public static readonly M3u8TimedMetadataBehavior PASSTHROUGH = new M3u8TimedMetadataBehavior("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M3u8TimedMetadataBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M3u8TimedMetadataBehavior FindValue(string value)
        {
            return FindValue<M3u8TimedMetadataBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M3u8TimedMetadataBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mp2CodingMode.
    /// </summary>
    public class Mp2CodingMode : ConstantClass
    {

        /// <summary>
        /// Constant CODING_MODE_1_0 for Mp2CodingMode
        /// </summary>
        public static readonly Mp2CodingMode CODING_MODE_1_0 = new Mp2CodingMode("CODING_MODE_1_0");
        /// <summary>
        /// Constant CODING_MODE_2_0 for Mp2CodingMode
        /// </summary>
        public static readonly Mp2CodingMode CODING_MODE_2_0 = new Mp2CodingMode("CODING_MODE_2_0");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mp2CodingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mp2CodingMode FindValue(string value)
        {
            return FindValue<Mp2CodingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mp2CodingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkInputServerValidation.
    /// </summary>
    public class NetworkInputServerValidation : ConstantClass
    {

        /// <summary>
        /// Constant CHECK_CRYPTOGRAPHY_AND_VALIDATE_NAME for NetworkInputServerValidation
        /// </summary>
        public static readonly NetworkInputServerValidation CHECK_CRYPTOGRAPHY_AND_VALIDATE_NAME = new NetworkInputServerValidation("CHECK_CRYPTOGRAPHY_AND_VALIDATE_NAME");
        /// <summary>
        /// Constant CHECK_CRYPTOGRAPHY_ONLY for NetworkInputServerValidation
        /// </summary>
        public static readonly NetworkInputServerValidation CHECK_CRYPTOGRAPHY_ONLY = new NetworkInputServerValidation("CHECK_CRYPTOGRAPHY_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkInputServerValidation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkInputServerValidation FindValue(string value)
        {
            return FindValue<NetworkInputServerValidation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkInputServerValidation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RtmpCacheFullBehavior.
    /// </summary>
    public class RtmpCacheFullBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DISCONNECT_IMMEDIATELY for RtmpCacheFullBehavior
        /// </summary>
        public static readonly RtmpCacheFullBehavior DISCONNECT_IMMEDIATELY = new RtmpCacheFullBehavior("DISCONNECT_IMMEDIATELY");
        /// <summary>
        /// Constant WAIT_FOR_SERVER for RtmpCacheFullBehavior
        /// </summary>
        public static readonly RtmpCacheFullBehavior WAIT_FOR_SERVER = new RtmpCacheFullBehavior("WAIT_FOR_SERVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RtmpCacheFullBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RtmpCacheFullBehavior FindValue(string value)
        {
            return FindValue<RtmpCacheFullBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RtmpCacheFullBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RtmpCaptionData.
    /// </summary>
    public class RtmpCaptionData : ConstantClass
    {

        /// <summary>
        /// Constant ALL for RtmpCaptionData
        /// </summary>
        public static readonly RtmpCaptionData ALL = new RtmpCaptionData("ALL");
        /// <summary>
        /// Constant FIELD1_608 for RtmpCaptionData
        /// </summary>
        public static readonly RtmpCaptionData FIELD1_608 = new RtmpCaptionData("FIELD1_608");
        /// <summary>
        /// Constant FIELD1_AND_FIELD2_608 for RtmpCaptionData
        /// </summary>
        public static readonly RtmpCaptionData FIELD1_AND_FIELD2_608 = new RtmpCaptionData("FIELD1_AND_FIELD2_608");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RtmpCaptionData(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RtmpCaptionData FindValue(string value)
        {
            return FindValue<RtmpCaptionData>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RtmpCaptionData(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RtmpOutputCertificateMode.
    /// </summary>
    public class RtmpOutputCertificateMode : ConstantClass
    {

        /// <summary>
        /// Constant SELF_SIGNED for RtmpOutputCertificateMode
        /// </summary>
        public static readonly RtmpOutputCertificateMode SELF_SIGNED = new RtmpOutputCertificateMode("SELF_SIGNED");
        /// <summary>
        /// Constant VERIFY_AUTHENTICITY for RtmpOutputCertificateMode
        /// </summary>
        public static readonly RtmpOutputCertificateMode VERIFY_AUTHENTICITY = new RtmpOutputCertificateMode("VERIFY_AUTHENTICITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RtmpOutputCertificateMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RtmpOutputCertificateMode FindValue(string value)
        {
            return FindValue<RtmpOutputCertificateMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RtmpOutputCertificateMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scte20Convert608To708.
    /// </summary>
    public class Scte20Convert608To708 : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Scte20Convert608To708
        /// </summary>
        public static readonly Scte20Convert608To708 DISABLED = new Scte20Convert608To708("DISABLED");
        /// <summary>
        /// Constant UPCONVERT for Scte20Convert608To708
        /// </summary>
        public static readonly Scte20Convert608To708 UPCONVERT = new Scte20Convert608To708("UPCONVERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scte20Convert608To708(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scte20Convert608To708 FindValue(string value)
        {
            return FindValue<Scte20Convert608To708>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scte20Convert608To708(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scte35AposNoRegionalBlackoutBehavior.
    /// </summary>
    public class Scte35AposNoRegionalBlackoutBehavior : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW for Scte35AposNoRegionalBlackoutBehavior
        /// </summary>
        public static readonly Scte35AposNoRegionalBlackoutBehavior FOLLOW = new Scte35AposNoRegionalBlackoutBehavior("FOLLOW");
        /// <summary>
        /// Constant IGNORE for Scte35AposNoRegionalBlackoutBehavior
        /// </summary>
        public static readonly Scte35AposNoRegionalBlackoutBehavior IGNORE = new Scte35AposNoRegionalBlackoutBehavior("IGNORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scte35AposNoRegionalBlackoutBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scte35AposNoRegionalBlackoutBehavior FindValue(string value)
        {
            return FindValue<Scte35AposNoRegionalBlackoutBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scte35AposNoRegionalBlackoutBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scte35AposWebDeliveryAllowedBehavior.
    /// </summary>
    public class Scte35AposWebDeliveryAllowedBehavior : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW for Scte35AposWebDeliveryAllowedBehavior
        /// </summary>
        public static readonly Scte35AposWebDeliveryAllowedBehavior FOLLOW = new Scte35AposWebDeliveryAllowedBehavior("FOLLOW");
        /// <summary>
        /// Constant IGNORE for Scte35AposWebDeliveryAllowedBehavior
        /// </summary>
        public static readonly Scte35AposWebDeliveryAllowedBehavior IGNORE = new Scte35AposWebDeliveryAllowedBehavior("IGNORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scte35AposWebDeliveryAllowedBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scte35AposWebDeliveryAllowedBehavior FindValue(string value)
        {
            return FindValue<Scte35AposWebDeliveryAllowedBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scte35AposWebDeliveryAllowedBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scte35SpliceInsertNoRegionalBlackoutBehavior.
    /// </summary>
    public class Scte35SpliceInsertNoRegionalBlackoutBehavior : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW for Scte35SpliceInsertNoRegionalBlackoutBehavior
        /// </summary>
        public static readonly Scte35SpliceInsertNoRegionalBlackoutBehavior FOLLOW = new Scte35SpliceInsertNoRegionalBlackoutBehavior("FOLLOW");
        /// <summary>
        /// Constant IGNORE for Scte35SpliceInsertNoRegionalBlackoutBehavior
        /// </summary>
        public static readonly Scte35SpliceInsertNoRegionalBlackoutBehavior IGNORE = new Scte35SpliceInsertNoRegionalBlackoutBehavior("IGNORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scte35SpliceInsertNoRegionalBlackoutBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scte35SpliceInsertNoRegionalBlackoutBehavior FindValue(string value)
        {
            return FindValue<Scte35SpliceInsertNoRegionalBlackoutBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scte35SpliceInsertNoRegionalBlackoutBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scte35SpliceInsertWebDeliveryAllowedBehavior.
    /// </summary>
    public class Scte35SpliceInsertWebDeliveryAllowedBehavior : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW for Scte35SpliceInsertWebDeliveryAllowedBehavior
        /// </summary>
        public static readonly Scte35SpliceInsertWebDeliveryAllowedBehavior FOLLOW = new Scte35SpliceInsertWebDeliveryAllowedBehavior("FOLLOW");
        /// <summary>
        /// Constant IGNORE for Scte35SpliceInsertWebDeliveryAllowedBehavior
        /// </summary>
        public static readonly Scte35SpliceInsertWebDeliveryAllowedBehavior IGNORE = new Scte35SpliceInsertWebDeliveryAllowedBehavior("IGNORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scte35SpliceInsertWebDeliveryAllowedBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scte35SpliceInsertWebDeliveryAllowedBehavior FindValue(string value)
        {
            return FindValue<Scte35SpliceInsertWebDeliveryAllowedBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scte35SpliceInsertWebDeliveryAllowedBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SmoothGroupAudioOnlyTimecodeControl.
    /// </summary>
    public class SmoothGroupAudioOnlyTimecodeControl : ConstantClass
    {

        /// <summary>
        /// Constant PASSTHROUGH for SmoothGroupAudioOnlyTimecodeControl
        /// </summary>
        public static readonly SmoothGroupAudioOnlyTimecodeControl PASSTHROUGH = new SmoothGroupAudioOnlyTimecodeControl("PASSTHROUGH");
        /// <summary>
        /// Constant USE_CONFIGURED_CLOCK for SmoothGroupAudioOnlyTimecodeControl
        /// </summary>
        public static readonly SmoothGroupAudioOnlyTimecodeControl USE_CONFIGURED_CLOCK = new SmoothGroupAudioOnlyTimecodeControl("USE_CONFIGURED_CLOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SmoothGroupAudioOnlyTimecodeControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SmoothGroupAudioOnlyTimecodeControl FindValue(string value)
        {
            return FindValue<SmoothGroupAudioOnlyTimecodeControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SmoothGroupAudioOnlyTimecodeControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SmoothGroupCertificateMode.
    /// </summary>
    public class SmoothGroupCertificateMode : ConstantClass
    {

        /// <summary>
        /// Constant SELF_SIGNED for SmoothGroupCertificateMode
        /// </summary>
        public static readonly SmoothGroupCertificateMode SELF_SIGNED = new SmoothGroupCertificateMode("SELF_SIGNED");
        /// <summary>
        /// Constant VERIFY_AUTHENTICITY for SmoothGroupCertificateMode
        /// </summary>
        public static readonly SmoothGroupCertificateMode VERIFY_AUTHENTICITY = new SmoothGroupCertificateMode("VERIFY_AUTHENTICITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SmoothGroupCertificateMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SmoothGroupCertificateMode FindValue(string value)
        {
            return FindValue<SmoothGroupCertificateMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SmoothGroupCertificateMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SmoothGroupEventIdMode.
    /// </summary>
    public class SmoothGroupEventIdMode : ConstantClass
    {

        /// <summary>
        /// Constant NO_EVENT_ID for SmoothGroupEventIdMode
        /// </summary>
        public static readonly SmoothGroupEventIdMode NO_EVENT_ID = new SmoothGroupEventIdMode("NO_EVENT_ID");
        /// <summary>
        /// Constant USE_CONFIGURED for SmoothGroupEventIdMode
        /// </summary>
        public static readonly SmoothGroupEventIdMode USE_CONFIGURED = new SmoothGroupEventIdMode("USE_CONFIGURED");
        /// <summary>
        /// Constant USE_TIMESTAMP for SmoothGroupEventIdMode
        /// </summary>
        public static readonly SmoothGroupEventIdMode USE_TIMESTAMP = new SmoothGroupEventIdMode("USE_TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SmoothGroupEventIdMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SmoothGroupEventIdMode FindValue(string value)
        {
            return FindValue<SmoothGroupEventIdMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SmoothGroupEventIdMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SmoothGroupEventStopBehavior.
    /// </summary>
    public class SmoothGroupEventStopBehavior : ConstantClass
    {

        /// <summary>
        /// Constant NONE for SmoothGroupEventStopBehavior
        /// </summary>
        public static readonly SmoothGroupEventStopBehavior NONE = new SmoothGroupEventStopBehavior("NONE");
        /// <summary>
        /// Constant SEND_EOS for SmoothGroupEventStopBehavior
        /// </summary>
        public static readonly SmoothGroupEventStopBehavior SEND_EOS = new SmoothGroupEventStopBehavior("SEND_EOS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SmoothGroupEventStopBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SmoothGroupEventStopBehavior FindValue(string value)
        {
            return FindValue<SmoothGroupEventStopBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SmoothGroupEventStopBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SmoothGroupSegmentationMode.
    /// </summary>
    public class SmoothGroupSegmentationMode : ConstantClass
    {

        /// <summary>
        /// Constant USE_INPUT_SEGMENTATION for SmoothGroupSegmentationMode
        /// </summary>
        public static readonly SmoothGroupSegmentationMode USE_INPUT_SEGMENTATION = new SmoothGroupSegmentationMode("USE_INPUT_SEGMENTATION");
        /// <summary>
        /// Constant USE_SEGMENT_DURATION for SmoothGroupSegmentationMode
        /// </summary>
        public static readonly SmoothGroupSegmentationMode USE_SEGMENT_DURATION = new SmoothGroupSegmentationMode("USE_SEGMENT_DURATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SmoothGroupSegmentationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SmoothGroupSegmentationMode FindValue(string value)
        {
            return FindValue<SmoothGroupSegmentationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SmoothGroupSegmentationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SmoothGroupSparseTrackType.
    /// </summary>
    public class SmoothGroupSparseTrackType : ConstantClass
    {

        /// <summary>
        /// Constant NONE for SmoothGroupSparseTrackType
        /// </summary>
        public static readonly SmoothGroupSparseTrackType NONE = new SmoothGroupSparseTrackType("NONE");
        /// <summary>
        /// Constant SCTE_35 for SmoothGroupSparseTrackType
        /// </summary>
        public static readonly SmoothGroupSparseTrackType SCTE_35 = new SmoothGroupSparseTrackType("SCTE_35");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SmoothGroupSparseTrackType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SmoothGroupSparseTrackType FindValue(string value)
        {
            return FindValue<SmoothGroupSparseTrackType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SmoothGroupSparseTrackType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SmoothGroupStreamManifestBehavior.
    /// </summary>
    public class SmoothGroupStreamManifestBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DO_NOT_SEND for SmoothGroupStreamManifestBehavior
        /// </summary>
        public static readonly SmoothGroupStreamManifestBehavior DO_NOT_SEND = new SmoothGroupStreamManifestBehavior("DO_NOT_SEND");
        /// <summary>
        /// Constant SEND for SmoothGroupStreamManifestBehavior
        /// </summary>
        public static readonly SmoothGroupStreamManifestBehavior SEND = new SmoothGroupStreamManifestBehavior("SEND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SmoothGroupStreamManifestBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SmoothGroupStreamManifestBehavior FindValue(string value)
        {
            return FindValue<SmoothGroupStreamManifestBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SmoothGroupStreamManifestBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SmoothGroupTimestampOffsetMode.
    /// </summary>
    public class SmoothGroupTimestampOffsetMode : ConstantClass
    {

        /// <summary>
        /// Constant USE_CONFIGURED_OFFSET for SmoothGroupTimestampOffsetMode
        /// </summary>
        public static readonly SmoothGroupTimestampOffsetMode USE_CONFIGURED_OFFSET = new SmoothGroupTimestampOffsetMode("USE_CONFIGURED_OFFSET");
        /// <summary>
        /// Constant USE_EVENT_START_DATE for SmoothGroupTimestampOffsetMode
        /// </summary>
        public static readonly SmoothGroupTimestampOffsetMode USE_EVENT_START_DATE = new SmoothGroupTimestampOffsetMode("USE_EVENT_START_DATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SmoothGroupTimestampOffsetMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SmoothGroupTimestampOffsetMode FindValue(string value)
        {
            return FindValue<SmoothGroupTimestampOffsetMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SmoothGroupTimestampOffsetMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimecodeConfigSource.
    /// </summary>
    public class TimecodeConfigSource : ConstantClass
    {

        /// <summary>
        /// Constant EMBEDDED for TimecodeConfigSource
        /// </summary>
        public static readonly TimecodeConfigSource EMBEDDED = new TimecodeConfigSource("EMBEDDED");
        /// <summary>
        /// Constant SYSTEMCLOCK for TimecodeConfigSource
        /// </summary>
        public static readonly TimecodeConfigSource SYSTEMCLOCK = new TimecodeConfigSource("SYSTEMCLOCK");
        /// <summary>
        /// Constant ZEROBASED for TimecodeConfigSource
        /// </summary>
        public static readonly TimecodeConfigSource ZEROBASED = new TimecodeConfigSource("ZEROBASED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimecodeConfigSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimecodeConfigSource FindValue(string value)
        {
            return FindValue<TimecodeConfigSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimecodeConfigSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TtmlDestinationStyleControl.
    /// </summary>
    public class TtmlDestinationStyleControl : ConstantClass
    {

        /// <summary>
        /// Constant PASSTHROUGH for TtmlDestinationStyleControl
        /// </summary>
        public static readonly TtmlDestinationStyleControl PASSTHROUGH = new TtmlDestinationStyleControl("PASSTHROUGH");
        /// <summary>
        /// Constant USE_CONFIGURED for TtmlDestinationStyleControl
        /// </summary>
        public static readonly TtmlDestinationStyleControl USE_CONFIGURED = new TtmlDestinationStyleControl("USE_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TtmlDestinationStyleControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TtmlDestinationStyleControl FindValue(string value)
        {
            return FindValue<TtmlDestinationStyleControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TtmlDestinationStyleControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UdpTimedMetadataId3Frame.
    /// </summary>
    public class UdpTimedMetadataId3Frame : ConstantClass
    {

        /// <summary>
        /// Constant NONE for UdpTimedMetadataId3Frame
        /// </summary>
        public static readonly UdpTimedMetadataId3Frame NONE = new UdpTimedMetadataId3Frame("NONE");
        /// <summary>
        /// Constant PRIV for UdpTimedMetadataId3Frame
        /// </summary>
        public static readonly UdpTimedMetadataId3Frame PRIV = new UdpTimedMetadataId3Frame("PRIV");
        /// <summary>
        /// Constant TDRL for UdpTimedMetadataId3Frame
        /// </summary>
        public static readonly UdpTimedMetadataId3Frame TDRL = new UdpTimedMetadataId3Frame("TDRL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UdpTimedMetadataId3Frame(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UdpTimedMetadataId3Frame FindValue(string value)
        {
            return FindValue<UdpTimedMetadataId3Frame>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UdpTimedMetadataId3Frame(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoDescriptionRespondToAfd.
    /// </summary>
    public class VideoDescriptionRespondToAfd : ConstantClass
    {

        /// <summary>
        /// Constant NONE for VideoDescriptionRespondToAfd
        /// </summary>
        public static readonly VideoDescriptionRespondToAfd NONE = new VideoDescriptionRespondToAfd("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for VideoDescriptionRespondToAfd
        /// </summary>
        public static readonly VideoDescriptionRespondToAfd PASSTHROUGH = new VideoDescriptionRespondToAfd("PASSTHROUGH");
        /// <summary>
        /// Constant RESPOND for VideoDescriptionRespondToAfd
        /// </summary>
        public static readonly VideoDescriptionRespondToAfd RESPOND = new VideoDescriptionRespondToAfd("RESPOND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoDescriptionRespondToAfd(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoDescriptionRespondToAfd FindValue(string value)
        {
            return FindValue<VideoDescriptionRespondToAfd>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoDescriptionRespondToAfd(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoDescriptionScalingBehavior.
    /// </summary>
    public class VideoDescriptionScalingBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for VideoDescriptionScalingBehavior
        /// </summary>
        public static readonly VideoDescriptionScalingBehavior DEFAULT = new VideoDescriptionScalingBehavior("DEFAULT");
        /// <summary>
        /// Constant STRETCH_TO_OUTPUT for VideoDescriptionScalingBehavior
        /// </summary>
        public static readonly VideoDescriptionScalingBehavior STRETCH_TO_OUTPUT = new VideoDescriptionScalingBehavior("STRETCH_TO_OUTPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoDescriptionScalingBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoDescriptionScalingBehavior FindValue(string value)
        {
            return FindValue<VideoDescriptionScalingBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoDescriptionScalingBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoSelectorColorSpace.
    /// </summary>
    public class VideoSelectorColorSpace : ConstantClass
    {

        /// <summary>
        /// Constant FOLLOW for VideoSelectorColorSpace
        /// </summary>
        public static readonly VideoSelectorColorSpace FOLLOW = new VideoSelectorColorSpace("FOLLOW");
        /// <summary>
        /// Constant REC_601 for VideoSelectorColorSpace
        /// </summary>
        public static readonly VideoSelectorColorSpace REC_601 = new VideoSelectorColorSpace("REC_601");
        /// <summary>
        /// Constant REC_709 for VideoSelectorColorSpace
        /// </summary>
        public static readonly VideoSelectorColorSpace REC_709 = new VideoSelectorColorSpace("REC_709");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoSelectorColorSpace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoSelectorColorSpace FindValue(string value)
        {
            return FindValue<VideoSelectorColorSpace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoSelectorColorSpace(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoSelectorColorSpaceUsage.
    /// </summary>
    public class VideoSelectorColorSpaceUsage : ConstantClass
    {

        /// <summary>
        /// Constant FALLBACK for VideoSelectorColorSpaceUsage
        /// </summary>
        public static readonly VideoSelectorColorSpaceUsage FALLBACK = new VideoSelectorColorSpaceUsage("FALLBACK");
        /// <summary>
        /// Constant FORCE for VideoSelectorColorSpaceUsage
        /// </summary>
        public static readonly VideoSelectorColorSpaceUsage FORCE = new VideoSelectorColorSpaceUsage("FORCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoSelectorColorSpaceUsage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoSelectorColorSpaceUsage FindValue(string value)
        {
            return FindValue<VideoSelectorColorSpaceUsage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoSelectorColorSpaceUsage(string value)
        {
            return FindValue(value);
        }
    }

}