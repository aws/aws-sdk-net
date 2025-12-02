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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Configuration settings for <a href="https://docs.aws.amazon.com/lambda/latest/dg/durable-functions.html">durable
    /// functions</a>, including execution timeout and retention period for execution history.
    /// </summary>
    public partial class DurableConfig
    {
        private int? _executionTimeout;
        private int? _retentionPeriodInDays;

        /// <summary>
        /// Gets and sets the property ExecutionTimeout. 
        /// <para>
        /// The maximum time (in seconds) that a durable execution can run before timing out.
        /// This timeout applies to the entire durable execution, not individual function invocations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=31622400)]
        public int ExecutionTimeout
        {
            get { return this._executionTimeout.GetValueOrDefault(); }
            set { this._executionTimeout = value; }
        }

        // Check to see if ExecutionTimeout property is set
        internal bool IsSetExecutionTimeout()
        {
            return this._executionTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriodInDays. 
        /// <para>
        /// The number of days to retain execution history after a durable execution completes.
        /// After this period, execution history is no longer available through the GetDurableExecutionHistory
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=90)]
        public int RetentionPeriodInDays
        {
            get { return this._retentionPeriodInDays.GetValueOrDefault(); }
            set { this._retentionPeriodInDays = value; }
        }

        // Check to see if RetentionPeriodInDays property is set
        internal bool IsSetRetentionPeriodInDays()
        {
            return this._retentionPeriodInDays.HasValue; 
        }

    }
}