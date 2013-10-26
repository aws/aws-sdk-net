/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <summary>Network Interface Association
    /// </summary>
    public class NetworkInterfaceAssociation
    {
        
        private string publicIp;
        private string ipOwnerId;
        private string allocationId;
        private string associationId;

        public string PublicIp
        {
            get { return this.publicIp; }
            set { this.publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this.publicIp != null;
        }
        public string IpOwnerId
        {
            get { return this.ipOwnerId; }
            set { this.ipOwnerId = value; }
        }

        // Check to see if IpOwnerId property is set
        internal bool IsSetIpOwnerId()
        {
            return this.ipOwnerId != null;
        }
        public string AllocationId
        {
            get { return this.allocationId; }
            set { this.allocationId = value; }
        }

        // Check to see if AllocationId property is set
        internal bool IsSetAllocationId()
        {
            return this.allocationId != null;
        }
        public string AssociationId
        {
            get { return this.associationId; }
            set { this.associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this.associationId != null;
        }
    }
}
