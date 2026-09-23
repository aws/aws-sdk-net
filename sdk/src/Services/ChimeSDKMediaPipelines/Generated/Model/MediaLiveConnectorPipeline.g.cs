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
    /// The connector pipeline.
    /// </summary>
    public partial class MediaLiveConnectorPipeline
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the connector pipeline was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property MediaPipelineArn. 
        /// <para>
        /// The connector pipeline's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string MediaPipelineArn { get; set; }

        /// <summary>
        /// Checks to see if the MediaPipelineArn property is set.
        /// </summary>
        internal bool IsSetMediaPipelineArn() => this.MediaPipelineArn != null;

        /// <summary>
        /// Gets and sets the property MediaPipelineId. 
        /// <para>
        /// The connector pipeline's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string MediaPipelineId { get; set; }

        /// <summary>
        /// Checks to see if the MediaPipelineId property is set.
        /// </summary>
        internal bool IsSetMediaPipelineId() => this.MediaPipelineId != null;

        /// <summary>
        /// Gets and sets the property Sinks. 
        /// <para>
        /// The connector pipeline's data sinks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<LiveConnectorSinkConfiguration> Sinks { get; set; } = AWSConfigs.InitializeCollections ? new List<LiveConnectorSinkConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Sinks property is set.
        /// </summary>
        internal bool IsSetSinks() => this.Sinks != null && (this.Sinks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The connector pipeline's data sources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<LiveConnectorSourceConfiguration> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<LiveConnectorSourceConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The connector pipeline's status.
        /// </para>
        /// </summary>
        public MediaPipelineStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which the connector pipeline was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;
    }
}
