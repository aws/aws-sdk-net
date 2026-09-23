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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A summary of the media insights pipeline configuration.
    /// </summary>
    public partial class MediaInsightsPipelineConfigurationSummary
    {
        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationArn. 
        /// <para>
        /// The ARN of the media insights pipeline configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string MediaInsightsPipelineConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the MediaInsightsPipelineConfigurationArn property is set.
        /// </summary>
        internal bool IsSetMediaInsightsPipelineConfigurationArn() => this.MediaInsightsPipelineConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationId. 
        /// <para>
        /// The ID of the media insights pipeline configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string MediaInsightsPipelineConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the MediaInsightsPipelineConfigurationId property is set.
        /// </summary>
        internal bool IsSetMediaInsightsPipelineConfigurationId() => this.MediaInsightsPipelineConfigurationId != null;

        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationName. 
        /// <para>
        /// The name of the media insights pipeline configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 64)]
        public string MediaInsightsPipelineConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the MediaInsightsPipelineConfigurationName property is set.
        /// </summary>
        internal bool IsSetMediaInsightsPipelineConfigurationName() => this.MediaInsightsPipelineConfigurationName != null;
    }
}
