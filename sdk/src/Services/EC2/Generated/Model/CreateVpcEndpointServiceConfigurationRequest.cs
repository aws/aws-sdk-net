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
    /// Container for the parameters to the CreateVpcEndpointServiceConfiguration operation.
    /// Creates a VPC endpoint service to which service consumers (Amazon Web Services accounts,
    /// users, and IAM roles) can connect.
    /// 
    ///  
    /// <para>
    /// Before you create an endpoint service, you must create one of the following for your
    /// service:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/">Network
    /// Load Balancer</a>. Service consumers connect to your service using an interface endpoint.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/">Gateway
    /// Load Balancer</a>. Service consumers connect to your service using a Gateway Load
    /// Balancer endpoint.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you set the private DNS name, you must prove that you own the private DNS domain
    /// name.
    /// </para>
    ///  
    /// <para>
    /// For more information, see the <a href="https://docs.aws.amazon.com/vpc/latest/privatelink/">Amazon
    /// Web Services PrivateLink Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateVpcEndpointServiceConfigurationRequest : AmazonEC2Request
    {
        private bool? _acceptanceRequired;
        private string _clientToken;
        private List<string> _gatewayLoadBalancerArns = new List<string>();
        private List<string> _networkLoadBalancerArns = new List<string>();
        private string _privateDnsName;
        private List<string> _supportedIpAddressTypes = new List<string>();
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// Indicates whether requests from service consumers to create an endpoint to your service
        /// must be accepted manually.
        /// </para>
        /// </summary>
        public bool AcceptanceRequired
        {
            get { return this._acceptanceRequired.GetValueOrDefault(); }
            set { this._acceptanceRequired = value; }
        }

        // Check to see if AcceptanceRequired property is set
        internal bool IsSetAcceptanceRequired()
        {
            return this._acceptanceRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">How
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
        /// Gets and sets the property GatewayLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Gateway Load Balancers.
        /// </para>
        /// </summary>
        public List<string> GatewayLoadBalancerArns
        {
            get { return this._gatewayLoadBalancerArns; }
            set { this._gatewayLoadBalancerArns = value; }
        }

        // Check to see if GatewayLoadBalancerArns property is set
        internal bool IsSetGatewayLoadBalancerArns()
        {
            return this._gatewayLoadBalancerArns != null && this._gatewayLoadBalancerArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Network Load Balancers.
        /// </para>
        /// </summary>
        public List<string> NetworkLoadBalancerArns
        {
            get { return this._networkLoadBalancerArns; }
            set { this._networkLoadBalancerArns = value; }
        }

        // Check to see if NetworkLoadBalancerArns property is set
        internal bool IsSetNetworkLoadBalancerArns()
        {
            return this._networkLoadBalancerArns != null && this._networkLoadBalancerArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsName. 
        /// <para>
        /// (Interface endpoint configuration) The private DNS name to assign to the VPC endpoint
        /// service.
        /// </para>
        /// </summary>
        public string PrivateDnsName
        {
            get { return this._privateDnsName; }
            set { this._privateDnsName = value; }
        }

        // Check to see if PrivateDnsName property is set
        internal bool IsSetPrivateDnsName()
        {
            return this._privateDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedIpAddressTypes. 
        /// <para>
        /// The supported IP address types. The possible values are <code>ipv4</code> and <code>ipv6</code>.
        /// </para>
        /// </summary>
        public List<string> SupportedIpAddressTypes
        {
            get { return this._supportedIpAddressTypes; }
            set { this._supportedIpAddressTypes = value; }
        }

        // Check to see if SupportedIpAddressTypes property is set
        internal bool IsSetSupportedIpAddressTypes()
        {
            return this._supportedIpAddressTypes != null && this._supportedIpAddressTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to associate with the service.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}