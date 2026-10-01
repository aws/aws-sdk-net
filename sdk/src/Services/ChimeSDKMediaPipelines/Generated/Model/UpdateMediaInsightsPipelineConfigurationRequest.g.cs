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
    /// Container for the parameters to the UpdateMediaInsightsPipelineConfiguration operation.
    /// Updates the media insights pipeline's configuration settings.
    /// </summary>
    public partial class UpdateMediaInsightsPipelineConfigurationRequest : AmazonChimeSDKMediaPipelinesRequest
    {
        /// <summary>
        /// Gets and sets the property Elements. 
        /// <para>
        /// The elements in the request, such as a processor for Amazon Transcribe or a sink for
        /// a Kinesis Data Stream..
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<MediaInsightsPipelineConfigurationElement> Elements { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaInsightsPipelineConfigurationElement>() : null;

        /// <summary>
        /// Checks to see if the Elements property is set.
        /// </summary>
        internal bool IsSetElements() => this.Elements != null && (this.Elements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier for the resource to be updated. Valid values include the name
        /// and ARN of the media insights pipeline configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property RealTimeAlertConfiguration. 
        /// <para>
        /// The configuration settings for real-time alerts for the media insights pipeline.
        /// </para>
        /// </summary>
        public RealTimeAlertConfiguration RealTimeAlertConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RealTimeAlertConfiguration property is set.
        /// </summary>
        internal bool IsSetRealTimeAlertConfiguration() => this.RealTimeAlertConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResourceAccessRoleArn. 
        /// <para>
        /// The ARN of the role used by the service to access Amazon Web Services resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string ResourceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetResourceAccessRoleArn() => this.ResourceAccessRoleArn != null;
    }
}
