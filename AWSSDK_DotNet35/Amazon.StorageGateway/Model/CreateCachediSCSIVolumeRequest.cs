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
    /// Container for the parameters to the CreateCachediSCSIVolume operation.
    /// This operation creates a cached volume on a specified cached gateway. This operation
    /// is supported only for the gateway-cached volume architecture.
    /// 
    ///  <note>Cache storage must be allocated to the gateway before you can create a cached
    /// volume. Use the <a>AddCache</a> operation to add cache storage to a gateway. </note>
    /// 
    /// <para>
    /// In the request, you must specify the gateway, size of the volume in bytes, the iSCSI
    /// target name, an IP address on which to expose the target, and a unique client token.
    /// In response, AWS Storage Gateway creates the volume and returns information about
    /// it such as the volume Amazon Resource Name (ARN), its size, and the iSCSI target ARN
    /// that initiators can use to connect to the volume target.
    /// </para>
    /// </summary>
    public partial class CreateCachediSCSIVolumeRequest : AmazonStorageGatewayRequest
    {
        private string _clientToken;
        private string _gatewayARN;
        private string _networkInterfaceId;
        private string _snapshotId;
        private string _targetName;
        private long? _volumeSizeInBytes;

        /// <summary>
        /// Gets and sets the property ClientToken.
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
        /// Gets and sets the property SnapshotId.
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

        /// <summary>
        /// Gets and sets the property VolumeSizeInBytes.
        /// </summary>
        public long VolumeSizeInBytes
        {
            get { return this._volumeSizeInBytes.GetValueOrDefault(); }
            set { this._volumeSizeInBytes = value; }
        }

        // Check to see if VolumeSizeInBytes property is set
        internal bool IsSetVolumeSizeInBytes()
        {
            return this._volumeSizeInBytes.HasValue; 
        }

    }
}