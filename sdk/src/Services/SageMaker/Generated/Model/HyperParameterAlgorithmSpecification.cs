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
    /// Specifies which training algorithm to use for training jobs that a hyperparameter
    /// tuning job launches and the metrics to monitor.
    /// </summary>
    public partial class HyperParameterAlgorithmSpecification
    {
        private string _algorithmName;
        private List<MetricDefinition> _metricDefinitions = new List<MetricDefinition>();
        private string _trainingImage;
        private TrainingInputMode _trainingInputMode;

        /// <summary>
        /// Gets and sets the property AlgorithmName. 
        /// <para>
        /// The name of the resource algorithm to use for the hyperparameter tuning job. If you
        /// specify a value for this parameter, do not specify a value for <code>TrainingImage</code>.
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
        /// Gets and sets the property MetricDefinitions. 
        /// <para>
        /// An array of <a>MetricDefinition</a> objects that specify the metrics that the algorithm
        /// emits.
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
        ///  The registry path of the Docker image that contains the training algorithm. For information
        /// about Docker registry paths for built-in algorithms, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-algo-docker-registry-paths.html">Algorithms
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
        /// The input mode that the algorithm supports: File or Pipe. In File input mode, Amazon
        /// SageMaker downloads the training data from Amazon S3 to the storage volume that is
        /// attached to the training instance and mounts the directory to the Docker volume for
        /// the training container. In Pipe input mode, Amazon SageMaker streams data directly
        /// from Amazon S3 to the container. 
        /// </para>
        ///  
        /// <para>
        /// If you specify File mode, make sure that you provision the storage volume that is
        /// attached to the training instance with enough capacity to accommodate the training
        /// data downloaded from Amazon S3, the model artifacts, and intermediate information.
        /// </para>
        ///   
        /// <para>
        /// For more information about input modes, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
        /// 
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