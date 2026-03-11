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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AWSHealth
{

    /// <summary>
    /// Constants used for properties of type EntityStatusCode.
    /// </summary>
    public class EntityStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant IMPAIRED for EntityStatusCode
        /// </summary>
        public static readonly EntityStatusCode IMPAIRED = new EntityStatusCode("IMPAIRED");
        /// <summary>
        /// Constant PENDING for EntityStatusCode
        /// </summary>
        public static readonly EntityStatusCode PENDING = new EntityStatusCode("PENDING");
        /// <summary>
        /// Constant RESOLVED for EntityStatusCode
        /// </summary>
        public static readonly EntityStatusCode RESOLVED = new EntityStatusCode("RESOLVED");
        /// <summary>
        /// Constant UNIMPAIRED for EntityStatusCode
        /// </summary>
        public static readonly EntityStatusCode UNIMPAIRED = new EntityStatusCode("UNIMPAIRED");
        /// <summary>
        /// Constant UNKNOWN for EntityStatusCode
        /// </summary>
        public static readonly EntityStatusCode UNKNOWN = new EntityStatusCode("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityStatusCode FindValue(string value)
        {
            return FindValue<EntityStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventActionability.
    /// </summary>
    public class EventActionability : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_MAY_BE_REQUIRED for EventActionability
        /// </summary>
        public static readonly EventActionability ACTION_MAY_BE_REQUIRED = new EventActionability("ACTION_MAY_BE_REQUIRED");
        /// <summary>
        /// Constant ACTION_REQUIRED for EventActionability
        /// </summary>
        public static readonly EventActionability ACTION_REQUIRED = new EventActionability("ACTION_REQUIRED");
        /// <summary>
        /// Constant INFORMATIONAL for EventActionability
        /// </summary>
        public static readonly EventActionability INFORMATIONAL = new EventActionability("INFORMATIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventActionability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventActionability FindValue(string value)
        {
            return FindValue<EventActionability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventActionability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventAggregateField.
    /// </summary>
    public class EventAggregateField : ConstantClass
    {

        /// <summary>
        /// Constant EventTypeCategory for EventAggregateField
        /// </summary>
        public static readonly EventAggregateField EventTypeCategory = new EventAggregateField("eventTypeCategory");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventAggregateField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventAggregateField FindValue(string value)
        {
            return FindValue<EventAggregateField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventAggregateField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventPersona.
    /// </summary>
    public class EventPersona : ConstantClass
    {

        /// <summary>
        /// Constant BILLING for EventPersona
        /// </summary>
        public static readonly EventPersona BILLING = new EventPersona("BILLING");
        /// <summary>
        /// Constant OPERATIONS for EventPersona
        /// </summary>
        public static readonly EventPersona OPERATIONS = new EventPersona("OPERATIONS");
        /// <summary>
        /// Constant SECURITY for EventPersona
        /// </summary>
        public static readonly EventPersona SECURITY = new EventPersona("SECURITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventPersona(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventPersona FindValue(string value)
        {
            return FindValue<EventPersona>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventPersona(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventScopeCode.
    /// </summary>
    public class EventScopeCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_SPECIFIC for EventScopeCode
        /// </summary>
        public static readonly EventScopeCode ACCOUNT_SPECIFIC = new EventScopeCode("ACCOUNT_SPECIFIC");
        /// <summary>
        /// Constant NONE for EventScopeCode
        /// </summary>
        public static readonly EventScopeCode NONE = new EventScopeCode("NONE");
        /// <summary>
        /// Constant PUBLIC for EventScopeCode
        /// </summary>
        public static readonly EventScopeCode PUBLIC = new EventScopeCode("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventScopeCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventScopeCode FindValue(string value)
        {
            return FindValue<EventScopeCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventScopeCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventStatusCode.
    /// </summary>
    public class EventStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Closed for EventStatusCode
        /// </summary>
        public static readonly EventStatusCode Closed = new EventStatusCode("closed");
        /// <summary>
        /// Constant Open for EventStatusCode
        /// </summary>
        public static readonly EventStatusCode Open = new EventStatusCode("open");
        /// <summary>
        /// Constant Upcoming for EventStatusCode
        /// </summary>
        public static readonly EventStatusCode Upcoming = new EventStatusCode("upcoming");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventStatusCode FindValue(string value)
        {
            return FindValue<EventStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventTypeActionability.
    /// </summary>
    public class EventTypeActionability : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_MAY_BE_REQUIRED for EventTypeActionability
        /// </summary>
        public static readonly EventTypeActionability ACTION_MAY_BE_REQUIRED = new EventTypeActionability("ACTION_MAY_BE_REQUIRED");
        /// <summary>
        /// Constant ACTION_REQUIRED for EventTypeActionability
        /// </summary>
        public static readonly EventTypeActionability ACTION_REQUIRED = new EventTypeActionability("ACTION_REQUIRED");
        /// <summary>
        /// Constant INFORMATIONAL for EventTypeActionability
        /// </summary>
        public static readonly EventTypeActionability INFORMATIONAL = new EventTypeActionability("INFORMATIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventTypeActionability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventTypeActionability FindValue(string value)
        {
            return FindValue<EventTypeActionability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventTypeActionability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventTypeCategory.
    /// </summary>
    public class EventTypeCategory : ConstantClass
    {

        /// <summary>
        /// Constant AccountNotification for EventTypeCategory
        /// </summary>
        public static readonly EventTypeCategory AccountNotification = new EventTypeCategory("accountNotification");
        /// <summary>
        /// Constant Investigation for EventTypeCategory
        /// </summary>
        public static readonly EventTypeCategory Investigation = new EventTypeCategory("investigation");
        /// <summary>
        /// Constant Issue for EventTypeCategory
        /// </summary>
        public static readonly EventTypeCategory Issue = new EventTypeCategory("issue");
        /// <summary>
        /// Constant ScheduledChange for EventTypeCategory
        /// </summary>
        public static readonly EventTypeCategory ScheduledChange = new EventTypeCategory("scheduledChange");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventTypeCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventTypeCategory FindValue(string value)
        {
            return FindValue<EventTypeCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventTypeCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventTypePersona.
    /// </summary>
    public class EventTypePersona : ConstantClass
    {

        /// <summary>
        /// Constant BILLING for EventTypePersona
        /// </summary>
        public static readonly EventTypePersona BILLING = new EventTypePersona("BILLING");
        /// <summary>
        /// Constant OPERATIONS for EventTypePersona
        /// </summary>
        public static readonly EventTypePersona OPERATIONS = new EventTypePersona("OPERATIONS");
        /// <summary>
        /// Constant SECURITY for EventTypePersona
        /// </summary>
        public static readonly EventTypePersona SECURITY = new EventTypePersona("SECURITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventTypePersona(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventTypePersona FindValue(string value)
        {
            return FindValue<EventTypePersona>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventTypePersona(string value)
        {
            return FindValue(value);
        }
    }

}