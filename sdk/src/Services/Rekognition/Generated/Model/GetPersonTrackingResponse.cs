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
    /// This is the response object from the GetPersonTracking operation.
    /// </summary>
    public partial class GetPersonTrackingResponse : AmazonWebServiceResponse
    {
        private string _jobId;
        private VideoJobStatus _jobStatus;
        private string _jobTag;
        private string _nextToken;
        private List<PersonDetection> _persons = AWSConfigs.InitializeCollections ? new List<PersonDetection>() : null;
        private string _statusMessage;
        private Video _video;
        private VideoMetadata _videoMetadata;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Job identifier for the person tracking operation for which you want to obtain results.
        /// The job identifer is returned by an initial call to StartPersonTracking.
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
        /// The current status of the person tracking job.
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
        /// A job identifier specified in the call to StartCelebrityRecognition and returned in
        /// the job completion notification sent to your Amazon Simple Notification Service topic.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Rekognition Video returns this token that you
        /// can use in the subsequent request to retrieve the next set of persons. 
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
        /// Gets and sets the property Persons. 
        /// <para>
        /// An array of the persons detected in the video and the time(s) their path was tracked
        /// throughout the video. An array element will exist for each time a person's path is
        /// tracked. 
        /// </para>
        /// </summary>
        public List<PersonDetection> Persons
        {
            get { return this._persons; }
            set { this._persons = value; }
        }

        // Check to see if Persons property is set
        internal bool IsSetPersons()
        {
            return this._persons != null && (this._persons.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Information about a video that Amazon Rekognition Video analyzed. <c>Videometadata</c>
        /// is returned in every page of paginated responses from a Amazon Rekognition Video operation.
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