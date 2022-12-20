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
    /// Constants used for properties of type AcceptHeader.
    /// </summary>
    public class AcceptHeader : ConstantClass
    {

        /// <summary>
        /// Constant ImageJpeg for AcceptHeader
        /// </summary>
        public static readonly AcceptHeader ImageJpeg = new AcceptHeader("image/jpeg");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceptHeader(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceptHeader FindValue(string value)
        {
            return FindValue<AcceptHeader>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceptHeader(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccessibilityType.
    /// </summary>
    public class AccessibilityType : ConstantClass
    {

        /// <summary>
        /// Constant DOES_NOT_IMPLEMENT_ACCESSIBILITY_FEATURES for AccessibilityType
        /// </summary>
        public static readonly AccessibilityType DOES_NOT_IMPLEMENT_ACCESSIBILITY_FEATURES = new AccessibilityType("DOES_NOT_IMPLEMENT_ACCESSIBILITY_FEATURES");
        /// <summary>
        /// Constant IMPLEMENTS_ACCESSIBILITY_FEATURES for AccessibilityType
        /// </summary>
        public static readonly AccessibilityType IMPLEMENTS_ACCESSIBILITY_FEATURES = new AccessibilityType("IMPLEMENTS_ACCESSIBILITY_FEATURES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessibilityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessibilityType FindValue(string value)
        {
            return FindValue<AccessibilityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessibilityType(string value)
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
    /// Constants used for properties of type ArchiveS3LogUploads.
    /// </summary>
    public class ArchiveS3LogUploads : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ArchiveS3LogUploads
        /// </summary>
        public static readonly ArchiveS3LogUploads DISABLED = new ArchiveS3LogUploads("DISABLED");
        /// <summary>
        /// Constant ENABLED for ArchiveS3LogUploads
        /// </summary>
        public static readonly ArchiveS3LogUploads ENABLED = new ArchiveS3LogUploads("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArchiveS3LogUploads(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArchiveS3LogUploads FindValue(string value)
        {
            return FindValue<ArchiveS3LogUploads>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArchiveS3LogUploads(string value)
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
    /// Constants used for properties of type AudioOnlyHlsSegmentType.
    /// </summary>
    public class AudioOnlyHlsSegmentType : ConstantClass
    {

        /// <summary>
        /// Constant AAC for AudioOnlyHlsSegmentType
        /// </summary>
        public static readonly AudioOnlyHlsSegmentType AAC = new AudioOnlyHlsSegmentType("AAC");
        /// <summary>
        /// Constant FMP4 for AudioOnlyHlsSegmentType
        /// </summary>
        public static readonly AudioOnlyHlsSegmentType FMP4 = new AudioOnlyHlsSegmentType("FMP4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioOnlyHlsSegmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioOnlyHlsSegmentType FindValue(string value)
        {
            return FindValue<AudioOnlyHlsSegmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioOnlyHlsSegmentType(string value)
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
    /// Constants used for properties of type CdiInputResolution.
    /// </summary>
    public class CdiInputResolution : ConstantClass
    {

        /// <summary>
        /// Constant FHD for CdiInputResolution
        /// </summary>
        public static readonly CdiInputResolution FHD = new CdiInputResolution("FHD");
        /// <summary>
        /// Constant HD for CdiInputResolution
        /// </summary>
        public static readonly CdiInputResolution HD = new CdiInputResolution("HD");
        /// <summary>
        /// Constant SD for CdiInputResolution
        /// </summary>
        public static readonly CdiInputResolution SD = new CdiInputResolution("SD");
        /// <summary>
        /// Constant UHD for CdiInputResolution
        /// </summary>
        public static readonly CdiInputResolution UHD = new CdiInputResolution("UHD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CdiInputResolution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CdiInputResolution FindValue(string value)
        {
            return FindValue<CdiInputResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CdiInputResolution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelClass.
    /// </summary>
    public class ChannelClass : ConstantClass
    {

        /// <summary>
        /// Constant SINGLE_PIPELINE for ChannelClass
        /// </summary>
        public static readonly ChannelClass SINGLE_PIPELINE = new ChannelClass("SINGLE_PIPELINE");
        /// <summary>
        /// Constant STANDARD for ChannelClass
        /// </summary>
        public static readonly ChannelClass STANDARD = new ChannelClass("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelClass FindValue(string value)
        {
            return FindValue<ChannelClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelClass(string value)
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
        /// Constant UPDATE_FAILED for ChannelState
        /// </summary>
        public static readonly ChannelState UPDATE_FAILED = new ChannelState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for ChannelState
        /// </summary>
        public static readonly ChannelState UPDATING = new ChannelState("UPDATING");

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
    /// Constants used for properties of type ContentType.
    /// </summary>
    public class ContentType : ConstantClass
    {

        /// <summary>
        /// Constant ImageJpeg for ContentType
        /// </summary>
        public static readonly ContentType ImageJpeg = new ContentType("image/jpeg");

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
    /// Constants used for properties of type DeviceSettingsSyncState.
    /// </summary>
    public class DeviceSettingsSyncState : ConstantClass
    {

        /// <summary>
        /// Constant SYNCED for DeviceSettingsSyncState
        /// </summary>
        public static readonly DeviceSettingsSyncState SYNCED = new DeviceSettingsSyncState("SYNCED");
        /// <summary>
        /// Constant SYNCING for DeviceSettingsSyncState
        /// </summary>
        public static readonly DeviceSettingsSyncState SYNCING = new DeviceSettingsSyncState("SYNCING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceSettingsSyncState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceSettingsSyncState FindValue(string value)
        {
            return FindValue<DeviceSettingsSyncState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceSettingsSyncState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceUpdateStatus.
    /// </summary>
    public class DeviceUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant NOT_UP_TO_DATE for DeviceUpdateStatus
        /// </summary>
        public static readonly DeviceUpdateStatus NOT_UP_TO_DATE = new DeviceUpdateStatus("NOT_UP_TO_DATE");
        /// <summary>
        /// Constant UP_TO_DATE for DeviceUpdateStatus
        /// </summary>
        public static readonly DeviceUpdateStatus UP_TO_DATE = new DeviceUpdateStatus("UP_TO_DATE");
        /// <summary>
        /// Constant UPDATING for DeviceUpdateStatus
        /// </summary>
        public static readonly DeviceUpdateStatus UPDATING = new DeviceUpdateStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceUpdateStatus FindValue(string value)
        {
            return FindValue<DeviceUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DolbyEProgramSelection.
    /// </summary>
    public class DolbyEProgramSelection : ConstantClass
    {

        /// <summary>
        /// Constant ALL_CHANNELS for DolbyEProgramSelection
        /// </summary>
        public static readonly DolbyEProgramSelection ALL_CHANNELS = new DolbyEProgramSelection("ALL_CHANNELS");
        /// <summary>
        /// Constant PROGRAM_1 for DolbyEProgramSelection
        /// </summary>
        public static readonly DolbyEProgramSelection PROGRAM_1 = new DolbyEProgramSelection("PROGRAM_1");
        /// <summary>
        /// Constant PROGRAM_2 for DolbyEProgramSelection
        /// </summary>
        public static readonly DolbyEProgramSelection PROGRAM_2 = new DolbyEProgramSelection("PROGRAM_2");
        /// <summary>
        /// Constant PROGRAM_3 for DolbyEProgramSelection
        /// </summary>
        public static readonly DolbyEProgramSelection PROGRAM_3 = new DolbyEProgramSelection("PROGRAM_3");
        /// <summary>
        /// Constant PROGRAM_4 for DolbyEProgramSelection
        /// </summary>
        public static readonly DolbyEProgramSelection PROGRAM_4 = new DolbyEProgramSelection("PROGRAM_4");
        /// <summary>
        /// Constant PROGRAM_5 for DolbyEProgramSelection
        /// </summary>
        public static readonly DolbyEProgramSelection PROGRAM_5 = new DolbyEProgramSelection("PROGRAM_5");
        /// <summary>
        /// Constant PROGRAM_6 for DolbyEProgramSelection
        /// </summary>
        public static readonly DolbyEProgramSelection PROGRAM_6 = new DolbyEProgramSelection("PROGRAM_6");
        /// <summary>
        /// Constant PROGRAM_7 for DolbyEProgramSelection
        /// </summary>
        public static readonly DolbyEProgramSelection PROGRAM_7 = new DolbyEProgramSelection("PROGRAM_7");
        /// <summary>
        /// Constant PROGRAM_8 for DolbyEProgramSelection
        /// </summary>
        public static readonly DolbyEProgramSelection PROGRAM_8 = new DolbyEProgramSelection("PROGRAM_8");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DolbyEProgramSelection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DolbyEProgramSelection FindValue(string value)
        {
            return FindValue<DolbyEProgramSelection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DolbyEProgramSelection(string value)
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
    /// Constants used for properties of type DvbSubOcrLanguage.
    /// </summary>
    public class DvbSubOcrLanguage : ConstantClass
    {

        /// <summary>
        /// Constant DEU for DvbSubOcrLanguage
        /// </summary>
        public static readonly DvbSubOcrLanguage DEU = new DvbSubOcrLanguage("DEU");
        /// <summary>
        /// Constant ENG for DvbSubOcrLanguage
        /// </summary>
        public static readonly DvbSubOcrLanguage ENG = new DvbSubOcrLanguage("ENG");
        /// <summary>
        /// Constant FRA for DvbSubOcrLanguage
        /// </summary>
        public static readonly DvbSubOcrLanguage FRA = new DvbSubOcrLanguage("FRA");
        /// <summary>
        /// Constant NLD for DvbSubOcrLanguage
        /// </summary>
        public static readonly DvbSubOcrLanguage NLD = new DvbSubOcrLanguage("NLD");
        /// <summary>
        /// Constant POR for DvbSubOcrLanguage
        /// </summary>
        public static readonly DvbSubOcrLanguage POR = new DvbSubOcrLanguage("POR");
        /// <summary>
        /// Constant SPA for DvbSubOcrLanguage
        /// </summary>
        public static readonly DvbSubOcrLanguage SPA = new DvbSubOcrLanguage("SPA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DvbSubOcrLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DvbSubOcrLanguage FindValue(string value)
        {
            return FindValue<DvbSubOcrLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DvbSubOcrLanguage(string value)
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
    /// Constants used for properties of type Eac3AtmosDrcLine.
    /// </summary>
    public class Eac3AtmosDrcLine : ConstantClass
    {

        /// <summary>
        /// Constant FILM_LIGHT for Eac3AtmosDrcLine
        /// </summary>
        public static readonly Eac3AtmosDrcLine FILM_LIGHT = new Eac3AtmosDrcLine("FILM_LIGHT");
        /// <summary>
        /// Constant FILM_STANDARD for Eac3AtmosDrcLine
        /// </summary>
        public static readonly Eac3AtmosDrcLine FILM_STANDARD = new Eac3AtmosDrcLine("FILM_STANDARD");
        /// <summary>
        /// Constant MUSIC_LIGHT for Eac3AtmosDrcLine
        /// </summary>
        public static readonly Eac3AtmosDrcLine MUSIC_LIGHT = new Eac3AtmosDrcLine("MUSIC_LIGHT");
        /// <summary>
        /// Constant MUSIC_STANDARD for Eac3AtmosDrcLine
        /// </summary>
        public static readonly Eac3AtmosDrcLine MUSIC_STANDARD = new Eac3AtmosDrcLine("MUSIC_STANDARD");
        /// <summary>
        /// Constant NONE for Eac3AtmosDrcLine
        /// </summary>
        public static readonly Eac3AtmosDrcLine NONE = new Eac3AtmosDrcLine("NONE");
        /// <summary>
        /// Constant SPEECH for Eac3AtmosDrcLine
        /// </summary>
        public static readonly Eac3AtmosDrcLine SPEECH = new Eac3AtmosDrcLine("SPEECH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AtmosDrcLine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AtmosDrcLine FindValue(string value)
        {
            return FindValue<Eac3AtmosDrcLine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AtmosDrcLine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Eac3AtmosDrcRf.
    /// </summary>
    public class Eac3AtmosDrcRf : ConstantClass
    {

        /// <summary>
        /// Constant FILM_LIGHT for Eac3AtmosDrcRf
        /// </summary>
        public static readonly Eac3AtmosDrcRf FILM_LIGHT = new Eac3AtmosDrcRf("FILM_LIGHT");
        /// <summary>
        /// Constant FILM_STANDARD for Eac3AtmosDrcRf
        /// </summary>
        public static readonly Eac3AtmosDrcRf FILM_STANDARD = new Eac3AtmosDrcRf("FILM_STANDARD");
        /// <summary>
        /// Constant MUSIC_LIGHT for Eac3AtmosDrcRf
        /// </summary>
        public static readonly Eac3AtmosDrcRf MUSIC_LIGHT = new Eac3AtmosDrcRf("MUSIC_LIGHT");
        /// <summary>
        /// Constant MUSIC_STANDARD for Eac3AtmosDrcRf
        /// </summary>
        public static readonly Eac3AtmosDrcRf MUSIC_STANDARD = new Eac3AtmosDrcRf("MUSIC_STANDARD");
        /// <summary>
        /// Constant NONE for Eac3AtmosDrcRf
        /// </summary>
        public static readonly Eac3AtmosDrcRf NONE = new Eac3AtmosDrcRf("NONE");
        /// <summary>
        /// Constant SPEECH for Eac3AtmosDrcRf
        /// </summary>
        public static readonly Eac3AtmosDrcRf SPEECH = new Eac3AtmosDrcRf("SPEECH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Eac3AtmosDrcRf(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Eac3AtmosDrcRf FindValue(string value)
        {
            return FindValue<Eac3AtmosDrcRf>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Eac3AtmosDrcRf(string value)
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
    /// Constants used for properties of type EbuTtDDestinationStyleControl.
    /// </summary>
    public class EbuTtDDestinationStyleControl : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for EbuTtDDestinationStyleControl
        /// </summary>
        public static readonly EbuTtDDestinationStyleControl EXCLUDE = new EbuTtDDestinationStyleControl("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for EbuTtDDestinationStyleControl
        /// </summary>
        public static readonly EbuTtDDestinationStyleControl INCLUDE = new EbuTtDDestinationStyleControl("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EbuTtDDestinationStyleControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EbuTtDDestinationStyleControl FindValue(string value)
        {
            return FindValue<EbuTtDDestinationStyleControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EbuTtDDestinationStyleControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EbuTtDFillLineGapControl.
    /// </summary>
    public class EbuTtDFillLineGapControl : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EbuTtDFillLineGapControl
        /// </summary>
        public static readonly EbuTtDFillLineGapControl DISABLED = new EbuTtDFillLineGapControl("DISABLED");
        /// <summary>
        /// Constant ENABLED for EbuTtDFillLineGapControl
        /// </summary>
        public static readonly EbuTtDFillLineGapControl ENABLED = new EbuTtDFillLineGapControl("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EbuTtDFillLineGapControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EbuTtDFillLineGapControl FindValue(string value)
        {
            return FindValue<EbuTtDFillLineGapControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EbuTtDFillLineGapControl(string value)
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
    /// Constants used for properties of type FeatureActivationsInputPrepareScheduleActions.
    /// </summary>
    public class FeatureActivationsInputPrepareScheduleActions : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FeatureActivationsInputPrepareScheduleActions
        /// </summary>
        public static readonly FeatureActivationsInputPrepareScheduleActions DISABLED = new FeatureActivationsInputPrepareScheduleActions("DISABLED");
        /// <summary>
        /// Constant ENABLED for FeatureActivationsInputPrepareScheduleActions
        /// </summary>
        public static readonly FeatureActivationsInputPrepareScheduleActions ENABLED = new FeatureActivationsInputPrepareScheduleActions("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureActivationsInputPrepareScheduleActions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureActivationsInputPrepareScheduleActions FindValue(string value)
        {
            return FindValue<FeatureActivationsInputPrepareScheduleActions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureActivationsInputPrepareScheduleActions(string value)
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
    /// Constants used for properties of type Fmp4NielsenId3Behavior.
    /// </summary>
    public class Fmp4NielsenId3Behavior : ConstantClass
    {

        /// <summary>
        /// Constant NO_PASSTHROUGH for Fmp4NielsenId3Behavior
        /// </summary>
        public static readonly Fmp4NielsenId3Behavior NO_PASSTHROUGH = new Fmp4NielsenId3Behavior("NO_PASSTHROUGH");
        /// <summary>
        /// Constant PASSTHROUGH for Fmp4NielsenId3Behavior
        /// </summary>
        public static readonly Fmp4NielsenId3Behavior PASSTHROUGH = new Fmp4NielsenId3Behavior("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Fmp4NielsenId3Behavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Fmp4NielsenId3Behavior FindValue(string value)
        {
            return FindValue<Fmp4NielsenId3Behavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Fmp4NielsenId3Behavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Fmp4TimedMetadataBehavior.
    /// </summary>
    public class Fmp4TimedMetadataBehavior : ConstantClass
    {

        /// <summary>
        /// Constant NO_PASSTHROUGH for Fmp4TimedMetadataBehavior
        /// </summary>
        public static readonly Fmp4TimedMetadataBehavior NO_PASSTHROUGH = new Fmp4TimedMetadataBehavior("NO_PASSTHROUGH");
        /// <summary>
        /// Constant PASSTHROUGH for Fmp4TimedMetadataBehavior
        /// </summary>
        public static readonly Fmp4TimedMetadataBehavior PASSTHROUGH = new Fmp4TimedMetadataBehavior("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Fmp4TimedMetadataBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Fmp4TimedMetadataBehavior FindValue(string value)
        {
            return FindValue<Fmp4TimedMetadataBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Fmp4TimedMetadataBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FollowPoint.
    /// </summary>
    public class FollowPoint : ConstantClass
    {

        /// <summary>
        /// Constant END for FollowPoint
        /// </summary>
        public static readonly FollowPoint END = new FollowPoint("END");
        /// <summary>
        /// Constant START for FollowPoint
        /// </summary>
        public static readonly FollowPoint START = new FollowPoint("START");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FollowPoint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FollowPoint FindValue(string value)
        {
            return FindValue<FollowPoint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FollowPoint(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FrameCaptureIntervalUnit.
    /// </summary>
    public class FrameCaptureIntervalUnit : ConstantClass
    {

        /// <summary>
        /// Constant MILLISECONDS for FrameCaptureIntervalUnit
        /// </summary>
        public static readonly FrameCaptureIntervalUnit MILLISECONDS = new FrameCaptureIntervalUnit("MILLISECONDS");
        /// <summary>
        /// Constant SECONDS for FrameCaptureIntervalUnit
        /// </summary>
        public static readonly FrameCaptureIntervalUnit SECONDS = new FrameCaptureIntervalUnit("SECONDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FrameCaptureIntervalUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FrameCaptureIntervalUnit FindValue(string value)
        {
            return FindValue<FrameCaptureIntervalUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FrameCaptureIntervalUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FrameCaptureS3LogUploads.
    /// </summary>
    public class FrameCaptureS3LogUploads : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FrameCaptureS3LogUploads
        /// </summary>
        public static readonly FrameCaptureS3LogUploads DISABLED = new FrameCaptureS3LogUploads("DISABLED");
        /// <summary>
        /// Constant ENABLED for FrameCaptureS3LogUploads
        /// </summary>
        public static readonly FrameCaptureS3LogUploads ENABLED = new FrameCaptureS3LogUploads("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FrameCaptureS3LogUploads(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FrameCaptureS3LogUploads FindValue(string value)
        {
            return FindValue<FrameCaptureS3LogUploads>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FrameCaptureS3LogUploads(string value)
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
    /// Constants used for properties of type GlobalConfigurationOutputLockingMode.
    /// </summary>
    public class GlobalConfigurationOutputLockingMode : ConstantClass
    {

        /// <summary>
        /// Constant EPOCH_LOCKING for GlobalConfigurationOutputLockingMode
        /// </summary>
        public static readonly GlobalConfigurationOutputLockingMode EPOCH_LOCKING = new GlobalConfigurationOutputLockingMode("EPOCH_LOCKING");
        /// <summary>
        /// Constant PIPELINE_LOCKING for GlobalConfigurationOutputLockingMode
        /// </summary>
        public static readonly GlobalConfigurationOutputLockingMode PIPELINE_LOCKING = new GlobalConfigurationOutputLockingMode("PIPELINE_LOCKING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlobalConfigurationOutputLockingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlobalConfigurationOutputLockingMode FindValue(string value)
        {
            return FindValue<GlobalConfigurationOutputLockingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlobalConfigurationOutputLockingMode(string value)
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
    /// Constants used for properties of type H264ForceFieldPictures.
    /// </summary>
    public class H264ForceFieldPictures : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H264ForceFieldPictures
        /// </summary>
        public static readonly H264ForceFieldPictures DISABLED = new H264ForceFieldPictures("DISABLED");
        /// <summary>
        /// Constant ENABLED for H264ForceFieldPictures
        /// </summary>
        public static readonly H264ForceFieldPictures ENABLED = new H264ForceFieldPictures("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264ForceFieldPictures(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264ForceFieldPictures FindValue(string value)
        {
            return FindValue<H264ForceFieldPictures>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264ForceFieldPictures(string value)
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
    /// Constants used for properties of type H264QualityLevel.
    /// </summary>
    public class H264QualityLevel : ConstantClass
    {

        /// <summary>
        /// Constant ENHANCED_QUALITY for H264QualityLevel
        /// </summary>
        public static readonly H264QualityLevel ENHANCED_QUALITY = new H264QualityLevel("ENHANCED_QUALITY");
        /// <summary>
        /// Constant STANDARD_QUALITY for H264QualityLevel
        /// </summary>
        public static readonly H264QualityLevel STANDARD_QUALITY = new H264QualityLevel("STANDARD_QUALITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264QualityLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264QualityLevel FindValue(string value)
        {
            return FindValue<H264QualityLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264QualityLevel(string value)
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
        /// Constant MULTIPLEX for H264RateControlMode
        /// </summary>
        public static readonly H264RateControlMode MULTIPLEX = new H264RateControlMode("MULTIPLEX");
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
    /// Constants used for properties of type H264SubGopLength.
    /// </summary>
    public class H264SubGopLength : ConstantClass
    {

        /// <summary>
        /// Constant DYNAMIC for H264SubGopLength
        /// </summary>
        public static readonly H264SubGopLength DYNAMIC = new H264SubGopLength("DYNAMIC");
        /// <summary>
        /// Constant FIXED for H264SubGopLength
        /// </summary>
        public static readonly H264SubGopLength FIXED = new H264SubGopLength("FIXED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H264SubGopLength(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H264SubGopLength FindValue(string value)
        {
            return FindValue<H264SubGopLength>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H264SubGopLength(string value)
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
    /// Constants used for properties of type H265AlternativeTransferFunction.
    /// </summary>
    public class H265AlternativeTransferFunction : ConstantClass
    {

        /// <summary>
        /// Constant INSERT for H265AlternativeTransferFunction
        /// </summary>
        public static readonly H265AlternativeTransferFunction INSERT = new H265AlternativeTransferFunction("INSERT");
        /// <summary>
        /// Constant OMIT for H265AlternativeTransferFunction
        /// </summary>
        public static readonly H265AlternativeTransferFunction OMIT = new H265AlternativeTransferFunction("OMIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265AlternativeTransferFunction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265AlternativeTransferFunction FindValue(string value)
        {
            return FindValue<H265AlternativeTransferFunction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265AlternativeTransferFunction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265ColorMetadata.
    /// </summary>
    public class H265ColorMetadata : ConstantClass
    {

        /// <summary>
        /// Constant IGNORE for H265ColorMetadata
        /// </summary>
        public static readonly H265ColorMetadata IGNORE = new H265ColorMetadata("IGNORE");
        /// <summary>
        /// Constant INSERT for H265ColorMetadata
        /// </summary>
        public static readonly H265ColorMetadata INSERT = new H265ColorMetadata("INSERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265ColorMetadata(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265ColorMetadata FindValue(string value)
        {
            return FindValue<H265ColorMetadata>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265ColorMetadata(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265FlickerAq.
    /// </summary>
    public class H265FlickerAq : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H265FlickerAq
        /// </summary>
        public static readonly H265FlickerAq DISABLED = new H265FlickerAq("DISABLED");
        /// <summary>
        /// Constant ENABLED for H265FlickerAq
        /// </summary>
        public static readonly H265FlickerAq ENABLED = new H265FlickerAq("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265FlickerAq(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265FlickerAq FindValue(string value)
        {
            return FindValue<H265FlickerAq>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265FlickerAq(string value)
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
    /// Constants used for properties of type H265Level.
    /// </summary>
    public class H265Level : ConstantClass
    {

        /// <summary>
        /// Constant H265_LEVEL_1 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_1 = new H265Level("H265_LEVEL_1");
        /// <summary>
        /// Constant H265_LEVEL_2 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_2 = new H265Level("H265_LEVEL_2");
        /// <summary>
        /// Constant H265_LEVEL_2_1 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_2_1 = new H265Level("H265_LEVEL_2_1");
        /// <summary>
        /// Constant H265_LEVEL_3 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_3 = new H265Level("H265_LEVEL_3");
        /// <summary>
        /// Constant H265_LEVEL_3_1 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_3_1 = new H265Level("H265_LEVEL_3_1");
        /// <summary>
        /// Constant H265_LEVEL_4 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_4 = new H265Level("H265_LEVEL_4");
        /// <summary>
        /// Constant H265_LEVEL_4_1 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_4_1 = new H265Level("H265_LEVEL_4_1");
        /// <summary>
        /// Constant H265_LEVEL_5 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_5 = new H265Level("H265_LEVEL_5");
        /// <summary>
        /// Constant H265_LEVEL_5_1 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_5_1 = new H265Level("H265_LEVEL_5_1");
        /// <summary>
        /// Constant H265_LEVEL_5_2 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_5_2 = new H265Level("H265_LEVEL_5_2");
        /// <summary>
        /// Constant H265_LEVEL_6 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_6 = new H265Level("H265_LEVEL_6");
        /// <summary>
        /// Constant H265_LEVEL_6_1 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_6_1 = new H265Level("H265_LEVEL_6_1");
        /// <summary>
        /// Constant H265_LEVEL_6_2 for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_6_2 = new H265Level("H265_LEVEL_6_2");
        /// <summary>
        /// Constant H265_LEVEL_AUTO for H265Level
        /// </summary>
        public static readonly H265Level H265_LEVEL_AUTO = new H265Level("H265_LEVEL_AUTO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265Level(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265Level FindValue(string value)
        {
            return FindValue<H265Level>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265Level(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265LookAheadRateControl.
    /// </summary>
    public class H265LookAheadRateControl : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for H265LookAheadRateControl
        /// </summary>
        public static readonly H265LookAheadRateControl HIGH = new H265LookAheadRateControl("HIGH");
        /// <summary>
        /// Constant LOW for H265LookAheadRateControl
        /// </summary>
        public static readonly H265LookAheadRateControl LOW = new H265LookAheadRateControl("LOW");
        /// <summary>
        /// Constant MEDIUM for H265LookAheadRateControl
        /// </summary>
        public static readonly H265LookAheadRateControl MEDIUM = new H265LookAheadRateControl("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265LookAheadRateControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265LookAheadRateControl FindValue(string value)
        {
            return FindValue<H265LookAheadRateControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265LookAheadRateControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265Profile.
    /// </summary>
    public class H265Profile : ConstantClass
    {

        /// <summary>
        /// Constant MAIN for H265Profile
        /// </summary>
        public static readonly H265Profile MAIN = new H265Profile("MAIN");
        /// <summary>
        /// Constant MAIN_10BIT for H265Profile
        /// </summary>
        public static readonly H265Profile MAIN_10BIT = new H265Profile("MAIN_10BIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265Profile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265Profile FindValue(string value)
        {
            return FindValue<H265Profile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265Profile(string value)
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
        /// Constant MULTIPLEX for H265RateControlMode
        /// </summary>
        public static readonly H265RateControlMode MULTIPLEX = new H265RateControlMode("MULTIPLEX");
        /// <summary>
        /// Constant QVBR for H265RateControlMode
        /// </summary>
        public static readonly H265RateControlMode QVBR = new H265RateControlMode("QVBR");

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
    /// Constants used for properties of type H265ScanType.
    /// </summary>
    public class H265ScanType : ConstantClass
    {

        /// <summary>
        /// Constant INTERLACED for H265ScanType
        /// </summary>
        public static readonly H265ScanType INTERLACED = new H265ScanType("INTERLACED");
        /// <summary>
        /// Constant PROGRESSIVE for H265ScanType
        /// </summary>
        public static readonly H265ScanType PROGRESSIVE = new H265ScanType("PROGRESSIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265ScanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265ScanType FindValue(string value)
        {
            return FindValue<H265ScanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265ScanType(string value)
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
    /// Constants used for properties of type H265Tier.
    /// </summary>
    public class H265Tier : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for H265Tier
        /// </summary>
        public static readonly H265Tier HIGH = new H265Tier("HIGH");
        /// <summary>
        /// Constant MAIN for H265Tier
        /// </summary>
        public static readonly H265Tier MAIN = new H265Tier("MAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265Tier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265Tier FindValue(string value)
        {
            return FindValue<H265Tier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265Tier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type H265TimecodeInsertionBehavior.
    /// </summary>
    public class H265TimecodeInsertionBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for H265TimecodeInsertionBehavior
        /// </summary>
        public static readonly H265TimecodeInsertionBehavior DISABLED = new H265TimecodeInsertionBehavior("DISABLED");
        /// <summary>
        /// Constant PIC_TIMING_SEI for H265TimecodeInsertionBehavior
        /// </summary>
        public static readonly H265TimecodeInsertionBehavior PIC_TIMING_SEI = new H265TimecodeInsertionBehavior("PIC_TIMING_SEI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public H265TimecodeInsertionBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static H265TimecodeInsertionBehavior FindValue(string value)
        {
            return FindValue<H265TimecodeInsertionBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator H265TimecodeInsertionBehavior(string value)
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
    /// Constants used for properties of type HlsDiscontinuityTags.
    /// </summary>
    public class HlsDiscontinuityTags : ConstantClass
    {

        /// <summary>
        /// Constant INSERT for HlsDiscontinuityTags
        /// </summary>
        public static readonly HlsDiscontinuityTags INSERT = new HlsDiscontinuityTags("INSERT");
        /// <summary>
        /// Constant NEVER_INSERT for HlsDiscontinuityTags
        /// </summary>
        public static readonly HlsDiscontinuityTags NEVER_INSERT = new HlsDiscontinuityTags("NEVER_INSERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsDiscontinuityTags(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsDiscontinuityTags FindValue(string value)
        {
            return FindValue<HlsDiscontinuityTags>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsDiscontinuityTags(string value)
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
    /// Constants used for properties of type HlsH265PackagingType.
    /// </summary>
    public class HlsH265PackagingType : ConstantClass
    {

        /// <summary>
        /// Constant HEV1 for HlsH265PackagingType
        /// </summary>
        public static readonly HlsH265PackagingType HEV1 = new HlsH265PackagingType("HEV1");
        /// <summary>
        /// Constant HVC1 for HlsH265PackagingType
        /// </summary>
        public static readonly HlsH265PackagingType HVC1 = new HlsH265PackagingType("HVC1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsH265PackagingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsH265PackagingType FindValue(string value)
        {
            return FindValue<HlsH265PackagingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsH265PackagingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsId3SegmentTaggingState.
    /// </summary>
    public class HlsId3SegmentTaggingState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for HlsId3SegmentTaggingState
        /// </summary>
        public static readonly HlsId3SegmentTaggingState DISABLED = new HlsId3SegmentTaggingState("DISABLED");
        /// <summary>
        /// Constant ENABLED for HlsId3SegmentTaggingState
        /// </summary>
        public static readonly HlsId3SegmentTaggingState ENABLED = new HlsId3SegmentTaggingState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsId3SegmentTaggingState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsId3SegmentTaggingState FindValue(string value)
        {
            return FindValue<HlsId3SegmentTaggingState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsId3SegmentTaggingState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsIncompleteSegmentBehavior.
    /// </summary>
    public class HlsIncompleteSegmentBehavior : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for HlsIncompleteSegmentBehavior
        /// </summary>
        public static readonly HlsIncompleteSegmentBehavior AUTO = new HlsIncompleteSegmentBehavior("AUTO");
        /// <summary>
        /// Constant SUPPRESS for HlsIncompleteSegmentBehavior
        /// </summary>
        public static readonly HlsIncompleteSegmentBehavior SUPPRESS = new HlsIncompleteSegmentBehavior("SUPPRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsIncompleteSegmentBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsIncompleteSegmentBehavior FindValue(string value)
        {
            return FindValue<HlsIncompleteSegmentBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsIncompleteSegmentBehavior(string value)
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
        /// Constant VARIANT_MANIFESTS_AND_SEGMENTS for HlsOutputSelection
        /// </summary>
        public static readonly HlsOutputSelection VARIANT_MANIFESTS_AND_SEGMENTS = new HlsOutputSelection("VARIANT_MANIFESTS_AND_SEGMENTS");

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
    /// Constants used for properties of type HlsProgramDateTimeClock.
    /// </summary>
    public class HlsProgramDateTimeClock : ConstantClass
    {

        /// <summary>
        /// Constant INITIALIZE_FROM_OUTPUT_TIMECODE for HlsProgramDateTimeClock
        /// </summary>
        public static readonly HlsProgramDateTimeClock INITIALIZE_FROM_OUTPUT_TIMECODE = new HlsProgramDateTimeClock("INITIALIZE_FROM_OUTPUT_TIMECODE");
        /// <summary>
        /// Constant SYSTEM_CLOCK for HlsProgramDateTimeClock
        /// </summary>
        public static readonly HlsProgramDateTimeClock SYSTEM_CLOCK = new HlsProgramDateTimeClock("SYSTEM_CLOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsProgramDateTimeClock(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsProgramDateTimeClock FindValue(string value)
        {
            return FindValue<HlsProgramDateTimeClock>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsProgramDateTimeClock(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsRedundantManifest.
    /// </summary>
    public class HlsRedundantManifest : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for HlsRedundantManifest
        /// </summary>
        public static readonly HlsRedundantManifest DISABLED = new HlsRedundantManifest("DISABLED");
        /// <summary>
        /// Constant ENABLED for HlsRedundantManifest
        /// </summary>
        public static readonly HlsRedundantManifest ENABLED = new HlsRedundantManifest("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsRedundantManifest(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsRedundantManifest FindValue(string value)
        {
            return FindValue<HlsRedundantManifest>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsRedundantManifest(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsS3LogUploads.
    /// </summary>
    public class HlsS3LogUploads : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for HlsS3LogUploads
        /// </summary>
        public static readonly HlsS3LogUploads DISABLED = new HlsS3LogUploads("DISABLED");
        /// <summary>
        /// Constant ENABLED for HlsS3LogUploads
        /// </summary>
        public static readonly HlsS3LogUploads ENABLED = new HlsS3LogUploads("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsS3LogUploads(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsS3LogUploads FindValue(string value)
        {
            return FindValue<HlsS3LogUploads>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsS3LogUploads(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HlsScte35SourceType.
    /// </summary>
    public class HlsScte35SourceType : ConstantClass
    {

        /// <summary>
        /// Constant MANIFEST for HlsScte35SourceType
        /// </summary>
        public static readonly HlsScte35SourceType MANIFEST = new HlsScte35SourceType("MANIFEST");
        /// <summary>
        /// Constant SEGMENTS for HlsScte35SourceType
        /// </summary>
        public static readonly HlsScte35SourceType SEGMENTS = new HlsScte35SourceType("SEGMENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HlsScte35SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsScte35SourceType FindValue(string value)
        {
            return FindValue<HlsScte35SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsScte35SourceType(string value)
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
    /// Constants used for properties of type IFrameOnlyPlaylistType.
    /// </summary>
    public class IFrameOnlyPlaylistType : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for IFrameOnlyPlaylistType
        /// </summary>
        public static readonly IFrameOnlyPlaylistType DISABLED = new IFrameOnlyPlaylistType("DISABLED");
        /// <summary>
        /// Constant STANDARD for IFrameOnlyPlaylistType
        /// </summary>
        public static readonly IFrameOnlyPlaylistType STANDARD = new IFrameOnlyPlaylistType("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IFrameOnlyPlaylistType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IFrameOnlyPlaylistType FindValue(string value)
        {
            return FindValue<IFrameOnlyPlaylistType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IFrameOnlyPlaylistType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputClass.
    /// </summary>
    public class InputClass : ConstantClass
    {

        /// <summary>
        /// Constant SINGLE_PIPELINE for InputClass
        /// </summary>
        public static readonly InputClass SINGLE_PIPELINE = new InputClass("SINGLE_PIPELINE");
        /// <summary>
        /// Constant STANDARD for InputClass
        /// </summary>
        public static readonly InputClass STANDARD = new InputClass("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputClass FindValue(string value)
        {
            return FindValue<InputClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputClass(string value)
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
    /// Constants used for properties of type InputDeviceActiveInput.
    /// </summary>
    public class InputDeviceActiveInput : ConstantClass
    {

        /// <summary>
        /// Constant HDMI for InputDeviceActiveInput
        /// </summary>
        public static readonly InputDeviceActiveInput HDMI = new InputDeviceActiveInput("HDMI");
        /// <summary>
        /// Constant SDI for InputDeviceActiveInput
        /// </summary>
        public static readonly InputDeviceActiveInput SDI = new InputDeviceActiveInput("SDI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputDeviceActiveInput(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputDeviceActiveInput FindValue(string value)
        {
            return FindValue<InputDeviceActiveInput>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputDeviceActiveInput(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputDeviceConfiguredInput.
    /// </summary>
    public class InputDeviceConfiguredInput : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for InputDeviceConfiguredInput
        /// </summary>
        public static readonly InputDeviceConfiguredInput AUTO = new InputDeviceConfiguredInput("AUTO");
        /// <summary>
        /// Constant HDMI for InputDeviceConfiguredInput
        /// </summary>
        public static readonly InputDeviceConfiguredInput HDMI = new InputDeviceConfiguredInput("HDMI");
        /// <summary>
        /// Constant SDI for InputDeviceConfiguredInput
        /// </summary>
        public static readonly InputDeviceConfiguredInput SDI = new InputDeviceConfiguredInput("SDI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputDeviceConfiguredInput(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputDeviceConfiguredInput FindValue(string value)
        {
            return FindValue<InputDeviceConfiguredInput>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputDeviceConfiguredInput(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputDeviceConnectionState.
    /// </summary>
    public class InputDeviceConnectionState : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for InputDeviceConnectionState
        /// </summary>
        public static readonly InputDeviceConnectionState CONNECTED = new InputDeviceConnectionState("CONNECTED");
        /// <summary>
        /// Constant DISCONNECTED for InputDeviceConnectionState
        /// </summary>
        public static readonly InputDeviceConnectionState DISCONNECTED = new InputDeviceConnectionState("DISCONNECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputDeviceConnectionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputDeviceConnectionState FindValue(string value)
        {
            return FindValue<InputDeviceConnectionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputDeviceConnectionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputDeviceIpScheme.
    /// </summary>
    public class InputDeviceIpScheme : ConstantClass
    {

        /// <summary>
        /// Constant DHCP for InputDeviceIpScheme
        /// </summary>
        public static readonly InputDeviceIpScheme DHCP = new InputDeviceIpScheme("DHCP");
        /// <summary>
        /// Constant STATIC for InputDeviceIpScheme
        /// </summary>
        public static readonly InputDeviceIpScheme STATIC = new InputDeviceIpScheme("STATIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputDeviceIpScheme(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputDeviceIpScheme FindValue(string value)
        {
            return FindValue<InputDeviceIpScheme>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputDeviceIpScheme(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputDeviceScanType.
    /// </summary>
    public class InputDeviceScanType : ConstantClass
    {

        /// <summary>
        /// Constant INTERLACED for InputDeviceScanType
        /// </summary>
        public static readonly InputDeviceScanType INTERLACED = new InputDeviceScanType("INTERLACED");
        /// <summary>
        /// Constant PROGRESSIVE for InputDeviceScanType
        /// </summary>
        public static readonly InputDeviceScanType PROGRESSIVE = new InputDeviceScanType("PROGRESSIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputDeviceScanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputDeviceScanType FindValue(string value)
        {
            return FindValue<InputDeviceScanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputDeviceScanType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputDeviceState.
    /// </summary>
    public class InputDeviceState : ConstantClass
    {

        /// <summary>
        /// Constant IDLE for InputDeviceState
        /// </summary>
        public static readonly InputDeviceState IDLE = new InputDeviceState("IDLE");
        /// <summary>
        /// Constant STREAMING for InputDeviceState
        /// </summary>
        public static readonly InputDeviceState STREAMING = new InputDeviceState("STREAMING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputDeviceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputDeviceState FindValue(string value)
        {
            return FindValue<InputDeviceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputDeviceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputDeviceTransferType.
    /// </summary>
    public class InputDeviceTransferType : ConstantClass
    {

        /// <summary>
        /// Constant INCOMING for InputDeviceTransferType
        /// </summary>
        public static readonly InputDeviceTransferType INCOMING = new InputDeviceTransferType("INCOMING");
        /// <summary>
        /// Constant OUTGOING for InputDeviceTransferType
        /// </summary>
        public static readonly InputDeviceTransferType OUTGOING = new InputDeviceTransferType("OUTGOING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputDeviceTransferType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputDeviceTransferType FindValue(string value)
        {
            return FindValue<InputDeviceTransferType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputDeviceTransferType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputDeviceType.
    /// </summary>
    public class InputDeviceType : ConstantClass
    {

        /// <summary>
        /// Constant HD for InputDeviceType
        /// </summary>
        public static readonly InputDeviceType HD = new InputDeviceType("HD");
        /// <summary>
        /// Constant UHD for InputDeviceType
        /// </summary>
        public static readonly InputDeviceType UHD = new InputDeviceType("UHD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputDeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputDeviceType FindValue(string value)
        {
            return FindValue<InputDeviceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputDeviceType(string value)
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
    /// Constants used for properties of type InputLossActionForRtmpOut.
    /// </summary>
    public class InputLossActionForRtmpOut : ConstantClass
    {

        /// <summary>
        /// Constant EMIT_OUTPUT for InputLossActionForRtmpOut
        /// </summary>
        public static readonly InputLossActionForRtmpOut EMIT_OUTPUT = new InputLossActionForRtmpOut("EMIT_OUTPUT");
        /// <summary>
        /// Constant PAUSE_OUTPUT for InputLossActionForRtmpOut
        /// </summary>
        public static readonly InputLossActionForRtmpOut PAUSE_OUTPUT = new InputLossActionForRtmpOut("PAUSE_OUTPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputLossActionForRtmpOut(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputLossActionForRtmpOut FindValue(string value)
        {
            return FindValue<InputLossActionForRtmpOut>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputLossActionForRtmpOut(string value)
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
    /// Constants used for properties of type InputPreference.
    /// </summary>
    public class InputPreference : ConstantClass
    {

        /// <summary>
        /// Constant EQUAL_INPUT_PREFERENCE for InputPreference
        /// </summary>
        public static readonly InputPreference EQUAL_INPUT_PREFERENCE = new InputPreference("EQUAL_INPUT_PREFERENCE");
        /// <summary>
        /// Constant PRIMARY_INPUT_PREFERRED for InputPreference
        /// </summary>
        public static readonly InputPreference PRIMARY_INPUT_PREFERRED = new InputPreference("PRIMARY_INPUT_PREFERRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputPreference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputPreference FindValue(string value)
        {
            return FindValue<InputPreference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputPreference(string value)
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
    /// Constants used for properties of type InputSourceType.
    /// </summary>
    public class InputSourceType : ConstantClass
    {

        /// <summary>
        /// Constant DYNAMIC for InputSourceType
        /// </summary>
        public static readonly InputSourceType DYNAMIC = new InputSourceType("DYNAMIC");
        /// <summary>
        /// Constant STATIC for InputSourceType
        /// </summary>
        public static readonly InputSourceType STATIC = new InputSourceType("STATIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputSourceType FindValue(string value)
        {
            return FindValue<InputSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputSourceType(string value)
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
    /// Constants used for properties of type InputTimecodeSource.
    /// </summary>
    public class InputTimecodeSource : ConstantClass
    {

        /// <summary>
        /// Constant EMBEDDED for InputTimecodeSource
        /// </summary>
        public static readonly InputTimecodeSource EMBEDDED = new InputTimecodeSource("EMBEDDED");
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
    /// Constants used for properties of type InputType.
    /// </summary>
    public class InputType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_CDI for InputType
        /// </summary>
        public static readonly InputType AWS_CDI = new InputType("AWS_CDI");
        /// <summary>
        /// Constant INPUT_DEVICE for InputType
        /// </summary>
        public static readonly InputType INPUT_DEVICE = new InputType("INPUT_DEVICE");
        /// <summary>
        /// Constant MEDIACONNECT for InputType
        /// </summary>
        public static readonly InputType MEDIACONNECT = new InputType("MEDIACONNECT");
        /// <summary>
        /// Constant MP4_FILE for InputType
        /// </summary>
        public static readonly InputType MP4_FILE = new InputType("MP4_FILE");
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
        /// Constant TS_FILE for InputType
        /// </summary>
        public static readonly InputType TS_FILE = new InputType("TS_FILE");
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
    /// Constants used for properties of type LastFrameClippingBehavior.
    /// </summary>
    public class LastFrameClippingBehavior : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE_LAST_FRAME for LastFrameClippingBehavior
        /// </summary>
        public static readonly LastFrameClippingBehavior EXCLUDE_LAST_FRAME = new LastFrameClippingBehavior("EXCLUDE_LAST_FRAME");
        /// <summary>
        /// Constant INCLUDE_LAST_FRAME for LastFrameClippingBehavior
        /// </summary>
        public static readonly LastFrameClippingBehavior INCLUDE_LAST_FRAME = new LastFrameClippingBehavior("INCLUDE_LAST_FRAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastFrameClippingBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastFrameClippingBehavior FindValue(string value)
        {
            return FindValue<LastFrameClippingBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastFrameClippingBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogLevel.
    /// </summary>
    public class LogLevel : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for LogLevel
        /// </summary>
        public static readonly LogLevel DEBUG = new LogLevel("DEBUG");
        /// <summary>
        /// Constant DISABLED for LogLevel
        /// </summary>
        public static readonly LogLevel DISABLED = new LogLevel("DISABLED");
        /// <summary>
        /// Constant ERROR for LogLevel
        /// </summary>
        public static readonly LogLevel ERROR = new LogLevel("ERROR");
        /// <summary>
        /// Constant INFO for LogLevel
        /// </summary>
        public static readonly LogLevel INFO = new LogLevel("INFO");
        /// <summary>
        /// Constant WARNING for LogLevel
        /// </summary>
        public static readonly LogLevel WARNING = new LogLevel("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogLevel FindValue(string value)
        {
            return FindValue<LogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogLevel(string value)
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
    /// Constants used for properties of type M2tsNielsenId3Behavior.
    /// </summary>
    public class M2tsNielsenId3Behavior : ConstantClass
    {

        /// <summary>
        /// Constant NO_PASSTHROUGH for M2tsNielsenId3Behavior
        /// </summary>
        public static readonly M2tsNielsenId3Behavior NO_PASSTHROUGH = new M2tsNielsenId3Behavior("NO_PASSTHROUGH");
        /// <summary>
        /// Constant PASSTHROUGH for M2tsNielsenId3Behavior
        /// </summary>
        public static readonly M2tsNielsenId3Behavior PASSTHROUGH = new M2tsNielsenId3Behavior("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2tsNielsenId3Behavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2tsNielsenId3Behavior FindValue(string value)
        {
            return FindValue<M2tsNielsenId3Behavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2tsNielsenId3Behavior(string value)
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
    /// Constants used for properties of type M3u8NielsenId3Behavior.
    /// </summary>
    public class M3u8NielsenId3Behavior : ConstantClass
    {

        /// <summary>
        /// Constant NO_PASSTHROUGH for M3u8NielsenId3Behavior
        /// </summary>
        public static readonly M3u8NielsenId3Behavior NO_PASSTHROUGH = new M3u8NielsenId3Behavior("NO_PASSTHROUGH");
        /// <summary>
        /// Constant PASSTHROUGH for M3u8NielsenId3Behavior
        /// </summary>
        public static readonly M3u8NielsenId3Behavior PASSTHROUGH = new M3u8NielsenId3Behavior("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M3u8NielsenId3Behavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M3u8NielsenId3Behavior FindValue(string value)
        {
            return FindValue<M3u8NielsenId3Behavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M3u8NielsenId3Behavior(string value)
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
    /// Constants used for properties of type MaintenanceDay.
    /// </summary>
    public class MaintenanceDay : ConstantClass
    {

        /// <summary>
        /// Constant FRIDAY for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay FRIDAY = new MaintenanceDay("FRIDAY");
        /// <summary>
        /// Constant MONDAY for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay MONDAY = new MaintenanceDay("MONDAY");
        /// <summary>
        /// Constant SATURDAY for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay SATURDAY = new MaintenanceDay("SATURDAY");
        /// <summary>
        /// Constant SUNDAY for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay SUNDAY = new MaintenanceDay("SUNDAY");
        /// <summary>
        /// Constant THURSDAY for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay THURSDAY = new MaintenanceDay("THURSDAY");
        /// <summary>
        /// Constant TUESDAY for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay TUESDAY = new MaintenanceDay("TUESDAY");
        /// <summary>
        /// Constant WEDNESDAY for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay WEDNESDAY = new MaintenanceDay("WEDNESDAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceDay(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceDay FindValue(string value)
        {
            return FindValue<MaintenanceDay>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceDay(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MotionGraphicsInsertion.
    /// </summary>
    public class MotionGraphicsInsertion : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for MotionGraphicsInsertion
        /// </summary>
        public static readonly MotionGraphicsInsertion DISABLED = new MotionGraphicsInsertion("DISABLED");
        /// <summary>
        /// Constant ENABLED for MotionGraphicsInsertion
        /// </summary>
        public static readonly MotionGraphicsInsertion ENABLED = new MotionGraphicsInsertion("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MotionGraphicsInsertion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MotionGraphicsInsertion FindValue(string value)
        {
            return FindValue<MotionGraphicsInsertion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MotionGraphicsInsertion(string value)
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
    /// Constants used for properties of type Mpeg2AdaptiveQuantization.
    /// </summary>
    public class Mpeg2AdaptiveQuantization : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for Mpeg2AdaptiveQuantization
        /// </summary>
        public static readonly Mpeg2AdaptiveQuantization AUTO = new Mpeg2AdaptiveQuantization("AUTO");
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
    /// Constants used for properties of type Mpeg2ColorMetadata.
    /// </summary>
    public class Mpeg2ColorMetadata : ConstantClass
    {

        /// <summary>
        /// Constant IGNORE for Mpeg2ColorMetadata
        /// </summary>
        public static readonly Mpeg2ColorMetadata IGNORE = new Mpeg2ColorMetadata("IGNORE");
        /// <summary>
        /// Constant INSERT for Mpeg2ColorMetadata
        /// </summary>
        public static readonly Mpeg2ColorMetadata INSERT = new Mpeg2ColorMetadata("INSERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2ColorMetadata(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2ColorMetadata FindValue(string value)
        {
            return FindValue<Mpeg2ColorMetadata>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2ColorMetadata(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2ColorSpace.
    /// </summary>
    public class Mpeg2ColorSpace : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for Mpeg2ColorSpace
        /// </summary>
        public static readonly Mpeg2ColorSpace AUTO = new Mpeg2ColorSpace("AUTO");
        /// <summary>
        /// Constant PASSTHROUGH for Mpeg2ColorSpace
        /// </summary>
        public static readonly Mpeg2ColorSpace PASSTHROUGH = new Mpeg2ColorSpace("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2ColorSpace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2ColorSpace FindValue(string value)
        {
            return FindValue<Mpeg2ColorSpace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2ColorSpace(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2DisplayRatio.
    /// </summary>
    public class Mpeg2DisplayRatio : ConstantClass
    {

        /// <summary>
        /// Constant DISPLAYRATIO16X9 for Mpeg2DisplayRatio
        /// </summary>
        public static readonly Mpeg2DisplayRatio DISPLAYRATIO16X9 = new Mpeg2DisplayRatio("DISPLAYRATIO16X9");
        /// <summary>
        /// Constant DISPLAYRATIO4X3 for Mpeg2DisplayRatio
        /// </summary>
        public static readonly Mpeg2DisplayRatio DISPLAYRATIO4X3 = new Mpeg2DisplayRatio("DISPLAYRATIO4X3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2DisplayRatio(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2DisplayRatio FindValue(string value)
        {
            return FindValue<Mpeg2DisplayRatio>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2DisplayRatio(string value)
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
    /// Constants used for properties of type Mpeg2ScanType.
    /// </summary>
    public class Mpeg2ScanType : ConstantClass
    {

        /// <summary>
        /// Constant INTERLACED for Mpeg2ScanType
        /// </summary>
        public static readonly Mpeg2ScanType INTERLACED = new Mpeg2ScanType("INTERLACED");
        /// <summary>
        /// Constant PROGRESSIVE for Mpeg2ScanType
        /// </summary>
        public static readonly Mpeg2ScanType PROGRESSIVE = new Mpeg2ScanType("PROGRESSIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2ScanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2ScanType FindValue(string value)
        {
            return FindValue<Mpeg2ScanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2ScanType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2SubGopLength.
    /// </summary>
    public class Mpeg2SubGopLength : ConstantClass
    {

        /// <summary>
        /// Constant DYNAMIC for Mpeg2SubGopLength
        /// </summary>
        public static readonly Mpeg2SubGopLength DYNAMIC = new Mpeg2SubGopLength("DYNAMIC");
        /// <summary>
        /// Constant FIXED for Mpeg2SubGopLength
        /// </summary>
        public static readonly Mpeg2SubGopLength FIXED = new Mpeg2SubGopLength("FIXED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2SubGopLength(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2SubGopLength FindValue(string value)
        {
            return FindValue<Mpeg2SubGopLength>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2SubGopLength(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mpeg2TimecodeInsertionBehavior.
    /// </summary>
    public class Mpeg2TimecodeInsertionBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Mpeg2TimecodeInsertionBehavior
        /// </summary>
        public static readonly Mpeg2TimecodeInsertionBehavior DISABLED = new Mpeg2TimecodeInsertionBehavior("DISABLED");
        /// <summary>
        /// Constant GOP_TIMECODE for Mpeg2TimecodeInsertionBehavior
        /// </summary>
        public static readonly Mpeg2TimecodeInsertionBehavior GOP_TIMECODE = new Mpeg2TimecodeInsertionBehavior("GOP_TIMECODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mpeg2TimecodeInsertionBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mpeg2TimecodeInsertionBehavior FindValue(string value)
        {
            return FindValue<Mpeg2TimecodeInsertionBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mpeg2TimecodeInsertionBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MsSmoothH265PackagingType.
    /// </summary>
    public class MsSmoothH265PackagingType : ConstantClass
    {

        /// <summary>
        /// Constant HEV1 for MsSmoothH265PackagingType
        /// </summary>
        public static readonly MsSmoothH265PackagingType HEV1 = new MsSmoothH265PackagingType("HEV1");
        /// <summary>
        /// Constant HVC1 for MsSmoothH265PackagingType
        /// </summary>
        public static readonly MsSmoothH265PackagingType HVC1 = new MsSmoothH265PackagingType("HVC1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MsSmoothH265PackagingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MsSmoothH265PackagingType FindValue(string value)
        {
            return FindValue<MsSmoothH265PackagingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MsSmoothH265PackagingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MultiplexState.
    /// </summary>
    public class MultiplexState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for MultiplexState
        /// </summary>
        public static readonly MultiplexState CREATE_FAILED = new MultiplexState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for MultiplexState
        /// </summary>
        public static readonly MultiplexState CREATING = new MultiplexState("CREATING");
        /// <summary>
        /// Constant DELETED for MultiplexState
        /// </summary>
        public static readonly MultiplexState DELETED = new MultiplexState("DELETED");
        /// <summary>
        /// Constant DELETING for MultiplexState
        /// </summary>
        public static readonly MultiplexState DELETING = new MultiplexState("DELETING");
        /// <summary>
        /// Constant IDLE for MultiplexState
        /// </summary>
        public static readonly MultiplexState IDLE = new MultiplexState("IDLE");
        /// <summary>
        /// Constant RECOVERING for MultiplexState
        /// </summary>
        public static readonly MultiplexState RECOVERING = new MultiplexState("RECOVERING");
        /// <summary>
        /// Constant RUNNING for MultiplexState
        /// </summary>
        public static readonly MultiplexState RUNNING = new MultiplexState("RUNNING");
        /// <summary>
        /// Constant STARTING for MultiplexState
        /// </summary>
        public static readonly MultiplexState STARTING = new MultiplexState("STARTING");
        /// <summary>
        /// Constant STOPPING for MultiplexState
        /// </summary>
        public static readonly MultiplexState STOPPING = new MultiplexState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MultiplexState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MultiplexState FindValue(string value)
        {
            return FindValue<MultiplexState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MultiplexState(string value)
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
    /// Constants used for properties of type NielsenPcmToId3TaggingState.
    /// </summary>
    public class NielsenPcmToId3TaggingState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for NielsenPcmToId3TaggingState
        /// </summary>
        public static readonly NielsenPcmToId3TaggingState DISABLED = new NielsenPcmToId3TaggingState("DISABLED");
        /// <summary>
        /// Constant ENABLED for NielsenPcmToId3TaggingState
        /// </summary>
        public static readonly NielsenPcmToId3TaggingState ENABLED = new NielsenPcmToId3TaggingState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NielsenPcmToId3TaggingState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NielsenPcmToId3TaggingState FindValue(string value)
        {
            return FindValue<NielsenPcmToId3TaggingState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NielsenPcmToId3TaggingState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NielsenWatermarksCbetStepaside.
    /// </summary>
    public class NielsenWatermarksCbetStepaside : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for NielsenWatermarksCbetStepaside
        /// </summary>
        public static readonly NielsenWatermarksCbetStepaside DISABLED = new NielsenWatermarksCbetStepaside("DISABLED");
        /// <summary>
        /// Constant ENABLED for NielsenWatermarksCbetStepaside
        /// </summary>
        public static readonly NielsenWatermarksCbetStepaside ENABLED = new NielsenWatermarksCbetStepaside("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NielsenWatermarksCbetStepaside(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NielsenWatermarksCbetStepaside FindValue(string value)
        {
            return FindValue<NielsenWatermarksCbetStepaside>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NielsenWatermarksCbetStepaside(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NielsenWatermarksDistributionTypes.
    /// </summary>
    public class NielsenWatermarksDistributionTypes : ConstantClass
    {

        /// <summary>
        /// Constant FINAL_DISTRIBUTOR for NielsenWatermarksDistributionTypes
        /// </summary>
        public static readonly NielsenWatermarksDistributionTypes FINAL_DISTRIBUTOR = new NielsenWatermarksDistributionTypes("FINAL_DISTRIBUTOR");
        /// <summary>
        /// Constant PROGRAM_CONTENT for NielsenWatermarksDistributionTypes
        /// </summary>
        public static readonly NielsenWatermarksDistributionTypes PROGRAM_CONTENT = new NielsenWatermarksDistributionTypes("PROGRAM_CONTENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NielsenWatermarksDistributionTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NielsenWatermarksDistributionTypes FindValue(string value)
        {
            return FindValue<NielsenWatermarksDistributionTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NielsenWatermarksDistributionTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OfferingDurationUnits.
    /// </summary>
    public class OfferingDurationUnits : ConstantClass
    {

        /// <summary>
        /// Constant MONTHS for OfferingDurationUnits
        /// </summary>
        public static readonly OfferingDurationUnits MONTHS = new OfferingDurationUnits("MONTHS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OfferingDurationUnits(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfferingDurationUnits FindValue(string value)
        {
            return FindValue<OfferingDurationUnits>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OfferingDurationUnits(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OfferingType.
    /// </summary>
    public class OfferingType : ConstantClass
    {

        /// <summary>
        /// Constant NO_UPFRONT for OfferingType
        /// </summary>
        public static readonly OfferingType NO_UPFRONT = new OfferingType("NO_UPFRONT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OfferingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfferingType FindValue(string value)
        {
            return FindValue<OfferingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OfferingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipelineId.
    /// </summary>
    public class PipelineId : ConstantClass
    {

        /// <summary>
        /// Constant PIPELINE_0 for PipelineId
        /// </summary>
        public static readonly PipelineId PIPELINE_0 = new PipelineId("PIPELINE_0");
        /// <summary>
        /// Constant PIPELINE_1 for PipelineId
        /// </summary>
        public static readonly PipelineId PIPELINE_1 = new PipelineId("PIPELINE_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineId(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineId FindValue(string value)
        {
            return FindValue<PipelineId>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineId(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PreferredChannelPipeline.
    /// </summary>
    public class PreferredChannelPipeline : ConstantClass
    {

        /// <summary>
        /// Constant CURRENTLY_ACTIVE for PreferredChannelPipeline
        /// </summary>
        public static readonly PreferredChannelPipeline CURRENTLY_ACTIVE = new PreferredChannelPipeline("CURRENTLY_ACTIVE");
        /// <summary>
        /// Constant PIPELINE_0 for PreferredChannelPipeline
        /// </summary>
        public static readonly PreferredChannelPipeline PIPELINE_0 = new PreferredChannelPipeline("PIPELINE_0");
        /// <summary>
        /// Constant PIPELINE_1 for PreferredChannelPipeline
        /// </summary>
        public static readonly PreferredChannelPipeline PIPELINE_1 = new PreferredChannelPipeline("PIPELINE_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PreferredChannelPipeline(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreferredChannelPipeline FindValue(string value)
        {
            return FindValue<PreferredChannelPipeline>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreferredChannelPipeline(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RebootInputDeviceForce.
    /// </summary>
    public class RebootInputDeviceForce : ConstantClass
    {

        /// <summary>
        /// Constant NO for RebootInputDeviceForce
        /// </summary>
        public static readonly RebootInputDeviceForce NO = new RebootInputDeviceForce("NO");
        /// <summary>
        /// Constant YES for RebootInputDeviceForce
        /// </summary>
        public static readonly RebootInputDeviceForce YES = new RebootInputDeviceForce("YES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RebootInputDeviceForce(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RebootInputDeviceForce FindValue(string value)
        {
            return FindValue<RebootInputDeviceForce>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RebootInputDeviceForce(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservationAutomaticRenewal.
    /// </summary>
    public class ReservationAutomaticRenewal : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ReservationAutomaticRenewal
        /// </summary>
        public static readonly ReservationAutomaticRenewal DISABLED = new ReservationAutomaticRenewal("DISABLED");
        /// <summary>
        /// Constant ENABLED for ReservationAutomaticRenewal
        /// </summary>
        public static readonly ReservationAutomaticRenewal ENABLED = new ReservationAutomaticRenewal("ENABLED");
        /// <summary>
        /// Constant UNAVAILABLE for ReservationAutomaticRenewal
        /// </summary>
        public static readonly ReservationAutomaticRenewal UNAVAILABLE = new ReservationAutomaticRenewal("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservationAutomaticRenewal(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservationAutomaticRenewal FindValue(string value)
        {
            return FindValue<ReservationAutomaticRenewal>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservationAutomaticRenewal(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservationCodec.
    /// </summary>
    public class ReservationCodec : ConstantClass
    {

        /// <summary>
        /// Constant AUDIO for ReservationCodec
        /// </summary>
        public static readonly ReservationCodec AUDIO = new ReservationCodec("AUDIO");
        /// <summary>
        /// Constant AVC for ReservationCodec
        /// </summary>
        public static readonly ReservationCodec AVC = new ReservationCodec("AVC");
        /// <summary>
        /// Constant HEVC for ReservationCodec
        /// </summary>
        public static readonly ReservationCodec HEVC = new ReservationCodec("HEVC");
        /// <summary>
        /// Constant LINK for ReservationCodec
        /// </summary>
        public static readonly ReservationCodec LINK = new ReservationCodec("LINK");
        /// <summary>
        /// Constant MPEG2 for ReservationCodec
        /// </summary>
        public static readonly ReservationCodec MPEG2 = new ReservationCodec("MPEG2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservationCodec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservationCodec FindValue(string value)
        {
            return FindValue<ReservationCodec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservationCodec(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservationMaximumBitrate.
    /// </summary>
    public class ReservationMaximumBitrate : ConstantClass
    {

        /// <summary>
        /// Constant MAX_10_MBPS for ReservationMaximumBitrate
        /// </summary>
        public static readonly ReservationMaximumBitrate MAX_10_MBPS = new ReservationMaximumBitrate("MAX_10_MBPS");
        /// <summary>
        /// Constant MAX_20_MBPS for ReservationMaximumBitrate
        /// </summary>
        public static readonly ReservationMaximumBitrate MAX_20_MBPS = new ReservationMaximumBitrate("MAX_20_MBPS");
        /// <summary>
        /// Constant MAX_50_MBPS for ReservationMaximumBitrate
        /// </summary>
        public static readonly ReservationMaximumBitrate MAX_50_MBPS = new ReservationMaximumBitrate("MAX_50_MBPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservationMaximumBitrate(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservationMaximumBitrate FindValue(string value)
        {
            return FindValue<ReservationMaximumBitrate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservationMaximumBitrate(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservationMaximumFramerate.
    /// </summary>
    public class ReservationMaximumFramerate : ConstantClass
    {

        /// <summary>
        /// Constant MAX_30_FPS for ReservationMaximumFramerate
        /// </summary>
        public static readonly ReservationMaximumFramerate MAX_30_FPS = new ReservationMaximumFramerate("MAX_30_FPS");
        /// <summary>
        /// Constant MAX_60_FPS for ReservationMaximumFramerate
        /// </summary>
        public static readonly ReservationMaximumFramerate MAX_60_FPS = new ReservationMaximumFramerate("MAX_60_FPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservationMaximumFramerate(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservationMaximumFramerate FindValue(string value)
        {
            return FindValue<ReservationMaximumFramerate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservationMaximumFramerate(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservationResolution.
    /// </summary>
    public class ReservationResolution : ConstantClass
    {

        /// <summary>
        /// Constant FHD for ReservationResolution
        /// </summary>
        public static readonly ReservationResolution FHD = new ReservationResolution("FHD");
        /// <summary>
        /// Constant HD for ReservationResolution
        /// </summary>
        public static readonly ReservationResolution HD = new ReservationResolution("HD");
        /// <summary>
        /// Constant SD for ReservationResolution
        /// </summary>
        public static readonly ReservationResolution SD = new ReservationResolution("SD");
        /// <summary>
        /// Constant UHD for ReservationResolution
        /// </summary>
        public static readonly ReservationResolution UHD = new ReservationResolution("UHD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservationResolution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservationResolution FindValue(string value)
        {
            return FindValue<ReservationResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservationResolution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservationResourceType.
    /// </summary>
    public class ReservationResourceType : ConstantClass
    {

        /// <summary>
        /// Constant CHANNEL for ReservationResourceType
        /// </summary>
        public static readonly ReservationResourceType CHANNEL = new ReservationResourceType("CHANNEL");
        /// <summary>
        /// Constant INPUT for ReservationResourceType
        /// </summary>
        public static readonly ReservationResourceType INPUT = new ReservationResourceType("INPUT");
        /// <summary>
        /// Constant MULTIPLEX for ReservationResourceType
        /// </summary>
        public static readonly ReservationResourceType MULTIPLEX = new ReservationResourceType("MULTIPLEX");
        /// <summary>
        /// Constant OUTPUT for ReservationResourceType
        /// </summary>
        public static readonly ReservationResourceType OUTPUT = new ReservationResourceType("OUTPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservationResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservationResourceType FindValue(string value)
        {
            return FindValue<ReservationResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservationResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservationSpecialFeature.
    /// </summary>
    public class ReservationSpecialFeature : ConstantClass
    {

        /// <summary>
        /// Constant ADVANCED_AUDIO for ReservationSpecialFeature
        /// </summary>
        public static readonly ReservationSpecialFeature ADVANCED_AUDIO = new ReservationSpecialFeature("ADVANCED_AUDIO");
        /// <summary>
        /// Constant AUDIO_NORMALIZATION for ReservationSpecialFeature
        /// </summary>
        public static readonly ReservationSpecialFeature AUDIO_NORMALIZATION = new ReservationSpecialFeature("AUDIO_NORMALIZATION");
        /// <summary>
        /// Constant MGHD for ReservationSpecialFeature
        /// </summary>
        public static readonly ReservationSpecialFeature MGHD = new ReservationSpecialFeature("MGHD");
        /// <summary>
        /// Constant MGUHD for ReservationSpecialFeature
        /// </summary>
        public static readonly ReservationSpecialFeature MGUHD = new ReservationSpecialFeature("MGUHD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservationSpecialFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservationSpecialFeature FindValue(string value)
        {
            return FindValue<ReservationSpecialFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservationSpecialFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservationState.
    /// </summary>
    public class ReservationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ReservationState
        /// </summary>
        public static readonly ReservationState ACTIVE = new ReservationState("ACTIVE");
        /// <summary>
        /// Constant CANCELED for ReservationState
        /// </summary>
        public static readonly ReservationState CANCELED = new ReservationState("CANCELED");
        /// <summary>
        /// Constant DELETED for ReservationState
        /// </summary>
        public static readonly ReservationState DELETED = new ReservationState("DELETED");
        /// <summary>
        /// Constant EXPIRED for ReservationState
        /// </summary>
        public static readonly ReservationState EXPIRED = new ReservationState("EXPIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservationState FindValue(string value)
        {
            return FindValue<ReservationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservationVideoQuality.
    /// </summary>
    public class ReservationVideoQuality : ConstantClass
    {

        /// <summary>
        /// Constant ENHANCED for ReservationVideoQuality
        /// </summary>
        public static readonly ReservationVideoQuality ENHANCED = new ReservationVideoQuality("ENHANCED");
        /// <summary>
        /// Constant PREMIUM for ReservationVideoQuality
        /// </summary>
        public static readonly ReservationVideoQuality PREMIUM = new ReservationVideoQuality("PREMIUM");
        /// <summary>
        /// Constant STANDARD for ReservationVideoQuality
        /// </summary>
        public static readonly ReservationVideoQuality STANDARD = new ReservationVideoQuality("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservationVideoQuality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservationVideoQuality FindValue(string value)
        {
            return FindValue<ReservationVideoQuality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservationVideoQuality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RtmpAdMarkers.
    /// </summary>
    public class RtmpAdMarkers : ConstantClass
    {

        /// <summary>
        /// Constant ON_CUE_POINT_SCTE35 for RtmpAdMarkers
        /// </summary>
        public static readonly RtmpAdMarkers ON_CUE_POINT_SCTE35 = new RtmpAdMarkers("ON_CUE_POINT_SCTE35");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RtmpAdMarkers(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RtmpAdMarkers FindValue(string value)
        {
            return FindValue<RtmpAdMarkers>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RtmpAdMarkers(string value)
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
    /// Constants used for properties of type S3CannedAcl.
    /// </summary>
    public class S3CannedAcl : ConstantClass
    {

        /// <summary>
        /// Constant AUTHENTICATED_READ for S3CannedAcl
        /// </summary>
        public static readonly S3CannedAcl AUTHENTICATED_READ = new S3CannedAcl("AUTHENTICATED_READ");
        /// <summary>
        /// Constant BUCKET_OWNER_FULL_CONTROL for S3CannedAcl
        /// </summary>
        public static readonly S3CannedAcl BUCKET_OWNER_FULL_CONTROL = new S3CannedAcl("BUCKET_OWNER_FULL_CONTROL");
        /// <summary>
        /// Constant BUCKET_OWNER_READ for S3CannedAcl
        /// </summary>
        public static readonly S3CannedAcl BUCKET_OWNER_READ = new S3CannedAcl("BUCKET_OWNER_READ");
        /// <summary>
        /// Constant PUBLIC_READ for S3CannedAcl
        /// </summary>
        public static readonly S3CannedAcl PUBLIC_READ = new S3CannedAcl("PUBLIC_READ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3CannedAcl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3CannedAcl FindValue(string value)
        {
            return FindValue<S3CannedAcl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3CannedAcl(string value)
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
    /// Constants used for properties of type Scte27OcrLanguage.
    /// </summary>
    public class Scte27OcrLanguage : ConstantClass
    {

        /// <summary>
        /// Constant DEU for Scte27OcrLanguage
        /// </summary>
        public static readonly Scte27OcrLanguage DEU = new Scte27OcrLanguage("DEU");
        /// <summary>
        /// Constant ENG for Scte27OcrLanguage
        /// </summary>
        public static readonly Scte27OcrLanguage ENG = new Scte27OcrLanguage("ENG");
        /// <summary>
        /// Constant FRA for Scte27OcrLanguage
        /// </summary>
        public static readonly Scte27OcrLanguage FRA = new Scte27OcrLanguage("FRA");
        /// <summary>
        /// Constant NLD for Scte27OcrLanguage
        /// </summary>
        public static readonly Scte27OcrLanguage NLD = new Scte27OcrLanguage("NLD");
        /// <summary>
        /// Constant POR for Scte27OcrLanguage
        /// </summary>
        public static readonly Scte27OcrLanguage POR = new Scte27OcrLanguage("POR");
        /// <summary>
        /// Constant SPA for Scte27OcrLanguage
        /// </summary>
        public static readonly Scte27OcrLanguage SPA = new Scte27OcrLanguage("SPA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scte27OcrLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scte27OcrLanguage FindValue(string value)
        {
            return FindValue<Scte27OcrLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scte27OcrLanguage(string value)
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
    /// Constants used for properties of type Scte35ArchiveAllowedFlag.
    /// </summary>
    public class Scte35ArchiveAllowedFlag : ConstantClass
    {

        /// <summary>
        /// Constant ARCHIVE_ALLOWED for Scte35ArchiveAllowedFlag
        /// </summary>
        public static readonly Scte35ArchiveAllowedFlag ARCHIVE_ALLOWED = new Scte35ArchiveAllowedFlag("ARCHIVE_ALLOWED");
        /// <summary>
        /// Constant ARCHIVE_NOT_ALLOWED for Scte35ArchiveAllowedFlag
        /// </summary>
        public static readonly Scte35ArchiveAllowedFlag ARCHIVE_NOT_ALLOWED = new Scte35ArchiveAllowedFlag("ARCHIVE_NOT_ALLOWED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scte35ArchiveAllowedFlag(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scte35ArchiveAllowedFlag FindValue(string value)
        {
            return FindValue<Scte35ArchiveAllowedFlag>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scte35ArchiveAllowedFlag(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scte35DeviceRestrictions.
    /// </summary>
    public class Scte35DeviceRestrictions : ConstantClass
    {

        /// <summary>
        /// Constant NONE for Scte35DeviceRestrictions
        /// </summary>
        public static readonly Scte35DeviceRestrictions NONE = new Scte35DeviceRestrictions("NONE");
        /// <summary>
        /// Constant RESTRICT_GROUP0 for Scte35DeviceRestrictions
        /// </summary>
        public static readonly Scte35DeviceRestrictions RESTRICT_GROUP0 = new Scte35DeviceRestrictions("RESTRICT_GROUP0");
        /// <summary>
        /// Constant RESTRICT_GROUP1 for Scte35DeviceRestrictions
        /// </summary>
        public static readonly Scte35DeviceRestrictions RESTRICT_GROUP1 = new Scte35DeviceRestrictions("RESTRICT_GROUP1");
        /// <summary>
        /// Constant RESTRICT_GROUP2 for Scte35DeviceRestrictions
        /// </summary>
        public static readonly Scte35DeviceRestrictions RESTRICT_GROUP2 = new Scte35DeviceRestrictions("RESTRICT_GROUP2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scte35DeviceRestrictions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scte35DeviceRestrictions FindValue(string value)
        {
            return FindValue<Scte35DeviceRestrictions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scte35DeviceRestrictions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scte35InputMode.
    /// </summary>
    public class Scte35InputMode : ConstantClass
    {

        /// <summary>
        /// Constant FIXED for Scte35InputMode
        /// </summary>
        public static readonly Scte35InputMode FIXED = new Scte35InputMode("FIXED");
        /// <summary>
        /// Constant FOLLOW_ACTIVE for Scte35InputMode
        /// </summary>
        public static readonly Scte35InputMode FOLLOW_ACTIVE = new Scte35InputMode("FOLLOW_ACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scte35InputMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scte35InputMode FindValue(string value)
        {
            return FindValue<Scte35InputMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scte35InputMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scte35NoRegionalBlackoutFlag.
    /// </summary>
    public class Scte35NoRegionalBlackoutFlag : ConstantClass
    {

        /// <summary>
        /// Constant NO_REGIONAL_BLACKOUT for Scte35NoRegionalBlackoutFlag
        /// </summary>
        public static readonly Scte35NoRegionalBlackoutFlag NO_REGIONAL_BLACKOUT = new Scte35NoRegionalBlackoutFlag("NO_REGIONAL_BLACKOUT");
        /// <summary>
        /// Constant REGIONAL_BLACKOUT for Scte35NoRegionalBlackoutFlag
        /// </summary>
        public static readonly Scte35NoRegionalBlackoutFlag REGIONAL_BLACKOUT = new Scte35NoRegionalBlackoutFlag("REGIONAL_BLACKOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scte35NoRegionalBlackoutFlag(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scte35NoRegionalBlackoutFlag FindValue(string value)
        {
            return FindValue<Scte35NoRegionalBlackoutFlag>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scte35NoRegionalBlackoutFlag(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scte35SegmentationCancelIndicator.
    /// </summary>
    public class Scte35SegmentationCancelIndicator : ConstantClass
    {

        /// <summary>
        /// Constant SEGMENTATION_EVENT_CANCELED for Scte35SegmentationCancelIndicator
        /// </summary>
        public static readonly Scte35SegmentationCancelIndicator SEGMENTATION_EVENT_CANCELED = new Scte35SegmentationCancelIndicator("SEGMENTATION_EVENT_CANCELED");
        /// <summary>
        /// Constant SEGMENTATION_EVENT_NOT_CANCELED for Scte35SegmentationCancelIndicator
        /// </summary>
        public static readonly Scte35SegmentationCancelIndicator SEGMENTATION_EVENT_NOT_CANCELED = new Scte35SegmentationCancelIndicator("SEGMENTATION_EVENT_NOT_CANCELED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scte35SegmentationCancelIndicator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scte35SegmentationCancelIndicator FindValue(string value)
        {
            return FindValue<Scte35SegmentationCancelIndicator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scte35SegmentationCancelIndicator(string value)
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
    /// Constants used for properties of type Scte35WebDeliveryAllowedFlag.
    /// </summary>
    public class Scte35WebDeliveryAllowedFlag : ConstantClass
    {

        /// <summary>
        /// Constant WEB_DELIVERY_ALLOWED for Scte35WebDeliveryAllowedFlag
        /// </summary>
        public static readonly Scte35WebDeliveryAllowedFlag WEB_DELIVERY_ALLOWED = new Scte35WebDeliveryAllowedFlag("WEB_DELIVERY_ALLOWED");
        /// <summary>
        /// Constant WEB_DELIVERY_NOT_ALLOWED for Scte35WebDeliveryAllowedFlag
        /// </summary>
        public static readonly Scte35WebDeliveryAllowedFlag WEB_DELIVERY_NOT_ALLOWED = new Scte35WebDeliveryAllowedFlag("WEB_DELIVERY_NOT_ALLOWED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scte35WebDeliveryAllowedFlag(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scte35WebDeliveryAllowedFlag FindValue(string value)
        {
            return FindValue<Scte35WebDeliveryAllowedFlag>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scte35WebDeliveryAllowedFlag(string value)
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
        /// Constant SCTE_35_WITHOUT_SEGMENTATION for SmoothGroupSparseTrackType
        /// </summary>
        public static readonly SmoothGroupSparseTrackType SCTE_35_WITHOUT_SEGMENTATION = new SmoothGroupSparseTrackType("SCTE_35_WITHOUT_SEGMENTATION");

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
    /// Constants used for properties of type Smpte2038DataPreference.
    /// </summary>
    public class Smpte2038DataPreference : ConstantClass
    {

        /// <summary>
        /// Constant IGNORE for Smpte2038DataPreference
        /// </summary>
        public static readonly Smpte2038DataPreference IGNORE = new Smpte2038DataPreference("IGNORE");
        /// <summary>
        /// Constant PREFER for Smpte2038DataPreference
        /// </summary>
        public static readonly Smpte2038DataPreference PREFER = new Smpte2038DataPreference("PREFER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Smpte2038DataPreference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Smpte2038DataPreference FindValue(string value)
        {
            return FindValue<Smpte2038DataPreference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Smpte2038DataPreference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemporalFilterPostFilterSharpening.
    /// </summary>
    public class TemporalFilterPostFilterSharpening : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for TemporalFilterPostFilterSharpening
        /// </summary>
        public static readonly TemporalFilterPostFilterSharpening AUTO = new TemporalFilterPostFilterSharpening("AUTO");
        /// <summary>
        /// Constant DISABLED for TemporalFilterPostFilterSharpening
        /// </summary>
        public static readonly TemporalFilterPostFilterSharpening DISABLED = new TemporalFilterPostFilterSharpening("DISABLED");
        /// <summary>
        /// Constant ENABLED for TemporalFilterPostFilterSharpening
        /// </summary>
        public static readonly TemporalFilterPostFilterSharpening ENABLED = new TemporalFilterPostFilterSharpening("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemporalFilterPostFilterSharpening(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemporalFilterPostFilterSharpening FindValue(string value)
        {
            return FindValue<TemporalFilterPostFilterSharpening>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemporalFilterPostFilterSharpening(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemporalFilterStrength.
    /// </summary>
    public class TemporalFilterStrength : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength AUTO = new TemporalFilterStrength("AUTO");
        /// <summary>
        /// Constant STRENGTH_1 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_1 = new TemporalFilterStrength("STRENGTH_1");
        /// <summary>
        /// Constant STRENGTH_10 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_10 = new TemporalFilterStrength("STRENGTH_10");
        /// <summary>
        /// Constant STRENGTH_11 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_11 = new TemporalFilterStrength("STRENGTH_11");
        /// <summary>
        /// Constant STRENGTH_12 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_12 = new TemporalFilterStrength("STRENGTH_12");
        /// <summary>
        /// Constant STRENGTH_13 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_13 = new TemporalFilterStrength("STRENGTH_13");
        /// <summary>
        /// Constant STRENGTH_14 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_14 = new TemporalFilterStrength("STRENGTH_14");
        /// <summary>
        /// Constant STRENGTH_15 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_15 = new TemporalFilterStrength("STRENGTH_15");
        /// <summary>
        /// Constant STRENGTH_16 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_16 = new TemporalFilterStrength("STRENGTH_16");
        /// <summary>
        /// Constant STRENGTH_2 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_2 = new TemporalFilterStrength("STRENGTH_2");
        /// <summary>
        /// Constant STRENGTH_3 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_3 = new TemporalFilterStrength("STRENGTH_3");
        /// <summary>
        /// Constant STRENGTH_4 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_4 = new TemporalFilterStrength("STRENGTH_4");
        /// <summary>
        /// Constant STRENGTH_5 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_5 = new TemporalFilterStrength("STRENGTH_5");
        /// <summary>
        /// Constant STRENGTH_6 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_6 = new TemporalFilterStrength("STRENGTH_6");
        /// <summary>
        /// Constant STRENGTH_7 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_7 = new TemporalFilterStrength("STRENGTH_7");
        /// <summary>
        /// Constant STRENGTH_8 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_8 = new TemporalFilterStrength("STRENGTH_8");
        /// <summary>
        /// Constant STRENGTH_9 for TemporalFilterStrength
        /// </summary>
        public static readonly TemporalFilterStrength STRENGTH_9 = new TemporalFilterStrength("STRENGTH_9");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemporalFilterStrength(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemporalFilterStrength FindValue(string value)
        {
            return FindValue<TemporalFilterStrength>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemporalFilterStrength(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimecodeBurninFontSize.
    /// </summary>
    public class TimecodeBurninFontSize : ConstantClass
    {

        /// <summary>
        /// Constant EXTRA_SMALL_10 for TimecodeBurninFontSize
        /// </summary>
        public static readonly TimecodeBurninFontSize EXTRA_SMALL_10 = new TimecodeBurninFontSize("EXTRA_SMALL_10");
        /// <summary>
        /// Constant LARGE_48 for TimecodeBurninFontSize
        /// </summary>
        public static readonly TimecodeBurninFontSize LARGE_48 = new TimecodeBurninFontSize("LARGE_48");
        /// <summary>
        /// Constant MEDIUM_32 for TimecodeBurninFontSize
        /// </summary>
        public static readonly TimecodeBurninFontSize MEDIUM_32 = new TimecodeBurninFontSize("MEDIUM_32");
        /// <summary>
        /// Constant SMALL_16 for TimecodeBurninFontSize
        /// </summary>
        public static readonly TimecodeBurninFontSize SMALL_16 = new TimecodeBurninFontSize("SMALL_16");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimecodeBurninFontSize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimecodeBurninFontSize FindValue(string value)
        {
            return FindValue<TimecodeBurninFontSize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimecodeBurninFontSize(string value)
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
        /// Constant HDR10 for VideoSelectorColorSpace
        /// </summary>
        public static readonly VideoSelectorColorSpace HDR10 = new VideoSelectorColorSpace("HDR10");
        /// <summary>
        /// Constant HLG_2020 for VideoSelectorColorSpace
        /// </summary>
        public static readonly VideoSelectorColorSpace HLG_2020 = new VideoSelectorColorSpace("HLG_2020");
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


    /// <summary>
    /// Constants used for properties of type WavCodingMode.
    /// </summary>
    public class WavCodingMode : ConstantClass
    {

        /// <summary>
        /// Constant CODING_MODE_1_0 for WavCodingMode
        /// </summary>
        public static readonly WavCodingMode CODING_MODE_1_0 = new WavCodingMode("CODING_MODE_1_0");
        /// <summary>
        /// Constant CODING_MODE_2_0 for WavCodingMode
        /// </summary>
        public static readonly WavCodingMode CODING_MODE_2_0 = new WavCodingMode("CODING_MODE_2_0");
        /// <summary>
        /// Constant CODING_MODE_4_0 for WavCodingMode
        /// </summary>
        public static readonly WavCodingMode CODING_MODE_4_0 = new WavCodingMode("CODING_MODE_4_0");
        /// <summary>
        /// Constant CODING_MODE_8_0 for WavCodingMode
        /// </summary>
        public static readonly WavCodingMode CODING_MODE_8_0 = new WavCodingMode("CODING_MODE_8_0");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WavCodingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WavCodingMode FindValue(string value)
        {
            return FindValue<WavCodingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WavCodingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WebvttDestinationStyleControl.
    /// </summary>
    public class WebvttDestinationStyleControl : ConstantClass
    {

        /// <summary>
        /// Constant NO_STYLE_DATA for WebvttDestinationStyleControl
        /// </summary>
        public static readonly WebvttDestinationStyleControl NO_STYLE_DATA = new WebvttDestinationStyleControl("NO_STYLE_DATA");
        /// <summary>
        /// Constant PASSTHROUGH for WebvttDestinationStyleControl
        /// </summary>
        public static readonly WebvttDestinationStyleControl PASSTHROUGH = new WebvttDestinationStyleControl("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebvttDestinationStyleControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebvttDestinationStyleControl FindValue(string value)
        {
            return FindValue<WebvttDestinationStyleControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebvttDestinationStyleControl(string value)
        {
            return FindValue(value);
        }
    }

}