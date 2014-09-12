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
    /// Container for the parameters to the DeleteSnapshotSchedule operation.
    /// This operation deletes a snapshot of a volume. 
    /// 
    ///  
    /// <para>
    ///  You can take snapshots of your gateway volumes on a scheduled or ad-hoc basis. This
    /// API enables you to delete a snapshot schedule for a volume. For more information,
    /// see <a href="http://docs.aws.amazon.com/storagegateway/latest/userguide/WorkingWithSnapshots.html">Working
    /// with Snapshots</a>. In the <code>DeleteSnapshotSchedule</code> request, you identify
    /// the volume by providing its Amazon Resource Name (ARN). 
    /// </para>
    /// </summary>
    public partial class DeleteSnapshotScheduleRequest : AmazonStorageGatewayRequest
    {
        private string _volumeARN;

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