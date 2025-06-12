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
    /// Container for the parameters to the CreateTrafficMirrorTarget operation.
    /// Creates a target for your Traffic Mirror session.
    /// 
    ///  
    /// <para>
    /// A Traffic Mirror target is the destination for mirrored traffic. The Traffic Mirror
    /// source and the Traffic Mirror target (monitoring appliances) can be in the same VPC,
    /// or in different VPCs connected via VPC peering or a transit gateway.
    /// </para>
    ///  
    /// <para>
    /// A Traffic Mirror target can be a network interface, a Network Load Balancer, or a
    /// Gateway Load Balancer endpoint.
    /// </para>
    ///  
    /// <para>
    /// To use the target in a Traffic Mirror session, use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTrafficMirrorSession.htm">CreateTrafficMirrorSession</a>.
    /// </para>
    /// </summary>
    public partial class CreateTrafficMirrorTargetRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _description;
        private bool? _dryRun;
        private string _gatewayLoadBalancerEndpointId;
        private string _networkInterfaceId;
        private string _networkLoadBalancerArn;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">How
        /// to ensure idempotency</a>.
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
        /// The description of the Traffic Mirror target.
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
        /// Gets and sets the property GatewayLoadBalancerEndpointId. 
        /// <para>
        /// The ID of the Gateway Load Balancer endpoint.
        /// </para>
        /// </summary>
        public string GatewayLoadBalancerEndpointId
        {
            get { return this._gatewayLoadBalancerEndpointId; }
            set { this._gatewayLoadBalancerEndpointId = value; }
        }

        // Check to see if GatewayLoadBalancerEndpointId property is set
        internal bool IsSetGatewayLoadBalancerEndpointId()
        {
            return this._gatewayLoadBalancerEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The network interface ID that is associated with the target.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkLoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Network Load Balancer that is associated with
        /// the target.
        /// </para>
        /// </summary>
        public string NetworkLoadBalancerArn
        {
            get { return this._networkLoadBalancerArn; }
            set { this._networkLoadBalancerArn = value; }
        }

        // Check to see if NetworkLoadBalancerArn property is set
        internal bool IsSetNetworkLoadBalancerArn()
        {
            return this._networkLoadBalancerArn != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the Traffic Mirror target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}