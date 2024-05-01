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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteVolume operation.
    /// Deletes the specified storage volume that you previously created using the <a>CreateCachediSCSIVolume</a>
    /// or <a>CreateStorediSCSIVolume</a> API. This operation is only supported in the cached
    /// volume and stored volume types. For stored volume gateways, the local disk that was
    /// configured as the storage volume is not deleted. You can reuse the local disk to create
    /// another storage volume.
    /// 
    ///  
    /// <para>
    /// Before you delete a volume, make sure there are no iSCSI connections to the volume
    /// you are deleting. You should also make sure there is no snapshot in progress. You
    /// can use the Amazon Elastic Compute Cloud (Amazon EC2) API to query snapshots on the
    /// volume you are deleting and check the snapshot status. For more information, go to
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeSnapshots.html">DescribeSnapshots</a>
    /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// In the request, you must provide the Amazon Resource Name (ARN) of the storage volume
    /// you want to delete.
    /// </para>
    /// </summary>
    public partial class DeleteVolumeRequest : AmazonStorageGatewayRequest
    {
        private string _volumeARN;

        /// <summary>
        /// Gets and sets the property VolumeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the volume. Use the <a>ListVolumes</a> operation
        /// to return a list of gateway volumes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
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