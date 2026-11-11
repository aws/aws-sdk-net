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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReplaceRootVolumeTask operation. Replaces
    /// the EBS-backed root volume for a <c>running</c> instance with a new volume that is
    /// restored to the original root volume's launch state, that is restored to a specific
    /// snapshot taken from the original root volume, that is restored from an AMI that has
    /// the same key characteristics as that of the instance, or that is replaced by a specified
    /// volume. <para> For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/replace-root.html">Replace
    /// a root volume</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </summary>
    public partial class CreateReplaceRootVolumeTaskRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// If you do not specify a client token, a randomly generated token is used for the request
        /// to ensure idempotency. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DeleteReplacedRootVolume. 
        /// <para>
        /// Indicates whether to automatically delete the original root volume after the root
        /// volume replacement task completes. To delete the original root volume, specify <c>true</c>.
        /// If you choose to keep the original root volume after the replacement task completes,
        /// you must manually delete it when you no longer need it.
        /// </para>
        /// </summary>
        public bool? DeleteReplacedRootVolume { get; set; }

        /// <summary>
        /// Checks to see if the DeleteReplacedRootVolume property is set.
        /// </summary>
        internal bool IsSetDeleteReplacedRootVolume() => this.DeleteReplacedRootVolume.HasValue;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI to use to restore the root volume. The specified AMI must have the
        /// same product code, billing information, architecture type, and virtualization type
        /// as that of the instance.
        /// </para>
        ///  
        /// <para>
        /// If you want to restore the replacement volume from a specific snapshot, if you want
        /// to restore it to its launch state, or if you want to replace the root volume with
        /// a specified volume, omit this parameter.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance for which to replace the root volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot from which to restore the replacement root volume. The specified
        /// snapshot must be a snapshot that you previously created from the original root volume.
        /// </para>
        ///  
        /// <para>
        /// If you want to restore the replacement root volume to the initial launch state, if
        /// you want to restore the replacement root volume from an AMI, or if you want to replace
        /// the root volume with a specified volume, omit this parameter.
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the root volume replacement task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume to use as the replacement root volume. The specified volume must
        /// be in the same Availability Zone as the instance, must be in the <c>available</c>
        /// state, and must not be attached to an instance. If the original root volume is encrypted,
        /// the specified volume must also be encrypted.
        /// </para>
        ///  
        /// <para>
        /// If you want to restore the replacement root volume from a specific snapshot, an AMI,
        /// or to its launch state, omit this parameter.
        /// </para>
        /// </summary>
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;

        /// <summary>
        /// Gets and sets the property VolumeInitializationRate. 
        /// <para>
        /// Specifies the Amazon EBS Provisioned Rate for Volume Initialization (volume initialization
        /// rate), in MiB/s, at which to download the snapshot blocks from Amazon S3 to the replacement
        /// root volume. This is also known as <i>volume initialization</i>. Specifying a volume
        /// initialization rate ensures that the volume is initialized at a predictable and consistent
        /// rate after creation.
        /// </para>
        ///  
        /// <para>
        /// Omit this parameter if:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You want to create the volume using fast snapshot restore. You must specify a snapshot
        /// that is enabled for fast snapshot restore. In this case, the volume is fully initialized
        /// at creation.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify a snapshot that is enabled for fast snapshot restore and a volume initialization
        /// rate, the volume will be initialized at the specified rate instead of fast snapshot
        /// restore.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// You want to create a volume that is initialized at the default rate.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/initalize-volume.html">
        /// Initialize Amazon EBS volumes</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid range: 100 - 300 MiB/s
        /// </para>
        /// </summary>
        public long? VolumeInitializationRate { get; set; }

        /// <summary>
        /// Checks to see if the VolumeInitializationRate property is set.
        /// </summary>
        internal bool IsSetVolumeInitializationRate() => this.VolumeInitializationRate.HasValue;
    }
}
