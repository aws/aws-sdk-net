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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEventLabel operation.
    /// Updates the specified event with a new label.
    /// </summary>
    public partial class UpdateEventLabelRequest : AmazonFraudDetectorRequest
    {
        private string _assignedLabel;
        private string _eventId;
        private string _eventTypeName;
        private string _labelTimestamp;

        /// <summary>
        /// Gets and sets the property AssignedLabel. 
        /// <para>
        /// The new label to assign to the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AssignedLabel
        {
            get { return this._assignedLabel; }
            set { this._assignedLabel = value; }
        }

        // Check to see if AssignedLabel property is set
        internal bool IsSetAssignedLabel()
        {
            return this._assignedLabel != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The ID of the event associated with the label to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The event type of the event associated with the label to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EventTypeName
        {
            get { return this._eventTypeName; }
            set { this._eventTypeName = value; }
        }

        // Check to see if EventTypeName property is set
        internal bool IsSetEventTypeName()
        {
            return this._eventTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property LabelTimestamp. 
        /// <para>
        /// The timestamp associated with the label. The timestamp must be specified using ISO
        /// 8601 standard in UTC. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=30)]
        public string LabelTimestamp
        {
            get { return this._labelTimestamp; }
            set { this._labelTimestamp = value; }
        }

        // Check to see if LabelTimestamp property is set
        internal bool IsSetLabelTimestamp()
        {
            return this._labelTimestamp != null;
        }

    }
}