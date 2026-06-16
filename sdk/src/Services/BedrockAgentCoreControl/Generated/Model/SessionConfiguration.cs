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
    /// The session configuration for an MCP gateway. This structure defines settings that
    /// control session behavior.
    /// </summary>
    public partial class SessionConfiguration
    {
        private int? _sessionTimeoutInSeconds;

        /// <summary>
        /// Gets and sets the property SessionTimeoutInSeconds. 
        /// <para>
        /// The session timeout in seconds. After this timeout, the session expires and subsequent
        /// requests to this session will receive an error. The minimum value is 900 seconds (15
        /// minutes), the maximum value is 28800 seconds (8 hours), and the default value is 3600
        /// seconds (1 hour).
        /// </para>
        /// </summary>
        [AWSProperty(Min=900, Max=28800)]
        public int? SessionTimeoutInSeconds
        {
            get { return this._sessionTimeoutInSeconds; }
            set { this._sessionTimeoutInSeconds = value; }
        }

        // Check to see if SessionTimeoutInSeconds property is set
        internal bool IsSetSessionTimeoutInSeconds()
        {
            return this._sessionTimeoutInSeconds.HasValue; 
        }

    }
}