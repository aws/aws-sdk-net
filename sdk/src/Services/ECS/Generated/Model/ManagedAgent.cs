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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Details about the managed agent status for the container.
    /// </summary>
    public partial class ManagedAgent
    {
        private DateTime? _lastStartedAt;
        private string _lastStatus;
        private ManagedAgentName _name;
        private string _reason;

        /// <summary>
        /// Gets and sets the property LastStartedAt. 
        /// <para>
        /// The Unix timestamp for the time when the managed agent was last started.
        /// </para>
        /// </summary>
        public DateTime? LastStartedAt
        {
            get { return this._lastStartedAt; }
            set { this._lastStartedAt = value; }
        }

        // Check to see if LastStartedAt property is set
        internal bool IsSetLastStartedAt()
        {
            return this._lastStartedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// The last known status of the managed agent.
        /// </para>
        /// </summary>
        public string LastStatus
        {
            get { return this._lastStatus; }
            set { this._lastStatus = value; }
        }

        // Check to see if LastStatus property is set
        internal bool IsSetLastStatus()
        {
            return this._lastStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed agent. When the execute command feature is turned on, the
        /// managed agent name is <c>ExecuteCommandAgent</c>.
        /// </para>
        /// </summary>
        public ManagedAgentName Name
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for why the managed agent is in the state it is in.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}