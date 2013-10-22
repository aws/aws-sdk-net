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
    /// Container for the parameters to the CreateSnapshotFromVolumeRecoveryPoint operation.
    /// 
    /// </summary>
    public partial class CreateSnapshotFromVolumeRecoveryPointRequest : AmazonWebServiceRequest
    {
        private string volumeARN;
        private string snapshotDescription;
        public string VolumeARN
        {
            get { return this.volumeARN; }
            set { this.volumeARN = value; }
        }

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this.volumeARN != null;
        }
        public string SnapshotDescription
        {
            get { return this.snapshotDescription; }
            set { this.snapshotDescription = value; }
        }

        // Check to see if SnapshotDescription property is set
        internal bool IsSetSnapshotDescription()
        {
            return this.snapshotDescription != null;
        }

    }
}
    
