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
    /// Container for the parameters to the CreateStorediSCSIVolume operation.
    /// Creates a volume on a specified gateway. This operation is only supported in the stored
    /// volume gateway type.
    /// 
    ///  
    /// <para>
    /// The size of the volume to create is inferred from the disk size. You can choose to
    /// preserve existing data on the disk, create volume from an existing snapshot, or create
    /// an empty volume. If you choose to create an empty gateway volume, then any existing
    /// data on the disk is erased.
    /// </para>
    ///  
    /// <para>
    /// In the request, you must specify the gateway and the disk information on which you
    /// are creating the volume. In response, the gateway creates the volume and returns volume
    /// information such as the volume Amazon Resource Name (ARN), its size, and the iSCSI
    /// target ARN that initiators can use to connect to the volume target.
    /// </para>
    /// </summary>
    public partial class CreateStorediSCSIVolumeRequest : AmazonStorageGatewayRequest
    {
        private string _diskId;
        private string _gatewayARN;
        private bool? _kmsEncrypted;
        private string _kmsKey;
        private string _networkInterfaceId;
        private bool? _preserveExistingData;
        private string _snapshotId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetName;

        /// <summary>
        /// Gets and sets the property DiskId. 
        /// <para>
        /// The unique identifier for the gateway local disk that is configured as a stored volume.
        /// Use <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/API_ListLocalDisks.html">ListLocalDisks</a>
        /// to list disk IDs for a gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DiskId
        {
            get { return this._diskId; }
            set { this._diskId = value; }
        }

        // Check to see if DiskId property is set
        internal bool IsSetDiskId()
        {
            return this._diskId != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property KMSEncrypted. 
        /// <para>
        /// Set to <c>true</c> to use Amazon S3 server-side encryption with your own KMS key,
        /// or <c>false</c> to use a key managed by Amazon S3. Optional.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool? KMSEncrypted
        {
            get { return this._kmsEncrypted; }
            set { this._kmsEncrypted = value; }
        }

        // Check to see if KMSEncrypted property is set
        internal bool IsSetKMSEncrypted()
        {
            return this._kmsEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KMSKey. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a symmetric customer master key (CMK) used for Amazon
        /// S3 server-side encryption. Storage Gateway does not support asymmetric CMKs. This
        /// value can only be set when <c>KMSEncrypted</c> is <c>true</c>. Optional.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=2048)]
        public string KMSKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KMSKey property is set
        internal bool IsSetKMSKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The network interface of the gateway on which to expose the iSCSI target. Accepts
        /// IPv4 and IPv6 addresses. Use <a>DescribeGatewayInformation</a> to get a list of the
        /// network interfaces available on a gateway.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: A valid IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property PreserveExistingData. 
        /// <para>
        /// Set to <c>true</c> if you want to preserve the data on the local disk. Otherwise,
        /// set to <c>false</c> to create an empty volume.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? PreserveExistingData
        {
            get { return this._preserveExistingData; }
            set { this._preserveExistingData = value; }
        }

        // Check to see if PreserveExistingData property is set
        internal bool IsSetPreserveExistingData()
        {
            return this._preserveExistingData.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The snapshot ID (e.g., "snap-1122aabb") of the snapshot to restore as the new stored
        /// volume. Specify this field if you want to create the iSCSI storage volume from a snapshot;
        /// otherwise, do not include this field. To list snapshots for your account use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags that can be assigned to a stored volume. Each tag is a key-value
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
        /// Gets and sets the property TargetName. 
        /// <para>
        /// The name of the iSCSI target used by an initiator to connect to a volume and used
        /// as a suffix for the target ARN. For example, specifying <c>TargetName</c> as <i>myvolume</i>
        /// results in the target ARN of <c>arn:aws:storagegateway:us-east-2:111122223333:gateway/sgw-12A3456B/target/iqn.1997-05.com.amazon:myvolume</c>.
        /// The target name must be unique across all volumes on a gateway.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, Storage Gateway uses the value that was previously used
        /// for this volume as the new target name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string TargetName
        {
            get { return this._targetName; }
            set { this._targetName = value; }
        }

        // Check to see if TargetName property is set
        internal bool IsSetTargetName()
        {
            return this._targetName != null;
        }

    }
}