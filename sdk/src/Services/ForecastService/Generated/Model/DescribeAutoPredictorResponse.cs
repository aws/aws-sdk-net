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
    /// This is the response object from the DescribeAutoPredictor operation.
    /// </summary>
    public partial class DescribeAutoPredictorResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private DataConfig _dataConfig;
        private List<string> _datasetImportJobArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EncryptionConfig _encryptionConfig;
        private long? _estimatedTimeRemainingInMinutes;
        private ExplainabilityInfo _explainabilityInfo;
        private List<string> _forecastDimensions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _forecastFrequency;
        private int? _forecastHorizon;
        private List<string> _forecastTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastModificationTime;
        private string _message;
        private MonitorInfo _monitorInfo;
        private OptimizationMetric _optimizationMetric;
        private string _predictorArn;
        private string _predictorName;
        private ReferencePredictorSummary _referencePredictorSummary;
        private string _status;
        private TimeAlignmentBoundary _timeAlignmentBoundary;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of the CreateAutoPredictor request.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataConfig. 
        /// <para>
        /// The data configuration for your dataset group and any additional datasets.
        /// </para>
        /// </summary>
        public DataConfig DataConfig
        {
            get { return this._dataConfig; }
            set { this._dataConfig = value; }
        }

        // Check to see if DataConfig property is set
        internal bool IsSetDataConfig()
        {
            return this._dataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetImportJobArns. 
        /// <para>
        /// An array of the ARNs of the dataset import jobs used to import training data for the
        /// predictor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DatasetImportJobArns
        {
            get { return this._datasetImportJobArns; }
            set { this._datasetImportJobArns = value; }
        }

        // Check to see if DatasetImportJobArns property is set
        internal bool IsSetDatasetImportJobArns()
        {
            return this._datasetImportJobArns != null && (this._datasetImportJobArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfig.
        /// </summary>
        public EncryptionConfig EncryptionConfig
        {
            get { return this._encryptionConfig; }
            set { this._encryptionConfig = value; }
        }

        // Check to see if EncryptionConfig property is set
        internal bool IsSetEncryptionConfig()
        {
            return this._encryptionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedTimeRemainingInMinutes. 
        /// <para>
        /// The estimated time remaining in minutes for the predictor training job to complete.
        /// </para>
        /// </summary>
        public long? EstimatedTimeRemainingInMinutes
        {
            get { return this._estimatedTimeRemainingInMinutes; }
            set { this._estimatedTimeRemainingInMinutes = value; }
        }

        // Check to see if EstimatedTimeRemainingInMinutes property is set
        internal bool IsSetEstimatedTimeRemainingInMinutes()
        {
            return this._estimatedTimeRemainingInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExplainabilityInfo. 
        /// <para>
        /// Provides the status and ARN of the Predictor Explainability.
        /// </para>
        /// </summary>
        public ExplainabilityInfo ExplainabilityInfo
        {
            get { return this._explainabilityInfo; }
            set { this._explainabilityInfo = value; }
        }

        // Check to see if ExplainabilityInfo property is set
        internal bool IsSetExplainabilityInfo()
        {
            return this._explainabilityInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastDimensions. 
        /// <para>
        /// An array of dimension (field) names that specify the attributes used to group your
        /// time series.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ForecastDimensions
        {
            get { return this._forecastDimensions; }
            set { this._forecastDimensions = value; }
        }

        // Check to see if ForecastDimensions property is set
        internal bool IsSetForecastDimensions()
        {
            return this._forecastDimensions != null && (this._forecastDimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=1, Max=5)]
        public string ForecastFrequency
        {
            get { return this._forecastFrequency; }
            set { this._forecastFrequency = value; }
        }

        // Check to see if ForecastFrequency property is set
        internal bool IsSetForecastFrequency()
        {
            return this._forecastFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastHorizon. 
        /// <para>
        /// The number of time-steps that the model predicts. The forecast horizon is also called
        /// the prediction length.
        /// </para>
        /// </summary>
        public int? ForecastHorizon
        {
            get { return this._forecastHorizon; }
            set { this._forecastHorizon = value; }
        }

        // Check to see if ForecastHorizon property is set
        internal bool IsSetForecastHorizon()
        {
            return this._forecastHorizon.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForecastTypes. 
        /// <para>
        /// The forecast types used during predictor training. Default value is ["0.1","0.5","0.9"].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> ForecastTypes
        {
            get { return this._forecastTypes; }
            set { this._forecastTypes = value; }
        }

        // Check to see if ForecastTypes property is set
        internal bool IsSetForecastTypes()
        {
            return this._forecastTypes != null && (this._forecastTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public DateTime? LastModificationTime
        {
            get { return this._lastModificationTime; }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// In the event of an error, a message detailing the cause of the error.
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
        /// Gets and sets the property MonitorInfo. 
        /// <para>
        /// A object with the Amazon Resource Name (ARN) and status of the monitor resource.
        /// </para>
        /// </summary>
        public MonitorInfo MonitorInfo
        {
            get { return this._monitorInfo; }
            set { this._monitorInfo = value; }
        }

        // Check to see if MonitorInfo property is set
        internal bool IsSetMonitorInfo()
        {
            return this._monitorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationMetric. 
        /// <para>
        /// The accuracy metric used to optimize the predictor.
        /// </para>
        /// </summary>
        public OptimizationMetric OptimizationMetric
        {
            get { return this._optimizationMetric; }
            set { this._optimizationMetric = value; }
        }

        // Check to see if OptimizationMetric property is set
        internal bool IsSetOptimizationMetric()
        {
            return this._optimizationMetric != null;
        }

        /// <summary>
        /// Gets and sets the property PredictorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the predictor
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string PredictorArn
        {
            get { return this._predictorArn; }
            set { this._predictorArn = value; }
        }

        // Check to see if PredictorArn property is set
        internal bool IsSetPredictorArn()
        {
            return this._predictorArn != null;
        }

        /// <summary>
        /// Gets and sets the property PredictorName. 
        /// <para>
        /// The name of the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string PredictorName
        {
            get { return this._predictorName; }
            set { this._predictorName = value; }
        }

        // Check to see if PredictorName property is set
        internal bool IsSetPredictorName()
        {
            return this._predictorName != null;
        }

        /// <summary>
        /// Gets and sets the property ReferencePredictorSummary. 
        /// <para>
        /// The ARN and state of the reference predictor. This parameter is only valid for retrained
        /// or upgraded predictors.
        /// </para>
        /// </summary>
        public ReferencePredictorSummary ReferencePredictorSummary
        {
            get { return this._referencePredictorSummary; }
            set { this._referencePredictorSummary = value; }
        }

        // Check to see if ReferencePredictorSummary property is set
        internal bool IsSetReferencePredictorSummary()
        {
            return this._referencePredictorSummary != null;
        }

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
        [AWSProperty(Max=256)]
        public string Status
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
        /// Gets and sets the property TimeAlignmentBoundary. 
        /// <para>
        /// The time boundary Forecast uses when aggregating data.
        /// </para>
        /// </summary>
        public TimeAlignmentBoundary TimeAlignmentBoundary
        {
            get { return this._timeAlignmentBoundary; }
            set { this._timeAlignmentBoundary = value; }
        }

        // Check to see if TimeAlignmentBoundary property is set
        internal bool IsSetTimeAlignmentBoundary()
        {
            return this._timeAlignmentBoundary != null;
        }

    }
}