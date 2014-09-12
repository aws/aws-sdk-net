/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStorediSCSIVolume operation.
    /// This operation creates a volume on a specified gateway. This operation is supported
    /// only for the gateway-stored volume architecture. 
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
    /// In the request you must specify the gateway and the disk information on which you
    /// are creating the volume. In response, AWS Storage Gateway creates the volume and returns
    /// volume information such as the volume Amazon Resource Name (ARN), its size, and the
    /// iSCSI target ARN that initiators can use to connect to the volume target.
    /// </para>
    /// </summary>
    public partial class CreateStorediSCSIVolumeRequest : AmazonStorageGatewayRequest
    {
        private string _diskId;
        private string _gatewayARN;
        private string _networkInterfaceId;
        private bool? _preserveExistingData;
        private string _snapshotId;
        private string _targetName;

        /// <summary>
        /// Gets and sets the property DiskId. 
        /// <para>
        /// The unique identifier for the gateway local disk that is configured as a stored volume.
        /// Use <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/API_ListLocalDisks.html">ListLocalDisks</a>
        /// to list disk IDs for a gateway.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The network interface of the gateway on which to expose the iSCSI target. Only IPv4
        /// addresses are accepted. Use <a>DescribeGatewayInformation</a> to get a list of the
        /// network interfaces available on a gateway.
        /// </para>
        ///  
        /// <para>
        /// <i>Valid Values</i>: A valid IP address.
        /// </para>
        /// </summary>
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
        /// Specify this field as true if you want to preserve the data on the local disk. Otherwise,
        /// specifying this field as false creates an empty volume.
        /// </para>
        ///  
        /// <para>
        /// <i>Valid Values</i>: true, false
        /// </para>
        /// </summary>
        public bool PreserveExistingData
        {
            get { return this._preserveExistingData.GetValueOrDefault(); }
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
        /// The snapshot ID (e.g. "snap-1122aabb") of the snapshot to restore as the new stored
        /// volume. Specify this field if you want to create the iSCSI storage volume from a snapshot
        /// otherwise do not include this field. To list snapshots for your account use <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a>
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
        /// Gets and sets the property TargetName. 
        /// <para>
        /// The name of the iSCSI target used by initiators to connect to the target and as a
        /// suffix for the target ARN. For example, specifying <code>TargetName</code> as <i>myvolume</i>
        /// results in the target ARN of arn:aws:storagegateway:us-east-1:111122223333:gateway/mygateway/target/iqn.1997-05.com.amazon:myvolume.
        /// The target name must be unique across all volumes of a gateway.
        /// </para>
        /// </summary>
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