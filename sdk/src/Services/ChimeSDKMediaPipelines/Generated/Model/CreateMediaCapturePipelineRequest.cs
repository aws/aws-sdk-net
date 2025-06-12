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
    /// Container for the parameters to the CreateMediaCapturePipeline operation.
    /// Creates a media pipeline.
    /// </summary>
    public partial class CreateMediaCapturePipelineRequest : AmazonChimeSDKMediaPipelinesRequest
    {
        private ChimeSdkMeetingConfiguration _chimeSdkMeetingConfiguration;
        private string _clientRequestToken;
        private string _sinkArn;
        private string _sinkIamRoleArn;
        private MediaPipelineSinkType _sinkType;
        private string _sourceArn;
        private MediaPipelineSourceType _sourceType;
        private SseAwsKeyManagementParams _sseAwsKeyManagementParams;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique identifier for the client request. The token makes the API request idempotent.
        /// Use a unique token for each media pipeline request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property SinkArn. 
        /// <para>
        /// The ARN of the sink type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
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
        /// in <c>SseAwsKeyManagementParams</c>. Can only interact with <c>S3Bucket</c> sink type.
        /// The role must belong to the caller’s account and be able to act on behalf of the caller
        /// during the API call. All minimum policy permissions requirements for the caller to
        /// perform sink-related actions are the same for <c>SinkIamRoleArn</c>.
        /// </para>
        ///  
        /// <para>
        /// Additionally, the role must have permission to <c>kms:GenerateDataKey</c> using KMS
        /// key supplied as <c>AwsKmsKeyId</c> in <c>SseAwsKeyManagementParams</c>. If media concatenation
        /// will be required later, the role must also have permission to <c>kms:Decrypt</c> for
        /// the same KMS key.
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
        /// Destination type to which the media artifacts are saved. You must use an S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// ARN of the source from which the media artifacts are captured.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
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
        /// Source type from which the media artifacts are captured. A Chime SDK Meeting is the
        /// only supported source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag key-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}