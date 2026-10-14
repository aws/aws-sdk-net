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
    /// Specifies which training algorithm to use for training jobs that a hyperparameter
    /// tuning job launches and the metrics to monitor.
    /// </summary>
    public partial class HyperParameterAlgorithmSpecification
    {
        /// <summary>
        /// Gets and sets the property AlgorithmName. 
        /// <para>
        /// The name of the resource algorithm to use for the hyperparameter tuning job. If you
        /// specify a value for this parameter, do not specify a value for <c>TrainingImage</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 170)]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmName property is set.
        /// </summary>
        internal bool IsSetAlgorithmName() => this.AlgorithmName != null;

        /// <summary>
        /// Gets and sets the property MetricDefinitions. 
        /// <para>
        /// An array of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_MetricDefinition.html">MetricDefinition</a>
        /// objects that specify the metrics that the algorithm emits.
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
        /// Gets and sets the property TrainingImage. 
        /// <para>
        ///  The registry path of the Docker image that contains the training algorithm. For information
        /// about Docker registry paths for built-in algorithms, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-algo-docker-registry-paths.html">Algorithms
        /// Provided by Amazon SageMaker: Common Parameters</a>. SageMaker supports both <c>registry/repository[:tag]</c>
        /// and <c>registry/repository[@digest]</c> image path formats. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html">Using
        /// Your Own Algorithms with Amazon SageMaker</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string TrainingImage { get; set; }

        /// <summary>
        /// Checks to see if the TrainingImage property is set.
        /// </summary>
        internal bool IsSetTrainingImage() => this.TrainingImage != null;

        /// <summary>
        /// Gets and sets the property TrainingInputMode.
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainingInputMode TrainingInputMode { get; set; }

        /// <summary>
        /// Checks to see if the TrainingInputMode property is set.
        /// </summary>
        internal bool IsSetTrainingInputMode() => this.TrainingInputMode != null;
    }
}
