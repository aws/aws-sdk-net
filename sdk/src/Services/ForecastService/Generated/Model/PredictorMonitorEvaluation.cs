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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Describes the results of a monitor evaluation.
    /// </summary>
    public partial class PredictorMonitorEvaluation
    {
        private string _evaluationState;
        private DateTime? _evaluationTime;
        private string _message;
        private List<MetricResult> _metricResults = AWSConfigs.InitializeCollections ? new List<MetricResult>() : null;
        private string _monitorArn;
        private MonitorDataSource _monitorDataSource;
        private long? _numItemsEvaluated;
        private PredictorEvent _predictorEvent;
        private string _resourceArn;
        private DateTime? _windowEndDatetime;
        private DateTime? _windowStartDatetime;

        /// <summary>
        /// Gets and sets the property EvaluationState. 
        /// <para>
        /// The status of the monitor evaluation. The state can be <c>SUCCESS</c> or <c>FAILURE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string EvaluationState
        {
            get { return this._evaluationState; }
            set { this._evaluationState = value; }
        }

        // Check to see if EvaluationState property is set
        internal bool IsSetEvaluationState()
        {
            return this._evaluationState != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationTime. 
        /// <para>
        /// The timestamp that indicates when the monitor evaluation was started. 
        /// </para>
        /// </summary>
        public DateTime? EvaluationTime
        {
            get { return this._evaluationTime; }
            set { this._evaluationTime = value; }
        }

        // Check to see if EvaluationTime property is set
        internal bool IsSetEvaluationTime()
        {
            return this._evaluationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Information about any errors that may have occurred during the monitor evaluation.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property MetricResults. 
        /// <para>
        /// A list of metrics Forecast calculated when monitoring a predictor. You can compare
        /// the value for each metric in the list to the metric's value in the <a>Baseline</a>
        /// to see how your predictor's performance is changing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricResult> MetricResults
        {
            get { return this._metricResults; }
            set { this._metricResults = value; }
        }

        // Check to see if MetricResults property is set
        internal bool IsSetMetricResults()
        {
            return this._metricResults != null && (this._metricResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitor resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MonitorArn
        {
            get { return this._monitorArn; }
            set { this._monitorArn = value; }
        }

        // Check to see if MonitorArn property is set
        internal bool IsSetMonitorArn()
        {
            return this._monitorArn != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorDataSource. 
        /// <para>
        /// The source of the data the monitor resource used during the evaluation.
        /// </para>
        /// </summary>
        public MonitorDataSource MonitorDataSource
        {
            get { return this._monitorDataSource; }
            set { this._monitorDataSource = value; }
        }

        // Check to see if MonitorDataSource property is set
        internal bool IsSetMonitorDataSource()
        {
            return this._monitorDataSource != null;
        }

        /// <summary>
        /// Gets and sets the property NumItemsEvaluated. 
        /// <para>
        /// The number of items considered during the evaluation.
        /// </para>
        /// </summary>
        public long? NumItemsEvaluated
        {
            get { return this._numItemsEvaluated; }
            set { this._numItemsEvaluated = value; }
        }

        // Check to see if NumItemsEvaluated property is set
        internal bool IsSetNumItemsEvaluated()
        {
            return this._numItemsEvaluated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredictorEvent. 
        /// <para>
        /// Provides details about a predictor event, such as a retraining.
        /// </para>
        /// </summary>
        public PredictorEvent PredictorEvent
        {
            get { return this._predictorEvent; }
            set { this._predictorEvent = value; }
        }

        // Check to see if PredictorEvent property is set
        internal bool IsSetPredictorEvent()
        {
            return this._predictorEvent != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource to monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property WindowEndDatetime. 
        /// <para>
        /// The timestamp that indicates the end of the window that is used for monitor evaluation.
        /// </para>
        /// </summary>
        public DateTime? WindowEndDatetime
        {
            get { return this._windowEndDatetime; }
            set { this._windowEndDatetime = value; }
        }

        // Check to see if WindowEndDatetime property is set
        internal bool IsSetWindowEndDatetime()
        {
            return this._windowEndDatetime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WindowStartDatetime. 
        /// <para>
        /// The timestamp that indicates the start of the window that is used for monitor evaluation.
        /// </para>
        /// </summary>
        public DateTime? WindowStartDatetime
        {
            get { return this._windowStartDatetime; }
            set { this._windowStartDatetime = value; }
        }

        // Check to see if WindowStartDatetime property is set
        internal bool IsSetWindowStartDatetime()
        {
            return this._windowStartDatetime.HasValue; 
        }

    }
}