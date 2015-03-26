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
    /// Container for the parameters to the DeleteSecurityGroup operation.
    /// Deletes a security group.
    /// 
    ///  
    /// <para>
    /// If you attempt to delete a security group that is associated with an instance, or
    /// is referenced by another security group, the operation fails with <code>InvalidGroup.InUse</code>
    /// in EC2-Classic or <code>DependencyViolation</code> in EC2-VPC.
    /// </para>
    /// </summary>
    public partial class DeleteSecurityGroupRequest : AmazonEC2Request
    {
        private string _groupId;
        private string _groupName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteSecurityGroupRequest() { }

        /// <summary>
        /// Instantiates DeleteSecurityGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="groupName">[EC2-Classic, default VPC] The name of the security group. You can specify either the security group name or the security group ID.</param>
        public DeleteSecurityGroupRequest(string groupName)
        {
            _groupName = groupName;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group. Required for a nondefault VPC.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// [EC2-Classic, default VPC] The name of the security group. You can specify either
        /// the security group name or the security group ID.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

    }
}