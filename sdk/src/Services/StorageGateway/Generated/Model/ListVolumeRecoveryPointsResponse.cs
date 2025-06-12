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
    /// This is the response object from the ListVolumeRecoveryPoints operation.
    /// </summary>
    public partial class ListVolumeRecoveryPointsResponse : AmazonWebServiceResponse
    {
        private string _gatewayARN;
        private List<VolumeRecoveryPointInfo> _volumeRecoveryPointInfos = AWSConfigs.InitializeCollections ? new List<VolumeRecoveryPointInfo>() : null;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
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
        /// <para>
        /// An array of <a>VolumeRecoveryPointInfo</a> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VolumeRecoveryPointInfo> VolumeRecoveryPointInfos
        {
            get { return this._volumeRecoveryPointInfos; }
            set { this._volumeRecoveryPointInfos = value; }
        }

        // Check to see if VolumeRecoveryPointInfos property is set
        internal bool IsSetVolumeRecoveryPointInfos()
        {
            return this._volumeRecoveryPointInfos != null && (this._volumeRecoveryPointInfos.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}