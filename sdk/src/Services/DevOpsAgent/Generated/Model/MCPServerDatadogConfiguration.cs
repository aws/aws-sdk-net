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
    /// Mixin for webhook update support.
    /// </summary>
    public partial class MCPServerDatadogConfiguration
    {
        private List<MCPToolDetail> _enabledElevatedTools = AWSConfigs.InitializeCollections ? new List<MCPToolDetail>() : null;

        /// <summary>
        /// Gets and sets the property EnabledElevatedTools. 
        /// <para>
        /// The subset of elevated-access tools enabled for this integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<MCPToolDetail> EnabledElevatedTools
        {
            get { return this._enabledElevatedTools; }
            set { this._enabledElevatedTools = value; }
        }

        // Check to see if EnabledElevatedTools property is set
        internal bool IsSetEnabledElevatedTools()
        {
            return this._enabledElevatedTools != null && (this._enabledElevatedTools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}