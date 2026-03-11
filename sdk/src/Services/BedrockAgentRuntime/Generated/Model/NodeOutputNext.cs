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
    /// Represents the next node that receives output data.
    /// </summary>
    public partial class NodeOutputNext
    {
        private string _inputFieldName;
        private string _nodeName;

        /// <summary>
        /// Gets and sets the property InputFieldName. 
        /// <para>
        /// The name of the input field in the next node that receives the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputFieldName
        {
            get { return this._inputFieldName; }
            set { this._inputFieldName = value; }
        }

        // Check to see if InputFieldName property is set
        internal bool IsSetInputFieldName()
        {
            return this._inputFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the next node that receives the output data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NodeName
        {
            get { return this._nodeName; }
            set { this._nodeName = value; }
        }

        // Check to see if NodeName property is set
        internal bool IsSetNodeName()
        {
            return this._nodeName != null;
        }

    }
}