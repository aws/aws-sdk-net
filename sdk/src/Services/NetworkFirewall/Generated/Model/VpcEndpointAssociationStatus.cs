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
    /// Detailed information about the current status of a <a>VpcEndpointAssociation</a>.
    /// You can retrieve this by calling <a>DescribeVpcEndpointAssociation</a> and providing
    /// the VPC endpoint association ARN.
    /// </summary>
    public partial class VpcEndpointAssociationStatus
    {
        private Dictionary<string, AZSyncState> _associationSyncState = AWSConfigs.InitializeCollections ? new Dictionary<string, AZSyncState>() : null;
        private FirewallStatusValue _status;

        /// <summary>
        /// Gets and sets the property AssociationSyncState. 
        /// <para>
        /// The list of the Availability Zone sync states for all subnets that are defined by
        /// the firewall. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AZSyncState> AssociationSyncState
        {
            get { return this._associationSyncState; }
            set { this._associationSyncState = value; }
        }

        // Check to see if AssociationSyncState property is set
        internal bool IsSetAssociationSyncState()
        {
            return this._associationSyncState != null && (this._associationSyncState.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The readiness of the configured firewall endpoint to handle network traffic. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}