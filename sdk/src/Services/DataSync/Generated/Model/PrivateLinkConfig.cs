/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The VPC endpoint, subnet, and security group that an agent uses to access IP addresses
    /// in a VPC (Virtual Private Cloud).
    /// </summary>
    public partial class PrivateLinkConfig
    {
        private string _privateLinkEndpoint;
        private List<string> _securityGroupArns = new List<string>();
        private List<string> _subnetArns = new List<string>();
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property PrivateLinkEndpoint. 
        /// <para>
        /// The private endpoint that is configured for an agent that has access to IP addresses
        /// in a <a href="https://docs.aws.amazon.com/vpc/latest/userguide/endpoint-service.html">PrivateLink</a>.
        /// An agent that is configured with this endpoint will not be accessible over the public
        /// internet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=15)]
        public string PrivateLinkEndpoint
        {
            get { return this._privateLinkEndpoint; }
            set { this._privateLinkEndpoint = value; }
        }

        // Check to see if PrivateLinkEndpoint property is set
        internal bool IsSetPrivateLinkEndpoint()
        {
            return this._privateLinkEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the security groups that are configured for the
        /// EC2 resource that hosts an agent activated in a VPC or an agent that has access to
        /// a VPC endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> SecurityGroupArns
        {
            get { return this._securityGroupArns; }
            set { this._securityGroupArns = value; }
        }

        // Check to see if SecurityGroupArns property is set
        internal bool IsSetSecurityGroupArns()
        {
            return this._securityGroupArns != null && this._securityGroupArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the subnets that are configured for an agent activated
        /// in a VPC or an agent that has access to a VPC endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> SubnetArns
        {
            get { return this._subnetArns; }
            set { this._subnetArns = value; }
        }

        // Check to see if SubnetArns property is set
        internal bool IsSetSubnetArns()
        {
            return this._subnetArns != null && this._subnetArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint that is configured for an agent. An agent that is configured
        /// with a VPC endpoint will not be accessible over the public internet.
        /// </para>
        /// </summary>
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

    }
}