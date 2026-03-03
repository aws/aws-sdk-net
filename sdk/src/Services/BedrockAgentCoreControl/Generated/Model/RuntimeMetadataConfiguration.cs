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
    /// Configuration for microVM metadata service settings.
    /// </summary>
    public partial class RuntimeMetadataConfiguration
    {
        private bool? _requiremmdsv2;

        /// <summary>
        /// Gets and sets the property RequireMMDSV2. 
        /// <para>
        /// Enables MMDSv2 (microVM Metadata Service Version 2) requirement for the agent runtime.
        /// When set to <c>true</c>, the runtime microVM will only accept MMDSv2 requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool RequireMMDSV2
        {
            get { return this._requiremmdsv2.GetValueOrDefault(); }
            set { this._requiremmdsv2 = value; }
        }

        // Check to see if RequireMMDSV2 property is set
        internal bool IsSetRequireMMDSV2()
        {
            return this._requiremmdsv2.HasValue; 
        }

    }
}