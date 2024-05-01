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
    /// Container for the parameters to the GetCelebrityRecognition operation.
    /// Gets the celebrity recognition results for a Amazon Rekognition Video analysis started
    /// by <a>StartCelebrityRecognition</a>.
    /// 
    ///  
    /// <para>
    /// Celebrity recognition in a video is an asynchronous operation. Analysis is started
    /// by a call to <a>StartCelebrityRecognition</a> which returns a job identifier (<c>JobId</c>).
    /// 
    /// </para>
    ///  
    /// <para>
    /// When the celebrity recognition operation finishes, Amazon Rekognition Video publishes
    /// a completion status to the Amazon Simple Notification Service topic registered in
    /// the initial call to <c>StartCelebrityRecognition</c>. To get the results of the celebrity
    /// recognition analysis, first check that the status value published to the Amazon SNS
    /// topic is <c>SUCCEEDED</c>. If so, call <c>GetCelebrityDetection</c> and pass the job
    /// identifier (<c>JobId</c>) from the initial call to <c>StartCelebrityDetection</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For more information, see Working With Stored Videos in the Amazon Rekognition Developer
    /// Guide.
    /// </para>
    ///  
    /// <para>
    ///  <c>GetCelebrityRecognition</c> returns detected celebrities and the time(s) they
    /// are detected in an array (<c>Celebrities</c>) of <a>CelebrityRecognition</a> objects.
    /// Each <c>CelebrityRecognition</c> contains information about the celebrity in a <a>CelebrityDetail</a>
    /// object and the time, <c>Timestamp</c>, the celebrity was detected. This <a>CelebrityDetail</a>
    /// object stores information about the detected celebrity's face attributes, a face bounding
    /// box, known gender, the celebrity's name, and a confidence estimate.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <c>GetCelebrityRecognition</c> only returns the default facial attributes (<c>BoundingBox</c>,
    /// <c>Confidence</c>, <c>Landmarks</c>, <c>Pose</c>, and <c>Quality</c>). The <c>BoundingBox</c>
    /// field only applies to the detected face instance. The other facial attributes listed
    /// in the <c>Face</c> object of the following response syntax are not returned. For more
    /// information, see FaceDetail in the Amazon Rekognition Developer Guide. 
    /// </para>
    ///  </note> 
    /// <para>
    /// By default, the <c>Celebrities</c> array is sorted by time (milliseconds from the
    /// start of the video). You can also sort the array by celebrity by specifying the value
    /// <c>ID</c> in the <c>SortBy</c> input parameter.
    /// </para>
    ///  
    /// <para>
    /// The <c>CelebrityDetail</c> object includes the celebrity identifer and additional
    /// information urls. If you don't store the additional information urls, you can get
    /// them later by calling <a>GetCelebrityInfo</a> with the celebrity identifer.
    /// </para>
    ///  
    /// <para>
    /// No information is returned for faces not recognized as celebrities.
    /// </para>
    ///  
    /// <para>
    /// Use MaxResults parameter to limit the number of labels returned. If there are more
    /// results than specified in <c>MaxResults</c>, the value of <c>NextToken</c> in the
    /// operation response contains a pagination token for getting the next set of results.
    /// To get the next page of results, call <c>GetCelebrityDetection</c> and populate the
    /// <c>NextToken</c> request parameter with the token value returned from the previous
    /// call to <c>GetCelebrityRecognition</c>.
    /// </para>
    /// </summary>
    public partial class GetCelebrityRecognitionRequest : AmazonRekognitionRequest
    {
        private string _jobId;
        private int? _maxResults;
        private string _nextToken;
        private CelebrityRecognitionSortBy _sortBy;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Job identifier for the required celebrity recognition analysis. You can get the job
        /// identifer from a call to <c>StartCelebrityRecognition</c>.
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
        /// If the previous response was incomplete (because there is more recognized celebrities
        /// to retrieve), Amazon Rekognition Video returns a pagination token in the response.
        /// You can use this pagination token to retrieve the next set of celebrities. 
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

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Sort to use for celebrities returned in <c>Celebrities</c> field. Specify <c>ID</c>
        /// to sort by the celebrity identifier, specify <c>TIMESTAMP</c> to sort by the time
        /// the celebrity was recognized.
        /// </para>
        /// </summary>
        public CelebrityRecognitionSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

    }
}