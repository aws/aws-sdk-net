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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
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
    /// Container for the parameters to the DeleteMountTarget operation.
    /// Deletes the specified mount target. 
    /// 
    ///  
    /// <para>
    ///  This operation forcibly breaks any mounts of the file system via the mount target
    /// being deleted, which might disrupt instances or applications using those mounts. To
    /// avoid applications getting cut off abruptly, you might consider unmounting any mounts
    /// of the mount target, if feasible. The operation also deletes the associated network
    /// interface. Uncommitted writes may be lost, but breaking a mount target using this
    /// operation does not corrupt the file system itself. The file system you created remains.
    /// You can mount an EC2 instance in your VPC using another mount target. 
    /// </para>
    ///  
    /// <para>
    ///  This operation requires permission for the following action on the file system: 
    /// </para>
    ///  <ul> <li> <code>elasticfilesystem:DeleteMountTarget</code> </li> </ul> <note>The
    /// <code>DeleteMountTarget</code> call returns while the mount target state is still
    /// "deleting". You can check the mount target deletion by calling the <a>DescribeMountTargets</a>
    /// API, which returns a list of mount target descriptions for the given file system.
    /// </note> 
    /// <para>
    /// The operation also requires permission for the following Amazon EC2 action on the
    /// mount target's network interface:
    /// </para>
    ///  <ul> <li> <code>ec2:DeleteNetworkInterface</code> </li> </ul>
    /// </summary>
    public partial class DeleteMountTargetRequest : AmazonElasticFileSystemRequest
    {
        private string _mountTargetId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteMountTargetRequest() { }

        /// <summary>
        /// Instantiates DeleteMountTargetRequest with the parameterized properties
        /// </summary>
        /// <param name="mountTargetId">String. The ID of the mount target to delete.</param>
        public DeleteMountTargetRequest(string mountTargetId)
        {
            _mountTargetId = mountTargetId;
        }

        /// <summary>
        /// Gets and sets the property MountTargetId. 
        /// <para>
        /// String. The ID of the mount target to delete.
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

    }
}