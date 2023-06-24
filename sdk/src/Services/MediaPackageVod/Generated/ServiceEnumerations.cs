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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MediaPackageVod
{

    /// <summary>
    /// Constants used for properties of type __PeriodTriggersElement.
    /// </summary>
    public class __PeriodTriggersElement : ConstantClass
    {

        /// <summary>
        /// Constant ADS for __PeriodTriggersElement
        /// </summary>
        public static readonly __PeriodTriggersElement ADS = new __PeriodTriggersElement("ADS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public __PeriodTriggersElement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static __PeriodTriggersElement FindValue(string value)
        {
            return FindValue<__PeriodTriggersElement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator __PeriodTriggersElement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdMarkers.
    /// </summary>
    public class AdMarkers : ConstantClass
    {

        /// <summary>
        /// Constant NONE for AdMarkers
        /// </summary>
        public static readonly AdMarkers NONE = new AdMarkers("NONE");
        /// <summary>
        /// Constant PASSTHROUGH for AdMarkers
        /// </summary>
        public static readonly AdMarkers PASSTHROUGH = new AdMarkers("PASSTHROUGH");
        /// <summary>
        /// Constant SCTE35_ENHANCED for AdMarkers
        /// </summary>
        public static readonly AdMarkers SCTE35_ENHANCED = new AdMarkers("SCTE35_ENHANCED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdMarkers(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdMarkers FindValue(string value)
        {
            return FindValue<AdMarkers>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdMarkers(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionMethod.
    /// </summary>
    public class EncryptionMethod : ConstantClass
    {

        /// <summary>
        /// Constant AES_128 for EncryptionMethod
        /// </summary>
        public static readonly EncryptionMethod AES_128 = new EncryptionMethod("AES_128");
        /// <summary>
        /// Constant SAMPLE_AES for EncryptionMethod
        /// </summary>
        public static readonly EncryptionMethod SAMPLE_AES = new EncryptionMethod("SAMPLE_AES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionMethod FindValue(string value)
        {
            return FindValue<EncryptionMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManifestLayout.
    /// </summary>
    public class ManifestLayout : ConstantClass
    {

        /// <summary>
        /// Constant COMPACT for ManifestLayout
        /// </summary>
        public static readonly ManifestLayout COMPACT = new ManifestLayout("COMPACT");
        /// <summary>
        /// Constant FULL for ManifestLayout
        /// </summary>
        public static readonly ManifestLayout FULL = new ManifestLayout("FULL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManifestLayout(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManifestLayout FindValue(string value)
        {
            return FindValue<ManifestLayout>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManifestLayout(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PresetSpeke20Audio.
    /// </summary>
    public class PresetSpeke20Audio : ConstantClass
    {

        /// <summary>
        /// Constant PRESETAUDIO1 for PresetSpeke20Audio
        /// </summary>
        public static readonly PresetSpeke20Audio PRESETAUDIO1 = new PresetSpeke20Audio("PRESET-AUDIO-1");
        /// <summary>
        /// Constant PRESETAUDIO2 for PresetSpeke20Audio
        /// </summary>
        public static readonly PresetSpeke20Audio PRESETAUDIO2 = new PresetSpeke20Audio("PRESET-AUDIO-2");
        /// <summary>
        /// Constant PRESETAUDIO3 for PresetSpeke20Audio
        /// </summary>
        public static readonly PresetSpeke20Audio PRESETAUDIO3 = new PresetSpeke20Audio("PRESET-AUDIO-3");
        /// <summary>
        /// Constant SHARED for PresetSpeke20Audio
        /// </summary>
        public static readonly PresetSpeke20Audio SHARED = new PresetSpeke20Audio("SHARED");
        /// <summary>
        /// Constant UNENCRYPTED for PresetSpeke20Audio
        /// </summary>
        public static readonly PresetSpeke20Audio UNENCRYPTED = new PresetSpeke20Audio("UNENCRYPTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PresetSpeke20Audio(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PresetSpeke20Audio FindValue(string value)
        {
            return FindValue<PresetSpeke20Audio>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PresetSpeke20Audio(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PresetSpeke20Video.
    /// </summary>
    public class PresetSpeke20Video : ConstantClass
    {

        /// <summary>
        /// Constant PRESETVIDEO1 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESETVIDEO1 = new PresetSpeke20Video("PRESET-VIDEO-1");
        /// <summary>
        /// Constant PRESETVIDEO2 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESETVIDEO2 = new PresetSpeke20Video("PRESET-VIDEO-2");
        /// <summary>
        /// Constant PRESETVIDEO3 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESETVIDEO3 = new PresetSpeke20Video("PRESET-VIDEO-3");
        /// <summary>
        /// Constant PRESETVIDEO4 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESETVIDEO4 = new PresetSpeke20Video("PRESET-VIDEO-4");
        /// <summary>
        /// Constant PRESETVIDEO5 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESETVIDEO5 = new PresetSpeke20Video("PRESET-VIDEO-5");
        /// <summary>
        /// Constant PRESETVIDEO6 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESETVIDEO6 = new PresetSpeke20Video("PRESET-VIDEO-6");
        /// <summary>
        /// Constant PRESETVIDEO7 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESETVIDEO7 = new PresetSpeke20Video("PRESET-VIDEO-7");
        /// <summary>
        /// Constant PRESETVIDEO8 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESETVIDEO8 = new PresetSpeke20Video("PRESET-VIDEO-8");
        /// <summary>
        /// Constant SHARED for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video SHARED = new PresetSpeke20Video("SHARED");
        /// <summary>
        /// Constant UNENCRYPTED for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video UNENCRYPTED = new PresetSpeke20Video("UNENCRYPTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PresetSpeke20Video(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PresetSpeke20Video FindValue(string value)
        {
            return FindValue<PresetSpeke20Video>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PresetSpeke20Video(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Profile.
    /// </summary>
    public class Profile : ConstantClass
    {

        /// <summary>
        /// Constant HBBTV_1_5 for Profile
        /// </summary>
        public static readonly Profile HBBTV_1_5 = new Profile("HBBTV_1_5");
        /// <summary>
        /// Constant NONE for Profile
        /// </summary>
        public static readonly Profile NONE = new Profile("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Profile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Profile FindValue(string value)
        {
            return FindValue<Profile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Profile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScteMarkersSource.
    /// </summary>
    public class ScteMarkersSource : ConstantClass
    {

        /// <summary>
        /// Constant MANIFEST for ScteMarkersSource
        /// </summary>
        public static readonly ScteMarkersSource MANIFEST = new ScteMarkersSource("MANIFEST");
        /// <summary>
        /// Constant SEGMENTS for ScteMarkersSource
        /// </summary>
        public static readonly ScteMarkersSource SEGMENTS = new ScteMarkersSource("SEGMENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScteMarkersSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScteMarkersSource FindValue(string value)
        {
            return FindValue<ScteMarkersSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScteMarkersSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SegmentTemplateFormat.
    /// </summary>
    public class SegmentTemplateFormat : ConstantClass
    {

        /// <summary>
        /// Constant NUMBER_WITH_DURATION for SegmentTemplateFormat
        /// </summary>
        public static readonly SegmentTemplateFormat NUMBER_WITH_DURATION = new SegmentTemplateFormat("NUMBER_WITH_DURATION");
        /// <summary>
        /// Constant NUMBER_WITH_TIMELINE for SegmentTemplateFormat
        /// </summary>
        public static readonly SegmentTemplateFormat NUMBER_WITH_TIMELINE = new SegmentTemplateFormat("NUMBER_WITH_TIMELINE");
        /// <summary>
        /// Constant TIME_WITH_TIMELINE for SegmentTemplateFormat
        /// </summary>
        public static readonly SegmentTemplateFormat TIME_WITH_TIMELINE = new SegmentTemplateFormat("TIME_WITH_TIMELINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SegmentTemplateFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SegmentTemplateFormat FindValue(string value)
        {
            return FindValue<SegmentTemplateFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SegmentTemplateFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamOrder.
    /// </summary>
    public class StreamOrder : ConstantClass
    {

        /// <summary>
        /// Constant ORIGINAL for StreamOrder
        /// </summary>
        public static readonly StreamOrder ORIGINAL = new StreamOrder("ORIGINAL");
        /// <summary>
        /// Constant VIDEO_BITRATE_ASCENDING for StreamOrder
        /// </summary>
        public static readonly StreamOrder VIDEO_BITRATE_ASCENDING = new StreamOrder("VIDEO_BITRATE_ASCENDING");
        /// <summary>
        /// Constant VIDEO_BITRATE_DESCENDING for StreamOrder
        /// </summary>
        public static readonly StreamOrder VIDEO_BITRATE_DESCENDING = new StreamOrder("VIDEO_BITRATE_DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamOrder FindValue(string value)
        {
            return FindValue<StreamOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamOrder(string value)
        {
            return FindValue(value);
        }
    }

}