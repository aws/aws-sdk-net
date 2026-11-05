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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        public ContactState AgentContactState { get; set; }

        /// <summary>
        /// Checks to see if the AgentContactState property is set.
        /// </summary>
        internal bool IsSetAgentContactState() => this.AgentContactState != null;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel of the contact.
        /// </para>
        /// </summary>
        public Channel Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property ConnectedToAgentTimestamp. 
        /// <para>
        /// The time at which the contact was connected to an agent.
        /// </para>
        /// </summary>
        public DateTime? ConnectedToAgentTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedToAgentTimestamp property is set.
        /// </summary>
        internal bool IsSetConnectedToAgentTimestamp() => this.ConnectedToAgentTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Connect Customer. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property InitiationMethod. 
        /// <para>
        /// How the contact was initiated.
        /// </para>
        /// </summary>
        public ContactInitiationMethod InitiationMethod { get; set; }

        /// <summary>
        /// Checks to see if the InitiationMethod property is set.
        /// </summary>
        internal bool IsSetInitiationMethod() => this.InitiationMethod != null;

        /// <summary>
        /// Gets and sets the property Queue.
        /// </summary>
        public QueueReference Queue { get; set; }

        /// <summary>
        /// Checks to see if the Queue property is set.
        /// </summary>
        internal bool IsSetQueue() => this.Queue != null;

        /// <summary>
        /// Gets and sets the property StateStartTimestamp. 
        /// <para>
        /// The epoch timestamp when the contact state started.
        /// </para>
        /// </summary>
        public DateTime? StateStartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StateStartTimestamp property is set.
        /// </summary>
        internal bool IsSetStateStartTimestamp() => this.StateStartTimestamp.HasValue;
    }
}
