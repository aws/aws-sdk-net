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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
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
namespace Amazon.Budgets.Model
{
    /// <summary>
    /// The historical records for a budget action.
    /// </summary>
    public partial class ActionHistory
    {
        private ActionHistoryDetails _actionHistoryDetails;
        private EventType _eventType;
        private ActionStatus _status;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property ActionHistoryDetails. 
        /// <para>
        /// The description of the details for the event. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionHistoryDetails ActionHistoryDetails
        {
            get { return this._actionHistoryDetails; }
            set { this._actionHistoryDetails = value; }
        }

        // Check to see if ActionHistoryDetails property is set
        internal bool IsSetActionHistoryDetails()
        {
            return this._actionHistoryDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// This distinguishes between whether the events are triggered by the user or are generated
        /// by the system. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of action at the time of the event. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Timestamp.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}