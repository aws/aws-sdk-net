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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the ListRealtimeContactAnalysisSegmentsV2 operation.
    /// </summary>
    public partial class ListRealtimeContactAnalysisSegmentsV2Response : AmazonWebServiceResponse
    {
        private RealTimeContactAnalysisSupportedChannel _channel;
        private string _nextToken;
        private List<RealtimeContactAnalysisSegment> _segments = AWSConfigs.InitializeCollections ? new List<RealtimeContactAnalysisSegment>() : null;
        private RealTimeContactAnalysisStatus _status;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel of the contact. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Only <c>CHAT</c> is supported. This API does not support <c>VOICE</c>. If you attempt
        /// to use it for the VOICE channel, an <c>InvalidRequestException</c> error occurs.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public RealTimeContactAnalysisSupportedChannel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Segments. 
        /// <para>
        /// An analyzed transcript or category.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RealtimeContactAnalysisSegment> Segments
        {
            get { return this._segments; }
            set { this._segments = value; }
        }

        // Check to see if Segments property is set
        internal bool IsSetSegments()
        {
            return this._segments != null && (this._segments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of real-time contact analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RealTimeContactAnalysisStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}