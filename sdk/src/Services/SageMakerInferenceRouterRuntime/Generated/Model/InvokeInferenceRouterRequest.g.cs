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

namespace Amazon.SageMakerInferenceRouterRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeInferenceRouter operation. Sends a real-time
    /// inference request to an inference router. In the request, you name the routing target,
    /// and the router sends the request to one of the routing target's destinations. The
    /// response includes the destination that served the request and the reason that the
    /// router chose it. <para> The following limits apply: </para> <ul> <li> <para> The maximum
    /// request payload is 6 MB. A request with a larger body fails with HTTP status code
    /// 413. </para> </li> <li> <para> Your model has up to 60 seconds for each attempt, the
    /// same limit as <c>InvokeEndpoint</c>. If your account has a higher model execution
    /// timeout for <c>InvokeEndpoint</c>, it doesn't apply through an inference router. For
    /// models that take longer, use <c>InvokeInferenceRouterAsync</c>. </para> </li> </ul>
    /// <para> If a destination returns an error that the router can retry, such as a throttling
    /// error, before your model produces a response, the router retries the request once
    /// on another destination. A request that times out on a destination isn't retried. Because
    /// a request can make two attempts, set your client read timeout to at least 170 seconds.
    /// </para> <para> The caller needs permission to invoke the inference router and every
    /// destination of the routing target. For information about permissions, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/inference-router.html">Route
    /// requests across Regions with inference routers</a>. </para>
    /// </summary>
    public partial class InvokeInferenceRouterRequest : AmazonSageMakerInferenceRouterRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The MIME type that you want for the inference response. The router passes it to the
        /// destination.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string Accept { get; set; }

        /// <summary>
        /// Checks to see if the Accept property is set.
        /// </summary>
        internal bool IsSetAccept() => this.Accept != null;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The input data for the inference, in the format that your model expects. The body
        /// can't be empty.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 6291456)]
        public MemoryStream Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the input data in the request body. The router passes it to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property CustomAttributes. 
        /// <para>
        /// Provides additional information about the inference request. The value is an opaque
        /// string that the router passes, unchanged, to the model container of the destination
        /// that serves the request. The value can contain up to 1,024 visible US-ASCII characters.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1024)]
        public string CustomAttributes { get; set; }

        /// <summary>
        /// Checks to see if the CustomAttributes property is set.
        /// </summary>
        internal bool IsSetCustomAttributes() => this.CustomAttributes != null;

        /// <summary>
        /// Gets and sets the property InferenceId. 
        /// <para>
        /// An identifier for the inference request. The router passes it to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string InferenceId { get; set; }

        /// <summary>
        /// Checks to see if the InferenceId property is set.
        /// </summary>
        internal bool IsSetInferenceId() => this.InferenceId != null;

        /// <summary>
        /// Gets and sets the property InferenceRouterName. 
        /// <para>
        /// The name of the inference router to invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string InferenceRouterName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceRouterName property is set.
        /// </summary>
        internal bool IsSetInferenceRouterName() => this.InferenceRouterName != null;

        /// <summary>
        /// Gets and sets the property PrefixAwareId. 
        /// <para>
        /// An optional, stable identifier that serves as a routing hint for prefix-aware routing.
        /// The router passes it to the destination that serves the request. Within that destination,
        /// requests with the same prefix and the same identifier go to the same instance. If
        /// requests from different applications might have the same prompt prefix, set a different
        /// identifier for each application to differentiate their routing decisions.
        /// </para>
        ///  
        /// <para>
        /// Applies only to destination endpoints configured with a <c>RoutingStrategy</c> of
        /// <c>PREFIX_AWARE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string PrefixAwareId { get; set; }

        /// <summary>
        /// Checks to see if the PrefixAwareId property is set.
        /// </summary>
        internal bool IsSetPrefixAwareId() => this.PrefixAwareId != null;

        /// <summary>
        /// Gets and sets the property RoutingTargetName. 
        /// <para>
        /// The name of the routing target in the inference router. The routing target lists the
        /// destinations that can serve the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string RoutingTargetName { get; set; }

        /// <summary>
        /// Checks to see if the RoutingTargetName property is set.
        /// </summary>
        internal bool IsSetRoutingTargetName() => this.RoutingTargetName != null;
    }
}
