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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a VPC peering connection.</para>
    /// </summary>
    public partial class VpcPeeringConnection
    {
        
        private VpcPeeringConnectionVpcInfo accepterVpcInfo;
        private DateTime? expirationTime;
        private VpcPeeringConnectionVpcInfo requesterVpcInfo;
        private VpcPeeringConnectionStateReason status;
        private List<Tag> tags = new List<Tag>();
        private string vpcPeeringConnectionId;


        /// <summary>
        /// The information of the peer VPC.
        ///  
        /// </summary>
        public VpcPeeringConnectionVpcInfo AccepterVpcInfo
        {
            get { return this.accepterVpcInfo; }
            set { this.accepterVpcInfo = value; }
        }

        // Check to see if AccepterVpcInfo property is set
        internal bool IsSetAccepterVpcInfo()
        {
            return this.accepterVpcInfo != null;
        }

        /// <summary>
        /// The time that an unaccepted VPC peering connection will expire.
        ///  
        /// </summary>
        public DateTime ExpirationTime
        {
            get { return this.expirationTime ?? default(DateTime); }
            set { this.expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this.expirationTime.HasValue;
        }

        /// <summary>
        /// The information of the requester VPC.
        ///  
        /// </summary>
        public VpcPeeringConnectionVpcInfo RequesterVpcInfo
        {
            get { return this.requesterVpcInfo; }
            set { this.requesterVpcInfo = value; }
        }

        // Check to see if RequesterVpcInfo property is set
        internal bool IsSetRequesterVpcInfo()
        {
            return this.requesterVpcInfo != null;
        }

        /// <summary>
        /// The status of the VPC peering connection.
        ///  
        /// </summary>
        public VpcPeeringConnectionStateReason Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Any tags assigned to the resource.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

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
