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
    /// Container for the parameters to the UpdateMediaInsightsPipelineConfiguration operation.
    /// Updates the media insights pipeline's configuration settings.
    /// </summary>
    public partial class UpdateMediaInsightsPipelineConfigurationRequest : AmazonChimeSDKMediaPipelinesRequest
    {
        private List<MediaInsightsPipelineConfigurationElement> _elements = new List<MediaInsightsPipelineConfigurationElement>();
        private string _identifier;
        private RealTimeAlertConfiguration _realTimeAlertConfiguration;
        private string _resourceAccessRoleArn;

        /// <summary>
        /// Gets and sets the property Elements. 
        /// <para>
        /// The elements in the request, such as a processor for Amazon Transcribe or a sink for
        /// a Kinesis Data Stream..
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier for the resource to be updated. Valid values include the name
        /// and ARN of the media insights pipeline configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property RealTimeAlertConfiguration. 
        /// <para>
        /// The configuration settings for real-time alerts for the media insights pipeline.
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
        /// The ARN of the role used by the service to access Amazon Web Services resources.
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

    }
}