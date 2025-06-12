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
    /// Container for the parameters to the CreateAlgorithm operation.
    /// Create a machine learning algorithm that you can use in SageMaker and list in the
    /// Amazon Web Services Marketplace.
    /// </summary>
    public partial class CreateAlgorithmRequest : AmazonSageMakerRequest
    {
        private string _algorithmDescription;
        private string _algorithmName;
        private bool? _certifyForMarketplace;
        private InferenceSpecification _inferenceSpecification;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TrainingSpecification _trainingSpecification;
        private AlgorithmValidationSpecification _validationSpecification;

        /// <summary>
        /// Gets and sets the property AlgorithmDescription. 
        /// <para>
        /// A description of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AlgorithmDescription
        {
            get { return this._algorithmDescription; }
            set { this._algorithmDescription = value; }
        }

        // Check to see if AlgorithmDescription property is set
        internal bool IsSetAlgorithmDescription()
        {
            return this._algorithmDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AlgorithmName. 
        /// <para>
        /// The name of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property CertifyForMarketplace. 
        /// <para>
        /// Whether to certify the algorithm so that it can be listed in Amazon Web Services Marketplace.
        /// </para>
        /// </summary>
        public bool? CertifyForMarketplace
        {
            get { return this._certifyForMarketplace; }
            set { this._certifyForMarketplace = value; }
        }

        // Check to see if CertifyForMarketplace property is set
        internal bool IsSetCertifyForMarketplace()
        {
            return this._certifyForMarketplace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InferenceSpecification. 
        /// <para>
        /// Specifies details about inference jobs that the algorithm runs, including the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Amazon ECR paths of containers that contain the inference code and model artifacts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The instance types that the algorithm supports for transform jobs and real-time endpoints
        /// used for inference.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The input and output content formats that the algorithm supports for inference.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InferenceSpecification InferenceSpecification
        {
            get { return this._inferenceSpecification; }
            set { this._inferenceSpecification = value; }
        }

        // Check to see if InferenceSpecification property is set
        internal bool IsSetInferenceSpecification()
        {
            return this._inferenceSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrainingSpecification. 
        /// <para>
        /// Specifies details about training jobs run by this algorithm, including the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Amazon ECR path of the container and the version digest of the algorithm.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The hyperparameters that the algorithm supports.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The instance types that the algorithm supports for training.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether the algorithm supports distributed training.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The metrics that the algorithm emits to Amazon CloudWatch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Which metrics that the algorithm emits can be used as the objective metric for hyperparameter
        /// tuning jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The input channels that the algorithm supports for training data. For example, an
        /// algorithm might support <c>train</c>, <c>validation</c>, and <c>test</c> channels.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingSpecification TrainingSpecification
        {
            get { return this._trainingSpecification; }
            set { this._trainingSpecification = value; }
        }

        // Check to see if TrainingSpecification property is set
        internal bool IsSetTrainingSpecification()
        {
            return this._trainingSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationSpecification. 
        /// <para>
        /// Specifies configurations for one or more training jobs and that SageMaker runs to
        /// test the algorithm's training code and, optionally, one or more batch transform jobs
        /// that SageMaker runs to test the algorithm's inference code.
        /// </para>
        /// </summary>
        public AlgorithmValidationSpecification ValidationSpecification
        {
            get { return this._validationSpecification; }
            set { this._validationSpecification = value; }
        }

        // Check to see if ValidationSpecification property is set
        internal bool IsSetValidationSpecification()
        {
            return this._validationSpecification != null;
        }

    }
}