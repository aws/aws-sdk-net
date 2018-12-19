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
    /// This is the response object from the DescribeModelPackage operation.
    /// </summary>
    public partial class DescribeModelPackageResponse : AmazonWebServiceResponse
    {
        private bool? _certifyForMarketplace;
        private DateTime? _creationTime;
        private InferenceSpecification _inferenceSpecification;
        private string _modelPackageArn;
        private string _modelPackageDescription;
        private string _modelPackageName;
        private ModelPackageStatus _modelPackageStatus;
        private ModelPackageStatusDetails _modelPackageStatusDetails;
        private SourceAlgorithmSpecification _sourceAlgorithmSpecification;
        private ModelPackageValidationSpecification _validationSpecification;

        /// <summary>
        /// Gets and sets the property CertifyForMarketplace. 
        /// <para>
        /// Whether the model package is certified for listing on AWS Marketplace.
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
        /// A timestamp specifying when the model package was created.
        /// </para>
        /// </summary>
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
        /// Details about inference jobs that can be run with models based on this model package.
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
        /// Gets and sets the property ModelPackageArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model package.
        /// </para>
        /// </summary>
        public string ModelPackageArn
        {
            get { return this._modelPackageArn; }
            set { this._modelPackageArn = value; }
        }

        // Check to see if ModelPackageArn property is set
        internal bool IsSetModelPackageArn()
        {
            return this._modelPackageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageDescription. 
        /// <para>
        /// A brief summary of the model package.
        /// </para>
        /// </summary>
        public string ModelPackageDescription
        {
            get { return this._modelPackageDescription; }
            set { this._modelPackageDescription = value; }
        }

        // Check to see if ModelPackageDescription property is set
        internal bool IsSetModelPackageDescription()
        {
            return this._modelPackageDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageName. 
        /// <para>
        /// The name of the model package being described.
        /// </para>
        /// </summary>
        public string ModelPackageName
        {
            get { return this._modelPackageName; }
            set { this._modelPackageName = value; }
        }

        // Check to see if ModelPackageName property is set
        internal bool IsSetModelPackageName()
        {
            return this._modelPackageName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageStatus. 
        /// <para>
        /// The current status of the model package.
        /// </para>
        /// </summary>
        public ModelPackageStatus ModelPackageStatus
        {
            get { return this._modelPackageStatus; }
            set { this._modelPackageStatus = value; }
        }

        // Check to see if ModelPackageStatus property is set
        internal bool IsSetModelPackageStatus()
        {
            return this._modelPackageStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageStatusDetails. 
        /// <para>
        /// Details about the current status of the model package.
        /// </para>
        /// </summary>
        public ModelPackageStatusDetails ModelPackageStatusDetails
        {
            get { return this._modelPackageStatusDetails; }
            set { this._modelPackageStatusDetails = value; }
        }

        // Check to see if ModelPackageStatusDetails property is set
        internal bool IsSetModelPackageStatusDetails()
        {
            return this._modelPackageStatusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAlgorithmSpecification. 
        /// <para>
        /// Details about the algorithm that was used to create the model package.
        /// </para>
        /// </summary>
        public SourceAlgorithmSpecification SourceAlgorithmSpecification
        {
            get { return this._sourceAlgorithmSpecification; }
            set { this._sourceAlgorithmSpecification = value; }
        }

        // Check to see if SourceAlgorithmSpecification property is set
        internal bool IsSetSourceAlgorithmSpecification()
        {
            return this._sourceAlgorithmSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationSpecification. 
        /// <para>
        /// Configurations for one or more transform jobs that Amazon SageMaker runs to test the
        /// model package.
        /// </para>
        /// </summary>
        public ModelPackageValidationSpecification ValidationSpecification
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