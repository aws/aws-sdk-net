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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A tool definition for a gateway target. This structure defines a tool that the target
    /// exposes through the Model Context Protocol.
    /// </summary>
    public partial class ToolDefinition
    {
        private string _description;
        private SchemaDefinition _inputSchema;
        private string _name;
        private SchemaDefinition _outputSchema;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the tool. This description provides information about the purpose
        /// and usage of the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InputSchema. 
        /// <para>
        /// The input schema for the tool. This schema defines the structure of the input that
        /// the tool accepts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaDefinition InputSchema
        {
            get { return this._inputSchema; }
            set { this._inputSchema = value; }
        }

        // Check to see if InputSchema property is set
        internal bool IsSetInputSchema()
        {
            return this._inputSchema != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the tool. This name identifies the tool in the Model Context Protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
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
        /// Gets and sets the property OutputSchema. 
        /// <para>
        /// The output schema for the tool. This schema defines the structure of the output that
        /// the tool produces.
        /// </para>
        /// </summary>
        public SchemaDefinition OutputSchema
        {
            get { return this._outputSchema; }
            set { this._outputSchema = value; }
        }

        // Check to see if OutputSchema property is set
        internal bool IsSetOutputSchema()
        {
            return this._outputSchema != null;
        }

    }
}