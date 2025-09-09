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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MediaPackageV2
{

    /// <summary>
    /// Constants used for properties of type AdMarkerDash.
    /// </summary>
    public class AdMarkerDash : ConstantClass
    {

        /// <summary>
        /// Constant BINARY for AdMarkerDash
        /// </summary>
        public static readonly AdMarkerDash BINARY = new AdMarkerDash("BINARY");
        /// <summary>
        /// Constant XML for AdMarkerDash
        /// </summary>
        public static readonly AdMarkerDash XML = new AdMarkerDash("XML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdMarkerDash(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdMarkerDash FindValue(string value)
        {
            return FindValue<AdMarkerDash>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdMarkerDash(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdMarkerHls.
    /// </summary>
    public class AdMarkerHls : ConstantClass
    {

        /// <summary>
        /// Constant DATERANGE for AdMarkerHls
        /// </summary>
        public static readonly AdMarkerHls DATERANGE = new AdMarkerHls("DATERANGE");
        /// <summary>
        /// Constant SCTE35_ENHANCED for AdMarkerHls
        /// </summary>
        public static readonly AdMarkerHls SCTE35_ENHANCED = new AdMarkerHls("SCTE35_ENHANCED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdMarkerHls(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdMarkerHls FindValue(string value)
        {
            return FindValue<AdMarkerHls>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdMarkerHls(string value)
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
        /// Constant CBCS for CmafEncryptionMethod
        /// </summary>
        public static readonly CmafEncryptionMethod CBCS = new CmafEncryptionMethod("CBCS");
        /// <summary>
        /// Constant CENC for CmafEncryptionMethod
        /// </summary>
        public static readonly CmafEncryptionMethod CENC = new CmafEncryptionMethod("CENC");

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
    /// Constants used for properties of type ConflictExceptionType.
    /// </summary>
    public class ConflictExceptionType : ConstantClass
    {

        /// <summary>
        /// Constant CONFLICTING_OPERATION for ConflictExceptionType
        /// </summary>
        public static readonly ConflictExceptionType CONFLICTING_OPERATION = new ConflictExceptionType("CONFLICTING_OPERATION");
        /// <summary>
        /// Constant IDEMPOTENT_PARAMETER_MISMATCH for ConflictExceptionType
        /// </summary>
        public static readonly ConflictExceptionType IDEMPOTENT_PARAMETER_MISMATCH = new ConflictExceptionType("IDEMPOTENT_PARAMETER_MISMATCH");
        /// <summary>
        /// Constant RESOURCE_ALREADY_EXISTS for ConflictExceptionType
        /// </summary>
        public static readonly ConflictExceptionType RESOURCE_ALREADY_EXISTS = new ConflictExceptionType("RESOURCE_ALREADY_EXISTS");
        /// <summary>
        /// Constant RESOURCE_IN_USE for ConflictExceptionType
        /// </summary>
        public static readonly ConflictExceptionType RESOURCE_IN_USE = new ConflictExceptionType("RESOURCE_IN_USE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictExceptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictExceptionType FindValue(string value)
        {
            return FindValue<ConflictExceptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictExceptionType(string value)
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
        /// Constant CMAF for ContainerType
        /// </summary>
        public static readonly ContainerType CMAF = new ContainerType("CMAF");
        /// <summary>
        /// Constant ISM for ContainerType
        /// </summary>
        public static readonly ContainerType ISM = new ContainerType("ISM");
        /// <summary>
        /// Constant TS for ContainerType
        /// </summary>
        public static readonly ContainerType TS = new ContainerType("TS");

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
    /// Constants used for properties of type DashCompactness.
    /// </summary>
    public class DashCompactness : ConstantClass
    {

        /// <summary>
        /// Constant NONE for DashCompactness
        /// </summary>
        public static readonly DashCompactness NONE = new DashCompactness("NONE");
        /// <summary>
        /// Constant STANDARD for DashCompactness
        /// </summary>
        public static readonly DashCompactness STANDARD = new DashCompactness("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashCompactness(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashCompactness FindValue(string value)
        {
            return FindValue<DashCompactness>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashCompactness(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashDrmSignaling.
    /// </summary>
    public class DashDrmSignaling : ConstantClass
    {

        /// <summary>
        /// Constant INDIVIDUAL for DashDrmSignaling
        /// </summary>
        public static readonly DashDrmSignaling INDIVIDUAL = new DashDrmSignaling("INDIVIDUAL");
        /// <summary>
        /// Constant REFERENCED for DashDrmSignaling
        /// </summary>
        public static readonly DashDrmSignaling REFERENCED = new DashDrmSignaling("REFERENCED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashDrmSignaling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashDrmSignaling FindValue(string value)
        {
            return FindValue<DashDrmSignaling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashDrmSignaling(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashPeriodTrigger.
    /// </summary>
    public class DashPeriodTrigger : ConstantClass
    {

        /// <summary>
        /// Constant AVAILS for DashPeriodTrigger
        /// </summary>
        public static readonly DashPeriodTrigger AVAILS = new DashPeriodTrigger("AVAILS");
        /// <summary>
        /// Constant DRM_KEY_ROTATION for DashPeriodTrigger
        /// </summary>
        public static readonly DashPeriodTrigger DRM_KEY_ROTATION = new DashPeriodTrigger("DRM_KEY_ROTATION");
        /// <summary>
        /// Constant NONE for DashPeriodTrigger
        /// </summary>
        public static readonly DashPeriodTrigger NONE = new DashPeriodTrigger("NONE");
        /// <summary>
        /// Constant SOURCE_CHANGES for DashPeriodTrigger
        /// </summary>
        public static readonly DashPeriodTrigger SOURCE_CHANGES = new DashPeriodTrigger("SOURCE_CHANGES");
        /// <summary>
        /// Constant SOURCE_DISRUPTIONS for DashPeriodTrigger
        /// </summary>
        public static readonly DashPeriodTrigger SOURCE_DISRUPTIONS = new DashPeriodTrigger("SOURCE_DISRUPTIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashPeriodTrigger(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashPeriodTrigger FindValue(string value)
        {
            return FindValue<DashPeriodTrigger>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashPeriodTrigger(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashProfile.
    /// </summary>
    public class DashProfile : ConstantClass
    {

        /// <summary>
        /// Constant DVB_DASH for DashProfile
        /// </summary>
        public static readonly DashProfile DVB_DASH = new DashProfile("DVB_DASH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashProfile FindValue(string value)
        {
            return FindValue<DashProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashSegmentTemplateFormat.
    /// </summary>
    public class DashSegmentTemplateFormat : ConstantClass
    {

        /// <summary>
        /// Constant NUMBER_WITH_TIMELINE for DashSegmentTemplateFormat
        /// </summary>
        public static readonly DashSegmentTemplateFormat NUMBER_WITH_TIMELINE = new DashSegmentTemplateFormat("NUMBER_WITH_TIMELINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashSegmentTemplateFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashSegmentTemplateFormat FindValue(string value)
        {
            return FindValue<DashSegmentTemplateFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashSegmentTemplateFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashTtmlProfile.
    /// </summary>
    public class DashTtmlProfile : ConstantClass
    {

        /// <summary>
        /// Constant EBU_TT_D_101 for DashTtmlProfile
        /// </summary>
        public static readonly DashTtmlProfile EBU_TT_D_101 = new DashTtmlProfile("EBU_TT_D_101");
        /// <summary>
        /// Constant IMSC_1 for DashTtmlProfile
        /// </summary>
        public static readonly DashTtmlProfile IMSC_1 = new DashTtmlProfile("IMSC_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashTtmlProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashTtmlProfile FindValue(string value)
        {
            return FindValue<DashTtmlProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashTtmlProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashUtcTimingMode.
    /// </summary>
    public class DashUtcTimingMode : ConstantClass
    {

        /// <summary>
        /// Constant HTTP_HEAD for DashUtcTimingMode
        /// </summary>
        public static readonly DashUtcTimingMode HTTP_HEAD = new DashUtcTimingMode("HTTP_HEAD");
        /// <summary>
        /// Constant HTTP_ISO for DashUtcTimingMode
        /// </summary>
        public static readonly DashUtcTimingMode HTTP_ISO = new DashUtcTimingMode("HTTP_ISO");
        /// <summary>
        /// Constant HTTP_XSDATE for DashUtcTimingMode
        /// </summary>
        public static readonly DashUtcTimingMode HTTP_XSDATE = new DashUtcTimingMode("HTTP_XSDATE");
        /// <summary>
        /// Constant UTC_DIRECT for DashUtcTimingMode
        /// </summary>
        public static readonly DashUtcTimingMode UTC_DIRECT = new DashUtcTimingMode("UTC_DIRECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashUtcTimingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashUtcTimingMode FindValue(string value)
        {
            return FindValue<DashUtcTimingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashUtcTimingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DrmSystem.
    /// </summary>
    public class DrmSystem : ConstantClass
    {

        /// <summary>
        /// Constant CLEAR_KEY_AES_128 for DrmSystem
        /// </summary>
        public static readonly DrmSystem CLEAR_KEY_AES_128 = new DrmSystem("CLEAR_KEY_AES_128");
        /// <summary>
        /// Constant FAIRPLAY for DrmSystem
        /// </summary>
        public static readonly DrmSystem FAIRPLAY = new DrmSystem("FAIRPLAY");
        /// <summary>
        /// Constant IRDETO for DrmSystem
        /// </summary>
        public static readonly DrmSystem IRDETO = new DrmSystem("IRDETO");
        /// <summary>
        /// Constant PLAYREADY for DrmSystem
        /// </summary>
        public static readonly DrmSystem PLAYREADY = new DrmSystem("PLAYREADY");
        /// <summary>
        /// Constant WIDEVINE for DrmSystem
        /// </summary>
        public static readonly DrmSystem WIDEVINE = new DrmSystem("WIDEVINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DrmSystem(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DrmSystem FindValue(string value)
        {
            return FindValue<DrmSystem>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DrmSystem(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointErrorCondition.
    /// </summary>
    public class EndpointErrorCondition : ConstantClass
    {

        /// <summary>
        /// Constant INCOMPLETE_MANIFEST for EndpointErrorCondition
        /// </summary>
        public static readonly EndpointErrorCondition INCOMPLETE_MANIFEST = new EndpointErrorCondition("INCOMPLETE_MANIFEST");
        /// <summary>
        /// Constant MISSING_DRM_KEY for EndpointErrorCondition
        /// </summary>
        public static readonly EndpointErrorCondition MISSING_DRM_KEY = new EndpointErrorCondition("MISSING_DRM_KEY");
        /// <summary>
        /// Constant SLATE_INPUT for EndpointErrorCondition
        /// </summary>
        public static readonly EndpointErrorCondition SLATE_INPUT = new EndpointErrorCondition("SLATE_INPUT");
        /// <summary>
        /// Constant STALE_MANIFEST for EndpointErrorCondition
        /// </summary>
        public static readonly EndpointErrorCondition STALE_MANIFEST = new EndpointErrorCondition("STALE_MANIFEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointErrorCondition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointErrorCondition FindValue(string value)
        {
            return FindValue<EndpointErrorCondition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointErrorCondition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HarvestJobStatus.
    /// </summary>
    public class HarvestJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for HarvestJobStatus
        /// </summary>
        public static readonly HarvestJobStatus CANCELLED = new HarvestJobStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for HarvestJobStatus
        /// </summary>
        public static readonly HarvestJobStatus COMPLETED = new HarvestJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for HarvestJobStatus
        /// </summary>
        public static readonly HarvestJobStatus FAILED = new HarvestJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for HarvestJobStatus
        /// </summary>
        public static readonly HarvestJobStatus IN_PROGRESS = new HarvestJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant QUEUED for HarvestJobStatus
        /// </summary>
        public static readonly HarvestJobStatus QUEUED = new HarvestJobStatus("QUEUED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HarvestJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarvestJobStatus FindValue(string value)
        {
            return FindValue<HarvestJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarvestJobStatus(string value)
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
        /// Constant CMAF for InputType
        /// </summary>
        public static readonly InputType CMAF = new InputType("CMAF");
        /// <summary>
        /// Constant HLS for InputType
        /// </summary>
        public static readonly InputType HLS = new InputType("HLS");

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
    /// Constants used for properties of type IsmEncryptionMethod.
    /// </summary>
    public class IsmEncryptionMethod : ConstantClass
    {

        /// <summary>
        /// Constant CENC for IsmEncryptionMethod
        /// </summary>
        public static readonly IsmEncryptionMethod CENC = new IsmEncryptionMethod("CENC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IsmEncryptionMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IsmEncryptionMethod FindValue(string value)
        {
            return FindValue<IsmEncryptionMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IsmEncryptionMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MssManifestLayout.
    /// </summary>
    public class MssManifestLayout : ConstantClass
    {

        /// <summary>
        /// Constant COMPACT for MssManifestLayout
        /// </summary>
        public static readonly MssManifestLayout COMPACT = new MssManifestLayout("COMPACT");
        /// <summary>
        /// Constant FULL for MssManifestLayout
        /// </summary>
        public static readonly MssManifestLayout FULL = new MssManifestLayout("FULL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MssManifestLayout(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MssManifestLayout FindValue(string value)
        {
            return FindValue<MssManifestLayout>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MssManifestLayout(string value)
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
        /// Constant PRESET_AUDIO_1 for PresetSpeke20Audio
        /// </summary>
        public static readonly PresetSpeke20Audio PRESET_AUDIO_1 = new PresetSpeke20Audio("PRESET_AUDIO_1");
        /// <summary>
        /// Constant PRESET_AUDIO_2 for PresetSpeke20Audio
        /// </summary>
        public static readonly PresetSpeke20Audio PRESET_AUDIO_2 = new PresetSpeke20Audio("PRESET_AUDIO_2");
        /// <summary>
        /// Constant PRESET_AUDIO_3 for PresetSpeke20Audio
        /// </summary>
        public static readonly PresetSpeke20Audio PRESET_AUDIO_3 = new PresetSpeke20Audio("PRESET_AUDIO_3");
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
        /// Constant PRESET_VIDEO_1 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESET_VIDEO_1 = new PresetSpeke20Video("PRESET_VIDEO_1");
        /// <summary>
        /// Constant PRESET_VIDEO_2 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESET_VIDEO_2 = new PresetSpeke20Video("PRESET_VIDEO_2");
        /// <summary>
        /// Constant PRESET_VIDEO_3 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESET_VIDEO_3 = new PresetSpeke20Video("PRESET_VIDEO_3");
        /// <summary>
        /// Constant PRESET_VIDEO_4 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESET_VIDEO_4 = new PresetSpeke20Video("PRESET_VIDEO_4");
        /// <summary>
        /// Constant PRESET_VIDEO_5 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESET_VIDEO_5 = new PresetSpeke20Video("PRESET_VIDEO_5");
        /// <summary>
        /// Constant PRESET_VIDEO_6 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESET_VIDEO_6 = new PresetSpeke20Video("PRESET_VIDEO_6");
        /// <summary>
        /// Constant PRESET_VIDEO_7 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESET_VIDEO_7 = new PresetSpeke20Video("PRESET_VIDEO_7");
        /// <summary>
        /// Constant PRESET_VIDEO_8 for PresetSpeke20Video
        /// </summary>
        public static readonly PresetSpeke20Video PRESET_VIDEO_8 = new PresetSpeke20Video("PRESET_VIDEO_8");
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
    /// Constants used for properties of type ResourceTypeNotFound.
    /// </summary>
    public class ResourceTypeNotFound : ConstantClass
    {

        /// <summary>
        /// Constant CHANNEL for ResourceTypeNotFound
        /// </summary>
        public static readonly ResourceTypeNotFound CHANNEL = new ResourceTypeNotFound("CHANNEL");
        /// <summary>
        /// Constant CHANNEL_GROUP for ResourceTypeNotFound
        /// </summary>
        public static readonly ResourceTypeNotFound CHANNEL_GROUP = new ResourceTypeNotFound("CHANNEL_GROUP");
        /// <summary>
        /// Constant HARVEST_JOB for ResourceTypeNotFound
        /// </summary>
        public static readonly ResourceTypeNotFound HARVEST_JOB = new ResourceTypeNotFound("HARVEST_JOB");
        /// <summary>
        /// Constant ORIGIN_ENDPOINT for ResourceTypeNotFound
        /// </summary>
        public static readonly ResourceTypeNotFound ORIGIN_ENDPOINT = new ResourceTypeNotFound("ORIGIN_ENDPOINT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceTypeNotFound(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceTypeNotFound FindValue(string value)
        {
            return FindValue<ResourceTypeNotFound>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceTypeNotFound(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScteFilter.
    /// </summary>
    public class ScteFilter : ConstantClass
    {

        /// <summary>
        /// Constant BREAK for ScteFilter
        /// </summary>
        public static readonly ScteFilter BREAK = new ScteFilter("BREAK");
        /// <summary>
        /// Constant DISTRIBUTOR_ADVERTISEMENT for ScteFilter
        /// </summary>
        public static readonly ScteFilter DISTRIBUTOR_ADVERTISEMENT = new ScteFilter("DISTRIBUTOR_ADVERTISEMENT");
        /// <summary>
        /// Constant DISTRIBUTOR_OVERLAY_PLACEMENT_OPPORTUNITY for ScteFilter
        /// </summary>
        public static readonly ScteFilter DISTRIBUTOR_OVERLAY_PLACEMENT_OPPORTUNITY = new ScteFilter("DISTRIBUTOR_OVERLAY_PLACEMENT_OPPORTUNITY");
        /// <summary>
        /// Constant DISTRIBUTOR_PLACEMENT_OPPORTUNITY for ScteFilter
        /// </summary>
        public static readonly ScteFilter DISTRIBUTOR_PLACEMENT_OPPORTUNITY = new ScteFilter("DISTRIBUTOR_PLACEMENT_OPPORTUNITY");
        /// <summary>
        /// Constant PROGRAM for ScteFilter
        /// </summary>
        public static readonly ScteFilter PROGRAM = new ScteFilter("PROGRAM");
        /// <summary>
        /// Constant PROVIDER_ADVERTISEMENT for ScteFilter
        /// </summary>
        public static readonly ScteFilter PROVIDER_ADVERTISEMENT = new ScteFilter("PROVIDER_ADVERTISEMENT");
        /// <summary>
        /// Constant PROVIDER_OVERLAY_PLACEMENT_OPPORTUNITY for ScteFilter
        /// </summary>
        public static readonly ScteFilter PROVIDER_OVERLAY_PLACEMENT_OPPORTUNITY = new ScteFilter("PROVIDER_OVERLAY_PLACEMENT_OPPORTUNITY");
        /// <summary>
        /// Constant PROVIDER_PLACEMENT_OPPORTUNITY for ScteFilter
        /// </summary>
        public static readonly ScteFilter PROVIDER_PLACEMENT_OPPORTUNITY = new ScteFilter("PROVIDER_PLACEMENT_OPPORTUNITY");
        /// <summary>
        /// Constant SPLICE_INSERT for ScteFilter
        /// </summary>
        public static readonly ScteFilter SPLICE_INSERT = new ScteFilter("SPLICE_INSERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScteFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScteFilter FindValue(string value)
        {
            return FindValue<ScteFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScteFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TsEncryptionMethod.
    /// </summary>
    public class TsEncryptionMethod : ConstantClass
    {

        /// <summary>
        /// Constant AES_128 for TsEncryptionMethod
        /// </summary>
        public static readonly TsEncryptionMethod AES_128 = new TsEncryptionMethod("AES_128");
        /// <summary>
        /// Constant SAMPLE_AES for TsEncryptionMethod
        /// </summary>
        public static readonly TsEncryptionMethod SAMPLE_AES = new TsEncryptionMethod("SAMPLE_AES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TsEncryptionMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TsEncryptionMethod FindValue(string value)
        {
            return FindValue<TsEncryptionMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TsEncryptionMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionType.
    /// </summary>
    public class ValidationExceptionType : ConstantClass
    {

        /// <summary>
        /// Constant BATCH_GET_SECRET_VALUE_DENIED for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType BATCH_GET_SECRET_VALUE_DENIED = new ValidationExceptionType("BATCH_GET_SECRET_VALUE_DENIED");
        /// <summary>
        /// Constant CENC_IV_INCOMPATIBLE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType CENC_IV_INCOMPATIBLE = new ValidationExceptionType("CENC_IV_INCOMPATIBLE");
        /// <summary>
        /// Constant CLIP_START_TIME_WITH_START_OR_END for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType CLIP_START_TIME_WITH_START_OR_END = new ValidationExceptionType("CLIP_START_TIME_WITH_START_OR_END");
        /// <summary>
        /// Constant CMAF_CONTAINER_TYPE_WITH_MSS_MANIFEST for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType CMAF_CONTAINER_TYPE_WITH_MSS_MANIFEST = new ValidationExceptionType("CMAF_CONTAINER_TYPE_WITH_MSS_MANIFEST");
        /// <summary>
        /// Constant CMAF_EXCLUDE_SEGMENT_DRM_METADATA_INCOMPATIBLE_CONTAINER_TYPE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType CMAF_EXCLUDE_SEGMENT_DRM_METADATA_INCOMPATIBLE_CONTAINER_TYPE = new ValidationExceptionType("CMAF_EXCLUDE_SEGMENT_DRM_METADATA_INCOMPATIBLE_CONTAINER_TYPE");
        /// <summary>
        /// Constant CONTAINER_TYPE_IMMUTABLE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType CONTAINER_TYPE_IMMUTABLE = new ValidationExceptionType("CONTAINER_TYPE_IMMUTABLE");
        /// <summary>
        /// Constant DASH_DVB_ATTRIBUTES_WITHOUT_DVB_DASH_PROFILE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType DASH_DVB_ATTRIBUTES_WITHOUT_DVB_DASH_PROFILE = new ValidationExceptionType("DASH_DVB_ATTRIBUTES_WITHOUT_DVB_DASH_PROFILE");
        /// <summary>
        /// Constant DECRYPT_SECRET_FAILED for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType DECRYPT_SECRET_FAILED = new ValidationExceptionType("DECRYPT_SECRET_FAILED");
        /// <summary>
        /// Constant DESCRIBE_SECRET_DENIED for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType DESCRIBE_SECRET_DENIED = new ValidationExceptionType("DESCRIBE_SECRET_DENIED");
        /// <summary>
        /// Constant DIRECT_MODE_WITH_TIMING_SOURCE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType DIRECT_MODE_WITH_TIMING_SOURCE = new ValidationExceptionType("DIRECT_MODE_WITH_TIMING_SOURCE");
        /// <summary>
        /// Constant DRM_SIGNALING_MISMATCH_SEGMENT_ENCRYPTION_STATUS for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType DRM_SIGNALING_MISMATCH_SEGMENT_ENCRYPTION_STATUS = new ValidationExceptionType("DRM_SIGNALING_MISMATCH_SEGMENT_ENCRYPTION_STATUS");
        /// <summary>
        /// Constant DRM_SYSTEMS_ENCRYPTION_METHOD_INCOMPATIBLE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType DRM_SYSTEMS_ENCRYPTION_METHOD_INCOMPATIBLE = new ValidationExceptionType("DRM_SYSTEMS_ENCRYPTION_METHOD_INCOMPATIBLE");
        /// <summary>
        /// Constant DUPLICATED_SECRET for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType DUPLICATED_SECRET = new ValidationExceptionType("DUPLICATED_SECRET");
        /// <summary>
        /// Constant ENCRYPTION_CONTRACT_SHARED for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ENCRYPTION_CONTRACT_SHARED = new ValidationExceptionType("ENCRYPTION_CONTRACT_SHARED");
        /// <summary>
        /// Constant ENCRYPTION_CONTRACT_UNENCRYPTED for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ENCRYPTION_CONTRACT_UNENCRYPTED = new ValidationExceptionType("ENCRYPTION_CONTRACT_UNENCRYPTED");
        /// <summary>
        /// Constant ENCRYPTION_CONTRACT_WITH_ISM_CONTAINER_INCOMPATIBLE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ENCRYPTION_CONTRACT_WITH_ISM_CONTAINER_INCOMPATIBLE = new ValidationExceptionType("ENCRYPTION_CONTRACT_WITH_ISM_CONTAINER_INCOMPATIBLE");
        /// <summary>
        /// Constant ENCRYPTION_CONTRACT_WITHOUT_AUDIO_RENDITION_INCOMPATIBLE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ENCRYPTION_CONTRACT_WITHOUT_AUDIO_RENDITION_INCOMPATIBLE = new ValidationExceptionType("ENCRYPTION_CONTRACT_WITHOUT_AUDIO_RENDITION_INCOMPATIBLE");
        /// <summary>
        /// Constant ENCRYPTION_METHOD_CONTAINER_TYPE_MISMATCH for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ENCRYPTION_METHOD_CONTAINER_TYPE_MISMATCH = new ValidationExceptionType("ENCRYPTION_METHOD_CONTAINER_TYPE_MISMATCH");
        /// <summary>
        /// Constant END_TIME_EARLIER_THAN_START_TIME for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType END_TIME_EARLIER_THAN_START_TIME = new ValidationExceptionType("END_TIME_EARLIER_THAN_START_TIME");
        /// <summary>
        /// Constant GET_SECRET_VALUE_DENIED for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType GET_SECRET_VALUE_DENIED = new ValidationExceptionType("GET_SECRET_VALUE_DENIED");
        /// <summary>
        /// Constant HARVEST_JOB_CUSTOMER_ENDPOINT_READ_ACCESS_DENIED for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType HARVEST_JOB_CUSTOMER_ENDPOINT_READ_ACCESS_DENIED = new ValidationExceptionType("HARVEST_JOB_CUSTOMER_ENDPOINT_READ_ACCESS_DENIED");
        /// <summary>
        /// Constant HARVEST_JOB_INELIGIBLE_FOR_CANCELLATION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType HARVEST_JOB_INELIGIBLE_FOR_CANCELLATION = new ValidationExceptionType("HARVEST_JOB_INELIGIBLE_FOR_CANCELLATION");
        /// <summary>
        /// Constant HARVEST_JOB_S3_DESTINATION_MISSING_OR_INCOMPLETE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType HARVEST_JOB_S3_DESTINATION_MISSING_OR_INCOMPLETE = new ValidationExceptionType("HARVEST_JOB_S3_DESTINATION_MISSING_OR_INCOMPLETE");
        /// <summary>
        /// Constant HARVEST_JOB_UNABLE_TO_WRITE_TO_S3_DESTINATION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType HARVEST_JOB_UNABLE_TO_WRITE_TO_S3_DESTINATION = new ValidationExceptionType("HARVEST_JOB_UNABLE_TO_WRITE_TO_S3_DESTINATION");
        /// <summary>
        /// Constant HARVESTED_MANIFEST_HAS_START_END_FILTER_CONFIGURATION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType HARVESTED_MANIFEST_HAS_START_END_FILTER_CONFIGURATION = new ValidationExceptionType("HARVESTED_MANIFEST_HAS_START_END_FILTER_CONFIGURATION");
        /// <summary>
        /// Constant HARVESTED_MANIFEST_NOT_FOUND_ON_ENDPOINT for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType HARVESTED_MANIFEST_NOT_FOUND_ON_ENDPOINT = new ValidationExceptionType("HARVESTED_MANIFEST_NOT_FOUND_ON_ENDPOINT");
        /// <summary>
        /// Constant INCOMPATIBLE_DASH_COMPACTNESS_CONFIGURATION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INCOMPATIBLE_DASH_COMPACTNESS_CONFIGURATION = new ValidationExceptionType("INCOMPATIBLE_DASH_COMPACTNESS_CONFIGURATION");
        /// <summary>
        /// Constant INCOMPATIBLE_DASH_PROFILE_DVB_DASH_CONFIGURATION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INCOMPATIBLE_DASH_PROFILE_DVB_DASH_CONFIGURATION = new ValidationExceptionType("INCOMPATIBLE_DASH_PROFILE_DVB_DASH_CONFIGURATION");
        /// <summary>
        /// Constant INCOMPATIBLE_XML_ENCODING for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INCOMPATIBLE_XML_ENCODING = new ValidationExceptionType("INCOMPATIBLE_XML_ENCODING");
        /// <summary>
        /// Constant INVALID_HARVEST_JOB_DURATION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INVALID_HARVEST_JOB_DURATION = new ValidationExceptionType("INVALID_HARVEST_JOB_DURATION");
        /// <summary>
        /// Constant INVALID_MANIFEST_FILTER for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INVALID_MANIFEST_FILTER = new ValidationExceptionType("INVALID_MANIFEST_FILTER");
        /// <summary>
        /// Constant INVALID_PAGINATION_MAX_RESULTS for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INVALID_PAGINATION_MAX_RESULTS = new ValidationExceptionType("INVALID_PAGINATION_MAX_RESULTS");
        /// <summary>
        /// Constant INVALID_PAGINATION_TOKEN for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INVALID_PAGINATION_TOKEN = new ValidationExceptionType("INVALID_PAGINATION_TOKEN");
        /// <summary>
        /// Constant INVALID_POLICY for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INVALID_POLICY = new ValidationExceptionType("INVALID_POLICY");
        /// <summary>
        /// Constant INVALID_ROLE_ARN for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INVALID_ROLE_ARN = new ValidationExceptionType("INVALID_ROLE_ARN");
        /// <summary>
        /// Constant INVALID_SECRET for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INVALID_SECRET = new ValidationExceptionType("INVALID_SECRET");
        /// <summary>
        /// Constant INVALID_SECRET_FORMAT for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INVALID_SECRET_FORMAT = new ValidationExceptionType("INVALID_SECRET_FORMAT");
        /// <summary>
        /// Constant INVALID_SECRET_KEY for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INVALID_SECRET_KEY = new ValidationExceptionType("INVALID_SECRET_KEY");
        /// <summary>
        /// Constant INVALID_SECRET_VALUE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INVALID_SECRET_VALUE = new ValidationExceptionType("INVALID_SECRET_VALUE");
        /// <summary>
        /// Constant INVALID_TIME_DELAY_SECONDS for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType INVALID_TIME_DELAY_SECONDS = new ValidationExceptionType("INVALID_TIME_DELAY_SECONDS");
        /// <summary>
        /// Constant ISM_CONTAINER_TYPE_WITH_DASH_MANIFEST for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ISM_CONTAINER_TYPE_WITH_DASH_MANIFEST = new ValidationExceptionType("ISM_CONTAINER_TYPE_WITH_DASH_MANIFEST");
        /// <summary>
        /// Constant ISM_CONTAINER_TYPE_WITH_HLS_MANIFEST for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ISM_CONTAINER_TYPE_WITH_HLS_MANIFEST = new ValidationExceptionType("ISM_CONTAINER_TYPE_WITH_HLS_MANIFEST");
        /// <summary>
        /// Constant ISM_CONTAINER_TYPE_WITH_LL_HLS_MANIFEST for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ISM_CONTAINER_TYPE_WITH_LL_HLS_MANIFEST = new ValidationExceptionType("ISM_CONTAINER_TYPE_WITH_LL_HLS_MANIFEST");
        /// <summary>
        /// Constant ISM_CONTAINER_TYPE_WITH_SCTE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ISM_CONTAINER_TYPE_WITH_SCTE = new ValidationExceptionType("ISM_CONTAINER_TYPE_WITH_SCTE");
        /// <summary>
        /// Constant ISM_CONTAINER_WITH_KEY_ROTATION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ISM_CONTAINER_WITH_KEY_ROTATION = new ValidationExceptionType("ISM_CONTAINER_WITH_KEY_ROTATION");
        /// <summary>
        /// Constant MALFORMED_SECRET_ARN for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType MALFORMED_SECRET_ARN = new ValidationExceptionType("MALFORMED_SECRET_ARN");
        /// <summary>
        /// Constant MANIFEST_DRM_SYSTEMS_INCOMPATIBLE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType MANIFEST_DRM_SYSTEMS_INCOMPATIBLE = new ValidationExceptionType("MANIFEST_DRM_SYSTEMS_INCOMPATIBLE");
        /// <summary>
        /// Constant MANIFEST_NAME_COLLISION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType MANIFEST_NAME_COLLISION = new ValidationExceptionType("MANIFEST_NAME_COLLISION");
        /// <summary>
        /// Constant MEMBER_DOES_NOT_MATCH_PATTERN for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType MEMBER_DOES_NOT_MATCH_PATTERN = new ValidationExceptionType("MEMBER_DOES_NOT_MATCH_PATTERN");
        /// <summary>
        /// Constant MEMBER_INVALID for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType MEMBER_INVALID = new ValidationExceptionType("MEMBER_INVALID");
        /// <summary>
        /// Constant MEMBER_INVALID_ENUM_VALUE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType MEMBER_INVALID_ENUM_VALUE = new ValidationExceptionType("MEMBER_INVALID_ENUM_VALUE");
        /// <summary>
        /// Constant MEMBER_MAX_LENGTH for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType MEMBER_MAX_LENGTH = new ValidationExceptionType("MEMBER_MAX_LENGTH");
        /// <summary>
        /// Constant MEMBER_MAX_VALUE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType MEMBER_MAX_VALUE = new ValidationExceptionType("MEMBER_MAX_VALUE");
        /// <summary>
        /// Constant MEMBER_MIN_LENGTH for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType MEMBER_MIN_LENGTH = new ValidationExceptionType("MEMBER_MIN_LENGTH");
        /// <summary>
        /// Constant MEMBER_MIN_VALUE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType MEMBER_MIN_VALUE = new ValidationExceptionType("MEMBER_MIN_VALUE");
        /// <summary>
        /// Constant MEMBER_MISSING for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType MEMBER_MISSING = new ValidationExceptionType("MEMBER_MISSING");
        /// <summary>
        /// Constant NONE_MODE_WITH_TIMING_SOURCE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType NONE_MODE_WITH_TIMING_SOURCE = new ValidationExceptionType("NONE_MODE_WITH_TIMING_SOURCE");
        /// <summary>
        /// Constant NUM_MANIFESTS_HIGH for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType NUM_MANIFESTS_HIGH = new ValidationExceptionType("NUM_MANIFESTS_HIGH");
        /// <summary>
        /// Constant NUM_MANIFESTS_LOW for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType NUM_MANIFESTS_LOW = new ValidationExceptionType("NUM_MANIFESTS_LOW");
        /// <summary>
        /// Constant ONLY_CMAF_INPUT_TYPE_ALLOW_FORCE_ENDPOINT_ERROR_CONFIGURATION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ONLY_CMAF_INPUT_TYPE_ALLOW_FORCE_ENDPOINT_ERROR_CONFIGURATION = new ValidationExceptionType("ONLY_CMAF_INPUT_TYPE_ALLOW_FORCE_ENDPOINT_ERROR_CONFIGURATION");
        /// <summary>
        /// Constant ONLY_CMAF_INPUT_TYPE_ALLOW_MQCS_INPUT_SWITCHING for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ONLY_CMAF_INPUT_TYPE_ALLOW_MQCS_INPUT_SWITCHING = new ValidationExceptionType("ONLY_CMAF_INPUT_TYPE_ALLOW_MQCS_INPUT_SWITCHING");
        /// <summary>
        /// Constant ONLY_CMAF_INPUT_TYPE_ALLOW_MQCS_OUTPUT_CONFIGURATION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ONLY_CMAF_INPUT_TYPE_ALLOW_MQCS_OUTPUT_CONFIGURATION = new ValidationExceptionType("ONLY_CMAF_INPUT_TYPE_ALLOW_MQCS_OUTPUT_CONFIGURATION");
        /// <summary>
        /// Constant ONLY_CMAF_INPUT_TYPE_ALLOW_PREFERRED_INPUT_CONFIGURATION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ONLY_CMAF_INPUT_TYPE_ALLOW_PREFERRED_INPUT_CONFIGURATION = new ValidationExceptionType("ONLY_CMAF_INPUT_TYPE_ALLOW_PREFERRED_INPUT_CONFIGURATION");
        /// <summary>
        /// Constant PERIOD_TRIGGERS_NONE_SPECIFIED_WITH_ADDITIONAL_VALUES for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType PERIOD_TRIGGERS_NONE_SPECIFIED_WITH_ADDITIONAL_VALUES = new ValidationExceptionType("PERIOD_TRIGGERS_NONE_SPECIFIED_WITH_ADDITIONAL_VALUES");
        /// <summary>
        /// Constant ROLE_ARN_INVALID_FORMAT for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ROLE_ARN_INVALID_FORMAT = new ValidationExceptionType("ROLE_ARN_INVALID_FORMAT");
        /// <summary>
        /// Constant ROLE_ARN_LENGTH_OUT_OF_RANGE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ROLE_ARN_LENGTH_OUT_OF_RANGE = new ValidationExceptionType("ROLE_ARN_LENGTH_OUT_OF_RANGE");
        /// <summary>
        /// Constant ROLE_ARN_NOT_ASSUMABLE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ROLE_ARN_NOT_ASSUMABLE = new ValidationExceptionType("ROLE_ARN_NOT_ASSUMABLE");
        /// <summary>
        /// Constant SECRET_ARN_RESOURCE_NOT_FOUND for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType SECRET_ARN_RESOURCE_NOT_FOUND = new ValidationExceptionType("SECRET_ARN_RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant SECRET_FROM_DIFFERENT_ACCOUNT for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType SECRET_FROM_DIFFERENT_ACCOUNT = new ValidationExceptionType("SECRET_FROM_DIFFERENT_ACCOUNT");
        /// <summary>
        /// Constant SECRET_FROM_DIFFERENT_REGION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType SECRET_FROM_DIFFERENT_REGION = new ValidationExceptionType("SECRET_FROM_DIFFERENT_REGION");
        /// <summary>
        /// Constant SECRET_IS_NOT_ONE_KEY_VALUE_PAIR for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType SECRET_IS_NOT_ONE_KEY_VALUE_PAIR = new ValidationExceptionType("SECRET_IS_NOT_ONE_KEY_VALUE_PAIR");
        /// <summary>
        /// Constant SOURCE_DISRUPTIONS_ENABLED_INCORRECTLY for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType SOURCE_DISRUPTIONS_ENABLED_INCORRECTLY = new ValidationExceptionType("SOURCE_DISRUPTIONS_ENABLED_INCORRECTLY");
        /// <summary>
        /// Constant START_TAG_TIME_OFFSET_INVALID for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType START_TAG_TIME_OFFSET_INVALID = new ValidationExceptionType("START_TAG_TIME_OFFSET_INVALID");
        /// <summary>
        /// Constant TIMING_SOURCE_MISSING for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType TIMING_SOURCE_MISSING = new ValidationExceptionType("TIMING_SOURCE_MISSING");
        /// <summary>
        /// Constant TOO_MANY_IN_PROGRESS_HARVEST_JOBS for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType TOO_MANY_IN_PROGRESS_HARVEST_JOBS = new ValidationExceptionType("TOO_MANY_IN_PROGRESS_HARVEST_JOBS");
        /// <summary>
        /// Constant TOO_MANY_SECRETS for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType TOO_MANY_SECRETS = new ValidationExceptionType("TOO_MANY_SECRETS");
        /// <summary>
        /// Constant TS_CONTAINER_TYPE_WITH_DASH_MANIFEST for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType TS_CONTAINER_TYPE_WITH_DASH_MANIFEST = new ValidationExceptionType("TS_CONTAINER_TYPE_WITH_DASH_MANIFEST");
        /// <summary>
        /// Constant TS_CONTAINER_TYPE_WITH_MSS_MANIFEST for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType TS_CONTAINER_TYPE_WITH_MSS_MANIFEST = new ValidationExceptionType("TS_CONTAINER_TYPE_WITH_MSS_MANIFEST");
        /// <summary>
        /// Constant UPDATE_PERIOD_SMALLER_THAN_SEGMENT_DURATION for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType UPDATE_PERIOD_SMALLER_THAN_SEGMENT_DURATION = new ValidationExceptionType("UPDATE_PERIOD_SMALLER_THAN_SEGMENT_DURATION");
        /// <summary>
        /// Constant URL_INVALID for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType URL_INVALID = new ValidationExceptionType("URL_INVALID");
        /// <summary>
        /// Constant URL_LINK_LOCAL_ADDRESS for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType URL_LINK_LOCAL_ADDRESS = new ValidationExceptionType("URL_LINK_LOCAL_ADDRESS");
        /// <summary>
        /// Constant URL_LOCAL_ADDRESS for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType URL_LOCAL_ADDRESS = new ValidationExceptionType("URL_LOCAL_ADDRESS");
        /// <summary>
        /// Constant URL_LOOPBACK_ADDRESS for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType URL_LOOPBACK_ADDRESS = new ValidationExceptionType("URL_LOOPBACK_ADDRESS");
        /// <summary>
        /// Constant URL_MULTICAST_ADDRESS for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType URL_MULTICAST_ADDRESS = new ValidationExceptionType("URL_MULTICAST_ADDRESS");
        /// <summary>
        /// Constant URL_PORT for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType URL_PORT = new ValidationExceptionType("URL_PORT");
        /// <summary>
        /// Constant URL_SCHEME for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType URL_SCHEME = new ValidationExceptionType("URL_SCHEME");
        /// <summary>
        /// Constant URL_UNKNOWN_HOST for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType URL_UNKNOWN_HOST = new ValidationExceptionType("URL_UNKNOWN_HOST");
        /// <summary>
        /// Constant URL_USER_INFO for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType URL_USER_INFO = new ValidationExceptionType("URL_USER_INFO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionType FindValue(string value)
        {
            return FindValue<ValidationExceptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionType(string value)
        {
            return FindValue(value);
        }
    }

}