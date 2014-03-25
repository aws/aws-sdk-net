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
    /// Container for the parameters to the DeleteVpcPeeringConnection operation.
    /// <para>Deletes a VPC peering connection. Either the owner of the requester VPC or the owner of the peer VPC can delete the VPC peering
    /// connection if it's in the <c>active</c> state. The owner of the requester VPC can delete a VPC peering connection in the
    /// <c>pending-acceptance</c> state.</para>
    /// </summary>
    public partial class DeleteVpcPeeringConnectionRequest : AmazonEC2Request
    {
        private string vpcPeeringConnectionId;


        /// <summary>
        /// The ID of the VPC peering connection.
        ///  
        /// </summary>
        public string VpcPeeringConnectionId
        {
            get { return this.vpcPeeringConnectionId; }
            set { this.vpcPeeringConnectionId = value; }
        }

        // Check to see if VpcPeeringConnectionId property is set
        internal bool IsSetVpcPeeringConnectionId()
        {
            return this.vpcPeeringConnectionId != null;
        }

    }
}
    
