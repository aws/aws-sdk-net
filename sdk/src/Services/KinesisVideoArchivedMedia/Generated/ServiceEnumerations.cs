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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.KinesisVideoArchivedMedia
{

    /// <summary>
    /// Constants used for properties of type ClipFragmentSelectorType.
    /// </summary>
    public class ClipFragmentSelectorType : ConstantClass
    {

        /// <summary>
        /// Constant PRODUCER_TIMESTAMP for ClipFragmentSelectorType
        /// </summary>
        public static readonly ClipFragmentSelectorType PRODUCER_TIMESTAMP = new ClipFragmentSelectorType("PRODUCER_TIMESTAMP");
        /// <summary>
        /// Constant SERVER_TIMESTAMP for ClipFragmentSelectorType
        /// </summary>
        public static readonly ClipFragmentSelectorType SERVER_TIMESTAMP = new ClipFragmentSelectorType("SERVER_TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClipFragmentSelectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClipFragmentSelectorType FindValue(string value)
        {
            return FindValue<ClipFragmentSelectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClipFragmentSelectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerFormat.
    /// </summary>
    public class ContainerFormat : ConstantClass
    {

        /// <summary>
        /// Constant FRAGMENTED_MP4 for ContainerFormat
        /// </summary>
        public static readonly ContainerFormat FRAGMENTED_MP4 = new ContainerFormat("FRAGMENTED_MP4");
        /// <summary>
        /// Constant MPEG_TS for ContainerFormat
        /// </summary>
        public static readonly ContainerFormat MPEG_TS = new ContainerFormat("MPEG_TS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerFormat FindValue(string value)
        {
            return FindValue<ContainerFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DASHDisplayFragmentNumber.
    /// </summary>
    public class DASHDisplayFragmentNumber : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS for DASHDisplayFragmentNumber
        /// </summary>
        public static readonly DASHDisplayFragmentNumber ALWAYS = new DASHDisplayFragmentNumber("ALWAYS");
        /// <summary>
        /// Constant NEVER for DASHDisplayFragmentNumber
        /// </summary>
        public static readonly DASHDisplayFragmentNumber NEVER = new DASHDisplayFragmentNumber("NEVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DASHDisplayFragmentNumber(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DASHDisplayFragmentNumber FindValue(string value)
        {
            return FindValue<DASHDisplayFragmentNumber>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DASHDisplayFragmentNumber(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DASHDisplayFragmentTimestamp.
    /// </summary>
    public class DASHDisplayFragmentTimestamp : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS for DASHDisplayFragmentTimestamp
        /// </summary>
        public static readonly DASHDisplayFragmentTimestamp ALWAYS = new DASHDisplayFragmentTimestamp("ALWAYS");
        /// <summary>
        /// Constant NEVER for DASHDisplayFragmentTimestamp
        /// </summary>
        public static readonly DASHDisplayFragmentTimestamp NEVER = new DASHDisplayFragmentTimestamp("NEVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DASHDisplayFragmentTimestamp(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DASHDisplayFragmentTimestamp FindValue(string value)
        {
            return FindValue<DASHDisplayFragmentTimestamp>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DASHDisplayFragmentTimestamp(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DASHFragmentSelectorType.
    /// </summary>
    public class DASHFragmentSelectorType : ConstantClass
    {

        /// <summary>
        /// Constant PRODUCER_TIMESTAMP for DASHFragmentSelectorType
        /// </summary>
        public static readonly DASHFragmentSelectorType PRODUCER_TIMESTAMP = new DASHFragmentSelectorType("PRODUCER_TIMESTAMP");
        /// <summary>
        /// Constant SERVER_TIMESTAMP for DASHFragmentSelectorType
        /// </summary>
        public static readonly DASHFragmentSelectorType SERVER_TIMESTAMP = new DASHFragmentSelectorType("SERVER_TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DASHFragmentSelectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DASHFragmentSelectorType FindValue(string value)
        {
            return FindValue<DASHFragmentSelectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DASHFragmentSelectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DASHPlaybackMode.
    /// </summary>
    public class DASHPlaybackMode : ConstantClass
    {

        /// <summary>
        /// Constant LIVE for DASHPlaybackMode
        /// </summary>
        public static readonly DASHPlaybackMode LIVE = new DASHPlaybackMode("LIVE");
        /// <summary>
        /// Constant LIVE_REPLAY for DASHPlaybackMode
        /// </summary>
        public static readonly DASHPlaybackMode LIVE_REPLAY = new DASHPlaybackMode("LIVE_REPLAY");
        /// <summary>
        /// Constant ON_DEMAND for DASHPlaybackMode
        /// </summary>
        public static readonly DASHPlaybackMode ON_DEMAND = new DASHPlaybackMode("ON_DEMAND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DASHPlaybackMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DASHPlaybackMode FindValue(string value)
        {
            return FindValue<DASHPlaybackMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DASHPlaybackMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Format.
    /// </summary>
    public class Format : ConstantClass
    {

        /// <summary>
        /// Constant JPEG for Format
        /// </summary>
        public static readonly Format JPEG = new Format("JPEG");
        /// <summary>
        /// Constant PNG for Format
        /// </summary>
        public static readonly Format PNG = new Format("PNG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Format(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Format FindValue(string value)
        {
            return FindValue<Format>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Format(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FormatConfigKey.
    /// </summary>
    public class FormatConfigKey : ConstantClass
    {

        /// <summary>
        /// Constant JPEGQuality for FormatConfigKey
        /// </summary>
        public static readonly FormatConfigKey JPEGQuality = new FormatConfigKey("JPEGQuality");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FormatConfigKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FormatConfigKey FindValue(string value)
        {
            return FindValue<FormatConfigKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FormatConfigKey(string value)
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
        /// Constant PRODUCER_TIMESTAMP for FragmentSelectorType
        /// </summary>
        public static readonly FragmentSelectorType PRODUCER_TIMESTAMP = new FragmentSelectorType("PRODUCER_TIMESTAMP");
        /// <summary>
        /// Constant SERVER_TIMESTAMP for FragmentSelectorType
        /// </summary>
        public static readonly FragmentSelectorType SERVER_TIMESTAMP = new FragmentSelectorType("SERVER_TIMESTAMP");

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
    /// Constants used for properties of type HLSDiscontinuityMode.
    /// </summary>
    public class HLSDiscontinuityMode : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS for HLSDiscontinuityMode
        /// </summary>
        public static readonly HLSDiscontinuityMode ALWAYS = new HLSDiscontinuityMode("ALWAYS");
        /// <summary>
        /// Constant NEVER for HLSDiscontinuityMode
        /// </summary>
        public static readonly HLSDiscontinuityMode NEVER = new HLSDiscontinuityMode("NEVER");
        /// <summary>
        /// Constant ON_DISCONTINUITY for HLSDiscontinuityMode
        /// </summary>
        public static readonly HLSDiscontinuityMode ON_DISCONTINUITY = new HLSDiscontinuityMode("ON_DISCONTINUITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HLSDiscontinuityMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HLSDiscontinuityMode FindValue(string value)
        {
            return FindValue<HLSDiscontinuityMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HLSDiscontinuityMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HLSDisplayFragmentTimestamp.
    /// </summary>
    public class HLSDisplayFragmentTimestamp : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS for HLSDisplayFragmentTimestamp
        /// </summary>
        public static readonly HLSDisplayFragmentTimestamp ALWAYS = new HLSDisplayFragmentTimestamp("ALWAYS");
        /// <summary>
        /// Constant NEVER for HLSDisplayFragmentTimestamp
        /// </summary>
        public static readonly HLSDisplayFragmentTimestamp NEVER = new HLSDisplayFragmentTimestamp("NEVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HLSDisplayFragmentTimestamp(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HLSDisplayFragmentTimestamp FindValue(string value)
        {
            return FindValue<HLSDisplayFragmentTimestamp>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HLSDisplayFragmentTimestamp(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HLSFragmentSelectorType.
    /// </summary>
    public class HLSFragmentSelectorType : ConstantClass
    {

        /// <summary>
        /// Constant PRODUCER_TIMESTAMP for HLSFragmentSelectorType
        /// </summary>
        public static readonly HLSFragmentSelectorType PRODUCER_TIMESTAMP = new HLSFragmentSelectorType("PRODUCER_TIMESTAMP");
        /// <summary>
        /// Constant SERVER_TIMESTAMP for HLSFragmentSelectorType
        /// </summary>
        public static readonly HLSFragmentSelectorType SERVER_TIMESTAMP = new HLSFragmentSelectorType("SERVER_TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HLSFragmentSelectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HLSFragmentSelectorType FindValue(string value)
        {
            return FindValue<HLSFragmentSelectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HLSFragmentSelectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HLSPlaybackMode.
    /// </summary>
    public class HLSPlaybackMode : ConstantClass
    {

        /// <summary>
        /// Constant LIVE for HLSPlaybackMode
        /// </summary>
        public static readonly HLSPlaybackMode LIVE = new HLSPlaybackMode("LIVE");
        /// <summary>
        /// Constant LIVE_REPLAY for HLSPlaybackMode
        /// </summary>
        public static readonly HLSPlaybackMode LIVE_REPLAY = new HLSPlaybackMode("LIVE_REPLAY");
        /// <summary>
        /// Constant ON_DEMAND for HLSPlaybackMode
        /// </summary>
        public static readonly HLSPlaybackMode ON_DEMAND = new HLSPlaybackMode("ON_DEMAND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HLSPlaybackMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HLSPlaybackMode FindValue(string value)
        {
            return FindValue<HLSPlaybackMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HLSPlaybackMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageError.
    /// </summary>
    public class ImageError : ConstantClass
    {

        /// <summary>
        /// Constant MEDIA_ERROR for ImageError
        /// </summary>
        public static readonly ImageError MEDIA_ERROR = new ImageError("MEDIA_ERROR");
        /// <summary>
        /// Constant NO_MEDIA for ImageError
        /// </summary>
        public static readonly ImageError NO_MEDIA = new ImageError("NO_MEDIA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageError(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageError FindValue(string value)
        {
            return FindValue<ImageError>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageError(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageSelectorType.
    /// </summary>
    public class ImageSelectorType : ConstantClass
    {

        /// <summary>
        /// Constant PRODUCER_TIMESTAMP for ImageSelectorType
        /// </summary>
        public static readonly ImageSelectorType PRODUCER_TIMESTAMP = new ImageSelectorType("PRODUCER_TIMESTAMP");
        /// <summary>
        /// Constant SERVER_TIMESTAMP for ImageSelectorType
        /// </summary>
        public static readonly ImageSelectorType SERVER_TIMESTAMP = new ImageSelectorType("SERVER_TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageSelectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageSelectorType FindValue(string value)
        {
            return FindValue<ImageSelectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageSelectorType(string value)
        {
            return FindValue(value);
        }
    }

}