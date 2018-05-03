/*
 * Copyright 2010-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Class that captures the CSM Api Call Monitoring Events
    /// for the entire SDK call. This is processed once.
    /// </summary>
    public class MonitoringAPICallEvent : MonitoringAPICall
    {
        public MonitoringAPICallEvent(IRequestContext requestContext)
            :base(requestContext)
        {
            Type = CSMType.ApiCall.ToString();
        }

        /// <summary>
        /// Contains the total number of attempts that were made 
        /// by the service client to fulfill this request before succeeding or failing
        /// </summary>
        public int AttemptCount { get; internal set; }

        /// <summary>
        /// Contains the elapsed time, in milliseconds, 
        /// between when the Api Call was begun and when a 
        /// final response or error is manifested to the caller
        /// </summary>
        public long Latency { get; internal set; }
    }
}
