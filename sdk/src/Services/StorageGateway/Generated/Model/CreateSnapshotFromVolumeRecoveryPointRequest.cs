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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSnapshotFromVolumeRecoveryPoint operation.
    /// Initiates a snapshot of a gateway from a volume recovery point. This operation is
    /// only supported in the cached volume gateway type.
    /// 
    ///  
    /// <para>
    /// A volume recovery point is a point in time at which all data of the volume is consistent
    /// and from which you can create a snapshot. To get a list of volume recovery point for
    /// cached volume gateway, use <a>ListVolumeRecoveryPoints</a>.
    /// </para>
    ///  
    /// <para>
    /// In the <c>CreateSnapshotFromVolumeRecoveryPoint</c> request, you identify the volume
    /// by providing its Amazon Resource Name (ARN). You must also provide a description for
    /// the snapshot. When the gateway takes a snapshot of the specified volume, the snapshot
    /// and its description appear in the Storage Gateway console. In response, the gateway
    /// returns you a snapshot ID. You can use this snapshot ID to check the snapshot progress
    /// or later use it when you want to create a volume from a snapshot.
    /// </para>
    ///  <note> 
    /// <para>
    /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
    /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeleteSnapshot.html">DeleteSnapshot</a>
    /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateSnapshotFromVolumeRecoveryPointRequest : AmazonStorageGatewayRequest
    {
        private string _snapshotDescription;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _volumeARN;

        /// <summary>
        /// Gets and sets the property SnapshotDescription. 
        /// <para>
        /// Textual description of the snapshot that appears in the Amazon EC2 console, Elastic
        /// Block Store snapshots panel in the <b>Description</b> field, and in the Storage Gateway
        /// snapshot <b>Details</b> pane, <b>Description</b> field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string SnapshotDescription
        {
            get { return this._snapshotDescription; }
            set { this._snapshotDescription = value; }
        }

        // Check to see if SnapshotDescription property is set
        internal bool IsSetSnapshotDescription()
        {
            return this._snapshotDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags that can be assigned to a snapshot. Each tag is a key-value
        /// pair.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid characters for key and value are letters, spaces, and numbers representable
        /// in UTF-8 format, and the following special characters: + - = . _ : / @. The maximum
        /// length of a tag's key is 128 characters, and the maximum length for a tag's value
        /// is 256.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property VolumeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the iSCSI volume target. Use the <a>DescribeStorediSCSIVolumes</a>
        /// operation to return to retrieve the TargetARN for specified VolumeARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string VolumeARN
        {
            get { return this._volumeARN; }
            set { this._volumeARN = value; }
        }

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this._volumeARN != null;
        }

    }
}