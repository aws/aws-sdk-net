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
 * Do not modify this file. This file is generated from the lambda-core-2026-04-30.normal.json service model.
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
namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNetworkConnector operation.
    /// Updates the VPC configuration or operator role of an existing network connector. You
    /// can modify the subnet IDs, security group IDs, network protocol, or operator role.
    /// The connector must be in <c>ACTIVE</c> state to accept updates.
    /// 
    ///  
    /// <para>
    /// This operation is asynchronous. The connector remains in <c>ACTIVE</c> state during
    /// the update — existing workloads that reference this connector are not disrupted. Use
    /// <c>GetNetworkConnector</c> to monitor the <c>LastUpdateStatus</c> field, which transitions
    /// through <c>InProgress</c> to <c>Successful</c> or <c>Failed</c>. If the update fails,
    /// the <c>LastUpdateStatusReasonCode</c> field provides a specific error code for troubleshooting.
    /// This operation is idempotent when you provide a <c>ClientToken</c>.
    /// </para>
    /// </summary>
    public partial class UpdateNetworkConnectorRequest : AmazonLambdaCoreRequest
    {
        private string _clientToken;
        private NetworkConnectorConfiguration _configuration;
        private string _identifier;
        private string _operatorRole;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the update request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The updated network configuration for the connector. Provide the full <c>VpcEgressConfiguration</c>
        /// including all subnet IDs and security group IDs — this replaces the existing configuration.
        /// </para>
        /// </summary>
        public NetworkConnectorConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property OperatorRole. 
        /// <para>
        /// The updated ARN of the IAM role that Lambda assumes to manage ENIs. Use this to change
        /// the operator role without recreating the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public string OperatorRole
        {
            get { return this._operatorRole; }
            set { this._operatorRole = value; }
        }

        // Check to see if OperatorRole property is set
        internal bool IsSetOperatorRole()
        {
            return this._operatorRole != null;
        }

    }
}