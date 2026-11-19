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
    /// Container for the parameters to the StartThirdPartyTelemetryEnrichment operation.
    /// Starts a third-party telemetry enrichment. An enrichment adds resource metadata, such
    /// as tags, from a third-party telemetry source to the telemetry that CloudWatch receives
    /// from the resources of that source. <para> You specify an Amazon Web Services Config
    /// connector for your third-party environment, such as a Microsoft Azure tenant. You
    /// can use each connector for only one enrichment. </para> <para> To use this operation,
    /// you must have the <c>config:PutThirdPartyServiceLinkedConfigurationRecorder</c> permission.
    /// If the Amazon Web Services Config service-linked role does not exist in your account,
    /// you must also have the <c>iam:CreateServiceLinkedRole</c> permission. </para>
    /// </summary>
    public partial class StartThirdPartyTelemetryEnrichmentRequest : AmazonObservabilityAdminRequest
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the enrichment. The name must be unique in your account and Region. You
        /// can use the name instead of the ARN to identify the enrichment in other operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the enrichment resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TelemetrySourceConfiguration. 
        /// <para>
        /// The third-party telemetry source to collect resource metadata from. Specify exactly
        /// one telemetry source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TelemetrySourceConfigurationInput TelemetrySourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TelemetrySourceConfiguration property is set.
        /// </summary>
        internal bool IsSetTelemetrySourceConfiguration() => this.TelemetrySourceConfiguration != null;
    }
}
