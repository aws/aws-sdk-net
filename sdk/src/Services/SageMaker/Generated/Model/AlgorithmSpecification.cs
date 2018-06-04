/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies the training algorithm to use in a <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateTrainingJob.html">CreateTrainingJob</a>
    /// request.
    /// 
    ///  
    /// <para>
    /// For more information about algorithms provided by Amazon SageMaker, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
    /// For information about using your own algorithms, see <a>your-algorithms</a>. 
    /// </para>
    /// </summary>
    public partial class AlgorithmSpecification
    {
        private string _trainingImage;
        private TrainingInputMode _trainingInputMode;

        /// <summary>
        /// Gets and sets the property TrainingImage. 
        /// <para>
        /// The registry path of the Docker image that contains the training algorithm. For information
        /// about docker registry paths for built-in algorithms, see <a>sagemaker-algo-docker-registry-paths</a>.
        /// </para>
        /// </summary>
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
        /// algorithms support, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
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