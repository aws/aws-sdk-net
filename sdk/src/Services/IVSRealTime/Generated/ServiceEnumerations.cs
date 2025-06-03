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
        /// Constant B_FRAME_PRESENT for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode B_FRAME_PRESENT = new EventErrorCode("B_FRAME_PRESENT");
        /// <summary>
        /// Constant BITRATE_EXCEEDED for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode BITRATE_EXCEEDED = new EventErrorCode("BITRATE_EXCEEDED");
        /// <summary>
        /// Constant INSUFFICIENT_CAPABILITIES for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode INSUFFICIENT_CAPABILITIES = new EventErrorCode("INSUFFICIENT_CAPABILITIES");
        /// <summary>
        /// Constant INTERNAL_SERVER_EXCEPTION for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode INTERNAL_SERVER_EXCEPTION = new EventErrorCode("INTERNAL_SERVER_EXCEPTION");
        /// <summary>
        /// Constant INVALID_AUDIO_CODEC for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode INVALID_AUDIO_CODEC = new EventErrorCode("INVALID_AUDIO_CODEC");
        /// <summary>
        /// Constant INVALID_INPUT for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode INVALID_INPUT = new EventErrorCode("INVALID_INPUT");
        /// <summary>
        /// Constant INVALID_PROTOCOL for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode INVALID_PROTOCOL = new EventErrorCode("INVALID_PROTOCOL");
        /// <summary>
        /// Constant INVALID_STREAM_KEY for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode INVALID_STREAM_KEY = new EventErrorCode("INVALID_STREAM_KEY");
        /// <summary>
        /// Constant INVALID_VIDEO_CODEC for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode INVALID_VIDEO_CODEC = new EventErrorCode("INVALID_VIDEO_CODEC");
        /// <summary>
        /// Constant PUBLISHER_NOT_FOUND for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode PUBLISHER_NOT_FOUND = new EventErrorCode("PUBLISHER_NOT_FOUND");
        /// <summary>
        /// Constant QUOTA_EXCEEDED for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode QUOTA_EXCEEDED = new EventErrorCode("QUOTA_EXCEEDED");
        /// <summary>
        /// Constant RESOLUTION_EXCEEDED for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode RESOLUTION_EXCEEDED = new EventErrorCode("RESOLUTION_EXCEEDED");
        /// <summary>
        /// Constant REUSE_OF_STREAM_KEY for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode REUSE_OF_STREAM_KEY = new EventErrorCode("REUSE_OF_STREAM_KEY");
        /// <summary>
        /// Constant STREAM_DURATION_EXCEEDED for EventErrorCode
        /// </summary>
        public static readonly EventErrorCode STREAM_DURATION_EXCEEDED = new EventErrorCode("STREAM_DURATION_EXCEEDED");

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
        /// Constant REPLICATION_STARTED for EventName
        /// </summary>
        public static readonly EventName REPLICATION_STARTED = new EventName("REPLICATION_STARTED");
        /// <summary>
        /// Constant REPLICATION_STOPPED for EventName
        /// </summary>
        public static readonly EventName REPLICATION_STOPPED = new EventName("REPLICATION_STOPPED");
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
    /// Constants used for properties of type IngestConfigurationState.
    /// </summary>
    public class IngestConfigurationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IngestConfigurationState
        /// </summary>
        public static readonly IngestConfigurationState ACTIVE = new IngestConfigurationState("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for IngestConfigurationState
        /// </summary>
        public static readonly IngestConfigurationState INACTIVE = new IngestConfigurationState("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestConfigurationState FindValue(string value)
        {
            return FindValue<IngestConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestConfigurationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestProtocol.
    /// </summary>
    public class IngestProtocol : ConstantClass
    {

        /// <summary>
        /// Constant RTMP for IngestProtocol
        /// </summary>
        public static readonly IngestProtocol RTMP = new IngestProtocol("RTMP");
        /// <summary>
        /// Constant RTMPS for IngestProtocol
        /// </summary>
        public static readonly IngestProtocol RTMPS = new IngestProtocol("RTMPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestProtocol FindValue(string value)
        {
            return FindValue<IngestProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantProtocol.
    /// </summary>
    public class ParticipantProtocol : ConstantClass
    {

        /// <summary>
        /// Constant RTMP for ParticipantProtocol
        /// </summary>
        public static readonly ParticipantProtocol RTMP = new ParticipantProtocol("RTMP");
        /// <summary>
        /// Constant RTMPS for ParticipantProtocol
        /// </summary>
        public static readonly ParticipantProtocol RTMPS = new ParticipantProtocol("RTMPS");
        /// <summary>
        /// Constant UNKNOWN for ParticipantProtocol
        /// </summary>
        public static readonly ParticipantProtocol UNKNOWN = new ParticipantProtocol("UNKNOWN");
        /// <summary>
        /// Constant WHIP for ParticipantProtocol
        /// </summary>
        public static readonly ParticipantProtocol WHIP = new ParticipantProtocol("WHIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantProtocol FindValue(string value)
        {
            return FindValue<ParticipantProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantProtocol(string value)
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
        /// Constant NONE for ParticipantRecordingMediaType
        /// </summary>
        public static readonly ParticipantRecordingMediaType NONE = new ParticipantRecordingMediaType("NONE");

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
    /// Constants used for properties of type ReplicationState.
    /// </summary>
    public class ReplicationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ReplicationState
        /// </summary>
        public static readonly ReplicationState ACTIVE = new ReplicationState("ACTIVE");
        /// <summary>
        /// Constant STOPPED for ReplicationState
        /// </summary>
        public static readonly ReplicationState STOPPED = new ReplicationState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationState FindValue(string value)
        {
            return FindValue<ReplicationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationType.
    /// </summary>
    public class ReplicationType : ConstantClass
    {

        /// <summary>
        /// Constant NONE for ReplicationType
        /// </summary>
        public static readonly ReplicationType NONE = new ReplicationType("NONE");
        /// <summary>
        /// Constant REPLICA for ReplicationType
        /// </summary>
        public static readonly ReplicationType REPLICA = new ReplicationType("REPLICA");
        /// <summary>
        /// Constant SOURCE for ReplicationType
        /// </summary>
        public static readonly ReplicationType SOURCE = new ReplicationType("SOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationType FindValue(string value)
        {
            return FindValue<ReplicationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThumbnailRecordingMode.
    /// </summary>
    public class ThumbnailRecordingMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ThumbnailRecordingMode
        /// </summary>
        public static readonly ThumbnailRecordingMode DISABLED = new ThumbnailRecordingMode("DISABLED");
        /// <summary>
        /// Constant INTERVAL for ThumbnailRecordingMode
        /// </summary>
        public static readonly ThumbnailRecordingMode INTERVAL = new ThumbnailRecordingMode("INTERVAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThumbnailRecordingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThumbnailRecordingMode FindValue(string value)
        {
            return FindValue<ThumbnailRecordingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThumbnailRecordingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThumbnailStorageType.
    /// </summary>
    public class ThumbnailStorageType : ConstantClass
    {

        /// <summary>
        /// Constant LATEST for ThumbnailStorageType
        /// </summary>
        public static readonly ThumbnailStorageType LATEST = new ThumbnailStorageType("LATEST");
        /// <summary>
        /// Constant SEQUENTIAL for ThumbnailStorageType
        /// </summary>
        public static readonly ThumbnailStorageType SEQUENTIAL = new ThumbnailStorageType("SEQUENTIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThumbnailStorageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThumbnailStorageType FindValue(string value)
        {
            return FindValue<ThumbnailStorageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThumbnailStorageType(string value)
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