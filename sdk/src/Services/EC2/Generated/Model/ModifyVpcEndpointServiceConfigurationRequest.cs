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
    /// Container for the parameters to the ModifyVpcEndpointServiceConfiguration operation.
    /// Modifies the attributes of your VPC endpoint service configuration. You can change
    /// the Network Load Balancers or Gateway Load Balancers for your service, and you can
    /// specify whether acceptance is required for requests to connect to your endpoint service
    /// through an interface VPC endpoint.
    /// 
    ///  
    /// <para>
    /// If you set or modify the private DNS name, you must prove that you own the private
    /// DNS domain name. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/endpoint-services-dns-validation.html">VPC
    /// Endpoint Service Private DNS Name Verification</a> in the <i>Amazon Virtual Private
    /// Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyVpcEndpointServiceConfigurationRequest : AmazonEC2Request
    {
        private bool? _acceptanceRequired;
        private List<string> _addGatewayLoadBalancerArns = new List<string>();
        private List<string> _addNetworkLoadBalancerArns = new List<string>();
        private string _privateDnsName;
        private List<string> _removeGatewayLoadBalancerArns = new List<string>();
        private List<string> _removeNetworkLoadBalancerArns = new List<string>();
        private bool? _removePrivateDnsName;
        private string _serviceId;

        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// Indicates whether requests to create an endpoint to your service must be accepted.
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
        /// Gets and sets the property AddGatewayLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Gateway Load Balancers to add to your service
        /// configuration.
        /// </para>
        /// </summary>
        public List<string> AddGatewayLoadBalancerArns
        {
            get { return this._addGatewayLoadBalancerArns; }
            set { this._addGatewayLoadBalancerArns = value; }
        }

        // Check to see if AddGatewayLoadBalancerArns property is set
        internal bool IsSetAddGatewayLoadBalancerArns()
        {
            return this._addGatewayLoadBalancerArns != null && this._addGatewayLoadBalancerArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AddNetworkLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Network Load Balancers to add to your service
        /// configuration.
        /// </para>
        /// </summary>
        public List<string> AddNetworkLoadBalancerArns
        {
            get { return this._addNetworkLoadBalancerArns; }
            set { this._addNetworkLoadBalancerArns = value; }
        }

        // Check to see if AddNetworkLoadBalancerArns property is set
        internal bool IsSetAddNetworkLoadBalancerArns()
        {
            return this._addNetworkLoadBalancerArns != null && this._addNetworkLoadBalancerArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsName. 
        /// <para>
        /// (Interface endpoint configuration) The private DNS name to assign to the endpoint
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
        /// Gets and sets the property RemoveGatewayLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Gateway Load Balancers to remove from your service
        /// configuration.
        /// </para>
        /// </summary>
        public List<string> RemoveGatewayLoadBalancerArns
        {
            get { return this._removeGatewayLoadBalancerArns; }
            set { this._removeGatewayLoadBalancerArns = value; }
        }

        // Check to see if RemoveGatewayLoadBalancerArns property is set
        internal bool IsSetRemoveGatewayLoadBalancerArns()
        {
            return this._removeGatewayLoadBalancerArns != null && this._removeGatewayLoadBalancerArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveNetworkLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Network Load Balancers to remove from your service
        /// configuration.
        /// </para>
        /// </summary>
        public List<string> RemoveNetworkLoadBalancerArns
        {
            get { return this._removeNetworkLoadBalancerArns; }
            set { this._removeNetworkLoadBalancerArns = value; }
        }

        // Check to see if RemoveNetworkLoadBalancerArns property is set
        internal bool IsSetRemoveNetworkLoadBalancerArns()
        {
            return this._removeNetworkLoadBalancerArns != null && this._removeNetworkLoadBalancerArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemovePrivateDnsName. 
        /// <para>
        /// (Interface endpoint configuration) Removes the private DNS name of the endpoint service.
        /// </para>
        /// </summary>
        public bool RemovePrivateDnsName
        {
            get { return this._removePrivateDnsName.GetValueOrDefault(); }
            set { this._removePrivateDnsName = value; }
        }

        // Check to see if RemovePrivateDnsName property is set
        internal bool IsSetRemovePrivateDnsName()
        {
            return this._removePrivateDnsName.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

    }
}