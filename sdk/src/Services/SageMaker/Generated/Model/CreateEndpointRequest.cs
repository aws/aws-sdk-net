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
    /// Container for the parameters to the CreateEndpoint operation.
    /// Creates an endpoint using the endpoint configuration specified in the request. SageMaker
    /// uses the endpoint to provision resources and deploy models. You create the endpoint
    /// configuration with the <a>CreateEndpointConfig</a> API. 
    /// 
    ///  
    /// <para>
    ///  Use this API to deploy models using SageMaker hosting services. 
    /// </para>
    ///  
    /// <para>
    /// For an example that calls this method when deploying a model to SageMaker hosting
    /// services, see the <a href="https://github.com/aws/amazon-sagemaker-examples/blob/master/sagemaker-fundamentals/create-endpoint/create_endpoint.ipynb">Create
    /// Endpoint example notebook.</a> 
    /// </para>
    ///  <note> 
    /// <para>
    ///  You must not delete an <code>EndpointConfig</code> that is in use by an endpoint
    /// that is live or while the <code>UpdateEndpoint</code> or <code>CreateEndpoint</code>
    /// operations are being performed on the endpoint. To update an endpoint, you must create
    /// a new <code>EndpointConfig</code>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The endpoint name must be unique within an Amazon Web Services Region in your Amazon
    /// Web Services account. 
    /// </para>
    ///  
    /// <para>
    /// When it receives the request, SageMaker creates the endpoint, launches the resources
    /// (ML compute instances), and deploys the model(s) on them. 
    /// </para>
    ///  <note> 
    /// <para>
    /// When you call <a>CreateEndpoint</a>, a load call is made to DynamoDB to verify that
    /// your endpoint configuration exists. When you read data from a DynamoDB table supporting
    /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
    /// <code>Eventually Consistent Reads</code> </a>, the response might not reflect the
    /// results of a recently completed write operation. The response might include some stale
    /// data. If the dependent entities are not yet in DynamoDB, this causes a validation
    /// error. If you repeat your read request after a short time, the response should return
    /// the latest data. So retry logic is recommended to handle these possible issues. We
    /// also recommend that customers call <a>DescribeEndpointConfig</a> before calling <a>CreateEndpoint</a>
    /// to minimize the potential impact of a DynamoDB eventually consistent read.
    /// </para>
    ///  </note> 
    /// <para>
    /// When SageMaker receives the request, it sets the endpoint status to <code>Creating</code>.
    /// After it creates the endpoint, it sets the status to <code>InService</code>. SageMaker
    /// can then process incoming requests for inferences. To check the status of an endpoint,
    /// use the <a>DescribeEndpoint</a> API.
    /// </para>
    ///  
    /// <para>
    /// If any of the models hosted at this endpoint get model data from an Amazon S3 location,
    /// SageMaker uses Amazon Web Services Security Token Service to download model artifacts
    /// from the S3 path you provided. Amazon Web Services STS is activated in your Amazon
    /// Web Services account by default. If you previously deactivated Amazon Web Services
    /// STS for a region, you need to reactivate Amazon Web Services STS for that region.
    /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
    /// and Deactivating Amazon Web Services STS in an Amazon Web Services Region</a> in the
    /// <i>Amazon Web Services Identity and Access Management User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  To add the IAM role policies for using this API operation, go to the <a href="https://console.aws.amazon.com/iam/">IAM
    /// console</a>, and choose Roles in the left navigation pane. Search the IAM role that
    /// you want to grant access to use the <a>CreateEndpoint</a> and <a>CreateEndpointConfig</a>
    /// API operations, add the following policies to the role. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Option 1: For a full SageMaker access, search and attach the <code>AmazonSageMakerFullAccess</code>
    /// policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Option 2: For granting a limited access to an IAM role, paste the following Action
    /// elements manually into the JSON file of the IAM role: 
    /// </para>
    ///  
    /// <para>
    ///  <code>"Action": ["sagemaker:CreateEndpoint", "sagemaker:CreateEndpointConfig"]</code>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <code>"Resource": [</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>"arn:aws:sagemaker:region:account-id:endpoint/endpointName"</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>"arn:aws:sagemaker:region:account-id:endpoint-config/endpointConfigName"</code>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <code>]</code> 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/api-permissions-reference.html">SageMaker
    /// API Permissions: Actions, Permissions, and Resources Reference</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CreateEndpointRequest : AmazonSageMakerRequest
    {
        private DeploymentConfig _deploymentConfig;
        private string _endpointConfigName;
        private string _endpointName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DeploymentConfig.
        /// </summary>
        public DeploymentConfig DeploymentConfig
        {
            get { return this._deploymentConfig; }
            set { this._deploymentConfig = value; }
        }

        // Check to see if DeploymentConfig property is set
        internal bool IsSetDeploymentConfig()
        {
            return this._deploymentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// The name of an endpoint configuration. For more information, see <a>CreateEndpointConfig</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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
        /// The name of the endpoint.The name must be unique within an Amazon Web Services Region
        /// in your Amazon Web Services account. The name is case-insensitive in <code>CreateEndpoint</code>,
        /// but the case is preserved and must be matched in .
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}