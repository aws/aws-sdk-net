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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the GetLabelDetection operation.
    /// Gets the label detection results of a Amazon Rekognition Video analysis started by
    /// <a>StartLabelDetection</a>. 
    /// 
    ///  
    /// <para>
    /// The label detection operation is started by a call to <a>StartLabelDetection</a> which
    /// returns a job identifier (<code>JobId</code>). When the label detection operation
    /// finishes, Amazon Rekognition publishes a completion status to the Amazon Simple Notification
    /// Service topic registered in the initial call to <code>StartlabelDetection</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// To get the results of the label detection operation, first check that the status value
    /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetLabelDetection</a>
    /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartLabelDetection</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>GetLabelDetection</code> returns an array of detected labels (<code>Labels</code>)
    /// sorted by the time the labels were detected. You can also sort by the label name by
    /// specifying <code>NAME</code> for the <code>SortBy</code> input parameter. If there
    /// is no <code>NAME</code> specified, the default sort is by timestamp.
    /// </para>
    ///  
    /// <para>
    /// You can select how results are aggregated by using the <code>AggregateBy</code> input
    /// parameter. The default aggregation method is <code>TIMESTAMPS</code>. You can also
    /// aggregate by <code>SEGMENTS</code>, which aggregates all instances of labels detected
    /// in a given segment. 
    /// </para>
    ///  
    /// <para>
    /// The returned Labels array may include the following attributes:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Name - The name of the detected label.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Confidence - The level of confidence in the label assigned to a detected object. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Parents - The ancestor labels for a detected label. GetLabelDetection returns a hierarchical
    /// taxonomy of detected labels. For example, a detected car might be assigned the label
    /// car. The label car has two parent labels: Vehicle (its parent) and Transportation
    /// (its grandparent). The response includes the all ancestors for a label, where every
    /// ancestor is a unique label. In the previous example, Car, Vehicle, and Transportation
    /// are returned as unique labels in the response. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Aliases - Possible Aliases for the label. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Categories - The label categories that the detected label belongs to.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// BoundingBox — Bounding boxes are described for all instances of detected common object
    /// labels, returned in an array of Instance objects. An Instance object contains a BoundingBox
    /// object, describing the location of the label on the input image. It also includes
    /// the confidence for the accuracy of the detected bounding box.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Timestamp - Time, in milliseconds from the start of the video, that the label was
    /// detected. For aggregation by <code>SEGMENTS</code>, the <code>StartTimestampMillis</code>,
    /// <code>EndTimestampMillis</code>, and <code>DurationMillis</code> structures are what
    /// define a segment. Although the “Timestamp” structure is still returned with each label,
    /// its value is set to be the same as <code>StartTimestampMillis</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Timestamp and Bounding box information are returned for detected Instances, only if
    /// aggregation is done by <code>TIMESTAMPS</code>. If aggregating by <code>SEGMENTS</code>,
    /// information about detected instances isn’t returned. 
    /// </para>
    ///  
    /// <para>
    /// The version of the label model used for the detection is also returned.
    /// </para>
    ///  
    /// <para>
    ///  <b>Note <code>DominantColors</code> isn't returned for <code>Instances</code>, although
    /// it is shown as part of the response in the sample seen below.</b> 
    /// </para>
    ///  
    /// <para>
    /// Use <code>MaxResults</code> parameter to limit the number of labels returned. If there
    /// are more results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
    /// in the operation response contains a pagination token for getting the next set of
    /// results. To get the next page of results, call <code>GetlabelDetection</code> and
    /// populate the <code>NextToken</code> request parameter with the token value returned
    /// from the previous call to <code>GetLabelDetection</code>.
    /// </para>
    /// </summary>
    public partial class GetLabelDetectionRequest : AmazonRekognitionRequest
    {
        private LabelDetectionAggregateBy _aggregateBy;
        private string _jobId;
        private int? _maxResults;
        private string _nextToken;
        private LabelDetectionSortBy _sortBy;

        /// <summary>
        /// Gets and sets the property AggregateBy. 
        /// <para>
        /// Defines how to aggregate the returned results. Results can be aggregated by timestamps
        /// or segments.
        /// </para>
        /// </summary>
        public LabelDetectionAggregateBy AggregateBy
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
        /// Job identifier for the label detection operation for which you want results returned.
        /// You get the job identifer from an initial call to <code>StartlabelDetection</code>.
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
        /// If the previous response was incomplete (because there are more labels to retrieve),
        /// Amazon Rekognition Video returns a pagination token in the response. You can use this
        /// pagination token to retrieve the next set of labels. 
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
        /// Sort to use for elements in the <code>Labels</code> array. Use <code>TIMESTAMP</code>
        /// to sort array elements by the time labels are detected. Use <code>NAME</code> to alphabetically
        /// group elements for a label together. Within each label group, the array element are
        /// sorted by detection confidence. The default sort is by <code>TIMESTAMP</code>.
        /// </para>
        /// </summary>
        public LabelDetectionSortBy SortBy
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