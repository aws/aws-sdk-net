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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a core network change event. This can be a change to a segment, attachment,
    /// route, etc.
    /// </summary>
    public partial class CoreNetworkChangeEvent
    {
        private ChangeAction _action;
        private DateTime? _eventTime;
        private string _identifierPath;
        private ChangeStatus _status;
        private ChangeType _type;
        private CoreNetworkChangeEventValues _values;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action taken for the change event.
        /// </para>
        /// </summary>
        public ChangeAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The timestamp for an event change in status.
        /// </para>
        /// </summary>
        public DateTime? EventTime
        {
            get { return this._eventTime; }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentifierPath. 
        /// <para>
        /// Uniquely identifies the path for a change within the changeset. For example, the <c>IdentifierPath</c>
        /// for a core network segment change might be <c>"CORE_NETWORK_SEGMENT/us-east-1/devsegment"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string IdentifierPath
        {
            get { return this._identifierPath; }
            set { this._identifierPath = value; }
        }

        // Check to see if IdentifierPath property is set
        internal bool IsSetIdentifierPath()
        {
            return this._identifierPath != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the core network change event.
        /// </para>
        /// </summary>
        public ChangeStatus Status
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
        /// Describes the type of change event. 
        /// </para>
        /// </summary>
        public ChangeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// Details of the change event.
        /// </para>
        /// </summary>
        public CoreNetworkChangeEventValues Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null;
        }

    }
}