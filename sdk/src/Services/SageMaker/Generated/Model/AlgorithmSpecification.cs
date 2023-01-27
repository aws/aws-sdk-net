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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies the training algorithm to use in a <a>CreateTrainingJob</a> request.
    /// 
    ///  
    /// <para>
    /// For more information about algorithms provided by SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
    /// For information about using your own algorithms, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html">Using
    /// Your Own Algorithms with Amazon SageMaker</a>. 
    /// </para>
    /// </summary>
    public partial class AlgorithmSpecification
    {
        private string _algorithmName;
        private List<string> _containerArguments = new List<string>();
        private List<string> _containerEntrypoint = new List<string>();
        private bool? _enableSageMakerMetricsTimeSeries;
        private List<MetricDefinition> _metricDefinitions = new List<MetricDefinition>();
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
        /// You must specify either the algorithm name to the <code>AlgorithmName</code> parameter
        /// or the image URI of the algorithm container to the <code>TrainingImage</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// Note that the <code>AlgorithmName</code> parameter is mutually exclusive with the
        /// <code>TrainingImage</code> parameter. If you specify a value for the <code>AlgorithmName</code>
        /// parameter, you can't specify a value for <code>TrainingImage</code>, and vice versa.
        /// </para>
        ///  
        /// <para>
        /// If you specify values for both parameters, the training job might break; if you don't
        /// specify any value for both parameters, the training job might raise a <code>null</code>
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
            return this._containerArguments != null && this._containerArguments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContainerEntrypoint. 
        /// <para>
        /// The <a href="https://docs.docker.com/engine/reference/builder/">entrypoint script
        /// for a Docker container</a> used to run a training job. This script takes precedence
        /// over the default train processing instructions. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-training-algo-dockerfile.html">How
        /// Amazon SageMaker Runs Your Training Image</a> for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ContainerEntrypoint
        {
            get { return this._containerEntrypoint; }
            set { this._containerEntrypoint = value; }
        }

        // Check to see if ContainerEntrypoint property is set
        internal bool IsSetContainerEntrypoint()
        {
            return this._containerEntrypoint != null && this._containerEntrypoint.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableSageMakerMetricsTimeSeries. 
        /// <para>
        /// To generate and save time-series metrics during training, set to <code>true</code>.
        /// The default is <code>false</code> and time-series metrics aren't generated except
        /// in the following cases:
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
        /// You specify at least one <a>MetricDefinition</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool EnableSageMakerMetricsTimeSeries
        {
            get { return this._enableSageMakerMetricsTimeSeries.GetValueOrDefault(); }
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
            return this._metricDefinitions != null && this._metricDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrainingImage. 
        /// <para>
        /// The registry path of the Docker image that contains the training algorithm. For information
        /// about docker registry paths for SageMaker built-in algorithms, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-algo-docker-registry-paths.html">Docker
        /// Registry Paths and Example Code</a> in the <i>Amazon SageMaker developer guide</i>.
        /// SageMaker supports both <code>registry/repository[:tag]</code> and <code>registry/repository[@digest]</code>
        /// image path formats. For more information about using your custom training container,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html">Using
        /// Your Own Algorithms with Amazon SageMaker</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify either the algorithm name to the <code>AlgorithmName</code> parameter
        /// or the image URI of the algorithm container to the <code>TrainingImage</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the note in the <code>AlgorithmName</code> parameter description.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=255)]
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