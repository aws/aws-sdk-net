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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides summary information for an endpoint.
    /// </summary>
    public partial class EndpointSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the endpoint was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string EndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointArn property is set.
        /// </summary>
        internal bool IsSetEndpointArn() => this.EndpointArn != null;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property EndpointStatus. 
        /// <para>
        /// The status of the endpoint.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OutOfService</c>: Endpoint is not available to take incoming requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Creating</c>: <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>
        /// is executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Updating</c>: <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpoint.html">UpdateEndpoint</a>
        /// or <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpointWeightsAndCapacities.html">UpdateEndpointWeightsAndCapacities</a>
        /// is executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SystemUpdating</c>: Endpoint is undergoing maintenance and cannot be updated or
        /// deleted or re-scaled until it has completed. This maintenance operation does not change
        /// any customer-specified values such as VPC config, KMS encryption, model, instance
        /// type, or instance count.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RollingBack</c>: Endpoint fails to scale up or down or change its variant weight
        /// and is in the process of rolling back to its previous configuration. Once the rollback
        /// completes, endpoint returns to an <c>InService</c> status. This transitional status
        /// only applies to an endpoint that has autoscaling enabled and is undergoing variant
        /// weight or capacity changes as part of an <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpointWeightsAndCapacities.html">UpdateEndpointWeightsAndCapacities</a>
        /// call or when the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpointWeightsAndCapacities.html">UpdateEndpointWeightsAndCapacities</a>
        /// operation is called explicitly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InService</c>: Endpoint is available to process incoming requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleting</c>: <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteEndpoint.html">DeleteEndpoint</a>
        /// is executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: Endpoint could not be created, updated, or re-scaled. Use <c>DescribeEndpointOutput$FailureReason</c>
        /// for information about the failure. <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteEndpoint.html">DeleteEndpoint</a>
        /// is the only operation that can be performed on a failed endpoint.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get a list of endpoints with a specified status, use the <c>StatusEquals</c> filter
        /// with a call to <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListEndpoints.html">ListEndpoints</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointStatus EndpointStatus { get; set; }

        /// <summary>
        /// Checks to see if the EndpointStatus property is set.
        /// </summary>
        internal bool IsSetEndpointStatus() => this.EndpointStatus != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that shows when the endpoint was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;
    }
}
