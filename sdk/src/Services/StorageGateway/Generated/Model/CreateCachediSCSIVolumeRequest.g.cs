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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCachediSCSIVolume operation. Creates a cached
    /// volume on a specified cached volume gateway. This operation is only supported in the
    /// cached volume gateway type. <note> <para> Cache storage must be allocated to the gateway
    /// before you can create a cached volume. Use the <a>AddCache</a> operation to add cache
    /// storage to a gateway. </para> </note> <para> In the request, you must specify the
    /// gateway, size of the volume in bytes, the iSCSI target name, an IP address on which
    /// to expose the target, and a unique client token. In response, the gateway creates
    /// the volume and returns information about it. This information includes the volume
    /// Amazon Resource Name (ARN), its size, and the iSCSI target ARN that initiators can
    /// use to connect to the volume target. </para> <para> Optionally, you can provide the
    /// ARN for an existing volume as the <c>SourceVolumeARN</c> for this cached volume, which
    /// creates an exact copy of the existing volume’s latest recovery point. The <c>VolumeSizeInBytes</c>
    /// value must be equal to or larger than the size of the copied volume, in bytes. </para>
    /// </summary>
    public partial class CreateCachediSCSIVolumeRequest : AmazonStorageGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier that you use to retry a request. If you retry a request, use the
        /// same <c>ClientToken</c> you specified in the initial request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required = true, Min = 50, Max = 500)]
        public string GatewayARN { get; set; }

        /// <summary>
        /// Checks to see if the GatewayARN property is set.
        /// </summary>
        internal bool IsSetGatewayARN() => this.GatewayARN != null;

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
        public bool? KMSEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the KMSEncrypted property is set.
        /// </summary>
        internal bool IsSetKMSEncrypted() => this.KMSEncrypted.HasValue;

        /// <summary>
        /// Gets and sets the property KMSKey. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a symmetric customer master key (CMK) used for Amazon
        /// S3 server-side encryption. Storage Gateway does not support asymmetric CMKs. This
        /// value can only be set when <c>KMSEncrypted</c> is <c>true</c>. Optional.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 2048)]
        public string KMSKey { get; set; }

        /// <summary>
        /// Checks to see if the KMSKey property is set.
        /// </summary>
        internal bool IsSetKMSKey() => this.KMSKey != null;

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
        [AWSProperty(Required = true)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The snapshot ID (e.g. "snap-1122aabb") of the snapshot to restore as the new cached
        /// volume. Specify this field if you want to create the iSCSI storage volume from a snapshot;
        /// otherwise, do not include this field. To list snapshots for your account use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property SourceVolumeARN. 
        /// <para>
        /// The ARN for an existing volume. Specifying this ARN makes the new volume into an exact
        /// copy of the specified existing volume's latest recovery point. The <c>VolumeSizeInBytes</c>
        /// value for this new volume must be equal to or larger than the size of the existing
        /// volume, in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string SourceVolumeARN { get; set; }

        /// <summary>
        /// Checks to see if the SourceVolumeARN property is set.
        /// </summary>
        internal bool IsSetSourceVolumeARN() => this.SourceVolumeARN != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags that you can assign to a cached volume. Each tag is a key-value
        /// pair.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid characters for key and value are letters, spaces, and numbers that you can represent
        /// in UTF-8 format, and the following special characters: + - = . _ : / @. The maximum
        /// length of a tag's key is 128 characters, and the maximum length for a tag's value
        /// is 256 characters.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string TargetName { get; set; }

        /// <summary>
        /// Checks to see if the TargetName property is set.
        /// </summary>
        internal bool IsSetTargetName() => this.TargetName != null;

        /// <summary>
        /// Gets and sets the property VolumeSizeInBytes. 
        /// <para>
        /// The size of the volume in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? VolumeSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSizeInBytes property is set.
        /// </summary>
        internal bool IsSetVolumeSizeInBytes() => this.VolumeSizeInBytes.HasValue;
    }
}
