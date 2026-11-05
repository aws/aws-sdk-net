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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A structure that contains details about the results of an aggregation type.
    /// </summary>
    public partial class AggregationResponse
    {
        /// <summary>
        /// Gets and sets the property AccountAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on Amazon Web
        /// Services account IDs.
        /// </para>
        /// </summary>
        public AccountAggregationResponse AccountAggregation { get; set; }

        /// <summary>
        /// Checks to see if the AccountAggregation property is set.
        /// </summary>
        internal bool IsSetAccountAggregation() => this.AccountAggregation != null;

        /// <summary>
        /// Gets and sets the property AmiAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on Amazon Machine
        /// Images (AMIs).
        /// </para>
        /// </summary>
        public AmiAggregationResponse AmiAggregation { get; set; }

        /// <summary>
        /// Checks to see if the AmiAggregation property is set.
        /// </summary>
        internal bool IsSetAmiAggregation() => this.AmiAggregation != null;

        /// <summary>
        /// Gets and sets the property AwsEcrContainerAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on Amazon ECR
        /// container images.
        /// </para>
        /// </summary>
        public AwsEcrContainerAggregationResponse AwsEcrContainerAggregation { get; set; }

        /// <summary>
        /// Checks to see if the AwsEcrContainerAggregation property is set.
        /// </summary>
        internal bool IsSetAwsEcrContainerAggregation() => this.AwsEcrContainerAggregation != null;

        /// <summary>
        /// Gets and sets the property CodeRepositoryAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on code repositories.
        /// </para>
        /// </summary>
        public CodeRepositoryAggregationResponse CodeRepositoryAggregation { get; set; }

        /// <summary>
        /// Checks to see if the CodeRepositoryAggregation property is set.
        /// </summary>
        internal bool IsSetCodeRepositoryAggregation() => this.CodeRepositoryAggregation != null;

        /// <summary>
        /// Gets and sets the property ContainerImageAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on container images.
        /// </para>
        /// </summary>
        public ContainerImageAggregationResponse ContainerImageAggregation { get; set; }

        /// <summary>
        /// Checks to see if the ContainerImageAggregation property is set.
        /// </summary>
        internal bool IsSetContainerImageAggregation() => this.ContainerImageAggregation != null;

        /// <summary>
        /// Gets and sets the property Ec2InstanceAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on Amazon EC2
        /// instances.
        /// </para>
        /// </summary>
        public Ec2InstanceAggregationResponse Ec2InstanceAggregation { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceAggregation property is set.
        /// </summary>
        internal bool IsSetEc2InstanceAggregation() => this.Ec2InstanceAggregation != null;

        /// <summary>
        /// Gets and sets the property FindingTypeAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on finding types.
        /// </para>
        /// </summary>
        public FindingTypeAggregationResponse FindingTypeAggregation { get; set; }

        /// <summary>
        /// Checks to see if the FindingTypeAggregation property is set.
        /// </summary>
        internal bool IsSetFindingTypeAggregation() => this.FindingTypeAggregation != null;

        /// <summary>
        /// Gets and sets the property ImageLayerAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on container image
        /// layers.
        /// </para>
        /// </summary>
        public ImageLayerAggregationResponse ImageLayerAggregation { get; set; }

        /// <summary>
        /// Checks to see if the ImageLayerAggregation property is set.
        /// </summary>
        internal bool IsSetImageLayerAggregation() => this.ImageLayerAggregation != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionAggregation. 
        /// <para>
        /// An aggregation of findings by Amazon Web Services Lambda function.
        /// </para>
        /// </summary>
        public LambdaFunctionAggregationResponse LambdaFunctionAggregation { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionAggregation property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionAggregation() => this.LambdaFunctionAggregation != null;

        /// <summary>
        /// Gets and sets the property LambdaLayerAggregation. 
        /// <para>
        /// An aggregation of findings by Amazon Web Services Lambda layer.
        /// </para>
        /// </summary>
        public LambdaLayerAggregationResponse LambdaLayerAggregation { get; set; }

        /// <summary>
        /// Checks to see if the LambdaLayerAggregation property is set.
        /// </summary>
        internal bool IsSetLambdaLayerAggregation() => this.LambdaLayerAggregation != null;

        /// <summary>
        /// Gets and sets the property PackageAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on operating system
        /// package type.
        /// </para>
        /// </summary>
        public PackageAggregationResponse PackageAggregation { get; set; }

        /// <summary>
        /// Checks to see if the PackageAggregation property is set.
        /// </summary>
        internal bool IsSetPackageAggregation() => this.PackageAggregation != null;

        /// <summary>
        /// Gets and sets the property RepositoryAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on Amazon ECR
        /// repositories.
        /// </para>
        /// </summary>
        public RepositoryAggregationResponse RepositoryAggregation { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryAggregation property is set.
        /// </summary>
        internal bool IsSetRepositoryAggregation() => this.RepositoryAggregation != null;

        /// <summary>
        /// Gets and sets the property ServerlessFunctionAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on serverless
        /// functions.
        /// </para>
        /// </summary>
        public ServerlessFunctionAggregationResponse ServerlessFunctionAggregation { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessFunctionAggregation property is set.
        /// </summary>
        internal bool IsSetServerlessFunctionAggregation() => this.ServerlessFunctionAggregation != null;

        /// <summary>
        /// Gets and sets the property TitleAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on finding title.
        /// </para>
        /// </summary>
        public TitleAggregationResponse TitleAggregation { get; set; }

        /// <summary>
        /// Checks to see if the TitleAggregation property is set.
        /// </summary>
        internal bool IsSetTitleAggregation() => this.TitleAggregation != null;

        /// <summary>
        /// Gets and sets the property VmInstanceAggregation. 
        /// <para>
        /// An object that contains details about an aggregation response based on VM instances.
        /// </para>
        /// </summary>
        public VmInstanceAggregationResponse VmInstanceAggregation { get; set; }

        /// <summary>
        /// Checks to see if the VmInstanceAggregation property is set.
        /// </summary>
        internal bool IsSetVmInstanceAggregation() => this.VmInstanceAggregation != null;
    }
}
