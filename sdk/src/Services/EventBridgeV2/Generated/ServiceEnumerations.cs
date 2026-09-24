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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.EventBridgeV2
{

    /// <summary>
    /// Constants used for properties of type BusState.
    /// </summary>
    public class BusState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for BusState
        /// </summary>
        public static readonly BusState ACTIVE = new BusState("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for BusState
        /// </summary>
        public static readonly BusState CREATE_FAILED = new BusState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for BusState
        /// </summary>
        public static readonly BusState CREATING = new BusState("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for BusState
        /// </summary>
        public static readonly BusState DELETE_FAILED = new BusState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for BusState
        /// </summary>
        public static readonly BusState DELETING = new BusState("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for BusState
        /// </summary>
        public static readonly BusState UPDATE_FAILED = new BusState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for BusState
        /// </summary>
        public static readonly BusState UPDATING = new BusState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BusState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BusState FindValue(string value)
        {
            return FindValue<BusState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BusState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeduplicationType.
    /// </summary>
    public class DeduplicationType : ConstantClass
    {

        /// <summary>
        /// Constant CONTENT_BASED for DeduplicationType
        /// </summary>
        public static readonly DeduplicationType CONTENT_BASED = new DeduplicationType("CONTENT_BASED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeduplicationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeduplicationType FindValue(string value)
        {
            return FindValue<DeduplicationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeduplicationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventSourceState.
    /// </summary>
    public class EventSourceState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EventSourceState
        /// </summary>
        public static readonly EventSourceState ACTIVE = new EventSourceState("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for EventSourceState
        /// </summary>
        public static readonly EventSourceState CREATE_FAILED = new EventSourceState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for EventSourceState
        /// </summary>
        public static readonly EventSourceState CREATING = new EventSourceState("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for EventSourceState
        /// </summary>
        public static readonly EventSourceState DELETE_FAILED = new EventSourceState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for EventSourceState
        /// </summary>
        public static readonly EventSourceState DELETING = new EventSourceState("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for EventSourceState
        /// </summary>
        public static readonly EventSourceState UPDATE_FAILED = new EventSourceState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for EventSourceState
        /// </summary>
        public static readonly EventSourceState UPDATING = new EventSourceState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSourceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSourceState FindValue(string value)
        {
            return FindValue<EventSourceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSourceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventSourceType.
    /// </summary>
    public class EventSourceType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_SERVICE_EVENTS for EventSourceType
        /// </summary>
        public static readonly EventSourceType AWS_SERVICE_EVENTS = new EventSourceType("AWS_SERVICE_EVENTS");
        /// <summary>
        /// Constant PARTNER_EVENTS for EventSourceType
        /// </summary>
        public static readonly EventSourceType PARTNER_EVENTS = new EventSourceType("PARTNER_EVENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSourceType FindValue(string value)
        {
            return FindValue<EventSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterLanguage.
    /// </summary>
    public class FilterLanguage : ConstantClass
    {

        /// <summary>
        /// Constant EVENT_BRIDGE_PATTERN for FilterLanguage
        /// </summary>
        public static readonly FilterLanguage EVENT_BRIDGE_PATTERN = new FilterLanguage("EVENT_BRIDGE_PATTERN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterLanguage FindValue(string value)
        {
            return FindValue<FilterLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterLanguage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterScope.
    /// </summary>
    public class FilterScope : ConstantClass
    {

        /// <summary>
        /// Constant DATA for FilterScope
        /// </summary>
        public static readonly FilterScope DATA = new FilterScope("DATA");
        /// <summary>
        /// Constant METADATA for FilterScope
        /// </summary>
        public static readonly FilterScope METADATA = new FilterScope("METADATA");
        /// <summary>
        /// Constant SYSTEM_METADATA for FilterScope
        /// </summary>
        public static readonly FilterScope SYSTEM_METADATA = new FilterScope("SYSTEM_METADATA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterScope FindValue(string value)
        {
            return FindValue<FilterScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IncludePayload.
    /// </summary>
    public class IncludePayload : ConstantClass
    {

        /// <summary>
        /// Constant FULL for IncludePayload
        /// </summary>
        public static readonly IncludePayload FULL = new IncludePayload("FULL");
        /// <summary>
        /// Constant ON_ERROR_ONLY for IncludePayload
        /// </summary>
        public static readonly IncludePayload ON_ERROR_ONLY = new IncludePayload("ON_ERROR_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IncludePayload(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IncludePayload FindValue(string value)
        {
            return FindValue<IncludePayload>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IncludePayload(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvocationType.
    /// </summary>
    public class InvocationType : ConstantClass
    {

        /// <summary>
        /// Constant EVENT for InvocationType
        /// </summary>
        public static readonly InvocationType EVENT = new InvocationType("EVENT");
        /// <summary>
        /// Constant REQUEST_RESPONSE for InvocationType
        /// </summary>
        public static readonly InvocationType REQUEST_RESPONSE = new InvocationType("REQUEST_RESPONSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvocationType FindValue(string value)
        {
            return FindValue<InvocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvocationType(string value)
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
        /// Constant ERROR for LogLevel
        /// </summary>
        public static readonly LogLevel ERROR = new LogLevel("ERROR");
        /// <summary>
        /// Constant INFO for LogLevel
        /// </summary>
        public static readonly LogLevel INFO = new LogLevel("INFO");
        /// <summary>
        /// Constant OFF for LogLevel
        /// </summary>
        public static readonly LogLevel OFF = new LogLevel("OFF");

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
    /// Constants used for properties of type OrderingType.
    /// </summary>
    public class OrderingType : ConstantClass
    {

        /// <summary>
        /// Constant FIFO for OrderingType
        /// </summary>
        public static readonly OrderingType FIFO = new OrderingType("FIFO");
        /// <summary>
        /// Constant UNORDERED for OrderingType
        /// </summary>
        public static readonly OrderingType UNORDERED = new OrderingType("UNORDERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderingType FindValue(string value)
        {
            return FindValue<OrderingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PointType.
    /// </summary>
    public class PointType : ConstantClass
    {

        /// <summary>
        /// Constant HORIZON for PointType
        /// </summary>
        public static readonly PointType HORIZON = new PointType("HORIZON");
        /// <summary>
        /// Constant TIMESTAMP for PointType
        /// </summary>
        public static readonly PointType TIMESTAMP = new PointType("TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PointType FindValue(string value)
        {
            return FindValue<PointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResumePosition.
    /// </summary>
    public class ResumePosition : ConstantClass
    {

        /// <summary>
        /// Constant LAST_PROCESSED for ResumePosition
        /// </summary>
        public static readonly ResumePosition LAST_PROCESSED = new ResumePosition("LAST_PROCESSED");
        /// <summary>
        /// Constant LATEST for ResumePosition
        /// </summary>
        public static readonly ResumePosition LATEST = new ResumePosition("LATEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResumePosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResumePosition FindValue(string value)
        {
            return FindValue<ResumePosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResumePosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetryStrategy.
    /// </summary>
    public class RetryStrategy : ConstantClass
    {

        /// <summary>
        /// Constant ALL for RetryStrategy
        /// </summary>
        public static readonly RetryStrategy ALL = new RetryStrategy("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetryStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetryStrategy FindValue(string value)
        {
            return FindValue<RetryStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetryStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StartingPosition.
    /// </summary>
    public class StartingPosition : ConstantClass
    {

        /// <summary>
        /// Constant LATEST for StartingPosition
        /// </summary>
        public static readonly StartingPosition LATEST = new StartingPosition("LATEST");
        /// <summary>
        /// Constant POINT_IN_TIME for StartingPosition
        /// </summary>
        public static readonly StartingPosition POINT_IN_TIME = new StartingPosition("POINT_IN_TIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StartingPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StartingPosition FindValue(string value)
        {
            return FindValue<StartingPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StartingPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriberState.
    /// </summary>
    public class SubscriberState : ConstantClass
    {

        /// <summary>
        /// Constant RUNNING for SubscriberState
        /// </summary>
        public static readonly SubscriberState RUNNING = new SubscriberState("RUNNING");
        /// <summary>
        /// Constant STOPPED for SubscriberState
        /// </summary>
        public static readonly SubscriberState STOPPED = new SubscriberState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriberState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriberState FindValue(string value)
        {
            return FindValue<SubscriberState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriberState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SuccessCode.
    /// </summary>
    public class SuccessCode : ConstantClass
    {

        /// <summary>
        /// Constant DEDUPLICATED for SuccessCode
        /// </summary>
        public static readonly SuccessCode DEDUPLICATED = new SuccessCode("DEDUPLICATED");
        /// <summary>
        /// Constant PUBLISHED for SuccessCode
        /// </summary>
        public static readonly SuccessCode PUBLISHED = new SuccessCode("PUBLISHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SuccessCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SuccessCode FindValue(string value)
        {
            return FindValue<SuccessCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SuccessCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformerType.
    /// </summary>
    public class TransformerType : ConstantClass
    {

        /// <summary>
        /// Constant JSONATA for TransformerType
        /// </summary>
        public static readonly TransformerType JSONATA = new TransformerType("JSONATA");
        /// <summary>
        /// Constant RAW for TransformerType
        /// </summary>
        public static readonly TransformerType RAW = new TransformerType("RAW");
        /// <summary>
        /// Constant WITH_METADATA for TransformerType
        /// </summary>
        public static readonly TransformerType WITH_METADATA = new TransformerType("WITH_METADATA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformerType FindValue(string value)
        {
            return FindValue<TransformerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformerType(string value)
        {
            return FindValue(value);
        }
    }

}