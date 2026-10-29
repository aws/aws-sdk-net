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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDirectorySetup operation. Updates directory
    /// configuration for the specified update type.
    /// </summary>
    public partial class UpdateDirectorySetupRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property CreateSnapshotBeforeUpdate. 
        /// <para>
        /// Specifies whether to create a directory snapshot before performing the update.
        /// </para>
        /// </summary>
        public bool? CreateSnapshotBeforeUpdate { get; set; }

        /// <summary>
        /// Checks to see if the CreateSnapshotBeforeUpdate property is set.
        /// </summary>
        internal bool IsSetCreateSnapshotBeforeUpdate() => this.CreateSnapshotBeforeUpdate.HasValue;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property DirectorySizeUpdateSettings. 
        /// <para>
        /// Directory size configuration to apply during the update operation.
        /// </para>
        /// </summary>
        public DirectorySizeUpdateSettings DirectorySizeUpdateSettings { get; set; }

        /// <summary>
        /// Checks to see if the DirectorySizeUpdateSettings property is set.
        /// </summary>
        internal bool IsSetDirectorySizeUpdateSettings() => this.DirectorySizeUpdateSettings != null;

        /// <summary>
        /// Gets and sets the property NetworkUpdateSettings. 
        /// <para>
        /// Network configuration to apply during the directory update operation.
        /// </para>
        /// </summary>
        public NetworkUpdateSettings NetworkUpdateSettings { get; set; }

        /// <summary>
        /// Checks to see if the NetworkUpdateSettings property is set.
        /// </summary>
        internal bool IsSetNetworkUpdateSettings() => this.NetworkUpdateSettings != null;

        /// <summary>
        /// Gets and sets the property OSUpdateSettings. 
        /// <para>
        /// Operating system configuration to apply during the directory update operation.
        /// </para>
        /// </summary>
        public OSUpdateSettings OSUpdateSettings { get; set; }

        /// <summary>
        /// Checks to see if the OSUpdateSettings property is set.
        /// </summary>
        internal bool IsSetOSUpdateSettings() => this.OSUpdateSettings != null;

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// The type of update to perform on the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UpdateType UpdateType { get; set; }

        /// <summary>
        /// Checks to see if the UpdateType property is set.
        /// </summary>
        internal bool IsSetUpdateType() => this.UpdateType != null;
    }
}
