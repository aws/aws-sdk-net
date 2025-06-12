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
    /// Specifies the training algorithm to use in a <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html">CreateTrainingJob</a>
    /// request.
    /// 
    ///  <important> 
    /// <para>
    /// SageMaker uses its own SageMaker account credentials to pull and access built-in algorithms
    /// so built-in algorithms are universally accessible across all Amazon Web Services accounts.
    /// As a result, built-in algorithms have standard, unrestricted access. You cannot restrict
    /// built-in algorithms using IAM roles. Use custom algorithms if you require specific
    /// access controls.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about algorithms provided by SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
    /// For information about using your own algorithms, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html">Using
    /// Your Own Algorithms with Amazon SageMaker</a>. 
    /// </para>
    /// </summary>
    public partial class AlgorithmSpecification
    {
        private string _algorithmName;
        private List<string> _containerArguments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _containerEntrypoint = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _enableSageMakerMetricsTimeSeries;
        private List<MetricDefinition> _metricDefinitions = AWSConfigs.InitializeCollections ? new List<MetricDefinition>() : null;
        private string _trainingImage;
        private TrainingImageConfig _trainingImageConfig;
        private TrainingInputMode _trainingInputMode;

        /// <summary>
        /// Gets and sets the property AlgorithmName. 
        /// <para>
        /// The name of the algorithm resource to use for the training job. This must be an algorithm
        /// resource that you created or subscribe to on Amazon Web Services Marketplace.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify either the algorithm name to the <c>AlgorithmName</c> parameter or
        /// the image URI of the algorithm container to the <c>TrainingImage</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Note that the <c>AlgorithmName</c> parameter is mutually exclusive with the <c>TrainingImage</c>
        /// parameter. If you specify a value for the <c>AlgorithmName</c> parameter, you can't
        /// specify a value for <c>TrainingImage</c>, and vice versa.
        /// </para>
        ///  
        /// <para>
        /// If you specify values for both parameters, the training job might break; if you don't
        /// specify any value for both parameters, the training job might raise a <c>null</c>
        /// error.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=170)]
        public string AlgorithmName
        {
            get { return this._algorithmName; }
            set { this._algorithmName = value; }
        }

        // Check to see if AlgorithmName property is set
        internal bool IsSetAlgorithmName()
        {
            return this._algorithmName != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerArguments. 
        /// <para>
        /// The arguments for a container used to run a training job. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-training-algo-dockerfile.html">How
        /// Amazon SageMaker Runs Your Training Image</a> for additional information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ContainerArguments
        {
            get { return this._containerArguments; }
            set { this._containerArguments = value; }
        }

        // Check to see if ContainerArguments property is set
        internal bool IsSetContainerArguments()
        {
            return this._containerArguments != null && (this._containerArguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContainerEntrypoint. 
        /// <para>
        /// The <a href="https://docs.docker.com/engine/reference/builder/">entrypoint script
        /// for a Docker container</a> used to run a training job. This script takes precedence
        /// over the default train processing instructions. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-training-algo-dockerfile.html">How
        /// Amazon SageMaker Runs Your Training Image</a> for more information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ContainerEntrypoint
        {
            get { return this._containerEntrypoint; }
            set { this._containerEntrypoint = value; }
        }

        // Check to see if ContainerEntrypoint property is set
        internal bool IsSetContainerEntrypoint()
        {
            return this._containerEntrypoint != null && (this._containerEntrypoint.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnableSageMakerMetricsTimeSeries. 
        /// <para>
        /// To generate and save time-series metrics during training, set to <c>true</c>. The
        /// default is <c>false</c> and time-series metrics aren't generated except in the following
        /// cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You use one of the SageMaker built-in algorithms
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You use one of the following <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/pre-built-containers-frameworks-deep-learning.html">Prebuilt
        /// SageMaker Docker Images</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Tensorflow (version &gt;= 1.15)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MXNet (version &gt;= 1.6)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PyTorch (version &gt;= 1.3)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// You specify at least one <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_MetricDefinition.html">MetricDefinition</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? EnableSageMakerMetricsTimeSeries
        {
            get { return this._enableSageMakerMetricsTimeSeries; }
            set { this._enableSageMakerMetricsTimeSeries = value; }
        }

        // Check to see if EnableSageMakerMetricsTimeSeries property is set
        internal bool IsSetEnableSageMakerMetricsTimeSeries()
        {
            return this._enableSageMakerMetricsTimeSeries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricDefinitions. 
        /// <para>
        /// A list of metric definition objects. Each object specifies the metric name and regular
        /// expressions used to parse algorithm logs. SageMaker publishes each metric to Amazon
        /// CloudWatch.
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
        /// Gets and sets the property TrainingImage. 
        /// <para>
        /// The registry path of the Docker image that contains the training algorithm. For information
        /// about docker registry paths for SageMaker built-in algorithms, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-algo-docker-registry-paths.html">Docker
        /// Registry Paths and Example Code</a> in the <i>Amazon SageMaker developer guide</i>.
        /// SageMaker supports both <c>registry/repository[:tag]</c> and <c>registry/repository[@digest]</c>
        /// image path formats. For more information about using your custom training container,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html">Using
        /// Your Own Algorithms with Amazon SageMaker</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify either the algorithm name to the <c>AlgorithmName</c> parameter or
        /// the image URI of the algorithm container to the <c>TrainingImage</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the note in the <c>AlgorithmName</c> parameter description.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property TrainingImageConfig. 
        /// <para>
        /// The configuration to use an image from a private Docker registry for a training job.
        /// </para>
        /// </summary>
        public TrainingImageConfig TrainingImageConfig
        {
            get { return this._trainingImageConfig; }
            set { this._trainingImageConfig = value; }
        }

        // Check to see if TrainingImageConfig property is set
        internal bool IsSetTrainingImageConfig()
        {
            return this._trainingImageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingInputMode.
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingInputMode TrainingInputMode
        {
            get { return this._trainingInputMode; }
            set { this._trainingInputMode = value; }
        }

        // Check to see if TrainingInputMode property is set
        internal bool IsSetTrainingInputMode()
        {
            return this._trainingInputMode != null;
        }

    }
}