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
 * Do not modify this file. This file is generated from the sms-voice-2018-09-05.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PinpointSMSVoice
{

    /// <summary>
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant ANSWERED for EventType
        /// </summary>
        public static readonly EventType ANSWERED = new EventType("ANSWERED");
        /// <summary>
        /// Constant BUSY for EventType
        /// </summary>
        public static readonly EventType BUSY = new EventType("BUSY");
        /// <summary>
        /// Constant COMPLETED_CALL for EventType
        /// </summary>
        public static readonly EventType COMPLETED_CALL = new EventType("COMPLETED_CALL");
        /// <summary>
        /// Constant FAILED for EventType
        /// </summary>
        public static readonly EventType FAILED = new EventType("FAILED");
        /// <summary>
        /// Constant INITIATED_CALL for EventType
        /// </summary>
        public static readonly EventType INITIATED_CALL = new EventType("INITIATED_CALL");
        /// <summary>
        /// Constant NO_ANSWER for EventType
        /// </summary>
        public static readonly EventType NO_ANSWER = new EventType("NO_ANSWER");
        /// <summary>
        /// Constant RINGING for EventType
        /// </summary>
        public static readonly EventType RINGING = new EventType("RINGING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }

}