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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
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
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMountTargetSecurityGroups operation.
    /// Returns the security groups currently in effect for a mount target. This operation
    /// requires that the network interface of the mount target has been created and the lifecycle
    /// state of the mount target is not <c>deleted</c>.
    /// 
    ///  
    /// <para>
    /// This operation requires permissions for the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>elasticfilesystem:DescribeMountTargetSecurityGroups</c> action on the mount target's
    /// file system. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ec2:DescribeNetworkInterfaceAttribute</c> action on the mount target's network
    /// interface. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeMountTargetSecurityGroupsRequest : AmazonElasticFileSystemRequest
    {
        private string _mountTargetId;

        /// <summary>
        /// Gets and sets the property MountTargetId. 
        /// <para>
        /// The ID of the mount target whose security groups you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=45)]
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

    }
}