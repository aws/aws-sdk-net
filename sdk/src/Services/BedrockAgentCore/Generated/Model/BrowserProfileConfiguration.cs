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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The configuration for a browser profile in Amazon Bedrock AgentCore. A browser profile
    /// contains persistent browser data such as cookies and local storage that can be saved
    /// from one browser session and reused in subsequent sessions. Browser profiles enable
    /// continuity for tasks that require authentication, maintain user preferences, or depend
    /// on previously stored browser state.
    /// </summary>
    public partial class BrowserProfileConfiguration
    {
        private string _profileIdentifier;

        /// <summary>
        /// Gets and sets the property ProfileIdentifier. 
        /// <para>
        /// The unique identifier of the browser profile. This identifier is used to reference
        /// the profile when starting new browser sessions or saving session data to the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProfileIdentifier
        {
            get { return this._profileIdentifier; }
            set { this._profileIdentifier = value; }
        }

        // Check to see if ProfileIdentifier property is set
        internal bool IsSetProfileIdentifier()
        {
            return this._profileIdentifier != null;
        }

    }
}