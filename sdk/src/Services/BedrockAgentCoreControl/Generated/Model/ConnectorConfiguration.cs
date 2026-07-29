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
    /// Configuration for a single tool within a connector.
    /// </summary>
    public partial class ConnectorConfiguration
    {
        private string _description;
        private string _name;
        private List<ConnectorParameterOverride> _parameterOverrides = AWSConfigs.InitializeCollections ? new List<ConnectorParameterOverride>() : null;
        private Amazon.Runtime.Documents.Document _parameterValues;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An agent-facing description override for this tool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The tool or operation name (for example, <c>retrieve</c> or <c>webSearch</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
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
        /// Gets and sets the property ParameterOverrides. 
        /// <para>
        /// Parameters to expose to the agent at runtime, with optional description overrides.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectorParameterOverride> ParameterOverrides
        {
            get { return this._parameterOverrides; }
            set { this._parameterOverrides = value; }
        }

        // Check to see if ParameterOverrides property is set
        internal bool IsSetParameterOverrides()
        {
            return this._parameterOverrides != null && (this._parameterOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParameterValues. 
        /// <para>
        /// Parameters to set as fixed or default values when provisioning this tool.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ParameterValues
        {
            get { return this._parameterValues; }
            set { this._parameterValues = value; }
        }

        // Check to see if ParameterValues property is set
        internal bool IsSetParameterValues()
        {
            return !this._parameterValues.IsNull();
        }

    }
}