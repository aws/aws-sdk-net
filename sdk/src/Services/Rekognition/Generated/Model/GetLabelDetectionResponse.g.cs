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
    /// This is the response object from the GetLabelDetection operation.
    /// </summary>
    public partial class GetLabelDetectionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property GetRequestMetadata. 
        /// <para>
        /// Information about the paramters used when getting a response. Includes information
        /// on aggregation and sorting methods.
        /// </para>
        /// </summary>
        public GetLabelDetectionRequestMetadata GetRequestMetadata { get; set; }

        /// <summary>
        /// Checks to see if the GetRequestMetadata property is set.
        /// </summary>
        internal bool IsSetGetRequestMetadata() => this.GetRequestMetadata != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Job identifier for the label detection operation for which you want to obtain results.
        /// The job identifer is returned by an initial call to StartLabelDetection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the label detection job.
        /// </para>
        /// </summary>
        public VideoJobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property JobTag. 
        /// <para>
        /// A job identifier specified in the call to StartLabelDetection and returned in the
        /// job completion notification sent to your Amazon Simple Notification Service topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string JobTag { get; set; }

        /// <summary>
        /// Checks to see if the JobTag property is set.
        /// </summary>
        internal bool IsSetJobTag() => this.JobTag != null;

        /// <summary>
        /// Gets and sets the property LabelModelVersion. 
        /// <para>
        /// Version number of the label detection model that was used to detect labels.
        /// </para>
        /// </summary>
        public string LabelModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the LabelModelVersion property is set.
        /// </summary>
        internal bool IsSetLabelModelVersion() => this.LabelModelVersion != null;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// An array of labels detected in the video. Each element contains the detected label
        /// and the time, in milliseconds from the start of the video, that the label was detected.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LabelDetection> Labels { get; set; } = AWSConfigs.InitializeCollections ? new List<LabelDetection>() : null;

        /// <summary>
        /// Checks to see if the Labels property is set.
        /// </summary>
        internal bool IsSetLabels() => this.Labels != null && (this.Labels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Rekognition Video returns this token that you
        /// can use in the subsequent request to retrieve the next set of labels.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// If the job fails, <c>StatusMessage</c> provides a descriptive error message.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Video.
        /// </summary>
        public Video Video { get; set; }

        /// <summary>
        /// Checks to see if the Video property is set.
        /// </summary>
        internal bool IsSetVideo() => this.Video != null;

        /// <summary>
        /// Gets and sets the property VideoMetadata. 
        /// <para>
        /// Information about a video that Amazon Rekognition Video analyzed. <c>Videometadata</c>
        /// is returned in every page of paginated responses from a Amazon Rekognition video operation.
        /// </para>
        /// </summary>
        public VideoMetadata VideoMetadata { get; set; }

        /// <summary>
        /// Checks to see if the VideoMetadata property is set.
        /// </summary>
        internal bool IsSetVideoMetadata() => this.VideoMetadata != null;
    }
}
