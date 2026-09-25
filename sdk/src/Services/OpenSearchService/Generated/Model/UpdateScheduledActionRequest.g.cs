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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateScheduledAction operation. Reschedules a
    /// planned domain configuration change for a later time. This change can be a scheduled
    /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">service
    /// software update</a> or a <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html#auto-tune-types">blue/green
    /// Auto-Tune enhancement</a>.
    /// </summary>
    public partial class UpdateScheduledActionRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ActionID. 
        /// <para>
        /// The unique identifier of the action to reschedule. To retrieve this ID, send a <a
        /// href="https://docs.aws.amazon.com/opensearch-service/latest/APIReference/API_ListScheduledActions.html">ListScheduledActions</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ActionID { get; set; }

        /// <summary>
        /// Checks to see if the ActionID property is set.
        /// </summary>
        internal bool IsSetActionID() => this.ActionID != null;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of action to reschedule. Can be one of <c>SERVICE_SOFTWARE_UPDATE</c>, <c>JVM_HEAP_SIZE_TUNING</c>,
        /// or <c>JVM_YOUNG_GEN_TUNING</c>. To retrieve this value, send a <a href="https://docs.aws.amazon.com/opensearch-service/latest/APIReference/API_ListScheduledActions.html">ListScheduledActions</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionType ActionType { get; set; }

        /// <summary>
        /// Checks to see if the ActionType property is set.
        /// </summary>
        internal bool IsSetActionType() => this.ActionType != null;

        /// <summary>
        /// Gets and sets the property DesiredStartTime. 
        /// <para>
        /// The time to implement the change, in Coordinated Universal Time (UTC). Only specify
        /// this parameter if you set <c>ScheduleAt</c> to <c>TIMESTAMP</c>.
        /// </para>
        /// </summary>
        public long? DesiredStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DesiredStartTime property is set.
        /// </summary>
        internal bool IsSetDesiredStartTime() => this.DesiredStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain to reschedule an action for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ScheduleAt. 
        /// <para>
        /// When to schedule the action.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NOW</c> - Immediately schedules the update to happen in the current hour if there's
        /// capacity available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TIMESTAMP</c> - Lets you specify a custom date and time to apply the update. If
        /// you specify this value, you must also provide a value for <c>DesiredStartTime</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OFF_PEAK_WINDOW</c> - Marks the action to be picked up during an upcoming off-peak
        /// window. There's no guarantee that the change will be implemented during the next immediate
        /// window. Depending on capacity, it might happen in subsequent days.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduleAt ScheduleAt { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleAt property is set.
        /// </summary>
        internal bool IsSetScheduleAt() => this.ScheduleAt != null;
    }
}
