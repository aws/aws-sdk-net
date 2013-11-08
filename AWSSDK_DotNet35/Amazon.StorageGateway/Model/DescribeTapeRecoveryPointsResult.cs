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
    /// <para>DescribeTapeRecoveryPointsOutput</para>
    /// </summary>
    public partial class DescribeTapeRecoveryPointsResult : AmazonWebServiceResponse
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

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
