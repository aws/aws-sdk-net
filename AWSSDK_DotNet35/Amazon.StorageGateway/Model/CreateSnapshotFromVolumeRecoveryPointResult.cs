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
    /// 
    /// </summary>
    public partial class CreateSnapshotFromVolumeRecoveryPointResult : AmazonWebServiceResponse
    {
        private string _snapshotId;
        private string _volumeARN;
        private string _volumeRecoveryPointTime;

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

        /// <summary>
        /// Gets and sets the property VolumeRecoveryPointTime.
        /// </summary>
        public string VolumeRecoveryPointTime
        {
            get { return this._volumeRecoveryPointTime; }
            set { this._volumeRecoveryPointTime = value; }
        }

        // Check to see if VolumeRecoveryPointTime property is set
        internal bool IsSetVolumeRecoveryPointTime()
        {
            return this._volumeRecoveryPointTime != null;
        }

    }
}