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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Describes a fulfillment option for a product. Each element contains exactly one fulfillment
    /// option type.
    /// </summary>
    public partial class FulfillmentOption
    {
        /// <summary>
        /// Gets and sets the property AmazonMachineImageFulfillmentOption. 
        /// <para>
        /// An Amazon Machine Image (AMI) fulfillment option for EC2 deployment.
        /// </para>
        /// </summary>
        public AmazonMachineImageFulfillmentOption AmazonMachineImageFulfillmentOption { get; set; }

        /// <summary>
        /// Checks to see if the AmazonMachineImageFulfillmentOption property is set.
        /// </summary>
        internal bool IsSetAmazonMachineImageFulfillmentOption() => this.AmazonMachineImageFulfillmentOption != null;

        /// <summary>
        /// Gets and sets the property ApiFulfillmentOption. 
        /// <para>
        /// An API-based fulfillment option for programmatic integration.
        /// </para>
        /// </summary>
        public ApiFulfillmentOption ApiFulfillmentOption { get; set; }

        /// <summary>
        /// Checks to see if the ApiFulfillmentOption property is set.
        /// </summary>
        internal bool IsSetApiFulfillmentOption() => this.ApiFulfillmentOption != null;

        /// <summary>
        /// Gets and sets the property CloudFormationFulfillmentOption. 
        /// <para>
        /// An AWS CloudFormation template fulfillment option for infrastructure deployment.
        /// </para>
        /// </summary>
        public CloudFormationFulfillmentOption CloudFormationFulfillmentOption { get; set; }

        /// <summary>
        /// Checks to see if the CloudFormationFulfillmentOption property is set.
        /// </summary>
        internal bool IsSetCloudFormationFulfillmentOption() => this.CloudFormationFulfillmentOption != null;

        /// <summary>
        /// Gets and sets the property ContainerFulfillmentOption. 
        /// <para>
        /// A container image fulfillment option for container-based deployment.
        /// </para>
        /// </summary>
        public ContainerFulfillmentOption ContainerFulfillmentOption { get; set; }

        /// <summary>
        /// Checks to see if the ContainerFulfillmentOption property is set.
        /// </summary>
        internal bool IsSetContainerFulfillmentOption() => this.ContainerFulfillmentOption != null;

        /// <summary>
        /// Gets and sets the property DataExchangeFulfillmentOption. 
        /// <para>
        /// An AWS Data Exchange fulfillment option for data set delivery.
        /// </para>
        /// </summary>
        public DataExchangeFulfillmentOption DataExchangeFulfillmentOption { get; set; }

        /// <summary>
        /// Checks to see if the DataExchangeFulfillmentOption property is set.
        /// </summary>
        internal bool IsSetDataExchangeFulfillmentOption() => this.DataExchangeFulfillmentOption != null;

        /// <summary>
        /// Gets and sets the property Ec2ImageBuilderComponentFulfillmentOption. 
        /// <para>
        /// An EC2 Image Builder component fulfillment option.
        /// </para>
        /// </summary>
        public Ec2ImageBuilderComponentFulfillmentOption Ec2ImageBuilderComponentFulfillmentOption { get; set; }

        /// <summary>
        /// Checks to see if the Ec2ImageBuilderComponentFulfillmentOption property is set.
        /// </summary>
        internal bool IsSetEc2ImageBuilderComponentFulfillmentOption() => this.Ec2ImageBuilderComponentFulfillmentOption != null;

        /// <summary>
        /// Gets and sets the property EksAddOnFulfillmentOption. 
        /// <para>
        /// An Amazon EKS add-on fulfillment option.
        /// </para>
        /// </summary>
        public EksAddOnFulfillmentOption EksAddOnFulfillmentOption { get; set; }

        /// <summary>
        /// Checks to see if the EksAddOnFulfillmentOption property is set.
        /// </summary>
        internal bool IsSetEksAddOnFulfillmentOption() => this.EksAddOnFulfillmentOption != null;

        /// <summary>
        /// Gets and sets the property HelmFulfillmentOption. 
        /// <para>
        /// A Helm chart fulfillment option for Kubernetes deployment.
        /// </para>
        /// </summary>
        public HelmFulfillmentOption HelmFulfillmentOption { get; set; }

        /// <summary>
        /// Checks to see if the HelmFulfillmentOption property is set.
        /// </summary>
        internal bool IsSetHelmFulfillmentOption() => this.HelmFulfillmentOption != null;

        /// <summary>
        /// Gets and sets the property ProfessionalServicesFulfillmentOption. 
        /// <para>
        /// A professional services fulfillment option.
        /// </para>
        /// </summary>
        public ProfessionalServicesFulfillmentOption ProfessionalServicesFulfillmentOption { get; set; }

        /// <summary>
        /// Checks to see if the ProfessionalServicesFulfillmentOption property is set.
        /// </summary>
        internal bool IsSetProfessionalServicesFulfillmentOption() => this.ProfessionalServicesFulfillmentOption != null;

        /// <summary>
        /// Gets and sets the property SaasFulfillmentOption. 
        /// <para>
        /// A Software as a Service (SaaS) fulfillment option.
        /// </para>
        /// </summary>
        public SaasFulfillmentOption SaasFulfillmentOption { get; set; }

        /// <summary>
        /// Checks to see if the SaasFulfillmentOption property is set.
        /// </summary>
        internal bool IsSetSaasFulfillmentOption() => this.SaasFulfillmentOption != null;

        /// <summary>
        /// Gets and sets the property SageMakerAlgorithmFulfillmentOption. 
        /// <para>
        /// An Amazon SageMaker algorithm fulfillment option.
        /// </para>
        /// </summary>
        public SageMakerAlgorithmFulfillmentOption SageMakerAlgorithmFulfillmentOption { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerAlgorithmFulfillmentOption property is set.
        /// </summary>
        internal bool IsSetSageMakerAlgorithmFulfillmentOption() => this.SageMakerAlgorithmFulfillmentOption != null;

        /// <summary>
        /// Gets and sets the property SageMakerModelFulfillmentOption. 
        /// <para>
        /// An Amazon SageMaker model fulfillment option.
        /// </para>
        /// </summary>
        public SageMakerModelFulfillmentOption SageMakerModelFulfillmentOption { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerModelFulfillmentOption property is set.
        /// </summary>
        internal bool IsSetSageMakerModelFulfillmentOption() => this.SageMakerModelFulfillmentOption != null;
    }
}
