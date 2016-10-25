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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Object representing a Replication Run
    /// </summary>
    public partial class ReplicationRun
    {
        private string _amiId;
        private DateTime? _completedTime;
        private string _description;
        private string _replicationRunId;
        private DateTime? _scheduledStartTime;
        private ReplicationRunState _state;
        private string _statusMessage;
        private ReplicationRunType _type;

        /// <summary>
        /// Gets and sets the property AmiId.
        /// </summary>
        public string AmiId
        {
            get { return this._amiId; }
            set { this._amiId = value; }
        }

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this._amiId != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedTime.
        /// </summary>
        public DateTime CompletedTime
        {
            get { return this._completedTime.GetValueOrDefault(); }
            set { this._completedTime = value; }
        }

        // Check to see if CompletedTime property is set
        internal bool IsSetCompletedTime()
        {
            return this._completedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description.
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
        /// Gets and sets the property ReplicationRunId.
        /// </summary>
        public string ReplicationRunId
        {
            get { return this._replicationRunId; }
            set { this._replicationRunId = value; }
        }

        // Check to see if ReplicationRunId property is set
        internal bool IsSetReplicationRunId()
        {
            return this._replicationRunId != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledStartTime.
        /// </summary>
        public DateTime ScheduledStartTime
        {
            get { return this._scheduledStartTime.GetValueOrDefault(); }
            set { this._scheduledStartTime = value; }
        }

        // Check to see if ScheduledStartTime property is set
        internal bool IsSetScheduledStartTime()
        {
            return this._scheduledStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public ReplicationRunState State
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
        /// Gets and sets the property StatusMessage.
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public ReplicationRunType Type
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