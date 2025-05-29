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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MWAA
{

    /// <summary>
    /// Constants used for properties of type EndpointManagement.
    /// </summary>
    public class EndpointManagement : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOMER for EndpointManagement
        /// </summary>
        public static readonly EndpointManagement CUSTOMER = new EndpointManagement("CUSTOMER");
        /// <summary>
        /// Constant SERVICE for EndpointManagement
        /// </summary>
        public static readonly EndpointManagement SERVICE = new EndpointManagement("SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointManagement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointManagement FindValue(string value)
        {
            return FindValue<EndpointManagement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointManagement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentStatus.
    /// </summary>
    public class EnvironmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus AVAILABLE = new EnvironmentStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATE_FAILED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATE_FAILED = new EnvironmentStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATING = new EnvironmentStatus("CREATING");
        /// <summary>
        /// Constant CREATING_SNAPSHOT for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATING_SNAPSHOT = new EnvironmentStatus("CREATING_SNAPSHOT");
        /// <summary>
        /// Constant DELETED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETED = new EnvironmentStatus("DELETED");
        /// <summary>
        /// Constant DELETING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETING = new EnvironmentStatus("DELETING");
        /// <summary>
        /// Constant MAINTENANCE for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus MAINTENANCE = new EnvironmentStatus("MAINTENANCE");
        /// <summary>
        /// Constant PENDING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus PENDING = new EnvironmentStatus("PENDING");
        /// <summary>
        /// Constant ROLLING_BACK for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus ROLLING_BACK = new EnvironmentStatus("ROLLING_BACK");
        /// <summary>
        /// Constant UNAVAILABLE for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus UNAVAILABLE = new EnvironmentStatus("UNAVAILABLE");
        /// <summary>
        /// Constant UPDATE_FAILED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus UPDATE_FAILED = new EnvironmentStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus UPDATING = new EnvironmentStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentStatus FindValue(string value)
        {
            return FindValue<EnvironmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoggingLevel.
    /// </summary>
    public class LoggingLevel : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel CRITICAL = new LoggingLevel("CRITICAL");
        /// <summary>
        /// Constant DEBUG for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel DEBUG = new LoggingLevel("DEBUG");
        /// <summary>
        /// Constant ERROR for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel ERROR = new LoggingLevel("ERROR");
        /// <summary>
        /// Constant INFO for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel INFO = new LoggingLevel("INFO");
        /// <summary>
        /// Constant WARNING for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel WARNING = new LoggingLevel("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoggingLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggingLevel FindValue(string value)
        {
            return FindValue<LoggingLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggingLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RestApiMethod.
    /// </summary>
    public class RestApiMethod : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for RestApiMethod
        /// </summary>
        public static readonly RestApiMethod DELETE = new RestApiMethod("DELETE");
        /// <summary>
        /// Constant GET for RestApiMethod
        /// </summary>
        public static readonly RestApiMethod GET = new RestApiMethod("GET");
        /// <summary>
        /// Constant PATCH for RestApiMethod
        /// </summary>
        public static readonly RestApiMethod PATCH = new RestApiMethod("PATCH");
        /// <summary>
        /// Constant POST for RestApiMethod
        /// </summary>
        public static readonly RestApiMethod POST = new RestApiMethod("POST");
        /// <summary>
        /// Constant PUT for RestApiMethod
        /// </summary>
        public static readonly RestApiMethod PUT = new RestApiMethod("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RestApiMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RestApiMethod FindValue(string value)
        {
            return FindValue<RestApiMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RestApiMethod(string value)
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
        /// Constant Bits for Unit
        /// </summary>
        public static readonly Unit Bits = new Unit("Bits");
        /// <summary>
        /// Constant BitsSecond for Unit
        /// </summary>
        public static readonly Unit BitsSecond = new Unit("Bits/Second");
        /// <summary>
        /// Constant Bytes for Unit
        /// </summary>
        public static readonly Unit Bytes = new Unit("Bytes");
        /// <summary>
        /// Constant BytesSecond for Unit
        /// </summary>
        public static readonly Unit BytesSecond = new Unit("Bytes/Second");
        /// <summary>
        /// Constant Count for Unit
        /// </summary>
        public static readonly Unit Count = new Unit("Count");
        /// <summary>
        /// Constant CountSecond for Unit
        /// </summary>
        public static readonly Unit CountSecond = new Unit("Count/Second");
        /// <summary>
        /// Constant Gigabits for Unit
        /// </summary>
        public static readonly Unit Gigabits = new Unit("Gigabits");
        /// <summary>
        /// Constant GigabitsSecond for Unit
        /// </summary>
        public static readonly Unit GigabitsSecond = new Unit("Gigabits/Second");
        /// <summary>
        /// Constant Gigabytes for Unit
        /// </summary>
        public static readonly Unit Gigabytes = new Unit("Gigabytes");
        /// <summary>
        /// Constant GigabytesSecond for Unit
        /// </summary>
        public static readonly Unit GigabytesSecond = new Unit("Gigabytes/Second");
        /// <summary>
        /// Constant Kilobits for Unit
        /// </summary>
        public static readonly Unit Kilobits = new Unit("Kilobits");
        /// <summary>
        /// Constant KilobitsSecond for Unit
        /// </summary>
        public static readonly Unit KilobitsSecond = new Unit("Kilobits/Second");
        /// <summary>
        /// Constant Kilobytes for Unit
        /// </summary>
        public static readonly Unit Kilobytes = new Unit("Kilobytes");
        /// <summary>
        /// Constant KilobytesSecond for Unit
        /// </summary>
        public static readonly Unit KilobytesSecond = new Unit("Kilobytes/Second");
        /// <summary>
        /// Constant Megabits for Unit
        /// </summary>
        public static readonly Unit Megabits = new Unit("Megabits");
        /// <summary>
        /// Constant MegabitsSecond for Unit
        /// </summary>
        public static readonly Unit MegabitsSecond = new Unit("Megabits/Second");
        /// <summary>
        /// Constant Megabytes for Unit
        /// </summary>
        public static readonly Unit Megabytes = new Unit("Megabytes");
        /// <summary>
        /// Constant MegabytesSecond for Unit
        /// </summary>
        public static readonly Unit MegabytesSecond = new Unit("Megabytes/Second");
        /// <summary>
        /// Constant Microseconds for Unit
        /// </summary>
        public static readonly Unit Microseconds = new Unit("Microseconds");
        /// <summary>
        /// Constant Milliseconds for Unit
        /// </summary>
        public static readonly Unit Milliseconds = new Unit("Milliseconds");
        /// <summary>
        /// Constant None for Unit
        /// </summary>
        public static readonly Unit None = new Unit("None");
        /// <summary>
        /// Constant Percent for Unit
        /// </summary>
        public static readonly Unit Percent = new Unit("Percent");
        /// <summary>
        /// Constant Seconds for Unit
        /// </summary>
        public static readonly Unit Seconds = new Unit("Seconds");
        /// <summary>
        /// Constant Terabits for Unit
        /// </summary>
        public static readonly Unit Terabits = new Unit("Terabits");
        /// <summary>
        /// Constant TerabitsSecond for Unit
        /// </summary>
        public static readonly Unit TerabitsSecond = new Unit("Terabits/Second");
        /// <summary>
        /// Constant Terabytes for Unit
        /// </summary>
        public static readonly Unit Terabytes = new Unit("Terabytes");
        /// <summary>
        /// Constant TerabytesSecond for Unit
        /// </summary>
        public static readonly Unit TerabytesSecond = new Unit("Terabytes/Second");

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


    /// <summary>
    /// Constants used for properties of type UpdateStatus.
    /// </summary>
    public class UpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus FAILED = new UpdateStatus("FAILED");
        /// <summary>
        /// Constant PENDING for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus PENDING = new UpdateStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus SUCCESS = new UpdateStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateStatus FindValue(string value)
        {
            return FindValue<UpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WebserverAccessMode.
    /// </summary>
    public class WebserverAccessMode : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE_ONLY for WebserverAccessMode
        /// </summary>
        public static readonly WebserverAccessMode PRIVATE_ONLY = new WebserverAccessMode("PRIVATE_ONLY");
        /// <summary>
        /// Constant PUBLIC_ONLY for WebserverAccessMode
        /// </summary>
        public static readonly WebserverAccessMode PUBLIC_ONLY = new WebserverAccessMode("PUBLIC_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebserverAccessMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebserverAccessMode FindValue(string value)
        {
            return FindValue<WebserverAccessMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebserverAccessMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkerReplacementStrategy.
    /// </summary>
    public class WorkerReplacementStrategy : ConstantClass
    {

        /// <summary>
        /// Constant FORCED for WorkerReplacementStrategy
        /// </summary>
        public static readonly WorkerReplacementStrategy FORCED = new WorkerReplacementStrategy("FORCED");
        /// <summary>
        /// Constant GRACEFUL for WorkerReplacementStrategy
        /// </summary>
        public static readonly WorkerReplacementStrategy GRACEFUL = new WorkerReplacementStrategy("GRACEFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkerReplacementStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkerReplacementStrategy FindValue(string value)
        {
            return FindValue<WorkerReplacementStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkerReplacementStrategy(string value)
        {
            return FindValue(value);
        }
    }

}