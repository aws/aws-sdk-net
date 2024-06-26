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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IVSRealTime
{

    /// <summary>
    /// Constants used for properties of type CompositionState.
    /// </summary>
    public class CompositionState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CompositionState
        /// </summary>
        public static readonly CompositionState ACTIVE = new CompositionState("ACTIVE");
        /// <summary>
        /// Constant FAILED for CompositionState
        /// </summary>
        public static readonly CompositionState FAILED = new CompositionState("FAILED");
        /// <summary>
        /// Constant STARTING for CompositionState
        /// </summary>
        public static readonly CompositionState STARTING = new CompositionState("STARTING");
        /// <summary>
        /// Constant STOPPED for CompositionState
        /// </summary>
        public static readonly CompositionState STOPPED = new CompositionState("STOPPED");
        /// <summary>
        /// Constant STOPPING for CompositionState
        /// </summary>
        public static readonly CompositionState STOPPING = new CompositionState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompositionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompositionState FindValue(string value)
        {
            return FindValue<CompositionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompositionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DestinationState.
    /// </summary>
    public class DestinationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DestinationState
        /// </summary>
        public static readonly DestinationState ACTIVE = new DestinationState("ACTIVE");
        /// <summary>
        /// Constant FAILED for DestinationState
        /// </summary>
        public static readonly DestinationState FAILED = new DestinationState("FAILED");
        /// <summary>
        /// Constant RECONNECTING for DestinationState
        /// </summary>
        public static readonly DestinationState RECONNECTING = new DestinationState("RECONNECTING");
        /// <summary>
        /// Constant STARTING for DestinationState
        /// </summary>
        public static readonly DestinationState STARTING = new DestinationState("STARTING");
        /// <summary>
        /// Constant STOPPED for DestinationState
        /// </summary>
        public static readonly DestinationState STOPPED = new DestinationState("STOPPED");
        /// <summary>
        /// Constant STOPPING for DestinationState
        /// </summary>
        public static readonly DestinationState STOPPING = new DestinationState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DestinationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DestinationState FindValue(string value)
        {
            return FindValue<DestinationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DestinationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventErrorCode.
    /// </summary>
    public class EventErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INSUFFICIENT_CAPABILITIES for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode INSUFFICIENT_CAPABILITIES = new EventErrorCode("INSUFFICIENT_CAPABILITIES");
        /// <summary>
        /// Constant PUBLISHER_NOT_FOUND for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode PUBLISHER_NOT_FOUND = new EventErrorCode("PUBLISHER_NOT_FOUND");
        /// <summary>
        /// Constant QUOTA_EXCEEDED for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode QUOTA_EXCEEDED = new EventErrorCode("QUOTA_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventErrorCode FindValue(string value)
        {
            return FindValue<EventErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventName.
    /// </summary>
    public class EventName : ConstantClass
    {

        /// <summary>
        /// Constant JOIN_ERROR for EventName
        /// </summary>
        public static readonly EventName JOIN_ERROR = new EventName("JOIN_ERROR");
        /// <summary>
        /// Constant JOINED for EventName
        /// </summary>
        public static readonly EventName JOINED = new EventName("JOINED");
        /// <summary>
        /// Constant LEFT for EventName
        /// </summary>
        public static readonly EventName LEFT = new EventName("LEFT");
        /// <summary>
        /// Constant PUBLISH_ERROR for EventName
        /// </summary>
        public static readonly EventName PUBLISH_ERROR = new EventName("PUBLISH_ERROR");
        /// <summary>
        /// Constant PUBLISH_STARTED for EventName
        /// </summary>
        public static readonly EventName PUBLISH_STARTED = new EventName("PUBLISH_STARTED");
        /// <summary>
        /// Constant PUBLISH_STOPPED for EventName
        /// </summary>
        public static readonly EventName PUBLISH_STOPPED = new EventName("PUBLISH_STOPPED");
        /// <summary>
        /// Constant SUBSCRIBE_ERROR for EventName
        /// </summary>
        public static readonly EventName SUBSCRIBE_ERROR = new EventName("SUBSCRIBE_ERROR");
        /// <summary>
        /// Constant SUBSCRIBE_STARTED for EventName
        /// </summary>
        public static readonly EventName SUBSCRIBE_STARTED = new EventName("SUBSCRIBE_STARTED");
        /// <summary>
        /// Constant SUBSCRIBE_STOPPED for EventName
        /// </summary>
        public static readonly EventName SUBSCRIBE_STOPPED = new EventName("SUBSCRIBE_STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventName FindValue(string value)
        {
            return FindValue<EventName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantRecordingFilterByRecordingState.
    /// </summary>
    public class ParticipantRecordingFilterByRecordingState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ParticipantRecordingFilterByRecordingState
        /// </summary>
        public static readonly ParticipantRecordingFilterByRecordingState ACTIVE = new ParticipantRecordingFilterByRecordingState("ACTIVE");
        /// <summary>
        /// Constant FAILED for ParticipantRecordingFilterByRecordingState
        /// </summary>
        public static readonly ParticipantRecordingFilterByRecordingState FAILED = new ParticipantRecordingFilterByRecordingState("FAILED");
        /// <summary>
        /// Constant STARTING for ParticipantRecordingFilterByRecordingState
        /// </summary>
        public static readonly ParticipantRecordingFilterByRecordingState STARTING = new ParticipantRecordingFilterByRecordingState("STARTING");
        /// <summary>
        /// Constant STOPPED for ParticipantRecordingFilterByRecordingState
        /// </summary>
        public static readonly ParticipantRecordingFilterByRecordingState STOPPED = new ParticipantRecordingFilterByRecordingState("STOPPED");
        /// <summary>
        /// Constant STOPPING for ParticipantRecordingFilterByRecordingState
        /// </summary>
        public static readonly ParticipantRecordingFilterByRecordingState STOPPING = new ParticipantRecordingFilterByRecordingState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantRecordingFilterByRecordingState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantRecordingFilterByRecordingState FindValue(string value)
        {
            return FindValue<ParticipantRecordingFilterByRecordingState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantRecordingFilterByRecordingState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantRecordingMediaType.
    /// </summary>
    public class ParticipantRecordingMediaType : ConstantClass
    {

        /// <summary>
        /// Constant AUDIO_ONLY for ParticipantRecordingMediaType
        /// </summary>
        public static readonly ParticipantRecordingMediaType AUDIO_ONLY = new ParticipantRecordingMediaType("AUDIO_ONLY");
        /// <summary>
        /// Constant AUDIO_VIDEO for ParticipantRecordingMediaType
        /// </summary>
        public static readonly ParticipantRecordingMediaType AUDIO_VIDEO = new ParticipantRecordingMediaType("AUDIO_VIDEO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantRecordingMediaType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantRecordingMediaType FindValue(string value)
        {
            return FindValue<ParticipantRecordingMediaType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantRecordingMediaType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantRecordingState.
    /// </summary>
    public class ParticipantRecordingState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ParticipantRecordingState
        /// </summary>
        public static readonly ParticipantRecordingState ACTIVE = new ParticipantRecordingState("ACTIVE");
        /// <summary>
        /// Constant DISABLED for ParticipantRecordingState
        /// </summary>
        public static readonly ParticipantRecordingState DISABLED = new ParticipantRecordingState("DISABLED");
        /// <summary>
        /// Constant FAILED for ParticipantRecordingState
        /// </summary>
        public static readonly ParticipantRecordingState FAILED = new ParticipantRecordingState("FAILED");
        /// <summary>
        /// Constant STARTING for ParticipantRecordingState
        /// </summary>
        public static readonly ParticipantRecordingState STARTING = new ParticipantRecordingState("STARTING");
        /// <summary>
        /// Constant STOPPED for ParticipantRecordingState
        /// </summary>
        public static readonly ParticipantRecordingState STOPPED = new ParticipantRecordingState("STOPPED");
        /// <summary>
        /// Constant STOPPING for ParticipantRecordingState
        /// </summary>
        public static readonly ParticipantRecordingState STOPPING = new ParticipantRecordingState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantRecordingState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantRecordingState FindValue(string value)
        {
            return FindValue<ParticipantRecordingState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantRecordingState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantState.
    /// </summary>
    public class ParticipantState : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for ParticipantState
        /// </summary>
        public static readonly ParticipantState CONNECTED = new ParticipantState("CONNECTED");
        /// <summary>
        /// Constant DISCONNECTED for ParticipantState
        /// </summary>
        public static readonly ParticipantState DISCONNECTED = new ParticipantState("DISCONNECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantState FindValue(string value)
        {
            return FindValue<ParticipantState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantTokenCapability.
    /// </summary>
    public class ParticipantTokenCapability : ConstantClass
    {

        /// <summary>
        /// Constant PUBLISH for ParticipantTokenCapability
        /// </summary>
        public static readonly ParticipantTokenCapability PUBLISH = new ParticipantTokenCapability("PUBLISH");
        /// <summary>
        /// Constant SUBSCRIBE for ParticipantTokenCapability
        /// </summary>
        public static readonly ParticipantTokenCapability SUBSCRIBE = new ParticipantTokenCapability("SUBSCRIBE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantTokenCapability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantTokenCapability FindValue(string value)
        {
            return FindValue<ParticipantTokenCapability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantTokenCapability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipBehavior.
    /// </summary>
    public class PipBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DYNAMIC for PipBehavior
        /// </summary>
        public static readonly PipBehavior DYNAMIC = new PipBehavior("DYNAMIC");
        /// <summary>
        /// Constant STATIC for PipBehavior
        /// </summary>
        public static readonly PipBehavior STATIC = new PipBehavior("STATIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipBehavior FindValue(string value)
        {
            return FindValue<PipBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipPosition.
    /// </summary>
    public class PipPosition : ConstantClass
    {

        /// <summary>
        /// Constant BOTTOM_LEFT for PipPosition
        /// </summary>
        public static readonly PipPosition BOTTOM_LEFT = new PipPosition("BOTTOM_LEFT");
        /// <summary>
        /// Constant BOTTOM_RIGHT for PipPosition
        /// </summary>
        public static readonly PipPosition BOTTOM_RIGHT = new PipPosition("BOTTOM_RIGHT");
        /// <summary>
        /// Constant TOP_LEFT for PipPosition
        /// </summary>
        public static readonly PipPosition TOP_LEFT = new PipPosition("TOP_LEFT");
        /// <summary>
        /// Constant TOP_RIGHT for PipPosition
        /// </summary>
        public static readonly PipPosition TOP_RIGHT = new PipPosition("TOP_RIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipPosition FindValue(string value)
        {
            return FindValue<PipPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordingConfigurationFormat.
    /// </summary>
    public class RecordingConfigurationFormat : ConstantClass
    {

        /// <summary>
        /// Constant HLS for RecordingConfigurationFormat
        /// </summary>
        public static readonly RecordingConfigurationFormat HLS = new RecordingConfigurationFormat("HLS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordingConfigurationFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordingConfigurationFormat FindValue(string value)
        {
            return FindValue<RecordingConfigurationFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordingConfigurationFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoAspectRatio.
    /// </summary>
    public class VideoAspectRatio : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for VideoAspectRatio
        /// </summary>
        public static readonly VideoAspectRatio AUTO = new VideoAspectRatio("AUTO");
        /// <summary>
        /// Constant PORTRAIT for VideoAspectRatio
        /// </summary>
        public static readonly VideoAspectRatio PORTRAIT = new VideoAspectRatio("PORTRAIT");
        /// <summary>
        /// Constant SQUARE for VideoAspectRatio
        /// </summary>
        public static readonly VideoAspectRatio SQUARE = new VideoAspectRatio("SQUARE");
        /// <summary>
        /// Constant VIDEO for VideoAspectRatio
        /// </summary>
        public static readonly VideoAspectRatio VIDEO = new VideoAspectRatio("VIDEO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoAspectRatio(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoAspectRatio FindValue(string value)
        {
            return FindValue<VideoAspectRatio>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoAspectRatio(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoFillMode.
    /// </summary>
    public class VideoFillMode : ConstantClass
    {

        /// <summary>
        /// Constant CONTAIN for VideoFillMode
        /// </summary>
        public static readonly VideoFillMode CONTAIN = new VideoFillMode("CONTAIN");
        /// <summary>
        /// Constant COVER for VideoFillMode
        /// </summary>
        public static readonly VideoFillMode COVER = new VideoFillMode("COVER");
        /// <summary>
        /// Constant FILL for VideoFillMode
        /// </summary>
        public static readonly VideoFillMode FILL = new VideoFillMode("FILL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoFillMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoFillMode FindValue(string value)
        {
            return FindValue<VideoFillMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoFillMode(string value)
        {
            return FindValue(value);
        }
    }

}