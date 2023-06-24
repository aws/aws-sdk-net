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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the Invoke operation.
    /// Invokes a Lambda function. You can invoke a function synchronously (and wait for the
    /// response), or asynchronously. To invoke a function asynchronously, set <code>InvocationType</code>
    /// to <code>Event</code>.
    /// 
    ///  
    /// <para>
    /// For <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-sync.html">synchronous
    /// invocation</a>, details about the function response, including errors, are included
    /// in the response body and headers. For either invocation type, you can find more information
    /// in the <a href="https://docs.aws.amazon.com/lambda/latest/dg/monitoring-functions.html">execution
    /// log</a> and <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-x-ray.html">trace</a>.
    /// </para>
    ///  
    /// <para>
    /// When an error occurs, your function may be invoked multiple times. Retry behavior
    /// varies by error type, client, event source, and invocation type. For example, if you
    /// invoke a function asynchronously and it returns an error, Lambda executes the function
    /// up to two more times. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-retries.html">Error
    /// handling and automatic retries in Lambda</a>.
    /// </para>
    ///  
    /// <para>
    /// For <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html">asynchronous
    /// invocation</a>, Lambda adds events to a queue before sending them to your function.
    /// If your function does not have enough capacity to keep up with the queue, events may
    /// be lost. Occasionally, your function may receive the same event multiple times, even
    /// if no error occurs. To retain events that were not processed, configure your function
    /// with a <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-dlq">dead-letter
    /// queue</a>.
    /// </para>
    ///  
    /// <para>
    /// The status code in the API response doesn't reflect function errors. Error codes are
    /// reserved for errors that prevent your function from executing, such as permissions
    /// errors, <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">quota</a>
    /// errors, or issues with your function's code and configuration. For example, Lambda
    /// returns <code>TooManyRequestsException</code> if running the function would cause
    /// you to exceed a concurrency limit at either the account level (<code>ConcurrentInvocationLimitExceeded</code>)
    /// or function level (<code>ReservedFunctionConcurrentInvocationLimitExceeded</code>).
    /// </para>
    ///  
    /// <para>
    /// For functions with a long timeout, your client might disconnect during synchronous
    /// invocation while it waits for a response. Configure your HTTP client, SDK, firewall,
    /// proxy, or operating system to allow for long connections with timeout or keep-alive
    /// settings.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/list_awslambda.html">lambda:InvokeFunction</a>
    /// action. For details on how to set up permissions for cross-account invocations, see
    /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html#permissions-resource-xaccountinvoke">Granting
    /// function access to other accounts</a>.
    /// </para>
    /// </summary>
    public partial class InvokeRequest : AmazonLambdaRequest
    {
        private string _clientContextBase64;
        private string _functionName;
        private InvocationType _invocationType;
        private LogType _logType;
        private MemoryStream _payloadStream;
        private string _qualifier;

        /// <summary>
        /// Gets and sets the property ClientContextBase64. 
        /// <para>
        /// Up to 3,583 bytes of base64-encoded data about the invoking client to pass to the
        /// function in the context object.
        /// </para>
        /// </summary>
        public string ClientContextBase64
        {
            get { return this._clientContextBase64; }
            set { this._clientContextBase64 = value; }
        }

        // Check to see if ClientContextBase64 property is set
        internal bool IsSetClientContextBase64()
        {
            return this._clientContextBase64 != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the Lambda function, version, or alias.
        /// </para>
        ///  <p class="title"> <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> – <code>my-function</code> (name-only), <code>my-function:v1</code>
        /// (with alias).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can append a version number or alias to any of the formats. The length constraint
        /// applies only to the full ARN. If you specify only the function name, it is limited
        /// to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=170)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationType. 
        /// <para>
        /// Choose from the following options.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RequestResponse</code> (default) – Invoke the function synchronously. Keep
        /// the connection open until the function returns a response or times out. The API response
        /// includes the function response and additional data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Event</code> – Invoke the function asynchronously. Send events that fail multiple
        /// times to the function's dead-letter queue (if one is configured). The API response
        /// only includes a status code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DryRun</code> – Validate parameter values and verify that the user or role
        /// has permission to invoke the function.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InvocationType InvocationType
        {
            get { return this._invocationType; }
            set { this._invocationType = value; }
        }

        // Check to see if InvocationType property is set
        internal bool IsSetInvocationType()
        {
            return this._invocationType != null;
        }

        /// <summary>
        /// Gets and sets the property LogType. 
        /// <para>
        /// Set to <code>Tail</code> to include the execution log in the response. Applies to
        /// synchronously invoked functions only.
        /// </para>
        /// </summary>
        public LogType LogType
        {
            get { return this._logType; }
            set { this._logType = value; }
        }

        // Check to see if LogType property is set
        internal bool IsSetLogType()
        {
            return this._logType != null;
        }

        /// <summary>
        /// Gets and sets the property PayloadStream. 
        /// <para>
        /// The JSON that you want to provide to your Lambda function as input.
        /// </para>
        ///  
        /// <para>
        /// You can enter the JSON directly. For example, <code>--payload '{ "key": "value" }'</code>.
        /// You can also specify a file path. For example, <code>--payload file://payload.json</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public MemoryStream PayloadStream
        {
            get { return this._payloadStream; }
            set { this._payloadStream = value; }
        }

        // Check to see if PayloadStream property is set
        internal bool IsSetPayloadStream()
        {
            return this._payloadStream != null;
        }

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// Specify a version or alias to invoke a published version of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Qualifier
        {
            get { return this._qualifier; }
            set { this._qualifier = value; }
        }

        // Check to see if Qualifier property is set
        internal bool IsSetQualifier()
        {
            return this._qualifier != null;
        }

    }
}