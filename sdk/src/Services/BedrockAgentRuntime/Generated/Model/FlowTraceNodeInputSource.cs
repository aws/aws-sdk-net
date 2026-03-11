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
    /// Represents the source of input data for a flow trace node field.
    /// </summary>
    public partial class FlowTraceNodeInputSource
    {
        private string _expression;
        private string _nodeName;
        private string _outputFieldName;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression used to extract data from the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the source node that provides the input data.
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

        /// <summary>
        /// Gets and sets the property OutputFieldName. 
        /// <para>
        /// The name of the output field from the source node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputFieldName
        {
            get { return this._outputFieldName; }
            set { this._outputFieldName = value; }
        }

        // Check to see if OutputFieldName property is set
        internal bool IsSetOutputFieldName()
        {
            return this._outputFieldName != null;
        }

    }
}