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
    /// Container for the parameters to the CreateEndpoint operation.
    /// Creates an endpoint using the endpoint configuration specified in the request. Amazon
    /// SageMaker uses the endpoint to provision resources and deploy models. You create the
    /// endpoint configuration with the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateEndpointConfig.html">CreateEndpointConfig</a>
    /// API. 
    /// 
    ///  <note> 
    /// <para>
    ///  Use this API only for hosting models using Amazon SageMaker hosting services. 
    /// </para>
    ///  </note> 
    /// <para>
    /// The endpoint name must be unique within an AWS Region in your AWS account. 
    /// </para>
    ///  
    /// <para>
    /// When it receives the request, Amazon SageMaker creates the endpoint, launches the
    /// resources (ML compute instances), and deploys the model(s) on them. 
    /// </para>
    ///  
    /// <para>
    /// When Amazon SageMaker receives the request, it sets the endpoint status to <code>Creating</code>.
    /// After it creates the endpoint, it sets the status to <code>InService</code>. Amazon
    /// SageMaker can then process incoming requests for inferences. To check the status of
    /// an endpoint, use the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_DescribeEndpoint.html">DescribeEndpoint</a>
    /// API.
    /// </para>
    ///  
    /// <para>
    /// For an example, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/ex1.html">Exercise
    /// 1: Using the K-Means Algorithm Provided by Amazon SageMaker</a>. 
    /// </para>
    ///  
    /// <para>
    /// If any of the models hosted at this endpoint get model data from an Amazon S3 location,
    /// Amazon SageMaker uses AWS Security Token Service to download model artifacts from
    /// the S3 path you provided. AWS STS is activated in your IAM user account by default.
    /// If you previously deactivated AWS STS for a region, you need to reactivate AWS STS
    /// for that region. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
    /// and Deactivating AWS STS i an AWS Region</a> in the <i>AWS Identity and Access Management
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateEndpointRequest : AmazonSageMakerRequest
    {
        private string _endpointConfigName;
        private string _endpointName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// The name of an endpoint configuration. For more information, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateEndpointConfig.html">CreateEndpointConfig</a>.
        /// 
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
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint. The name must be unique within an AWS Region in your AWS
        /// account.
        /// </para>
        /// </summary>
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. For more information, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-what">Using
        /// Cost Allocation Tags</a>in the <i>AWS Billing and Cost Management User Guide</i>.
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