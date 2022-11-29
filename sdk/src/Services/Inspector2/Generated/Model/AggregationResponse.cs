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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A structure that contains details about the results of an aggregation type.
    /// </summary>
    public partial class AggregationResponse
    {
        private AccountAggregationResponse _accountAggregation;
        private AmiAggregationResponse _amiAggregation;
        private AwsEcrContainerAggregationResponse _awsEcrContainerAggregation;
        private Ec2InstanceAggregationResponse _ec2InstanceAggregation;
        private FindingTypeAggregationResponse _findingTypeAggregation;
        private ImageLayerAggregationResponse _imageLayerAggregation;
        private LambdaFunctionAggregationResponse _lambdaFunctionAggregation;
        private LambdaLayerAggregationResponse _lambdaLayerAggregation;
        private PackageAggregationResponse _packageAggregation;
        private RepositoryAggregationResponse _repositoryAggregation;
        private TitleAggregationResponse _titleAggregation;

        /// <summary>
        /// Gets and sets the property AccountAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on Amazon Web
        /// Services account IDs.
        /// </para>
        /// </summary>
        public AccountAggregationResponse AccountAggregation
        {
            get { return this._accountAggregation; }
            set { this._accountAggregation = value; }
        }

        // Check to see if AccountAggregation property is set
        internal bool IsSetAccountAggregation()
        {
            return this._accountAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property AmiAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on Amazon Machine
        /// Images (AMIs).
        /// </para>
        /// </summary>
        public AmiAggregationResponse AmiAggregation
        {
            get { return this._amiAggregation; }
            set { this._amiAggregation = value; }
        }

        // Check to see if AmiAggregation property is set
        internal bool IsSetAmiAggregation()
        {
            return this._amiAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEcrContainerAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on Amazon ECR
        /// container images.
        /// </para>
        /// </summary>
        public AwsEcrContainerAggregationResponse AwsEcrContainerAggregation
        {
            get { return this._awsEcrContainerAggregation; }
            set { this._awsEcrContainerAggregation = value; }
        }

        // Check to see if AwsEcrContainerAggregation property is set
        internal bool IsSetAwsEcrContainerAggregation()
        {
            return this._awsEcrContainerAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on Amazon EC2
        /// instances.
        /// </para>
        /// </summary>
        public Ec2InstanceAggregationResponse Ec2InstanceAggregation
        {
            get { return this._ec2InstanceAggregation; }
            set { this._ec2InstanceAggregation = value; }
        }

        // Check to see if Ec2InstanceAggregation property is set
        internal bool IsSetEc2InstanceAggregation()
        {
            return this._ec2InstanceAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property FindingTypeAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on finding types.
        /// </para>
        /// </summary>
        public FindingTypeAggregationResponse FindingTypeAggregation
        {
            get { return this._findingTypeAggregation; }
            set { this._findingTypeAggregation = value; }
        }

        // Check to see if FindingTypeAggregation property is set
        internal bool IsSetFindingTypeAggregation()
        {
            return this._findingTypeAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property ImageLayerAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on container image
        /// layers.
        /// </para>
        /// </summary>
        public ImageLayerAggregationResponse ImageLayerAggregation
        {
            get { return this._imageLayerAggregation; }
            set { this._imageLayerAggregation = value; }
        }

        // Check to see if ImageLayerAggregation property is set
        internal bool IsSetImageLayerAggregation()
        {
            return this._imageLayerAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionAggregation. 
        /// <para>
        /// An aggregation of findings by AWS Lambda function.
        /// </para>
        /// </summary>
        public LambdaFunctionAggregationResponse LambdaFunctionAggregation
        {
            get { return this._lambdaFunctionAggregation; }
            set { this._lambdaFunctionAggregation = value; }
        }

        // Check to see if LambdaFunctionAggregation property is set
        internal bool IsSetLambdaFunctionAggregation()
        {
            return this._lambdaFunctionAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaLayerAggregation. 
        /// <para>
        /// An aggregation of findings by AWS Lambda layer.
        /// </para>
        /// </summary>
        public LambdaLayerAggregationResponse LambdaLayerAggregation
        {
            get { return this._lambdaLayerAggregation; }
            set { this._lambdaLayerAggregation = value; }
        }

        // Check to see if LambdaLayerAggregation property is set
        internal bool IsSetLambdaLayerAggregation()
        {
            return this._lambdaLayerAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property PackageAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on operating system
        /// package type.
        /// </para>
        /// </summary>
        public PackageAggregationResponse PackageAggregation
        {
            get { return this._packageAggregation; }
            set { this._packageAggregation = value; }
        }

        // Check to see if PackageAggregation property is set
        internal bool IsSetPackageAggregation()
        {
            return this._packageAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on Amazon ECR
        /// repositories.
        /// </para>
        /// </summary>
        public RepositoryAggregationResponse RepositoryAggregation
        {
            get { return this._repositoryAggregation; }
            set { this._repositoryAggregation = value; }
        }

        // Check to see if RepositoryAggregation property is set
        internal bool IsSetRepositoryAggregation()
        {
            return this._repositoryAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property TitleAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on finding title.
        /// </para>
        /// </summary>
        public TitleAggregationResponse TitleAggregation
        {
            get { return this._titleAggregation; }
            set { this._titleAggregation = value; }
        }

        // Check to see if TitleAggregation property is set
        internal bool IsSetTitleAggregation()
        {
            return this._titleAggregation != null;
        }

    }
}