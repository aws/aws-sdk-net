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

namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAnomalyDetector operation. Creates an anomaly
    /// detector within a workspace using the Random Cut Forest algorithm for time-series
    /// analysis. The anomaly detector analyzes Amazon Managed Service for Prometheus metrics
    /// to identify unusual patterns and behaviors.
    /// </summary>
    public partial class CreateAnomalyDetectorRequest : AmazonPrometheusServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// A user-friendly name for the anomaly detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The algorithm configuration for the anomaly detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnomalyDetectorConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property EvaluationIntervalInSeconds. 
        /// <para>
        /// The frequency, in seconds, at which the anomaly detector evaluates metrics. The default
        /// value is 60 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 30, Max = 86400)]
        public int? EvaluationIntervalInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationIntervalInSeconds property is set.
        /// </summary>
        internal bool IsSetEvaluationIntervalInSeconds() => this.EvaluationIntervalInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// The Amazon Managed Service for Prometheus metric labels to associate with the anomaly
        /// detector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 140)]
        public Dictionary<string, string> Labels { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Labels property is set.
        /// </summary>
        internal bool IsSetLabels() => this.Labels != null && (this.Labels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MissingDataAction. 
        /// <para>
        /// Specifies the action to take when data is missing during evaluation.
        /// </para>
        /// </summary>
        public AnomalyDetectorMissingDataAction MissingDataAction { get; set; }

        /// <summary>
        /// Checks to see if the MissingDataAction property is set.
        /// </summary>
        internal bool IsSetMissingDataAction() => this.MissingDataAction != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata to apply to the anomaly detector to assist with categorization and organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The identifier of the workspace where the anomaly detector will be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;
    }
}
