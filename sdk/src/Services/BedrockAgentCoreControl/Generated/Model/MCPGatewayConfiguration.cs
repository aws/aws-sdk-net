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
    /// The configuration for a Model Context Protocol (MCP) gateway. This structure defines
    /// how the gateway implements the MCP protocol.
    /// </summary>
    public partial class MCPGatewayConfiguration
    {
        private string _instructions;
        private SearchType _searchType;
        private List<string> _supportedVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Instructions. 
        /// <para>
        /// The instructions for using the Model Context Protocol gateway. These instructions
        /// provide guidance on how to interact with the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Instructions
        {
            get { return this._instructions; }
            set { this._instructions = value; }
        }

        // Check to see if Instructions property is set
        internal bool IsSetInstructions()
        {
            return this._instructions != null;
        }

        /// <summary>
        /// Gets and sets the property SearchType. 
        /// <para>
        /// The search type for the Model Context Protocol gateway. This field specifies how the
        /// gateway handles search operations.
        /// </para>
        /// </summary>
        public SearchType SearchType
        {
            get { return this._searchType; }
            set { this._searchType = value; }
        }

        // Check to see if SearchType property is set
        internal bool IsSetSearchType()
        {
            return this._searchType != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedVersions. 
        /// <para>
        /// The supported versions of the Model Context Protocol. This field specifies which versions
        /// of the protocol the gateway can use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedVersions
        {
            get { return this._supportedVersions; }
            set { this._supportedVersions = value; }
        }

        // Check to see if SupportedVersions property is set
        internal bool IsSetSupportedVersions()
        {
            return this._supportedVersions != null && (this._supportedVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}