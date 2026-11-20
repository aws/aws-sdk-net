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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.SageMakerGatewayRuntime.Model;

#pragma warning disable CS1570

namespace Amazon.SageMakerGatewayRuntime
{
    /// <summary>
    /// <para>Interface for accessing SageMakerGatewayRuntime</para>
    ///
    /// Use the Amazon SageMaker Gateway Runtime API to run inference through a Global Inference
    /// Gateway. A Global Inference Gateway routes each request to an inference gateway that
    /// serves the model named in the request. The request body is an OpenAI-compatible JSON
    /// object, sent with `Content-Type: application/json`, and the model is selected by the
    /// `model` key in that body. The content of the body is passed to the model server unchanged,
    /// except for the `stream` flag, which each operation sets. Requests are signed with
    /// Signature Version 4 under the `sagemaker` signing name. IAM actions are in the `sagemaker`
    /// namespace, for example `sagemaker:InvokeGlobalInferenceGateway`. The default regional
    /// endpoint is `gateway-runtime.sagemaker.{region}.amazonaws.com`.
    /// </summary>
    public partial interface IAmazonSageMakerGatewayRuntime : IAmazonService, IDisposable
    {
#if NETFRAMEWORK
        /// <summary>
        /// Buffered (non-streaming) inference. Returns the full OpenAI completion body. Errors
        /// carry their origin in the `Message` prefix. Every typed error's text is in the `Message`
        /// member (JSON key `Message`), and starts with one of these prefixes: * `Global Inference
        /// Gateway: ` -- the gateway rejected or failed the request itself: validation, authorization,
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
        /// <param name="request">Container for the necessary parameters to execute the InvokeGlobalInferenceGateway service method.</param>
        /// <returns>The response from the InvokeGlobalInferenceGateway service method, as returned by SageMakerGatewayRuntime.</returns>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.AccessDeniedException">
        /// The caller is not authorized to invoke this gateway. Invoking requires the `sagemaker:InvokeGlobalInferenceGateway`
        /// permission, or `sagemaker:InvokeGlobalInferenceGatewayWithResponseStream` for the
        /// streaming operation, on the gateway ARN. A message starting `inference gateway` means
        /// the inference gateway serving the model refused the request with a 401 or 403, for
        /// example for its customer identity token. Its status code is in the message (the response
        /// status is 403), and up to 256 bytes of its error message are quoted.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.BadGatewayException">
        /// 502 -- The gateway could not get a usable response from the inference gateway. The
        /// `Message` prefix says why: * `Global Inference Gateway: could not reach the inference
        /// gateway: &lt;reason&gt;` -- the request could not be sent, or the connection closed
        /// before a response arrived (for example, the connection failed, or the inference gateway
        /// closed it after reading the request). * `Global Inference Gateway: timed out waiting
        /// for the inference gateway` -- on the buffered operation, the inference gateway stopped
        /// sending partway through the response body and the gateway's read timeout expired.
        /// (The same text on a GatewayTimeoutException means no response arrived.) * Any other
        /// `Global Inference Gateway: ` message -- the gateway ended a response before it was
        /// complete, for example because it exceeded the 10 MiB limit of the buffered operation,
        /// the request exceeded its maximum duration, or the inference gateway was taken out
        /// of service. * `inference gateway: &lt;status&gt; &lt;message&gt;` -- the inference
        /// gateway serving the model returned a 502, 500, 503 or another 5xx error. Its status
        /// code is in the message (the response status is 502), and up to 256 bytes of its error
        /// message are quoted. * `inference gateway: response ended unexpectedly` -- the inference
        /// gateway's connection failed while it was sending the response. The inference gateway
        /// names a component in the prefix when it reports one: `inference gateway (&lt;component&gt;):
        /// `, where the component is `config` (the inference gateway's configuration and proxy
        /// layer), `scheduler` (its request scheduler), `model selector` (its model selector)
        /// or `model server` (the model server). Not modeled as retryable: a 502 can mean the
        /// inference already ran, and the gateway may already have tried another inference gateway.
        /// Standard SDK retry modes may still retry a 5xx status, which would run (and bill)
        /// the inference again; set max attempts to 1 if a repeated inference is unacceptable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.GatewayTimeoutException">
        /// 504 -- The inference gateway did not respond in time. The `Message` prefix says whose
        /// time limit expired: * `Global Inference Gateway: timed out waiting for the inference
        /// gateway` -- the gateway's limit on the wait for the first part of the response. *
        /// `inference gateway: &lt;status&gt; &lt;message&gt;` -- the inference gateway serving
        /// the model returned a 504, or a 408 because it timed out waiting for the request to
        /// arrive. Its status code is in the message (the response status is 504), and up to
        /// 256 bytes of its error message are quoted. The inference gateway names a component
        /// in the prefix when it reports one: `inference gateway (&lt;component&gt;): `, where
        /// the component is `config` (the inference gateway's configuration and proxy layer),
        /// `scheduler` (its request scheduler), `model selector` (its model selector) or `model
        /// server` (the model server). Not modeled as retryable: a timeout does not prove the
        /// inference did not run, and the gateway may already have tried another inference gateway.
        /// Standard SDK retry modes may still retry a 5xx status, which could run (and bill)
        /// the inference again; set max attempts to 1 if a repeated inference is unacceptable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.InternalServerException">
        /// An unexpected internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.PayloadTooLargeException">
        /// The request body exceeds the 10 MiB limit. Reduce the size of the payload and send
        /// the request again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ResourceNotFoundException">
        /// No gateway with this ID exists in this account and Region, or no target of the gateway
        /// serves the model named in the request body. A model that is served but has no available
        /// target right now returns ServiceUnavailableException instead. A message starting `inference
        /// gateway` means the inference gateway serving the model returned a 404; up to 256 bytes
        /// of its error message are quoted.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ServiceUnavailableException">
        /// The service is temporarily unable to serve the request, for example because no capacity
        /// is available for the requested model. The request was not dispatched for inference.
        /// A 503 returned by the inference gateway serving the model after dispatch is reported
        /// as BadGatewayException, with the 503 in its `Message`, not as this error.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ThrottlingException">
        /// The request was throttled before it was dispatched for inference. Retry the request
        /// with backoff, after the `Retry-After` seconds when the response carries one. A message
        /// starting `inference gateway` means the last inference gateway tried for the model
        /// returned a 429. The gateway may have tried others first, and they may have failed
        /// for other reasons. Up to 256 bytes of its error message are quoted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-gateway-runtime-2026-10-01/InvokeGlobalInferenceGateway">REST API Reference for InvokeGlobalInferenceGateway Operation</seealso>
        InvokeGlobalInferenceGatewayResponse InvokeGlobalInferenceGateway(InvokeGlobalInferenceGatewayRequest request);
#endif

        /// <summary>
        /// Buffered (non-streaming) inference. Returns the full OpenAI completion body. Errors
        /// carry their origin in the `Message` prefix. Every typed error's text is in the `Message`
        /// member (JSON key `Message`), and starts with one of these prefixes: * `Global Inference
        /// Gateway: ` -- the gateway rejected or failed the request itself: validation, authorization,
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
        /// <param name="request">Container for the necessary parameters to execute the InvokeGlobalInferenceGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the InvokeGlobalInferenceGateway service method, as returned by SageMakerGatewayRuntime.</returns>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.AccessDeniedException">
        /// The caller is not authorized to invoke this gateway. Invoking requires the `sagemaker:InvokeGlobalInferenceGateway`
        /// permission, or `sagemaker:InvokeGlobalInferenceGatewayWithResponseStream` for the
        /// streaming operation, on the gateway ARN. A message starting `inference gateway` means
        /// the inference gateway serving the model refused the request with a 401 or 403, for
        /// example for its customer identity token. Its status code is in the message (the response
        /// status is 403), and up to 256 bytes of its error message are quoted.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.BadGatewayException">
        /// 502 -- The gateway could not get a usable response from the inference gateway. The
        /// `Message` prefix says why: * `Global Inference Gateway: could not reach the inference
        /// gateway: &lt;reason&gt;` -- the request could not be sent, or the connection closed
        /// before a response arrived (for example, the connection failed, or the inference gateway
        /// closed it after reading the request). * `Global Inference Gateway: timed out waiting
        /// for the inference gateway` -- on the buffered operation, the inference gateway stopped
        /// sending partway through the response body and the gateway's read timeout expired.
        /// (The same text on a GatewayTimeoutException means no response arrived.) * Any other
        /// `Global Inference Gateway: ` message -- the gateway ended a response before it was
        /// complete, for example because it exceeded the 10 MiB limit of the buffered operation,
        /// the request exceeded its maximum duration, or the inference gateway was taken out
        /// of service. * `inference gateway: &lt;status&gt; &lt;message&gt;` -- the inference
        /// gateway serving the model returned a 502, 500, 503 or another 5xx error. Its status
        /// code is in the message (the response status is 502), and up to 256 bytes of its error
        /// message are quoted. * `inference gateway: response ended unexpectedly` -- the inference
        /// gateway's connection failed while it was sending the response. The inference gateway
        /// names a component in the prefix when it reports one: `inference gateway (&lt;component&gt;):
        /// `, where the component is `config` (the inference gateway's configuration and proxy
        /// layer), `scheduler` (its request scheduler), `model selector` (its model selector)
        /// or `model server` (the model server). Not modeled as retryable: a 502 can mean the
        /// inference already ran, and the gateway may already have tried another inference gateway.
        /// Standard SDK retry modes may still retry a 5xx status, which would run (and bill)
        /// the inference again; set max attempts to 1 if a repeated inference is unacceptable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.GatewayTimeoutException">
        /// 504 -- The inference gateway did not respond in time. The `Message` prefix says whose
        /// time limit expired: * `Global Inference Gateway: timed out waiting for the inference
        /// gateway` -- the gateway's limit on the wait for the first part of the response. *
        /// `inference gateway: &lt;status&gt; &lt;message&gt;` -- the inference gateway serving
        /// the model returned a 504, or a 408 because it timed out waiting for the request to
        /// arrive. Its status code is in the message (the response status is 504), and up to
        /// 256 bytes of its error message are quoted. The inference gateway names a component
        /// in the prefix when it reports one: `inference gateway (&lt;component&gt;): `, where
        /// the component is `config` (the inference gateway's configuration and proxy layer),
        /// `scheduler` (its request scheduler), `model selector` (its model selector) or `model
        /// server` (the model server). Not modeled as retryable: a timeout does not prove the
        /// inference did not run, and the gateway may already have tried another inference gateway.
        /// Standard SDK retry modes may still retry a 5xx status, which could run (and bill)
        /// the inference again; set max attempts to 1 if a repeated inference is unacceptable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.InternalServerException">
        /// An unexpected internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.PayloadTooLargeException">
        /// The request body exceeds the 10 MiB limit. Reduce the size of the payload and send
        /// the request again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ResourceNotFoundException">
        /// No gateway with this ID exists in this account and Region, or no target of the gateway
        /// serves the model named in the request body. A model that is served but has no available
        /// target right now returns ServiceUnavailableException instead. A message starting `inference
        /// gateway` means the inference gateway serving the model returned a 404; up to 256 bytes
        /// of its error message are quoted.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ServiceUnavailableException">
        /// The service is temporarily unable to serve the request, for example because no capacity
        /// is available for the requested model. The request was not dispatched for inference.
        /// A 503 returned by the inference gateway serving the model after dispatch is reported
        /// as BadGatewayException, with the 503 in its `Message`, not as this error.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ThrottlingException">
        /// The request was throttled before it was dispatched for inference. Retry the request
        /// with backoff, after the `Retry-After` seconds when the response carries one. A message
        /// starting `inference gateway` means the last inference gateway tried for the model
        /// returned a 429. The gateway may have tried others first, and they may have failed
        /// for other reasons. Up to 256 bytes of its error message are quoted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-gateway-runtime-2026-10-01/InvokeGlobalInferenceGateway">REST API Reference for InvokeGlobalInferenceGateway Operation</seealso>
        Task<InvokeGlobalInferenceGatewayResponse> InvokeGlobalInferenceGatewayAsync(InvokeGlobalInferenceGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Streaming inference. Returns an AWS event stream of PayloadPart events that carry
        /// the model server's server-sent event (SSE) bytes, so SDKs decode the stream into events
        /// for you. The errors listed for this operation, other than ModelStreamError and InternalStreamFailure,
        /// are returned before the response starts (before the 200 status), so they end the request,
        /// not the stream. None of them can occur after the 200. ModelStreamError and InternalStreamFailure
        /// appear only as events in the stream, after the 200. Once the 200 is sent, the stream
        /// carries the response as PayloadPart events. If reading the inference gateway's response
        /// fails, the stream carries one InternalStreamFailure event and then ends. ModelStreamError
        /// is reserved and is not currently sent. Errors carry their origin in the `Message`
        /// prefix. Every typed error's text is in the `Message` member (JSON key `Message`),
        /// and starts with one of these prefixes: * `Global Inference Gateway: ` -- the gateway
        /// rejected or failed the request itself: validation, authorization, throttling, routing
        /// (the gateway or model was not found, or no capacity is available), a gateway limit
        /// or time limit, or failing to reach the inference gateway (`Global Inference Gateway:
        /// could not reach the inference gateway: &lt;reason&gt;`, or `Global Inference Gateway:
        /// timed out waiting for the inference gateway`). This includes the 400 for an invalid
        /// request and the 413 for a request body that is too large. * `inference gateway: `
        /// -- the inference gateway serving the model returned an error status. The message gives
        /// that status code and up to 256 bytes of its error message, for example `inference
        /// gateway: 503 &lt;message&gt;`. * `inference gateway (&lt;component&gt;): ` -- the
        /// same, when the inference gateway reports which of its components produced the error,
        /// for example `inference gateway (model server): 502 &lt;message&gt;`. The component
        /// is one of: * `config` -- the inference gateway's configuration and proxy layer. *
        /// `scheduler` -- the inference gateway's request scheduler. * `model selector` -- the
        /// inference gateway's model selector. * `model server` -- the model server. An InternalStreamFailure
        /// event's `Message` uses the same prefixes, with the same text the buffered operation
        /// uses for the same failure. Its `inference gateway: ` message carries no status: `inference
        /// gateway: response ended unexpectedly` when the inference gateway's connection failed
        /// while it was sending the response. Every error status the inference gateway returns
        /// before the 200 is a typed error, chosen by that status as for InvokeGlobalInferenceGateway:
        /// * 400 and any other 4xx not listed here -- a 400 validation error. * 401 and 403 --
        /// AccessDeniedException (403). * 404 -- ResourceNotFoundException. * 408 -- GatewayTimeoutException
        /// (504). * 429 -- ThrottlingException, with the `Retry-After` header. * 502, and 500,
        /// 503 or any other 5xx not listed here -- BadGatewayException (502). A 500 or 503 from
        /// the inference gateway comes after the request was dispatched, so it is not modeled
        /// as retryable, and the gateway may already have tried another inference gateway. Standard
        /// SDK retry modes may still retry a 5xx status; set max attempts to 1 if a repeated
        /// inference is unacceptable. * 504 -- GatewayTimeoutException.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeGlobalInferenceGatewayWithResponseStream service method.</param>
        /// <returns>The response from the InvokeGlobalInferenceGatewayWithResponseStream service method, as returned by SageMakerGatewayRuntime.</returns>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.AccessDeniedException">
        /// The caller is not authorized to invoke this gateway. Invoking requires the `sagemaker:InvokeGlobalInferenceGateway`
        /// permission, or `sagemaker:InvokeGlobalInferenceGatewayWithResponseStream` for the
        /// streaming operation, on the gateway ARN. A message starting `inference gateway` means
        /// the inference gateway serving the model refused the request with a 401 or 403, for
        /// example for its customer identity token. Its status code is in the message (the response
        /// status is 403), and up to 256 bytes of its error message are quoted.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.BadGatewayException">
        /// 502 -- The gateway could not get a usable response from the inference gateway. The
        /// `Message` prefix says why: * `Global Inference Gateway: could not reach the inference
        /// gateway: &lt;reason&gt;` -- the request could not be sent, or the connection closed
        /// before a response arrived (for example, the connection failed, or the inference gateway
        /// closed it after reading the request). * `Global Inference Gateway: timed out waiting
        /// for the inference gateway` -- on the buffered operation, the inference gateway stopped
        /// sending partway through the response body and the gateway's read timeout expired.
        /// (The same text on a GatewayTimeoutException means no response arrived.) * Any other
        /// `Global Inference Gateway: ` message -- the gateway ended a response before it was
        /// complete, for example because it exceeded the 10 MiB limit of the buffered operation,
        /// the request exceeded its maximum duration, or the inference gateway was taken out
        /// of service. * `inference gateway: &lt;status&gt; &lt;message&gt;` -- the inference
        /// gateway serving the model returned a 502, 500, 503 or another 5xx error. Its status
        /// code is in the message (the response status is 502), and up to 256 bytes of its error
        /// message are quoted. * `inference gateway: response ended unexpectedly` -- the inference
        /// gateway's connection failed while it was sending the response. The inference gateway
        /// names a component in the prefix when it reports one: `inference gateway (&lt;component&gt;):
        /// `, where the component is `config` (the inference gateway's configuration and proxy
        /// layer), `scheduler` (its request scheduler), `model selector` (its model selector)
        /// or `model server` (the model server). Not modeled as retryable: a 502 can mean the
        /// inference already ran, and the gateway may already have tried another inference gateway.
        /// Standard SDK retry modes may still retry a 5xx status, which would run (and bill)
        /// the inference again; set max attempts to 1 if a repeated inference is unacceptable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.GatewayTimeoutException">
        /// 504 -- The inference gateway did not respond in time. The `Message` prefix says whose
        /// time limit expired: * `Global Inference Gateway: timed out waiting for the inference
        /// gateway` -- the gateway's limit on the wait for the first part of the response. *
        /// `inference gateway: &lt;status&gt; &lt;message&gt;` -- the inference gateway serving
        /// the model returned a 504, or a 408 because it timed out waiting for the request to
        /// arrive. Its status code is in the message (the response status is 504), and up to
        /// 256 bytes of its error message are quoted. The inference gateway names a component
        /// in the prefix when it reports one: `inference gateway (&lt;component&gt;): `, where
        /// the component is `config` (the inference gateway's configuration and proxy layer),
        /// `scheduler` (its request scheduler), `model selector` (its model selector) or `model
        /// server` (the model server). Not modeled as retryable: a timeout does not prove the
        /// inference did not run, and the gateway may already have tried another inference gateway.
        /// Standard SDK retry modes may still retry a 5xx status, which could run (and bill)
        /// the inference again; set max attempts to 1 if a repeated inference is unacceptable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.InternalServerException">
        /// An unexpected internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.InternalStreamFailureException">
        /// A failure after the stream started. The `Message` says where it came from: `Global
        /// Inference Gateway: ` when a gateway time limit expired or the inference gateway was
        /// taken out of service, or `inference gateway: response ended unexpectedly` when the
        /// inference gateway's connection failed while it was sending the response. The stream
        /// ends after this event.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ModelStreamErrorException">
        /// Reserved for a model error during the stream. Not currently sent; a failure after
        /// the stream starts is reported as InternalStreamFailure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.PayloadTooLargeException">
        /// The request body exceeds the 10 MiB limit. Reduce the size of the payload and send
        /// the request again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ResourceNotFoundException">
        /// No gateway with this ID exists in this account and Region, or no target of the gateway
        /// serves the model named in the request body. A model that is served but has no available
        /// target right now returns ServiceUnavailableException instead. A message starting `inference
        /// gateway` means the inference gateway serving the model returned a 404; up to 256 bytes
        /// of its error message are quoted.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ServiceUnavailableException">
        /// The service is temporarily unable to serve the request, for example because no capacity
        /// is available for the requested model. The request was not dispatched for inference.
        /// A 503 returned by the inference gateway serving the model after dispatch is reported
        /// as BadGatewayException, with the 503 in its `Message`, not as this error.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ThrottlingException">
        /// The request was throttled before it was dispatched for inference. Retry the request
        /// with backoff, after the `Retry-After` seconds when the response carries one. A message
        /// starting `inference gateway` means the last inference gateway tried for the model
        /// returned a 429. The gateway may have tried others first, and they may have failed
        /// for other reasons. Up to 256 bytes of its error message are quoted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-gateway-runtime-2026-10-01/InvokeGlobalInferenceGatewayWithResponseStream">REST API Reference for InvokeGlobalInferenceGatewayWithResponseStream Operation</seealso>
        InvokeGlobalInferenceGatewayWithResponseStreamResponse InvokeGlobalInferenceGatewayWithResponseStream(InvokeGlobalInferenceGatewayWithResponseStreamRequest request);
#endif

        /// <summary>
        /// Streaming inference. Returns an AWS event stream of PayloadPart events that carry
        /// the model server's server-sent event (SSE) bytes, so SDKs decode the stream into events
        /// for you. The errors listed for this operation, other than ModelStreamError and InternalStreamFailure,
        /// are returned before the response starts (before the 200 status), so they end the request,
        /// not the stream. None of them can occur after the 200. ModelStreamError and InternalStreamFailure
        /// appear only as events in the stream, after the 200. Once the 200 is sent, the stream
        /// carries the response as PayloadPart events. If reading the inference gateway's response
        /// fails, the stream carries one InternalStreamFailure event and then ends. ModelStreamError
        /// is reserved and is not currently sent. Errors carry their origin in the `Message`
        /// prefix. Every typed error's text is in the `Message` member (JSON key `Message`),
        /// and starts with one of these prefixes: * `Global Inference Gateway: ` -- the gateway
        /// rejected or failed the request itself: validation, authorization, throttling, routing
        /// (the gateway or model was not found, or no capacity is available), a gateway limit
        /// or time limit, or failing to reach the inference gateway (`Global Inference Gateway:
        /// could not reach the inference gateway: &lt;reason&gt;`, or `Global Inference Gateway:
        /// timed out waiting for the inference gateway`). This includes the 400 for an invalid
        /// request and the 413 for a request body that is too large. * `inference gateway: `
        /// -- the inference gateway serving the model returned an error status. The message gives
        /// that status code and up to 256 bytes of its error message, for example `inference
        /// gateway: 503 &lt;message&gt;`. * `inference gateway (&lt;component&gt;): ` -- the
        /// same, when the inference gateway reports which of its components produced the error,
        /// for example `inference gateway (model server): 502 &lt;message&gt;`. The component
        /// is one of: * `config` -- the inference gateway's configuration and proxy layer. *
        /// `scheduler` -- the inference gateway's request scheduler. * `model selector` -- the
        /// inference gateway's model selector. * `model server` -- the model server. An InternalStreamFailure
        /// event's `Message` uses the same prefixes, with the same text the buffered operation
        /// uses for the same failure. Its `inference gateway: ` message carries no status: `inference
        /// gateway: response ended unexpectedly` when the inference gateway's connection failed
        /// while it was sending the response. Every error status the inference gateway returns
        /// before the 200 is a typed error, chosen by that status as for InvokeGlobalInferenceGateway:
        /// * 400 and any other 4xx not listed here -- a 400 validation error. * 401 and 403 --
        /// AccessDeniedException (403). * 404 -- ResourceNotFoundException. * 408 -- GatewayTimeoutException
        /// (504). * 429 -- ThrottlingException, with the `Retry-After` header. * 502, and 500,
        /// 503 or any other 5xx not listed here -- BadGatewayException (502). A 500 or 503 from
        /// the inference gateway comes after the request was dispatched, so it is not modeled
        /// as retryable, and the gateway may already have tried another inference gateway. Standard
        /// SDK retry modes may still retry a 5xx status; set max attempts to 1 if a repeated
        /// inference is unacceptable. * 504 -- GatewayTimeoutException.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeGlobalInferenceGatewayWithResponseStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the InvokeGlobalInferenceGatewayWithResponseStream service method, as returned by SageMakerGatewayRuntime.</returns>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.AccessDeniedException">
        /// The caller is not authorized to invoke this gateway. Invoking requires the `sagemaker:InvokeGlobalInferenceGateway`
        /// permission, or `sagemaker:InvokeGlobalInferenceGatewayWithResponseStream` for the
        /// streaming operation, on the gateway ARN. A message starting `inference gateway` means
        /// the inference gateway serving the model refused the request with a 401 or 403, for
        /// example for its customer identity token. Its status code is in the message (the response
        /// status is 403), and up to 256 bytes of its error message are quoted.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.BadGatewayException">
        /// 502 -- The gateway could not get a usable response from the inference gateway. The
        /// `Message` prefix says why: * `Global Inference Gateway: could not reach the inference
        /// gateway: &lt;reason&gt;` -- the request could not be sent, or the connection closed
        /// before a response arrived (for example, the connection failed, or the inference gateway
        /// closed it after reading the request). * `Global Inference Gateway: timed out waiting
        /// for the inference gateway` -- on the buffered operation, the inference gateway stopped
        /// sending partway through the response body and the gateway's read timeout expired.
        /// (The same text on a GatewayTimeoutException means no response arrived.) * Any other
        /// `Global Inference Gateway: ` message -- the gateway ended a response before it was
        /// complete, for example because it exceeded the 10 MiB limit of the buffered operation,
        /// the request exceeded its maximum duration, or the inference gateway was taken out
        /// of service. * `inference gateway: &lt;status&gt; &lt;message&gt;` -- the inference
        /// gateway serving the model returned a 502, 500, 503 or another 5xx error. Its status
        /// code is in the message (the response status is 502), and up to 256 bytes of its error
        /// message are quoted. * `inference gateway: response ended unexpectedly` -- the inference
        /// gateway's connection failed while it was sending the response. The inference gateway
        /// names a component in the prefix when it reports one: `inference gateway (&lt;component&gt;):
        /// `, where the component is `config` (the inference gateway's configuration and proxy
        /// layer), `scheduler` (its request scheduler), `model selector` (its model selector)
        /// or `model server` (the model server). Not modeled as retryable: a 502 can mean the
        /// inference already ran, and the gateway may already have tried another inference gateway.
        /// Standard SDK retry modes may still retry a 5xx status, which would run (and bill)
        /// the inference again; set max attempts to 1 if a repeated inference is unacceptable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.GatewayTimeoutException">
        /// 504 -- The inference gateway did not respond in time. The `Message` prefix says whose
        /// time limit expired: * `Global Inference Gateway: timed out waiting for the inference
        /// gateway` -- the gateway's limit on the wait for the first part of the response. *
        /// `inference gateway: &lt;status&gt; &lt;message&gt;` -- the inference gateway serving
        /// the model returned a 504, or a 408 because it timed out waiting for the request to
        /// arrive. Its status code is in the message (the response status is 504), and up to
        /// 256 bytes of its error message are quoted. The inference gateway names a component
        /// in the prefix when it reports one: `inference gateway (&lt;component&gt;): `, where
        /// the component is `config` (the inference gateway's configuration and proxy layer),
        /// `scheduler` (its request scheduler), `model selector` (its model selector) or `model
        /// server` (the model server). Not modeled as retryable: a timeout does not prove the
        /// inference did not run, and the gateway may already have tried another inference gateway.
        /// Standard SDK retry modes may still retry a 5xx status, which could run (and bill)
        /// the inference again; set max attempts to 1 if a repeated inference is unacceptable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.InternalServerException">
        /// An unexpected internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.InternalStreamFailureException">
        /// A failure after the stream started. The `Message` says where it came from: `Global
        /// Inference Gateway: ` when a gateway time limit expired or the inference gateway was
        /// taken out of service, or `inference gateway: response ended unexpectedly` when the
        /// inference gateway's connection failed while it was sending the response. The stream
        /// ends after this event.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ModelStreamErrorException">
        /// Reserved for a model error during the stream. Not currently sent; a failure after
        /// the stream starts is reported as InternalStreamFailure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.PayloadTooLargeException">
        /// The request body exceeds the 10 MiB limit. Reduce the size of the payload and send
        /// the request again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ResourceNotFoundException">
        /// No gateway with this ID exists in this account and Region, or no target of the gateway
        /// serves the model named in the request body. A model that is served but has no available
        /// target right now returns ServiceUnavailableException instead. A message starting `inference
        /// gateway` means the inference gateway serving the model returned a 404; up to 256 bytes
        /// of its error message are quoted.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ServiceUnavailableException">
        /// The service is temporarily unable to serve the request, for example because no capacity
        /// is available for the requested model. The request was not dispatched for inference.
        /// A 503 returned by the inference gateway serving the model after dispatch is reported
        /// as BadGatewayException, with the 503 in its `Message`, not as this error.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGatewayRuntime.Model.ThrottlingException">
        /// The request was throttled before it was dispatched for inference. Retry the request
        /// with backoff, after the `Retry-After` seconds when the response carries one. A message
        /// starting `inference gateway` means the last inference gateway tried for the model
        /// returned a 429. The gateway may have tried others first, and they may have failed
        /// for other reasons. Up to 256 bytes of its error message are quoted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-gateway-runtime-2026-10-01/InvokeGlobalInferenceGatewayWithResponseStream">REST API Reference for InvokeGlobalInferenceGatewayWithResponseStream Operation</seealso>
        Task<InvokeGlobalInferenceGatewayWithResponseStreamResponse> InvokeGlobalInferenceGatewayWithResponseStreamAsync(InvokeGlobalInferenceGatewayWithResponseStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSageMakerGatewayRuntimeConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSageMakerGatewayRuntimeConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSageMakerGatewayRuntimeConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSageMakerGatewayRuntimeConfig to create AmazonSageMakerGatewayRuntimeClient");
            }

            return awsCredentials == null ?
                    new AmazonSageMakerGatewayRuntimeClient(serviceClientConfig) :
                    new AmazonSageMakerGatewayRuntimeClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
