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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
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
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// A media pipeline object consisting of an ID, source type, source ARN, a sink type,
    /// a sink ARN, and a configuration object.
    /// </summary>
    public partial class MediaCapturePipeline
    {
        private ChimeSdkMeetingConfiguration _chimeSdkMeetingConfiguration;
        private DateTime? _createdTimestamp;
        private string _mediaPipelineArn;
        private string _mediaPipelineId;
        private string _sinkArn;
        private string _sinkIamRoleArn;
        private MediaPipelineSinkType _sinkType;
        private string _sourceArn;
        private MediaPipelineSourceType _sourceType;
        private SseAwsKeyManagementParams _sseAwsKeyManagementParams;
        private MediaPipelineStatus _status;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property ChimeSdkMeetingConfiguration. 
        /// <para>
        /// The configuration for a specified media pipeline. <c>SourceType</c> must be <c>ChimeSdkMeeting</c>.
        /// </para>
        /// </summary>
        public ChimeSdkMeetingConfiguration ChimeSdkMeetingConfiguration
        {
            get { return this._chimeSdkMeetingConfiguration; }
            set { this._chimeSdkMeetingConfiguration = value; }
        }

        // Check to see if ChimeSdkMeetingConfiguration property is set
        internal bool IsSetChimeSdkMeetingConfiguration()
        {
            return this._chimeSdkMeetingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the pipeline was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediaPipelineArn. 
        /// <para>
        /// The ARN of the media capture pipeline
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string MediaPipelineArn
        {
            get { return this._mediaPipelineArn; }
            set { this._mediaPipelineArn = value; }
        }

        // Check to see if MediaPipelineArn property is set
        internal bool IsSetMediaPipelineArn()
        {
            return this._mediaPipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property MediaPipelineId. 
        /// <para>
        /// The ID of a media pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string MediaPipelineId
        {
            get { return this._mediaPipelineId; }
            set { this._mediaPipelineId = value; }
        }

        // Check to see if MediaPipelineId property is set
        internal bool IsSetMediaPipelineId()
        {
            return this._mediaPipelineId != null;
        }

        /// <summary>
        /// Gets and sets the property SinkArn. 
        /// <para>
        /// ARN of the destination to which the media artifacts are saved.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string SinkArn
        {
            get { return this._sinkArn; }
            set { this._sinkArn = value; }
        }

        // Check to see if SinkArn property is set
        internal bool IsSetSinkArn()
        {
            return this._sinkArn != null;
        }

        /// <summary>
        /// Gets and sets the property SinkIamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the sink role to be used with <c>AwsKmsKeyId</c>
        /// in <c>SseAwsKeyManagementParams</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string SinkIamRoleArn
        {
            get { return this._sinkIamRoleArn; }
            set { this._sinkIamRoleArn = value; }
        }

        // Check to see if SinkIamRoleArn property is set
        internal bool IsSetSinkIamRoleArn()
        {
            return this._sinkIamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SinkType. 
        /// <para>
        /// Destination type to which the media artifacts are saved. You must use an S3 Bucket.
        /// </para>
        /// </summary>
        public MediaPipelineSinkType SinkType
        {
            get { return this._sinkType; }
            set { this._sinkType = value; }
        }

        // Check to see if SinkType property is set
        internal bool IsSetSinkType()
        {
            return this._sinkType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// ARN of the source from which the media artifacts are saved.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Source type from which media artifacts are saved. You must use <c>ChimeMeeting</c>.
        /// </para>
        /// </summary>
        public MediaPipelineSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SseAwsKeyManagementParams. 
        /// <para>
        /// An object that contains server side encryption parameters to be used by media capture
        /// pipeline. The parameters can also be used by media concatenation pipeline taking media
        /// capture pipeline as a media source.
        /// </para>
        /// </summary>
        public SseAwsKeyManagementParams SseAwsKeyManagementParams
        {
            get { return this._sseAwsKeyManagementParams; }
            set { this._sseAwsKeyManagementParams = value; }
        }

        // Check to see if SseAwsKeyManagementParams property is set
        internal bool IsSetSseAwsKeyManagementParams()
        {
            return this._sseAwsKeyManagementParams != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the media pipeline.
        /// </para>
        /// </summary>
        public MediaPipelineStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which the pipeline was updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp
        {
            get { return this._updatedTimestamp; }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}