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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MediaPackage
{

    /// <summary>
    /// Constants used for properties of type __AdTriggersElement.
    /// </summary>
    public class __AdTriggersElement : ConstantClass
    {

        /// <summary>
        /// Constant BREAK for __AdTriggersElement
        /// </summary>
        public static readonly __AdTriggersElement BREAK = new __AdTriggersElement("BREAK");
        /// <summary>
        /// Constant DISTRIBUTOR_ADVERTISEMENT for __AdTriggersElement
        /// </summary>
        public static readonly __AdTriggersElement DISTRIBUTOR_ADVERTISEMENT = new __AdTriggersElement("DISTRIBUTOR_ADVERTISEMENT");
        /// <summary>
        /// Constant DISTRIBUTOR_OVERLAY_PLACEMENT_OPPORTUNITY for __AdTriggersElement
        /// </summary>
        public static readonly __AdTriggersElement DISTRIBUTOR_OVERLAY_PLACEMENT_OPPORTUNITY = new __AdTriggersElement("DISTRIBUTOR_OVERLAY_PLACEMENT_OPPORTUNITY");
        /// <summary>
        /// Constant DISTRIBUTOR_PLACEMENT_OPPORTUNITY for __AdTriggersElement
        /// </summary>
        public static readonly __AdTriggersElement DISTRIBUTOR_PLACEMENT_OPPORTUNITY = new __AdTriggersElement("DISTRIBUTOR_PLACEMENT_OPPORTUNITY");
        /// <summary>
        /// Constant PROVIDER_ADVERTISEMENT for __AdTriggersElement
        /// </summary>
        public static readonly __AdTriggersElement PROVIDER_ADVERTISEMENT = new __AdTriggersElement("PROVIDER_ADVERTISEMENT");
        /// <summary>
        /// Constant PROVIDER_OVERLAY_PLACEMENT_OPPORTUNITY for __AdTriggersElement
        /// </summary>
        public static readonly __AdTriggersElement PROVIDER_OVERLAY_PLACEMENT_OPPORTUNITY = new __AdTriggersElement("PROVIDER_OVERLAY_PLACEMENT_OPPORTUNITY");
        /// <summary>
        /// Constant PROVIDER_PLACEMENT_OPPORTUNITY for __AdTriggersElement
        /// </summary>
        public static readonly __AdTriggersElement PROVIDER_PLACEMENT_OPPORTUNITY = new __AdTriggersElement("PROVIDER_PLACEMENT_OPPORTUNITY");
        /// <summary>
        /// Constant SPLICE_INSERT for __AdTriggersElement
        /// </summary>
        public static readonly __AdTriggersElement SPLICE_INSERT = new __AdTriggersElement("SPLICE_INSERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public __AdTriggersElement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static __AdTriggersElement FindValue(string value)
        {
            return FindValue<__AdTriggersElement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator __AdTriggersElement(string value)
        {
            return FindValue(value);
        }
    }


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
        /// Constant DATERANGE for AdMarkers
        /// </summary>
        public static readonly AdMarkers DATERANGE = new AdMarkers("DATERANGE");
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
    /// Constants used for properties of type AdsOnDeliveryRestrictions.
    /// </summary>
    public class AdsOnDeliveryRestrictions : ConstantClass
    {

        /// <summary>
        /// Constant BOTH for AdsOnDeliveryRestrictions
        /// </summary>
        public static readonly AdsOnDeliveryRestrictions BOTH = new AdsOnDeliveryRestrictions("BOTH");
        /// <summary>
        /// Constant NONE for AdsOnDeliveryRestrictions
        /// </summary>
        public static readonly AdsOnDeliveryRestrictions NONE = new AdsOnDeliveryRestrictions("NONE");
        /// <summary>
        /// Constant RESTRICTED for AdsOnDeliveryRestrictions
        /// </summary>
        public static readonly AdsOnDeliveryRestrictions RESTRICTED = new AdsOnDeliveryRestrictions("RESTRICTED");
        /// <summary>
        /// Constant UNRESTRICTED for AdsOnDeliveryRestrictions
        /// </summary>
        public static readonly AdsOnDeliveryRestrictions UNRESTRICTED = new AdsOnDeliveryRestrictions("UNRESTRICTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdsOnDeliveryRestrictions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdsOnDeliveryRestrictions FindValue(string value)
        {
            return FindValue<AdsOnDeliveryRestrictions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdsOnDeliveryRestrictions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CmafEncryptionMethod.
    /// </summary>
    public class CmafEncryptionMethod : ConstantClass
    {

        /// <summary>
        /// Constant AES_CTR for CmafEncryptionMethod
        /// </summary>
        public static readonly CmafEncryptionMethod AES_CTR = new CmafEncryptionMethod("AES_CTR");
        /// <summary>
        /// Constant SAMPLE_AES for CmafEncryptionMethod
        /// </summary>
        public static readonly CmafEncryptionMethod SAMPLE_AES = new CmafEncryptionMethod("SAMPLE_AES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CmafEncryptionMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CmafEncryptionMethod FindValue(string value)
        {
            return FindValue<CmafEncryptionMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CmafEncryptionMethod(string value)
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
        /// Constant DRM_TOP_LEVEL_COMPACT for ManifestLayout
        /// </summary>
        public static readonly ManifestLayout DRM_TOP_LEVEL_COMPACT = new ManifestLayout("DRM_TOP_LEVEL_COMPACT");
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
    /// Constants used for properties of type Origination.
    /// </summary>
    public class Origination : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for Origination
        /// </summary>
        public static readonly Origination ALLOW = new Origination("ALLOW");
        /// <summary>
        /// Constant DENY for Origination
        /// </summary>
        public static readonly Origination DENY = new Origination("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Origination(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Origination FindValue(string value)
        {
            return FindValue<Origination>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Origination(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlaylistType.
    /// </summary>
    public class PlaylistType : ConstantClass
    {

        /// <summary>
        /// Constant EVENT for PlaylistType
        /// </summary>
        public static readonly PlaylistType EVENT = new PlaylistType("EVENT");
        /// <summary>
        /// Constant NONE for PlaylistType
        /// </summary>
        public static readonly PlaylistType NONE = new PlaylistType("NONE");
        /// <summary>
        /// Constant VOD for PlaylistType
        /// </summary>
        public static readonly PlaylistType VOD = new PlaylistType("VOD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlaylistType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlaylistType FindValue(string value)
        {
            return FindValue<PlaylistType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlaylistType(string value)
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
        /// Constant DVB_DASH_2014 for Profile
        /// </summary>
        public static readonly Profile DVB_DASH_2014 = new Profile("DVB_DASH_2014");
        /// <summary>
        /// Constant HBBTV_1_5 for Profile
        /// </summary>
        public static readonly Profile HBBTV_1_5 = new Profile("HBBTV_1_5");
        /// <summary>
        /// Constant HYBRIDCAST for Profile
        /// </summary>
        public static readonly Profile HYBRIDCAST = new Profile("HYBRIDCAST");
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
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for Status
        /// </summary>
        public static readonly Status FAILED = new Status("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for Status
        /// </summary>
        public static readonly Status IN_PROGRESS = new Status("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for Status
        /// </summary>
        public static readonly Status SUCCEEDED = new Status("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
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


    /// <summary>
    /// Constants used for properties of type UtcTiming.
    /// </summary>
    public class UtcTiming : ConstantClass
    {

        /// <summary>
        /// Constant HTTPHEAD for UtcTiming
        /// </summary>
        public static readonly UtcTiming HTTPHEAD = new UtcTiming("HTTP-HEAD");
        /// <summary>
        /// Constant HTTPISO for UtcTiming
        /// </summary>
        public static readonly UtcTiming HTTPISO = new UtcTiming("HTTP-ISO");
        /// <summary>
        /// Constant HTTPXSDATE for UtcTiming
        /// </summary>
        public static readonly UtcTiming HTTPXSDATE = new UtcTiming("HTTP-XSDATE");
        /// <summary>
        /// Constant NONE for UtcTiming
        /// </summary>
        public static readonly UtcTiming NONE = new UtcTiming("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UtcTiming(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UtcTiming FindValue(string value)
        {
            return FindValue<UtcTiming>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UtcTiming(string value)
        {
            return FindValue(value);
        }
    }

}