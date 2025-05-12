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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Input object for the batch transform job.
    /// </summary>
    public partial class BatchTransformInput
    {
        private string _dataCapturedDestinationS3Uri;
        private MonitoringDatasetFormat _datasetFormat;
        private string _endTimeOffset;
        private string _excludeFeaturesAttribute;
        private string _featuresAttribute;
        private string _inferenceAttribute;
        private string _localPath;
        private string _probabilityAttribute;
        private double? _probabilityThresholdAttribute;
        private ProcessingS3DataDistributionType _s3DataDistributionType;
        private ProcessingS3InputMode _s3InputMode;
        private string _startTimeOffset;

        /// <summary>
        /// Gets and sets the property DataCapturedDestinationS3Uri. 
        /// <para>
        /// The Amazon S3 location being used to capture the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=512)]
        public string DataCapturedDestinationS3Uri
        {
            get { return this._dataCapturedDestinationS3Uri; }
            set { this._dataCapturedDestinationS3Uri = value; }
        }

        // Check to see if DataCapturedDestinationS3Uri property is set
        internal bool IsSetDataCapturedDestinationS3Uri()
        {
            return this._dataCapturedDestinationS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetFormat. 
        /// <para>
        /// The dataset format for your batch transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitoringDatasetFormat DatasetFormat
        {
            get { return this._datasetFormat; }
            set { this._datasetFormat = value; }
        }

        // Check to see if DatasetFormat property is set
        internal bool IsSetDatasetFormat()
        {
            return this._datasetFormat != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimeOffset. 
        /// <para>
        /// If specified, monitoring jobs subtract this time from the end time. For information
        /// about using offsets for scheduling monitoring jobs, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor-model-quality-schedule.html">Schedule
        /// Model Quality Monitoring Jobs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public string EndTimeOffset
        {
            get { return this._endTimeOffset; }
            set { this._endTimeOffset = value; }
        }

        // Check to see if EndTimeOffset property is set
        internal bool IsSetEndTimeOffset()
        {
            return this._endTimeOffset != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludeFeaturesAttribute. 
        /// <para>
        /// The attributes of the input data to exclude from the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string ExcludeFeaturesAttribute
        {
            get { return this._excludeFeaturesAttribute; }
            set { this._excludeFeaturesAttribute = value; }
        }

        // Check to see if ExcludeFeaturesAttribute property is set
        internal bool IsSetExcludeFeaturesAttribute()
        {
            return this._excludeFeaturesAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property FeaturesAttribute. 
        /// <para>
        /// The attributes of the input data that are the input features.
        /// </para>
        /// </summary>
        public string FeaturesAttribute
        {
            get { return this._featuresAttribute; }
            set { this._featuresAttribute = value; }
        }

        // Check to see if FeaturesAttribute property is set
        internal bool IsSetFeaturesAttribute()
        {
            return this._featuresAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceAttribute. 
        /// <para>
        /// The attribute of the input data that represents the ground truth label.
        /// </para>
        /// </summary>
        public string InferenceAttribute
        {
            get { return this._inferenceAttribute; }
            set { this._inferenceAttribute = value; }
        }

        // Check to see if InferenceAttribute property is set
        internal bool IsSetInferenceAttribute()
        {
            return this._inferenceAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property LocalPath. 
        /// <para>
        /// Path to the filesystem where the batch transform data is available to the container.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string LocalPath
        {
            get { return this._localPath; }
            set { this._localPath = value; }
        }

        // Check to see if LocalPath property is set
        internal bool IsSetLocalPath()
        {
            return this._localPath != null;
        }

        /// <summary>
        /// Gets and sets the property ProbabilityAttribute. 
        /// <para>
        /// In a classification problem, the attribute that represents the class probability.
        /// </para>
        /// </summary>
        public string ProbabilityAttribute
        {
            get { return this._probabilityAttribute; }
            set { this._probabilityAttribute = value; }
        }

        // Check to see if ProbabilityAttribute property is set
        internal bool IsSetProbabilityAttribute()
        {
            return this._probabilityAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property ProbabilityThresholdAttribute. 
        /// <para>
        /// The threshold for the class probability to be evaluated as a positive result.
        /// </para>
        /// </summary>
        public double? ProbabilityThresholdAttribute
        {
            get { return this._probabilityThresholdAttribute; }
            set { this._probabilityThresholdAttribute = value; }
        }

        // Check to see if ProbabilityThresholdAttribute property is set
        internal bool IsSetProbabilityThresholdAttribute()
        {
            return this._probabilityThresholdAttribute.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3DataDistributionType. 
        /// <para>
        /// Whether input data distributed in Amazon S3 is fully replicated or sharded by an S3
        /// key. Defaults to <c>FullyReplicated</c> 
        /// </para>
        /// </summary>
        public ProcessingS3DataDistributionType S3DataDistributionType
        {
            get { return this._s3DataDistributionType; }
            set { this._s3DataDistributionType = value; }
        }

        // Check to see if S3DataDistributionType property is set
        internal bool IsSetS3DataDistributionType()
        {
            return this._s3DataDistributionType != null;
        }

        /// <summary>
        /// Gets and sets the property S3InputMode. 
        /// <para>
        /// Whether the <c>Pipe</c> or <c>File</c> is used as the input mode for transferring
        /// data for the monitoring job. <c>Pipe</c> mode is recommended for large datasets. <c>File</c>
        /// mode is useful for small files that fit in memory. Defaults to <c>File</c>.
        /// </para>
        /// </summary>
        public ProcessingS3InputMode S3InputMode
        {
            get { return this._s3InputMode; }
            set { this._s3InputMode = value; }
        }

        // Check to see if S3InputMode property is set
        internal bool IsSetS3InputMode()
        {
            return this._s3InputMode != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimeOffset. 
        /// <para>
        /// If specified, monitoring jobs substract this time from the start time. For information
        /// about using offsets for scheduling monitoring jobs, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor-model-quality-schedule.html">Schedule
        /// Model Quality Monitoring Jobs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public string StartTimeOffset
        {
            get { return this._startTimeOffset; }
            set { this._startTimeOffset = value; }
        }

        // Check to see if StartTimeOffset property is set
        internal bool IsSetStartTimeOffset()
        {
            return this._startTimeOffset != null;
        }

    }
}