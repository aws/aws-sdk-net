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
 * Do not modify this file. This file is generated from the efs-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyMountTargetSecurityGroups operation.
    /// Modifies the set of security groups in effect for a mount target.
    /// 
    ///  
    /// <para>
    /// When you create a mount target, Amazon EFS also creates a new network interface (see
    /// <a>CreateMountTarget</a>). This operation replaces the security groups in effect for
    /// the network interface associated with a mount target, with the <code>SecurityGroups</code>
    /// provided in the request. This operation requires that the network interface of the
    /// mount target has been created and the life cycle state of the mount target is not
    /// "deleted". 
    /// </para>
    ///  
    /// <para>
    /// The operation requires permissions for the following actions:
    /// </para>
    ///  <ul> <li> <code>elasticfilesystem:ModifyMountTargetSecurityGroups</code> action on
    /// the mount target's file system. </li> <li> <code>ec2:ModifyNetworkInterfaceAttribute</code>
    /// action on the mount target's network interface. </li> </ul>
    /// </summary>
    public partial class ModifyMountTargetSecurityGroupsRequest : AmazonElasticFileSystemRequest
    {
        private string _mountTargetId;
        private List<string> _securityGroups = new List<string>();

        /// <summary>
        /// Gets and sets the property MountTargetId. 
        /// <para>
        /// The ID of the mount target whose security groups you want to modify.
        /// </para>
        /// </summary>
        public string MountTargetId
        {
            get { return this._mountTargetId; }
            set { this._mountTargetId = value; }
        }

        // Check to see if MountTargetId property is set
        internal bool IsSetMountTargetId()
        {
            return this._mountTargetId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// An array of up to five VPC security group IDs.
        /// </para>
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

    }
}