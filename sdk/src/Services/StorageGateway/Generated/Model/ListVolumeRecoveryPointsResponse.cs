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
    public partial class ListVolumeRecoveryPointsResponse : AmazonWebServiceResponse
    {
        private string _gatewayARN;
        private List<VolumeRecoveryPointInfo> _volumeRecoveryPointInfos = new List<VolumeRecoveryPointInfo>();

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
        /// Gets and sets the property VolumeRecoveryPointInfos.
        /// </summary>
        public List<VolumeRecoveryPointInfo> VolumeRecoveryPointInfos
        {
            get { return this._volumeRecoveryPointInfos; }
            set { this._volumeRecoveryPointInfos = value; }
        }

        // Check to see if VolumeRecoveryPointInfos property is set
        internal bool IsSetVolumeRecoveryPointInfos()
        {
            return this._volumeRecoveryPointInfos != null && this._volumeRecoveryPointInfos.Count > 0; 
        }

    }
}