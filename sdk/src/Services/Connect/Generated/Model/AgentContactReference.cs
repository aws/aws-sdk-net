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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Contact.html">contact</a>
    /// associated to the user.
    /// </summary>
    public partial class AgentContactReference
    {
        private ContactState _agentContactState;
        private Channel _channel;
        private DateTime? _connectedToAgentTimestamp;
        private string _contactId;
        private ContactInitiationMethod _initiationMethod;
        private QueueReference _queue;
        private DateTime? _stateStartTimestamp;

        /// <summary>
        /// Gets and sets the property AgentContactState. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/connect/latest/adminguide/about-contact-states.html">state
        /// of the contact</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When <c>AgentContactState</c> is set to <c>CONNECTED_ONHOLD</c>, <c>StateStartTimestamp</c>
        /// is not changed. Instead, <c>StateStartTimestamp</c> reflects the time the contact
        /// was <c>CONNECTED</c> to the agent.
        /// </para>
        ///  </note>
        /// </summary>
        public ContactState AgentContactState
        {
            get { return this._agentContactState; }
            set { this._agentContactState = value; }
        }

        // Check to see if AgentContactState property is set
        internal bool IsSetAgentContactState()
        {
            return this._agentContactState != null;
        }

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel of the contact.
        /// </para>
        /// </summary>
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectedToAgentTimestamp. 
        /// <para>
        /// The time at which the contact was connected to an agent.
        /// </para>
        /// </summary>
        public DateTime? ConnectedToAgentTimestamp
        {
            get { return this._connectedToAgentTimestamp; }
            set { this._connectedToAgentTimestamp = value; }
        }

        // Check to see if ConnectedToAgentTimestamp property is set
        internal bool IsSetConnectedToAgentTimestamp()
        {
            return this._connectedToAgentTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Amazon Connect. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property InitiationMethod. 
        /// <para>
        /// How the contact was initiated.
        /// </para>
        /// </summary>
        public ContactInitiationMethod InitiationMethod
        {
            get { return this._initiationMethod; }
            set { this._initiationMethod = value; }
        }

        // Check to see if InitiationMethod property is set
        internal bool IsSetInitiationMethod()
        {
            return this._initiationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Queue.
        /// </summary>
        public QueueReference Queue
        {
            get { return this._queue; }
            set { this._queue = value; }
        }

        // Check to see if Queue property is set
        internal bool IsSetQueue()
        {
            return this._queue != null;
        }

        /// <summary>
        /// Gets and sets the property StateStartTimestamp. 
        /// <para>
        /// The epoch timestamp when the contact state started.
        /// </para>
        /// </summary>
        public DateTime? StateStartTimestamp
        {
            get { return this._stateStartTimestamp; }
            set { this._stateStartTimestamp = value; }
        }

        // Check to see if StateStartTimestamp property is set
        internal bool IsSetStateStartTimestamp()
        {
            return this._stateStartTimestamp.HasValue; 
        }

    }
}