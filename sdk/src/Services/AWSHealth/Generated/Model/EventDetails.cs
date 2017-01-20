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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EventDetails
    {
        private Event _event;
        private EventDescription _eventDescription;
        private Dictionary<string, string> _eventMetadata = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public Event Event
        {
            get { return this._event; }
            set { this._event = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this._event != null;
        }

        /// <summary>
        /// Gets and sets the property EventDescription. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public EventDescription EventDescription
        {
            get { return this._eventDescription; }
            set { this._eventDescription = value; }
        }

        // Check to see if EventDescription property is set
        internal bool IsSetEventDescription()
        {
            return this._eventDescription != null;
        }

        /// <summary>
        /// Gets and sets the property EventMetadata. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public Dictionary<string, string> EventMetadata
        {
            get { return this._eventMetadata; }
            set { this._eventMetadata = value; }
        }

        // Check to see if EventMetadata property is set
        internal bool IsSetEventMetadata()
        {
            return this._eventMetadata != null && this._eventMetadata.Count > 0; 
        }

    }
}