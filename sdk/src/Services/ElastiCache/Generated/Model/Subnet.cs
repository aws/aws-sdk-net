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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Represents the subnet associated with a cluster. This parameter refers to subnets
    /// defined in Amazon Virtual Private Cloud (Amazon VPC) and used with ElastiCache.
    /// </summary>
    public partial class Subnet
    {
        private AvailabilityZone _subnetAvailabilityZone;
        private string _subnetIdentifier;
        private SubnetOutpost _subnetOutpost;
        private List<string> _supportedNetworkTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZone. 
        /// <para>
        /// The Availability Zone associated with the subnet.
        /// </para>
        /// </summary>
        public AvailabilityZone SubnetAvailabilityZone
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
        /// Gets and sets the property SubnetIdentifier. 
        /// <para>
        /// The unique identifier for the subnet.
        /// </para>
        /// </summary>
        public string SubnetIdentifier
        {
            get { return this._subnetIdentifier; }
            set { this._subnetIdentifier = value; }
        }

        // Check to see if SubnetIdentifier property is set
        internal bool IsSetSubnetIdentifier()
        {
            return this._subnetIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetOutpost. 
        /// <para>
        /// The outpost ARN of the subnet.
        /// </para>
        /// </summary>
        public SubnetOutpost SubnetOutpost
        {
            get { return this._subnetOutpost; }
            set { this._subnetOutpost = value; }
        }

        // Check to see if SubnetOutpost property is set
        internal bool IsSetSubnetOutpost()
        {
            return this._subnetOutpost != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedNetworkTypes. 
        /// <para>
        /// Either <code>ipv4</code> | <code>ipv6</code> | <code>dual_stack</code>. IPv6 is supported
        /// for workloads using Redis engine version 6.2 onward or Memcached engine version 1.6.6
        /// on all instances built on the <a href="http://aws.amazon.com/ec2/nitro/">Nitro system</a>.
        /// </para>
        /// </summary>
        public List<string> SupportedNetworkTypes
        {
            get { return this._supportedNetworkTypes; }
            set { this._supportedNetworkTypes = value; }
        }

        // Check to see if SupportedNetworkTypes property is set
        internal bool IsSetSupportedNetworkTypes()
        {
            return this._supportedNetworkTypes != null && this._supportedNetworkTypes.Count > 0; 
        }

    }
}