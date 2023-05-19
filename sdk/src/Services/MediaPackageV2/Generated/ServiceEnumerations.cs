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
    /// Constants used for properties of type AdMarkerHls.
    /// </summary>
    public class AdMarkerHls : ConstantClass
    {

        /// <summary>
        /// Constant DATERANGE for AdMarkerHls
        /// </summary>
        public static readonly AdMarkerHls DATERANGE = new AdMarkerHls("DATERANGE");

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
        /// Constant CENC_IV_INCOMPATIBLE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType CENC_IV_INCOMPATIBLE = new ValidationExceptionType("CENC_IV_INCOMPATIBLE");
        /// <summary>
        /// Constant CONTAINER_TYPE_IMMUTABLE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType CONTAINER_TYPE_IMMUTABLE = new ValidationExceptionType("CONTAINER_TYPE_IMMUTABLE");
        /// <summary>
        /// Constant DRM_SYSTEMS_ENCRYPTION_METHOD_INCOMPATIBLE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType DRM_SYSTEMS_ENCRYPTION_METHOD_INCOMPATIBLE = new ValidationExceptionType("DRM_SYSTEMS_ENCRYPTION_METHOD_INCOMPATIBLE");
        /// <summary>
        /// Constant ENCRYPTION_CONTRACT_SHARED for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ENCRYPTION_CONTRACT_SHARED = new ValidationExceptionType("ENCRYPTION_CONTRACT_SHARED");
        /// <summary>
        /// Constant ENCRYPTION_CONTRACT_UNENCRYPTED for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ENCRYPTION_CONTRACT_UNENCRYPTED = new ValidationExceptionType("ENCRYPTION_CONTRACT_UNENCRYPTED");
        /// <summary>
        /// Constant ENCRYPTION_CONTRACT_WITHOUT_AUDIO_RENDITION_INCOMPATIBLE for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ENCRYPTION_CONTRACT_WITHOUT_AUDIO_RENDITION_INCOMPATIBLE = new ValidationExceptionType("ENCRYPTION_CONTRACT_WITHOUT_AUDIO_RENDITION_INCOMPATIBLE");
        /// <summary>
        /// Constant ENCRYPTION_METHOD_CONTAINER_TYPE_MISMATCH for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ENCRYPTION_METHOD_CONTAINER_TYPE_MISMATCH = new ValidationExceptionType("ENCRYPTION_METHOD_CONTAINER_TYPE_MISMATCH");
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
        /// Constant NUM_MANIFESTS_HIGH for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType NUM_MANIFESTS_HIGH = new ValidationExceptionType("NUM_MANIFESTS_HIGH");
        /// <summary>
        /// Constant NUM_MANIFESTS_LOW for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType NUM_MANIFESTS_LOW = new ValidationExceptionType("NUM_MANIFESTS_LOW");
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