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
    /// Container for the parameters to the CreateEndpointConfig operation.
    /// Creates an endpoint configuration that Amazon SageMaker hosting services uses to deploy
    /// models. In the configuration, you identify one or more models, created using the <code>CreateModel</code>
    /// API, to deploy and the resources that you want Amazon SageMaker to provision. Then
    /// you call the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateEndpoint.html">CreateEndpoint</a>
    /// API.
    /// 
    ///  <note> 
    /// <para>
    ///  Use this API only if you want to use Amazon SageMaker hosting services to deploy
    /// models into production. 
    /// </para>
    ///  </note> 
    /// <para>
    /// In the request, you define one or more <code>ProductionVariant</code>s, each of which
    /// identifies a model. Each <code>ProductionVariant</code> parameter also describes the
    /// resources that you want Amazon SageMaker to provision. This includes the number and
    /// type of ML compute instances to deploy. 
    /// </para>
    ///  
    /// <para>
    /// If you are hosting multiple models, you also assign a <code>VariantWeight</code> to
    /// specify how much traffic you want to allocate to each model. For example, suppose
    /// that you want to host two models, A and B, and you assign traffic weight 2 for model
    /// A and 1 for model B. Amazon SageMaker distributes two-thirds of the traffic to Model
    /// A, and one-third to model B. 
    /// </para>
    /// </summary>
    public partial class CreateEndpointConfigRequest : AmazonSageMakerRequest
    {
        private string _endpointConfigName;
        private string _kmsKeyId;
        private List<ProductionVariant> _productionVariants = new List<ProductionVariant>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// The name of the endpoint configuration. You specify this name in a <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateEndpoint.html">CreateEndpoint</a>
        /// request. 
        /// </para>
        /// </summary>
        public string EndpointConfigName
        {
            get { return this._endpointConfigName; }
            set { this._endpointConfigName = value; }
        }

        // Check to see if EndpointConfigName property is set
        internal bool IsSetEndpointConfigName()
        {
            return this._endpointConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a AWS Key Management Service key that Amazon SageMaker
        /// uses to encrypt data on the storage volume attached to the ML compute instance that
        /// hosts the endpoint.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductionVariants. 
        /// <para>
        /// An array of <code>ProductionVariant</code> objects, one for each model that you want
        /// to host at this endpoint.
        /// </para>
        /// </summary>
        public List<ProductionVariant> ProductionVariants
        {
            get { return this._productionVariants; }
            set { this._productionVariants = value; }
        }

        // Check to see if ProductionVariants property is set
        internal bool IsSetProductionVariants()
        {
            return this._productionVariants != null && this._productionVariants.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. For more information, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-what">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// 
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}