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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
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
namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// All the customer-modifiable InfluxDB v2 parameters in Timestream for InfluxDB.
    /// </summary>
    public partial class InfluxDBv2Parameters
    {
        private bool? _fluxLogEnabled;
        private LogLevel _logLevel;
        private bool? _metricsDisabled;
        private bool? _noTasks;
        private int? _queryConcurrency;
        private int? _queryQueueSize;
        private TracingType _tracingType;

        /// <summary>
        /// Gets and sets the property FluxLogEnabled. 
        /// <para>
        /// Include option to show detailed logs for Flux queries.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? FluxLogEnabled
        {
            get { return this._fluxLogEnabled; }
            set { this._fluxLogEnabled = value; }
        }

        // Check to see if FluxLogEnabled property is set
        internal bool IsSetFluxLogEnabled()
        {
            return this._fluxLogEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// Log output level. InfluxDB outputs log entries with severity levels greater than or
        /// equal to the level specified.
        /// </para>
        ///  
        /// <para>
        /// Default: info
        /// </para>
        /// </summary>
        public LogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsDisabled. 
        /// <para>
        /// Disable the HTTP /metrics endpoint which exposes <a href="https://docs.influxdata.com/influxdb/v2/reference/internals/metrics/">internal
        /// InfluxDB metrics</a>.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? MetricsDisabled
        {
            get { return this._metricsDisabled; }
            set { this._metricsDisabled = value; }
        }

        // Check to see if MetricsDisabled property is set
        internal bool IsSetMetricsDisabled()
        {
            return this._metricsDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoTasks. 
        /// <para>
        /// Disable the task scheduler. If problematic tasks prevent InfluxDB from starting, use
        /// this option to start InfluxDB without scheduling or executing tasks.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? NoTasks
        {
            get { return this._noTasks; }
            set { this._noTasks = value; }
        }

        // Check to see if NoTasks property is set
        internal bool IsSetNoTasks()
        {
            return this._noTasks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryConcurrency. 
        /// <para>
        /// Number of queries allowed to execute concurrently. Setting to 0 allows an unlimited
        /// number of concurrent queries.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public int? QueryConcurrency
        {
            get { return this._queryConcurrency; }
            set { this._queryConcurrency = value; }
        }

        // Check to see if QueryConcurrency property is set
        internal bool IsSetQueryConcurrency()
        {
            return this._queryConcurrency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryQueueSize. 
        /// <para>
        /// Maximum number of queries allowed in execution queue. When queue limit is reached,
        /// new queries are rejected. Setting to 0 allows an unlimited number of queries in the
        /// queue.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public int? QueryQueueSize
        {
            get { return this._queryQueueSize; }
            set { this._queryQueueSize = value; }
        }

        // Check to see if QueryQueueSize property is set
        internal bool IsSetQueryQueueSize()
        {
            return this._queryQueueSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TracingType. 
        /// <para>
        /// Enable tracing in InfluxDB and specifies the tracing type. Tracing is disabled by
        /// default.
        /// </para>
        /// </summary>
        public TracingType TracingType
        {
            get { return this._tracingType; }
            set { this._tracingType = value; }
        }

        // Check to see if TracingType property is set
        internal bool IsSetTracingType()
        {
            return this._tracingType != null;
        }

    }
}