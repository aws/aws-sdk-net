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
    /// The configuration for the root volume of a capacity provider instance. Specify the
    /// amount of free space to guarantee on the root volume. The device name and delete-on-termination
    /// settings are fixed and cannot be changed.
    /// </summary>
    public partial class RootVolumeConfiguration
    {
        private bool? _encrypted;
        private int? _freeSpaceGiB;
        private int? _iops;
        private string _kmsKeyId;
        private int? _throughput;
        private EbsVolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Specifies whether to encrypt the volume. Encrypted volumes can be attached only to
        /// instances that support Amazon EBS encryption. If you create a volume from a snapshot,
        /// you cannot specify an encryption value.
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
        /// Gets and sets the property FreeSpaceGiB. 
        /// <para>
        /// The free space guaranteed on the root volume, in GiB. AgentCore adds the operating
        /// system overhead on top of this value. The default is 8 GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=65000)]
        public int? FreeSpaceGiB
        {
            get { return this._freeSpaceGiB; }
            set { this._freeSpaceGiB = value; }
        }

        // Check to see if FreeSpaceGiB property is set
        internal bool IsSetFreeSpaceGiB()
        {
            return this._freeSpaceGiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of IOPS to provision. For <c>gp3</c>, <c>io1</c>, and <c>io2</c> volumes,
        /// this is the number of IOPS provisioned for the volume. For <c>gp2</c> volumes, this
        /// sets the baseline IOPS performance. It also controls the rate at which the volume
        /// accumulates I/O credits for bursting. Supported values: <c>gp3</c>, 3,000–80,000;
        /// <c>io1</c>, 100–64,000; <c>io2</c>, 100–256,000.
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
        /// The identifier (key ID, key alias, key ARN, or alias ARN) of the customer managed
        /// KMS key to use for Amazon EBS encryption.
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
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput to provision, in MiB/s. Valid only for <c>gp3</c> volumes. Valid range:
        /// 125–2,000 MiB/s.
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