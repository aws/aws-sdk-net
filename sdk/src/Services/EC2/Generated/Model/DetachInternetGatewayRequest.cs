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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DetachInternetGateway operation.
    /// Detaches an internet gateway from a VPC, disabling connectivity between the internet
    /// and the VPC. The VPC must not contain any running instances with Elastic IP addresses
    /// or public IPv4 addresses.
    /// </summary>
    public partial class DetachInternetGatewayRequest : AmazonEC2Request
    {
        private string _internetGatewayId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property InternetGatewayId. 
        /// <para>
        /// The ID of the internet gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InternetGatewayId
        {
            get { return this._internetGatewayId; }
            set { this._internetGatewayId = value; }
        }

        // Check to see if InternetGatewayId property is set
        internal bool IsSetInternetGatewayId()
        {
            return this._internetGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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