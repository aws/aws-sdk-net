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
    /// <para>DescribeTapeRecoveryPointsOutput</para>
    /// </summary>
    public partial class DescribeTapeRecoveryPointsResult
    {
        
        private string gatewayARN;
        private List<TapeRecoveryPointInfo> tapeRecoveryPointInfos = new List<TapeRecoveryPointInfo>();
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
        public DescribeTapeRecoveryPointsResult WithGatewayARN(string gatewayARN)
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
        /// An array of TapeRecoveryPointInfos that are available for the specified gateway.
        ///  
        /// </summary>
        public List<TapeRecoveryPointInfo> TapeRecoveryPointInfos
        {
            get { return this.tapeRecoveryPointInfos; }
            set { this.tapeRecoveryPointInfos = value; }
        }
        /// <summary>
        /// Adds elements to the TapeRecoveryPointInfos collection
        /// </summary>
        /// <param name="tapeRecoveryPointInfos">The values to add to the TapeRecoveryPointInfos collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTapeRecoveryPointsResult WithTapeRecoveryPointInfos(params TapeRecoveryPointInfo[] tapeRecoveryPointInfos)
        {
            foreach (TapeRecoveryPointInfo element in tapeRecoveryPointInfos)
            {
                this.tapeRecoveryPointInfos.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the TapeRecoveryPointInfos collection
        /// </summary>
        /// <param name="tapeRecoveryPointInfos">The values to add to the TapeRecoveryPointInfos collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTapeRecoveryPointsResult WithTapeRecoveryPointInfos(IEnumerable<TapeRecoveryPointInfo> tapeRecoveryPointInfos)
        {
            foreach (TapeRecoveryPointInfo element in tapeRecoveryPointInfos)
            {
                this.tapeRecoveryPointInfos.Add(element);
            }

            return this;
        }

        // Check to see if TapeRecoveryPointInfos property is set
        internal bool IsSetTapeRecoveryPointInfos()
        {
            return this.tapeRecoveryPointInfos.Count > 0;
        }

        /// <summary>
        /// An opaque string that indicates the position at which the virtual tape recovery points that were listed for description ended. Use this
        /// marker in your next request to list the next set of virtual tape recovery points in the list. If there are no more recovery points to
        /// describe, this field does not appear in the response.
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
        public DescribeTapeRecoveryPointsResult WithMarker(string marker)
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
