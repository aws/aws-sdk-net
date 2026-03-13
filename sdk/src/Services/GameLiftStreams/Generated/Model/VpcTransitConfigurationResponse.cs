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
    /// The VPC transit configuration details for a stream group location, including the Transit
    /// Gateway information needed to complete the VPC attachment setup.
    /// </summary>
    public partial class VpcTransitConfigurationResponse
    {
        private List<string> _ipv4CidrBlocks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _transitGatewayId;
        private string _transitGatewayResourceShareArn;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Ipv4CidrBlocks. 
        /// <para>
        /// The IPv4 CIDR blocks in your VPC that the stream group can access.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
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
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the Transit Gateway that Amazon GameLift Streams created for this VPC connection.
        /// Use this ID when creating your VPC attachment.
        /// </para>
        /// </summary>
        public string TransitGatewayId
        {
            get { return this._transitGatewayId; }
            set { this._transitGatewayId = value; }
        }

        // Check to see if TransitGatewayId property is set
        internal bool IsSetTransitGatewayId()
        {
            return this._transitGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayResourceShareArn. 
        /// <para>
        /// The ARN of the AWS Resource Access Manager resource share for the Transit Gateway.
        /// You must accept this resource share before you can create a VPC attachment.
        /// </para>
        /// </summary>
        public string TransitGatewayResourceShareArn
        {
            get { return this._transitGatewayResourceShareArn; }
            set { this._transitGatewayResourceShareArn = value; }
        }

        // Check to see if TransitGatewayResourceShareArn property is set
        internal bool IsSetTransitGatewayResourceShareArn()
        {
            return this._transitGatewayResourceShareArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the Amazon VPC that is connected to the stream group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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