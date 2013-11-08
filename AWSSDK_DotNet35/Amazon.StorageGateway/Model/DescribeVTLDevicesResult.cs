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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>DescribeVTLDevicesOutput</para>
    /// </summary>
    public partial class DescribeVTLDevicesResult : AmazonWebServiceResponse
    {
        
        private string gatewayARN;
        private List<VTLDevice> vTLDevices = new List<VTLDevice>();
        private string marker;


        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation to return a list of gateways for your account and
        /// region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }

        /// <summary>
        /// An array of VTL device objects composed of the Amazon Resource Name(ARN) of the VTL devices.
        ///  
        /// </summary>
        public List<VTLDevice> VTLDevices
        {
            get { return this.vTLDevices; }
            set { this.vTLDevices = value; }
        }

        // Check to see if VTLDevices property is set
        internal bool IsSetVTLDevices()
        {
            return this.vTLDevices.Count > 0;
        }

        /// <summary>
        /// An opaque string that indicates the position at which the VTL devices that were fetched for description ended. Use the marker in your next
        /// request to fetch the next set of VTL devices in the list. If there are no more VTL devices to describe, this field does not appear in the
        /// response.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
