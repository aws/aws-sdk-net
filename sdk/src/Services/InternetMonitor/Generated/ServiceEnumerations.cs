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