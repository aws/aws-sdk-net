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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFlowAlias operation.
    /// Deletes an alias of a flow.
    /// </summary>
    public partial class DeleteFlowAliasRequest : AmazonBedrockAgentRequest
    {
        private string _aliasIdentifier;
        private string _flowIdentifier;

        /// <summary>
        /// Gets and sets the property AliasIdentifier. 
        /// <para>
        /// The unique identifier of the alias to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AliasIdentifier
        {
            get { return this._aliasIdentifier; }
            set { this._aliasIdentifier = value; }
        }

        // Check to see if AliasIdentifier property is set
        internal bool IsSetAliasIdentifier()
        {
            return this._aliasIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FlowIdentifier. 
        /// <para>
        /// The unique identifier of the flow that the alias belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowIdentifier
        {
            get { return this._flowIdentifier; }
            set { this._flowIdentifier = value; }
        }

        // Check to see if FlowIdentifier property is set
        internal bool IsSetFlowIdentifier()
        {
            return this._flowIdentifier != null;
        }

    }
}