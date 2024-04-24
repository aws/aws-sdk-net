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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DisassociateSubnetCidrBlock operation.
    /// </summary>
    public partial class DisassociateSubnetCidrBlockResponse : AmazonWebServiceResponse
    {
        private SubnetIpv6CidrBlockAssociation _ipv6CidrBlockAssociation;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockAssociation. 
        /// <para>
        /// Information about the IPv6 CIDR block association.
        /// </para>
        /// </summary>
        public SubnetIpv6CidrBlockAssociation Ipv6CidrBlockAssociation
        {
            get { return this._ipv6CidrBlockAssociation; }
            set { this._ipv6CidrBlockAssociation = value; }
        }

        // Check to see if Ipv6CidrBlockAssociation property is set
        internal bool IsSetIpv6CidrBlockAssociation()
        {
            return this._ipv6CidrBlockAssociation != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

    }
}