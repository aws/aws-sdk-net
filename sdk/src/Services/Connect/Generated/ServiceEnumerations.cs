/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Connect
{

    /// <summary>
    /// Constants used for properties of type Channel.
    /// </summary>
    public class Channel : ConstantClass
    {

        /// <summary>
        /// Constant VOICE for Channel
        /// </summary>
        public static readonly Channel VOICE = new Channel("VOICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Channel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Channel FindValue(string value)
        {
            return FindValue<Channel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Channel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Comparison.
    /// </summary>
    public class Comparison : ConstantClass
    {

        /// <summary>
        /// Constant LT for Comparison
        /// </summary>
        public static readonly Comparison LT = new Comparison("LT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Comparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Comparison FindValue(string value)
        {
            return FindValue<Comparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Comparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CurrentMetricName.
    /// </summary>
    public class CurrentMetricName : ConstantClass
    {

        /// <summary>
        /// Constant AGENTS_AFTER_CONTACT_WORK for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_AFTER_CONTACT_WORK = new CurrentMetricName("AGENTS_AFTER_CONTACT_WORK");
        /// <summary>
        /// Constant AGENTS_AVAILABLE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_AVAILABLE = new CurrentMetricName("AGENTS_AVAILABLE");
        /// <summary>
        /// Constant AGENTS_ERROR for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_ERROR = new CurrentMetricName("AGENTS_ERROR");
        /// <summary>
        /// Constant AGENTS_NON_PRODUCTIVE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_NON_PRODUCTIVE = new CurrentMetricName("AGENTS_NON_PRODUCTIVE");
        /// <summary>
        /// Constant AGENTS_ON_CALL for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_ON_CALL = new CurrentMetricName("AGENTS_ON_CALL");
        /// <summary>
        /// Constant AGENTS_ONLINE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_ONLINE = new CurrentMetricName("AGENTS_ONLINE");
        /// <summary>
        /// Constant AGENTS_STAFFED for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_STAFFED = new CurrentMetricName("AGENTS_STAFFED");
        /// <summary>
        /// Constant CONTACTS_IN_QUEUE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName CONTACTS_IN_QUEUE = new CurrentMetricName("CONTACTS_IN_QUEUE");
        /// <summary>
        /// Constant CONTACTS_SCHEDULED for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName CONTACTS_SCHEDULED = new CurrentMetricName("CONTACTS_SCHEDULED");
        /// <summary>
        /// Constant OLDEST_CONTACT_AGE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName OLDEST_CONTACT_AGE = new CurrentMetricName("OLDEST_CONTACT_AGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CurrentMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CurrentMetricName FindValue(string value)
        {
            return FindValue<CurrentMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CurrentMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Grouping.
    /// </summary>
    public class Grouping : ConstantClass
    {

        /// <summary>
        /// Constant CHANNEL for Grouping
        /// </summary>
        public static readonly Grouping CHANNEL = new Grouping("CHANNEL");
        /// <summary>
        /// Constant QUEUE for Grouping
        /// </summary>
        public static readonly Grouping QUEUE = new Grouping("QUEUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Grouping(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Grouping FindValue(string value)
        {
            return FindValue<Grouping>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Grouping(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HistoricalMetricName.
    /// </summary>
    public class HistoricalMetricName : ConstantClass
    {

        /// <summary>
        /// Constant ABANDON_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName ABANDON_TIME = new HistoricalMetricName("ABANDON_TIME");
        /// <summary>
        /// Constant AFTER_CONTACT_WORK_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName AFTER_CONTACT_WORK_TIME = new HistoricalMetricName("AFTER_CONTACT_WORK_TIME");
        /// <summary>
        /// Constant API_CONTACTS_HANDLED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName API_CONTACTS_HANDLED = new HistoricalMetricName("API_CONTACTS_HANDLED");
        /// <summary>
        /// Constant CALLBACK_CONTACTS_HANDLED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CALLBACK_CONTACTS_HANDLED = new HistoricalMetricName("CALLBACK_CONTACTS_HANDLED");
        /// <summary>
        /// Constant CONTACTS_ABANDONED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_ABANDONED = new HistoricalMetricName("CONTACTS_ABANDONED");
        /// <summary>
        /// Constant CONTACTS_AGENT_HUNG_UP_FIRST for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_AGENT_HUNG_UP_FIRST = new HistoricalMetricName("CONTACTS_AGENT_HUNG_UP_FIRST");
        /// <summary>
        /// Constant CONTACTS_CONSULTED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_CONSULTED = new HistoricalMetricName("CONTACTS_CONSULTED");
        /// <summary>
        /// Constant CONTACTS_HANDLED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_HANDLED = new HistoricalMetricName("CONTACTS_HANDLED");
        /// <summary>
        /// Constant CONTACTS_HANDLED_INCOMING for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_HANDLED_INCOMING = new HistoricalMetricName("CONTACTS_HANDLED_INCOMING");
        /// <summary>
        /// Constant CONTACTS_HANDLED_OUTBOUND for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_HANDLED_OUTBOUND = new HistoricalMetricName("CONTACTS_HANDLED_OUTBOUND");
        /// <summary>
        /// Constant CONTACTS_HOLD_ABANDONS for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_HOLD_ABANDONS = new HistoricalMetricName("CONTACTS_HOLD_ABANDONS");
        /// <summary>
        /// Constant CONTACTS_MISSED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_MISSED = new HistoricalMetricName("CONTACTS_MISSED");
        /// <summary>
        /// Constant CONTACTS_QUEUED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_QUEUED = new HistoricalMetricName("CONTACTS_QUEUED");
        /// <summary>
        /// Constant CONTACTS_TRANSFERRED_IN for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_TRANSFERRED_IN = new HistoricalMetricName("CONTACTS_TRANSFERRED_IN");
        /// <summary>
        /// Constant CONTACTS_TRANSFERRED_IN_FROM_QUEUE for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_TRANSFERRED_IN_FROM_QUEUE = new HistoricalMetricName("CONTACTS_TRANSFERRED_IN_FROM_QUEUE");
        /// <summary>
        /// Constant CONTACTS_TRANSFERRED_OUT for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_TRANSFERRED_OUT = new HistoricalMetricName("CONTACTS_TRANSFERRED_OUT");
        /// <summary>
        /// Constant CONTACTS_TRANSFERRED_OUT_FROM_QUEUE for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_TRANSFERRED_OUT_FROM_QUEUE = new HistoricalMetricName("CONTACTS_TRANSFERRED_OUT_FROM_QUEUE");
        /// <summary>
        /// Constant HANDLE_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName HANDLE_TIME = new HistoricalMetricName("HANDLE_TIME");
        /// <summary>
        /// Constant HOLD_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName HOLD_TIME = new HistoricalMetricName("HOLD_TIME");
        /// <summary>
        /// Constant INTERACTION_AND_HOLD_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName INTERACTION_AND_HOLD_TIME = new HistoricalMetricName("INTERACTION_AND_HOLD_TIME");
        /// <summary>
        /// Constant INTERACTION_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName INTERACTION_TIME = new HistoricalMetricName("INTERACTION_TIME");
        /// <summary>
        /// Constant OCCUPANCY for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName OCCUPANCY = new HistoricalMetricName("OCCUPANCY");
        /// <summary>
        /// Constant QUEUE_ANSWER_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName QUEUE_ANSWER_TIME = new HistoricalMetricName("QUEUE_ANSWER_TIME");
        /// <summary>
        /// Constant QUEUED_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName QUEUED_TIME = new HistoricalMetricName("QUEUED_TIME");
        /// <summary>
        /// Constant SERVICE_LEVEL for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName SERVICE_LEVEL = new HistoricalMetricName("SERVICE_LEVEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HistoricalMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HistoricalMetricName FindValue(string value)
        {
            return FindValue<HistoricalMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HistoricalMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneType.
    /// </summary>
    public class PhoneType : ConstantClass
    {

        /// <summary>
        /// Constant DESK_PHONE for PhoneType
        /// </summary>
        public static readonly PhoneType DESK_PHONE = new PhoneType("DESK_PHONE");
        /// <summary>
        /// Constant SOFT_PHONE for PhoneType
        /// </summary>
        public static readonly PhoneType SOFT_PHONE = new PhoneType("SOFT_PHONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneType FindValue(string value)
        {
            return FindValue<PhoneType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Statistic.
    /// </summary>
    public class Statistic : ConstantClass
    {

        /// <summary>
        /// Constant AVG for Statistic
        /// </summary>
        public static readonly Statistic AVG = new Statistic("AVG");
        /// <summary>
        /// Constant MAX for Statistic
        /// </summary>
        public static readonly Statistic MAX = new Statistic("MAX");
        /// <summary>
        /// Constant SUM for Statistic
        /// </summary>
        public static readonly Statistic SUM = new Statistic("SUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Statistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Statistic FindValue(string value)
        {
            return FindValue<Statistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Statistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Unit.
    /// </summary>
    public class Unit : ConstantClass
    {

        /// <summary>
        /// Constant COUNT for Unit
        /// </summary>
        public static readonly Unit COUNT = new Unit("COUNT");
        /// <summary>
        /// Constant PERCENT for Unit
        /// </summary>
        public static readonly Unit PERCENT = new Unit("PERCENT");
        /// <summary>
        /// Constant SECONDS for Unit
        /// </summary>
        public static readonly Unit SECONDS = new Unit("SECONDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Unit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Unit FindValue(string value)
        {
            return FindValue<Unit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Unit(string value)
        {
            return FindValue(value);
        }
    }

}