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
    /// This structure contains the information about the metric that is used for a request-based
    /// SLO.
    /// </summary>
    public partial class RequestBasedServiceLevelIndicatorMetric
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
        /// This is a string-to-string map that contains information about the type of object
        /// that this SLO is related to. It can include the following fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Type</c> designates the type of object that this SLO is related to.
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
        /// If the SLO monitors either the <c>LATENCY</c> or <c>AVAILABILITY</c> metric that Application
        /// Signals collects, this field displays which of those metrics is used.
        /// </para>
        /// </summary>
        public ServiceLevelIndicatorMetricType MetricType { get; set; }

        /// <summary>
        /// Checks to see if the MetricType property is set.
        /// </summary>
        internal bool IsSetMetricType() => this.MetricType != null;

        /// <summary>
        /// Gets and sets the property MonitoredRequestCountMetric. 
        /// <para>
        /// This structure defines the metric that is used as the "good request" or "bad request"
        /// value for a request-based SLO. This value observed for the metric defined in <c>TotalRequestCountMetric</c>
        /// is divided by the number found for <c>MonitoredRequestCountMetric</c> to determine
        /// the percentage of successful requests that this SLO tracks.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitoredRequestCountMetricDataQueries MonitoredRequestCountMetric { get; set; }

        /// <summary>
        /// Checks to see if the MonitoredRequestCountMetric property is set.
        /// </summary>
        internal bool IsSetMonitoredRequestCountMetric() => this.MonitoredRequestCountMetric != null;

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// If the SLO monitors a specific operation of the service, this field displays that
        /// operation name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OperationName { get; set; }

        /// <summary>
        /// Checks to see if the OperationName property is set.
        /// </summary>
        internal bool IsSetOperationName() => this.OperationName != null;

        /// <summary>
        /// Gets and sets the property TotalRequestCountMetric. 
        /// <para>
        /// This structure defines the metric that is used as the "total requests" number for
        /// a request-based SLO. The number observed for this metric is divided by the number
        /// of "good requests" or "bad requests" that is observed for the metric defined in <c>MonitoredRequestCountMetric</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<MetricDataQuery> TotalRequestCountMetric { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricDataQuery>() : null;

        /// <summary>
        /// Checks to see if the TotalRequestCountMetric property is set.
        /// </summary>
        internal bool IsSetTotalRequestCountMetric() => this.TotalRequestCountMetric != null && (this.TotalRequestCountMetric.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
