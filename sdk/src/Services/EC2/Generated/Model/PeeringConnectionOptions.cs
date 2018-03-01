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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the VPC peering connection options.
    /// </summary>
    public partial class PeeringConnectionOptions
    {
        private bool? _allowDnsResolutionFromRemoteVpc;
        private bool? _allowEgressFromLocalClassicLinkToRemoteVpc;
        private bool? _allowEgressFromLocalVpcToRemoteClassicLink;

        /// <summary>
        /// Gets and sets the property AllowDnsResolutionFromRemoteVpc. 
        /// <para>
        /// If true, the public DNS hostnames of instances in the specified VPC resolve to private
        /// IP addresses when queried from instances in the peer VPC.
        /// </para>
        /// </summary>
        public bool AllowDnsResolutionFromRemoteVpc
        {
            get { return this._allowDnsResolutionFromRemoteVpc.GetValueOrDefault(); }
            set { this._allowDnsResolutionFromRemoteVpc = value; }
        }

        // Check to see if AllowDnsResolutionFromRemoteVpc property is set
        internal bool IsSetAllowDnsResolutionFromRemoteVpc()
        {
            return this._allowDnsResolutionFromRemoteVpc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowEgressFromLocalClassicLinkToRemoteVpc. 
        /// <para>
        /// If true, enables outbound communication from an EC2-Classic instance that's linked
        /// to a local VPC via ClassicLink to instances in a peer VPC.
        /// </para>
        /// </summary>
        public bool AllowEgressFromLocalClassicLinkToRemoteVpc
        {
            get { return this._allowEgressFromLocalClassicLinkToRemoteVpc.GetValueOrDefault(); }
            set { this._allowEgressFromLocalClassicLinkToRemoteVpc = value; }
        }

        // Check to see if AllowEgressFromLocalClassicLinkToRemoteVpc property is set
        internal bool IsSetAllowEgressFromLocalClassicLinkToRemoteVpc()
        {
            return this._allowEgressFromLocalClassicLinkToRemoteVpc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowEgressFromLocalVpcToRemoteClassicLink. 
        /// <para>
        /// If true, enables outbound communication from instances in a local VPC to an EC2-Classic
        /// instance that's linked to a peer VPC via ClassicLink.
        /// </para>
        /// </summary>
        public bool AllowEgressFromLocalVpcToRemoteClassicLink
        {
            get { return this._allowEgressFromLocalVpcToRemoteClassicLink.GetValueOrDefault(); }
            set { this._allowEgressFromLocalVpcToRemoteClassicLink = value; }
        }

        // Check to see if AllowEgressFromLocalVpcToRemoteClassicLink property is set
        internal bool IsSetAllowEgressFromLocalVpcToRemoteClassicLink()
        {
            return this._allowEgressFromLocalVpcToRemoteClassicLink.HasValue; 
        }

    }
}