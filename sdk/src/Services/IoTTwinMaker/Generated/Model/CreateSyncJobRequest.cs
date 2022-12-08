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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSyncJob operation.
    /// This action creates a SyncJob.
    /// </summary>
    public partial class CreateSyncJobRequest : AmazonIoTTwinMakerRequest
    {
        private string _syncRole;
        private string _syncSource;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property SyncRole. 
        /// <para>
        /// The SyncJob IAM role. This IAM role is used by the sync job to read from the syncSource,
        /// and create, update or delete the corresponding resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string SyncRole
        {
            get { return this._syncRole; }
            set { this._syncRole = value; }
        }

        // Check to see if SyncRole property is set
        internal bool IsSetSyncRole()
        {
            return this._syncRole != null;
        }

        /// <summary>
        /// Gets and sets the property SyncSource. 
        /// <para>
        /// The sync source.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently the only supported syncSoucre is <code>SITEWISE </code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SyncSource
        {
            get { return this._syncSource; }
            set { this._syncSource = value; }
        }

        // Check to see if SyncSource property is set
        internal bool IsSetSyncSource()
        {
            return this._syncSource != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The SyncJob tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The workspace Id.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}