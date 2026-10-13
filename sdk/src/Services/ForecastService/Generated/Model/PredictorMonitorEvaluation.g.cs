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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Describes the results of a monitor evaluation.
    /// </summary>
    public partial class PredictorMonitorEvaluation
    {
        /// <summary>
        /// Gets and sets the property EvaluationState. 
        /// <para>
        /// The status of the monitor evaluation. The state can be <c>SUCCESS</c> or <c>FAILURE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EvaluationState { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationState property is set.
        /// </summary>
        internal bool IsSetEvaluationState() => this.EvaluationState != null;

        /// <summary>
        /// Gets and sets the property EvaluationTime. 
        /// <para>
        /// The timestamp that indicates when the monitor evaluation was started. 
        /// </para>
        /// </summary>
        public DateTime? EvaluationTime { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationTime property is set.
        /// </summary>
        internal bool IsSetEvaluationTime() => this.EvaluationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Information about any errors that may have occurred during the monitor evaluation.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property MetricResults. 
        /// <para>
        /// A list of metrics Forecast calculated when monitoring a predictor. You can compare
        /// the value for each metric in the list to the metric's value in the <a>Baseline</a>
        /// to see how your predictor's performance is changing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricResult> MetricResults { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricResult>() : null;

        /// <summary>
        /// Checks to see if the MetricResults property is set.
        /// </summary>
        internal bool IsSetMetricResults() => this.MetricResults != null && (this.MetricResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitor resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string MonitorArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitorArn property is set.
        /// </summary>
        internal bool IsSetMonitorArn() => this.MonitorArn != null;

        /// <summary>
        /// Gets and sets the property MonitorDataSource. 
        /// <para>
        /// The source of the data the monitor resource used during the evaluation.
        /// </para>
        /// </summary>
        public MonitorDataSource MonitorDataSource { get; set; }

        /// <summary>
        /// Checks to see if the MonitorDataSource property is set.
        /// </summary>
        internal bool IsSetMonitorDataSource() => this.MonitorDataSource != null;

        /// <summary>
        /// Gets and sets the property NumItemsEvaluated. 
        /// <para>
        /// The number of items considered during the evaluation.
        /// </para>
        /// </summary>
        public long? NumItemsEvaluated { get; set; }

        /// <summary>
        /// Checks to see if the NumItemsEvaluated property is set.
        /// </summary>
        internal bool IsSetNumItemsEvaluated() => this.NumItemsEvaluated.HasValue;

        /// <summary>
        /// Gets and sets the property PredictorEvent. 
        /// <para>
        /// Provides details about a predictor event, such as a retraining.
        /// </para>
        /// </summary>
        public PredictorEvent PredictorEvent { get; set; }

        /// <summary>
        /// Checks to see if the PredictorEvent property is set.
        /// </summary>
        internal bool IsSetPredictorEvent() => this.PredictorEvent != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource to monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property WindowEndDatetime. 
        /// <para>
        /// The timestamp that indicates the end of the window that is used for monitor evaluation.
        /// </para>
        /// </summary>
        public DateTime? WindowEndDatetime { get; set; }

        /// <summary>
        /// Checks to see if the WindowEndDatetime property is set.
        /// </summary>
        internal bool IsSetWindowEndDatetime() => this.WindowEndDatetime.HasValue;

        /// <summary>
        /// Gets and sets the property WindowStartDatetime. 
        /// <para>
        /// The timestamp that indicates the start of the window that is used for monitor evaluation.
        /// </para>
        /// </summary>
        public DateTime? WindowStartDatetime { get; set; }

        /// <summary>
        /// Checks to see if the WindowStartDatetime property is set.
        /// </summary>
        internal bool IsSetWindowStartDatetime() => this.WindowStartDatetime.HasValue;
    }
}
