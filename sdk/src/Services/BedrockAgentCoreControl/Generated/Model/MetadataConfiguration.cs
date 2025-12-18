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
    /// Configuration for HTTP header and query parameter propagation between the gateway
    /// and target servers.
    /// </summary>
    public partial class MetadataConfiguration
    {
        private List<string> _allowedQueryParameters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedRequestHeaders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedResponseHeaders = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedQueryParameters. 
        /// <para>
        /// A list of URL query parameters that are allowed to be propagated from incoming gateway
        /// URL to the target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> AllowedQueryParameters
        {
            get { return this._allowedQueryParameters; }
            set { this._allowedQueryParameters = value; }
        }

        // Check to see if AllowedQueryParameters property is set
        internal bool IsSetAllowedQueryParameters()
        {
            return this._allowedQueryParameters != null && (this._allowedQueryParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedRequestHeaders. 
        /// <para>
        /// A list of HTTP headers that are allowed to be propagated from incoming client requests
        /// to the target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> AllowedRequestHeaders
        {
            get { return this._allowedRequestHeaders; }
            set { this._allowedRequestHeaders = value; }
        }

        // Check to see if AllowedRequestHeaders property is set
        internal bool IsSetAllowedRequestHeaders()
        {
            return this._allowedRequestHeaders != null && (this._allowedRequestHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedResponseHeaders. 
        /// <para>
        /// A list of HTTP headers that are allowed to be propagated from the target response
        /// back to the client.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> AllowedResponseHeaders
        {
            get { return this._allowedResponseHeaders; }
            set { this._allowedResponseHeaders = value; }
        }

        // Check to see if AllowedResponseHeaders property is set
        internal bool IsSetAllowedResponseHeaders()
        {
            return this._allowedResponseHeaders != null && (this._allowedResponseHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}