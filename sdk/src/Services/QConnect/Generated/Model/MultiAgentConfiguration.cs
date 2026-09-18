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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// A union that configures a single collaborator agent for an Orchestration AI Agent,
    /// as either a delegate or a handoff.
    /// </summary>
    public partial class MultiAgentConfiguration
    {
        private DelegateAgentConfiguration _delegateAgentConfiguration;
        private HandoffAgentConfiguration _handoffAgentConfiguration;

        /// <summary>
        /// Gets and sets the property DelegateAgentConfiguration. 
        /// <para>
        /// Configures the collaborator agent as a delegate that the Orchestration AI Agent invokes
        /// while retaining control of the conversation.
        /// </para>
        /// </summary>
        public DelegateAgentConfiguration DelegateAgentConfiguration
        {
            get { return this._delegateAgentConfiguration; }
            set { this._delegateAgentConfiguration = value; }
        }

        // Check to see if DelegateAgentConfiguration property is set
        internal bool IsSetDelegateAgentConfiguration()
        {
            return this._delegateAgentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property HandoffAgentConfiguration. 
        /// <para>
        /// Configures the collaborator agent as a handoff target that the Orchestration AI Agent
        /// transfers control of the conversation to.
        /// </para>
        /// </summary>
        public HandoffAgentConfiguration HandoffAgentConfiguration
        {
            get { return this._handoffAgentConfiguration; }
            set { this._handoffAgentConfiguration = value; }
        }

        // Check to see if HandoffAgentConfiguration property is set
        internal bool IsSetHandoffAgentConfiguration()
        {
            return this._handoffAgentConfiguration != null;
        }

    }
}