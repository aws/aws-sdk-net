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
    /// <para>This operation creates a cached volume on a specified cached gateway. This operation is supported only for the gateway-cached volume
    /// architecture.</para> <para><b>NOTE:</b>Cache storage must be allocated to the gateway before you can create a cached volume. Use the
    /// AddCache operation to add cache storage to a gateway. </para> <para>In the request, you must specify the gateway, size of the volume in
    /// bytes, the iSCSI target name, an IP address on which to expose the target, and a unique client token. In response, AWS Storage Gateway
    /// creates the volume and returns information about it such as the volume Amazon Resource Name (ARN), its size, and the iSCSI target ARN that
    /// initiators can use to connect to the volume target.</para>
    /// </summary>
    /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.CreateCachediSCSIVolume"/>
    public class CreateCachediSCSIVolumeRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the GatewayARN property
        /// </summary>
        /// <param name="gatewayARN">The value to set for the GatewayARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateCachediSCSIVolumeRequest WithGatewayARN(string gatewayARN)
        {
            this.gatewayARN = gatewayARN;
            return this;
        }
            

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;       
        }

        /// <summary>
        /// The size of the cached volume.
        ///  
        /// </summary>
        public long VolumeSizeInBytes
        {
            get { return this.volumeSizeInBytes ?? default(long); }
            set { this.volumeSizeInBytes = value; }
        }

        /// <summary>
        /// Sets the VolumeSizeInBytes property
        /// </summary>
        /// <param name="volumeSizeInBytes">The value to set for the VolumeSizeInBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateCachediSCSIVolumeRequest WithVolumeSizeInBytes(long volumeSizeInBytes)
        {
            this.volumeSizeInBytes = volumeSizeInBytes;
            return this;
        }
            

        // Check to see if VolumeSizeInBytes property is set
        internal bool IsSetVolumeSizeInBytes()
        {
            return this.volumeSizeInBytes.HasValue;       
        }

        /// <summary>
        /// The snapshot ID (e.g., "snap-1122aabb") of the snapshot to restore as the new stored volume. Specify this field if you want to create the
        /// iSCSI cached volume from a snapshot; otherwise, do not include this field. To list snapshots for your account, use <a
        /// href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a> in
        /// Amazon Elastic Compute Cloud API Reference.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>\Asnap-[0-9a-fA-F]{8}\z</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this.snapshotId; }
            set { this.snapshotId = value; }
        }

        /// <summary>
        /// Sets the SnapshotId property
        /// </summary>
        /// <param name="snapshotId">The value to set for the SnapshotId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateCachediSCSIVolumeRequest WithSnapshotId(string snapshotId)
        {
            this.snapshotId = snapshotId;
            return this;
        }
            

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this.snapshotId != null;       
        }

        /// <summary>
        /// The name of the iSCSI target used by initiators to connect to the target and as a suffix for the target ARN. For example, specifying
        /// <b>TargetName</b> as <i>myvolume</i> results in the target ARN of
        /// <i>arn:aws:storagegateway:us-east-1:111122223333:gateway/mygateway/target/iqn.1997-05.com.amazon:myvolume</i>. The target name must be
        /// unique across all volumes of a gateway.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 200</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^[-\.;a-z0-9]+$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TargetName
        {
            get { return this.targetName; }
            set { this.targetName = value; }
        }

        /// <summary>
        /// Sets the TargetName property
        /// </summary>
        /// <param name="targetName">The value to set for the TargetName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateCachediSCSIVolumeRequest WithTargetName(string targetName)
        {
            this.targetName = targetName;
            return this;
        }
            

        // Check to see if TargetName property is set
        internal bool IsSetTargetName()
        {
            return this.targetName != null;       
        }

        /// <summary>
        /// The network interface of the gateway on which to expose the iSCSI target. Only IPv4 addresses are accepted. Use the
        /// <a>DescribeGatewayInformation</a> operation to get a list of the network interfaces available on the gateway.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>\A(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}\z</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceId; }
            set { this.networkInterfaceId = value; }
        }

        /// <summary>
        /// Sets the NetworkInterfaceId property
        /// </summary>
        /// <param name="networkInterfaceId">The value to set for the NetworkInterfaceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateCachediSCSIVolumeRequest WithNetworkInterfaceId(string networkInterfaceId)
        {
            this.networkInterfaceId = networkInterfaceId;
            return this;
        }
            

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;       
        }

        /// <summary>
        /// A unique identifying string for the cached volume.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>5 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this.clientToken; }
            set { this.clientToken = value; }
        }

        /// <summary>
        /// Sets the ClientToken property
        /// </summary>
        /// <param name="clientToken">The value to set for the ClientToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateCachediSCSIVolumeRequest WithClientToken(string clientToken)
        {
            this.clientToken = clientToken;
            return this;
        }
            

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this.clientToken != null;       
        }
    }
}
    
