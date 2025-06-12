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
    /// Defines how the algorithm is used for a training job.
    /// </summary>
    public partial class TrainingSpecification
    {
        private AdditionalS3DataSource _additionalS3DataSource;
        private List<MetricDefinition> _metricDefinitions = AWSConfigs.InitializeCollections ? new List<MetricDefinition>() : null;
        private List<HyperParameterSpecification> _supportedHyperParameters = AWSConfigs.InitializeCollections ? new List<HyperParameterSpecification>() : null;
        private List<string> _supportedTrainingInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<HyperParameterTuningJobObjective> _supportedTuningJobObjectiveMetrics = AWSConfigs.InitializeCollections ? new List<HyperParameterTuningJobObjective>() : null;
        private bool? _supportsDistributedTraining;
        private List<ChannelSpecification> _trainingChannels = AWSConfigs.InitializeCollections ? new List<ChannelSpecification>() : null;
        private string _trainingImage;
        private string _trainingImageDigest;

        /// <summary>
        /// Gets and sets the property AdditionalS3DataSource. 
        /// <para>
        /// The additional data source used during the training job.
        /// </para>
        /// </summary>
        public AdditionalS3DataSource AdditionalS3DataSource
        {
            get { return this._additionalS3DataSource; }
            set { this._additionalS3DataSource = value; }
        }

        // Check to see if AdditionalS3DataSource property is set
        internal bool IsSetAdditionalS3DataSource()
        {
            return this._additionalS3DataSource != null;
        }

        /// <summary>
        /// Gets and sets the property MetricDefinitions. 
        /// <para>
        /// A list of <c>MetricDefinition</c> objects, which are used for parsing metrics generated
        /// by the algorithm.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public List<MetricDefinition> MetricDefinitions
        {
            get { return this._metricDefinitions; }
            set { this._metricDefinitions = value; }
        }

        // Check to see if MetricDefinitions property is set
        internal bool IsSetMetricDefinitions()
        {
            return this._metricDefinitions != null && (this._metricDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedHyperParameters. 
        /// <para>
        /// A list of the <c>HyperParameterSpecification</c> objects, that define the supported
        /// hyperparameters. This is required if the algorithm supports automatic model tuning.&gt;
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<HyperParameterSpecification> SupportedHyperParameters
        {
            get { return this._supportedHyperParameters; }
            set { this._supportedHyperParameters = value; }
        }

        // Check to see if SupportedHyperParameters property is set
        internal bool IsSetSupportedHyperParameters()
        {
            return this._supportedHyperParameters != null && (this._supportedHyperParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedTrainingInstanceTypes. 
        /// <para>
        /// A list of the instance types that this algorithm can use for training.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SupportedTrainingInstanceTypes
        {
            get { return this._supportedTrainingInstanceTypes; }
            set { this._supportedTrainingInstanceTypes = value; }
        }

        // Check to see if SupportedTrainingInstanceTypes property is set
        internal bool IsSetSupportedTrainingInstanceTypes()
        {
            return this._supportedTrainingInstanceTypes != null && (this._supportedTrainingInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedTuningJobObjectiveMetrics. 
        /// <para>
        /// A list of the metrics that the algorithm emits that can be used as the objective metric
        /// in a hyperparameter tuning job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HyperParameterTuningJobObjective> SupportedTuningJobObjectiveMetrics
        {
            get { return this._supportedTuningJobObjectiveMetrics; }
            set { this._supportedTuningJobObjectiveMetrics = value; }
        }

        // Check to see if SupportedTuningJobObjectiveMetrics property is set
        internal bool IsSetSupportedTuningJobObjectiveMetrics()
        {
            return this._supportedTuningJobObjectiveMetrics != null && (this._supportedTuningJobObjectiveMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportsDistributedTraining. 
        /// <para>
        /// Indicates whether the algorithm supports distributed training. If set to false, buyers
        /// can't request more than one instance during training.
        /// </para>
        /// </summary>
        public bool? SupportsDistributedTraining
        {
            get { return this._supportsDistributedTraining; }
            set { this._supportsDistributedTraining = value; }
        }

        // Check to see if SupportsDistributedTraining property is set
        internal bool IsSetSupportsDistributedTraining()
        {
            return this._supportsDistributedTraining.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingChannels. 
        /// <para>
        /// A list of <c>ChannelSpecification</c> objects, which specify the input sources to
        /// be used by the algorithm.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8)]
        public List<ChannelSpecification> TrainingChannels
        {
            get { return this._trainingChannels; }
            set { this._trainingChannels = value; }
        }

        // Check to see if TrainingChannels property is set
        internal bool IsSetTrainingChannels()
        {
            return this._trainingChannels != null && (this._trainingChannels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrainingImage. 
        /// <para>
        /// The Amazon ECR registry path of the Docker image that contains the training algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string TrainingImage
        {
            get { return this._trainingImage; }
            set { this._trainingImage = value; }
        }

        // Check to see if TrainingImage property is set
        internal bool IsSetTrainingImage()
        {
            return this._trainingImage != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingImageDigest. 
        /// <para>
        /// An MD5 hash of the training algorithm that identifies the Docker image used for training.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=72)]
        public string TrainingImageDigest
        {
            get { return this._trainingImageDigest; }
            set { this._trainingImageDigest = value; }
        }

        // Check to see if TrainingImageDigest property is set
        internal bool IsSetTrainingImageDigest()
        {
            return this._trainingImageDigest != null;
        }

    }
}