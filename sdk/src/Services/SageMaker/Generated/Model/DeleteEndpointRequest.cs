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
    /// Container for the parameters to the DeleteEndpoint operation.
    /// Deletes an endpoint. SageMaker frees up all of the resources that were deployed when
    /// the endpoint was created. 
    /// 
    ///  
    /// <para>
    /// SageMaker retires any custom KMS key grants associated with the endpoint, meaning
    /// you don't need to use the <a href="http://docs.aws.amazon.com/kms/latest/APIReference/API_RevokeGrant.html">RevokeGrant</a>
    /// API call.
    /// </para>
    ///  
    /// <para>
    /// When you delete your endpoint, SageMaker asynchronously deletes associated endpoint
    /// resources such as KMS key grants. You might still see these resources in your account
    /// for a few minutes after deleting your endpoint. Do not delete or revoke the permissions
    /// for your <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateModel.html#sagemaker-CreateModel-request-ExecutionRoleArn">ExecutionRoleArn</a>
    /// </c>, otherwise SageMaker cannot delete these resources.
    /// </para>
    /// </summary>
    public partial class DeleteEndpointRequest : AmazonSageMakerRequest
    {
        private string _endpointName;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
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

    }
}