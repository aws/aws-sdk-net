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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>DescribeVTLDevicesOutput</para>
    /// </summary>
    public partial class DescribeVTLDevicesResult
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

        /// <summary>
        /// Sets the GatewayARN property
        /// </summary>
        /// <param name="gatewayARN">The value to set for the GatewayARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVTLDevicesResult WithGatewayARN(string gatewayARN)
        {
            this.gatewayARN = gatewayARN;
            return this;
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
        /// <summary>
        /// Adds elements to the VTLDevices collection
        /// </summary>
        /// <param name="vTLDevices">The values to add to the VTLDevices collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVTLDevicesResult WithVTLDevices(params VTLDevice[] vTLDevices)
        {
            foreach (VTLDevice element in vTLDevices)
            {
                this.vTLDevices.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the VTLDevices collection
        /// </summary>
        /// <param name="vTLDevices">The values to add to the VTLDevices collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVTLDevicesResult WithVTLDevices(IEnumerable<VTLDevice> vTLDevices)
        {
            foreach (VTLDevice element in vTLDevices)
            {
                this.vTLDevices.Add(element);
            }

            return this;
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

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVTLDevicesResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
