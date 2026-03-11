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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
    /// Container for the parameters to the UpdateDirectorySetup operation.
    /// Updates directory configuration for the specified update type.
    /// </summary>
    public partial class UpdateDirectorySetupRequest : AmazonDirectoryServiceRequest
    {
        private bool? _createSnapshotBeforeUpdate;
        private string _directoryId;
        private DirectorySizeUpdateSettings _directorySizeUpdateSettings;
        private NetworkUpdateSettings _networkUpdateSettings;
        private OSUpdateSettings _osUpdateSettings;
        private UpdateType _updateType;

        /// <summary>
        /// Gets and sets the property CreateSnapshotBeforeUpdate. 
        /// <para>
        /// Specifies whether to create a directory snapshot before performing the update.
        /// </para>
        /// </summary>
        public bool? CreateSnapshotBeforeUpdate
        {
            get { return this._createSnapshotBeforeUpdate; }
            set { this._createSnapshotBeforeUpdate = value; }
        }

        // Check to see if CreateSnapshotBeforeUpdate property is set
        internal bool IsSetCreateSnapshotBeforeUpdate()
        {
            return this._createSnapshotBeforeUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DirectorySizeUpdateSettings. 
        /// <para>
        /// Directory size configuration to apply during the update operation.
        /// </para>
        /// </summary>
        public DirectorySizeUpdateSettings DirectorySizeUpdateSettings
        {
            get { return this._directorySizeUpdateSettings; }
            set { this._directorySizeUpdateSettings = value; }
        }

        // Check to see if DirectorySizeUpdateSettings property is set
        internal bool IsSetDirectorySizeUpdateSettings()
        {
            return this._directorySizeUpdateSettings != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkUpdateSettings. 
        /// <para>
        /// Network configuration to apply during the directory update operation.
        /// </para>
        /// </summary>
        public NetworkUpdateSettings NetworkUpdateSettings
        {
            get { return this._networkUpdateSettings; }
            set { this._networkUpdateSettings = value; }
        }

        // Check to see if NetworkUpdateSettings property is set
        internal bool IsSetNetworkUpdateSettings()
        {
            return this._networkUpdateSettings != null;
        }

        /// <summary>
        /// Gets and sets the property OSUpdateSettings. 
        /// <para>
        /// Operating system configuration to apply during the directory update operation.
        /// </para>
        /// </summary>
        public OSUpdateSettings OSUpdateSettings
        {
            get { return this._osUpdateSettings; }
            set { this._osUpdateSettings = value; }
        }

        // Check to see if OSUpdateSettings property is set
        internal bool IsSetOSUpdateSettings()
        {
            return this._osUpdateSettings != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// The type of update to perform on the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateType UpdateType
        {
            get { return this._updateType; }
            set { this._updateType = value; }
        }

        // Check to see if UpdateType property is set
        internal bool IsSetUpdateType()
        {
            return this._updateType != null;
        }

    }
}