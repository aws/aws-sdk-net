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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// A single metric observed on a context graph node.
    /// </summary>
    public partial class MetricMetadata
    {
        /// <summary>
        /// Gets and sets the property Attributes. Per-metric qualifying attributes the console
        /// uses to query this metric's telemetry. These are the RAW, store-matching values keyed
        /// by their OTel names ("service.name", "service.namespace", "cloud.provider", "cloud.account.id",
        /// "cloud.region", "instrumentation_scope") — deliberately NOT the node's normalized/merged
        /// identity, so the query selectors match the emitted series. A merged node can carry
        /// different values per metric, which is why they live here rather than on the node.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricType. OTel metric kind: "gauge", "sum", "histogram",
        /// "exponential_histogram", or "summary" (CloudWatch-vended metrics carry the same kinds).
        /// Absent when the producer did not report one.
        /// </summary>
        public string MetricType { get; set; }

        /// <summary>
        /// Checks to see if the MetricType property is set.
        /// </summary>
        internal bool IsSetMetricType() => this.MetricType != null;

        /// <summary>
        /// Gets and sets the property Name. The metric name as emitted, such as "Duration".
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Namespace. DEPRECATED: read attributes["service.namespace"]
        /// instead. Retained (deprecated) for backward compatibility with existing consumers;
        /// will be removed once they migrate. The logical service grouping the metric belongs
        /// to.
        /// </summary>
        [Obsolete("Use attributes['service.namespace']; retained for backward compatibility.")]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property PreferredStat. The statistic to chart or alarm on, such
        /// as "p99" or "Sum". Free-form and frequently absent.
        /// </summary>
        public string PreferredStat { get; set; }

        /// <summary>
        /// Checks to see if the PreferredStat property is set.
        /// </summary>
        internal bool IsSetPreferredStat() => this.PreferredStat != null;

        /// <summary>
        /// Gets and sets the property Semantics. What the metric means and the unit it is reported
        /// in.
        /// </summary>
        public MetricSemantics Semantics { get; set; }

        /// <summary>
        /// Checks to see if the Semantics property is set.
        /// </summary>
        internal bool IsSetSemantics() => this.Semantics != null;
    }
}
