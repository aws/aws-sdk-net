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
    /// Container for the parameters to the CreateNetworkConnector operation.
    /// Creates a network connector that enables Lambda compute resources to route outbound
    /// traffic through your Amazon VPC. The network connector provisions elastic network
    /// interfaces (ENIs) in the subnets you specify, providing a managed network path to
    /// private resources such as databases, caches, and internal APIs.
    /// 
    ///  
    /// <para>
    /// This operation is asynchronous. The network connector starts in <c>PENDING</c> state
    /// while ENIs are provisioned in your VPC (provisioning typically takes up to 10 minutes).
    /// Use <c>GetNetworkConnector</c> to poll the connector state until it reaches <c>ACTIVE</c>.
    /// Once active, you can attach the connector to Lambda MicroVMs at run time using the
    /// <c>egressNetworkConnectors</c> parameter on <c>RunMicroVm</c>.
    /// </para>
    ///  
    /// <para>
    /// This operation is idempotent when you provide a <c>ClientToken</c> — if you retry
    /// a request that completed successfully using the same client token, the operation returns
    /// the existing connector without creating a duplicate.
    /// </para>
    /// </summary>
    public partial class CreateNetworkConnectorRequest : AmazonLambdaCoreRequest
    {
        private string _clientToken;
        private NetworkConnectorConfiguration _configuration;
        private string _name;
        private string _operatorRole;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request with the same client token, the API returns the
        /// existing connector without creating a duplicate.
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
        /// The network configuration for the connector. Specify a <c>VpcEgressConfiguration</c>
        /// to enable outbound traffic routing through your VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the network connector within your account and Region. You can use
        /// the name to identify the connector in subsequent API calls.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
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
        /// Gets and sets the property OperatorRole. 
        /// <para>
        /// The ARN of the IAM role that Lambda assumes to manage elastic network interfaces in
        /// your VPC. This role must have permissions for <c>ec2:CreateNetworkInterface</c>, <c>ec2:DeleteNetworkInterface</c>,
        /// and related describe operations.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs to associate with the network connector for organization,
        /// cost allocation, or access control.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}