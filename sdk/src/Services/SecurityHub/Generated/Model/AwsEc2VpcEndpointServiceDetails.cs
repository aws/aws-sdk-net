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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains details about the service configuration for a VPC endpoint service.
    /// </summary>
    public partial class AwsEc2VpcEndpointServiceDetails
    {
        private bool? _acceptanceRequired;
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _baseEndpointDnsNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _gatewayLoadBalancerArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _managesVpcEndpoints;
        private List<string> _networkLoadBalancerArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _privateDnsName;
        private string _serviceId;
        private string _serviceName;
        private string _serviceState;
        private List<AwsEc2VpcEndpointServiceServiceTypeDetails> _serviceType = AWSConfigs.InitializeCollections ? new List<AwsEc2VpcEndpointServiceServiceTypeDetails>() : null;

        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// Whether requests from other Amazon Web Services accounts to create an endpoint to
        /// the service must first be accepted.
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
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones where the service is available.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BaseEndpointDnsNames. 
        /// <para>
        /// The DNS names for the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BaseEndpointDnsNames
        {
            get { return this._baseEndpointDnsNames; }
            set { this._baseEndpointDnsNames = value; }
        }

        // Check to see if BaseEndpointDnsNames property is set
        internal bool IsSetBaseEndpointDnsNames()
        {
            return this._baseEndpointDnsNames != null && (this._baseEndpointDnsNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GatewayLoadBalancerArns. 
        /// <para>
        /// The ARNs of the Gateway Load Balancers for the service.
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
        /// Gets and sets the property ManagesVpcEndpoints. 
        /// <para>
        /// Whether the service manages its VPC endpoints.
        /// </para>
        /// </summary>
        public bool? ManagesVpcEndpoints
        {
            get { return this._managesVpcEndpoints; }
            set { this._managesVpcEndpoints = value; }
        }

        // Check to see if ManagesVpcEndpoints property is set
        internal bool IsSetManagesVpcEndpoints()
        {
            return this._managesVpcEndpoints.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkLoadBalancerArns. 
        /// <para>
        /// The ARNs of the Network Load Balancers for the service.
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
        /// The private DNS name for the service.
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
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The identifier of the service.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceState. 
        /// <para>
        /// The current state of the service. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Available</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleted</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleting</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Pending</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ServiceState
        {
            get { return this._serviceState; }
            set { this._serviceState = value; }
        }

        // Check to see if ServiceState property is set
        internal bool IsSetServiceState()
        {
            return this._serviceState != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The types for the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2VpcEndpointServiceServiceTypeDetails> ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null && (this._serviceType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}