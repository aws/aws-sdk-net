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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a standby WorkSpace.
    /// </summary>
    public partial class StandbyWorkspace
    {
        /// <summary>
        /// Gets and sets the property DataReplication. 
        /// <para>
        /// Indicates whether data replication is enabled, and if enabled, the type of data replication.
        /// </para>
        /// </summary>
        public DataReplication DataReplication { get; set; }

        /// <summary>
        /// Checks to see if the DataReplication property is set.
        /// </summary>
        internal bool IsSetDataReplication() => this.DataReplication != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory for the standby WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 65)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property PrimaryWorkspaceId. 
        /// <para>
        /// The identifier of the standby WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PrimaryWorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryWorkspaceId property is set.
        /// </summary>
        internal bool IsSetPrimaryWorkspaceId() => this.PrimaryWorkspaceId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the standby WorkSpace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VolumeEncryptionKey. 
        /// <para>
        /// The volume encryption key of the standby WorkSpace.
        /// </para>
        /// </summary>
        public string VolumeEncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the VolumeEncryptionKey property is set.
        /// </summary>
        internal bool IsSetVolumeEncryptionKey() => this.VolumeEncryptionKey != null;
    }
}
