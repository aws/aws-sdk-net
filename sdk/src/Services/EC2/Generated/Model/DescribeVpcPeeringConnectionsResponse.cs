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
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
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
    /// Contains the output of DescribeVpcPeeringConnections.
    /// </summary>
    public partial class DescribeVpcPeeringConnectionsResponse : AmazonWebServiceResponse
    {
        private List<VpcPeeringConnection> _vpcPeeringConnections = new List<VpcPeeringConnection>();

        /// <summary>
        /// Gets and sets the property VpcPeeringConnections. 
        /// <para>
        /// Information about the VPC peering connections.
        /// </para>
        /// </summary>
        public List<VpcPeeringConnection> VpcPeeringConnections
        {
            get { return this._vpcPeeringConnections; }
            set { this._vpcPeeringConnections = value; }
        }

        // Check to see if VpcPeeringConnections property is set
        internal bool IsSetVpcPeeringConnections()
        {
            return this._vpcPeeringConnections != null && this._vpcPeeringConnections.Count > 0; 
        }

    }
}