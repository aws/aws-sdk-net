/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the Invoke operation.
    /// Invokes a Lambda function. For an example, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/with-dynamodb-create-function.html#with-dbb-invoke-manually">Create
    /// the Lambda Function and Test It Manually</a>. 
    /// 
    ///  
    /// <para>
    /// Specify just a function name to invoke the latest version of the function. To invoke
    /// a published version, use the <code>Qualifier</code> parameter to specify a <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">version
    /// or alias</a>.
    /// </para>
    ///  
    /// <para>
    /// If you use the <code>RequestResponse</code> (synchronous) invocation option, the function
    /// will be invoked only once. If you use the <code>Event</code> (asynchronous) invocation
    /// option, the function will be invoked at least once in response to an event and the
    /// function must be idempotent to handle this.
    /// </para>
    ///  
    /// <para>
    /// For functions with a long timeout, your client may be disconnected during synchronous
    /// invocation while it waits for a response. Configure your HTTP client, SDK, firewall,
    /// proxy, or operating system to allow for long connections with timeout or keep-alive
    /// settings.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <code>lambda:InvokeFunction</code> action.
    /// </para>
    ///  
    /// <para>
    /// The <code>TooManyRequestsException</code> noted below will return the following: <code>ConcurrentInvocationLimitExceeded</code>
    /// will be returned if you have no functions with reserved concurrency and have exceeded
    /// your account concurrent limit or if a function without reserved concurrency exceeds
    /// the account's unreserved concurrency limit. <code>ReservedFunctionConcurrentInvocationLimitExceeded</code>
    /// will be returned when a function with reserved concurrency exceeds its configured
    /// concurrency limit. 
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
        /// Using the <code>ClientContext</code> you can pass client-specific information to the
        /// Lambda function you are invoking. You can then process the client information in your
        /// Lambda function as you choose through the context variable. For an example of a <code>ClientContext</code>
        /// JSON, see <a href="http://docs.aws.amazon.com/mobileanalytics/latest/ug/PutEvents.html">PutEvents</a>
        /// in the <i>Amazon Mobile Analytics API Reference and User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The ClientContext JSON must be base64-encoded and has a maximum size of 3583 bytes.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>ClientContext</code> information is returned only if you use the synchronous
        /// (<code>RequestResponse</code>) invocation type.
        /// </para>
        ///  </note>
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
        /// The name of the lambda function.
        /// </para>
        ///  <p class="title"> <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> - <code>MyFunction</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:MyFunction</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> - <code>123456789012:function:MyFunction</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
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
        ///  <code>RequestResponse</code> (default) - Invoke the function synchronously. Keep
        /// the connection open until the function returns a response or times out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Event</code> - Invoke the function asynchronously. Send events that fail multiple
        /// times to the function's dead-letter queue (if configured).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DryRun</code> - Validate parameter values and verify that the user or role
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
        /// You can set this optional parameter to <code>Tail</code> in the request only if you
        /// specify the <code>InvocationType</code> parameter with value <code>RequestResponse</code>.
        /// In this case, AWS Lambda returns the base64-encoded last 4 KB of log data produced
        /// by your Lambda function in the <code>x-amz-log-result</code> header. 
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
        /// JSON that you want to provide to your Lambda function as input.
        /// </para>
        /// </summary>
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