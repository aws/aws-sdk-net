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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Input for an agent collaborator. The input can be text or an action invocation result.
    /// </summary>
    public partial class AgentCollaboratorInputPayload
    {
        private ReturnControlResults _returnControlResults;
        private string _text;
        private PayloadType _type;

        /// <summary>
        /// Gets and sets the property ReturnControlResults. 
        /// <para>
        /// An action invocation result.
        /// </para>
        /// </summary>
        public ReturnControlResults ReturnControlResults
        {
            get { return this._returnControlResults; }
            set { this._returnControlResults = value; }
        }

        // Check to see if ReturnControlResults property is set
        internal bool IsSetReturnControlResults()
        {
            return this._returnControlResults != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// Input text.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The input type.
        /// </para>
        /// </summary>
        public PayloadType Type
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