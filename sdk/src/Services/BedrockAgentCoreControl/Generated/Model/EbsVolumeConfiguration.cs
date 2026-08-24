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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration for an Amazon EBS-backed persistent volume. The service creates
    /// persistent volumes when a session first launches, and the volumes survive instance
    /// termination. The volumes persist until you delete the session.
    /// </summary>
    public partial class EbsVolumeConfiguration
    {
        private bool? _encrypted;
        private int? _iops;
        private string _kmsKeyId;
        private string _name;
        private int? _sizeGiB;
        private string _snapshotId;
        private int? _throughput;
        private EbsVolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Specifies whether to encrypt the volume. If <c>true</c>, the service encrypts the
        /// volume with the KMS key that you specify in <c>kmsKeyId</c>, or the default KMS key
        /// for Amazon EBS if you do not specify one. The default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? Encrypted
        {
            get { return this._encrypted; }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of IOPS to provision. Valid only for <c>gp3</c>, <c>io1</c>, and <c>io2</c>
        /// volumes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=256000)]
        public int? Iops
        {
            get { return this._iops; }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the KMS key to use for encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The logical name of the volume. Use this name to reference the volume when you mount
        /// it into an agent runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SizeGiB. 
        /// <para>
        /// The size of the volume, in GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65536)]
        public int? SizeGiB
        {
            get { return this._sizeGiB; }
            set { this._sizeGiB = value; }
        }

        // Check to see if SizeGiB property is set
        internal bool IsSetSizeGiB()
        {
            return this._sizeGiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// An optional Amazon EBS snapshot ID. If provided, the volume is initialized from this
        /// snapshot the first time it is created. On subsequent restarts, the existing volume
        /// is used and the snapshot is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=13, Max=64)]
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
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput, in MiB/s. Valid only for <c>gp3</c> volumes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=125, Max=2000)]
        public int? Throughput
        {
            get { return this._throughput; }
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
        /// The Amazon EBS volume type. If you do not specify a type, the default is <c>gp3</c>.
        /// </para>
        /// </summary>
        public EbsVolumeType VolumeType
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