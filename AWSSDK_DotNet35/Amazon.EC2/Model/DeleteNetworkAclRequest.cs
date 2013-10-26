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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteNetworkAcl operation.
    /// <para> Deletes a network ACL from a VPC. The ACL must not have any subnets associated with it. You can't delete the default network ACL. For
    /// more information about network ACLs, go to Network ACLs in the Amazon Virtual Private Cloud User Guide. </para>
    /// </summary>
    public partial class DeleteNetworkAclRequest : AmazonEC2Request
    {
        private string networkAclId;


        /// <summary>
        /// The ID of the network ACL to be deleted.
        ///  
        /// </summary>
        public string NetworkAclId
        {
            get { return this.networkAclId; }
            set { this.networkAclId = value; }
        }

        // Check to see if NetworkAclId property is set
        internal bool IsSetNetworkAclId()
        {
            return this.networkAclId != null;
        }

    }
}
    
