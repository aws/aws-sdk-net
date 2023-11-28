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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Trace Part which contains output details for action group or knowledge base or final
    /// response
    /// </summary>
    public partial class Observation
    {
        private ActionGroupInvocationOutput _actionGroupInvocationOutput;
        private FinalResponse _finalResponse;
        private KnowledgeBaseLookupOutput _knowledgeBaseLookupOutput;
        private RepromptResponse _repromptResponse;
        private string _traceId;
        private Type _type;

        /// <summary>
        /// Gets and sets the property ActionGroupInvocationOutput.
        /// </summary>
        public ActionGroupInvocationOutput ActionGroupInvocationOutput
        {
            get { return this._actionGroupInvocationOutput; }
            set { this._actionGroupInvocationOutput = value; }
        }

        // Check to see if ActionGroupInvocationOutput property is set
        internal bool IsSetActionGroupInvocationOutput()
        {
            return this._actionGroupInvocationOutput != null;
        }

        /// <summary>
        /// Gets and sets the property FinalResponse.
        /// </summary>
        public FinalResponse FinalResponse
        {
            get { return this._finalResponse; }
            set { this._finalResponse = value; }
        }

        // Check to see if FinalResponse property is set
        internal bool IsSetFinalResponse()
        {
            return this._finalResponse != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseLookupOutput.
        /// </summary>
        public KnowledgeBaseLookupOutput KnowledgeBaseLookupOutput
        {
            get { return this._knowledgeBaseLookupOutput; }
            set { this._knowledgeBaseLookupOutput = value; }
        }

        // Check to see if KnowledgeBaseLookupOutput property is set
        internal bool IsSetKnowledgeBaseLookupOutput()
        {
            return this._knowledgeBaseLookupOutput != null;
        }

        /// <summary>
        /// Gets and sets the property RepromptResponse.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RepromptResponse RepromptResponse
        {
            get { return this._repromptResponse; }
            set { this._repromptResponse = value; }
        }

        // Check to see if RepromptResponse property is set
        internal bool IsSetRepromptResponse()
        {
            return this._repromptResponse != null;
        }

        /// <summary>
        /// Gets and sets the property TraceId.
        /// </summary>
        [AWSProperty(Min=2, Max=16)]
        public string TraceId
        {
            get { return this._traceId; }
            set { this._traceId = value; }
        }

        // Check to see if TraceId property is set
        internal bool IsSetTraceId()
        {
            return this._traceId != null;
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public Type Type
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