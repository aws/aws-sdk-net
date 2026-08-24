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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private string _arn;
        private string _category;
        private DateTime? _createdTime;
        private CreatedByInfo _createdUser;
        private MetricCreationMethod _creationMethod;
        private string _defaultStat;
        private string _description;
        private DateTime? _effectiveTime;
        private List<AvailableFilter> _filters = AWSConfigs.InitializeCollections ? new List<AvailableFilter>() : null;
        private List<string> _groupings = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _id;
        private string _lastModifiedRegion;
        private DateTime? _lastModifiedTime;
        private CreatedByInfo _lastModifiedUser;
        private MetricCalculation _metricCalculation;
        private string _name;
        private TrendIndicator _positiveTrendIndicator;
        private string _primaryEventSource;
        private string _primaryEventSourceEffectiveTimestampType;
        private long? _refreshRate;
        private MetricStatus _status;
        private List<string> _supportedStats = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _supportsCustomCalculation;
        private bool? _supportsPreaggregateCalculation;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private MetricType _type;
        private MetricUnit _unit;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the metric. May be qualified with <c>$SAVED</c>
        /// or <c>$LATEST</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp of when the metric was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedUser. 
        /// <para>
        /// The user that created the metric. The creator for metrics created through the CreateMetric
        /// API will be <c>Amazon Connect API</c>.
        /// </para>
        /// </summary>
        public CreatedByInfo CreatedUser
        {
            get { return this._createdUser; }
            set { this._createdUser = value; }
        }

        // Check to see if CreatedUser property is set
        internal bool IsSetCreatedUser()
        {
            return this._createdUser != null;
        }

        /// <summary>
        /// Gets and sets the property CreationMethod. 
        /// <para>
        /// The method used to create the metric. Valid values: <c>SERVICE_LEVEL_BUILDER</c> (created
        /// with the guided service-level experience) | <c>METRIC_BUILDER</c> (created with the
        /// free-form metric builder).
        /// </para>
        /// </summary>
        public MetricCreationMethod CreationMethod
        {
            get { return this._creationMethod; }
            set { this._creationMethod = value; }
        }

        // Check to see if CreationMethod property is set
        internal bool IsSetCreationMethod()
        {
            return this._creationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultStat. 
        /// <para>
        /// The default stat aggregation for the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string DefaultStat
        {
            get { return this._defaultStat; }
            set { this._defaultStat = value; }
        }

        // Check to see if DefaultStat property is set
        internal bool IsSetDefaultStat()
        {
            return this._defaultStat != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveTime. 
        /// <para>
        /// The earliest time that can be queried for this metric.
        /// </para>
        /// </summary>
        public DateTime? EffectiveTime
        {
            get { return this._effectiveTime; }
            set { this._effectiveTime = value; }
        }

        // Check to see if EffectiveTime property is set
        internal bool IsSetEffectiveTime()
        {
            return this._effectiveTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters applied to the metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AvailableFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Groupings. 
        /// <para>
        /// The groupings available for this metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Groupings
        {
            get { return this._groupings; }
            set { this._groupings = value; }
        }

        // Check to see if Groupings property is set
        internal bool IsSetGroupings()
        {
            return this._groupings != null && (this._groupings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=150)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The region where the metric was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion
        {
            get { return this._lastModifiedRegion; }
            set { this._lastModifiedRegion = value; }
        }

        // Check to see if LastModifiedRegion property is set
        internal bool IsSetLastModifiedRegion()
        {
            return this._lastModifiedRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp of when the metric was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedUser. 
        /// <para>
        /// The user that last modified the metric. For modifications made through the API, this
        /// will be <c>Amazon Connect API</c>.
        /// </para>
        /// </summary>
        public CreatedByInfo LastModifiedUser
        {
            get { return this._lastModifiedUser; }
            set { this._lastModifiedUser = value; }
        }

        // Check to see if LastModifiedUser property is set
        internal bool IsSetLastModifiedUser()
        {
            return this._lastModifiedUser != null;
        }

        /// <summary>
        /// Gets and sets the property MetricCalculation. 
        /// <para>
        /// The calculation definition for the metric.
        /// </para>
        /// </summary>
        public MetricCalculation MetricCalculation
        {
            get { return this._metricCalculation; }
            set { this._metricCalculation = value; }
        }

        // Check to see if MetricCalculation property is set
        internal bool IsSetMetricCalculation()
        {
            return this._metricCalculation != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property PositiveTrendIndicator. 
        /// <para>
        /// How an increase in the metric value should be interpreted. Valid values: <c>POSITIVE</c>,
        /// <c>NEUTRAL</c>, <c>NEGATIVE</c>.
        /// </para>
        /// </summary>
        public TrendIndicator PositiveTrendIndicator
        {
            get { return this._positiveTrendIndicator; }
            set { this._positiveTrendIndicator = value; }
        }

        // Check to see if PositiveTrendIndicator property is set
        internal bool IsSetPositiveTrendIndicator()
        {
            return this._positiveTrendIndicator != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryEventSource. 
        /// <para>
        /// The primary event source for the metric data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PrimaryEventSource
        {
            get { return this._primaryEventSource; }
            set { this._primaryEventSource = value; }
        }

        // Check to see if PrimaryEventSource property is set
        internal bool IsSetPrimaryEventSource()
        {
            return this._primaryEventSource != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryEventSourceEffectiveTimestampType. 
        /// <para>
        /// The timestamp type that determines where the metric appears on a time series.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PrimaryEventSourceEffectiveTimestampType
        {
            get { return this._primaryEventSourceEffectiveTimestampType; }
            set { this._primaryEventSourceEffectiveTimestampType = value; }
        }

        // Check to see if PrimaryEventSourceEffectiveTimestampType property is set
        internal bool IsSetPrimaryEventSourceEffectiveTimestampType()
        {
            return this._primaryEventSourceEffectiveTimestampType != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshRate. 
        /// <para>
        /// The minimum interval, in seconds, between data refreshes for this metric.
        /// </para>
        /// </summary>
        public long? RefreshRate
        {
            get { return this._refreshRate; }
            set { this._refreshRate = value; }
        }

        // Check to see if RefreshRate property is set
        internal bool IsSetRefreshRate()
        {
            return this._refreshRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The publish status of the metric. Valid values: <c>PUBLISHED</c> | <c>SAVED</c>.
        /// </para>
        /// </summary>
        public MetricStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedStats. 
        /// <para>
        /// The stat aggregations available for this metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedStats
        {
            get { return this._supportedStats; }
            set { this._supportedStats = value; }
        }

        // Check to see if SupportedStats property is set
        internal bool IsSetSupportedStats()
        {
            return this._supportedStats != null && (this._supportedStats.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportsCustomCalculation. 
        /// <para>
        /// Specifies whether the metric can be used as a component of custom metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? SupportsCustomCalculation
        {
            get { return this._supportsCustomCalculation; }
            set { this._supportsCustomCalculation = value; }
        }

        // Check to see if SupportsCustomCalculation property is set
        internal bool IsSetSupportsCustomCalculation()
        {
            return this._supportsCustomCalculation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsPreaggregateCalculation. 
        /// <para>
        /// Specifies whether the metric can be used inside aggregating statistical functions
        /// (SUM, AVG, etc.) in custom metric calculations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? SupportsPreaggregateCalculation
        {
            get { return this._supportsPreaggregateCalculation; }
            set { this._supportsPreaggregateCalculation = value; }
        }

        // Check to see if SupportsPreaggregateCalculation property is set
        internal bool IsSetSupportsPreaggregateCalculation()
        {
            return this._supportsPreaggregateCalculation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the metric. Valid values: <c>AWS_MANAGED</c> | <c>CUSTOMER_MANAGED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The display unit for the metric's data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}