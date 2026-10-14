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
    /// Container for the parameters to the CopySnapshotAndUpdateVolume operation. Updates
    /// an existing volume by using a snapshot from another Amazon FSx for OpenZFS file system.
    /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/on-demand-replication.html">on-demand
    /// data replication</a> in the Amazon FSx for OpenZFS User Guide.
    /// </summary>
    public partial class CopySnapshotAndUpdateVolumeRequest : AmazonFSxRequest
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
        /// Gets and sets the property CopyStrategy. 
        /// <para>
        /// Specifies the strategy to use when copying data from a snapshot to the volume. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FULL_COPY</c> - Copies all data from the snapshot to the volume. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INCREMENTAL_COPY</c> - Copies only the snapshot data that's changed since the
        /// previous replication.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <c>CLONE</c> isn't a valid copy strategy option for the <c>CopySnapshotAndUpdateVolume</c>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        public OpenZFSCopyStrategy CopyStrategy { get; set; }

        /// <summary>
        /// Checks to see if the CopyStrategy property is set.
        /// </summary>
        internal bool IsSetCopyStrategy() => this.CopyStrategy != null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Confirms that you want to delete data on the destination volume that wasn’t there
        /// during the previous snapshot replication.
        /// </para>
        ///  
        /// <para>
        /// Your replication will fail if you don’t include an option for a specific type of data
        /// and that data is on your destination. For example, if you don’t include <c>DELETE_INTERMEDIATE_SNAPSHOTS</c>
        /// and there are intermediate snapshots on the destination, you can’t copy the snapshot.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETE_INTERMEDIATE_SNAPSHOTS</c> - Deletes snapshots on the destination volume
        /// that aren’t on the source volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_CLONED_VOLUMES</c> - Deletes snapshot clones on the destination volume
        /// that aren't on the source volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_INTERMEDIATE_DATA</c> - Overwrites snapshots on the destination volume
        /// that don’t match the source snapshot that you’re copying.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Options { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null && (this.Options.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceSnapshotARN.
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 512)]
        public string SourceSnapshotARN { get; set; }

        /// <summary>
        /// Checks to see if the SourceSnapshotARN property is set.
        /// </summary>
        internal bool IsSetSourceSnapshotARN() => this.SourceSnapshotARN != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// Specifies the ID of the volume that you are copying the snapshot to.
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
