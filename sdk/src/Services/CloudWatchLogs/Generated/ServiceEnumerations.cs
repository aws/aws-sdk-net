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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudWatchLogs
{

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

}