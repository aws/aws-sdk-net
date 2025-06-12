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
    /// DescribeTapeRecoveryPointsOutput
    /// </summary>
    public partial class DescribeTapeRecoveryPointsResponse : AmazonWebServiceResponse
    {
        private string _gatewayARN;
        private string _marker;
        private List<TapeRecoveryPointInfo> _tapeRecoveryPointInfos = AWSConfigs.InitializeCollections ? new List<TapeRecoveryPointInfo>() : null;

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
        /// An opaque string that indicates the position at which the virtual tape recovery points
        /// that were listed for description ended.
        /// </para>
        ///  
        /// <para>
        /// Use this marker in your next request to list the next set of virtual tape recovery
        /// points in the list. If there are no more recovery points to describe, this field does
        /// not appear in the response.
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
        /// Gets and sets the property TapeRecoveryPointInfos. 
        /// <para>
        /// An array of TapeRecoveryPointInfos that are available for the specified gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TapeRecoveryPointInfo> TapeRecoveryPointInfos
        {
            get { return this._tapeRecoveryPointInfos; }
            set { this._tapeRecoveryPointInfos = value; }
        }

        // Check to see if TapeRecoveryPointInfos property is set
        internal bool IsSetTapeRecoveryPointInfos()
        {
            return this._tapeRecoveryPointInfos != null && (this._tapeRecoveryPointInfos.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}