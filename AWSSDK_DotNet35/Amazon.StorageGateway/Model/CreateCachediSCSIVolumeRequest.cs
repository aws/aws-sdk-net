/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// 
    /// </summary>
    public partial class CreateCachediSCSIVolumeRequest : AmazonWebServiceRequest
    {
        private string gatewayARN;
        private long? volumeSizeInBytes;
        private string snapshotId;
        private string targetName;
        private string networkInterfaceId;
        private string clientToken;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation to return a list of gateways for your account and
        /// region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }
        public long VolumeSizeInBytes
        {
            get { return this.volumeSizeInBytes ?? default(long); }
            set { this.volumeSizeInBytes = value; }
        }

        // Check to see if VolumeSizeInBytes property is set
        internal bool IsSetVolumeSizeInBytes()
        {
            return this.volumeSizeInBytes.HasValue;
        }
        public string SnapshotId
        {
            get { return this.snapshotId; }
            set { this.snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this.snapshotId != null;
        }
        public string TargetName
        {
            get { return this.targetName; }
            set { this.targetName = value; }
        }

        // Check to see if TargetName property is set
        internal bool IsSetTargetName()
        {
            return this.targetName != null;
        }
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceId; }
            set { this.networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;
        }
        public string ClientToken
        {
            get { return this.clientToken; }
            set { this.clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this.clientToken != null;
        }

    }
}
    
