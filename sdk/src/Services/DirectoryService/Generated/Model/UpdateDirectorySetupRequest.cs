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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDirectorySetup operation.
    /// Updates the directory for a particular update type.
    /// </summary>
    public partial class UpdateDirectorySetupRequest : AmazonDirectoryServiceRequest
    {
        private bool? _createSnapshotBeforeUpdate;
        private string _directoryId;
        private OSUpdateSettings _osUpdateSettings;
        private UpdateType _updateType;

        /// <summary>
        /// Gets and sets the property CreateSnapshotBeforeUpdate. 
        /// <para>
        ///  The boolean that specifies if a snapshot for the directory needs to be taken before
        /// updating the directory. 
        /// </para>
        /// </summary>
        public bool CreateSnapshotBeforeUpdate
        {
            get { return this._createSnapshotBeforeUpdate.GetValueOrDefault(); }
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
        ///  The identifier of the directory on which you want to perform the update. 
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
        /// Gets and sets the property OSUpdateSettings. 
        /// <para>
        ///  The settings for the OS update that needs to be performed on the directory. 
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
        ///  The type of update that needs to be performed on the directory. For example, OS.
        /// 
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