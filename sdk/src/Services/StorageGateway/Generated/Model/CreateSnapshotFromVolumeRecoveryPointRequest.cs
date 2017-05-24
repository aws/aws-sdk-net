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
    /// Container for the parameters to the CreateSnapshotFromVolumeRecoveryPoint operation.
    /// Initiates a snapshot of a gateway from a volume recovery point. This operation is
    /// only supported in the cached volume gateway architecture.
    /// 
    ///  
    /// <para>
    /// A volume recovery point is a point in time at which all data of the volume is consistent
    /// and from which you can create a snapshot. To get a list of volume recovery point for
    /// cached volume gateway, use <a>ListVolumeRecoveryPoints</a>.
    /// </para>
    ///  
    /// <para>
    /// In the <code>CreateSnapshotFromVolumeRecoveryPoint</code> request, you identify the
    /// volume by providing its Amazon Resource Name (ARN). You must also provide a description
    /// for the snapshot. When the gateway takes a snapshot of the specified volume, the snapshot
    /// and its description appear in the AWS Storage Gateway console. In response, the gateway
    /// returns you a snapshot ID. You can use this snapshot ID to check the snapshot progress
    /// or later use it when you want to create a volume from a snapshot.
    /// </para>
    ///  <note> 
    /// <para>
    /// To list or delete a snapshot, you must use the Amazon EC2 API. For more information,
    /// in <i>Amazon Elastic Compute Cloud API Reference</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateSnapshotFromVolumeRecoveryPointRequest : AmazonStorageGatewayRequest
    {
        private string _snapshotDescription;
        private string _volumeARN;

        /// <summary>
        /// Gets and sets the property SnapshotDescription.
        /// </summary>
        public string SnapshotDescription
        {
            get { return this._snapshotDescription; }
            set { this._snapshotDescription = value; }
        }

        // Check to see if SnapshotDescription property is set
        internal bool IsSetSnapshotDescription()
        {
            return this._snapshotDescription != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeARN.
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