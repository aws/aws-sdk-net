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
    /// Details specific to a registered token-based remote A2A agent.
    /// </summary>
    public partial class RegisteredRemoteAgentDetails
    {
        private string _apiKeyHeader;
        private RemoteAgentAuthorizationMethod _authorizationMethod;
        private string _description;
        private string _endpoint;
        private string _name;

        /// <summary>
        /// Gets and sets the property ApiKeyHeader. 
        /// <para>
        /// If the remote agent uses API key authentication, the header name.
        /// </para>
        /// </summary>
        public string ApiKeyHeader
        {
            get { return this._apiKeyHeader; }
            set { this._apiKeyHeader = value; }
        }

        // Check to see if ApiKeyHeader property is set
        internal bool IsSetApiKeyHeader()
        {
            return this._apiKeyHeader != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationMethod. 
        /// <para>
        /// The authorization method used by the remote agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RemoteAgentAuthorizationMethod AuthorizationMethod
        {
            get { return this._authorizationMethod; }
            set { this._authorizationMethod = value; }
        }

        // Check to see if AuthorizationMethod property is set
        internal bool IsSetAuthorizationMethod()
        {
            return this._authorizationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=500)]
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
        /// Gets and sets the property Endpoint.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
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

    }
}