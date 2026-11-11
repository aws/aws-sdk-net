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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains the full definition of a metric, including its calculation, unit, status,
    /// and trend indicator.
    /// </summary>
    public partial class MetricDefinition
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the metric. May be qualified with <c>$SAVED</c>
        /// or <c>$LATEST</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp of when the metric was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedUser. 
        /// <para>
        /// The user that created the metric. The creator for metrics created through the CreateMetric
        /// API will be <c>Amazon Connect API</c>.
        /// </para>
        /// </summary>
        public CreatedByInfo CreatedUser { get; set; }

        /// <summary>
        /// Checks to see if the CreatedUser property is set.
        /// </summary>
        internal bool IsSetCreatedUser() => this.CreatedUser != null;

        /// <summary>
        /// Gets and sets the property CreationMethod. 
        /// <para>
        /// The method used to create the metric. Valid values: <c>SERVICE_LEVEL_BUILDER</c> (created
        /// with the guided service-level experience) | <c>METRIC_BUILDER</c> (created with the
        /// free-form metric builder).
        /// </para>
        /// </summary>
        public MetricCreationMethod CreationMethod { get; set; }

        /// <summary>
        /// Checks to see if the CreationMethod property is set.
        /// </summary>
        internal bool IsSetCreationMethod() => this.CreationMethod != null;

        /// <summary>
        /// Gets and sets the property DefaultStat. 
        /// <para>
        /// The default stat aggregation for the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string DefaultStat { get; set; }

        /// <summary>
        /// Checks to see if the DefaultStat property is set.
        /// </summary>
        internal bool IsSetDefaultStat() => this.DefaultStat != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EffectiveTime. 
        /// <para>
        /// The earliest time that can be queried for this metric.
        /// </para>
        /// </summary>
        public DateTime? EffectiveTime { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveTime property is set.
        /// </summary>
        internal bool IsSetEffectiveTime() => this.EffectiveTime.HasValue;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters applied to the metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AvailableFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<AvailableFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Groupings. 
        /// <para>
        /// The groupings available for this metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Groupings { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Groupings property is set.
        /// </summary>
        internal bool IsSetGroupings() => this.Groupings != null && (this.Groupings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 150)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The region where the metric was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedRegion property is set.
        /// </summary>
        internal bool IsSetLastModifiedRegion() => this.LastModifiedRegion != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp of when the metric was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedUser. 
        /// <para>
        /// The user that last modified the metric. For modifications made through the API, this
        /// will be <c>Amazon Connect API</c>.
        /// </para>
        /// </summary>
        public CreatedByInfo LastModifiedUser { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedUser property is set.
        /// </summary>
        internal bool IsSetLastModifiedUser() => this.LastModifiedUser != null;

        /// <summary>
        /// Gets and sets the property MetricCalculation. 
        /// <para>
        /// The calculation definition for the metric.
        /// </para>
        /// </summary>
        public MetricCalculation MetricCalculation { get; set; }

        /// <summary>
        /// Checks to see if the MetricCalculation property is set.
        /// </summary>
        internal bool IsSetMetricCalculation() => this.MetricCalculation != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PositiveTrendIndicator. 
        /// <para>
        /// How an increase in the metric value should be interpreted. Valid values: <c>POSITIVE</c>,
        /// <c>NEUTRAL</c>, <c>NEGATIVE</c>.
        /// </para>
        /// </summary>
        public TrendIndicator PositiveTrendIndicator { get; set; }

        /// <summary>
        /// Checks to see if the PositiveTrendIndicator property is set.
        /// </summary>
        internal bool IsSetPositiveTrendIndicator() => this.PositiveTrendIndicator != null;

        /// <summary>
        /// Gets and sets the property PrimaryEventSource. 
        /// <para>
        /// The primary event source for the metric data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PrimaryEventSource { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryEventSource property is set.
        /// </summary>
        internal bool IsSetPrimaryEventSource() => this.PrimaryEventSource != null;

        /// <summary>
        /// Gets and sets the property PrimaryEventSourceEffectiveTimestampType. 
        /// <para>
        /// The timestamp type that determines where the metric appears on a time series.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PrimaryEventSourceEffectiveTimestampType { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryEventSourceEffectiveTimestampType property is set.
        /// </summary>
        internal bool IsSetPrimaryEventSourceEffectiveTimestampType() => this.PrimaryEventSourceEffectiveTimestampType != null;

        /// <summary>
        /// Gets and sets the property RefreshRate. 
        /// <para>
        /// The minimum interval, in seconds, between data refreshes for this metric.
        /// </para>
        /// </summary>
        public long? RefreshRate { get; set; }

        /// <summary>
        /// Checks to see if the RefreshRate property is set.
        /// </summary>
        internal bool IsSetRefreshRate() => this.RefreshRate.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The publish status of the metric. Valid values: <c>PUBLISHED</c> | <c>SAVED</c>.
        /// </para>
        /// </summary>
        public MetricStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SupportedStats. 
        /// <para>
        /// The stat aggregations available for this metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedStats { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedStats property is set.
        /// </summary>
        internal bool IsSetSupportedStats() => this.SupportedStats != null && (this.SupportedStats.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportsCustomCalculation. 
        /// <para>
        /// Specifies whether the metric can be used as a component of custom metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? SupportsCustomCalculation { get; set; }

        /// <summary>
        /// Checks to see if the SupportsCustomCalculation property is set.
        /// </summary>
        internal bool IsSetSupportsCustomCalculation() => this.SupportsCustomCalculation.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsPreaggregateCalculation. 
        /// <para>
        /// Specifies whether the metric can be used inside aggregating statistical functions
        /// (SUM, AVG, etc.) in custom metric calculations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? SupportsPreaggregateCalculation { get; set; }

        /// <summary>
        /// Checks to see if the SupportsPreaggregateCalculation property is set.
        /// </summary>
        internal bool IsSetSupportsPreaggregateCalculation() => this.SupportsPreaggregateCalculation.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the metric. Valid values: <c>AWS_MANAGED</c> | <c>CUSTOMER_MANAGED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetricType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The display unit for the metric's data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetricUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
