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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoTEventsData
{

    /// <summary>
    /// Constants used for properties of type AlarmStateName.
    /// </summary>
    public class AlarmStateName : ConstantClass
    {

        /// <summary>
        /// Constant ACKNOWLEDGED for AlarmStateName
        /// </summary>
        public static readonly AlarmStateName ACKNOWLEDGED = new AlarmStateName("ACKNOWLEDGED");
        /// <summary>
        /// Constant ACTIVE for AlarmStateName
        /// </summary>
        public static readonly AlarmStateName ACTIVE = new AlarmStateName("ACTIVE");
        /// <summary>
        /// Constant DISABLED for AlarmStateName
        /// </summary>
        public static readonly AlarmStateName DISABLED = new AlarmStateName("DISABLED");
        /// <summary>
        /// Constant LATCHED for AlarmStateName
        /// </summary>
        public static readonly AlarmStateName LATCHED = new AlarmStateName("LATCHED");
        /// <summary>
        /// Constant NORMAL for AlarmStateName
        /// </summary>
        public static readonly AlarmStateName NORMAL = new AlarmStateName("NORMAL");
        /// <summary>
        /// Constant SNOOZE_DISABLED for AlarmStateName
        /// </summary>
        public static readonly AlarmStateName SNOOZE_DISABLED = new AlarmStateName("SNOOZE_DISABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlarmStateName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlarmStateName FindValue(string value)
        {
            return FindValue<AlarmStateName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlarmStateName(string value)
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
        /// Constant EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator EQUAL = new ComparisonOperator("EQUAL");
        /// <summary>
        /// Constant GREATER for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GREATER = new ComparisonOperator("GREATER");
        /// <summary>
        /// Constant GREATER_OR_EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GREATER_OR_EQUAL = new ComparisonOperator("GREATER_OR_EQUAL");
        /// <summary>
        /// Constant LESS for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LESS = new ComparisonOperator("LESS");
        /// <summary>
        /// Constant LESS_OR_EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LESS_OR_EQUAL = new ComparisonOperator("LESS_OR_EQUAL");
        /// <summary>
        /// Constant NOT_EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NOT_EQUAL = new ComparisonOperator("NOT_EQUAL");

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
    /// Constants used for properties of type CustomerActionName.
    /// </summary>
    public class CustomerActionName : ConstantClass
    {

        /// <summary>
        /// Constant ACKNOWLEDGE for CustomerActionName
        /// </summary>
        public static readonly CustomerActionName ACKNOWLEDGE = new CustomerActionName("ACKNOWLEDGE");
        /// <summary>
        /// Constant DISABLE for CustomerActionName
        /// </summary>
        public static readonly CustomerActionName DISABLE = new CustomerActionName("DISABLE");
        /// <summary>
        /// Constant ENABLE for CustomerActionName
        /// </summary>
        public static readonly CustomerActionName ENABLE = new CustomerActionName("ENABLE");
        /// <summary>
        /// Constant RESET for CustomerActionName
        /// </summary>
        public static readonly CustomerActionName RESET = new CustomerActionName("RESET");
        /// <summary>
        /// Constant SNOOZE for CustomerActionName
        /// </summary>
        public static readonly CustomerActionName SNOOZE = new CustomerActionName("SNOOZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomerActionName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomerActionName FindValue(string value)
        {
            return FindValue<CustomerActionName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomerActionName(string value)
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
        /// Constant InternalFailureException for ErrorCode
        /// </summary>
        public static readonly ErrorCode InternalFailureException = new ErrorCode("InternalFailureException");
        /// <summary>
        /// Constant InvalidRequestException for ErrorCode
        /// </summary>
        public static readonly ErrorCode InvalidRequestException = new ErrorCode("InvalidRequestException");
        /// <summary>
        /// Constant ResourceNotFoundException for ErrorCode
        /// </summary>
        public static readonly ErrorCode ResourceNotFoundException = new ErrorCode("ResourceNotFoundException");
        /// <summary>
        /// Constant ServiceUnavailableException for ErrorCode
        /// </summary>
        public static readonly ErrorCode ServiceUnavailableException = new ErrorCode("ServiceUnavailableException");
        /// <summary>
        /// Constant ThrottlingException for ErrorCode
        /// </summary>
        public static readonly ErrorCode ThrottlingException = new ErrorCode("ThrottlingException");

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
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant STATE_CHANGE for EventType
        /// </summary>
        public static readonly EventType STATE_CHANGE = new EventType("STATE_CHANGE");

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


    /// <summary>
    /// Constants used for properties of type TriggerType.
    /// </summary>
    public class TriggerType : ConstantClass
    {

        /// <summary>
        /// Constant SNOOZE_TIMEOUT for TriggerType
        /// </summary>
        public static readonly TriggerType SNOOZE_TIMEOUT = new TriggerType("SNOOZE_TIMEOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriggerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriggerType FindValue(string value)
        {
            return FindValue<TriggerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriggerType(string value)
        {
            return FindValue(value);
        }
    }

}