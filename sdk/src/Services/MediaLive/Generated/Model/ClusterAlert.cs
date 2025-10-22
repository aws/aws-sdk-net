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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// An alert on a cluster
    /// </summary>
    public partial class ClusterAlert
    {
        private string _alertType;
        private string _channelId;
        private DateTime? _clearedTimestamp;
        private string _id;
        private string _message;
        private string _nodeId;
        private DateTime? _setTimestamp;
        private ClusterAlertState _state;

        /// <summary>
        /// Gets and sets the property AlertType. The type of the alert
        /// </summary>
        public string AlertType
        {
            get { return this._alertType; }
            set { this._alertType = value; }
        }

        // Check to see if AlertType property is set
        internal bool IsSetAlertType()
        {
            return this._alertType != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelId. The ID of the channel this alert is associated
        /// with
        /// </summary>
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property ClearedTimestamp. The time when the alert was cleared
        /// </summary>
        public DateTime ClearedTimestamp
        {
            get { return this._clearedTimestamp.GetValueOrDefault(); }
            set { this._clearedTimestamp = value; }
        }

        // Check to see if ClearedTimestamp property is set
        internal bool IsSetClearedTimestamp()
        {
            return this._clearedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. The further subtype of this alert
        /// </summary>
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
        /// Gets and sets the property Message. The user facing alert message which can have more
        /// context
        /// </summary>
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
        /// Gets and sets the property NodeId. The ID of the node this alert is associated with
        /// </summary>
        public string NodeId
        {
            get { return this._nodeId; }
            set { this._nodeId = value; }
        }

        // Check to see if NodeId property is set
        internal bool IsSetNodeId()
        {
            return this._nodeId != null;
        }

        /// <summary>
        /// Gets and sets the property SetTimestamp. The time when the alert was set
        /// </summary>
        public DateTime SetTimestamp
        {
            get { return this._setTimestamp.GetValueOrDefault(); }
            set { this._setTimestamp = value; }
        }

        // Check to see if SetTimestamp property is set
        internal bool IsSetSetTimestamp()
        {
            return this._setTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. The state of the alert
        /// </summary>
        public ClusterAlertState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}