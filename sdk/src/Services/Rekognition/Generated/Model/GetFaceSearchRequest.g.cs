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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the GetFaceSearch operation. Gets the face search
    /// results for Amazon Rekognition Video face search started by <a>StartFaceSearch</a>.
    /// The search returns faces in a collection that match the faces of persons detected
    /// in a video. It also includes the time(s) that faces are matched in the video. <para>
    /// Face search in a video is an asynchronous operation. You start face search by calling
    /// to <a>StartFaceSearch</a> which returns a job identifier (<c>JobId</c>). When the
    /// search operation finishes, Amazon Rekognition Video publishes a completion status
    /// to the Amazon Simple Notification Service topic registered in the initial call to
    /// <c>StartFaceSearch</c>. To get the search results, first check that the status value
    /// published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <c>GetFaceSearch</c>
    /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartFaceSearch</c>.
    /// </para> <para> For more information, see Searching Faces in a Collection in the Amazon
    /// Rekognition Developer Guide. </para> <para> The search results are retured in an array,
    /// <c>Persons</c>, of <a>PersonMatch</a> objects. Each<c>PersonMatch</c> element contains
    /// details about the matching faces in the input collection, person information (facial
    /// attributes, bounding boxes, and person identifer) for the matched person, and the
    /// time the person was matched in the video. </para> <note> <para> <c>GetFaceSearch</c>
    /// only returns the default facial attributes (<c>BoundingBox</c>, <c>Confidence</c>,
    /// <c>Landmarks</c>, <c>Pose</c>, and <c>Quality</c>). The other facial attributes listed
    /// in the <c>Face</c> object of the following response syntax are not returned. For more
    /// information, see FaceDetail in the Amazon Rekognition Developer Guide. </para> </note>
    /// <para> By default, the <c>Persons</c> array is sorted by the time, in milliseconds
    /// from the start of the video, persons are matched. You can also sort by persons by
    /// specifying <c>INDEX</c> for the <c>SORTBY</c> input parameter. </para>
    /// </summary>
    public partial class GetFaceSearchRequest : AmazonRekognitionRequest
    {
        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job identifer for the search request. You get the job identifier from an initial
        /// call to <c>StartFaceSearch</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return per paginated call. The largest value you can
        /// specify is 1000. If you specify a value greater than 1000, a maximum of 1000 results
        /// is returned. The default value is 1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was incomplete (because there is more search results to retrieve),
        /// Amazon Rekognition Video returns a pagination token in the response. You can use this
        /// pagination token to retrieve the next set of search results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Sort to use for grouping faces in the response. Use <c>TIMESTAMP</c> to group faces
        /// by the time that they are recognized. Use <c>INDEX</c> to sort by recognized faces.
        /// 
        /// </para>
        /// </summary>
        public FaceSearchSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;
    }
}
