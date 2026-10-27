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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVolume operation. Modifies the size, volume
    /// type, IOPS (input/output operations per second), or throughput of a volume. When you
    /// modify a volume, you must specify at least one of these parameters. You can modify
    /// a volume only after any previous modification for that volume has finished. <para>
    /// To track the progress of a modification, use the Amazon EC2 <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeVolumesModifications.html">DescribeVolumesModifications</a>
    /// operation. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/monitoring-volume-modifications.html">Monitor
    /// the progress of Amazon EBS volume modifications</a> in the <i>Amazon EBS User Guide</i>.
    /// </para> <para> After you increase the size of a volume, you must extend the partition
    /// and file system to use the new storage capacity. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/recognize-expanded-volume-linux.html">Extend
    /// the file system after resizing an Amazon EBS volume</a> in the <i>Amazon EBS User
    /// Guide</i>, which covers both <a href="https://docs.aws.amazon.com/ebs/latest/userguide/recognize-expanded-volume-linux.html#extend-linux">Linux</a>
    /// and <a href="https://docs.aws.amazon.com/ebs/latest/userguide/recognize-expanded-volume-linux.html#extend-windows">Windows</a>
    /// instances. </para>
    /// </summary>
    public partial class ModifyVolumeRequest : AmazonWorkspacesInstancesRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique token to ensure idempotent volume modification, preventing duplicate volume
        /// modifications.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// Specifies the target IOPS rate of the volume. This parameter is valid only for <c>gp3</c>,
        /// <c>io1</c>, and <c>io2</c> volumes. If you don't specify IOPS and keep the same volume
        /// type, the current IOPS rate is retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property SizeInGB. 
        /// <para>
        /// Specifies the target size of the volume, in GiB. The target size must be greater than
        /// or equal to the current size of the volume. If you don't specify a size, the current
        /// size is retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16384)]
        public int? SizeInGB { get; set; }

        /// <summary>
        /// Checks to see if the SizeInGB property is set.
        /// </summary>
        internal bool IsSetSizeInGB() => this.SizeInGB.HasValue;

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// Specifies the target throughput of the volume, in MiB/s. This parameter is valid only
        /// for <c>gp3</c> volumes. If you don't specify throughput and the volume remains <c>gp3</c>,
        /// the current throughput is retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Throughput { get; set; }

        /// <summary>
        /// Checks to see if the Throughput property is set.
        /// </summary>
        internal bool IsSetThroughput() => this.Throughput.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// Specifies the identifier of the volume to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// Specifies the target Amazon Elastic Block Store (Amazon EBS) volume type. If you don't
        /// specify a volume type, the current volume type is retained.
        /// </para>
        /// </summary>
        public VolumeTypeEnum VolumeType { get; set; }

        /// <summary>
        /// Checks to see if the VolumeType property is set.
        /// </summary>
        internal bool IsSetVolumeType() => this.VolumeType != null;
    }
}
