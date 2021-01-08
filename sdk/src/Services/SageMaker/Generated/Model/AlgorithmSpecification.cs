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
    /// For more information about algorithms provided by Amazon SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
    /// For information about using your own algorithms, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html">Using
    /// Your Own Algorithms with Amazon SageMaker</a>. 
    /// </para>
    /// </summary>
    public partial class AlgorithmSpecification
    {
        private string _algorithmName;
        private bool? _enableSageMakerMetricsTimeSeries;
        private List<MetricDefinition> _metricDefinitions = new List<MetricDefinition>();
        private string _trainingImage;
        private TrainingInputMode _trainingInputMode;

        /// <summary>
        /// Gets and sets the property AlgorithmName. 
        /// <para>
        /// The name of the algorithm resource to use for the training job. This must be an algorithm
        /// resource that you created or subscribe to on AWS Marketplace. If you specify a value
        /// for this parameter, you can't specify a value for <code>TrainingImage</code>.
        /// </para>
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
        /// Gets and sets the property EnableSageMakerMetricsTimeSeries. 
        /// <para>
        /// To generate and save time-series metrics during training, set to <code>true</code>.
        /// The default is <code>false</code> and time-series metrics aren't generated except
        /// in the following cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You use one of the Amazon SageMaker built-in algorithms
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You use one of the following <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/pre-built-containers-frameworks-deep-learning.html">Prebuilt
        /// Amazon SageMaker Docker Images</a>:
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
        /// expressions used to parse algorithm logs. Amazon SageMaker publishes each metric to
        /// Amazon CloudWatch.
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
        /// about docker registry paths for built-in algorithms, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-algo-docker-registry-paths.html">Algorithms
        /// Provided by Amazon SageMaker: Common Parameters</a>. Amazon SageMaker supports both
        /// <code>registry/repository[:tag]</code> and <code>registry/repository[@digest]</code>
        /// image path formats. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html">Using
        /// Your Own Algorithms with Amazon SageMaker</a>.
        /// </para>
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
        /// Gets and sets the property TrainingInputMode. 
        /// <para>
        /// The input mode that the algorithm supports. For the input modes that Amazon SageMaker
        /// algorithms support, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
        /// If an algorithm supports the <code>File</code> input mode, Amazon SageMaker downloads
        /// the training data from S3 to the provisioned ML storage Volume, and mounts the directory
        /// to docker volume for training container. If an algorithm supports the <code>Pipe</code>
        /// input mode, Amazon SageMaker streams data directly from S3 to the container. 
        /// </para>
        ///  
        /// <para>
        ///  In File mode, make sure you provision ML storage volume with sufficient capacity
        /// to accommodate the data download from S3. In addition to the training data, the ML
        /// storage volume also stores the output model. The algorithm container use ML storage
        /// volume to also store intermediate information, if any. 
        /// </para>
        ///  
        /// <para>
        ///  For distributed algorithms using File mode, training data is distributed uniformly,
        /// and your training duration is predictable if the input data objects size is approximately
        /// same. Amazon SageMaker does not split the files any further for model training. If
        /// the object sizes are skewed, training won't be optimal as the data distribution is
        /// also skewed where one host in a training cluster is overloaded, thus becoming bottleneck
        /// in training. 
        /// </para>
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