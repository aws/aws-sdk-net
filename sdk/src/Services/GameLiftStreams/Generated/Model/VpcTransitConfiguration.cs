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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// Configuration for connecting a stream group location to resources in your Amazon VPC
    /// using AWS Transit Gateway. When you specify a VPC transit configuration, Amazon GameLift
    /// Streams creates a Transit Gateway and shares it with your account using AWS Resource
    /// Access Manager. After the stream group is active, you must complete the setup by accepting
    /// the resource share, creating a VPC attachment, and configuring routing.
    /// </summary>
    public partial class VpcTransitConfiguration
    {
        private List<string> _ipv4CidrBlocks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Ipv4CidrBlocks. 
        /// <para>
        /// A list of IPv4 CIDR blocks in your VPC that you want the stream group to be able to
        /// access. You can specify up to 5 CIDR blocks. The CIDR blocks must be valid subsets
        /// of the VPC's CIDR blocks and cannot overlap with the service VPC CIDR block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> Ipv4CidrBlocks
        {
            get { return this._ipv4CidrBlocks; }
            set { this._ipv4CidrBlocks = value; }
        }

        // Check to see if Ipv4CidrBlocks property is set
        internal bool IsSetIpv4CidrBlocks()
        {
            return this._ipv4CidrBlocks != null && (this._ipv4CidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the Amazon VPC that you want to connect to the stream group. The VPC must
        /// be in the same Amazon Web Services account as the stream group. This value cannot
        /// be changed after the stream group is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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