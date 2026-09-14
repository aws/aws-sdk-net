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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Represents a complete telemetry pipeline resource with configuration, status, and
    /// metadata for data processing and transformation.
    /// </summary>
    public partial class TelemetryPipeline
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the telemetry pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration that defines how the telemetry pipeline processes data.
        /// </para>
        /// </summary>
        public TelemetryPipelineConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CreatedTimeStamp. 
        /// <para>
        /// The timestamp when the telemetry pipeline was created.
        /// </para>
        /// </summary>
        public long? CreatedTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimeStamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimeStamp() => this.CreatedTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateTimeStamp. 
        /// <para>
        /// The timestamp when the telemetry pipeline was last updated.
        /// </para>
        /// </summary>
        public long? LastUpdateTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimeStamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimeStamp() => this.LastUpdateTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the telemetry pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 28)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the telemetry pipeline.
        /// </para>
        /// </summary>
        public TelemetryPipelineStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the pipeline status, including reasons for failure states.
        /// </para>
        /// </summary>
        public TelemetryPipelineStatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pairs associated with the telemetry pipeline resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
