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

namespace Amazon.SagemakerEdgeManager.Model
{
    /// <summary>
    /// Information about a model deployed on an edge device that is registered with SageMaker
    /// Edge Manager.
    /// </summary>
    public partial class Model
    {
        /// <summary>
        /// Gets and sets the property LatestInference. 
        /// <para>
        /// The timestamp of the last inference that was made.
        /// </para>
        /// </summary>
        public DateTime? LatestInference { get; set; }

        /// <summary>
        /// Checks to see if the LatestInference property is set.
        /// </summary>
        internal bool IsSetLatestInference() => this.LatestInference.HasValue;

        /// <summary>
        /// Gets and sets the property LatestSampleTime. 
        /// <para>
        /// The timestamp of the last data sample taken.
        /// </para>
        /// </summary>
        public DateTime? LatestSampleTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestSampleTime property is set.
        /// </summary>
        internal bool IsSetLatestSampleTime() => this.LatestSampleTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelMetrics. 
        /// <para>
        /// Information required for model metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EdgeMetric> ModelMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<EdgeMetric>() : null;

        /// <summary>
        /// Checks to see if the ModelMetrics property is set.
        /// </summary>
        internal bool IsSetModelMetrics() => this.ModelMetrics != null && (this.ModelMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 255)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersion property is set.
        /// </summary>
        internal bool IsSetModelVersion() => this.ModelVersion != null;
    }
}
