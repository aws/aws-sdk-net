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
    /// This is the response object from the GetSegmentDetection operation.
    /// </summary>
    public partial class GetSegmentDetectionResponse : AmazonWebServiceResponse
    {
        private List<AudioMetadata> _audioMetadata = AWSConfigs.InitializeCollections ? new List<AudioMetadata>() : null;
        private string _jobId;
        private VideoJobStatus _jobStatus;
        private string _jobTag;
        private string _nextToken;
        private List<SegmentDetection> _segments = AWSConfigs.InitializeCollections ? new List<SegmentDetection>() : null;
        private List<SegmentTypeInfo> _selectedSegmentTypes = AWSConfigs.InitializeCollections ? new List<SegmentTypeInfo>() : null;
        private string _statusMessage;
        private Video _video;
        private List<VideoMetadata> _videoMetadata = AWSConfigs.InitializeCollections ? new List<VideoMetadata>() : null;

        /// <summary>
        /// Gets and sets the property AudioMetadata. 
        /// <para>
        /// An array of objects. There can be multiple audio streams. Each <c>AudioMetadata</c>
        /// object contains metadata for a single audio stream. Audio information in an <c>AudioMetadata</c>
        /// objects includes the audio codec, the number of audio channels, the duration of the
        /// audio stream, and the sample rate. Audio metadata is returned in each page of information
        /// returned by <c>GetSegmentDetection</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AudioMetadata> AudioMetadata
        {
            get { return this._audioMetadata; }
            set { this._audioMetadata = value; }
        }

        // Check to see if AudioMetadata property is set
        internal bool IsSetAudioMetadata()
        {
            return this._audioMetadata != null && (this._audioMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Job identifier for the segment detection operation for which you want to obtain results.
        /// The job identifer is returned by an initial call to StartSegmentDetection.
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
        /// Current status of the segment detection job.
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
        /// A job identifier specified in the call to StartSegmentDetection and returned in the
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was incomplete (because there are more labels to retrieve),
        /// Amazon Rekognition Video returns a pagination token in the response. You can use this
        /// pagination token to retrieve the next set of text.
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
        /// Gets and sets the property Segments. 
        /// <para>
        /// An array of segments detected in a video. The array is sorted by the segment types
        /// (TECHNICAL_CUE or SHOT) specified in the <c>SegmentTypes</c> input parameter of <c>StartSegmentDetection</c>.
        /// Within each segment type the array is sorted by timestamp values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SegmentDetection> Segments
        {
            get { return this._segments; }
            set { this._segments = value; }
        }

        // Check to see if Segments property is set
        internal bool IsSetSegments()
        {
            return this._segments != null && (this._segments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelectedSegmentTypes. 
        /// <para>
        /// An array containing the segment types requested in the call to <c>StartSegmentDetection</c>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SegmentTypeInfo> SelectedSegmentTypes
        {
            get { return this._selectedSegmentTypes; }
            set { this._selectedSegmentTypes = value; }
        }

        // Check to see if SelectedSegmentTypes property is set
        internal bool IsSetSelectedSegmentTypes()
        {
            return this._selectedSegmentTypes != null && (this._selectedSegmentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Currently, Amazon Rekognition Video returns a single object in the <c>VideoMetadata</c>
        /// array. The object contains information about the video stream in the input file that
        /// Amazon Rekognition Video chose to analyze. The <c>VideoMetadata</c> object includes
        /// the video codec, video format and other information. Video metadata is returned in
        /// each page of information returned by <c>GetSegmentDetection</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VideoMetadata> VideoMetadata
        {
            get { return this._videoMetadata; }
            set { this._videoMetadata = value; }
        }

        // Check to see if VideoMetadata property is set
        internal bool IsSetVideoMetadata()
        {
            return this._videoMetadata != null && (this._videoMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}