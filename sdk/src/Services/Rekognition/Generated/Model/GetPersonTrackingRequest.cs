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
    /// Container for the parameters to the GetPersonTracking operation.
    /// <note> 
    /// <para>
    ///  <i>End of support notice:</i> On October 31, 2025, AWS will discontinue support for
    /// Amazon Rekognition People Pathing. After October 31, 2025, you will no longer be able
    /// to use the Rekognition People Pathing capability. For more information, visit this
    /// <a href="https://aws.amazon.com/blogs/machine-learning/transitioning-from-amazon-rekognition-people-pathing-exploring-other-alternatives/">blog
    /// post</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Gets the path tracking results of a Amazon Rekognition Video analysis started by <a>StartPersonTracking</a>.
    /// </para>
    ///  
    /// <para>
    /// The person path tracking operation is started by a call to <c>StartPersonTracking</c>
    /// which returns a job identifier (<c>JobId</c>). When the operation finishes, Amazon
    /// Rekognition Video publishes a completion status to the Amazon Simple Notification
    /// Service topic registered in the initial call to <c>StartPersonTracking</c>.
    /// </para>
    ///  
    /// <para>
    /// To get the results of the person path tracking operation, first check that the status
    /// value published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <a>GetPersonTracking</a>
    /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartPersonTracking</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>GetPersonTracking</c> returns an array, <c>Persons</c>, of tracked persons and
    /// the time(s) their paths were tracked in the video. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  <c>GetPersonTracking</c> only returns the default facial attributes (<c>BoundingBox</c>,
    /// <c>Confidence</c>, <c>Landmarks</c>, <c>Pose</c>, and <c>Quality</c>). The other facial
    /// attributes listed in the <c>Face</c> object of the following response syntax are not
    /// returned. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see FaceDetail in the Amazon Rekognition Developer Guide.
    /// </para>
    ///  </note> 
    /// <para>
    /// By default, the array is sorted by the time(s) a person's path is tracked in the video.
    /// You can sort by tracked persons by specifying <c>INDEX</c> for the <c>SortBy</c> input
    /// parameter.
    /// </para>
    ///  
    /// <para>
    /// Use the <c>MaxResults</c> parameter to limit the number of items returned. If there
    /// are more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c>
    /// in the operation response contains a pagination token for getting the next set of
    /// results. To get the next page of results, call <c>GetPersonTracking</c> and populate
    /// the <c>NextToken</c> request parameter with the token value returned from the previous
    /// call to <c>GetPersonTracking</c>.
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
        /// The identifier for a job that tracks persons in a video. You get the <c>JobId</c>
        /// from a call to <c>StartPersonTracking</c>. 
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
        /// If the previous response was incomplete (because there are more persons to retrieve),
        /// Amazon Rekognition Video returns a pagination token in the response. You can use this
        /// pagination token to retrieve the next set of persons. 
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
        /// Sort to use for elements in the <c>Persons</c> array. Use <c>TIMESTAMP</c> to sort
        /// array elements by the time persons are detected. Use <c>INDEX</c> to sort by the tracked
        /// persons. If you sort by <c>INDEX</c>, the array elements for each person are sorted
        /// by detection confidence. The default sort is by <c>TIMESTAMP</c>.
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