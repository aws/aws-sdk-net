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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateScheduledAction operation.
    /// Reschedules a planned domain configuration change for a later time. This change can
    /// be a scheduled <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">service
    /// software update</a> or a <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html#auto-tune-types">blue/green
    /// Auto-Tune enhancement</a>.
    /// </summary>
    public partial class UpdateScheduledActionRequest : AmazonOpenSearchServiceRequest
    {
        private string _actionID;
        private ActionType _actionType;
        private long? _desiredStartTime;
        private string _domainName;
        private ScheduleAt _scheduleAt;

        /// <summary>
        /// Gets and sets the property ActionID. 
        /// <para>
        /// The unique identifier of the action to reschedule. To retrieve this ID, send a <a
        /// href="https://docs.aws.amazon.com/opensearch-service/latest/APIReference/API_ListScheduledActions.html">ListScheduledActions</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActionID
        {
            get { return this._actionID; }
            set { this._actionID = value; }
        }

        // Check to see if ActionID property is set
        internal bool IsSetActionID()
        {
            return this._actionID != null;
        }

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of action to reschedule. Can be one of <code>SERVICE_SOFTWARE_UPDATE</code>,
        /// <code>JVM_HEAP_SIZE_TUNING</code>, or <code>JVM_YOUNG_GEN_TUNING</code>. To retrieve
        /// this value, send a <a href="https://docs.aws.amazon.com/opensearch-service/latest/APIReference/API_ListScheduledActions.html">ListScheduledActions</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionType ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredStartTime. 
        /// <para>
        /// The time to implement the change, in Coordinated Universal Time (UTC). Only specify
        /// this parameter if you set <code>ScheduleAt</code> to <code>TIMESTAMP</code>.
        /// </para>
        /// </summary>
        public long DesiredStartTime
        {
            get { return this._desiredStartTime.GetValueOrDefault(); }
            set { this._desiredStartTime = value; }
        }

        // Check to see if DesiredStartTime property is set
        internal bool IsSetDesiredStartTime()
        {
            return this._desiredStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain to reschedule an action for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=28)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleAt. 
        /// <para>
        /// When to schedule the action.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NOW</code> - Immediately schedules the update to happen in the current hour
        /// if there's capacity available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TIMESTAMP</code> - Lets you specify a custom date and time to apply the update.
        /// If you specify this value, you must also provide a value for <code>DesiredStartTime</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OFF_PEAK_WINDOW</code> - Marks the action to be picked up during an upcoming
        /// off-peak window. There's no guarantee that the change will be implemented during the
        /// next immediate window. Depending on capacity, it might happen in subsequent days.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduleAt ScheduleAt
        {
            get { return this._scheduleAt; }
            set { this._scheduleAt = value; }
        }

        // Check to see if ScheduleAt property is set
        internal bool IsSetScheduleAt()
        {
            return this._scheduleAt != null;
        }

    }
}