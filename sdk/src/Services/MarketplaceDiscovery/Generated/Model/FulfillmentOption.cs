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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
        private AmazonMachineImageFulfillmentOption _amazonMachineImageFulfillmentOption;
        private ApiFulfillmentOption _apiFulfillmentOption;
        private CloudFormationFulfillmentOption _cloudFormationFulfillmentOption;
        private ContainerFulfillmentOption _containerFulfillmentOption;
        private DataExchangeFulfillmentOption _dataExchangeFulfillmentOption;
        private Ec2ImageBuilderComponentFulfillmentOption _ec2ImageBuilderComponentFulfillmentOption;
        private EksAddOnFulfillmentOption _eksAddOnFulfillmentOption;
        private HelmFulfillmentOption _helmFulfillmentOption;
        private ProfessionalServicesFulfillmentOption _professionalServicesFulfillmentOption;
        private SaasFulfillmentOption _saasFulfillmentOption;
        private SageMakerAlgorithmFulfillmentOption _sageMakerAlgorithmFulfillmentOption;
        private SageMakerModelFulfillmentOption _sageMakerModelFulfillmentOption;

        /// <summary>
        /// Gets and sets the property AmazonMachineImageFulfillmentOption. 
        /// <para>
        /// An Amazon Machine Image (AMI) fulfillment option for EC2 deployment.
        /// </para>
        /// </summary>
        public AmazonMachineImageFulfillmentOption AmazonMachineImageFulfillmentOption
        {
            get { return this._amazonMachineImageFulfillmentOption; }
            set { this._amazonMachineImageFulfillmentOption = value; }
        }

        // Check to see if AmazonMachineImageFulfillmentOption property is set
        internal bool IsSetAmazonMachineImageFulfillmentOption()
        {
            return this._amazonMachineImageFulfillmentOption != null;
        }

        /// <summary>
        /// Gets and sets the property ApiFulfillmentOption. 
        /// <para>
        /// An API-based fulfillment option for programmatic integration.
        /// </para>
        /// </summary>
        public ApiFulfillmentOption ApiFulfillmentOption
        {
            get { return this._apiFulfillmentOption; }
            set { this._apiFulfillmentOption = value; }
        }

        // Check to see if ApiFulfillmentOption property is set
        internal bool IsSetApiFulfillmentOption()
        {
            return this._apiFulfillmentOption != null;
        }

        /// <summary>
        /// Gets and sets the property CloudFormationFulfillmentOption. 
        /// <para>
        /// An AWS CloudFormation template fulfillment option for infrastructure deployment.
        /// </para>
        /// </summary>
        public CloudFormationFulfillmentOption CloudFormationFulfillmentOption
        {
            get { return this._cloudFormationFulfillmentOption; }
            set { this._cloudFormationFulfillmentOption = value; }
        }

        // Check to see if CloudFormationFulfillmentOption property is set
        internal bool IsSetCloudFormationFulfillmentOption()
        {
            return this._cloudFormationFulfillmentOption != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerFulfillmentOption. 
        /// <para>
        /// A container image fulfillment option for container-based deployment.
        /// </para>
        /// </summary>
        public ContainerFulfillmentOption ContainerFulfillmentOption
        {
            get { return this._containerFulfillmentOption; }
            set { this._containerFulfillmentOption = value; }
        }

        // Check to see if ContainerFulfillmentOption property is set
        internal bool IsSetContainerFulfillmentOption()
        {
            return this._containerFulfillmentOption != null;
        }

        /// <summary>
        /// Gets and sets the property DataExchangeFulfillmentOption. 
        /// <para>
        /// An AWS Data Exchange fulfillment option for data set delivery.
        /// </para>
        /// </summary>
        public DataExchangeFulfillmentOption DataExchangeFulfillmentOption
        {
            get { return this._dataExchangeFulfillmentOption; }
            set { this._dataExchangeFulfillmentOption = value; }
        }

        // Check to see if DataExchangeFulfillmentOption property is set
        internal bool IsSetDataExchangeFulfillmentOption()
        {
            return this._dataExchangeFulfillmentOption != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2ImageBuilderComponentFulfillmentOption. 
        /// <para>
        /// An EC2 Image Builder component fulfillment option.
        /// </para>
        /// </summary>
        public Ec2ImageBuilderComponentFulfillmentOption Ec2ImageBuilderComponentFulfillmentOption
        {
            get { return this._ec2ImageBuilderComponentFulfillmentOption; }
            set { this._ec2ImageBuilderComponentFulfillmentOption = value; }
        }

        // Check to see if Ec2ImageBuilderComponentFulfillmentOption property is set
        internal bool IsSetEc2ImageBuilderComponentFulfillmentOption()
        {
            return this._ec2ImageBuilderComponentFulfillmentOption != null;
        }

        /// <summary>
        /// Gets and sets the property EksAddOnFulfillmentOption. 
        /// <para>
        /// An Amazon EKS add-on fulfillment option.
        /// </para>
        /// </summary>
        public EksAddOnFulfillmentOption EksAddOnFulfillmentOption
        {
            get { return this._eksAddOnFulfillmentOption; }
            set { this._eksAddOnFulfillmentOption = value; }
        }

        // Check to see if EksAddOnFulfillmentOption property is set
        internal bool IsSetEksAddOnFulfillmentOption()
        {
            return this._eksAddOnFulfillmentOption != null;
        }

        /// <summary>
        /// Gets and sets the property HelmFulfillmentOption. 
        /// <para>
        /// A Helm chart fulfillment option for Kubernetes deployment.
        /// </para>
        /// </summary>
        public HelmFulfillmentOption HelmFulfillmentOption
        {
            get { return this._helmFulfillmentOption; }
            set { this._helmFulfillmentOption = value; }
        }

        // Check to see if HelmFulfillmentOption property is set
        internal bool IsSetHelmFulfillmentOption()
        {
            return this._helmFulfillmentOption != null;
        }

        /// <summary>
        /// Gets and sets the property ProfessionalServicesFulfillmentOption. 
        /// <para>
        /// A professional services fulfillment option.
        /// </para>
        /// </summary>
        public ProfessionalServicesFulfillmentOption ProfessionalServicesFulfillmentOption
        {
            get { return this._professionalServicesFulfillmentOption; }
            set { this._professionalServicesFulfillmentOption = value; }
        }

        // Check to see if ProfessionalServicesFulfillmentOption property is set
        internal bool IsSetProfessionalServicesFulfillmentOption()
        {
            return this._professionalServicesFulfillmentOption != null;
        }

        /// <summary>
        /// Gets and sets the property SaasFulfillmentOption. 
        /// <para>
        /// A Software as a Service (SaaS) fulfillment option.
        /// </para>
        /// </summary>
        public SaasFulfillmentOption SaasFulfillmentOption
        {
            get { return this._saasFulfillmentOption; }
            set { this._saasFulfillmentOption = value; }
        }

        // Check to see if SaasFulfillmentOption property is set
        internal bool IsSetSaasFulfillmentOption()
        {
            return this._saasFulfillmentOption != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerAlgorithmFulfillmentOption. 
        /// <para>
        /// An Amazon SageMaker algorithm fulfillment option.
        /// </para>
        /// </summary>
        public SageMakerAlgorithmFulfillmentOption SageMakerAlgorithmFulfillmentOption
        {
            get { return this._sageMakerAlgorithmFulfillmentOption; }
            set { this._sageMakerAlgorithmFulfillmentOption = value; }
        }

        // Check to see if SageMakerAlgorithmFulfillmentOption property is set
        internal bool IsSetSageMakerAlgorithmFulfillmentOption()
        {
            return this._sageMakerAlgorithmFulfillmentOption != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerModelFulfillmentOption. 
        /// <para>
        /// An Amazon SageMaker model fulfillment option.
        /// </para>
        /// </summary>
        public SageMakerModelFulfillmentOption SageMakerModelFulfillmentOption
        {
            get { return this._sageMakerModelFulfillmentOption; }
            set { this._sageMakerModelFulfillmentOption = value; }
        }

        // Check to see if SageMakerModelFulfillmentOption property is set
        internal bool IsSetSageMakerModelFulfillmentOption()
        {
            return this._sageMakerModelFulfillmentOption != null;
        }

    }
}