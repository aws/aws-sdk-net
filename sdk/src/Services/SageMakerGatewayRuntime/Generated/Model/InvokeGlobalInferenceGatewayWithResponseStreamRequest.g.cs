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
    /// Container for the parameters to the InvokeGlobalInferenceGatewayWithResponseStream
    /// operation. Streaming inference. Returns an AWS event stream of PayloadPart events
    /// that carry the model server's server-sent event (SSE) bytes, so SDKs decode the stream
    /// into events for you. The errors listed for this operation, other than ModelStreamError
    /// and InternalStreamFailure, are returned before the response starts (before the 200
    /// status), so they end the request, not the stream. None of them can occur after the
    /// 200. ModelStreamError and InternalStreamFailure appear only as events in the stream,
    /// after the 200. Once the 200 is sent, the stream carries the response as PayloadPart
    /// events. If reading the inference gateway's response fails, the stream carries one
    /// InternalStreamFailure event and then ends. ModelStreamError is reserved and is not
    /// currently sent. Errors carry their origin in the `Message` prefix. Every typed error's
    /// text is in the `Message` member (JSON key `Message`), and starts with one of these
    /// prefixes: * `Global Inference Gateway: ` -- the gateway rejected or failed the request
    /// itself: validation, authorization, throttling, routing (the gateway or model was not
    /// found, or no capacity is available), a gateway limit or time limit, or failing to
    /// reach the inference gateway (`Global Inference Gateway: could not reach the inference
    /// gateway: &lt;reason&gt;`, or `Global Inference Gateway: timed out waiting for the
    /// inference gateway`). This includes the 400 for an invalid request and the 413 for
    /// a request body that is too large. * `inference gateway: ` -- the inference gateway
    /// serving the model returned an error status. The message gives that status code and
    /// up to 256 bytes of its error message, for example `inference gateway: 503 &lt;message&gt;`.
    /// * `inference gateway (&lt;component&gt;): ` -- the same, when the inference gateway
    /// reports which of its components produced the error, for example `inference gateway
    /// (model server): 502 &lt;message&gt;`. The component is one of: * `config` -- the inference
    /// gateway's configuration and proxy layer. * `scheduler` -- the inference gateway's
    /// request scheduler. * `model selector` -- the inference gateway's model selector. *
    /// `model server` -- the model server. An InternalStreamFailure event's `Message` uses
    /// the same prefixes, with the same text the buffered operation uses for the same failure.
    /// Its `inference gateway: ` message carries no status: `inference gateway: response
    /// ended unexpectedly` when the inference gateway's connection failed while it was sending
    /// the response. Every error status the inference gateway returns before the 200 is a
    /// typed error, chosen by that status as for InvokeGlobalInferenceGateway: * 400 and
    /// any other 4xx not listed here -- a 400 validation error. * 401 and 403 -- AccessDeniedException
    /// (403). * 404 -- ResourceNotFoundException. * 408 -- GatewayTimeoutException (504).
    /// * 429 -- ThrottlingException, with the `Retry-After` header. * 502, and 500, 503 or
    /// any other 5xx not listed here -- BadGatewayException (502). A 500 or 503 from the
    /// inference gateway comes after the request was dispatched, so it is not modeled as
    /// retryable, and the gateway may already have tried another inference gateway. Standard
    /// SDK retry modes may still retry a 5xx status; set max attempts to 1 if a repeated
    /// inference is unacceptable. * 504 -- GatewayTimeoutException.
    /// </summary>
    public partial class InvokeGlobalInferenceGatewayWithResponseStreamRequest : AmazonSageMakerGatewayRuntimeRequest
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
        /// Gets and sets the property Body. The inference request body, as for InvokeGlobalInferenceGateway,
        /// except that the request is always sent with `"stream": true`: this operation returns
        /// an event stream, so a `"stream": false` in the body (or no `stream` key) is overridden.
        /// A body larger than 10 MiB is rejected with PayloadTooLargeException (413).
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 10485760)]
        public MemoryStream Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ContentType. The MIME type of the request body, as for
        /// InvokeGlobalInferenceGateway. Pass `application/json`.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property CustomerIdentityToken. The customer identity token (a JWT),
        /// as for InvokeGlobalInferenceGateway. It is passed unchanged to the inference gateway,
        /// which validates it.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CustomerIdentityToken { get; set; }

        /// <summary>
        /// Checks to see if the CustomerIdentityToken property is set.
        /// </summary>
        internal bool IsSetCustomerIdentityToken() => this.CustomerIdentityToken != null;

        /// <summary>
        /// Gets and sets the property GatewayId. The ID of the Global Inference Gateway to invoke,
        /// as for InvokeGlobalInferenceGateway.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;
    }
}
