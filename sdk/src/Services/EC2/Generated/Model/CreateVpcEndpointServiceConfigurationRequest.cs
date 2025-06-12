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
        private bool? _dryRun;
        private List<string> _gatewayLoadBalancerArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _networkLoadBalancerArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _privateDnsName;
        private List<string> _supportedIpAddressTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// Indicates whether requests from service consumers to create an endpoint to your service
        /// must be accepted manually.
        /// </para>
        /// </summary>
        public bool? AcceptanceRequired
        {
            get { return this._acceptanceRequired; }
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
        /// Gets and sets the property GatewayLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Gateway Load Balancers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GatewayLoadBalancerArns
        {
            get { return this._gatewayLoadBalancerArns; }
            set { this._gatewayLoadBalancerArns = value; }
        }

        // Check to see if GatewayLoadBalancerArns property is set
        internal bool IsSetGatewayLoadBalancerArns()
        {
            return this._gatewayLoadBalancerArns != null && (this._gatewayLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Network Load Balancers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NetworkLoadBalancerArns
        {
            get { return this._networkLoadBalancerArns; }
            set { this._networkLoadBalancerArns = value; }
        }

        // Check to see if NetworkLoadBalancerArns property is set
        internal bool IsSetNetworkLoadBalancerArns()
        {
            return this._networkLoadBalancerArns != null && (this._networkLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The supported IP address types. The possible values are <c>ipv4</c> and <c>ipv6</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedIpAddressTypes
        {
            get { return this._supportedIpAddressTypes; }
            set { this._supportedIpAddressTypes = value; }
        }

        // Check to see if SupportedIpAddressTypes property is set
        internal bool IsSetSupportedIpAddressTypes()
        {
            return this._supportedIpAddressTypes != null && (this._supportedIpAddressTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedRegions. 
        /// <para>
        /// The Regions from which service consumers can access the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedRegions
        {
            get { return this._supportedRegions; }
            set { this._supportedRegions = value; }
        }

        // Check to see if SupportedRegions property is set
        internal bool IsSetSupportedRegions()
        {
            return this._supportedRegions != null && (this._supportedRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to associate with the service.
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