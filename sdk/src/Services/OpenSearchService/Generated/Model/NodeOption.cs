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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Configuration settings for defining the node type within a cluster.
    /// </summary>
    public partial class NodeOption
    {
        private NodeConfig _nodeConfig;
        private NodeOptionsNodeType _nodeType;

        /// <summary>
        /// Gets and sets the property NodeConfig. 
        /// <para>
        /// Configuration options for defining the setup of any node type.
        /// </para>
        /// </summary>
        public NodeConfig NodeConfig
        {
            get { return this._nodeConfig; }
            set { this._nodeConfig = value; }
        }

        // Check to see if NodeConfig property is set
        internal bool IsSetNodeConfig()
        {
            return this._nodeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// Defines the type of node, such as coordinating nodes.
        /// </para>
        /// </summary>
        public NodeOptionsNodeType NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

    }
}