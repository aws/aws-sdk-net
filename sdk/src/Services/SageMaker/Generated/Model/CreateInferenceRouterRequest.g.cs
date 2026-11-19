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
    /// Container for the parameters to the CreateInferenceRouter operation. Creates an inference
    /// router. An inference router is a Regional SageMaker AI resource that sends each inference
    /// request to one of the endpoints or inference components that you list for a routing
    /// target. These destinations can be in any Amazon Web Services account, and in any Amazon
    /// Web Services Region in the same partition as the router. <para> The router's status
    /// is <c>Creating</c> until it's ready to use. SageMaker AI checks that each endpoint
    /// is a real-time or asynchronous endpoint, as the routing target requires, and rejects
    /// one of the wrong type. It checks endpoints in other accounts with your credentials,
    /// so the endpoint policy must allow <c>sagemaker:DescribeEndpoint</c>. SageMaker AI
    /// accepts an endpoint that it can't check, for example one that doesn't exist. Requests
    /// to it fail if it's the wrong type or doesn't exist. To see the status of each destination,
    /// call <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeInferenceRouter.html">DescribeInferenceRouter</a>
    /// and see the <c>RoutingStatus</c> of each destination. </para> <para> To invoke the
    /// router, use <c>InvokeInferenceRouter</c> or <c>InvokeInferenceRouterAsync</c>. For
    /// information about inference routers, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/inference-router.html">Route
    /// requests across Regions with inference routers</a>. </para>
    /// </summary>
    public partial class CreateInferenceRouterRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you reuse a client token, use the same request parameters. Otherwise,
        /// the request fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property InferenceRouterName. 
        /// <para>
        /// The name of the inference router. The name must be unique within your account in the
        /// current Amazon Web Services Region. The name is case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string InferenceRouterName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceRouterName property is set.
        /// </summary>
        internal bool IsSetInferenceRouterName() => this.InferenceRouterName != null;

        /// <summary>
        /// Gets and sets the property RoutingTargets. 
        /// <para>
        /// The routing targets of the inference router. Each routing target is a model that callers
        /// name when they invoke the router, and the destinations that serve it.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public List<RoutingTarget> RoutingTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<RoutingTarget>() : null;

        /// <summary>
        /// Checks to see if the RoutingTargets property is set.
        /// </summary>
        internal bool IsSetRoutingTargets() => this.RoutingTargets != null && (this.RoutingTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to apply to the inference router. For information about
        /// tagging, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
