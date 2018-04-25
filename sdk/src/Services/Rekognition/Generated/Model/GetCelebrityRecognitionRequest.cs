/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the GetCelebrityRecognition operation.
    /// Gets the celebrity recognition results for a Rekognition Video analysis started by
    /// .
    /// 
    ///  
    /// <para>
    /// Celebrity recognition in a video is an asynchronous operation. Analysis is started
    /// by a call to which returns a job identifier (<code>JobId</code>). When the celebrity
    /// recognition operation finishes, Rekognition Video publishes a completion status to
    /// the Amazon Simple Notification Service topic registered in the initial call to <code>StartCelebrityRecognition</code>.
    /// To get the results of the celebrity recognition analysis, first check that the status
    /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <code>GetCelebrityDetection</code>
    /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartCelebrityDetection</code>.
    /// For more information, see <a>video</a>.
    /// </para>
    ///  
    /// <para>
    ///  <code>GetCelebrityRecognition</code> returns detected celebrities and the time(s)
    /// they are detected in an array (<code>Celebrities</code>) of objects. Each <code>CelebrityRecognition</code>
    /// contains information about the celebrity in a object and the time, <code>Timestamp</code>,
    /// the celebrity was detected. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  <code>GetCelebrityRecognition</code> only returns the default facial attributes (<code>BoundingBox</code>,
    /// <code>Confidence</code>, <code>Landmarks</code>, <code>Pose</code>, and <code>Quality</code>).
    /// The other facial attributes listed in the <code>Face</code> object of the following
    /// response syntax are not returned. For more information, see . 
    /// </para>
    ///  </note> 
    /// <para>
    /// By default, the <code>Celebrities</code> array is sorted by time (milliseconds from
    /// the start of the video). You can also sort the array by celebrity by specifying the
    /// value <code>ID</code> in the <code>SortBy</code> input parameter.
    /// </para>
    ///  
    /// <para>
    /// The <code>CelebrityDetail</code> object includes the celebrity identifer and additional
    /// information urls. If you don't store the additional information urls, you can get
    /// them later by calling with the celebrity identifer.
    /// </para>
    ///  
    /// <para>
    /// No information is returned for faces not recognized as celebrities.
    /// </para>
    ///  
    /// <para>
    /// Use MaxResults parameter to limit the number of labels returned. If there are more
    /// results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
    /// in the operation response contains a pagination token for getting the next set of
    /// results. To get the next page of results, call <code>GetCelebrityDetection</code>
    /// and populate the <code>NextToken</code> request parameter with the token value returned
    /// from the previous call to <code>GetCelebrityRecognition</code>.
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
        /// identifer from a call to <code>StartCelebrityRecognition</code>.
        /// </para>
        /// </summary>
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
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// to retrieve), Rekognition Video returns a pagination token in the response. You can
        /// use this pagination token to retrieve the next set of celebrities. 
        /// </para>
        /// </summary>
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
        /// Sort to use for celebrities returned in <code>Celebrities</code> field. Specify <code>ID</code>
        /// to sort by the celebrity identifier, specify <code>TIMESTAMP</code> to sort by the
        /// time the celebrity was recognized.
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