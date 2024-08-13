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
    /// Container for the parameters to the GetContentModeration operation.
    /// Gets the inappropriate, unwanted, or offensive content analysis results for a Amazon
    /// Rekognition Video analysis started by <a>StartContentModeration</a>. For a list of
    /// moderation labels in Amazon Rekognition, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/moderation.html#moderation-api">Using
    /// the image and video moderation APIs</a>.
    /// 
    ///  
    /// <para>
    /// Amazon Rekognition Video inappropriate or offensive content detection in a stored
    /// video is an asynchronous operation. You start analysis by calling <a>StartContentModeration</a>
    /// which returns a job identifier (<c>JobId</c>). When analysis finishes, Amazon Rekognition
    /// Video publishes a completion status to the Amazon Simple Notification Service topic
    /// registered in the initial call to <c>StartContentModeration</c>. To get the results
    /// of the content analysis, first check that the status value published to the Amazon
    /// SNS topic is <c>SUCCEEDED</c>. If so, call <c>GetContentModeration</c> and pass the
    /// job identifier (<c>JobId</c>) from the initial call to <c>StartContentModeration</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For more information, see Working with Stored Videos in the Amazon Rekognition Devlopers
    /// Guide.
    /// </para>
    ///  
    /// <para>
    ///  <c>GetContentModeration</c> returns detected inappropriate, unwanted, or offensive
    /// content moderation labels, and the time they are detected, in an array, <c>ModerationLabels</c>,
    /// of <a>ContentModerationDetection</a> objects. 
    /// </para>
    ///  
    /// <para>
    /// By default, the moderated labels are returned sorted by time, in milliseconds from
    /// the start of the video. You can also sort them by moderated label by specifying <c>NAME</c>
    /// for the <c>SortBy</c> input parameter. 
    /// </para>
    ///  
    /// <para>
    /// Since video analysis can return a large number of results, use the <c>MaxResults</c>
    /// parameter to limit the number of labels returned in a single call to <c>GetContentModeration</c>.
    /// If there are more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c>
    /// in the operation response contains a pagination token for getting the next set of
    /// results. To get the next page of results, call <c>GetContentModeration</c> and populate
    /// the <c>NextToken</c> request parameter with the value of <c>NextToken</c> returned
    /// from the previous call to <c>GetContentModeration</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see moderating content in the Amazon Rekognition Developer Guide.
    /// </para>
    /// </summary>
    public partial class GetContentModerationRequest : AmazonRekognitionRequest
    {
        private ContentModerationAggregateBy _aggregateBy;
        private string _jobId;
        private int? _maxResults;
        private string _nextToken;
        private ContentModerationSortBy _sortBy;

        /// <summary>
        /// Gets and sets the property AggregateBy. 
        /// <para>
        /// Defines how to aggregate results of the StartContentModeration request. Default aggregation
        /// option is TIMESTAMPS. SEGMENTS mode aggregates moderation labels over time.
        /// </para>
        /// </summary>
        public ContentModerationAggregateBy AggregateBy
        {
            get { return this._aggregateBy; }
            set { this._aggregateBy = value; }
        }

        // Check to see if AggregateBy property is set
        internal bool IsSetAggregateBy()
        {
            return this._aggregateBy != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The identifier for the inappropriate, unwanted, or offensive content moderation job.
        /// Use <c>JobId</c> to identify the job in a subsequent call to <c>GetContentModeration</c>.
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
        /// If the previous response was incomplete (because there is more data to retrieve),
        /// Amazon Rekognition returns a pagination token in the response. You can use this pagination
        /// token to retrieve the next set of content moderation labels.
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
        /// Sort to use for elements in the <c>ModerationLabelDetections</c> array. Use <c>TIMESTAMP</c>
        /// to sort array elements by the time labels are detected. Use <c>NAME</c> to alphabetically
        /// group elements for a label together. Within each label group, the array element are
        /// sorted by detection confidence. The default sort is by <c>TIMESTAMP</c>.
        /// </para>
        /// </summary>
        public ContentModerationSortBy SortBy
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