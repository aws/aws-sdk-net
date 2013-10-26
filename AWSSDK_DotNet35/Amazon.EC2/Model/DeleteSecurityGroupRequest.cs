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
    /// Container for the parameters to the DeleteSecurityGroup operation.
    /// <para> The DeleteSecurityGroup operation deletes a security group. </para> <para><b>NOTE:</b> If you attempt to delete a security group that
    /// contains instances, a fault is returned. If you attempt to delete a security group that is referenced by another security group, a fault is
    /// returned. For example, if security group B has a rule that allows access from security group A, security group A cannot be deleted until the
    /// allow rule is removed. </para>
    /// </summary>
    public partial class DeleteSecurityGroupRequest : AmazonEC2Request
    {
        private string groupName;
        private string groupId;


        /// <summary>
        /// The name of the Amazon EC2 security group to delete.
        ///  
        /// </summary>
        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this.groupName != null;
        }

        /// <summary>
        /// The ID of the Amazon EC2 security group to delete.
        ///  
        /// </summary>
        public string GroupId
        {
            get { return this.groupId; }
            set { this.groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this.groupId != null;
        }

    }
}
    
