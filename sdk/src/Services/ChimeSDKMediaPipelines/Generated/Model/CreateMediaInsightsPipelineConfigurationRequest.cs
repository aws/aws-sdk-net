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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMediaInsightsPipelineConfiguration operation.
    /// A structure that contains the static configurations for a media insights pipeline.
    /// </summary>
    public partial class CreateMediaInsightsPipelineConfigurationRequest : AmazonChimeSDKMediaPipelinesRequest
    {
        private string _clientRequestToken;
        private List<MediaInsightsPipelineConfigurationElement> _elements = new List<MediaInsightsPipelineConfigurationElement>();
        private string _mediaInsightsPipelineConfigurationName;
        private RealTimeAlertConfiguration _realTimeAlertConfiguration;
        private string _resourceAccessRoleArn;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique identifier for the media insights pipeline configuration request.
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
        /// Gets and sets the property Elements. 
        /// <para>
        /// The elements in the request, such as a processor for Amazon Transcribe or a sink for
        /// a Kinesis Data Stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MediaInsightsPipelineConfigurationElement> Elements
        {
            get { return this._elements; }
            set { this._elements = value; }
        }

        // Check to see if Elements property is set
        internal bool IsSetElements()
        {
            return this._elements != null && this._elements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationName. 
        /// <para>
        /// The name of the media insights pipeline configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=64)]
        public string MediaInsightsPipelineConfigurationName
        {
            get { return this._mediaInsightsPipelineConfigurationName; }
            set { this._mediaInsightsPipelineConfigurationName = value; }
        }

        // Check to see if MediaInsightsPipelineConfigurationName property is set
        internal bool IsSetMediaInsightsPipelineConfigurationName()
        {
            return this._mediaInsightsPipelineConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property RealTimeAlertConfiguration. 
        /// <para>
        /// The configuration settings for the real-time alerts in a media insights pipeline configuration.
        /// </para>
        /// </summary>
        public RealTimeAlertConfiguration RealTimeAlertConfiguration
        {
            get { return this._realTimeAlertConfiguration; }
            set { this._realTimeAlertConfiguration = value; }
        }

        // Check to see if RealTimeAlertConfiguration property is set
        internal bool IsSetRealTimeAlertConfiguration()
        {
            return this._realTimeAlertConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceAccessRoleArn. 
        /// <para>
        /// The ARN of the role used by the service to access Amazon Web Services resources, including
        /// <code>Transcribe</code> and <code>Transcribe Call Analytics</code>, on the caller’s
        /// behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string ResourceAccessRoleArn
        {
            get { return this._resourceAccessRoleArn; }
            set { this._resourceAccessRoleArn = value; }
        }

        // Check to see if ResourceAccessRoleArn property is set
        internal bool IsSetResourceAccessRoleArn()
        {
            return this._resourceAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the media insights pipeline configuration.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}