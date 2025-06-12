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
    /// Container for the parameters to the DescribeVTLDevices operation.
    /// Returns a description of virtual tape library (VTL) devices for the specified tape
    /// gateway. In the response, Storage Gateway returns VTL device information.
    /// 
    ///  
    /// <para>
    /// This operation is only supported in the tape gateway type.
    /// </para>
    /// </summary>
    public partial class DescribeVTLDevicesRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;
        private int? _limit;
        private string _marker;
        private List<string> _vtlDeviceARNs = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
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
        /// Gets and sets the property Limit. 
        /// <para>
        /// Specifies that the number of VTL devices described be limited to the specified number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string that indicates the position at which to begin describing the VTL
        /// devices.
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
        /// Gets and sets the property VTLDeviceARNs. 
        /// <para>
        /// An array of strings, where each string represents the Amazon Resource Name (ARN) of
        /// a VTL device.
        /// </para>
        ///  <note> 
        /// <para>
        /// All of the specified VTL devices must be from the same gateway. If no VTL devices
        /// are specified, the result will contain all devices on the specified gateway.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VTLDeviceARNs
        {
            get { return this._vtlDeviceARNs; }
            set { this._vtlDeviceARNs = value; }
        }

        // Check to see if VTLDeviceARNs property is set
        internal bool IsSetVTLDeviceARNs()
        {
            return this._vtlDeviceARNs != null && (this._vtlDeviceARNs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}