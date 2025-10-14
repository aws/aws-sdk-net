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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the CopyVolumes operation.
    /// Creates a crash-consistent, point-in-time copy of an existing Amazon EBS volume within
    /// the same Availability Zone. The volume copy can be attached to an Amazon EC2 instance
    /// once it reaches the <c>available</c> state. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-copying-volume.html">Copy
    /// an Amazon EBS volume</a>.
    /// </summary>
    public partial class CopyVolumesRequest : AmazonEC2Request
    {
        private string _clientToken;
        private int? _iops;
        private bool? _multiAttachEnabled;
        private int? _size;
        private string _sourceVolumeId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private int? _throughput;
        private VolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">
        /// Ensure Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of I/O operations per second (IOPS) to provision for the volume copy. Required
        /// for <c>io1</c> and <c>io2</c> volumes. Optional for <c>gp3</c> volumes. Omit for all
        /// other volume types. Full provisioned IOPS performance can be achieved only once the
        /// volume copy is fully initialized. 
        /// </para>
        ///  
        /// <para>
        /// Valid ranges:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// gp3: <c>3,000 </c>(<i>default</i>)<c> - 80,000</c> IOPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// io1: <c>100 - 64,000</c> IOPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// io2: <c>100 - 256,000</c> IOPS
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-nitro-instances.html">
        /// Instances built on the Nitro System</a> can support up to 256,000 IOPS. Other instances
        /// can support up to 32,000 IOPS.
        /// </para>
        ///  </note>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultiAttachEnabled. 
        /// <para>
        /// Indicates whether to enable Amazon EBS Multi-Attach for the volume copy. If you enable
        /// Multi-Attach, you can attach the volume to up to 16 Nitro instances in the same Availability
        /// Zone simultaneously. Supported with <c>io1</c> and <c>io2</c> volumes only. For more
        /// information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-volumes-multi.html">
        /// Amazon EBS Multi-Attach</a>.
        /// </para>
        /// </summary>
        public bool MultiAttachEnabled
        {
            get { return this._multiAttachEnabled.GetValueOrDefault(); }
            set { this._multiAttachEnabled = value; }
        }

        // Check to see if MultiAttachEnabled property is set
        internal bool IsSetMultiAttachEnabled()
        {
            return this._multiAttachEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the volume copy, in GiBs. The size must be equal to or greater than the
        /// size of the source volume. If not specified, the size defaults to the size of the
        /// source volume.
        /// </para>
        ///  
        /// <para>
        /// Maximum supported sizes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// gp2: <c>16,384</c> GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// gp3: <c>65,536</c> GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// io1: <c>16,384</c> GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// io2: <c>65,536</c> GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// st1 and sc1: <c>16,384</c> GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// standard: <c>1024</c> GiB
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceVolumeId. 
        /// <para>
        /// The ID of the source EBS volume to copy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceVolumeId
        {
            get { return this._sourceVolumeId; }
            set { this._sourceVolumeId = value; }
        }

        // Check to see if SourceVolumeId property is set
        internal bool IsSetSourceVolumeId()
        {
            return this._sourceVolumeId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the volume copy during creation.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput to provision for the volume copy, in MiB/s. Supported for <c>gp3</c>
        /// volumes only. Omit for all other volume types. Full provisioned throughput performance
        /// can be achieved only once the volume copy is fully initialized.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: <c>125 - 2000</c> MiB/s
        /// </para>
        /// </summary>
        public int Throughput
        {
            get { return this._throughput.GetValueOrDefault(); }
            set { this._throughput = value; }
        }

        // Check to see if Throughput property is set
        internal bool IsSetThroughput()
        {
            return this._throughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type for the volume copy. If not specified, the volume type defaults to
        /// <c>gp2</c>.
        /// </para>
        /// </summary>
        public VolumeType VolumeType
        {
            get { return this._volumeType; }
            set { this._volumeType = value; }
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this._volumeType != null;
        }

    }
}