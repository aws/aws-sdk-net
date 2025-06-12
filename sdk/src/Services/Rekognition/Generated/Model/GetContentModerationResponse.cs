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
    /// This is the response object from the GetContentModeration operation.
    /// </summary>
    public partial class GetContentModerationResponse : AmazonWebServiceResponse
    {
        private GetContentModerationRequestMetadata _getRequestMetadata;
        private string _jobId;
        private VideoJobStatus _jobStatus;
        private string _jobTag;
        private List<ContentModerationDetection> _moderationLabels = AWSConfigs.InitializeCollections ? new List<ContentModerationDetection>() : null;
        private string _moderationModelVersion;
        private string _nextToken;
        private string _statusMessage;
        private Video _video;
        private VideoMetadata _videoMetadata;

        /// <summary>
        /// Gets and sets the property GetRequestMetadata. 
        /// <para>
        /// Information about the paramters used when getting a response. Includes information
        /// on aggregation and sorting methods.
        /// </para>
        /// </summary>
        public GetContentModerationRequestMetadata GetRequestMetadata
        {
            get { return this._getRequestMetadata; }
            set { this._getRequestMetadata = value; }
        }

        // Check to see if GetRequestMetadata property is set
        internal bool IsSetGetRequestMetadata()
        {
            return this._getRequestMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Job identifier for the content moderation operation for which you want to obtain results.
        /// The job identifer is returned by an initial call to StartContentModeration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the content moderation analysis job.
        /// </para>
        /// </summary>
        public VideoJobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property JobTag. 
        /// <para>
        /// A job identifier specified in the call to StartContentModeration and returned in the
        /// job completion notification sent to your Amazon Simple Notification Service topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string JobTag
        {
            get { return this._jobTag; }
            set { this._jobTag = value; }
        }

        // Check to see if JobTag property is set
        internal bool IsSetJobTag()
        {
            return this._jobTag != null;
        }

        /// <summary>
        /// Gets and sets the property ModerationLabels. 
        /// <para>
        /// The detected inappropriate, unwanted, or offensive content moderation labels and the
        /// time(s) they were detected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContentModerationDetection> ModerationLabels
        {
            get { return this._moderationLabels; }
            set { this._moderationLabels = value; }
        }

        // Check to see if ModerationLabels property is set
        internal bool IsSetModerationLabels()
        {
            return this._moderationLabels != null && (this._moderationLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModerationModelVersion. 
        /// <para>
        /// Version number of the moderation detection model that was used to detect inappropriate,
        /// unwanted, or offensive content.
        /// </para>
        /// </summary>
        public string ModerationModelVersion
        {
            get { return this._moderationModelVersion; }
            set { this._moderationModelVersion = value; }
        }

        // Check to see if ModerationModelVersion property is set
        internal bool IsSetModerationModelVersion()
        {
            return this._moderationModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Rekognition Video returns this token that you
        /// can use in the subsequent request to retrieve the next set of content moderation labels.
        /// 
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// If the job fails, <c>StatusMessage</c> provides a descriptive error message.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Video.
        /// </summary>
        public Video Video
        {
            get { return this._video; }
            set { this._video = value; }
        }

        // Check to see if Video property is set
        internal bool IsSetVideo()
        {
            return this._video != null;
        }

        /// <summary>
        /// Gets and sets the property VideoMetadata. 
        /// <para>
        /// Information about a video that Amazon Rekognition analyzed. <c>Videometadata</c> is
        /// returned in every page of paginated responses from <c>GetContentModeration</c>. 
        /// </para>
        /// </summary>
        public VideoMetadata VideoMetadata
        {
            get { return this._videoMetadata; }
            set { this._videoMetadata = value; }
        }

        // Check to see if VideoMetadata property is set
        internal bool IsSetVideoMetadata()
        {
            return this._videoMetadata != null;
        }

    }
}