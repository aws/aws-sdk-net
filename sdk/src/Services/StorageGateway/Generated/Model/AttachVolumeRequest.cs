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
    /// Container for the parameters to the AttachVolume operation.
    /// Connects a volume to an iSCSI connection and then attaches the volume to the specified
    /// gateway. Detaching and attaching a volume enables you to recover your data from one
    /// gateway to a different gateway without creating a snapshot. It also makes it easier
    /// to move your volumes from an on-premises gateway to a gateway hosted on an Amazon
    /// EC2 instance.
    /// </summary>
    public partial class AttachVolumeRequest : AmazonStorageGatewayRequest
    {
        private string _diskId;
        private string _gatewayARN;
        private string _networkInterfaceId;
        private string _targetName;
        private string _volumeARN;

        /// <summary>
        /// Gets and sets the property DiskId. 
        /// <para>
        /// The unique device ID or other distinguishing data that identifies the local disk used
        /// to create the volume. This value is only required when you are attaching a stored
        /// volume.
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
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway that you want to attach the volume to.
        /// </para>
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
        ///  Valid Values: A valid IP address.
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
        /// Gets and sets the property TargetName. 
        /// <para>
        /// The name of the iSCSI target used by an initiator to connect to a volume and used
        /// as a suffix for the target ARN. For example, specifying <code>TargetName</code> as
        /// <i>myvolume</i> results in the target ARN of <code>arn:aws:storagegateway:us-east-2:111122223333:gateway/sgw-12A3456B/target/iqn.1997-05.com.amazon:myvolume</code>.
        /// The target name must be unique across all volumes on a gateway.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, Storage Gateway uses the value that was previously used
        /// for this volume as the new target name.
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

        /// <summary>
        /// Gets and sets the property VolumeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the volume to attach to the specified gateway.
        /// </para>
        /// </summary>
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