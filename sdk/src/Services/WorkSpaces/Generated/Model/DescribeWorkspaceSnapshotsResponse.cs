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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// This is the response object from the DescribeWorkspaceSnapshots operation.
    /// </summary>
    public partial class DescribeWorkspaceSnapshotsResponse : AmazonWebServiceResponse
    {
        private List<Snapshot> _rebuildSnapshots = new List<Snapshot>();
        private List<Snapshot> _restoreSnapshots = new List<Snapshot>();

        /// <summary>
        /// Gets and sets the property RebuildSnapshots. 
        /// <para>
        /// Information about the snapshots that can be used to rebuild a WorkSpace. These snapshots
        /// include the user volume.
        /// </para>
        /// </summary>
        public List<Snapshot> RebuildSnapshots
        {
            get { return this._rebuildSnapshots; }
            set { this._rebuildSnapshots = value; }
        }

        // Check to see if RebuildSnapshots property is set
        internal bool IsSetRebuildSnapshots()
        {
            return this._rebuildSnapshots != null && this._rebuildSnapshots.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RestoreSnapshots. 
        /// <para>
        /// Information about the snapshots that can be used to restore a WorkSpace. These snapshots
        /// include both the root volume and the user volume.
        /// </para>
        /// </summary>
        public List<Snapshot> RestoreSnapshots
        {
            get { return this._restoreSnapshots; }
            set { this._restoreSnapshots = value; }
        }

        // Check to see if RestoreSnapshots property is set
        internal bool IsSetRestoreSnapshots()
        {
            return this._restoreSnapshots != null && this._restoreSnapshots.Count > 0; 
        }

    }
}