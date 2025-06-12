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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
    public partial class RequestBasedServiceLevelIndicatorMetricConfig
    {
        private DependencyConfig _dependencyConfig;
        private Dictionary<string, string> _keyAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ServiceLevelIndicatorMetricType _metricType;
        private MonitoredRequestCountMetricDataQueries _monitoredRequestCountMetric;
        private string _operationName;
        private List<MetricDataQuery> _totalRequestCountMetric = AWSConfigs.InitializeCollections ? new List<MetricDataQuery>() : null;

        /// <summary>
        /// Gets and sets the property DependencyConfig. 
        /// <para>
        /// Identifies the dependency using the <c>DependencyKeyAttributes</c> and <c>DependencyOperationName</c>.
        /// 
        /// </para>
        /// </summary>
        public DependencyConfig DependencyConfig
        {
            get { return this._dependencyConfig; }
            set { this._dependencyConfig = value; }
        }

        // Check to see if DependencyConfig property is set
        internal bool IsSetDependencyConfig()
        {
            return this._dependencyConfig != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public Dictionary<string, string> KeyAttributes
        {
            get { return this._keyAttributes; }
            set { this._keyAttributes = value; }
        }

        // Check to see if KeyAttributes property is set
        internal bool IsSetKeyAttributes()
        {
            return this._keyAttributes != null && (this._keyAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricType. 
        /// <para>
        /// If the SLO is to monitor either the <c>LATENCY</c> or <c>AVAILABILITY</c> metric that
        /// Application Signals collects, use this field to specify which of those metrics is
        /// used.
        /// </para>
        /// </summary>
        public ServiceLevelIndicatorMetricType MetricType
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
        /// Gets and sets the property MonitoredRequestCountMetric. 
        /// <para>
        /// Use this structure to define the metric that you want to use as the "good request"
        /// or "bad request" value for a request-based SLO. This value observed for the metric
        /// defined in <c>TotalRequestCountMetric</c> will be divided by the number found for
        /// <c>MonitoredRequestCountMetric</c> to determine the percentage of successful requests
        /// that this SLO tracks.
        /// </para>
        /// </summary>
        public MonitoredRequestCountMetricDataQueries MonitoredRequestCountMetric
        {
            get { return this._monitoredRequestCountMetric; }
            set { this._monitoredRequestCountMetric = value; }
        }

        // Check to see if MonitoredRequestCountMetric property is set
        internal bool IsSetMonitoredRequestCountMetric()
        {
            return this._monitoredRequestCountMetric != null;
        }

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// If the SLO is to monitor a specific operation of the service, use this field to specify
        /// the name of that operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OperationName
        {
            get { return this._operationName; }
            set { this._operationName = value; }
        }

        // Check to see if OperationName property is set
        internal bool IsSetOperationName()
        {
            return this._operationName != null;
        }

        /// <summary>
        /// Gets and sets the property TotalRequestCountMetric. 
        /// <para>
        /// Use this structure to define the metric that you want to use as the "total requests"
        /// number for a request-based SLO. This result will be divided by the "good request"
        /// or "bad request" value defined in <c>MonitoredRequestCountMetric</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricDataQuery> TotalRequestCountMetric
        {
            get { return this._totalRequestCountMetric; }
            set { this._totalRequestCountMetric = value; }
        }

        // Check to see if TotalRequestCountMetric property is set
        internal bool IsSetTotalRequestCountMetric()
        {
            return this._totalRequestCountMetric != null && (this._totalRequestCountMetric.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}