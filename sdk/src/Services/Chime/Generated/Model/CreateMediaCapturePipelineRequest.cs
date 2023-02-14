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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMediaCapturePipeline operation.
    /// Creates a media capture pipeline.
    /// </summary>
    public partial class CreateMediaCapturePipelineRequest : AmazonChimeRequest
    {
        private ChimeSdkMeetingConfiguration _chimeSdkMeetingConfiguration;
        private string _clientRequestToken;
        private string _sinkArn;
        private MediaPipelineSinkType _sinkType;
        private string _sourceArn;
        private MediaPipelineSourceType _sourceType;

        /// <summary>
        /// Gets and sets the property ChimeSdkMeetingConfiguration. 
        /// <para>
        /// The configuration for a specified media capture pipeline. <code>SourceType</code>
        /// must be <code>ChimeSdkMeeting</code>.
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
        /// The token assigned to the client making the pipeline request.
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
        /// Gets and sets the property SinkType. 
        /// <para>
        /// Destination type to which the media artifacts are saved. You must use an S3 bucket.
        /// 
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
        /// Source type from which the media artifacts will be captured. A Chime SDK Meeting is
        /// the only supported source.
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

    }
}