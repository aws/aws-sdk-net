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
        /// Default Constructor
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

        public static implicit operator OrderBy(string value)
        {
            return FindValue(value);
        }
    }

}