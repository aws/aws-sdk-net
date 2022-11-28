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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudWatchLogs
{

    /// <summary>
    /// Constants used for properties of type DataProtectionStatus.
    /// </summary>
    public class DataProtectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for DataProtectionStatus
        /// </summary>
        public static readonly DataProtectionStatus ACTIVATED = new DataProtectionStatus("ACTIVATED");
        /// <summary>
        /// Constant ARCHIVED for DataProtectionStatus
        /// </summary>
        public static readonly DataProtectionStatus ARCHIVED = new DataProtectionStatus("ARCHIVED");
        /// <summary>
        /// Constant DELETED for DataProtectionStatus
        /// </summary>
        public static readonly DataProtectionStatus DELETED = new DataProtectionStatus("DELETED");
        /// <summary>
        /// Constant DISABLED for DataProtectionStatus
        /// </summary>
        public static readonly DataProtectionStatus DISABLED = new DataProtectionStatus("DISABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataProtectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataProtectionStatus FindValue(string value)
        {
            return FindValue<DataProtectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataProtectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Distribution.
    /// </summary>
    public class Distribution : ConstantClass
    {

        /// <summary>
        /// Constant ByLogStream for Distribution
        /// </summary>
        public static readonly Distribution ByLogStream = new Distribution("ByLogStream");
        /// <summary>
        /// Constant Random for Distribution
        /// </summary>
        public static readonly Distribution Random = new Distribution("Random");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Distribution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Distribution FindValue(string value)
        {
            return FindValue<Distribution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Distribution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportTaskStatusCode.
    /// </summary>
    public class ExportTaskStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ExportTaskStatusCode
        /// </summary>
        public static readonly ExportTaskStatusCode CANCELLED = new ExportTaskStatusCode("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for ExportTaskStatusCode
        /// </summary>
        public static readonly ExportTaskStatusCode COMPLETED = new ExportTaskStatusCode("COMPLETED");
        /// <summary>
        /// Constant FAILED for ExportTaskStatusCode
        /// </summary>
        public static readonly ExportTaskStatusCode FAILED = new ExportTaskStatusCode("FAILED");
        /// <summary>
        /// Constant PENDING for ExportTaskStatusCode
        /// </summary>
        public static readonly ExportTaskStatusCode PENDING = new ExportTaskStatusCode("PENDING");
        /// <summary>
        /// Constant PENDING_CANCEL for ExportTaskStatusCode
        /// </summary>
        public static readonly ExportTaskStatusCode PENDING_CANCEL = new ExportTaskStatusCode("PENDING_CANCEL");
        /// <summary>
        /// Constant RUNNING for ExportTaskStatusCode
        /// </summary>
        public static readonly ExportTaskStatusCode RUNNING = new ExportTaskStatusCode("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportTaskStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportTaskStatusCode FindValue(string value)
        {
            return FindValue<ExportTaskStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportTaskStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderBy.
    /// </summary>
    public class OrderBy : ConstantClass
    {

        /// <summary>
        /// Constant LastEventTime for OrderBy
        /// </summary>
        public static readonly OrderBy LastEventTime = new OrderBy("LastEventTime");
        /// <summary>
        /// Constant LogStreamName for OrderBy
        /// </summary>
        public static readonly OrderBy LogStreamName = new OrderBy("LogStreamName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderBy FindValue(string value)
        {
            return FindValue<OrderBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderBy(string value)
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
        /// Constant Cancelled for QueryStatus
        /// </summary>
        public static readonly QueryStatus Cancelled = new QueryStatus("Cancelled");
        /// <summary>
        /// Constant Complete for QueryStatus
        /// </summary>
        public static readonly QueryStatus Complete = new QueryStatus("Complete");
        /// <summary>
        /// Constant Failed for QueryStatus
        /// </summary>
        public static readonly QueryStatus Failed = new QueryStatus("Failed");
        /// <summary>
        /// Constant Running for QueryStatus
        /// </summary>
        public static readonly QueryStatus Running = new QueryStatus("Running");
        /// <summary>
        /// Constant Scheduled for QueryStatus
        /// </summary>
        public static readonly QueryStatus Scheduled = new QueryStatus("Scheduled");
        /// <summary>
        /// Constant Timeout for QueryStatus
        /// </summary>
        public static readonly QueryStatus Timeout = new QueryStatus("Timeout");
        /// <summary>
        /// Constant Unknown for QueryStatus
        /// </summary>
        public static readonly QueryStatus Unknown = new QueryStatus("Unknown");

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
    /// Constants used for properties of type StandardUnit.
    /// </summary>
    public class StandardUnit : ConstantClass
    {

        /// <summary>
        /// Constant Bits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Bits = new StandardUnit("Bits");
        /// <summary>
        /// Constant BitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit BitsSecond = new StandardUnit("Bits/Second");
        /// <summary>
        /// Constant Bytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Bytes = new StandardUnit("Bytes");
        /// <summary>
        /// Constant BytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit BytesSecond = new StandardUnit("Bytes/Second");
        /// <summary>
        /// Constant Count for StandardUnit
        /// </summary>
        public static readonly StandardUnit Count = new StandardUnit("Count");
        /// <summary>
        /// Constant CountSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit CountSecond = new StandardUnit("Count/Second");
        /// <summary>
        /// Constant Gigabits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Gigabits = new StandardUnit("Gigabits");
        /// <summary>
        /// Constant GigabitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit GigabitsSecond = new StandardUnit("Gigabits/Second");
        /// <summary>
        /// Constant Gigabytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Gigabytes = new StandardUnit("Gigabytes");
        /// <summary>
        /// Constant GigabytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit GigabytesSecond = new StandardUnit("Gigabytes/Second");
        /// <summary>
        /// Constant Kilobits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Kilobits = new StandardUnit("Kilobits");
        /// <summary>
        /// Constant KilobitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit KilobitsSecond = new StandardUnit("Kilobits/Second");
        /// <summary>
        /// Constant Kilobytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Kilobytes = new StandardUnit("Kilobytes");
        /// <summary>
        /// Constant KilobytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit KilobytesSecond = new StandardUnit("Kilobytes/Second");
        /// <summary>
        /// Constant Megabits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Megabits = new StandardUnit("Megabits");
        /// <summary>
        /// Constant MegabitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit MegabitsSecond = new StandardUnit("Megabits/Second");
        /// <summary>
        /// Constant Megabytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Megabytes = new StandardUnit("Megabytes");
        /// <summary>
        /// Constant MegabytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit MegabytesSecond = new StandardUnit("Megabytes/Second");
        /// <summary>
        /// Constant Microseconds for StandardUnit
        /// </summary>
        public static readonly StandardUnit Microseconds = new StandardUnit("Microseconds");
        /// <summary>
        /// Constant Milliseconds for StandardUnit
        /// </summary>
        public static readonly StandardUnit Milliseconds = new StandardUnit("Milliseconds");
        /// <summary>
        /// Constant None for StandardUnit
        /// </summary>
        public static readonly StandardUnit None = new StandardUnit("None");
        /// <summary>
        /// Constant Percent for StandardUnit
        /// </summary>
        public static readonly StandardUnit Percent = new StandardUnit("Percent");
        /// <summary>
        /// Constant Seconds for StandardUnit
        /// </summary>
        public static readonly StandardUnit Seconds = new StandardUnit("Seconds");
        /// <summary>
        /// Constant Terabits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Terabits = new StandardUnit("Terabits");
        /// <summary>
        /// Constant TerabitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit TerabitsSecond = new StandardUnit("Terabits/Second");
        /// <summary>
        /// Constant Terabytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Terabytes = new StandardUnit("Terabytes");
        /// <summary>
        /// Constant TerabytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit TerabytesSecond = new StandardUnit("Terabytes/Second");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StandardUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandardUnit FindValue(string value)
        {
            return FindValue<StandardUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StandardUnit(string value)
        {
            return FindValue(value);
        }
    }

}