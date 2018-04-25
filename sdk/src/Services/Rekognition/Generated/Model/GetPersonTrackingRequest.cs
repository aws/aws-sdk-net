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
    /// Container for the parameters to the GetPersonTracking operation.
    /// Gets the person tracking results of a Rekognition Video analysis started by .
    /// 
    ///  
    /// <para>
    /// The person detection operation is started by a call to <code>StartPersonTracking</code>
    /// which returns a job identifier (<code>JobId</code>). When the person detection operation
    /// finishes, Rekognition Video publishes a completion status to the Amazon Simple Notification
    /// Service topic registered in the initial call to <code>StartPersonTracking</code>.
    /// </para>
    ///  
    /// <para>
    /// To get the results of the person tracking operation, first check that the status value
    /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call and pass
    /// the job identifier (<code>JobId</code>) from the initial call to <code>StartPersonTracking</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>GetPersonTracking</code> returns an array, <code>Persons</code>, of tracked
    /// persons and the time(s) they were tracked in the video. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  <code>GetPersonTracking</code> only returns the default facial attributes (<code>BoundingBox</code>,
    /// <code>Confidence</code>, <code>Landmarks</code>, <code>Pose</code>, and <code>Quality</code>).
    /// The other facial attributes listed in the <code>Face</code> object of the following
    /// response syntax are not returned. For more information, see . 
    /// </para>
    ///  </note> 
    /// <para>
    /// By default, the array is sorted by the time(s) a person is tracked in the video. You
    /// can sort by tracked persons by specifying <code>INDEX</code> for the <code>SortBy</code>
    /// input parameter.
    /// </para>
    ///  
    /// <para>
    /// Use the <code>MaxResults</code> parameter to limit the number of items returned. If
    /// there are more results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
    /// in the operation response contains a pagination token for getting the next set of
    /// results. To get the next page of results, call <code>GetPersonTracking</code> and
    /// populate the <code>NextToken</code> request parameter with the token value returned
    /// from the previous call to <code>GetPersonTracking</code>.
    /// </para>
    /// </summary>
    public partial class GetPersonTrackingRequest : AmazonRekognitionRequest
    {
        private string _jobId;
        private int? _maxResults;
        private string _nextToken;
        private PersonTrackingSortBy _sortBy;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The identifier for a job that tracks persons in a video. You get the <code>JobId</code>
        /// from a call to <code>StartPersonTracking</code>. 
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
        /// If the previous response was incomplete (because there are more persons to retrieve),
        /// Rekognition Video returns a pagination token in the response. You can use this pagination
        /// token to retrieve the next set of persons. 
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
        /// Sort to use for elements in the <code>Persons</code> array. Use <code>TIMESTAMP</code>
        /// to sort array elements by the time persons are detected. Use <code>INDEX</code> to
        /// sort by the tracked persons. If you sort by <code>INDEX</code>, the array elements
        /// for each person are sorted by detection confidence. The default sort is by <code>TIMESTAMP</code>.
        /// </para>
        /// </summary>
        public PersonTrackingSortBy SortBy
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