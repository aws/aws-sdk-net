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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the GetSegmentDetection operation.
    /// Gets the segment detection results of a Amazon Rekognition Video analysis started
    /// by <a>StartSegmentDetection</a>.
    /// 
    ///  
    /// <para>
    /// Segment detection with Amazon Rekognition Video is an asynchronous operation. You
    /// start segment detection by calling <a>StartSegmentDetection</a> which returns a job
    /// identifier (<c>JobId</c>). When the segment detection operation finishes, Amazon Rekognition
    /// publishes a completion status to the Amazon Simple Notification Service topic registered
    /// in the initial call to <c>StartSegmentDetection</c>. To get the results of the segment
    /// detection operation, first check that the status value published to the Amazon SNS
    /// topic is <c>SUCCEEDED</c>. if so, call <c>GetSegmentDetection</c> and pass the job
    /// identifier (<c>JobId</c>) from the initial call of <c>StartSegmentDetection</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>GetSegmentDetection</c> returns detected segments in an array (<c>Segments</c>)
    /// of <a>SegmentDetection</a> objects. <c>Segments</c> is sorted by the segment types
    /// specified in the <c>SegmentTypes</c> input parameter of <c>StartSegmentDetection</c>.
    /// Each element of the array includes the detected segment, the precentage confidence
    /// in the acuracy of the detected segment, the type of the segment, and the frame in
    /// which the segment was detected.
    /// </para>
    ///  
    /// <para>
    /// Use <c>SelectedSegmentTypes</c> to find out the type of segment detection requested
    /// in the call to <c>StartSegmentDetection</c>.
    /// </para>
    ///  
    /// <para>
    /// Use the <c>MaxResults</c> parameter to limit the number of segment detections returned.
    /// If there are more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c>
    /// in the operation response contains a pagination token for getting the next set of
    /// results. To get the next page of results, call <c>GetSegmentDetection</c> and populate
    /// the <c>NextToken</c> request parameter with the token value returned from the previous
    /// call to <c>GetSegmentDetection</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see Detecting video segments in stored video in the Amazon Rekognition
    /// Developer Guide.
    /// </para>
    /// </summary>
    public partial class GetSegmentDetectionRequest : AmazonRekognitionRequest
    {
        private string _jobId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Job identifier for the text detection operation for which you want results returned.
        /// You get the job identifer from an initial call to <c>StartSegmentDetection</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return per paginated call. The largest value you can
        /// specify is 1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Rekognition Video returns this token that you
        /// can use in the subsequent request to retrieve the next set of text.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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

    }
}