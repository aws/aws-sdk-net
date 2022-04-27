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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ChimeSDKMediaPipelines
{

    /// <summary>
    /// Constants used for properties of type ArtifactsState.
    /// </summary>
    public class ArtifactsState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ArtifactsState
        /// </summary>
        public static readonly ArtifactsState Disabled = new ArtifactsState("Disabled");
        /// <summary>
        /// Constant Enabled for ArtifactsState
        /// </summary>
        public static readonly ArtifactsState Enabled = new ArtifactsState("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactsState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactsState FindValue(string value)
        {
            return FindValue<ArtifactsState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactsState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioMuxType.
    /// </summary>
    public class AudioMuxType : ConstantClass
    {

        /// <summary>
        /// Constant AudioOnly for AudioMuxType
        /// </summary>
        public static readonly AudioMuxType AudioOnly = new AudioMuxType("AudioOnly");
        /// <summary>
        /// Constant AudioWithActiveSpeakerVideo for AudioMuxType
        /// </summary>
        public static readonly AudioMuxType AudioWithActiveSpeakerVideo = new AudioMuxType("AudioWithActiveSpeakerVideo");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioMuxType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioMuxType FindValue(string value)
        {
            return FindValue<AudioMuxType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioMuxType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentMuxType.
    /// </summary>
    public class ContentMuxType : ConstantClass
    {

        /// <summary>
        /// Constant ContentOnly for ContentMuxType
        /// </summary>
        public static readonly ContentMuxType ContentOnly = new ContentMuxType("ContentOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentMuxType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentMuxType FindValue(string value)
        {
            return FindValue<ContentMuxType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentMuxType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BadRequest for ErrorCode
        /// </summary>
        public static readonly ErrorCode BadRequest = new ErrorCode("BadRequest");
        /// <summary>
        /// Constant Forbidden for ErrorCode
        /// </summary>
        public static readonly ErrorCode Forbidden = new ErrorCode("Forbidden");
        /// <summary>
        /// Constant NotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode NotFound = new ErrorCode("NotFound");
        /// <summary>
        /// Constant ResourceLimitExceeded for ErrorCode
        /// </summary>
        public static readonly ErrorCode ResourceLimitExceeded = new ErrorCode("ResourceLimitExceeded");
        /// <summary>
        /// Constant ServiceFailure for ErrorCode
        /// </summary>
        public static readonly ErrorCode ServiceFailure = new ErrorCode("ServiceFailure");
        /// <summary>
        /// Constant ServiceUnavailable for ErrorCode
        /// </summary>
        public static readonly ErrorCode ServiceUnavailable = new ErrorCode("ServiceUnavailable");
        /// <summary>
        /// Constant Throttling for ErrorCode
        /// </summary>
        public static readonly ErrorCode Throttling = new ErrorCode("Throttling");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaPipelineSinkType.
    /// </summary>
    public class MediaPipelineSinkType : ConstantClass
    {

        /// <summary>
        /// Constant S3Bucket for MediaPipelineSinkType
        /// </summary>
        public static readonly MediaPipelineSinkType S3Bucket = new MediaPipelineSinkType("S3Bucket");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaPipelineSinkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaPipelineSinkType FindValue(string value)
        {
            return FindValue<MediaPipelineSinkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaPipelineSinkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaPipelineSourceType.
    /// </summary>
    public class MediaPipelineSourceType : ConstantClass
    {

        /// <summary>
        /// Constant ChimeSdkMeeting for MediaPipelineSourceType
        /// </summary>
        public static readonly MediaPipelineSourceType ChimeSdkMeeting = new MediaPipelineSourceType("ChimeSdkMeeting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaPipelineSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaPipelineSourceType FindValue(string value)
        {
            return FindValue<MediaPipelineSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaPipelineSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaPipelineStatus.
    /// </summary>
    public class MediaPipelineStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Failed = new MediaPipelineStatus("Failed");
        /// <summary>
        /// Constant Initializing for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Initializing = new MediaPipelineStatus("Initializing");
        /// <summary>
        /// Constant InProgress for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus InProgress = new MediaPipelineStatus("InProgress");
        /// <summary>
        /// Constant Stopped for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Stopped = new MediaPipelineStatus("Stopped");
        /// <summary>
        /// Constant Stopping for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Stopping = new MediaPipelineStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaPipelineStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaPipelineStatus FindValue(string value)
        {
            return FindValue<MediaPipelineStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaPipelineStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoMuxType.
    /// </summary>
    public class VideoMuxType : ConstantClass
    {

        /// <summary>
        /// Constant VideoOnly for VideoMuxType
        /// </summary>
        public static readonly VideoMuxType VideoOnly = new VideoMuxType("VideoOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoMuxType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoMuxType FindValue(string value)
        {
            return FindValue<VideoMuxType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoMuxType(string value)
        {
            return FindValue(value);
        }
    }

}