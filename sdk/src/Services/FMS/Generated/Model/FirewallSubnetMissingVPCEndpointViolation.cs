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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// The violation details for a firewall subnet's VPC endpoint that's deleted or missing.
    /// </summary>
    public partial class FirewallSubnetMissingVPCEndpointViolation
    {
        private string _firewallSubnetId;
        private string _subnetAvailabilityZone;
        private string _subnetAvailabilityZoneId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property FirewallSubnetId. 
        /// <para>
        /// The ID of the firewall that this VPC endpoint is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string FirewallSubnetId
        {
            get { return this._firewallSubnetId; }
            set { this._firewallSubnetId = value; }
        }

        // Check to see if FirewallSubnetId property is set
        internal bool IsSetFirewallSubnetId()
        {
            return this._firewallSubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone of the deleted VPC subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SubnetAvailabilityZone
        {
            get { return this._subnetAvailabilityZone; }
            set { this._subnetAvailabilityZone = value; }
        }

        // Check to see if SubnetAvailabilityZone property is set
        internal bool IsSetSubnetAvailabilityZone()
        {
            return this._subnetAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone of the deleted VPC subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SubnetAvailabilityZoneId
        {
            get { return this._subnetAvailabilityZoneId; }
            set { this._subnetAvailabilityZoneId = value; }
        }

        // Check to see if SubnetAvailabilityZoneId property is set
        internal bool IsSetSubnetAvailabilityZoneId()
        {
            return this._subnetAvailabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The resource ID of the VPC associated with the deleted VPC subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}