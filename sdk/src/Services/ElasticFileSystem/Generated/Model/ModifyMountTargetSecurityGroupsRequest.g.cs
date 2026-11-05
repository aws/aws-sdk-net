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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ModifyMountTargetSecurityGroups operation. Modifies
    /// the set of security groups in effect for a mount target. <para> When you create a
    /// mount target, Amazon EFS also creates a new network interface. For more information,
    /// see <a>CreateMountTarget</a>. This operation replaces the security groups in effect
    /// for the network interface associated with a mount target, with the <c>SecurityGroups</c>
    /// provided in the request. This operation requires that the network interface of the
    /// mount target has been created and the lifecycle state of the mount target is not <c>deleted</c>.
    /// </para> <para> The operation requires permissions for the following actions: </para>
    /// <ul> <li> <para> <c>elasticfilesystem:ModifyMountTargetSecurityGroups</c> action on
    /// the mount target's file system. </para> </li> <li> <para> <c>ec2:ModifyNetworkInterfaceAttribute</c>
    /// action on the mount target's network interface. </para> </li> </ul>
    /// </summary>
    public partial class ModifyMountTargetSecurityGroupsRequest : AmazonElasticFileSystemRequest
    {
        /// <summary>
        /// Gets and sets the property MountTargetId. 
        /// <para>
        /// The ID of the mount target whose security groups you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 13, Max = 45)]
        public string MountTargetId { get; set; }

        /// <summary>
        /// Checks to see if the MountTargetId property is set.
        /// </summary>
        internal bool IsSetMountTargetId() => this.MountTargetId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// An array of VPC security group IDs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
