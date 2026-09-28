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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Summary of an EventSource, as returned by ListEventSources.
    /// </summary>
    public partial class EventSourceSummary
    {
        private DateTime? _creationTime;
        private string _eventBusArn;
        private string _eventSourceAccountId;
        private string _eventSourceArn;
        private DateTime? _lastModifiedTime;
        private string _name;
        private bool? _revoked;
        private EventSourceState _state;
        private EventSourceType _type;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the EventSource was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventBusArn.
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string EventBusArn
        {
            get { return this._eventBusArn; }
            set { this._eventBusArn = value; }
        }

        // Check to see if EventBusArn property is set
        internal bool IsSetEventBusArn()
        {
            return this._eventBusArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventSourceAccountId.
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string EventSourceAccountId
        {
            get { return this._eventSourceAccountId; }
            set { this._eventSourceAccountId = value; }
        }

        // Check to see if EventSourceAccountId property is set
        internal bool IsSetEventSourceAccountId()
        {
            return this._eventSourceAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property EventSourceArn.
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string EventSourceArn
        {
            get { return this._eventSourceArn; }
            set { this._eventSourceArn = value; }
        }

        // Check to see if EventSourceArn property is set
        internal bool IsSetEventSourceArn()
        {
            return this._eventSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time the EventSource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Revoked. 
        /// <para>
        /// True when the bus owner has withdrawn this EventSource. Present only when true, so
        /// a bus owner listing EventSources sees at a glance which ones they revoked. See DescribeEventSourceResponse$Revoked.
        /// </para>
        /// </summary>
        public bool? Revoked
        {
            get { return this._revoked; }
            set { this._revoked = value; }
        }

        // Check to see if Revoked property is set
        internal bool IsSetRevoked()
        {
            return this._revoked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public EventSourceState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public EventSourceType Type
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