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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVerifiedAccessEndpoint operation.
    /// Modifies the configuration of the specified Amazon Web Services Verified Access endpoint.
    /// </summary>
    public partial class ModifyVerifiedAccessEndpointRequest : AmazonEC2Request
    {
        private ModifyVerifiedAccessEndpointCidrOptions _cidrOptions;
        private string _clientToken;
        private string _description;
        private bool? _dryRun;
        private ModifyVerifiedAccessEndpointLoadBalancerOptions _loadBalancerOptions;
        private ModifyVerifiedAccessEndpointEniOptions _networkInterfaceOptions;
        private ModifyVerifiedAccessEndpointRdsOptions _rdsOptions;
        private string _verifiedAccessEndpointId;
        private string _verifiedAccessGroupId;

        /// <summary>
        /// Gets and sets the property CidrOptions. 
        /// <para>
        /// The CIDR options.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessEndpointCidrOptions CidrOptions
        {
            get { return this._cidrOptions; }
            set { this._cidrOptions = value; }
        }

        // Check to see if CidrOptions property is set
        internal bool IsSetCidrOptions()
        {
            return this._cidrOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure idempotency of your modification
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
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
        /// A description for the Verified Access endpoint.
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerOptions. 
        /// <para>
        /// The load balancer details if creating the Verified Access endpoint as <c>load-balancer</c>type.
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
        /// Gets and sets the property RdsOptions. 
        /// <para>
        /// The RDS options.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessEndpointRdsOptions RdsOptions
        {
            get { return this._rdsOptions; }
            set { this._rdsOptions = value; }
        }

        // Check to see if RdsOptions property is set
        internal bool IsSetRdsOptions()
        {
            return this._rdsOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessEndpointId. 
        /// <para>
        /// The ID of the Verified Access endpoint.
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
        /// The ID of the Verified Access group.
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