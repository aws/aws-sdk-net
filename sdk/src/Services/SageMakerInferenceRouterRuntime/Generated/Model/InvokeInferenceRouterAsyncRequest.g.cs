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
    /// Container for the parameters to the InvokeInferenceRouterAsync operation. Submits
    /// an asynchronous inference request to an inference router. Before you call this operation,
    /// upload the input data to Amazon S3 in the router's Amazon Web Services Region. The
    /// router returns as soon as it accepts the request, and sends the request to one of
    /// the destinations of the routing target. The destination reads the input from Amazon
    /// S3, and the inference response is written to the Amazon S3 output path that the routing
    /// target specifies. <para> If a destination doesn't start the request within the routing
    /// target's <c>MaxTimeInBacklogSeconds</c>, the router moves the request to another destination.
    /// After your model starts processing the request, the request doesn't move. If no destination
    /// can take the request before <c>RequestTTLSeconds</c> runs out, or every destination
    /// has been tried, the router writes a failure object to the <c>FailureLocation</c> and
    /// publishes a notification to the routing target's error topic, if one is configured.
    /// </para> <para> For information about the permissions that the caller and each destination
    /// need, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/inference-router-async.html">Send
    /// asynchronous requests through an inference router</a>. </para>
    /// </summary>
    public partial class InvokeInferenceRouterAsyncRequest : AmazonSageMakerInferenceRouterRuntimeRequest
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
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the input data in Amazon S3. The router passes it to the destination.
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
        /// Gets and sets the property Filename. 
        /// <para>
        /// The file name of the inference response stored in Amazon S3. If you don't provide
        /// one, SageMaker AI generates one.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Filename { get; set; }

        /// <summary>
        /// Checks to see if the Filename property is set.
        /// </summary>
        internal bool IsSetFilename() => this.Filename != null;

        /// <summary>
        /// Gets and sets the property InferenceId. 
        /// <para>
        /// An identifier for the inference request. If you don't provide one, SageMaker AI generates
        /// one and returns it in the response.
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
        /// Gets and sets the property InputLocation. 
        /// <para>
        /// The Amazon S3 URI of the object that contains the input data for the inference. The
        /// bucket must be in the inference router's Amazon Web Services Region and owned by the
        /// router's account. The destination endpoint's execution role reads the object, and
        /// the destination's asynchronous inference limits apply to it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string InputLocation { get; set; }

        /// <summary>
        /// Checks to see if the InputLocation property is set.
        /// </summary>
        internal bool IsSetInputLocation() => this.InputLocation != null;

        /// <summary>
        /// Gets and sets the property InvocationTimeoutSeconds. 
        /// <para>
        /// The maximum time, in seconds, that a destination can spend processing the request
        /// before the request is marked as expired. The default is 900 seconds (15 minutes).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3600)]
        public int? InvocationTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the InvocationTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetInvocationTimeoutSeconds() => this.InvocationTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property RequestTTLSeconds. 
        /// <para>
        /// The time to live of the request, in seconds, measured from when the router accepts
        /// it. If no destination starts the request in this time, the request fails. The default
        /// is 21,600 seconds (6 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 21600)]
        public int? RequestTTLSeconds { get; set; }

        /// <summary>
        /// Checks to see if the RequestTTLSeconds property is set.
        /// </summary>
        internal bool IsSetRequestTTLSeconds() => this.RequestTTLSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property RoutingTargetName. 
        /// <para>
        /// The name of the routing target in the inference router. The routing target must be
        /// configured for asynchronous inference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string RoutingTargetName { get; set; }

        /// <summary>
        /// Checks to see if the RoutingTargetName property is set.
        /// </summary>
        internal bool IsSetRoutingTargetName() => this.RoutingTargetName != null;

        /// <summary>
        /// Gets and sets the property S3OutputPathExtension. 
        /// <para>
        /// The path extension that is appended to the routing target's Amazon S3 output path
        /// where the inference response is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string S3OutputPathExtension { get; set; }

        /// <summary>
        /// Checks to see if the S3OutputPathExtension property is set.
        /// </summary>
        internal bool IsSetS3OutputPathExtension() => this.S3OutputPathExtension != null;
    }
}
