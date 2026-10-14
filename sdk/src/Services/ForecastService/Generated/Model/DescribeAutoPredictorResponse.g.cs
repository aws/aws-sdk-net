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
    /// This is the response object from the DescribeAutoPredictor operation.
    /// </summary>
    public partial class DescribeAutoPredictorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of the CreateAutoPredictor request.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataConfig. 
        /// <para>
        /// The data configuration for your dataset group and any additional datasets.
        /// </para>
        /// </summary>
        public DataConfig DataConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataConfig property is set.
        /// </summary>
        internal bool IsSetDataConfig() => this.DataConfig != null;

        /// <summary>
        /// Gets and sets the property DatasetImportJobArns. 
        /// <para>
        /// An array of the ARNs of the dataset import jobs used to import training data for the
        /// predictor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DatasetImportJobArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DatasetImportJobArns property is set.
        /// </summary>
        internal bool IsSetDatasetImportJobArns() => this.DatasetImportJobArns != null && (this.DatasetImportJobArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EncryptionConfig.
        /// </summary>
        public EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfig property is set.
        /// </summary>
        internal bool IsSetEncryptionConfig() => this.EncryptionConfig != null;

        /// <summary>
        /// Gets and sets the property EstimatedTimeRemainingInMinutes. 
        /// <para>
        /// The estimated time remaining in minutes for the predictor training job to complete.
        /// </para>
        /// </summary>
        public long? EstimatedTimeRemainingInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTimeRemainingInMinutes property is set.
        /// </summary>
        internal bool IsSetEstimatedTimeRemainingInMinutes() => this.EstimatedTimeRemainingInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property ExplainabilityInfo. 
        /// <para>
        /// Provides the status and ARN of the Predictor Explainability.
        /// </para>
        /// </summary>
        public ExplainabilityInfo ExplainabilityInfo { get; set; }

        /// <summary>
        /// Checks to see if the ExplainabilityInfo property is set.
        /// </summary>
        internal bool IsSetExplainabilityInfo() => this.ExplainabilityInfo != null;

        /// <summary>
        /// Gets and sets the property ForecastDimensions. 
        /// <para>
        /// An array of dimension (field) names that specify the attributes used to group your
        /// time series.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> ForecastDimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ForecastDimensions property is set.
        /// </summary>
        internal bool IsSetForecastDimensions() => this.ForecastDimensions != null && (this.ForecastDimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ForecastFrequency. 
        /// <para>
        /// The frequency of predictions in a forecast.
        /// </para>
        ///  
        /// <para>
        /// Valid intervals are Y (Year), M (Month), W (Week), D (Day), H (Hour), 30min (30 minutes),
        /// 15min (15 minutes), 10min (10 minutes), 5min (5 minutes), and 1min (1 minute). For
        /// example, "Y" indicates every year and "5min" indicates every five minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string ForecastFrequency { get; set; }

        /// <summary>
        /// Checks to see if the ForecastFrequency property is set.
        /// </summary>
        internal bool IsSetForecastFrequency() => this.ForecastFrequency != null;

        /// <summary>
        /// Gets and sets the property ForecastHorizon. 
        /// <para>
        /// The number of time-steps that the model predicts. The forecast horizon is also called
        /// the prediction length.
        /// </para>
        /// </summary>
        public int? ForecastHorizon { get; set; }

        /// <summary>
        /// Checks to see if the ForecastHorizon property is set.
        /// </summary>
        internal bool IsSetForecastHorizon() => this.ForecastHorizon.HasValue;

        /// <summary>
        /// Gets and sets the property ForecastTypes. 
        /// <para>
        /// The forecast types used during predictor training. Default value is ["0.1","0.5","0.9"].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> ForecastTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ForecastTypes property is set.
        /// </summary>
        internal bool IsSetForecastTypes() => this.ForecastTypes != null && (this.ForecastTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The last time the resource was modified. The timestamp depends on the status of the
        /// job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c> - The <c>CreationTime</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPED</c> - When the job stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> or <c>CREATE_FAILED</c> - When the job finished or failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationTime property is set.
        /// </summary>
        internal bool IsSetLastModificationTime() => this.LastModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// In the event of an error, a message detailing the cause of the error.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property MonitorInfo. 
        /// <para>
        /// A object with the Amazon Resource Name (ARN) and status of the monitor resource.
        /// </para>
        /// </summary>
        public MonitorInfo MonitorInfo { get; set; }

        /// <summary>
        /// Checks to see if the MonitorInfo property is set.
        /// </summary>
        internal bool IsSetMonitorInfo() => this.MonitorInfo != null;

        /// <summary>
        /// Gets and sets the property OptimizationMetric. 
        /// <para>
        /// The accuracy metric used to optimize the predictor.
        /// </para>
        /// </summary>
        public OptimizationMetric OptimizationMetric { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationMetric property is set.
        /// </summary>
        internal bool IsSetOptimizationMetric() => this.OptimizationMetric != null;

        /// <summary>
        /// Gets and sets the property PredictorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the predictor
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PredictorArn { get; set; }

        /// <summary>
        /// Checks to see if the PredictorArn property is set.
        /// </summary>
        internal bool IsSetPredictorArn() => this.PredictorArn != null;

        /// <summary>
        /// Gets and sets the property PredictorName. 
        /// <para>
        /// The name of the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string PredictorName { get; set; }

        /// <summary>
        /// Checks to see if the PredictorName property is set.
        /// </summary>
        internal bool IsSetPredictorName() => this.PredictorName != null;

        /// <summary>
        /// Gets and sets the property ReferencePredictorSummary. 
        /// <para>
        /// The ARN and state of the reference predictor. This parameter is only valid for retrained
        /// or upgraded predictors.
        /// </para>
        /// </summary>
        public ReferencePredictorSummary ReferencePredictorSummary { get; set; }

        /// <summary>
        /// Checks to see if the ReferencePredictorSummary property is set.
        /// </summary>
        internal bool IsSetReferencePredictorSummary() => this.ReferencePredictorSummary != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the predictor. States include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c>, <c>CREATE_IN_PROGRESS</c>, <c>CREATE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c>, <c>CREATE_STOPPED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_PENDING</c>, <c>DELETE_IN_PROGRESS</c>, <c>DELETE_FAILED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TimeAlignmentBoundary. 
        /// <para>
        /// The time boundary Forecast uses when aggregating data.
        /// </para>
        /// </summary>
        public TimeAlignmentBoundary TimeAlignmentBoundary { get; set; }

        /// <summary>
        /// Checks to see if the TimeAlignmentBoundary property is set.
        /// </summary>
        internal bool IsSetTimeAlignmentBoundary() => this.TimeAlignmentBoundary != null;
    }
}
