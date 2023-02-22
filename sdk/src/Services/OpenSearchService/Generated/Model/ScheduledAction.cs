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
    /// Information about a scheduled configuration change for an OpenSearch Service domain.
    /// This actions can be a <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">service
    /// software update</a> or a <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html#auto-tune-types">blue/green
    /// Auto-Tune enhancement</a>.
    /// </summary>
    public partial class ScheduledAction
    {
        private bool? _cancellable;
        private string _description;
        private string _id;
        private bool? _mandatory;
        private ScheduledBy _scheduledBy;
        private long? _scheduledTime;
        private ActionSeverity _severity;
        private ActionStatus _status;
        private ActionType _type;

        /// <summary>
        /// Gets and sets the property Cancellable. 
        /// <para>
        /// Whether or not the scheduled action is cancellable.
        /// </para>
        /// </summary>
        public bool Cancellable
        {
            get { return this._cancellable.GetValueOrDefault(); }
            set { this._cancellable = value; }
        }

        // Check to see if Cancellable property is set
        internal bool IsSetCancellable()
        {
            return this._cancellable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the action to be taken.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the scheduled action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Mandatory. 
        /// <para>
        /// Whether the action is required or optional.
        /// </para>
        /// </summary>
        public bool Mandatory
        {
            get { return this._mandatory.GetValueOrDefault(); }
            set { this._mandatory = value; }
        }

        // Check to see if Mandatory property is set
        internal bool IsSetMandatory()
        {
            return this._mandatory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduledBy. 
        /// <para>
        /// Whether the action was scheduled manually (<code>CUSTOMER</code>, or by OpenSearch
        /// Service automatically (<code>SYSTEM</code>).
        /// </para>
        /// </summary>
        public ScheduledBy ScheduledBy
        {
            get { return this._scheduledBy; }
            set { this._scheduledBy = value; }
        }

        // Check to see if ScheduledBy property is set
        internal bool IsSetScheduledBy()
        {
            return this._scheduledBy != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledTime. 
        /// <para>
        /// The time when the change is scheduled to happen.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long ScheduledTime
        {
            get { return this._scheduledTime.GetValueOrDefault(); }
            set { this._scheduledTime = value; }
        }

        // Check to see if ScheduledTime property is set
        internal bool IsSetScheduledTime()
        {
            return this._scheduledTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionSeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the scheduled action.
        /// </para>
        /// </summary>
        public ActionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of action that will be taken on the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}