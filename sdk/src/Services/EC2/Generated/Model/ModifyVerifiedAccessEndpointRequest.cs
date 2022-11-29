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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVerifiedAccessEndpoint operation.
    /// Modifies the configuration of an Amazon Web Services Verified Access endpoint.
    /// </summary>
    public partial class ModifyVerifiedAccessEndpointRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _description;
        private ModifyVerifiedAccessEndpointLoadBalancerOptions _loadBalancerOptions;
        private ModifyVerifiedAccessEndpointEniOptions _networkInterfaceOptions;
        private string _verifiedAccessEndpointId;
        private string _verifiedAccessGroupId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure idempotency of your modification
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Web Services Verified Access endpoint.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LoadBalancerOptions. 
        /// <para>
        /// The load balancer details if creating the Amazon Web Services Verified Access endpoint
        /// as <code>load-balancer</code>type.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessEndpointLoadBalancerOptions LoadBalancerOptions
        {
            get { return this._loadBalancerOptions; }
            set { this._loadBalancerOptions = value; }
        }

        // Check to see if LoadBalancerOptions property is set
        internal bool IsSetLoadBalancerOptions()
        {
            return this._loadBalancerOptions != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceOptions. 
        /// <para>
        /// The network interface options.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessEndpointEniOptions NetworkInterfaceOptions
        {
            get { return this._networkInterfaceOptions; }
            set { this._networkInterfaceOptions = value; }
        }

        // Check to see if NetworkInterfaceOptions property is set
        internal bool IsSetNetworkInterfaceOptions()
        {
            return this._networkInterfaceOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessEndpointId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VerifiedAccessEndpointId
        {
            get { return this._verifiedAccessEndpointId; }
            set { this._verifiedAccessEndpointId = value; }
        }

        // Check to see if VerifiedAccessEndpointId property is set
        internal bool IsSetVerifiedAccessEndpointId()
        {
            return this._verifiedAccessEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessGroupId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access group.
        /// </para>
        /// </summary>
        public string VerifiedAccessGroupId
        {
            get { return this._verifiedAccessGroupId; }
            set { this._verifiedAccessGroupId = value; }
        }

        // Check to see if VerifiedAccessGroupId property is set
        internal bool IsSetVerifiedAccessGroupId()
        {
            return this._verifiedAccessGroupId != null;
        }

    }
}