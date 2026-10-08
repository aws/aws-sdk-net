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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Recurring time-of-day window in UTC. The service derives an EventBridge expression
    /// anchored at startAfter and a flexible-window width from the interval to startBefore.
    /// A startBefore earlier than startAfter wraps past midnight.
    /// </summary>
    public partial class TimeRangeSchedule
    {
        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// How the window recurs
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Recurrence Recurrence { get; set; }

        /// <summary>
        /// Checks to see if the Recurrence property is set.
        /// </summary>
        internal bool IsSetRecurrence() => this.Recurrence != null;

        /// <summary>
        /// Gets and sets the property StartAfter. 
        /// <para>
        /// Earliest time of day the trigger may fire
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string StartAfter { get; set; }

        /// <summary>
        /// Checks to see if the StartAfter property is set.
        /// </summary>
        internal bool IsSetStartAfter() => this.StartAfter != null;

        /// <summary>
        /// Gets and sets the property StartBefore. 
        /// <para>
        /// Latest time of day the trigger may fire
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string StartBefore { get; set; }

        /// <summary>
        /// Checks to see if the StartBefore property is set.
        /// </summary>
        internal bool IsSetStartBefore() => this.StartBefore != null;
    }
}
