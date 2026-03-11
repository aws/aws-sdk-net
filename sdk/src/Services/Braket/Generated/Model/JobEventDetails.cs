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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Details about the type and time events that occurred related to the Amazon Braket
    /// hybrid job.
    /// </summary>
    public partial class JobEventDetails
    {
        private JobEventType _eventType;
        private string _message;
        private DateTime? _timeOfEvent;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event that occurred related to the Amazon Braket hybrid job.
        /// </para>
        /// </summary>
        public JobEventType EventType
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
        /// Gets and sets the property Message. 
        /// <para>
        /// A message describing the event that occurred related to the Amazon Braket hybrid job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2500)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property TimeOfEvent. 
        /// <para>
        /// The time of the event that occurred related to the Amazon Braket hybrid job.
        /// </para>
        /// </summary>
        public DateTime? TimeOfEvent
        {
            get { return this._timeOfEvent; }
            set { this._timeOfEvent = value; }
        }

        // Check to see if TimeOfEvent property is set
        internal bool IsSetTimeOfEvent()
        {
            return this._timeOfEvent.HasValue; 
        }

    }
}