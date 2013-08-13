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
    /// <para>A JSON object containing the following fields:</para>
    /// <ul>
    /// <li> GatewayARN </li>
    /// <li> ListVolumesOutput$Marker </li>
    /// <li> ListVolumesOutput$VolumeInfos </li>
    /// 
    /// </ul>
    /// </summary>
    public class ListVolumesResult  
    {
        
        private string gatewayARN;
        private string marker;
        private List<VolumeInfo> volumeInfos = new List<VolumeInfo>();

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
        public ListVolumesResult WithGatewayARN(string gatewayARN)
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
        /// Use the marker in your next request to continue pagination of iSCSI volumes. If there are no more volumes to list, this field does not
        /// appear in the response body.
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
        public ListVolumesResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;       
        }

        /// <summary>
        /// An array of <a>VolumeInfo</a> objects, where each object describes an iSCSI volume. If no volumes are defined for the gateway, then
        /// <c>VolumeInfos</c> is an empty array "[]".
        ///  
        /// </summary>
        public List<VolumeInfo> VolumeInfos
        {
            get { return this.volumeInfos; }
            set { this.volumeInfos = value; }
        }
        /// <summary>
        /// Adds elements to the VolumeInfos collection
        /// </summary>
        /// <param name="volumeInfos">The values to add to the VolumeInfos collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListVolumesResult WithVolumeInfos(params VolumeInfo[] volumeInfos)
        {
            foreach (VolumeInfo element in volumeInfos)
            {
                this.volumeInfos.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the VolumeInfos collection
        /// </summary>
        /// <param name="volumeInfos">The values to add to the VolumeInfos collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListVolumesResult WithVolumeInfos(IEnumerable<VolumeInfo> volumeInfos)
        {
            foreach (VolumeInfo element in volumeInfos)
            {
                this.volumeInfos.Add(element);
            }

            return this;
        }

        // Check to see if VolumeInfos property is set
        internal bool IsSetVolumeInfos()
        {
            return this.volumeInfos.Count > 0;       
        }
    }
}
