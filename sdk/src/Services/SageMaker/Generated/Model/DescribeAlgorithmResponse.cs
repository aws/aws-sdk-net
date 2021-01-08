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
    /// This is the response object from the DescribeAlgorithm operation.
    /// </summary>
    public partial class DescribeAlgorithmResponse : AmazonWebServiceResponse
    {
        private string _algorithmArn;
        private string _algorithmDescription;
        private string _algorithmName;
        private AlgorithmStatus _algorithmStatus;
        private AlgorithmStatusDetails _algorithmStatusDetails;
        private bool? _certifyForMarketplace;
        private DateTime? _creationTime;
        private InferenceSpecification _inferenceSpecification;
        private string _productId;
        private TrainingSpecification _trainingSpecification;
        private AlgorithmValidationSpecification _validationSpecification;

        /// <summary>
        /// Gets and sets the property AlgorithmArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AlgorithmArn
        {
            get { return this._algorithmArn; }
            set { this._algorithmArn = value; }
        }

        // Check to see if AlgorithmArn property is set
        internal bool IsSetAlgorithmArn()
        {
            return this._algorithmArn != null;
        }

        /// <summary>
        /// Gets and sets the property AlgorithmDescription. 
        /// <para>
        /// A brief summary about the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// The name of the algorithm being described.
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
        /// Gets and sets the property AlgorithmStatus. 
        /// <para>
        /// The current status of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AlgorithmStatus AlgorithmStatus
        {
            get { return this._algorithmStatus; }
            set { this._algorithmStatus = value; }
        }

        // Check to see if AlgorithmStatus property is set
        internal bool IsSetAlgorithmStatus()
        {
            return this._algorithmStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AlgorithmStatusDetails. 
        /// <para>
        /// Details about the current status of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AlgorithmStatusDetails AlgorithmStatusDetails
        {
            get { return this._algorithmStatusDetails; }
            set { this._algorithmStatusDetails = value; }
        }

        // Check to see if AlgorithmStatusDetails property is set
        internal bool IsSetAlgorithmStatusDetails()
        {
            return this._algorithmStatusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property CertifyForMarketplace. 
        /// <para>
        /// Whether the algorithm is certified to be listed in AWS Marketplace.
        /// </para>
        /// </summary>
        public bool CertifyForMarketplace
        {
            get { return this._certifyForMarketplace.GetValueOrDefault(); }
            set { this._certifyForMarketplace = value; }
        }

        // Check to see if CertifyForMarketplace property is set
        internal bool IsSetCertifyForMarketplace()
        {
            return this._certifyForMarketplace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp specifying when the algorithm was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InferenceSpecification. 
        /// <para>
        /// Details about inference jobs that the algorithm runs.
        /// </para>
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
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingSpecification. 
        /// <para>
        /// Details about training jobs run by this algorithm.
        /// </para>
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
        /// Details about configurations for one or more training jobs that Amazon SageMaker runs
        /// to test the algorithm.
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