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
    /// This is the response object from the GetTextDetection operation.
    /// </summary>
    public partial class GetTextDetectionResponse : AmazonWebServiceResponse
    {
        private VideoJobStatus _jobStatus;
        private string _nextToken;
        private string _statusMessage;
        private List<TextDetectionResult> _textDetections = new List<TextDetectionResult>();
        private string _textModelVersion;
        private VideoMetadata _videoMetadata;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// Current status of the text detection job.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Rekognition Video returns this token that you
        /// can use in the subsequent request to retrieve the next set of text.
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
        /// Gets and sets the property TextDetections. 
        /// <para>
        /// An array of text detected in the video. Each element contains the detected text, the
        /// time in milliseconds from the start of the video that the text was detected, and where
        /// it was detected on the screen.
        /// </para>
        /// </summary>
        public List<TextDetectionResult> TextDetections
        {
            get { return this._textDetections; }
            set { this._textDetections = value; }
        }

        // Check to see if TextDetections property is set
        internal bool IsSetTextDetections()
        {
            return this._textDetections != null && this._textDetections.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TextModelVersion. 
        /// <para>
        /// Version number of the text detection model that was used to detect text.
        /// </para>
        /// </summary>
        public string TextModelVersion
        {
            get { return this._textModelVersion; }
            set { this._textModelVersion = value; }
        }

        // Check to see if TextModelVersion property is set
        internal bool IsSetTextModelVersion()
        {
            return this._textModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property VideoMetadata.
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