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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Container for the parameters to the CreateVpnGateway operation.
    /// Creates a virtual private gateway. A virtual private gateway is the endpoint on the
    /// VPC side of your VPN connection. You can create a virtual private gateway before creating
    /// the VPC itself.
    /// 
    ///  
    /// <para>
    /// For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
    /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
    /// Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVpnGatewayRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private GatewayType _type;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateVpnGatewayRequest() { }

        /// <summary>
        /// Instantiates CreateVpnGatewayRequest with the parameterized properties
        /// </summary>
        /// <param name="type">The type of VPN connection this virtual private gateway supports.</param>
        public CreateVpnGatewayRequest(GatewayType type)
        {
            _type = type;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the virtual private gateway.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of VPN connection this virtual private gateway supports.
        /// </para>
        /// </summary>
        public GatewayType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}