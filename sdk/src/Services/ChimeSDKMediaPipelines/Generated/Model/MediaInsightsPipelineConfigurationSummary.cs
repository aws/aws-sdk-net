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
    /// A summary of the media insights pipeline configuration.
    /// </summary>
    public partial class MediaInsightsPipelineConfigurationSummary
    {
        private string _mediaInsightsPipelineConfigurationArn;
        private string _mediaInsightsPipelineConfigurationId;
        private string _mediaInsightsPipelineConfigurationName;

        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationArn. 
        /// <para>
        /// The ARN of the media insights pipeline configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string MediaInsightsPipelineConfigurationArn
        {
            get { return this._mediaInsightsPipelineConfigurationArn; }
            set { this._mediaInsightsPipelineConfigurationArn = value; }
        }

        // Check to see if MediaInsightsPipelineConfigurationArn property is set
        internal bool IsSetMediaInsightsPipelineConfigurationArn()
        {
            return this._mediaInsightsPipelineConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationId. 
        /// <para>
        /// The ID of the media insights pipeline configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string MediaInsightsPipelineConfigurationId
        {
            get { return this._mediaInsightsPipelineConfigurationId; }
            set { this._mediaInsightsPipelineConfigurationId = value; }
        }

        // Check to see if MediaInsightsPipelineConfigurationId property is set
        internal bool IsSetMediaInsightsPipelineConfigurationId()
        {
            return this._mediaInsightsPipelineConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationName. 
        /// <para>
        /// The name of the media insights pipeline configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
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

    }
}