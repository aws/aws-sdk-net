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
    /// Container for the parameters to the DescribeVTLDevices operation.
    /// <para>Returns a description of virtual tape library (VTL) devices for the specified gateway. In the response, AWS Storage Gateway returns
    /// VTL device information. </para> <para>The list of VTL devices must be from one gateway.</para>
    /// </summary>
    public partial class DescribeVTLDevicesRequest : AmazonStorageGatewayRequest
    {
        private string gatewayARN;
        private List<string> vTLDeviceARNs = new List<string>();
        private string marker;
        private int? limit;


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
        /// An array of strings, where each string represents the Amazon Resource Name (ARN) of a VTL device. <note>All of the specified VTL devices
        /// must be from the same gateway. If no VTL devices are specified, the result will contain all devices on the specified gateway.</note>
        ///  
        /// </summary>
        public List<string> VTLDeviceARNs
        {
            get { return this.vTLDeviceARNs; }
            set { this.vTLDeviceARNs = value; }
        }

        // Check to see if VTLDeviceARNs property is set
        internal bool IsSetVTLDeviceARNs()
        {
            return this.vTLDeviceARNs.Count > 0;
        }

        /// <summary>
        /// An opaque string that indicates the position at which to begin describing the VTL devices.
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

        /// <summary>
        /// Specifies that the number of VTL devices described be limited to the specified number.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;
        }

    }
}
    
