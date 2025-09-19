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
    /// Configuration for HTTP request headers that will be passed through to the runtime.
    /// </summary>
    public partial class RequestHeaderConfiguration
    {
        private List<string> _requestHeaderAllowlist = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property RequestHeaderAllowlist. 
        /// <para>
        /// A list of HTTP request headers that are allowed to be passed through to the runtime.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> RequestHeaderAllowlist
        {
            get { return this._requestHeaderAllowlist; }
            set { this._requestHeaderAllowlist = value; }
        }

        // Check to see if RequestHeaderAllowlist property is set
        internal bool IsSetRequestHeaderAllowlist()
        {
            return this._requestHeaderAllowlist != null && (this._requestHeaderAllowlist.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}