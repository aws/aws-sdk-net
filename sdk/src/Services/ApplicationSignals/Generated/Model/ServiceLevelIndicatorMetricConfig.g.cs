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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Use this structure to specify the information for the metric that a period-based SLO
    /// will monitor.
    /// </summary>
    public partial class ServiceLevelIndicatorMetricConfig
    {
        /// <summary>
        /// Gets and sets the property CompositeSliConfig. 
        /// <para>
        /// The composite SLI configuration for service-level SLOs that monitor multiple operations
        /// of a service.
        /// </para>
        /// </summary>
        public CompositeSliConfig CompositeSliConfig { get; set; }

        /// <summary>
        /// Checks to see if the CompositeSliConfig property is set.
        /// </summary>
        internal bool IsSetCompositeSliConfig() => this.CompositeSliConfig != null;

        /// <summary>
        /// Gets and sets the property DependencyConfig. 
        /// <para>
        /// Identifies the dependency using the <c>DependencyKeyAttributes</c> and <c>DependencyOperationName</c>.
        /// 
        /// </para>
        /// </summary>
        public DependencyConfig DependencyConfig { get; set; }

        /// <summary>
        /// Checks to see if the DependencyConfig property is set.
        /// </summary>
        internal bool IsSetDependencyConfig() => this.DependencyConfig != null;

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// If this SLO is related to a metric collected by Application Signals, you must use
        /// this field to specify which service the SLO metric is related to. To do so, you must
        /// specify at least the <c>Type</c>, <c>Name</c>, and <c>Environment</c> attributes.
        /// </para>
        ///  
        /// <para>
        /// This is a string-to-string map. It can include the following fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Type</c> designates the type of object this is.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType</c> specifies the type of the resource. This field is used only when
        /// the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> specifies the name of the object. This is used only if the value of the
        /// <c>Type</c> field is <c>Service</c>, <c>RemoteService</c>, or <c>AWS::Service</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Identifier</c> identifies the resource objects of this resource. This is used
        /// only if the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Environment</c> specifies the location where this object is hosted, or what it
        /// belongs to.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public Dictionary<string, string> KeyAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the KeyAttributes property is set.
        /// </summary>
        internal bool IsSetKeyAttributes() => this.KeyAttributes != null && (this.KeyAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricDataQueries. 
        /// <para>
        /// If this SLO monitors a CloudWatch metric or the result of a CloudWatch metric math
        /// expression, use this structure to specify that metric or expression. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricDataQuery> MetricDataQueries { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricDataQuery>() : null;

        /// <summary>
        /// Checks to see if the MetricDataQueries property is set.
        /// </summary>
        internal bool IsSetMetricDataQueries() => this.MetricDataQueries != null && (this.MetricDataQueries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the CloudWatch metric to use for the SLO, when using a custom metric rather
        /// than Application Signals standard metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property MetricSource. 
        /// <para>
        /// Identifies the metric source for SLOs on resources other than Application Signals
        /// services.
        /// </para>
        /// </summary>
        public MetricSource MetricSource { get; set; }

        /// <summary>
        /// Checks to see if the MetricSource property is set.
        /// </summary>
        internal bool IsSetMetricSource() => this.MetricSource != null;

        /// <summary>
        /// Gets and sets the property MetricType. 
        /// <para>
        /// If the SLO is to monitor either the <c>LATENCY</c> or <c>AVAILABILITY</c> metric that
        /// Application Signals collects, use this field to specify which of those metrics is
        /// used.
        /// </para>
        /// </summary>
        public ServiceLevelIndicatorMetricType MetricType { get; set; }

        /// <summary>
        /// Checks to see if the MetricType property is set.
        /// </summary>
        internal bool IsSetMetricType() => this.MetricType != null;

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// If the SLO is to monitor a specific operation of the service, use this field to specify
        /// the name of that operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OperationName { get; set; }

        /// <summary>
        /// Checks to see if the OperationName property is set.
        /// </summary>
        internal bool IsSetOperationName() => this.OperationName != null;

        /// <summary>
        /// Gets and sets the property PeriodSeconds. 
        /// <para>
        /// The number of seconds to use as the period for SLO evaluation. Your application's
        /// performance is compared to the SLI during each period. For each period, the application
        /// is determined to have either achieved or not achieved the necessary performance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 900)]
        public int? PeriodSeconds { get; set; }

        /// <summary>
        /// Checks to see if the PeriodSeconds property is set.
        /// </summary>
        internal bool IsSetPeriodSeconds() => this.PeriodSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic to use for comparison to the threshold. It can be any CloudWatch statistic
        /// or extended statistic. For more information about statistics, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Statistics-definitions.html">CloudWatch
        /// statistics definitions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string Statistic { get; set; }

        /// <summary>
        /// Checks to see if the Statistic property is set.
        /// </summary>
        internal bool IsSetStatistic() => this.Statistic != null;
    }
}
