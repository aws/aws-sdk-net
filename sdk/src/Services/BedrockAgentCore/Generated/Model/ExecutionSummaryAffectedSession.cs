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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A session associated with an execution summary cluster.
    /// </summary>
    public partial class ExecutionSummaryAffectedSession
    {
        private string _approachTaken;
        private string _finalOutcome;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property ApproachTaken. 
        /// <para>
        /// The approach taken by the agent during this session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApproachTaken
        {
            get { return this._approachTaken; }
            set { this._approachTaken = value; }
        }

        // Check to see if ApproachTaken property is set
        internal bool IsSetApproachTaken()
        {
            return this._approachTaken != null;
        }

        /// <summary>
        /// Gets and sets the property FinalOutcome. 
        /// <para>
        /// The final outcome of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FinalOutcome
        {
            get { return this._finalOutcome; }
            set { this._finalOutcome = value; }
        }

        // Check to see if FinalOutcome property is set
        internal bool IsSetFinalOutcome()
        {
            return this._finalOutcome != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}