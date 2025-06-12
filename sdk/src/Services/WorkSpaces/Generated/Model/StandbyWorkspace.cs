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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
        private DataReplication _dataReplication;
        private string _directoryId;
        private string _primaryWorkspaceId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _volumeEncryptionKey;

        /// <summary>
        /// Gets and sets the property DataReplication. 
        /// <para>
        /// Indicates whether data replication is enabled, and if enabled, the type of data replication.
        /// </para>
        /// </summary>
        public DataReplication DataReplication
        {
            get { return this._dataReplication; }
            set { this._dataReplication = value; }
        }

        // Check to see if DataReplication property is set
        internal bool IsSetDataReplication()
        {
            return this._dataReplication != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory for the standby WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=65)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryWorkspaceId. 
        /// <para>
        /// The identifier of the standby WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrimaryWorkspaceId
        {
            get { return this._primaryWorkspaceId; }
            set { this._primaryWorkspaceId = value; }
        }

        // Check to see if PrimaryWorkspaceId property is set
        internal bool IsSetPrimaryWorkspaceId()
        {
            return this._primaryWorkspaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the standby WorkSpace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VolumeEncryptionKey. 
        /// <para>
        /// The volume encryption key of the standby WorkSpace.
        /// </para>
        /// </summary>
        public string VolumeEncryptionKey
        {
            get { return this._volumeEncryptionKey; }
            set { this._volumeEncryptionKey = value; }
        }

        // Check to see if VolumeEncryptionKey property is set
        internal bool IsSetVolumeEncryptionKey()
        {
            return this._volumeEncryptionKey != null;
        }

    }
}