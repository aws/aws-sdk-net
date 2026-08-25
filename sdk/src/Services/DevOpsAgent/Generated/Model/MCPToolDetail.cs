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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// An MCP tool together with its access categorization.
    /// </summary>
    public partial class MCPToolDetail
    {
        private string _name;
        private ToolClassification _toolClassification;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the MCP tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property ToolClassification. 
        /// <para>
        /// The access categorization of the MCP tool.
        /// </para>
        /// </summary>
        public ToolClassification ToolClassification
        {
            get { return this._toolClassification; }
            set { this._toolClassification = value; }
        }

        // Check to see if ToolClassification property is set
        internal bool IsSetToolClassification()
        {
            return this._toolClassification != null;
        }

    }
}