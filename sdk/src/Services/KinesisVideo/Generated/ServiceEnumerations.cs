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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.KinesisVideo
{

    /// <summary>
    /// Constants used for properties of type APIName.
    /// </summary>
    public class APIName : ConstantClass
    {

        /// <summary>
        /// Constant GET_CLIP for APIName
        /// </summary>
        public static readonly APIName GET_CLIP = new APIName("GET_CLIP");
        /// <summary>
        /// Constant GET_DASH_STREAMING_SESSION_URL for APIName
        /// </summary>
        public static readonly APIName GET_DASH_STREAMING_SESSION_URL = new APIName("GET_DASH_STREAMING_SESSION_URL");
        /// <summary>
        /// Constant GET_HLS_STREAMING_SESSION_URL for APIName
        /// </summary>
        public static readonly APIName GET_HLS_STREAMING_SESSION_URL = new APIName("GET_HLS_STREAMING_SESSION_URL");
        /// <summary>
        /// Constant GET_IMAGES for APIName
        /// </summary>
        public static readonly APIName GET_IMAGES = new APIName("GET_IMAGES");
        /// <summary>
        /// Constant GET_MEDIA for APIName
        /// </summary>
        public static readonly APIName GET_MEDIA = new APIName("GET_MEDIA");
        /// <summary>
        /// Constant GET_MEDIA_FOR_FRAGMENT_LIST for APIName
        /// </summary>
        public static readonly APIName GET_MEDIA_FOR_FRAGMENT_LIST = new APIName("GET_MEDIA_FOR_FRAGMENT_LIST");
        /// <summary>
        /// Constant LIST_FRAGMENTS for APIName
        /// </summary>
        public static readonly APIName LIST_FRAGMENTS = new APIName("LIST_FRAGMENTS");
        /// <summary>
        /// Constant PUT_MEDIA for APIName
        /// </summary>
        public static readonly APIName PUT_MEDIA = new APIName("PUT_MEDIA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public APIName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static APIName FindValue(string value)
        {
            return FindValue<APIName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator APIName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelProtocol.
    /// </summary>
    public class ChannelProtocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTPS for ChannelProtocol
        /// </summary>
        public static readonly ChannelProtocol HTTPS = new ChannelProtocol("HTTPS");
        /// <summary>
        /// Constant WEBRTC for ChannelProtocol
        /// </summary>
        public static readonly ChannelProtocol WEBRTC = new ChannelProtocol("WEBRTC");
        /// <summary>
        /// Constant WSS for ChannelProtocol
        /// </summary>
        public static readonly ChannelProtocol WSS = new ChannelProtocol("WSS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelProtocol FindValue(string value)
        {
            return FindValue<ChannelProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelRole.
    /// </summary>
    public class ChannelRole : ConstantClass
    {

        /// <summary>
        /// Constant MASTER for ChannelRole
        /// </summary>
        public static readonly ChannelRole MASTER = new ChannelRole("MASTER");
        /// <summary>
        /// Constant VIEWER for ChannelRole
        /// </summary>
        public static readonly ChannelRole VIEWER = new ChannelRole("VIEWER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelRole FindValue(string value)
        {
            return FindValue<ChannelRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelType.
    /// </summary>
    public class ChannelType : ConstantClass
    {

        /// <summary>
        /// Constant FULL_MESH for ChannelType
        /// </summary>
        public static readonly ChannelType FULL_MESH = new ChannelType("FULL_MESH");
        /// <summary>
        /// Constant SINGLE_MASTER for ChannelType
        /// </summary>
        public static readonly ChannelType SINGLE_MASTER = new ChannelType("SINGLE_MASTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelType FindValue(string value)
        {
            return FindValue<ChannelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant BEGINS_WITH for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator BEGINS_WITH = new ComparisonOperator("BEGINS_WITH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperator FindValue(string value)
        {
            return FindValue<ComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationStatus.
    /// </summary>
    public class ConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ConfigurationStatus
        /// </summary>
        public static readonly ConfigurationStatus DISABLED = new ConfigurationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for ConfigurationStatus
        /// </summary>
        public static readonly ConfigurationStatus ENABLED = new ConfigurationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationStatus FindValue(string value)
        {
            return FindValue<ConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationStatus(string value)
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


    /// <summary>
    /// Constants used for properties of type MediaStorageConfigurationStatus.
    /// </summary>
    public class MediaStorageConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for MediaStorageConfigurationStatus
        /// </summary>
        public static readonly MediaStorageConfigurationStatus DISABLED = new MediaStorageConfigurationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for MediaStorageConfigurationStatus
        /// </summary>
        public static readonly MediaStorageConfigurationStatus ENABLED = new MediaStorageConfigurationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaStorageConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaStorageConfigurationStatus FindValue(string value)
        {
            return FindValue<MediaStorageConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaStorageConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaUriType.
    /// </summary>
    public class MediaUriType : ConstantClass
    {

        /// <summary>
        /// Constant FILE_URI for MediaUriType
        /// </summary>
        public static readonly MediaUriType FILE_URI = new MediaUriType("FILE_URI");
        /// <summary>
        /// Constant RTSP_URI for MediaUriType
        /// </summary>
        public static readonly MediaUriType RTSP_URI = new MediaUriType("RTSP_URI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaUriType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaUriType FindValue(string value)
        {
            return FindValue<MediaUriType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaUriType(string value)
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
        /// Constant ACTIVE for Status
        /// </summary>
        public static readonly Status ACTIVE = new Status("ACTIVE");
        /// <summary>
        /// Constant CREATING for Status
        /// </summary>
        public static readonly Status CREATING = new Status("CREATING");
        /// <summary>
        /// Constant DELETING for Status
        /// </summary>
        public static readonly Status DELETING = new Status("DELETING");
        /// <summary>
        /// Constant UPDATING for Status
        /// </summary>
        public static readonly Status UPDATING = new Status("UPDATING");

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
    /// Constants used for properties of type StrategyOnFullSize.
    /// </summary>
    public class StrategyOnFullSize : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_OLDEST_MEDIA for StrategyOnFullSize
        /// </summary>
        public static readonly StrategyOnFullSize DELETE_OLDEST_MEDIA = new StrategyOnFullSize("DELETE_OLDEST_MEDIA");
        /// <summary>
        /// Constant DENY_NEW_MEDIA for StrategyOnFullSize
        /// </summary>
        public static readonly StrategyOnFullSize DENY_NEW_MEDIA = new StrategyOnFullSize("DENY_NEW_MEDIA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StrategyOnFullSize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StrategyOnFullSize FindValue(string value)
        {
            return FindValue<StrategyOnFullSize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StrategyOnFullSize(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SyncStatus.
    /// </summary>
    public class SyncStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACKNOWLEDGED for SyncStatus
        /// </summary>
        public static readonly SyncStatus ACKNOWLEDGED = new SyncStatus("ACKNOWLEDGED");
        /// <summary>
        /// Constant DELETE_FAILED for SyncStatus
        /// </summary>
        public static readonly SyncStatus DELETE_FAILED = new SyncStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for SyncStatus
        /// </summary>
        public static readonly SyncStatus DELETING = new SyncStatus("DELETING");
        /// <summary>
        /// Constant IN_SYNC for SyncStatus
        /// </summary>
        public static readonly SyncStatus IN_SYNC = new SyncStatus("IN_SYNC");
        /// <summary>
        /// Constant SYNC_FAILED for SyncStatus
        /// </summary>
        public static readonly SyncStatus SYNC_FAILED = new SyncStatus("SYNC_FAILED");
        /// <summary>
        /// Constant SYNCING for SyncStatus
        /// </summary>
        public static readonly SyncStatus SYNCING = new SyncStatus("SYNCING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SyncStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SyncStatus FindValue(string value)
        {
            return FindValue<SyncStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SyncStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateDataRetentionOperation.
    /// </summary>
    public class UpdateDataRetentionOperation : ConstantClass
    {

        /// <summary>
        /// Constant DECREASE_DATA_RETENTION for UpdateDataRetentionOperation
        /// </summary>
        public static readonly UpdateDataRetentionOperation DECREASE_DATA_RETENTION = new UpdateDataRetentionOperation("DECREASE_DATA_RETENTION");
        /// <summary>
        /// Constant INCREASE_DATA_RETENTION for UpdateDataRetentionOperation
        /// </summary>
        public static readonly UpdateDataRetentionOperation INCREASE_DATA_RETENTION = new UpdateDataRetentionOperation("INCREASE_DATA_RETENTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateDataRetentionOperation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateDataRetentionOperation FindValue(string value)
        {
            return FindValue<UpdateDataRetentionOperation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateDataRetentionOperation(string value)
        {
            return FindValue(value);
        }
    }

}