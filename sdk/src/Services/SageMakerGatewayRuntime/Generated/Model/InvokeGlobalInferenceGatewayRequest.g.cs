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

namespace Amazon.SageMakerGatewayRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeGlobalInferenceGateway operation. Buffered
    /// (non-streaming) inference. Returns the full OpenAI completion body. Errors carry their
    /// origin in the `Message` prefix. Every typed error's text is in the `Message` member
    /// (JSON key `Message`), and starts with one of these prefixes: * `Global Inference Gateway:
    /// ` -- the gateway rejected or failed the request itself: validation, authorization,
    /// throttling, routing (the gateway or model was not found, or no capacity is available),
    /// a gateway limit or time limit, or failing to reach the inference gateway (`Global
    /// Inference Gateway: could not reach the inference gateway: &lt;reason&gt;`, or `Global
    /// Inference Gateway: timed out waiting for the inference gateway`). This includes the
    /// 400 for an invalid request and the 413 for a request body that is too large. * `inference
    /// gateway: ` -- the inference gateway serving the model returned an error status. The
    /// message gives that status code and up to 256 bytes of its error message, for example
    /// `inference gateway: 503 &lt;message&gt;`. A BadGatewayException can instead read `inference
    /// gateway: response ended unexpectedly`, with no status, when the inference gateway's
    /// connection failed while it was sending the response. * `inference gateway (&lt;component&gt;):
    /// ` -- the same, when the inference gateway reports which of its components produced
    /// the error, for example `inference gateway (model server): 502 &lt;message&gt;`. The
    /// component is one of: * `config` -- the inference gateway's configuration and proxy
    /// layer. * `scheduler` -- the inference gateway's request scheduler. * `model selector`
    /// -- the inference gateway's model selector. * `model server` -- the model server. Every
    /// error status the inference gateway returns is a typed error, chosen by that status:
    /// * 400 and any other 4xx not listed here -- a 400 validation error. * 401 and 403 --
    /// AccessDeniedException (403). * 404 -- ResourceNotFoundException. * 408 -- GatewayTimeoutException
    /// (504). * 429 -- ThrottlingException, with the `Retry-After` header. * 502, and 500,
    /// 503 or any other 5xx not listed here -- BadGatewayException (502). A 500 or 503 from
    /// the inference gateway comes after the request was dispatched, so it is not modeled
    /// as retryable, and the gateway may already have tried another inference gateway. Standard
    /// SDK retry modes may still retry a 5xx status; set max attempts to 1 if a repeated
    /// inference is unacceptable. * 504 -- GatewayTimeoutException.
    /// </summary>
    public partial class InvokeGlobalInferenceGatewayRequest : AmazonSageMakerGatewayRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property Accept. The MIME type you want for the response. It is
        /// passed to the model server.
        /// </summary>
        public string Accept { get; set; }

        /// <summary>
        /// Checks to see if the Accept property is set.
        /// </summary>
        internal bool IsSetAccept() => this.Accept != null;

        /// <summary>
        /// Gets and sets the property Body. The inference request body: one OpenAI JSON object,
        /// at most 10 MiB. Its content is passed to the model server unchanged, except that the
        /// request is always sent with `"stream": false`: this operation returns one JSON document,
        /// so a `"stream": true` in the body is overridden (use InvokeGlobalInferenceGatewayWithResponseStream
        /// to stream). A body that is not one JSON object, or that repeats the top-level `model`
        /// key with different values, is rejected with a 400 validation error. A body larger
        /// than 10 MiB is rejected with PayloadTooLargeException (413). The gateway reads only
        /// `model` and `stream`, and does not store the body.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 10485760)]
        public MemoryStream Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ContentType. The MIME type of the request body. Pass `application/json`
        /// (parameters such as `charset=utf-8` are allowed): the body is one OpenAI JSON object.
        /// The Global Inference Gateway rejects other content types with a 415 error.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property CustomerIdentityToken. Per-caller customer identity token
        /// (a JWT), forwarded unchanged to the inference gateway, which validates it. The gateway
        /// does not use it to authorize the request. Include it in the SigV4 signed headers so
        /// it cannot be altered in transit. Redacted from logs, metrics and traces.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CustomerIdentityToken { get; set; }

        /// <summary>
        /// Checks to see if the CustomerIdentityToken property is set.
        /// </summary>
        internal bool IsSetCustomerIdentityToken() => this.CustomerIdentityToken != null;

        /// <summary>
        /// Gets and sets the property GatewayId. The ID of the Global Inference Gateway to invoke.
        /// IAM policies refer to the gateway by its ARN, `arn:&lt;partition&gt;:sagemaker:&lt;region&gt;:&lt;account&gt;:global-inference-gateway/&lt;id&gt;`.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;
    }
}
