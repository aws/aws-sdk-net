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
    /// Container for the parameters to the GetFaceSearch operation.
    /// Gets the face search results for Rekognition Video face search started by . The search
    /// returns faces in a collection that match the faces of persons detected in a video.
    /// It also includes the time(s) that faces are matched in the video.
    /// 
    ///  
    /// <para>
    /// Face search in a video is an asynchronous operation. You start face search by calling
    /// to which returns a job identifier (<code>JobId</code>). When the search operation
    /// finishes, Rekognition Video publishes a completion status to the Amazon Simple Notification
    /// Service topic registered in the initial call to <code>StartFaceSearch</code>. To get
    /// the search results, first check that the status value published to the Amazon SNS
    /// topic is <code>SUCCEEDED</code>. If so, call <code>GetFaceSearch</code> and pass the
    /// job identifier (<code>JobId</code>) from the initial call to <code>StartFaceSearch</code>.
    /// For more information, see <a>collections</a>.
    /// </para>
    ///  
    /// <para>
    /// The search results are retured in an array, <code>Persons</code>, of objects. Each<code>PersonMatch</code>
    /// element contains details about the matching faces in the input collection, person
    /// information (facial attributes, bounding boxes, and person identifer) for the matched
    /// person, and the time the person was matched in the video.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <code>GetFaceSearch</code> only returns the default facial attributes (<code>BoundingBox</code>,
    /// <code>Confidence</code>, <code>Landmarks</code>, <code>Pose</code>, and <code>Quality</code>).
    /// The other facial attributes listed in the <code>Face</code> object of the following
    /// response syntax are not returned. For more information, see . 
    /// </para>
    ///  </note> 
    /// <para>
    /// By default, the <code>Persons</code> array is sorted by the time, in milliseconds
    /// from the start of the video, persons are matched. You can also sort by persons by
    /// specifying <code>INDEX</code> for the <code>SORTBY</code> input parameter.
    /// </para>
    /// </summary>
    public partial class GetFaceSearchRequest : AmazonRekognitionRequest
    {
        private string _jobId;
        private int? _maxResults;
        private string _nextToken;
        private FaceSearchSortBy _sortBy;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job identifer for the search request. You get the job identifier from an initial
        /// call to <code>StartFaceSearch</code>.
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
        /// If the previous response was incomplete (because there is more search results to retrieve),
        /// Rekognition Video returns a pagination token in the response. You can use this pagination
        /// token to retrieve the next set of search results. 
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
        /// Sort to use for grouping faces in the response. Use <code>TIMESTAMP</code> to group
        /// faces by the time that they are recognized. Use <code>INDEX</code> to sort by recognized
        /// faces. 
        /// </para>
        /// </summary>
        public FaceSearchSortBy SortBy
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