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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreVolumeFromSnapshot operation. Returns an
    /// Amazon FSx for OpenZFS volume to the state saved by the specified snapshot.
    /// </summary>
    public partial class RestoreVolumeFromSnapshotRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The settings used when restoring the specified volume from snapshot.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETE_INTERMEDIATE_SNAPSHOTS</c> - Deletes snapshots between the current state
        /// and the specified snapshot. If there are intermediate snapshots and this option isn't
        /// used, <c>RestoreVolumeFromSnapshot</c> fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_CLONED_VOLUMES</c> - Deletes any dependent clone volumes created from intermediate
        /// snapshots. If there are any dependent clone volumes and this option isn't used, <c>RestoreVolumeFromSnapshot</c>
        /// fails.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> Options { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null && (this.Options.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the source snapshot. Specifies the snapshot that you are restoring from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 11, Max = 28)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume that you are restoring.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 23, Max = 23)]
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;
    }
}
