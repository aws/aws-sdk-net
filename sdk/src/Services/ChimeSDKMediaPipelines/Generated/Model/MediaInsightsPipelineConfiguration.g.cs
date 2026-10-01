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
    /// A structure that contains the configuration settings for a media insights pipeline.
    /// </summary>
    public partial class MediaInsightsPipelineConfiguration
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the configuration was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Elements. 
        /// <para>
        /// The elements in the configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaInsightsPipelineConfigurationElement> Elements { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaInsightsPipelineConfigurationElement>() : null;

        /// <summary>
        /// Checks to see if the Elements property is set.
        /// </summary>
        internal bool IsSetElements() => this.Elements != null && (this.Elements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationArn. 
        /// <para>
        /// The ARN of the configuration.
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
        /// The ID of the configuration.
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
        /// The name of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 64)]
        public string MediaInsightsPipelineConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the MediaInsightsPipelineConfigurationName property is set.
        /// </summary>
        internal bool IsSetMediaInsightsPipelineConfigurationName() => this.MediaInsightsPipelineConfigurationName != null;

        /// <summary>
        /// Gets and sets the property RealTimeAlertConfiguration. 
        /// <para>
        /// Lists the rules that trigger a real-time alert.
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
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string ResourceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetResourceAccessRoleArn() => this.ResourceAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which the configuration was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;
    }
}
