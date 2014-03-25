/*******************************************************************************
 * Copyright 2008-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RejectVpcPeeringConnection operation.
    /// <para>Rejects a VPC peering connection request. The VPC peering connection must be in the <c>pending-acceptance</c> state. Use the
    /// <c>DescribeVpcPeeringConnections</c> request to view your outstanding VPC peering connection requests.</para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class RejectVpcPeeringConnectionRequest : EC2Request
    {
        private string vpcPeeringConnectionIdField;

        /// <summary>
        /// The ID of the VPC peering connection.
        ///  
        /// </summary>
        public string VpcPeeringConnectionId
        {
            get { return this.vpcPeeringConnectionIdField; }
            set { this.vpcPeeringConnectionIdField = value; }
        }
        
        /// <summary>
        /// Sets the VpcPeeringConnectionId
        /// <param name="vpcPeeringConnectionId">The VpcPeeringConnectionId.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RejectVpcPeeringConnectionRequest WithVpcPeeringConnectionId(string vpcPeeringConnectionId)
        {
            this.vpcPeeringConnectionIdField = vpcPeeringConnectionId;
            return this;
        }
        
        /// <summary>
        /// Checks if VpcPeeringConnectionId is set
        /// </summary>
        /// <returns>true if VpcPeeringConnectionId property is set</returns>
        public bool IsSetVpcPeeringConnectionId()
        {
            return this.vpcPeeringConnectionIdField != null;
        }
        
    }
}
