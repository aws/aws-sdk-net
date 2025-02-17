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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.InternetMonitor
{

    /// <summary>
    /// Constants used for properties of type HealthEventImpactType.
    /// </summary>
    public class HealthEventImpactType : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABILITY for HealthEventImpactType
        /// </summary>
        public static readonly HealthEventImpactType AVAILABILITY = new HealthEventImpactType("AVAILABILITY");
        /// <summary>
        /// Constant LOCAL_AVAILABILITY for HealthEventImpactType
        /// </summary>
        public static readonly HealthEventImpactType LOCAL_AVAILABILITY = new HealthEventImpactType("LOCAL_AVAILABILITY");
        /// <summary>
        /// Constant LOCAL_PERFORMANCE for HealthEventImpactType
        /// </summary>
        public static readonly HealthEventImpactType LOCAL_PERFORMANCE = new HealthEventImpactType("LOCAL_PERFORMANCE");
        /// <summary>
        /// Constant PERFORMANCE for HealthEventImpactType
        /// </summary>
        public static readonly HealthEventImpactType PERFORMANCE = new HealthEventImpactType("PERFORMANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthEventImpactType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthEventImpactType FindValue(string value)
        {
            return FindValue<HealthEventImpactType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthEventImpactType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HealthEventStatus.
    /// </summary>
    public class HealthEventStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for HealthEventStatus
        /// </summary>
        public static readonly HealthEventStatus ACTIVE = new HealthEventStatus("ACTIVE");
        /// <summary>
        /// Constant RESOLVED for HealthEventStatus
        /// </summary>
        public static readonly HealthEventStatus RESOLVED = new HealthEventStatus("RESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthEventStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthEventStatus FindValue(string value)
        {
            return FindValue<HealthEventStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthEventStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InternetEventStatus.
    /// </summary>
    public class InternetEventStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for InternetEventStatus
        /// </summary>
        public static readonly InternetEventStatus ACTIVE = new InternetEventStatus("ACTIVE");
        /// <summary>
        /// Constant RESOLVED for InternetEventStatus
        /// </summary>
        public static readonly InternetEventStatus RESOLVED = new InternetEventStatus("RESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InternetEventStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InternetEventStatus FindValue(string value)
        {
            return FindValue<InternetEventStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InternetEventStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InternetEventType.
    /// </summary>
    public class InternetEventType : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABILITY for InternetEventType
        /// </summary>
        public static readonly InternetEventType AVAILABILITY = new InternetEventType("AVAILABILITY");
        /// <summary>
        /// Constant PERFORMANCE for InternetEventType
        /// </summary>
        public static readonly InternetEventType PERFORMANCE = new InternetEventType("PERFORMANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InternetEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InternetEventType FindValue(string value)
        {
            return FindValue<InternetEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InternetEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocalHealthEventsConfigStatus.
    /// </summary>
    public class LocalHealthEventsConfigStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for LocalHealthEventsConfigStatus
        /// </summary>
        public static readonly LocalHealthEventsConfigStatus DISABLED = new LocalHealthEventsConfigStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for LocalHealthEventsConfigStatus
        /// </summary>
        public static readonly LocalHealthEventsConfigStatus ENABLED = new LocalHealthEventsConfigStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocalHealthEventsConfigStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocalHealthEventsConfigStatus FindValue(string value)
        {
            return FindValue<LocalHealthEventsConfigStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocalHealthEventsConfigStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogDeliveryStatus.
    /// </summary>
    public class LogDeliveryStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for LogDeliveryStatus
        /// </summary>
        public static readonly LogDeliveryStatus DISABLED = new LogDeliveryStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for LogDeliveryStatus
        /// </summary>
        public static readonly LogDeliveryStatus ENABLED = new LogDeliveryStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogDeliveryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogDeliveryStatus FindValue(string value)
        {
            return FindValue<LogDeliveryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogDeliveryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitorConfigState.
    /// </summary>
    public class MonitorConfigState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for MonitorConfigState
        /// </summary>
        public static readonly MonitorConfigState ACTIVE = new MonitorConfigState("ACTIVE");
        /// <summary>
        /// Constant ERROR for MonitorConfigState
        /// </summary>
        public static readonly MonitorConfigState ERROR = new MonitorConfigState("ERROR");
        /// <summary>
        /// Constant INACTIVE for MonitorConfigState
        /// </summary>
        public static readonly MonitorConfigState INACTIVE = new MonitorConfigState("INACTIVE");
        /// <summary>
        /// Constant PENDING for MonitorConfigState
        /// </summary>
        public static readonly MonitorConfigState PENDING = new MonitorConfigState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitorConfigState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitorConfigState FindValue(string value)
        {
            return FindValue<MonitorConfigState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitorConfigState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitorProcessingStatusCode.
    /// </summary>
    public class MonitorProcessingStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant COLLECTING_DATA for MonitorProcessingStatusCode
        /// </summary>
        public static readonly MonitorProcessingStatusCode COLLECTING_DATA = new MonitorProcessingStatusCode("COLLECTING_DATA");
        /// <summary>
        /// Constant FAULT_ACCESS_CLOUDWATCH for MonitorProcessingStatusCode
        /// </summary>
        public static readonly MonitorProcessingStatusCode FAULT_ACCESS_CLOUDWATCH = new MonitorProcessingStatusCode("FAULT_ACCESS_CLOUDWATCH");
        /// <summary>
        /// Constant FAULT_SERVICE for MonitorProcessingStatusCode
        /// </summary>
        public static readonly MonitorProcessingStatusCode FAULT_SERVICE = new MonitorProcessingStatusCode("FAULT_SERVICE");
        /// <summary>
        /// Constant INACTIVE for MonitorProcessingStatusCode
        /// </summary>
        public static readonly MonitorProcessingStatusCode INACTIVE = new MonitorProcessingStatusCode("INACTIVE");
        /// <summary>
        /// Constant INSUFFICIENT_DATA for MonitorProcessingStatusCode
        /// </summary>
        public static readonly MonitorProcessingStatusCode INSUFFICIENT_DATA = new MonitorProcessingStatusCode("INSUFFICIENT_DATA");
        /// <summary>
        /// Constant OK for MonitorProcessingStatusCode
        /// </summary>
        public static readonly MonitorProcessingStatusCode OK = new MonitorProcessingStatusCode("OK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitorProcessingStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitorProcessingStatusCode FindValue(string value)
        {
            return FindValue<MonitorProcessingStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitorProcessingStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operator.
    /// </summary>
    public class Operator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for Operator
        /// </summary>
        public static readonly Operator EQUALS = new Operator("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for Operator
        /// </summary>
        public static readonly Operator NOT_EQUALS = new Operator("NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operator FindValue(string value)
        {
            return FindValue<Operator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryStatus.
    /// </summary>
    public class QueryStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for QueryStatus
        /// </summary>
        public static readonly QueryStatus CANCELED = new QueryStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for QueryStatus
        /// </summary>
        public static readonly QueryStatus FAILED = new QueryStatus("FAILED");
        /// <summary>
        /// Constant QUEUED for QueryStatus
        /// </summary>
        public static readonly QueryStatus QUEUED = new QueryStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for QueryStatus
        /// </summary>
        public static readonly QueryStatus RUNNING = new QueryStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for QueryStatus
        /// </summary>
        public static readonly QueryStatus SUCCEEDED = new QueryStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryStatus FindValue(string value)
        {
            return FindValue<QueryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryType.
    /// </summary>
    public class QueryType : ConstantClass
    {

        /// <summary>
        /// Constant MEASUREMENTS for QueryType
        /// </summary>
        public static readonly QueryType MEASUREMENTS = new QueryType("MEASUREMENTS");
        /// <summary>
        /// Constant OVERALL_TRAFFIC_SUGGESTIONS for QueryType
        /// </summary>
        public static readonly QueryType OVERALL_TRAFFIC_SUGGESTIONS = new QueryType("OVERALL_TRAFFIC_SUGGESTIONS");
        /// <summary>
        /// Constant OVERALL_TRAFFIC_SUGGESTIONS_DETAILS for QueryType
        /// </summary>
        public static readonly QueryType OVERALL_TRAFFIC_SUGGESTIONS_DETAILS = new QueryType("OVERALL_TRAFFIC_SUGGESTIONS_DETAILS");
        /// <summary>
        /// Constant ROUTING_SUGGESTIONS for QueryType
        /// </summary>
        public static readonly QueryType ROUTING_SUGGESTIONS = new QueryType("ROUTING_SUGGESTIONS");
        /// <summary>
        /// Constant TOP_LOCATION_DETAILS for QueryType
        /// </summary>
        public static readonly QueryType TOP_LOCATION_DETAILS = new QueryType("TOP_LOCATION_DETAILS");
        /// <summary>
        /// Constant TOP_LOCATIONS for QueryType
        /// </summary>
        public static readonly QueryType TOP_LOCATIONS = new QueryType("TOP_LOCATIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryType FindValue(string value)
        {
            return FindValue<QueryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TriangulationEventType.
    /// </summary>
    public class TriangulationEventType : ConstantClass
    {

        /// <summary>
        /// Constant AWS for TriangulationEventType
        /// </summary>
        public static readonly TriangulationEventType AWS = new TriangulationEventType("AWS");
        /// <summary>
        /// Constant Internet for TriangulationEventType
        /// </summary>
        public static readonly TriangulationEventType Internet = new TriangulationEventType("Internet");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriangulationEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriangulationEventType FindValue(string value)
        {
            return FindValue<TriangulationEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriangulationEventType(string value)
        {
            return FindValue(value);
        }
    }

}