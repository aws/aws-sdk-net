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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _metricType;
        private string _name;
        private string _awsNamespace;
        private string _preferredStat;
        private MetricSemantics _semantics;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Per-metric qualifying attributes the console uses to query this metric's telemetry.
        /// These are the RAW, store-matching values keyed by their OTel names (&quot;service.name&quot;,
        /// &quot;service.namespace&quot;, &quot;cloud.provider&quot;, &quot;cloud.account.id&quot;,
        /// &quot;cloud.region&quot;, &quot;instrumentation_scope&quot;) — deliberately NOT the
        /// node's normalized/merged identity, so the query selectors match the emitted series.
        /// A merged node can carry different values per metric, which is why they live here rather
        /// than on the node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricType. 
        /// <para>
        /// OTel metric kind: &quot;gauge&quot;, &quot;sum&quot;, &quot;histogram&quot;, &quot;exponential_histogram&quot;,
        /// or &quot;summary&quot; (CloudWatch-vended metrics carry the same kinds). Absent when
        /// the producer did not report one.
        /// </para>
        /// </summary>
        public string MetricType
        {
            get { return this._metricType; }
            set { this._metricType = value; }
        }

        // Check to see if MetricType property is set
        internal bool IsSetMetricType()
        {
            return this._metricType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The metric name as emitted, such as &quot;Duration&quot;.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// DEPRECATED: read attributes[&quot;service.namespace&quot;] instead. Retained (deprecated)
        /// for backward compatibility with existing consumers; will be removed once they migrate.
        /// The logical service grouping the metric belongs to.
        /// </para>
        /// </summary>
        [Obsolete("Use attributes['service.namespace']; retained for backward compatibility.")]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredStat. 
        /// <para>
        /// The statistic to chart or alarm on, such as &quot;p99&quot; or &quot;Sum&quot;. Free-form
        /// and frequently absent.
        /// </para>
        /// </summary>
        public string PreferredStat
        {
            get { return this._preferredStat; }
            set { this._preferredStat = value; }
        }

        // Check to see if PreferredStat property is set
        internal bool IsSetPreferredStat()
        {
            return this._preferredStat != null;
        }

        /// <summary>
        /// Gets and sets the property Semantics. 
        /// <para>
        /// What the metric means and the unit it is reported in.
        /// </para>
        /// </summary>
        public MetricSemantics Semantics
        {
            get { return this._semantics; }
            set { this._semantics = value; }
        }

        // Check to see if Semantics property is set
        internal bool IsSetSemantics()
        {
            return this._semantics != null;
        }

    }
}