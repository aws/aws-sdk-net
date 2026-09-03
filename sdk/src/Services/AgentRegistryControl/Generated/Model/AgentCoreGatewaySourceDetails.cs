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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Source details for a record auto-detected from an AgentCore Gateway resource.
    /// </summary>
    public partial class AgentCoreGatewaySourceDetails
    {
        private AuthorizerConfiguration _authorizerConfiguration;
        private string _authorizerType;
        private AgentCoreGatewayProtocolType _protocolType;
        private WorkloadIdentityDetails _workloadIdentityDetails;

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration.
        /// </summary>
        public AuthorizerConfiguration AuthorizerConfiguration
        {
            get { return this._authorizerConfiguration; }
            set { this._authorizerConfiguration = value; }
        }

        // Check to see if AuthorizerConfiguration property is set
        internal bool IsSetAuthorizerConfiguration()
        {
            return this._authorizerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerType. 
        /// <para>
        /// The type of authorizer configured on the AgentCore Gateway resource that the registry
        /// record was detected from.
        /// </para>
        /// </summary>
        public string AuthorizerType
        {
            get { return this._authorizerType; }
            set { this._authorizerType = value; }
        }

        // Check to see if AuthorizerType property is set
        internal bool IsSetAuthorizerType()
        {
            return this._authorizerType != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolType.
        /// </summary>
        public AgentCoreGatewayProtocolType ProtocolType
        {
            get { return this._protocolType; }
            set { this._protocolType = value; }
        }

        // Check to see if ProtocolType property is set
        internal bool IsSetProtocolType()
        {
            return this._protocolType != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadIdentityDetails.
        /// </summary>
        public WorkloadIdentityDetails WorkloadIdentityDetails
        {
            get { return this._workloadIdentityDetails; }
            set { this._workloadIdentityDetails = value; }
        }

        // Check to see if WorkloadIdentityDetails property is set
        internal bool IsSetWorkloadIdentityDetails()
        {
            return this._workloadIdentityDetails != null;
        }

    }
}