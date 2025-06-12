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
    /// DescribeVTLDevicesOutput
    /// </summary>
    public partial class DescribeVTLDevicesResponse : AmazonWebServiceResponse
    {
        private string _gatewayARN;
        private string _marker;
        private List<VTLDevice> _vtlDevices = AWSConfigs.InitializeCollections ? new List<VTLDevice>() : null;

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
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string that indicates the position at which the VTL devices that were fetched
        /// for description ended. Use the marker in your next request to fetch the next set of
        /// VTL devices in the list. If there are no more VTL devices to describe, this field
        /// does not appear in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// Gets and sets the property VTLDevices. 
        /// <para>
        /// An array of VTL device objects composed of the Amazon Resource Name (ARN) of the VTL
        /// devices.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VTLDevice> VTLDevices
        {
            get { return this._vtlDevices; }
            set { this._vtlDevices = value; }
        }

        // Check to see if VTLDevices property is set
        internal bool IsSetVTLDevices()
        {
            return this._vtlDevices != null && (this._vtlDevices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}