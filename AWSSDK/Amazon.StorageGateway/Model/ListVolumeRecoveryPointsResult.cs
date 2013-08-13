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
    /// <li> ListVolumeRecoveryPointsOutput$GatewayARN </li>
    /// <li> ListVolumeRecoveryPointsOutput$VolumeRecoveryPointInfos </li>
    /// 
    /// </ul>
    /// </summary>
    public class ListVolumeRecoveryPointsResult  
    {
        
        private string gatewayARN;
        private List<VolumeRecoveryPointInfo> volumeRecoveryPointInfos = new List<VolumeRecoveryPointInfo>();

        /// <summary>
        /// The Amazon Resource Name (ARN) of the activated gateway whose local disk information is returned.
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
        public ListVolumeRecoveryPointsResult WithGatewayARN(string gatewayARN)
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
        /// An array of <a>VolumeRecoveryPointInfo</a> objects, where each object describes a recovery point. If no recovery points are defined for the
        /// volume, then <i>VolumeRecoveryPointInfos</i> is an empty array "[]"
        ///  
        /// </summary>
        public List<VolumeRecoveryPointInfo> VolumeRecoveryPointInfos
        {
            get { return this.volumeRecoveryPointInfos; }
            set { this.volumeRecoveryPointInfos = value; }
        }
        /// <summary>
        /// Adds elements to the VolumeRecoveryPointInfos collection
        /// </summary>
        /// <param name="volumeRecoveryPointInfos">The values to add to the VolumeRecoveryPointInfos collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListVolumeRecoveryPointsResult WithVolumeRecoveryPointInfos(params VolumeRecoveryPointInfo[] volumeRecoveryPointInfos)
        {
            foreach (VolumeRecoveryPointInfo element in volumeRecoveryPointInfos)
            {
                this.volumeRecoveryPointInfos.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the VolumeRecoveryPointInfos collection
        /// </summary>
        /// <param name="volumeRecoveryPointInfos">The values to add to the VolumeRecoveryPointInfos collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListVolumeRecoveryPointsResult WithVolumeRecoveryPointInfos(IEnumerable<VolumeRecoveryPointInfo> volumeRecoveryPointInfos)
        {
            foreach (VolumeRecoveryPointInfo element in volumeRecoveryPointInfos)
            {
                this.volumeRecoveryPointInfos.Add(element);
            }

            return this;
        }

        // Check to see if VolumeRecoveryPointInfos property is set
        internal bool IsSetVolumeRecoveryPointInfos()
        {
            return this.volumeRecoveryPointInfos.Count > 0;       
        }
    }
}
