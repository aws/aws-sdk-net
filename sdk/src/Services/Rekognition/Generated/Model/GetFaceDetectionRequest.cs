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
    /// Container for the parameters to the GetFaceDetection operation.
    /// Gets face detection results for a Amazon Rekognition Video analysis started by <a>StartFaceDetection</a>.
    /// 
    ///  
    /// <para>
    /// Face detection with Amazon Rekognition Video is an asynchronous operation. You start
    /// face detection by calling <a>StartFaceDetection</a> which returns a job identifier
    /// (<c>JobId</c>). When the face detection operation finishes, Amazon Rekognition Video
    /// publishes a completion status to the Amazon Simple Notification Service topic registered
    /// in the initial call to <c>StartFaceDetection</c>. To get the results of the face detection
    /// operation, first check that the status value published to the Amazon SNS topic is
    /// <c>SUCCEEDED</c>. If so, call <a>GetFaceDetection</a> and pass the job identifier
    /// (<c>JobId</c>) from the initial call to <c>StartFaceDetection</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>GetFaceDetection</c> returns an array of detected faces (<c>Faces</c>) sorted
    /// by the time the faces were detected. 
    /// </para>
    ///  
    /// <para>
    /// Use MaxResults parameter to limit the number of labels returned. If there are more
    /// results than specified in <c>MaxResults</c>, the value of <c>NextToken</c> in the
    /// operation response contains a pagination token for getting the next set of results.
    /// To get the next page of results, call <c>GetFaceDetection</c> and populate the <c>NextToken</c>
    /// request parameter with the token value returned from the previous call to <c>GetFaceDetection</c>.
    /// </para>
    ///  
    /// <para>
    /// Note that for the <c>GetFaceDetection</c> operation, the returned values for <c>FaceOccluded</c>
    /// and <c>EyeDirection</c> will always be "null".
    /// </para>
    /// </summary>
    public partial class GetFaceDetectionRequest : AmazonRekognitionRequest
    {
        private string _jobId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Unique identifier for the face detection job. The <c>JobId</c> is returned from <c>StartFaceDetection</c>.
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
        /// specify is 1000. If you specify a value greater than 1000, a maximum of 1000 results
        /// is returned. The default value is 1000.
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
        /// If the previous response was incomplete (because there are more faces to retrieve),
        /// Amazon Rekognition Video returns a pagination token in the response. You can use this
        /// pagination token to retrieve the next set of faces.
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