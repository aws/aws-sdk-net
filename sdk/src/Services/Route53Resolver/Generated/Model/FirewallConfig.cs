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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Configuration of the firewall behavior provided by DNS Firewall for a single VPC from
    /// Amazon Virtual Private Cloud (Amazon VPC).
    /// </summary>
    public partial class FirewallConfig
    {
        private FirewallFailOpenStatus _firewallFailOpen;
        private string _id;
        private string _ownerId;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property FirewallFailOpen. 
        /// <para>
        /// Determines how DNS Firewall operates during failures, for example when all traffic
        /// that is sent to DNS Firewall fails to receive a reply. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// By default, fail open is disabled, which means the failure mode is closed. This approach
        /// favors security over availability. DNS Firewall returns a failure error when it is
        /// unable to properly evaluate a query. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you enable this option, the failure mode is open. This approach favors availability
        /// over security. DNS Firewall allows queries to proceed if it is unable to properly
        /// evaluate them. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This behavior is only enforced for VPCs that have at least one DNS Firewall rule group
        /// association. 
        /// </para>
        /// </summary>
        public FirewallFailOpenStatus FirewallFailOpen
        {
            get { return this._firewallFailOpen; }
            set { this._firewallFailOpen = value; }
        }

        // Check to see if FirewallFailOpen property is set
        internal bool IsSetFirewallFailOpen()
        {
            return this._firewallFailOpen != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the firewall configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the VPC that this firewall configuration
        /// applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=32)]
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the VPC that this firewall configuration applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}