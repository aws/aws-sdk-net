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
    /// Details about a missing required output in a node.
    /// </summary>
    public partial class MissingNodeOutputFlowValidationDetails
    {
        private string _node;
        private string _output;

        /// <summary>
        /// Gets and sets the property Node. 
        /// <para>
        /// The name of the node missing the required output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Node
        {
            get { return this._node; }
            set { this._node = value; }
        }

        // Check to see if Node property is set
        internal bool IsSetNode()
        {
            return this._node != null;
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// The name of the missing output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

    }
}