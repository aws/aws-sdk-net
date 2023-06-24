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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// An object representing failback related information of the Recovery Instance.
    /// </summary>
    public partial class RecoveryInstanceFailback
    {
        private string _agentLastSeenByServiceDateTime;
        private string _elapsedReplicationDuration;
        private string _failbackClientID;
        private string _failbackClientLastSeenByServiceDateTime;
        private string _failbackInitiationTime;
        private string _failbackJobID;
        private FailbackLaunchType _failbackLaunchType;
        private bool? _failbackToOriginalServer;
        private string _firstByteDateTime;
        private FailbackState _state;

        /// <summary>
        /// Gets and sets the property AgentLastSeenByServiceDateTime. 
        /// <para>
        /// The date and time the agent on the Recovery Instance was last seen by the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string AgentLastSeenByServiceDateTime
        {
            get { return this._agentLastSeenByServiceDateTime; }
            set { this._agentLastSeenByServiceDateTime = value; }
        }

        // Check to see if AgentLastSeenByServiceDateTime property is set
        internal bool IsSetAgentLastSeenByServiceDateTime()
        {
            return this._agentLastSeenByServiceDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property ElapsedReplicationDuration. 
        /// <para>
        /// The amount of time that the Recovery Instance has been replicating for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string ElapsedReplicationDuration
        {
            get { return this._elapsedReplicationDuration; }
            set { this._elapsedReplicationDuration = value; }
        }

        // Check to see if ElapsedReplicationDuration property is set
        internal bool IsSetElapsedReplicationDuration()
        {
            return this._elapsedReplicationDuration != null;
        }

        /// <summary>
        /// Gets and sets the property FailbackClientID. 
        /// <para>
        /// The ID of the failback client that this Recovery Instance is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string FailbackClientID
        {
            get { return this._failbackClientID; }
            set { this._failbackClientID = value; }
        }

        // Check to see if FailbackClientID property is set
        internal bool IsSetFailbackClientID()
        {
            return this._failbackClientID != null;
        }

        /// <summary>
        /// Gets and sets the property FailbackClientLastSeenByServiceDateTime. 
        /// <para>
        /// The date and time that the failback client was last seen by the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string FailbackClientLastSeenByServiceDateTime
        {
            get { return this._failbackClientLastSeenByServiceDateTime; }
            set { this._failbackClientLastSeenByServiceDateTime = value; }
        }

        // Check to see if FailbackClientLastSeenByServiceDateTime property is set
        internal bool IsSetFailbackClientLastSeenByServiceDateTime()
        {
            return this._failbackClientLastSeenByServiceDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property FailbackInitiationTime. 
        /// <para>
        /// The date and time that the failback initiation started.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string FailbackInitiationTime
        {
            get { return this._failbackInitiationTime; }
            set { this._failbackInitiationTime = value; }
        }

        // Check to see if FailbackInitiationTime property is set
        internal bool IsSetFailbackInitiationTime()
        {
            return this._failbackInitiationTime != null;
        }

        /// <summary>
        /// Gets and sets the property FailbackJobID. 
        /// <para>
        /// The Job ID of the last failback log for this Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=24, Max=24)]
        public string FailbackJobID
        {
            get { return this._failbackJobID; }
            set { this._failbackJobID = value; }
        }

        // Check to see if FailbackJobID property is set
        internal bool IsSetFailbackJobID()
        {
            return this._failbackJobID != null;
        }

        /// <summary>
        /// Gets and sets the property FailbackLaunchType. 
        /// <para>
        /// The launch type (Recovery / Drill) of the last launch for the failback replication
        /// of this recovery instance.
        /// </para>
        /// </summary>
        public FailbackLaunchType FailbackLaunchType
        {
            get { return this._failbackLaunchType; }
            set { this._failbackLaunchType = value; }
        }

        // Check to see if FailbackLaunchType property is set
        internal bool IsSetFailbackLaunchType()
        {
            return this._failbackLaunchType != null;
        }

        /// <summary>
        /// Gets and sets the property FailbackToOriginalServer. 
        /// <para>
        /// Whether we are failing back to the original Source Server for this Recovery Instance.
        /// </para>
        /// </summary>
        public bool FailbackToOriginalServer
        {
            get { return this._failbackToOriginalServer.GetValueOrDefault(); }
            set { this._failbackToOriginalServer = value; }
        }

        // Check to see if FailbackToOriginalServer property is set
        internal bool IsSetFailbackToOriginalServer()
        {
            return this._failbackToOriginalServer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstByteDateTime. 
        /// <para>
        /// The date and time of the first byte that was replicated from the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string FirstByteDateTime
        {
            get { return this._firstByteDateTime; }
            set { this._firstByteDateTime = value; }
        }

        // Check to see if FirstByteDateTime property is set
        internal bool IsSetFirstByteDateTime()
        {
            return this._firstByteDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the failback process that this Recovery Instance is in.
        /// </para>
        /// </summary>
        public FailbackState State
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