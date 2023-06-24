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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreVolumeFromSnapshot operation.
    /// Returns an Amazon FSx for OpenZFS volume to the state saved by the specified snapshot.
    /// </summary>
    public partial class RestoreVolumeFromSnapshotRequest : AmazonFSxRequest
    {
        private string _clientRequestToken;
        private List<string> _options = new List<string>();
        private string _snapshotId;
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The settings used when restoring the specified volume from snapshot.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DELETE_INTERMEDIATE_SNAPSHOTS</code> - Deletes snapshots between the current
        /// state and the specified snapshot. If there are intermediate snapshots and this option
        /// isn't used, <code>RestoreVolumeFromSnapshot</code> fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_CLONED_VOLUMES</code> - Deletes any dependent clone volumes created
        /// from intermediate snapshots. If there are any dependent clone volumes and this option
        /// isn't used, <code>RestoreVolumeFromSnapshot</code> fails.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2)]
        public List<string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && this._options.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the source snapshot. Specifies the snapshot that you are restoring from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=28)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume that you are restoring.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=23, Max=23)]
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

    }
}