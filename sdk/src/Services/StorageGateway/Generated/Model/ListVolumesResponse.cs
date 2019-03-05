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
    /// A JSON object containing the following fields:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListVolumesOutput$Marker</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListVolumesOutput$VolumeInfos</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListVolumesResponse : AmazonWebServiceResponse
    {
        private string _gatewayARN;
        private string _marker;
        private List<VolumeInfo> _volumeInfos = new List<VolumeInfo>();

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
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use the marker in your next request to continue pagination of iSCSI volumes. If there
        /// are no more volumes to list, this field does not appear in the response body.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeInfos. 
        /// <para>
        /// An array of <a>VolumeInfo</a> objects, where each object describes an iSCSI volume.
        /// If no volumes are defined for the gateway, then <code>VolumeInfos</code> is an empty
        /// array "[]".
        /// </para>
        /// </summary>
        public List<VolumeInfo> VolumeInfos
        {
            get { return this._volumeInfos; }
            set { this._volumeInfos = value; }
        }

        // Check to see if VolumeInfos property is set
        internal bool IsSetVolumeInfos()
        {
            return this._volumeInfos != null && this._volumeInfos.Count > 0; 
        }

    }
}