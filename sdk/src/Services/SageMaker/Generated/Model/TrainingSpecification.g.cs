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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Defines how the algorithm is used for a training job.
    /// </summary>
    public partial class TrainingSpecification
    {
        /// <summary>
        /// Gets and sets the property AdditionalS3DataSource. 
        /// <para>
        /// The additional data source used during the training job.
        /// </para>
        /// </summary>
        public AdditionalS3DataSource AdditionalS3DataSource { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalS3DataSource property is set.
        /// </summary>
        internal bool IsSetAdditionalS3DataSource() => this.AdditionalS3DataSource != null;

        /// <summary>
        /// Gets and sets the property MetricDefinitions. 
        /// <para>
        /// A list of <c>MetricDefinition</c> objects, which are used for parsing metrics generated
        /// by the algorithm.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 40)]
        public List<MetricDefinition> MetricDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricDefinition>() : null;

        /// <summary>
        /// Checks to see if the MetricDefinitions property is set.
        /// </summary>
        internal bool IsSetMetricDefinitions() => this.MetricDefinitions != null && (this.MetricDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedHyperParameters. 
        /// <para>
        /// A list of the <c>HyperParameterSpecification</c> objects, that define the supported
        /// hyperparameters. This is required if the algorithm supports automatic model tuning.&gt;
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<HyperParameterSpecification> SupportedHyperParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<HyperParameterSpecification>() : null;

        /// <summary>
        /// Checks to see if the SupportedHyperParameters property is set.
        /// </summary>
        internal bool IsSetSupportedHyperParameters() => this.SupportedHyperParameters != null && (this.SupportedHyperParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedTrainingInstanceTypes. 
        /// <para>
        /// A list of the instance types that this algorithm can use for training.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> SupportedTrainingInstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedTrainingInstanceTypes property is set.
        /// </summary>
        internal bool IsSetSupportedTrainingInstanceTypes() => this.SupportedTrainingInstanceTypes != null && (this.SupportedTrainingInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedTuningJobObjectiveMetrics. 
        /// <para>
        /// A list of the metrics that the algorithm emits that can be used as the objective metric
        /// in a hyperparameter tuning job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HyperParameterTuningJobObjective> SupportedTuningJobObjectiveMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<HyperParameterTuningJobObjective>() : null;

        /// <summary>
        /// Checks to see if the SupportedTuningJobObjectiveMetrics property is set.
        /// </summary>
        internal bool IsSetSupportedTuningJobObjectiveMetrics() => this.SupportedTuningJobObjectiveMetrics != null && (this.SupportedTuningJobObjectiveMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportsDistributedTraining. 
        /// <para>
        /// Indicates whether the algorithm supports distributed training. If set to false, buyers
        /// can't request more than one instance during training.
        /// </para>
        /// </summary>
        public bool? SupportsDistributedTraining { get; set; }

        /// <summary>
        /// Checks to see if the SupportsDistributedTraining property is set.
        /// </summary>
        internal bool IsSetSupportsDistributedTraining() => this.SupportsDistributedTraining.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingChannels. 
        /// <para>
        /// A list of <c>ChannelSpecification</c> objects, which specify the input sources to
        /// be used by the algorithm.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8)]
        public List<ChannelSpecification> TrainingChannels { get; set; } = AWSConfigs.InitializeCollections ? new List<ChannelSpecification>() : null;

        /// <summary>
        /// Checks to see if the TrainingChannels property is set.
        /// </summary>
        internal bool IsSetTrainingChannels() => this.TrainingChannels != null && (this.TrainingChannels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrainingImage. 
        /// <para>
        /// The Amazon ECR registry path of the Docker image that contains the training algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string TrainingImage { get; set; }

        /// <summary>
        /// Checks to see if the TrainingImage property is set.
        /// </summary>
        internal bool IsSetTrainingImage() => this.TrainingImage != null;

        /// <summary>
        /// Gets and sets the property TrainingImageDigest. 
        /// <para>
        /// An MD5 hash of the training algorithm that identifies the Docker image used for training.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 72)]
        public string TrainingImageDigest { get; set; }

        /// <summary>
        /// Checks to see if the TrainingImageDigest property is set.
        /// </summary>
        internal bool IsSetTrainingImageDigest() => this.TrainingImageDigest != null;
    }
}
