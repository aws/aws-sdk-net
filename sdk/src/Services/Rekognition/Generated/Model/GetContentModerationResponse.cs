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
    /// This is the response object from the GetContentModeration operation.
    /// </summary>
    public partial class GetContentModerationResponse : AmazonWebServiceResponse
    {
        private VideoJobStatus _jobStatus;
        private List<ContentModerationDetection> _moderationLabels = new List<ContentModerationDetection>();
        private string _moderationModelVersion;
        private string _nextToken;
        private string _statusMessage;
        private VideoMetadata _videoMetadata;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the unsafe content analysis job.
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
        /// Gets and sets the property ModerationLabels. 
        /// <para>
        /// The detected unsafe content labels and the time(s) they were detected.
        /// </para>
        /// </summary>
        public List<ContentModerationDetection> ModerationLabels
        {
            get { return this._moderationLabels; }
            set { this._moderationLabels = value; }
        }

        // Check to see if ModerationLabels property is set
        internal bool IsSetModerationLabels()
        {
            return this._moderationLabels != null && this._moderationLabels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ModerationModelVersion. 
        /// <para>
        /// Version number of the moderation detection model that was used to detect unsafe content.
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
        /// can use in the subsequent request to retrieve the next set of unsafe content labels.
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
        /// If the job fails, <code>StatusMessage</code> provides a descriptive error message.
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
        /// Gets and sets the property VideoMetadata. 
        /// <para>
        /// Information about a video that Amazon Rekognition analyzed. <code>Videometadata</code>
        /// is returned in every page of paginated responses from <code>GetContentModeration</code>.
        /// 
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