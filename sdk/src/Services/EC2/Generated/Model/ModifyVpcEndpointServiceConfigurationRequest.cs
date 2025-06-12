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
    /// Container for the parameters to the ModifyVpcEndpointServiceConfiguration operation.
    /// Modifies the attributes of the specified VPC endpoint service configuration.
    /// 
    ///  
    /// <para>
    /// If you set or modify the private DNS name, you must prove that you own the private
    /// DNS domain name.
    /// </para>
    /// </summary>
    public partial class ModifyVpcEndpointServiceConfigurationRequest : AmazonEC2Request
    {
        private bool? _acceptanceRequired;
        private List<string> _addGatewayLoadBalancerArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _addNetworkLoadBalancerArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _addSupportedIpAddressTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _addSupportedRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _dryRun;
        private string _privateDnsName;
        private List<string> _removeGatewayLoadBalancerArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _removeNetworkLoadBalancerArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _removePrivateDnsName;
        private List<string> _removeSupportedIpAddressTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _removeSupportedRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serviceId;

        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// Indicates whether requests to create an endpoint to the service must be accepted.
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
        /// Gets and sets the property AddGatewayLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Gateway Load Balancers to add to the service configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddGatewayLoadBalancerArns
        {
            get { return this._addGatewayLoadBalancerArns; }
            set { this._addGatewayLoadBalancerArns = value; }
        }

        // Check to see if AddGatewayLoadBalancerArns property is set
        internal bool IsSetAddGatewayLoadBalancerArns()
        {
            return this._addGatewayLoadBalancerArns != null && (this._addGatewayLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AddNetworkLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Network Load Balancers to add to the service configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddNetworkLoadBalancerArns
        {
            get { return this._addNetworkLoadBalancerArns; }
            set { this._addNetworkLoadBalancerArns = value; }
        }

        // Check to see if AddNetworkLoadBalancerArns property is set
        internal bool IsSetAddNetworkLoadBalancerArns()
        {
            return this._addNetworkLoadBalancerArns != null && (this._addNetworkLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AddSupportedIpAddressTypes. 
        /// <para>
        /// The IP address types to add to the service configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddSupportedIpAddressTypes
        {
            get { return this._addSupportedIpAddressTypes; }
            set { this._addSupportedIpAddressTypes = value; }
        }

        // Check to see if AddSupportedIpAddressTypes property is set
        internal bool IsSetAddSupportedIpAddressTypes()
        {
            return this._addSupportedIpAddressTypes != null && (this._addSupportedIpAddressTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AddSupportedRegions. 
        /// <para>
        /// The supported Regions to add to the service configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddSupportedRegions
        {
            get { return this._addSupportedRegions; }
            set { this._addSupportedRegions = value; }
        }

        // Check to see if AddSupportedRegions property is set
        internal bool IsSetAddSupportedRegions()
        {
            return this._addSupportedRegions != null && (this._addSupportedRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The Amazon Resource Names (ARNs) of Gateway Load Balancers to remove from the service
        /// configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveGatewayLoadBalancerArns
        {
            get { return this._removeGatewayLoadBalancerArns; }
            set { this._removeGatewayLoadBalancerArns = value; }
        }

        // Check to see if RemoveGatewayLoadBalancerArns property is set
        internal bool IsSetRemoveGatewayLoadBalancerArns()
        {
            return this._removeGatewayLoadBalancerArns != null && (this._removeGatewayLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemoveNetworkLoadBalancerArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of Network Load Balancers to remove from the service
        /// configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveNetworkLoadBalancerArns
        {
            get { return this._removeNetworkLoadBalancerArns; }
            set { this._removeNetworkLoadBalancerArns = value; }
        }

        // Check to see if RemoveNetworkLoadBalancerArns property is set
        internal bool IsSetRemoveNetworkLoadBalancerArns()
        {
            return this._removeNetworkLoadBalancerArns != null && (this._removeNetworkLoadBalancerArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemovePrivateDnsName. 
        /// <para>
        /// (Interface endpoint configuration) Removes the private DNS name of the endpoint service.
        /// </para>
        /// </summary>
        public bool? RemovePrivateDnsName
        {
            get { return this._removePrivateDnsName; }
            set { this._removePrivateDnsName = value; }
        }

        // Check to see if RemovePrivateDnsName property is set
        internal bool IsSetRemovePrivateDnsName()
        {
            return this._removePrivateDnsName.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveSupportedIpAddressTypes. 
        /// <para>
        /// The IP address types to remove from the service configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveSupportedIpAddressTypes
        {
            get { return this._removeSupportedIpAddressTypes; }
            set { this._removeSupportedIpAddressTypes = value; }
        }

        // Check to see if RemoveSupportedIpAddressTypes property is set
        internal bool IsSetRemoveSupportedIpAddressTypes()
        {
            return this._removeSupportedIpAddressTypes != null && (this._removeSupportedIpAddressTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemoveSupportedRegions. 
        /// <para>
        /// The supported Regions to remove from the service configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveSupportedRegions
        {
            get { return this._removeSupportedRegions; }
            set { this._removeSupportedRegions = value; }
        }

        // Check to see if RemoveSupportedRegions property is set
        internal bool IsSetRemoveSupportedRegions()
        {
            return this._removeSupportedRegions != null && (this._removeSupportedRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
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