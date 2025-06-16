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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// This is the response object from the DescribeFirewallMetadata operation.
    /// </summary>
    public partial class DescribeFirewallMetadataResponse : AmazonWebServiceResponse
    {
        private string _description;
        private string _firewallArn;
        private string _firewallPolicyArn;
        private FirewallStatusValue _status;
        private Dictionary<string, AvailabilityZoneMetadata> _supportedAvailabilityZones = AWSConfigs.InitializeCollections ? new Dictionary<string, AvailabilityZoneMetadata>() : null;
        private string _transitGatewayAttachmentId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
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
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string FirewallArn
        {
            get { return this._firewallArn; }
            set { this._firewallArn = value; }
        }

        // Check to see if FirewallArn property is set
        internal bool IsSetFirewallArn()
        {
            return this._firewallArn != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string FirewallPolicyArn
        {
            get { return this._firewallPolicyArn; }
            set { this._firewallPolicyArn = value; }
        }

        // Check to see if FirewallPolicyArn property is set
        internal bool IsSetFirewallPolicyArn()
        {
            return this._firewallPolicyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The readiness of the configured firewall to handle network traffic across all of the
        /// Availability Zones where you have it configured. This setting is <c>READY</c> only
        /// when the <c>ConfigurationSyncStateSummary</c> value is <c>IN_SYNC</c> and the <c>Attachment</c>
        /// <c>Status</c> values for all of the configured subnets are <c>READY</c>. 
        /// </para>
        /// </summary>
        public FirewallStatusValue Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedAvailabilityZones. 
        /// <para>
        /// The Availability Zones that the firewall currently supports. This includes all Availability
        /// Zones for which the firewall has a subnet defined. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AvailabilityZoneMetadata> SupportedAvailabilityZones
        {
            get { return this._supportedAvailabilityZones; }
            set { this._supportedAvailabilityZones = value; }
        }

        // Check to see if SupportedAvailabilityZones property is set
        internal bool IsSetSupportedAvailabilityZones()
        {
            return this._supportedAvailabilityZones != null && (this._supportedAvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The unique identifier of the transit gateway attachment associated with this firewall.
        /// This field is only present for transit gateway-attached firewalls.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TransitGatewayAttachmentId
        {
            get { return this._transitGatewayAttachmentId; }
            set { this._transitGatewayAttachmentId = value; }
        }

        // Check to see if TransitGatewayAttachmentId property is set
        internal bool IsSetTransitGatewayAttachmentId()
        {
            return this._transitGatewayAttachmentId != null;
        }

    }
}