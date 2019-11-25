/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Describes an anomaly or error with the application.
    /// </summary>
    public partial class Observation
    {
        private DateTime? _endTime;
        private string _id;
        private DateTime? _lineTime;
        private LogFilter _logFilter;
        private string _logGroup;
        private string _logText;
        private string _metricName;
        private string _metricNamespace;
        private string _sourceARN;
        private string _sourceType;
        private DateTime? _startTime;
        private string _unit;
        private double? _value;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the observation ended, in epoch seconds.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the observation type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=38, Max=38)]
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
        /// Gets and sets the property LineTime. 
        /// <para>
        /// The timestamp in the CloudWatch Logs that specifies when the matched line occurred.
        /// </para>
        /// </summary>
        public DateTime LineTime
        {
            get { return this._lineTime.GetValueOrDefault(); }
            set { this._lineTime = value; }
        }

        // Check to see if LineTime property is set
        internal bool IsSetLineTime()
        {
            return this._lineTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogFilter. 
        /// <para>
        /// The log filter of the observation.
        /// </para>
        /// </summary>
        public LogFilter LogFilter
        {
            get { return this._logFilter; }
            set { this._logFilter = value; }
        }

        // Check to see if LogFilter property is set
        internal bool IsSetLogFilter()
        {
            return this._logFilter != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroup. 
        /// <para>
        /// The log group name.
        /// </para>
        /// </summary>
        public string LogGroup
        {
            get { return this._logGroup; }
            set { this._logGroup = value; }
        }

        // Check to see if LogGroup property is set
        internal bool IsSetLogGroup()
        {
            return this._logGroup != null;
        }

        /// <summary>
        /// Gets and sets the property LogText. 
        /// <para>
        /// The log text of the observation.
        /// </para>
        /// </summary>
        public string LogText
        {
            get { return this._logText; }
            set { this._logText = value; }
        }

        // Check to see if LogText property is set
        internal bool IsSetLogText()
        {
            return this._logText != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the observation metric.
        /// </para>
        /// </summary>
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricNamespace. 
        /// <para>
        /// The namespace of the observation metric.
        /// </para>
        /// </summary>
        public string MetricNamespace
        {
            get { return this._metricNamespace; }
            set { this._metricNamespace = value; }
        }

        // Check to see if MetricNamespace property is set
        internal bool IsSetMetricNamespace()
        {
            return this._metricNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property SourceARN. 
        /// <para>
        /// The source resource ARN of the observation.
        /// </para>
        /// </summary>
        public string SourceARN
        {
            get { return this._sourceARN; }
            set { this._sourceARN = value; }
        }

        // Check to see if SourceARN property is set
        internal bool IsSetSourceARN()
        {
            return this._sourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type of the observation.
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the observation was first detected, in epoch seconds.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of the source observation metric.
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the source observation metric.
        /// </para>
        /// </summary>
        public double Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}